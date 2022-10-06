using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alexvas.Rtsp {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alexvas.rtsp']/class[@name='RtspClient']"
	[global::Android.Runtime.Register ("com/alexvas/rtsp/RtspClient", DoNotGenerateAcw=true)]
	public partial class RtspClient : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.rtsp']/class[@name='RtspClient']/field[@name='AUDIO_CODEC_AAC']"
		[Register ("AUDIO_CODEC_AAC")]
		public const int AudioCodecAac = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.rtsp']/class[@name='RtspClient']/field[@name='AUDIO_CODEC_UNKNOWN']"
		[Register ("AUDIO_CODEC_UNKNOWN")]
		public const int AudioCodecUnknown = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.rtsp']/class[@name='RtspClient']/field[@name='RTSP_CAPABILITY_ANNOUNCE']"
		[Register ("RTSP_CAPABILITY_ANNOUNCE")]
		public const int RtspCapabilityAnnounce = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.rtsp']/class[@name='RtspClient']/field[@name='RTSP_CAPABILITY_DESCRIBE']"
		[Register ("RTSP_CAPABILITY_DESCRIBE")]
		public const int RtspCapabilityDescribe = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.rtsp']/class[@name='RtspClient']/field[@name='RTSP_CAPABILITY_GET_PARAMETER']"
		[Register ("RTSP_CAPABILITY_GET_PARAMETER")]
		public const int RtspCapabilityGetParameter = (int) 1024;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.rtsp']/class[@name='RtspClient']/field[@name='RTSP_CAPABILITY_NONE']"
		[Register ("RTSP_CAPABILITY_NONE")]
		public const int RtspCapabilityNone = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.rtsp']/class[@name='RtspClient']/field[@name='RTSP_CAPABILITY_OPTIONS']"
		[Register ("RTSP_CAPABILITY_OPTIONS")]
		public const int RtspCapabilityOptions = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.rtsp']/class[@name='RtspClient']/field[@name='RTSP_CAPABILITY_PAUSE']"
		[Register ("RTSP_CAPABILITY_PAUSE")]
		public const int RtspCapabilityPause = (int) 128;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.rtsp']/class[@name='RtspClient']/field[@name='RTSP_CAPABILITY_PLAY']"
		[Register ("RTSP_CAPABILITY_PLAY")]
		public const int RtspCapabilityPlay = (int) 32;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.rtsp']/class[@name='RtspClient']/field[@name='RTSP_CAPABILITY_RECORD']"
		[Register ("RTSP_CAPABILITY_RECORD")]
		public const int RtspCapabilityRecord = (int) 64;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.rtsp']/class[@name='RtspClient']/field[@name='RTSP_CAPABILITY_REDIRECT']"
		[Register ("RTSP_CAPABILITY_REDIRECT")]
		public const int RtspCapabilityRedirect = (int) 2048;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.rtsp']/class[@name='RtspClient']/field[@name='RTSP_CAPABILITY_SETUP']"
		[Register ("RTSP_CAPABILITY_SETUP")]
		public const int RtspCapabilitySetup = (int) 16;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.rtsp']/class[@name='RtspClient']/field[@name='RTSP_CAPABILITY_SET_PARAMETER']"
		[Register ("RTSP_CAPABILITY_SET_PARAMETER")]
		public const int RtspCapabilitySetParameter = (int) 512;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.rtsp']/class[@name='RtspClient']/field[@name='RTSP_CAPABILITY_TEARDOWN']"
		[Register ("RTSP_CAPABILITY_TEARDOWN")]
		public const int RtspCapabilityTeardown = (int) 256;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.rtsp']/class[@name='RtspClient']/field[@name='VIDEO_CODEC_H264']"
		[Register ("VIDEO_CODEC_H264")]
		public const int VideoCodecH264 = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.rtsp']/class[@name='RtspClient']/field[@name='VIDEO_CODEC_H265']"
		[Register ("VIDEO_CODEC_H265")]
		public const int VideoCodecH265 = (int) 1;

		// Metadata.xml XPath class reference: path="/api/package[@name='com.alexvas.rtsp']/class[@name='RtspClient.AudioTrack']"
		[global::Android.Runtime.Register ("com/alexvas/rtsp/RtspClient$AudioTrack", DoNotGenerateAcw=true)]
		public partial class AudioTrack : global::Com.Alexvas.Rtsp.RtspClient.Track {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.rtsp']/class[@name='RtspClient.AudioTrack']/field[@name='audioCodec']"
			[Register ("audioCodec")]
			public int AudioCodec {
				get {
					const string __id = "audioCodec.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "audioCodec.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.rtsp']/class[@name='RtspClient.AudioTrack']/field[@name='channels']"
			[Register ("channels")]
			public int Channels {
				get {
					const string __id = "channels.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "channels.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.rtsp']/class[@name='RtspClient.AudioTrack']/field[@name='config']"
			[Register ("config")]
			public IList<byte> Config {
				get {
					const string __id = "config.[B";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Android.Runtime.JavaArray<byte>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "config.[B";

					IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.rtsp']/class[@name='RtspClient.AudioTrack']/field[@name='mode']"
			[Register ("mode")]
			public string Mode {
				get {
					const string __id = "mode.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "mode.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString ((string)value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.rtsp']/class[@name='RtspClient.AudioTrack']/field[@name='sampleRateHz']"
			[Register ("sampleRateHz")]
			public int SampleRateHz {
				get {
					const string __id = "sampleRateHz.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "sampleRateHz.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/alexvas/rtsp/RtspClient$AudioTrack", typeof (AudioTrack));

			internal static new IntPtr class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			protected AudioTrack (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alexvas.rtsp']/class[@name='RtspClient.AudioTrack']/constructor[@name='RtspClient.AudioTrack' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe AudioTrack () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "()V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, null);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.alexvas.rtsp']/class[@name='RtspClient.Builder']"
		[global::Android.Runtime.Register ("com/alexvas/rtsp/RtspClient$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/alexvas/rtsp/RtspClient$Builder", typeof (Builder));

			internal static IntPtr class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alexvas.rtsp']/class[@name='RtspClient.Builder']/constructor[@name='RtspClient.Builder' and count(parameter)=4 and parameter[1][@type='java.net.Socket'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.concurrent.atomic.AtomicBoolean'] and parameter[4][@type='com.alexvas.rtsp.RtspClient.RtspClientListener']]"
			[Register (".ctor", "(Ljava/net/Socket;Ljava/lang/String;Ljava/util/concurrent/atomic/AtomicBoolean;Lcom/alexvas/rtsp/RtspClient$RtspClientListener;)V", "")]
			public unsafe Builder (global::Java.Net.Socket rtspSocket, string uriRtsp, global::Java.Util.Concurrent.Atomic.AtomicBoolean exitFlag, global::Com.Alexvas.Rtsp.RtspClient.IRtspClientListener listener) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/net/Socket;Ljava/lang/String;Ljava/util/concurrent/atomic/AtomicBoolean;Lcom/alexvas/rtsp/RtspClient$RtspClientListener;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_uriRtsp = JNIEnv.NewString ((string)uriRtsp);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue ((rtspSocket == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rtspSocket).Handle);
					__args [1] = new JniArgumentValue (native_uriRtsp);
					__args [2] = new JniArgumentValue ((exitFlag == null) ? IntPtr.Zero : ((global::Java.Lang.Object) exitFlag).Handle);
					__args [3] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_uriRtsp);
					global::System.GC.KeepAlive (rtspSocket);
					global::System.GC.KeepAlive (exitFlag);
					global::System.GC.KeepAlive (listener);
				}
			}

			static Delegate cb_build;
#pragma warning disable 0169
			static Delegate GetBuildHandler ()
			{
				if (cb_build == null)
					cb_build = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Build);
				return cb_build;
			}

			static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Alexvas.Rtsp.RtspClient.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.alexvas.rtsp']/class[@name='RtspClient.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/alexvas/rtsp/RtspClient;", "GetBuildHandler")]
			public virtual unsafe global::Com.Alexvas.Rtsp.RtspClient Build ()
			{
				const string __id = "build.()Lcom/alexvas/rtsp/RtspClient;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Alexvas.Rtsp.RtspClient> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_requestAudio_Z;
#pragma warning disable 0169
			static Delegate GetRequestAudio_ZHandler ()
			{
				if (cb_requestAudio_Z == null)
					cb_requestAudio_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_RequestAudio_Z);
				return cb_requestAudio_Z;
			}

			static IntPtr n_RequestAudio_Z (IntPtr jnienv, IntPtr native__this, bool requestAudio)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Alexvas.Rtsp.RtspClient.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.RequestAudio (requestAudio));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.alexvas.rtsp']/class[@name='RtspClient.Builder']/method[@name='requestAudio' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("requestAudio", "(Z)Lcom/alexvas/rtsp/RtspClient$Builder;", "GetRequestAudio_ZHandler")]
			public virtual unsafe global::Com.Alexvas.Rtsp.RtspClient.Builder RequestAudio (bool requestAudio)
			{
				const string __id = "requestAudio.(Z)Lcom/alexvas/rtsp/RtspClient$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (requestAudio);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Alexvas.Rtsp.RtspClient.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_requestVideo_Z;
#pragma warning disable 0169
			static Delegate GetRequestVideo_ZHandler ()
			{
				if (cb_requestVideo_Z == null)
					cb_requestVideo_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_RequestVideo_Z);
				return cb_requestVideo_Z;
			}

			static IntPtr n_RequestVideo_Z (IntPtr jnienv, IntPtr native__this, bool requestVideo)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Alexvas.Rtsp.RtspClient.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.RequestVideo (requestVideo));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.alexvas.rtsp']/class[@name='RtspClient.Builder']/method[@name='requestVideo' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("requestVideo", "(Z)Lcom/alexvas/rtsp/RtspClient$Builder;", "GetRequestVideo_ZHandler")]
			public virtual unsafe global::Com.Alexvas.Rtsp.RtspClient.Builder RequestVideo (bool requestVideo)
			{
				const string __id = "requestVideo.(Z)Lcom/alexvas/rtsp/RtspClient$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (requestVideo);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Alexvas.Rtsp.RtspClient.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_withCredentials_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetWithCredentials_Ljava_lang_String_Ljava_lang_String_Handler ()
			{
				if (cb_withCredentials_Ljava_lang_String_Ljava_lang_String_ == null)
					cb_withCredentials_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_WithCredentials_Ljava_lang_String_Ljava_lang_String_);
				return cb_withCredentials_Ljava_lang_String_Ljava_lang_String_;
			}

			static IntPtr n_WithCredentials_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_username, IntPtr native_password)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Alexvas.Rtsp.RtspClient.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var username = JNIEnv.GetString (native_username, JniHandleOwnership.DoNotTransfer);
				var password = JNIEnv.GetString (native_password, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithCredentials (username, password));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.alexvas.rtsp']/class[@name='RtspClient.Builder']/method[@name='withCredentials' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("withCredentials", "(Ljava/lang/String;Ljava/lang/String;)Lcom/alexvas/rtsp/RtspClient$Builder;", "GetWithCredentials_Ljava_lang_String_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Alexvas.Rtsp.RtspClient.Builder WithCredentials (string username, string password)
			{
				const string __id = "withCredentials.(Ljava/lang/String;Ljava/lang/String;)Lcom/alexvas/rtsp/RtspClient$Builder;";
				IntPtr native_username = JNIEnv.NewString ((string)username);
				IntPtr native_password = JNIEnv.NewString ((string)password);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_username);
					__args [1] = new JniArgumentValue (native_password);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Alexvas.Rtsp.RtspClient.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_username);
					JNIEnv.DeleteLocalRef (native_password);
				}
			}

			static Delegate cb_withDebug_Z;
#pragma warning disable 0169
			static Delegate GetWithDebug_ZHandler ()
			{
				if (cb_withDebug_Z == null)
					cb_withDebug_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_WithDebug_Z);
				return cb_withDebug_Z;
			}

			static IntPtr n_WithDebug_Z (IntPtr jnienv, IntPtr native__this, bool debug)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Alexvas.Rtsp.RtspClient.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.WithDebug (debug));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.alexvas.rtsp']/class[@name='RtspClient.Builder']/method[@name='withDebug' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("withDebug", "(Z)Lcom/alexvas/rtsp/RtspClient$Builder;", "GetWithDebug_ZHandler")]
			public virtual unsafe global::Com.Alexvas.Rtsp.RtspClient.Builder WithDebug (bool debug)
			{
				const string __id = "withDebug.(Z)Lcom/alexvas/rtsp/RtspClient$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (debug);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Alexvas.Rtsp.RtspClient.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_withUserAgent_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetWithUserAgent_Ljava_lang_String_Handler ()
			{
				if (cb_withUserAgent_Ljava_lang_String_ == null)
					cb_withUserAgent_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_WithUserAgent_Ljava_lang_String_);
				return cb_withUserAgent_Ljava_lang_String_;
			}

			static IntPtr n_WithUserAgent_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_userAgent)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Alexvas.Rtsp.RtspClient.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var userAgent = JNIEnv.GetString (native_userAgent, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithUserAgent (userAgent));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.alexvas.rtsp']/class[@name='RtspClient.Builder']/method[@name='withUserAgent' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("withUserAgent", "(Ljava/lang/String;)Lcom/alexvas/rtsp/RtspClient$Builder;", "GetWithUserAgent_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Alexvas.Rtsp.RtspClient.Builder WithUserAgent (string userAgent)
			{
				const string __id = "withUserAgent.(Ljava/lang/String;)Lcom/alexvas/rtsp/RtspClient$Builder;";
				IntPtr native_userAgent = JNIEnv.NewString ((string)userAgent);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_userAgent);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Alexvas.Rtsp.RtspClient.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_userAgent);
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.alexvas.rtsp']/interface[@name='RtspClient.RtspClientListener']"
		[Register ("com/alexvas/rtsp/RtspClient$RtspClientListener", "", "Com.Alexvas.Rtsp.RtspClient/IRtspClientListenerInvoker")]
		public partial interface IRtspClientListener : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alexvas.rtsp']/interface[@name='RtspClient.RtspClientListener']/method[@name='onRtspAudioSampleReceived' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='long']]"
			[Register ("onRtspAudioSampleReceived", "([BIIJ)V", "GetOnRtspAudioSampleReceived_arrayBIIJHandler:Com.Alexvas.Rtsp.RtspClient/IRtspClientListenerInvoker, Xamarin.Rtsp.Lib")]
			void OnRtspAudioSampleReceived (byte[] data, int offset, int length, long timestamp);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.alexvas.rtsp']/interface[@name='RtspClient.RtspClientListener']/method[@name='onRtspConnected' and count(parameter)=1 and parameter[1][@type='com.alexvas.rtsp.RtspClient.SdpInfo']]"
			[Register ("onRtspConnected", "(Lcom/alexvas/rtsp/RtspClient$SdpInfo;)V", "GetOnRtspConnected_Lcom_alexvas_rtsp_RtspClient_SdpInfo_Handler:Com.Alexvas.Rtsp.RtspClient/IRtspClientListenerInvoker, Xamarin.Rtsp.Lib")]
			void OnRtspConnected (global::Com.Alexvas.Rtsp.RtspClient.SdpInfo sdpInfo);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.alexvas.rtsp']/interface[@name='RtspClient.RtspClientListener']/method[@name='onRtspConnecting' and count(parameter)=0]"
			[Register ("onRtspConnecting", "()V", "GetOnRtspConnectingHandler:Com.Alexvas.Rtsp.RtspClient/IRtspClientListenerInvoker, Xamarin.Rtsp.Lib")]
			void OnRtspConnecting ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.alexvas.rtsp']/interface[@name='RtspClient.RtspClientListener']/method[@name='onRtspDisconnected' and count(parameter)=0]"
			[Register ("onRtspDisconnected", "()V", "GetOnRtspDisconnectedHandler:Com.Alexvas.Rtsp.RtspClient/IRtspClientListenerInvoker, Xamarin.Rtsp.Lib")]
			void OnRtspDisconnected ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.alexvas.rtsp']/interface[@name='RtspClient.RtspClientListener']/method[@name='onRtspFailed' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onRtspFailed", "(Ljava/lang/String;)V", "GetOnRtspFailed_Ljava_lang_String_Handler:Com.Alexvas.Rtsp.RtspClient/IRtspClientListenerInvoker, Xamarin.Rtsp.Lib")]
			void OnRtspFailed (string message);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.alexvas.rtsp']/interface[@name='RtspClient.RtspClientListener']/method[@name='onRtspFailedUnauthorized' and count(parameter)=0]"
			[Register ("onRtspFailedUnauthorized", "()V", "GetOnRtspFailedUnauthorizedHandler:Com.Alexvas.Rtsp.RtspClient/IRtspClientListenerInvoker, Xamarin.Rtsp.Lib")]
			void OnRtspFailedUnauthorized ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.alexvas.rtsp']/interface[@name='RtspClient.RtspClientListener']/method[@name='onRtspVideoNalUnitReceived' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='long']]"
			[Register ("onRtspVideoNalUnitReceived", "([BIIJ)V", "GetOnRtspVideoNalUnitReceived_arrayBIIJHandler:Com.Alexvas.Rtsp.RtspClient/IRtspClientListenerInvoker, Xamarin.Rtsp.Lib")]
			void OnRtspVideoNalUnitReceived (byte[] data, int offset, int length, long timestamp);

		}

		[global::Android.Runtime.Register ("com/alexvas/rtsp/RtspClient$RtspClientListener", DoNotGenerateAcw=true)]
		internal partial class IRtspClientListenerInvoker : global::Java.Lang.Object, IRtspClientListener {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/alexvas/rtsp/RtspClient$RtspClientListener", typeof (IRtspClientListenerInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IRtspClientListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IRtspClientListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.alexvas.rtsp.RtspClient.RtspClientListener'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IRtspClientListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onRtspAudioSampleReceived_arrayBIIJ;
#pragma warning disable 0169
			static Delegate GetOnRtspAudioSampleReceived_arrayBIIJHandler ()
			{
				if (cb_onRtspAudioSampleReceived_arrayBIIJ == null)
					cb_onRtspAudioSampleReceived_arrayBIIJ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIIJ_V) n_OnRtspAudioSampleReceived_arrayBIIJ);
				return cb_onRtspAudioSampleReceived_arrayBIIJ;
			}

			static void n_OnRtspAudioSampleReceived_arrayBIIJ (IntPtr jnienv, IntPtr native__this, IntPtr native_data, int offset, int length, long timestamp)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Alexvas.Rtsp.RtspClient.IRtspClientListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var data = (byte[]) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
				__this.OnRtspAudioSampleReceived (data, offset, length, timestamp);
				if (data != null)
					JNIEnv.CopyArray (data, native_data);
			}
