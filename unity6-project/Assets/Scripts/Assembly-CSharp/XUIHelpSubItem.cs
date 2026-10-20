using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2001023")]
public class XUIHelpSubItem : MonoBehaviour
{
	[Token(Token = "0x400568F")]
	[FieldOffset(Offset = "0xC")]
	private XHelpInfo m_helpInfo;

	[Token(Token = "0x4005690")]
	[FieldOffset(Offset = "0x10")]
	public UILabel lblTitle;

	[Token(Token = "0x4005691")]
	[FieldOffset(Offset = "0x14")]
	public GameObject bgActive;

	[Token(Token = "0x4005692")]
	[FieldOffset(Offset = "0x18")]
	public GameObject bgDeactive;

	[Token(Token = "0x4005693")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite sprArrow;

	[Token(Token = "0x4005694")]
	[FieldOffset(Offset = "0x20")]
	public Action<int> m_selectAction;

	[Token(Token = "0x4005695")]
	[FieldOffset(Offset = "0x24")]
	public UIButton btnClick;

	[Token(Token = "0x17000EF9")]
	public XHelpInfo HelpInfo
	{
		[Token(Token = "0x6007859")]
		[Address(RVA = "0x108A988", Offset = "0x108A988", VA = "0x108A988")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007855")]
	[Address(RVA = "0x108A994", Offset = "0x108A994", VA = "0x108A994")]
	public XUIHelpSubItem()
	{
	}

	[Token(Token = "0x6007856")]
	[Address(RVA = "0x108A218", Offset = "0x108A218", VA = "0x108A218")]
	public void Build(XHelpInfo helpInfo, Action<int> selectAction)
	{
	}

	[Token(Token = "0x6007857")]
	[Address(RVA = "0x108A99C", Offset = "0x108A99C", VA = "0x108A99C")]
	public void RefreshSubList(int id)
	{
	}

	[Token(Token = "0x6007858")]
	[Address(RVA = "0x108AB84", Offset = "0x108AB84", VA = "0x108AB84")]
	public bool ActiveSpriteState()
	{
		return default(bool);
	}

	[Token(Token = "0x600785A")]
	[Address(RVA = "0x108ABC0", Offset = "0x108ABC0", VA = "0x108ABC0")]
	private void _003CBuild_003Em__503()
	{
	}
}
