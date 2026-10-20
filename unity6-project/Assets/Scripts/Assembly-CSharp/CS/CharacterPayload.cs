using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000889")]
	public class CharacterPayload
	{
		[Token(Token = "0x400294A")]
		[FieldOffset(Offset = "0x8")]
		public string uid;

		[Token(Token = "0x400294B")]
		[FieldOffset(Offset = "0xC")]
		public int id;

		[Token(Token = "0x400294C")]
		[FieldOffset(Offset = "0x10")]
		public int level;

		[Token(Token = "0x400294D")]
		[FieldOffset(Offset = "0x14")]
		public int xp;

		[Token(Token = "0x60045CE")]
		[Address(RVA = "0x23E8298", Offset = "0x23E8298", VA = "0x23E8298")]
		public CharacterPayload()
		{
		}
	}
}
