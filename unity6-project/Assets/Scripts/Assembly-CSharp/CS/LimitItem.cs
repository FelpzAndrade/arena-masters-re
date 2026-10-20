using System;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000973")]
	public class LimitItem
	{
		[Token(Token = "0x4002EBF")]
		[FieldOffset(Offset = "0x8")]
		private string ProductId__BackingField;

		[Token(Token = "0x4002EC0")]
		[FieldOffset(Offset = "0xC")]
		private int BoughtCount__BackingField;

		[Token(Token = "0x4002EC1")]
		[FieldOffset(Offset = "0x10")]
		private int MaxCount__BackingField;

		[Token(Token = "0x4002EC2")]
		[FieldOffset(Offset = "0x18")]
		private DateTime ExpireTime__BackingField;

		[Token(Token = "0x17000AD7")]
		public string ProductId
		{
			[Token(Token = "0x6004C1C")]
			[Address(RVA = "0x233A488", Offset = "0x233A488", VA = "0x233A488")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004C1D")]
			[Address(RVA = "0x233A490", Offset = "0x233A490", VA = "0x233A490")]
			set
			{
			}
		}

		[Token(Token = "0x17000AD8")]
		public int BoughtCount
		{
			[Token(Token = "0x6004C1E")]
			[Address(RVA = "0x233A498", Offset = "0x233A498", VA = "0x233A498")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004C1F")]
			[Address(RVA = "0x233A4A0", Offset = "0x233A4A0", VA = "0x233A4A0")]
			set
			{
			}
		}

		[Token(Token = "0x17000AD9")]
		public int MaxCount
		{
			[Token(Token = "0x6004C20")]
			[Address(RVA = "0x233A4A8", Offset = "0x233A4A8", VA = "0x233A4A8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004C21")]
			[Address(RVA = "0x233A4B0", Offset = "0x233A4B0", VA = "0x233A4B0")]
			set
			{
			}
		}

		[Token(Token = "0x17000ADA")]
		public DateTime ExpireTime
		{
			[Token(Token = "0x6004C22")]
			[Address(RVA = "0x233A4B8", Offset = "0x233A4B8", VA = "0x233A4B8")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x6004C23")]
			[Address(RVA = "0x233A4C8", Offset = "0x233A4C8", VA = "0x233A4C8")]
			set
			{
			}
		}

		[Token(Token = "0x6004C1B")]
		[Address(RVA = "0x233A480", Offset = "0x233A480", VA = "0x233A480")]
		public LimitItem()
		{
		}
	}
}
