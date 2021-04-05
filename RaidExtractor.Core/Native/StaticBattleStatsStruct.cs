using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace RaidExtractor.Core.Native
{
    [StructLayout(LayoutKind.Explicit)]
    public struct StaticBattleStatsStruct
    {
        [FieldOffset(0x10)]
		public Fixed Health; // 0x10
        [FieldOffset(0x18)]
        public Fixed Attack; // 0x18
        [FieldOffset(0x20)]
        public Fixed Defence; // 0x20
        [FieldOffset(0x28)]
        public Fixed Speed; // 0x28
        [FieldOffset(0x30)]
        public Fixed Resistance; // 0x30
        [FieldOffset(0x38)]
        public Fixed Accuracy; // 0x38
        [FieldOffset(0x40)]
        public Fixed CriticalChance; // 0x40
        [FieldOffset(0x48)]
        public Fixed CriticalDamage; // 0x48
        [FieldOffset(0x50)]
        public Fixed CriticalHeal; // 0x50
    }

    public struct Fixed
    {
        public long Number;
        private const long Divisor = 4294967296; // (2^32)

        public int ToInt()
        {
            return (int)(Number / Divisor);
        }
    }
}
