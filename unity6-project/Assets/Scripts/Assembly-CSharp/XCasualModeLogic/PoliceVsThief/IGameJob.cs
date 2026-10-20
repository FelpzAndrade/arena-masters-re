using CS;
using Il2CppDummyDll;

namespace XCasualModeLogic.PoliceVsThief
{
	[Token(Token = "0x200052E")]
	public interface IGameJob
	{
		[Token(Token = "0x6002C51")]
		void OnStartMode();

		[Token(Token = "0x6002C52")]
		void NotifyRoundStart(int round);

		[Token(Token = "0x6002C53")]
		void OnRoundStart(int round, PoliceVsThiefRole role, float startTime);

		[Token(Token = "0x6002C54")]
		void OnRoundEndCount(int remainTime);

		[Token(Token = "0x6002C55")]
		void NotifyRoundEnd(int round, XTeamEnum team);

		[Token(Token = "0x6002C56")]
		void OnRoundEnd(int round, XTeamEnum team, float endTime);

		[Token(Token = "0x6002C57")]
		void NotifyGameEnd(XTeamEnum winTeam);

		[Token(Token = "0x6002C58")]
		void OnEndMode(XTeamEnum winTeam);

		[Token(Token = "0x6002C59")]
		void OnWaitingRound(float remainTime, PoliceVsThiefRole role);

		[Token(Token = "0x6002C5A")]
		void OnActorStatusChanged(PlayerProperty prop, int value);
	}
}
