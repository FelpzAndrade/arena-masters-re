using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D1E")]
public class XPanel_TeamDeath : XPanel_GameBase
{
	[Token(Token = "0x400432D")]
	[FieldOffset(Offset = "0x14")]
	public UILabel lblRedTeamKillCount;

	[Token(Token = "0x400432E")]
	[FieldOffset(Offset = "0x18")]
	public UILabel lblBlueTeamKillCount;

	[Token(Token = "0x400432F")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject sprScoreBoardLight_ATeam;

	[Token(Token = "0x4004330")]
	[FieldOffset(Offset = "0x20")]
	public TweenAlpha sprScoreBoardLightTween_ATeam;

	[Token(Token = "0x4004331")]
	[FieldOffset(Offset = "0x24")]
	public GameObject sprScoreBoardLight_BTeam;

	[Token(Token = "0x4004332")]
	[FieldOffset(Offset = "0x28")]
	public TweenAlpha sprScoreBoardLightTweeb_BTeam;

	[Token(Token = "0x600601E")]
	[Address(RVA = "0xACDF4C", Offset = "0xACDF4C", VA = "0xACDF4C")]
	public XPanel_TeamDeath()
	{
	}

	[Token(Token = "0x600601F")]
	[Address(RVA = "0xACDF54", Offset = "0xACDF54", VA = "0xACDF54")]
	public void Init()
	{
	}

	[Token(Token = "0x6006020")]
	[Address(RVA = "0xACE100", Offset = "0xACE100", VA = "0xACE100")]
	public void OnNetdataUpdated_GameData(object arg)
	{
	}

	[Token(Token = "0x6006021")]
	[Address(RVA = "0xACE11C", Offset = "0xACE11C", VA = "0xACE11C")]
	public void StartSelectedMyTeamAlarm()
	{
	}

	[Token(Token = "0x6006022")]
	[Address(RVA = "0xACE260", Offset = "0xACE260", VA = "0xACE260")]
	public void StopSelectedMyTeamAlarmTween()
	{
	}

	[Token(Token = "0x6006023")]
	[Address(RVA = "0xACE344", Offset = "0xACE344", VA = "0xACE344")]
	public void Update()
	{
	}

	[Token(Token = "0x6006024")]
	[Address(RVA = "0xACE388", Offset = "0xACE388", VA = "0xACE388")]
	public void Refresh()
	{
	}
}
