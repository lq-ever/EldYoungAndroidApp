using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nostra13.Universalimageloader.Cache.Disc.Impl.Ext {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.impl.ext']/class[@name='DiskLruCache']"
	[global::Android.Runtime.Register ("com/nostra13/universalimageloader/cache/disc/impl/ext/DiskLruCache", DoNotGenerateAcw=true)]
	public sealed partial class DiskLruCache : global::Java.Lang.Object, global::Java.IO.ICloseable {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.impl.ext']/class[@name='DiskLruCache.Editor']"
		[global::Android.Runtime.Register ("com/nostra13/universalimageloader/cache/disc/impl/ext/DiskLruCache$Editor", DoNotGenerateAcw=true)]
		public sealed partial class Editor : global::Java.Lang.Object {

			// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.impl.ext']/class[@name='DiskLruCache.Editor.FaultHidingOutputStream']"
			[global::Android.Runtime.Register ("com/nostra13/universalimageloader/cache/disc/impl/ext/DiskLruCache$Editor$FaultHidingOutputStream", DoNotGenerateAcw=true)]
			public partial class FaultHidingOutputStream : global::Java.IO.FilterOutputStream {

				protected FaultHidingOutputStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			}

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/nostra13/universalimageloader/cache/disc/impl/ext/DiskLruCache$Editor", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Editor); }
			}

			internal Editor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_abort;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.impl.ext']/class[@name='DiskLruCache.Editor']/method[@name='abort' and count(parameter)=0]"
			[Register ("abort", "()V", "")]
			public unsafe void Abort ()
			{
				if (id_abort == IntPtr.Zero)
					id_abort = JNIEnv.GetMethodID (class_ref, "abort", "()V");
				try {
					JNIEnv.CallVoidMethod  (Handle, id_abort);
				} finally {
				}
			}

			static IntPtr id_abortUnlessCommitted;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.impl.ext']/class[@name='DiskLruCache.Editor']/method[@name='abortUnlessCommitted' and count(parameter)=0]"
			[Register ("abortUnlessCommitted", "()V", "")]
			public unsafe void AbortUnlessCommitted ()
			{
				if (id_abortUnlessCommitted == IntPtr.Zero)
					id_abortUnlessCommitted = JNIEnv.GetMethodID (class_ref, "abortUnlessCommitted", "()V");
				try {
					JNIEnv.CallVoidMethod  (Handle, id_abortUnlessCommitted);
				} finally {
				}
			}

			static IntPtr id_commit;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.impl.ext']/class[@name='DiskLruCache.Editor']/method[@name='commit' and count(parameter)=0]"
			[Register ("commit", "()V", "")]
			public unsafe void Commit ()
			{
				if (id_commit == IntPtr.Zero)
					id_commit = JNIEnv.GetMethodID (class_ref, "commit", "()V");
				try {
					JNIEnv.CallVoidMethod  (Handle, id_commit);
				} finally {
				}
			}

			static IntPtr id_getString_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.impl.ext']/class[@name='DiskLruCache.Editor']/method[@name='getString' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getString", "(I)Ljava/lang/String;", "")]
			public unsafe string GetString (int p0)
			{
				if (id_getString_I == IntPtr.Zero)
					id_getString_I = JNIEnv.GetMethodID (class_ref, "getString", "(I)Ljava/lang/String;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getString_I, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_newInputStream_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.impl.ext']/class[@name='DiskLruCache.Editor']/method[@name='newInputStream' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("newInputStream", "(I)Ljava/io/InputStream;", "")]
			public unsafe global::System.IO.Stream NewInputStream (int p0)
			{
				if (id_newInputStream_I == IntPtr.Zero)
					id_newInputStream_I = JNIEnv.GetMethodID (class_ref, "newInputStream", "(I)Ljava/io/InputStream;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					return global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_newInputStream_I, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_newOutputStream_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.impl.ext']/class[@name='DiskLruCache.Editor']/method[@name='newOutputStream' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("newOutputStream", "(I)Ljava/io/OutputStream;", "")]
			public unsafe global::System.IO.Stream NewOutputStream (int p0)
			{
				if (id_newOutputStream_I == IntPtr.Zero)
					id_newOutputStream_I = JNIEnv.GetMethodID (class_ref, "newOutputStream", "(I)Ljava/io/OutputStream;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					return global::Android.Runtime.OutputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_newOutputStream_I, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_set_ILjava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.impl.ext']/class[@name='DiskLruCache.Editor']/method[@name='set' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
			[Register ("set", "(ILjava/lang/String;)V", "")]
			public unsafe void Set (int p0, string p1)
			{
				if (id_set_ILjava_lang_String_ == IntPtr.Zero)
					id_set_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "set", "(ILjava/lang/String;)V");
				IntPtr native_p1 = JNIEnv.NewString (p1);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (native_p1);
					JNIEnv.CallVoidMethod  (Handle, id_set_ILjava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.impl.ext']/class[@name='DiskLruCache.Entry']"
		[global::Android.Runtime.Register ("com/nostra13/universalimageloader/cache/disc/impl/ext/DiskLruCache$Entry", DoNotGenerateAcw=true)]
		public sealed partial class Entry : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/nostra13/universalimageloader/cache/disc/impl/ext/DiskLruCache$Entry", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Entry); }
			}

			internal Entry (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getLengths;
			public unsafe string Lengths {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.impl.ext']/class[@name='DiskLruCache.Entry']/method[@name='getLengths' and count(parameter)=0]"
				[Register ("getLengths", "()Ljava/lang/String;", "GetGetLengthsHandler")]
				get {
					if (id_getLengths == IntPtr.Zero)
						id_getLengths = JNIEnv.GetMethodID (class_ref, "getLengths", "()Ljava/lang/String;");
					try {
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getLengths), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static IntPtr id_getCleanFile_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.impl.ext']/class[@name='DiskLruCache.Entry']/method[@name='getCleanFile' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getCleanFile", "(I)Ljava/io/File;", "")]
			public unsafe global::Java.IO.File GetCleanFile (int p0)
			{
				if (id_getCleanFile_I == IntPtr.Zero)
					id_getCleanFile_I = JNIEnv.GetMethodID (class_ref, "getCleanFile", "(I)Ljava/io/File;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					return global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallObjectMethod  (Handle, id_getCleanFile_I, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_getDirtyFile_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.impl.ext']/class[@name='DiskLruCache.Entry']/method[@name='getDirtyFile' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getDirtyFile", "(I)Ljava/io/File;", "")]
			public unsafe global::Java.IO.File GetDirtyFile (int p0)
			{
				if (id_getDirtyFile_I == IntPtr.Zero)
					id_getDirtyFile_I = JNIEnv.GetMethodID (class_ref, "getDirtyFile", "(I)Ljava/io/File;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					return global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallObjectMethod  (Handle, id_getDirtyFile_I, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.impl.ext']/class[@name='DiskLruCache.Snapshot']"
		[global::Android.Runtime.Register ("com/nostra13/universalimageloader/cache/disc/impl/ext/DiskLruCache$Snapshot", DoNotGenerateAcw=true)]
		public sealed partial class Snapshot : global::Java.Lang.Object, global::Java.IO.ICloseable {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/nostra13/universalimageloader/cache/disc/impl/ext/DiskLruCache$Snapshot", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Snapshot); }
			}

			internal Snapshot (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_close;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.impl.ext']/class[@name='DiskLruCache.Snapshot']/method[@name='close' and count(parameter)=0]"
			[Register ("close", "()V", "")]
			public unsafe void Close ()
			{
				if (id_close == IntPtr.Zero)
					id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
				try {
					JNIEnv.CallVoidMethod  (Handle, id_close);
				} finally {
				}
			}

			static IntPtr id_edit;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.impl.ext']/class[@name='DiskLruCache.Snapshot']/method[@name='edit' and count(parameter)=0]"
			[Register ("edit", "()Lcom/nostra13/universalimageloader/cache/disc/impl/ext/DiskLruCache$Editor;", "")]
			public unsafe global::Com.Nostra13.Universalimageloader.Cache.Disc.Impl.Ext.DiskLruCache.Editor Edit ()
			{
				if (id_edit == IntPtr.Zero)
					id_edit = JNIEnv.GetMethodID (class_ref, "edit", "()Lcom/nostra13/universalimageloader/cache/disc/impl/ext/DiskLruCache$Editor;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Cache.Disc.Impl.Ext.DiskLruCache.Editor> (JNIEnv.CallObjectMethod  (Handle, id_edit), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_getFile_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.impl.ext']/class[@name='DiskLruCache.Snapshot']/method[@name='getFile' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getFile", "(I)Ljava/io/File;", "")]
			public unsafe global::Java.IO.File GetFile (int p0)
			{
				if (id_getFile_I == IntPtr.Zero)
					id_getFile_I = JNIEnv.GetMethodID (class_ref, "getFile", "(I)Ljava/io/File;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					return global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallObjectMethod  (Handle, id_getFile_I, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_getInputStream_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.impl.ext']/class[@name='DiskLruCache.Snapshot']/method[@name='getInputStream' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getInputStream", "(I)Ljava/io/InputStream;", "")]
			public unsafe global::System.IO.Stream GetInputStream (int p0)
			{
				if (id_getInputStream_I == IntPtr.Zero)
					id_getInputStream_I = JNIEnv.GetMethodID (class_ref, "getInputStream", "(I)Ljava/io/InputStream;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					return global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getInputStream_I, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_getLength_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.impl.ext']/class[@name='DiskLruCache.Snapshot']/method[@name='getLength' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getLength", "(I)J", "")]
			public unsafe long GetLength (int p0)
			{
				if (id_getLength_I == IntPtr.Zero)
					id_getLength_I = JNIEnv.GetMethodID (class_ref, "getLength", "(I)J");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					return JNIEnv.CallLongMethod  (Handle, id_getLength_I, __args);
				} finally {
				}
			}

			static IntPtr id_getString_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.impl.ext']/class[@name='DiskLruCache.Snapshot']/method[@name='getString' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getString", "(I)Ljava/lang/String;", "")]
			public unsafe string GetString (int p0)
			{
				if (id_getString_I == IntPtr.Zero)
					id_getString_I = JNIEnv.GetMethodID (class_ref, "getString", "(I)Ljava/lang/String;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getString_I, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nostra13/universalimageloader/cache/disc/impl/ext/DiskLruCache", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DiskLruCache); }
		}

		internal DiskLruCache (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getDirectory;
		public unsafe global::Java.IO.File Directory {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.impl.ext']/class[@name='DiskLruCache']/method[@name='getDirectory' and count(parameter)=0]"
			[Register ("getDirectory", "()Ljava/io/File;", "GetGetDirectoryHandler")]
			get {
				if (id_getDirectory == IntPtr.Zero)
					id_getDirectory = JNIEnv.GetMethodID (class_ref, "getDirectory", "()Ljava/io/File;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallObjectMethod  (Handle, id_getDirectory), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_isClosed;
		public unsafe bool IsClosed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.impl.ext']/class[@name='DiskLruCache']/method[@name='isClosed' and count(parameter)=0]"
			[Register ("isClosed", "()Z", "GetIsClosedHandler")]
			get {
				if (id_isClosed == IntPtr.Zero)
					id_isClosed = JNIEnv.GetMethodID (class_ref, "isClosed", "()Z");
				try {
					return JNIEnv.CallBooleanMethod  (Handle, id_isClosed);
				} finally {
				}
			}
		}

		static IntPtr id_getMaxFileCount;
		public unsafe int MaxFileCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.impl.ext']/class[@name='DiskLruCache']/method[@name='getMaxFileCount' and count(parameter)=0]"
			[Register ("getMaxFileCount", "()I", "GetGetMaxFileCountHandler")]
			get {
				if (id_getMaxFileCount == IntPtr.Zero)
					id_getMaxFileCount = JNIEnv.GetMethodID (class_ref, "getMaxFileCount", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getMaxFileCount);
				} finally {
				}
			}
		}

		static IntPtr id_getMaxSize;
		static IntPtr id_setMaxSize_J;
		public unsafe long MaxSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.impl.ext']/class[@name='DiskLruCache']/method[@name='getMaxSize' and count(parameter)=0]"
			[Register ("getMaxSize", "()J", "GetGetMaxSizeHandler")]
			get {
				if (id_getMaxSize == IntPtr.Zero)
					id_getMaxSize = JNIEnv.GetMethodID (class_ref, "getMaxSize", "()J");
				try {
					return JNIEnv.CallLongMethod  (Handle, id_getMaxSize);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.impl.ext']/class[@name='DiskLruCache']/method[@name='setMaxSize' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setMaxSize", "(J)V", "GetSetMaxSize_JHandler")]
			set {
				if (id_setMaxSize_J == IntPtr.Zero)
					id_setMaxSize_J = JNIEnv.GetMethodID (class_ref, "setMaxSize", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod  (Handle, id_setMaxSize_J, __args);
				} finally {
				}
			}
		}

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.impl.ext']/class[@name='DiskLruCache']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "")]
		public unsafe void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_close);
			} finally {
			}
		}

		static IntPtr id_delete;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.impl.ext']/class[@name='DiskLruCache']/method[@name='delete' and count(parameter)=0]"
		[Register ("delete", "()V", "")]
		public unsafe void Delete ()
		{
			if (id_delete == IntPtr.Zero)
				id_delete = JNIEnv.GetMethodID (class_ref, "delete", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_delete);
			} finally {
			}
		}

		static IntPtr id_edit_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.impl.ext']/class[@name='DiskLruCache']/method[@name='edit' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("edit", "(Ljava/lang/String;)Lcom/nostra13/universalimageloader/cache/disc/impl/ext/DiskLruCache$Editor;", "")]
		public unsafe global::Com.Nostra13.Universalimageloader.Cache.Disc.Impl.Ext.DiskLruCache.Editor Edit (string p0)
		{
			if (id_edit_Ljava_lang_String_ == IntPtr.Zero)
				id_edit_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "edit", "(Ljava/lang/String;)Lcom/nostra13/universalimageloader/cache/disc/impl/ext/DiskLruCache$Editor;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Nostra13.Universalimageloader.Cache.Disc.Impl.Ext.DiskLruCache.Editor __ret = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Cache.Disc.Impl.Ext.DiskLruCache.Editor> (JNIEnv.CallObjectMethod  (Handle, id_edit_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_fileCount;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.impl.ext']/class[@name='DiskLruCache']/method[@name='fileCount' and count(parameter)=0]"
		[Register ("fileCount", "()J", "")]
		public unsafe long FileCount ()
		{
			if (id_fileCount == IntPtr.Zero)
				id_fileCount = JNIEnv.GetMethodID (class_ref, "fileCount", "()J");
			try {
				return JNIEnv.CallLongMethod  (Handle, id_fileCount);
			} finally {
			}
		}

		static IntPtr id_flush;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.impl.ext']/class[@name='DiskLruCache']/method[@name='flush' and count(parameter)=0]"
		[Register ("flush", "()V", "")]
		public unsafe void Flush ()
		{
			if (id_flush == IntPtr.Zero)
				id_flush = JNIEnv.GetMethodID (class_ref, "flush", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_flush);
			} finally {
			}
		}

		static IntPtr id_get_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.impl.ext']/class[@name='DiskLruCache']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;)Lcom/nostra13/universalimageloader/cache/disc/impl/ext/DiskLruCache$Snapshot;", "")]
		public unsafe global::Com.Nostra13.Universalimageloader.Cache.Disc.Impl.Ext.DiskLruCache.Snapshot Get (string p0)
		{
			if (id_get_Ljava_lang_String_ == IntPtr.Zero)
				id_get_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/String;)Lcom/nostra13/universalimageloader/cache/disc/impl/ext/DiskLruCache$Snapshot;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Nostra13.Universalimageloader.Cache.Disc.Impl.Ext.DiskLruCache.Snapshot __ret = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Cache.Disc.Impl.Ext.DiskLruCache.Snapshot> (JNIEnv.CallObjectMethod  (Handle, id_get_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_remove_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.impl.ext']/class[@name='DiskLruCache']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("remove", "(Ljava/lang/String;)Z", "")]
		public unsafe bool Remove (string p0)
		{
			if (id_remove_Ljava_lang_String_ == IntPtr.Zero)
				id_remove_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "remove", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_remove_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_size;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.cache.disc.impl.ext']/class[@name='DiskLruCache']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()J", "")]
		public unsafe long Size ()
		{
			if (id_size == IntPtr.Zero)
				id_size = JNIEnv.GetMethodID (class_ref, "size", "()J");
			try {
				return JNIEnv.CallLongMethod  (Handle, id_size);
			} finally {
			}
		}

	}
}
