using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nostra13.Universalimageloader.Cache.Disc.Impl {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.impl']/class[@name='UnlimitedDiskCache']"
	[global::Android.Runtime.Register ("com/nostra13/universalimageloader/cache/disc/impl/UnlimitedDiskCache", DoNotGenerateAcw=true)]
	public partial class UnlimitedDiskCache : global::Com.Nostra13.Universalimageloader.Cache.Disc.Impl.BaseDiskCache {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nostra13/universalimageloader/cache/disc/impl/UnlimitedDiskCache", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UnlimitedDiskCache); }
		}

		protected UnlimitedDiskCache (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_io_File_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.impl']/class[@name='UnlimitedDiskCache']/constructor[@name='UnlimitedDiskCache' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register (".ctor", "(Ljava/io/File;)V", "")]
		public unsafe UnlimitedDiskCache (global::Java.IO.File p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (UnlimitedDiskCache)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/io/File;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/io/File;)V", __args);
					return;
				}

				if (id_ctor_Ljava_io_File_ == IntPtr.Zero)
					id_ctor_Ljava_io_File_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/File;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_File_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_io_File_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_io_File_Ljava_io_File_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.impl']/class[@name='UnlimitedDiskCache']/constructor[@name='UnlimitedDiskCache' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='java.io.File']]"
		[Register (".ctor", "(Ljava/io/File;Ljava/io/File;)V", "")]
		public unsafe UnlimitedDiskCache (global::Java.IO.File p0, global::Java.IO.File p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (UnlimitedDiskCache)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/io/File;Ljava/io/File;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/io/File;Ljava/io/File;)V", __args);
					return;
				}

				if (id_ctor_Ljava_io_File_Ljava_io_File_ == IntPtr.Zero)
					id_ctor_Ljava_io_File_Ljava_io_File_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/File;Ljava/io/File;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_File_Ljava_io_File_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_io_File_Ljava_io_File_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_io_File_Ljava_io_File_Lcom_nostra13_universalimageloader_cache_disc_naming_FileNameGenerator_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.impl']/class[@name='UnlimitedDiskCache']/constructor[@name='UnlimitedDiskCache' and count(parameter)=3 and parameter[1][@type='java.io.File'] and parameter[2][@type='java.io.File'] and parameter[3][@type='com.nostra13.universalimageloader.cache.disc.naming.FileNameGenerator']]"
		[Register (".ctor", "(Ljava/io/File;Ljava/io/File;Lcom/nostra13/universalimageloader/cache/disc/naming/FileNameGenerator;)V", "")]
		public unsafe UnlimitedDiskCache (global::Java.IO.File p0, global::Java.IO.File p1, global::Com.Nostra13.Universalimageloader.Cache.Disc.Naming.IFileNameGenerator p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (UnlimitedDiskCache)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/io/File;Ljava/io/File;Lcom/nostra13/universalimageloader/cache/disc/naming/FileNameGenerator;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/io/File;Ljava/io/File;Lcom/nostra13/universalimageloader/cache/disc/naming/FileNameGenerator;)V", __args);
					return;
				}

				if (id_ctor_Ljava_io_File_Ljava_io_File_Lcom_nostra13_universalimageloader_cache_disc_naming_FileNameGenerator_ == IntPtr.Zero)
					id_ctor_Ljava_io_File_Ljava_io_File_Lcom_nostra13_universalimageloader_cache_disc_naming_FileNameGenerator_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/File;Ljava/io/File;Lcom/nostra13/universalimageloader/cache/disc/naming/FileNameGenerator;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_File_Ljava_io_File_Lcom_nostra13_universalimageloader_cache_disc_naming_FileNameGenerator_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_io_File_Ljava_io_File_Lcom_nostra13_universalimageloader_cache_disc_naming_FileNameGenerator_, __args);
			} finally {
			}
		}

	}
}
