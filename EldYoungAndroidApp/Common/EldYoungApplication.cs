using System;
using Android.App;
using CN.Jpush.Android.Api;
using Android.Runtime;
using Java.Lang;

namespace EldYoungAndroidApp.Common
{
	public class EldYoungApplication:Application
	{
		public EldYoungApplication ():base()
		{
		}
		protected EldYoungApplication (IntPtr javaReference, JniHandleOwnership transfer):base(javaReference,transfer)
		{
		}
		public override void OnCreate ()
		{
			base.OnCreate ();
			#region 极光推送相关
			//注册Jpush
			JPushInterface.SetDebugMode (true);
			JPushInterface.Init (ApplicationContext);
			//设置基本样式
			SetNotificationStyleBasic();
			//自定义推送通知栏样式 test
			SetNotificationStyleCustom();
			//设置保留最近5条通知
			JPushInterface.SetLatestNotificationNumber(ApplicationContext,5);
			#endregion
		}
		/// <summary>
		/// Sets the notification style basic.
		/// </summary>
		private void SetNotificationStyleBasic()
		{
			BasicPushNotificationBuilder builder1 = new BasicPushNotificationBuilder(this);
			builder1.StatusBarDrawable =Resource.Drawable.ic_launch;
			builder1.NotificationFlags = (int) NotificationFlags.AutoCancel;  //设置为自动消失
			builder1.NotificationDefaults =(int) NotificationDefaults.All; // 设置为铃声与震动都要
			JPushInterface.SetPushNotificationBuilder((Integer)1,builder1);
		}

		/// <summary>
		/// Sets the notification style custom.
		/// </summary>
		private void SetNotificationStyleCustom()
		{
			CustomPushNotificationBuilder  builder2 = new CustomPushNotificationBuilder(this,Resource.Layout.customer_notitfication_layout,
				Resource.Id.msgIcon,Resource.Id.msgTitle,Resource.Id.msgContent);
			builder2.StatusBarDrawable = Resource.Drawable.ic_launch;      
			// 指定最顶层状态栏小图标
			builder2.LayoutIconDrawable = Resource.Drawable.ic_launch;   
			// 指定下拉状态栏时显示的通知图标
			JPushInterface.SetPushNotificationBuilder((Integer)2, builder2);

		}

	}
}

