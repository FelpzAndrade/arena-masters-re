using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000951")]
	public class ClanRankingList
	{
		[Token(Token = "0x4002E2C")]
		[FieldOffset(Offset = "0x8")]
		private int Season__BackingField;

		[Token(Token = "0x4002E2D")]
		[FieldOffset(Offset = "0xC")]
		private List<ClanRankMetaData> list__BackingField;

		[Token(Token = "0x4002E2E")]
		[FieldOffset(Offset = "0x10")]
		private int Page__BackingField;

		[Token(Token = "0x4002E2F")]
		[FieldOffset(Offset = "0x14")]
		private int ViewCount__BackingField;

		[Token(Token = "0x4002E30")]
		[FieldOffset(Offset = "0x18")]
		private int TotalCount__BackingField;

		[Token(Token = "0x4002E31")]
		[FieldOffset(Offset = "0x1C")]
		private int TopScoreTieCount__BackingField;

		[Token(Token = "0x4002E32")]
		[FieldOffset(Offset = "0x20")]
		private RankListViewType ViewType__BackingField;

		[Token(Token = "0x17000A62")]
		public int Season
		{
			[Token(Token = "0x6004AC7")]
			[Address(RVA = "0x23EBB04", Offset = "0x23EBB04", VA = "0x23EBB04")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004AC8")]
			[Address(RVA = "0x23EBB0C", Offset = "0x23EBB0C", VA = "0x23EBB0C")]
			set
			{
			}
		}

		[Token(Token = "0x17000A63")]
		public List<ClanRankMetaData> list
		{
			[Token(Token = "0x6004AC9")]
			[Address(RVA = "0x23EBB14", Offset = "0x23EBB14", VA = "0x23EBB14")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004ACA")]
			[Address(RVA = "0x23EBB1C", Offset = "0x23EBB1C", VA = "0x23EBB1C")]
			set
			{
			}
		}

		[Token(Token = "0x17000A64")]
		public int Page
		{
			[Token(Token = "0x6004ACB")]
			[Address(RVA = "0x23EBB24", Offset = "0x23EBB24", VA = "0x23EBB24")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004ACC")]
			[Address(RVA = "0x23EBB2C", Offset = "0x23EBB2C", VA = "0x23EBB2C")]
			set
			{
			}
		}

		[Token(Token = "0x17000A65")]
		public int ViewCount
		{
			[Token(Token = "0x6004ACD")]
			[Address(RVA = "0x23EBB34", Offset = "0x23EBB34", VA = "0x23EBB34")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004ACE")]
			[Address(RVA = "0x23EBB3C", Offset = "0x23EBB3C", VA = "0x23EBB3C")]
			set
			{
			}
		}

		[Token(Token = "0x17000A66")]
		public int TotalCount
		{
			[Token(Token = "0x6004ACF")]
			[Address(RVA = "0x23EBB44", Offset = "0x23EBB44", VA = "0x23EBB44")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004AD0")]
			[Address(RVA = "0x23EBB4C", Offset = "0x23EBB4C", VA = "0x23EBB4C")]
			set
			{
			}
		}

		[Token(Token = "0x17000A67")]
		public int TopScoreTieCount
		{
			[Token(Token = "0x6004AD1")]
			[Address(RVA = "0x23EBB54", Offset = "0x23EBB54", VA = "0x23EBB54")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004AD2")]
			[Address(RVA = "0x23EBB5C", Offset = "0x23EBB5C", VA = "0x23EBB5C")]
			set
			{
			}
		}

		[Token(Token = "0x17000A68")]
		public RankListViewType ViewType
		{
			[Token(Token = "0x6004AD3")]
			[Address(RVA = "0x23EBB64", Offset = "0x23EBB64", VA = "0x23EBB64")]
			get
			{
				return default(RankListViewType);
			}
			[Token(Token = "0x6004AD4")]
			[Address(RVA = "0x23EBB6C", Offset = "0x23EBB6C", VA = "0x23EBB6C")]
			set
			{
			}
		}

		[Token(Token = "0x6004AC6")]
		[Address(RVA = "0x23EBAFC", Offset = "0x23EBAFC", VA = "0x23EBAFC")]
		public ClanRankingList()
		{
		}
	}
}
