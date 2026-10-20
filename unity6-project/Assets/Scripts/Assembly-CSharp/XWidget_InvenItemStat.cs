using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F8D")]
public class XWidget_InvenItemStat : XWiget_KeyValueLabel
{
	[Token(Token = "0x400521C")]
	[FieldOffset(Offset = "0x14")]
	public UILabel arrow;

	[Token(Token = "0x400521D")]
	[FieldOffset(Offset = "0x18")]
	public Color colorUp;

	[Token(Token = "0x400521E")]
	[FieldOffset(Offset = "0x28")]
	public Color colorDown;

	[Token(Token = "0x400521F")]
	[FieldOffset(Offset = "0x38")]
	public bool isUseColorText;

	[Token(Token = "0x4005220")]
	[FieldOffset(Offset = "0x39")]
	private bool m_isUp;

	[Token(Token = "0x60073B5")]
	[Address(RVA = "0x14497E8", Offset = "0x14497E8", VA = "0x14497E8")]
	public XWidget_InvenItemStat()
	{
	}

	[Token(Token = "0x60073B6")]
	[Address(RVA = "0x14497F0", Offset = "0x14497F0", VA = "0x14497F0")]
	public void Build(string key, string value, bool? Up)
	{
	}

	[Token(Token = "0x60073B7")]
	[Address(RVA = "0x1449BAC", Offset = "0x1449BAC", VA = "0x1449BAC")]
	public void BuildStatDiff(XCharStatusDisplay.StatInfo statNullable, bool isUseColorText)
	{
	}

	[Token(Token = "0x60073B8")]
	[Address(RVA = "0x1449944", Offset = "0x1449944", VA = "0x1449944")]
	private void SetArrow()
	{
	}

	[Token(Token = "0x60073B9")]
	[Address(RVA = "0x1449A5C", Offset = "0x1449A5C", VA = "0x1449A5C")]
	private void ChangeColor(UILabel label)
	{
	}
}
