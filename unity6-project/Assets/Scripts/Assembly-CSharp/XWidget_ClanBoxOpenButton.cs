using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E88")]
public class XWidget_ClanBoxOpenButton : MonoBehaviour
{
	[Token(Token = "0x4004C1F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public UILabel lblTitle;

	[Token(Token = "0x4004C20")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public UILabel lblRemainTime;

	[Token(Token = "0x4004C21")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public UI2DSprite sprBox;

	[Token(Token = "0x4004C22")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public XWidget_ProgressBarWithTable prb;

	[Token(Token = "0x4004C23")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public UIButton btn;

	[Token(Token = "0x4004C24")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject rewardBG;

	[Token(Token = "0x4004C25")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public GameObject progressBG;

	[Token(Token = "0x4004C26")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject disableBG;

	[Token(Token = "0x4004C27")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private DateTime endTime;

	[Token(Token = "0x4004C28")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Action onClick;

	[Token(Token = "0x4004C29")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private bool clickOnce;

	[Token(Token = "0x6006C5E")]
	[Address(RVA = "0x15CF85C", Offset = "0x15CF85C", VA = "0x15CF85C")]
	public XWidget_ClanBoxOpenButton()
	{
	}

	[Token(Token = "0x6006C5F")]
	[Address(RVA = "0x15CF864", Offset = "0x15CF864", VA = "0x15CF864")]
	public void Build(bool canTakeReward, bool alreadyTakeReward, int initScore, int score, DateTime endTime, [Optional] Action onClick, bool clickOnce = true)
	{
	}

	[Token(Token = "0x6006C60")]
	[Address(RVA = "0x15D008C", Offset = "0x15D008C", VA = "0x15D008C")]
	private void SetDisable()
	{
	}

	[Token(Token = "0x6006C61")]
	[Address(RVA = "0x15D0028", Offset = "0x15D0028", VA = "0x15D0028")]
	private void SetRewardBG()
	{
	}

	[Token(Token = "0x6006C62")]
	[Address(RVA = "0x15D00F0", Offset = "0x15D00F0", VA = "0x15D00F0")]
	private void SetProgress()
	{
	}

	[Token(Token = "0x6006C63")]
	[Address(RVA = "0x15CFC14", Offset = "0x15CFC14", VA = "0x15CFC14")]
	private void BuildTitle(int score, bool isProgressing)
	{
	}

	[Token(Token = "0x6006C64")]
	[Address(RVA = "0x15D0154", Offset = "0x15D0154", VA = "0x15D0154")]
	private void Update()
	{
	}

	[Token(Token = "0x6006C65")]
	[Address(RVA = "0x15D0318", Offset = "0x15D0318", VA = "0x15D0318")]
	public void OnClick_ClanBox()
	{
	}

	[Token(Token = "0x6006C66")]
	[Address(RVA = "0x15D034C", Offset = "0x15D034C", VA = "0x15D034C")]
	private void _003CBuild_003Em__3DC(int s)
	{
	}

	[Token(Token = "0x6006C67")]
	[Address(RVA = "0x15D0354", Offset = "0x15D0354", VA = "0x15D0354")]
	private void _003CBuild_003Em__3DD()
	{
	}
}
