﻿using System;
using EldYoungAndroidApp.Model;
using Com.Nostra13.Universalimageloader.Core;
using Android.Graphics;
using Com.Nostra13.Universalimageloader.Core.Display;


namespace EldYoungAndroidApp.Common
{
	public class Global
	{
		public Global ()
		{
		}
		#region 共享sharedperfernces相关
		public const string SHAREDPREFERENCES_LAUNCHNAME = "first_pref";
		public const string SHAREDPREFERENCES_USERINFO = "userInfo";

	

		public const string IsFirstIn = "isFirstIn";

		public const string login_Password_Check = "IsPasswordCheck";
		public const string login_AutoLogin_Check ="AutoCheck";
		public const string login_UserName ="userName";
		public const string login_Password ="userPassword";

		/// <summary>
		/// 极光推送
		/// </summary>
		public const string SHAREDPREFERENCES_JPUSH ="Jpush";
		public const string Jpush_Alias = "alias";
		#endregion

		/// <summary>
		/// 程序包名称
		/// </summary>
		public const string package_name ="com.eldyoung.lelaozuandroidapp";
		/// <summary>
		/// 程序本地版本号
		/// </summary>
		public const string version_code = "1.0.0";
		/// <summary>
		/// 程序平台
		/// </summary>
		public const string app_platform = "Android";

		/// <summary>
		/// 服务器地址
		/// </summary>
		public const string LocalServer="http://192.168.0.117:8089/";

		#region Hanlder Uri
		public const string AlarmHandler ="SearchAlarmInforService.ashx";

		public const string CustomHandler ="CustomerServiceInforService.ashx";

		#endregion

		//服务端安装包路径
		public static string AppPackagePath = "http://192.168.0.134/AndroidApp/Release/com.eldyoung.lelaozuandroidapp.apk";

		#region androidRestApi
		public const string AndroidKey = "yiyang";

		//测试环境
		//public const string AndroidLocalServerPath ="http://192.168.0.117:8089/Android/";
		public const string AndroidLocalServerPath ="http://192.168.0.129:82/Android/";
		//正式环境
		public const string AndroidReleaseServerPath ="http://dataserver.lelaozu.com/Android/";
		public const string AndroidReleaseHeadImgPre ="http://i.lelaozu.com";


		//登录注册相关
		public const string RegistLoginUrl = "AndroidDataService.aspx";
		//报警信息相关
		public const string AlarmUrl ="AlarmInforDataService.aspx";
		//监护人信息相关
		public const string GuardianUrl ="UserBind.aspx";

		//健康体检信息相关
		public const string HealthInfoUrl = "HealthInforDataService.aspx"; 
		//头像上传
		public const string HeadImgUrl ="SaveHeadImg.aspx";
		//更新个人信息
		public const string UpdatePersonInfoUrl="UpdateBaseInfo.aspx";
		//获取服务端软件版本
		public const string GetAppVersionUrl ="GetAppVersionService.aspx";
		//投诉建议信息服务
		public const string AdviceInfoUrl = "DoMessageInfor.aspx";

		#endregion


		public static PersonInfoItem MyInfo;//个人信息


		#region 使用imageloader加载网络图像
		public static ImageLoader imageLoader
		{
			get{
				return ImageLoader.Instance;
			}
		}

		public static DisplayImageOptions Options
		{
			get {
				return new DisplayImageOptions.Builder ().ShowImageOnLoading (Resource.Drawable.headImagedefault)
					.ShowImageOnFail (Resource.Drawable.headImagedefault)
					.ShowImageForEmptyUri (Resource.Drawable.headImagedefault)
					.CacheInMemory (true)
					.CacheOnDisk (true)
					.BitmapConfig (Bitmap.Config.Rgb565)
					.Displayer(new RoundedBitmapDisplayer(20))
					.Displayer(new FadeInBitmapDisplayer(100))
					.Build ();
			}
		}

		#endregion
	}
}

  