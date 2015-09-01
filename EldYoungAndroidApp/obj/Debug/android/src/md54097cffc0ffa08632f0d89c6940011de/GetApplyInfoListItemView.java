package md54097cffc0ffa08632f0d89c6940011de;


public class GetApplyInfoListItemView
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("EldYoungAndroidApp.GetApplyInfoListItemView, EldYoungAndroidApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", GetApplyInfoListItemView.class, __md_methods);
	}


	public GetApplyInfoListItemView () throws java.lang.Throwable
	{
		super ();
		if (getClass () == GetApplyInfoListItemView.class)
			mono.android.TypeManager.Activate ("EldYoungAndroidApp.GetApplyInfoListItemView, EldYoungAndroidApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
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
