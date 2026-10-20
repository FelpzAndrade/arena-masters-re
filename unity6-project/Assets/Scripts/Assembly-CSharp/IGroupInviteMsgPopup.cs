using System;
using Il2CppDummyDll;

[Token(Token = "0x2000D9A")]
public interface IGroupInviteMsgPopup
{
	[Token(Token = "0x6006416")]
	void Show(string groupMaster, Action onClickAccept, Action onClickReject);
}
