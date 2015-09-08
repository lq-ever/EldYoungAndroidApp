using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nostra13.Universalimageloader.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='ImageLoader']"
	[global::Android.Runtime.Register ("com/nostra13/universalimageloader/core/ImageLoader", DoNotGenerateAcw=true)]
	public partial class ImageLoader : global::Java.Lang.Object {


		static IntPtr TAG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='ImageLoader']/field[@name='TAG']"
		[Register ("TAG")]
		public static string Tag {
			get {
				if (TAG_jfieldId == IntPtr.Zero)
					TAG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TAG", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TAG_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='ImageLoader.SyncImageLoadingListener']"
		[global::Android.Runtime.Register ("com/nostra13/universalimageloader/core/ImageLoader$SyncImageLoadingListener", DoNotGenerateAcw=true)]
		public partial class SyncImageLoadingListener : global::Com.Nostra13.Universalimageloader.Core.Listener.SimpleImageLoadingListener {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/nostra13/universalimageloader/core/ImageLoader$SyncImageLoadingListener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (SyncImageLoadingListener); }
			}

			protected SyncImageLoadingListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_getLoadedBitmap;
#pragma warning disable 0169
			static Delegate GetGetLoadedBitmapHandler ()
			{
				if (cb_getLoadedBitmap == null)
					cb_getLoadedBitmap = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLoadedBitmap);
				return cb_getLoadedBitmap;
			}

			static IntPtr n_GetLoadedBitmap (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Nostra13.Universalimageloader.Core.ImageLoader.SyncImageLoadingListener __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoader.SyncImageLoadingListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.LoadedBitmap);
			}
#pragma warning restore 0169

			static IntPtr id_getLoadedBitmap;
			public virtual unsafe global::Android.Graphics.Bitmap LoadedBitmap {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='ImageLoader.SyncImageLoadingListener']/method[@name='getLoadedBitmap' and count(parameter)=0]"
				[Register ("getLoadedBitmap", "()Landroid/graphics/Bitmap;", "GetGetLoadedBitmapHandler")]
				get {
					if (id_getLoadedBitmap == IntPtr.Zero)
						id_getLoadedBitmap = JNIEnv.GetMethodID (class_ref, "getLoadedBitmap", "()Landroid/graphics/Bitmap;");
					try {

						if (GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod  (Handle, id_getLoadedBitmap), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLoadedBitmap", "()Landroid/graphics/Bitmap;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nostra13/universalimageloader/core/ImageLoader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ImageLoader); }
		}

		protected ImageLoader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='ImageLoader']/constructor[@name='ImageLoader' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe ImageLoader ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ImageLoader)) {
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

		static Delegate cb_getDiscCache;
#pragma warning disable 0169
		static Delegate GetGetDiscCacheHandler ()
		{
			if (cb_getDiscCache == null)
				cb_getDiscCache = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDiscCache);
			return cb_getDiscCache;
		}

		static IntPtr n_GetDiscCache (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Core.ImageLoader __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DiscCache);
		}
#pragma warning restore 0169

		static IntPtr id_getDiscCache;
		[Obsolete (@"deprecated")]
		public virtual unsafe global::Com.Nostra13.Universalimageloader.Cache.Disc.IDiskCache DiscCache {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='ImageLoader']/method[@name='getDiscCache' and count(parameter)=0]"
			[Register ("getDiscCache", "()Lcom/nostra13/universalimageloader/cache/disc/DiskCache;", "GetGetDiscCacheHandler")]
			get {
				if (id_getDiscCache == IntPtr.Zero)
					id_getDiscCache = JNIEnv.GetMethodID (class_ref, "getDiscCache", "()Lcom/nostra13/universalimageloader/cache/disc/DiskCache;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Cache.Disc.IDiskCache> (JNIEnv.CallObjectMethod  (Handle, id_getDiscCache), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Cache.Disc.IDiskCache> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDiscCache", "()Lcom/nostra13/universalimageloader/cache/disc/DiskCache;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDiskCache;
#pragma warning disable 0169
		static Delegate GetGetDiskCacheHandler ()
		{
			if (cb_getDiskCache == null)
				cb_getDiskCache = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDiskCache);
			return cb_getDiskCache;
		}

		static IntPtr n_GetDiskCache (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Core.ImageLoader __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DiskCache);
		}
#pragma warning restore 0169

		static IntPtr id_getDiskCache;
		public virtual unsafe global::Com.Nostra13.Universalimageloader.Cache.Disc.IDiskCache DiskCache {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='ImageLoader']/method[@name='getDiskCache' and count(parameter)=0]"
			[Register ("getDiskCache", "()Lcom/nostra13/universalimageloader/cache/disc/DiskCache;", "GetGetDiskCacheHandler")]
			get {
				if (id_getDiskCache == IntPtr.Zero)
					id_getDiskCache = JNIEnv.GetMethodID (class_ref, "getDiskCache", "()Lcom/nostra13/universalimageloader/cache/disc/DiskCache;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Cache.Disc.IDiskCache> (JNIEnv.CallObjectMethod  (Handle, id_getDiskCache), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Cache.Disc.IDiskCache> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDiskCache", "()Lcom/nostra13/universalimageloader/cache/disc/DiskCache;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getInstance;
		public static unsafe global::Com.Nostra13.Universalimageloader.Core.ImageLoader Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='ImageLoader']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/nostra13/universalimageloader/core/ImageLoader;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/nostra13/universalimageloader/core/ImageLoader;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoader> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isInited;
#pragma warning disable 0169
		static Delegate GetIsInitedHandler ()
		{
			if (cb_isInited == null)
				cb_isInited = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsInited);
			return cb_isInited;
		}

		static bool n_IsInited (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Core.ImageLoader __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInited;
		}
#pragma warning restore 0169

		static IntPtr id_isInited;
		public virtual unsafe bool IsInited {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='ImageLoader']/method[@name='isInited' and count(parameter)=0]"
			[Register ("isInited", "()Z", "GetIsInitedHandler")]
			get {
				if (id_isInited == IntPtr.Zero)
					id_isInited = JNIEnv.GetMethodID (class_ref, "isInited", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isInited);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isInited", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getMemoryCache;
#pragma warning disable 0169
		static Delegate GetGetMemoryCacheHandler ()
		{
			if (cb_getMemoryCache == null)
				cb_getMemoryCache = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMemoryCache);
			return cb_getMemoryCache;
		}

		static IntPtr n_GetMemoryCache (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Core.ImageLoader __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MemoryCache);
		}
#pragma warning restore 0169

		static IntPtr id_getMemoryCache;
		public virtual unsafe global::Com.Nostra13.Universalimageloader.Cache.Memory.IMemoryCache MemoryCache {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='ImageLoader']/method[@name='getMemoryCache' and count(parameter)=0]"
			[Register ("getMemoryCache", "()Lcom/nostra13/universalimageloader/cache/memory/MemoryCache;", "GetGetMemoryCacheHandler")]
			get {
				if (id_getMemoryCache == IntPtr.Zero)
					id_getMemoryCache = JNIEnv.GetMethodID (class_ref, "getMemoryCache", "()Lcom/nostra13/universalimageloader/cache/memory/MemoryCache;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Cache.Memory.IMemoryCache> (JNIEnv.CallObjectMethod  (Handle, id_getMemoryCache), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Cache.Memory.IMemoryCache> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMemoryCache", "()Lcom/nostra13/universalimageloader/cache/memory/MemoryCache;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_cancelDisplayTask_Landroid_widget_ImageView_;
#pragma warning disable 0169
		static Delegate GetCancelDisplayTask_Landroid_widget_ImageView_Handler ()
		{
			if (cb_cancelDisplayTask_Landroid_widget_ImageView_ == null)
				cb_cancelDisplayTask_Landroid_widget_ImageView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CancelDisplayTask_Landroid_widget_ImageView_);
			return cb_cancelDisplayTask_Landroid_widget_ImageView_;
		}

		static void n_CancelDisplayTask_Landroid_widget_ImageView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nostra13.Universalimageloader.Core.ImageLoader __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.ImageView p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.ImageView> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CancelDisplayTask (p0);
		}
