using System;
using Android.Content;
using Android.Net;
using Android.Telephony;
using Android.OS;
using Android.Content.PM;
using System.Text.RegularExpressions;
using CN.Jpush.Android.Api;
using Android.Content.Res;


namespace EldYoungAndroidApp.Common
{
	public class EldYoungUtil
	{
		public static readonly String KEY_APP_KEY = "JPUSH_APPKEY";

		public EldYoungUtil ()
		{
		}

		/// <summary>
		/// 检测网络连接状态
		/// </summary>
		/// <returns><c>true</c> if this instance is connected the specified context; otherwise, <c>false</c>.</returns>
		/// <param name="context">Context.</param>
		public static bool IsConnected(Context context)
		{
			bool netFlag = false;
			ConnectivityManager connManager = (ConnectivityManager)context.GetSystemService (Context.ConnectivityService);

			if (connManager.ActiveNetworkInfo != null) {
				var wifiWorkInfo = connManager.GetNetworkInfo (ConnectivityType.Wifi);
				var gprsWorkInfo = connManager.GetNetworkInfo (ConnectivityType.Mobile);
				if (wifiWorkInfo != null && wifiWorkInfo.IsAvailable != false)
					netFlag = true;
				if (gprsWorkInfo != null && gprsWorkInfo.IsConnected != false)
					netFlag = true;
			}
			return netFlag;
				
		}
		/// <summary>
		/// 获取手机Imei
		/// </summary>
		/// <returns>The imei.</returns>
		/// <param name="context">Context.</param>
		public static string GetImei(Context context)
		{
			try{
				TelephonyManager telePhoneManager = (TelephonyManager) context.GetSystemService (Context.TelephonyService);
				return telePhoneManager.DeviceId;
			}
			catch(Android.Content.PM.PackageManager.NameNotFoundException ex) {
				return string.Empty;
			}
		}

		/// <summary>
		/// 获取app版本号versioncode
		/// </summary>
		/// <returns>The app version.</returns>
		/// <param name="context">Context.</param>
		public static int GetAppVersionCode(Context context)
		{
			return	context.PackageManager.GetPackageInfo (context.PackageName, 0).VersionCode;
		}

		/// <summary>
		/// 获取JPushapp key
		/// </summary>
		/// <returns>The J push app key.</returns>
		/// <param name="context">Context.</param>
		public static string GetJPushAppKey(Context context)
		{
			Bundle metaData = null;
			string appKey = null;
			try{
				

				ApplicationInfo  info = context.PackageManager.GetApplicationInfo(context.PackageName,PackageInfoFlags.MetaData);

				if(info!=null)
					metaData = info.MetaData;
				if(metaData!=null)
					appKey = metaData.GetString(KEY_APP_KEY);
				if(appKey!=null && appKey.Length !=24)
					appKey = null;
			}
			catch(Android.Content.PM.PackageManager.NameNotFoundException ex) {
				
			}
			return appKey;
		}

		/// <summary>
		/// 检测tag或别名有效性,只能是数字、英文字母、中文
		/// </summary>
		/// <returns><c>true</c> if is valid tag and alias the specified str; otherwise, <c>false</c>.</returns>
		/// <param name="str">String.</param>
		public static bool IsValidTagAndAlias(string str)
		{
			Regex regex = new Regex ("^[\u4E00-\u9FA50-9a-zA-Z_-]{0,}$");
			return regex.IsMatch (str);
		}


		/// <summary>
		/// 验证手机号
		/// </summary>
		/// <returns><c>true</c> if is mobile no the specified mobileNo; otherwise, <c>false</c>.</returns>
		/// <param name="mobileNo">Mobile no.</param>
		public static bool IsMobileNo(string mobileNo)
		{
			/* 
				移动：134、135、136、137、138、139、150、151、157(TD)、158、159、187、188 
				联通：130、131、132、152、155、156、185、186 
				电信：133、153、180、189、（1349卫通） 
				总结起来就是第一位必定为1，第二位必定为3或5或8，其他位置的可以为0-9 
			*/  
			if (string.IsNullOrEmpty (mobileNo))
				return false;
			var telRegex = "[1][358]\\d{9}";
			return Regex.IsMatch (mobileNo, telRegex);

		}

		/// <summary>
		/// 手机安全码
		/// </summary>
		/// <returns><c>true</c> if is security code the specified code; otherwise, <c>false</c>.</returns>
		/// <param name="code">Code.</param>
		public static bool IsSecurityCode(string code)
		{
			var securityCode = "^\\d{6}$";
			return Regex.IsMatch (code, securityCode);
		}
		/// <summary>
		/// 验证固定电话号码
		/// </summary>
		/// <returns><c>true</c> if is fixed phone the specified fixedPhone; otherwise, <c>false</c>.</returns>
		/// <param name="fixedPhone">Fixed phone.</param>
		public static bool IsFixedPhone(string fixedPhone)
		{
			var fixedRegx = "^(\\d{3,4}-)?\\d{6,8}$";
			return Regex.IsMatch (fixedPhone, fixedRegx);
		}
		/// <summary>
		/// 验证身份证号码
		/// </summary>
		/// <returns><c>true</c> if is identifier card no the specified IdCardNo; otherwise, <c>false</c>.</returns>
		/// <param name="IdCardNo">Identifier card no.</param>
		public static bool IsIdCardNo(string IdCardNo)
		{
			var idCardNoRegx = "(^\\d{18}$)|(^\\d{15}$)";
			return Regex.IsMatch (IdCardNo, idCardNoRegx);
		}
		/// <summary>
		/// 验证邮箱号码
		/// </summary>
		/// <returns><c>true</c> if is email the specified email; otherwise, <c>false</c>.</returns>
		/// <param name="email">Email.</param>
		public static bool IsEmail(string email)
		{
			var emailRegx = "^(\\w)+(\\.\\w+)*@(\\w)+((\\.\\w+)+)$";
			return Regex.IsMatch (email, emailRegx);
		}
	
		public static int px2dip(Context context, float pxValue)
		{
			var m = context.Resources.DisplayMetrics.Density;
			return (int)(pxValue / m + 0.5f) ;
		}
	}
}

