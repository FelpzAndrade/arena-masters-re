using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C1E")]
public class XWidget_AccumulateTutorialReward : MonoBehaviour
{
	[Token(Token = "0x2000C1F")]
	private sealed class _003CResetTweens_003Ec__AnonStorey178
	{
		[Token(Token = "0x4003D44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal Action longestTweenFinishCallback;

		[Token(Token = "0x60057C0")]
		[Address(RVA = "0x193D88C", Offset = "0x193D88C", VA = "0x193D88C")]
		public _003CResetTweens_003Ec__AnonStorey178()
		{
		}

		[Token(Token = "0x60057C1")]
		[Address(RVA = "0x193D9F4", Offset = "0x193D9F4", VA = "0x193D9F4")]
		internal void _003C_003Em__249()
		{
		}
	}

	[Token(Token = "0x4003D37")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public XWidget_TweenCost tweenCost;

	[Token(Token = "0x4003D38")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public UILabel lblRewardCnt;

	[Token(Token = "0x4003D39")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public UIWidget sortParticleWidget;

	[Token(Token = "0x4003D3A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject goRewardDirectionRoot;

	[Token(Token = "0x4003D3B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public GameObject goRewardUpEffect;

	[Token(Token = "0x4003D3C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public UITweener[] upTweens;

	[Token(Token = "0x4003D3D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public UITweener hideTween;

	[Token(Token = "0x4003D3E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float effectPlayTime;

	[Token(Token = "0x4003D3F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float nextMoveTime;

	[Token(Token = "0x4003D40")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float m_elaspedTime;

	[Token(Token = "0x4003D41")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private bool m_reserveNextTutorial;

	[Token(Token = "0x4003D42")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Action m_nextCallBack;

	[Token(Token = "0x4003D43")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private int rewardEndCnt;

	[Token(Token = "0x60057B4")]
	[Address(RVA = "0x193CF58", Offset = "0x193CF58", VA = "0x193CF58")]
	public XWidget_AccumulateTutorialReward()
	{
	}

	[Token(Token = "0x60057B5")]
	[Address(RVA = "0x193CF74", Offset = "0x193CF74", VA = "0x193CF74")]
	private void Update()
	{
	}

	[Token(Token = "0x60057B6")]
	[Address(RVA = "0x193D0AC", Offset = "0x193D0AC", VA = "0x193D0AC")]
	public void Show(string strRewardCnt, Action nextCallBack)
	{
	}

	[Token(Token = "0x60057B7")]
	[Address(RVA = "0x193D11C", Offset = "0x193D11C", VA = "0x193D11C")]
	public void Build(string strRewardCnt, Action nextCallBack)
	{
	}

	[Token(Token = "0x60057B8")]
	[Address(RVA = "0x193D2A0", Offset = "0x193D2A0", VA = "0x193D2A0")]
	public void BuildDirection(int endCnt, Action nextCallBack)
	{
	}

	[Token(Token = "0x60057B9")]
	[Address(RVA = "0x193D14C", Offset = "0x193D14C", VA = "0x193D14C")]
	private void Build(Action nextCallBack)
	{
	}

	[Token(Token = "0x60057BA")]
	[Address(RVA = "0x193D508", Offset = "0x193D508", VA = "0x193D508")]
	public void StartEffect()
	{
	}

	[Token(Token = "0x60057BB")]
	[Address(RVA = "0x193D2D4", Offset = "0x193D2D4", VA = "0x193D2D4")]
	public void StartDirection()
	{
	}

	[Token(Token = "0x60057BC")]
	[Address(RVA = "0x193D658", Offset = "0x193D658", VA = "0x193D658")]
	private void ResetTweens(UITweener[] tweens, [Optional] Action longestTweenFinishCallback)
	{
	}

	[Token(Token = "0x60057BD")]
	[Address(RVA = "0x193D0E8", Offset = "0x193D0E8", VA = "0x193D0E8")]
	public void Show()
	{
	}

	[Token(Token = "0x60057BE")]
	[Address(RVA = "0x193D894", Offset = "0x193D894", VA = "0x193D894")]
	public void Hide()
	{
	}

	[Token(Token = "0x60057BF")]
	[Address(RVA = "0x193D9AC", Offset = "0x193D9AC", VA = "0x193D9AC")]
	private void _003CStartDirection_003Em__248()
	{
	}
}
