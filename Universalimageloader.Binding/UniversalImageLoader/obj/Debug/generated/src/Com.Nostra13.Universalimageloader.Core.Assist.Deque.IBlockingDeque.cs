using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nostra13.Universalimageloader.Core.Assist.Deque {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/interface[@name='BlockingDeque']"
	[Register ("com/nostra13/universalimageloader/core/assist/deque/BlockingDeque", "", "Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDequeInvoker")]
	public partial interface IBlockingDeque : global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IDeque, global::Java.Util.Concurrent.IBlockingQueue {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/interface[@name='BlockingDeque']/method[@name='add' and count(parameter)=1 and parameter[1][@type='E']]"
		[Register ("add", "(Ljava/lang/Object;)Z", "GetAdd_Ljava_lang_Object_Handler:Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDequeInvoker, UniversalImageLoader")]
		bool Add (global::Java.Lang.Object p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/interface[@name='BlockingDeque']/method[@name='addFirst' and count(parameter)=1 and parameter[1][@type='E']]"
		[Register ("addFirst", "(Ljava/lang/Object;)V", "GetAddFirst_Ljava_lang_Object_Handler:Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDequeInvoker, UniversalImageLoader")]
		void AddFirst (global::Java.Lang.Object p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/interface[@name='BlockingDeque']/method[@name='addLast' and count(parameter)=1 and parameter[1][@type='E']]"
		[Register ("addLast", "(Ljava/lang/Object;)V", "GetAddLast_Ljava_lang_Object_Handler:Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDequeInvoker, UniversalImageLoader")]
		void AddLast (global::Java.Lang.Object p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/interface[@name='BlockingDeque']/method[@name='contains' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("contains", "(Ljava/lang/Object;)Z", "GetContains_Ljava_lang_Object_Handler:Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDequeInvoker, UniversalImageLoader")]
		bool Contains (global::Java.Lang.Object p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/interface[@name='BlockingDeque']/method[@name='element' and count(parameter)=0]"
		[Register ("element", "()Ljava/lang/Object;", "GetElementHandler:Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDequeInvoker, UniversalImageLoader")]
		global::Java.Lang.Object Element ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/interface[@name='BlockingDeque']/method[@name='iterator' and count(parameter)=0]"
		[Register ("iterator", "()Ljava/util/Iterator;", "GetIteratorHandler:Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDequeInvoker, UniversalImageLoader")]
		global::Java.Util.IIterator Iterator ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/interface[@name='BlockingDeque']/method[@name='offer' and count(parameter)=1 and parameter[1][@type='E']]"
		[Register ("offer", "(Ljava/lang/Object;)Z", "GetOffer_Ljava_lang_Object_Handler:Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDequeInvoker, UniversalImageLoader")]
		bool Offer (global::Java.Lang.Object p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/interface[@name='BlockingDeque']/method[@name='offer' and count(parameter)=3 and parameter[1][@type='E'] and parameter[2][@type='long'] and parameter[3][@type='java.util.concurrent.TimeUnit']]"
		[Register ("offer", "(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Z", "GetOffer_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_Handler:Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDequeInvoker, UniversalImageLoader")]
		bool Offer (global::Java.Lang.Object p0, long p1, global::Java.Util.Concurrent.TimeUnit p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/interface[@name='BlockingDeque']/method[@name='offerFirst' and count(parameter)=1 and parameter[1][@type='E']]"
		[Register ("offerFirst", "(Ljava/lang/Object;)Z", "GetOfferFirst_Ljava_lang_Object_Handler:Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDequeInvoker, UniversalImageLoader")]
		bool OfferFirst (global::Java.Lang.Object p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/interface[@name='BlockingDeque']/method[@name='offerFirst' and count(parameter)=3 and parameter[1][@type='E'] and parameter[2][@type='long'] and parameter[3][@type='java.util.concurrent.TimeUnit']]"
		[Register ("offerFirst", "(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Z", "GetOfferFirst_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_Handler:Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDequeInvoker, UniversalImageLoader")]
		bool OfferFirst (global::Java.Lang.Object p0, long p1, global::Java.Util.Concurrent.TimeUnit p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/interface[@name='BlockingDeque']/method[@name='offerLast' and count(parameter)=1 and parameter[1][@type='E']]"
		[Register ("offerLast", "(Ljava/lang/Object;)Z", "GetOfferLast_Ljava_lang_Object_Handler:Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDequeInvoker, UniversalImageLoader")]
		bool OfferLast (global::Java.Lang.Object p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/interface[@name='BlockingDeque']/method[@name='offerLast' and count(parameter)=3 and parameter[1][@type='E'] and parameter[2][@type='long'] and parameter[3][@type='java.util.concurrent.TimeUnit']]"
		[Register ("offerLast", "(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Z", "GetOfferLast_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_Handler:Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDequeInvoker, UniversalImageLoader")]
		bool OfferLast (global::Java.Lang.Object p0, long p1, global::Java.Util.Concurrent.TimeUnit p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/interface[@name='BlockingDeque']/method[@name='peek' and count(parameter)=0]"
		[Register ("peek", "()Ljava/lang/Object;", "GetPeekHandler:Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDequeInvoker, UniversalImageLoader")]
		global::Java.Lang.Object Peek ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/interface[@name='BlockingDeque']/method[@name='poll' and count(parameter)=0]"
		[Register ("poll", "()Ljava/lang/Object;", "GetPollHandler:Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDequeInvoker, UniversalImageLoader")]
		global::Java.Lang.Object Poll ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/interface[@name='BlockingDeque']/method[@name='poll' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("poll", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", "GetPoll_JLjava_util_concurrent_TimeUnit_Handler:Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDequeInvoker, UniversalImageLoader")]
		global::Java.Lang.Object Poll (long p0, global::Java.Util.Concurrent.TimeUnit p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/interface[@name='BlockingDeque']/method[@name='pollFirst' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("pollFirst", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", "GetPollFirst_JLjava_util_concurrent_TimeUnit_Handler:Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDequeInvoker, UniversalImageLoader")]
		global::Java.Lang.Object PollFirst (long p0, global::Java.Util.Concurrent.TimeUnit p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/interface[@name='BlockingDeque']/method[@name='pollLast' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("pollLast", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", "GetPollLast_JLjava_util_concurrent_TimeUnit_Handler:Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDequeInvoker, UniversalImageLoader")]
		global::Java.Lang.Object PollLast (long p0, global::Java.Util.Concurrent.TimeUnit p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/interface[@name='BlockingDeque']/method[@name='push' and count(parameter)=1 and parameter[1][@type='E']]"
		[Register ("push", "(Ljava/lang/Object;)V", "GetPush_Ljava_lang_Object_Handler:Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDequeInvoker, UniversalImageLoader")]
		void Push (global::Java.Lang.Object p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/interface[@name='BlockingDeque']/method[@name='put' and count(parameter)=1 and parameter[1][@type='E']]"
		[Register ("put", "(Ljava/lang/Object;)V", "GetPut_Ljava_lang_Object_Handler:Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDequeInvoker, UniversalImageLoader")]
		void Put (global::Java.Lang.Object p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/interface[@name='BlockingDeque']/method[@name='putFirst' and count(parameter)=1 and parameter[1][@type='E']]"
		[Register ("putFirst", "(Ljava/lang/Object;)V", "GetPutFirst_Ljava_lang_Object_Handler:Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDequeInvoker, UniversalImageLoader")]
		void PutFirst (global::Java.Lang.Object p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/interface[@name='BlockingDeque']/method[@name='putLast' and count(parameter)=1 and parameter[1][@type='E']]"
		[Register ("putLast", "(Ljava/lang/Object;)V", "GetPutLast_Ljava_lang_Object_Handler:Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDequeInvoker, UniversalImageLoader")]
		void PutLast (global::Java.Lang.Object p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/interface[@name='BlockingDeque']/method[@name='remove' and count(parameter)=0]"
		[Register ("remove", "()Ljava/lang/Object;", "GetRemoveHandler:Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDequeInvoker, UniversalImageLoader")]
		global::Java.Lang.Object Remove ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/interface[@name='BlockingDeque']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("remove", "(Ljava/lang/Object;)Z", "GetRemove_Ljava_lang_Object_Handler:Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDequeInvoker, UniversalImageLoader")]
		bool Remove (global::Java.Lang.Object p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/interface[@name='BlockingDeque']/method[@name='removeFirstOccurrence' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("removeFirstOccurrence", "(Ljava/lang/Object;)Z", "GetRemoveFirstOccurrence_Ljava_lang_Object_Handler:Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDequeInvoker, UniversalImageLoader")]
		bool RemoveFirstOccurrence (global::Java.Lang.Object p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/interface[@name='BlockingDeque']/method[@name='removeLastOccurrence' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("removeLastOccurrence", "(Ljava/lang/Object;)Z", "GetRemoveLastOccurrence_Ljava_lang_Object_Handler:Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDequeInvoker, UniversalImageLoader")]
		bool RemoveLastOccurrence (global::Java.Lang.Object p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/interface[@name='BlockingDeque']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()I", "GetSizeHandler:Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDequeInvoker, UniversalImageLoader")]
		int Size ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/interface[@name='BlockingDeque']/method[@name='take' and count(parameter)=0]"
		[Register ("take", "()Ljava/lang/Object;", "GetTakeHandler:Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDequeInvoker, UniversalImageLoader")]
		global::Java.Lang.Object Take ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/interface[@name='BlockingDeque']/method[@name='takeFirst' and count(parameter)=0]"
		[Register ("takeFirst", "()Ljava/lang/Object;", "GetTakeFirstHandler:Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDequeInvoker, UniversalImageLoader")]
		global::Java.Lang.Object TakeFirst ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nostra13.universalimageloader.core.assist.deque']/interface[@name='BlockingDeque']/method[@name='takeLast' and count(parameter)=0]"
		[Register ("takeLast", "()Ljava/lang/Object;", "GetTakeLastHandler:Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDequeInvoker, UniversalImageLoader")]
		global::Java.Lang.Object TakeLast ();

	}

	[global::Android.Runtime.Register ("com/nostra13/universalimageloader/core/assist/deque/BlockingDeque", DoNotGenerateAcw=true)]
	internal class IBlockingDequeInvoker : global::Java.Lang.Object, IBlockingDeque {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/nostra13/universalimageloader/core/assist/deque/BlockingDeque");
		IntPtr class_ref;

		public static IBlockingDeque GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBlockingDeque> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.nostra13.universalimageloader.core.assist.deque.BlockingDeque"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBlockingDequeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBlockingDequeInvoker); }
		}

		static Delegate cb_add_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetAdd_Ljava_lang_Object_Handler ()
		{
			if (cb_add_Ljava_lang_Object_ == null)
				cb_add_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Add_Ljava_lang_Object_);
			return cb_add_Ljava_lang_Object_;
		}

		static bool n_Add_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Add (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_add_Ljava_lang_Object_;
		public unsafe bool Add (global::Java.Lang.Object p0)
		{
			if (id_add_Ljava_lang_Object_ == IntPtr.Zero)
				id_add_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "add", "(Ljava/lang/Object;)Z");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_add_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_addFirst_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetAddFirst_Ljava_lang_Object_Handler ()
		{
			if (cb_addFirst_Ljava_lang_Object_ == null)
				cb_addFirst_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddFirst_Ljava_lang_Object_);
			return cb_addFirst_Ljava_lang_Object_;
		}

		static void n_AddFirst_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddFirst (p0);
		}
#pragma warning restore 0169

		IntPtr id_addFirst_Ljava_lang_Object_;
		public unsafe void AddFirst (global::Java.Lang.Object p0)
		{
			if (id_addFirst_Ljava_lang_Object_ == IntPtr.Zero)
				id_addFirst_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "addFirst", "(Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (Handle, id_addFirst_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_addLast_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetAddLast_Ljava_lang_Object_Handler ()
		{
			if (cb_addLast_Ljava_lang_Object_ == null)
				cb_addLast_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddLast_Ljava_lang_Object_);
			return cb_addLast_Ljava_lang_Object_;
		}

		static void n_AddLast_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddLast (p0);
		}
#pragma warning restore 0169

		IntPtr id_addLast_Ljava_lang_Object_;
		public unsafe void AddLast (global::Java.Lang.Object p0)
		{
			if (id_addLast_Ljava_lang_Object_ == IntPtr.Zero)
				id_addLast_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "addLast", "(Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (Handle, id_addLast_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_contains_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetContains_Ljava_lang_Object_Handler ()
		{
			if (cb_contains_Ljava_lang_Object_ == null)
				cb_contains_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Contains_Ljava_lang_Object_);
			return cb_contains_Ljava_lang_Object_;
		}

		static bool n_Contains_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Contains (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_contains_Ljava_lang_Object_;
		public unsafe bool Contains (global::Java.Lang.Object p0)
		{
			if (id_contains_Ljava_lang_Object_ == IntPtr.Zero)
				id_contains_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "contains", "(Ljava/lang/Object;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_contains_Ljava_lang_Object_, __args);
			return __ret;
		}

		static Delegate cb_element;
#pragma warning disable 0169
		static Delegate GetElementHandler ()
		{
			if (cb_element == null)
				cb_element = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Element);
			return cb_element;
		}

		static IntPtr n_Element (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Element ());
		}
#pragma warning restore 0169

		IntPtr id_element;
		public unsafe global::Java.Lang.Object Element ()
		{
			if (id_element == IntPtr.Zero)
				id_element = JNIEnv.GetMethodID (class_ref, "element", "()Ljava/lang/Object;");
			return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (Handle, id_element), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_iterator;
#pragma warning disable 0169
		static Delegate GetIteratorHandler ()
		{
			if (cb_iterator == null)
				cb_iterator = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Iterator);
			return cb_iterator;
		}

		static IntPtr n_Iterator (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Iterator ());
		}
#pragma warning restore 0169

		IntPtr id_iterator;
		public unsafe global::Java.Util.IIterator Iterator ()
		{
			if (id_iterator == IntPtr.Zero)
				id_iterator = JNIEnv.GetMethodID (class_ref, "iterator", "()Ljava/util/Iterator;");
			return global::Java.Lang.Object.GetObject<global::Java.Util.IIterator> (JNIEnv.CallObjectMethod (Handle, id_iterator), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_offer_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOffer_Ljava_lang_Object_Handler ()
		{
			if (cb_offer_Ljava_lang_Object_ == null)
				cb_offer_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Offer_Ljava_lang_Object_);
			return cb_offer_Ljava_lang_Object_;
		}

		static bool n_Offer_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Offer (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_offer_Ljava_lang_Object_;
		public unsafe bool Offer (global::Java.Lang.Object p0)
		{
			if (id_offer_Ljava_lang_Object_ == IntPtr.Zero)
				id_offer_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "offer", "(Ljava/lang/Object;)Z");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_offer_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_offer_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_;
#pragma warning disable 0169
		static Delegate GetOffer_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_Handler ()
		{
			if (cb_offer_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_ == null)
				cb_offer_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long, IntPtr, bool>) n_Offer_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_);
			return cb_offer_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_;
		}

		static bool n_Offer_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, IntPtr native_p2)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Concurrent.TimeUnit p2 = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Offer (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_offer_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_;
		public unsafe bool Offer (global::Java.Lang.Object p0, long p1, global::Java.Util.Concurrent.TimeUnit p2)
		{
			if (id_offer_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_offer_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "offer", "(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Z");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_offer_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_offerFirst_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOfferFirst_Ljava_lang_Object_Handler ()
		{
			if (cb_offerFirst_Ljava_lang_Object_ == null)
				cb_offerFirst_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OfferFirst_Ljava_lang_Object_);
			return cb_offerFirst_Ljava_lang_Object_;
		}

		static bool n_OfferFirst_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OfferFirst (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_offerFirst_Ljava_lang_Object_;
		public unsafe bool OfferFirst (global::Java.Lang.Object p0)
		{
			if (id_offerFirst_Ljava_lang_Object_ == IntPtr.Zero)
				id_offerFirst_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "offerFirst", "(Ljava/lang/Object;)Z");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_offerFirst_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_offerFirst_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_;
#pragma warning disable 0169
		static Delegate GetOfferFirst_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_Handler ()
		{
			if (cb_offerFirst_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_ == null)
				cb_offerFirst_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long, IntPtr, bool>) n_OfferFirst_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_);
			return cb_offerFirst_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_;
		}

		static bool n_OfferFirst_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, IntPtr native_p2)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Concurrent.TimeUnit p2 = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OfferFirst (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_offerFirst_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_;
		public unsafe bool OfferFirst (global::Java.Lang.Object p0, long p1, global::Java.Util.Concurrent.TimeUnit p2)
		{
			if (id_offerFirst_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_offerFirst_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "offerFirst", "(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Z");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_offerFirst_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_offerLast_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOfferLast_Ljava_lang_Object_Handler ()
		{
			if (cb_offerLast_Ljava_lang_Object_ == null)
				cb_offerLast_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OfferLast_Ljava_lang_Object_);
			return cb_offerLast_Ljava_lang_Object_;
		}

		static bool n_OfferLast_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OfferLast (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_offerLast_Ljava_lang_Object_;
		public unsafe bool OfferLast (global::Java.Lang.Object p0)
		{
			if (id_offerLast_Ljava_lang_Object_ == IntPtr.Zero)
				id_offerLast_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "offerLast", "(Ljava/lang/Object;)Z");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_offerLast_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_offerLast_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_;
#pragma warning disable 0169
		static Delegate GetOfferLast_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_Handler ()
		{
			if (cb_offerLast_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_ == null)
				cb_offerLast_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long, IntPtr, bool>) n_OfferLast_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_);
			return cb_offerLast_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_;
		}

		static bool n_OfferLast_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, IntPtr native_p2)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Concurrent.TimeUnit p2 = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OfferLast (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_offerLast_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_;
		public unsafe bool OfferLast (global::Java.Lang.Object p0, long p1, global::Java.Util.Concurrent.TimeUnit p2)
		{
			if (id_offerLast_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_offerLast_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "offerLast", "(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Z");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_offerLast_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_peek;
#pragma warning disable 0169
		static Delegate GetPeekHandler ()
		{
			if (cb_peek == null)
				cb_peek = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Peek);
			return cb_peek;
		}

		static IntPtr n_Peek (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Peek ());
		}
#pragma warning restore 0169

		IntPtr id_peek;
		public unsafe global::Java.Lang.Object Peek ()
		{
			if (id_peek == IntPtr.Zero)
				id_peek = JNIEnv.GetMethodID (class_ref, "peek", "()Ljava/lang/Object;");
			return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (Handle, id_peek), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_poll;
#pragma warning disable 0169
		static Delegate GetPollHandler ()
		{
			if (cb_poll == null)
				cb_poll = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Poll);
			return cb_poll;
		}

		static IntPtr n_Poll (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Poll ());
		}
#pragma warning restore 0169

		IntPtr id_poll;
		public unsafe global::Java.Lang.Object Poll ()
		{
			if (id_poll == IntPtr.Zero)
				id_poll = JNIEnv.GetMethodID (class_ref, "poll", "()Ljava/lang/Object;");
			return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (Handle, id_poll), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_poll_JLjava_util_concurrent_TimeUnit_;
#pragma warning disable 0169
		static Delegate GetPoll_JLjava_util_concurrent_TimeUnit_Handler ()
		{
			if (cb_poll_JLjava_util_concurrent_TimeUnit_ == null)
				cb_poll_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, IntPtr>) n_Poll_JLjava_util_concurrent_TimeUnit_);
			return cb_poll_JLjava_util_concurrent_TimeUnit_;
		}

		static IntPtr n_Poll_JLjava_util_concurrent_TimeUnit_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Concurrent.TimeUnit p1 = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Poll (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_poll_JLjava_util_concurrent_TimeUnit_;
		public unsafe global::Java.Lang.Object Poll (long p0, global::Java.Util.Concurrent.TimeUnit p1)
		{
			if (id_poll_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_poll_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "poll", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (Handle, id_poll_JLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_pollFirst_JLjava_util_concurrent_TimeUnit_;
#pragma warning disable 0169
		static Delegate GetPollFirst_JLjava_util_concurrent_TimeUnit_Handler ()
		{
			if (cb_pollFirst_JLjava_util_concurrent_TimeUnit_ == null)
				cb_pollFirst_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, IntPtr>) n_PollFirst_JLjava_util_concurrent_TimeUnit_);
			return cb_pollFirst_JLjava_util_concurrent_TimeUnit_;
		}

		static IntPtr n_PollFirst_JLjava_util_concurrent_TimeUnit_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Concurrent.TimeUnit p1 = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PollFirst (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_pollFirst_JLjava_util_concurrent_TimeUnit_;
		public unsafe global::Java.Lang.Object PollFirst (long p0, global::Java.Util.Concurrent.TimeUnit p1)
		{
			if (id_pollFirst_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_pollFirst_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "pollFirst", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (Handle, id_pollFirst_JLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_pollLast_JLjava_util_concurrent_TimeUnit_;
#pragma warning disable 0169
		static Delegate GetPollLast_JLjava_util_concurrent_TimeUnit_Handler ()
		{
			if (cb_pollLast_JLjava_util_concurrent_TimeUnit_ == null)
				cb_pollLast_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, IntPtr>) n_PollLast_JLjava_util_concurrent_TimeUnit_);
			return cb_pollLast_JLjava_util_concurrent_TimeUnit_;
		}

		static IntPtr n_PollLast_JLjava_util_concurrent_TimeUnit_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Concurrent.TimeUnit p1 = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PollLast (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_pollLast_JLjava_util_concurrent_TimeUnit_;
		public unsafe global::Java.Lang.Object PollLast (long p0, global::Java.Util.Concurrent.TimeUnit p1)
		{
			if (id_pollLast_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_pollLast_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "pollLast", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (Handle, id_pollLast_JLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_push_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetPush_Ljava_lang_Object_Handler ()
		{
			if (cb_push_Ljava_lang_Object_ == null)
				cb_push_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Push_Ljava_lang_Object_);
			return cb_push_Ljava_lang_Object_;
		}

		static void n_Push_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Push (p0);
		}
#pragma warning restore 0169

		IntPtr id_push_Ljava_lang_Object_;
		public unsafe void Push (global::Java.Lang.Object p0)
		{
			if (id_push_Ljava_lang_Object_ == IntPtr.Zero)
				id_push_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "push", "(Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (Handle, id_push_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_put_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_Object_Handler ()
		{
			if (cb_put_Ljava_lang_Object_ == null)
				cb_put_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Put_Ljava_lang_Object_);
			return cb_put_Ljava_lang_Object_;
		}

		static void n_Put_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Put (p0);
		}
#pragma warning restore 0169

		IntPtr id_put_Ljava_lang_Object_;
		public unsafe void Put (global::Java.Lang.Object p0)
		{
			if (id_put_Ljava_lang_Object_ == IntPtr.Zero)
				id_put_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "put", "(Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (Handle, id_put_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_putFirst_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetPutFirst_Ljava_lang_Object_Handler ()
		{
			if (cb_putFirst_Ljava_lang_Object_ == null)
				cb_putFirst_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PutFirst_Ljava_lang_Object_);
			return cb_putFirst_Ljava_lang_Object_;
		}

		static void n_PutFirst_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PutFirst (p0);
		}
#pragma warning restore 0169

		IntPtr id_putFirst_Ljava_lang_Object_;
		public unsafe void PutFirst (global::Java.Lang.Object p0)
		{
			if (id_putFirst_Ljava_lang_Object_ == IntPtr.Zero)
				id_putFirst_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "putFirst", "(Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (Handle, id_putFirst_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_putLast_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetPutLast_Ljava_lang_Object_Handler ()
		{
			if (cb_putLast_Ljava_lang_Object_ == null)
				cb_putLast_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PutLast_Ljava_lang_Object_);
			return cb_putLast_Ljava_lang_Object_;
		}

		static void n_PutLast_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PutLast (p0);
		}
#pragma warning restore 0169

		IntPtr id_putLast_Ljava_lang_Object_;
		public unsafe void PutLast (global::Java.Lang.Object p0)
		{
			if (id_putLast_Ljava_lang_Object_ == IntPtr.Zero)
				id_putLast_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "putLast", "(Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (Handle, id_putLast_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_remove;
#pragma warning disable 0169
		static Delegate GetRemoveHandler ()
		{
			if (cb_remove == null)
				cb_remove = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Remove);
			return cb_remove;
		}

		static IntPtr n_Remove (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Remove ());
		}
#pragma warning restore 0169

		IntPtr id_remove;
		public unsafe global::Java.Lang.Object Remove ()
		{
			if (id_remove == IntPtr.Zero)
				id_remove = JNIEnv.GetMethodID (class_ref, "remove", "()Ljava/lang/Object;");
			return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (Handle, id_remove), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_remove_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetRemove_Ljava_lang_Object_Handler ()
		{
			if (cb_remove_Ljava_lang_Object_ == null)
				cb_remove_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Remove_Ljava_lang_Object_);
			return cb_remove_Ljava_lang_Object_;
		}

		static bool n_Remove_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Remove (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_remove_Ljava_lang_Object_;
		public unsafe bool Remove (global::Java.Lang.Object p0)
		{
			if (id_remove_Ljava_lang_Object_ == IntPtr.Zero)
				id_remove_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "remove", "(Ljava/lang/Object;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_remove_Ljava_lang_Object_, __args);
			return __ret;
		}

		static Delegate cb_removeFirstOccurrence_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetRemoveFirstOccurrence_Ljava_lang_Object_Handler ()
		{
			if (cb_removeFirstOccurrence_Ljava_lang_Object_ == null)
				cb_removeFirstOccurrence_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RemoveFirstOccurrence_Ljava_lang_Object_);
			return cb_removeFirstOccurrence_Ljava_lang_Object_;
		}

		static bool n_RemoveFirstOccurrence_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveFirstOccurrence (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_removeFirstOccurrence_Ljava_lang_Object_;
		public unsafe bool RemoveFirstOccurrence (global::Java.Lang.Object p0)
		{
			if (id_removeFirstOccurrence_Ljava_lang_Object_ == IntPtr.Zero)
				id_removeFirstOccurrence_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "removeFirstOccurrence", "(Ljava/lang/Object;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_removeFirstOccurrence_Ljava_lang_Object_, __args);
			return __ret;
		}

		static Delegate cb_removeLastOccurrence_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetRemoveLastOccurrence_Ljava_lang_Object_Handler ()
		{
			if (cb_removeLastOccurrence_Ljava_lang_Object_ == null)
				cb_removeLastOccurrence_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RemoveLastOccurrence_Ljava_lang_Object_);
			return cb_removeLastOccurrence_Ljava_lang_Object_;
		}

		static bool n_RemoveLastOccurrence_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveLastOccurrence (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_removeLastOccurrence_Ljava_lang_Object_;
		public unsafe bool RemoveLastOccurrence (global::Java.Lang.Object p0)
		{
			if (id_removeLastOccurrence_Ljava_lang_Object_ == IntPtr.Zero)
				id_removeLastOccurrence_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "removeLastOccurrence", "(Ljava/lang/Object;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_removeLastOccurrence_Ljava_lang_Object_, __args);
			return __ret;
		}

		static Delegate cb_size;
#pragma warning disable 0169
		static Delegate GetSizeHandler ()
		{
			if (cb_size == null)
				cb_size = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Size);
			return cb_size;
		}

		static int n_Size (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size ();
		}
#pragma warning restore 0169

		IntPtr id_size;
		public unsafe int Size ()
		{
			if (id_size == IntPtr.Zero)
				id_size = JNIEnv.GetMethodID (class_ref, "size", "()I");
			return JNIEnv.CallIntMethod (Handle, id_size);
		}

		static Delegate cb_take;
#pragma warning disable 0169
		static Delegate GetTakeHandler ()
		{
			if (cb_take == null)
				cb_take = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Take);
			return cb_take;
		}

		static IntPtr n_Take (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Take ());
		}
#pragma warning restore 0169

		IntPtr id_take;
		public unsafe global::Java.Lang.Object Take ()
		{
			if (id_take == IntPtr.Zero)
				id_take = JNIEnv.GetMethodID (class_ref, "take", "()Ljava/lang/Object;");
			return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (Handle, id_take), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_takeFirst;
#pragma warning disable 0169
		static Delegate GetTakeFirstHandler ()
		{
			if (cb_takeFirst == null)
				cb_takeFirst = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_TakeFirst);
			return cb_takeFirst;
		}

		static IntPtr n_TakeFirst (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TakeFirst ());
		}
#pragma warning restore 0169

		IntPtr id_takeFirst;
		public unsafe global::Java.Lang.Object TakeFirst ()
		{
			if (id_takeFirst == IntPtr.Zero)
				id_takeFirst = JNIEnv.GetMethodID (class_ref, "takeFirst", "()Ljava/lang/Object;");
			return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (Handle, id_takeFirst), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_takeLast;
#pragma warning disable 0169
		static Delegate GetTakeLastHandler ()
		{
			if (cb_takeLast == null)
				cb_takeLast = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_TakeLast);
			return cb_takeLast;
		}

		static IntPtr n_TakeLast (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TakeLast ());
		}
#pragma warning restore 0169

		IntPtr id_takeLast;
		public unsafe global::Java.Lang.Object TakeLast ()
		{
			if (id_takeLast == IntPtr.Zero)
				id_takeLast = JNIEnv.GetMethodID (class_ref, "takeLast", "()Ljava/lang/Object;");
			return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (Handle, id_takeLast), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getFirst;
#pragma warning disable 0169
		static Delegate GetGetFirstHandler ()
		{
			if (cb_getFirst == null)
				cb_getFirst = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFirst);
			return cb_getFirst;
		}

		static IntPtr n_GetFirst (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.First);
		}
#pragma warning restore 0169

		IntPtr id_getFirst;
		public unsafe global::Java.Lang.Object First {
			get {
				if (id_getFirst == IntPtr.Zero)
					id_getFirst = JNIEnv.GetMethodID (class_ref, "getFirst", "()Ljava/lang/Object;");
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (Handle, id_getFirst), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getLast;
#pragma warning disable 0169
		static Delegate GetGetLastHandler ()
		{
			if (cb_getLast == null)
				cb_getLast = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLast);
			return cb_getLast;
		}

		static IntPtr n_GetLast (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Last);
		}
#pragma warning restore 0169

		IntPtr id_getLast;
		public unsafe global::Java.Lang.Object Last {
			get {
				if (id_getLast == IntPtr.Zero)
					id_getLast = JNIEnv.GetMethodID (class_ref, "getLast", "()Ljava/lang/Object;");
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (Handle, id_getLast), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_descendingIterator;
#pragma warning disable 0169
		static Delegate GetDescendingIteratorHandler ()
		{
			if (cb_descendingIterator == null)
				cb_descendingIterator = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_DescendingIterator);
			return cb_descendingIterator;
		}

		static IntPtr n_DescendingIterator (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DescendingIterator ());
		}
#pragma warning restore 0169

		IntPtr id_descendingIterator;
		public unsafe global::Java.Util.IIterator DescendingIterator ()
		{
			if (id_descendingIterator == IntPtr.Zero)
				id_descendingIterator = JNIEnv.GetMethodID (class_ref, "descendingIterator", "()Ljava/util/Iterator;");
			return global::Java.Lang.Object.GetObject<global::Java.Util.IIterator> (JNIEnv.CallObjectMethod (Handle, id_descendingIterator), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_peekFirst;
#pragma warning disable 0169
		static Delegate GetPeekFirstHandler ()
		{
			if (cb_peekFirst == null)
				cb_peekFirst = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_PeekFirst);
			return cb_peekFirst;
		}

		static IntPtr n_PeekFirst (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PeekFirst ());
		}
#pragma warning restore 0169

		IntPtr id_peekFirst;
		public unsafe global::Java.Lang.Object PeekFirst ()
		{
			if (id_peekFirst == IntPtr.Zero)
				id_peekFirst = JNIEnv.GetMethodID (class_ref, "peekFirst", "()Ljava/lang/Object;");
			return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (Handle, id_peekFirst), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_peekLast;
#pragma warning disable 0169
		static Delegate GetPeekLastHandler ()
		{
			if (cb_peekLast == null)
				cb_peekLast = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_PeekLast);
			return cb_peekLast;
		}

		static IntPtr n_PeekLast (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PeekLast ());
		}
#pragma warning restore 0169

		IntPtr id_peekLast;
		public unsafe global::Java.Lang.Object PeekLast ()
		{
			if (id_peekLast == IntPtr.Zero)
				id_peekLast = JNIEnv.GetMethodID (class_ref, "peekLast", "()Ljava/lang/Object;");
			return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (Handle, id_peekLast), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_pollFirst;
#pragma warning disable 0169
		static Delegate GetPollFirstHandler ()
		{
			if (cb_pollFirst == null)
				cb_pollFirst = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_PollFirst);
			return cb_pollFirst;
		}

		static IntPtr n_PollFirst (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PollFirst ());
		}
#pragma warning restore 0169

		IntPtr id_pollFirst;
		public unsafe global::Java.Lang.Object PollFirst ()
		{
			if (id_pollFirst == IntPtr.Zero)
				id_pollFirst = JNIEnv.GetMethodID (class_ref, "pollFirst", "()Ljava/lang/Object;");
			return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (Handle, id_pollFirst), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_pollLast;
#pragma warning disable 0169
		static Delegate GetPollLastHandler ()
		{
			if (cb_pollLast == null)
				cb_pollLast = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_PollLast);
			return cb_pollLast;
		}

		static IntPtr n_PollLast (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PollLast ());
		}
#pragma warning restore 0169

		IntPtr id_pollLast;
		public unsafe global::Java.Lang.Object PollLast ()
		{
			if (id_pollLast == IntPtr.Zero)
				id_pollLast = JNIEnv.GetMethodID (class_ref, "pollLast", "()Ljava/lang/Object;");
			return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (Handle, id_pollLast), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_pop;
#pragma warning disable 0169
		static Delegate GetPopHandler ()
		{
			if (cb_pop == null)
				cb_pop = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Pop);
			return cb_pop;
		}

		static IntPtr n_Pop (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Pop ());
		}
#pragma warning restore 0169

		IntPtr id_pop;
		public unsafe global::Java.Lang.Object Pop ()
		{
			if (id_pop == IntPtr.Zero)
				id_pop = JNIEnv.GetMethodID (class_ref, "pop", "()Ljava/lang/Object;");
			return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (Handle, id_pop), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_removeFirst;
#pragma warning disable 0169
		static Delegate GetRemoveFirstHandler ()
		{
			if (cb_removeFirst == null)
				cb_removeFirst = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_RemoveFirst);
			return cb_removeFirst;
		}

		static IntPtr n_RemoveFirst (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RemoveFirst ());
		}
#pragma warning restore 0169

		IntPtr id_removeFirst;
		public unsafe global::Java.Lang.Object RemoveFirst ()
		{
			if (id_removeFirst == IntPtr.Zero)
				id_removeFirst = JNIEnv.GetMethodID (class_ref, "removeFirst", "()Ljava/lang/Object;");
			return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (Handle, id_removeFirst), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_removeLast;
#pragma warning disable 0169
		static Delegate GetRemoveLastHandler ()
		{
			if (cb_removeLast == null)
				cb_removeLast = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_RemoveLast);
			return cb_removeLast;
		}

		static IntPtr n_RemoveLast (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RemoveLast ());
		}
#pragma warning restore 0169

		IntPtr id_removeLast;
		public unsafe global::Java.Lang.Object RemoveLast ()
		{
			if (id_removeLast == IntPtr.Zero)
				id_removeLast = JNIEnv.GetMethodID (class_ref, "removeLast", "()Ljava/lang/Object;");
			return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (Handle, id_removeLast), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_isEmpty;
#pragma warning disable 0169
		static Delegate GetIsEmptyHandler ()
		{
			if (cb_isEmpty == null)
				cb_isEmpty = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEmpty);
			return cb_isEmpty;
		}

		static bool n_IsEmpty (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEmpty;
		}
#pragma warning restore 0169

		IntPtr id_isEmpty;
		public unsafe global::System.Boolean IsEmpty {
			get {
				if (id_isEmpty == IntPtr.Zero)
					id_isEmpty = JNIEnv.GetMethodID (class_ref, "isEmpty", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isEmpty);
			}
		}

		static Delegate cb_addAll_LSystem_Collections_ICollection_;
#pragma warning disable 0169
		static Delegate GetAddAll_LSystem_Collections_ICollection_Handler ()
		{
			if (cb_addAll_LSystem_Collections_ICollection_ == null)
				cb_addAll_LSystem_Collections_ICollection_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_AddAll_LSystem_Collections_ICollection_);
			return cb_addAll_LSystem_Collections_ICollection_;
		}

		static bool n_AddAll_LSystem_Collections_ICollection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_collection)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var collection = global::Android.Runtime.JavaCollection.FromJniHandle (native_collection, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AddAll (collection);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_addAll_LSystem_Collections_ICollection_;
		public unsafe global::System.Boolean AddAll (global::System.Collections.ICollection collection)
		{
			if (id_addAll_LSystem_Collections_ICollection_ == IntPtr.Zero)
				id_addAll_LSystem_Collections_ICollection_ = JNIEnv.GetMethodID (class_ref, "addAll", "(LSystem/Collections/ICollection;)Z");
			IntPtr native_collection = global::Android.Runtime.JavaCollection.ToLocalJniHandle (collection);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_collection);
			global::System.Boolean __ret = JNIEnv.CallBooleanMethod (Handle, id_addAll_LSystem_Collections_ICollection_, __args);
			JNIEnv.DeleteLocalRef (native_collection);
			return __ret;
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		IntPtr id_clear;
		public unsafe void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			JNIEnv.CallVoidMethod (Handle, id_clear);
		}

		static Delegate cb_containsAll_LSystem_Collections_ICollection_;
#pragma warning disable 0169
		static Delegate GetContainsAll_LSystem_Collections_ICollection_Handler ()
		{
			if (cb_containsAll_LSystem_Collections_ICollection_ == null)
				cb_containsAll_LSystem_Collections_ICollection_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_ContainsAll_LSystem_Collections_ICollection_);
			return cb_containsAll_LSystem_Collections_ICollection_;
		}

		static bool n_ContainsAll_LSystem_Collections_ICollection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_collection)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var collection = global::Android.Runtime.JavaCollection.FromJniHandle (native_collection, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ContainsAll (collection);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_containsAll_LSystem_Collections_ICollection_;
		public unsafe global::System.Boolean ContainsAll (global::System.Collections.ICollection collection)
		{
			if (id_containsAll_LSystem_Collections_ICollection_ == IntPtr.Zero)
				id_containsAll_LSystem_Collections_ICollection_ = JNIEnv.GetMethodID (class_ref, "containsAll", "(LSystem/Collections/ICollection;)Z");
			IntPtr native_collection = global::Android.Runtime.JavaCollection.ToLocalJniHandle (collection);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_collection);
			global::System.Boolean __ret = JNIEnv.CallBooleanMethod (Handle, id_containsAll_LSystem_Collections_ICollection_, __args);
			JNIEnv.DeleteLocalRef (native_collection);
			return __ret;
		}

		static Delegate cb_equals_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetEquals_Ljava_lang_Object_Handler ()
		{
			if (cb_equals_Ljava_lang_Object_ == null)
				cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Equals_Ljava_lang_Object_);
			return cb_equals_Ljava_lang_Object_;
		}

		static bool n_Equals_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native__object)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object @object = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native__object, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Equals (@object);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_equals_Ljava_lang_Object_;
		public unsafe global::System.Boolean Equals (global::Java.Lang.Object @object)
		{
			if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
				id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (@object);
			global::System.Boolean __ret = JNIEnv.CallBooleanMethod (Handle, id_equals_Ljava_lang_Object_, __args);
			return __ret;
		}

		static Delegate cb_hashCode;
#pragma warning disable 0169
		static Delegate GetGetHashCodeHandler ()
		{
			if (cb_hashCode == null)
				cb_hashCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHashCode);
			return cb_hashCode;
		}

		static int n_GetHashCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetHashCode ();
		}
