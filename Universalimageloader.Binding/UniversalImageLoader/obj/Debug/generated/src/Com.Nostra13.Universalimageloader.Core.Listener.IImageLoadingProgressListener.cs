using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nostra13.Universalimageloader.Core.Listener {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.nostra13.universalimageloader.core.listener']/interface[@name='ImageLoadingProgressListener']"
	[Register ("com/nostra13/universalimageloader/core/listener/ImageLoadingProgressListener", "", "Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingProgressListenerInvoker")]
	public partial interface IImageLoadingProgressListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.listener']/interface[@name='ImageLoadingProgressListener']/method[@name='onProgressUpdate' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.view.View'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("onProgressUpdate", "(Ljava/lang/String;Landroid/view/View;II)V", "GetOnProgressUpdate_Ljava_lang_String_Landroid_view_View_IIHandler:Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingProgressListenerInvoker, UniversalImageLoader")]
		void OnProgressUpdate (string p0, global::Android.Views.View p1, int p2, int p3);

	}

	[global::Android.Runtime.Register ("com/nostra13/universalimageloader/core/listener/ImageLoadingProgressListener", DoNotGenerateAcw=true)]
	internal class IImageLoadingProgressListenerInvoker : global::Java.Lang.Object, IImageLoadingProgressListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/nostra13/universalimageloader/core/listener/ImageLoadingProgressListener");
		IntPtr class_ref;

		public static IImageLoadingProgressListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IImageLoadingProgressListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.nostra13.universalimageloader.core.listener.ImageLoadingProgressListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IImageLoadingProgressListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IImageLoadingProgressListenerInvoker); }
		}

		static Delegate cb_onProgressUpdate_Ljava_lang_String_Landroid_view_View_II;
#pragma warning disable 0169
		static Delegate GetOnProgressUpdate_Ljava_lang_String_Landroid_view_View_IIHandler ()
		{
			if (cb_onProgressUpdate_Ljava_lang_String_Landroid_view_View_II == null)
				cb_onProgressUpdate_Ljava_lang_String_Landroid_view_View_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, int>) n_OnProgressUpdate_Ljava_lang_String_Landroid_view_View_II);
			return cb_onProgressUpdate_Ljava_lang_String_Landroid_view_View_II;
		}

		static void n_OnProgressUpdate_Ljava_lang_String_Landroid_view_View_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, int p3)
		{
			global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingProgressListener __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Listener.IImageLoadingProgressListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnProgressUpdate (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_onProgressUpdate_Ljava_lang_String_Landroid_view_View_II;
		public unsafe void OnProgressUpdate (string p0, global::Android.Views.View p1, int p2, int p3)
		{
			if (id_onProgressUpdate_Ljava_lang_String_Landroid_view_View_II == IntPtr.Zero)
				id_onProgressUpdate_Ljava_lang_String_Landroid_view_View_II = JNIEnv.GetMethodID (class_ref, "onProgressUpdate", "(Ljava/lang/String;Landroid/view/View;II)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (Handle, id_onProgressUpdate_Ljava_lang_String_Landroid_view_View_II, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

	public partial class ImageLoadingProgressEventArgs : global::System.EventArgs {

		public ImageLoadingProgressEventArgs (string p0, global::Android.Views.View p1, int p2, int p3)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
			this.p3 = p3;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}

		global::Android.Views.View p1;
		public global::Android.Views.View P1 {
			get { return p1; }
		}

		int p2;
		public int P2 {
			get { return p2; }
		}

		int p3;
		public int P3 {
			get { return p3; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/nostra13/universalimageloader/core/listener/ImageLoadingProgressListenerImplementor")]
	internal sealed partial class IImageLoadingProgressListenerImplementor : global::Java.Lang.Object, IImageLoadingProgressListener {

		object sender;

		public IImageLoadingProgressListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/nostra13/universalimageloader/core/listener/ImageLoadingProgressListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<ImageLoadingProgressEventArgs> Handler;
#pragma warning restore 0649

		public void OnProgressUpdate (string p0, global::Android.Views.View p1, int p2, int p3)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new ImageLoadingProgressEventArgs (p0, p1, p2, p3));
		}

		internal static bool __IsEmpty (IImageLoadingProgressListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
