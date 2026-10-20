using CS;
using Il2CppDummyDll;

namespace XCasualModeLogic.PoliceVsThief
{
	[Token(Token = "0x2000531")]
	public interface IPlayer
	{
		[Token(Token = "0x170006EF")]
		XTeamEnum Team
		{
			[Token(Token = "0x6002C78")]
			get;
		}

		[Token(Token = "0x170006F0")]
		PoliceVsThiefRole Role
		{
			[Token(Token = "0x6002C79")]
			get;
		}

		[Token(Token = "0x170006F1")]
		int RoleBuff
		{
			[Token(Token = "0x6002C7A")]
			get;
		}

		[Token(Token = "0x170006F2")]
		bool IsLocal
		{
			[Token(Token = "0x6002C7C")]
			get;
		}

		[Token(Token = "0x170006F3")]
		int SafeScore
		{
			[Token(Token = "0x6002C7D")]
			get;
		}

		[Token(Token = "0x170006F4")]
		bool Escaped
		{
			[Token(Token = "0x6002C7E")]
			get;
		}

		[Token(Token = "0x6002C7B")]
		void ChangeRoll(PoliceVsThiefRole role, int buff);
	}
}
