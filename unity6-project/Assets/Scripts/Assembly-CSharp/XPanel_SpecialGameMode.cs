using System;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D1D")]
public class XPanel_SpecialGameMode : XPanel_GameBase
{
	[Token(Token = "0x4004319")]
	[FieldOffset(Offset = "0x14")]
	public UILabel lblGold;

	[Token(Token = "0x400431A")]
	[FieldOffset(Offset = "0x18")]
	public UILabel lblPotionCount;

	[Token(Token = "0x400431B")]
	[FieldOffset(Offset = "0x1C")]
	public Transform breakThroughDirectionParent;

	[Token(Token = "0x400431C")]
	[FieldOffset(Offset = "0x20")]
	private XWidget_ContentIcon contentIcon;

	[Token(Token = "0x400431D")]
	[FieldOffset(Offset = "0x24")]
	private XWidget_BreakThrough m_breakThroughDirection;

	[Token(Token = "0x400431E")]
	[FieldOffset(Offset = "0x28")]
	private Action<int> m_refreshText;

	[Token(Token = "0x400431F")]
	[FieldOffset(Offset = "0x2C")]
	private float m_curScoreF;

	[Token(Token = "0x4004320")]
	[FieldOffset(Offset = "0x30")]
	private int m_targetScore;

	[Token(Token = "0x4004321")]
	[FieldOffset(Offset = "0x34")]
	private float m_limitSec;

	[Token(Token = "0x4004322")]
	[FieldOffset(Offset = "0x38")]
	private float m_step;

	[Token(Token = "0x4004323")]
	[FieldOffset(Offset = "0x3C")]
	private float m_baseStep;

	[Token(Token = "0x4004324")]
	[FieldOffset(Offset = "0x40")]
	private readonly int expMod;

	[Token(Token = "0x4004325")]
	[FieldOffset(Offset = "0x44")]
	private float m_maxScore;

	[Token(Token = "0x4004326")]
	[FieldOffset(Offset = "0x48")]
	private string m_strPotion;

	[Token(Token = "0x4004327")]
	[FieldOffset(Offset = "0x4C")]
	private string m_strGold;

	[Token(Token = "0x4004328")]
	[FieldOffset(Offset = "0x50")]
	private string m_strPiece;

	[Token(Token = "0x4004329")]
	[FieldOffset(Offset = "0x54")]
	private string m_strBreakthrough;

	[Token(Token = "0x400432A")]
	[FieldOffset(Offset = "0x58")]
	private CSStageInfo m_stageInfo;

	[Token(Token = "0x400432B")]
	[FieldOffset(Offset = "0x5C")]
	private int m_last;

	[Token(Token = "0x400432C")]
	[FieldOffset(Offset = "0x60")]
	private int m_lastBreakthrough;

	[Token(Token = "0x17000D13")]
	private int m_curScore
	{
		[Token(Token = "0x6006011")]
		[Address(RVA = "0xACC9F4", Offset = "0xACC9F4", VA = "0xACC9F4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6006010")]
	[Address(RVA = "0xACC9B8", Offset = "0xACC9B8", VA = "0xACC9B8")]
	public XPanel_SpecialGameMode()
	{
	}

	[Token(Token = "0x6006012")]
	[Address(RVA = "0xACCA04", Offset = "0xACCA04", VA = "0xACCA04")]
	private void InitStr()
	{
	}

	[Token(Token = "0x6006013")]
	[Address(RVA = "0xACCAF0", Offset = "0xACCAF0", VA = "0xACCAF0")]
	public void Build(CSStageInfo info)
	{
	}

	[Token(Token = "0x6006014")]
	[Address(RVA = "0xACCFE0", Offset = "0xACCFE0", VA = "0xACCFE0")]
	public void Hide()
	{
	}

	[Token(Token = "0x6006015")]
	[Address(RVA = "0xACD014", Offset = "0xACD014", VA = "0xACD014")]
	private void CalcStep()
	{
	}

	[Token(Token = "0x6006016")]
	[Address(RVA = "0xACD058", Offset = "0xACD058", VA = "0xACD058")]
	public void SetScore(int score)
	{
	}

	[Token(Token = "0x6006017")]
	[Address(RVA = "0xACD09C", Offset = "0xACD09C", VA = "0xACD09C")]
	public void SetMaxScore(int maxScore)
	{
	}

	[Token(Token = "0x6006018")]
	[Address(RVA = "0xACCF3C", Offset = "0xACCF3C", VA = "0xACCF3C")]
	public void RefreshText(int curScore)
	{
	}

	[Token(Token = "0x6006019")]
	[Address(RVA = "0xACD0B8", Offset = "0xACD0B8", VA = "0xACD0B8")]
	private void RefreshScore(float dt)
	{
	}

	[Token(Token = "0x600601A")]
	[Address(RVA = "0xACD204", Offset = "0xACD204", VA = "0xACD204")]
	private void RefreshGold(int score)
	{
	}

	[Token(Token = "0x600601B")]
	[Address(RVA = "0xACD468", Offset = "0xACD468", VA = "0xACD468")]
	private int GetReward(int score)
	{
		return default(int);
	}

	[Token(Token = "0x600601C")]
	[Address(RVA = "0xACD4C0", Offset = "0xACD4C0", VA = "0xACD4C0")]
	private void RefreshPotion(int score)
	{
	}

	[Token(Token = "0x600601D")]
	[Address(RVA = "0xACD76C", Offset = "0xACD76C", VA = "0xACD76C")]
	private void Update()
	{
	}
}
