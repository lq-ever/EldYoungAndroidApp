package md5efbc768ae386ac08df7d9174ffcc382d;


public class BitmapDisplayer
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		java.lang.Runnable
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_run:()V:GetRunHandler:Java.Lang.IRunnableInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("EldYoungAndroidApp.Common.ImageCache.BitmapDisplayer, EldYoungAndroidApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", BitmapDisplayer.class, __md_methods);
	}


	public BitmapDisplayer () throws java.lang.Throwable
	{
		super ();
		if (getClass () == BitmapDisplayer.class)
			mono.android.TypeManager.Activate ("EldYoungAndroidApp.Common.ImageCache.BitmapDisplayer, EldYoungAndroidApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void run ()
	{
		n_run ();
	}

	private native void n_run ();

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
