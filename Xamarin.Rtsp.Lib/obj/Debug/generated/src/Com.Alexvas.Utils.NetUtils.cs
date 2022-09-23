using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alexvas.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alexvas.utils']/class[@name='NetUtils']"
	[global::Android.Runtime.Register ("com/alexvas/utils/NetUtils", DoNotGenerateAcw=true)]
	public partial class NetUtils : global::Java.Lang.Object {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.alexvas.utils']/class[@name='NetUtils.FakeX509TrustManager']"
		[global::Android.Runtime.Register ("com/alexvas/utils/NetUtils$FakeX509TrustManager", DoNotGenerateAcw=true)]
		public sealed partial class FakeX509TrustManager : global::Java.Lang.Object, global::Javax.Net.Ssl.IX509TrustManager {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/alexvas/utils/NetUtils$FakeX509TrustManager", typeof (FakeX509TrustManager));

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

			internal FakeX509TrustManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alexvas.utils']/class[@name='NetUtils.FakeX509TrustManager']/constructor[@name='NetUtils.FakeX509TrustManager' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe FakeX509TrustManager () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.alexvas.utils']/class[@name='NetUtils.FakeX509TrustManager']/method[@name='checkClientTrusted' and count(parameter)=2 and parameter[1][@type='java.security.cert.X509Certificate[]'] and parameter[2][@type='java.lang.String']]"
			[Register ("checkClientTrusted", "([Ljava/security/cert/X509Certificate;Ljava/lang/String;)V", "")]
			public unsafe void CheckClientTrusted (global::Java.Security.Cert.X509Certificate[] certificates, string authType)
			{
				const string __id = "checkClientTrusted.([Ljava/security/cert/X509Certificate;Ljava/lang/String;)V";
				IntPtr native_certificates = JNIEnv.NewArray (certificates);
				IntPtr native_authType = JNIEnv.NewString (authType);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_certificates);
					__args [1] = new JniArgumentValue (native_authType);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					if (certificates != null) {
						JNIEnv.CopyArray (native_certificates, certificates);
						JNIEnv.DeleteLocalRef (native_certificates);
					}
					JNIEnv.DeleteLocalRef (native_authType);
					global::System.GC.KeepAlive (certificates);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.alexvas.utils']/class[@name='NetUtils.FakeX509TrustManager']/method[@name='checkServerTrusted' and count(parameter)=2 and parameter[1][@type='java.security.cert.X509Certificate[]'] and parameter[2][@type='java.lang.String']]"
			[Register ("checkServerTrusted", "([Ljava/security/cert/X509Certificate;Ljava/lang/String;)V", "")]
			public unsafe void CheckServerTrusted (global::Java.Security.Cert.X509Certificate[] certificates, string authType)
			{
				const string __id = "checkServerTrusted.([Ljava/security/cert/X509Certificate;Ljava/lang/String;)V";
				IntPtr native_certificates = JNIEnv.NewArray (certificates);
				IntPtr native_authType = JNIEnv.NewString (authType);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_certificates);
					__args [1] = new JniArgumentValue (native_authType);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					if (certificates != null) {
						JNIEnv.CopyArray (native_certificates, certificates);
						JNIEnv.DeleteLocalRef (native_certificates);
					}
					JNIEnv.DeleteLocalRef (native_authType);
					global::System.GC.KeepAlive (certificates);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.alexvas.utils']/class[@name='NetUtils.FakeX509TrustManager']/method[@name='checkServerTrusted' and count(parameter)=3 and parameter[1][@type='java.security.cert.X509Certificate[]'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
			[Register ("checkServerTrusted", "([Ljava/security/cert/X509Certificate;Ljava/lang/String;Ljava/lang/String;)Ljava/util/List;", "")]
			public unsafe global::System.Collections.Generic.IList<global::Java.Security.Cert.X509Certificate> CheckServerTrusted (global::Java.Security.Cert.X509Certificate[] chain, string authType, string host)
			{
				const string __id = "checkServerTrusted.([Ljava/security/cert/X509Certificate;Ljava/lang/String;Ljava/lang/String;)Ljava/util/List;";
				IntPtr native_chain = JNIEnv.NewArray (chain);
				IntPtr native_authType = JNIEnv.NewString (authType);
				IntPtr native_host = JNIEnv.NewString (host);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_chain);
					__args [1] = new JniArgumentValue (native_authType);
					__args [2] = new JniArgumentValue (native_host);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Android.Runtime.JavaList<global::Java.Security.Cert.X509Certificate>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					if (chain != null) {
						JNIEnv.CopyArray (native_chain, chain);
						JNIEnv.DeleteLocalRef (native_chain);
					}
					JNIEnv.DeleteLocalRef (native_authType);
					JNIEnv.DeleteLocalRef (native_host);
					global::System.GC.KeepAlive (chain);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.alexvas.utils']/class[@name='NetUtils.FakeX509TrustManager']/method[@name='getAcceptedIssuers' and count(parameter)=0]"
			[Register ("getAcceptedIssuers", "()[Ljava/security/cert/X509Certificate;", "")]
			public unsafe global::Java.Security.Cert.X509Certificate[] GetAcceptedIssuers ()
			{
				const string __id = "getAcceptedIssuers.()[Ljava/security/cert/X509Certificate;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return (global::Java.Security.Cert.X509Certificate[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.Security.Cert.X509Certificate));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alexvas/utils/NetUtils", typeof (NetUtils));

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

		protected NetUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alexvas.utils']/class[@name='NetUtils']/constructor[@name='NetUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe NetUtils () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alexvas.utils']/class[@name='NetUtils']/method[@name='closeSocket' and count(parameter)=1 and parameter[1][@type='java.net.Socket']]"
		[Register ("closeSocket", "(Ljava/net/Socket;)V", "")]
		public static unsafe void CloseSocket (global::Java.Net.Socket socket)
		{
			const string __id = "closeSocket.(Ljava/net/Socket;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((socket == null) ? IntPtr.Zero : ((global::Java.Lang.Object) socket).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (socket);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alexvas.utils']/class[@name='NetUtils']/method[@name='createSocket' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("createSocket", "(I)Ljava/net/Socket;", "")]
		public static unsafe global::Java.Net.Socket CreateSocket (int timeout)
		{
			const string __id = "createSocket.(I)Ljava/net/Socket;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (timeout);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Net.Socket> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alexvas.utils']/class[@name='NetUtils']/method[@name='createSocketAndConnect' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("createSocketAndConnect", "(Ljava/lang/String;II)Ljava/net/Socket;", "")]
		public static unsafe global::Java.Net.Socket CreateSocketAndConnect (string dstName, int dstPort, int timeout)
		{
			const string __id = "createSocketAndConnect.(Ljava/lang/String;II)Ljava/net/Socket;";
			IntPtr native_dstName = JNIEnv.NewString (dstName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_dstName);
				__args [1] = new JniArgumentValue (dstPort);
				__args [2] = new JniArgumentValue (timeout);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Net.Socket> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_dstName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alexvas.utils']/class[@name='NetUtils']/method[@name='createSslSocketAndConnect' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("createSslSocketAndConnect", "(Ljava/lang/String;II)Ljavax/net/ssl/SSLSocket;", "")]
		public static unsafe global::Javax.Net.Ssl.SSLSocket CreateSslSocketAndConnect (string dstName, int dstPort, int timeout)
		{
			const string __id = "createSslSocketAndConnect.(Ljava/lang/String;II)Ljavax/net/ssl/SSLSocket;";
			IntPtr native_dstName = JNIEnv.NewString (dstName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_dstName);
				__args [1] = new JniArgumentValue (dstPort);
				__args [2] = new JniArgumentValue (timeout);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.SSLSocket> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_dstName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alexvas.utils']/class[@name='NetUtils']/method[@name='getResponseStatusCode' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList&lt;java.lang.String&gt;']]"
		[Register ("getResponseStatusCode", "(Ljava/util/ArrayList;)I", "")]
		public static unsafe int GetResponseStatusCode (global::System.Collections.Generic.IList<string> headers)
		{
			const string __id = "getResponseStatusCode.(Ljava/util/ArrayList;)I";
			IntPtr native_headers = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (headers);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_headers);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_headers);
				global::System.GC.KeepAlive (headers);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alexvas.utils']/class[@name='NetUtils']/method[@name='readContentAsText' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='int']]"
		[Register ("readContentAsText", "(Ljava/io/InputStream;I)Ljava/lang/String;", "")]
		public static unsafe string ReadContentAsText (global::System.IO.Stream inputStream, int length)
		{
			const string __id = "readContentAsText.(Ljava/io/InputStream;I)Ljava/lang/String;";
			IntPtr native_inputStream = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (inputStream);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_inputStream);
				__args [1] = new JniArgumentValue (length);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_inputStream);
				global::System.GC.KeepAlive (inputStream);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alexvas.utils']/class[@name='NetUtils']/method[@name='readData' and count(parameter)=4 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("readData", "(Ljava/io/InputStream;[BII)I", "")]
		public static unsafe int ReadData (global::System.IO.Stream inputStream, byte[] buffer, int offset, int length)
		{
			const string __id = "readData.(Ljava/io/InputStream;[BII)I";
			IntPtr native_inputStream = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (inputStream);
			IntPtr native_buffer = JNIEnv.NewArray (buffer);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_inputStream);
				__args [1] = new JniArgumentValue (native_buffer);
				__args [2] = new JniArgumentValue (offset);
				__args [3] = new JniArgumentValue (length);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_inputStream);
				if (buffer != null) {
					JNIEnv.CopyArray (native_buffer, buffer);
					JNIEnv.DeleteLocalRef (native_buffer);
				}
				global::System.GC.KeepAlive (inputStream);
				global::System.GC.KeepAlive (buffer);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alexvas.utils']/class[@name='NetUtils']/method[@name='readLine' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("readLine", "(Ljava/io/InputStream;)Ljava/lang/String;", "")]
		public static unsafe string ReadLine (global::System.IO.Stream inputStream)
		{
			const string __id = "readLine.(Ljava/io/InputStream;)Ljava/lang/String;";
			IntPtr native_inputStream = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (inputStream);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_inputStream);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_inputStream);
				global::System.GC.KeepAlive (inputStream);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alexvas.utils']/class[@name='NetUtils']/method[@name='readResponseHeaders' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("readResponseHeaders", "(Ljava/io/InputStream;)Ljava/util/ArrayList;", "")]
		public static unsafe global::System.Collections.Generic.IList<string> ReadResponseHeaders (global::System.IO.Stream inputStream)
		{
			const string __id = "readResponseHeaders.(Ljava/io/InputStream;)Ljava/util/ArrayList;";
			IntPtr native_inputStream = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (inputStream);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_inputStream);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_inputStream);
				global::System.GC.KeepAlive (inputStream);
			}
		}

	}
}
