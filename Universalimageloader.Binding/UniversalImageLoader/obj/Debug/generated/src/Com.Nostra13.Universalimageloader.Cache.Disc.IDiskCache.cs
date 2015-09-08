using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nostra13.Universalimageloader.Cache.Disc {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc']/interface[@name='DiskCache']"
	[Register ("com/nostra13/universalimageloader/cache/disc/DiskCache", "", "Com.Nostra13.Universalimageloader.Cache.Disc.IDiskCacheInvoker")]
	public partial interface IDiskCache : IJavaObject {

		global::Java.IO.File Directory {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc']/interface[@name='DiskCache']/method[@name='getDirectory' and count(parameter)=0]"
			[Register ("getDirectory", "()Ljava/io/File;", "GetGetDirectoryHandler:Com.Nostra13.Universalimageloader.Cache.Disc.IDiskCacheInvoker, UniversalImageLoader")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc']/interface[@name='DiskCache']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler:Com.Nostra13.Universalimageloader.Cache.Disc.IDiskCacheInvoker, UniversalImageLoader")]
		void Clear ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc']/interface[@name='DiskCache']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler:Com.Nostra13.Universalimageloader.Cache.Disc.IDiskCacheInvoker, UniversalImageLoader")]
		void Close ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc']/interface[@name='DiskCache']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;)Ljava/io/File;", "GetGet_Ljava_lang_String_Handler:Com.Nostra13.Universalimageloader.Cache.Disc.IDiskCacheInvoker, UniversalImageLoader")]
		global::Java.IO.File Get (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc']/interface[@name='DiskCache']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("remove", "(Ljava/lang/String;)Z", "GetRemove_Ljava_lang_String_Handler:Com.Nostra13.Universalimageloader.Cache.Disc.IDiskCacheInvoker, UniversalImageLoader")]
		bool Remove (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc']/interface[@name='DiskCache']/method[@name='save' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.graphics.Bitmap']]"
		[Register ("save", "(Ljava/lang/String;Landroid/graphics/Bitmap;)Z", "GetSave_Ljava_lang_String_Landroid_graphics_Bitmap_Handler:Com.Nostra13.Universalimageloader.Cache.Disc.IDiskCacheInvoker, UniversalImageLoader")]
		bool Save (string p0, global::Android.Graphics.Bitmap p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc']/interface[@name='DiskCache']/method[@name='save' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.io.InputStream'] and parameter[3][@type='com.nostra13.universalimageloader.utils.IoUtils.CopyListener']]"
		[Register ("save", "(Ljava/lang/String;Ljava/io/InputStream;Lcom/nostra13/universalimageloader/utils/IoUtils$CopyListener;)Z", "GetSave_Ljava_lang_String_Ljava_io_InputStream_Lcom_nostra13_universalimageloader_utils_IoUtils_CopyListener_Handler:Com.Nostra13.Universalimageloader.Cache.Disc.IDiskCacheInvoker, UniversalImageLoader")]
		bool Save (string p0, global::System.IO.Stream p1, global::Com.Nostra13.Universalimageloader.Utils.IoUtils.ICopyListener p2);

	}

	[global::Android.Runtime.Register ("com/nostra13/universalimageloader/cache/disc/DiskCache", DoNotGenerateAcw=true)]
	internal class IDiskCacheInvoker : global::Java.Lang.Object, IDiskCache {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/nostra13/universalimageloader/cache/disc/DiskCache");
		IntPtr class_ref;

		public static IDiskCache GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDiskCache> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.nostra13.universalimageloader.cache.disc.DiskCache"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDiskCacheInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IDiskCacheInvoker); }
		}

		static Delegate cb_getDirectory;
#pragma warning disable 0169
		static Delegate GetGetDirectoryHandler ()
		{
			if (cb_getDirectory == null)
				cb_getDirectory = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDirectory);
			return cb_getDirectory;
		}

		static IntPtr n_GetDirectory (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Cache.Disc.IDiskCache __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Cache.Disc.IDiskCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Directory);
		}
