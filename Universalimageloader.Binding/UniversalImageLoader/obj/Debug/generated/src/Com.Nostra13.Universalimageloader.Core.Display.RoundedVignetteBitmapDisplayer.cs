using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nostra13.Universalimageloader.Core.Display {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.core.display']/class[@name='RoundedVignetteBitmapDisplayer']"
	[global::Android.Runtime.Register ("com/nostra13/universalimageloader/core/display/RoundedVignetteBitmapDisplayer", DoNotGenerateAcw=true)]
	public partial class RoundedVignetteBitmapDisplayer : global::Com.Nostra13.Universalimageloader.Core.Display.RoundedBitmapDisplayer {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.core.display']/class[@name='RoundedVignetteBitmapDisplayer.RoundedVignetteDrawable']"
		[global::Android.Runtime.Register ("com/nostra13/universalimageloader/core/display/RoundedVignetteBitmapDisplayer$RoundedVignetteDrawable", DoNotGenerateAcw=true)]
		protected internal partial class RoundedVignetteDrawable : global::Com.Nostra13.Universalimageloader.Core.Display.RoundedBitmapDisplayer.RoundedDrawable {

			protected RoundedVignetteDrawable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nostra13/universalimageloader/core/display/RoundedVignetteBitmapDisplayer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RoundedVignetteBitmapDisplayer); }
		}

		protected RoundedVignetteBitmapDisplayer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nostra13.universalimageloader.core.display']/class[@name='RoundedVignetteBitmapDisplayer']/constructor[@name='RoundedVignetteBitmapDisplayer' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register (".ctor", "(II)V", "")]
		public unsafe RoundedVignetteBitmapDisplayer (int p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (RoundedVignetteBitmapDisplayer)) {
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

	}
}
