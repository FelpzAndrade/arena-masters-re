using System;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000B80")]
	public class TitleInfo
	{
		[Token(Token = "0x4003A1F")]
		[FieldOffset(Offset = "0x8")]
		public int m_id;

		[Token(Token = "0x4003A20")]
		[FieldOffset(Offset = "0xC")]
		public string m_name;

		[Token(Token = "0x4003A21")]
		[FieldOffset(Offset = "0x10")]
		public string m_desc;

		[Token(Token = "0x4003A22")]
		[FieldOffset(Offset = "0x14")]
		public string m_icon;

		[Token(Token = "0x4003A23")]
		[FieldOffset(Offset = "0x18")]
		public Stat.Type m_FinishConditionKey;

		[Token(Token = "0x4003A24")]
		[FieldOffset(Offset = "0x1C")]
		public int m_FinishConditionValue;

		[Token(Token = "0x4003A25")]
		[FieldOffset(Offset = "0x20")]
		public string m_FinishConditionDesc;

		[Token(Token = "0x4003A26")]
		[FieldOffset(Offset = "0x24")]
		public int m_order;

		[Token(Token = "0x17000C2A")]
		public string FinishConditionKeyString
		{
			[Token(Token = "0x600535E")]
			[Address(RVA = "0x21E93B0", Offset = "0x21E93B0", VA = "0x21E93B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600535D")]
		[Address(RVA = "0x21E92A4", Offset = "0x21E92A4", VA = "0x21E92A4")]
		public TitleInfo()
		{
		}
	}
}