#pragma warning restore 0169

		IntPtr id_getDirectory;
		public unsafe global::Java.IO.File Directory {
			get {
				if (id_getDirectory == IntPtr.Zero)
					id_getDirectory = JNIEnv.GetMethodID (class_ref, "getDirectory", "()Ljava/io/File;");
				return global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallObjectMethod (Handle, id_getDirectory), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Nostra13.Universalimageloader.Cache.Disc.IDiskCache __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Cache.Disc.IDiskCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Cache.Disc.IDiskCache __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Cache.Disc.IDiskCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		IntPtr id_close;
		public unsafe void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			JNIEnv.CallVoidMethod (Handle, id_close);
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
			global::Com.Nostra13.Universalimageloader.Cache.Disc.IDiskCache __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Cache.Disc.IDiskCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_get_Ljava_lang_String_;
		public unsafe global::Java.IO.File Get (string p0)
		{
			if (id_get_Ljava_lang_String_ == IntPtr.Zero)
				id_get_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/String;)Ljava/io/File;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Java.IO.File __ret = global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallObjectMethod (Handle, id_get_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_remove_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemove_Ljava_lang_String_Handler ()
		{
			if (cb_remove_Ljava_lang_String_ == null)
				cb_remove_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Remove_Ljava_lang_String_);
			return cb_remove_Ljava_lang_String_;
		}

		static bool n_Remove_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nostra13.Universalimageloader.Cache.Disc.IDiskCache __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Cache.Disc.IDiskCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Remove (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_remove_Ljava_lang_String_;
		public unsafe bool Remove (string p0)
		{
			if (id_remove_Ljava_lang_String_ == IntPtr.Zero)
				id_remove_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "remove", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_remove_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_save_Ljava_lang_String_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetSave_Ljava_lang_String_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_save_Ljava_lang_String_Landroid_graphics_Bitmap_ == null)
				cb_save_Ljava_lang_String_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Save_Ljava_lang_String_Landroid_graphics_Bitmap_);
			return cb_save_Ljava_lang_String_Landroid_graphics_Bitmap_;
		}

		static bool n_Save_Ljava_lang_String_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Nostra13.Universalimageloader.Cache.Disc.IDiskCache __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Cache.Disc.IDiskCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Save (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_save_Ljava_lang_String_Landroid_graphics_Bitmap_;
		public unsafe bool Save (string p0, global::Android.Graphics.Bitmap p1)
		{
			if (id_save_Ljava_lang_String_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_save_Ljava_lang_String_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "save", "(Ljava/lang/String;Landroid/graphics/Bitmap;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_save_Ljava_lang_String_Landroid_graphics_Bitmap_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_save_Ljava_lang_String_Ljava_io_InputStream_Lcom_nostra13_universalimageloader_utils_IoUtils_CopyListener_;
#pragma warning disable 0169
		static Delegate GetSave_Ljava_lang_String_Ljava_io_InputStream_Lcom_nostra13_universalimageloader_utils_IoUtils_CopyListener_Handler ()
		{
			if (cb_save_Ljava_lang_String_Ljava_io_InputStream_Lcom_nostra13_universalimageloader_utils_IoUtils_CopyListener_ == null)
				cb_save_Ljava_lang_String_Ljava_io_InputStream_Lcom_nostra13_universalimageloader_utils_IoUtils_CopyListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Save_Ljava_lang_String_Ljava_io_InputStream_Lcom_nostra13_universalimageloader_utils_IoUtils_CopyListener_);
			return cb_save_Ljava_lang_String_Ljava_io_InputStream_Lcom_nostra13_universalimageloader_utils_IoUtils_CopyListener_;
		}

		static bool n_Save_Ljava_lang_String_Ljava_io_InputStream_Lcom_nostra13_universalimageloader_utils_IoUtils_CopyListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Nostra13.Universalimageloader.Cache.Disc.IDiskCache __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Cache.Disc.IDiskCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p1 = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Nostra13.Universalimageloader.Utils.IoUtils.ICopyListener p2 = (global::Com.Nostra13.Universalimageloader.Utils.IoUtils.ICopyListener)global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Utils.IoUtils.ICopyListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Save (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_save_Ljava_lang_String_Ljava_io_InputStream_Lcom_nostra13_universalimageloader_utils_IoUtils_CopyListener_;
		public unsafe bool Save (string p0, global::System.IO.Stream p1, global::Com.Nostra13.Universalimageloader.Utils.IoUtils.ICopyListener p2)
		{
			if (id_save_Ljava_lang_String_Ljava_io_InputStream_Lcom_nostra13_universalimageloader_utils_IoUtils_CopyListener_ == IntPtr.Zero)
				id_save_Ljava_lang_String_Ljava_io_InputStream_Lcom_nostra13_universalimageloader_utils_IoUtils_CopyListener_ = JNIEnv.GetMethodID (class_ref, "save", "(Ljava/lang/String;Ljava/io/InputStream;Lcom/nostra13/universalimageloader/utils/IoUtils$CopyListener;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_save_Ljava_lang_String_Ljava_io_InputStream_Lcom_nostra13_universalimageloader_utils_IoUtils_CopyListener_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

	}

}
