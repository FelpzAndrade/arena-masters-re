using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C2A")]
public class XWidget_TutorialStart : MonoBehaviour
{
	[Token(Token = "0x4003D83")]
	[FieldOffset(Offset = "0xC")]
	public UIPanel panel;

	[Token(Token = "0x4003D84")]
	[FieldOffset(Offset = "0x10")]
	public TweenAlpha startTween;

	[Token(Token = "0x4003D85")]
	[FieldOffset(Offset = "0x14")]
	public UITweener[] nextTweens;

	[Token(Token = "0x4003D86")]
	[FieldOffset(Offset = "0x18")]
	public XWidget_AccumulateTutorialReward reward;

	[Token(Token = "0x4003D87")]
	[FieldOffset(Offset = "0x1C")]
	private Action m_nextCallBack;

	[Token(Token = "0x4003D88")]
	[FieldOffset(Offset = "0x20")]
	private bool isNextTweenStart;

	[Token(Token = "0x4003D89")]
	[FieldOffset(Offset = "0x24")]
	public float hidePlayTime;

	[Token(Token = "0x4003D8A")]
	[FieldOffset(Offset = "0x28")]
	private float m_elaspedTime;

	[Token(Token = "0x6005806")]
	[Address(RVA = "0x1B31704", Offset = "0x1B31704", VA = "0x1B31704")]
	public XWidget_TutorialStart()
	{
	}

	[Token(Token = "0x6005807")]
	[Address(RVA = "0x1B31714", Offset = "0x1B31714", VA = "0x1B31714")]
	public void Show(TutorialDataBase data, Action nextCallBack)
	{
	}

	[Token(Token = "0x6005808")]
	[Address(RVA = "0x1B31928", Offset = "0x1B31928", VA = "0x1B31928")]
	private void Update()
	{
	}

	[Token(Token = "0x6005809")]
	[Address(RVA = "0x1B318D0", Offset = "0x1B318D0", VA = "0x1B318D0")]
	private void Build(TutorialDataBase data, Action nextCallBack)
	{
	}

	[Token(Token = "0x600580A")]
	[Address(RVA = "0x1B31C04", Offset = "0x1B31C04", VA = "0x1B31C04")]
	public void OnTouch_NextTutorial()
	{
	}

	[Token(Token = "0x600580B")]
	[Address(RVA = "0x1B3189C", Offset = "0x1B3189C", VA = "0x1B3189C")]
	public void Show()
	{
	}

	[Token(Token = "0x600580C")]
	[Address(RVA = "0x1B31C18", Offset = "0x1B31C18", VA = "0x1B31C18")]
	public void Hide()
	{
	}

	[Token(Token = "0x600580D")]
	[Address(RVA = "0x1B31B80", Offset = "0x1B31B80", VA = "0x1B31B80")]
	private void ResetTweens()
	{
	}

	[Token(Token = "0x600580E")]
	[Address(RVA = "0x1B31990", Offset = "0x1B31990", VA = "0x1B31990")]
	private void PlayNextTweens()
	{
	}

	[Token(Token = "0x600580F")]
	[Address(RVA = "0x1B31C4C", Offset = "0x1B31C4C", VA = "0x1B31C4C")]
	private void _003CPlayNextTweens_003Em__24A()
	{
	}
}
