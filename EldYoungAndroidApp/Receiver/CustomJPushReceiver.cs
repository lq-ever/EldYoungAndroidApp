using System;
using Android.Content;
using Android.Util;
using Android.App;
using Android.OS;
using Java.Util.Logging;
using CN.Jpush.Android.Api;
using System.Text;
using EldYoungAndroidApp.Activitys.Alarm;



namespace EldYoungAndroidApp.Receiver
{
	public class CustomJPushReceiver:BroadcastReceiver 
	{
		private static readonly string TAG = "CustomJPushReceiver";

		private NotificationManager notificationManager;

		public CustomJPushReceiver ()
		{
			
		}

		public override void OnReceive (Context context, Intent intent)
		{
			
			
			if (notificationManager == null)
				notificationManager = (NotificationManager) context.GetSystemService (Context.NotificationService);
			Bundle bundle = intent.Extras;
			Log.Debug (TAG,"[CustomJPushReceiver] onReceive - "+intent.Action +",extrals:"+ printBundle(bundle));

			if (JPushInterface.ActionRegistrationId.Equals (intent.Action)) {
				//注册成功,获取广播中的registerid
				var regId = bundle.GetString(JPushInterface.ExtraRegistrationId);
				Log.Debug(TAG, "[CustomJPushReceiver] 接收Registration Id : " + regId);
			    
			}
			else if (JPushInterface.ActionMessageReceived.Equals (intent.Action)) {
				//接收自定义消息
				Log.Debug(TAG, "[CustomJPushReceiver] 接收到推送下来的自定义消息: " + bundle.GetString(JPushInterface.ExtraMessage));
				ProcessCustomMessage(context, bundle);
				
			} else if (JPushInterface.ActionNotificationReceived.Equals (intent.Action)) {
				//接收到用户通知
				int notifactionId = bundle.GetInt(JPushInterface.ExtraNotificationId);
				Log.Debug(TAG, "[CustomJPushReceiver] 接收到推送下来的通知的ID: " + notifactionId);

			} else if (JPushInterface.ActionNotificationOpened.Equals (intent.Action)) {

				Log.Debug(TAG, "[CustomJPushReceiver] 用户点击打开了通知");
				OpenNotification (context,bundle);

			} else if (JPushInterface.ActionRichpushCallback.Equals (intent.Action)) {
				Log.Debug(TAG, "[CustomJPushReceiver] 用户收到到RICH PUSH CALLBACK: " + bundle.GetString(JPushInterface.ExtraExtra));
				//在这里根据 JPushInterface.EXTRA_EXTRA 的内容处理代码，比如打开新的Activity， 打开一个网页等..

			} else if (JPushInterface.ActionConnectionChange.Equals (intent.Action)) {
				//接收网络变化 连接/断开
				var connected = intent.GetBooleanExtra(JPushInterface.ExtraConnectionChange, false);
				Log.Warn(TAG, "[CustomJPushReceiver]" + intent.Action +" connected state change to "+connected);
			} else {
				//处理其它意图
				Log.Debug(TAG, "Unhandled intent - " + intent.Action);
			}
				

		}

		// 打印所有的 intent extra 数据
		private static String printBundle(Bundle bundle) {
			StringBuilder sb = new StringBuilder();
			foreach (string key in bundle.KeySet()) {
				if (key.Equals(JPushInterface.ExtraNotificationId)) {
					sb.Append("\nkey:" + key + ", value:" + bundle.GetInt(key));
				}else if(key.Equals(JPushInterface.ExtraConnectionChange)){
					sb.Append("\nkey:" + key + ", value:" + bundle.GetBoolean(key));
				} 
				else {
					sb.Append("\nkey:" + key + ", value:" + bundle.GetString(key));
				}
			}
			return sb.ToString();
		}

		private void OpenNotification(Context context,Bundle bundle)
		{
			//			String extras = bundle.getString(JPushInterface.EXTRA_EXTRA);
			//			String myValue = ""; 
			//			try {
			//				JSONObject extrasJson = new JSONObject(extras);
			//				myValue = extrasJson.optString("myKey");
			//			} catch (Exception e) {
			//				Logger.w(TAG, "Unexpected: extras is not a valid json", e);
			//				return;
			//			}
			//			if (TYPE_THIS.equals(myValue)) {
			//				Intent mIntent = new Intent(context, ThisActivity.class);
			//				mIntent.putExtras(bundle);
			//				mIntent.setFlags(Intent.FLAG_ACTIVITY_NEW_TASK);
			//				context.startActivity(mIntent);
			//			} else if (TYPE_ANOTHER.equals(myValue)){
			//				Intent mIntent = new Intent(context, AnotherActivity.class);
			//				mIntent.putExtras(bundle);
			//				mIntent.setFlags(Intent.FLAG_ACTIVITY_NEW_TASK);
			//				context.startActivity(mIntent);
			//			}

			//清除通知
			//JPushInterface.ClearNotificationById(context,bundle.GetInt(JPushInterface.ExtraNotificationId));//根据通知id
			String extras = bundle.GetString(JPushInterface.ExtraExtra);

			JPushInterface.ClearAllNotifications(context);//清除所有通知
			Intent intent = new Intent(context,typeof(AlarmDetailInfoActivity));
			bundle.PutString("alarmOrigin","Jpush");
			intent.PutExtras (bundle);

			intent.SetFlags (ActivityFlags.NewTask);
			context.StartActivity (intent);


		}

		/// <summary>
		/// 接收自定义消息
		/// </summary>
		/// <param name="context">Context.</param>
		/// <param name="bundle">Bundle.</param>
		private void ProcessCustomMessage(Context context,Bundle bundle)
		{
//			if (MainActivity.isForeground) {
//				String message = bundle.getString(JPushInterface.EXTRA_MESSAGE);
//				String extras = bundle.getString(JPushInterface.EXTRA_EXTRA);
//				Intent msgIntent = new Intent(MainActivity.MESSAGE_RECEIVED_ACTION);
//				msgIntent.putExtra(MainActivity.KEY_MESSAGE, message);
//				if (!ExampleUtil.isEmpty(extras)) {
//					try {
//						JSONObject extraJson = new JSONObject(extras);
//						if (null != extraJson && extraJson.length() > 0) {
//							msgIntent.putExtra(MainActivity.KEY_EXTRAS, extras);
//						}
//					} catch (JSONException e) {
//
//					}
//
//				}
//				context.sendBroadcast(msgIntent);
//			}

		}



	
	}


}

