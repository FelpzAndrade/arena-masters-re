using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000EAD")]
public class XUIEventModeRewardItem : MonoBehaviour
{
	[Token(Token = "0x4004D10")]
	[FieldOffset(Offset = "0xC")]
	public UILabel lblCondition;

	[Token(Token = "0x4004D11")]
	[FieldOffset(Offset = "0x10")]
	public XWiget_GridBuilder contentBuilder;

	[Token(Token = "0x4004D12")]
	[FieldOffset(Offset = "0x14")]
	public XWidget_EnvelopContentGrid envolpWidget;

	[Token(Token = "0x4004D13")]
	[FieldOffset(Offset = "0x18")]
	public GameObject goBar;

	[Token(Token = "0x4004D14")]
	[FieldOffset(Offset = "0x1C")]
	private XWidget_ContentIcon buildContentIcon;

	[Token(Token = "0x4004D15")]
	[FieldOffset(Offset = "0x20")]
	public UIWidget.Pivot contentOnelineAlignment;

	[Token(Token = "0x4004D16")]
	[FieldOffset(Offset = "0x24")]
	public int contentFontSize;

	[Token(Token = "0x6006D6B")]
	[Address(RVA = "0x1A43030", Offset = "0x1A43030", VA = "0x1A43030")]
	public XUIEventModeRewardItem()
	{
	}

	[Token(Token = "0x6006D6C")]
	[Address(RVA = "0x1A43040", Offset = "0x1A43040", VA = "0x1A43040")]
	public void Awake()
	{
	}

	[Token(Token = "0x6006D6D")]
	[Address(RVA = "0x1A4315C", Offset = "0x1A4315C", VA = "0x1A4315C")]
	public void Build(ConditionType conditionType, int conditionCount, List<CSContent> content, bool isLast = false)
	{
	}

	[Token(Token = "0x6006D6E")]
	[Address(RVA = "0x1A43480", Offset = "0x1A43480", VA = "0x1A43480")]
	private XWidget_ContentIcon.Option GetContentIconOption(CSContentType contentType)
	{
		return default(XWidget_ContentIcon.Option);
	}
}