#pragma warning restore 0169

			IntPtr id_onRtspAudioSampleReceived_arrayBIIJ;
			public unsafe void OnRtspAudioSampleReceived (byte[] data, int offset, int length, long timestamp)
			{
				if (id_onRtspAudioSampleReceived_arrayBIIJ == IntPtr.Zero)
					id_onRtspAudioSampleReceived_arrayBIIJ = JNIEnv.GetMethodID (class_ref, "onRtspAudioSampleReceived", "([BIIJ)V");
				IntPtr native_data = JNIEnv.NewArray (data);
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_data);
				__args [1] = new JValue (offset);
				__args [2] = new JValue (length);
				__args [3] = new JValue (timestamp);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRtspAudioSampleReceived_arrayBIIJ, __args);
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
			}

			static Delegate cb_onRtspConnected_Lcom_alexvas_rtsp_RtspClient_SdpInfo_;
#pragma warning disable 0169
			static Delegate GetOnRtspConnected_Lcom_alexvas_rtsp_RtspClient_SdpInfo_Handler ()
			{
				if (cb_onRtspConnected_Lcom_alexvas_rtsp_RtspClient_SdpInfo_ == null)
					cb_onRtspConnected_Lcom_alexvas_rtsp_RtspClient_SdpInfo_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnRtspConnected_Lcom_alexvas_rtsp_RtspClient_SdpInfo_);
				return cb_onRtspConnected_Lcom_alexvas_rtsp_RtspClient_SdpInfo_;
			}

			static void n_OnRtspConnected_Lcom_alexvas_rtsp_RtspClient_SdpInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sdpInfo)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Alexvas.Rtsp.RtspClient.IRtspClientListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var sdpInfo = global::Java.Lang.Object.GetObject<global::Com.Alexvas.Rtsp.RtspClient.SdpInfo> (native_sdpInfo, JniHandleOwnership.DoNotTransfer);
				__this.OnRtspConnected (sdpInfo);
			}
