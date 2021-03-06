using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Overlayutil {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.overlayutil']/class[@name='TransitRouteOverlay']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/overlayutil/TransitRouteOverlay", DoNotGenerateAcw=true)]
	public partial class TransitRouteOverlay : global::Com.Baidu.Mapapi.Overlayutil.OverlayManager {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/overlayutil/TransitRouteOverlay", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TransitRouteOverlay); }
		}

		protected TransitRouteOverlay (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_baidu_mapapi_map_BaiduMap_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.overlayutil']/class[@name='TransitRouteOverlay']/constructor[@name='TransitRouteOverlay' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.BaiduMap']]"
		[Register (".ctor", "(Lcom/baidu/mapapi/map/BaiduMap;)V", "")]
		public unsafe TransitRouteOverlay (global::Com.Baidu.Mapapi.Map.BaiduMap p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (TransitRouteOverlay)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/baidu/mapapi/map/BaiduMap;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/baidu/mapapi/map/BaiduMap;)V", __args);
					return;
				}

				if (id_ctor_Lcom_baidu_mapapi_map_BaiduMap_ == IntPtr.Zero)
					id_ctor_Lcom_baidu_mapapi_map_BaiduMap_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/baidu/mapapi/map/BaiduMap;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_baidu_mapapi_map_BaiduMap_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_baidu_mapapi_map_BaiduMap_, __args);
			} finally {
			}
		}

		static Delegate cb_getLineColor;
#pragma warning disable 0169
		static Delegate GetGetLineColorHandler ()
		{
			if (cb_getLineColor == null)
				cb_getLineColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLineColor);
			return cb_getLineColor;
		}

		static int n_GetLineColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Overlayutil.TransitRouteOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Overlayutil.TransitRouteOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LineColor;
		}
#pragma warning restore 0169

		static IntPtr id_getLineColor;
		public virtual unsafe int LineColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.overlayutil']/class[@name='TransitRouteOverlay']/method[@name='getLineColor' and count(parameter)=0]"
			[Register ("getLineColor", "()I", "GetGetLineColorHandler")]
			get {
				if (id_getLineColor == IntPtr.Zero)
					id_getLineColor = JNIEnv.GetMethodID (class_ref, "getLineColor", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getLineColor);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLineColor", "()I"));
				} finally {
				}
			}
		}

		static IntPtr id_getOverlayOptions;
		public override unsafe global::System.Collections.Generic.IList<global::Com.Baidu.Mapapi.Map.OverlayOptions> OverlayOptions {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.overlayutil']/class[@name='TransitRouteOverlay']/method[@name='getOverlayOptions' and count(parameter)=0]"
			[Register ("getOverlayOptions", "()Ljava/util/List;", "GetGetOverlayOptionsHandler")]
			get {
				if (id_getOverlayOptions == IntPtr.Zero)
					id_getOverlayOptions = JNIEnv.GetMethodID (class_ref, "getOverlayOptions", "()Ljava/util/List;");
				try {
					return global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Map.OverlayOptions>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getOverlayOptions), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getStartMarker;
#pragma warning disable 0169
		static Delegate GetGetStartMarkerHandler ()
		{
			if (cb_getStartMarker == null)
				cb_getStartMarker = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStartMarker);
			return cb_getStartMarker;
		}

		static IntPtr n_GetStartMarker (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Overlayutil.TransitRouteOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Overlayutil.TransitRouteOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.StartMarker);
		}
