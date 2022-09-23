package crc645e184c64c340eee3;


public class Frame
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Xamarin.Rtsp.Droid.Renderers.Frame, Xamarin.Rtsp.Android", Frame.class, __md_methods);
	}


	public Frame ()
	{
		super ();
		if (getClass () == Frame.class)
			mono.android.TypeManager.Activate ("Xamarin.Rtsp.Droid.Renderers.Frame, Xamarin.Rtsp.Android", "", this, new java.lang.Object[] {  });
	}

	private java.util.ArrayList refList;
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
