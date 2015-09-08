package md5efbc768ae386ac08df7d9174ffcc382d;


public class PhotosLoader
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
		mono.android.Runtime.register ("EldYoungAndroidApp.Common.ImageCache.PhotosLoader, EldYoungAndroidApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", PhotosLoader.class, __md_methods);
	}


	public PhotosLoader () throws java.lang.Throwable
	{
		super ();
		if (getClass () == PhotosLoader.class)
			mono.android.TypeManager.Activate ("EldYoungAndroidApp.Common.ImageCache.PhotosLoader, EldYoungAndroidApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
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
