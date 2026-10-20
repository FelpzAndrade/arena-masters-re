using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x200040E")]
public class DTUpdateClanPartyList
{
	[Token(Token = "0x4001414")]
	[FieldOffset(Offset = "0x8")]
	public List<DTPartyInfo> PartyList;

	[Token(Token = "0x4001415")]
	[FieldOffset(Offset = "0xC")]
	public List<long> DeleteList;

	[Token(Token = "0x4001416")]
	[FieldOffset(Offset = "0x10")]
	public long TimeStamp;

	[Token(Token = "0x6002128")]
	[Address(RVA = "0x1E676EC", Offset = "0x1E676EC", VA = "0x1E676EC")]
	public DTUpdateClanPartyList()
	{
	}

	[Token(Token = "0x6002129")]
	[Address(RVA = "0x1E67838", Offset = "0x1E67838", VA = "0x1E67838")]
	public DTUpdateClanPartyList(List<DTPartyInfo> list, List<long> liDelParty, long timeStamp)
	{
	}
}
