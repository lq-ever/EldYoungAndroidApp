using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nostra13.Universalimageloader.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.utils']/class[@name='ImageSizeUtils']"
	[global::Android.Runtime.Register ("com/nostra13/universalimageloader/utils/ImageSizeUtils", DoNotGenerateAcw=true)]
	public sealed partial class ImageSizeUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nostra13/universalimageloader/utils/ImageSizeUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ImageSizeUtils); }
		}

		internal ImageSizeUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_computeImageSampleSize_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_assist_ViewScaleType_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.utils']/class[@name='ImageSizeUtils']/method[@name='computeImageSampleSize' and count(parameter)=4 and parameter[1][@type='com.nostra13.universalimageloader.core.assist.ImageSize'] and parameter[2][@type='com.nostra13.universalimageloader.core.assist.ImageSize'] and parameter[3][@type='com.nostra13.universalimageloader.core.assist.ViewScaleType'] and parameter[4][@type='boolean']]"
		[Register ("computeImageSampleSize", "(Lcom/nostra13/universalimageloader/core/assist/ImageSize;Lcom/nostra13/universalimageloader/core/assist/ImageSize;Lcom/nostra13/universalimageloader/core/assist/ViewScaleType;Z)I", "")]
		public static unsafe int ComputeImageSampleSize (global::Com.Nostra13.Universalimageloader.Core.Assist.ImageSize p0, global::Com.Nostra13.Universalimageloader.Core.Assist.ImageSize p1, global::Com.Nostra13.Universalimageloader.Core.Assist.ViewScaleType p2, bool p3)
		{
			if (id_computeImageSampleSize_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_assist_ViewScaleType_Z == IntPtr.Zero)
				id_computeImageSampleSize_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_assist_ViewScaleType_Z = JNIEnv.GetStaticMethodID (class_ref, "computeImageSampleSize", "(Lcom/nostra13/universalimageloader/core/assist/ImageSize;Lcom/nostra13/universalimageloader/core/assist/ImageSize;Lcom/nostra13/universalimageloader/core/assist/ViewScaleType;Z)I");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_computeImageSampleSize_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_assist_ViewScaleType_Z, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_computeImageScale_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_assist_ViewScaleType_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.utils']/class[@name='ImageSizeUtils']/method[@name='computeImageScale' and count(parameter)=4 and parameter[1][@type='com.nostra13.universalimageloader.core.assist.ImageSize'] and parameter[2][@type='com.nostra13.universalimageloader.core.assist.ImageSize'] and parameter[3][@type='com.nostra13.universalimageloader.core.assist.ViewScaleType'] and parameter[4][@type='boolean']]"
		[Register ("computeImageScale", "(Lcom/nostra13/universalimageloader/core/assist/ImageSize;Lcom/nostra13/universalimageloader/core/assist/ImageSize;Lcom/nostra13/universalimageloader/core/assist/ViewScaleType;Z)F", "")]
		public static unsafe float ComputeImageScale (global::Com.Nostra13.Universalimageloader.Core.Assist.ImageSize p0, global::Com.Nostra13.Universalimageloader.Core.Assist.ImageSize p1, global::Com.Nostra13.Universalimageloader.Core.Assist.ViewScaleType p2, bool p3)
		{
			if (id_computeImageScale_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_assist_ViewScaleType_Z == IntPtr.Zero)
				id_computeImageScale_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_assist_ViewScaleType_Z = JNIEnv.GetStaticMethodID (class_ref, "computeImageScale", "(Lcom/nostra13/universalimageloader/core/assist/ImageSize;Lcom/nostra13/universalimageloader/core/assist/ImageSize;Lcom/nostra13/universalimageloader/core/assist/ViewScaleType;Z)F");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				float __ret = JNIEnv.CallStaticFloatMethod  (class_ref, id_computeImageScale_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_assist_ViewScaleType_Z, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_computeMinImageSampleSize_Lcom_nostra13_universalimageloader_core_assist_ImageSize_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.utils']/class[@name='ImageSizeUtils']/method[@name='computeMinImageSampleSize' and count(parameter)=1 and parameter[1][@type='com.nostra13.universalimageloader.core.assist.ImageSize']]"
		[Register ("computeMinImageSampleSize", "(Lcom/nostra13/universalimageloader/core/assist/ImageSize;)I", "")]
		public static unsafe int ComputeMinImageSampleSize (global::Com.Nostra13.Universalimageloader.Core.Assist.ImageSize p0)
		{
			if (id_computeMinImageSampleSize_Lcom_nostra13_universalimageloader_core_assist_ImageSize_ == IntPtr.Zero)
				id_computeMinImageSampleSize_Lcom_nostra13_universalimageloader_core_assist_ImageSize_ = JNIEnv.GetStaticMethodID (class_ref, "computeMinImageSampleSize", "(Lcom/nostra13/universalimageloader/core/assist/ImageSize;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_computeMinImageSampleSize_Lcom_nostra13_universalimageloader_core_assist_ImageSize_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_defineTargetSizeForView_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_assist_ImageSize_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.utils']/class[@name='ImageSizeUtils']/method[@name='defineTargetSizeForView' and count(parameter)=2 and parameter[1][@type='com.nostra13.universalimageloader.core.imageaware.ImageAware'] and parameter[2][@type='com.nostra13.universalimageloader.core.assist.ImageSize']]"
		[Register ("defineTargetSizeForView", "(Lcom/nostra13/universalimageloader/core/imageaware/ImageAware;Lcom/nostra13/universalimageloader/core/assist/ImageSize;)Lcom/nostra13/universalimageloader/core/assist/ImageSize;", "")]
		public static unsafe global::Com.Nostra13.Universalimageloader.Core.Assist.ImageSize DefineTargetSizeForView (global::Com.Nostra13.Universalimageloader.Core.Imageaware.IImageAware p0, global::Com.Nostra13.Universalimageloader.Core.Assist.ImageSize p1)
		{
			if (id_defineTargetSizeForView_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_assist_ImageSize_ == IntPtr.Zero)
				id_defineTargetSizeForView_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_assist_ImageSize_ = JNIEnv.GetStaticMethodID (class_ref, "defineTargetSizeForView", "(Lcom/nostra13/universalimageloader/core/imageaware/ImageAware;Lcom/nostra13/universalimageloader/core/assist/ImageSize;)Lcom/nostra13/universalimageloader/core/assist/ImageSize;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Com.Nostra13.Universalimageloader.Core.Assist.ImageSize __ret = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.ImageSize> (JNIEnv.CallStaticObjectMethod  (class_ref, id_defineTargetSizeForView_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_assist_ImageSize_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
