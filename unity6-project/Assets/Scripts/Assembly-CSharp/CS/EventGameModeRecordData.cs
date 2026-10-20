using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000955")]
	public class EventGameModeRecordData
	{
		[Token(Token = "0x4002E3E")]
		[FieldOffset(Offset = "0x8")]
		public bool IsPayedEnterCost;

		[Token(Token = "0x4002E3F")]
		[FieldOffset(Offset = "0xA")]
		public short ELO;

		[Token(Token = "0x4002E40")]
		[FieldOffset(Offset = "0xC")]
		public short DefaultELO;

		[Token(Token = "0x4002E41")]
		[FieldOffset(Offset = "0x10")]
		private DateTime ExpireAt__BackingField;

		[Token(Token = "0x4002E42")]
		[FieldOffset(Offset = "0x20")]
		private int FailCount__BackingField;

		[Token(Token = "0x4002E43")]
		[FieldOffset(Offset = "0x24")]
		private int RepeatCount__BackingField;

		[Token(Token = "0x4002E44")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<ConditionType, int> MilestoneRecieveDic__BackingField;

		[Token(Token = "0x4002E45")]
		[FieldOffset(Offset = "0x2C")]
		private Dictionary<ConditionType, int> FirstRecieveDic__BackingField;

		[Token(Token = "0x4002E46")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<ConditionType, int> TotalRecieveDic__BackingField;

		[Token(Token = "0x4002E47")]
		[FieldOffset(Offset = "0x0")]
		private static Func<Dictionary<ConditionType, int>, string> _003C_003Ef__am_0024cache9;

		[Token(Token = "0x17000A72")]
		public DateTime ExpireAt
		{
			[Token(Token = "0x6004AFD")]
			[Address(RVA = "0x1CDE5BC", Offset = "0x1CDE5BC", VA = "0x1CDE5BC")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x6004AFE")]
			[Address(RVA = "0x1CDD98C", Offset = "0x1CDD98C", VA = "0x1CDD98C")]
			set
			{
			}
		}

		[Token(Token = "0x17000A73")]
		public int FailCount
		{
			[Token(Token = "0x6004AFF")]
			[Address(RVA = "0x1CDDDE4", Offset = "0x1CDDDE4", VA = "0x1CDDDE4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004B00")]
			[Address(RVA = "0x1CDDF3C", Offset = "0x1CDDF3C", VA = "0x1CDDF3C")]
			set
			{
			}
		}

		[Token(Token = "0x17000A74")]
		public int RepeatCount
		{
			[Token(Token = "0x6004B01")]
			[Address(RVA = "0x1CDDF64", Offset = "0x1CDDF64", VA = "0x1CDDF64")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004B02")]
			[Address(RVA = "0x1CDE030", Offset = "0x1CDE030", VA = "0x1CDE030")]
			set
			{
			}
		}

		[Token(Token = "0x17000A75")]
		public Dictionary<ConditionType, int> MilestoneRecieveDic
		{
			[Token(Token = "0x6004B03")]
			[Address(RVA = "0x1CDDB60", Offset = "0x1CDDB60", VA = "0x1CDDB60")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004B04")]
			[Address(RVA = "0x1CDEC04", Offset = "0x1CDEC04", VA = "0x1CDEC04")]
			set
			{
			}
		}

		[Token(Token = "0x17000A76")]
		public Dictionary<ConditionType, int> FirstRecieveDic
		{
			[Token(Token = "0x6004B05")]
			[Address(RVA = "0x1CDDB68", Offset = "0x1CDDB68", VA = "0x1CDDB68")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004B06")]
			[Address(RVA = "0x1CDEC0C", Offset = "0x1CDEC0C", VA = "0x1CDEC0C")]
			set
			{
			}
		}

		[Token(Token = "0x17000A77")]
		public Dictionary<ConditionType, int> TotalRecieveDic
		{
			[Token(Token = "0x6004B07")]
			[Address(RVA = "0x1CDDB70", Offset = "0x1CDDB70", VA = "0x1CDDB70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004B08")]
			[Address(RVA = "0x1CDEC14", Offset = "0x1CDEC14", VA = "0x1CDEC14")]
			set
			{
			}
		}

		[Token(Token = "0x6004AFC")]
		[Address(RVA = "0x1CDD8B0", Offset = "0x1CDD8B0", VA = "0x1CDD8B0")]
		public EventGameModeRecordData()
		{
		}

		[Token(Token = "0x6004B09")]
		[Address(RVA = "0x1CDEC1C", Offset = "0x1CDEC1C", VA = "0x1CDEC1C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6004B0A")]
		[Address(RVA = "0x1CDECCC", Offset = "0x1CDECCC", VA = "0x1CDECCC")]
		public string TryRecordToString(string prefix)
		{
			return null;
		}

		[Token(Token = "0x6004B0B")]
		[Address(RVA = "0x1CDEF6C", Offset = "0x1CDEF6C", VA = "0x1CDEF6C")]
		private static string _003CTryRecordToString_003Em__1F6(Dictionary<ConditionType, int> dic)
		{
			return null;
		}
	}
}
