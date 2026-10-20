using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using NPA;

[Token(Token = "0x200103D")]
public class XUISnsFriendInvite : UIBase, IToyFacebookListener
{
	[Token(Token = "0x6007932")]
	[Address(RVA = "0x192F7F4", Offset = "0x192F7F4", VA = "0x192F7F4")]
	public XUISnsFriendInvite()
	{
	}

	[Token(Token = "0x6007933")]
	[Address(RVA = "0x192F7FC", Offset = "0x192F7FC", VA = "0x192F7FC", Slot = "9")]
	public override void Show()
	{
	}

	[Token(Token = "0x6007934")]
	[Address(RVA = "0x192F8DC", Offset = "0x192F8DC", VA = "0x192F8DC", Slot = "11")]
	public override void Hide()
	{
	}

	[Token(Token = "0x6007935")]
	[Address(RVA = "0x192F9BC", Offset = "0x192F9BC", VA = "0x192F9BC")]
	public void OnClick_Invite()
	{
	}

	[Token(Token = "0x6007936")]
	[Address(RVA = "0x192FA20", Offset = "0x192FA20", VA = "0x192FA20", Slot = "13")]
	public void OnResponseConnect(NPErrorCode errno)
	{
	}

	[Token(Token = "0x6007937")]
	[Address(RVA = "0x192FA24", Offset = "0x192FA24", VA = "0x192FA24", Slot = "14")]
	public void OnResponseFriendList(ApiReturnCode errno, List<FacebookFriend> appendfriends)
	{
	}

	[Token(Token = "0x6007938")]
	[Address(RVA = "0x192FA28", Offset = "0x192FA28", VA = "0x192FA28", Slot = "15")]
	public void OnResponseError(NPErrorCode errno)
	{
	}

	[Token(Token = "0x6007939")]
	[Address(RVA = "0x192FAD0", Offset = "0x192FAD0", VA = "0x192FAD0", Slot = "16")]
	public void OnResponseError(ApiReturnCode errno)
	{
	}
}
