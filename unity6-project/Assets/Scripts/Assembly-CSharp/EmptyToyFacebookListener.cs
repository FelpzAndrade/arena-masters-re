using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using NPA;

[Token(Token = "0x2000BE2")]
public class EmptyToyFacebookListener : IToyFacebookListener
{
	[Token(Token = "0x60055F1")]
	[Address(RVA = "0x1E69798", Offset = "0x1E69798", VA = "0x1E69798")]
	public EmptyToyFacebookListener()
	{
	}

	[Token(Token = "0x60055F2")]
	[Address(RVA = "0x1E697A0", Offset = "0x1E697A0", VA = "0x1E697A0", Slot = "4")]
	public void OnResponseConnect(NPErrorCode errno)
	{
	}

	[Token(Token = "0x60055F3")]
	[Address(RVA = "0x1E697A4", Offset = "0x1E697A4", VA = "0x1E697A4", Slot = "5")]
	public void OnResponseFriendList(ApiReturnCode errno, List<FacebookFriend> appendfriends)
	{
	}

	[Token(Token = "0x60055F4")]
	[Address(RVA = "0x1E697A8", Offset = "0x1E697A8", VA = "0x1E697A8", Slot = "6")]
	public void OnResponseError(NPErrorCode errno)
	{
	}

	[Token(Token = "0x60055F5")]
	[Address(RVA = "0x1E697AC", Offset = "0x1E697AC", VA = "0x1E697AC", Slot = "7")]
	public void OnResponseError(ApiReturnCode errno)
	{
	}
}
