using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nostra13.Universalimageloader.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.utils']/class[@name='IoUtils']"
	[global::Android.Runtime.Register ("com/nostra13/universalimageloader/utils/IoUtils", DoNotGenerateAcw=true)]
	public sealed partial class IoUtils : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.utils']/class[@name='IoUtils']/field[@name='CONTINUE_LOADING_PERCENTAGE']"
		[Register ("CONTINUE_LOADING_PERCENTAGE")]
		public const int ContinueLoadingPercentage = (int) 75;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.utils']/class[@name='IoUtils']/field[@name='DEFAULT_BUFFER_SIZE']"
		[Register ("DEFAULT_BUFFER_SIZE")]
		public const int DefaultBufferSize = (int) 32768;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.utils']/class[@name='IoUtils']/field[@name='DEFAULT_IMAGE_TOTAL_SIZE']"
		[Register ("DEFAULT_IMAGE_TOTAL_SIZE")]
		public const int DefaultImageTotalSize = (int) 512000;
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.nostra13.universalimageloader.utils']/interface[@name='IoUtils.CopyListener']"
		[Register ("com/nostra13/universalimageloader/utils/IoUtils$CopyListener", "", "Com.Nostra13.Universalimageloader.Utils.IoUtils/ICopyListenerInvoker")]
		public partial interface ICopyListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.utils']/interface[@name='IoUtils.CopyListener']/method[@name='onBytesCopied' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("onBytesCopied", "(II)Z", "GetOnBytesCopied_IIHandler:Com.Nostra13.Universalimageloader.Utils.IoUtils/ICopyListenerInvoker, UniversalImageLoader")]
			bool OnBytesCopied (int p0, int p1);

		}

		[global::Android.Runtime.Register ("com/nostra13/universalimageloader/utils/IoUtils$CopyListener", DoNotGenerateAcw=true)]
		internal class ICopyListenerInvoker : global::Java.Lang.Object, ICopyListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/nostra13/universalimageloader/utils/IoUtils$CopyListener");
			IntPtr class_ref;

			public static ICopyListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ICopyListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.nostra13.universalimageloader.utils.IoUtils.CopyListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ICopyListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ICopyListenerInvoker); }
			}

			static Delegate cb_onBytesCopied_II;
