package md54097cffc0ffa08632f0d89c6940011de;


public class RegisterResultActivity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"n_finish:()V:GetFinishHandler\n" +
			"";
		mono.android.Runtime.register ("EldYoungAndroidApp.RegisterResultActivity, EldYoungAndroidApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", RegisterResultActivity.class, __md_methods);
	}


	public RegisterResultActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == RegisterResultActivity.class)
			mono.android.TypeManager.Activate ("EldYoungAndroidApp.RegisterResultActivity, EldYoungAndroidApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);


	public void finish ()
	{
		n_finish ();
	}

	private native void n_finish ();

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
