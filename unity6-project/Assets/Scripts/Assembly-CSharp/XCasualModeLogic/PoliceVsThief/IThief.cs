using Il2CppDummyDll;

namespace XCasualModeLogic.PoliceVsThief
{
	[Token(Token = "0x2000537")]
	public interface IThief : IActor
	{
		[Token(Token = "0x170006F8")]
		bool IsArrested
		{
			[Token(Token = "0x6002C95")]
			get;
		}

		[Token(Token = "0x170006F9")]
		int KeyCount
		{
			[Token(Token = "0x6002C96")]
			get;
		}

		[Token(Token = "0x170006FA")]
		float SurviveTime
		{
			[Token(Token = "0x6002C97")]
			get;
			[Token(Token = "0x6002C98")]
			set;
		}

		[Token(Token = "0x6002C99")]
		void IncreaseSurvive();
	}
}