#pragma warning restore 0169

		static IntPtr id_cancelDisplayTask_Landroid_widget_ImageView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='ImageLoader']/method[@name='cancelDisplayTask' and count(parameter)=1 and parameter[1][@type='android.widget.ImageView']]"
		[Register ("cancelDisplayTask", "(Landroid/widget/ImageView;)V", "GetCancelDisplayTask_Landroid_widget_ImageView_Handler")]
		public virtual unsafe void CancelDisplayTask (global::Android.Widget.ImageView p0)
		{
			if (id_cancelDisplayTask_Landroid_widget_ImageView_ == IntPtr.Zero)
				id_cancelDisplayTask_Landroid_widget_ImageView_ = JNIEnv.GetMethodID (class_ref, "cancelDisplayTask", "(Landroid/widget/ImageView;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_cancelDisplayTask_Landroid_widget_ImageView_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cancelDisplayTask", "(Landroid/widget/ImageView;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_cancelDisplayTask_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_;
#pragma warning disable 0169
		static Delegate GetCancelDisplayTask_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Handler ()
		{
			if (cb_cancelDisplayTask_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_ == null)
				cb_cancelDisplayTask_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CancelDisplayTask_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_);
			return cb_cancelDisplayTask_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_;
		}

		static void n_CancelDisplayTask_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nostra13.Universalimageloader.Core.ImageLoader __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nostra13.Universalimageloader.Core.Imageaware.IImageAware p0 = (global::Com.Nostra13.Universalimageloader.Core.Imageaware.IImageAware)global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Imageaware.IImageAware> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CancelDisplayTask (p0);
		}
#pragma warning restore 0169

		static IntPtr id_cancelDisplayTask_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='ImageLoader']/method[@name='cancelDisplayTask' and count(parameter)=1 and parameter[1][@type='com.nostra13.universalimageloader.core.imageaware.ImageAware']]"
		[Register ("cancelDisplayTask", "(Lcom/nostra13/universalimageloader/core/imageaware/ImageAware;)V", "GetCancelDisplayTask_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Handler")]
		public virtual unsafe void CancelDisplayTask (global::Com.Nostra13.Universalimageloader.Core.Imageaware.IImageAware p0)
		{
			if (id_cancelDisplayTask_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_ == IntPtr.Zero)
				id_cancelDisplayTask_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_ = JNIEnv.GetMethodID (class_ref, "cancelDisplayTask", "(Lcom/nostra13/universalimageloader/core/imageaware/ImageAware;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_cancelDisplayTask_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cancelDisplayTask", "(Lcom/nostra13/universalimageloader/core/imageaware/ImageAware;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_clearDiscCache;
#pragma warning disable 0169
		static Delegate GetClearDiscCacheHandler ()
		{
			if (cb_clearDiscCache == null)
				cb_clearDiscCache = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearDiscCache);
			return cb_clearDiscCache;
		}

		static void n_ClearDiscCache (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Core.ImageLoader __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearDiscCache ();
		}
#pragma warning restore 0169

		static IntPtr id_clearDiscCache;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='ImageLoader']/method[@name='clearDiscCache' and count(parameter)=0]"
		[Obsolete (@"deprecated")]
		[Register ("clearDiscCache", "()V", "GetClearDiscCacheHandler")]
		public virtual unsafe void ClearDiscCache ()
		{
			if (id_clearDiscCache == IntPtr.Zero)
				id_clearDiscCache = JNIEnv.GetMethodID (class_ref, "clearDiscCache", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_clearDiscCache);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearDiscCache", "()V"));
			} finally {
			}
		}

		static Delegate cb_clearDiskCache;
#pragma warning disable 0169
		static Delegate GetClearDiskCacheHandler ()
		{
			if (cb_clearDiskCache == null)
				cb_clearDiskCache = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearDiskCache);
			return cb_clearDiskCache;
		}

		static void n_ClearDiskCache (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Core.ImageLoader __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearDiskCache ();
		}
#pragma warning restore 0169

		static IntPtr id_clearDiskCache;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='ImageLoader']/method[@name='clearDiskCache' and count(parameter)=0]"
		[Register ("clearDiskCache", "()V", "GetClearDiskCacheHandler")]
		public virtual unsafe void ClearDiskCache ()
		{
			if (id_clearDiskCache == IntPtr.Zero)
				id_clearDiskCache = JNIEnv.GetMethodID (class_ref, "clearDiskCache", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_clearDiskCache);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearDiskCache", "()V"));
			} finally {
			}
		}

		static Delegate cb_clearMemoryCache;
#pragma warning disable 0169
		static Delegate GetClearMemoryCacheHandler ()
		{
			if (cb_clearMemoryCache == null)
				cb_clearMemoryCache = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearMemoryCache);
			return cb_clearMemoryCache;
		}

		static void n_ClearMemoryCache (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Core.ImageLoader __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearMemoryCache ();
		}
#pragma warning restore 0169

		static IntPtr id_clearMemoryCache;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='ImageLoader']/method[@name='clearMemoryCache' and count(parameter)=0]"
		[Register ("clearMemoryCache", "()V", "GetClearMemoryCacheHandler")]
		public virtual unsafe void ClearMemoryCache ()
		{
			if (id_clearMemoryCache == IntPtr.Zero)
				id_clearMemoryCache = JNIEnv.GetMethodID (class_ref, "clearMemoryCache", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_clearMemoryCache);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearMemoryCache", "()V"));
			} finally {
			}
		}

		static Delegate cb_denyNetworkDownloads_Z;
#pragma warning disable 0169
		static Delegate GetDenyNetworkDownloads_ZHandler ()
		{
			if (cb_denyNetworkDownloads_Z == null)
				cb_denyNetworkDownloads_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_DenyNetworkDownloads_Z);
			return cb_denyNetworkDownloads_Z;
		}

		static void n_DenyNetworkDownloads_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Nostra13.Universalimageloader.Core.ImageLoader __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DenyNetworkDownloads (p0);
		}
#pragma warning restore 0169

		static IntPtr id_denyNetworkDownloads_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='ImageLoader']/method[@name='denyNetworkDownloads' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("denyNetworkDownloads", "(Z)V", "GetDenyNetworkDownloads_ZHandler")]
		public virtual unsafe void DenyNetworkDownloads (bool p0)
		{
			if (id_denyNetworkDownloads_Z == IntPtr.Zero)
				id_denyNetworkDownloads_Z = JNIEnv.GetMethodID (class_ref, "denyNetworkDownloads", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_denyNetworkDownloads_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "denyNetworkDownloads", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_destroy;
#pragma warning disable 0169
		static Delegate GetDestroyHandler ()
		{
			if (cb_destroy == null)
				cb_destroy = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Destroy);
			return cb_destroy;
		}

		static void n_Destroy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Core.ImageLoader __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Destroy ();
		}
#pragma warning restore 0169

		static IntPtr id_destroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='ImageLoader']/method[@name='destroy' and count(parameter)=0]"
		[Register ("destroy", "()V", "GetDestroyHandler")]
		public virtual unsafe void Destroy ()
		{
			if (id_destroy == IntPtr.Zero)
				id_destroy = JNIEnv.GetMethodID (class_ref, "destroy", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_destroy);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "destroy", "()V"));
			} finally {
			}
		}

		static Delegate cb_displayImage_Ljava_lang_String_Landroid_widget_ImageView_;
