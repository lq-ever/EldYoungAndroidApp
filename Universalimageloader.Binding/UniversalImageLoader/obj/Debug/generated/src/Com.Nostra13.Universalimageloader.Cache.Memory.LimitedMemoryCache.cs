using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nostra13.Universalimageloader.Cache.Memory {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.memory']/class[@name='LimitedMemoryCache']"
	[global::Android.Runtime.Register ("com/nostra13/universalimageloader/cache/memory/LimitedMemoryCache", DoNotGenerateAcw=true)]
	public abstract partial class LimitedMemoryCache : global::Com.Nostra13.Universalimageloader.Cache.Memory.BaseMemoryCache {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nostra13/universalimageloader/cache/memory/LimitedMemoryCache", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LimitedMemoryCache); }
		}

		protected LimitedMemoryCache (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.memory']/class[@name='LimitedMemoryCache']/constructor[@name='LimitedMemoryCache' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe LimitedMemoryCache (int p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (LimitedMemoryCache)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(I)V", __args);
					return;
				}

				if (id_ctor_I == IntPtr.Zero)
					id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_I, __args);
			} finally {
			}
		}

		static Delegate cb_getSizeLimit;
#pragma warning disable 0169
		static Delegate GetGetSizeLimitHandler ()
		{
			if (cb_getSizeLimit == null)
				cb_getSizeLimit = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSizeLimit);
			return cb_getSizeLimit;
		}

		static int n_GetSizeLimit (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Cache.Memory.LimitedMemoryCache __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Cache.Memory.LimitedMemoryCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SizeLimit;
		}
#pragma warning restore 0169

		static IntPtr id_getSizeLimit;
		protected virtual unsafe int SizeLimit {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.memory']/class[@name='LimitedMemoryCache']/method[@name='getSizeLimit' and count(parameter)=0]"
			[Register ("getSizeLimit", "()I", "GetGetSizeLimitHandler")]
			get {
				if (id_getSizeLimit == IntPtr.Zero)
					id_getSizeLimit = JNIEnv.GetMethodID (class_ref, "getSizeLimit", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getSizeLimit);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSizeLimit", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getSize_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetGetSize_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_getSize_Landroid_graphics_Bitmap_ == null)
				cb_getSize_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetSize_Landroid_graphics_Bitmap_);
			return cb_getSize_Landroid_graphics_Bitmap_;
		}

		static int n_GetSize_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nostra13.Universalimageloader.Cache.Memory.LimitedMemoryCache __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Cache.Memory.LimitedMemoryCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetSize (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.memory']/class[@name='LimitedMemoryCache']/method[@name='getSize' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("getSize", "(Landroid/graphics/Bitmap;)I", "GetGetSize_Landroid_graphics_Bitmap_Handler")]
		protected abstract int GetSize (global::Android.Graphics.Bitmap p0);

		static Delegate cb_removeNext;
#pragma warning disable 0169
		static Delegate GetRemoveNextHandler ()
		{
			if (cb_removeNext == null)
				cb_removeNext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_RemoveNext);
			return cb_removeNext;
		}

		static IntPtr n_RemoveNext (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Cache.Memory.LimitedMemoryCache __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Cache.Memory.LimitedMemoryCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RemoveNext ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.memory']/class[@name='LimitedMemoryCache']/method[@name='removeNext' and count(parameter)=0]"
		[Register ("removeNext", "()Landroid/graphics/Bitmap;", "GetRemoveNextHandler")]
		protected abstract global::Android.Graphics.Bitmap RemoveNext ();

	}

	[global::Android.Runtime.Register ("com/nostra13/universalimageloader/cache/memory/LimitedMemoryCache", DoNotGenerateAcw=true)]
	internal partial class LimitedMemoryCacheInvoker : LimitedMemoryCache {

		public LimitedMemoryCacheInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (LimitedMemoryCacheInvoker); }
		}

		static IntPtr id_getSize_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.memory']/class[@name='LimitedMemoryCache']/method[@name='getSize' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("getSize", "(Landroid/graphics/Bitmap;)I", "GetGetSize_Landroid_graphics_Bitmap_Handler")]
		protected override unsafe int GetSize (global::Android.Graphics.Bitmap p0)
		{
			if (id_getSize_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_getSize_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "getSize", "(Landroid/graphics/Bitmap;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				int __ret = JNIEnv.CallIntMethod  (Handle, id_getSize_Landroid_graphics_Bitmap_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_removeNext;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.memory']/class[@name='LimitedMemoryCache']/method[@name='removeNext' and count(parameter)=0]"
		[Register ("removeNext", "()Landroid/graphics/Bitmap;", "GetRemoveNextHandler")]
		protected override unsafe global::Android.Graphics.Bitmap RemoveNext ()
		{
			if (id_removeNext == IntPtr.Zero)
				id_removeNext = JNIEnv.GetMethodID (class_ref, "removeNext", "()Landroid/graphics/Bitmap;");
			try {
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod  (Handle, id_removeNext), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_createReference_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.memory']/class[@name='BaseMemoryCache']/method[@name='createReference' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("createReference", "(Landroid/graphics/Bitmap;)Ljava/lang/ref/Reference;", "GetCreateReference_Landroid_graphics_Bitmap_Handler")]
		protected override unsafe global::Java.Lang.Ref.Reference CreateReference (global::Android.Graphics.Bitmap p0)
		{
			if (id_createReference_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_createReference_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "createReference", "(Landroid/graphics/Bitmap;)Ljava/lang/ref/Reference;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Java.Lang.Ref.Reference __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Ref.Reference> (JNIEnv.CallObjectMethod  (Handle, id_createReference_Landroid_graphics_Bitmap_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}

}
