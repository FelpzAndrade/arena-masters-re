using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000954")]
	public class ContinuousItem
	{
		[Token(Token = "0x4002E3B")]
		[FieldOffset(Offset = "0x8")]
		private Dictionary<int, PremiumTicketData> DicPremiumTicket__BackingField;

		[Token(Token = "0x4002E3C")]
		[FieldOffset(Offset = "0x0")]
		private static Func<PremiumTicketData, int> _003C_003Ef__am_0024cache1;

		[Token(Token = "0x4002E3D")]
		[FieldOffset(Offset = "0x4")]
		private static Func<PremiumTicketData, DateTime> _003C_003Ef__am_0024cache2;

		[Token(Token = "0x17000A71")]
		public Dictionary<int, PremiumTicketData> DicPremiumTicket
		{
			[Token(Token = "0x6004AF0")]
			[Address(RVA = "0x23ED740", Offset = "0x23ED740", VA = "0x23ED740")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004AF1")]
			[Address(RVA = "0x23ED738", Offset = "0x23ED738", VA = "0x23ED738")]
			set
			{
			}
		}

		[Token(Token = "0x6004AEF")]
		[Address(RVA = "0x23ED68C", Offset = "0x23ED68C", VA = "0x23ED68C")]
		public ContinuousItem()
		{
		}

		[Token(Token = "0x6004AF2")]
		[Address(RVA = "0x23ED748", Offset = "0x23ED748", VA = "0x23ED748")]
		public bool ExistTicket(int ticketID)
		{
			return default(bool);
		}

		[Token(Token = "0x6004AF3")]
		[Address(RVA = "0x23ED7E8", Offset = "0x23ED7E8", VA = "0x23ED7E8")]
		public bool TryGetPermiumTicketData(int ticketID, out PremiumTicketData permiumTicket)
		{
			permiumTicket = default;
			return default(bool);
		}

		[Token(Token = "0x6004AF4")]
		[Address(RVA = "0x23ED890", Offset = "0x23ED890", VA = "0x23ED890")]
		public int GetTakeCount(int ticketID)
		{
			return default(int);
		}

		[Token(Token = "0x6004AF5")]
		[Address(RVA = "0x23ED95C", Offset = "0x23ED95C", VA = "0x23ED95C")]
		public void DeleteAll()
		{
		}

		[Token(Token = "0x6004AF6")]
		[Address(RVA = "0x23ED9F4", Offset = "0x23ED9F4", VA = "0x23ED9F4")]
		public void Add(int premiumTicketId, DateTime nowTime)
		{
		}

		[Token(Token = "0x6004AF7")]
		[Address(RVA = "0x23EDB10", Offset = "0x23EDB10", VA = "0x23EDB10")]
		public void Remove(int premiumTicketId)
		{
		}

		[Token(Token = "0x6004AF8")]
		[Address(RVA = "0x23EDBB0", Offset = "0x23EDBB0", VA = "0x23EDBB0")]
		public int GetCount()
		{
			return default(int);
		}

		[Token(Token = "0x6004AF9")]
		[Address(RVA = "0x23EDC48", Offset = "0x23EDC48", VA = "0x23EDC48")]
		public Dictionary<int, DateTime> GetTicketTimes()
		{
			return null;
		}

		[Token(Token = "0x6004AFA")]
		[Address(RVA = "0x23EDE28", Offset = "0x23EDE28", VA = "0x23EDE28")]
		private static int _003CGetTicketTimes_003Em__1F4(PremiumTicketData item)
		{
			return default(int);
		}

		[Token(Token = "0x6004AFB")]
		[Address(RVA = "0x23EDE54", Offset = "0x23EDE54", VA = "0x23EDE54")]
		private static DateTime _003CGetTicketTimes_003Em__1F5(PremiumTicketData item)
		{
			return default(DateTime);
		}
	}
}
