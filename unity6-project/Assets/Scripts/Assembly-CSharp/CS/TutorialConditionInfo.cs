using System;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000B89")]
	public class TutorialConditionInfo
	{
		[Token(Token = "0x4003A66")]
		[FieldOffset(Offset = "0x8")]
		public int id;

		[Token(Token = "0x4003A67")]
		[FieldOffset(Offset = "0xC")]
		public TutorialType type;

		[Token(Token = "0x4003A68")]
		[FieldOffset(Offset = "0x10")]
		public string startCondition;

		[Token(Token = "0x4003A69")]
		[FieldOffset(Offset = "0x14")]
		public TutorialType preConditionType;

		[Token(Token = "0x4003A6A")]
		[FieldOffset(Offset = "0x18")]
		public int teamLv;

		[Token(Token = "0x4003A6B")]
		[FieldOffset(Offset = "0x1C")]
		public int forceNextTutorial;

		[Token(Token = "0x4003A6C")]
		[FieldOffset(Offset = "0x20")]
		public int rewardID;

		[Token(Token = "0x4003A6D")]
		[FieldOffset(Offset = "0x24")]
		public CSContentType rewardType;

		[Token(Token = "0x4003A6E")]
		[FieldOffset(Offset = "0x28")]
		public int rewardAmount;

		[Token(Token = "0x4003A6F")]
		[FieldOffset(Offset = "0x2C")]
		public string strImmediateCommit;

		[Token(Token = "0x4003A70")]
		[FieldOffset(Offset = "0x30")]
		public bool IsNextTutoImmediateCommit;

		[Token(Token = "0x600537A")]
		[Address(RVA = "0x21EA5A8", Offset = "0x21EA5A8", VA = "0x21EA5A8")]
		public TutorialConditionInfo()
		{
		}

		[Token(Token = "0x600537B")]
		[Address(RVA = "0x21EA674", Offset = "0x21EA674", VA = "0x21EA674")]
		public void Cooking()
		{
		}
	}
}
