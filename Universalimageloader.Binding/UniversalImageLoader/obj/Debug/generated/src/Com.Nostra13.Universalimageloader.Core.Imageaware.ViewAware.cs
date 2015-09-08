using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nostra13.Universalimageloader.Core.Imageaware {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.core.imageaware']/class[@name='ViewAware']"
	[global::Android.Runtime.Register ("com/nostra13/universalimageloader/core/imageaware/ViewAware", DoNotGenerateAcw=true)]
	public abstract partial class ViewAware : global::Java.Lang.Object, global::Com.Nostra13.Universalimageloader.Core.Imageaware.IImageAware {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.core.imageaware']/class[@name='ViewAware']/field[@name='WARN_CANT_SET_BITMAP']"
		[Register ("WARN_CANT_SET_BITMAP")]
		public const string WarnCantSetBitmap = (string) "Can't set a bitmap into view. You should call ImageLoader on UI thread for it.";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.core.imageaware']/class[@name='ViewAware']/field[@name='WARN_CANT_SET_DRAWABLE']"
		[Register ("WARN_CANT_SET_DRAWABLE")]
		public const string WarnCantSetDrawable = (string) "Can't set a drawable into view. You should call ImageLoader on UI thread for it.";

		static IntPtr checkActualViewSize_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.core.imageaware']/class[@name='ViewAware']/field[@name='checkActualViewSize']"
		[Register ("checkActualViewSize")]
		protected bool CheckActualViewSize {
			get {
				if (checkActualViewSize_jfieldId == IntPtr.Zero)
					checkActualViewSize_jfieldId = JNIEnv.GetFieldID (class_ref, "checkActualViewSize", "Z");
				return JNIEnv.GetBooleanField (Handle, checkActualViewSize_jfieldId);
			}
			set {
				if (checkActualViewSize_jfieldId == IntPtr.Zero)
					checkActualViewSize_jfieldId = JNIEnv.GetFieldID (class_ref, "checkActualViewSize", "Z");
				try {
					JNIEnv.SetField (Handle, checkActualViewSize_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr viewRef_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.core.imageaware']/class[@name='ViewAware']/field[@name='viewRef']"
		[Register ("viewRef")]
		protected global::Java.Lang.Ref.Reference ViewRef {
			get {
				if (viewRef_jfieldId == IntPtr.Zero)
					viewRef_jfieldId = JNIEnv.GetFieldID (class_ref, "viewRef", "Ljava/lang/ref/Reference;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, viewRef_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Ref.Reference> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (viewRef_jfieldId == IntPtr.Zero)
					viewRef_jfieldId = JNIEnv.GetFieldID (class_ref, "viewRef", "Ljava/lang/ref/Reference;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, viewRef_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nostra13/universalimageloader/core/imageaware/ViewAware", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ViewAware); }
		}

		protected ViewAware (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_view_View_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nostra13.universalimageloader.core.imageaware']/class[@name='ViewAware']/constructor[@name='ViewAware' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register (".ctor", "(Landroid/view/View;)V", "")]
		public unsafe ViewAware (global::Android.Views.View p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (ViewAware)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/view/View;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/view/View;)V", __args);
					return;
				}

				if (id_ctor_Landroid_view_View_ == IntPtr.Zero)
					id_ctor_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/view/View;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_view_View_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_view_View_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_view_View_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nostra13.universalimageloader.core.imageaware']/class[@name='ViewAware']/constructor[@name='ViewAware' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(Landroid/view/View;Z)V", "")]
		public unsafe ViewAware (global::Android.Views.View p0, bool p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (ViewAware)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/view/View;Z)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/view/View;Z)V", __args);
					return;
				}

				if (id_ctor_Landroid_view_View_Z == IntPtr.Zero)
					id_ctor_Landroid_view_View_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/view/View;Z)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_view_View_Z, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_view_View_Z, __args);
			} finally {
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
			global::Com.Nostra13.Universalimageloader.Core.Imageaware.ViewAware __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Imageaware.ViewAware> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Height;
		}
#pragma warning restore 0169

		static IntPtr id_getHeight;
		public virtual unsafe int Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.imageaware']/class[@name='ViewAware']/method[@name='getHeight' and count(parameter)=0]"
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
			global::Com.Nostra13.Universalimageloader.Core.Imageaware.ViewAware __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Imageaware.ViewAware> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Id;
		}
#pragma warning restore 0169

		static IntPtr id_getId;
		public virtual unsafe int Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.imageaware']/class[@name='ViewAware']/method[@name='getId' and count(parameter)=0]"
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
			global::Com.Nostra13.Universalimageloader.Core.Imageaware.ViewAware __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Imageaware.ViewAware> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCollected;
		}
