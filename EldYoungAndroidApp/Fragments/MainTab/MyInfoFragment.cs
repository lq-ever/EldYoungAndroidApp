
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Android.Support.V4.App;
using Android.App;
using EldYoungAndroidApp.My;
using Android.Graphics;
using EldYoungAndroidApp.Common;

namespace EldYoungAndroidApp.Fragments.MainTab
{
	public class MyInfoFragment : Android.Support.V4.App.Fragment
	{
		private  string path="/sdcard/eldYoung/Cache/HeadImage/";//sd卡路径
		private ImageView img_head;
		public override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);


			// Create your fragment here
		}

		public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			// Use this to return your custom view for this Fragment
			// return inflater.Inflate(Resource.Layout.YourFragment, container, false);

			base.OnCreateView (inflater, container, savedInstanceState);
			var tab_MyView = inflater.Inflate (Resource.Layout.Main_Tab_MyLayout, container, false);
			return tab_MyView;
		}
		public override void OnActivityCreated (Bundle savedInstanceState)
		{
			base.OnActivityCreated (savedInstanceState);

			img_head = View.FindViewById<ImageView> (Resource.Id.img_head);
			//设置头像
			SetPersonImg ();
			//设置界面
			var btn_setting = View.FindViewById<Button> (Resource.Id.btn_setting);
			btn_setting.Click += (sender, e) => 
			{
				Activity.StartActivity(typeof(SetActivity));
				Activity.OverridePendingTransition(Android.Resource.Animation.FadeIn,Android.Resource.Animation.FadeOut);
			};

			//设置个人账户信息
			var rl_personal = View.FindViewById<RelativeLayout>(Resource.Id.rl_personal);
			rl_personal.Click += (sender, e) => 
			{
				Activity.StartActivity(typeof(PersonActivity));
			    Activity.OverridePendingTransition(Android.Resource.Animation.FadeIn,Android.Resource.Animation.FadeOut);
			};

			var tv_nickName = View.FindViewById<TextView> (Resource.Id.tv_nickName);
			var tv_phonenumber = View.FindViewById<TextView> (Resource.Id.tv_phonenumber);
			//设置用户昵称和手机号
			tv_nickName.Text = string.IsNullOrEmpty(Global.MyInfo.UserName)?"未设置昵称":Global.MyInfo.UserName;
			var iphoneNumber = Global.MyInfo.PhoneNumberOne;
			if (!string.IsNullOrEmpty (iphoneNumber)) {
				var midleStr = iphoneNumber.Substring (3, 4);
				var resultStr = iphoneNumber.Replace (midleStr, "****");
				tv_phonenumber.Text = resultStr;
			} else
				tv_phonenumber.Text = "未绑定手机号";
				

			

			//分享给好友
//			var rl_share = View.FindViewById<RelativeLayout>(Resource.Id.rl_share);
//			rl_share.Click += (sender, e) => 
//			{
//				//todo:
//			};

		}
		private void SetPersonImg()
		{
			//从Sd中找头像，转换成Bitmap
			Bitmap bt = BitmapFactory.DecodeFile(path +Global.Guid+ "head.jpg");
			if(bt!=null){

				img_head.SetImageBitmap (bt);
			}
			else
			{
				//本地无照片,调用web服务获取
				Global.imageLoader.DisplayImage(Global.MyInfo.HeadImgReleaseUrl,img_head,Global.Options);
			}
		}

		public override void OnResume ()
		{
			SetPersonImg ();
			base.OnResume ();
		}
	}
}

