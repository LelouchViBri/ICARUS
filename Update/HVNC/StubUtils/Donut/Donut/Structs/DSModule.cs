using System;
using System.Runtime.InteropServices;

namespace ICARUS.HVNC.StubUtils.Donut.Structs
{
    public struct DSModule
    {
        public int type;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
        public byte[] runtime;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
        public byte[] domain;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
        public byte[] cls;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
        public byte[] method;

        public int param_cnt;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public GStruct2[] gstruct2_0;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
        public char[] sig;

        public ulong mac;

        public ulong len;

        public IntPtr data;
    }
}
