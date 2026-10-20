using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

[Token(Token = "0x2000C0A")]
public class XTutorialData
{
	[Token(Token = "0x4003CF5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public Dictionary<int, int> lastShowGroupList;

	[Token(Token = "0x4003CF6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public List<int> clearList;

	[Token(Token = "0x4003CF7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int selectCharID;

	[Token(Token = "0x6005716")]
	[Address(RVA = "0x184B63C", Offset = "0x184B63C", VA = "0x184B63C")]
	public XTutorialData()
	{
	}

	[Token(Token = "0x6005717")]
	[Address(RVA = "0x184B71C", Offset = "0x184B71C", VA = "0x184B71C", Slot = "4")]
	public virtual void SetServerData(Dictionary<int, int> lastShowGroupList, List<int> clearList)
	{
	}

	[Token(Token = "0x6005718")]
	[Address(RVA = "0x184B81C", Offset = "0x184B81C", VA = "0x184B81C", Slot = "5")]
	public virtual void Reset()
	{
	}

	[Token(Token = "0x6005719")]
	[Address(RVA = "0x184B8E8", Offset = "0x184B8E8", VA = "0x184B8E8", Slot = "6")]
	public virtual void SetCompleteGroup(int group, int tutorialID)
	{
	}

	[Token(Token = "0x600571A")]
	[Address(RVA = "0x184BA00", Offset = "0x184BA00", VA = "0x184BA00")]
	public int GetCompletedGroup(int tutorialID)
	{
		return default(int);
	}

	[Token(Token = "0x600571B")]
	[Address(RVA = "0x184BAE0", Offset = "0x184BAE0", VA = "0x184BAE0", Slot = "7")]
	public virtual void SetCompleteTutorial(int tutorialID)
	{
	}

	[Token(Token = "0x600571C")]
	[Address(RVA = "0x184BBC0", Offset = "0x184BBC0", VA = "0x184BBC0")]
	public bool IsCompleteTutorial(int tutorialID)
	{
		return default(bool);
	}

	[Token(Token = "0x600571D")]
	[Address(RVA = "0x184BC60", Offset = "0x184BC60", VA = "0x184BC60", Slot = "8")]
	public virtual void RemoveCompleteTutorial(int tutorialID)
	{
	}

	[Token(Token = "0x600571E")]
	[Address(RVA = "0x184BD40", Offset = "0x184BD40", VA = "0x184BD40")]
	public int GetResumeNeedTutorialID([Optional] Func<int, bool> checkExistTuto)
	{
		return default(int);
	}

	[Token(Token = "0x600571F")]
	[Address(RVA = "0x184BF10", Offset = "0x184BF10", VA = "0x184BF10", Slot = "9")]
	public virtual void SetSelectCharacter(int characterID)
	{
	}
}
