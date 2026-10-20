using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using NPA;

[Token(Token = "0x2000BE1")]
public interface IToyFacebookListener
{
	[Token(Token = "0x60055ED")]
	void OnResponseConnect(NPErrorCode errno);

	[Token(Token = "0x60055EE")]
	void OnResponseFriendList(ApiReturnCode errno, List<FacebookFriend> appendfriends);

	[Token(Token = "0x60055EF")]
	void OnResponseError(NPErrorCode errno);

	[Token(Token = "0x60055F0")]
	void OnResponseError(ApiReturnCode errno);
}
