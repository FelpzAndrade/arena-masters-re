using System.Collections.Generic;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20006EB")]
public class XItem
{
	[Token(Token = "0x400212D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private string m_IID;

	[Token(Token = "0x400212E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private CSItemInfo m_ItemInfo;

	[Token(Token = "0x400212F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private CharStatus m_status;

	[Token(Token = "0x4002130")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private CharStatus m_mergeRandomStatus;

	[Token(Token = "0x4002131")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private int m_nSlotID;

	[Token(Token = "0x4002132")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private int m_nRefineLevel;

	[Token(Token = "0x4002133")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int m_nRefineXP;

	[Token(Token = "0x4002134")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private XModuleActor.CharacterStatus m_Character;

	[Token(Token = "0x4002135")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int m_nStackCount;

	[Token(Token = "0x4002136")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private bool m_isShowed;

	[Token(Token = "0x4002137")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<int> m_randomOptionList;

	[Token(Token = "0x4002138")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private List<CharStatus> m_randomStatusList;

	[Token(Token = "0x1700081F")]
	public string IID
	{
		[Token(Token = "0x6003A06")]
		[Address(RVA = "0x1D2F694", Offset = "0x1D2F694", VA = "0x1D2F694")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000820")]
	public int SlotID
	{
		[Token(Token = "0x6003A07")]
		[Address(RVA = "0x1D324E0", Offset = "0x1D324E0", VA = "0x1D324E0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6003A08")]
		[Address(RVA = "0x1D324E8", Offset = "0x1D324E8", VA = "0x1D324E8")]
		set
		{
		}
	}

	[Token(Token = "0x17000821")]
	public bool IsSetItem
	{
		[Token(Token = "0x6003A09")]
		[Address(RVA = "0x1D324F0", Offset = "0x1D324F0", VA = "0x1D324F0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000822")]
	public int ItemID
	{
		[Token(Token = "0x6003A0A")]
		[Address(RVA = "0x1D32510", Offset = "0x1D32510", VA = "0x1D32510")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000823")]
	public int StackCount
	{
		[Token(Token = "0x6003A0B")]
		[Address(RVA = "0x1D311F8", Offset = "0x1D311F8", VA = "0x1D311F8")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000824")]
	public int RefineXP
	{
		[Token(Token = "0x6003A0C")]
		[Address(RVA = "0x1D3060C", Offset = "0x1D3060C", VA = "0x1D3060C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000825")]
	public int RefinedLevel
	{
		[Token(Token = "0x6003A0D")]
		[Address(RVA = "0x1D30084", Offset = "0x1D30084", VA = "0x1D30084")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000826")]
	public CSItemInfo Info
	{
		[Token(Token = "0x6003A0E")]
		[Address(RVA = "0x1D3007C", Offset = "0x1D3007C", VA = "0x1D3007C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000827")]
	public CharStatus Status
	{
		[Token(Token = "0x6003A0F")]
		[Address(RVA = "0x1D32524", Offset = "0x1D32524", VA = "0x1D32524")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000828")]
	public CharStatus RadomOptionStatus
	{
		[Token(Token = "0x6003A10")]
		[Address(RVA = "0x1D3252C", Offset = "0x1D3252C", VA = "0x1D3252C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000829")]
	public List<CharStatus> RandomStatusList
	{
		[Token(Token = "0x6003A11")]
		[Address(RVA = "0x1D32534", Offset = "0x1D32534", VA = "0x1D32534")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700082A")]
	public XModuleActor.CharacterStatus Character
	{
		[Token(Token = "0x6003A12")]
		[Address(RVA = "0x1D3253C", Offset = "0x1D3253C", VA = "0x1D3253C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60039FC")]
	[Address(RVA = "0x1D31C4C", Offset = "0x1D31C4C", VA = "0x1D31C4C")]
	public XItem(string iid, CSItemInfo itemInfo, int nEnchantXP, int stack_count, bool isShowed, [Optional] List<int> randomOptionList)
	{
	}

	[Token(Token = "0x60039FD")]
	[Address(RVA = "0x1D32238", Offset = "0x1D32238", VA = "0x1D32238")]
	public XItem(bool pvp, string iid, CSItemInfo itemInfo, int exp)
	{
	}

	[Token(Token = "0x60039FE")]
	[Address(RVA = "0x1D32270", Offset = "0x1D32270", VA = "0x1D32270")]
	public XItem()
	{
	}

	[Token(Token = "0x60039FF")]
	[Address(RVA = "0x1D3228C", Offset = "0x1D3228C", VA = "0x1D3228C")]
	public XItem(int stackCount)
	{
	}

	[Token(Token = "0x6003A00")]
	[Address(RVA = "0x1D322C4", Offset = "0x1D322C4", VA = "0x1D322C4")]
	public XItem(bool pvp, CSItemInfo itemInfo, int itemLevel)
	{
	}

	[Token(Token = "0x6003A01")]
	[Address(RVA = "0x1D31F8C", Offset = "0x1D31F8C", VA = "0x1D31F8C")]
	public void RefreshRandomStat()
	{
	}

	[Token(Token = "0x6003A02")]
	[Address(RVA = "0x1D324B4", Offset = "0x1D324B4", VA = "0x1D324B4")]
	public void SetEquip(XModuleActor.CharacterStatus character)
	{
	}

	[Token(Token = "0x6003A03")]
	[Address(RVA = "0x1D324BC", Offset = "0x1D324BC", VA = "0x1D324BC")]
	public void SetItemInfo(CSItemInfo itemInfo)
	{
	}

	[Token(Token = "0x6003A04")]
	[Address(RVA = "0x1D324C4", Offset = "0x1D324C4", VA = "0x1D324C4")]
	public void SetUnequip()
	{
	}

	[Token(Token = "0x6003A05")]
	[Address(RVA = "0x1D324D0", Offset = "0x1D324D0", VA = "0x1D324D0")]
	public bool IsEquiped()
	{
		return default(bool);
	}

	[Token(Token = "0x6003A13")]
	[Address(RVA = "0x1D32544", Offset = "0x1D32544", VA = "0x1D32544")]
	public bool IsLevelupItem()
	{
		return default(bool);
	}

	[Token(Token = "0x6003A14")]
	[Address(RVA = "0x1D3257C", Offset = "0x1D3257C", VA = "0x1D3257C")]
	public bool IsSellableItem()
	{
		return default(bool);
	}

	[Token(Token = "0x6003A15")]
	[Address(RVA = "0x1D325A8", Offset = "0x1D325A8", VA = "0x1D325A8")]
	public Currency GetSellType()
	{
		return default(Currency);
	}

	[Token(Token = "0x6003A16")]
	[Address(RVA = "0x1D325C0", Offset = "0x1D325C0", VA = "0x1D325C0")]
	public int GetSellValue()
	{
		return default(int);
	}

	[Token(Token = "0x6003A17")]
	[Address(RVA = "0x1D32738", Offset = "0x1D32738", VA = "0x1D32738")]
	public int GetArenaCoinSellValue()
	{
		return default(int);
	}

	[Token(Token = "0x6003A18")]
	[Address(RVA = "0x1D3287C", Offset = "0x1D3287C", VA = "0x1D3287C")]
	public void SetShowed()
	{
	}

	[Token(Token = "0x6003A19")]
	[Address(RVA = "0x1D32888", Offset = "0x1D32888", VA = "0x1D32888")]
	public bool IsShowed()
	{
		return default(bool);
	}

	[Token(Token = "0x6003A1A")]
	[Address(RVA = "0x1D3008C", Offset = "0x1D3008C", VA = "0x1D3008C")]
	public List<int> GetRandomOptionList()
	{
		return null;
	}

	[Token(Token = "0x6003A1B")]
	[Address(RVA = "0x1D32890", Offset = "0x1D32890", VA = "0x1D32890")]
	internal Netdata_Item ToNetDataItem()
	{
		return null;
	}

	[Token(Token = "0x6003A1C")]
	[Address(RVA = "0x1D3296C", Offset = "0x1D3296C", VA = "0x1D3296C")]
	public void PlayCardFlyStartSound()
	{
	}

	[Token(Token = "0x6003A1D")]
	[Address(RVA = "0x1D32B10", Offset = "0x1D32B10", VA = "0x1D32B10")]
	public void PlayCardFlyEndSound()
	{
	}

	[Token(Token = "0x6003A1E")]
	[Address(RVA = "0x1D32C80", Offset = "0x1D32C80", VA = "0x1D32C80")]
	public void PlayCardTurnSound()
	{
	}

	[Token(Token = "0x6003A1F")]
	[Address(RVA = "0x1D32DF0", Offset = "0x1D32DF0", VA = "0x1D32DF0")]
	public void PlayEquipSound()
	{
	}

	[Token(Token = "0x6003A20")]
	[Address(RVA = "0x1D32ADC", Offset = "0x1D32ADC", VA = "0x1D32ADC")]
	public bool IsBestRarity()
	{
		return default(bool);
	}

	[Token(Token = "0x6003A21")]
	[Address(RVA = "0x1D33068", Offset = "0x1D33068", VA = "0x1D33068")]
	public bool IsWeapon()
	{
		return default(bool);
	}

	[Token(Token = "0x6003A22")]
	[Address(RVA = "0x1D3308C", Offset = "0x1D3308C", VA = "0x1D3308C")]
	public bool IsArmor()
	{
		return default(bool);
	}

	[Token(Token = "0x6003A23")]
	[Address(RVA = "0x1D330C0", Offset = "0x1D330C0", VA = "0x1D330C0")]
	public bool IsAccessory()
	{
		return default(bool);
	}
}