#pragma warning restore 0169

		static IntPtr id_getStartMarker;
		public virtual unsafe global::Com.Baidu.Mapapi.Map.BitmapDescriptor StartMarker {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.overlayutil']/class[@name='TransitRouteOverlay']/method[@name='getStartMarker' and count(parameter)=0]"
			[Register ("getStartMarker", "()Lcom/baidu/mapapi/map/BitmapDescriptor;", "GetGetStartMarkerHandler")]
			get {
				if (id_getStartMarker == IntPtr.Zero)
					id_getStartMarker = JNIEnv.GetMethodID (class_ref, "getStartMarker", "()Lcom/baidu/mapapi/map/BitmapDescriptor;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BitmapDescriptor> (JNIEnv.CallObjectMethod  (Handle, id_getStartMarker), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BitmapDescriptor> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStartMarker", "()Lcom/baidu/mapapi/map/BitmapDescriptor;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTerminalMarker;
#pragma warning disable 0169
		static Delegate GetGetTerminalMarkerHandler ()
		{
			if (cb_getTerminalMarker == null)
				cb_getTerminalMarker = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTerminalMarker);
			return cb_getTerminalMarker;
		}

		static IntPtr n_GetTerminalMarker (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Overlayutil.TransitRouteOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Overlayutil.TransitRouteOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TerminalMarker);
		}
#pragma warning restore 0169

		static IntPtr id_getTerminalMarker;
		public virtual unsafe global::Com.Baidu.Mapapi.Map.BitmapDescriptor TerminalMarker {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.overlayutil']/class[@name='TransitRouteOverlay']/method[@name='getTerminalMarker' and count(parameter)=0]"
			[Register ("getTerminalMarker", "()Lcom/baidu/mapapi/map/BitmapDescriptor;", "GetGetTerminalMarkerHandler")]
			get {
				if (id_getTerminalMarker == IntPtr.Zero)
					id_getTerminalMarker = JNIEnv.GetMethodID (class_ref, "getTerminalMarker", "()Lcom/baidu/mapapi/map/BitmapDescriptor;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BitmapDescriptor> (JNIEnv.CallObjectMethod  (Handle, id_getTerminalMarker), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BitmapDescriptor> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTerminalMarker", "()Lcom/baidu/mapapi/map/BitmapDescriptor;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_onMarkerClick_Lcom_baidu_mapapi_map_Marker_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.overlayutil']/class[@name='TransitRouteOverlay']/method[@name='onMarkerClick' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.Marker']]"
		[Register ("onMarkerClick", "(Lcom/baidu/mapapi/map/Marker;)Z", "")]
		public override sealed unsafe bool OnMarkerClick (global::Com.Baidu.Mapapi.Map.Marker p0)
		{
			if (id_onMarkerClick_Lcom_baidu_mapapi_map_Marker_ == IntPtr.Zero)
				id_onMarkerClick_Lcom_baidu_mapapi_map_Marker_ = JNIEnv.GetMethodID (class_ref, "onMarkerClick", "(Lcom/baidu/mapapi/map/Marker;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_onMarkerClick_Lcom_baidu_mapapi_map_Marker_, __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onPolylineClick_Lcom_baidu_mapapi_map_Polyline_;
#pragma warning disable 0169
		static Delegate GetOnPolylineClick_Lcom_baidu_mapapi_map_Polyline_Handler ()
		{
			if (cb_onPolylineClick_Lcom_baidu_mapapi_map_Polyline_ == null)
				cb_onPolylineClick_Lcom_baidu_mapapi_map_Polyline_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnPolylineClick_Lcom_baidu_mapapi_map_Polyline_);
			return cb_onPolylineClick_Lcom_baidu_mapapi_map_Polyline_;
		}

		static bool n_OnPolylineClick_Lcom_baidu_mapapi_map_Polyline_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Overlayutil.TransitRouteOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Overlayutil.TransitRouteOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Map.Polyline p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.Polyline> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnPolylineClick (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onPolylineClick_Lcom_baidu_mapapi_map_Polyline_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.overlayutil']/class[@name='TransitRouteOverlay']/method[@name='onPolylineClick' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.Polyline']]"
		[Register ("onPolylineClick", "(Lcom/baidu/mapapi/map/Polyline;)Z", "GetOnPolylineClick_Lcom_baidu_mapapi_map_Polyline_Handler")]
		public override unsafe bool OnPolylineClick (global::Com.Baidu.Mapapi.Map.Polyline p0)
		{
			if (id_onPolylineClick_Lcom_baidu_mapapi_map_Polyline_ == IntPtr.Zero)
				id_onPolylineClick_Lcom_baidu_mapapi_map_Polyline_ = JNIEnv.GetMethodID (class_ref, "onPolylineClick", "(Lcom/baidu/mapapi/map/Polyline;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_onPolylineClick_Lcom_baidu_mapapi_map_Polyline_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPolylineClick", "(Lcom/baidu/mapapi/map/Polyline;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onRouteNodeClick_I;
#pragma warning disable 0169
		static Delegate GetOnRouteNodeClick_IHandler ()
		{
			if (cb_onRouteNodeClick_I == null)
				cb_onRouteNodeClick_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_OnRouteNodeClick_I);
			return cb_onRouteNodeClick_I;
		}

		static bool n_OnRouteNodeClick_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Baidu.Mapapi.Overlayutil.TransitRouteOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Overlayutil.TransitRouteOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OnRouteNodeClick (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onRouteNodeClick_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.overlayutil']/class[@name='TransitRouteOverlay']/method[@name='onRouteNodeClick' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onRouteNodeClick", "(I)Z", "GetOnRouteNodeClick_IHandler")]
		public virtual unsafe bool OnRouteNodeClick (int p0)
		{
			if (id_onRouteNodeClick_I == IntPtr.Zero)
				id_onRouteNodeClick_I = JNIEnv.GetMethodID (class_ref, "onRouteNodeClick", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_onRouteNodeClick_I, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onRouteNodeClick", "(I)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_setData_Lcom_baidu_mapapi_search_route_TransitRouteLine_;
#pragma warning disable 0169
		static Delegate GetSetData_Lcom_baidu_mapapi_search_route_TransitRouteLine_Handler ()
		{
			if (cb_setData_Lcom_baidu_mapapi_search_route_TransitRouteLine_ == null)
				cb_setData_Lcom_baidu_mapapi_search_route_TransitRouteLine_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetData_Lcom_baidu_mapapi_search_route_TransitRouteLine_);
			return cb_setData_Lcom_baidu_mapapi_search_route_TransitRouteLine_;
		}

		static void n_SetData_Lcom_baidu_mapapi_search_route_TransitRouteLine_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Overlayutil.TransitRouteOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Overlayutil.TransitRouteOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Search.Route.TransitRouteLine p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.TransitRouteLine> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetData (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setData_Lcom_baidu_mapapi_search_route_TransitRouteLine_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.overlayutil']/class[@name='TransitRouteOverlay']/method[@name='setData' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.search.route.TransitRouteLine']]"
		[Register ("setData", "(Lcom/baidu/mapapi/search/route/TransitRouteLine;)V", "GetSetData_Lcom_baidu_mapapi_search_route_TransitRouteLine_Handler")]
		public virtual unsafe void SetData (global::Com.Baidu.Mapapi.Search.Route.TransitRouteLine p0)
		{
			if (id_setData_Lcom_baidu_mapapi_search_route_TransitRouteLine_ == IntPtr.Zero)
				id_setData_Lcom_baidu_mapapi_search_route_TransitRouteLine_ = JNIEnv.GetMethodID (class_ref, "setData", "(Lcom/baidu/mapapi/search/route/TransitRouteLine;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setData_Lcom_baidu_mapapi_search_route_TransitRouteLine_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setData", "(Lcom/baidu/mapapi/search/route/TransitRouteLine;)V"), __args);
			} finally {
			}
		}

	}
}
