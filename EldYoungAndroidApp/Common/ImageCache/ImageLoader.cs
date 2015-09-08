using System;
using Java.Util.Concurrent;
using Android.OS;
using Android.Widget;
using Java.Util;
using Android.Content;
using Android.Graphics;
using Java.IO;
using Java.Lang;
using Java.Net;
using System.IO;
using Android.Util;

namespace EldYoungAndroidApp.Common.ImageCache
{
	/// <summary>
	/// 图像加载类,imagViews是否存在bug？？？
	/// </summary>
	public class ImageLoader
	{
		// 当进入listview时默认的图片，可换成你自己的默认图片
		public const int stub_id=Resource.Drawable.head;
		public MemoryCache memoryCache=new MemoryCache();
		FileCache fileCache;
		//private Map<ImageView, String> imageViews=Collections.synchronizedMap(new WeakHashMap<ImageView, String>());
		private IMap imageViews = new WeakHashMap();
		IExecutorService executorService;
		public  Handler handler=new Handler();//handler to display images in UI thread
		private volatile static ImageLoader _instance = null;
		private static readonly object lockHelper = new object();
		private ImageLoader (Context context)
		{
			fileCache = new FileCache (context);
			executorService = Executors.NewFixedThreadPool (5);

		}
		public static ImageLoader CreateImageLoaderInstance(Context context)
		{
			if (_instance == null) {
				lock (lockHelper) {
					if (_instance == null)
						_instance = new ImageLoader (context);
				}
			}
			return _instance;
		}

		public void DisplayImage(string url, ImageView imageView)
		{
			imageViews.Put(imageView, url);
			// 先从内存缓存中查找
			Bitmap bitmap=memoryCache.GetBitmap(url);
			if(bitmap!=null)
				imageView.SetImageBitmap(bitmap);
			else
			{
				// 若没有的话则开启新线程加载图片
				QueuePhoto(url, imageView);
				imageView.SetImageResource(stub_id);
			}
		}

		private void QueuePhoto(string url, ImageView imageView)
		{
			PhotoToLoad p=new PhotoToLoad(url, imageView);
			executorService.Submit(new PhotosLoader(p,this));
		}

		public Bitmap GetBitmap(string url) 
		{
			Java.IO.File file=fileCache.GetFile(url);
			//先从文件缓存中查找是否有
			//from SD cache
			Bitmap b = DecodeFile(file);
			if(b!=null)
				return b;
			/**
         *  最后从指定的url中下载图片
         */
			//from web
			try {
				Bitmap bitmap=null;
				URL imageUrl = new URL(url);
				HttpURLConnection conn = (HttpURLConnection)imageUrl.OpenConnection();
				conn.Connect();
				conn.ConnectTimeout=30000;
				conn.ReadTimeout=30000;
				conn.InstanceFollowRedirects=true;
				var inStream=conn.InputStream;
				var outputStream = new FileOutputStream(file);
				CopyStream(inStream, outputStream);
				outputStream.Close();
				conn.Disconnect();
				bitmap = DecodeFile(file);

				return bitmap;

			} catch (Throwable ex){
				
				ex.PrintStackTrace();
				if(ex is OutOfMemoryError)
					memoryCache.Clear();
				return null;
			}

		}

