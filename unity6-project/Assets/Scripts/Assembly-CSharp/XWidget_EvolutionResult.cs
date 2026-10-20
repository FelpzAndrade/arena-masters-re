using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F83")]
public class XWidget_EvolutionResult : XUIBaseWidget
{
	[Token(Token = "0x40051DE")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel lblLevelTitle;

	[Token(Token = "0x40051DF")]
	[FieldOffset(Offset = "0x20")]
	public UILabel lblLevel;

	[Token(Token = "0x40051E0")]
	[FieldOffset(Offset = "0x24")]
	public UILabel lblSkillPoint;

	[Token(Token = "0x40051E1")]
	[FieldOffset(Offset = "0x28")]
	public GameObject buttonObject;

	[Token(Token = "0x40051E2")]
	[FieldOffset(Offset = "0x2C")]
	public string popupSoundKey;

	[Token(Token = "0x40051E3")]
	[FieldOffset(Offset = "0x30")]
	public GameObject sprBackgroundObject;

	[Token(Token = "0x40051E4")]
	[FieldOffset(Offset = "0x34")]
	private Action m_clickAction;

	[Token(Token = "0x6007379")]
	[Address(RVA = "0x142B36C", Offset = "0x142B36C", VA = "0x142B36C")]
	public XWidget_EvolutionResult()
	{
	}

	[Token(Token = "0x600737A")]
	[Address(RVA = "0x142B3F8", Offset = "0x142B3F8", VA = "0x142B3F8")]
	public void Init()
	{
	}

	[Token(Token = "0x600737B")]
	[Address(RVA = "0x142B534", Offset = "0x142B534", VA = "0x142B534")]
	public void Show(XModuleActor character, Action clickAction)
	{
	}

	[Token(Token = "0x600737C")]
	[Address(RVA = "0x142B894", Offset = "0x142B894", VA = "0x142B894", Slot = "12")]
	public override void Hide()
	{
	}

	[Token(Token = "0x600737D")]
	[Address(RVA = "0x142B8C4", Offset = "0x142B8C4", VA = "0x142B8C4")]
	public void OnClick_Close()
	{
	}
}
