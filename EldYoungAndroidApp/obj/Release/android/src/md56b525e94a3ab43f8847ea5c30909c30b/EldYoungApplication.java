package md56b525e94a3ab43f8847ea5c30909c30b;


public class EldYoungApplication
	extends mono.android.app.Application
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:()V:GetOnCreateHandler\n" +
			"";
	}


	public EldYoungApplication () throws java.lang.Throwable
	{
		super ();
	}

	public void onCreate ()
	{
		mono.android.Runtime.register ("EldYoungAndroidApp.Common.EldYoungApplication, EldYoungAndroidApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", EldYoungApplication.class, __md_methods);
		n_onCreate ();
	}

	private native void n_onCreate ();

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
