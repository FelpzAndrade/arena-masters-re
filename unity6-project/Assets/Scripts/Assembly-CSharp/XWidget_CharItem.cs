using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F70")]
public class XWidget_CharItem : MonoBehaviour
{
	[Token(Token = "0x4005152")]
	[FieldOffset(Offset = "0xC")]
	public int charID;

	[Token(Token = "0x4005153")]
	[FieldOffset(Offset = "0x10")]
	public UI2DSprite sprChar;

	[Token(Token = "0x4005154")]
	[FieldOffset(Offset = "0x14")]
	public UIBasicSprite sprSel;

	[Token(Token = "0x4005155")]
	[FieldOffset(Offset = "0x18")]
	public UIBasicSprite sprLock;

	[Token(Token = "0x4005156")]
	[FieldOffset(Offset = "0x1C")]
	public UIBasicSprite sprDisable;

	[Token(Token = "0x4005157")]
	[FieldOffset(Offset = "0x20")]
	public GameObject goSprFreeRota;

	[Token(Token = "0x4005158")]
	[FieldOffset(Offset = "0x24")]
	public Action<int> onClick;

	[Token(Token = "0x4005159")]
	[FieldOffset(Offset = "0x28")]
	private Action onRefresh;

	[Token(Token = "0x400515A")]
	[FieldOffset(Offset = "0x2C")]
	public UI2DSprite sprTime;

	[Token(Token = "0x400515B")]
	[FieldOffset(Offset = "0x30")]
	private bool m_isOpen;

	[Token(Token = "0x400515C")]
	[FieldOffset(Offset = "0x34")]
	private XModuleActor m_character;

	[Token(Token = "0x60072DF")]
	[Address(RVA = "0x15CEB6C", Offset = "0x15CEB6C", VA = "0x15CEB6C")]
	public XWidget_CharItem()
	{
	}

	[Token(Token = "0x60072E0")]
	[Address(RVA = "0x15CEB74", Offset = "0x15CEB74", VA = "0x15CEB74")]
	private void Update()
	{
	}

	[Token(Token = "0x60072E1")]
	[Address(RVA = "0x15CECB8", Offset = "0x15CECB8", VA = "0x15CECB8")]
	public void Build(XModuleActor character, Sprite spr, bool seleceted, bool disable, Action<int> onClick, bool isFreeRotaChar, Action onRefresh)
	{
	}

	[Token(Token = "0x60072E2")]
	[Address(RVA = "0x15CEFA4", Offset = "0x15CEFA4", VA = "0x15CEFA4")]
	private void SetOpenInfo(out bool changed)
	{
		changed = default;
	}

	[Token(Token = "0x60072E3")]
	[Address(RVA = "0x15CEB84", Offset = "0x15CEB84", VA = "0x15CEB84")]
	private void RefreshOpenInfo()
	{
	}

	[Token(Token = "0x60072E4")]
	[Address(RVA = "0x15CEF9C", Offset = "0x15CEF9C", VA = "0x15CEF9C")]
	public void SetOnClick(Action<int> onClick)
	{
	}

	[Token(Token = "0x60072E5")]
	[Address(RVA = "0x15CF144", Offset = "0x15CF144", VA = "0x15CF144")]
	public void OnClick()
	{
	}

	[Token(Token = "0x60072E6")]
	[Address(RVA = "0x15CEF58", Offset = "0x15CEF58", VA = "0x15CEF58")]
	public void Select(bool val)
	{
	}
}
