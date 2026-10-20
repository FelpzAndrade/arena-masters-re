using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D08")]
public class XPanel_Annihilation : XPanel_GameBase
{
	[Token(Token = "0x400422C")]
	[FieldOffset(Offset = "0x14")]
	public UILabel lblGameGoal;

	[Token(Token = "0x400422D")]
	[FieldOffset(Offset = "0x18")]
	public UILabel lblRedTeamKillCount;

	[Token(Token = "0x400422E")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel lblBlueTeamKillCount;

	[Token(Token = "0x400422F")]
	[FieldOffset(Offset = "0x20")]
	public GameObject sprScoreBoardLight_ATeam;

	[Token(Token = "0x4004230")]
	[FieldOffset(Offset = "0x24")]
	public TweenAlpha sprScoreBoardLightTween_ATeam;

	[Token(Token = "0x4004231")]
	[FieldOffset(Offset = "0x28")]
	public GameObject sprScoreBoardLight_BTeam;

	[Token(Token = "0x4004232")]
	[FieldOffset(Offset = "0x2C")]
	public TweenAlpha sprScoreBoardLightTweeb_BTeam;

	[Token(Token = "0x4004233")]
	[FieldOffset(Offset = "0x30")]
	public UI2DSprite[] sprRedTeamLifes;

	[Token(Token = "0x4004234")]
	[FieldOffset(Offset = "0x34")]
	public UI2DSprite[] sprBlueTeamLifes;

	[Token(Token = "0x4004235")]
	[FieldOffset(Offset = "0x38")]
	private Dictionary<string, UI2DSprite> dicProfile;

	[Token(Token = "0x4004236")]
	[FieldOffset(Offset = "0x3C")]
	public XWidget_MatchingLoadingClanInfo ATeamClanInfo;

	[Token(Token = "0x4004237")]
	[FieldOffset(Offset = "0x40")]
	public XWidget_MatchingLoadingClanInfo BTeamClanInfo;

	[Token(Token = "0x6005F03")]
	[Address(RVA = "0x1691AD4", Offset = "0x1691AD4", VA = "0x1691AD4")]
	public XPanel_Annihilation()
	{
	}

	[Token(Token = "0x6005F04")]
	[Address(RVA = "0x1691B80", Offset = "0x1691B80", VA = "0x1691B80")]
	public void Init()
	{
	}

	[Token(Token = "0x6005F05")]
	[Address(RVA = "0x1691D2C", Offset = "0x1691D2C", VA = "0x1691D2C")]
	public void ClanInfoBuild(XTeamEnum teamEnum, MatchPlayerInfo info)
	{
	}

	[Token(Token = "0x6005F06")]
	[Address(RVA = "0x1691E94", Offset = "0x1691E94", VA = "0x1691E94")]
	public void ClanInfoInActive(XTeamEnum teamEnum)
	{
	}

	[Token(Token = "0x6005F07")]
	[Address(RVA = "0x1691FD8", Offset = "0x1691FD8", VA = "0x1691FD8")]
	public void OnNetdataUpdated_GameData(object arg)
	{
	}

	[Token(Token = "0x6005F08")]
	[Address(RVA = "0x1691FF4", Offset = "0x1691FF4", VA = "0x1691FF4")]
	public void StartSelectedMyTeamAlarm()
	{
	}

	[Token(Token = "0x6005F09")]
	[Address(RVA = "0x169213C", Offset = "0x169213C", VA = "0x169213C")]
	public void StopSelectedMyTeamAlarmTween()
	{
	}

	[Token(Token = "0x6005F0A")]
	[Address(RVA = "0x16921D0", Offset = "0x16921D0", VA = "0x16921D0")]
	public void Update()
	{
	}

	[Token(Token = "0x6005F0B")]
	[Address(RVA = "0x1692214", Offset = "0x1692214", VA = "0x1692214", Slot = "4")]
	protected override void RefreshTime()
	{
	}

	[Token(Token = "0x6005F0C")]
	[Address(RVA = "0x16922FC", Offset = "0x16922FC", VA = "0x16922FC")]
	protected int GetRoundRemainedTime()
	{
		return default(int);
	}

	[Token(Token = "0x6005F0D")]
	[Address(RVA = "0x16925A0", Offset = "0x16925A0", VA = "0x16925A0")]
	public void Build(List<XPlayer> myTeam, List<XPlayer> enemyTeam, int round)
	{
	}

	[Token(Token = "0x6005F0E")]
	[Address(RVA = "0x16929C0", Offset = "0x16929C0", VA = "0x16929C0")]
	private void BuildProfileIcon(List<XPlayer> myTeam, List<XPlayer> enemyTeam)
	{
	}

	[Token(Token = "0x6005F0F")]
	[Address(RVA = "0x169298C", Offset = "0x169298C", VA = "0x169298C")]
	public void SetLifeUI(List<XPlayer> myTeam, List<XPlayer> enemyTeam)
	{
	}

	[Token(Token = "0x6005F10")]
	[Address(RVA = "0x1692FAC", Offset = "0x1692FAC", VA = "0x1692FAC")]
	public void CheckAndBuildDeathProfileIcon(List<XPlayer> team)
	{
	}
}
