using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000FB4")]
public class XWidget_OptionGameTab : XUIBaseWidget
{
	[Token(Token = "0x400533E")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject ComboBoxGraphicHigh;

	[Token(Token = "0x400533F")]
	[FieldOffset(Offset = "0x20")]
	public GameObject ComboBoxGraphicMiddle;

	[Token(Token = "0x4005340")]
	[FieldOffset(Offset = "0x24")]
	public GameObject ComboBoxGraphicLow;

	[Token(Token = "0x4005341")]
	[FieldOffset(Offset = "0x28")]
	public GameObject ComboBoxFrameHigh;

	[Token(Token = "0x4005342")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject ComboBoxFrameMiddle;

	[Token(Token = "0x4005343")]
	[FieldOffset(Offset = "0x30")]
	public GameObject ComboBoxFrameLow;

	[Token(Token = "0x4005344")]
	[FieldOffset(Offset = "0x34")]
	public GameObject ComboBoxVirtualPadStaticModeApply;

	[Token(Token = "0x4005345")]
	[FieldOffset(Offset = "0x38")]
	public GameObject ComboBoxVirtualPadStaticModeNotApply;

	[Token(Token = "0x4005346")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject ComboBoxIngamePlayRecordShow;

	[Token(Token = "0x4005347")]
	[FieldOffset(Offset = "0x40")]
	public GameObject ComboBoxIngamePlayRecordHide;

	[Token(Token = "0x4005348")]
	[FieldOffset(Offset = "0x44")]
	public UISlider BGM_Slider;

	[Token(Token = "0x4005349")]
	[FieldOffset(Offset = "0x48")]
	public UISprite sprBGMNoSound;

	[Token(Token = "0x400534A")]
	[FieldOffset(Offset = "0x4C")]
	public UISlider SFX_Slider;

	[Token(Token = "0x400534B")]
	[FieldOffset(Offset = "0x50")]
	public UISprite sprSFXNoSound;

	[Token(Token = "0x60074DA")]
	[Address(RVA = "0x1308768", Offset = "0x1308768", VA = "0x1308768")]
	public XWidget_OptionGameTab()
	{
	}

	[Token(Token = "0x60074DB")]
	[Address(RVA = "0x1308770", Offset = "0x1308770", VA = "0x1308770")]
	public void BuildTab()
	{
	}

	[Token(Token = "0x60074DC")]
	[Address(RVA = "0x1309200", Offset = "0x1309200", VA = "0x1309200")]
	public void Show()
	{
	}

	[Token(Token = "0x60074DD")]
	[Address(RVA = "0x130924C", Offset = "0x130924C", VA = "0x130924C")]
	public void OnClickOptionGraphics()
	{
	}

	[Token(Token = "0x60074DE")]
	[Address(RVA = "0x1309580", Offset = "0x1309580", VA = "0x1309580")]
	public void OnClickOptionFrame()
	{
	}

	[Token(Token = "0x60074DF")]
	[Address(RVA = "0x13098B4", Offset = "0x13098B4", VA = "0x13098B4")]
	public void OnClickOptionVirtualPadStaticMode()
	{
	}

	[Token(Token = "0x60074E0")]
	[Address(RVA = "0x1309A28", Offset = "0x1309A28", VA = "0x1309A28")]
	public void OnClickOptionIngamePlayRecord()
	{
	}

	[Token(Token = "0x60074E1")]
	[Address(RVA = "0x1309B9C", Offset = "0x1309B9C", VA = "0x1309B9C")]
	public void OnClickOptionSoundBGM(float val)
	{
	}

	[Token(Token = "0x60074E2")]
	[Address(RVA = "0x1309D2C", Offset = "0x1309D2C", VA = "0x1309D2C")]
	public void OnClickOptionSoundEffect(float val)
	{
	}
}
