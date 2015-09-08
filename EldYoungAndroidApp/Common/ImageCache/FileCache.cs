
using Android.Content;
using Java.IO;
using Java.Lang;
using Android.Util;

namespace EldYoungAndroidApp.Common.ImageCache
{
	public class FileCache
	{
		private File cacheDir;
		public FileCache (Context context)
		{
			// 如果有SD卡则在SD卡中建一个LazyList的目录存放缓存的图片,没有SD卡就放在系统的缓存目录中
			if (Android.OS.Environment.ExternalStorageState == Android.OS.Environment.MediaMounted)
				cacheDir = new File (Android.OS.Environment.GetExternalStoragePublicDirectory (Android.OS.Environment.MediaMounted), "LazyList");
			else
				cacheDir = context.CacheDir;
			if(!cacheDir.Exists())
				cacheDir.Mkdirs();
			

		}

		public File GetFile(string url)
		{
			//将url的hashCode作为缓存的文件名
			//I identify images by hashcode. Not a perfect solution, good for the demo.
			//var fileName = String.ValueOf(url.GetHashCode());
//			Log.Info ("fileName",fileName);
			var fileName = url.Substring (url.LastIndexOf ('/') + 1);
			Log.Info ("fileName",fileName);
			return new File (cacheDir, fileName);

		}

		public void Clear()
		{
			File[] files = cacheDir.ListFiles();
			if (files == null)
				return;
			foreach (File f in files) {
				f.Delete ();
			}
		}
	}
}

