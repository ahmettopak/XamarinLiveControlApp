using System;

[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.alexvas.rtsp", Managed="Com.Alexvas.Rtsp")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.alexvas.utils", Managed="Com.Alexvas.Utils")]

delegate IntPtr _JniMarshal_PP_L (IntPtr jnienv, IntPtr klass);
delegate void _JniMarshal_PP_V (IntPtr jnienv, IntPtr klass);
delegate IntPtr _JniMarshal_PPL_L (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate void _JniMarshal_PPL_V (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate IntPtr _JniMarshal_PPLI_L (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1);
delegate void _JniMarshal_PPLIIJ_V (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, int p2, long p3);
delegate IntPtr _JniMarshal_PPLL_L (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
delegate IntPtr _JniMarshal_PPZ_L (IntPtr jnienv, IntPtr klass, bool p0);
#if !NET
namespace System.Runtime.Versioning {
    [System.Diagnostics.Conditional("NEVER")]
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Constructor | AttributeTargets.Event | AttributeTargets.Method | AttributeTargets.Module | AttributeTargets.Property | AttributeTargets.Struct, AllowMultiple = true, Inherited = false)]
    internal sealed class SupportedOSPlatformAttribute : Attribute {
        public SupportedOSPlatformAttribute (string platformName) { }
    }
}
#endif

