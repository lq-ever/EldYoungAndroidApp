using System;
using System.Threading;

using Android.Content;
using Android.Widget;
using Android.App;
using Android.OS;
using Android.Views;
using Android.Net;
using Java.Net;
using Java.IO;
using System.Threading.Tasks;
using System.IO;




namespace EldYoungAndroidApp.Common
{
	public class UpdateManager
	{
		private Context context;
		private const int DownLoading =1;
		private const int DownLoadFinish =2;

		//分隔符
		private static  String FILE_SEPARATOR = "/";  
		// 下载安装包存放路径  
		private static readonly String FILE_PATH =  Android.OS.Environment.GetExternalStoragePublicDirectory(Android.OS.Environment.DirectoryDownloads).Path+FILE_SEPARATOR+"autoupdate"+FILE_SEPARATOR;
		//private static readonly String FILE_PATH =  "/sdcard/eldYoung/"+"autoupdate"+FILE_SEPARATOR; //使用统一eldyoung+功能
		// 文件存放全路径
		private string saveFileName = FILE_PATH +Global.package_name+".apk";
		private int progress;//记录下载进度

		private bool cancelUpdate =false;

		private ProgressBar mProgressbar;//更新进度条

	

		private Dialog dowloadDialog;
		private Dialog noticeDialog;

		public UpdateManager (Context _context )
		{
			context = _context;
		}
		/// <summary>
		/// 检测软件更新
		/// </summary>
		public bool CheckUpdate()
		{
//			if (IsUpdate ()) {
//				//显示提示对话框
//				ShowNoticeDialog();
//			}

			//update by liuqiang 2015/07/08 for 暂停使用更新
			//return IsUpdate(); 
			return false;
		}

		/// <summary>
		/// 检测是否需要更新
		/// </summary>
		/// <returns><c>true</c> if this instance is update; otherwise, <c>false</c>.</returns>
		private bool IsUpdate()
		{
			// 获取软件版本号，对应AndroidManifest.xml下android:versionCode
			//var localversionCode =context.PackageManager.GetPackageInfo (Global.package_name,0).VersionCode;
			var localversionCode =EldYoungUtil.GetAppVersionCode(context);
			//todo:获取webservice中android app版本号,两者比较，如果不同，返回true else false

			return true;
		}
		/// <summary>
		/// 显示软件更新对话框
		/// </summary>
		public void ShowNoticeDialog()
		{
			
			var builder = new AlertDialog.Builder (context).SetTitle ("软件升级").SetMessage ("发现新版本,建议更新使用");

			builder.SetPositiveButton ("下载", (sender, e) => {
				noticeDialog.Dismiss();	
				//显示下载对话框
				ShowDownloadDialog();
			});
			builder.SetNegativeButton ("以后再说", (sender, e) => {
				noticeDialog.Dismiss();	

			});
			noticeDialog= builder.Create ();
			noticeDialog.Show();

		}

		/// <summary>
		/// 显示软件下载更新对话框
		/// </summary>
		public void ShowDownloadDialog()
		{
			
			var builder = new AlertDialog.Builder (context).SetTitle ("正在更新");
			var inflater = LayoutInflater.From (context);
			var view = inflater.Inflate (Resource.Layout.progressbar, null);
			mProgressbar = view.FindViewById<ProgressBar> (Resource.Id.progressbar);
			builder.SetView (view);

			builder.SetNegativeButton ("取消", (sender, e) => {
				dowloadDialog.Dismiss();
				//设置取消状态
				cancelUpdate = true;
			});
			dowloadDialog = builder.Create ();
			dowloadDialog.Show ();
			//异步下载文件
			Task.Factory.StartNew(()=>DownloadApk());

		}
		/// <summary>
		/// 下载apk文件
		/// </summary>
		private void DownloadApk()
		{
			
			URL url = null;  
			Stream instream = null;  
			FileOutputStream outstream = null;  
			HttpURLConnection conn = null;  
			try
			{
				url = new URL(Global.AppServerUri);
				//创建连接
				conn = (HttpURLConnection) url.OpenConnection();
				conn.Connect();
				conn.ConnectTimeout =10000;
				conn.ConnectTimeout =20000;
				//获取文件大小
				var filelength = conn.ContentLength;
				instream = conn.InputStream;
				var file = new Java.IO.File(FILE_PATH);
				if(!file.Exists())
				{
					file.Mkdir();
				}
				outstream = new FileOutputStream(new Java.IO.File(saveFileName));

				int count =0;
				//缓存
				byte[] buff = new byte[1024];
				//写入文件中
				do
				{
					int numread = instream.Read(buff,0,buff.Length);
					count+=numread;
					//计算进度条位置
					progress = (int)(((float)count/filelength)*100);
				    //更新进度---- other question

					mProgressbar.Progress = progress;
					if(numread<=0)
					{
						//下载完成,安装新apk
						Task.Factory.StartNew(InStallApk);
						break;
					}
					//写入文件
					outstream.Write(buff,0,numread);

				}
				while(!cancelUpdate);//点击取消，停止下载
					
			}
			catch(Exception ex)
			{
				Android.Util.Log.Error (ex.StackTrace,ex.Message);
			}
			finally
			{
				if (instream != null)
					instream.Close ();
				if (outstream != null)
					outstream.Close ();
				if(conn!=null)
				    conn.Disconnect ();
			}
			dowloadDialog.Dismiss ();
		}

		private void InStallApk()
		{
			var file = new Java.IO.File (saveFileName);
			if (!file.Exists ()) {
				return;
			}
			//通过Intent安装新的apk文件
			Intent intent = new Intent(Intent.ActionView);
			intent.SetDataAndType (Android.Net.Uri.Parse ("file://"+saveFileName.ToString()), "application/vnd.android.package-archive");
			context.StartActivity (intent);

		}

	}
}

