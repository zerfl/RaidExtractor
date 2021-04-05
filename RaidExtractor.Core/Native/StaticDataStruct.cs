using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace RaidExtractor.Core.Native
{
    [StructLayout(LayoutKind.Explicit)]
	public struct StaticDataStruct
	{
        [FieldOffset(0x10)]
		public IntPtr HeroData;
        [FieldOffset(0x18)]
        public IntPtr SkillData;
        //[FieldOffset(0x20)]
        //public StaticEffectData EffectData;
        [FieldOffset(0x28)]
        public IntPtr ArtifactData;
        [FieldOffset(0x30)]
        public IntPtr GameplayData;
        [FieldOffset(0x38)]
        public IntPtr StageData;
        [FieldOffset(0x100)]
		public IntPtr Revision;
    }

}
