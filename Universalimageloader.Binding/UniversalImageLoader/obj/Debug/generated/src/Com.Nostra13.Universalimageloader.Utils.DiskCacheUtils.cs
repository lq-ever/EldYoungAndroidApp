using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nostra13.Universalimageloader.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.utils']/class[@name='DiskCacheUtils']"
	[global::Android.Runtime.Register ("com/nostra13/universalimageloader/utils/DiskCacheUtils", DoNotGenerateAcw=true)]
	public sealed partial class DiskCacheUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nostra13/universalimageloader/utils/DiskCacheUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DiskCacheUtils); }
		}

		internal DiskCacheUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_findInCache_Ljava_lang_String_Lcom_nostra13_universalimageloader_cache_disc_DiskCache_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.utils']/class[@name='DiskCacheUtils']/method[@name='findInCache' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.nostra13.universalimageloader.cache.disc.DiskCache']]"
		[Register ("findInCache", "(Ljava/lang/String;Lcom/nostra13/universalimageloader/cache/disc/DiskCache;)Ljava/io/File;", "")]
		public static unsafe global::Java.IO.File FindInCache (string p0, global::Com.Nostra13.Universalimageloader.Cache.Disc.IDiskCache p1)
		{
			if (id_findInCache_Ljava_lang_String_Lcom_nostra13_universalimageloader_cache_disc_DiskCache_ == IntPtr.Zero)
				id_findInCache_Ljava_lang_String_Lcom_nostra13_universalimageloader_cache_disc_DiskCache_ = JNIEnv.GetStaticMethodID (class_ref, "findInCache", "(Ljava/lang/String;Lcom/nostra13/universalimageloader/cache/disc/DiskCache;)Ljava/io/File;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::Java.IO.File __ret = global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallStaticObjectMethod  (class_ref, id_findInCache_Ljava_lang_String_Lcom_nostra13_universalimageloader_cache_disc_DiskCache_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_removeFromCache_Ljava_lang_String_Lcom_nostra13_universalimageloader_cache_disc_DiskCache_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.utils']/class[@name='DiskCacheUtils']/method[@name='removeFromCache' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.nostra13.universalimageloader.cache.disc.DiskCache']]"
		[Register ("removeFromCache", "(Ljava/lang/String;Lcom/nostra13/universalimageloader/cache/disc/DiskCache;)Z", "")]
		public static unsafe bool RemoveFromCache (string p0, global::Com.Nostra13.Universalimageloader.Cache.Disc.IDiskCache p1)
		{
			if (id_removeFromCache_Ljava_lang_String_Lcom_nostra13_universalimageloader_cache_disc_DiskCache_ == IntPtr.Zero)
				id_removeFromCache_Ljava_lang_String_Lcom_nostra13_universalimageloader_cache_disc_DiskCache_ = JNIEnv.GetStaticMethodID (class_ref, "removeFromCache", "(Ljava/lang/String;Lcom/nostra13/universalimageloader/cache/disc/DiskCache;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_removeFromCache_Ljava_lang_String_Lcom_nostra13_universalimageloader_cache_disc_DiskCache_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
