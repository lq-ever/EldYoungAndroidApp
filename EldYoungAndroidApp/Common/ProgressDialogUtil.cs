using System;
using Android.Content;
using Android.App;
using Android.Views;


namespace EldYoungAndroidApp.Common
{
	public class ProgressDialogUtil
	{
		private static CustomProgressDialog progressDialog;
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

//			if(progressDialog == null)
				progressDialog = CustomProgressDialog.createDialog (_activity);
			progressDialog.Window.SetGravity (GravityFlags.Center); 
			progressDialog.SetMessage (msg);
			progressDialog.Show ();
			progressDialog.SetCancelable (false);

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

