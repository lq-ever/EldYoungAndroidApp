using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nostra13.Universalimageloader.Core.Imageaware {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.core.imageaware']/class[@name='NonViewAware']"
	[global::Android.Runtime.Register ("com/nostra13/universalimageloader/core/imageaware/NonViewAware", DoNotGenerateAcw=true)]
	public partial class NonViewAware : global::Java.Lang.Object, global::Com.Nostra13.Universalimageloader.Core.Imageaware.IImageAware {


		static IntPtr imageSize_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.core.imageaware']/class[@name='NonViewAware']/field[@name='imageSize']"
		[Register ("imageSize")]
		protected global::Com.Nostra13.Universalimageloader.Core.Assist.ImageSize ImageSize {
			get {
				if (imageSize_jfieldId == IntPtr.Zero)
					imageSize_jfieldId = JNIEnv.GetFieldID (class_ref, "imageSize", "Lcom/nostra13/universalimageloader/core/assist/ImageSize;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, imageSize_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.ImageSize> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (imageSize_jfieldId == IntPtr.Zero)
					imageSize_jfieldId = JNIEnv.GetFieldID (class_ref, "imageSize", "Lcom/nostra13/universalimageloader/core/assist/ImageSize;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, imageSize_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr imageUri_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.core.imageaware']/class[@name='NonViewAware']/field[@name='imageUri']"
		[Register ("imageUri")]
		protected string ImageUri {
			get {
				if (imageUri_jfieldId == IntPtr.Zero)
					imageUri_jfieldId = JNIEnv.GetFieldID (class_ref, "imageUri", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, imageUri_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (imageUri_jfieldId == IntPtr.Zero)
					imageUri_jfieldId = JNIEnv.GetFieldID (class_ref, "imageUri", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, imageUri_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nostra13/universalimageloader/core/imageaware/NonViewAware", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NonViewAware); }
		}

		protected NonViewAware (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_assist_ViewScaleType_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nostra13.universalimageloader.core.imageaware']/class[@name='NonViewAware']/constructor[@name='NonViewAware' and count(parameter)=2 and parameter[1][@type='com.nostra13.universalimageloader.core.assist.ImageSize'] and parameter[2][@type='com.nostra13.universalimageloader.core.assist.ViewScaleType']]"
		[Register (".ctor", "(Lcom/nostra13/universalimageloader/core/assist/ImageSize;Lcom/nostra13/universalimageloader/core/assist/ViewScaleType;)V", "")]
		public unsafe NonViewAware (global::Com.Nostra13.Universalimageloader.Core.Assist.ImageSize p0, global::Com.Nostra13.Universalimageloader.Core.Assist.ViewScaleType p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (NonViewAware)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/nostra13/universalimageloader/core/assist/ImageSize;Lcom/nostra13/universalimageloader/core/assist/ViewScaleType;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/nostra13/universalimageloader/core/assist/ImageSize;Lcom/nostra13/universalimageloader/core/assist/ViewScaleType;)V", __args);
					return;
				}

				if (id_ctor_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_assist_ViewScaleType_ == IntPtr.Zero)
					id_ctor_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_assist_ViewScaleType_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/nostra13/universalimageloader/core/assist/ImageSize;Lcom/nostra13/universalimageloader/core/assist/ViewScaleType;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_assist_ViewScaleType_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_assist_ViewScaleType_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_assist_ViewScaleType_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nostra13.universalimageloader.core.imageaware']/class[@name='NonViewAware']/constructor[@name='NonViewAware' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.nostra13.universalimageloader.core.assist.ImageSize'] and parameter[3][@type='com.nostra13.universalimageloader.core.assist.ViewScaleType']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/nostra13/universalimageloader/core/assist/ImageSize;Lcom/nostra13/universalimageloader/core/assist/ViewScaleType;)V", "")]
		public unsafe NonViewAware (string p0, global::Com.Nostra13.Universalimageloader.Core.Assist.ImageSize p1, global::Com.Nostra13.Universalimageloader.Core.Assist.ViewScaleType p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (NonViewAware)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Lcom/nostra13/universalimageloader/core/assist/ImageSize;Lcom/nostra13/universalimageloader/core/assist/ViewScaleType;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Lcom/nostra13/universalimageloader/core/assist/ImageSize;Lcom/nostra13/universalimageloader/core/assist/ViewScaleType;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_assist_ViewScaleType_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_assist_ViewScaleType_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Lcom/nostra13/universalimageloader/core/assist/ImageSize;Lcom/nostra13/universalimageloader/core/assist/ViewScaleType;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_assist_ViewScaleType_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_assist_ViewScaleType_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getHeight;
#pragma warning disable 0169
		static Delegate GetGetHeightHandler ()
		{
			if (cb_getHeight == null)
				cb_getHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHeight);
			return cb_getHeight;
		}

		static int n_GetHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Core.Imageaware.NonViewAware __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Imageaware.NonViewAware> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Height;
		}
#pragma warning restore 0169

		static IntPtr id_getHeight;
		public virtual unsafe int Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.imageaware']/class[@name='NonViewAware']/method[@name='getHeight' and count(parameter)=0]"
			[Register ("getHeight", "()I", "GetGetHeightHandler")]
			get {
				if (id_getHeight == IntPtr.Zero)
					id_getHeight = JNIEnv.GetMethodID (class_ref, "getHeight", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getHeight);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHeight", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getId;
#pragma warning disable 0169
		static Delegate GetGetIdHandler ()
		{
			if (cb_getId == null)
				cb_getId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetId);
			return cb_getId;
		}

		static int n_GetId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Core.Imageaware.NonViewAware __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Imageaware.NonViewAware> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Id;
		}
#pragma warning restore 0169

		static IntPtr id_getId;
		public virtual unsafe int Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.imageaware']/class[@name='NonViewAware']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()I", "GetGetIdHandler")]
			get {
				if (id_getId == IntPtr.Zero)
					id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getId);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getId", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_isCollected;
#pragma warning disable 0169
		static Delegate GetIsCollectedHandler ()
		{
			if (cb_isCollected == null)
				cb_isCollected = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCollected);
			return cb_isCollected;
		}

		static bool n_IsCollected (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Core.Imageaware.NonViewAware __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Imageaware.NonViewAware> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCollected;
		}
#pragma warning restore 0169

		static IntPtr id_isCollected;
		public virtual unsafe bool IsCollected {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.imageaware']/class[@name='NonViewAware']/method[@name='isCollected' and count(parameter)=0]"
			[Register ("isCollected", "()Z", "GetIsCollectedHandler")]
			get {
				if (id_isCollected == IntPtr.Zero)
					id_isCollected = JNIEnv.GetMethodID (class_ref, "isCollected", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isCollected);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isCollected", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getScaleType;
#pragma warning disable 0169
		static Delegate GetGetScaleTypeHandler ()
		{
			if (cb_getScaleType == null)
				cb_getScaleType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetScaleType);
			return cb_getScaleType;
		}

		static IntPtr n_GetScaleType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Core.Imageaware.NonViewAware __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Imageaware.NonViewAware> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ScaleType);
		}
#pragma warning restore 0169

		static IntPtr id_getScaleType;
		public virtual unsafe global::Com.Nostra13.Universalimageloader.Core.Assist.ViewScaleType ScaleType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.imageaware']/class[@name='NonViewAware']/method[@name='getScaleType' and count(parameter)=0]"
			[Register ("getScaleType", "()Lcom/nostra13/universalimageloader/core/assist/ViewScaleType;", "GetGetScaleTypeHandler")]
			get {
				if (id_getScaleType == IntPtr.Zero)
					id_getScaleType = JNIEnv.GetMethodID (class_ref, "getScaleType", "()Lcom/nostra13/universalimageloader/core/assist/ViewScaleType;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.ViewScaleType> (JNIEnv.CallObjectMethod  (Handle, id_getScaleType), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.ViewScaleType> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getScaleType", "()Lcom/nostra13/universalimageloader/core/assist/ViewScaleType;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getWidth;
#pragma warning disable 0169
		static Delegate GetGetWidthHandler ()
		{
			if (cb_getWidth == null)
				cb_getWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetWidth);
			return cb_getWidth;
		}

		static int n_GetWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Core.Imageaware.NonViewAware __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Imageaware.NonViewAware> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Width;
		}
#pragma warning restore 0169

		static IntPtr id_getWidth;
		public virtual unsafe int Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.imageaware']/class[@name='NonViewAware']/method[@name='getWidth' and count(parameter)=0]"
			[Register ("getWidth", "()I", "GetGetWidthHandler")]
			get {
				if (id_getWidth == IntPtr.Zero)
					id_getWidth = JNIEnv.GetMethodID (class_ref, "getWidth", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getWidth);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWidth", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getWrappedView;
#pragma warning disable 0169
		static Delegate GetGetWrappedViewHandler ()
		{
			if (cb_getWrappedView == null)
				cb_getWrappedView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetWrappedView);
			return cb_getWrappedView;
		}

		static IntPtr n_GetWrappedView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Core.Imageaware.NonViewAware __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Imageaware.NonViewAware> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WrappedView);
		}
#pragma warning restore 0169

		static IntPtr id_getWrappedView;
		public virtual unsafe global::Android.Views.View WrappedView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.imageaware']/class[@name='NonViewAware']/method[@name='getWrappedView' and count(parameter)=0]"
			[Register ("getWrappedView", "()Landroid/view/View;", "GetGetWrappedViewHandler")]
			get {
				if (id_getWrappedView == IntPtr.Zero)
					id_getWrappedView = JNIEnv.GetMethodID (class_ref, "getWrappedView", "()Landroid/view/View;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod  (Handle, id_getWrappedView), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWrappedView", "()Landroid/view/View;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_setImageBitmap_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetSetImageBitmap_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_setImageBitmap_Landroid_graphics_Bitmap_ == null)
				cb_setImageBitmap_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SetImageBitmap_Landroid_graphics_Bitmap_);
			return cb_setImageBitmap_Landroid_graphics_Bitmap_;
		}

		static bool n_SetImageBitmap_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nostra13.Universalimageloader.Core.Imageaware.NonViewAware __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Imageaware.NonViewAware> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetImageBitmap (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setImageBitmap_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.imageaware']/class[@name='NonViewAware']/method[@name='setImageBitmap' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("setImageBitmap", "(Landroid/graphics/Bitmap;)Z", "GetSetImageBitmap_Landroid_graphics_Bitmap_Handler")]
		public virtual unsafe bool SetImageBitmap (global::Android.Graphics.Bitmap p0)
		{
			if (id_setImageBitmap_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_setImageBitmap_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "setImageBitmap", "(Landroid/graphics/Bitmap;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_setImageBitmap_Landroid_graphics_Bitmap_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setImageBitmap", "(Landroid/graphics/Bitmap;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setImageDrawable_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetImageDrawable_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setImageDrawable_Landroid_graphics_drawable_Drawable_ == null)
				cb_setImageDrawable_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SetImageDrawable_Landroid_graphics_drawable_Drawable_);
			return cb_setImageDrawable_Landroid_graphics_drawable_Drawable_;
		}

		static bool n_SetImageDrawable_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nostra13.Universalimageloader.Core.Imageaware.NonViewAware __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Imageaware.NonViewAware> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetImageDrawable (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setImageDrawable_Landroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.imageaware']/class[@name='NonViewAware']/method[@name='setImageDrawable' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("setImageDrawable", "(Landroid/graphics/drawable/Drawable;)Z", "GetSetImageDrawable_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe bool SetImageDrawable (global::Android.Graphics.Drawables.Drawable p0)
		{
			if (id_setImageDrawable_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_setImageDrawable_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "setImageDrawable", "(Landroid/graphics/drawable/Drawable;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_setImageDrawable_Landroid_graphics_drawable_Drawable_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setImageDrawable", "(Landroid/graphics/drawable/Drawable;)Z"), __args);
				return __ret;
			} finally {
			}
		}

	}
}
