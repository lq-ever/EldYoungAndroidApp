using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nostra13.Universalimageloader.Core.Assist {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='LoadedFrom']"
	[global::Android.Runtime.Register ("com/nostra13/universalimageloader/core/assist/LoadedFrom", DoNotGenerateAcw=true)]
	public sealed partial class LoadedFrom : global::Java.Lang.Enum {


		static IntPtr DISC_CACHE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='LoadedFrom']/field[@name='DISC_CACHE']"
		[Register ("DISC_CACHE")]
		public static global::Com.Nostra13.Universalimageloader.Core.Assist.LoadedFrom DiscCache {
			get {
				if (DISC_CACHE_jfieldId == IntPtr.Zero)
					DISC_CACHE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DISC_CACHE", "Lcom/nostra13/universalimageloader/core/assist/LoadedFrom;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DISC_CACHE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.LoadedFrom> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr MEMORY_CACHE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='LoadedFrom']/field[@name='MEMORY_CACHE']"
		[Register ("MEMORY_CACHE")]
		public static global::Com.Nostra13.Universalimageloader.Core.Assist.LoadedFrom MemoryCache {
			get {
				if (MEMORY_CACHE_jfieldId == IntPtr.Zero)
					MEMORY_CACHE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MEMORY_CACHE", "Lcom/nostra13/universalimageloader/core/assist/LoadedFrom;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MEMORY_CACHE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.LoadedFrom> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr NETWORK_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='LoadedFrom']/field[@name='NETWORK']"
		[Register ("NETWORK")]
		public static global::Com.Nostra13.Universalimageloader.Core.Assist.LoadedFrom Network {
			get {
				if (NETWORK_jfieldId == IntPtr.Zero)
					NETWORK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NETWORK", "Lcom/nostra13/universalimageloader/core/assist/LoadedFrom;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NETWORK_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.LoadedFrom> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nostra13/universalimageloader/core/assist/LoadedFrom", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LoadedFrom); }
		}

		internal LoadedFrom (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='LoadedFrom']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/nostra13/universalimageloader/core/assist/LoadedFrom;", "")]
		public static unsafe global::Com.Nostra13.Universalimageloader.Core.Assist.LoadedFrom ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/nostra13/universalimageloader/core/assist/LoadedFrom;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Nostra13.Universalimageloader.Core.Assist.LoadedFrom __ret = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.LoadedFrom> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='LoadedFrom']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/nostra13/universalimageloader/core/assist/LoadedFrom;", "")]
		public static unsafe global::Com.Nostra13.Universalimageloader.Core.Assist.LoadedFrom[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/nostra13/universalimageloader/core/assist/LoadedFrom;");
			try {
				return (global::Com.Nostra13.Universalimageloader.Core.Assist.LoadedFrom[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Nostra13.Universalimageloader.Core.Assist.LoadedFrom));
			} finally {
			}
		}

	}
}
