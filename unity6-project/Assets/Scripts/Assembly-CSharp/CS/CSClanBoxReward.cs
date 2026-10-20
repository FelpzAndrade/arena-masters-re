using System;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000AAB")]
	public class CSClanBoxReward
	{
		[Token(Token = "0x400321F")]
		[FieldOffset(Offset = "0x8")]
		public int groupId;

		[Token(Token = "0x4003220")]
		[FieldOffset(Offset = "0xC")]
		public int id;

		[Token(Token = "0x4003221")]
		[FieldOffset(Offset = "0x10")]
		public int nextTrophy;

		[Token(Token = "0x4003222")]
		[FieldOffset(Offset = "0x14")]
		public CSContentType contentType;

		[Token(Token = "0x4003223")]
		[FieldOffset(Offset = "0x18")]
		public int contentId;

		[Token(Token = "0x4003224")]
		[FieldOffset(Offset = "0x1C")]
		public int contentCount;

		[Token(Token = "0x4003225")]
		[FieldOffset(Offset = "0x20")]
		public int showBoxID;

		[Token(Token = "0x4003226")]
		[FieldOffset(Offset = "0x24")]
		public string boxIconPath;

		[Token(Token = "0x6004E99")]
		[Address(RVA = "0x22288E0", Offset = "0x22288E0", VA = "0x22288E0")]
		public CSClanBoxReward()
		{
		}

		[Token(Token = "0x6004E9A")]
		[Address(RVA = "0x222896C", Offset = "0x222896C", VA = "0x222896C")]
		public bool Cooking()
		{
			return default(bool);
		}
	}
}
