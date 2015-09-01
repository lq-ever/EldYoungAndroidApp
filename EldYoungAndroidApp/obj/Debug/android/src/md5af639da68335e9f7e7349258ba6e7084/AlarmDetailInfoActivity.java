package md5af639da68335e9f7e7349258ba6e7084;


public class AlarmDetailInfoActivity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("EldYoungAndroidApp.Activitys.Alarm.AlarmDetailInfoActivity, EldYoungAndroidApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", AlarmDetailInfoActivity.class, __md_methods);
	}


	public AlarmDetailInfoActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == AlarmDetailInfoActivity.class)
			mono.android.TypeManager.Activate ("EldYoungAndroidApp.Activitys.Alarm.AlarmDetailInfoActivity, EldYoungAndroidApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

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
