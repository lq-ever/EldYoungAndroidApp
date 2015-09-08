using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nostra13.Universalimageloader.Cache.Memory.Impl {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.memory.impl']/class[@name='FuzzyKeyMemoryCache']"
	[global::Android.Runtime.Register ("com/nostra13/universalimageloader/cache/memory/impl/FuzzyKeyMemoryCache", DoNotGenerateAcw=true)]
	public partial class FuzzyKeyMemoryCache : global::Java.Lang.Object, global::Com.Nostra13.Universalimageloader.Cache.Memory.IMemoryCache {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nostra13/universalimageloader/cache/memory/impl/FuzzyKeyMemoryCache", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FuzzyKeyMemoryCache); }
		}

		protected FuzzyKeyMemoryCache (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_nostra13_universalimageloader_cache_memory_MemoryCache_Ljava_util_Comparator_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.memory.impl']/class[@name='FuzzyKeyMemoryCache']/constructor[@name='FuzzyKeyMemoryCache' and count(parameter)=2 and parameter[1][@type='com.nostra13.universalimageloader.cache.memory.MemoryCache'] and parameter[2][@type='java.util.Comparator&lt;java.lang.String&gt;']]"
		[Register (".ctor", "(Lcom/nostra13/universalimageloader/cache/memory/MemoryCache;Ljava/util/Comparator;)V", "")]
		public unsafe FuzzyKeyMemoryCache (global::Com.Nostra13.Universalimageloader.Cache.Memory.IMemoryCache p0, global::Java.Util.IComparator p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (FuzzyKeyMemoryCache)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/nostra13/universalimageloader/cache/memory/MemoryCache;Ljava/util/Comparator;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/nostra13/universalimageloader/cache/memory/MemoryCache;Ljava/util/Comparator;)V", __args);
					return;
				}

				if (id_ctor_Lcom_nostra13_universalimageloader_cache_memory_MemoryCache_Ljava_util_Comparator_ == IntPtr.Zero)
					id_ctor_Lcom_nostra13_universalimageloader_cache_memory_MemoryCache_Ljava_util_Comparator_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/nostra13/universalimageloader/cache/memory/MemoryCache;Ljava/util/Comparator;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_nostra13_universalimageloader_cache_memory_MemoryCache_Ljava_util_Comparator_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_nostra13_universalimageloader_cache_memory_MemoryCache_Ljava_util_Comparator_, __args);
			} finally {
			}
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Cache.Memory.Impl.FuzzyKeyMemoryCache __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Cache.Memory.Impl.FuzzyKeyMemoryCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.memory.impl']/class[@name='FuzzyKeyMemoryCache']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public virtual unsafe void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_clear);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clear", "()V"));
			} finally {
			}
		}

		static Delegate cb_get_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_lang_String_Handler ()
		{
			if (cb_get_Ljava_lang_String_ == null)
				cb_get_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Get_Ljava_lang_String_);
			return cb_get_Ljava_lang_String_;
		}

		static IntPtr n_Get_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nostra13.Universalimageloader.Cache.Memory.Impl.FuzzyKeyMemoryCache __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Cache.Memory.Impl.FuzzyKeyMemoryCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_get_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.memory.impl']/class[@name='FuzzyKeyMemoryCache']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;)Landroid/graphics/Bitmap;", "GetGet_Ljava_lang_String_Handler")]
		public virtual unsafe global::Android.Graphics.Bitmap Get (string p0)
		{
			if (id_get_Ljava_lang_String_ == IntPtr.Zero)
				id_get_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/String;)Landroid/graphics/Bitmap;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Android.Graphics.Bitmap __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod  (Handle, id_get_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(Ljava/lang/String;)Landroid/graphics/Bitmap;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_keys;
#pragma warning disable 0169
		static Delegate GetKeysHandler ()
		{
			if (cb_keys == null)
				cb_keys = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Keys);
			return cb_keys;
		}

		static IntPtr n_Keys (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Cache.Memory.Impl.FuzzyKeyMemoryCache __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Cache.Memory.Impl.FuzzyKeyMemoryCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaCollection<string>.ToLocalJniHandle (__this.Keys ());
		}
#pragma warning restore 0169

		static IntPtr id_keys;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.memory.impl']/class[@name='FuzzyKeyMemoryCache']/method[@name='keys' and count(parameter)=0]"
		[Register ("keys", "()Ljava/util/Collection;", "GetKeysHandler")]
		public virtual unsafe global::System.Collections.Generic.ICollection<string> Keys ()
		{
			if (id_keys == IntPtr.Zero)
				id_keys = JNIEnv.GetMethodID (class_ref, "keys", "()Ljava/util/Collection;");
			try {

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaCollection<string>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_keys), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaCollection<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "keys", "()Ljava/util/Collection;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_put_Ljava_lang_String_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_String_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_put_Ljava_lang_String_Landroid_graphics_Bitmap_ == null)
				cb_put_Ljava_lang_String_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Put_Ljava_lang_String_Landroid_graphics_Bitmap_);
			return cb_put_Ljava_lang_String_Landroid_graphics_Bitmap_;
		}

		static bool n_Put_Ljava_lang_String_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Nostra13.Universalimageloader.Cache.Memory.Impl.FuzzyKeyMemoryCache __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Cache.Memory.Impl.FuzzyKeyMemoryCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Put (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_put_Ljava_lang_String_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.memory.impl']/class[@name='FuzzyKeyMemoryCache']/method[@name='put' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.graphics.Bitmap']]"
		[Register ("put", "(Ljava/lang/String;Landroid/graphics/Bitmap;)Z", "GetPut_Ljava_lang_String_Landroid_graphics_Bitmap_Handler")]
		public virtual unsafe bool Put (string p0, global::Android.Graphics.Bitmap p1)
		{
			if (id_put_Ljava_lang_String_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_put_Ljava_lang_String_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "put", "(Ljava/lang/String;Landroid/graphics/Bitmap;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_put_Ljava_lang_String_Landroid_graphics_Bitmap_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "put", "(Ljava/lang/String;Landroid/graphics/Bitmap;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_remove_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemove_Ljava_lang_String_Handler ()
		{
			if (cb_remove_Ljava_lang_String_ == null)
				cb_remove_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Remove_Ljava_lang_String_);
			return cb_remove_Ljava_lang_String_;
		}

		static IntPtr n_Remove_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nostra13.Universalimageloader.Cache.Memory.Impl.FuzzyKeyMemoryCache __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Cache.Memory.Impl.FuzzyKeyMemoryCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Remove (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_remove_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.memory.impl']/class[@name='FuzzyKeyMemoryCache']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("remove", "(Ljava/lang/String;)Landroid/graphics/Bitmap;", "GetRemove_Ljava_lang_String_Handler")]
		public virtual unsafe global::Android.Graphics.Bitmap Remove (string p0)
		{
			if (id_remove_Ljava_lang_String_ == IntPtr.Zero)
				id_remove_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "remove", "(Ljava/lang/String;)Landroid/graphics/Bitmap;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Android.Graphics.Bitmap __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod  (Handle, id_remove_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "remove", "(Ljava/lang/String;)Landroid/graphics/Bitmap;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
