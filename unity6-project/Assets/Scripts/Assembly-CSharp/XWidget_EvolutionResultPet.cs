using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F84")]
public class XWidget_EvolutionResultPet : XUIBaseWidget
{
	[Token(Token = "0x40051E5")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel lblLevelTitle;

	[Token(Token = "0x40051E6")]
	[FieldOffset(Offset = "0x20")]
	public UILabel lblBeforeLevel;

	[Token(Token = "0x40051E7")]
	[FieldOffset(Offset = "0x24")]
	public UILabel lblAfterLevel;

	[Token(Token = "0x40051E8")]
	[FieldOffset(Offset = "0x28")]
	public UILabel lblMedalTitle;

	[Token(Token = "0x40051E9")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel lblBeforeMedal;

	[Token(Token = "0x40051EA")]
	[FieldOffset(Offset = "0x30")]
	public UILabel lblAfterMedal;

	[Token(Token = "0x40051EB")]
	[FieldOffset(Offset = "0x34")]
	public UILabel lblGoldTitle;

	[Token(Token = "0x40051EC")]
	[FieldOffset(Offset = "0x38")]
	public UILabel lblBeforeGold;

	[Token(Token = "0x40051ED")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel lblAfterGold;

	[Token(Token = "0x40051EE")]
	[FieldOffset(Offset = "0x40")]
	public GameObject buttonObject;

	[Token(Token = "0x40051EF")]
	[FieldOffset(Offset = "0x44")]
	public string popupSoundKey;

	[Token(Token = "0x40051F0")]
	[FieldOffset(Offset = "0x48")]
	public GameObject sprBackgroundObject;

	[Token(Token = "0x40051F1")]
	[FieldOffset(Offset = "0x4C")]
	private Action m_clickAction;

	[Token(Token = "0x600737E")]
	[Address(RVA = "0x142B908", Offset = "0x142B908", VA = "0x142B908")]
	public XWidget_EvolutionResultPet()
	{
	}

	[Token(Token = "0x600737F")]
	[Address(RVA = "0x142B994", Offset = "0x142B994", VA = "0x142B994")]
	public void Init()
	{
	}

	[Token(Token = "0x6007380")]
	[Address(RVA = "0x142BBF8", Offset = "0x142BBF8", VA = "0x142BBF8")]
	public void Show(XModuleActor character, Action clickAction)
	{
	}

	[Token(Token = "0x6007381")]
	[Address(RVA = "0x142C05C", Offset = "0x142C05C", VA = "0x142C05C", Slot = "12")]
	public override void Hide()
	{
	}

	[Token(Token = "0x6007382")]
	[Address(RVA = "0x142C08C", Offset = "0x142C08C", VA = "0x142C08C")]
	public void OnClick_Close()
	{
	}
}
