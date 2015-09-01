package md54097cffc0ffa08632f0d89c6940011de;


public abstract class BaseFragment
	extends android.support.v4.app.Fragment
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_getUserVisibleHint:()Z:GetGetUserVisibleHintHandler\n" +
			"n_setUserVisibleHint:(Z)V:GetSetUserVisibleHint_ZHandler\n" +
			"";
		mono.android.Runtime.register ("EldYoungAndroidApp.BaseFragment, EldYoungAndroidApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", BaseFragment.class, __md_methods);
	}


	public BaseFragment () throws java.lang.Throwable
	{
		super ();
		if (getClass () == BaseFragment.class)
			mono.android.TypeManager.Activate ("EldYoungAndroidApp.BaseFragment, EldYoungAndroidApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public boolean getUserVisibleHint ()
	{
		return n_getUserVisibleHint ();
	}

	private native boolean n_getUserVisibleHint ();


	public void setUserVisibleHint (boolean p0)
	{
		n_setUserVisibleHint (p0);
	}

	private native void n_setUserVisibleHint (boolean p0);

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
