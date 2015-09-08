//using System.Collections.Generic;
using Java.Util;

using Java.Lang;
using Android.Graphics;
using Android.Util;
using System.Collections;
using System.Collections.Generic;


namespace EldYoungAndroidApp.Common.ImageCache
{
	public class MemoryCache
	{
		private static readonly string TAG = "MemoryCache";

        /* 放入缓存时是个同步操作
		    LinkedHashMap构造方法的最后一个参数true代表这个map里的元素将按照最近使用次数由少到多排列，即LRU
		    这样的好处是如果要将缓存中的元素替换，则先遍历出最近最少使用的元素来替换以提高效率
        */
		//private IMap cache=Java.Util.Collections.SynchronizedMap(new LinkedHashMap(10,1.5f,true));//Last argument true for LRU ordering
		private IMap cache = new LinkedHashMap(10,1.5f,true);

		//缓存中图片所占用的字节，初始0，将通过此变量严格控制缓存所占用的堆内存
		private long size=0;//current allocated size
		//缓存只能占用的最大堆内存
		private long limit =1000000;//max memory in bytes

		public MemoryCache ()
		{
			
			SetLimit (Runtime.GetRuntime().MaxMemory()/4);
		}

		public void SetLimit(long new_limit){
			limit=new_limit;
			Log.Info(TAG, "MemoryCache will use up to "+limit/1024/1024+"MB");
		}

		/// <summary>
		/// 取图像
		/// </summary>
		/// <returns>The bitmap.</returns>
		/// <param name="id">Identifier.</param>
		public Bitmap GetBitmap(string id)
		{
			try{
				if (!cache.ContainsKey (id))
					return null;
				return (Bitmap)cache.Get (id);
			}
			catch(NullPointerException ex)
			{
				ex.PrintStackTrace();
				return null;
			}
		}


		/// <summary>
		/// 放入图像
		/// </summary>
		/// <param name="id">Identifier.</param>
		/// <param name="bitmap">Bitmap.</param>
		public void PutBitmap(string id,Bitmap bitmap)
		{
			try{
				if(cache.ContainsKey(id))
				{
					size -= GetSizeInBytes((Bitmap)cache.Get(id));
					cache.Remove(id);
				}
				cache.Put(id,bitmap);
				size += GetSizeInBytes(bitmap);
				CheckSize();
			}
			catch(Throwable th) {
				th.PrintStackTrace ();
			}
		}


		/// <summary>
		/// 图片占用的内存
		/// </summary>
		/// <returns>The size in bytes.</returns>
		/// <param name="bitmap">Bitmap.</param>
		private	long GetSizeInBytes(Bitmap bitmap) {
			if(bitmap==null)
				return 0;
			return bitmap.RowBytes * bitmap.Height;
		}
		/// <summary>
		/// 严格控制堆内存，如果超过将首先替换最近最少使用的那个图片缓存
		/// </summary>
//		private void CheckSize() {
//			Log.Info(TAG, "cache size="+size+" length="+cache.Size());
//			if(size>limit){
//		
//        	    // 先遍历最近最少使用的元素
//				//least recently accessed item will be the first one iterated  
//				Iterator<Entry<String, Bitmap>> iter=cache.entrySet().iterator();
//				while(iter.hasNext()){
//					Entry<String, Bitmap> entry=iter.next();
//					size-=getSizeInBytes(entry.getValue());
//					iter.remove();
//					if(size<=limit)
//						break;
//				}
//				Log.i(TAG, "Clean cache. New size "+cache.size());
//			}
//		}

		/// <summary>
		/// 严格控制堆内存，如果超过将首先替换最近最少使用的那个图片缓存
		/// </summary>
		private void CheckSize()
		{
			Log.Info(TAG, "cache size="+size+" length="+cache.Size());

			if (size > limit) {
				var enumerator = cache.KeySet ().GetEnumerator ();
				while (enumerator.MoveNext ()) {
					var key = enumerator.Current.ToString ();
					Log.Info ("MemoryCache.CheckSize",key);
					size -= GetSizeInBytes ((Bitmap)cache.Get(key));
					cache.Remove (key);
					if (size <= limit)
						break;
				}
			}
		}

		/// <summary>
		/// 清楚缓存
		/// </summary>
		public void Clear() {
			try{
				//NullPointerException sometimes happen here http://code.google.com/p/osmdroid/issues/detail?id=78 
				cache.Clear();
				size=0;
			}catch(NullPointerException ex){
				ex.PrintStackTrace();
			}
		}

	}
}

