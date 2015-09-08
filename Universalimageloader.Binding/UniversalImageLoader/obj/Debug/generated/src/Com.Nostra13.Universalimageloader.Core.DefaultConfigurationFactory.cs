using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nostra13.Universalimageloader.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='DefaultConfigurationFactory']"
	[global::Android.Runtime.Register ("com/nostra13/universalimageloader/core/DefaultConfigurationFactory", DoNotGenerateAcw=true)]
	public partial class DefaultConfigurationFactory : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='DefaultConfigurationFactory.DefaultThreadFactory']"
		[global::Android.Runtime.Register ("com/nostra13/universalimageloader/core/DefaultConfigurationFactory$DefaultThreadFactory", DoNotGenerateAcw=true)]
		public partial class DefaultThreadFactory : global::Java.Lang.Object, global::Java.Util.Concurrent.IThreadFactory {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/nostra13/universalimageloader/core/DefaultConfigurationFactory$DefaultThreadFactory", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DefaultThreadFactory); }
			}

			protected DefaultThreadFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_newThread_Ljava_lang_Runnable_;
#pragma warning disable 0169
			static Delegate GetNewThread_Ljava_lang_Runnable_Handler ()
			{
				if (cb_newThread_Ljava_lang_Runnable_ == null)
					cb_newThread_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_NewThread_Ljava_lang_Runnable_);
				return cb_newThread_Ljava_lang_Runnable_;
			}

			static IntPtr n_NewThread_Ljava_lang_Runnable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Nostra13.Universalimageloader.Core.DefaultConfigurationFactory.DefaultThreadFactory __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.DefaultConfigurationFactory.DefaultThreadFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.IRunnable p0 = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewThread (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_newThread_Ljava_lang_Runnable_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='DefaultConfigurationFactory.DefaultThreadFactory']/method[@name='newThread' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
			[Register ("newThread", "(Ljava/lang/Runnable;)Ljava/lang/Thread;", "GetNewThread_Ljava_lang_Runnable_Handler")]
			public virtual unsafe global::Java.Lang.Thread NewThread (global::Java.Lang.IRunnable p0)
			{
				if (id_newThread_Ljava_lang_Runnable_ == IntPtr.Zero)
					id_newThread_Ljava_lang_Runnable_ = JNIEnv.GetMethodID (class_ref, "newThread", "(Ljava/lang/Runnable;)Ljava/lang/Thread;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Java.Lang.Thread __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Thread> (JNIEnv.CallObjectMethod  (Handle, id_newThread_Ljava_lang_Runnable_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Thread> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "newThread", "(Ljava/lang/Runnable;)Ljava/lang/Thread;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nostra13/universalimageloader/core/DefaultConfigurationFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DefaultConfigurationFactory); }
		}

		protected DefaultConfigurationFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='DefaultConfigurationFactory']/constructor[@name='DefaultConfigurationFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DefaultConfigurationFactory ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (DefaultConfigurationFactory)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_createBitmapDisplayer;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='DefaultConfigurationFactory']/method[@name='createBitmapDisplayer' and count(parameter)=0]"
		[Register ("createBitmapDisplayer", "()Lcom/nostra13/universalimageloader/core/display/BitmapDisplayer;", "")]
		public static unsafe global::Com.Nostra13.Universalimageloader.Core.Display.IBitmapDisplayer CreateBitmapDisplayer ()
		{
			if (id_createBitmapDisplayer == IntPtr.Zero)
				id_createBitmapDisplayer = JNIEnv.GetStaticMethodID (class_ref, "createBitmapDisplayer", "()Lcom/nostra13/universalimageloader/core/display/BitmapDisplayer;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Display.IBitmapDisplayer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createBitmapDisplayer), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_createDiskCache_Landroid_content_Context_Lcom_nostra13_universalimageloader_cache_disc_naming_FileNameGenerator_JI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='DefaultConfigurationFactory']/method[@name='createDiskCache' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.nostra13.universalimageloader.cache.disc.naming.FileNameGenerator'] and parameter[3][@type='long'] and parameter[4][@type='int']]"
		[Register ("createDiskCache", "(Landroid/content/Context;Lcom/nostra13/universalimageloader/cache/disc/naming/FileNameGenerator;JI)Lcom/nostra13/universalimageloader/cache/disc/DiskCache;", "")]
		public static unsafe global::Com.Nostra13.Universalimageloader.Cache.Disc.IDiskCache CreateDiskCache (global::Android.Content.Context p0, global::Com.Nostra13.Universalimageloader.Cache.Disc.Naming.IFileNameGenerator p1, long p2, int p3)
		{
			if (id_createDiskCache_Landroid_content_Context_Lcom_nostra13_universalimageloader_cache_disc_naming_FileNameGenerator_JI == IntPtr.Zero)
				id_createDiskCache_Landroid_content_Context_Lcom_nostra13_universalimageloader_cache_disc_naming_FileNameGenerator_JI = JNIEnv.GetStaticMethodID (class_ref, "createDiskCache", "(Landroid/content/Context;Lcom/nostra13/universalimageloader/cache/disc/naming/FileNameGenerator;JI)Lcom/nostra13/universalimageloader/cache/disc/DiskCache;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				global::Com.Nostra13.Universalimageloader.Cache.Disc.IDiskCache __ret = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Cache.Disc.IDiskCache> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createDiskCache_Landroid_content_Context_Lcom_nostra13_universalimageloader_cache_disc_naming_FileNameGenerator_JI, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_createExecutor_IILcom_nostra13_universalimageloader_core_assist_QueueProcessingType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='DefaultConfigurationFactory']/method[@name='createExecutor' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.nostra13.universalimageloader.core.assist.QueueProcessingType']]"
		[Register ("createExecutor", "(IILcom/nostra13/universalimageloader/core/assist/QueueProcessingType;)Ljava/util/concurrent/Executor;", "")]
		public static unsafe global::Java.Util.Concurrent.IExecutor CreateExecutor (int p0, int p1, global::Com.Nostra13.Universalimageloader.Core.Assist.QueueProcessingType p2)
		{
			if (id_createExecutor_IILcom_nostra13_universalimageloader_core_assist_QueueProcessingType_ == IntPtr.Zero)
				id_createExecutor_IILcom_nostra13_universalimageloader_core_assist_QueueProcessingType_ = JNIEnv.GetStaticMethodID (class_ref, "createExecutor", "(IILcom/nostra13/universalimageloader/core/assist/QueueProcessingType;)Ljava/util/concurrent/Executor;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Java.Util.Concurrent.IExecutor __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IExecutor> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createExecutor_IILcom_nostra13_universalimageloader_core_assist_QueueProcessingType_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_createFileNameGenerator;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='DefaultConfigurationFactory']/method[@name='createFileNameGenerator' and count(parameter)=0]"
		[Register ("createFileNameGenerator", "()Lcom/nostra13/universalimageloader/cache/disc/naming/FileNameGenerator;", "")]
		public static unsafe global::Com.Nostra13.Universalimageloader.Cache.Disc.Naming.IFileNameGenerator CreateFileNameGenerator ()
		{
			if (id_createFileNameGenerator == IntPtr.Zero)
				id_createFileNameGenerator = JNIEnv.GetStaticMethodID (class_ref, "createFileNameGenerator", "()Lcom/nostra13/universalimageloader/cache/disc/naming/FileNameGenerator;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Cache.Disc.Naming.IFileNameGenerator> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createFileNameGenerator), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_createImageDecoder_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='DefaultConfigurationFactory']/method[@name='createImageDecoder' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("createImageDecoder", "(Z)Lcom/nostra13/universalimageloader/core/decode/ImageDecoder;", "")]
		public static unsafe global::Com.Nostra13.Universalimageloader.Core.Decode.IImageDecoder CreateImageDecoder (bool p0)
		{
			if (id_createImageDecoder_Z == IntPtr.Zero)
				id_createImageDecoder_Z = JNIEnv.GetStaticMethodID (class_ref, "createImageDecoder", "(Z)Lcom/nostra13/universalimageloader/core/decode/ImageDecoder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Decode.IImageDecoder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createImageDecoder_Z, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_createImageDownloader_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='DefaultConfigurationFactory']/method[@name='createImageDownloader' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("createImageDownloader", "(Landroid/content/Context;)Lcom/nostra13/universalimageloader/core/download/ImageDownloader;", "")]
		public static unsafe global::Com.Nostra13.Universalimageloader.Core.Download.IImageDownloader CreateImageDownloader (global::Android.Content.Context p0)
		{
			if (id_createImageDownloader_Landroid_content_Context_ == IntPtr.Zero)
				id_createImageDownloader_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "createImageDownloader", "(Landroid/content/Context;)Lcom/nostra13/universalimageloader/core/download/ImageDownloader;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Nostra13.Universalimageloader.Core.Download.IImageDownloader __ret = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Download.IImageDownloader> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createImageDownloader_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_createMemoryCache_Landroid_content_Context_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='DefaultConfigurationFactory']/method[@name='createMemoryCache' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("createMemoryCache", "(Landroid/content/Context;I)Lcom/nostra13/universalimageloader/cache/memory/MemoryCache;", "")]
		public static unsafe global::Com.Nostra13.Universalimageloader.Cache.Memory.IMemoryCache CreateMemoryCache (global::Android.Content.Context p0, int p1)
		{
			if (id_createMemoryCache_Landroid_content_Context_I == IntPtr.Zero)
				id_createMemoryCache_Landroid_content_Context_I = JNIEnv.GetStaticMethodID (class_ref, "createMemoryCache", "(Landroid/content/Context;I)Lcom/nostra13/universalimageloader/cache/memory/MemoryCache;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Com.Nostra13.Universalimageloader.Cache.Memory.IMemoryCache __ret = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Cache.Memory.IMemoryCache> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createMemoryCache_Landroid_content_Context_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_createTaskDistributor;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='DefaultConfigurationFactory']/method[@name='createTaskDistributor' and count(parameter)=0]"
		[Register ("createTaskDistributor", "()Ljava/util/concurrent/Executor;", "")]
		public static unsafe global::Java.Util.Concurrent.IExecutor CreateTaskDistributor ()
		{
			if (id_createTaskDistributor == IntPtr.Zero)
				id_createTaskDistributor = JNIEnv.GetStaticMethodID (class_ref, "createTaskDistributor", "()Ljava/util/concurrent/Executor;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IExecutor> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createTaskDistributor), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
