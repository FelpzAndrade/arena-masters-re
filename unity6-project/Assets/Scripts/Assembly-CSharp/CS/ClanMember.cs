using System;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x200096C")]
	public class ClanMember
	{
		[Token(Token = "0x4002E9C")]
		[FieldOffset(Offset = "0x8")]
		public ClanMemberSeasonRecord PreClanWarReward;

		[Token(Token = "0x4002E9D")]
		[FieldOffset(Offset = "0xC")]
		public ClanMemberSeasonRecord CurClanWarReward;

		[Token(Token = "0x4002E9E")]
		[FieldOffset(Offset = "0x10")]
		public ClanMemberSeasonRecord PreClanBoxReward;

		[Token(Token = "0x4002E9F")]
		[FieldOffset(Offset = "0x14")]
		public ClanMemberSeasonRecord CurClanBoxReward;

		[Token(Token = "0x4002EA0")]
		[FieldOffset(Offset = "0x18")]
		private string Name__BackingField;

		[Token(Token = "0x4002EA1")]
		[FieldOffset(Offset = "0x1C")]
		private int Contribution__BackingField;

		[Token(Token = "0x4002EA2")]
		[FieldOffset(Offset = "0x20")]
		private DateTime RegistTime__BackingField;

		[Token(Token = "0x4002EA3")]
		[FieldOffset(Offset = "0x30")]
		private ClanMemberGrade Grade__BackingField;

		[Token(Token = "0x17000AC0")]
		public string Name
		{
			[Token(Token = "0x6004BE1")]
			[Address(RVA = "0x23EB7CC", Offset = "0x23EB7CC", VA = "0x23EB7CC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004BE2")]
			[Address(RVA = "0x23EB7D4", Offset = "0x23EB7D4", VA = "0x23EB7D4")]
			set
			{
			}
		}

		[Token(Token = "0x17000AC1")]
		public int Contribution
		{
			[Token(Token = "0x6004BE3")]
			[Address(RVA = "0x23EB7DC", Offset = "0x23EB7DC", VA = "0x23EB7DC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004BE4")]
			[Address(RVA = "0x23EB7E4", Offset = "0x23EB7E4", VA = "0x23EB7E4")]
			set
			{
			}
		}

		[Token(Token = "0x17000AC2")]
		public DateTime RegistTime
		{
			[Token(Token = "0x6004BE5")]
			[Address(RVA = "0x23EB7EC", Offset = "0x23EB7EC", VA = "0x23EB7EC")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x6004BE6")]
			[Address(RVA = "0x23EB7FC", Offset = "0x23EB7FC", VA = "0x23EB7FC")]
			set
			{
			}
		}

		[Token(Token = "0x17000AC3")]
		public ClanMemberGrade Grade
		{
			[Token(Token = "0x6004BE7")]
			[Address(RVA = "0x23EB814", Offset = "0x23EB814", VA = "0x23EB814")]
			get
			{
				return default(ClanMemberGrade);
			}
			[Token(Token = "0x6004BE8")]
			[Address(RVA = "0x23EB81C", Offset = "0x23EB81C", VA = "0x23EB81C")]
			set
			{
			}
		}

		[Token(Token = "0x6004BE0")]
		[Address(RVA = "0x23EB6E0", Offset = "0x23EB6E0", VA = "0x23EB6E0")]
		public ClanMember()
		{
		}
	}
}
