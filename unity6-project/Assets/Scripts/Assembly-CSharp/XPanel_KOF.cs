using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D15")]
public class XPanel_KOF : XPanel_GameBase
{
	[Token(Token = "0x40042CF")]
	[FieldOffset(Offset = "0x14")]
	public UILabel lblGameGoal;

	[Token(Token = "0x40042D0")]
	[FieldOffset(Offset = "0x18")]
	public UILabel lblRedTeamKillCount;

	[Token(Token = "0x40042D1")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel lblBlueTeamKillCount;

	[Token(Token = "0x40042D2")]
	[FieldOffset(Offset = "0x20")]
	public GameObject sprScoreBoardLight_ATeam;

	[Token(Token = "0x40042D3")]
	[FieldOffset(Offset = "0x24")]
	public TweenAlpha sprScoreBoardLightTween_ATeam;

	[Token(Token = "0x40042D4")]
	[FieldOffset(Offset = "0x28")]
	public GameObject sprScoreBoardLight_BTeam;

	[Token(Token = "0x40042D5")]
	[FieldOffset(Offset = "0x2C")]
	public TweenAlpha sprScoreBoardLightTweeb_BTeam;

	[Token(Token = "0x40042D6")]
	[FieldOffset(Offset = "0x30")]
	public UI2DSprite[] sprRedTeamLifes;

	[Token(Token = "0x40042D7")]
	[FieldOffset(Offset = "0x34")]
	public UI2DSprite[] sprBlueTeamLifes;

	[Token(Token = "0x40042D8")]
	[FieldOffset(Offset = "0x38")]
	public XWidget_CharSelectMode SelectModeUI;

	[Token(Token = "0x40042D9")]
	[FieldOffset(Offset = "0x3C")]
	public XUIIngameCustomMessage IngameCustomMessage;

	[Token(Token = "0x40042DA")]
	[FieldOffset(Offset = "0x40")]
	public XUIRelayMatchGameStartUI RelayMatchGameStartUI;

	[Token(Token = "0x6005FB8")]
	[Address(RVA = "0xFF952C", Offset = "0xFF952C", VA = "0xFF952C")]
	public XPanel_KOF()
	{
	}

	[Token(Token = "0x6005FB9")]
	[Address(RVA = "0xFF9534", Offset = "0xFF9534", VA = "0xFF9534")]
	public void Init()
	{
	}

	[Token(Token = "0x6005FBA")]
	[Address(RVA = "0xFF96F4", Offset = "0xFF96F4", VA = "0xFF96F4")]
	public void OpenSelectModeUI(bool isActive)
	{
	}

	[Token(Token = "0x6005FBB")]
	[Address(RVA = "0xFF9720", Offset = "0xFF9720", VA = "0xFF9720")]
	public void OnNetdataUpdated_GameData(object arg)
	{
	}

	[Token(Token = "0x6005FBC")]
	[Address(RVA = "0xFF973C", Offset = "0xFF973C", VA = "0xFF973C")]
	public void StartSelectedMyTeamAlarm()
	{
	}

	[Token(Token = "0x6005FBD")]
	[Address(RVA = "0xFF9884", Offset = "0xFF9884", VA = "0xFF9884")]
	public void StopSelectedMyTeamAlarmTween()
	{
	}

	[Token(Token = "0x6005FBE")]
	[Address(RVA = "0xFF9918", Offset = "0xFF9918", VA = "0xFF9918")]
	public void Update()
	{
	}

	[Token(Token = "0x6005FBF")]
	[Address(RVA = "0xFF995C", Offset = "0xFF995C", VA = "0xFF995C", Slot = "4")]
	protected override void RefreshTime()
	{
	}

	[Token(Token = "0x6005FC0")]
	[Address(RVA = "0xFF9B1C", Offset = "0xFF9B1C", VA = "0xFF9B1C")]
	public void Build(List<XPlayer> myTeam, List<XPlayer> enemyTeam, int round)
	{
	}

	[Token(Token = "0x6005FC1")]
	[Address(RVA = "0xFF9E84", Offset = "0xFF9E84", VA = "0xFF9E84")]
	public void SetLifeUI(List<XPlayer> myTeamList, List<XPlayer> enemyTeamList)
	{
	}

	[Token(Token = "0x6005FC2")]
	[Address(RVA = "0xFF9F28", Offset = "0xFF9F28", VA = "0xFF9F28")]
	private void BuildProfileIcon(XTeamEnum myTeam, XModuleActor myActor, XTeamEnum enemyTeam, XModuleActor enemyActor)
	{
	}

	[Token(Token = "0x6005FC3")]
	[Address(RVA = "0xFFA2AC", Offset = "0xFFA2AC", VA = "0xFFA2AC")]
	private void SetSprite(XTeamEnum team, XModuleActor actor)
	{
	}

	[Token(Token = "0x6005FC4")]
	[Address(RVA = "0xFFA138", Offset = "0xFFA138", VA = "0xFFA138")]
	public void CheckAndBuildDeathProfileIcon(List<XPlayer> player, XTeamEnum team)
	{
	}

	[Token(Token = "0x6005FC5")]
	[Address(RVA = "0xFFA604", Offset = "0xFFA604", VA = "0xFFA604")]
	public void ShowIngameCustomMessage(string strMsgKey, float duration)
	{
	}

	[Token(Token = "0x6005FC6")]
	[Address(RVA = "0xFFA630", Offset = "0xFFA630", VA = "0xFFA630")]
	public void ShowRelayMatchGameStartUI(int round)
	{
	}

	[Token(Token = "0x6005FC7")]
	[Address(RVA = "0xFFA65C", Offset = "0xFFA65C", VA = "0xFFA65C")]
	public void OnClick_test()
	{
	}
}