#pragma warning disable 0169
		static Delegate GetDisplayImage_Ljava_lang_String_Landroid_widget_ImageView_Handler ()
		{
			if (cb_displayImage_Ljava_lang_String_Landroid_widget_ImageView_ == null)
				cb_displayImage_Ljava_lang_String_Landroid_widget_ImageView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_DisplayImage_Ljava_lang_String_Landroid_widget_ImageView_);
			return cb_displayImage_Ljava_lang_String_Landroid_widget_ImageView_;
		}

		static void n_DisplayImage_Ljava_lang_String_Landroid_widget_ImageView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Nostra13.Universalimageloader.Core.ImageLoader __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.ImageView p1 = global::Java.Lang.Object.GetObject<global::Android.Widget.ImageView> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.DisplayImage (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_displayImage_Ljava_lang_String_Landroid_widget_ImageView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='ImageLoader']/method[@name='displayImage' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.widget.ImageView']]"
		[Register ("displayImage", "(Ljava/lang/String;Landroid/widget/ImageView;)V", "GetDisplayImage_Ljava_lang_String_Landroid_widget_ImageView_Handler")]
		public virtual unsafe void DisplayImage (string p0, global::Android.Widget.ImageView p1)
		{
			if (id_displayImage_Ljava_lang_String_Landroid_widget_ImageView_ == IntPtr.Zero)
				id_displayImage_Ljava_lang_String_Landroid_widget_ImageView_ = JNIEnv.GetMethodID (class_ref, "displayImage", "(Ljava/lang/String;Landroid/widget/ImageView;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_displayImage_Ljava_lang_String_Landroid_widget_ImageView_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "displayImage", "(Ljava/lang/String;Landroid/widget/ImageView;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_displayImage_Ljava_lang_String_Landroid_widget_ImageView_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_;
#pragma warning disable 0169
		static Delegate GetDisplayImage_Ljava_lang_String_Landroid_widget_ImageView_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Handler ()
		{
			if (cb_displayImage_Ljava_lang_String_Landroid_widget_ImageView_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_ == null)
				cb_displayImage_Ljava_lang_String_Landroid_widget_ImageView_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_DisplayImage_Ljava_lang_String_Landroid_widget_ImageView_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_);
			return cb_displayImage_Ljava_lang_String_Landroid_widget_ImageView_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_;
		}

		static void n_DisplayImage_Ljava_lang_String_Landroid_widget_ImageView_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Nostra13.Universalimageloader.Core.ImageLoader __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.ImageView p1 = global::Java.Lang.Object.GetObject<global::Android.Widget.ImageView> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions p2 = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.DisplayImage (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_displayImage_Ljava_lang_String_Landroid_widget_ImageView_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='ImageLoader']/method[@name='displayImage' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.widget.ImageView'] and parameter[3][@type='com.nostra13.universalimageloader.core.DisplayImageOptions']]"
		[Register ("displayImage", "(Ljava/lang/String;Landroid/widget/ImageView;Lcom/nostra13/universalimageloader/core/DisplayImageOptions;)V", "GetDisplayImage_Ljava_lang_String_Landroid_widget_ImageView_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Handler")]
		public virtual unsafe void DisplayImage (string p0, global::Android.Widget.ImageView p1, global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions p2)
		{
			if (id_displayImage_Ljava_lang_String_Landroid_widget_ImageView_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_ == IntPtr.Zero)
				id_displayImage_Ljava_lang_String_Landroid_widget_ImageView_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_ = JNIEnv.GetMethodID (class_ref, "displayImage", "(Ljava/lang/String;Landroid/widget/ImageView;Lcom/nostra13/universalimageloader/core/DisplayImageOptions;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_displayImage_Ljava_lang_String_Landroid_widget_ImageView_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "displayImage", "(Ljava/lang/String;Landroid/widget/ImageView;Lcom/nostra13/universalimageloader/core/DisplayImageOptions;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_displayImage_Ljava_lang_String_Landroid_widget_ImageView_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_;
#pragma warning disable 0169
		static Delegate GetDisplayImage_Ljava_lang_String_Landroid_widget_ImageView_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_Handler ()
		{
			if (cb_displayImage_Ljava_lang_String_Landroid_widget_ImageView_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_ == null)
				cb_displayImage_Ljava_lang_String_Landroid_widget_ImageView_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_DisplayImage_Ljava_lang_String_Landroid_widget_ImageView_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_);
			return cb_displayImage_Ljava_lang_String_Landroid_widget_ImageView_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_;
		}

		static void n_DisplayImage_Ljava_lang_String_Landroid_widget_ImageView_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Nostra13.Universalimageloader.Core.ImageLoader __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.ImageView p1 = global::Java.Lang.Object.GetObject<global::Android.Widget.ImageView> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions p2 = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingListener p3 = (global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingListener)global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingListener> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.DisplayImage (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_displayImage_Ljava_lang_String_Landroid_widget_ImageView_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='ImageLoader']/method[@name='displayImage' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.widget.ImageView'] and parameter[3][@type='com.nostra13.universalimageloader.core.DisplayImageOptions'] and parameter[4][@type='com.nostra13.universalimageloader.core.listener.ImageLoadingListener']]"
		[Register ("displayImage", "(Ljava/lang/String;Landroid/widget/ImageView;Lcom/nostra13/universalimageloader/core/DisplayImageOptions;Lcom/nostra13/universalimageloader/core/listener/ImageLoadingListener;)V", "GetDisplayImage_Ljava_lang_String_Landroid_widget_ImageView_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_Handler")]
		public virtual unsafe void DisplayImage (string p0, global::Android.Widget.ImageView p1, global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions p2, global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingListener p3)
		{
			if (id_displayImage_Ljava_lang_String_Landroid_widget_ImageView_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_ == IntPtr.Zero)
				id_displayImage_Ljava_lang_String_Landroid_widget_ImageView_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_ = JNIEnv.GetMethodID (class_ref, "displayImage", "(Ljava/lang/String;Landroid/widget/ImageView;Lcom/nostra13/universalimageloader/core/DisplayImageOptions;Lcom/nostra13/universalimageloader/core/listener/ImageLoadingListener;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_displayImage_Ljava_lang_String_Landroid_widget_ImageView_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "displayImage", "(Ljava/lang/String;Landroid/widget/ImageView;Lcom/nostra13/universalimageloader/core/DisplayImageOptions;Lcom/nostra13/universalimageloader/core/listener/ImageLoadingListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_displayImage_Ljava_lang_String_Landroid_widget_ImageView_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingProgressListener_;
#pragma warning disable 0169
		static Delegate GetDisplayImage_Ljava_lang_String_Landroid_widget_ImageView_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingProgressListener_Handler ()
		{
			if (cb_displayImage_Ljava_lang_String_Landroid_widget_ImageView_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingProgressListener_ == null)
				cb_displayImage_Ljava_lang_String_Landroid_widget_ImageView_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingProgressListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_DisplayImage_Ljava_lang_String_Landroid_widget_ImageView_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingProgressListener_);
			return cb_displayImage_Ljava_lang_String_Landroid_widget_ImageView_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingProgressListener_;
		}

		static void n_DisplayImage_Ljava_lang_String_Landroid_widget_ImageView_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingProgressListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Com.Nostra13.Universalimageloader.Core.ImageLoader __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.ImageView p1 = global::Java.Lang.Object.GetObject<global::Android.Widget.ImageView> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions p2 = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingListener p3 = (global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingListener)global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingListener> (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingProgressListener p4 = (global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingProgressListener)global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingProgressListener> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.DisplayImage (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_displayImage_Ljava_lang_String_Landroid_widget_ImageView_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingProgressListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='ImageLoader']/method[@name='displayImage' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.widget.ImageView'] and parameter[3][@type='com.nostra13.universalimageloader.core.DisplayImageOptions'] and parameter[4][@type='com.nostra13.universalimageloader.core.listener.ImageLoadingListener'] and parameter[5][@type='com.nostra13.universalimageloader.core.listener.ImageLoadingProgressListener']]"
		[Register ("displayImage", "(Ljava/lang/String;Landroid/widget/ImageView;Lcom/nostra13/universalimageloader/core/DisplayImageOptions;Lcom/nostra13/universalimageloader/core/listener/ImageLoadingListener;Lcom/nostra13/universalimageloader/core/listener/ImageLoadingProgressListener;)V", "GetDisplayImage_Ljava_lang_String_Landroid_widget_ImageView_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingProgressListener_Handler")]
		public virtual unsafe void DisplayImage (string p0, global::Android.Widget.ImageView p1, global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions p2, global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingListener p3, global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingProgressListener p4)
		{
			if (id_displayImage_Ljava_lang_String_Landroid_widget_ImageView_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingProgressListener_ == IntPtr.Zero)
				id_displayImage_Ljava_lang_String_Landroid_widget_ImageView_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingProgressListener_ = JNIEnv.GetMethodID (class_ref, "displayImage", "(Ljava/lang/String;Landroid/widget/ImageView;Lcom/nostra13/universalimageloader/core/DisplayImageOptions;Lcom/nostra13/universalimageloader/core/listener/ImageLoadingListener;Lcom/nostra13/universalimageloader/core/listener/ImageLoadingProgressListener;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_displayImage_Ljava_lang_String_Landroid_widget_ImageView_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingProgressListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "displayImage", "(Ljava/lang/String;Landroid/widget/ImageView;Lcom/nostra13/universalimageloader/core/DisplayImageOptions;Lcom/nostra13/universalimageloader/core/listener/ImageLoadingListener;Lcom/nostra13/universalimageloader/core/listener/ImageLoadingProgressListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_displayImage_Ljava_lang_String_Landroid_widget_ImageView_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_;
#pragma warning disable 0169
		static Delegate GetDisplayImage_Ljava_lang_String_Landroid_widget_ImageView_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_Handler ()
		{
			if (cb_displayImage_Ljava_lang_String_Landroid_widget_ImageView_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_ == null)
				cb_displayImage_Ljava_lang_String_Landroid_widget_ImageView_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_DisplayImage_Ljava_lang_String_Landroid_widget_ImageView_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_);
			return cb_displayImage_Ljava_lang_String_Landroid_widget_ImageView_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_;
		}

		static void n_DisplayImage_Ljava_lang_String_Landroid_widget_ImageView_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Nostra13.Universalimageloader.Core.ImageLoader __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.ImageView p1 = global::Java.Lang.Object.GetObject<global::Android.Widget.ImageView> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingListener p2 = (global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingListener)global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.DisplayImage (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_displayImage_Ljava_lang_String_Landroid_widget_ImageView_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='ImageLoader']/method[@name='displayImage' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.widget.ImageView'] and parameter[3][@type='com.nostra13.universalimageloader.core.listener.ImageLoadingListener']]"
		[Register ("displayImage", "(Ljava/lang/String;Landroid/widget/ImageView;Lcom/nostra13/universalimageloader/core/listener/ImageLoadingListener;)V", "GetDisplayImage_Ljava_lang_String_Landroid_widget_ImageView_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_Handler")]
		public virtual unsafe void DisplayImage (string p0, global::Android.Widget.ImageView p1, global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingListener p2)
		{
			if (id_displayImage_Ljava_lang_String_Landroid_widget_ImageView_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_ == IntPtr.Zero)
				id_displayImage_Ljava_lang_String_Landroid_widget_ImageView_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_ = JNIEnv.GetMethodID (class_ref, "displayImage", "(Ljava/lang/String;Landroid/widget/ImageView;Lcom/nostra13/universalimageloader/core/listener/ImageLoadingListener;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_displayImage_Ljava_lang_String_Landroid_widget_ImageView_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "displayImage", "(Ljava/lang/String;Landroid/widget/ImageView;Lcom/nostra13/universalimageloader/core/listener/ImageLoadingListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_displayImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_;
#pragma warning disable 0169
		static Delegate GetDisplayImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Handler ()
		{
			if (cb_displayImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_ == null)
				cb_displayImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_DisplayImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_);
			return cb_displayImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_;
		}

		static void n_DisplayImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Nostra13.Universalimageloader.Core.ImageLoader __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Nostra13.Universalimageloader.Core.Imageaware.IImageAware p1 = (global::Com.Nostra13.Universalimageloader.Core.Imageaware.IImageAware)global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Imageaware.IImageAware> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.DisplayImage (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_displayImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='ImageLoader']/method[@name='displayImage' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.nostra13.universalimageloader.core.imageaware.ImageAware']]"
		[Register ("displayImage", "(Ljava/lang/String;Lcom/nostra13/universalimageloader/core/imageaware/ImageAware;)V", "GetDisplayImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Handler")]
		public virtual unsafe void DisplayImage (string p0, global::Com.Nostra13.Universalimageloader.Core.Imageaware.IImageAware p1)
		{
			if (id_displayImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_ == IntPtr.Zero)
				id_displayImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_ = JNIEnv.GetMethodID (class_ref, "displayImage", "(Ljava/lang/String;Lcom/nostra13/universalimageloader/core/imageaware/ImageAware;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_displayImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "displayImage", "(Ljava/lang/String;Lcom/nostra13/universalimageloader/core/imageaware/ImageAware;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_displayImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_;
#pragma warning disable 0169
		static Delegate GetDisplayImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Handler ()
		{
			if (cb_displayImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_ == null)
				cb_displayImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_DisplayImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_);
			return cb_displayImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_;
		}

		static void n_DisplayImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Nostra13.Universalimageloader.Core.ImageLoader __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Nostra13.Universalimageloader.Core.Imageaware.IImageAware p1 = (global::Com.Nostra13.Universalimageloader.Core.Imageaware.IImageAware)global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Imageaware.IImageAware> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions p2 = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.DisplayImage (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_displayImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='ImageLoader']/method[@name='displayImage' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.nostra13.universalimageloader.core.imageaware.ImageAware'] and parameter[3][@type='com.nostra13.universalimageloader.core.DisplayImageOptions']]"
		[Register ("displayImage", "(Ljava/lang/String;Lcom/nostra13/universalimageloader/core/imageaware/ImageAware;Lcom/nostra13/universalimageloader/core/DisplayImageOptions;)V", "GetDisplayImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Handler")]
		public virtual unsafe void DisplayImage (string p0, global::Com.Nostra13.Universalimageloader.Core.Imageaware.IImageAware p1, global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions p2)
		{
			if (id_displayImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_ == IntPtr.Zero)
				id_displayImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_ = JNIEnv.GetMethodID (class_ref, "displayImage", "(Ljava/lang/String;Lcom/nostra13/universalimageloader/core/imageaware/ImageAware;Lcom/nostra13/universalimageloader/core/DisplayImageOptions;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_displayImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "displayImage", "(Ljava/lang/String;Lcom/nostra13/universalimageloader/core/imageaware/ImageAware;Lcom/nostra13/universalimageloader/core/DisplayImageOptions;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_displayImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_;
#pragma warning disable 0169
		static Delegate GetDisplayImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_Handler ()
		{
			if (cb_displayImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_ == null)
				cb_displayImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_DisplayImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_);
			return cb_displayImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_;
		}

		static void n_DisplayImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Nostra13.Universalimageloader.Core.ImageLoader __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Nostra13.Universalimageloader.Core.Imageaware.IImageAware p1 = (global::Com.Nostra13.Universalimageloader.Core.Imageaware.IImageAware)global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Imageaware.IImageAware> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions p2 = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingListener p3 = (global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingListener)global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingListener> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.DisplayImage (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_displayImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='ImageLoader']/method[@name='displayImage' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.nostra13.universalimageloader.core.imageaware.ImageAware'] and parameter[3][@type='com.nostra13.universalimageloader.core.DisplayImageOptions'] and parameter[4][@type='com.nostra13.universalimageloader.core.listener.ImageLoadingListener']]"
		[Register ("displayImage", "(Ljava/lang/String;Lcom/nostra13/universalimageloader/core/imageaware/ImageAware;Lcom/nostra13/universalimageloader/core/DisplayImageOptions;Lcom/nostra13/universalimageloader/core/listener/ImageLoadingListener;)V", "GetDisplayImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_Handler")]
		public virtual unsafe void DisplayImage (string p0, global::Com.Nostra13.Universalimageloader.Core.Imageaware.IImageAware p1, global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions p2, global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingListener p3)
		{
			if (id_displayImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_ == IntPtr.Zero)
				id_displayImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_ = JNIEnv.GetMethodID (class_ref, "displayImage", "(Ljava/lang/String;Lcom/nostra13/universalimageloader/core/imageaware/ImageAware;Lcom/nostra13/universalimageloader/core/DisplayImageOptions;Lcom/nostra13/universalimageloader/core/listener/ImageLoadingListener;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_displayImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "displayImage", "(Ljava/lang/String;Lcom/nostra13/universalimageloader/core/imageaware/ImageAware;Lcom/nostra13/universalimageloader/core/DisplayImageOptions;Lcom/nostra13/universalimageloader/core/listener/ImageLoadingListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_displayImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingProgressListener_;
#pragma warning disable 0169
		static Delegate GetDisplayImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingProgressListener_Handler ()
		{
			if (cb_displayImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingProgressListener_ == null)
				cb_displayImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingProgressListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_DisplayImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingProgressListener_);
			return cb_displayImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingProgressListener_;
		}

		static void n_DisplayImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingProgressListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Com.Nostra13.Universalimageloader.Core.ImageLoader __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Nostra13.Universalimageloader.Core.Imageaware.IImageAware p1 = (global::Com.Nostra13.Universalimageloader.Core.Imageaware.IImageAware)global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Imageaware.IImageAware> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions p2 = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingListener p3 = (global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingListener)global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingListener> (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingProgressListener p4 = (global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingProgressListener)global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingProgressListener> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.DisplayImage (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_displayImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingProgressListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='ImageLoader']/method[@name='displayImage' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.nostra13.universalimageloader.core.imageaware.ImageAware'] and parameter[3][@type='com.nostra13.universalimageloader.core.DisplayImageOptions'] and parameter[4][@type='com.nostra13.universalimageloader.core.listener.ImageLoadingListener'] and parameter[5][@type='com.nostra13.universalimageloader.core.listener.ImageLoadingProgressListener']]"
		[Register ("displayImage", "(Ljava/lang/String;Lcom/nostra13/universalimageloader/core/imageaware/ImageAware;Lcom/nostra13/universalimageloader/core/DisplayImageOptions;Lcom/nostra13/universalimageloader/core/listener/ImageLoadingListener;Lcom/nostra13/universalimageloader/core/listener/ImageLoadingProgressListener;)V", "GetDisplayImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingProgressListener_Handler")]
		public virtual unsafe void DisplayImage (string p0, global::Com.Nostra13.Universalimageloader.Core.Imageaware.IImageAware p1, global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions p2, global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingListener p3, global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingProgressListener p4)
		{
			if (id_displayImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingProgressListener_ == IntPtr.Zero)
				id_displayImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingProgressListener_ = JNIEnv.GetMethodID (class_ref, "displayImage", "(Ljava/lang/String;Lcom/nostra13/universalimageloader/core/imageaware/ImageAware;Lcom/nostra13/universalimageloader/core/DisplayImageOptions;Lcom/nostra13/universalimageloader/core/listener/ImageLoadingListener;Lcom/nostra13/universalimageloader/core/listener/ImageLoadingProgressListener;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_displayImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingProgressListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "displayImage", "(Ljava/lang/String;Lcom/nostra13/universalimageloader/core/imageaware/ImageAware;Lcom/nostra13/universalimageloader/core/DisplayImageOptions;Lcom/nostra13/universalimageloader/core/listener/ImageLoadingListener;Lcom/nostra13/universalimageloader/core/listener/ImageLoadingProgressListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_displayImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_;
#pragma warning disable 0169
		static Delegate GetDisplayImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_Handler ()
		{
			if (cb_displayImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_ == null)
				cb_displayImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_DisplayImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_);
			return cb_displayImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_;
		}

		static void n_DisplayImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Nostra13.Universalimageloader.Core.ImageLoader __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Nostra13.Universalimageloader.Core.Imageaware.IImageAware p1 = (global::Com.Nostra13.Universalimageloader.Core.Imageaware.IImageAware)global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Imageaware.IImageAware> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingListener p2 = (global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingListener)global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.DisplayImage (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_displayImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='ImageLoader']/method[@name='displayImage' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.nostra13.universalimageloader.core.imageaware.ImageAware'] and parameter[3][@type='com.nostra13.universalimageloader.core.listener.ImageLoadingListener']]"
		[Register ("displayImage", "(Ljava/lang/String;Lcom/nostra13/universalimageloader/core/imageaware/ImageAware;Lcom/nostra13/universalimageloader/core/listener/ImageLoadingListener;)V", "GetDisplayImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_Handler")]
		public virtual unsafe void DisplayImage (string p0, global::Com.Nostra13.Universalimageloader.Core.Imageaware.IImageAware p1, global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingListener p2)
		{
			if (id_displayImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_ == IntPtr.Zero)
				id_displayImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_ = JNIEnv.GetMethodID (class_ref, "displayImage", "(Ljava/lang/String;Lcom/nostra13/universalimageloader/core/imageaware/ImageAware;Lcom/nostra13/universalimageloader/core/listener/ImageLoadingListener;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_displayImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "displayImage", "(Ljava/lang/String;Lcom/nostra13/universalimageloader/core/imageaware/ImageAware;Lcom/nostra13/universalimageloader/core/listener/ImageLoadingListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getLoadingUriForView_Landroid_widget_ImageView_;
#pragma warning disable 0169
		static Delegate GetGetLoadingUriForView_Landroid_widget_ImageView_Handler ()
		{
			if (cb_getLoadingUriForView_Landroid_widget_ImageView_ == null)
				cb_getLoadingUriForView_Landroid_widget_ImageView_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetLoadingUriForView_Landroid_widget_ImageView_);
			return cb_getLoadingUriForView_Landroid_widget_ImageView_;
		}

		static IntPtr n_GetLoadingUriForView_Landroid_widget_ImageView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nostra13.Universalimageloader.Core.ImageLoader __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.ImageView p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.ImageView> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetLoadingUriForView (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getLoadingUriForView_Landroid_widget_ImageView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='ImageLoader']/method[@name='getLoadingUriForView' and count(parameter)=1 and parameter[1][@type='android.widget.ImageView']]"
		[Register ("getLoadingUriForView", "(Landroid/widget/ImageView;)Ljava/lang/String;", "GetGetLoadingUriForView_Landroid_widget_ImageView_Handler")]
		public virtual unsafe string GetLoadingUriForView (global::Android.Widget.ImageView p0)
		{
			if (id_getLoadingUriForView_Landroid_widget_ImageView_ == IntPtr.Zero)
				id_getLoadingUriForView_Landroid_widget_ImageView_ = JNIEnv.GetMethodID (class_ref, "getLoadingUriForView", "(Landroid/widget/ImageView;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getLoadingUriForView_Landroid_widget_ImageView_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLoadingUriForView", "(Landroid/widget/ImageView;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getLoadingUriForView_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_;
#pragma warning disable 0169
		static Delegate GetGetLoadingUriForView_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Handler ()
		{
			if (cb_getLoadingUriForView_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_ == null)
				cb_getLoadingUriForView_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetLoadingUriForView_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_);
			return cb_getLoadingUriForView_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_;
		}

		static IntPtr n_GetLoadingUriForView_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nostra13.Universalimageloader.Core.ImageLoader __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nostra13.Universalimageloader.Core.Imageaware.IImageAware p0 = (global::Com.Nostra13.Universalimageloader.Core.Imageaware.IImageAware)global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Imageaware.IImageAware> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetLoadingUriForView (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getLoadingUriForView_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='ImageLoader']/method[@name='getLoadingUriForView' and count(parameter)=1 and parameter[1][@type='com.nostra13.universalimageloader.core.imageaware.ImageAware']]"
		[Register ("getLoadingUriForView", "(Lcom/nostra13/universalimageloader/core/imageaware/ImageAware;)Ljava/lang/String;", "GetGetLoadingUriForView_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Handler")]
		public virtual unsafe string GetLoadingUriForView (global::Com.Nostra13.Universalimageloader.Core.Imageaware.IImageAware p0)
		{
			if (id_getLoadingUriForView_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_ == IntPtr.Zero)
				id_getLoadingUriForView_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_ = JNIEnv.GetMethodID (class_ref, "getLoadingUriForView", "(Lcom/nostra13/universalimageloader/core/imageaware/ImageAware;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getLoadingUriForView_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLoadingUriForView", "(Lcom/nostra13/universalimageloader/core/imageaware/ImageAware;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_handleSlowNetwork_Z;
#pragma warning disable 0169
		static Delegate GetHandleSlowNetwork_ZHandler ()
		{
			if (cb_handleSlowNetwork_Z == null)
				cb_handleSlowNetwork_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_HandleSlowNetwork_Z);
			return cb_handleSlowNetwork_Z;
		}

		static void n_HandleSlowNetwork_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Nostra13.Universalimageloader.Core.ImageLoader __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HandleSlowNetwork (p0);
		}
#pragma warning restore 0169

		static IntPtr id_handleSlowNetwork_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='ImageLoader']/method[@name='handleSlowNetwork' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("handleSlowNetwork", "(Z)V", "GetHandleSlowNetwork_ZHandler")]
		public virtual unsafe void HandleSlowNetwork (bool p0)
		{
			if (id_handleSlowNetwork_Z == IntPtr.Zero)
				id_handleSlowNetwork_Z = JNIEnv.GetMethodID (class_ref, "handleSlowNetwork", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_handleSlowNetwork_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "handleSlowNetwork", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_init_Lcom_nostra13_universalimageloader_core_ImageLoaderConfiguration_;
#pragma warning disable 0169
		static Delegate GetInit_Lcom_nostra13_universalimageloader_core_ImageLoaderConfiguration_Handler ()
		{
			if (cb_init_Lcom_nostra13_universalimageloader_core_ImageLoaderConfiguration_ == null)
				cb_init_Lcom_nostra13_universalimageloader_core_ImageLoaderConfiguration_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Init_Lcom_nostra13_universalimageloader_core_ImageLoaderConfiguration_);
			return cb_init_Lcom_nostra13_universalimageloader_core_ImageLoaderConfiguration_;
		}

		static void n_Init_Lcom_nostra13_universalimageloader_core_ImageLoaderConfiguration_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nostra13.Universalimageloader.Core.ImageLoader __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration p0 = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Init (p0);
		}
#pragma warning restore 0169

		static IntPtr id_init_Lcom_nostra13_universalimageloader_core_ImageLoaderConfiguration_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='ImageLoader']/method[@name='init' and count(parameter)=1 and parameter[1][@type='com.nostra13.universalimageloader.core.ImageLoaderConfiguration']]"
		[Register ("init", "(Lcom/nostra13/universalimageloader/core/ImageLoaderConfiguration;)V", "GetInit_Lcom_nostra13_universalimageloader_core_ImageLoaderConfiguration_Handler")]
		public virtual unsafe void Init (global::Com.Nostra13.Universalimageloader.Core.ImageLoaderConfiguration p0)
		{
			if (id_init_Lcom_nostra13_universalimageloader_core_ImageLoaderConfiguration_ == IntPtr.Zero)
				id_init_Lcom_nostra13_universalimageloader_core_ImageLoaderConfiguration_ = JNIEnv.GetMethodID (class_ref, "init", "(Lcom/nostra13/universalimageloader/core/ImageLoaderConfiguration;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_init_Lcom_nostra13_universalimageloader_core_ImageLoaderConfiguration_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "init", "(Lcom/nostra13/universalimageloader/core/ImageLoaderConfiguration;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_loadImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_;
#pragma warning disable 0169
		static Delegate GetLoadImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_Handler ()
		{
			if (cb_loadImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_ == null)
				cb_loadImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_LoadImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_);
			return cb_loadImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_;
		}

		static void n_LoadImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Nostra13.Universalimageloader.Core.ImageLoader __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions p1 = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingListener p2 = (global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingListener)global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.LoadImage (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_loadImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='ImageLoader']/method[@name='loadImage' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.nostra13.universalimageloader.core.DisplayImageOptions'] and parameter[3][@type='com.nostra13.universalimageloader.core.listener.ImageLoadingListener']]"
		[Register ("loadImage", "(Ljava/lang/String;Lcom/nostra13/universalimageloader/core/DisplayImageOptions;Lcom/nostra13/universalimageloader/core/listener/ImageLoadingListener;)V", "GetLoadImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_Handler")]
		public virtual unsafe void LoadImage (string p0, global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions p1, global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingListener p2)
		{
			if (id_loadImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_ == IntPtr.Zero)
				id_loadImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_ = JNIEnv.GetMethodID (class_ref, "loadImage", "(Ljava/lang/String;Lcom/nostra13/universalimageloader/core/DisplayImageOptions;Lcom/nostra13/universalimageloader/core/listener/ImageLoadingListener;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_loadImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadImage", "(Ljava/lang/String;Lcom/nostra13/universalimageloader/core/DisplayImageOptions;Lcom/nostra13/universalimageloader/core/listener/ImageLoadingListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_loadImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_;
#pragma warning disable 0169
		static Delegate GetLoadImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_Handler ()
		{
			if (cb_loadImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_ == null)
				cb_loadImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_LoadImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_);
			return cb_loadImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_;
		}

		static void n_LoadImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Nostra13.Universalimageloader.Core.ImageLoader __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Nostra13.Universalimageloader.Core.Assist.ImageSize p1 = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.ImageSize> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions p2 = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingListener p3 = (global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingListener)global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingListener> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.LoadImage (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_loadImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='ImageLoader']/method[@name='loadImage' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.nostra13.universalimageloader.core.assist.ImageSize'] and parameter[3][@type='com.nostra13.universalimageloader.core.DisplayImageOptions'] and parameter[4][@type='com.nostra13.universalimageloader.core.listener.ImageLoadingListener']]"
		[Register ("loadImage", "(Ljava/lang/String;Lcom/nostra13/universalimageloader/core/assist/ImageSize;Lcom/nostra13/universalimageloader/core/DisplayImageOptions;Lcom/nostra13/universalimageloader/core/listener/ImageLoadingListener;)V", "GetLoadImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_Handler")]
		public virtual unsafe void LoadImage (string p0, global::Com.Nostra13.Universalimageloader.Core.Assist.ImageSize p1, global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions p2, global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingListener p3)
		{
			if (id_loadImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_ == IntPtr.Zero)
				id_loadImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_ = JNIEnv.GetMethodID (class_ref, "loadImage", "(Ljava/lang/String;Lcom/nostra13/universalimageloader/core/assist/ImageSize;Lcom/nostra13/universalimageloader/core/DisplayImageOptions;Lcom/nostra13/universalimageloader/core/listener/ImageLoadingListener;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_loadImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadImage", "(Ljava/lang/String;Lcom/nostra13/universalimageloader/core/assist/ImageSize;Lcom/nostra13/universalimageloader/core/DisplayImageOptions;Lcom/nostra13/universalimageloader/core/listener/ImageLoadingListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_loadImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingProgressListener_;
#pragma warning disable 0169
		static Delegate GetLoadImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingProgressListener_Handler ()
		{
			if (cb_loadImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingProgressListener_ == null)
				cb_loadImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingProgressListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_LoadImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingProgressListener_);
			return cb_loadImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingProgressListener_;
		}

		static void n_LoadImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingProgressListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Com.Nostra13.Universalimageloader.Core.ImageLoader __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Nostra13.Universalimageloader.Core.Assist.ImageSize p1 = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.ImageSize> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions p2 = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingListener p3 = (global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingListener)global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingListener> (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingProgressListener p4 = (global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingProgressListener)global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingProgressListener> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.LoadImage (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_loadImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingProgressListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='ImageLoader']/method[@name='loadImage' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.nostra13.universalimageloader.core.assist.ImageSize'] and parameter[3][@type='com.nostra13.universalimageloader.core.DisplayImageOptions'] and parameter[4][@type='com.nostra13.universalimageloader.core.listener.ImageLoadingListener'] and parameter[5][@type='com.nostra13.universalimageloader.core.listener.ImageLoadingProgressListener']]"
		[Register ("loadImage", "(Ljava/lang/String;Lcom/nostra13/universalimageloader/core/assist/ImageSize;Lcom/nostra13/universalimageloader/core/DisplayImageOptions;Lcom/nostra13/universalimageloader/core/listener/ImageLoadingListener;Lcom/nostra13/universalimageloader/core/listener/ImageLoadingProgressListener;)V", "GetLoadImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingProgressListener_Handler")]
		public virtual unsafe void LoadImage (string p0, global::Com.Nostra13.Universalimageloader.Core.Assist.ImageSize p1, global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions p2, global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingListener p3, global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingProgressListener p4)
		{
			if (id_loadImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingProgressListener_ == IntPtr.Zero)
				id_loadImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingProgressListener_ = JNIEnv.GetMethodID (class_ref, "loadImage", "(Ljava/lang/String;Lcom/nostra13/universalimageloader/core/assist/ImageSize;Lcom/nostra13/universalimageloader/core/DisplayImageOptions;Lcom/nostra13/universalimageloader/core/listener/ImageLoadingListener;Lcom/nostra13/universalimageloader/core/listener/ImageLoadingProgressListener;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_loadImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingProgressListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadImage", "(Ljava/lang/String;Lcom/nostra13/universalimageloader/core/assist/ImageSize;Lcom/nostra13/universalimageloader/core/DisplayImageOptions;Lcom/nostra13/universalimageloader/core/listener/ImageLoadingListener;Lcom/nostra13/universalimageloader/core/listener/ImageLoadingProgressListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_loadImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_;
#pragma warning disable 0169
		static Delegate GetLoadImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_Handler ()
		{
			if (cb_loadImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_ == null)
				cb_loadImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_LoadImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_);
			return cb_loadImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_;
		}

		static void n_LoadImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Nostra13.Universalimageloader.Core.ImageLoader __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Nostra13.Universalimageloader.Core.Assist.ImageSize p1 = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.ImageSize> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingListener p2 = (global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingListener)global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.LoadImage (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_loadImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='ImageLoader']/method[@name='loadImage' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.nostra13.universalimageloader.core.assist.ImageSize'] and parameter[3][@type='com.nostra13.universalimageloader.core.listener.ImageLoadingListener']]"
		[Register ("loadImage", "(Ljava/lang/String;Lcom/nostra13/universalimageloader/core/assist/ImageSize;Lcom/nostra13/universalimageloader/core/listener/ImageLoadingListener;)V", "GetLoadImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_Handler")]
		public virtual unsafe void LoadImage (string p0, global::Com.Nostra13.Universalimageloader.Core.Assist.ImageSize p1, global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingListener p2)
		{
			if (id_loadImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_ == IntPtr.Zero)
				id_loadImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_ = JNIEnv.GetMethodID (class_ref, "loadImage", "(Ljava/lang/String;Lcom/nostra13/universalimageloader/core/assist/ImageSize;Lcom/nostra13/universalimageloader/core/listener/ImageLoadingListener;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_loadImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadImage", "(Ljava/lang/String;Lcom/nostra13/universalimageloader/core/assist/ImageSize;Lcom/nostra13/universalimageloader/core/listener/ImageLoadingListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_loadImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_;
#pragma warning disable 0169
		static Delegate GetLoadImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_Handler ()
		{
			if (cb_loadImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_ == null)
				cb_loadImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_LoadImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_);
			return cb_loadImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_;
		}

		static void n_LoadImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Nostra13.Universalimageloader.Core.ImageLoader __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingListener p1 = (global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingListener)global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.LoadImage (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_loadImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='ImageLoader']/method[@name='loadImage' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.nostra13.universalimageloader.core.listener.ImageLoadingListener']]"
		[Register ("loadImage", "(Ljava/lang/String;Lcom/nostra13/universalimageloader/core/listener/ImageLoadingListener;)V", "GetLoadImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_Handler")]
		public virtual unsafe void LoadImage (string p0, global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingListener p1)
		{
			if (id_loadImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_ == IntPtr.Zero)
				id_loadImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_ = JNIEnv.GetMethodID (class_ref, "loadImage", "(Ljava/lang/String;Lcom/nostra13/universalimageloader/core/listener/ImageLoadingListener;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_loadImage_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadImage", "(Ljava/lang/String;Lcom/nostra13/universalimageloader/core/listener/ImageLoadingListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_loadImageSync_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLoadImageSync_Ljava_lang_String_Handler ()
		{
			if (cb_loadImageSync_Ljava_lang_String_ == null)
				cb_loadImageSync_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_LoadImageSync_Ljava_lang_String_);
			return cb_loadImageSync_Ljava_lang_String_;
		}

		static IntPtr n_LoadImageSync_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nostra13.Universalimageloader.Core.ImageLoader __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.LoadImageSync (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_loadImageSync_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='ImageLoader']/method[@name='loadImageSync' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("loadImageSync", "(Ljava/lang/String;)Landroid/graphics/Bitmap;", "GetLoadImageSync_Ljava_lang_String_Handler")]
		public virtual unsafe global::Android.Graphics.Bitmap LoadImageSync (string p0)
		{
			if (id_loadImageSync_Ljava_lang_String_ == IntPtr.Zero)
				id_loadImageSync_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "loadImageSync", "(Ljava/lang/String;)Landroid/graphics/Bitmap;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Android.Graphics.Bitmap __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod  (Handle, id_loadImageSync_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadImageSync", "(Ljava/lang/String;)Landroid/graphics/Bitmap;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_loadImageSync_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_;
#pragma warning disable 0169
		static Delegate GetLoadImageSync_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Handler ()
		{
			if (cb_loadImageSync_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_ == null)
				cb_loadImageSync_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_LoadImageSync_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_);
			return cb_loadImageSync_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_;
		}

		static IntPtr n_LoadImageSync_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Nostra13.Universalimageloader.Core.ImageLoader __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions p1 = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.LoadImageSync (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_loadImageSync_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='ImageLoader']/method[@name='loadImageSync' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.nostra13.universalimageloader.core.DisplayImageOptions']]"
		[Register ("loadImageSync", "(Ljava/lang/String;Lcom/nostra13/universalimageloader/core/DisplayImageOptions;)Landroid/graphics/Bitmap;", "GetLoadImageSync_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Handler")]
		public virtual unsafe global::Android.Graphics.Bitmap LoadImageSync (string p0, global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions p1)
		{
			if (id_loadImageSync_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_ == IntPtr.Zero)
				id_loadImageSync_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_ = JNIEnv.GetMethodID (class_ref, "loadImageSync", "(Ljava/lang/String;Lcom/nostra13/universalimageloader/core/DisplayImageOptions;)Landroid/graphics/Bitmap;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				global::Android.Graphics.Bitmap __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod  (Handle, id_loadImageSync_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadImageSync", "(Ljava/lang/String;Lcom/nostra13/universalimageloader/core/DisplayImageOptions;)Landroid/graphics/Bitmap;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_loadImageSync_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_;
#pragma warning disable 0169
		static Delegate GetLoadImageSync_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Handler ()
		{
			if (cb_loadImageSync_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_ == null)
				cb_loadImageSync_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_LoadImageSync_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_);
			return cb_loadImageSync_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_;
		}

		static IntPtr n_LoadImageSync_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Nostra13.Universalimageloader.Core.ImageLoader __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Nostra13.Universalimageloader.Core.Assist.ImageSize p1 = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.ImageSize> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.LoadImageSync (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_loadImageSync_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='ImageLoader']/method[@name='loadImageSync' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.nostra13.universalimageloader.core.assist.ImageSize']]"
		[Register ("loadImageSync", "(Ljava/lang/String;Lcom/nostra13/universalimageloader/core/assist/ImageSize;)Landroid/graphics/Bitmap;", "GetLoadImageSync_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Handler")]
		public virtual unsafe global::Android.Graphics.Bitmap LoadImageSync (string p0, global::Com.Nostra13.Universalimageloader.Core.Assist.ImageSize p1)
		{
			if (id_loadImageSync_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_ == IntPtr.Zero)
				id_loadImageSync_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_ = JNIEnv.GetMethodID (class_ref, "loadImageSync", "(Ljava/lang/String;Lcom/nostra13/universalimageloader/core/assist/ImageSize;)Landroid/graphics/Bitmap;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				global::Android.Graphics.Bitmap __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod  (Handle, id_loadImageSync_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadImageSync", "(Ljava/lang/String;Lcom/nostra13/universalimageloader/core/assist/ImageSize;)Landroid/graphics/Bitmap;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_loadImageSync_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_;
#pragma warning disable 0169
		static Delegate GetLoadImageSync_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Handler ()
		{
			if (cb_loadImageSync_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_ == null)
				cb_loadImageSync_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_LoadImageSync_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_);
			return cb_loadImageSync_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_;
		}

		static IntPtr n_LoadImageSync_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Nostra13.Universalimageloader.Core.ImageLoader __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Nostra13.Universalimageloader.Core.Assist.ImageSize p1 = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.ImageSize> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions p2 = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.LoadImageSync (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_loadImageSync_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='ImageLoader']/method[@name='loadImageSync' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.nostra13.universalimageloader.core.assist.ImageSize'] and parameter[3][@type='com.nostra13.universalimageloader.core.DisplayImageOptions']]"
		[Register ("loadImageSync", "(Ljava/lang/String;Lcom/nostra13/universalimageloader/core/assist/ImageSize;Lcom/nostra13/universalimageloader/core/DisplayImageOptions;)Landroid/graphics/Bitmap;", "GetLoadImageSync_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_Handler")]
		public virtual unsafe global::Android.Graphics.Bitmap LoadImageSync (string p0, global::Com.Nostra13.Universalimageloader.Core.Assist.ImageSize p1, global::Com.Nostra13.Universalimageloader.Core.DisplayImageOptions p2)
		{
			if (id_loadImageSync_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_ == IntPtr.Zero)
				id_loadImageSync_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_ = JNIEnv.GetMethodID (class_ref, "loadImageSync", "(Ljava/lang/String;Lcom/nostra13/universalimageloader/core/assist/ImageSize;Lcom/nostra13/universalimageloader/core/DisplayImageOptions;)Landroid/graphics/Bitmap;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				global::Android.Graphics.Bitmap __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod  (Handle, id_loadImageSync_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_DisplayImageOptions_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadImageSync", "(Ljava/lang/String;Lcom/nostra13/universalimageloader/core/assist/ImageSize;Lcom/nostra13/universalimageloader/core/DisplayImageOptions;)Landroid/graphics/Bitmap;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_pause;
#pragma warning disable 0169
		static Delegate GetPauseHandler ()
		{
			if (cb_pause == null)
				cb_pause = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Pause);
			return cb_pause;
		}

		static void n_Pause (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Core.ImageLoader __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Pause ();
		}
#pragma warning restore 0169

		static IntPtr id_pause;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='ImageLoader']/method[@name='pause' and count(parameter)=0]"
		[Register ("pause", "()V", "GetPauseHandler")]
		public virtual unsafe void Pause ()
		{
			if (id_pause == IntPtr.Zero)
				id_pause = JNIEnv.GetMethodID (class_ref, "pause", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_pause);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "pause", "()V"));
			} finally {
			}
		}

		static Delegate cb_resume;
#pragma warning disable 0169
		static Delegate GetResumeHandler ()
		{
			if (cb_resume == null)
				cb_resume = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Resume);
			return cb_resume;
		}

		static void n_Resume (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Core.ImageLoader __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Resume ();
		}
#pragma warning restore 0169

		static IntPtr id_resume;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='ImageLoader']/method[@name='resume' and count(parameter)=0]"
		[Register ("resume", "()V", "GetResumeHandler")]
		public virtual unsafe void Resume ()
		{
			if (id_resume == IntPtr.Zero)
				id_resume = JNIEnv.GetMethodID (class_ref, "resume", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_resume);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "resume", "()V"));
			} finally {
			}
		}

		static Delegate cb_setDefaultLoadingListener_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_;
#pragma warning disable 0169
		static Delegate GetSetDefaultLoadingListener_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_Handler ()
		{
			if (cb_setDefaultLoadingListener_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_ == null)
				cb_setDefaultLoadingListener_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDefaultLoadingListener_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_);
			return cb_setDefaultLoadingListener_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_;
		}

		static void n_SetDefaultLoadingListener_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nostra13.Universalimageloader.Core.ImageLoader __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingListener p0 = (global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingListener)global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetDefaultLoadingListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDefaultLoadingListener_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='ImageLoader']/method[@name='setDefaultLoadingListener' and count(parameter)=1 and parameter[1][@type='com.nostra13.universalimageloader.core.listener.ImageLoadingListener']]"
		[Register ("setDefaultLoadingListener", "(Lcom/nostra13/universalimageloader/core/listener/ImageLoadingListener;)V", "GetSetDefaultLoadingListener_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_Handler")]
		public virtual unsafe void SetDefaultLoadingListener (global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingListener p0)
		{
			if (id_setDefaultLoadingListener_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_ == IntPtr.Zero)
				id_setDefaultLoadingListener_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_ = JNIEnv.GetMethodID (class_ref, "setDefaultLoadingListener", "(Lcom/nostra13/universalimageloader/core/listener/ImageLoadingListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setDefaultLoadingListener_Lcom_nostra13_universalimageloader_core_listener_ImageLoadingListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDefaultLoadingListener", "(Lcom/nostra13/universalimageloader/core/listener/ImageLoadingListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Stop);
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Core.ImageLoader __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.ImageLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		static IntPtr id_stop;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core']/class[@name='ImageLoader']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public virtual unsafe void Stop ()
		{
			if (id_stop == IntPtr.Zero)
				id_stop = JNIEnv.GetMethodID (class_ref, "stop", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_stop);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stop", "()V"));
			} finally {
			}
		}

#region "Event implementation for Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingListener"
		public event EventHandler<global::Com.Nostra13.Universalimageloader.Core.Listener.LoadingCancelledEventArgs> LoadingCancelled {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingListener, global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingListenerImplementor>(
						ref weak_implementor_SetDefaultLoadingListener,
						__CreateIImageLoadingListenerImplementor,
						SetDefaultLoadingListener,
						__h => __h.OnLoadingCancelledHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingListener, global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingListenerImplementor>(
						ref weak_implementor_SetDefaultLoadingListener,
						global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingListenerImplementor.__IsEmpty,
						__v => SetDefaultLoadingListener (null),
						__h => __h.OnLoadingCancelledHandler -= value);
			}
		}

		public event EventHandler<global::Com.Nostra13.Universalimageloader.Core.Listener.LoadingCompleteEventArgs> LoadingComplete {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingListener, global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingListenerImplementor>(
						ref weak_implementor_SetDefaultLoadingListener,
						__CreateIImageLoadingListenerImplementor,
						SetDefaultLoadingListener,
						__h => __h.OnLoadingCompleteHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingListener, global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingListenerImplementor>(
						ref weak_implementor_SetDefaultLoadingListener,
						global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingListenerImplementor.__IsEmpty,
						__v => SetDefaultLoadingListener (null),
						__h => __h.OnLoadingCompleteHandler -= value);
			}
		}

		public event EventHandler<global::Com.Nostra13.Universalimageloader.Core.Listener.LoadingFailedEventArgs> LoadingFailed {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingListener, global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingListenerImplementor>(
						ref weak_implementor_SetDefaultLoadingListener,
						__CreateIImageLoadingListenerImplementor,
						SetDefaultLoadingListener,
						__h => __h.OnLoadingFailedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingListener, global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingListenerImplementor>(
						ref weak_implementor_SetDefaultLoadingListener,
						global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingListenerImplementor.__IsEmpty,
						__v => SetDefaultLoadingListener (null),
						__h => __h.OnLoadingFailedHandler -= value);
			}
		}

		public event EventHandler<global::Com.Nostra13.Universalimageloader.Core.Listener.LoadingStartedEventArgs> LoadingStarted {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingListener, global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingListenerImplementor>(
						ref weak_implementor_SetDefaultLoadingListener,
						__CreateIImageLoadingListenerImplementor,
						SetDefaultLoadingListener,
						__h => __h.OnLoadingStartedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingListener, global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingListenerImplementor>(
						ref weak_implementor_SetDefaultLoadingListener,
						global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingListenerImplementor.__IsEmpty,
						__v => SetDefaultLoadingListener (null),
						__h => __h.OnLoadingStartedHandler -= value);
			}
		}

		WeakReference weak_implementor_SetDefaultLoadingListener;

		global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingListenerImplementor __CreateIImageLoadingListenerImplementor ()
		{
			return new global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingListenerImplementor (this);
		}
#endregion
	}
}
