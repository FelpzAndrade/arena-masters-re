using System;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000953")]
	public class PremiumTicketData
	{
		[Token(Token = "0x4002E36")]
		[FieldOffset(Offset = "0x8")]
		public IncreasableDictionary<CSContentType> TakenCurrency;

		[Token(Token = "0x4002E37")]
		[FieldOffset(Offset = "0xC")]
		private int TicketID__BackingField;

		[Token(Token = "0x4002E38")]
		[FieldOffset(Offset = "0x10")]
		private DateTime StartTime__BackingField;

		[Token(Token = "0x4002E39")]
		[FieldOffset(Offset = "0x20")]
		private int TakeCount__BackingField;

		[Token(Token = "0x4002E3A")]
		[FieldOffset(Offset = "0x28")]
		private DateTime LastTakeTime__BackingField;

		[Token(Token = "0x17000A6D")]
		public int TicketID
		{
			[Token(Token = "0x6004AE2")]
			[Address(RVA = "0x21AE804", Offset = "0x21AE804", VA = "0x21AE804")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004AE3")]
			[Address(RVA = "0x21AE678", Offset = "0x21AE678", VA = "0x21AE678")]
			set
			{
			}
		}

		[Token(Token = "0x17000A6E")]
		public DateTime StartTime
		{
			[Token(Token = "0x6004AE4")]
			[Address(RVA = "0x21AE80C", Offset = "0x21AE80C", VA = "0x21AE80C")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x6004AE5")]
			[Address(RVA = "0x21AE688", Offset = "0x21AE688", VA = "0x21AE688")]
			set
			{
			}
		}

		[Token(Token = "0x17000A6F")]
		public int TakeCount
		{
			[Token(Token = "0x6004AE6")]
			[Address(RVA = "0x21AE81C", Offset = "0x21AE81C", VA = "0x21AE81C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004AE7")]
			[Address(RVA = "0x21AE680", Offset = "0x21AE680", VA = "0x21AE680")]
			set
			{
			}
		}

		[Token(Token = "0x17000A70")]
		public DateTime LastTakeTime
		{
			[Token(Token = "0x6004AE8")]
			[Address(RVA = "0x21AE824", Offset = "0x21AE824", VA = "0x21AE824")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x6004AE9")]
			[Address(RVA = "0x21AE6A0", Offset = "0x21AE6A0", VA = "0x21AE6A0")]
			set
			{
			}
		}

		[Token(Token = "0x6004AE0")]
		[Address(RVA = "0x21AE4E8", Offset = "0x21AE4E8", VA = "0x21AE4E8")]
		public PremiumTicketData()
		{
		}

		[Token(Token = "0x6004AE1")]
		[Address(RVA = "0x21AE6B8", Offset = "0x21AE6B8", VA = "0x21AE6B8")]
		public PremiumTicketData(int ticketID, DateTime regTime)
		{
		}

		[Token(Token = "0x6004AEA")]
		[Address(RVA = "0x21AE834", Offset = "0x21AE834", VA = "0x21AE834")]
		public void AddStartDay(double addDays)
		{
		}

		[Token(Token = "0x6004AEB")]
		[Address(RVA = "0x21AE874", Offset = "0x21AE874", VA = "0x21AE874")]
		public void AddStartHours(double addHours)
		{
		}

		[Token(Token = "0x6004AEC")]
		[Address(RVA = "0x21AE8B4", Offset = "0x21AE8B4", VA = "0x21AE8B4")]
		public void AddStartMins(double addMins)
		{
		}

		[Token(Token = "0x6004AED")]
		[Address(RVA = "0x21AE8F4", Offset = "0x21AE8F4", VA = "0x21AE8F4")]
		public void Take(DateTime now)
		{
		}

		[Token(Token = "0x6004AEE")]
		[Address(RVA = "0x21AE918", Offset = "0x21AE918", VA = "0x21AE918")]
		public string GetStatKey()
		{
			return null;
		}
	}
}
