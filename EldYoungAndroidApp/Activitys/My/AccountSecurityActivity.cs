
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
using Com.Handmark.Pulltorefresh.Library;
using System.Threading.Tasks;
using System.Threading;

namespace EldYoungAndroidApp
{
	[Activity (Theme = "@style/MyCustomTheme")]			
	public class AccountSecurityActivity : Activity,PullToRefreshBase.IOnRefreshListener
	{
		private PullToRefreshScrollView mPullRefreshScrollView;  
		private ScrollView mScrollView;  
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			RequestWindowFeature (WindowFeatures.CustomTitle);
			SetContentView (Resource.Layout.AccountSecurityLayout);
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
			var tv_header_title = FindViewById<TextView> (Resource.Id.tv_header_title);
			tv_header_title.Text = "账户安全";


			mPullRefreshScrollView = FindViewById<PullToRefreshScrollView>(Resource.Id.pull_refresh_scrollview);
			mScrollView = (ScrollView)mPullRefreshScrollView.RefreshableView;
			//下拉刷新提示文本
			mPullRefreshScrollView.GetLoadingLayoutProxy(true,false).SetPullLabel(GetString(Resource.String.pullDownLbl));
			mPullRefreshScrollView.GetLoadingLayoutProxy (true,false).SetRefreshingLabel(GetString(Resource.String.pullDownRefreshLbl));
			mPullRefreshScrollView.GetLoadingLayoutProxy (true, false).SetReleaseLabel (GetString(Resource.String.pullDownReleaseLbl));
			//上拉、下拉设定  
			mPullRefreshScrollView.Mode = PullToRefreshBase.PullToRefreshMode.Both;  

			//登录密码
			var rl_person_loginPwd = FindViewById<RelativeLayout>(Resource.Id.rl_person_loginPwd);
			rl_person_loginPwd.Click += (sender, e) => 
			{
				var intent = new Intent(this,typeof(SendSecurityCodeActivity));
				var sendbundle = new Bundle();
				sendbundle.PutString("SendType","ModifyPwd");//修改密码
				sendbundle.PutString("PhoneNumber",Global.MyInfo.PhoneNumberOne);
				intent.PutExtras(sendbundle);
				StartActivity(intent);
				OverridePendingTransition(Android.Resource.Animation.SlideInLeft,Android.Resource.Animation.SlideOutRight);

			};
			//修改支付密码
			var rl_person_payPwd = FindViewById<RelativeLayout>(Resource.Id.rl_person_payPwd);
			rl_person_payPwd.Click += (sender, e) => 
			{
				var intent = new Intent(this,typeof(SendSecurityCodeActivity));
				var sendbundle = new Bundle();
				sendbundle.PutString("SendType","ModifyPayPwd");//设置支付密码
				sendbundle.PutString("PhoneNumber",Global.MyInfo.PhoneNumberOne);
				intent.PutExtras(sendbundle);
				StartActivity(intent);
				OverridePendingTransition(Android.Resource.Animation.SlideInLeft,Android.Resource.Animation.SlideOutRight);
			};
			var tv_payPwd = FindViewById<TextView> (Resource.Id.tv_payPwd);
			tv_payPwd.Text = string.IsNullOrEmpty (Global.MyInfo.PayPassword) ? "设置" : "修改";

			//手机绑定
			var rl_person_phoneBind = FindViewById<RelativeLayout>(Resource.Id.rl_person_phoneBind);
			rl_person_phoneBind.Click += (sender, e) => 
			{

			};
			var tv_phoneBind = FindViewById<TextView> (Resource.Id.tv_phoneBind);
			tv_phoneBind.Text = string.IsNullOrEmpty (Global.MyInfo.PhoneNumberOne) ? "绑定" : "解绑";
			//身份认证
			var rl_person_identity = FindViewById<RelativeLayout>(Resource.Id.rl_person_identity);
			rl_person_identity.Click += (sender, e) => 
			{

			};
			var tv_identity = FindViewById<TextView> (Resource.Id.tv_identity);
			tv_identity.Text = string.IsNullOrEmpty (Global.MyInfo.IDNumber) ? "未认证" : "已认证";

		}

		public void OnRefresh (PullToRefreshBase p0)
		{
			Task.Factory.StartNew (() => {
				
				Refresh();
			});
		}
		/// <summary>
		/// Refresh this instance.
		/// </summary>
		private void Refresh()
		{
			Thread.Sleep (2000);
			mPullRefreshScrollView.OnRefreshComplete ();
		}
	}
}

