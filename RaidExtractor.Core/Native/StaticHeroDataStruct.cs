using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace RaidExtractor.Core.Native
{
    [StructLayout(LayoutKind.Explicit)]
	public struct StaticHeroDataStruct
	{
        [FieldOffset(0x10)]
        public List<HeroType> HeroTypes;
        //[FieldOffset(0x18)]
        //public Dictionary<int, int> HeroExperienceByKey;
        //[FieldOffset(0x20)]
        //public Dictionary<int, int> SacrificeExperienceByKey;
        //[FieldOffset(0x28)]
        //public Dictionary<HeroGrade, int> RankHeroCountByGrade;
        //[FieldOffset(0x30)]
        //public Dictionary<HeroGrade, int> RankSilverByGrade;
        //[FieldOffset(0x38)]
        //public Dictionary<HeroGrade, Account.Resources> LevelUpPriceByGrade;
        //[FieldOffset(0x40)]
        //public Dictionary<HeroRace, List<HeroFraction>> FractionsByRace;
        //[FieldOffset(0x48)]
        //public Dictionary<HeroRarity, List<int>> HeroIdsByRarities;
        //[FieldOffset(0x50)]
        //public int LevelUpMaterialsLimit;
        //[FieldOffset(0x54)]
        //public int MultipleHeroesSummonCount;
        //[FieldOffset(0x58)]
        //public int MaxInventorySlotsCount;
        //[FieldOffset(0x5C)]
        //public int MaxStorageSlotsCount;
        //[FieldOffset(0x60)]
        //public List<InventorySlotsPrice> InventorySlotsPrices;
        //[FieldOffset(0x68)]
        //public List<InventorySlotsPrice> StorageSlotsPrices;
        //[FieldOffset(0x70)]
        //public int[] HeroesOnIntroFinish;
        //[FieldOffset(0x78)]
        //public double HeroRatingUpdateCooldownMinutes;
        //[FieldOffset(0x80)]
        //public Dictionary<int, int> HeroPartsCountByHeroType;
        //[FieldOffset(0x88)]
        //public Dictionary<int, HeroType> HeroTypeById;
        //[FieldOffset(0x90)]
        //private Dictionary<HeroFraction, HeroRace> _raceByFraction;
        //[FieldOffset(0x98)]
        //private List<HeroFraction> _activeFractions;
        //[FieldOffset(0xA0)]
        //public List<int> UserAvailableBaseHeroIds;
        //[FieldOffset(0xA8)]
        //public List<HeroFraction> Fractions;
        //[FieldOffset(0xB0)]
        //public List<Element> Elements;
    }
}