		public  void CopyStream(Stream inputStream, FileOutputStream outputStream)
		{
			int buffer_size=1024;
			try 
			{
				byte[] bytes=new byte[buffer_size];
				do{
					int numread=inputStream.Read(bytes, 0, buffer_size);
					if(numread<=0)
						break;
					outputStream.Write(bytes, 0, numread);
				}
				while(true);
			}
			catch(System.Exception ex){
				Log.Info ("ImageLoader.CopyStream",ex.Message);
			}
		}
		/// <summary>
		/// decode这个图片并且按比例缩放以减少内存消耗，虚拟机对每张图片的缓存大小也是有限制的
		/// </summary>
		/// <returns>The file.</returns>
		/// <param name="f">F.</param>
		private Bitmap DecodeFile(Java.IO.File f){
			try {
				//decode image size
				BitmapFactory.Options o = new BitmapFactory.Options();
				o.InJustDecodeBounds = true;
				//FileInputStream stream1=new FileInputStream(f);

				FileStream stream1 = new FileStream(f.ToString(),FileMode.OpenOrCreate);

				BitmapFactory.DecodeStream(stream1,null,o);



				stream1.Close();

				//Find the correct scale value. It should be the power of 2.
				int REQUIRED_SIZE=60;
				int width_tmp=o.OutWidth, height_tmp=o.OutHeight;
				int scale=1;
				while(true){
					if(width_tmp/2<REQUIRED_SIZE || height_tmp/2<REQUIRED_SIZE)
						break;
					width_tmp/=2;
					height_tmp/=2;
					scale*=2;
				}

				//decode with inSampleSize
				BitmapFactory.Options o2 = new BitmapFactory.Options();
				o2.InSampleSize=scale;
				//FileInputStream stream2=new FileInputStream(f);
				FileStream stream2 = new FileStream(f.ToString(),FileMode.OpenOrCreate);
				Bitmap bitmap=BitmapFactory.DecodeStream(stream2, null, o2);
				stream2.Close();
				return bitmap;
			} catch (Java.IO.FileNotFoundException e) {
				e.PrintStackTrace ();
			} 
			catch (Java.IO.IOException e) {
				e.PrintStackTrace();
			}
			return null;
		}


		/// <summary>
		/// 防止图片错位
		/// </summary>
		/// <returns><c>true</c>, if view reused was imaged, <c>false</c> otherwise.</returns>
		/// <param name="photoToLoad">Photo to load.</param>
		public	bool imageViewReused(PhotoToLoad photoToLoad){
			var tag=(string)imageViews.Get(photoToLoad.imageView);
			if(tag==null ||!tag.Equals(photoToLoad.url))
				return true;
			return false;
		}



		public void ClearCache() {
			memoryCache.Clear();
			fileCache.Clear();
		}

	}

	public	class BitmapDisplayer:Java.Lang.Object, IRunnable
	{
		Bitmap bitmap;
		PhotoToLoad photoToLoad;
		private ImageLoader imageLoader;
		public BitmapDisplayer(Bitmap b, PhotoToLoad p,ImageLoader _imageLoader){
			bitmap=b;
			photoToLoad=p;
			imageLoader = _imageLoader;
		}
		public void Run()
		{
			if(imageLoader.imageViewReused(photoToLoad))
				return;
			if(bitmap!=null)
				photoToLoad.imageView.SetImageBitmap(bitmap);
			else
				photoToLoad.imageView.SetImageResource(ImageLoader.stub_id);
		}
	}

	//Task for the queue
	public class PhotoToLoad
	{
		public string url;
		public ImageView imageView;
		public PhotoToLoad(string u, ImageView i){
			url=u; 
			imageView=i;
		}
	}

	public class PhotosLoader: Java.Lang.Object, IRunnable {
		PhotoToLoad photoToLoad;
		private ImageLoader imageLoader;
		public	PhotosLoader(PhotoToLoad photoToLoad,ImageLoader _imageLoader){
			this.photoToLoad=photoToLoad;
			imageLoader = _imageLoader;
		}


		public void Run () {
			try{
				if(imageLoader.imageViewReused(photoToLoad))
					return;
				Bitmap bmp=imageLoader.GetBitmap(photoToLoad.url);
				imageLoader.memoryCache.PutBitmap(photoToLoad.url, bmp);
				if(imageLoader.imageViewReused(photoToLoad))
					return;
				BitmapDisplayer bd=new BitmapDisplayer(bmp, photoToLoad,imageLoader);
				imageLoader.handler.Post(bd);
			}catch(Throwable th){
				th.PrintStackTrace();
			}
		}
	}

}

