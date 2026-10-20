using Il2CppDummyDll;

namespace DTOPhoton
{
	[Token(Token = "0x200083C")]
	public class DTOFinishExitDuringTheGameData
	{
		[Token(Token = "0x40023AF")]
		[FieldOffset(Offset = "0x8")]
		public string Name;

		[Token(Token = "0x40023B0")]
		[FieldOffset(Offset = "0xC")]
		public int Rank;

		[Token(Token = "0x60041F6")]
		[Address(RVA = "0x1E659EC", Offset = "0x1E659EC", VA = "0x1E659EC")]
		public DTOFinishExitDuringTheGameData()
		{
		}
	}
}
