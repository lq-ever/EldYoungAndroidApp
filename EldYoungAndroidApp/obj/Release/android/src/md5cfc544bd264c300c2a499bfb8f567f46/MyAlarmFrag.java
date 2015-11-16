package md5cfc544bd264c300c2a499bfb8f567f46;


public class MyAlarmFrag
	extends md54097cffc0ffa08632f0d89c6940011de.BaseFragment
	implements
		mono.android.IGCUserPeer,
		com.handmark.pulltorefresh.library.PullToRefreshBase.OnRefreshListener2,
		android.view.View.OnFocusChangeListener,
		android.widget.AdapterView.OnItemSelectedListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"n_onCreateView:(Landroid/view/LayoutInflater;Landroid/view/ViewGroup;Landroid/os/Bundle;)Landroid/view/View;:GetOnCreateView_Landroid_view_LayoutInflater_Landroid_view_ViewGroup_Landroid_os_Bundle_Handler\n" +
			"n_onActivityCreated:(Landroid/os/Bundle;)V:GetOnActivityCreated_Landroid_os_Bundle_Handler\n" +
			"n_onPullDownToRefresh:(Lcom/handmark/pulltorefresh/library/PullToRefreshBase;)V:GetOnPullDownToRefresh_Lcom_handmark_pulltorefresh_library_PullToRefreshBase_Handler:Com.Handmark.Pulltorefresh.Library.PullToRefreshBase/IOnRefreshListener2Invoker, PullToRefresh\n" +
			"n_onPullUpToRefresh:(Lcom/handmark/pulltorefresh/library/PullToRefreshBase;)V:GetOnPullUpToRefresh_Lcom_handmark_pulltorefresh_library_PullToRefreshBase_Handler:Com.Handmark.Pulltorefresh.Library.PullToRefreshBase/IOnRefreshListener2Invoker, PullToRefresh\n" +
			"n_onFocusChange:(Landroid/view/View;Z)V:GetOnFocusChange_Landroid_view_View_ZHandler:Android.Views.View/IOnFocusChangeListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"n_onItemSelected:(Landroid/widget/AdapterView;Landroid/view/View;IJ)V:GetOnItemSelected_Landroid_widget_AdapterView_Landroid_view_View_IJHandler:Android.Widget.AdapterView/IOnItemSelectedListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"n_onNothingSelected:(Landroid/widget/AdapterView;)V:GetOnNothingSelected_Landroid_widget_AdapterView_Handler:Android.Widget.AdapterView/IOnItemSelectedListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("EldYoungAndroidApp.Fragments.MainTab.Alarm.MyAlarmFrag, EldYoungAndroidApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MyAlarmFrag.class, __md_methods);
	}


	public MyAlarmFrag () throws java.lang.Throwable
	{
		super ();
		if (getClass () == MyAlarmFrag.class)
			mono.android.TypeManager.Activate ("EldYoungAndroidApp.Fragments.MainTab.Alarm.MyAlarmFrag, EldYoungAndroidApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);


	public android.view.View onCreateView (android.view.LayoutInflater p0, android.view.ViewGroup p1, android.os.Bundle p2)
	{
		return n_onCreateView (p0, p1, p2);
	}

	private native android.view.View n_onCreateView (android.view.LayoutInflater p0, android.view.ViewGroup p1, android.os.Bundle p2);


	public void onActivityCreated (android.os.Bundle p0)
	{
		n_onActivityCreated (p0);
	}

	private native void n_onActivityCreated (android.os.Bundle p0);


	public void onPullDownToRefresh (com.handmark.pulltorefresh.library.PullToRefreshBase p0)
	{
		n_onPullDownToRefresh (p0);
	}

	private native void n_onPullDownToRefresh (com.handmark.pulltorefresh.library.PullToRefreshBase p0);


	public void onPullUpToRefresh (com.handmark.pulltorefresh.library.PullToRefreshBase p0)
	{
		n_onPullUpToRefresh (p0);
	}

	private native void n_onPullUpToRefresh (com.handmark.pulltorefresh.library.PullToRefreshBase p0);


	public void onFocusChange (android.view.View p0, boolean p1)
	{
		n_onFocusChange (p0, p1);
	}

	private native void n_onFocusChange (android.view.View p0, boolean p1);


	public void onItemSelected (android.widget.AdapterView p0, android.view.View p1, int p2, long p3)
	{
		n_onItemSelected (p0, p1, p2, p3);
	}

	private native void n_onItemSelected (android.widget.AdapterView p0, android.view.View p1, int p2, long p3);


	public void onNothingSelected (android.widget.AdapterView p0)
	{
		n_onNothingSelected (p0);
	}

	private native void n_onNothingSelected (android.widget.AdapterView p0);

	java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
