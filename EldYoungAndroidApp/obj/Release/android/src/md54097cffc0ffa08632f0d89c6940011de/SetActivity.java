package md54097cffc0ffa08632f0d89c6940011de;


public class SetActivity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer,
		android.content.DialogInterface.OnKeyListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"n_onKey:(Landroid/content/DialogInterface;ILandroid/view/KeyEvent;)Z:GetOnKey_Landroid_content_DialogInterface_ILandroid_view_KeyEvent_Handler:Android.Content.IDialogInterfaceOnKeyListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("EldYoungAndroidApp.SetActivity, EldYoungAndroidApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", SetActivity.class, __md_methods);
	}


	public SetActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == SetActivity.class)
			mono.android.TypeManager.Activate ("EldYoungAndroidApp.SetActivity, EldYoungAndroidApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);


	public boolean onKey (android.content.DialogInterface p0, int p1, android.view.KeyEvent p2)
	{
		return n_onKey (p0, p1, p2);
	}

	private native boolean n_onKey (android.content.DialogInterface p0, int p1, android.view.KeyEvent p2);

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
