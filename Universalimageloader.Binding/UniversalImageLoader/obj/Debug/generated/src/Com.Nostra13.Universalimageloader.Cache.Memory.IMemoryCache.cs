using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nostra13.Universalimageloader.Cache.Memory {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.memory']/interface[@name='MemoryCache']"
	[Register ("com/nostra13/universalimageloader/cache/memory/MemoryCache", "", "Com.Nostra13.Universalimageloader.Cache.Memory.IMemoryCacheInvoker")]
	public partial interface IMemoryCache : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.memory']/interface[@name='MemoryCache']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler:Com.Nostra13.Universalimageloader.Cache.Memory.IMemoryCacheInvoker, UniversalImageLoader")]
		void Clear ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.memory']/interface[@name='MemoryCache']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;)Landroid/graphics/Bitmap;", "GetGet_Ljava_lang_String_Handler:Com.Nostra13.Universalimageloader.Cache.Memory.IMemoryCacheInvoker, UniversalImageLoader")]
		global::Android.Graphics.Bitmap Get (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.memory']/interface[@name='MemoryCache']/method[@name='keys' and count(parameter)=0]"
		[Register ("keys", "()Ljava/util/Collection;", "GetKeysHandler:Com.Nostra13.Universalimageloader.Cache.Memory.IMemoryCacheInvoker, UniversalImageLoader")]
		global::System.Collections.Generic.ICollection<string> Keys ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.memory']/interface[@name='MemoryCache']/method[@name='put' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.graphics.Bitmap']]"
		[Register ("put", "(Ljava/lang/String;Landroid/graphics/Bitmap;)Z", "GetPut_Ljava_lang_String_Landroid_graphics_Bitmap_Handler:Com.Nostra13.Universalimageloader.Cache.Memory.IMemoryCacheInvoker, UniversalImageLoader")]
		bool Put (string p0, global::Android.Graphics.Bitmap p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.memory']/interface[@name='MemoryCache']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("remove", "(Ljava/lang/String;)Landroid/graphics/Bitmap;", "GetRemove_Ljava_lang_String_Handler:Com.Nostra13.Universalimageloader.Cache.Memory.IMemoryCacheInvoker, UniversalImageLoader")]
		global::Android.Graphics.Bitmap Remove (string p0);

	}

	[global::Android.Runtime.Register ("com/nostra13/universalimageloader/cache/memory/MemoryCache", DoNotGenerateAcw=true)]
	internal class IMemoryCacheInvoker : global::Java.Lang.Object, IMemoryCache {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/nostra13/universalimageloader/cache/memory/MemoryCache");
		IntPtr class_ref;

		public static IMemoryCache GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMemoryCache> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.nostra13.universalimageloader.cache.memory.MemoryCache"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMemoryCacheInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMemoryCacheInvoker); }
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
			global::Com.Nostra13.Universalimageloader.Cache.Memory.IMemoryCache __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Cache.Memory.IMemoryCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		IntPtr id_clear;
		public unsafe void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			JNIEnv.CallVoidMethod (Handle, id_clear);
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
			global::Com.Nostra13.Universalimageloader.Cache.Memory.IMemoryCache __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Cache.Memory.IMemoryCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_get_Ljava_lang_String_;
		public unsafe global::Android.Graphics.Bitmap Get (string p0)
		{
			if (id_get_Ljava_lang_String_ == IntPtr.Zero)
				id_get_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/String;)Landroid/graphics/Bitmap;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Android.Graphics.Bitmap __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod (Handle, id_get_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
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
			global::Com.Nostra13.Universalimageloader.Cache.Memory.IMemoryCache __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Cache.Memory.IMemoryCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaCollection<string>.ToLocalJniHandle (__this.Keys ());
		}
#pragma warning restore 0169

		IntPtr id_keys;
		public unsafe global::System.Collections.Generic.ICollection<string> Keys ()
		{
			if (id_keys == IntPtr.Zero)
				id_keys = JNIEnv.GetMethodID (class_ref, "keys", "()Ljava/util/Collection;");
			return global::Android.Runtime.JavaCollection<string>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_keys), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Nostra13.Universalimageloader.Cache.Memory.IMemoryCache __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Cache.Memory.IMemoryCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Put (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_put_Ljava_lang_String_Landroid_graphics_Bitmap_;
		public unsafe bool Put (string p0, global::Android.Graphics.Bitmap p1)
		{
			if (id_put_Ljava_lang_String_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_put_Ljava_lang_String_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "put", "(Ljava/lang/String;Landroid/graphics/Bitmap;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_put_Ljava_lang_String_Landroid_graphics_Bitmap_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
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
			global::Com.Nostra13.Universalimageloader.Cache.Memory.IMemoryCache __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Cache.Memory.IMemoryCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Remove (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_remove_Ljava_lang_String_;
		public unsafe global::Android.Graphics.Bitmap Remove (string p0)
		{
			if (id_remove_Ljava_lang_String_ == IntPtr.Zero)
				id_remove_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "remove", "(Ljava/lang/String;)Landroid/graphics/Bitmap;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Android.Graphics.Bitmap __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod (Handle, id_remove_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
