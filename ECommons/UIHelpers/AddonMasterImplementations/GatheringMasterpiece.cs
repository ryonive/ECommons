﻿using FFXIVClientStructs.FFXIV.Client.UI;

namespace ECommons.UIHelpers.AddonMasterImplementations;
public partial class AddonMaster
{
    public unsafe class GatheringMasterpiece : AddonMasterBase<AddonGatheringMasterpiece>
    {
        public GatheringMasterpiece(nint addon) : base(addon) { }
        public GatheringMasterpiece(void* addon) : base(addon) { }

        public string ItemName => Addon->ItemName->NodeText.ExtractText();
        public uint ItemID => Addon->AtkUnitBase.AtkValues[2].UInt;

        public int CurrentCollectability => Addon->AtkUnitBase.AtkValues[13].Int;
        public int MaxCollectability => Addon->AtkUnitBase.AtkValues[14].Int;
        public uint MinCollectability => Addon->AtkUnitBase.AtkValues[65].UInt;
        public uint MidCollectability => Addon->AtkUnitBase.AtkValues[66].UInt;
        public uint HighCollectability => Addon->AtkUnitBase.AtkValues[67].UInt;

        public uint CurrentIntegrity => Addon->AtkUnitBase.AtkValues[62].UInt;

        public uint TotalIntegrity => Addon->AtkUnitBase.AtkValues[63].UInt;

        public uint GatherChance => Addon->AtkUnitBase.AtkValues[18].UInt;

        public int ScourPower => Addon->AtkUnitBase.AtkValues[48].Int;
        public int BrazenPowerMin => Addon->AtkUnitBase.AtkValues[49].Int;
        public int BrazenPowerMax => Addon->AtkUnitBase.AtkValues[50].Int;
        public int MeticulousPower => Addon->AtkUnitBase.AtkValues[51].Int;
    }
}
