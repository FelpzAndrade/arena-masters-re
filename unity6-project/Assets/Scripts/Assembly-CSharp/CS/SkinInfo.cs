using System;
using System.Xml.Serialization;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000B67")]
	public sealed class SkinInfo : CharStatus
	{
		[Token(Token = "0x4003975")]
		[FieldOffset(Offset = "0xB0")]
		public int nID;

		[Token(Token = "0x4003976")]
		[FieldOffset(Offset = "0xB4")]
		public int nCharID;

		[Token(Token = "0x4003977")]
		[FieldOffset(Offset = "0xB8")]
		public string strName;

		[Token(Token = "0x4003978")]
		[FieldOffset(Offset = "0xBC")]
		public string strShow;

		[Token(Token = "0x4003979")]
		[FieldOffset(Offset = "0xC0")]
		public string strTitle;

		[Token(Token = "0x400397A")]
		[FieldOffset(Offset = "0xC4")]
		public string strIntro;

		[Token(Token = "0x400397B")]
		[FieldOffset(Offset = "0xC8")]
		public string strFightingMsg;

		[Token(Token = "0x400397C")]
		[FieldOffset(Offset = "0xCC")]
		public string strResourcePath;

		[Token(Token = "0x400397D")]
		[FieldOffset(Offset = "0xD0")]
		public string strResourceName;

		[Token(Token = "0x400397E")]
		[FieldOffset(Offset = "0xD4")]
		public string strIcon;

		[Token(Token = "0x400397F")]
		[FieldOffset(Offset = "0xD8")]
		public string strLobbyIcon;

		[Token(Token = "0x4003980")]
		[FieldOffset(Offset = "0xDC")]
		public string strUltIcon;

		[Token(Token = "0x4003981")]
		[FieldOffset(Offset = "0xE0")]
		public int m_conditionItemID;

		[Token(Token = "0x4003982")]
		[FieldOffset(Offset = "0xE4")]
		public int m_keyItemCount;

		[Token(Token = "0x4003983")]
		[FieldOffset(Offset = "0xE8")]
		public int nPrice;

		[Token(Token = "0x4003984")]
		[FieldOffset(Offset = "0xEC")]
		public int nArenaCoin;

		[Token(Token = "0x4003985")]
		[FieldOffset(Offset = "0xF0")]
		public int nSkinTreasureItemId;

		[Token(Token = "0x4003986")]
		[FieldOffset(Offset = "0xF4")]
		private bool isShow__BackingField;

		[Token(Token = "0x4003987")]
		[FieldOffset(Offset = "0xF8")]
		private ItemRarity nRarity__BackingField;

		[Token(Token = "0x17000C28")]
		[XmlIgnore]
		public bool isShow
		{
			[Token(Token = "0x600530A")]
			[Address(RVA = "0x21E297C", Offset = "0x21E297C", VA = "0x21E297C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600530B")]
			[Address(RVA = "0x21E2984", Offset = "0x21E2984", VA = "0x21E2984")]
			private set
			{
			}
		}

		[Token(Token = "0x17000C29")]
		public ItemRarity nRarity
		{
			[Token(Token = "0x600530C")]
			[Address(RVA = "0x21E298C", Offset = "0x21E298C", VA = "0x21E298C")]
			get
			{
				return default(ItemRarity);
			}
			[Token(Token = "0x600530D")]
			[Address(RVA = "0x21E2994", Offset = "0x21E2994", VA = "0x21E2994")]
			set
			{
			}
		}

		[Token(Token = "0x6005309")]
		[Address(RVA = "0x21E27E8", Offset = "0x21E27E8", VA = "0x21E27E8")]
		public SkinInfo()
		{
		}

		[Token(Token = "0x600530E")]
		[Address(RVA = "0x21E299C", Offset = "0x21E299C", VA = "0x21E299C")]
		public string GetResourceFullPathName()
		{
			return null;
		}

		[Token(Token = "0x600530F")]
		[Address(RVA = "0x21E2A70", Offset = "0x21E2A70", VA = "0x21E2A70")]
		public bool Cooking()
		{
			return default(bool);
		}
	}
}
