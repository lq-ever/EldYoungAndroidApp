using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nostra13.Universalimageloader.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.utils']/class[@name='MemoryCacheUtils']"
	[global::Android.Runtime.Register ("com/nostra13/universalimageloader/utils/MemoryCacheUtils", DoNotGenerateAcw=true)]
	public sealed partial class MemoryCacheUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nostra13/universalimageloader/utils/MemoryCacheUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MemoryCacheUtils); }
		}

		internal MemoryCacheUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_createFuzzyKeyComparator;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.utils']/class[@name='MemoryCacheUtils']/method[@name='createFuzzyKeyComparator' and count(parameter)=0]"
		[Register ("createFuzzyKeyComparator", "()Ljava/util/Comparator;", "")]
		public static unsafe global::Java.Util.IComparator CreateFuzzyKeyComparator ()
		{
			if (id_createFuzzyKeyComparator == IntPtr.Zero)
				id_createFuzzyKeyComparator = JNIEnv.GetStaticMethodID (class_ref, "createFuzzyKeyComparator", "()Ljava/util/Comparator;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Util.IComparator> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createFuzzyKeyComparator), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_findCacheKeysForImageUri_Ljava_lang_String_Lcom_nostra13_universalimageloader_cache_memory_MemoryCache_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.utils']/class[@name='MemoryCacheUtils']/method[@name='findCacheKeysForImageUri' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.nostra13.universalimageloader.cache.memory.MemoryCache']]"
		[Register ("findCacheKeysForImageUri", "(Ljava/lang/String;Lcom/nostra13/universalimageloader/cache/memory/MemoryCache;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<string> FindCacheKeysForImageUri (string p0, global::Com.Nostra13.Universalimageloader.Cache.Memory.IMemoryCache p1)
		{
			if (id_findCacheKeysForImageUri_Ljava_lang_String_Lcom_nostra13_universalimageloader_cache_memory_MemoryCache_ == IntPtr.Zero)
				id_findCacheKeysForImageUri_Ljava_lang_String_Lcom_nostra13_universalimageloader_cache_memory_MemoryCache_ = JNIEnv.GetStaticMethodID (class_ref, "findCacheKeysForImageUri", "(Ljava/lang/String;Lcom/nostra13/universalimageloader/cache/memory/MemoryCache;)Ljava/util/List;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::System.Collections.Generic.IList<string> __ret = global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_findCacheKeysForImageUri_Ljava_lang_String_Lcom_nostra13_universalimageloader_cache_memory_MemoryCache_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_findCachedBitmapsForImageUri_Ljava_lang_String_Lcom_nostra13_universalimageloader_cache_memory_MemoryCache_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.utils']/class[@name='MemoryCacheUtils']/method[@name='findCachedBitmapsForImageUri' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.nostra13.universalimageloader.cache.memory.MemoryCache']]"
		[Register ("findCachedBitmapsForImageUri", "(Ljava/lang/String;Lcom/nostra13/universalimageloader/cache/memory/MemoryCache;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Android.Graphics.Bitmap> FindCachedBitmapsForImageUri (string p0, global::Com.Nostra13.Universalimageloader.Cache.Memory.IMemoryCache p1)
		{
			if (id_findCachedBitmapsForImageUri_Ljava_lang_String_Lcom_nostra13_universalimageloader_cache_memory_MemoryCache_ == IntPtr.Zero)
				id_findCachedBitmapsForImageUri_Ljava_lang_String_Lcom_nostra13_universalimageloader_cache_memory_MemoryCache_ = JNIEnv.GetStaticMethodID (class_ref, "findCachedBitmapsForImageUri", "(Ljava/lang/String;Lcom/nostra13/universalimageloader/cache/memory/MemoryCache;)Ljava/util/List;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::System.Collections.Generic.IList<global::Android.Graphics.Bitmap> __ret = global::Android.Runtime.JavaList<global::Android.Graphics.Bitmap>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_findCachedBitmapsForImageUri_Ljava_lang_String_Lcom_nostra13_universalimageloader_cache_memory_MemoryCache_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_generateKey_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.utils']/class[@name='MemoryCacheUtils']/method[@name='generateKey' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.nostra13.universalimageloader.core.assist.ImageSize']]"
		[Register ("generateKey", "(Ljava/lang/String;Lcom/nostra13/universalimageloader/core/assist/ImageSize;)Ljava/lang/String;", "")]
		public static unsafe string GenerateKey (string p0, global::Com.Nostra13.Universalimageloader.Core.Assist.ImageSize p1)
		{
			if (id_generateKey_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_ == IntPtr.Zero)
				id_generateKey_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_ = JNIEnv.GetStaticMethodID (class_ref, "generateKey", "(Ljava/lang/String;Lcom/nostra13/universalimageloader/core/assist/ImageSize;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_generateKey_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_removeFromCache_Ljava_lang_String_Lcom_nostra13_universalimageloader_cache_memory_MemoryCache_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.utils']/class[@name='MemoryCacheUtils']/method[@name='removeFromCache' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.nostra13.universalimageloader.cache.memory.MemoryCache']]"
		[Register ("removeFromCache", "(Ljava/lang/String;Lcom/nostra13/universalimageloader/cache/memory/MemoryCache;)V", "")]
		public static unsafe void RemoveFromCache (string p0, global::Com.Nostra13.Universalimageloader.Cache.Memory.IMemoryCache p1)
		{
			if (id_removeFromCache_Ljava_lang_String_Lcom_nostra13_universalimageloader_cache_memory_MemoryCache_ == IntPtr.Zero)
				id_removeFromCache_Ljava_lang_String_Lcom_nostra13_universalimageloader_cache_memory_MemoryCache_ = JNIEnv.GetStaticMethodID (class_ref, "removeFromCache", "(Ljava/lang/String;Lcom/nostra13/universalimageloader/cache/memory/MemoryCache;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_removeFromCache_Ljava_lang_String_Lcom_nostra13_universalimageloader_cache_memory_MemoryCache_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
