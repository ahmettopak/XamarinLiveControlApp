using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alexvas.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alexvas.utils']/class[@name='ByteUtils']"
	[global::Android.Runtime.Register ("com/alexvas/utils/ByteUtils", DoNotGenerateAcw=true)]
	public partial class ByteUtils : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alexvas/utils/ByteUtils", typeof (ByteUtils));

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

		protected ByteUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alexvas.utils']/class[@name='ByteUtils']/constructor[@name='ByteUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ByteUtils () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alexvas.utils']/class[@name='ByteUtils']/method[@name='copy' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("copy", "([B)[B", "")]
		public static unsafe byte[] Copy (byte[] src)
		{
			const string __id = "copy.([B)[B";
			IntPtr native_src = JNIEnv.NewArray (src);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_src);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (src != null) {
					JNIEnv.CopyArray (native_src, src);
					JNIEnv.DeleteLocalRef (native_src);
				}
				global::System.GC.KeepAlive (src);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alexvas.utils']/class[@name='ByteUtils']/method[@name='memcmp' and count(parameter)=5 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
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
