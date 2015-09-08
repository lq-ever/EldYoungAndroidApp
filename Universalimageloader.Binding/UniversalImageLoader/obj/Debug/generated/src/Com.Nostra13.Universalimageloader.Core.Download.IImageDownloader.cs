using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nostra13.Universalimageloader.Core.Download {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.core.download']/class[@name='ImageDownloader.Scheme']"
	[global::Android.Runtime.Register ("com/nostra13/universalimageloader/core/download/ImageDownloader$Scheme", DoNotGenerateAcw=true)]
	public sealed partial class ImageDownloaderScheme : global::Java.Lang.Enum {


		static IntPtr ASSETS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.core.download']/class[@name='ImageDownloader.Scheme']/field[@name='ASSETS']"
		[Register ("ASSETS")]
		public static global::Com.Nostra13.Universalimageloader.Core.Download.ImageDownloaderScheme Assets {
			get {
				if (ASSETS_jfieldId == IntPtr.Zero)
					ASSETS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ASSETS", "Lcom/nostra13/universalimageloader/core/download/ImageDownloader$Scheme;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ASSETS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Download.ImageDownloaderScheme> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CONTENT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.core.download']/class[@name='ImageDownloader.Scheme']/field[@name='CONTENT']"
		[Register ("CONTENT")]
		public static global::Com.Nostra13.Universalimageloader.Core.Download.ImageDownloaderScheme Content {
			get {
				if (CONTENT_jfieldId == IntPtr.Zero)
					CONTENT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONTENT", "Lcom/nostra13/universalimageloader/core/download/ImageDownloader$Scheme;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONTENT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Download.ImageDownloaderScheme> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr DRAWABLE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.core.download']/class[@name='ImageDownloader.Scheme']/field[@name='DRAWABLE']"
		[Register ("DRAWABLE")]
		public static global::Com.Nostra13.Universalimageloader.Core.Download.ImageDownloaderScheme Drawable {
			get {
				if (DRAWABLE_jfieldId == IntPtr.Zero)
					DRAWABLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DRAWABLE", "Lcom/nostra13/universalimageloader/core/download/ImageDownloader$Scheme;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DRAWABLE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Download.ImageDownloaderScheme> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr FILE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.core.download']/class[@name='ImageDownloader.Scheme']/field[@name='FILE']"
		[Register ("FILE")]
		public static global::Com.Nostra13.Universalimageloader.Core.Download.ImageDownloaderScheme File {
			get {
				if (FILE_jfieldId == IntPtr.Zero)
					FILE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FILE", "Lcom/nostra13/universalimageloader/core/download/ImageDownloader$Scheme;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FILE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Download.ImageDownloaderScheme> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr HTTP_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.core.download']/class[@name='ImageDownloader.Scheme']/field[@name='HTTP']"
		[Register ("HTTP")]
		public static global::Com.Nostra13.Universalimageloader.Core.Download.ImageDownloaderScheme Http {
			get {
				if (HTTP_jfieldId == IntPtr.Zero)
					HTTP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HTTP", "Lcom/nostra13/universalimageloader/core/download/ImageDownloader$Scheme;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HTTP_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Download.ImageDownloaderScheme> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr HTTPS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.core.download']/class[@name='ImageDownloader.Scheme']/field[@name='HTTPS']"
		[Register ("HTTPS")]
		public static global::Com.Nostra13.Universalimageloader.Core.Download.ImageDownloaderScheme Https {
			get {
				if (HTTPS_jfieldId == IntPtr.Zero)
					HTTPS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HTTPS", "Lcom/nostra13/universalimageloader/core/download/ImageDownloader$Scheme;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HTTPS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Download.ImageDownloaderScheme> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UNKNOWN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.core.download']/class[@name='ImageDownloader.Scheme']/field[@name='UNKNOWN']"
		[Register ("UNKNOWN")]
		public static global::Com.Nostra13.Universalimageloader.Core.Download.ImageDownloaderScheme Unknown {
			get {
				if (UNKNOWN_jfieldId == IntPtr.Zero)
					UNKNOWN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNKNOWN", "Lcom/nostra13/universalimageloader/core/download/ImageDownloader$Scheme;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNKNOWN_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Download.ImageDownloaderScheme> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nostra13/universalimageloader/core/download/ImageDownloader$Scheme", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ImageDownloaderScheme); }
		}

		internal ImageDownloaderScheme (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_crop_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.download']/class[@name='ImageDownloader.Scheme']/method[@name='crop' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("crop", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe string Crop (string p0)
		{
			if (id_crop_Ljava_lang_String_ == IntPtr.Zero)
				id_crop_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "crop", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_crop_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ofUri_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.download']/class[@name='ImageDownloader.Scheme']/method[@name='ofUri' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("ofUri", "(Ljava/lang/String;)Lcom/nostra13/universalimageloader/core/download/ImageDownloader$Scheme;", "")]
		public static unsafe global::Com.Nostra13.Universalimageloader.Core.Download.ImageDownloaderScheme OfUri (string p0)
		{
			if (id_ofUri_Ljava_lang_String_ == IntPtr.Zero)
				id_ofUri_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "ofUri", "(Ljava/lang/String;)Lcom/nostra13/universalimageloader/core/download/ImageDownloader$Scheme;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Nostra13.Universalimageloader.Core.Download.ImageDownloaderScheme __ret = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Download.ImageDownloaderScheme> (JNIEnv.CallStaticObjectMethod  (class_ref, id_ofUri_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.download']/class[@name='ImageDownloader.Scheme']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/nostra13/universalimageloader/core/download/ImageDownloader$Scheme;", "")]
		public static unsafe global::Com.Nostra13.Universalimageloader.Core.Download.ImageDownloaderScheme ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/nostra13/universalimageloader/core/download/ImageDownloader$Scheme;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Nostra13.Universalimageloader.Core.Download.ImageDownloaderScheme __ret = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Download.ImageDownloaderScheme> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.download']/class[@name='ImageDownloader.Scheme']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/nostra13/universalimageloader/core/download/ImageDownloader$Scheme;", "")]
		public static unsafe global::Com.Nostra13.Universalimageloader.Core.Download.ImageDownloaderScheme[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/nostra13/universalimageloader/core/download/ImageDownloader$Scheme;");
			try {
				return (global::Com.Nostra13.Universalimageloader.Core.Download.ImageDownloaderScheme[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Nostra13.Universalimageloader.Core.Download.ImageDownloaderScheme));
			} finally {
			}
		}

		static IntPtr id_wrap_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.download']/class[@name='ImageDownloader.Scheme']/method[@name='wrap' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("wrap", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe string Wrap (string p0)
		{
			if (id_wrap_Ljava_lang_String_ == IntPtr.Zero)
				id_wrap_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "wrap", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_wrap_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.nostra13.universalimageloader.core.download']/interface[@name='ImageDownloader']"
	[Register ("com/nostra13/universalimageloader/core/download/ImageDownloader", "", "Com.Nostra13.Universalimageloader.Core.Download.IImageDownloaderInvoker")]
	public partial interface IImageDownloader : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.download']/interface[@name='ImageDownloader']/method[@name='getStream' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("getStream", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/io/InputStream;", "GetGetStream_Ljava_lang_String_Ljava_lang_Object_Handler:Com.Nostra13.Universalimageloader.Core.Download.IImageDownloaderInvoker, UniversalImageLoader")]
		global::System.IO.Stream GetStream (string p0, global::Java.Lang.Object p1);

	}

	[global::Android.Runtime.Register ("com/nostra13/universalimageloader/core/download/ImageDownloader", DoNotGenerateAcw=true)]
	internal class IImageDownloaderInvoker : global::Java.Lang.Object, IImageDownloader {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/nostra13/universalimageloader/core/download/ImageDownloader");
		IntPtr class_ref;

		public static IImageDownloader GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IImageDownloader> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.nostra13.universalimageloader.core.download.ImageDownloader"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IImageDownloaderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IImageDownloaderInvoker); }
		}

		static Delegate cb_getStream_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetStream_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_getStream_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_getStream_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetStream_Ljava_lang_String_Ljava_lang_Object_);
			return cb_getStream_Ljava_lang_String_Ljava_lang_Object_;
		}

		static IntPtr n_GetStream_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Nostra13.Universalimageloader.Core.Download.IImageDownloader __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Download.IImageDownloader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.GetStream (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getStream_Ljava_lang_String_Ljava_lang_Object_;
		public unsafe global::System.IO.Stream GetStream (string p0, global::Java.Lang.Object p1)
		{
			if (id_getStream_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_getStream_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getStream", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/io/InputStream;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			global::System.IO.Stream __ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getStream_Ljava_lang_String_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
