using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D09")]
public class XPanel_CapturePointA : MonoBehaviour
{
	[Token(Token = "0x4004238")]
	[FieldOffset(Offset = "0xC")]
	public UILabel lblATeamTime;

	[Token(Token = "0x4004239")]
	[FieldOffset(Offset = "0x10")]
	public UILabel lblBTeamTime;

	[Token(Token = "0x400423A")]
	[FieldOffset(Offset = "0x14")]
	public UILabel lblOccupyingTeam;

	[Token(Token = "0x400423B")]
	[FieldOffset(Offset = "0x18")]
	public XUIFlag flagUI;

	[Token(Token = "0x400423C")]
	[FieldOffset(Offset = "0x1C")]
	private XGameModeCapturePointA m_GameMode;

	[Token(Token = "0x400423D")]
	[FieldOffset(Offset = "0x20")]
	private XGameModeData_CapturePointA m_GameModeData;

	[Token(Token = "0x400423E")]
	[FieldOffset(Offset = "0x24")]
	private XGameModeLocalData_CapturePointA m_GameModeLocalData;

	[Token(Token = "0x400423F")]
	[FieldOffset(Offset = "0x28")]
	public GameObject sprScoreBoardLight_ATeam;

	[Token(Token = "0x4004240")]
	[FieldOffset(Offset = "0x2C")]
	public TweenAlpha sprScoreBoardLightTween_ATeam;

	[Token(Token = "0x4004241")]
	[FieldOffset(Offset = "0x30")]
	public GameObject sprScoreBoardLight_BTeam;

	[Token(Token = "0x4004242")]
	[FieldOffset(Offset = "0x34")]
	public TweenAlpha sprScoreBoardLightTweeb_BTeam;

	[Token(Token = "0x4004243")]
	[FieldOffset(Offset = "0x38")]
	private XTeamEnum capturedTeam;

	[Token(Token = "0x4004244")]
	[FieldOffset(Offset = "0x3C")]
	private bool m_interactingByMe;

	[Token(Token = "0x4004245")]
	[FieldOffset(Offset = "0x40")]
	private XTeamEnum capturingTeam;

	[Token(Token = "0x6005F11")]
	[Address(RVA = "0x169524C", Offset = "0x169524C", VA = "0x169524C")]
	public XPanel_CapturePointA()
	{
	}

	[Token(Token = "0x6005F12")]
	[Address(RVA = "0x169525C", Offset = "0x169525C", VA = "0x169525C")]
	public void Init()
	{
	}

	[Token(Token = "0x6005F13")]
	[Address(RVA = "0x1695698", Offset = "0x1695698", VA = "0x1695698")]
	public void StartSelectedMyTeamAlarm()
	{
	}

	[Token(Token = "0x6005F14")]
	[Address(RVA = "0x16957E0", Offset = "0x16957E0", VA = "0x16957E0")]
	public void StopSelectedMyTeamAlarmTween()
	{
	}

	[Token(Token = "0x6005F15")]
	[Address(RVA = "0x1695874", Offset = "0x1695874", VA = "0x1695874")]
	public void Update()
	{
	}

	[Token(Token = "0x6005F16")]
	[Address(RVA = "0x16958A0", Offset = "0x16958A0", VA = "0x16958A0")]
	private void RefreshScore()
	{
	}

	[Token(Token = "0x6005F17")]
	[Address(RVA = "0x1695C68", Offset = "0x1695C68", VA = "0x1695C68")]
	public void Refresh()
	{
	}

	[Token(Token = "0x6005F18")]
	[Address(RVA = "0x1695B60", Offset = "0x1695B60", VA = "0x1695B60")]
	private void RefreshInteractionByMe()
	{
	}

	[Token(Token = "0x6005F19")]
	[Address(RVA = "0x1695A40", Offset = "0x1695A40", VA = "0x1695A40")]
	private void RefreshInteractionTimeSprite()
	{
	}

	[Token(Token = "0x6005F1A")]
	[Address(RVA = "0x1695BD8", Offset = "0x1695BD8", VA = "0x1695BD8")]
	private void RefreshOccupyingTeam()
	{
	}
}
