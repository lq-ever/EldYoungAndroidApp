using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nostra13.Universalimageloader.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.utils']/class[@name='L']"
	[global::Android.Runtime.Register ("com/nostra13/universalimageloader/utils/L", DoNotGenerateAcw=true)]
	public sealed partial class L : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nostra13/universalimageloader/utils/L", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (L); }
		}

		internal L (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_d_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.utils']/class[@name='L']/method[@name='d' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("d", "(Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void D (string p0, params global:: Java.Lang.Object[] p1)
		{
			if (id_d_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_d_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "d", "(Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_d_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_disableLogging;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.utils']/class[@name='L']/method[@name='disableLogging' and count(parameter)=0]"
		[Obsolete (@"deprecated")]
		[Register ("disableLogging", "()V", "")]
		public static unsafe void DisableLogging ()
		{
			if (id_disableLogging == IntPtr.Zero)
				id_disableLogging = JNIEnv.GetStaticMethodID (class_ref, "disableLogging", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_disableLogging);
			} finally {
			}
		}

		static IntPtr id_e_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.utils']/class[@name='L']/method[@name='e' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("e", "(Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void E (string p0, params global:: Java.Lang.Object[] p1)
		{
			if (id_e_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_e_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "e", "(Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_e_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_e_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.utils']/class[@name='L']/method[@name='e' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("e", "(Ljava/lang/Throwable;)V", "")]
		public static unsafe void E (global::Java.Lang.Throwable p0)
		{
			if (id_e_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_e_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "e", "(Ljava/lang/Throwable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_e_Ljava_lang_Throwable_, __args);
			} finally {
			}
		}

		static IntPtr id_e_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.utils']/class[@name='L']/method[@name='e' and count(parameter)=3 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("e", "(Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void E (global::Java.Lang.Throwable p0, string p1, params global:: Java.Lang.Object[] p2)
		{
			if (id_e_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_e_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "e", "(Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_e_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static IntPtr id_enableLogging;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.utils']/class[@name='L']/method[@name='enableLogging' and count(parameter)=0]"
		[Obsolete (@"deprecated")]
		[Register ("enableLogging", "()V", "")]
		public static unsafe void EnableLogging ()
		{
			if (id_enableLogging == IntPtr.Zero)
				id_enableLogging = JNIEnv.GetStaticMethodID (class_ref, "enableLogging", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_enableLogging);
			} finally {
			}
		}

		static IntPtr id_i_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.utils']/class[@name='L']/method[@name='i' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("i", "(Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void I (string p0, params global:: Java.Lang.Object[] p1)
		{
			if (id_i_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_i_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "i", "(Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_i_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_w_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.utils']/class[@name='L']/method[@name='w' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("w", "(Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void W (string p0, params global:: Java.Lang.Object[] p1)
		{
			if (id_w_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_w_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "w", "(Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_w_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_writeDebugLogs_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.utils']/class[@name='L']/method[@name='writeDebugLogs' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("writeDebugLogs", "(Z)V", "")]
		public static unsafe void WriteDebugLogs (bool p0)
		{
			if (id_writeDebugLogs_Z == IntPtr.Zero)
				id_writeDebugLogs_Z = JNIEnv.GetStaticMethodID (class_ref, "writeDebugLogs", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_writeDebugLogs_Z, __args);
			} finally {
			}
		}

		static IntPtr id_writeLogs_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.utils']/class[@name='L']/method[@name='writeLogs' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("writeLogs", "(Z)V", "")]
		public static unsafe void WriteLogs (bool p0)
		{
			if (id_writeLogs_Z == IntPtr.Zero)
				id_writeLogs_Z = JNIEnv.GetStaticMethodID (class_ref, "writeLogs", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_writeLogs_Z, __args);
			} finally {
			}
		}

	}
}