#pragma warning restore 0169

		IntPtr id_hashCode;
		public unsafe global::System.Int32 GetHashCode ()
		{
			if (id_hashCode == IntPtr.Zero)
				id_hashCode = JNIEnv.GetMethodID (class_ref, "hashCode", "()I");
			return JNIEnv.CallIntMethod (Handle, id_hashCode);
		}

		static Delegate cb_removeAll_LSystem_Collections_ICollection_;
#pragma warning disable 0169
		static Delegate GetRemoveAll_LSystem_Collections_ICollection_Handler ()
		{
			if (cb_removeAll_LSystem_Collections_ICollection_ == null)
				cb_removeAll_LSystem_Collections_ICollection_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RemoveAll_LSystem_Collections_ICollection_);
			return cb_removeAll_LSystem_Collections_ICollection_;
		}

		static bool n_RemoveAll_LSystem_Collections_ICollection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_collection)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var collection = global::Android.Runtime.JavaCollection.FromJniHandle (native_collection, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveAll (collection);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_removeAll_LSystem_Collections_ICollection_;
		public unsafe global::System.Boolean RemoveAll (global::System.Collections.ICollection collection)
		{
			if (id_removeAll_LSystem_Collections_ICollection_ == IntPtr.Zero)
				id_removeAll_LSystem_Collections_ICollection_ = JNIEnv.GetMethodID (class_ref, "removeAll", "(LSystem/Collections/ICollection;)Z");
			IntPtr native_collection = global::Android.Runtime.JavaCollection.ToLocalJniHandle (collection);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_collection);
			global::System.Boolean __ret = JNIEnv.CallBooleanMethod (Handle, id_removeAll_LSystem_Collections_ICollection_, __args);
			JNIEnv.DeleteLocalRef (native_collection);
			return __ret;
		}

		static Delegate cb_retainAll_LSystem_Collections_ICollection_;
