using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F01")]
public class XWidget_TeamLevleUpPopup : XCommonBackUI
{
	[Token(Token = "0x4004F93")]
	[FieldOffset(Offset = "0x18")]
	public UILabel lblBeforeMaxEnergy;

	[Token(Token = "0x4004F94")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel lblAfterMaxEnergy;

	[Token(Token = "0x4004F95")]
	[FieldOffset(Offset = "0x20")]
	public UILabel lblBeforeTalentPoint;

	[Token(Token = "0x4004F96")]
	[FieldOffset(Offset = "0x24")]
	public UILabel lblAfterTalentPoint;

	[Token(Token = "0x4004F97")]
	[FieldOffset(Offset = "0x28")]
	public XWiget_GridBuilder grid;

	[Token(Token = "0x4004F98")]
	[FieldOffset(Offset = "0x2C")]
	public UIBasicSprite frame;

	[Token(Token = "0x4004F99")]
	[FieldOffset(Offset = "0x30")]
	public UILabel levelLabelBefore;

	[Token(Token = "0x4004F9A")]
	[FieldOffset(Offset = "0x34")]
	public UILabel levelLabelAfter;

	[Token(Token = "0x4004F9B")]
	[FieldOffset(Offset = "0x38")]
	public GameObject unlockLine;

	[Token(Token = "0x4004F9C")]
	[FieldOffset(Offset = "0x3C")]
	public EnvelopContent envelop;

	[Token(Token = "0x6007008")]
	[Address(RVA = "0x1B17FEC", Offset = "0x1B17FEC", VA = "0x1B17FEC")]
	public XWidget_TeamLevleUpPopup()
	{
	}

	[Token(Token = "0x6007009")]
	[Address(RVA = "0x1B17FF4", Offset = "0x1B17FF4", VA = "0x1B17FF4")]
	public void Show(int beforeTeamLv, int afterTeamLv, int earnEnergy = 0)
	{
	}

	[Token(Token = "0x600700A")]
	[Address(RVA = "0x1B18194", Offset = "0x1B18194", VA = "0x1B18194")]
	private void Build(int beforeTeamLv, int afterTeamLv, int earnEnergy)
	{
	}

	[Token(Token = "0x600700B")]
	[Address(RVA = "0x1B1881C", Offset = "0x1B1881C", VA = "0x1B1881C", Slot = "12")]
	public override void Hide()
	{
	}

	[Token(Token = "0x600700C")]
	[Address(RVA = "0x1B188E8", Offset = "0x1B188E8", VA = "0x1B188E8")]
	public void Init()
	{
	}

	[Token(Token = "0x600700D")]
	[Address(RVA = "0x1B189A0", Offset = "0x1B189A0", VA = "0x1B189A0")]
	public void OnClick_Confirm()
	{
	}
}
