package md576495055e471726c799e5ac8046c9f7e;


public class GetApplyInfoListItem
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("EldYoungAndroidApp.Model.GetApplyInfoListItem, EldYoungAndroidApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", GetApplyInfoListItem.class, __md_methods);
	}


	public GetApplyInfoListItem () throws java.lang.Throwable
	{
		super ();
		if (getClass () == GetApplyInfoListItem.class)
			mono.android.TypeManager.Activate ("EldYoungAndroidApp.Model.GetApplyInfoListItem, EldYoungAndroidApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
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
