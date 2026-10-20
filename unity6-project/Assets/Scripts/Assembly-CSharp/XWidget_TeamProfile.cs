using System;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using UnityEngine;

[Token(Token = "0x2000FF6")]
public class XWidget_TeamProfile : XUIBaseWidget
{
	[Token(Token = "0x2000FF7")]
	private sealed class _003CBuildLevel_003Ec__AnonStorey24F
	{
		[Token(Token = "0x400553C")]
		[FieldOffset(Offset = "0x8")]
		internal CSProtoInfoManager_TeamLevel teamProto;

		[Token(Token = "0x6007718")]
		[Address(RVA = "0x1B1A4A8", Offset = "0x1B1A4A8", VA = "0x1B1A4A8")]
		public _003CBuildLevel_003Ec__AnonStorey24F()
		{
		}

		[Token(Token = "0x6007719")]
		[Address(RVA = "0x1B1B304", Offset = "0x1B1B304", VA = "0x1B1B304")]
		internal string _003C_003Em__4EB(int val)
		{
			return null;
		}
	}

	[Token(Token = "0x2000FF8")]
	private sealed class _003CBuildMAXEXP_003Ec__AnonStorey250
	{
		[Token(Token = "0x400553D")]
		[FieldOffset(Offset = "0x8")]
		internal CSProtoInfoManager_TeamLevel teamProto;

		[Token(Token = "0x600771A")]
		[Address(RVA = "0x1B1A4B0", Offset = "0x1B1A4B0", VA = "0x1B1A4B0")]
		public _003CBuildMAXEXP_003Ec__AnonStorey250()
		{
		}

		[Token(Token = "0x600771B")]
		[Address(RVA = "0x1B1B350", Offset = "0x1B1B350", VA = "0x1B1B350")]
		internal bool _003C_003Em__4EC(int val)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4005526")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel lblMyName;

	[Token(Token = "0x4005527")]
	[FieldOffset(Offset = "0x20")]
	public UILabel lblMyEXP;

	[Token(Token = "0x4005528")]
	[FieldOffset(Offset = "0x24")]
	public UILabel lblLv;

	[Token(Token = "0x4005529")]
	[FieldOffset(Offset = "0x28")]
	public UIProgressBar expBar;

	[Token(Token = "0x400552A")]
	[FieldOffset(Offset = "0x2C")]
	public UI2DSprite sprTitle;

	[Token(Token = "0x400552B")]
	[FieldOffset(Offset = "0x30")]
	public UI2DSprite sprMainChar;

	[Token(Token = "0x400552C")]
	[FieldOffset(Offset = "0x34")]
	public GameObject sprGoodManner;

	[Token(Token = "0x400552D")]
	[FieldOffset(Offset = "0x38")]
	public GameObject sprBadManner;