#pragma warning disable 0169
			static Delegate GetOnBytesCopied_IIHandler ()
			{
				if (cb_onBytesCopied_II == null)
					cb_onBytesCopied_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, bool>) n_OnBytesCopied_II);
				return cb_onBytesCopied_II;
			}

			static bool n_OnBytesCopied_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
			{
				global::Com.Nostra13.Universalimageloader.Utils.IoUtils.ICopyListener __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Utils.IoUtils.ICopyListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.OnBytesCopied (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onBytesCopied_II;
			public unsafe bool OnBytesCopied (int p0, int p1)
			{
				if (id_onBytesCopied_II == IntPtr.Zero)
					id_onBytesCopied_II = JNIEnv.GetMethodID (class_ref, "onBytesCopied", "(II)Z");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return JNIEnv.CallBooleanMethod (Handle, id_onBytesCopied_II, __args);
			}

		}

		public partial class CopyEventArgs : global::System.EventArgs {

			public CopyEventArgs (bool handled, int p0, int p1)
			{
				this.handled = handled;
				this.p0 = p0;
				this.p1 = p1;
			}

			bool handled;
			public bool Handled {
				get { return handled; }
				set { handled = value; }
			}

			int p0;
			public int P0 {
				get { return p0; }
			}

			int p1;
			public int P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/nostra13/universalimageloader/utils/IoUtils_CopyListenerImplementor")]
		internal sealed partial class ICopyListenerImplementor : global::Java.Lang.Object, ICopyListener {

			object sender;

			public ICopyListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/nostra13/universalimageloader/utils/IoUtils_CopyListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<CopyEventArgs> Handler;
#pragma warning restore 0649

			public bool OnBytesCopied (int p0, int p1)
			{
				var __h = Handler;
				if (__h == null)
					return false;
				var __e = new CopyEventArgs (true, p0, p1);
				__h (sender, __e);
				return __e.Handled;
			}

			internal static bool __IsEmpty (ICopyListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nostra13/universalimageloader/utils/IoUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IoUtils); }
		}

		internal IoUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_closeSilently_Ljava_io_Closeable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.utils']/class[@name='IoUtils']/method[@name='closeSilently' and count(parameter)=1 and parameter[1][@type='java.io.Closeable']]"
		[Register ("closeSilently", "(Ljava/io/Closeable;)V", "")]
		public static unsafe void CloseSilently (global::Java.IO.ICloseable p0)
		{
			if (id_closeSilently_Ljava_io_Closeable_ == IntPtr.Zero)
				id_closeSilently_Ljava_io_Closeable_ = JNIEnv.GetStaticMethodID (class_ref, "closeSilently", "(Ljava/io/Closeable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_closeSilently_Ljava_io_Closeable_, __args);
			} finally {
			}
		}

		static IntPtr id_copyStream_Ljava_io_InputStream_Ljava_io_OutputStream_Lcom_nostra13_universalimageloader_utils_IoUtils_CopyListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.utils']/class[@name='IoUtils']/method[@name='copyStream' and count(parameter)=3 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='java.io.OutputStream'] and parameter[3][@type='com.nostra13.universalimageloader.utils.IoUtils.CopyListener']]"
		[Register ("copyStream", "(Ljava/io/InputStream;Ljava/io/OutputStream;Lcom/nostra13/universalimageloader/utils/IoUtils$CopyListener;)Z", "")]
		public static unsafe bool CopyStream (global::System.IO.Stream p0, global::System.IO.Stream p1, global::Com.Nostra13.Universalimageloader.Utils.IoUtils.ICopyListener p2)
		{
			if (id_copyStream_Ljava_io_InputStream_Ljava_io_OutputStream_Lcom_nostra13_universalimageloader_utils_IoUtils_CopyListener_ == IntPtr.Zero)
				id_copyStream_Ljava_io_InputStream_Ljava_io_OutputStream_Lcom_nostra13_universalimageloader_utils_IoUtils_CopyListener_ = JNIEnv.GetStaticMethodID (class_ref, "copyStream", "(Ljava/io/InputStream;Ljava/io/OutputStream;Lcom/nostra13/universalimageloader/utils/IoUtils$CopyListener;)Z");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_copyStream_Ljava_io_InputStream_Ljava_io_OutputStream_Lcom_nostra13_universalimageloader_utils_IoUtils_CopyListener_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_copyStream_Ljava_io_InputStream_Ljava_io_OutputStream_Lcom_nostra13_universalimageloader_utils_IoUtils_CopyListener_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.utils']/class[@name='IoUtils']/method[@name='copyStream' and count(parameter)=4 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='java.io.OutputStream'] and parameter[3][@type='com.nostra13.universalimageloader.utils.IoUtils.CopyListener'] and parameter[4][@type='int']]"
		[Register ("copyStream", "(Ljava/io/InputStream;Ljava/io/OutputStream;Lcom/nostra13/universalimageloader/utils/IoUtils$CopyListener;I)Z", "")]
		public static unsafe bool CopyStream (global::System.IO.Stream p0, global::System.IO.Stream p1, global::Com.Nostra13.Universalimageloader.Utils.IoUtils.ICopyListener p2, int p3)
		{
			if (id_copyStream_Ljava_io_InputStream_Ljava_io_OutputStream_Lcom_nostra13_universalimageloader_utils_IoUtils_CopyListener_I == IntPtr.Zero)
				id_copyStream_Ljava_io_InputStream_Ljava_io_OutputStream_Lcom_nostra13_universalimageloader_utils_IoUtils_CopyListener_I = JNIEnv.GetStaticMethodID (class_ref, "copyStream", "(Ljava/io/InputStream;Ljava/io/OutputStream;Lcom/nostra13/universalimageloader/utils/IoUtils$CopyListener;I)Z");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_copyStream_Ljava_io_InputStream_Ljava_io_OutputStream_Lcom_nostra13_universalimageloader_utils_IoUtils_CopyListener_I, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_readAndCloseStream_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.utils']/class[@name='IoUtils']/method[@name='readAndCloseStream' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("readAndCloseStream", "(Ljava/io/InputStream;)V", "")]
		public static unsafe void ReadAndCloseStream (global::System.IO.Stream p0)
		{
			if (id_readAndCloseStream_Ljava_io_InputStream_ == IntPtr.Zero)
				id_readAndCloseStream_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "readAndCloseStream", "(Ljava/io/InputStream;)V");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_readAndCloseStream_Ljava_io_InputStream_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
