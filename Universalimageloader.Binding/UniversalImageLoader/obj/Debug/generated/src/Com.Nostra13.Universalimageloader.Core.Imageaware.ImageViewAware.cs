using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nostra13.Universalimageloader.Core.Imageaware {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.core.imageaware']/class[@name='ImageViewAware']"
	[global::Android.Runtime.Register ("com/nostra13/universalimageloader/core/imageaware/ImageViewAware", DoNotGenerateAcw=true)]
	public partial class ImageViewAware : global::Com.Nostra13.Universalimageloader.Core.Imageaware.ViewAware {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nostra13/universalimageloader/core/imageaware/ImageViewAware", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ImageViewAware); }
		}

		protected ImageViewAware (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_widget_ImageView_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nostra13.universalimageloader.core.imageaware']/class[@name='ImageViewAware']/constructor[@name='ImageViewAware' and count(parameter)=1 and parameter[1][@type='android.widget.ImageView']]"
		[Register (".ctor", "(Landroid/widget/ImageView;)V", "")]
		public unsafe ImageViewAware (global::Android.Widget.ImageView p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (ImageViewAware)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/widget/ImageView;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/widget/ImageView;)V", __args);
					return;
				}

				if (id_ctor_Landroid_widget_ImageView_ == IntPtr.Zero)
					id_ctor_Landroid_widget_ImageView_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/widget/ImageView;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_widget_ImageView_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_widget_ImageView_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_widget_ImageView_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nostra13.universalimageloader.core.imageaware']/class[@name='ImageViewAware']/constructor[@name='ImageViewAware' and count(parameter)=2 and parameter[1][@type='android.widget.ImageView'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(Landroid/widget/ImageView;Z)V", "")]
		public unsafe ImageViewAware (global::Android.Widget.ImageView p0, bool p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (ImageViewAware)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/widget/ImageView;Z)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/widget/ImageView;Z)V", __args);
					return;
				}

				if (id_ctor_Landroid_widget_ImageView_Z == IntPtr.Zero)
					id_ctor_Landroid_widget_ImageView_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/widget/ImageView;Z)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_widget_ImageView_Z, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_widget_ImageView_Z, __args);
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
			global::Com.Nostra13.Universalimageloader.Core.Imageaware.ImageViewAware __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Imageaware.ImageViewAware> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetImageBitmapInto (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setImageBitmapInto_Landroid_graphics_Bitmap_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.imageaware']/class[@name='ImageViewAware']/method[@name='setImageBitmapInto' and count(parameter)=2 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='android.view.View']]"
		[Register ("setImageBitmapInto", "(Landroid/graphics/Bitmap;Landroid/view/View;)V", "GetSetImageBitmapInto_Landroid_graphics_Bitmap_Landroid_view_View_Handler")]
		protected override unsafe void SetImageBitmapInto (global::Android.Graphics.Bitmap p0, global::Android.Views.View p1)
		{
			if (id_setImageBitmapInto_Landroid_graphics_Bitmap_Landroid_view_View_ == IntPtr.Zero)
				id_setImageBitmapInto_Landroid_graphics_Bitmap_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "setImageBitmapInto", "(Landroid/graphics/Bitmap;Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setImageBitmapInto_Landroid_graphics_Bitmap_Landroid_view_View_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setImageBitmapInto", "(Landroid/graphics/Bitmap;Landroid/view/View;)V"), __args);
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
			global::Com.Nostra13.Universalimageloader.Core.Imageaware.ImageViewAware __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Imageaware.ImageViewAware> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetImageDrawableInto (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setImageDrawableInto_Landroid_graphics_drawable_Drawable_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.imageaware']/class[@name='ImageViewAware']/method[@name='setImageDrawableInto' and count(parameter)=2 and parameter[1][@type='android.graphics.drawable.Drawable'] and parameter[2][@type='android.view.View']]"
		[Register ("setImageDrawableInto", "(Landroid/graphics/drawable/Drawable;Landroid/view/View;)V", "GetSetImageDrawableInto_Landroid_graphics_drawable_Drawable_Landroid_view_View_Handler")]
		protected override unsafe void SetImageDrawableInto (global::Android.Graphics.Drawables.Drawable p0, global::Android.Views.View p1)
		{
			if (id_setImageDrawableInto_Landroid_graphics_drawable_Drawable_Landroid_view_View_ == IntPtr.Zero)
				id_setImageDrawableInto_Landroid_graphics_drawable_Drawable_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "setImageDrawableInto", "(Landroid/graphics/drawable/Drawable;Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setImageDrawableInto_Landroid_graphics_drawable_Drawable_Landroid_view_View_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setImageDrawableInto", "(Landroid/graphics/drawable/Drawable;Landroid/view/View;)V"), __args);
			} finally {
			}
		}

	}
}
