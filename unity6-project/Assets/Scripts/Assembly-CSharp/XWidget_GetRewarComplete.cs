using System;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F8A")]
public class XWidget_GetRewarComplete : MonoBehaviour
{
	[Token(Token = "0x4005211")]
	[FieldOffset(Offset = "0xC")]
	public UI2DSprite sprItemIcon;

	[Token(Token = "0x4005212")]
	[FieldOffset(Offset = "0x10")]
	public UILabel lblItemCount;

	[Token(Token = "0x4005213")]
	[FieldOffset(Offset = "0x14")]
	private Action m_action;

	[Token(Token = "0x60073AB")]
	[Address(RVA = "0x143D57C", Offset = "0x143D57C", VA = "0x143D57C")]
	public XWidget_GetRewarComplete()
	{
	}

	[Token(Token = "0x60073AC")]
	[Address(RVA = "0x143D584", Offset = "0x143D584", VA = "0x143D584")]
	public void Show(CSContentType type, int id, int count, Action action)
	{
	}

	[Token(Token = "0x60073AD")]
	[Address(RVA = "0x143D7C0", Offset = "0x143D7C0", VA = "0x143D7C0")]
	public void OnClick_Hide()
	{
	}
}