#pragma warning disable 0169
		static Delegate GetRetainAll_LSystem_Collections_ICollection_Handler ()
		{
			if (cb_retainAll_LSystem_Collections_ICollection_ == null)
				cb_retainAll_LSystem_Collections_ICollection_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RetainAll_LSystem_Collections_ICollection_);
			return cb_retainAll_LSystem_Collections_ICollection_;
		}

		static bool n_RetainAll_LSystem_Collections_ICollection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_collection)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var collection = global::Android.Runtime.JavaCollection.FromJniHandle (native_collection, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RetainAll (collection);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_retainAll_LSystem_Collections_ICollection_;
		public unsafe global::System.Boolean RetainAll (global::System.Collections.ICollection collection)
		{
			if (id_retainAll_LSystem_Collections_ICollection_ == IntPtr.Zero)
				id_retainAll_LSystem_Collections_ICollection_ = JNIEnv.GetMethodID (class_ref, "retainAll", "(LSystem/Collections/ICollection;)Z");
			IntPtr native_collection = global::Android.Runtime.JavaCollection.ToLocalJniHandle (collection);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_collection);
			global::System.Boolean __ret = JNIEnv.CallBooleanMethod (Handle, id_retainAll_LSystem_Collections_ICollection_, __args);
			JNIEnv.DeleteLocalRef (native_collection);
			return __ret;
		}

		static Delegate cb_toArray;
