using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C98")]
public class XWidget_RewardIcon : MonoBehaviour
{
	[Token(Token = "0x400401C")]
	[FieldOffset(Offset = "0xC")]
	public UI2DSprite sprIcon;

	[Token(Token = "0x400401D")]
	[FieldOffset(Offset = "0x10")]
	public UILabel lblQuantity;

	[Token(Token = "0x400401E")]
	[FieldOffset(Offset = "0x14")]
	public UILabel lblToolTip;

	[Token(Token = "0x400401F")]
	[FieldOffset(Offset = "0x18")]
	public TweenAlpha tweenToolTip;

	[Token(Token = "0x4004020")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton btnToolTip;

	[Token(Token = "0x4004021")]
	[FieldOffset(Offset = "0x20")]
	private bool m_isShowToolTip;

	[Token(Token = "0x6005AFA")]
	[Address(RVA = "0x1345290", Offset = "0x1345290", VA = "0x1345290")]
	public XWidget_RewardIcon()
	{
	}

	[Token(Token = "0x6005AFB")]
	[Address(RVA = "0x1345298", Offset = "0x1345298", VA = "0x1345298")]
	public void Build(CSContent content)
	{
	}

	[Token(Token = "0x6005AFC")]
	[Address(RVA = "0x13456EC", Offset = "0x13456EC", VA = "0x13456EC")]
	private void BuildItemToolTip(string itemName)
	{
	}

	[Token(Token = "0x6005AFD")]
	[Address(RVA = "0x13457F4", Offset = "0x13457F4", VA = "0x13457F4")]
	public void OnClick_ToolTip()
	{
	}
}
