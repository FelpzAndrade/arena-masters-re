using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2001050")]
public class XPanel_Title : MonoBehaviour
{
	[Token(Token = "0x40057F0")]
	[FieldOffset(Offset = "0x0")]
	public static string titleLogoPath;

	[Token(Token = "0x40057F1")]
	[FieldOffset(Offset = "0xC")]
	public GameObject TitleObject;

	[Token(Token = "0x40057F2")]
	[FieldOffset(Offset = "0x10")]
	public UI2DSprite sprSubTitleUI;

	[Token(Token = "0x40057F3")]
	[FieldOffset(Offset = "0x14")]
	public UI2DSprite sprTitleUI;

	[Token(Token = "0x40057F4")]
	[FieldOffset(Offset = "0x18")]
	public UI2DSprite sprTitleBackgroundUI;

	[Token(Token = "0x40057F5")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject TitleLogoEffect;

	[Token(Token = "0x40057F6")]
	[FieldOffset(Offset = "0x20")]
	public GameObject TitleLogoEffect_TW;

	[Token(Token = "0x40057F7")]
	[FieldOffset(Offset = "0x24")]
	public UI2DSprite sprGradeUI;

	[Token(Token = "0x40057F8")]
	[FieldOffset(Offset = "0x28")]
	public GameObject networkLoading;

	[Token(Token = "0x40057F9")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject goTouchScreen;

	[Token(Token = "0x40057FA")]
	[FieldOffset(Offset = "0x30")]
	public Transform parentRegionBtn;

	[Token(Token = "0x40057FB")]
	[FieldOffset(Offset = "0x34")]
	private XWidget_RegionButton regionBtn;

	[Token(Token = "0x60079B3")]
	[Address(RVA = "0xAD01D4", Offset = "0xAD01D4", VA = "0xAD01D4")]
	public XPanel_Title()
	{
	}

	[Token(Token = "0x60079B5")]
	[Address(RVA = "0xAD02B0", Offset = "0xAD02B0", VA = "0xAD02B0")]
	private void BuildCountryTitleInfo(string country)
	{
	}

	[Token(Token = "0x60079B6")]
	[Address(RVA = "0xAD05A8", Offset = "0xAD05A8", VA = "0xAD05A8")]
	private void SetSprite(UI2DSprite spr2D, string strPath)
	{
	}

	[Token(Token = "0x60079B7")]
	[Address(RVA = "0xAD0744", Offset = "0xAD0744", VA = "0xAD0744")]
	private void Awake()
	{
	}

	[Token(Token = "0x60079B8")]
	[Address(RVA = "0xAD0954", Offset = "0xAD0954", VA = "0xAD0954")]
	public void ShowTitleObject()
	{
	}

	[Token(Token = "0x60079B9")]
	[Address(RVA = "0xAD0A78", Offset = "0xAD0A78", VA = "0xAD0A78")]
	public void ShowTitleLogoEffect()
	{
	}

	[Token(Token = "0x60079BA")]
	[Address(RVA = "0xAD0B68", Offset = "0xAD0B68", VA = "0xAD0B68")]
	public void ShowTouchToPlay()
	{
	}

	[Token(Token = "0x60079BB")]
	[Address(RVA = "0xAD0C3C", Offset = "0xAD0C3C", VA = "0xAD0C3C")]
	public void ShowRegionPopup(bool isBackable)
	{
	}

	[Token(Token = "0x60079BC")]
	[Address(RVA = "0xAD0D20", Offset = "0xAD0D20", VA = "0xAD0D20")]
	private void LoadRegionBtn()
	{
	}

	[Token(Token = "0x60079BD")]
	[Address(RVA = "0xAD1000", Offset = "0xAD1000", VA = "0xAD1000")]
	public void Show()
	{
	}

	[Token(Token = "0x60079BE")]
	[Address(RVA = "0xAD07C0", Offset = "0xAD07C0", VA = "0xAD07C0")]
	public void ShowTouchScreen(bool bShow)
	{
	}

	[Token(Token = "0x60079BF")]
	[Address(RVA = "0xAD07EC", Offset = "0xAD07EC", VA = "0xAD07EC")]
	public void SetEnableRegionChange(bool bEnable)
	{
	}

	[Token(Token = "0x60079C0")]
	[Address(RVA = "0xAD113C", Offset = "0xAD113C", VA = "0xAD113C")]
	public void RefreshRegionButtonText()
	{
	}

	[Token(Token = "0x60079C1")]
	[Address(RVA = "0xAD1214", Offset = "0xAD1214", VA = "0xAD1214")]
	public void Hide()
	{
	}

	[Token(Token = "0x60079C2")]
	[Address(RVA = "0xAD105C", Offset = "0xAD105C", VA = "0xAD105C")]
	public void ShowNetworkLoadingIcon(bool bshow)
	{
	}

	[Token(Token = "0x60079C3")]
	[Address(RVA = "0xAD1248", Offset = "0xAD1248", VA = "0xAD1248")]
	public void StartLogin()
	{
	}

	[Token(Token = "0x60079C4")]
	[Address(RVA = "0xAD13E8", Offset = "0xAD13E8", VA = "0xAD13E8")]
	public void ShowLogin()
	{
	}
}
