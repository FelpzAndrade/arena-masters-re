using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x20008CF")]
	public static class Version
	{
		[Token(Token = "0x4002AE8")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int Major;

		[Token(Token = "0x4002AE9")]
		[FieldOffset(Offset = "0x4")]
		public static int Minor;

		[Token(Token = "0x4002AEA")]
		[FieldOffset(Offset = "0x8")]
		public static int AssetBundle;

		[Token(Token = "0x4002AEB")]
		[FieldOffset(Offset = "0xC")]
		public static int LocalGameData;

		[Token(Token = "0x4002AEC")]
		[FieldOffset(Offset = "0x10")]
		public static int ServerGameData;
	}
}
