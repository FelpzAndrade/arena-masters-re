using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006D1")]
public class XVirtualKeyControl : MonoBehaviour
{
	[Token(Token = "0x4002093")]
	[FieldOffset(Offset = "0xC")]
	public TouchController ctrl;

	[Token(Token = "0x4002094")]
	[FieldOffset(Offset = "0x10")]
	private TouchStick stick;

	[Token(Token = "0x4002095")]
	[FieldOffset(Offset = "0x14")]
	private TouchController.LayoutBox layOutBox;

	[Token(Token = "0x4002096")]
	[FieldOffset(Offset = "0x18")]
	private readonly float standardDPI;

	[Token(Token = "0x6003923")]
	[Address(RVA = "0x193C9F8", Offset = "0x193C9F8", VA = "0x193C9F8")]
	public XVirtualKeyControl()
	{
	}

	[Token(Token = "0x6003924")]
	[Address(RVA = "0x193CA0C", Offset = "0x193CA0C", VA = "0x193CA0C")]
	public void Init()
	{
	}

	[Token(Token = "0x6003925")]
	[Address(RVA = "0x193CE3C", Offset = "0x193CE3C", VA = "0x193CE3C")]
	private void AdjustSickSizeFromDPI()
	{
	}

	[Token(Token = "0x6003926")]
	[Address(RVA = "0x193CBAC", Offset = "0x193CBAC", VA = "0x193CBAC")]
	private void SetSick()
	{
	}

	[Token(Token = "0x6003927")]
	[Address(RVA = "0x193CCD8", Offset = "0x193CCD8", VA = "0x193CCD8")]
	private void SetLayout()
	{
	}

	[Token(Token = "0x6003928")]
	[Address(RVA = "0x193CCC4", Offset = "0x193CCC4", VA = "0x193CCC4")]
	public void HideStick()
	{
	}

	[Token(Token = "0x6003929")]
	[Address(RVA = "0x193CF00", Offset = "0x193CF00", VA = "0x193CF00")]
	public void ShowStick()
	{
	}

	[Token(Token = "0x600392A")]
	[Address(RVA = "0x193CF20", Offset = "0x193CF20", VA = "0x193CF20")]
	public void SetActive(bool isActive)
	{
	}
}
