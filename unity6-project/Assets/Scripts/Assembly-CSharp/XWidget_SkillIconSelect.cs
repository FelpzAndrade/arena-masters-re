using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E70")]
public class XWidget_SkillIconSelect : XWidget_SkillIcon
{
	[Token(Token = "0x4004B99")]
	[FieldOffset(Offset = "0x24")]
	public UILabel lblSkillType;

	[Token(Token = "0x4004B9A")]
	[FieldOffset(Offset = "0x28")]
	public UIToggle toggleSelected;

	[Token(Token = "0x4004B9B")]
	[FieldOffset(Offset = "0x2C")]
	private CSCharacterSkillInfo charSkillInfo;

	[Token(Token = "0x4004B9C")]
	[FieldOffset(Offset = "0x30")]
	public Color ultColor;

	[Token(Token = "0x4004B9D")]
	[FieldOffset(Offset = "0x40")]
	public Color passiveColor;

	[Token(Token = "0x4004B9E")]
	[FieldOffset(Offset = "0x50")]
	public Color defaultColor;

	[Token(Token = "0x6006BC0")]
	[Address(RVA = "0x1B072B8", Offset = "0x1B072B8", VA = "0x1B072B8")]
	public XWidget_SkillIconSelect()
	{
	}

	[Token(Token = "0x6006BC1")]
	[Address(RVA = "0x1B072C0", Offset = "0x1B072C0", VA = "0x1B072C0")]
	public void Build(CSCharacterSkillInfo characterSkillInfo)
	{
	}

	[Token(Token = "0x6006BC2")]
	[Address(RVA = "0x1B07504", Offset = "0x1B07504", VA = "0x1B07504")]
	private void BuildSkillType(CSCharacterSkillInfo characterSkillInfo)
	{
	}

	[Token(Token = "0x6006BC3")]
	[Address(RVA = "0x1B076F0", Offset = "0x1B076F0", VA = "0x1B076F0", Slot = "4")]
	public override void Select(bool isSelect)
	{
	}
}
