using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace RaidExtractor.Core.Native
{
    [StructLayout(LayoutKind.Explicit)]
    public struct SharedLTextKeyStruct
    {
        [FieldOffset(0x10)]
        public IntPtr Key;
        [FieldOffset(0x18)]
        public IntPtr DefaultValue;
    }
}
