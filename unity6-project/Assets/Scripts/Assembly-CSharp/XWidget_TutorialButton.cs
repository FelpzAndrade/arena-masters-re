using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

[Token(Token = "0x2000C21")]
public class XWidget_TutorialButton : XWidget_Button
{
	[Token(Token = "0x4003D47")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private bool completeOnClick;

	[Token(Token = "0x4003D48")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private UIDragScrollView m_dragComponent;

	[Token(Token = "0x4003D49")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private bool isExitColider;

	[Token(Token = "0x4003D4A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
	private bool usePress;

	[Token(Token = "0x4003D4B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Action m_tutoNextAction;

	[Token(Token = "0x60057C5")]
	[Address(RVA = "0x1B2E808", Offset = "0x1B2E808", VA = "0x1B2E808")]
	public XWidget_TutorialButton()
	{
	}

	[Token(Token = "0x60057C6")]
	[Address(RVA = "0x1B2E810", Offset = "0x1B2E810", VA = "0x1B2E810", Slot = "4")]
	public override void Build(string title, Action onClick, [Optional][DefaultParameterValue(false)] bool isDisable, [Optional] Action onDisableClick)
	{
	}

	[Token(Token = "0x60057C7")]
	[Address(RVA = "0x1B2EAC8", Offset = "0x1B2EAC8", VA = "0x1B2EAC8")]
	public void SetPress(bool usePress)
	{
	}

	[Token(Token = "0x60057C8")]
	[Address(RVA = "0x1B2E9E0", Offset = "0x1B2E9E0", VA = "0x1B2E9E0")]
	public void SetColider()
	{
	}

	[Token(Token = "0x60057C9")]
	[Address(RVA = "0x1B2EAD0", Offset = "0x1B2EAD0", VA = "0x1B2EAD0")]
	public void NextTutorialRegist(Action tutoNextAction)
	{
	}

	[Token(Token = "0x60057CA")]
	[Address(RVA = "0x1B2EAD8", Offset = "0x1B2EAD8", VA = "0x1B2EAD8", Slot = "5")]
	protected override void OnClick()
	{
	}

	[Token(Token = "0x60057CB")]
	[Address(RVA = "0x1B2EB8C", Offset = "0x1B2EB8C", VA = "0x1B2EB8C")]
	private new void OnPress(bool isPressed)
	{
	}

	[Token(Token = "0x60057CC")]
	[Address(RVA = "0x1B2E900", Offset = "0x1B2E900", VA = "0x1B2E900")]
	private void SetDragComponentEnable(bool isEnable)
	{
	}

	[Token(Token = "0x60057CD")]
	[Address(RVA = "0x1B2EB48", Offset = "0x1B2EB48", VA = "0x1B2EB48")]
	public void CallOnClick()
	{
	}
}
