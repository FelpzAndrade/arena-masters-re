using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D2D")]
public class XUIRelayMatchGameStartUI : MonoBehaviour
{
	[Token(Token = "0x2000D2E")]
	private enum UIState
	{
		[Token(Token = "0x400436B")]
		None = -1,
		[Token(Token = "0x400436C")]
		Round = 0,
		[Token(Token = "0x400436D")]
		Ready = 1,
		[Token(Token = "0x400436E")]
		GO = 2
	}

	[Token(Token = "0x4004365")]
	[FieldOffset(Offset = "0xC")]
	public List<GameObject> TweenObjects;

	[Token(Token = "0x4004366")]
	[FieldOffset(Offset = "0x10")]
	public UI2DSprite RoundNum;

	[Token(Token = "0x4004367")]
	[FieldOffset(Offset = "0x14")]
	private List<UITweener> nextTweenList;

	[Token(Token = "0x4004368")]
	[FieldOffset(Offset = "0x18")]
	private UIState m_currentIndex;

	[Token(Token = "0x4004369")]
	[FieldOffset(Offset = "0x1C")]
	private int m_round;

	[Token(Token = "0x60060A9")]
	[Address(RVA = "0x1916444", Offset = "0x1916444", VA = "0x1916444")]
	public XUIRelayMatchGameStartUI()
	{
	}

	[Token(Token = "0x60060AA")]
	[Address(RVA = "0x1916454", Offset = "0x1916454", VA = "0x1916454")]
	private void Start()
	{
	}

	[Token(Token = "0x60060AB")]
	[Address(RVA = "0x1916458", Offset = "0x1916458", VA = "0x1916458")]
	private void MakeNextTweenList()
	{
	}

	[Token(Token = "0x60060AC")]
	[Address(RVA = "0x19165DC", Offset = "0x19165DC", VA = "0x19165DC")]
	public void Build(int round)
	{
	}

	[Token(Token = "0x60060AD")]
	[Address(RVA = "0x1916888", Offset = "0x1916888", VA = "0x1916888")]
	public void NextAni()
	{
	}

	[Token(Token = "0x60060AE")]
	[Address(RVA = "0x1916AF8", Offset = "0x1916AF8", VA = "0x1916AF8")]
	private void MainSoundPlay(UIState state)
	{
	}

	[Token(Token = "0x60060AF")]
	[Address(RVA = "0x1916C7C", Offset = "0x1916C7C", VA = "0x1916C7C")]
	public void RoundSoundPlay()
	{
	}

	[Token(Token = "0x60060B0")]
	[Address(RVA = "0x1916790", Offset = "0x1916790", VA = "0x1916790")]
	private void AllHide()
	{
	}

	[Token(Token = "0x60060B1")]
	[Address(RVA = "0x1916A04", Offset = "0x1916A04", VA = "0x1916A04")]
	private void ResetTweenList()
	{
	}
}
