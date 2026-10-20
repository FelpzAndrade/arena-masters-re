using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000AB8")]
	public class CraftInfo
	{
		[Token(Token = "0x4003240")]
		[FieldOffset(Offset = "0x8")]
		public int nID;

		[Token(Token = "0x4003241")]
		[FieldOffset(Offset = "0xC")]
		public CSContentType resultContentType;

		[Token(Token = "0x4003242")]
		[FieldOffset(Offset = "0x10")]
		public int resultContentID;

		[Token(Token = "0x4003243")]
		[FieldOffset(Offset = "0x14")]
		public int resultContentCount;

		[Token(Token = "0x4003244")]
		[FieldOffset(Offset = "0x18")]
		public int materialID1;

		[Token(Token = "0x4003245")]
		[FieldOffset(Offset = "0x1C")]
		public int materialCount1;

		[Token(Token = "0x6004ED3")]
		[Address(RVA = "0x23EDF50", Offset = "0x23EDF50", VA = "0x23EDF50")]
		public CraftInfo()
		{
		}

		[Token(Token = "0x6004ED4")]
		[Address(RVA = "0x23EDF58", Offset = "0x23EDF58", VA = "0x23EDF58")]
		public CSContent GetResultContent()
		{
			return null;
		}

		[Token(Token = "0x6004ED5")]
		[Address(RVA = "0x23EE010", Offset = "0x23EE010", VA = "0x23EE010")]
		public CSContent GetMaterialContent()
		{
			return null;
		}
	}
}
