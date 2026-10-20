using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x200096B")]
	public class CompletedClanMember
	{
		[Token(Token = "0x4002E9A")]
		[FieldOffset(Offset = "0x8")]
		private ClanMember clanData__BackingField;

		[Token(Token = "0x4002E9B")]
		[FieldOffset(Offset = "0xC")]
		private ClanMemberMetaData MetaData__BackingField;

		[Token(Token = "0x17000ABE")]
		public ClanMember clanData
		{
			[Token(Token = "0x6004BDB")]
			[Address(RVA = "0x23EC8F0", Offset = "0x23EC8F0", VA = "0x23EC8F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004BDC")]
			[Address(RVA = "0x23EC8C4", Offset = "0x23EC8C4", VA = "0x23EC8C4")]
			set
			{
			}
		}

		[Token(Token = "0x17000ABF")]
		public ClanMemberMetaData MetaData
		{
			[Token(Token = "0x6004BDD")]
			[Address(RVA = "0x23EC8F8", Offset = "0x23EC8F8", VA = "0x23EC8F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004BDE")]
			[Address(RVA = "0x23EC900", Offset = "0x23EC900", VA = "0x23EC900")]
			set
			{
			}
		}

		[Token(Token = "0x6004BD9")]
		[Address(RVA = "0x23EC82C", Offset = "0x23EC82C", VA = "0x23EC82C")]
		public CompletedClanMember()
		{
		}

		[Token(Token = "0x6004BDA")]
		[Address(RVA = "0x23EC8CC", Offset = "0x23EC8CC", VA = "0x23EC8CC")]
		public CompletedClanMember(ClanMemberMetaData metaData)
		{
		}

		[Token(Token = "0x6004BDF")]
		[Address(RVA = "0x23EC8E8", Offset = "0x23EC8E8", VA = "0x23EC8E8")]
		internal void SetUserMetaData(ClanMemberMetaData metaData)
		{
		}
	}
}
