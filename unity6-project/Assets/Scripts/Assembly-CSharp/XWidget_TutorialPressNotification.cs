using System;
using Il2CppDummyDll;

[Token(Token = "0x2000C28")]
public class XWidget_TutorialPressNotification : XWidget_TutorialBase
{
	[Token(Token = "0x4003D7E")]
	[FieldOffset(Offset = "0x14")]
	public XWidget_Builder arrowBuilder;

	[Token(Token = "0x4003D7F")]
	[FieldOffset(Offset = "0x18")]
	protected Action m_nextCallBack;

	[Token(Token = "0x4003D80")]
	[FieldOffset(Offset = "0x1C")]
	private int tutorialPanelDepth;

	[Token(Token = "0x60057FC")]
	[Address(RVA = "0x1B312AC", Offset = "0x1B312AC", VA = "0x1B312AC")]
	public XWidget_TutorialPressNotification()
	{
	}

	[Token(Token = "0x60057FD")]
	[Address(RVA = "0x1B312B8", Offset = "0x1B312B8", VA = "0x1B312B8")]
	public void Show(TutorialPressNotificationData data, Action nextCallBack)
	{
	}

	[Token(Token = "0x60057FE")]
	[Address(RVA = "0x1B31580", Offset = "0x1B31580", VA = "0x1B31580")]
	public void Show()
	{
	}

	[Token(Token = "0x60057FF")]
	[Address(RVA = "0x1B315B4", Offset = "0x1B315B4", VA = "0x1B315B4")]
	public void Hide()
	{
	}
}