#pragma warning restore 0169

			IntPtr id_onRtspConnected_Lcom_alexvas_rtsp_RtspClient_SdpInfo_;
			public unsafe void OnRtspConnected (global::Com.Alexvas.Rtsp.RtspClient.SdpInfo sdpInfo)
			{
				if (id_onRtspConnected_Lcom_alexvas_rtsp_RtspClient_SdpInfo_ == IntPtr.Zero)
					id_onRtspConnected_Lcom_alexvas_rtsp_RtspClient_SdpInfo_ = JNIEnv.GetMethodID (class_ref, "onRtspConnected", "(Lcom/alexvas/rtsp/RtspClient$SdpInfo;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((sdpInfo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sdpInfo).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRtspConnected_Lcom_alexvas_rtsp_RtspClient_SdpInfo_, __args);
			}

			static Delegate cb_onRtspConnecting;
#pragma warning disable 0169
			static Delegate GetOnRtspConnectingHandler ()
			{
				if (cb_onRtspConnecting == null)
					cb_onRtspConnecting = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnRtspConnecting);
				return cb_onRtspConnecting;
			}

			static void n_OnRtspConnecting (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Alexvas.Rtsp.RtspClient.IRtspClientListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnRtspConnecting ();
			}
#pragma warning restore 0169

			IntPtr id_onRtspConnecting;
			public unsafe void OnRtspConnecting ()
			{
				if (id_onRtspConnecting == IntPtr.Zero)
					id_onRtspConnecting = JNIEnv.GetMethodID (class_ref, "onRtspConnecting", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRtspConnecting);
			}

			static Delegate cb_onRtspDisconnected;