	[Token(Token = "0x400552E")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite sprMannerBackground;

	[Token(Token = "0x400552F")]
	[FieldOffset(Offset = "0x40")]
	public UILabel lblMannerPoint;

	[Token(Token = "0x4005530")]
	[FieldOffset(Offset = "0x44")]
	public XWidget_ProgressBarWithTable prbTeamLevel;

	[Token(Token = "0x4005531")]
	[FieldOffset(Offset = "0x48")]
	public XUITeamInformationList pnlTeamList;

	[Token(Token = "0x4005532")]
	[FieldOffset(Offset = "0x4C")]
	public XWiget_GridBuilder rankInfoBuilder;

	[Token(Token = "0x4005533")]
	[FieldOffset(Offset = "0x50")]
	public XWidget_MostPlayedCharInfo mostPlayedInfo;

	[Token(Token = "0x4005534")]
	[FieldOffset(Offset = "0x54")]
	private readonly string Path_TierTableDetailPopup;

	[Token(Token = "0x4005535")]
	[FieldOffset(Offset = "0x58")]
	private XWidget_TierInfoTable _tierTableDetailPopup;

	[Token(Token = "0x4005536")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject selectCharPopup;

	[Token(Token = "0x4005537")]
	[FieldOffset(Offset = "0x60")]
	public UILabel lblPopupTitle;

	[Token(Token = "0x4005538")]
	[FieldOffset(Offset = "0x64")]
	private XUITeamInformationItem m_item;

	[Token(Token = "0x4005539")]
	[FieldOffset(Offset = "0x68")]
	private int m_nSelectedProfileIconId;

	[Token(Token = "0x400553A")]
	[FieldOffset(Offset = "0x0")]
	private static Action<UILabel, int> _003C_003Ef__am_0024cache14;

	[Token(Token = "0x400553B")]
	[FieldOffset(Offset = "0x4")]
	private static Action<UIProgressBar, int> _003C_003Ef__am_0024cache15;

	[Token(Token = "0x17000EE6")]
	public XWidget_TierInfoTable TierTableDetailPopup
	{
		[Token(Token = "0x6007700")]
		[Address(RVA = "0x1B18FC8", Offset = "0x1B18FC8", VA = "0x1B18FC8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60076FF")]
	[Address(RVA = "0x1B18F3C", Offset = "0x1B18F3C", VA = "0x1B18F3C")]
	public XWidget_TeamProfile()
	{
	}

	[Token(Token = "0x6007701")]
	[Address(RVA = "0x1B190E4", Offset = "0x1B190E4", VA = "0x1B190E4", Slot = "16")]
	public override bool Back()
	{
		return default(bool);
	}

	[Token(Token = "0x6007702")]
	[Address(RVA = "0x1B19160", Offset = "0x1B19160", VA = "0x1B19160")]
	public void Build()
	{
	}

	[Token(Token = "0x6007703")]
	[Address(RVA = "0x1B1A0EC", Offset = "0x1B1A0EC", VA = "0x1B1A0EC")]
	private void BuildMannerPoint()
	{
	}

	[Token(Token = "0x6007704")]
	[Address(RVA = "0x1B19370", Offset = "0x1B19370", VA = "0x1B19370")]
	public void BuildProfileIcon()
	{
	}

	[Token(Token = "0x6007705")]
	[Address(RVA = "0x1B19C70", Offset = "0x1B19C70", VA = "0x1B19C70")]
	public void BuildRankInfo()
	{
	}

	[Token(Token = "0x6007706")]
	[Address(RVA = "0x1B19FC0", Offset = "0x1B19FC0", VA = "0x1B19FC0")]
	public void BuildMostPlayedInfo()
	{
	}

	[Token(Token = "0x6007707")]
	[Address(RVA = "0x1B19974", Offset = "0x1B19974", VA = "0x1B19974")]
	private void BuildName()
	{
	}

	[Token(Token = "0x6007708")]
	[Address(RVA = "0x1B1A360", Offset = "0x1B1A360", VA = "0x1B1A360")]
	public void BuildCharIcon(string iconName, int titleId)
	{
	}

	[Token(Token = "0x6007709")]
	[Address(RVA = "0x1B191F4", Offset = "0x1B191F4", VA = "0x1B191F4")]
	private void BuildTitle()
	{
	}

	[Token(Token = "0x600770A")]
	[Address(RVA = "0x1B194C4", Offset = "0x1B194C4", VA = "0x1B194C4")]
	public void BuildLevel()
	{
	}

	[Token(Token = "0x600770B")]
	[Address(RVA = "0x1B196B8", Offset = "0x1B196B8", VA = "0x1B196B8")]
	public void BuildMAXEXP()
	{
	}

	[Token(Token = "0x600770C")]
	[Address(RVA = "0x1B1A4B8", Offset = "0x1B1A4B8", VA = "0x1B1A4B8")]
	public void OnClick_Crystal()
	{
	}

	[Token(Token = "0x600770D")]
	[Address(RVA = "0x1B1A590", Offset = "0x1B1A590", VA = "0x1B1A590")]
	public void OnClick_Gold()
	{
	}

	[Token(Token = "0x600770E")]
	[Address(RVA = "0x1B1A668", Offset = "0x1B1A668", VA = "0x1B1A668")]
	public void OnClick_Stamina()
	{
	}

	[Token(Token = "0x600770F")]
	[Address(RVA = "0x1B1A740", Offset = "0x1B1A740", VA = "0x1B1A740")]
	public void OnClick_SelectTeamCharacterPopup()
	{
	}

	[Token(Token = "0x6007710")]
	[Address(RVA = "0x1B1A878", Offset = "0x1B1A878", VA = "0x1B1A878")]
	public void SetProfileIconItem(XUITeamInformationItem item)
	{
	}

	[Token(Token = "0x6007711")]
	[Address(RVA = "0x1B1A9E8", Offset = "0x1B1A9E8", VA = "0x1B1A9E8")]
	public void SetSelectCharacter()
	{
	}

	[Token(Token = "0x6007712")]
	[Address(RVA = "0x1B1AAE8", Offset = "0x1B1AAE8", VA = "0x1B1AAE8")]
	private void RequestChangeProfileIcon()
	{
	}

	[Token(Token = "0x6007713")]
	[Address(RVA = "0x1B19130", Offset = "0x1B19130", VA = "0x1B19130")]
	public void HidePopup()
	{
	}

	[Token(Token = "0x6007714")]
	[Address(RVA = "0x1B1ACD0", Offset = "0x1B1ACD0", VA = "0x1B1ACD0")]
	public void OnClick_ShowTierTableDetailPopup()
	{
	}

	[Token(Token = "0x6007715")]
	[Address(RVA = "0x1B1AFB8", Offset = "0x1B1AFB8", VA = "0x1B1AFB8")]
	private static void _003CBuildMAXEXP_003Em__4ED(UILabel label, int val)
	{
	}

	[Token(Token = "0x6007716")]
	[Address(RVA = "0x1B1B110", Offset = "0x1B1B110", VA = "0x1B1B110")]
	private static void _003CBuildMAXEXP_003Em__4EE(UIProgressBar prb, int val)
	{
	}

	[Token(Token = "0x6007717")]
	[Address(RVA = "0x1B1B2C0", Offset = "0x1B1B2C0", VA = "0x1B1B2C0")]
	private void _003CRequestChangeProfileIcon_003Em__4EF(ApiReturnCode result, string errmsg, JObject json)
	{
	}
}
