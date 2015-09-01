package md55e96b505149b7d456ab077d0f6ae8798;


public class GuardianItemView
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("EldYoungAndroidApp.Adapter.GuardianItemView, EldYoungAndroidApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", GuardianItemView.class, __md_methods);
	}


	public GuardianItemView () throws java.lang.Throwable
	{
		super ();
		if (getClass () == GuardianItemView.class)
			mono.android.TypeManager.Activate ("EldYoungAndroidApp.Adapter.GuardianItemView, EldYoungAndroidApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

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
