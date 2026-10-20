using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D21")]
public class XPanel_ZombieTag : XPanel_GameBase
{
	[Token(Token = "0x4004337")]
	[FieldOffset(Offset = "0x14")]
	public UILabel lblRedTeamKillCount;

	[Token(Token = "0x4004338")]
	[FieldOffset(Offset = "0x18")]
	public UILabel lblBlueTeamKillCount;

	[Token(Token = "0x4004339")]
	[FieldOffset(Offset = "0x1C")]
	private XGameModeZombieTag m_GameMode;

	[Token(Token = "0x400433A")]
	[FieldOffset(Offset = "0x20")]
	public GameObject sprScoreBoardLight_ATeam;

	[Token(Token = "0x400433B")]
	[FieldOffset(Offset = "0x24")]
	public TweenAlpha sprScoreBoardLightTween_ATeam;

	[Token(Token = "0x400433C")]
	[FieldOffset(Offset = "0x28")]
	public GameObject sprScoreBoardLight_BTeam;

	[Token(Token = "0x400433D")]
	[FieldOffset(Offset = "0x2C")]
	public TweenAlpha sprScoreBoardLightTweeb_BTeam;

	[Token(Token = "0x6006033")]
	[Address(RVA = "0xADADB0", Offset = "0xADADB0", VA = "0xADADB0")]
	public XPanel_ZombieTag()
	{
	}

	[Token(Token = "0x6006034")]
	[Address(RVA = "0xADADB8", Offset = "0xADADB8", VA = "0xADADB8")]
	public void Init()
	{
	}

	[Token(Token = "0x6006035")]
	[Address(RVA = "0xADAF8C", Offset = "0xADAF8C", VA = "0xADAF8C")]
	public void StartSelectedMyTeamAlarm()
	{
	}

	[Token(Token = "0x6006036")]
	[Address(RVA = "0xADB1A8", Offset = "0xADB1A8", VA = "0xADB1A8")]
	public void StopSelectedMyTeamAlarmTween()
	{
	}

	[Token(Token = "0x6006037")]
	[Address(RVA = "0xADB23C", Offset = "0xADB23C", VA = "0xADB23C")]
	public void Update()
	{
	}

	[Token(Token = "0x6006038")]
	[Address(RVA = "0xADB0D8", Offset = "0xADB0D8", VA = "0xADB0D8")]
	public void Refresh()
	{
	}
}
