using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nostra13.Universalimageloader.Cache.Disc.Impl.Ext {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.impl.ext']/class[@name='LruDiskCache']"
	[global::Android.Runtime.Register ("com/nostra13/universalimageloader/cache/disc/impl/ext/LruDiskCache", DoNotGenerateAcw=true)]
	public partial class LruDiskCache : global::Java.Lang.Object, global::Com.Nostra13.Universalimageloader.Cache.Disc.IDiskCache {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.impl.ext']/class[@name='LruDiskCache']/field[@name='DEFAULT_BUFFER_SIZE']"
		[Register ("DEFAULT_BUFFER_SIZE")]
		public const int DefaultBufferSize = (int) 32768;

		static IntPtr DEFAULT_COMPRESS_FORMAT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.impl.ext']/class[@name='LruDiskCache']/field[@name='DEFAULT_COMPRESS_FORMAT']"
		[Register ("DEFAULT_COMPRESS_FORMAT")]
		public static global::Android.Graphics.Bitmap.CompressFormat DefaultCompressFormat {
			get {
				if (DEFAULT_COMPRESS_FORMAT_jfieldId == IntPtr.Zero)
					DEFAULT_COMPRESS_FORMAT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT_COMPRESS_FORMAT", "Landroid/graphics/Bitmap$CompressFormat;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEFAULT_COMPRESS_FORMAT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap.CompressFormat> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.impl.ext']/class[@name='LruDiskCache']/field[@name='DEFAULT_COMPRESS_QUALITY']"
		[Register ("DEFAULT_COMPRESS_QUALITY")]
		public const int DefaultCompressQuality = (int) 100;

		static IntPtr bufferSize_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.impl.ext']/class[@name='LruDiskCache']/field[@name='bufferSize']"
		[Register ("bufferSize")]
		protected int BufferSize {
			get {
				if (bufferSize_jfieldId == IntPtr.Zero)
					bufferSize_jfieldId = JNIEnv.GetFieldID (class_ref, "bufferSize", "I");
				return JNIEnv.GetIntField (Handle, bufferSize_jfieldId);
			}
			set {
				if (bufferSize_jfieldId == IntPtr.Zero)
					bufferSize_jfieldId = JNIEnv.GetFieldID (class_ref, "bufferSize", "I");
				try {
					JNIEnv.SetField (Handle, bufferSize_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr cache_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.impl.ext']/class[@name='LruDiskCache']/field[@name='cache']"
		[Register ("cache")]
		protected global::Com.Nostra13.Universalimageloader.Cache.Disc.Impl.Ext.DiskLruCache Cache {
			get {
				if (cache_jfieldId == IntPtr.Zero)
					cache_jfieldId = JNIEnv.GetFieldID (class_ref, "cache", "Lcom/nostra13/universalimageloader/cache/disc/impl/ext/DiskLruCache;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, cache_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Cache.Disc.Impl.Ext.DiskLruCache> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (cache_jfieldId == IntPtr.Zero)
					cache_jfieldId = JNIEnv.GetFieldID (class_ref, "cache", "Lcom/nostra13/universalimageloader/cache/disc/impl/ext/DiskLruCache;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, cache_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr compressFormat_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.impl.ext']/class[@name='LruDiskCache']/field[@name='compressFormat']"
		[Register ("compressFormat")]
		protected global::Android.Graphics.Bitmap.CompressFormat CompressFormat {
			get {
				if (compressFormat_jfieldId == IntPtr.Zero)
					compressFormat_jfieldId = JNIEnv.GetFieldID (class_ref, "compressFormat", "Landroid/graphics/Bitmap$CompressFormat;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, compressFormat_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap.CompressFormat> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (compressFormat_jfieldId == IntPtr.Zero)
					compressFormat_jfieldId = JNIEnv.GetFieldID (class_ref, "compressFormat", "Landroid/graphics/Bitmap$CompressFormat;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, compressFormat_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr compressQuality_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.impl.ext']/class[@name='LruDiskCache']/field[@name='compressQuality']"
		[Register ("compressQuality")]
		protected int CompressQuality {
			get {
				if (compressQuality_jfieldId == IntPtr.Zero)
					compressQuality_jfieldId = JNIEnv.GetFieldID (class_ref, "compressQuality", "I");
				return JNIEnv.GetIntField (Handle, compressQuality_jfieldId);
			}
			set {
				if (compressQuality_jfieldId == IntPtr.Zero)
					compressQuality_jfieldId = JNIEnv.GetFieldID (class_ref, "compressQuality", "I");
				try {
					JNIEnv.SetField (Handle, compressQuality_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr fileNameGenerator_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.impl.ext']/class[@name='LruDiskCache']/field[@name='fileNameGenerator']"
		[Register ("fileNameGenerator")]
		protected global::Com.Nostra13.Universalimageloader.Cache.Disc.Naming.IFileNameGenerator FileNameGenerator {
			get {
				if (fileNameGenerator_jfieldId == IntPtr.Zero)
					fileNameGenerator_jfieldId = JNIEnv.GetFieldID (class_ref, "fileNameGenerator", "Lcom/nostra13/universalimageloader/cache/disc/naming/FileNameGenerator;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, fileNameGenerator_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Cache.Disc.Naming.IFileNameGenerator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (fileNameGenerator_jfieldId == IntPtr.Zero)
					fileNameGenerator_jfieldId = JNIEnv.GetFieldID (class_ref, "fileNameGenerator", "Lcom/nostra13/universalimageloader/cache/disc/naming/FileNameGenerator;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, fileNameGenerator_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nostra13/universalimageloader/cache/disc/impl/ext/LruDiskCache", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LruDiskCache); }
		}

		protected LruDiskCache (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_io_File_Lcom_nostra13_universalimageloader_cache_disc_naming_FileNameGenerator_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.impl.ext']/class[@name='LruDiskCache']/constructor[@name='LruDiskCache' and count(parameter)=3 and parameter[1][@type='java.io.File'] and parameter[2][@type='com.nostra13.universalimageloader.cache.disc.naming.FileNameGenerator'] and parameter[3][@type='long']]"
		[Register (".ctor", "(Ljava/io/File;Lcom/nostra13/universalimageloader/cache/disc/naming/FileNameGenerator;J)V", "")]
		public unsafe LruDiskCache (global::Java.IO.File p0, global::Com.Nostra13.Universalimageloader.Cache.Disc.Naming.IFileNameGenerator p1, long p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (LruDiskCache)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/io/File;Lcom/nostra13/universalimageloader/cache/disc/naming/FileNameGenerator;J)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/io/File;Lcom/nostra13/universalimageloader/cache/disc/naming/FileNameGenerator;J)V", __args);
					return;
				}

				if (id_ctor_Ljava_io_File_Lcom_nostra13_universalimageloader_cache_disc_naming_FileNameGenerator_J == IntPtr.Zero)
					id_ctor_Ljava_io_File_Lcom_nostra13_universalimageloader_cache_disc_naming_FileNameGenerator_J = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/File;Lcom/nostra13/universalimageloader/cache/disc/naming/FileNameGenerator;J)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_File_Lcom_nostra13_universalimageloader_cache_disc_naming_FileNameGenerator_J, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_io_File_Lcom_nostra13_universalimageloader_cache_disc_naming_FileNameGenerator_J, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_io_File_Ljava_io_File_Lcom_nostra13_universalimageloader_cache_disc_naming_FileNameGenerator_JI;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.impl.ext']/class[@name='LruDiskCache']/constructor[@name='LruDiskCache' and count(parameter)=5 and parameter[1][@type='java.io.File'] and parameter[2][@type='java.io.File'] and parameter[3][@type='com.nostra13.universalimageloader.cache.disc.naming.FileNameGenerator'] and parameter[4][@type='long'] and parameter[5][@type='int']]"
		[Register (".ctor", "(Ljava/io/File;Ljava/io/File;Lcom/nostra13/universalimageloader/cache/disc/naming/FileNameGenerator;JI)V", "")]
		public unsafe LruDiskCache (global::Java.IO.File p0, global::Java.IO.File p1, global::Com.Nostra13.Universalimageloader.Cache.Disc.Naming.IFileNameGenerator p2, long p3, int p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				if (GetType () != typeof (LruDiskCache)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/io/File;Ljava/io/File;Lcom/nostra13/universalimageloader/cache/disc/naming/FileNameGenerator;JI)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/io/File;Ljava/io/File;Lcom/nostra13/universalimageloader/cache/disc/naming/FileNameGenerator;JI)V", __args);
					return;
				}

				if (id_ctor_Ljava_io_File_Ljava_io_File_Lcom_nostra13_universalimageloader_cache_disc_naming_FileNameGenerator_JI == IntPtr.Zero)
					id_ctor_Ljava_io_File_Ljava_io_File_Lcom_nostra13_universalimageloader_cache_disc_naming_FileNameGenerator_JI = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/File;Ljava/io/File;Lcom/nostra13/universalimageloader/cache/disc/naming/FileNameGenerator;JI)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_File_Ljava_io_File_Lcom_nostra13_universalimageloader_cache_disc_naming_FileNameGenerator_JI, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_io_File_Ljava_io_File_Lcom_nostra13_universalimageloader_cache_disc_naming_FileNameGenerator_JI, __args);
			} finally {
			}
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
			global::Com.Nostra13.Universalimageloader.Cache.Disc.Impl.Ext.LruDiskCache __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Cache.Disc.Impl.Ext.LruDiskCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Directory);
		}
#pragma warning restore 0169

		static IntPtr id_getDirectory;
		public virtual unsafe global::Java.IO.File Directory {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.impl.ext']/class[@name='LruDiskCache']/method[@name='getDirectory' and count(parameter)=0]"
			[Register ("getDirectory", "()Ljava/io/File;", "GetGetDirectoryHandler")]
			get {
				if (id_getDirectory == IntPtr.Zero)
					id_getDirectory = JNIEnv.GetMethodID (class_ref, "getDirectory", "()Ljava/io/File;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallObjectMethod  (Handle, id_getDirectory), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDirectory", "()Ljava/io/File;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Com.Nostra13.Universalimageloader.Cache.Disc.Impl.Ext.LruDiskCache __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Cache.Disc.Impl.Ext.LruDiskCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.impl.ext']/class[@name='LruDiskCache']/method[@name='clear' and count(parameter)=0]"
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
			global::Com.Nostra13.Universalimageloader.Cache.Disc.Impl.Ext.LruDiskCache __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Cache.Disc.Impl.Ext.LruDiskCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.impl.ext']/class[@name='LruDiskCache']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual unsafe void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_close);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "close", "()V"));
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
			global::Com.Nostra13.Universalimageloader.Cache.Disc.Impl.Ext.LruDiskCache __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Cache.Disc.Impl.Ext.LruDiskCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_get_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.impl.ext']/class[@name='LruDiskCache']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;)Ljava/io/File;", "GetGet_Ljava_lang_String_Handler")]
		public virtual unsafe global::Java.IO.File Get (string p0)
		{
			if (id_get_Ljava_lang_String_ == IntPtr.Zero)
				id_get_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/String;)Ljava/io/File;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Java.IO.File __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallObjectMethod  (Handle, id_get_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(Ljava/lang/String;)Ljava/io/File;"), __args), JniHandleOwnership.TransferLocalRef);
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
				cb_remove_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Remove_Ljava_lang_String_);
			return cb_remove_Ljava_lang_String_;
		}

		static bool n_Remove_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nostra13.Universalimageloader.Cache.Disc.Impl.Ext.LruDiskCache __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Cache.Disc.Impl.Ext.LruDiskCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Remove (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_remove_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.impl.ext']/class[@name='LruDiskCache']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("remove", "(Ljava/lang/String;)Z", "GetRemove_Ljava_lang_String_Handler")]
		public virtual unsafe bool Remove (string p0)
		{
			if (id_remove_Ljava_lang_String_ == IntPtr.Zero)
				id_remove_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "remove", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_remove_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "remove", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
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
			global::Com.Nostra13.Universalimageloader.Cache.Disc.Impl.Ext.LruDiskCache __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Cache.Disc.Impl.Ext.LruDiskCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Save (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_save_Ljava_lang_String_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.impl.ext']/class[@name='LruDiskCache']/method[@name='save' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.graphics.Bitmap']]"
		[Register ("save", "(Ljava/lang/String;Landroid/graphics/Bitmap;)Z", "GetSave_Ljava_lang_String_Landroid_graphics_Bitmap_Handler")]
		public virtual unsafe bool Save (string p0, global::Android.Graphics.Bitmap p1)
		{
			if (id_save_Ljava_lang_String_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_save_Ljava_lang_String_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "save", "(Ljava/lang/String;Landroid/graphics/Bitmap;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_save_Ljava_lang_String_Landroid_graphics_Bitmap_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "save", "(Ljava/lang/String;Landroid/graphics/Bitmap;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
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
			global::Com.Nostra13.Universalimageloader.Cache.Disc.Impl.Ext.LruDiskCache __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Cache.Disc.Impl.Ext.LruDiskCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p1 = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Nostra13.Universalimageloader.Utils.IoUtils.ICopyListener p2 = (global::Com.Nostra13.Universalimageloader.Utils.IoUtils.ICopyListener)global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Utils.IoUtils.ICopyListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Save (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_save_Ljava_lang_String_Ljava_io_InputStream_Lcom_nostra13_universalimageloader_utils_IoUtils_CopyListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.impl.ext']/class[@name='LruDiskCache']/method[@name='save' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.io.InputStream'] and parameter[3][@type='com.nostra13.universalimageloader.utils.IoUtils.CopyListener']]"
		[Register ("save", "(Ljava/lang/String;Ljava/io/InputStream;Lcom/nostra13/universalimageloader/utils/IoUtils$CopyListener;)Z", "GetSave_Ljava_lang_String_Ljava_io_InputStream_Lcom_nostra13_universalimageloader_utils_IoUtils_CopyListener_Handler")]
		public virtual unsafe bool Save (string p0, global::System.IO.Stream p1, global::Com.Nostra13.Universalimageloader.Utils.IoUtils.ICopyListener p2)
		{
			if (id_save_Ljava_lang_String_Ljava_io_InputStream_Lcom_nostra13_universalimageloader_utils_IoUtils_CopyListener_ == IntPtr.Zero)
				id_save_Ljava_lang_String_Ljava_io_InputStream_Lcom_nostra13_universalimageloader_utils_IoUtils_CopyListener_ = JNIEnv.GetMethodID (class_ref, "save", "(Ljava/lang/String;Ljava/io/InputStream;Lcom/nostra13/universalimageloader/utils/IoUtils$CopyListener;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_save_Ljava_lang_String_Ljava_io_InputStream_Lcom_nostra13_universalimageloader_utils_IoUtils_CopyListener_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "save", "(Ljava/lang/String;Ljava/io/InputStream;Lcom/nostra13/universalimageloader/utils/IoUtils$CopyListener;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_setBufferSize_I;
#pragma warning disable 0169
		static Delegate GetSetBufferSize_IHandler ()
		{
			if (cb_setBufferSize_I == null)
				cb_setBufferSize_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetBufferSize_I);
			return cb_setBufferSize_I;
		}

		static void n_SetBufferSize_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Nostra13.Universalimageloader.Cache.Disc.Impl.Ext.LruDiskCache __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Cache.Disc.Impl.Ext.LruDiskCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetBufferSize (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setBufferSize_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.impl.ext']/class[@name='LruDiskCache']/method[@name='setBufferSize' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setBufferSize", "(I)V", "GetSetBufferSize_IHandler")]
		public virtual unsafe void SetBufferSize (int p0)
		{
			if (id_setBufferSize_I == IntPtr.Zero)
				id_setBufferSize_I = JNIEnv.GetMethodID (class_ref, "setBufferSize", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setBufferSize_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBufferSize", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setCompressFormat_Landroid_graphics_Bitmap_CompressFormat_;
#pragma warning disable 0169
		static Delegate GetSetCompressFormat_Landroid_graphics_Bitmap_CompressFormat_Handler ()
		{
			if (cb_setCompressFormat_Landroid_graphics_Bitmap_CompressFormat_ == null)
				cb_setCompressFormat_Landroid_graphics_Bitmap_CompressFormat_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCompressFormat_Landroid_graphics_Bitmap_CompressFormat_);
			return cb_setCompressFormat_Landroid_graphics_Bitmap_CompressFormat_;
		}

		static void n_SetCompressFormat_Landroid_graphics_Bitmap_CompressFormat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nostra13.Universalimageloader.Cache.Disc.Impl.Ext.LruDiskCache __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Cache.Disc.Impl.Ext.LruDiskCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap.CompressFormat p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap.CompressFormat> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetCompressFormat (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setCompressFormat_Landroid_graphics_Bitmap_CompressFormat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.impl.ext']/class[@name='LruDiskCache']/method[@name='setCompressFormat' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap.CompressFormat']]"
		[Register ("setCompressFormat", "(Landroid/graphics/Bitmap$CompressFormat;)V", "GetSetCompressFormat_Landroid_graphics_Bitmap_CompressFormat_Handler")]
		public virtual unsafe void SetCompressFormat (global::Android.Graphics.Bitmap.CompressFormat p0)
		{
			if (id_setCompressFormat_Landroid_graphics_Bitmap_CompressFormat_ == IntPtr.Zero)
				id_setCompressFormat_Landroid_graphics_Bitmap_CompressFormat_ = JNIEnv.GetMethodID (class_ref, "setCompressFormat", "(Landroid/graphics/Bitmap$CompressFormat;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setCompressFormat_Landroid_graphics_Bitmap_CompressFormat_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCompressFormat", "(Landroid/graphics/Bitmap$CompressFormat;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setCompressQuality_I;
#pragma warning disable 0169
		static Delegate GetSetCompressQuality_IHandler ()
		{
			if (cb_setCompressQuality_I == null)
				cb_setCompressQuality_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetCompressQuality_I);
			return cb_setCompressQuality_I;
		}

		static void n_SetCompressQuality_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Nostra13.Universalimageloader.Cache.Disc.Impl.Ext.LruDiskCache __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Cache.Disc.Impl.Ext.LruDiskCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCompressQuality (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setCompressQuality_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.impl.ext']/class[@name='LruDiskCache']/method[@name='setCompressQuality' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setCompressQuality", "(I)V", "GetSetCompressQuality_IHandler")]
		public virtual unsafe void SetCompressQuality (int p0)
		{
			if (id_setCompressQuality_I == IntPtr.Zero)
				id_setCompressQuality_I = JNIEnv.GetMethodID (class_ref, "setCompressQuality", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setCompressQuality_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCompressQuality", "(I)V"), __args);
			} finally {
			}
		}

	}
}
