using System;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000A9D")]
	public sealed class CharAnimInfo
	{
		[Token(Token = "0x4003179")]
		[FieldOffset(Offset = "0x8")]
		public string char_key;

		[Token(Token = "0x400317A")]
		[FieldOffset(Offset = "0xC")]
		public AniCategoryType category;

		[Token(Token = "0x400317B")]
		[FieldOffset(Offset = "0x10")]
		public string ani_key;

		[Token(Token = "0x400317C")]
		[FieldOffset(Offset = "0x14")]
		public int skin_id;

		[Token(Token = "0x400317D")]
		[FieldOffset(Offset = "0x18")]
		public string strResourcePath;

		[Token(Token = "0x400317E")]
		[FieldOffset(Offset = "0x1C")]
		public string strResourceName;

		[Token(Token = "0x6004E4B")]
		[Address(RVA = "0x23E82A0", Offset = "0x23E82A0", VA = "0x23E82A0")]
		public CharAnimInfo()
		{
		}

		[Token(Token = "0x6004E4C")]
		[Address(RVA = "0x23E83AC", Offset = "0x23E83AC", VA = "0x23E83AC")]
		public string GetResourceFullPathName()
		{
			return null;
		}
	}
}
