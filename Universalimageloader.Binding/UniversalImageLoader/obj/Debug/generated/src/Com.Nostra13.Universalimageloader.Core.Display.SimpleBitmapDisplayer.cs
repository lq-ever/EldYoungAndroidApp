using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nostra13.Universalimageloader.Core.Display {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.core.display']/class[@name='SimpleBitmapDisplayer']"
	[global::Android.Runtime.Register ("com/nostra13/universalimageloader/core/display/SimpleBitmapDisplayer", DoNotGenerateAcw=true)]
	public sealed partial class SimpleBitmapDisplayer : global::Java.Lang.Object, global::Com.Nostra13.Universalimageloader.Core.Display.IBitmapDisplayer {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nostra13/universalimageloader/core/display/SimpleBitmapDisplayer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SimpleBitmapDisplayer); }
		}

		internal SimpleBitmapDisplayer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nostra13.universalimageloader.core.display']/class[@name='SimpleBitmapDisplayer']/constructor[@name='SimpleBitmapDisplayer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SimpleBitmapDisplayer ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (SimpleBitmapDisplayer)) {
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

		static IntPtr id_display_Landroid_graphics_Bitmap_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_assist_LoadedFrom_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.display']/class[@name='SimpleBitmapDisplayer']/method[@name='display' and count(parameter)=3 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='com.nostra13.universalimageloader.core.imageaware.ImageAware'] and parameter[3][@type='com.nostra13.universalimageloader.core.assist.LoadedFrom']]"
		[Register ("display", "(Landroid/graphics/Bitmap;Lcom/nostra13/universalimageloader/core/imageaware/ImageAware;Lcom/nostra13/universalimageloader/core/assist/LoadedFrom;)V", "")]
		public unsafe void Display (global::Android.Graphics.Bitmap p0, global::Com.Nostra13.Universalimageloader.Core.Imageaware.IImageAware p1, global::Com.Nostra13.Universalimageloader.Core.Assist.LoadedFrom p2)
		{
			if (id_display_Landroid_graphics_Bitmap_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_assist_LoadedFrom_ == IntPtr.Zero)
				id_display_Landroid_graphics_Bitmap_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_assist_LoadedFrom_ = JNIEnv.GetMethodID (class_ref, "display", "(Landroid/graphics/Bitmap;Lcom/nostra13/universalimageloader/core/imageaware/ImageAware;Lcom/nostra13/universalimageloader/core/assist/LoadedFrom;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod  (Handle, id_display_Landroid_graphics_Bitmap_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_assist_LoadedFrom_, __args);
			} finally {
			}
		}

	}
}
