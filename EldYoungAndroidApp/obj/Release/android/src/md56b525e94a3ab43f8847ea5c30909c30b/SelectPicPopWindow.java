package md56b525e94a3ab43f8847ea5c30909c30b;


public class SelectPicPopWindow
	extends android.widget.PopupWindow
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("EldYoungAndroidApp.Common.SelectPicPopWindow, EldYoungAndroidApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", SelectPicPopWindow.class, __md_methods);
	}


	public SelectPicPopWindow () throws java.lang.Throwable
	{
		super ();
		if (getClass () == SelectPicPopWindow.class)
			mono.android.TypeManager.Activate ("EldYoungAndroidApp.Common.SelectPicPopWindow, EldYoungAndroidApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public SelectPicPopWindow (android.content.Context p0, android.util.AttributeSet p1) throws java.lang.Throwable
	{
		super (p0, p1);
		if (getClass () == SelectPicPopWindow.class)
			mono.android.TypeManager.Activate ("EldYoungAndroidApp.Common.SelectPicPopWindow, EldYoungAndroidApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0, p1 });
	}


	public SelectPicPopWindow (android.content.Context p0, android.util.AttributeSet p1, int p2) throws java.lang.Throwable
	{
		super (p0, p1, p2);
		if (getClass () == SelectPicPopWindow.class)
			mono.android.TypeManager.Activate ("EldYoungAndroidApp.Common.SelectPicPopWindow, EldYoungAndroidApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:System.Int32, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public SelectPicPopWindow (android.view.View p0, int p1, int p2) throws java.lang.Throwable
	{
		super (p0, p1, p2);
		if (getClass () == SelectPicPopWindow.class)
			mono.android.TypeManager.Activate ("EldYoungAndroidApp.Common.SelectPicPopWindow, EldYoungAndroidApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Views.View, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:System.Int32, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e:System.Int32, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0, p1, p2 });
	}

	public SelectPicPopWindow (android.app.Activity p0) throws java.lang.Throwable
	{
		super ();
		if (getClass () == SelectPicPopWindow.class)
			mono.android.TypeManager.Activate ("EldYoungAndroidApp.Common.SelectPicPopWindow, EldYoungAndroidApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.App.Activity, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
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
