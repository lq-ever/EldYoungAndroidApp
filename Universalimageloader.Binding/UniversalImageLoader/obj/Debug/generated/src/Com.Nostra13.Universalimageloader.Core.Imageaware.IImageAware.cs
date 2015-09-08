using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nostra13.Universalimageloader.Core.Imageaware {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.nostra13.universalimageloader.core.imageaware']/interface[@name='ImageAware']"
	[Register ("com/nostra13/universalimageloader/core/imageaware/ImageAware", "", "Com.Nostra13.Universalimageloader.Core.Imageaware.IImageAwareInvoker")]
	public partial interface IImageAware : IJavaObject {

		int Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.imageaware']/interface[@name='ImageAware']/method[@name='getHeight' and count(parameter)=0]"
			[Register ("getHeight", "()I", "GetGetHeightHandler:Com.Nostra13.Universalimageloader.Core.Imageaware.IImageAwareInvoker, UniversalImageLoader")] get;
		}

		int Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.imageaware']/interface[@name='ImageAware']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()I", "GetGetIdHandler:Com.Nostra13.Universalimageloader.Core.Imageaware.IImageAwareInvoker, UniversalImageLoader")] get;
		}

		bool IsCollected {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.imageaware']/interface[@name='ImageAware']/method[@name='isCollected' and count(parameter)=0]"
			[Register ("isCollected", "()Z", "GetIsCollectedHandler:Com.Nostra13.Universalimageloader.Core.Imageaware.IImageAwareInvoker, UniversalImageLoader")] get;
		}

		global::Com.Nostra13.Universalimageloader.Core.Assist.ViewScaleType ScaleType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.imageaware']/interface[@name='ImageAware']/method[@name='getScaleType' and count(parameter)=0]"
			[Register ("getScaleType", "()Lcom/nostra13/universalimageloader/core/assist/ViewScaleType;", "GetGetScaleTypeHandler:Com.Nostra13.Universalimageloader.Core.Imageaware.IImageAwareInvoker, UniversalImageLoader")] get;
		}

		int Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.imageaware']/interface[@name='ImageAware']/method[@name='getWidth' and count(parameter)=0]"
			[Register ("getWidth", "()I", "GetGetWidthHandler:Com.Nostra13.Universalimageloader.Core.Imageaware.IImageAwareInvoker, UniversalImageLoader")] get;
		}

		global::Android.Views.View WrappedView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.imageaware']/interface[@name='ImageAware']/method[@name='getWrappedView' and count(parameter)=0]"
			[Register ("getWrappedView", "()Landroid/view/View;", "GetGetWrappedViewHandler:Com.Nostra13.Universalimageloader.Core.Imageaware.IImageAwareInvoker, UniversalImageLoader")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.imageaware']/interface[@name='ImageAware']/method[@name='setImageBitmap' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("setImageBitmap", "(Landroid/graphics/Bitmap;)Z", "GetSetImageBitmap_Landroid_graphics_Bitmap_Handler:Com.Nostra13.Universalimageloader.Core.Imageaware.IImageAwareInvoker, UniversalImageLoader")]
		bool SetImageBitmap (global::Android.Graphics.Bitmap p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.imageaware']/interface[@name='ImageAware']/method[@name='setImageDrawable' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("setImageDrawable", "(Landroid/graphics/drawable/Drawable;)Z", "GetSetImageDrawable_Landroid_graphics_drawable_Drawable_Handler:Com.Nostra13.Universalimageloader.Core.Imageaware.IImageAwareInvoker, UniversalImageLoader")]
		bool SetImageDrawable (global::Android.Graphics.Drawables.Drawable p0);

	}

	[global::Android.Runtime.Register ("com/nostra13/universalimageloader/core/imageaware/ImageAware", DoNotGenerateAcw=true)]
	internal class IImageAwareInvoker : global::Java.Lang.Object, IImageAware {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/nostra13/universalimageloader/core/imageaware/ImageAware");
		IntPtr class_ref;

		public static IImageAware GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IImageAware> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.nostra13.universalimageloader.core.imageaware.ImageAware"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IImageAwareInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IImageAwareInvoker); }
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
			global::Com.Nostra13.Universalimageloader.Core.Imageaware.IImageAware __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Imageaware.IImageAware> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Height;
		}
#pragma warning restore 0169

		IntPtr id_getHeight;
		public unsafe int Height {
			get {
				if (id_getHeight == IntPtr.Zero)
					id_getHeight = JNIEnv.GetMethodID (class_ref, "getHeight", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getHeight);
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
			global::Com.Nostra13.Universalimageloader.Core.Imageaware.IImageAware __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Imageaware.IImageAware> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Id;
		}
#pragma warning restore 0169

		IntPtr id_getId;
		public unsafe int Id {
			get {
				if (id_getId == IntPtr.Zero)
					id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getId);
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
			global::Com.Nostra13.Universalimageloader.Core.Imageaware.IImageAware __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Imageaware.IImageAware> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCollected;
		}
#pragma warning restore 0169

		IntPtr id_isCollected;
		public unsafe bool IsCollected {
			get {
				if (id_isCollected == IntPtr.Zero)
					id_isCollected = JNIEnv.GetMethodID (class_ref, "isCollected", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isCollected);
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
			global::Com.Nostra13.Universalimageloader.Core.Imageaware.IImageAware __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Imageaware.IImageAware> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ScaleType);
		}
#pragma warning restore 0169

		IntPtr id_getScaleType;
		public unsafe global::Com.Nostra13.Universalimageloader.Core.Assist.ViewScaleType ScaleType {
			get {
				if (id_getScaleType == IntPtr.Zero)
					id_getScaleType = JNIEnv.GetMethodID (class_ref, "getScaleType", "()Lcom/nostra13/universalimageloader/core/assist/ViewScaleType;");
				return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.ViewScaleType> (JNIEnv.CallObjectMethod (Handle, id_getScaleType), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Nostra13.Universalimageloader.Core.Imageaware.IImageAware __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Imageaware.IImageAware> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Width;
		}
#pragma warning restore 0169

		IntPtr id_getWidth;
		public unsafe int Width {
			get {
				if (id_getWidth == IntPtr.Zero)
					id_getWidth = JNIEnv.GetMethodID (class_ref, "getWidth", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getWidth);
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
			global::Com.Nostra13.Universalimageloader.Core.Imageaware.IImageAware __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Imageaware.IImageAware> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WrappedView);
		}
#pragma warning restore 0169

		IntPtr id_getWrappedView;
		public unsafe global::Android.Views.View WrappedView {
			get {
				if (id_getWrappedView == IntPtr.Zero)
					id_getWrappedView = JNIEnv.GetMethodID (class_ref, "getWrappedView", "()Landroid/view/View;");
				return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (Handle, id_getWrappedView), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Nostra13.Universalimageloader.Core.Imageaware.IImageAware __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Imageaware.IImageAware> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetImageBitmap (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setImageBitmap_Landroid_graphics_Bitmap_;
		public unsafe bool SetImageBitmap (global::Android.Graphics.Bitmap p0)
		{
			if (id_setImageBitmap_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_setImageBitmap_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "setImageBitmap", "(Landroid/graphics/Bitmap;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_setImageBitmap_Landroid_graphics_Bitmap_, __args);
			return __ret;
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
			global::Com.Nostra13.Universalimageloader.Core.Imageaware.IImageAware __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Imageaware.IImageAware> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetImageDrawable (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setImageDrawable_Landroid_graphics_drawable_Drawable_;
		public unsafe bool SetImageDrawable (global::Android.Graphics.Drawables.Drawable p0)
		{
			if (id_setImageDrawable_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_setImageDrawable_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "setImageDrawable", "(Landroid/graphics/drawable/Drawable;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_setImageDrawable_Landroid_graphics_drawable_Drawable_, __args);
			return __ret;
		}

	}

}
