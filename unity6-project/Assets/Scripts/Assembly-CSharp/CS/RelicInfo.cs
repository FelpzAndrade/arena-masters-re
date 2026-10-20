using System;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000B3E")]
	public class RelicInfo
	{
		[Token(Token = "0x40037AE")]
		[FieldOffset(Offset = "0x8")]
		public int m_id;

		[Token(Token = "0x40037AF")]
		[FieldOffset(Offset = "0xC")]
		public string m_name;

		[Token(Token = "0x40037B0")]
		[FieldOffset(Offset = "0x10")]
		public int m_level;

		[Token(Token = "0x40037B1")]
		[FieldOffset(Offset = "0x14")]
		public ItemRarity nGrade;

		[Token(Token = "0x40037B2")]
		[FieldOffset(Offset = "0x18")]
		public string m_desc;

		[Token(Token = "0x40037B3")]
		[FieldOffset(Offset = "0x1C")]
		public int m_skill_id;

		[Token(Token = "0x40037B4")]
		[FieldOffset(Offset = "0x20")]
		public string m_icon;

		[Token(Token = "0x40037B5")]
		[FieldOffset(Offset = "0x24")]
		public string m_finish_reference;

		[Token(Token = "0x40037B6")]
		[FieldOffset(Offset = "0x28")]
		public string m_finish_condition_key;

		[Token(Token = "0x40037B7")]
		[FieldOffset(Offset = "0x2C")]
		public int m_finish_condition_value;

		[Token(Token = "0x40037B8")]
		[FieldOffset(Offset = "0x30")]
		public string m_finish_condition_desc;

		[Token(Token = "0x40037B9")]
		[FieldOffset(Offset = "0x34")]
		public int m_learn_gold;

		[Token(Token = "0x40037BA")]
		[FieldOffset(Offset = "0x38")]
		public int m_materialid;

		[Token(Token = "0x40037BB")]
		[FieldOffset(Offset = "0x3C")]
		public int m_materialcount;

		[Token(Token = "0x40037BC")]
		[FieldOffset(Offset = "0x40")]
		public string strShow;

		[Token(Token = "0x40037BD")]
		[FieldOffset(Offset = "0x44")]
		public bool IsShow;

		[Token(Token = "0x6005236")]
		[Address(RVA = "0x21C136C", Offset = "0x21C136C", VA = "0x21C136C")]
		public RelicInfo()
		{
		}

		[Token(Token = "0x6005237")]
		[Address(RVA = "0x21B2AAC", Offset = "0x21B2AAC", VA = "0x21B2AAC")]
		public bool Cooking()
		{
			return default(bool);
		}
	}
}
