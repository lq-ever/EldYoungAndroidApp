
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

namespace EldYoungAndroidApp
{
	[Activity (Theme = "@style/MyCustomTheme")]			
	public class SendSecurityCodeActivity : Activity
	{
		private EditText edit_Phone,edit_SecurityCode;
		public Button btn_Send,btn_Next;
		private MyCount mc;
		private string securityCode;
		private string sendType;
		private string phoneNumber;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			RequestWindowFeature (WindowFeatures.CustomTitle);
			SetContentView (Resource.Layout.SendSecurityCodeLayout);
			Window.SetFeatureInt (WindowFeatures.CustomTitle, Resource.Layout.custom_title_bar);
			// Create your application here
			InitView();
		}

		private void InitView()
		{
			//设置标题栏
			var btn_header_back = FindViewById<Button> (Resource.Id.btn_header_back);
			btn_header_back.Click += (sender, e) => 
			{
				this.Finish();
			};

			//取得上一页面传递过来的值包括是什么类型发送验证码（找回密码\修改支付密码\修改密码）
			var bundle = Intent.Extras;
			sendType = bundle.GetString ("SendType");
			phoneNumber = bundle.GetString ("PhoneNumber");
			var tv_header_title = FindViewById<TextView> (Resource.Id.tv_header_title);
			tv_header_title.Text = "找回登录密码";
			edit_Phone = FindViewById<EditText> (Resource.Id.edit_Phone);
			edit_SecurityCode = FindViewById<EditText> (Resource.Id.edit_SecurityCode);
			btn_Send = FindViewById<Button> (Resource.Id.btn_Send);
			btn_Next = FindViewById<Button> (Resource.Id.btn_Next);

			//初始化计时器,启动
			mc = new MyCount(this,60000,1000);
			//mc.Start ();

			//发送验证码
			btn_Send.Click += (sender, e) => 
			{
				btn_Send.Clickable = false;
				btn_Send.SetBackgroundResource(Resource.Color.lightgray);
				btn_Send.SetTextColor(Resources.GetColor(Resource.Color.ingray));
				SendCode();
			};

			//下一步
			btn_Next.Click += (sender, e) => 
			{
				this.Finish();
			};


		}
		/// <summary>
		/// 发送验证码
		/// </summary>
		private void SendCode()
		{
			 
		}
		/// <summary>
		/// 下一步操作
		/// </summary>
		private void Next()
		{
			
		}

		/// <summary>
		/// 发送验证码计时器
		/// </summary>
		public class MyCount:CountDownTimer
		{
			private SendSecurityCodeActivity Activity;
			public MyCount(SendSecurityCodeActivity _Activity,long millisInFuture, long countDownInterval):base(millisInFuture,countDownInterval)
			{
				Activity = _Activity;
			}
			public override void OnTick (long millisUntilFinished)
			{
				Activity.btn_Send.Text = (millisUntilFinished / 1000) + "秒后可重发";
			}
			public override void OnFinish ()
			{
				Activity.btn_Send.Text = "获取验证码";
				Activity.btn_Send.Clickable = true;
				Activity.securityCode = string.Empty;
				Activity.btn_Send.SetBackgroundResource (Resource.Color.blue);
				Activity.btn_Send.SetTextColor(Activity.Resources.GetColor(Resource.Color.white));
			}
		}


		public override void Finish ()
		{
			base.Finish ();
			mc.Cancel ();
		}
	}


}

