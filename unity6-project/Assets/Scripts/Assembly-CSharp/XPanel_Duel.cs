using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D0C")]
public class XPanel_Duel : XPanel_GameBase
{
	[Token(Token = "0x4004246")]
	[FieldOffset(Offset = "0x14")]
	public UILabel lblGameGoal;

	[Token(Token = "0x4004247")]
	[FieldOffset(Offset = "0x18")]
	public UILabel lblRedTeamKillCount;

	[Token(Token = "0x4004248")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel lblBlueTeamKillCount;

	[Token(Token = "0x4004249")]
	[FieldOffset(Offset = "0x20")]
	public GameObject sprScoreBoardLight_ATeam;

	[Token(Token = "0x400424A")]
	[FieldOffset(Offset = "0x24")]
	public TweenAlpha sprScoreBoardLightTween_ATeam;

	[Token(Token = "0x400424B")]
	[FieldOffset(Offset = "0x28")]
	public GameObject sprScoreBoardLight_BTeam;

	[Token(Token = "0x400424C")]
	[FieldOffset(Offset = "0x2C")]
	public TweenAlpha sprScoreBoardLightTweeb_BTeam;

	[Token(Token = "0x6005F21")]
	[Address(RVA = "0x16B6474", Offset = "0x16B6474", VA = "0x16B6474")]
	public XPanel_Duel()
	{
	}

	[Token(Token = "0x6005F22")]
	[Address(RVA = "0x16B647C", Offset = "0x16B647C", VA = "0x16B647C")]
	public void Init()
	{
	}

	[Token(Token = "0x6005F23")]
	[Address(RVA = "0x16B6628", Offset = "0x16B6628", VA = "0x16B6628")]
	public void OnNetdataUpdated_GameData(object arg)
	{
	}

	[Token(Token = "0x6005F24")]
	[Address(RVA = "0x16B6644", Offset = "0x16B6644", VA = "0x16B6644")]
	public void StartSelectedMyTeamAlarm()
	{
	}

	[Token(Token = "0x6005F25")]
	[Address(RVA = "0x16B678C", Offset = "0x16B678C", VA = "0x16B678C")]
	public void StopSelectedMyTeamAlarmTween()
	{
	}

	[Token(Token = "0x6005F26")]
	[Address(RVA = "0x16B6820", Offset = "0x16B6820", VA = "0x16B6820")]
	public void Build(XPlayer mine, XPlayer enemy, int round)
	{
	}

	[Token(Token = "0x6005F27")]
	[Address(RVA = "0x16B6AC4", Offset = "0x16B6AC4", VA = "0x16B6AC4", Slot = "4")]
	protected override void RefreshTime()
	{
	}

	[Token(Token = "0x6005F28")]
	[Address(RVA = "0x16B6C84", Offset = "0x16B6C84", VA = "0x16B6C84")]
	public void Update()
	{
	}

	[Token(Token = "0x6005F29")]
	[Address(RVA = "0x16B6CC8", Offset = "0x16B6CC8", VA = "0x16B6CC8")]
	private void BuildTeamInfos(List<PhotonPlayer> infos, XWidget_Sprite[] icons, UILabel killCount)
	{
	}
}