#pragma warning restore 0169

		static IntPtr id_isCollected;
		public virtual unsafe bool IsCollected {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.imageaware']/class[@name='ViewAware']/method[@name='isCollected' and count(parameter)=0]"
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
			global::Com.Nostra13.Universalimageloader.Core.Imageaware.ViewAware __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Imageaware.ViewAware> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ScaleType);
		}
#pragma warning restore 0169

		static IntPtr id_getScaleType;
		public virtual unsafe global::Com.Nostra13.Universalimageloader.Core.Assist.ViewScaleType ScaleType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.imageaware']/class[@name='ViewAware']/method[@name='getScaleType' and count(parameter)=0]"
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
			global::Com.Nostra13.Universalimageloader.Core.Imageaware.ViewAware __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Imageaware.ViewAware> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Width;
		}
#pragma warning restore 0169

		static IntPtr id_getWidth;
		public virtual unsafe int Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.imageaware']/class[@name='ViewAware']/method[@name='getWidth' and count(parameter)=0]"
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
			global::Com.Nostra13.Universalimageloader.Core.Imageaware.ViewAware __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Imageaware.ViewAware> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WrappedView);
		}
#pragma warning restore 0169

		static IntPtr id_getWrappedView;
		public virtual unsafe global::Android.Views.View WrappedView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.imageaware']/class[@name='ViewAware']/method[@name='getWrappedView' and count(parameter)=0]"
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
			global::Com.Nostra13.Universalimageloader.Core.Imageaware.ViewAware __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Imageaware.ViewAware> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetImageBitmap (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setImageBitmap_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.imageaware']/class[@name='ViewAware']/method[@name='setImageBitmap' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
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

		static Delegate cb_setImageBitmapInto_Landroid_graphics_Bitmap_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetSetImageBitmapInto_Landroid_graphics_Bitmap_Landroid_view_View_Handler ()
		{
			if (cb_setImageBitmapInto_Landroid_graphics_Bitmap_Landroid_view_View_ == null)
				cb_setImageBitmapInto_Landroid_graphics_Bitmap_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetImageBitmapInto_Landroid_graphics_Bitmap_Landroid_view_View_);
			return cb_setImageBitmapInto_Landroid_graphics_Bitmap_Landroid_view_View_;
		}

		static void n_SetImageBitmapInto_Landroid_graphics_Bitmap_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Nostra13.Universalimageloader.Core.Imageaware.ViewAware __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Imageaware.ViewAware> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetImageBitmapInto (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.imageaware']/class[@name='ViewAware']/method[@name='setImageBitmapInto' and count(parameter)=2 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='android.view.View']]"
		[Register ("setImageBitmapInto", "(Landroid/graphics/Bitmap;Landroid/view/View;)V", "GetSetImageBitmapInto_Landroid_graphics_Bitmap_Landroid_view_View_Handler")]
		protected abstract void SetImageBitmapInto (global::Android.Graphics.Bitmap p0, global::Android.Views.View p1);

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
			global::Com.Nostra13.Universalimageloader.Core.Imageaware.ViewAware __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Imageaware.ViewAware> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetImageDrawable (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setImageDrawable_Landroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.imageaware']/class[@name='ViewAware']/method[@name='setImageDrawable' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
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

		static Delegate cb_setImageDrawableInto_Landroid_graphics_drawable_Drawable_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetSetImageDrawableInto_Landroid_graphics_drawable_Drawable_Landroid_view_View_Handler ()
		{
			if (cb_setImageDrawableInto_Landroid_graphics_drawable_Drawable_Landroid_view_View_ == null)
				cb_setImageDrawableInto_Landroid_graphics_drawable_Drawable_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetImageDrawableInto_Landroid_graphics_drawable_Drawable_Landroid_view_View_);
			return cb_setImageDrawableInto_Landroid_graphics_drawable_Drawable_Landroid_view_View_;
		}

		static void n_SetImageDrawableInto_Landroid_graphics_drawable_Drawable_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Nostra13.Universalimageloader.Core.Imageaware.ViewAware __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Imageaware.ViewAware> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetImageDrawableInto (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.imageaware']/class[@name='ViewAware']/method[@name='setImageDrawableInto' and count(parameter)=2 and parameter[1][@type='android.graphics.drawable.Drawable'] and parameter[2][@type='android.view.View']]"
		[Register ("setImageDrawableInto", "(Landroid/graphics/drawable/Drawable;Landroid/view/View;)V", "GetSetImageDrawableInto_Landroid_graphics_drawable_Drawable_Landroid_view_View_Handler")]
		protected abstract void SetImageDrawableInto (global::Android.Graphics.Drawables.Drawable p0, global::Android.Views.View p1);

	}

	[global::Android.Runtime.Register ("com/nostra13/universalimageloader/core/imageaware/ViewAware", DoNotGenerateAcw=true)]
	internal partial class ViewAwareInvoker : ViewAware {

		public ViewAwareInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (ViewAwareInvoker); }
		}

		static IntPtr id_setImageBitmapInto_Landroid_graphics_Bitmap_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.imageaware']/class[@name='ViewAware']/method[@name='setImageBitmapInto' and count(parameter)=2 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='android.view.View']]"
		[Register ("setImageBitmapInto", "(Landroid/graphics/Bitmap;Landroid/view/View;)V", "GetSetImageBitmapInto_Landroid_graphics_Bitmap_Landroid_view_View_Handler")]
		protected override unsafe void SetImageBitmapInto (global::Android.Graphics.Bitmap p0, global::Android.Views.View p1)
		{
			if (id_setImageBitmapInto_Landroid_graphics_Bitmap_Landroid_view_View_ == IntPtr.Zero)
				id_setImageBitmapInto_Landroid_graphics_Bitmap_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "setImageBitmapInto", "(Landroid/graphics/Bitmap;Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod  (Handle, id_setImageBitmapInto_Landroid_graphics_Bitmap_Landroid_view_View_, __args);
			} finally {
			}
		}

		static IntPtr id_setImageDrawableInto_Landroid_graphics_drawable_Drawable_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.imageaware']/class[@name='ViewAware']/method[@name='setImageDrawableInto' and count(parameter)=2 and parameter[1][@type='android.graphics.drawable.Drawable'] and parameter[2][@type='android.view.View']]"
		[Register ("setImageDrawableInto", "(Landroid/graphics/drawable/Drawable;Landroid/view/View;)V", "GetSetImageDrawableInto_Landroid_graphics_drawable_Drawable_Landroid_view_View_Handler")]
		protected override unsafe void SetImageDrawableInto (global::Android.Graphics.Drawables.Drawable p0, global::Android.Views.View p1)
		{
			if (id_setImageDrawableInto_Landroid_graphics_drawable_Drawable_Landroid_view_View_ == IntPtr.Zero)
				id_setImageDrawableInto_Landroid_graphics_drawable_Drawable_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "setImageDrawableInto", "(Landroid/graphics/drawable/Drawable;Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod  (Handle, id_setImageDrawableInto_Landroid_graphics_drawable_Drawable_Landroid_view_View_, __args);
			} finally {
			}
		}

	}

}
