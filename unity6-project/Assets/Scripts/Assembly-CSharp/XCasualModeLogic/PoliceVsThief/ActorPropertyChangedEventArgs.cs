using System;
using Il2CppDummyDll;

namespace XCasualModeLogic.PoliceVsThief
{
	[Token(Token = "0x2000529")]
	public class ActorPropertyChangedEventArgs : EventArgs
	{
		[Token(Token = "0x4001A07")]
		[FieldOffset(Offset = "0x8")]
		private PlayerProperty prop;

		[Token(Token = "0x170006E0")]
		public PlayerProperty Prop
		{
			[Token(Token = "0x6002C2E")]
			[Address(RVA = "0x1AAABCC", Offset = "0x1AAABCC", VA = "0x1AAABCC")]
			get
			{
				return default(PlayerProperty);
			}
		}

		[Token(Token = "0x6002C2D")]
		[Address(RVA = "0x1AAAB20", Offset = "0x1AAAB20", VA = "0x1AAAB20")]
		public ActorPropertyChangedEventArgs(PlayerProperty prop)
		{
		}

		[Token(Token = "0x6002C2F")]
		[Address(RVA = "0x1AAABD4", Offset = "0x1AAABD4", VA = "0x1AAABD4")]
		public bool HasProp(PlayerProperty prop)
		{
			return default(bool);
		}
	}
}
