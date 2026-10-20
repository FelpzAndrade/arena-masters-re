using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006D7")]
public interface IModeMenuElementLogic
{
	[Token(Token = "0x17000817")]
	XGameModeSortInfo info
	{
		[Token(Token = "0x6003958")]
		get;
	}

	[Token(Token = "0x6003959")]
	int GetUnlockLv();

	[Token(Token = "0x600395A")]
	bool IsLock();

	[Token(Token = "0x600395B")]
	string GetTitle();

	[Token(Token = "0x600395C")]
	Sprite GetImage();

	[Token(Token = "0x600395D")]
	void GetTopDeco(out string text, out bool isTween);

	[Token(Token = "0x600395E")]
	bool GetMidTitle(out string midTop, out bool isLock);

	[Token(Token = "0x600395F")]
	string GetBottomTitle();

	[Token(Token = "0x6003960")]
	void OnClick();

	[Token(Token = "0x6003961")]
	bool IsEffectActive();

	[Token(Token = "0x6003962")]
	void SetEventDescriptionText(string text);

	[Token(Token = "0x6003963")]
	bool TryRewardItemIconInfo(out string iconPath, out Color color);
}
