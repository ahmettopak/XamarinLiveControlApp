package crc645e184c64c340eee3;


public class CustomView
	extends android.view.SurfaceView
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Xamarin.Rtsp.Droid.Renderers.CustomView, Xamarin.Rtsp.Android", CustomView.class, __md_methods);
	}


	public CustomView (android.content.Context p0)
	{
		super (p0);
		if (getClass () == CustomView.class) {
			mono.android.TypeManager.Activate ("Xamarin.Rtsp.Droid.Renderers.CustomView, Xamarin.Rtsp.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
		}
	}


	public CustomView (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == CustomView.class) {
			mono.android.TypeManager.Activate ("Xamarin.Rtsp.Droid.Renderers.CustomView, Xamarin.Rtsp.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
		}
	}


	public CustomView (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == CustomView.class) {
			mono.android.TypeManager.Activate ("Xamarin.Rtsp.Droid.Renderers.CustomView, Xamarin.Rtsp.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
		}
	}


	public CustomView (android.content.Context p0, android.util.AttributeSet p1, int p2, int p3)
	{
		super (p0, p1, p2, p3);
		if (getClass () == CustomView.class) {
			mono.android.TypeManager.Activate ("Xamarin.Rtsp.Droid.Renderers.CustomView, Xamarin.Rtsp.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2, p3 });
		}
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
