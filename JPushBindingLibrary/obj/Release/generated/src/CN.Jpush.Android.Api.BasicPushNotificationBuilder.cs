using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CN.Jpush.Android.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='BasicPushNotificationBuilder']"
	[global::Android.Runtime.Register ("cn/jpush/android/api/BasicPushNotificationBuilder", DoNotGenerateAcw=true)]
	public partial class BasicPushNotificationBuilder : global::CN.Jpush.Android.Api.DefaultPushNotificationBuilder {


		static IntPtr developerArg0_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='BasicPushNotificationBuilder']/field[@name='developerArg0']"
		[Register ("developerArg0")]
		public string DeveloperArg0 {
			get {
				if (developerArg0_jfieldId == IntPtr.Zero)
					developerArg0_jfieldId = JNIEnv.GetFieldID (class_ref, "developerArg0", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, developerArg0_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (developerArg0_jfieldId == IntPtr.Zero)
					developerArg0_jfieldId = JNIEnv.GetFieldID (class_ref, "developerArg0", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, developerArg0_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr notificationDefaults_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='BasicPushNotificationBuilder']/field[@name='notificationDefaults']"
		[Register ("notificationDefaults")]
		public int NotificationDefaults {
			get {
				if (notificationDefaults_jfieldId == IntPtr.Zero)
					notificationDefaults_jfieldId = JNIEnv.GetFieldID (class_ref, "notificationDefaults", "I");
				return JNIEnv.GetIntField (Handle, notificationDefaults_jfieldId);
			}
			set {
				if (notificationDefaults_jfieldId == IntPtr.Zero)
					notificationDefaults_jfieldId = JNIEnv.GetFieldID (class_ref, "notificationDefaults", "I");
				try {
					JNIEnv.SetField (Handle, notificationDefaults_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr notificationFlags_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='BasicPushNotificationBuilder']/field[@name='notificationFlags']"
		[Register ("notificationFlags")]
		public int NotificationFlags {
			get {
				if (notificationFlags_jfieldId == IntPtr.Zero)
					notificationFlags_jfieldId = JNIEnv.GetFieldID (class_ref, "notificationFlags", "I");
				return JNIEnv.GetIntField (Handle, notificationFlags_jfieldId);
			}
			set {
				if (notificationFlags_jfieldId == IntPtr.Zero)
					notificationFlags_jfieldId = JNIEnv.GetFieldID (class_ref, "notificationFlags", "I");
				try {
					JNIEnv.SetField (Handle, notificationFlags_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr statusBarDrawable_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='BasicPushNotificationBuilder']/field[@name='statusBarDrawable']"
		[Register ("statusBarDrawable")]
		public int StatusBarDrawable {
			get {
				if (statusBarDrawable_jfieldId == IntPtr.Zero)
					statusBarDrawable_jfieldId = JNIEnv.GetFieldID (class_ref, "statusBarDrawable", "I");
				return JNIEnv.GetIntField (Handle, statusBarDrawable_jfieldId);
			}
			set {
				if (statusBarDrawable_jfieldId == IntPtr.Zero)
					statusBarDrawable_jfieldId = JNIEnv.GetFieldID (class_ref, "statusBarDrawable", "I");
				try {
					JNIEnv.SetField (Handle, statusBarDrawable_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("cn/jpush/android/api/BasicPushNotificationBuilder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BasicPushNotificationBuilder); }
		}

		protected BasicPushNotificationBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='BasicPushNotificationBuilder']/constructor[@name='BasicPushNotificationBuilder' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe BasicPushNotificationBuilder (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (BasicPushNotificationBuilder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='BasicPushNotificationBuilder']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Ljava/lang/String;", "")]
		public override sealed unsafe string A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_a), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
