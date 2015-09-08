using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nostra13.Universalimageloader.Core.Display {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.core.display']/class[@name='RoundedBitmapDisplayer']"
	[global::Android.Runtime.Register ("com/nostra13/universalimageloader/core/display/RoundedBitmapDisplayer", DoNotGenerateAcw=true)]
	public partial class RoundedBitmapDisplayer : global::Java.Lang.Object, global::Com.Nostra13.Universalimageloader.Core.Display.IBitmapDisplayer {


		static IntPtr cornerRadius_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.core.display']/class[@name='RoundedBitmapDisplayer']/field[@name='cornerRadius']"
		[Register ("cornerRadius")]
		protected int CornerRadius {
			get {
				if (cornerRadius_jfieldId == IntPtr.Zero)
					cornerRadius_jfieldId = JNIEnv.GetFieldID (class_ref, "cornerRadius", "I");
				return JNIEnv.GetIntField (Handle, cornerRadius_jfieldId);
			}
			set {
				if (cornerRadius_jfieldId == IntPtr.Zero)
					cornerRadius_jfieldId = JNIEnv.GetFieldID (class_ref, "cornerRadius", "I");
				try {
					JNIEnv.SetField (Handle, cornerRadius_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr margin_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.core.display']/class[@name='RoundedBitmapDisplayer']/field[@name='margin']"
		[Register ("margin")]
		protected int Margin {
			get {
				if (margin_jfieldId == IntPtr.Zero)
					margin_jfieldId = JNIEnv.GetFieldID (class_ref, "margin", "I");
				return JNIEnv.GetIntField (Handle, margin_jfieldId);
			}
			set {
				if (margin_jfieldId == IntPtr.Zero)
					margin_jfieldId = JNIEnv.GetFieldID (class_ref, "margin", "I");
				try {
					JNIEnv.SetField (Handle, margin_jfieldId, value);
				} finally {
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.core.display']/class[@name='RoundedBitmapDisplayer.RoundedDrawable']"
		[global::Android.Runtime.Register ("com/nostra13/universalimageloader/core/display/RoundedBitmapDisplayer$RoundedDrawable", DoNotGenerateAcw=true)]
		public partial class RoundedDrawable : global::Android.Graphics.Drawables.Drawable {


			static IntPtr bitmapShader_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.core.display']/class[@name='RoundedBitmapDisplayer.RoundedDrawable']/field[@name='bitmapShader']"
			[Register ("bitmapShader")]
			protected global::Android.Graphics.BitmapShader BitmapShader {
				get {
					if (bitmapShader_jfieldId == IntPtr.Zero)
						bitmapShader_jfieldId = JNIEnv.GetFieldID (class_ref, "bitmapShader", "Landroid/graphics/BitmapShader;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, bitmapShader_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.BitmapShader> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (bitmapShader_jfieldId == IntPtr.Zero)
						bitmapShader_jfieldId = JNIEnv.GetFieldID (class_ref, "bitmapShader", "Landroid/graphics/BitmapShader;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (Handle, bitmapShader_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr cornerRadius_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.core.display']/class[@name='RoundedBitmapDisplayer.RoundedDrawable']/field[@name='cornerRadius']"
			[Register ("cornerRadius")]
			protected float CornerRadius {
				get {
					if (cornerRadius_jfieldId == IntPtr.Zero)
						cornerRadius_jfieldId = JNIEnv.GetFieldID (class_ref, "cornerRadius", "F");
					return JNIEnv.GetFloatField (Handle, cornerRadius_jfieldId);
				}
				set {
					if (cornerRadius_jfieldId == IntPtr.Zero)
						cornerRadius_jfieldId = JNIEnv.GetFieldID (class_ref, "cornerRadius", "F");
					try {
						JNIEnv.SetField (Handle, cornerRadius_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr mBitmapRect_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.core.display']/class[@name='RoundedBitmapDisplayer.RoundedDrawable']/field[@name='mBitmapRect']"
			[Register ("mBitmapRect")]
			protected global::Android.Graphics.RectF MBitmapRect {
				get {
					if (mBitmapRect_jfieldId == IntPtr.Zero)
						mBitmapRect_jfieldId = JNIEnv.GetFieldID (class_ref, "mBitmapRect", "Landroid/graphics/RectF;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, mBitmapRect_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.RectF> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (mBitmapRect_jfieldId == IntPtr.Zero)
						mBitmapRect_jfieldId = JNIEnv.GetFieldID (class_ref, "mBitmapRect", "Landroid/graphics/RectF;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (Handle, mBitmapRect_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr mRect_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.core.display']/class[@name='RoundedBitmapDisplayer.RoundedDrawable']/field[@name='mRect']"
			[Register ("mRect")]
			protected global::Android.Graphics.RectF MRect {
				get {
					if (mRect_jfieldId == IntPtr.Zero)
						mRect_jfieldId = JNIEnv.GetFieldID (class_ref, "mRect", "Landroid/graphics/RectF;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, mRect_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.RectF> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (mRect_jfieldId == IntPtr.Zero)
						mRect_jfieldId = JNIEnv.GetFieldID (class_ref, "mRect", "Landroid/graphics/RectF;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (Handle, mRect_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr margin_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.core.display']/class[@name='RoundedBitmapDisplayer.RoundedDrawable']/field[@name='margin']"
			[Register ("margin")]
			protected int Margin {
				get {
					if (margin_jfieldId == IntPtr.Zero)
						margin_jfieldId = JNIEnv.GetFieldID (class_ref, "margin", "I");
					return JNIEnv.GetIntField (Handle, margin_jfieldId);
				}
				set {
					if (margin_jfieldId == IntPtr.Zero)
						margin_jfieldId = JNIEnv.GetFieldID (class_ref, "margin", "I");
					try {
						JNIEnv.SetField (Handle, margin_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr paint_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.nostra13.universalimageloader.core.display']/class[@name='RoundedBitmapDisplayer.RoundedDrawable']/field[@name='paint']"
			[Register ("paint")]
			protected global::Android.Graphics.Paint Paint {
				get {
					if (paint_jfieldId == IntPtr.Zero)
						paint_jfieldId = JNIEnv.GetFieldID (class_ref, "paint", "Landroid/graphics/Paint;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, paint_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (paint_jfieldId == IntPtr.Zero)
						paint_jfieldId = JNIEnv.GetFieldID (class_ref, "paint", "Landroid/graphics/Paint;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (Handle, paint_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/nostra13/universalimageloader/core/display/RoundedBitmapDisplayer$RoundedDrawable", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (RoundedDrawable); }
			}

			protected RoundedDrawable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Landroid_graphics_Bitmap_II;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nostra13.universalimageloader.core.display']/class[@name='RoundedBitmapDisplayer.RoundedDrawable']/constructor[@name='RoundedBitmapDisplayer.RoundedDrawable' and count(parameter)=3 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register (".ctor", "(Landroid/graphics/Bitmap;II)V", "")]
			public unsafe RoundedDrawable (global::Android.Graphics.Bitmap p0, int p1, int p2)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					if (GetType () != typeof (RoundedDrawable)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/graphics/Bitmap;II)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/graphics/Bitmap;II)V", __args);
						return;
					}

					if (id_ctor_Landroid_graphics_Bitmap_II == IntPtr.Zero)
						id_ctor_Landroid_graphics_Bitmap_II = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/graphics/Bitmap;II)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_graphics_Bitmap_II, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_graphics_Bitmap_II, __args);
				} finally {
				}
			}

			static Delegate cb_getOpacity;
#pragma warning disable 0169
			static Delegate GetGetOpacityHandler ()
			{
				if (cb_getOpacity == null)
					cb_getOpacity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetOpacity);
				return cb_getOpacity;
			}

			static int n_GetOpacity (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Nostra13.Universalimageloader.Core.Display.RoundedBitmapDisplayer.RoundedDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Display.RoundedBitmapDisplayer.RoundedDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Opacity;
			}
#pragma warning restore 0169

			static IntPtr id_getOpacity;
			public override unsafe int Opacity {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.display']/class[@name='RoundedBitmapDisplayer.RoundedDrawable']/method[@name='getOpacity' and count(parameter)=0]"
				[Register ("getOpacity", "()I", "GetGetOpacityHandler")]
				get {
					if (id_getOpacity == IntPtr.Zero)
						id_getOpacity = JNIEnv.GetMethodID (class_ref, "getOpacity", "()I");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.CallIntMethod  (Handle, id_getOpacity);
						else
							return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOpacity", "()I"));
					} finally {
					}
				}
			}

			static Delegate cb_draw_Landroid_graphics_Canvas_;
#pragma warning disable 0169
			static Delegate GetDraw_Landroid_graphics_Canvas_Handler ()
			{
				if (cb_draw_Landroid_graphics_Canvas_ == null)
					cb_draw_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Draw_Landroid_graphics_Canvas_);
				return cb_draw_Landroid_graphics_Canvas_;
			}

			static void n_Draw_Landroid_graphics_Canvas_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Nostra13.Universalimageloader.Core.Display.RoundedBitmapDisplayer.RoundedDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Display.RoundedBitmapDisplayer.RoundedDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Draw (p0);
			}
#pragma warning restore 0169

			static IntPtr id_draw_Landroid_graphics_Canvas_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.display']/class[@name='RoundedBitmapDisplayer.RoundedDrawable']/method[@name='draw' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
			[Register ("draw", "(Landroid/graphics/Canvas;)V", "GetDraw_Landroid_graphics_Canvas_Handler")]
			public override unsafe void Draw (global::Android.Graphics.Canvas p0)
			{
				if (id_draw_Landroid_graphics_Canvas_ == IntPtr.Zero)
					id_draw_Landroid_graphics_Canvas_ = JNIEnv.GetMethodID (class_ref, "draw", "(Landroid/graphics/Canvas;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_draw_Landroid_graphics_Canvas_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "draw", "(Landroid/graphics/Canvas;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_setAlpha_I;
#pragma warning disable 0169
			static Delegate GetSetAlpha_IHandler ()
			{
				if (cb_setAlpha_I == null)
					cb_setAlpha_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetAlpha_I);
				return cb_setAlpha_I;
			}

			static void n_SetAlpha_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Nostra13.Universalimageloader.Core.Display.RoundedBitmapDisplayer.RoundedDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Display.RoundedBitmapDisplayer.RoundedDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.SetAlpha (p0);
			}
#pragma warning restore 0169

			static IntPtr id_setAlpha_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.display']/class[@name='RoundedBitmapDisplayer.RoundedDrawable']/method[@name='setAlpha' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setAlpha", "(I)V", "GetSetAlpha_IHandler")]
			public override unsafe void SetAlpha (int p0)
			{
				if (id_setAlpha_I == IntPtr.Zero)
					id_setAlpha_I = JNIEnv.GetMethodID (class_ref, "setAlpha", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setAlpha_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAlpha", "(I)V"), __args);
				} finally {
				}
			}

			static Delegate cb_setColorFilter_Landroid_graphics_ColorFilter_;
#pragma warning disable 0169
			static Delegate GetSetColorFilter_Landroid_graphics_ColorFilter_Handler ()
			{
				if (cb_setColorFilter_Landroid_graphics_ColorFilter_ == null)
					cb_setColorFilter_Landroid_graphics_ColorFilter_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetColorFilter_Landroid_graphics_ColorFilter_);
				return cb_setColorFilter_Landroid_graphics_ColorFilter_;
			}

			static void n_SetColorFilter_Landroid_graphics_ColorFilter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Nostra13.Universalimageloader.Core.Display.RoundedBitmapDisplayer.RoundedDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Display.RoundedBitmapDisplayer.RoundedDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.ColorFilter p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.ColorFilter> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.SetColorFilter (p0);
			}
#pragma warning restore 0169

			static IntPtr id_setColorFilter_Landroid_graphics_ColorFilter_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.display']/class[@name='RoundedBitmapDisplayer.RoundedDrawable']/method[@name='setColorFilter' and count(parameter)=1 and parameter[1][@type='android.graphics.ColorFilter']]"
			[Register ("setColorFilter", "(Landroid/graphics/ColorFilter;)V", "GetSetColorFilter_Landroid_graphics_ColorFilter_Handler")]
			public override unsafe void SetColorFilter (global::Android.Graphics.ColorFilter p0)
			{
				if (id_setColorFilter_Landroid_graphics_ColorFilter_ == IntPtr.Zero)
					id_setColorFilter_Landroid_graphics_ColorFilter_ = JNIEnv.GetMethodID (class_ref, "setColorFilter", "(Landroid/graphics/ColorFilter;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setColorFilter_Landroid_graphics_ColorFilter_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V"), __args);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nostra13/universalimageloader/core/display/RoundedBitmapDisplayer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RoundedBitmapDisplayer); }
		}

		protected RoundedBitmapDisplayer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nostra13.universalimageloader.core.display']/class[@name='RoundedBitmapDisplayer']/constructor[@name='RoundedBitmapDisplayer' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register (".ctor", "(II)V", "")]
		public unsafe RoundedBitmapDisplayer (int p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (RoundedBitmapDisplayer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(II)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(II)V", __args);
					return;
				}

				if (id_ctor_II == IntPtr.Zero)
					id_ctor_II = JNIEnv.GetMethodID (class_ref, "<init>", "(II)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_II, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_II, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nostra13.universalimageloader.core.display']/class[@name='RoundedBitmapDisplayer']/constructor[@name='RoundedBitmapDisplayer' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe RoundedBitmapDisplayer (int p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (RoundedBitmapDisplayer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(I)V", __args);
					return;
				}

				if (id_ctor_I == IntPtr.Zero)
					id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_I, __args);
			} finally {
			}
		}

		static Delegate cb_display_Landroid_graphics_Bitmap_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_assist_LoadedFrom_;
#pragma warning disable 0169
		static Delegate GetDisplay_Landroid_graphics_Bitmap_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_assist_LoadedFrom_Handler ()
		{
			if (cb_display_Landroid_graphics_Bitmap_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_assist_LoadedFrom_ == null)
				cb_display_Landroid_graphics_Bitmap_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_assist_LoadedFrom_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Display_Landroid_graphics_Bitmap_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_assist_LoadedFrom_);
			return cb_display_Landroid_graphics_Bitmap_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_assist_LoadedFrom_;
		}

		static void n_Display_Landroid_graphics_Bitmap_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_assist_LoadedFrom_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Nostra13.Universalimageloader.Core.Display.RoundedBitmapDisplayer __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Display.RoundedBitmapDisplayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Nostra13.Universalimageloader.Core.Imageaware.IImageAware p1 = (global::Com.Nostra13.Universalimageloader.Core.Imageaware.IImageAware)global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Imageaware.IImageAware> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Nostra13.Universalimageloader.Core.Assist.LoadedFrom p2 = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.LoadedFrom> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Display (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_display_Landroid_graphics_Bitmap_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_assist_LoadedFrom_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.display']/class[@name='RoundedBitmapDisplayer']/method[@name='display' and count(parameter)=3 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='com.nostra13.universalimageloader.core.imageaware.ImageAware'] and parameter[3][@type='com.nostra13.universalimageloader.core.assist.LoadedFrom']]"
		[Register ("display", "(Landroid/graphics/Bitmap;Lcom/nostra13/universalimageloader/core/imageaware/ImageAware;Lcom/nostra13/universalimageloader/core/assist/LoadedFrom;)V", "GetDisplay_Landroid_graphics_Bitmap_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_assist_LoadedFrom_Handler")]
		public virtual unsafe void Display (global::Android.Graphics.Bitmap p0, global::Com.Nostra13.Universalimageloader.Core.Imageaware.IImageAware p1, global::Com.Nostra13.Universalimageloader.Core.Assist.LoadedFrom p2)
		{
			if (id_display_Landroid_graphics_Bitmap_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_assist_LoadedFrom_ == IntPtr.Zero)
				id_display_Landroid_graphics_Bitmap_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_assist_LoadedFrom_ = JNIEnv.GetMethodID (class_ref, "display", "(Landroid/graphics/Bitmap;Lcom/nostra13/universalimageloader/core/imageaware/ImageAware;Lcom/nostra13/universalimageloader/core/assist/LoadedFrom;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_display_Landroid_graphics_Bitmap_Lcom_nostra13_universalimageloader_core_imageaware_ImageAware_Lcom_nostra13_universalimageloader_core_assist_LoadedFrom_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "display", "(Landroid/graphics/Bitmap;Lcom/nostra13/universalimageloader/core/imageaware/ImageAware;Lcom/nostra13/universalimageloader/core/assist/LoadedFrom;)V"), __args);
			} finally {
			}
		}

	}
}
