using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alexvas.Rtsp {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alexvas.rtsp']/class[@name='AacParser']"
	[global::Android.Runtime.Register ("com/alexvas/rtsp/AacParser", DoNotGenerateAcw=true)]
	public partial class AacParser : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alexvas/rtsp/AacParser", typeof (AacParser));

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

		protected AacParser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alexvas.rtsp']/class[@name='AacParser']/constructor[@name='AacParser' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe AacParser (string aacMode) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_aacMode = JNIEnv.NewString (aacMode);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_aacMode);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_aacMode);
			}
		}

		static Delegate cb_processRtpPacketAndGetSample_arrayBI;
#pragma warning disable 0169
		static Delegate GetProcessRtpPacketAndGetSample_arrayBIHandler ()
		{
			if (cb_processRtpPacketAndGetSample_arrayBI == null)
				cb_processRtpPacketAndGetSample_arrayBI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_L) n_ProcessRtpPacketAndGetSample_arrayBI);
			return cb_processRtpPacketAndGetSample_arrayBI;
		}

		static IntPtr n_ProcessRtpPacketAndGetSample_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_data, int length)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Alexvas.Rtsp.AacParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var data = (byte[]) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewArray (__this.ProcessRtpPacketAndGetSample (data, length));
			if (data != null)
				JNIEnv.CopyArray (data, native_data);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alexvas.rtsp']/class[@name='AacParser']/method[@name='processRtpPacketAndGetSample' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("processRtpPacketAndGetSample", "([BI)[B", "GetProcessRtpPacketAndGetSample_arrayBIHandler")]
		public virtual unsafe byte[] ProcessRtpPacketAndGetSample (byte[] data, int length)
		{
			const string __id = "processRtpPacketAndGetSample.([BI)[B";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_data);
				__args [1] = new JniArgumentValue (length);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
				global::System.GC.KeepAlive (data);
			}
		}

	}
}
