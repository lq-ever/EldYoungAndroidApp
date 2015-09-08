using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nostra13.Universalimageloader.Core.Display {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.core.display']/class[@name='FadeInBitmapDisplayer']"
	[global::Android.Runtime.Register ("com/nostra13/universalimageloader/core/display/FadeInBitmapDisplayer", DoNotGenerateAcw=true)]
	public partial class FadeInBitmapDisplayer : global::Java.Lang.Object, global::Com.Nostra13.Universalimageloader.Core.Display.IBitmapDisplayer {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nostra13/universalimageloader/core/display/FadeInBitmapDisplayer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FadeInBitmapDisplayer); }
		}

		protected FadeInBitmapDisplayer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_IZZZ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nostra13.universalimageloader.core.display']/class[@name='FadeInBitmapDisplayer']/constructor[@name='FadeInBitmapDisplayer' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean']]"
		[Register (".ctor", "(IZZZ)V", "")]
		public unsafe FadeInBitmapDisplayer (int p0, bool p1, bool p2, bool p3)
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
				if (GetType () != typeof (FadeInBitmapDisplayer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(IZZZ)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(IZZZ)V", __args);
					return;
				}

				if (id_ctor_IZZZ == IntPtr.Zero)
					id_ctor_IZZZ = JNIEnv.GetMethodID (class_ref, "<init>", "(IZZZ)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IZZZ, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_IZZZ, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nostra13.universalimageloader.core.display']/class[@name='FadeInBitmapDisplayer']/constructor[@name='FadeInBitmapDisplayer' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe FadeInBitmapDisplayer (int p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (FadeInBitmapDisplayer)) {
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

		static IntPtr id_animate_Landroid_view_View_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.display']/class[@name='FadeInBitmapDisplayer']/method[@name='animate' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='int']]"
		[Register ("animate", "(Landroid/view/View;I)V", "")]
		public static unsafe void Animate (global::Android.Views.View p0, int p1)
		{
			if (id_animate_Landroid_view_View_I == IntPtr.Zero)
				id_animate_Landroid_view_View_I = JNIEnv.GetStaticMethodID (class_ref, "animate", "(Landroid/view/View;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_animate_Landroid_view_View_I, __args);
			} finally {
			}
		}

		static Delegate cb_display_Landroid_graphics_Bitmap_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_assist_LoadedFrom_;
#pragma warning disable 0169
		static Delegate GetDisplay_Landroid_graphics_Bitmap_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_assist_LoadedFrom_Handler ()
		{
			if (cb_display_Landroid_graphics_Bitmap_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_assist_LoadedFrom_ == null)
				cb_display_Landroid_graphics_Bitmap_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_assist_LoadedFrom_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Display_Landroid_graphics_Bitmap_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_assist_LoadedFrom_);
			return cb_display_Landroid_graphics_Bitmap_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_assist_LoadedFrom_;
		}

		static void n_Display_Landroid_graphics_Bitmap_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_assist_LoadedFrom_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Nostra13.Universalimageloader.Core.Display.FadeInBitmapDisplayer __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Display.FadeInBitmapDisplayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Nostra13.Universalimageloader.Core.Imageaware.IImageAware p1 = (global::Com.Nostra13.Universalimageloader.Core.Imageaware.IImageAware)global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Imageaware.IImageAware> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Nostra13.Universalimageloader.Core.Assist.LoadedFrom p2 = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.LoadedFrom> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Display (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_display_Landroid_graphics_Bitmap_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_assist_LoadedFrom_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.display']/class[@name='FadeInBitmapDisplayer']/method[@name='display' and count(parameter)=3 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='com.nostra13.universalimageloader.core.imageaware.ImageAware'] and parameter[3][@type='com.nostra13.universalimageloader.core.assist.LoadedFrom']]"
		[Register ("display", "(Landroid/graphics/Bitmap;Lcom/nostra13/universalimageloader/core/imageaware/ImageAware;Lcom/nostra13/universalimageloader/core/assist/LoadedFrom;)V", "GetDisplay_Landroid_graphics_Bitmap_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_assist_LoadedFrom_Handler")]
		public virtual unsafe void Display (global::Android.Graphics.Bitmap p0, global::Com.Nostra13.Universalimageloader.Core.Imageaware.IImageAware p1, global::Com.Nostra13.Universalimageloader.Core.Assist.LoadedFrom p2)
		{
			if (id_display_Landroid_graphics_Bitmap_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_assist_LoadedFrom_ == IntPtr.Zero)
				id_display_Landroid_graphics_Bitmap_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_assist_LoadedFrom_ = JNIEnv.GetMethodID (class_ref, "display", "(Landroid/graphics/Bitmap;Lcom/nostra13/universalimageloader/core/imageaware/ImageAware;Lcom/nostra13/universalimageloader/core/assist/LoadedFrom;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_display_Landroid_graphics_Bitmap_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_assist_LoadedFrom_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "display", "(Landroid/graphics/Bitmap;Lcom/nostra13/universalimageloader/core/imageaware/ImageAware;Lcom/nostra13/universalimageloader/core/assist/LoadedFrom;)V"), __args);
			} finally {
			}
		}

	}
}
