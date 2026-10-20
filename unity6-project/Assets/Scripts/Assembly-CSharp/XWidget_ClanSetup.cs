using System;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using UnityEngine;

[Token(Token = "0x2000EA4")]
public class XWidget_ClanSetup : XUIBaseWidget
{
	[Token(Token = "0x2000EA5")]
	private enum TabType
	{
		[Token(Token = "0x4004CF4")]
		Info = 0,
		[Token(Token = "0x4004CF5")]
		Mark = 1
	}

	[Token(Token = "0x4004CE6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private readonly string Path_Info;

	[Token(Token = "0x4004CE7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly string Path_Mark;

	[Token(Token = "0x4004CE8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private XWidget_ClanSetupInfo _widgetInfo;

	[Token(Token = "0x4004CE9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private XWidget_ClanSetupMark _widgetMark;

	[Token(Token = "0x4004CEA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public XWidget_ToggleTab[] tabs;

	[Token(Token = "0x4004CEB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private TabType tab_type;

	[Token(Token = "0x4004CEC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public UILabel lblClanLvAndName;

	[Token(Token = "0x4004CED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Transform transformClanMark;

	[Token(Token = "0x4004CEE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private Action<Netdata_Clan> m_saveCallBack;

	[Token(Token = "0x4004CEF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private ClanMemberGrade m_grade;

	[Token(Token = "0x4004CF0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private Netdata_Clan m_clanNetdata;

	[Token(Token = "0x4004CF1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int m_rank;

	[Token(Token = "0x4004CF2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private XWidget_ClanMark clanMark;

	[Token(Token = "0x17000DF9")]
	public XWidget_ClanSetupInfo widgetInfo
	{
		[Token(Token = "0x6006D3C")]
		[Address(RVA = "0x15E5CD4", Offset = "0x15E5CD4", VA = "0x15E5CD4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DFA")]
	public XWidget_ClanSetupMark widgetMark
	{
		[Token(Token = "0x6006D3D")]
		[Address(RVA = "0x15E5E98", Offset = "0x15E5E98", VA = "0x15E5E98")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006D3B")]
	[Address(RVA = "0x15E5C34", Offset = "0x15E5C34", VA = "0x15E5C34")]
	public XWidget_ClanSetup()
	{
	}

	[Token(Token = "0x6006D3E")]
	[Address(RVA = "0x15D3DDC", Offset = "0x15D3DDC", VA = "0x15D3DDC")]
	public void Build(ClanMemberGrade grade, Netdata_Clan clanNetdata, int rank, [Optional] Action<Netdata_Clan> saveCallBack)
	{
	}

	[Token(Token = "0x6006D3F")]
	[Address(RVA = "0x15E605C", Offset = "0x15E605C", VA = "0x15E605C")]
	private void SetLeftInfo(Netdata_Clan clanNetdata)
	{
	}

	[Token(Token = "0x6006D40")]
	[Address(RVA = "0x15E6408", Offset = "0x15E6408", VA = "0x15E6408")]
	public void OnClickTabs(int type)
	{
	}

	[Token(Token = "0x6006D41")]
	[Address(RVA = "0x15E6518", Offset = "0x15E6518", VA = "0x15E6518")]
	public void OnClick_TabInfo()
	{
	}

	[Token(Token = "0x6006D42")]
	[Address(RVA = "0x15E654C", Offset = "0x15E654C", VA = "0x15E654C")]
	public void OnClick_TabMark()
	{
	}

	[Token(Token = "0x6006D43")]
	[Address(RVA = "0x15E645C", Offset = "0x15E645C", VA = "0x15E645C")]
	private void BuildTabType(TabType tabs)
	{
	}

	[Token(Token = "0x6006D44")]
	[Address(RVA = "0x15E6580", Offset = "0x15E6580", VA = "0x15E6580")]
	private void WidgetHide()
	{
	}

	[Token(Token = "0x6006D45")]
	[Address(RVA = "0x15E71F8", Offset = "0x15E71F8", VA = "0x15E71F8")]
	public void OnClick_ClanInfoSave()
	{
	}

	[Token(Token = "0x6006D46")]
	[Address(RVA = "0x15E7A20", Offset = "0x15E7A20", VA = "0x15E7A20")]
	private void ShowErrorMessage(ApiReturnCode errorcode)
	{
	}

	[Token(Token = "0x6006D47")]
	[Address(RVA = "0x15E7D8C", Offset = "0x15E7D8C", VA = "0x15E7D8C")]
	private void _003COnClick_ClanInfoSave_003Em__402(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
	{
	}
}
