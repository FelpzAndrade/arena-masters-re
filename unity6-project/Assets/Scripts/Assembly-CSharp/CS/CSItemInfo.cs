using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000AFF")]
	public sealed class CSItemInfo : CharStatus
	{
		[Token(Token = "0x4003611")]
		[FieldOffset(Offset = "0xB0")]
		public int nID;

		[Token(Token = "0x4003612")]
		[FieldOffset(Offset = "0xB4")]
		public string strName;

		[Token(Token = "0x4003613")]
		[FieldOffset(Offset = "0xB8")]
		public string strDesc;

		[Token(Token = "0x4003614")]
		[FieldOffset(Offset = "0xBC")]
		public string strIcon;

		[Token(Token = "0x4003615")]
		[FieldOffset(Offset = "0xC0")]
		public EquipmentSlot nSlot;

		[Token(Token = "0x4003616")]
		[FieldOffset(Offset = "0xC4")]
		public int nRegLevel;

		[Token(Token = "0x4003617")]
		[FieldOffset(Offset = "0xC8")]
		public float fusionRatio;

		[Token(Token = "0x4003618")]
		[FieldOffset(Offset = "0xCC")]
		public float fusionAncientRatio;

		[Token(Token = "0x4003619")]
		[FieldOffset(Offset = "0xD0")]
		public string strSoulCharacterIDs;

		[Token(Token = "0x400361A")]
		[FieldOffset(Offset = "0xD4")]
		[XmlIgnore]
		public List<int> SoulCharacterIDs;

		[Token(Token = "0x400361B")]
		[FieldOffset(Offset = "0xD8")]
		public int nFragmentCount;

		[Token(Token = "0x400361C")]
		[FieldOffset(Offset = "0xDC")]
		public int nFragmentSourceID;

		[Token(Token = "0x400361D")]
		[FieldOffset(Offset = "0xE0")]
		public int nEnchantRate;

		[Token(Token = "0x400361E")]
		[FieldOffset(Offset = "0xE4")]
		public int nPrice;

		[Token(Token = "0x400361F")]
		[FieldOffset(Offset = "0xE8")]
		public int nArenaCoinPrice;

		[Token(Token = "0x4003620")]
		[FieldOffset(Offset = "0xEC")]
		public string strDisplayStat1;

		[Token(Token = "0x4003621")]
		[FieldOffset(Offset = "0xF0")]
		public string strDisplayStat2;

		[Token(Token = "0x4003622")]
		[FieldOffset(Offset = "0xF4")]
		public string strMajorStat;

		[Token(Token = "0x4003623")]
		[FieldOffset(Offset = "0xF8")]
		public string strFixedMod;

		[Token(Token = "0x4003624")]
		[FieldOffset(Offset = "0xFC")]
		private bool m_FixedMod;

		[Token(Token = "0x4003625")]
		[FieldOffset(Offset = "0x100")]
		public int nExpAmount;

		[Token(Token = "0x4003626")]
		[FieldOffset(Offset = "0x104")]
		public int nSetItemID;

		[Token(Token = "0x4003627")]
		[FieldOffset(Offset = "0x108")]
		public int nPassiveSkillId;

		[Token(Token = "0x4003628")]
		[FieldOffset(Offset = "0x10C")]
		public int nBalanceRegulateId;

		[Token(Token = "0x4003629")]
		[FieldOffset(Offset = "0x110")]
		public int nGachaID;

		[Token(Token = "0x400362A")]
		[FieldOffset(Offset = "0x114")]
		public string TimeIntervalKey;

		[Token(Token = "0x400362B")]
		[FieldOffset(Offset = "0x118")]
		public int ActiveDay;

		[Token(Token = "0x400362C")]
		[FieldOffset(Offset = "0x11C")]
		public int ActiveSkin;

		[Token(Token = "0x400362D")]
		[FieldOffset(Offset = "0x120")]
		public string strSellPossible;

		[Token(Token = "0x400362E")]
		[FieldOffset(Offset = "0x124")]
		private bool m_SellPossible;

		[Token(Token = "0x400362F")]
		[FieldOffset(Offset = "0x128")]
		[XmlIgnore]
		public CSSkillInfo itemPassiveSkillInfo;

		[Token(Token = "0x4003630")]
		[FieldOffset(Offset = "0x12C")]
		[XmlIgnore]
		public bool isHavePassiveSkill;

		[Token(Token = "0x4003631")]
		[FieldOffset(Offset = "0x130")]
		private ItemType nType__BackingField;

		[Token(Token = "0x4003632")]
		[FieldOffset(Offset = "0x134")]
		private ItemRarity nRarity__BackingField;

		[Token(Token = "0x17000BCE")]
		public ItemType nType
		{
			[Token(Token = "0x60050F8")]
			[Address(RVA = "0x2235B60", Offset = "0x2235B60", VA = "0x2235B60")]
			get
			{
				return default(ItemType);
			}
			[Token(Token = "0x60050F9")]
			[Address(RVA = "0x2235B68", Offset = "0x2235B68", VA = "0x2235B68")]
			set
			{
			}
		}

		[Token(Token = "0x17000BCF")]
		public ItemRarity nRarity
		{
			[Token(Token = "0x60050FA")]
			[Address(RVA = "0x2235B70", Offset = "0x2235B70", VA = "0x2235B70")]
			get
			{
				return default(ItemRarity);
			}
			[Token(Token = "0x60050FB")]
			[Address(RVA = "0x2235B78", Offset = "0x2235B78", VA = "0x2235B78")]
			set
			{
			}
		}

		[Token(Token = "0x17000BD0")]
		public bool FixedMod
		{
			[Token(Token = "0x60050FC")]
			[Address(RVA = "0x2235B80", Offset = "0x2235B80", VA = "0x2235B80")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000BD1")]
		public bool SellPossible
		{
			[Token(Token = "0x60050FD")]
			[Address(RVA = "0x2235B88", Offset = "0x2235B88", VA = "0x2235B88")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60050F7")]
		[Address(RVA = "0x2235994", Offset = "0x2235994", VA = "0x2235994")]
		public CSItemInfo()
		{
		}

		[Token(Token = "0x60050FE")]
		[Address(RVA = "0x2235B90", Offset = "0x2235B90", VA = "0x2235B90")]
		public bool Cooking()
		{
			return default(bool);
		}

		[Token(Token = "0x60050FF")]
		[Address(RVA = "0x2235D00", Offset = "0x2235D00", VA = "0x2235D00")]
		private void ParseSoulCharacterIDs()
		{
		}

		[Token(Token = "0x6005100")]
		[Address(RVA = "0x2235FE4", Offset = "0x2235FE4", VA = "0x2235FE4")]
		public int GetFirstSoulCharacterID()
		{
			return default(int);
		}

		[Token(Token = "0x6005101")]
		[Address(RVA = "0x22360BC", Offset = "0x22360BC", VA = "0x22360BC")]
		public Currency GetUseStoneCurrencyType()
		{
			return default(Currency);
		}

		[Token(Token = "0x6005102")]
		[Address(RVA = "0x22360EC", Offset = "0x22360EC", VA = "0x22360EC")]
		public bool IsSoulStone()
		{
			return default(bool);
		}

		[Token(Token = "0x6005103")]
		[Address(RVA = "0x2236104", Offset = "0x2236104", VA = "0x2236104")]
		public bool IsSoulDust()
		{
			return default(bool);
		}

		[Token(Token = "0x6005104")]
		[Address(RVA = "0x2236118", Offset = "0x2236118", VA = "0x2236118")]
		public bool IsDimensionSoulStone()
		{
			return default(bool);
		}

		[Token(Token = "0x6005105")]
		[Address(RVA = "0x223612C", Offset = "0x223612C", VA = "0x223612C")]
		public bool IsDimensionSoulDust()
		{
			return default(bool);
		}

		[Token(Token = "0x6005106")]
		[Address(RVA = "0x2236140", Offset = "0x2236140", VA = "0x2236140")]
		public bool IsSkin()
		{
			return default(bool);
		}

		[Token(Token = "0x6005107")]
		[Address(RVA = "0x2236154", Offset = "0x2236154", VA = "0x2236154")]
		public Currency GetSellType()
		{
			return default(Currency);
		}

		[Token(Token = "0x6005108")]
		[Address(RVA = "0x2236194", Offset = "0x2236194", VA = "0x2236194")]
		internal bool IsArenaCoinCurrencyType()
		{
			return default(bool);
		}
	}
}
