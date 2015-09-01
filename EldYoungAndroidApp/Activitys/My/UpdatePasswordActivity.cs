
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
using System.Threading;

namespace EldYoungAndroidApp
{
	[Activity (Theme="@style/MyCustomTheme")]			
	public class UpdatePasswordActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			RequestWindowFeature (WindowFeatures.CustomTitle);
			// Create your application here
			SetContentView(Resource.Layout.UpdatePasswordLayout);
			Window.SetFeatureInt (WindowFeatures.CustomTitle, Resource.Layout.custom_titlebar_action);
			InitView ();
		}
		private void InitView()
		{
			//设置标题栏
			var btn_headerBack = FindViewById<Button> (Resource.Id.btn_header_back);

			btn_headerBack.Click += (sender, e) => 
			{
				this.Finish();
				OverridePendingTransition(Android.Resource.Animation.SlideInLeft,Android.Resource.Animation.SlideOutRight);
			};
			FindViewById<TextView> (Resource.Id.tv_header_title).Text = "修改密码";
			//完成按钮
			var tv_header_save = FindViewById<TextView>(Resource.Id.tv_header_save);
			tv_header_save.Text="提交";
			tv_header_save.Click += (sender, e) => 
			{
				//todo:调用webservice保存个人信息
				ProgressDialogUtil.StartProgressDialog(this,"正在提交中,请稍后...");
				new  Thread(()=>
					{
						Thread.Sleep(2000);
						RunOnUiThread(()=>
							{
								Toast.MakeText(this,"修改密码成功",ToastLength.Short).Show();
								ProgressDialogUtil.StopProgressDialog();
								this.Finish();
								OverridePendingTransition(Android.Resource.Animation.SlideInLeft,Android.Resource.Animation.SlideOutRight);
							});
					}).Start();
			};

		}
	}
}

