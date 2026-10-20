using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E76")]
public class XWidget_ToggleTab : MonoBehaviour
{
	[Token(Token = "0x4004BC9")]
	[FieldOffset(Offset = "0xC")]
	public UILabel lblTitle;

	[Token(Token = "0x4004BCA")]
	[FieldOffset(Offset = "0x10")]
	public GameObject[] onActive;

	[Token(Token = "0x4004BCB")]
	[FieldOffset(Offset = "0x14")]
	public GameObject[] onDeactive;

	[Token(Token = "0x4004BCC")]
	[FieldOffset(Offset = "0x18")]
	private UIWidget[] m_widgets;

	[Token(Token = "0x4004BCD")]
	[FieldOffset(Offset = "0x1C")]
	private Color[] m_colors;

	[Token(Token = "0x4004BCE")]
	[FieldOffset(Offset = "0x20")]
	private Action m_onClick;

	[Token(Token = "0x4004BCF")]
	[FieldOffset(Offset = "0x24")]
	public GameObject newBadge;

	[Token(Token = "0x4004BD0")]
	[FieldOffset(Offset = "0x28")]
	public GameObject tabLock;

	[Token(Token = "0x4004BD1")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject disableRect;

	[Token(Token = "0x4004BD2")]
	[FieldOffset(Offset = "0x30")]
	public bool disableColorUse;

	[Token(Token = "0x4004BD3")]
	[FieldOffset(Offset = "0x31")]
	public bool textRarityColorUse;

	[Token(Token = "0x4004BD4")]
	[FieldOffset(Offset = "0x34")]
	private int m_index;

	[Token(Token = "0x6006BEB")]
	[Address(RVA = "0x1B25E20", Offset = "0x1B25E20", VA = "0x1B25E20")]
	public XWidget_ToggleTab()
	{
	}

	[Token(Token = "0x6006BEC")]
	[Address(RVA = "0x1B25E30", Offset = "0x1B25E30", VA = "0x1B25E30")]
	private void Awake()
	{
	}

	[Token(Token = "0x6006BED")]
	[Address(RVA = "0x1B26044", Offset = "0x1B26044", VA = "0x1B26044")]
	public void Build(string title, Action onClick, int index = 0, bool bLock = false)
	{
	}

	[Token(Token = "0x6006BEE")]
	[Address(RVA = "0x1B261FC", Offset = "0x1B261FC", VA = "0x1B261FC")]
	public void OnClickThisTab()
	{
	}

	[Token(Token = "0x6006BEF")]
	[Address(RVA = "0x1B262E0", Offset = "0x1B262E0", VA = "0x1B262E0")]
	public void OnTabClicked(XWidget_ToggleTab tab)
	{
	}

	[Token(Token = "0x6006BF0")]
	[Address(RVA = "0x1B26630", Offset = "0x1B26630", VA = "0x1B26630")]
	public void OnTabClickedReset()
	{
	}

	[Token(Token = "0x6006BF1")]
	[Address(RVA = "0x1B2639C", Offset = "0x1B2639C", VA = "0x1B2639C")]
	private void Toggle(bool val)
	{
	}

	[Token(Token = "0x6006BF2")]
	[Address(RVA = "0x1B26944", Offset = "0x1B26944", VA = "0x1B26944")]
	public void SetActiveNewBadge(bool isActive)
	{
	}

	[Token(Token = "0x6006BF3")]
	[Address(RVA = "0x1B26A24", Offset = "0x1B26A24", VA = "0x1B26A24")]
	public bool IsNew()
	{
		return default(bool);
	}

	[Token(Token = "0x6006BF4")]
	[Address(RVA = "0x1B26638", Offset = "0x1B26638", VA = "0x1B26638")]
	private void ColorChange(bool isActive)
	{
	}

	[Token(Token = "0x6006BF5")]
	[Address(RVA = "0x1B267C0", Offset = "0x1B267C0", VA = "0x1B267C0")]
	private void TabTextRarityColorChange(bool isActive)
	{
	}

	[Token(Token = "0x6006BF6")]
	[Address(RVA = "0x1B26B08", Offset = "0x1B26B08", VA = "0x1B26B08")]
	public void TabBaseWhiteColor()
	{
	}
}
