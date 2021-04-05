using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace RaidExtractor.Core.Native
{
    [StructLayout(LayoutKind.Explicit)]
    public struct StaticHeroTypeStruct
	{
        [FieldOffset(0x10)]
		public int Id; // 0x10
        [FieldOffset(0x18)]
		public IntPtr Name; // 0x18 // SharedLTextKey
        //[FieldOffset(0x20)]
        //public string AvatarName; // 0x20
        //[FieldOffset(0x28)]
        //public string ModelName; // 0x28
        //[FieldOffset(0x30)]
        //public string ShowcaseSceneName; // 0x30
        [FieldOffset(0x38)]
		public Element Element; // 0x38
        [FieldOffset(0x3C)]
		public HeroRole Role; // 0x3C
        [FieldOffset(0x40)]
		public HeroFraction Fraction; // 0x40
        [FieldOffset(0x44)]
		public HeroRarity Rarity; // 0x44
        [FieldOffset(0x50)]
        public IntPtr BaseStats; // 0x50
        //[FieldOffset(0x58)]
        //public List<int> SkillTypeIds; // 0x58
        //[FieldOffset(0x60)]
        //public LeaderSkill LeaderSkill; // 0x60
        //[FieldOffset(0x68)]
        //public BossData BossData; // 0x68
        //[FieldOffset(0x70)]
        //public double SummonWeight; // 0x70
        //[FieldOffset(0x78)]
        //public bool IsLocationOnly; // 0x78
        //[FieldOffset(0x7C)]
        //public ReadyStatus Status; // 0x7C
        //[FieldOffset(0x80)]
        //public Brain Brain; // 0x80

        [FieldOffset(0x90)]
        private bool _isAwakable; // 0x90
        [FieldOffset(0x98)]
        private IntPtr _maxAwakenedType; // 0x98 // HeroType
    }
}
