package crc64d0cb88fa184f3d40;


public class VideoDecodeThread
	extends java.lang.Thread
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_run:()V:GetRunHandler\n" +
			"";
		mono.android.Runtime.register ("Xamarin.Rtsp.Droid.Renderers.Decode.VideoDecodeThread, Xamarin.Rtsp.Android", VideoDecodeThread.class, __md_methods);
	}


	public VideoDecodeThread ()
	{
		super ();
		if (getClass () == VideoDecodeThread.class) {
			mono.android.TypeManager.Activate ("Xamarin.Rtsp.Droid.Renderers.Decode.VideoDecodeThread, Xamarin.Rtsp.Android", "", this, new java.lang.Object[] {  });
		}
	}


	public VideoDecodeThread (java.lang.Runnable p0)
	{
		super (p0);
		if (getClass () == VideoDecodeThread.class) {
			mono.android.TypeManager.Activate ("Xamarin.Rtsp.Droid.Renderers.Decode.VideoDecodeThread, Xamarin.Rtsp.Android", "Java.Lang.IRunnable, Mono.Android", this, new java.lang.Object[] { p0 });
		}
	}


	public VideoDecodeThread (java.lang.Runnable p0, java.lang.String p1)
	{
		super (p0, p1);
		if (getClass () == VideoDecodeThread.class) {
			mono.android.TypeManager.Activate ("Xamarin.Rtsp.Droid.Renderers.Decode.VideoDecodeThread, Xamarin.Rtsp.Android", "Java.Lang.IRunnable, Mono.Android:System.String, mscorlib", this, new java.lang.Object[] { p0, p1 });
		}
	}


	public VideoDecodeThread (java.lang.String p0)
	{
		super (p0);
		if (getClass () == VideoDecodeThread.class) {
			mono.android.TypeManager.Activate ("Xamarin.Rtsp.Droid.Renderers.Decode.VideoDecodeThread, Xamarin.Rtsp.Android", "System.String, mscorlib", this, new java.lang.Object[] { p0 });
		}
	}


	public VideoDecodeThread (java.lang.ThreadGroup p0, java.lang.Runnable p1)
	{
		super (p0, p1);
		if (getClass () == VideoDecodeThread.class) {
			mono.android.TypeManager.Activate ("Xamarin.Rtsp.Droid.Renderers.Decode.VideoDecodeThread, Xamarin.Rtsp.Android", "Java.Lang.ThreadGroup, Mono.Android:Java.Lang.IRunnable, Mono.Android", this, new java.lang.Object[] { p0, p1 });
		}
	}


	public VideoDecodeThread (java.lang.ThreadGroup p0, java.lang.Runnable p1, java.lang.String p2)
	{
		super (p0, p1, p2);
		if (getClass () == VideoDecodeThread.class) {
			mono.android.TypeManager.Activate ("Xamarin.Rtsp.Droid.Renderers.Decode.VideoDecodeThread, Xamarin.Rtsp.Android", "Java.Lang.ThreadGroup, Mono.Android:Java.Lang.IRunnable, Mono.Android:System.String, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
		}
	}


	public VideoDecodeThread (java.lang.ThreadGroup p0, java.lang.Runnable p1, java.lang.String p2, long p3)
	{
		super (p0, p1, p2, p3);
		if (getClass () == VideoDecodeThread.class) {
			mono.android.TypeManager.Activate ("Xamarin.Rtsp.Droid.Renderers.Decode.VideoDecodeThread, Xamarin.Rtsp.Android", "Java.Lang.ThreadGroup, Mono.Android:Java.Lang.IRunnable, Mono.Android:System.String, mscorlib:System.Int64, mscorlib", this, new java.lang.Object[] { p0, p1, p2, p3 });
		}
	}


	public VideoDecodeThread (java.lang.ThreadGroup p0, java.lang.String p1)
	{
		super (p0, p1);
		if (getClass () == VideoDecodeThread.class) {
			mono.android.TypeManager.Activate ("Xamarin.Rtsp.Droid.Renderers.Decode.VideoDecodeThread, Xamarin.Rtsp.Android", "Java.Lang.ThreadGroup, Mono.Android:System.String, mscorlib", this, new java.lang.Object[] { p0, p1 });
		}
	}


	public void run ()
	{
		n_run ();
	}

	private native void n_run ();

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
