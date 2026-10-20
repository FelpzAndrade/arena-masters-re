using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E6B")]
public class XWidget_DropDownMenuButton : MonoBehaviour
{
	[Token(Token = "0x4004B7E")]
	[FieldOffset(Offset = "0xC")]
	public List<UIButton> elements;

	[Token(Token = "0x4004B7F")]
	[FieldOffset(Offset = "0x10")]
	public int representDepth;

	[Token(Token = "0x4004B80")]
	[FieldOffset(Offset = "0x14")]
	public int hideDepth;

	[Token(Token = "0x4004B81")]
	[FieldOffset(Offset = "0x18")]
	public float elementHeight;

	[Token(Token = "0x4004B82")]
	[FieldOffset(Offset = "0x1C")]
	public float foldingDuration;

	[Token(Token = "0x4004B83")]
	[FieldOffset(Offset = "0x20")]
	private bool m_isFolded;

	[Token(Token = "0x4004B84")]
	[FieldOffset(Offset = "0x24")]
	private UIButton m_represent;

	[Token(Token = "0x4004B85")]
	[FieldOffset(Offset = "0x28")]
	private List<EventDelegate> m_represent_delegateCache;

	[Token(Token = "0x4004B86")]
	[FieldOffset(Offset = "0x2C")]
	private List<EventDelegate> m_dropDownDelegate;

	[Token(Token = "0x6006BA4")]
	[Address(RVA = "0x15F2B84", Offset = "0x15F2B84", VA = "0x15F2B84")]
	public XWidget_DropDownMenuButton()
	{
	}

	[Token(Token = "0x6006BA5")]
	[Address(RVA = "0x15F2C54", Offset = "0x15F2C54", VA = "0x15F2C54")]
	private void Awake()
	{
	}

	[Token(Token = "0x6006BA6")]
	[Address(RVA = "0x15F30C0", Offset = "0x15F30C0", VA = "0x15F30C0")]
	public void OnClick_Sort(UIButton button)
	{
	}

	[Token(Token = "0x6006BA7")]
	[Address(RVA = "0x15F30C4", Offset = "0x15F30C4", VA = "0x15F30C4")]
	public void OnClick_DropDown()
	{
	}

	[Token(Token = "0x6006BA8")]
	[Address(RVA = "0x15F32BC", Offset = "0x15F32BC", VA = "0x15F32BC")]
	public void Fold()
	{
	}

	[Token(Token = "0x6006BA9")]
	[Address(RVA = "0x15F30D8", Offset = "0x15F30D8", VA = "0x15F30D8")]
	private void Unfold()
	{
	}

	[Token(Token = "0x6006BAA")]
	[Address(RVA = "0x15F3484", Offset = "0x15F3484", VA = "0x15F3484")]
	public void ImmediatelyFold()
	{
	}

	[Token(Token = "0x6006BAB")]
	[Address(RVA = "0x15F305C", Offset = "0x15F305C", VA = "0x15F305C")]
	public void SetRepresent(UIButton represent)
	{
	}

	[Token(Token = "0x6006BAC")]
	[Address(RVA = "0x15F3650", Offset = "0x15F3650", VA = "0x15F3650")]
	private void SetDepth()
	{
	}
}
