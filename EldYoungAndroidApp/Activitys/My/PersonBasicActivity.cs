
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
	public class PersonBasicActivity : Activity
	{
		private TextView tv_userName,tv_phoneNumberOne;
		private EditText edit_trueName,edit_IdCardNo,edit_birth,edit_fixedPhone,edit_email,edit_idCardLocation,edit_locationthreelevel,edit_locationdeatil;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			RequestWindowFeature (WindowFeatures.CustomTitle);
			// Create your application here
			SetContentView(Resource.Layout.PersonBasicLayout);
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
			FindViewById<TextView> (Resource.Id.tv_header_title).Text = "基本资料";
			//完成按钮
			var tv_header_save = FindViewById<TextView>(Resource.Id.tv_header_save);
			tv_header_save.Text = "保存";
			tv_header_save.Click += (sender, e) => 
			{
				//todo:调用webservice保存个人信息
				ProgressDialogUtil.StartProgressDialog(this,"正在保存中,请稍后...");
				new  Thread(()=>
					{
						Thread.Sleep(2000);
						RunOnUiThread(()=>
							{
								Toast.MakeText(this,"保存成功",ToastLength.Short).Show();
								ProgressDialogUtil.StopProgressDialog();
								this.Finish();
								OverridePendingTransition(Android.Resource.Animation.SlideInLeft,Android.Resource.Animation.SlideOutRight);
							});
					}).Start();
			};
			//用户名
			tv_userName = FindViewById<TextView>(Resource.Id.tv_userName);
			tv_userName.Text = Global.MyInfo.UserName;
			//真实姓名
			edit_trueName = FindViewById<EditText>(Resource.Id.edit_trueName);
			edit_trueName.Text = string.IsNullOrEmpty (Global.MyInfo.TrueName) ? "" : Global.MyInfo.TrueName;
			//身份证号码
			edit_IdCardNo = FindViewById<EditText>(Resource.Id.edit_IdCardNo);
			edit_IdCardNo.Text = string.IsNullOrEmpty (Global.MyInfo.IDNumber) ? "" : Global.MyInfo.IDNumber;
			//性别
			var rbtn_male = FindViewById<RadioButton>(Resource.Id.rbtn_male);
			var rbtn_female = FindViewById<RadioButton> (Resource.Id.rbtn_female);
			if (!string.IsNullOrEmpty (Global.MyInfo.Gender) && Global.MyInfo.Gender.Equals ("0"))
				rbtn_male.Checked = true;
			else
				rbtn_female.Checked = true;
			//生日
			edit_birth = FindViewById<EditText> (Resource.Id.edit_birth);
			edit_birth.Text = !string.IsNullOrEmpty (Global.MyInfo.Age) ?Convert.ToDateTime(Global.MyInfo.Age).ToString("yyyy-MM-dd") :"";
			edit_birth.Click += (sender, e) => 
			{
				var datepickdialog = new DatePickDialogUtil(this,edit_birth.Text);
				datepickdialog.DatePickDialogShow(edit_birth);

			};
			//电话号码
			tv_phoneNumberOne = FindViewById<TextView>(Resource.Id.tv_phoneNumberOne);
			tv_phoneNumberOne.Text = !string.IsNullOrEmpty (Global.MyInfo.PhoneNumberOne) ? Global.MyInfo.PhoneNumberOne : "";
			//固定电话
			edit_fixedPhone = FindViewById<EditText>(Resource.Id.edit_fixedPhone);
			edit_fixedPhone.Text = !string.IsNullOrEmpty (Global.MyInfo.TelePhoneNumber) ? Global.MyInfo.TelePhoneNumber : "";
			//电子邮箱
			edit_email = FindViewById<EditText>(Resource.Id.edit_email);
			edit_email.Text = !string.IsNullOrEmpty (Global.MyInfo.Email) ? Global.MyInfo.Email : "";
			//身份证所在地
			edit_idCardLocation = FindViewById<EditText>(Resource.Id.edit_idCardLocation);
			edit_idCardLocation.Text = !string.IsNullOrEmpty (Global.MyInfo.IDAddress) ? Global.MyInfo.IDAddress : "";
			//todo:设置详细地址
			edit_locationthreelevel = FindViewById<EditText>(Resource.Id.edit_locationthreelevel);
			edit_locationdeatil = FindViewById<EditText> (Resource.Id.edit_locationdeatil);
		}
	}
}

