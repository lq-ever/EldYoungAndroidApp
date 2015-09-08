using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nostra13.Universalimageloader.Core.Assist {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='ViewScaleType']"
	[global::Android.Runtime.Register ("com/nostra13/universalimageloader/core/assist/ViewScaleType", DoNotGenerateAcw=true)]
	public sealed partial class ViewScaleType : global::Java.Lang.Enum {


		static IntPtr CROP_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='ViewScaleType']/field[@name='CROP']"
		[Register ("CROP")]
		public static global::Com.Nostra13.Universalimageloader.Core.Assist.ViewScaleType Crop {
			get {
				if (CROP_jfieldId == IntPtr.Zero)
					CROP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CROP", "Lcom/nostra13/universalimageloader/core/assist/ViewScaleType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CROP_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.ViewScaleType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr FIT_INSIDE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='ViewScaleType']/field[@name='FIT_INSIDE']"
		[Register ("FIT_INSIDE")]
		public static global::Com.Nostra13.Universalimageloader.Core.Assist.ViewScaleType FitInside {
			get {
				if (FIT_INSIDE_jfieldId == IntPtr.Zero)
					FIT_INSIDE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FIT_INSIDE", "Lcom/nostra13/universalimageloader/core/assist/ViewScaleType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FIT_INSIDE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.ViewScaleType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nostra13/universalimageloader/core/assist/ViewScaleType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ViewScaleType); }
		}

		internal ViewScaleType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_fromImageView_Landroid_widget_ImageView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='ViewScaleType']/method[@name='fromImageView' and count(parameter)=1 and parameter[1][@type='android.widget.ImageView']]"
		[Register ("fromImageView", "(Landroid/widget/ImageView;)Lcom/nostra13/universalimageloader/core/assist/ViewScaleType;", "")]
		public static unsafe global::Com.Nostra13.Universalimageloader.Core.Assist.ViewScaleType FromImageView (global::Android.Widget.ImageView p0)
		{
			if (id_fromImageView_Landroid_widget_ImageView_ == IntPtr.Zero)
				id_fromImageView_Landroid_widget_ImageView_ = JNIEnv.GetStaticMethodID (class_ref, "fromImageView", "(Landroid/widget/ImageView;)Lcom/nostra13/universalimageloader/core/assist/ViewScaleType;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Nostra13.Universalimageloader.Core.Assist.ViewScaleType __ret = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.ViewScaleType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromImageView_Landroid_widget_ImageView_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='ViewScaleType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/nostra13/universalimageloader/core/assist/ViewScaleType;", "")]
		public static unsafe global::Com.Nostra13.Universalimageloader.Core.Assist.ViewScaleType ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/nostra13/universalimageloader/core/assist/ViewScaleType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Nostra13.Universalimageloader.Core.Assist.ViewScaleType __ret = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.ViewScaleType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist']/class[@name='ViewScaleType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/nostra13/universalimageloader/core/assist/ViewScaleType;", "")]
		public static unsafe global::Com.Nostra13.Universalimageloader.Core.Assist.ViewScaleType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/nostra13/universalimageloader/core/assist/ViewScaleType;");
			try {
				return (global::Com.Nostra13.Universalimageloader.Core.Assist.ViewScaleType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Nostra13.Universalimageloader.Core.Assist.ViewScaleType));
			} finally {
			}
		}

	}
}
