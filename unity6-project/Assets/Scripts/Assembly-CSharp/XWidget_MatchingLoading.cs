using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000EB9")]
public class XWidget_MatchingLoading : MonoSingleton<XWidget_MatchingLoading>
{
	[Token(Token = "0x4004D70")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private GameObject m_goLoadingContents;

	[Token(Token = "0x4004D71")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public List<XWidget_CharactersInfo> m_liRedTeamCharacterInfo;

	[Token(Token = "0x4004D72")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public List<XWidget_CharactersInfo> m_liBlueTeamCharacterInfo;

	[Token(Token = "0x4004D73")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public XWidget_MatchingLoadingClanInfo m_RedMatchingLoadingClanInfo;

	[Token(Token = "0x4004D74")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public XWidget_MatchingLoadingClanInfo m_BlueMatchingLoadingClanInfo;

	[Token(Token = "0x4004D75")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public UI2DSprite sprBG;

	[Token(Token = "0x4004D76")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private string bgPath;

	[Token(Token = "0x4004D77")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static bool initialized;

	[Token(Token = "0x4004D78")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private UICamera m_camera;

	[Token(Token = "0x4004D79")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private XUIMessageBox m_messageBox;

	[Token(Token = "0x4004D7A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Action m_onDirectionComplete;

	[Token(Token = "0x4004D7B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static Predicate<MatchPlayerInfo> _003C_003Ef__am_0024cacheB;

	[Token(Token = "0x4004D7C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Predicate<MatchPlayerInfo> _003C_003Ef__am_0024cacheC;

	[Token(Token = "0x4004D7D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private static Predicate<XPlayer> _003C_003Ef__am_0024cacheD;

	[Token(Token = "0x17000DFD")]
	private XUIMessageBox messageBox
	{
		[Token(Token = "0x6006DB3")]
		[Address(RVA = "0x145E53C", Offset = "0x145E53C", VA = "0x145E53C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DFE")]
	public override bool WillDestroyOnLoad
	{
		[Token(Token = "0x6006DB4")]
		[Address(RVA = "0x145E754", Offset = "0x145E754", VA = "0x145E754", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6006DB0")]
	[Address(RVA = "0x145DFF8", Offset = "0x145DFF8", VA = "0x145DFF8")]
	public XWidget_MatchingLoading()
	{
	}

	[Token(Token = "0x6006DB2")]
	[Address(RVA = "0x145E0CC", Offset = "0x145E0CC", VA = "0x145E0CC", Slot = "5")]
	public override void Init()
	{
	}

	[Token(Token = "0x6006DB5")]
	[Address(RVA = "0x145E75C", Offset = "0x145E75C", VA = "0x145E75C")]
	public static bool IsMatchingLoadingActivity()
	{
		return default(bool);
	}

	[Token(Token = "0x6006DB6")]
	[Address(RVA = "0x145E898", Offset = "0x145E898", VA = "0x145E898")]
	private void LoadBackGround()
	{
	}

	[Token(Token = "0x6006DB7")]
	[Address(RVA = "0x145EA04", Offset = "0x145EA04", VA = "0x145EA04")]
	private void UnloadSprite()
	{
	}

	[Token(Token = "0x6006DB8")]
	[Address(RVA = "0x145EC38", Offset = "0x145EC38", VA = "0x145EC38")]
	private void UnloadTierSprite(List<XWidget_CharactersInfo> teamInfo)
	{
	}

	[Token(Token = "0x6006DB9")]
	[Address(RVA = "0x145EE48", Offset = "0x145EE48", VA = "0x145EE48")]
	private void BuildClanInfo(List<MatchPlayerInfo> matchPlayerInfoList, XTeamEnum teamEnum)
	{
	}

	[Token(Token = "0x6006DBA")]
	[Address(RVA = "0x145F710", Offset = "0x145F710", VA = "0x145F710")]
	private void BuildClanInfo(MatchPlayerInfo clanInfo, XTeamEnum teamEnum)
	{
	}

	[Token(Token = "0x6006DBB")]
	[Address(RVA = "0x145F828", Offset = "0x145F828", VA = "0x145F828")]
	private void ResetWidgetPlayerInfo()
	{
	}

	[Token(Token = "0x6006DBC")]
	[Address(RVA = "0x145FA38", Offset = "0x145FA38", VA = "0x145FA38")]
	private void BuildRedTeamPlayer(List<MatchPlayerInfo> liRedTeamPlayer)
	{
	}

	[Token(Token = "0x6006DBD")]
	[Address(RVA = "0x145FB94", Offset = "0x145FB94", VA = "0x145FB94")]
	private void BuildBlueTeamPlayer(List<MatchPlayerInfo> liBlueTeamPlayer)
	{
	}

	[Token(Token = "0x6006DBE")]
	[Address(RVA = "0x145FCF0", Offset = "0x145FCF0", VA = "0x145FCF0")]
	public void Show(List<MatchPlayerInfo> liMatchPlayerInfo, Action onDirectionComplete, float invokeTime = 0f)
	{
	}

	[Token(Token = "0x6006DBF")]
	[Address(RVA = "0x146066C", Offset = "0x146066C", VA = "0x146066C")]
	public static void HideStatic()
	{
	}

	[Token(Token = "0x6006DC0")]
	[Address(RVA = "0x1460798", Offset = "0x1460798", VA = "0x1460798")]
	public void Hide()
	{
	}

	[Token(Token = "0x6006DC1")]
	[Address(RVA = "0x14607DC", Offset = "0x14607DC", VA = "0x14607DC")]
	public void OnDirectionComplete()
	{
	}

	[Token(Token = "0x6006DC2")]
	[Address(RVA = "0x1460808", Offset = "0x1460808", VA = "0x1460808")]
	public static void UpdatePlayerLoadingStateStatic(XPlayer player)
	{
	}

	[Token(Token = "0x6006DC3")]
	[Address(RVA = "0x146093C", Offset = "0x146093C", VA = "0x146093C")]
	internal void UpdatePlayerLoadingState(XPlayer player)
	{
	}

	[Token(Token = "0x6006DC4")]
	[Address(RVA = "0x1460D24", Offset = "0x1460D24", VA = "0x1460D24")]
	private void FillInThePlayerInfo(XPlayer _player)
	{
	}

	[Token(Token = "0x6006DC5")]
	[Address(RVA = "0x1460A58", Offset = "0x1460A58", VA = "0x1460A58")]
	private XWidget_CharactersInfo FindWidgetPlayer(XPlayer xPlayer)
	{
		return null;
	}

	[Token(Token = "0x6006DC6")]
	[Address(RVA = "0x1460E6C", Offset = "0x1460E6C", VA = "0x1460E6C")]
	private XWidget_CharactersInfo GetNonActiveWidgetCharacterInfo(XTeamEnum team)
	{
		return null;
	}

	[Token(Token = "0x6006DC7")]
	[Address(RVA = "0x1461078", Offset = "0x1461078", VA = "0x1461078")]
	public static void UpdatePlayersAllReadyStateStatic(List<XPlayer> liPlayer)
	{
	}

	[Token(Token = "0x6006DC8")]
	[Address(RVA = "0x14611AC", Offset = "0x14611AC", VA = "0x14611AC")]
	internal void UpdatePlayersAllReadyState(List<XPlayer> liPlayer)
	{
	}

	[Token(Token = "0x6006DC9")]
	[Address(RVA = "0x1461570", Offset = "0x1461570", VA = "0x1461570")]
	public IUIBackbutton ShowMessageBox(string strTitle, string strMessage, XMessageBoxButtons nButtons, [Optional] Action delegateOK, [Optional] Action delegateCancle, [Optional] Action delegateLink, [Optional][DefaultParameterValue("")] string strLink, [Optional][DefaultParameterValue(false)] bool forceAlignmentLeft, [Optional] string okText, [Optional] string cancleText, [Optional] string linkText, int backgroundWidth = 606, int backgroundHeight = 406)
	{
		return null;
	}

	[Token(Token = "0x6006DCA")]
	[Address(RVA = "0x14616C4", Offset = "0x14616C4", VA = "0x14616C4")]
	public void HideMessageBox(bool doEventHandler = false)
	{
	}

	[Token(Token = "0x6006DCB")]
	[Address(RVA = "0x14617F8", Offset = "0x14617F8", VA = "0x14617F8")]
	private static bool _003CShow_003Em__40F(MatchPlayerInfo item)
	{
		return default(bool);
	}

	[Token(Token = "0x6006DCC")]
	[Address(RVA = "0x1461824", Offset = "0x1461824", VA = "0x1461824")]
	private static bool _003CShow_003Em__410(MatchPlayerInfo item)
	{
		return default(bool);
	}

	[Token(Token = "0x6006DCD")]
	[Address(RVA = "0x1461854", Offset = "0x1461854", VA = "0x1461854")]
	private static bool _003CUpdatePlayersAllReadyState_003Em__411(XPlayer item)
	{
		return default(bool);
	}
}
