using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E02")]
public class XPanel_Option : XUIBasePanel
{
	[Token(Token = "0x2000E03")]
	public enum OptionTabType
	{
		[Token(Token = "0x4004976")]
		Game = 0,
		[Token(Token = "0x4004977")]
		Noti = 1,
		[Token(Token = "0x4004978")]
		Lang = 2,
		[Token(Token = "0x4004979")]
		Info = 3
	}

	[Token(Token = "0x4004963")]
	[FieldOffset(Offset = "0x10")]
	private XUIBaseWidget m_currentTabUI;

	[Token(Token = "0x4004964")]
	[FieldOffset(Offset = "0x14")]
	public OptionTabType m_type;

	[Token(Token = "0x4004965")]
	[FieldOffset(Offset = "0x18")]
	public XWidget_ToggleTab[] tabArray;

	[Token(Token = "0x4004966")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton btnConsole;

	[Token(Token = "0x4004967")]
	[FieldOffset(Offset = "0x20")]
	public Transform tabRoot;

	[Token(Token = "0x4004968")]
	[FieldOffset(Offset = "0x24")]
	private readonly string Path_GameTab;

	[Token(Token = "0x4004969")]
	[FieldOffset(Offset = "0x28")]
	private readonly string Path_InfoTab;

	[Token(Token = "0x400496A")]
	[FieldOffset(Offset = "0x2C")]
	private readonly string Path_LangTab;

	[Token(Token = "0x400496B")]
	[FieldOffset(Offset = "0x30")]
	private readonly string Path_NotiTab;

	[Token(Token = "0x400496C")]
	[FieldOffset(Offset = "0x34")]
	private XWidget_OptionGameTab _GameTab;

	[Token(Token = "0x400496D")]
	[FieldOffset(Offset = "0x38")]
	private XWidget_OptionNotiTab _NotiTab;

	[Token(Token = "0x400496E")]
	[FieldOffset(Offset = "0x3C")]
	private XWidget_OptionLangTab _LangTab;

	[Token(Token = "0x400496F")]
	[FieldOffset(Offset = "0x40")]
	private XWidget_OptionInfoTab _InfoTab;

	[Token(Token = "0x4004970")]
	[FieldOffset(Offset = "0x44")]
	private int m_startingGraphicQuality;

	[Token(Token = "0x4004971")]
	[FieldOffset(Offset = "0x48")]
	private int m_startingFrameRate;

	[Token(Token = "0x4004972")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject OptionWindow;

	[Token(Token = "0x4004973")]
	[FieldOffset(Offset = "0x50")]
	private XPanel_TopBanner topBanner;

	[Token(Token = "0x4004974")]
	[FieldOffset(Offset = "0x0")]
	private static Action _003C_003Ef__am_0024cache11;

	[Token(Token = "0x17000D78")]
	private XWidget_OptionGameTab GameTab
	{
		[Token(Token = "0x60067F5")]
		[Address(RVA = "0x100C240", Offset = "0x100C240", VA = "0x100C240")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D79")]
	private XWidget_OptionNotiTab NotiTab
	{
		[Token(Token = "0x60067F6")]
		[Address(RVA = "0x100C330", Offset = "0x100C330", VA = "0x100C330")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D7A")]
	private XWidget_OptionLangTab LangTab
	{
		[Token(Token = "0x60067F7")]
		[Address(RVA = "0x100C420", Offset = "0x100C420", VA = "0x100C420")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D7B")]
	private XWidget_OptionInfoTab InfoTab
	{
		[Token(Token = "0x60067F8")]
		[Address(RVA = "0x100C510", Offset = "0x100C510", VA = "0x100C510")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60067F4")]
	[Address(RVA = "0x100C178", Offset = "0x100C178", VA = "0x100C178")]
	public XPanel_Option()
	{
	}

	[Token(Token = "0x60067F9")]
	[Address(RVA = "0x100C600", Offset = "0x100C600", VA = "0x100C600")]
	public void BuildTabType(OptionTabType type)
	{
	}

	[Token(Token = "0x60067FA")]
	[Address(RVA = "0x100C8F8", Offset = "0x100C8F8", VA = "0x100C8F8")]
	private void WidgetHide()
	{
	}

	[Token(Token = "0x60067FB")]
	[Address(RVA = "0x100C9FC", Offset = "0x100C9FC", VA = "0x100C9FC")]
	public void Build()
	{
	}

	[Token(Token = "0x60067FC")]
	[Address(RVA = "0x100CB18", Offset = "0x100CB18", VA = "0x100CB18")]
	private void BuildTab()
	{
	}

	[Token(Token = "0x60067FD")]
	[Address(RVA = "0x100CC28", Offset = "0x100CC28", VA = "0x100CC28")]
	private void SetConsoleButton()
	{
	}

	[Token(Token = "0x60067FE")]
	[Address(RVA = "0x100CD14", Offset = "0x100CD14", VA = "0x100CD14")]
	public void OnClickTabs(OptionTabType type)
	{
	}

	[Token(Token = "0x60067FF")]
	[Address(RVA = "0x100CD68", Offset = "0x100CD68", VA = "0x100CD68")]
	private void Save()
	{
	}

	[Token(Token = "0x6006800")]
	[Address(RVA = "0x100CE24", Offset = "0x100CE24", VA = "0x100CE24")]
	public void OnClick_Console()
	{
	}

	[Token(Token = "0x6006801")]
	[Address(RVA = "0x100CF24", Offset = "0x100CF24", VA = "0x100CF24")]
	public void OnClickGameTab()
	{
	}

	[Token(Token = "0x6006802")]
	[Address(RVA = "0x100CF58", Offset = "0x100CF58", VA = "0x100CF58")]
	public void OnClickNotificationTab()
	{
	}

	[Token(Token = "0x6006803")]
	[Address(RVA = "0x100CF8C", Offset = "0x100CF8C", VA = "0x100CF8C")]
	public void OnClickLanguageTab()
	{
	}

	[Token(Token = "0x6006804")]
	[Address(RVA = "0x100CFC0", Offset = "0x100CFC0", VA = "0x100CFC0")]
	public void OnClicInfomationTab()
	{
	}

	[Token(Token = "0x6006805")]
	[Address(RVA = "0x100CFF4", Offset = "0x100CFF4", VA = "0x100CFF4")]
	public void OnClickClose()
	{
	}

	[Token(Token = "0x6006806")]
	[Address(RVA = "0x100D358", Offset = "0x100D358", VA = "0x100D358")]
	public void OnClickOptionGraphics()
	{
	}

	[Token(Token = "0x6006807")]
	[Address(RVA = "0x100D6E8", Offset = "0x100D6E8", VA = "0x100D6E8")]
	public void OnClickOptionFrame()
	{
	}

	[Token(Token = "0x6006808")]
	[Address(RVA = "0x100DA78", Offset = "0x100DA78", VA = "0x100DA78")]
	public void OnClickOptionVirtualPadStaticMode()
	{
	}

	[Token(Token = "0x6006809")]
	[Address(RVA = "0x100DC4C", Offset = "0x100DC4C", VA = "0x100DC4C")]
	public void OnClickOptionPushAlarm()
	{
	}

	[Token(Token = "0x600680A")]
	[Address(RVA = "0x100DE58", Offset = "0x100DE58", VA = "0x100DE58")]
	public void OnClickOptionVibration()
	{
	}

	[Token(Token = "0x600680B")]
	[Address(RVA = "0x100E02C", Offset = "0x100E02C", VA = "0x100E02C")]
	private static void _003COnClickClose_003Em__39D()
	{
	}
}
