using System;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C42")]
public class XPanel_ServerRegion : XCommonBackUI
{
	[Token(Token = "0x4003E0A")]
	[FieldOffset(Offset = "0x0")]
	private static readonly string PATH;

	[Token(Token = "0x4003E0B")]
	[FieldOffset(Offset = "0x18")]
	public int MAX_VIEW;

	[Token(Token = "0x4003E0C")]
	[FieldOffset(Offset = "0x1C")]
	public int MIN_VIEW;

	[Token(Token = "0x4003E0D")]
	[FieldOffset(Offset = "0x20")]
	public int IntervalResizeNeedCnt;

	[Token(Token = "0x4003E0E")]
	[FieldOffset(Offset = "0x24")]
	public int initInterval;

	[Token(Token = "0x4003E0F")]
	[FieldOffset(Offset = "0x28")]
	public int minInterval;

	[Token(Token = "0x4003E10")]
	[FieldOffset(Offset = "0x2C")]
	public int minScrollViewSize;

	[Token(Token = "0x4003E11")]
	[FieldOffset(Offset = "0x30")]
	public XWiget_GridBuilder regionBuilder;

	[Token(Token = "0x4003E12")]
	[FieldOffset(Offset = "0x34")]
	public UIScrollView scrollView;

	[Token(Token = "0x4003E13")]
	[FieldOffset(Offset = "0x38")]
	public UIWidget widgetInnerBG;

	[Token(Token = "0x4003E14")]
	[FieldOffset(Offset = "0x3C")]
	private XWidget_Selectable_Label[] regions;

	[Token(Token = "0x4003E15")]
	[FieldOffset(Offset = "0x40")]
	private XWidget_Selectable_Label selectRegion;

	[Token(Token = "0x4003E16")]
	[FieldOffset(Offset = "0x44")]
	private Action<ConnectEnum.RegionType> selectCallback;

	[Token(Token = "0x4003E17")]
	[FieldOffset(Offset = "0x48")]
	private ConnectEnum.RegionType initRegion;

	[Token(Token = "0x4003E18")]
	[FieldOffset(Offset = "0x4C")]
	private ConnectEnum.RegionType recommendRegion;

	[Token(Token = "0x4003E19")]
	[FieldOffset(Offset = "0x50")]
	public GameObject closeButtonObject;

	[Token(Token = "0x4003E1A")]
	[FieldOffset(Offset = "0x54")]
	private bool isNotSelectCountry;

	[Token(Token = "0x60058AE")]
	[Address(RVA = "0xAB9AC8", Offset = "0xAB9AC8", VA = "0xAB9AC8")]
	public XPanel_ServerRegion()
	{
	}

	[Token(Token = "0x60058B0")]
	[Address(RVA = "0xAB9B98", Offset = "0xAB9B98", VA = "0xAB9B98")]
	public static XPanel_ServerRegion Create(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x60058B1")]
	[Address(RVA = "0xAB9D38", Offset = "0xAB9D38", VA = "0xAB9D38")]
	public void Show(ConnectEnum.RegionType selectRegion, Action<ConnectEnum.RegionType> selectCallback, bool isBackable = true)
	{
	}

	[Token(Token = "0x60058B2")]
	[Address(RVA = "0xAB9DE8", Offset = "0xAB9DE8", VA = "0xAB9DE8")]
	private void SetRecommendRegion()
	{
	}

	[Token(Token = "0x60058B3")]
	[Address(RVA = "0xAB9F24", Offset = "0xAB9F24", VA = "0xAB9F24")]
	private void BuildRegion(ConnectEnum.RegionType selectRegion)
	{
	}

	[Token(Token = "0x60058B4")]
	[Address(RVA = "0xABA4C8", Offset = "0xABA4C8", VA = "0xABA4C8")]
	private void ChangeSelectRegion(bool toggle, int condition)
	{
	}

	[Token(Token = "0x60058B5")]
	[Address(RVA = "0xABA60C", Offset = "0xABA60C", VA = "0xABA60C")]
	public void OnClick_SelectComplete()
	{
	}
}