#pragma warning disable 0169
		static Delegate GetToArrayHandler ()
		{
			if (cb_toArray == null)
				cb_toArray = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToArray);
			return cb_toArray;
		}

		static IntPtr n_ToArray (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.ToArray ());
		}
#pragma warning restore 0169

		IntPtr id_toArray;
		public unsafe global::Java.Lang.Object[] ToArray ()
		{
			if (id_toArray == IntPtr.Zero)
				id_toArray = JNIEnv.GetMethodID (class_ref, "toArray", "()[Ljava/lang/Object;");
			return (global::Java.Lang.Object[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (Handle, id_toArray), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
		}

		static Delegate cb_toArray_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetToArray_arrayLjava_lang_Object_Handler ()
		{
			if (cb_toArray_arrayLjava_lang_Object_ == null)
				cb_toArray_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ToArray_arrayLjava_lang_Object_);
			return cb_toArray_arrayLjava_lang_Object_;
		}

		static IntPtr n_ToArray_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_array)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] array = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_array, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.NewArray (__this.ToArray (array));
			if (array != null)
				JNIEnv.CopyArray (array, native_array);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_toArray_arrayLjava_lang_Object_;
		public unsafe global::Java.Lang.Object[] ToArray (global::Java.Lang.Object[] array)
		{
			if (id_toArray_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_toArray_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			IntPtr native_array = JNIEnv.NewArray (array);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_array);
			global::Java.Lang.Object[] __ret = (global::Java.Lang.Object[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (Handle, id_toArray_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
			if (array != null) {
				JNIEnv.CopyArray (native_array, array);
				JNIEnv.DeleteLocalRef (native_array);
			}
			return __ret;
		}

		static Delegate cb_drainTo_LSystem_Collections_ICollection_;
#pragma warning disable 0169
		static Delegate GetDrainTo_LSystem_Collections_ICollection_Handler ()
		{
			if (cb_drainTo_LSystem_Collections_ICollection_ == null)
				cb_drainTo_LSystem_Collections_ICollection_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_DrainTo_LSystem_Collections_ICollection_);
			return cb_drainTo_LSystem_Collections_ICollection_;
		}

		static int n_DrainTo_LSystem_Collections_ICollection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_c)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var c = global::Android.Runtime.JavaCollection.FromJniHandle (native_c, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.DrainTo (c);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_drainTo_LSystem_Collections_ICollection_;
		public unsafe global::System.Int32 DrainTo (global::System.Collections.ICollection c)
		{
			if (id_drainTo_LSystem_Collections_ICollection_ == IntPtr.Zero)
				id_drainTo_LSystem_Collections_ICollection_ = JNIEnv.GetMethodID (class_ref, "drainTo", "(LSystem/Collections/ICollection;)I");
			IntPtr native_c = global::Android.Runtime.JavaCollection.ToLocalJniHandle (c);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_c);
			global::System.Int32 __ret = JNIEnv.CallIntMethod (Handle, id_drainTo_LSystem_Collections_ICollection_, __args);
			JNIEnv.DeleteLocalRef (native_c);
			return __ret;
		}

		static Delegate cb_drainTo_LSystem_Collections_ICollection_I;
#pragma warning disable 0169
		static Delegate GetDrainTo_LSystem_Collections_ICollection_IHandler ()
		{
			if (cb_drainTo_LSystem_Collections_ICollection_I == null)
				cb_drainTo_LSystem_Collections_ICollection_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int>) n_DrainTo_LSystem_Collections_ICollection_I);
			return cb_drainTo_LSystem_Collections_ICollection_I;
		}

		static int n_DrainTo_LSystem_Collections_ICollection_I (IntPtr jnienv, IntPtr native__this, IntPtr native_c, int maxElements)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var c = global::Android.Runtime.JavaCollection.FromJniHandle (native_c, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.DrainTo (c, maxElements);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_drainTo_LSystem_Collections_ICollection_I;
		public unsafe global::System.Int32 DrainTo (global::System.Collections.ICollection c, int maxElements)
		{
			if (id_drainTo_LSystem_Collections_ICollection_I == IntPtr.Zero)
				id_drainTo_LSystem_Collections_ICollection_I = JNIEnv.GetMethodID (class_ref, "drainTo", "(LSystem/Collections/ICollection;I)I");
			IntPtr native_c = global::Android.Runtime.JavaCollection.ToLocalJniHandle (c);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_c);
			__args [1] = new JValue (maxElements);
			global::System.Int32 __ret = JNIEnv.CallIntMethod (Handle, id_drainTo_LSystem_Collections_ICollection_I, __args);
			JNIEnv.DeleteLocalRef (native_c);
			return __ret;
		}

		static Delegate cb_remainingCapacity;
#pragma warning disable 0169
		static Delegate GetRemainingCapacityHandler ()
		{
			if (cb_remainingCapacity == null)
				cb_remainingCapacity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_RemainingCapacity);
			return cb_remainingCapacity;
		}

		static int n_RemainingCapacity (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque __this = global::Java.Lang.Object.GetObject<global::Com.Nostra13.Universalimageloader.Core.Assist.Deque.IBlockingDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RemainingCapacity ();
		}
#pragma warning restore 0169

		IntPtr id_remainingCapacity;
		public unsafe global::System.Int32 RemainingCapacity ()
		{
			if (id_remainingCapacity == IntPtr.Zero)
				id_remainingCapacity = JNIEnv.GetMethodID (class_ref, "remainingCapacity", "()I");
			return JNIEnv.CallIntMethod (Handle, id_remainingCapacity);
		}

	}

}
