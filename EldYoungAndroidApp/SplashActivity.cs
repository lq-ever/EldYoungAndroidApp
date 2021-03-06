﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using CN.Jpush.Android.Api;
using EldYoungAndroidApp.Common;


namespace EldYoungAndroidApp
{
	[Activity (MainLauncher =true,ScreenOrientation= ScreenOrientation.Portrait, NoHistory = true,Theme= "@style/AppTheme")]			
	public class SplashActivity : InstrumentedActivity,IDialogInterfaceOnKeyListener
	{
		private Dialog noticeDialog;
		protected override void OnCreate (Bundle bundle)
		{
			
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.SplashLayout);
			// Create your application here
			new Handler ().PostDelayed (() => {
				var updateManager = new UpdateManager(this,true);
				if (updateManager.CheckUpdate())
				{
					var builder = new AlertDialog.Builder (this).SetTitle ("软件升级").SetMessage ("发现新版本,建议更新使用新版本").SetOnKeyListener(this).SetCancelable(false);
					builder.SetPositiveButton ("下载", (sender, e) => {
						noticeDialog.Dismiss();	
						//显示下载对话框,下载
						updateManager.ShowDownloadDialog();
					});
					builder.SetNegativeButton ("以后再说", (sender, e) => {
						noticeDialog.Dismiss();	
						LoadActivity();
					});
					noticeDialog= builder.Create ();
					noticeDialog.Show();
				}
				else
				{
					LoadActivity();
				}
			}, 2000);
		}

		public bool OnKey (IDialogInterface dialog, [GeneratedEnum] Keycode keyCode, KeyEvent e)
		{
			if (keyCode == Keycode.Back && e.RepeatCount == 0)
				return true;
			return false;
		}

		/// <summary>
		/// Loads the activity.
		/// </summary>
		public void LoadActivity()
		{
			//如果启动app的Intent中带有额外的参数，表明app是从点击通知栏的动作中启动的
			//将参数取出，传递到login activity 或MainActivity中
			var sharedPreferencelaunch =  this.GetSharedPreferences(Global.SHAREDPREFERENCES_LAUNCHNAME,FileCreationMode.Private);
			var isFirstLaunch = sharedPreferencelaunch.GetBoolean (Global.IsFirstIn, true);
			var sharedPreferenceuserinfo = this.GetSharedPreferences(Global.SHAREDPREFERENCES_USERINFO,FileCreationMode.Private);
			if (isFirstLaunch) {
				//软件第一次使用，进入功能引导页				
				StartActivity(typeof(GuiderActivity));
			} else {
				//软件不是第一次使用,判断是否自动登录和是否曾经登录成功过，
				if(sharedPreferenceuserinfo.GetBoolean(Global.login_AutoLogin_Check,false))
				{
					//勾选自动登录，且本地用户名存在，进入主界面，否则进入登录界面
					if (!string.IsNullOrEmpty (sharedPreferenceuserinfo.GetString (Global.login_UserName, string.Empty))) {
						Intent mainIntent = new Intent (this, typeof(MainFragActivity));
						var bundle = Intent.Extras;
						if (bundle != null)
							mainIntent.PutExtras (bundle);
						StartActivity (mainIntent);
						//StartActivity(typeof(MainFragActivity));
					} else {
						Intent loginIntent = new Intent(this,typeof(LoginActivity));
						loginIntent.SetFlags (ActivityFlags.ClearTop);
						var bundle = Intent.Extras;
						if (bundle != null)
							loginIntent.PutExtras (bundle);
						StartActivity(loginIntent);
						//StartActivity (typeof(LoginActivity));
					}
				}
				else
				{
					//未勾选自动登录
					Intent loginIntent = new Intent(this,typeof(LoginActivity));
					loginIntent.SetFlags (ActivityFlags.ClearTop);
					var bundle = Intent.Extras;
					if (bundle != null)
						loginIntent.PutExtras (bundle);
					StartActivity(loginIntent);
				}


			}

			this.Finish();
			OverridePendingTransition(Android.Resource.Animation.FadeIn,Android.Resource.Animation.FadeOut);

		}
		protected override void OnResume ()
		{
			base.OnResume ();
			JPushInterface.OnResume (ApplicationContext);
		}
		protected override void OnPause ()
		{
			base.OnPause ();
			JPushInterface.OnPause (ApplicationContext);
		}


	}
}

