using System;
using Android.Content;
using Android.App;
using Android.Views;


namespace EldYoungAndroidApp.Common
{
	public class ProgressDialogUtil
	{
		private static CustomProgressDialog progressDialog;
		private static Activity activity;
		public ProgressDialogUtil ()
		{
			  
		}
		/// <summary>
		/// 启动 progress dialog.
		/// </summary>
		/// <param name="context">Context.</param>
		/// <param name="msg">Message.</param>
		public static void StartProgressDialog(Activity _activity,string msg)
		{
			activity = _activity;
//			if(progressDialog == null)
				progressDialog = CustomProgressDialog.createDialog (_activity);

			progressDialog.SetMessage (msg);
			progressDialog.Show ();


		}
		/// <summary>
		/// 停止 the progress dialog.
		/// </summary>
		public static void StopProgressDialog()
		{
			if (progressDialog != null && progressDialog.IsShowing)
				progressDialog.Dismiss ();
			progressDialog = null;

		}

	
	}
}

