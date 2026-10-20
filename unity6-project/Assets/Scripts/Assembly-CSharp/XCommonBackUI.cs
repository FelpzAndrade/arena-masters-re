using System;
using Il2CppDummyDll;

[Token(Token = "0x2001008")]
public class XCommonBackUI : XUIBase
{
	[Token(Token = "0x4005595")]
	[FieldOffset(Offset = "0xC")]
	protected Action<ICommonBackableUI> m_RegisterPopup;

	[Token(Token = "0x4005596")]
	[FieldOffset(Offset = "0x10")]
	protected Action<ICommonBackableUI> m_ReleasePopup;

	[Token(Token = "0x4005597")]
	[FieldOffset(Offset = "0x14")]
	private bool m_isBackable;

	[Token(Token = "0x4005598")]
	[FieldOffset(Offset = "0x15")]
	private bool m_isLeaf;

	[Token(Token = "0x6007794")]
	[Address(RVA = "0x198A37C", Offset = "0x198A37C", VA = "0x198A37C")]
	public XCommonBackUI()
	{
	}

	[Token(Token = "0x6007795")]
	[Address(RVA = "0x198A38C", Offset = "0x198A38C", VA = "0x198A38C", Slot = "13")]
	public override bool IsBackable()
	{
		return default(bool);
	}

	[Token(Token = "0x6007796")]
	[Address(RVA = "0x198A394", Offset = "0x198A394", VA = "0x198A394", Slot = "14")]
	public override bool IsLeaf()
	{
		return default(bool);
	}

	[Token(Token = "0x6007797")]
	[Address(RVA = "0x198A39C", Offset = "0x198A39C", VA = "0x198A39C")]
	public void SetRegisterFunc(Action<ICommonBackableUI> registerPopup, Action<ICommonBackableUI> releasePopup)
	{
	}

	[Token(Token = "0x6007798")]
	[Address(RVA = "0x198A3B8", Offset = "0x198A3B8", VA = "0x198A3B8")]
	public void RegisterPopup(bool isBackable = true, bool isLeaf = false)
	{
	}

	[Token(Token = "0x6007799")]
	[Address(RVA = "0x198A458", Offset = "0x198A458", VA = "0x198A458", Slot = "12")]
	public override void Hide()
	{
	}

	[Token(Token = "0x600779A")]
	[Address(RVA = "0x198A478", Offset = "0x198A478", VA = "0x198A478")]
	public void ReleasePopup()
	{
	}
}
