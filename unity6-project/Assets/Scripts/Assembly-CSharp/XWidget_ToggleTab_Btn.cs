using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E77")]
public class XWidget_ToggleTab_Btn : MonoBehaviour
{
	[Token(Token = "0x4004BD5")]
	[FieldOffset(Offset = "0xC")]
	public UILabel lblTitle;

	[Token(Token = "0x4004BD6")]
	[FieldOffset(Offset = "0x10")]
	private UIWidget m_lblWidget;

	[Token(Token = "0x4004BD7")]
	[FieldOffset(Offset = "0x14")]
	public Color lblActiveColor;

	[Token(Token = "0x4004BD8")]
	[FieldOffset(Offset = "0x24")]
	public Color lblDeactiveColor;

	[Token(Token = "0x4004BD9")]
	[FieldOffset(Offset = "0x34")]
	public GameObject[] onActive;

	[Token(Token = "0x4004BDA")]
	[FieldOffset(Offset = "0x38")]
	public GameObject[] onDeactive;

	[Token(Token = "0x4004BDB")]
	[FieldOffset(Offset = "0x3C")]
	private List<UIWidget> m_widgets;

	[Token(Token = "0x4004BDC")]
	[FieldOffset(Offset = "0x40")]
	private Color[] m_colors;

	[Token(Token = "0x4004BDD")]
	[FieldOffset(Offset = "0x44")]
	private Action m_onClick;

	[Token(Token = "0x4004BDE")]
	[FieldOffset(Offset = "0x48")]
	public GameObject newBadge;

	[Token(Token = "0x4004BDF")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject tabLock;

	[Token(Token = "0x4004BE0")]
	[FieldOffset(Offset = "0x50")]
	public GameObject disableRect;

	[Token(Token = "0x4004BE1")]
	[FieldOffset(Offset = "0x54")]
	public bool disableColorUse;

	[Token(Token = "0x4004BE2")]
	[FieldOffset(Offset = "0x55")]
	public bool rarityColorUse;

	[Token(Token = "0x4004BE3")]
	[FieldOffset(Offset = "0x58")]
	private int m_index;

	[Token(Token = "0x6006BF7")]
	[Address(RVA = "0x1B26BA4", Offset = "0x1B26BA4", VA = "0x1B26BA4")]
	public XWidget_ToggleTab_Btn()
	{
	}

	[Token(Token = "0x6006BF8")]
	[Address(RVA = "0x1B26BB4", Offset = "0x1B26BB4", VA = "0x1B26BB4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6006BF9")]
	[Address(RVA = "0x1B26E94", Offset = "0x1B26E94", VA = "0x1B26E94")]
	private void AddWidgetComponent(GameObject[] objs, ref List<UIWidget> widgets)
	{
	}

	[Token(Token = "0x6006BFA")]
	[Address(RVA = "0x1B26FE8", Offset = "0x1B26FE8", VA = "0x1B26FE8")]
	public void Build(string title, Action onClick, int index = 0, bool bLock = false)
	{
	}

	[Token(Token = "0x6006BFB")]
	[Address(RVA = "0x1B271A0", Offset = "0x1B271A0", VA = "0x1B271A0")]
	public void OnClickThisTab()
	{
	}

	[Token(Token = "0x6006BFC")]
	[Address(RVA = "0x1B27284", Offset = "0x1B27284", VA = "0x1B27284")]
	public void OnTabClicked(XWidget_ToggleTab_Btn tab)
	{
	}

	[Token(Token = "0x6006BFD")]
	[Address(RVA = "0x1B274F8", Offset = "0x1B274F8", VA = "0x1B274F8")]
	public void OnTabClickedReset()
	{
	}

	[Token(Token = "0x6006BFE")]
	[Address(RVA = "0x1B27340", Offset = "0x1B27340", VA = "0x1B27340")]
	private void Toggle(bool val)
	{
	}

	[Token(Token = "0x6006BFF")]
	[Address(RVA = "0x1B27910", Offset = "0x1B27910", VA = "0x1B27910")]
	public void SetActiveNewBadge(bool isActive)
	{
	}

	[Token(Token = "0x6006C00")]
	[Address(RVA = "0x1B276FC", Offset = "0x1B276FC", VA = "0x1B276FC")]
	private void ColorLblChange(bool isActive)
	{
	}

	[Token(Token = "0x6006C01")]
	[Address(RVA = "0x1B27500", Offset = "0x1B27500", VA = "0x1B27500")]
	private void ColorChange(bool isActive)
	{
	}

	[Token(Token = "0x6006C02")]
	[Address(RVA = "0x1B27758", Offset = "0x1B27758", VA = "0x1B27758")]
	private void TabRarityColorChange(bool isActive)
	{
	}

	[Token(Token = "0x6006C03")]
	[Address(RVA = "0x1B279F0", Offset = "0x1B279F0", VA = "0x1B279F0")]
	public void TabBaseWhiteColor()
	{
	}
}
