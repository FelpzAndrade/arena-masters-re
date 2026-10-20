using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000974")]
	public class LimitItemPurchasedList
	{
		[Token(Token = "0x4002EC3")]
		[FieldOffset(Offset = "0x8")]
		private Dictionary<string, LimitItem> _list;

		[Token(Token = "0x4002EC4")]
		[FieldOffset(Offset = "0xC")]
		private string AccountId__BackingField;

		[Token(Token = "0x17000ADB")]
		public string AccountId
		{
			[Token(Token = "0x6004C25")]
			[Address(RVA = "0x233A58C", Offset = "0x233A58C", VA = "0x233A58C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004C26")]
			[Address(RVA = "0x233A594", Offset = "0x233A594", VA = "0x233A594")]
			set
			{
			}
		}

		[Token(Token = "0x6004C24")]
		[Address(RVA = "0x233A4E0", Offset = "0x233A4E0", VA = "0x233A4E0")]
		public LimitItemPurchasedList()
		{
		}

		[Token(Token = "0x6004C27")]
		[Address(RVA = "0x233A59C", Offset = "0x233A59C", VA = "0x233A59C")]
		public void CleanUp()
		{
		}

		[Token(Token = "0x6004C28")]
		[Address(RVA = "0x233AB4C", Offset = "0x233AB4C", VA = "0x233AB4C")]
		public int GetBoughtCount(string ProductId)
		{
			return default(int);
		}

		[Token(Token = "0x6004C29")]
		[Address(RVA = "0x233AC1C", Offset = "0x233AC1C", VA = "0x233AC1C")]
		public bool IncreaseBoughtCount(string ProductId, DateTime ExpireTime, int MaxCount, int Count = 1)
		{
			return default(bool);
		}
	}
}
