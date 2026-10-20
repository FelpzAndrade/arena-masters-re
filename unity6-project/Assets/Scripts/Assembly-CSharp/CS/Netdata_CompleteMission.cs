using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x20009D3")]
	public class Netdata_CompleteMission
	{
		[Token(Token = "0x4002FA7")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string String;

		[Token(Token = "0x4002FA8")]
		[FieldOffset(Offset = "0x8")]
		public CSContentReward teamExp;

		[Token(Token = "0x4002FA9")]
		[FieldOffset(Offset = "0xC")]
		public CSContentReward gold;

		[Token(Token = "0x4002FAA")]
		[FieldOffset(Offset = "0x10")]
		public List<CSContentReward> dropGachaList;

		[Token(Token = "0x4002FAB")]
		[FieldOffset(Offset = "0x14")]
		public CSContentReward firstClear;

		[Token(Token = "0x4002FAC")]
		[FieldOffset(Offset = "0x18")]
		public CSContentReward clearTicket;

		[Token(Token = "0x4002FAD")]
		[FieldOffset(Offset = "0x1C")]
		public bool isMail;

		[Token(Token = "0x4002FAE")]
		[FieldOffset(Offset = "0x1D")]
		public bool isUseItemBooster;

		[Token(Token = "0x4002FAF")]
		[FieldOffset(Offset = "0x1E")]
		public bool isUseGoldBooster;

		[Token(Token = "0x4002FB0")]
		[FieldOffset(Offset = "0x1F")]
		public bool isUsePromstoneBooster;

		[Token(Token = "0x6004D13")]
		[Address(RVA = "0x233FBDC", Offset = "0x233FBDC", VA = "0x233FBDC")]
		public Netdata_CompleteMission()
		{
		}
	}
}
