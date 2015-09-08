using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nostra13.Universalimageloader.Cache.Disc.Impl {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.impl']/class[@name='LimitedAgeDiskCache']"
	[global::Android.Runtime.Register ("com/nostra13/universalimageloader/cache/disc/impl/LimitedAgeDiskCache", DoNotGenerateAcw=true)]
	public partial class LimitedAgeDiskCache : global::Com.Nostra13.Universalimageloader.Cache.Disc.Impl.BaseDiskCache {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nostra13/universalimageloader/cache/disc/impl/LimitedAgeDiskCache", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LimitedAgeDiskCache); }
		}

		protected LimitedAgeDiskCache (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_io_File_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.impl']/class[@name='LimitedAgeDiskCache']/constructor[@name='LimitedAgeDiskCache' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='long']]"
		[Register (".ctor", "(Ljava/io/File;J)V", "")]
		public unsafe LimitedAgeDiskCache (global::Java.IO.File p0, long p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (LimitedAgeDiskCache)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/io/File;J)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/io/File;J)V", __args);
					return;
				}

				if (id_ctor_Ljava_io_File_J == IntPtr.Zero)
					id_ctor_Ljava_io_File_J = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/File;J)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_File_J, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_io_File_J, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_io_File_Ljava_io_File_Lcom_nostra13_universalimageloader_cache_disc_naming_FileNameGenerator_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.impl']/class[@name='LimitedAgeDiskCache']/constructor[@name='LimitedAgeDiskCache' and count(parameter)=4 and parameter[1][@type='java.io.File'] and parameter[2][@type='java.io.File'] and parameter[3][@type='com.nostra13.universalimageloader.cache.disc.naming.FileNameGenerator'] and parameter[4][@type='long']]"
		[Register (".ctor", "(Ljava/io/File;Ljava/io/File;Lcom/nostra13/universalimageloader/cache/disc/naming/FileNameGenerator;J)V", "")]
		public unsafe LimitedAgeDiskCache (global::Java.IO.File p0, global::Java.IO.File p1, global::Com.Nostra13.Universalimageloader.Cache.Disc.Naming.IFileNameGenerator p2, long p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				if (GetType () != typeof (LimitedAgeDiskCache)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/io/File;Ljava/io/File;Lcom/nostra13/universalimageloader/cache/disc/naming/FileNameGenerator;J)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/io/File;Ljava/io/File;Lcom/nostra13/universalimageloader/cache/disc/naming/FileNameGenerator;J)V", __args);
					return;
				}

				if (id_ctor_Ljava_io_File_Ljava_io_File_Lcom_nostra13_universalimageloader_cache_disc_naming_FileNameGenerator_J == IntPtr.Zero)
					id_ctor_Ljava_io_File_Ljava_io_File_Lcom_nostra13_universalimageloader_cache_disc_naming_FileNameGenerator_J = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/File;Ljava/io/File;Lcom/nostra13/universalimageloader/cache/disc/naming/FileNameGenerator;J)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_File_Ljava_io_File_Lcom_nostra13_universalimageloader_cache_disc_naming_FileNameGenerator_J, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_io_File_Ljava_io_File_Lcom_nostra13_universalimageloader_cache_disc_naming_FileNameGenerator_J, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_io_File_Ljava_io_File_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.impl']/class[@name='LimitedAgeDiskCache']/constructor[@name='LimitedAgeDiskCache' and count(parameter)=3 and parameter[1][@type='java.io.File'] and parameter[2][@type='java.io.File'] and parameter[3][@type='long']]"
		[Register (".ctor", "(Ljava/io/File;Ljava/io/File;J)V", "")]
		public unsafe LimitedAgeDiskCache (global::Java.IO.File p0, global::Java.IO.File p1, long p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (LimitedAgeDiskCache)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/io/File;Ljava/io/File;J)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/io/File;Ljava/io/File;J)V", __args);
					return;
				}

				if (id_ctor_Ljava_io_File_Ljava_io_File_J == IntPtr.Zero)
					id_ctor_Ljava_io_File_Ljava_io_File_J = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/File;Ljava/io/File;J)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_File_Ljava_io_File_J, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_io_File_Ljava_io_File_J, __args);
			} finally {
			}
		}

	}
}
