using System;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000964")]
	public class IronsMissionState
	{
		[Token(Token = "0x4002E78")]
		[FieldOffset(Offset = "0x8")]
		public int QuestId;

		[Token(Token = "0x4002E79")]
		[FieldOffset(Offset = "0xC")]
		public int Current;

		[Token(Token = "0x4002E7A")]
		[FieldOffset(Offset = "0x10")]
		public int Max;

		[Token(Token = "0x4002E7B")]
		[FieldOffset(Offset = "0x14")]
		public MissionState State;

		[Token(Token = "0x17000AA8")]
		public float ProcessRate
		{
			[Token(Token = "0x6004BA3")]
			[Address(RVA = "0x23396AC", Offset = "0x23396AC", VA = "0x23396AC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6004BA0")]
		[Address(RVA = "0x23395BC", Offset = "0x23395BC", VA = "0x23395BC")]
		public IronsMissionState()
		{
		}

		[Token(Token = "0x6004BA1")]
		[Address(RVA = "0x23395C4", Offset = "0x23395C4", VA = "0x23395C4")]
		public static IronsMissionState Create(int questid, int current, int max, MissionState state)
		{
			return null;
		}

		[Token(Token = "0x6004BA2")]
		[Address(RVA = "0x2339680", Offset = "0x2339680", VA = "0x2339680")]
		public void Set(IronsMission mission)
		{
		}

		[Token(Token = "0x6004BA4")]
		[Address(RVA = "0x23396E0", Offset = "0x23396E0", VA = "0x23396E0")]
		public bool IsClose()
		{
			return default(bool);
		}

		[Token(Token = "0x6004BA5")]
		[Address(RVA = "0x23396F4", Offset = "0x23396F4", VA = "0x23396F4")]
		public bool IsOpen()
		{
			return default(bool);
		}

		[Token(Token = "0x6004BA6")]
		[Address(RVA = "0x2339704", Offset = "0x2339704", VA = "0x2339704")]
		public bool IsComplete()
		{
			return default(bool);
		}

		[Token(Token = "0x6004BA7")]
		[Address(RVA = "0x2339718", Offset = "0x2339718", VA = "0x2339718")]
		public bool IsClear()
		{
			return default(bool);
		}

		[Token(Token = "0x6004BA8")]
		[Address(RVA = "0x2339730", Offset = "0x2339730", VA = "0x2339730")]
		public bool CanReceiveReward()
		{
			return default(bool);
		}
	}
}
