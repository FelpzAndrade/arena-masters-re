using System;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000967")]
	public class LastStartedGame
	{
		[Token(Token = "0x4002E81")]
		[FieldOffset(Offset = "0x8")]
		private XGameModeType Mode__BackingField;

		[Token(Token = "0x4002E82")]
		[FieldOffset(Offset = "0xC")]
		private string GameId__BackingField;

		[Token(Token = "0x4002E83")]
		[FieldOffset(Offset = "0x10")]
		private int SectorId__BackingField;

		[Token(Token = "0x4002E84")]
		[FieldOffset(Offset = "0x14")]
		private int EnemyELO__BackingField;

		[Token(Token = "0x4002E85")]
		[FieldOffset(Offset = "0x18")]
		private string Char1__BackingField;

		[Token(Token = "0x4002E86")]
		[FieldOffset(Offset = "0x1C")]
		private string Char2__BackingField;

		[Token(Token = "0x4002E87")]
		[FieldOffset(Offset = "0x20")]
		private DateTime StartTime__BackingField;

		[Token(Token = "0x17000AAE")]
		public XGameModeType Mode
		{
			[Token(Token = "0x6004BB6")]
			[Address(RVA = "0x233A3B8", Offset = "0x233A3B8", VA = "0x233A3B8")]
			get
			{
				return default(XGameModeType);
			}
			[Token(Token = "0x6004BB7")]
			[Address(RVA = "0x233A3C0", Offset = "0x233A3C0", VA = "0x233A3C0")]
			set
			{
			}
		}

		[Token(Token = "0x17000AAF")]
		public string GameId
		{
			[Token(Token = "0x6004BB8")]
			[Address(RVA = "0x233A3C8", Offset = "0x233A3C8", VA = "0x233A3C8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004BB9")]
			[Address(RVA = "0x233A3D0", Offset = "0x233A3D0", VA = "0x233A3D0")]
			set
			{
			}
		}

		[Token(Token = "0x17000AB0")]
		public int SectorId
		{
			[Token(Token = "0x6004BBA")]
			[Address(RVA = "0x233A3D8", Offset = "0x233A3D8", VA = "0x233A3D8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004BBB")]
			[Address(RVA = "0x233A3E0", Offset = "0x233A3E0", VA = "0x233A3E0")]
			set
			{
			}
		}

		[Token(Token = "0x17000AB1")]
		public int EnemyELO
		{
			[Token(Token = "0x6004BBC")]
			[Address(RVA = "0x233A3E8", Offset = "0x233A3E8", VA = "0x233A3E8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004BBD")]
			[Address(RVA = "0x233A3F0", Offset = "0x233A3F0", VA = "0x233A3F0")]
			set
			{
			}
		}

		[Token(Token = "0x17000AB2")]
		public string Char1
		{
			[Token(Token = "0x6004BBE")]
			[Address(RVA = "0x233A3F8", Offset = "0x233A3F8", VA = "0x233A3F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004BBF")]
			[Address(RVA = "0x233A400", Offset = "0x233A400", VA = "0x233A400")]
			set
			{
			}
		}

		[Token(Token = "0x17000AB3")]
		public string Char2
		{
			[Token(Token = "0x6004BC0")]
			[Address(RVA = "0x233A408", Offset = "0x233A408", VA = "0x233A408")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004BC1")]
			[Address(RVA = "0x233A410", Offset = "0x233A410", VA = "0x233A410")]
			set
			{
			}
		}

		[Token(Token = "0x17000AB4")]
		public DateTime StartTime
		{
			[Token(Token = "0x6004BC2")]
			[Address(RVA = "0x233A418", Offset = "0x233A418", VA = "0x233A418")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x6004BC3")]
			[Address(RVA = "0x233A428", Offset = "0x233A428", VA = "0x233A428")]
			set
			{
			}
		}

		[Token(Token = "0x6004BB5")]
		[Address(RVA = "0x233A3B0", Offset = "0x233A3B0", VA = "0x233A3B0")]
		public LastStartedGame()
		{
		}

		[Token(Token = "0x6004BC4")]
		[Address(RVA = "0x233A440", Offset = "0x233A440", VA = "0x233A440")]
		public void Set(XGameModeType Mode, string GameId, int SectorId, int EnemyELO, string Char1, string Char2, DateTime StartTime)
		{
		}
	}
}
