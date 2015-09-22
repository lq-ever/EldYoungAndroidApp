
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using EldYoungAndroidApp.Common;

namespace EldYoungAndroidApp
{
	[Activity (Theme="@style/MyCustomTheme")]			
	public class SetActivity : Activity
	{
		private Dialog noticeDialog;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			RequestWindowFeature (WindowFeatures.CustomTitle);
			SetContentView (Resource.Layout.SetLayout);
			Window.SetFeatureInt (WindowFeatures.CustomTitle, Resource.Layout.custom_title_bar);
			InitView ();
			// Create your application here
		}
		private void InitView()
		{
			//设置标题栏
			var btn_header_back = FindViewById<Button> (Resource.Id.btn_header_back);
			btn_header_back.Click += (sender, e) => 
			{
				this.Finish();
				OverridePendingTransition(Android.Resource.Animation.SlideInLeft,Android.Resource.Animation.SlideOutRight);
			};

			FindViewById<TextView> (Resource.Id.tv_header_title).Text = "设置";

			//关于我们
			var rl_aboutUs = FindViewById<RelativeLayout> (Resource.Id.rl_aboutUs);
			rl_aboutUs.Click += (sender, e) => 
			{
				StartActivity(typeof(AboutUsActivity));
				OverridePendingTransition(Android.Resource.Animation.FadeIn,Android.Resource.Animation.FadeOut);
			};
			//版本检测  待测试
			var rl_versionCheck = FindViewById<RelativeLayout>(Resource.Id.rl_versionCheck);
			rl_versionCheck.Click += (sender, e) => 
			{
				new Handler().PostDelayed(()=>
					{
						var updateManager = new UpdateManager(this);
						if (updateManager.CheckUpdate())
						{
							var builder = new AlertDialog.Builder (this).SetTitle ("软件升级").SetMessage ("发现新版本,建议更新使用新版本");

							builder.SetPositiveButton ("下载", (sender1, e1) => {
								noticeDialog.Dismiss();	
								//显示下载对话框,下载
								updateManager.ShowDownloadDialog();
							});
							builder.SetNegativeButton ("以后再说", (sender2, e2) => {
								noticeDialog.Dismiss();	
							});
							noticeDialog= builder.Create ();
							noticeDialog.Show();

						}
						else
						{
							RunOnUiThread(()=>
								{
									Toast.MakeText(this,"当前是已是最新版本",ToastLength.Short).Show();
								});
							
						}
						
					},1000);
				
			};
			//清楚缓存
			var rl_cacheRemover = FindViewById<RelativeLayout>(Resource.Id.rl_cacheRemover);
			rl_cacheRemover.Click += (sender, e) => 
			{
				//todo:清楚缓存
				Toast.MakeText(this,"清除缓存成功",ToastLength.Short).Show();
			};

			//退出进入登录界面
			var btn_Exit = FindViewById<Button> (Resource.Id.btn_Exit);
			btn_Exit.Click += (sender, e) => 
			{
				var intent = new Intent(this,typeof(LoginActivity));
				intent.SetFlags(ActivityFlags.ClearTask|ActivityFlags.NewTask);
				StartActivity(intent);						
				this.Finish();
				OverridePendingTransition(Android.Resource.Animation.FadeIn,Android.Resource.Animation.FadeOut);
			};
		}
	}
}

