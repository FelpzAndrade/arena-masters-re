using System;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x20003E1")]
public class XClanInviteChatMessageObject : XChatMessageObject
{
	[Token(Token = "0x20003E2")]
	public enum ClanInviteState
	{
		[Token(Token = "0x4001386")]
		None = 0,
		[Token(Token = "0x4001387")]
		CreateRoom = 1,
		[Token(Token = "0x4001388")]
		Join = 2,
		[Token(Token = "0x4001389")]
		UpdateMember = 3,
		[Token(Token = "0x400138A")]
		Matching = 4,
		[Token(Token = "0x400138B")]
		BreakRoom = 5
	}

	[Token(Token = "0x4001381")]
	[FieldOffset(Offset = "0x28")]
	public long PartyKey;

	[Token(Token = "0x4001382")]
	[FieldOffset(Offset = "0x30")]
	public DTPartyInfoForChat PartyInfo;

	[Token(Token = "0x4001383")]
	[FieldOffset(Offset = "0x34")]
	public ClanInviteState State;

	[Token(Token = "0x4001384")]
	[FieldOffset(Offset = "0x38")]
	public bool RefreshOnly;

	[Token(Token = "0x6001FB6")]
	[Address(RVA = "0x1AC5844", Offset = "0x1AC5844", VA = "0x1AC5844")]
	public XClanInviteChatMessageObject()
	{
	}

	[Token(Token = "0x6001FB7")]
	[Address(RVA = "0x1AC584C", Offset = "0x1AC584C", VA = "0x1AC584C")]
	public bool IsMaxParty()
	{
		return default(bool);
	}

	[Token(Token = "0x6001FB8")]
	[Address(RVA = "0x1AC594C", Offset = "0x1AC594C", VA = "0x1AC594C")]
	public static XClanInviteChatMessageObject MakeClanInviteChatMessage(ClanInviteState state, DTPartyInfo party)
	{
		return null;
	}

	[Token(Token = "0x6001FB9")]
	[Address(RVA = "0x1AC5B84", Offset = "0x1AC5B84", VA = "0x1AC5B84")]
	public static XClanInviteChatMessageObject MakeClanInviteChatMessage(ClanInviteState state, long partyKey)
	{
		return null;
	}
}