#pragma warning disable 0169
			static Delegate GetOnRtspDisconnectedHandler ()
			{
				if (cb_onRtspDisconnected == null)
					cb_onRtspDisconnected = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnRtspDisconnected);
				return cb_onRtspDisconnected;
			}

			static void n_OnRtspDisconnected (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Alexvas.Rtsp.RtspClient.IRtspClientListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnRtspDisconnected ();
			}
#pragma warning restore 0169

			IntPtr id_onRtspDisconnected;
			public unsafe void OnRtspDisconnected ()
			{
				if (id_onRtspDisconnected == IntPtr.Zero)
					id_onRtspDisconnected = JNIEnv.GetMethodID (class_ref, "onRtspDisconnected", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRtspDisconnected);
			}

			static Delegate cb_onRtspFailed_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnRtspFailed_Ljava_lang_String_Handler ()
			{
				if (cb_onRtspFailed_Ljava_lang_String_ == null)
					cb_onRtspFailed_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnRtspFailed_Ljava_lang_String_);
				return cb_onRtspFailed_Ljava_lang_String_;
			}

			static void n_OnRtspFailed_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_message)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Alexvas.Rtsp.RtspClient.IRtspClientListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var message = JNIEnv.GetString (native_message, JniHandleOwnership.DoNotTransfer);
				__this.OnRtspFailed (message);
			}
