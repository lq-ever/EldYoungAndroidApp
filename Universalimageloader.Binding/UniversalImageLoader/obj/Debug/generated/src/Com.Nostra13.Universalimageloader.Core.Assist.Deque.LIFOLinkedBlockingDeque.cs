using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nostra13.Universalimageloader.Core.Assist.Deque {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/class[@name='LIFOLinkedBlockingDeque']"
	[global::Android.Runtime.Register ("com/nostra13/universalimageloader/core/assist/deque/LIFOLinkedBlockingDeque", DoNotGenerateAcw=true)]
	public partial class LIFOLinkedBlockingDeque : global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.LinkedBlockingDeque {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nostra13/universalimageloader/core/assist/deque/LIFOLinkedBlockingDeque", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LIFOLinkedBlockingDeque); }
		}

		protected LIFOLinkedBlockingDeque (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/class[@name='LIFOLinkedBlockingDeque']/constructor[@name='LIFOLinkedBlockingDeque' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LIFOLinkedBlockingDeque ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (LIFOLinkedBlockingDeque)) {
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

	}
}
