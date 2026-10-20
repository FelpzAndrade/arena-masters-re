using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000995")]
	public class NetData_TeamInfo
	{
		[Token(Token = "0x4002F66")]
		[FieldOffset(Offset = "0x8")]
		public string aid;

		[Token(Token = "0x4002F67")]
		[FieldOffset(Offset = "0xC")]
		public string nickname;

		[Token(Token = "0x4002F68")]
		[FieldOffset(Offset = "0x10")]
		public int team;

		[Token(Token = "0x6004CD3")]
		[Address(RVA = "0x23404B4", Offset = "0x23404B4", VA = "0x23404B4")]
		public NetData_TeamInfo()
		{
		}
	}
}