#pragma warning restore 0169

			IntPtr id_onRtspFailed_Ljava_lang_String_;
			public unsafe void OnRtspFailed (string message)
			{
				if (id_onRtspFailed_Ljava_lang_String_ == IntPtr.Zero)
					id_onRtspFailed_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onRtspFailed", "(Ljava/lang/String;)V");
				IntPtr native_message = JNIEnv.NewString ((string)message);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_message);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRtspFailed_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_message);
			}

			static Delegate cb_onRtspFailedUnauthorized;
#pragma warning disable 0169
			static Delegate GetOnRtspFailedUnauthorizedHandler ()
			{
				if (cb_onRtspFailedUnauthorized == null)
					cb_onRtspFailedUnauthorized = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnRtspFailedUnauthorized);
				return cb_onRtspFailedUnauthorized;
			}

			static void n_OnRtspFailedUnauthorized (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Alexvas.Rtsp.RtspClient.IRtspClientListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnRtspFailedUnauthorized ();
			}
#pragma warning restore 0169

			IntPtr id_onRtspFailedUnauthorized;
			public unsafe void OnRtspFailedUnauthorized ()
			{
				if (id_onRtspFailedUnauthorized == IntPtr.Zero)
					id_onRtspFailedUnauthorized = JNIEnv.GetMethodID (class_ref, "onRtspFailedUnauthorized", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRtspFailedUnauthorized);
			}

			static Delegate cb_onRtspVideoNalUnitReceived_arrayBIIJ;
