using System;
using CS;
using Il2CppDummyDll;

namespace XCasualModeLogic.PoliceVsThief
{
	[Token(Token = "0x2000528")]
	public class GameEventArgs : EventArgs
	{
		[Token(Token = "0x4001A05")]
		[FieldOffset(Offset = "0x8")]
		private float time;

		[Token(Token = "0x4001A06")]
		[FieldOffset(Offset = "0xC")]
		private PoliceVsThiefRole role;

		[Token(Token = "0x170006DE")]
		public float Time
		{
			[Token(Token = "0x6002C2B")]
			[Address(RVA = "0x1AACD50", Offset = "0x1AACD50", VA = "0x1AACD50")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170006DF")]
		public PoliceVsThiefRole Role
		{
			[Token(Token = "0x6002C2C")]
			[Address(RVA = "0x1AACD58", Offset = "0x1AACD58", VA = "0x1AACD58")]
			get
			{
				return default(PoliceVsThiefRole);
			}
		}

		[Token(Token = "0x6002C2A")]
		[Address(RVA = "0x1AACC88", Offset = "0x1AACC88", VA = "0x1AACC88")]
		public GameEventArgs(float time, PoliceVsThiefRole role)
		{
		}
	}
}
