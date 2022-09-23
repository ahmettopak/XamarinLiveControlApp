using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alexvas.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alexvas.utils']/class[@name='VideoCodecUtils']"
	[global::Android.Runtime.Register ("com/alexvas/utils/VideoCodecUtils", DoNotGenerateAcw=true)]
	public sealed partial class VideoCodecUtils : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.utils']/class[@name='VideoCodecUtils']/field[@name='H265_NAL_AUD']"
		[Register ("H265_NAL_AUD")]
		public const sbyte H265NalAud = (sbyte) 35;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.utils']/class[@name='VideoCodecUtils']/field[@name='H265_NAL_BLA_N_LP']"
		[Register ("H265_NAL_BLA_N_LP")]
		public const sbyte H265NalBlaNLp = (sbyte) 18;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.utils']/class[@name='VideoCodecUtils']/field[@name='H265_NAL_BLA_W_LP']"
		[Register ("H265_NAL_BLA_W_LP")]
		public const sbyte H265NalBlaWLp = (sbyte) 16;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.utils']/class[@name='VideoCodecUtils']/field[@name='H265_NAL_BLA_W_RADL']"
		[Register ("H265_NAL_BLA_W_RADL")]
		public const sbyte H265NalBlaWRadl = (sbyte) 17;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.utils']/class[@name='VideoCodecUtils']/field[@name='H265_NAL_CRA_NUT']"
		[Register ("H265_NAL_CRA_NUT")]
		public const sbyte H265NalCraNut = (sbyte) 21;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.utils']/class[@name='VideoCodecUtils']/field[@name='H265_NAL_EOB_NUT']"
		[Register ("H265_NAL_EOB_NUT")]
		public const sbyte H265NalEobNut = (sbyte) 37;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.utils']/class[@name='VideoCodecUtils']/field[@name='H265_NAL_EOS_NUT']"
		[Register ("H265_NAL_EOS_NUT")]
		public const sbyte H265NalEosNut = (sbyte) 36;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.utils']/class[@name='VideoCodecUtils']/field[@name='H265_NAL_FD_NUT']"
		[Register ("H265_NAL_FD_NUT")]
		public const sbyte H265NalFdNut = (sbyte) 38;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.utils']/class[@name='VideoCodecUtils']/field[@name='H265_NAL_IDR_N_LP']"
		[Register ("H265_NAL_IDR_N_LP")]
		public const sbyte H265NalİdrNLp = (sbyte) 20;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.utils']/class[@name='VideoCodecUtils']/field[@name='H265_NAL_IDR_W_RADL']"
		[Register ("H265_NAL_IDR_W_RADL")]
		public const sbyte H265NalİdrWRadl = (sbyte) 19;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.utils']/class[@name='VideoCodecUtils']/field[@name='H265_NAL_PPS']"
		[Register ("H265_NAL_PPS")]
		public const sbyte H265NalPps = (sbyte) 34;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.utils']/class[@name='VideoCodecUtils']/field[@name='H265_NAL_RADL_N']"
		[Register ("H265_NAL_RADL_N")]
		public const sbyte H265NalRadlN = (sbyte) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.utils']/class[@name='VideoCodecUtils']/field[@name='H265_NAL_RADL_R']"
		[Register ("H265_NAL_RADL_R")]
		public const sbyte H265NalRadlR = (sbyte) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.utils']/class[@name='VideoCodecUtils']/field[@name='H265_NAL_RASL_N']"
		[Register ("H265_NAL_RASL_N")]
		public const sbyte H265NalRaslN = (sbyte) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.utils']/class[@name='VideoCodecUtils']/field[@name='H265_NAL_RASL_R']"
		[Register ("H265_NAL_RASL_R")]
		public const sbyte H265NalRaslR = (sbyte) 9;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.utils']/class[@name='VideoCodecUtils']/field[@name='H265_NAL_SEI_PREFIX']"
		[Register ("H265_NAL_SEI_PREFIX")]
		public const sbyte H265NalSeiPrefix = (sbyte) 39;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.utils']/class[@name='VideoCodecUtils']/field[@name='H265_NAL_SEI_SUFFIX']"
		[Register ("H265_NAL_SEI_SUFFIX")]
		public const sbyte H265NalSeiSuffix = (sbyte) 40;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.utils']/class[@name='VideoCodecUtils']/field[@name='H265_NAL_SPS']"
		[Register ("H265_NAL_SPS")]
		public const sbyte H265NalSps = (sbyte) 33;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.utils']/class[@name='VideoCodecUtils']/field[@name='H265_NAL_STSA_N']"
		[Register ("H265_NAL_STSA_N")]
		public const sbyte H265NalStsaN = (sbyte) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.utils']/class[@name='VideoCodecUtils']/field[@name='H265_NAL_STSA_R']"
		[Register ("H265_NAL_STSA_R")]
		public const sbyte H265NalStsaR = (sbyte) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.utils']/class[@name='VideoCodecUtils']/field[@name='H265_NAL_TRAIL_N']"
		[Register ("H265_NAL_TRAIL_N")]
		public const sbyte H265NalTrailN = (sbyte) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.utils']/class[@name='VideoCodecUtils']/field[@name='H265_NAL_TRAIL_R']"
		[Register ("H265_NAL_TRAIL_R")]
		public const sbyte H265NalTrailR = (sbyte) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.utils']/class[@name='VideoCodecUtils']/field[@name='H265_NAL_TSA_N']"
		[Register ("H265_NAL_TSA_N")]
		public const sbyte H265NalTsaN = (sbyte) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.utils']/class[@name='VideoCodecUtils']/field[@name='H265_NAL_TSA_R']"
		[Register ("H265_NAL_TSA_R")]
		public const sbyte H265NalTsaR = (sbyte) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.utils']/class[@name='VideoCodecUtils']/field[@name='H265_NAL_VPS']"
		[Register ("H265_NAL_VPS")]
		public const sbyte H265NalVps = (sbyte) 32;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.utils']/class[@name='VideoCodecUtils']/field[@name='NAL_AUD']"
		[Register ("NAL_AUD")]
		public const sbyte NalAud = (sbyte) 9;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.utils']/class[@name='VideoCodecUtils']/field[@name='NAL_AUXILIARY_SLICE']"
		[Register ("NAL_AUXILIARY_SLICE")]
		public const sbyte NalAuxiliarySlice = (sbyte) 19;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.utils']/class[@name='VideoCodecUtils']/field[@name='NAL_DPA']"
		[Register ("NAL_DPA")]
		public const sbyte NalDpa = (sbyte) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.utils']/class[@name='VideoCodecUtils']/field[@name='NAL_DPB']"
		[Register ("NAL_DPB")]
		public const sbyte NalDpb = (sbyte) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.utils']/class[@name='VideoCodecUtils']/field[@name='NAL_DPC']"
		[Register ("NAL_DPC")]
		public const sbyte NalDpc = (sbyte) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.utils']/class[@name='VideoCodecUtils']/field[@name='NAL_END_SEQUENCE']"
		[Register ("NAL_END_SEQUENCE")]
		public const sbyte NalEndSequence = (sbyte) 10;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.utils']/class[@name='VideoCodecUtils']/field[@name='NAL_END_STREAM']"
		[Register ("NAL_END_STREAM")]
		public const sbyte NalEndStream = (sbyte) 11;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.utils']/class[@name='VideoCodecUtils']/field[@name='NAL_FILLER_DATA']"
		[Register ("NAL_FILLER_DATA")]
		public const sbyte NalFillerData = (sbyte) 12;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.utils']/class[@name='VideoCodecUtils']/field[@name='NAL_FU_A']"
		[Register ("NAL_FU_A")]
		public const sbyte NalFuA = (sbyte) 28;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.utils']/class[@name='VideoCodecUtils']/field[@name='NAL_FU_B']"
		[Register ("NAL_FU_B")]
		public const sbyte NalFuB = (sbyte) 29;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.utils']/class[@name='VideoCodecUtils']/field[@name='NAL_IDR_SLICE']"
		[Register ("NAL_IDR_SLICE")]
		public const sbyte NalİdrSlice = (sbyte) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.utils']/class[@name='VideoCodecUtils']/field[@name='NAL_MTAP16']"
		[Register ("NAL_MTAP16")]
		public const sbyte NalMtap16 = (sbyte) 26;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.utils']/class[@name='VideoCodecUtils']/field[@name='NAL_MTAP24']"
		[Register ("NAL_MTAP24")]
		public const sbyte NalMtap24 = (sbyte) 27;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.utils']/class[@name='VideoCodecUtils']/field[@name='NAL_PPS']"
		[Register ("NAL_PPS")]
		public const sbyte NalPps = (sbyte) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.utils']/class[@name='VideoCodecUtils']/field[@name='NAL_SEI']"
		[Register ("NAL_SEI")]
		public const sbyte NalSei = (sbyte) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.utils']/class[@name='VideoCodecUtils']/field[@name='NAL_SLICE']"
		[Register ("NAL_SLICE")]
		public const sbyte NalSlice = (sbyte) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.utils']/class[@name='VideoCodecUtils']/field[@name='NAL_SPS']"
		[Register ("NAL_SPS")]
		public const sbyte NalSps = (sbyte) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.utils']/class[@name='VideoCodecUtils']/field[@name='NAL_SPS_EXT']"
		[Register ("NAL_SPS_EXT")]
		public const sbyte NalSpsExt = (sbyte) 13;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.utils']/class[@name='VideoCodecUtils']/field[@name='NAL_STAP_A']"
		[Register ("NAL_STAP_A")]
		public const sbyte NalStapA = (sbyte) 24;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.utils']/class[@name='VideoCodecUtils']/field[@name='NAL_STAP_B']"
		[Register ("NAL_STAP_B")]
		public const sbyte NalStapB = (sbyte) 25;

		// Metadata.xml XPath class reference: path="/api/package[@name='com.alexvas.utils']/class[@name='VideoCodecUtils.NalUnit']"
		[global::Android.Runtime.Register ("com/alexvas/utils/VideoCodecUtils$NalUnit", DoNotGenerateAcw=true)]
		public partial class NalUnit : global::Java.Lang.Object {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.utils']/class[@name='VideoCodecUtils.NalUnit']/field[@name='length']"
			[Register ("length")]
			public int Length {
				get {
					const string __id = "length.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "length.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.utils']/class[@name='VideoCodecUtils.NalUnit']/field[@name='offset']"
			[Register ("offset")]
			public int Offset {
				get {
					const string __id = "offset.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "offset.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.alexvas.utils']/class[@name='VideoCodecUtils.NalUnit']/field[@name='type']"
			[Register ("type")]
			public sbyte Type {
				get {
					const string __id = "type.B";

					var __v = _members.InstanceFields.GetSByteValue (__id, this);
					return __v;
				}
				set {
					const string __id = "type.B";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/alexvas/utils/VideoCodecUtils$NalUnit", typeof (NalUnit));

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

			protected NalUnit (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alexvas/utils/VideoCodecUtils", typeof (VideoCodecUtils));

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

		internal VideoCodecUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alexvas.utils']/class[@name='VideoCodecUtils']/constructor[@name='VideoCodecUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VideoCodecUtils () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alexvas.utils']/class[@name='VideoCodecUtils']/method[@name='getH264NalUnitType' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("getH264NalUnitType", "([BII)B", "")]
		public static unsafe sbyte GetH264NalUnitType (byte[] data, int offset, int length)
		{
			const string __id = "getH264NalUnitType.([BII)B";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_data);
				__args [1] = new JniArgumentValue (offset);
				__args [2] = new JniArgumentValue (length);
				var __rm = _members.StaticMethods.InvokeSByteMethod (__id, __args);
				return __rm;
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
				global::System.GC.KeepAlive (data);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alexvas.utils']/class[@name='VideoCodecUtils']/method[@name='getH264NalUnitTypeString' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("getH264NalUnitTypeString", "(B)Ljava/lang/String;", "")]
		public static unsafe string GetH264NalUnitTypeString (sbyte nalUnitType)
		{
			const string __id = "getH264NalUnitTypeString.(B)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (nalUnitType);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alexvas.utils']/class[@name='VideoCodecUtils']/method[@name='getH264NalUnits' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='java.util.ArrayList&lt;com.alexvas.utils.VideoCodecUtils.NalUnit&gt;']]"
		[Register ("getH264NalUnits", "([BIILjava/util/ArrayList;)I", "")]
		public static unsafe int GetH264NalUnits (byte[] data, int dataOffset, int length, global::System.Collections.Generic.IList<global::Com.Alexvas.Utils.VideoCodecUtils.NalUnit> foundNals)
		{
			const string __id = "getH264NalUnits.([BIILjava/util/ArrayList;)I";
			IntPtr native_data = JNIEnv.NewArray (data);
			IntPtr native_foundNals = global::Android.Runtime.JavaList<global::Com.Alexvas.Utils.VideoCodecUtils.NalUnit>.ToLocalJniHandle (foundNals);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_data);
				__args [1] = new JniArgumentValue (dataOffset);
				__args [2] = new JniArgumentValue (length);
				__args [3] = new JniArgumentValue (native_foundNals);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
				JNIEnv.DeleteLocalRef (native_foundNals);
				global::System.GC.KeepAlive (data);
				global::System.GC.KeepAlive (foundNals);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alexvas.utils']/class[@name='VideoCodecUtils']/method[@name='getH264NalUnitsNumber' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("getH264NalUnitsNumber", "([BII)I", "")]
		public static unsafe int GetH264NalUnitsNumber (byte[] data, int dataOffset, int length)
		{
			const string __id = "getH264NalUnitsNumber.([BII)I";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_data);
				__args [1] = new JniArgumentValue (dataOffset);
				__args [2] = new JniArgumentValue (length);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
				global::System.GC.KeepAlive (data);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alexvas.utils']/class[@name='VideoCodecUtils']/method[@name='isValidH264NalUnit' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("isValidH264NalUnit", "([BII)Z", "")]
		public static unsafe bool IsValidH264NalUnit (byte[] data, int offset, int length)
		{
			const string __id = "isValidH264NalUnit.([BII)Z";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_data);
				__args [1] = new JniArgumentValue (offset);
				__args [2] = new JniArgumentValue (length);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
				global::System.GC.KeepAlive (data);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alexvas.utils']/class[@name='VideoCodecUtils']/method[@name='searchForH264NalUnitByType' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("searchForH264NalUnitByType", "([BIII)I", "")]
		public static unsafe int SearchForH264NalUnitByType (byte[] data, int offset, int length, int byUnitType)
		{
			const string __id = "searchForH264NalUnitByType.([BIII)I";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_data);
				__args [1] = new JniArgumentValue (offset);
				__args [2] = new JniArgumentValue (length);
				__args [3] = new JniArgumentValue (byUnitType);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
				global::System.GC.KeepAlive (data);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alexvas.utils']/class[@name='VideoCodecUtils']/method[@name='searchForH264NalUnitStart' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='java.util.concurrent.atomic.AtomicInteger']]"
		[Register ("searchForH264NalUnitStart", "([BIILjava/util/concurrent/atomic/AtomicInteger;)I", "")]
		public static unsafe int SearchForH264NalUnitStart (byte[] data, int offset, int length, global::Java.Util.Concurrent.Atomic.AtomicInteger prefixSize)
		{
			const string __id = "searchForH264NalUnitStart.([BIILjava/util/concurrent/atomic/AtomicInteger;)I";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_data);
				__args [1] = new JniArgumentValue (offset);
				__args [2] = new JniArgumentValue (length);
				__args [3] = new JniArgumentValue ((prefixSize == null) ? IntPtr.Zero : ((global::Java.Lang.Object) prefixSize).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
				global::System.GC.KeepAlive (data);
				global::System.GC.KeepAlive (prefixSize);
			}
		}

	}
}
