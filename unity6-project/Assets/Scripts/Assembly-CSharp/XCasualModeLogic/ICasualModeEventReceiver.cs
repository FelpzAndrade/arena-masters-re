using CS;
using Il2CppDummyDll;
using XCasualModeLogic.PoliceVsThief;

namespace XCasualModeLogic
{
	[Token(Token = "0x2000545")]
	public interface ICasualModeEventReceiver
	{
		[Token(Token = "0x6002CEA")]
		void StartRound(int round, float time);

		[Token(Token = "0x6002CEB")]
		void EndRound(int round, XTeamEnum winTeam, float time);

		[Token(Token = "0x6002CEC")]
		void End(XTeamEnum winTeam);

		[Token(Token = "0x6002CED")]
		void OnPlayerPropertiesChanged(PlayerProperty prop, object val);
	}
}
