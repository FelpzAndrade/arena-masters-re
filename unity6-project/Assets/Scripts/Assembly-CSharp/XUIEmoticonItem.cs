using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F1B")]
public class XUIEmoticonItem : MonoBehaviour
{
	[Token(Token = "0x4004FF0")]
	[FieldOffset(Offset = "0xC")]
	public GameObject goRoot;

	[Token(Token = "0x4004FF1")]
	[FieldOffset(Offset = "0x10")]
	public UI2DSprite sprIcon;

	[Token(Token = "0x4004FF2")]
	[FieldOffset(Offset = "0x14")]
	public GameObject sprSelect;

	[Token(Token = "0x4004FF3")]
	[FieldOffset(Offset = "0x18")]
	public GameObject sprLock;

	[Token(Token = "0x4004FF4")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject sprChecked;

	[Token(Token = "0x4004FF5")]
	[FieldOffset(Offset = "0x20")]
	public GameObject sprEvent;

	[Token(Token = "0x4004FF6")]
	[FieldOffset(Offset = "0x24")]
	public CSEmoticonSetInfo m_emoticonInfo;

	[Token(Token = "0x4004FF7")]
	[FieldOffset(Offset = "0x28")]
	private Action<XUIEmoticonItem> m_OnSelect;

	[Token(Token = "0x600709A")]
	[Address(RVA = "0x1A3E6BC", Offset = "0x1A3E6BC", VA = "0x1A3E6BC")]
	public XUIEmoticonItem()
	{
	}

	[Token(Token = "0x600709B")]
	[Address(RVA = "0x1A3E6C4", Offset = "0x1A3E6C4", VA = "0x1A3E6C4")]
	public void ShowOnlyBG()
	{
	}

	[Token(Token = "0x600709C")]
	[Address(RVA = "0x1A3E700", Offset = "0x1A3E700", VA = "0x1A3E700")]
	public void Build(CSEmoticonSetInfo info, Action<XUIEmoticonItem> onSelect, bool bOpened, bool bSelected, bool bChecked)
	{
	}

	[Token(Token = "0x600709D")]
	[Address(RVA = "0x1A3E8D0", Offset = "0x1A3E8D0", VA = "0x1A3E8D0")]
	public void Refresh(CSEmoticonSetInfo info, bool bOpened, bool bSelected, bool bChecked)
	{
	}

	[Token(Token = "0x600709E")]
	[Address(RVA = "0x1A3EA14", Offset = "0x1A3EA14", VA = "0x1A3EA14")]
	public void SetSelected(bool state)
	{
	}

	[Token(Token = "0x600709F")]
	[Address(RVA = "0x1A3EAF4", Offset = "0x1A3EAF4", VA = "0x1A3EAF4")]
	public void SetChecked(bool state)
	{
	}

	[Token(Token = "0x60070A0")]
	[Address(RVA = "0x1A3EBD4", Offset = "0x1A3EBD4", VA = "0x1A3EBD4")]
	public void SetEvent(bool state)
	{
	}

	[Token(Token = "0x60070A1")]
	[Address(RVA = "0x1A3E934", Offset = "0x1A3E934", VA = "0x1A3E934")]
	public void SetOpened(bool state)
	{
	}

	[Token(Token = "0x60070A2")]
	[Address(RVA = "0x1A3ECB4", Offset = "0x1A3ECB4", VA = "0x1A3ECB4")]
	public void OnClick()
	{
	}
}
