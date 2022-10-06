package crc645e184c64c340eee3;


public class RtspListener
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.alexvas.rtsp.RtspClient.RtspClientListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onRtspAudioSampleReceived:([BIIJ)V:GetOnRtspAudioSampleReceived_arrayBIIJHandler:Com.Alexvas.Rtsp.RtspClient/IRtspClientListenerInvoker, Xamarin.Rtsp.Lib\n" +
			"n_onRtspConnected:(Lcom/alexvas/rtsp/RtspClient$SdpInfo;)V:GetOnRtspConnected_Lcom_alexvas_rtsp_RtspClient_SdpInfo_Handler:Com.Alexvas.Rtsp.RtspClient/IRtspClientListenerInvoker, Xamarin.Rtsp.Lib\n" +
			"n_onRtspConnecting:()V:GetOnRtspConnectingHandler:Com.Alexvas.Rtsp.RtspClient/IRtspClientListenerInvoker, Xamarin.Rtsp.Lib\n" +
			"n_onRtspDisconnected:()V:GetOnRtspDisconnectedHandler:Com.Alexvas.Rtsp.RtspClient/IRtspClientListenerInvoker, Xamarin.Rtsp.Lib\n" +
			"n_onRtspFailed:(Ljava/lang/String;)V:GetOnRtspFailed_Ljava_lang_String_Handler:Com.Alexvas.Rtsp.RtspClient/IRtspClientListenerInvoker, Xamarin.Rtsp.Lib\n" +
			"n_onRtspFailedUnauthorized:()V:GetOnRtspFailedUnauthorizedHandler:Com.Alexvas.Rtsp.RtspClient/IRtspClientListenerInvoker, Xamarin.Rtsp.Lib\n" +
			"n_onRtspVideoNalUnitReceived:([BIIJ)V:GetOnRtspVideoNalUnitReceived_arrayBIIJHandler:Com.Alexvas.Rtsp.RtspClient/IRtspClientListenerInvoker, Xamarin.Rtsp.Lib\n" +
			"";
		mono.android.Runtime.register ("Xamarin.Rtsp.Droid.Renderers.RtspListener, Xamarin.Rtsp.Android", RtspListener.class, __md_methods);
	}


	public RtspListener ()
	{
		super ();
		if (getClass () == RtspListener.class) {
			mono.android.TypeManager.Activate ("Xamarin.Rtsp.Droid.Renderers.RtspListener, Xamarin.Rtsp.Android", "", this, new java.lang.Object[] {  });
		}
	}

	public RtspListener (android.view.Surface p0, int p1, int p2)
	{
		super ();
		if (getClass () == RtspListener.class) {
			mono.android.TypeManager.Activate ("Xamarin.Rtsp.Droid.Renderers.RtspListener, Xamarin.Rtsp.Android", "Android.Views.Surface, Mono.Android:System.Int32, mscorlib:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
		}
	}


	public void onRtspAudioSampleReceived (byte[] p0, int p1, int p2, long p3)
	{
		n_onRtspAudioSampleReceived (p0, p1, p2, p3);
	}

	private native void n_onRtspAudioSampleReceived (byte[] p0, int p1, int p2, long p3);


	public void onRtspConnected (com.alexvas.rtsp.RtspClient.SdpInfo p0)
	{
		n_onRtspConnected (p0);
	}

	private native void n_onRtspConnected (com.alexvas.rtsp.RtspClient.SdpInfo p0);


	public void onRtspConnecting ()
	{
		n_onRtspConnecting ();
	}

	private native void n_onRtspConnecting ();


	public void onRtspDisconnected ()
	{
		n_onRtspDisconnected ();
	}

	private native void n_onRtspDisconnected ();


	public void onRtspFailed (java.lang.String p0)
	{
		n_onRtspFailed (p0);
	}

	private native void n_onRtspFailed (java.lang.String p0);


	public void onRtspFailedUnauthorized ()
	{
		n_onRtspFailedUnauthorized ();
	}

	private native void n_onRtspFailedUnauthorized ();


	public void onRtspVideoNalUnitReceived (byte[] p0, int p1, int p2, long p3)
	{
		n_onRtspVideoNalUnitReceived (p0, p1, p2, p3);
	}

	private native void n_onRtspVideoNalUnitReceived (byte[] p0, int p1, int p2, long p3);

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
