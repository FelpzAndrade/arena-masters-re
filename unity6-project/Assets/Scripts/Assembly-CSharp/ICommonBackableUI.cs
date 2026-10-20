using System;
using Il2CppDummyDll;

[Token(Token = "0x2000DA5")]
public interface ICommonBackableUI
{
	[Token(Token = "0x6006451")]
	bool IsActive();

	[Token(Token = "0x6006452")]
	void Hide();

	[Token(Token = "0x6006453")]
	bool IsBackable();

	[Token(Token = "0x6006454")]
	bool IsLeaf();

	[Token(Token = "0x6006455")]
	string GetName();

	[Token(Token = "0x6006456")]
	bool Back();

	[Token(Token = "0x6006457")]
	void SetPopupFunc(Action<ICommonBackableUI> registerPopup, Action<ICommonBackableUI> releasePopup);
}
