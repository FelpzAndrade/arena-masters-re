using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F5C")]
public class XUITeamInformationItem : MonoBehaviour
{
	[Token(Token = "0x40050AB")]
	[FieldOffset(Offset = "0xC")]
	public UI2DSprite sprIcon;

	[Token(Token = "0x40050AC")]
	[FieldOffset(Offset = "0x10")]
	private int m_ProfileIconId;

	[Token(Token = "0x40050AD")]
	[FieldOffset(Offset = "0x14")]
	private bool m_bLocked;

	[Token(Token = "0x40050AE")]
	[FieldOffset(Offset = "0x18")]
	private Action<XUITeamInformationItem> m_action;

	[Token(Token = "0x40050AF")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject goSprSelect;

	[Token(Token = "0x40050B0")]
	[FieldOffset(Offset = "0x20")]
	public GameObject goSprLock;

	[Token(Token = "0x17000E92")]
	public bool IsLocked
	{
		[Token(Token = "0x600721F")]
		[Address(RVA = "0x1934E14", Offset = "0x1934E14", VA = "0x1934E14")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000E93")]
	public int ProfileIconId
	{
		[Token(Token = "0x6007220")]
		[Address(RVA = "0x1934E1C", Offset = "0x1934E1C", VA = "0x1934E1C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600721E")]
	[Address(RVA = "0x1934E04", Offset = "0x1934E04", VA = "0x1934E04")]
	public XUITeamInformationItem()
	{
	}

	[Token(Token = "0x6007221")]
	[Address(RVA = "0x1934E24", Offset = "0x1934E24", VA = "0x1934E24")]
	public void Build(int profileIconId, Action<XUITeamInformationItem> action)
	{
	}

	[Token(Token = "0x6007222")]
	[Address(RVA = "0x1935104", Offset = "0x1935104", VA = "0x1935104")]
	public void SelectSprite(bool state)
	{
	}

	[Token(Token = "0x6007223")]
	[Address(RVA = "0x19351FC", Offset = "0x19351FC", VA = "0x19351FC")]
	public void OnClick()
	{
	}
}
