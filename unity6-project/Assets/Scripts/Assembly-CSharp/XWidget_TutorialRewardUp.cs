using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C29")]
public class XWidget_TutorialRewardUp : MonoBehaviour
{
	[Token(Token = "0x4003D81")]
	[FieldOffset(Offset = "0xC")]
	private XWidget_AccumulateTutorialReward m_reward;

	[Token(Token = "0x4003D82")]
	[FieldOffset(Offset = "0x10")]
	private Action m_nextCallBack;

	[Token(Token = "0x6005800")]
	[Address(RVA = "0x1B315E8", Offset = "0x1B315E8", VA = "0x1B315E8")]
	public XWidget_TutorialRewardUp()
	{
	}

	[Token(Token = "0x6005801")]
	[Address(RVA = "0x1B315F0", Offset = "0x1B315F0", VA = "0x1B315F0")]
	public void SetAccumulateObject(XWidget_AccumulateTutorialReward obj)
	{
	}

	[Token(Token = "0x6005802")]
	[Address(RVA = "0x1B315F8", Offset = "0x1B315F8", VA = "0x1B315F8")]
	public void ShowDirection(TutorialDataBase data, Action nextCallBack)
	{
	}

	[Token(Token = "0x6005803")]
	[Address(RVA = "0x1B31678", Offset = "0x1B31678", VA = "0x1B31678")]
	private void Build(TutorialDataBase data, Action nextCallBack)
	{
	}

	[Token(Token = "0x6005804")]
	[Address(RVA = "0x1B31644", Offset = "0x1B31644", VA = "0x1B31644")]
	public void Show()
	{
	}

	[Token(Token = "0x6005805")]
	[Address(RVA = "0x1B316D0", Offset = "0x1B316D0", VA = "0x1B316D0")]
	public void Hide()
	{
	}
}