#pragma warning disable 0169
			static Delegate GetOnRtspVideoNalUnitReceived_arrayBIIJHandler ()
			{
				if (cb_onRtspVideoNalUnitReceived_arrayBIIJ == null)
					cb_onRtspVideoNalUnitReceived_arrayBIIJ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIIJ_V) n_OnRtspVideoNalUnitReceived_arrayBIIJ);
				return cb_onRtspVideoNalUnitReceived_arrayBIIJ;
			}

			static void n_OnRtspVideoNalUnitReceived_arrayBIIJ (IntPtr jnienv, IntPtr native__this, IntPtr native_data, int offset, int length, long timestamp)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Alexvas.Rtsp.RtspClient.IRtspClientListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var data = (byte[]) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
				__this.OnRtspVideoNalUnitReceived (data, offset, length, timestamp);
				if (data != null)
					JNIEnv.CopyArray (data, native_data);
			}
#pragma warning restore 0169

			IntPtr id_onRtspVideoNalUnitReceived_arrayBIIJ;
			public unsafe void OnRtspVideoNalUnitReceived (byte[] data, int offset, int length, long timestamp)
			{
				if (id_onRtspVideoNalUnitReceived_arrayBIIJ == IntPtr.Zero)
					id_onRtspVideoNalUnitReceived_arrayBIIJ = JNIEnv.GetMethodID (class_ref, "onRtspVideoNalUnitReceived", "([BIIJ)V");
				IntPtr native_data = JNIEnv.NewArray (data);
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_data);
				__args [1] = new JValue (offset);
				__args [2] = new JValue (length);
				__args [3] = new JValue (timestamp);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRtspVideoNalUnitReceived_arrayBIIJ, __args);
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
			}

		}

		// event args for com.alexvas.rtsp.RtspClient.RtspClientListener.onRtspAudioSampleReceived
		public partial class RtspAudioSampleReceivedEventArgs : global::System.EventArgs {
			public RtspAudioSampleReceivedEventArgs (byte[] data, int offset, int length, long timestamp)
			{
				this.data = data;
				this.offset = offset;
				this.length = length;
				this.timestamp = timestamp;
			}

			byte[] data;

			public byte[] Data {
				get { return data; }
			}

			int offset;

			public int Offset {
				get { return offset; }
			}

			int length;

			public int Length {
				get { return length; }
			}

			long timestamp;

			public long Timestamp {
				get { return timestamp; }
			}

		}

		// event args for com.alexvas.rtsp.RtspClient.RtspClientListener.onRtspConnected
		public partial class RtspConnectedEventArgs : global::System.EventArgs {
			public RtspConnectedEventArgs (global::Com.Alexvas.Rtsp.RtspClient.SdpInfo sdpInfo)
			{
				this.sdpInfo = sdpInfo;
			}

			global::Com.Alexvas.Rtsp.RtspClient.SdpInfo sdpInfo;

			public global::Com.Alexvas.Rtsp.RtspClient.SdpInfo SdpInfo {
				get { return sdpInfo; }
			}

		}

		// event args for com.alexvas.rtsp.RtspClient.RtspClientListener.onRtspFailed
		public partial class RtspFailedEventArgs : global::System.EventArgs {
			public RtspFailedEventArgs (string message)
			{
				this.message = message;
			}

			string message;

			public string Message {
				get { return message; }
			}

		}

		// event args for com.alexvas.rtsp.RtspClient.RtspClientListener.onRtspVideoNalUnitReceived
		public partial class RtspVideoNalUnitReceivedEventArgs : global::System.EventArgs {
			public RtspVideoNalUnitReceivedEventArgs (byte[] data, int offset, int length, long timestamp)
			{
				this.data = data;
				this.offset = offset;
				this.length = length;
				this.timestamp = timestamp;
			}

			byte[] data;

			public byte[] Data {
				get { return data; }
			}

			int offset;

			public int Offset {
				get { return offset; }
			}

			int length;

			public int Length {
				get { return length; }
			}

			long timestamp;

			public long Timestamp {
				get { return timestamp; }
			}

		}

		[global::Android.Runtime.Register ("mono/com/alexvas/rtsp/RtspClient_RtspClientListenerImplementor")]
		internal sealed partial class IRtspClientListenerImplementor : global::Java.Lang.Object, IRtspClientListener {

			object sender;

			public IRtspClientListenerImplementor (object sender) : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/alexvas/rtsp/RtspClient_RtspClientListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

			#pragma warning disable 0649
			public EventHandler<RtspAudioSampleReceivedEventArgs> OnRtspAudioSampleReceivedHandler;
			#pragma warning restore 0649

			public void OnRtspAudioSampleReceived (byte[] data, int offset, int length, long timestamp)
			{
				var __h = OnRtspAudioSampleReceivedHandler;
				if (__h != null)
					__h (sender, new RtspAudioSampleReceivedEventArgs (data, offset, length, timestamp));
			}

			#pragma warning disable 0649
			public EventHandler<RtspConnectedEventArgs> OnRtspConnectedHandler;
			#pragma warning restore 0649

			public void OnRtspConnected (global::Com.Alexvas.Rtsp.RtspClient.SdpInfo sdpInfo)
			{
				var __h = OnRtspConnectedHandler;
				if (__h != null)
					__h (sender, new RtspConnectedEventArgs (sdpInfo));
			}

			#pragma warning disable 0649
			public EventHandler OnRtspConnectingHandler;
			#pragma warning restore 0649

			public void OnRtspConnecting ()
			{
				var __h = OnRtspConnectingHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			#pragma warning disable 0649
			public EventHandler OnRtspDisconnectedHandler;
			#pragma warning restore 0649

			public void OnRtspDisconnected ()
			{
				var __h = OnRtspDisconnectedHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			#pragma warning disable 0649
			public EventHandler<RtspFailedEventArgs> OnRtspFailedHandler;
			#pragma warning restore 0649

			public void OnRtspFailed (string message)
			{
				var __h = OnRtspFailedHandler;
				if (__h != null)
					__h (sender, new RtspFailedEventArgs (message));
			}

			#pragma warning disable 0649
			public EventHandler OnRtspFailedUnauthorizedHandler;
			#pragma warning restore 0649

			public void OnRtspFailedUnauthorized ()
			{
				var __h = OnRtspFailedUnauthorizedHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			#pragma warning disable 0649
			public EventHandler<RtspVideoNalUnitReceivedEventArgs> OnRtspVideoNalUnitReceivedHandler;
			#pragma warning restore 0649

			public void OnRtspVideoNalUnitReceived (byte[] data, int offset, int length, long timestamp)
			{
				var __h = OnRtspVideoNalUnitReceivedHandler;
				if (__h != null)
					__h (sender, new RtspVideoNalUnitReceivedEventArgs (data, offset, length, timestamp));
			}

			internal static bool __IsEmpty (IRtspClientListenerImplementor value)
			{
				return value.OnRtspAudioSampleReceivedHandler == null && value.OnRtspConnectedHandler == null && value.OnRtspConnectingHandler == null && value.OnRtspDisconnectedHandler == null && value.OnRtspFailedHandler == null && value.OnRtspFailedUnauthorizedHandler == null && value.OnRtspVideoNalUnitReceivedHandler == null;
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.alexvas.rtsp']/class[@name='RtspClient.SdpInfo']"
		[global::Android.Runtime.Register ("com/alexvas/rtsp/RtspClient$SdpInfo", DoNotGenerateAcw=true)]
		public partial class SdpInfo : global::Java.Lang.Object {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.rtsp']/class[@name='RtspClient.SdpInfo']/field[@name='audioTrack']"
			[Register ("audioTrack")]
			public global::Com.Alexvas.Rtsp.RtspClient.AudioTrack AudioTrack {
				get {
					const string __id = "audioTrack.Lcom/alexvas/rtsp/RtspClient$AudioTrack;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Com.Alexvas.Rtsp.RtspClient.AudioTrack> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "audioTrack.Lcom/alexvas/rtsp/RtspClient$AudioTrack;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.rtsp']/class[@name='RtspClient.SdpInfo']/field[@name='sessionDescription']"
			[Register ("sessionDescription")]
			public string SessionDescription {
				get {
					const string __id = "sessionDescription.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "sessionDescription.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString ((string)value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.rtsp']/class[@name='RtspClient.SdpInfo']/field[@name='sessionName']"
			[Register ("sessionName")]
			public string SessionName {
				get {
					const string __id = "sessionName.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "sessionName.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString ((string)value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.rtsp']/class[@name='RtspClient.SdpInfo']/field[@name='videoTrack']"
			[Register ("videoTrack")]
			public global::Com.Alexvas.Rtsp.RtspClient.VideoTrack VideoTrack {
				get {
					const string __id = "videoTrack.Lcom/alexvas/rtsp/RtspClient$VideoTrack;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Com.Alexvas.Rtsp.RtspClient.VideoTrack> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "videoTrack.Lcom/alexvas/rtsp/RtspClient$VideoTrack;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/alexvas/rtsp/RtspClient$SdpInfo", typeof (SdpInfo));

			internal static IntPtr class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			protected SdpInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alexvas.rtsp']/class[@name='RtspClient.SdpInfo']/constructor[@name='RtspClient.SdpInfo' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe SdpInfo () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "()V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, null);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.alexvas.rtsp']/class[@name='RtspClient.Track']"
		[global::Android.Runtime.Register ("com/alexvas/rtsp/RtspClient$Track", DoNotGenerateAcw=true)]
		public abstract partial class Track : global::Java.Lang.Object {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.rtsp']/class[@name='RtspClient.Track']/field[@name='payloadType']"
			[Register ("payloadType")]
			public int PayloadType {
				get {
					const string __id = "payloadType.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "payloadType.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.rtsp']/class[@name='RtspClient.Track']/field[@name='request']"
			[Register ("request")]
			public string Request {
				get {
					const string __id = "request.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "request.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString ((string)value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/alexvas/rtsp/RtspClient$Track", typeof (Track));

			internal static IntPtr class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			protected Track (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alexvas.rtsp']/class[@name='RtspClient.Track']/constructor[@name='RtspClient.Track' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Track () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "()V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, null);
				} finally {
				}
			}

		}

		[global::Android.Runtime.Register ("com/alexvas/rtsp/RtspClient$Track", DoNotGenerateAcw=true)]
		internal partial class TrackInvoker : Track {
			public TrackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
			{
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/alexvas/rtsp/RtspClient$Track", typeof (TrackInvoker));

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.alexvas.rtsp']/class[@name='RtspClient.VideoTrack']"
		[global::Android.Runtime.Register ("com/alexvas/rtsp/RtspClient$VideoTrack", DoNotGenerateAcw=true)]
		public partial class VideoTrack : global::Com.Alexvas.Rtsp.RtspClient.Track {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.rtsp']/class[@name='RtspClient.VideoTrack']/field[@name='pps']"
			[Register ("pps")]
			public IList<byte> Pps {
				get {
					const string __id = "pps.[B";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Android.Runtime.JavaArray<byte>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "pps.[B";

					IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.rtsp']/class[@name='RtspClient.VideoTrack']/field[@name='sps']"
			[Register ("sps")]
			public IList<byte> Sps {
				get {
					const string __id = "sps.[B";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Android.Runtime.JavaArray<byte>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "sps.[B";

					IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.rtsp']/class[@name='RtspClient.VideoTrack']/field[@name='videoCodec']"
			[Register ("videoCodec")]
			public int VideoCodec {
				get {
					const string __id = "videoCodec.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "videoCodec.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/alexvas/rtsp/RtspClient$VideoTrack", typeof (VideoTrack));

			internal static new IntPtr class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			protected VideoTrack (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alexvas.rtsp']/class[@name='RtspClient.VideoTrack']/constructor[@name='RtspClient.VideoTrack' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe VideoTrack () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "()V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, null);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alexvas/rtsp/RtspClient", typeof (RtspClient));

		internal static IntPtr class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected RtspClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate cb_execute;
#pragma warning disable 0169
		static Delegate GetExecuteHandler ()
		{
			if (cb_execute == null)
				cb_execute = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Execute);
			return cb_execute;
		}

		static void n_Execute (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Alexvas.Rtsp.RtspClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Execute ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alexvas.rtsp']/class[@name='RtspClient']/method[@name='execute' and count(parameter)=0]"
		[Register ("execute", "()V", "GetExecuteHandler")]
		public virtual unsafe void Execute ()
		{
			const string __id = "execute.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alexvas.rtsp']/class[@name='RtspClient']/method[@name='hasCapability' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("hasCapability", "(II)Z", "")]
		public static unsafe bool HasCapability (int capability, int capabilitiesMask)
		{
			const string __id = "hasCapability.(II)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (capability);
				__args [1] = new JniArgumentValue (capabilitiesMask);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alexvas.rtsp']/class[@name='RtspClient']/method[@name='memcmp' and count(parameter)=5 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("memcmp", "([BI[BII)Z", "")]
		public static unsafe bool Memcmp (byte[] source1, int offsetSource1, byte[] source2, int offsetSource2, int num)
		{
			const string __id = "memcmp.([BI[BII)Z";
			IntPtr native_source1 = JNIEnv.NewArray (source1);
			IntPtr native_source2 = JNIEnv.NewArray (source2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_source1);
				__args [1] = new JniArgumentValue (offsetSource1);
				__args [2] = new JniArgumentValue (native_source2);
				__args [3] = new JniArgumentValue (offsetSource2);
				__args [4] = new JniArgumentValue (num);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				if (source1 != null) {
					JNIEnv.CopyArray (native_source1, source1);
					JNIEnv.DeleteLocalRef (native_source1);
				}
				if (source2 != null) {
					JNIEnv.CopyArray (native_source2, source2);
					JNIEnv.DeleteLocalRef (native_source2);
				}
				global::System.GC.KeepAlive (source1);
				global::System.GC.KeepAlive (source2);
			}
		}

	}
}
