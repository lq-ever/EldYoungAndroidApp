using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nostra13.Universalimageloader.Core.Decode {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.core.decode']/class[@name='BaseImageDecoder']"
	[global::Android.Runtime.Register ("com/nostra13/universalimageloader/core/decode/BaseImageDecoder", DoNotGenerateAcw=true)]
	public partial class BaseImageDecoder : global::Java.Lang.Object, global::Com.Nostra13.Universalimageloader.Core.Decode.IImageDecoder {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.core.decode']/class[@name='BaseImageDecoder']/field[@name='ERROR_CANT_DECODE_IMAGE']"
		[Register ("ERROR_CANT_DECODE_IMAGE")]
		protected const string ErrorCantDecodeImage = (string) "Image can't be decoded [%s]";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.core.decode']/class[@name='BaseImageDecoder']/field[@name='ERROR_NO_IMAGE_STREAM']"
		[Register ("ERROR_NO_IMAGE_STREAM")]
		protected const string ErrorNoImageStream = (string) "No stream for image [%s]";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.core.decode']/class[@name='BaseImageDecoder']/field[@name='LOG_FLIP_IMAGE']"
		[Register ("LOG_FLIP_IMAGE")]
		protected const string LogFlipImage = (string) "Flip image horizontally [%s]";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.core.decode']/class[@name='BaseImageDecoder']/field[@name='LOG_ROTATE_IMAGE']"
		[Register ("LOG_ROTATE_IMAGE")]
		protected const string LogRotateImage = (string) "Rotate image on %1$d° [%2$s]";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.core.decode']/class[@name='BaseImageDecoder']/field[@name='LOG_SCALE_IMAGE']"
		[Register ("LOG_SCALE_IMAGE")]
		protected const string LogScaleImage = (string) "Scale subsampled image (%1$s) to %2$s (scale = %3$.5f) [%4$s]";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.core.decode']/class[@name='BaseImageDecoder']/field[@name='LOG_SUBSAMPLE_IMAGE']"
		[Register ("LOG_SUBSAMPLE_IMAGE")]
		protected const string LogSubsampleImage = (string) "Subsample original image (%1$s) to %2$s (scale = %3$d) [%4$s]";

		static IntPtr loggingEnabled_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.core.decode']/class[@name='BaseImageDecoder']/field[@name='loggingEnabled']"
		[Register ("loggingEnabled")]
		protected bool LoggingEnabled {
			get {
				if (loggingEnabled_jfieldId == IntPtr.Zero)
					loggingEnabled_jfieldId = JNIEnv.GetFieldID (class_ref, "loggingEnabled", "Z");
				return JNIEnv.GetBooleanField (Handle, loggingEnabled_jfieldId);
			}
			set {
				if (loggingEnabled_jfieldId == IntPtr.Zero)
					loggingEnabled_jfieldId = JNIEnv.GetFieldID (class_ref, "loggingEnabled", "Z");
				try {
					JNIEnv.SetField (Handle, loggingEnabled_jfieldId, value);
				} finally {
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.core.decode']/class[@name='BaseImageDecoder.ExifInfo']"
		[global::Android.Runtime.Register ("com/nostra13/universalimageloader/core/decode/BaseImageDecoder$ExifInfo", DoNotGenerateAcw=true)]
		protected internal partial class ExifInfo : global::Java.Lang.Object {


			static IntPtr flipHorizontal_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.core.decode']/class[@name='BaseImageDecoder.ExifInfo']/field[@name='flipHorizontal']"
			[Register ("flipHorizontal")]
			public bool FlipHorizontal {
				get {
					if (flipHorizontal_jfieldId == IntPtr.Zero)
						flipHorizontal_jfieldId = JNIEnv.GetFieldID (class_ref, "flipHorizontal", "Z");
					return JNIEnv.GetBooleanField (Handle, flipHorizontal_jfieldId);
				}
				set {
					if (flipHorizontal_jfieldId == IntPtr.Zero)
						flipHorizontal_jfieldId = JNIEnv.GetFieldID (class_ref, "flipHorizontal", "Z");
					try {
						JNIEnv.SetField (Handle, flipHorizontal_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr rotation_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.core.decode']/class[@name='BaseImageDecoder.ExifInfo']/field[@name='rotation']"
			[Register ("rotation")]
			public int Rotation {
				get {
					if (rotation_jfieldId == IntPtr.Zero)
						rotation_jfieldId = JNIEnv.GetFieldID (class_ref, "rotation", "I");
					return JNIEnv.GetIntField (Handle, rotation_jfieldId);
				}
				set {
					if (rotation_jfieldId == IntPtr.Zero)
						rotation_jfieldId = JNIEnv.GetFieldID (class_ref, "rotation", "I");
					try {
						JNIEnv.SetField (Handle, rotation_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/nostra13/universalimageloader/core/decode/BaseImageDecoder$ExifInfo", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ExifInfo); }
			}

			protected ExifInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nostra13.universalimageloader.core.decode']/class[@name='BaseImageDecoder.ExifInfo']/constructor[@name='BaseImageDecoder.ExifInfo' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			protected unsafe ExifInfo ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (ExifInfo)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
						return;
					}

					if (id_ctor == IntPtr.Zero)
						id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
				} finally {
				}
			}

			static IntPtr id_ctor_IZ;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nostra13.universalimageloader.core.decode']/class[@name='BaseImageDecoder.ExifInfo']/constructor[@name='BaseImageDecoder.ExifInfo' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
			[Register (".ctor", "(IZ)V", "")]
			protected unsafe ExifInfo (int p0, bool p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					if (GetType () != typeof (ExifInfo)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(IZ)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(IZ)V", __args);
						return;
					}

					if (id_ctor_IZ == IntPtr.Zero)
						id_ctor_IZ = JNIEnv.GetMethodID (class_ref, "<init>", "(IZ)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IZ, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_IZ, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.core.decode']/class[@name='BaseImageDecoder.ImageFileInfo']"
		[global::Android.Runtime.Register ("com/nostra13/universalimageloader/core/decode/BaseImageDecoder$ImageFileInfo", DoNotGenerateAcw=true)]
		protected internal partial class ImageFileInfo : global::Java.Lang.Object {


			static IntPtr exif_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.core.decode']/class[@name='BaseImageDecoder.ImageFileInfo']/field[@name='exif']"
			[Register ("exif")]
			public global::Com.Nostra13.Universalimageloader.Core.Decode.BaseImageDecoder.ExifInfo Exif {
				get {
					if (exif_jfieldId == IntPtr.Zero)
						exif_jfieldId = JNIEnv.GetFieldID (class_ref, "exif", "Lcom/nostra13/universalimageloader/core/decode/BaseImageDecoder$ExifInfo;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, exif_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Decode.BaseImageDecoder.ExifInfo> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (exif_jfieldId == IntPtr.Zero)
						exif_jfieldId = JNIEnv.GetFieldID (class_ref, "exif", "Lcom/nostra13/universalimageloader/core/decode/BaseImageDecoder$ExifInfo;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (Handle, exif_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr imageSize_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.core.decode']/class[@name='BaseImageDecoder.ImageFileInfo']/field[@name='imageSize']"
			[Register ("imageSize")]
			public global::Com.Nostra13.Universalimageloader.Core.Assist.ImageSize ImageSize {
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
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/nostra13/universalimageloader/core/decode/BaseImageDecoder$ImageFileInfo", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ImageFileInfo); }
			}

			protected ImageFileInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_decode_BaseImageDecoder_ExifInfo_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nostra13.universalimageloader.core.decode']/class[@name='BaseImageDecoder.ImageFileInfo']/constructor[@name='BaseImageDecoder.ImageFileInfo' and count(parameter)=2 and parameter[1][@type='com.nostra13.universalimageloader.core.assist.ImageSize'] and parameter[2][@type='com.nostra13.universalimageloader.core.decode.BaseImageDecoder.ExifInfo']]"
			[Register (".ctor", "(Lcom/nostra13/universalimageloader/core/assist/ImageSize;Lcom/nostra13/universalimageloader/core/decode/BaseImageDecoder$ExifInfo;)V", "")]
			protected unsafe ImageFileInfo (global::Com.Nostra13.Universalimageloader.Core.Assist.ImageSize p0, global::Com.Nostra13.Universalimageloader.Core.Decode.BaseImageDecoder.ExifInfo p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					if (GetType () != typeof (ImageFileInfo)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/nostra13/universalimageloader/core/assist/ImageSize;Lcom/nostra13/universalimageloader/core/decode/BaseImageDecoder$ExifInfo;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/nostra13/universalimageloader/core/assist/ImageSize;Lcom/nostra13/universalimageloader/core/decode/BaseImageDecoder$ExifInfo;)V", __args);
						return;
					}

					if (id_ctor_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_decode_BaseImageDecoder_ExifInfo_ == IntPtr.Zero)
						id_ctor_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_decode_BaseImageDecoder_ExifInfo_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/nostra13/universalimageloader/core/assist/ImageSize;Lcom/nostra13/universalimageloader/core/decode/BaseImageDecoder$ExifInfo;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_decode_BaseImageDecoder_ExifInfo_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_decode_BaseImageDecoder_ExifInfo_, __args);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nostra13/universalimageloader/core/decode/BaseImageDecoder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseImageDecoder); }
		}

		protected BaseImageDecoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nostra13.universalimageloader.core.decode']/class[@name='BaseImageDecoder']/constructor[@name='BaseImageDecoder' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register (".ctor", "(Z)V", "")]
		public unsafe BaseImageDecoder (bool p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (BaseImageDecoder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Z)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Z)V", __args);
					return;
				}

				if (id_ctor_Z == IntPtr.Zero)
					id_ctor_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Z)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Z, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Z, __args);
			} finally {
			}
		}

		static Delegate cb_considerExactScaleAndOrientatiton_Landroid_graphics_Bitmap_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_IZ;
#pragma warning disable 0169
		static Delegate GetConsiderExactScaleAndOrientatiton_Landroid_graphics_Bitmap_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_IZHandler ()
		{
			if (cb_considerExactScaleAndOrientatiton_Landroid_graphics_Bitmap_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_IZ == null)
				cb_considerExactScaleAndOrientatiton_Landroid_graphics_Bitmap_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_IZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int, bool, IntPtr>) n_ConsiderExactScaleAndOrientatiton_Landroid_graphics_Bitmap_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_IZ);
			return cb_considerExactScaleAndOrientatiton_Landroid_graphics_Bitmap_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_IZ;
		}

		static IntPtr n_ConsiderExactScaleAndOrientatiton_Landroid_graphics_Bitmap_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_IZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, bool p3)
		{
			global::Com.Nostra13.Universalimageloader.Core.Decode.BaseImageDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Decode.BaseImageDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Nostra13.Universalimageloader.Core.Decode.ImageDecodingInfo p1 = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Decode.ImageDecodingInfo> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ConsiderExactScaleAndOrientatiton (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_considerExactScaleAndOrientatiton_Landroid_graphics_Bitmap_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.decode']/class[@name='BaseImageDecoder']/method[@name='considerExactScaleAndOrientatiton' and count(parameter)=4 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='com.nostra13.universalimageloader.core.decode.ImageDecodingInfo'] and parameter[3][@type='int'] and parameter[4][@type='boolean']]"
		[Register ("considerExactScaleAndOrientatiton", "(Landroid/graphics/Bitmap;Lcom/nostra13/universalimageloader/core/decode/ImageDecodingInfo;IZ)Landroid/graphics/Bitmap;", "GetConsiderExactScaleAndOrientatiton_Landroid_graphics_Bitmap_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_IZHandler")]
		protected virtual unsafe global::Android.Graphics.Bitmap ConsiderExactScaleAndOrientatiton (global::Android.Graphics.Bitmap p0, global::Com.Nostra13.Universalimageloader.Core.Decode.ImageDecodingInfo p1, int p2, bool p3)
		{
			if (id_considerExactScaleAndOrientatiton_Landroid_graphics_Bitmap_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_IZ == IntPtr.Zero)
				id_considerExactScaleAndOrientatiton_Landroid_graphics_Bitmap_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_IZ = JNIEnv.GetMethodID (class_ref, "considerExactScaleAndOrientatiton", "(Landroid/graphics/Bitmap;Lcom/nostra13/universalimageloader/core/decode/ImageDecodingInfo;IZ)Landroid/graphics/Bitmap;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				global::Android.Graphics.Bitmap __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod  (Handle, id_considerExactScaleAndOrientatiton_Landroid_graphics_Bitmap_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_IZ, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "considerExactScaleAndOrientatiton", "(Landroid/graphics/Bitmap;Lcom/nostra13/universalimageloader/core/decode/ImageDecodingInfo;IZ)Landroid/graphics/Bitmap;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_decode_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_;
#pragma warning disable 0169
		static Delegate GetDecode_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_Handler ()
		{
			if (cb_decode_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_ == null)
				cb_decode_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Decode_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_);
			return cb_decode_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_;
		}

		static IntPtr n_Decode_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nostra13.Universalimageloader.Core.Decode.BaseImageDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Decode.BaseImageDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nostra13.Universalimageloader.Core.Decode.ImageDecodingInfo p0 = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Decode.ImageDecodingInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Decode (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decode_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.decode']/class[@name='BaseImageDecoder']/method[@name='decode' and count(parameter)=1 and parameter[1][@type='com.nostra13.universalimageloader.core.decode.ImageDecodingInfo']]"
		[Register ("decode", "(Lcom/nostra13/universalimageloader/core/decode/ImageDecodingInfo;)Landroid/graphics/Bitmap;", "GetDecode_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_Handler")]
		public virtual unsafe global::Android.Graphics.Bitmap Decode (global::Com.Nostra13.Universalimageloader.Core.Decode.ImageDecodingInfo p0)
		{
			if (id_decode_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_ == IntPtr.Zero)
				id_decode_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_ = JNIEnv.GetMethodID (class_ref, "decode", "(Lcom/nostra13/universalimageloader/core/decode/ImageDecodingInfo;)Landroid/graphics/Bitmap;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Android.Graphics.Bitmap __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod  (Handle, id_decode_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decode", "(Lcom/nostra13/universalimageloader/core/decode/ImageDecodingInfo;)Landroid/graphics/Bitmap;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_defineExifOrientation_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDefineExifOrientation_Ljava_lang_String_Handler ()
		{
			if (cb_defineExifOrientation_Ljava_lang_String_ == null)
				cb_defineExifOrientation_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DefineExifOrientation_Ljava_lang_String_);
			return cb_defineExifOrientation_Ljava_lang_String_;
		}

		static IntPtr n_DefineExifOrientation_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nostra13.Universalimageloader.Core.Decode.BaseImageDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Decode.BaseImageDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DefineExifOrientation (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_defineExifOrientation_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.decode']/class[@name='BaseImageDecoder']/method[@name='defineExifOrientation' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("defineExifOrientation", "(Ljava/lang/String;)Lcom/nostra13/universalimageloader/core/decode/BaseImageDecoder$ExifInfo;", "GetDefineExifOrientation_Ljava_lang_String_Handler")]
		protected virtual unsafe global::Com.Nostra13.Universalimageloader.Core.Decode.BaseImageDecoder.ExifInfo DefineExifOrientation (string p0)
		{
			if (id_defineExifOrientation_Ljava_lang_String_ == IntPtr.Zero)
				id_defineExifOrientation_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "defineExifOrientation", "(Ljava/lang/String;)Lcom/nostra13/universalimageloader/core/decode/BaseImageDecoder$ExifInfo;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Nostra13.Universalimageloader.Core.Decode.BaseImageDecoder.ExifInfo __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Decode.BaseImageDecoder.ExifInfo> (JNIEnv.CallObjectMethod  (Handle, id_defineExifOrientation_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Decode.BaseImageDecoder.ExifInfo> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "defineExifOrientation", "(Ljava/lang/String;)Lcom/nostra13/universalimageloader/core/decode/BaseImageDecoder$ExifInfo;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_defineImageSizeAndRotation_Ljava_io_InputStream_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_;
#pragma warning disable 0169
		static Delegate GetDefineImageSizeAndRotation_Ljava_io_InputStream_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_Handler ()
		{
			if (cb_defineImageSizeAndRotation_Ljava_io_InputStream_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_ == null)
				cb_defineImageSizeAndRotation_Ljava_io_InputStream_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_DefineImageSizeAndRotation_Ljava_io_InputStream_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_);
			return cb_defineImageSizeAndRotation_Ljava_io_InputStream_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_;
		}

		static IntPtr n_DefineImageSizeAndRotation_Ljava_io_InputStream_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Nostra13.Universalimageloader.Core.Decode.BaseImageDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Decode.BaseImageDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p0 = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Nostra13.Universalimageloader.Core.Decode.ImageDecodingInfo p1 = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Decode.ImageDecodingInfo> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DefineImageSizeAndRotation (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_defineImageSizeAndRotation_Ljava_io_InputStream_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.decode']/class[@name='BaseImageDecoder']/method[@name='defineImageSizeAndRotation' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='com.nostra13.universalimageloader.core.decode.ImageDecodingInfo']]"
		[Register ("defineImageSizeAndRotation", "(Ljava/io/InputStream;Lcom/nostra13/universalimageloader/core/decode/ImageDecodingInfo;)Lcom/nostra13/universalimageloader/core/decode/BaseImageDecoder$ImageFileInfo;", "GetDefineImageSizeAndRotation_Ljava_io_InputStream_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_Handler")]
		protected virtual unsafe global::Com.Nostra13.Universalimageloader.Core.Decode.BaseImageDecoder.ImageFileInfo DefineImageSizeAndRotation (global::System.IO.Stream p0, global::Com.Nostra13.Universalimageloader.Core.Decode.ImageDecodingInfo p1)
		{
			if (id_defineImageSizeAndRotation_Ljava_io_InputStream_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_ == IntPtr.Zero)
				id_defineImageSizeAndRotation_Ljava_io_InputStream_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_ = JNIEnv.GetMethodID (class_ref, "defineImageSizeAndRotation", "(Ljava/io/InputStream;Lcom/nostra13/universalimageloader/core/decode/ImageDecodingInfo;)Lcom/nostra13/universalimageloader/core/decode/BaseImageDecoder$ImageFileInfo;");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				global::Com.Nostra13.Universalimageloader.Core.Decode.BaseImageDecoder.ImageFileInfo __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Decode.BaseImageDecoder.ImageFileInfo> (JNIEnv.CallObjectMethod  (Handle, id_defineImageSizeAndRotation_Ljava_io_InputStream_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Decode.BaseImageDecoder.ImageFileInfo> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "defineImageSizeAndRotation", "(Ljava/io/InputStream;Lcom/nostra13/universalimageloader/core/decode/ImageDecodingInfo;)Lcom/nostra13/universalimageloader/core/decode/BaseImageDecoder$ImageFileInfo;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getImageStream_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_;
#pragma warning disable 0169
		static Delegate GetGetImageStream_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_Handler ()
		{
			if (cb_getImageStream_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_ == null)
				cb_getImageStream_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetImageStream_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_);
			return cb_getImageStream_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_;
		}

		static IntPtr n_GetImageStream_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nostra13.Universalimageloader.Core.Decode.BaseImageDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Decode.BaseImageDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nostra13.Universalimageloader.Core.Decode.ImageDecodingInfo p0 = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Decode.ImageDecodingInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.GetImageStream (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getImageStream_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.decode']/class[@name='BaseImageDecoder']/method[@name='getImageStream' and count(parameter)=1 and parameter[1][@type='com.nostra13.universalimageloader.core.decode.ImageDecodingInfo']]"
		[Register ("getImageStream", "(Lcom/nostra13/universalimageloader/core/decode/ImageDecodingInfo;)Ljava/io/InputStream;", "GetGetImageStream_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_Handler")]
		protected virtual unsafe global::System.IO.Stream GetImageStream (global::Com.Nostra13.Universalimageloader.Core.Decode.ImageDecodingInfo p0)
		{
			if (id_getImageStream_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_ == IntPtr.Zero)
				id_getImageStream_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_ = JNIEnv.GetMethodID (class_ref, "getImageStream", "(Lcom/nostra13/universalimageloader/core/decode/ImageDecodingInfo;)Ljava/io/InputStream;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::System.IO.Stream __ret;
				if (GetType () == ThresholdType)
					__ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getImageStream_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImageStream", "(Lcom/nostra13/universalimageloader/core/decode/ImageDecodingInfo;)Ljava/io/InputStream;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_prepareDecodingOptions_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_;
#pragma warning disable 0169
		static Delegate GetPrepareDecodingOptions_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_Handler ()
		{
			if (cb_prepareDecodingOptions_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_ == null)
				cb_prepareDecodingOptions_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_PrepareDecodingOptions_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_);
			return cb_prepareDecodingOptions_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_;
		}

		static IntPtr n_PrepareDecodingOptions_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Nostra13.Universalimageloader.Core.Decode.BaseImageDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Decode.BaseImageDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nostra13.Universalimageloader.Core.Assist.ImageSize p0 = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.ImageSize> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Nostra13.Universalimageloader.Core.Decode.ImageDecodingInfo p1 = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Decode.ImageDecodingInfo> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PrepareDecodingOptions (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_prepareDecodingOptions_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.decode']/class[@name='BaseImageDecoder']/method[@name='prepareDecodingOptions' and count(parameter)=2 and parameter[1][@type='com.nostra13.universalimageloader.core.assist.ImageSize'] and parameter[2][@type='com.nostra13.universalimageloader.core.decode.ImageDecodingInfo']]"
		[Register ("prepareDecodingOptions", "(Lcom/nostra13/universalimageloader/core/assist/ImageSize;Lcom/nostra13/universalimageloader/core/decode/ImageDecodingInfo;)Landroid/graphics/BitmapFactory$Options;", "GetPrepareDecodingOptions_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_Handler")]
		protected virtual unsafe global::Android.Graphics.BitmapFactory.Options PrepareDecodingOptions (global::Com.Nostra13.Universalimageloader.Core.Assist.ImageSize p0, global::Com.Nostra13.Universalimageloader.Core.Decode.ImageDecodingInfo p1)
		{
			if (id_prepareDecodingOptions_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_ == IntPtr.Zero)
				id_prepareDecodingOptions_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_ = JNIEnv.GetMethodID (class_ref, "prepareDecodingOptions", "(Lcom/nostra13/universalimageloader/core/assist/ImageSize;Lcom/nostra13/universalimageloader/core/decode/ImageDecodingInfo;)Landroid/graphics/BitmapFactory$Options;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Android.Graphics.BitmapFactory.Options __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.BitmapFactory.Options> (JNIEnv.CallObjectMethod  (Handle, id_prepareDecodingOptions_Lcom_nostra13_universalimageloader_core_assist_ImageSize_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.BitmapFactory.Options> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "prepareDecodingOptions", "(Lcom/nostra13/universalimageloader/core/assist/ImageSize;Lcom/nostra13/universalimageloader/core/decode/ImageDecodingInfo;)Landroid/graphics/BitmapFactory$Options;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_resetStream_Ljava_io_InputStream_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_;
#pragma warning disable 0169
		static Delegate GetResetStream_Ljava_io_InputStream_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_Handler ()
		{
			if (cb_resetStream_Ljava_io_InputStream_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_ == null)
				cb_resetStream_Ljava_io_InputStream_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ResetStream_Ljava_io_InputStream_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_);
			return cb_resetStream_Ljava_io_InputStream_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_;
		}

		static IntPtr n_ResetStream_Ljava_io_InputStream_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Nostra13.Universalimageloader.Core.Decode.BaseImageDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Decode.BaseImageDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p0 = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Nostra13.Universalimageloader.Core.Decode.ImageDecodingInfo p1 = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Decode.ImageDecodingInfo> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.ResetStream (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_resetStream_Ljava_io_InputStream_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.decode']/class[@name='BaseImageDecoder']/method[@name='resetStream' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='com.nostra13.universalimageloader.core.decode.ImageDecodingInfo']]"
		[Register ("resetStream", "(Ljava/io/InputStream;Lcom/nostra13/universalimageloader/core/decode/ImageDecodingInfo;)Ljava/io/InputStream;", "GetResetStream_Ljava_io_InputStream_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_Handler")]
		protected virtual unsafe global::System.IO.Stream ResetStream (global::System.IO.Stream p0, global::Com.Nostra13.Universalimageloader.Core.Decode.ImageDecodingInfo p1)
		{
			if (id_resetStream_Ljava_io_InputStream_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_ == IntPtr.Zero)
				id_resetStream_Ljava_io_InputStream_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_ = JNIEnv.GetMethodID (class_ref, "resetStream", "(Ljava/io/InputStream;Lcom/nostra13/universalimageloader/core/decode/ImageDecodingInfo;)Ljava/io/InputStream;");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				global::System.IO.Stream __ret;
				if (GetType () == ThresholdType)
					__ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_resetStream_Ljava_io_InputStream_Lcom_nostra13_universalimageloader_core_decode_ImageDecodingInfo_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "resetStream", "(Ljava/io/InputStream;Lcom/nostra13/universalimageloader/core/decode/ImageDecodingInfo;)Ljava/io/InputStream;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
