using CS;
using Il2CppDummyDll;

namespace XCasualModeLogic.PoliceVsThief
{
	[Token(Token = "0x200052F")]
	public class PhotonHostJob : IGameJob
	{
		[Token(Token = "0x6002C5B")]
		[Address(RVA = "0x1AB2884", Offset = "0x1AB2884", VA = "0x1AB2884")]
		public PhotonHostJob()
		{
		}

		[Token(Token = "0x6002C5C")]
		[Address(RVA = "0x1AB288C", Offset = "0x1AB288C", VA = "0x1AB288C", Slot = "4")]
		public void OnStartMode()
		{
		}

		[Token(Token = "0x6002C5D")]
		[Address(RVA = "0x1AB2F34", Offset = "0x1AB2F34", VA = "0x1AB2F34")]
		public void NotifyGameEnd()
		{
		}

		[Token(Token = "0x6002C5E")]
		[Address(RVA = "0x1AB309C", Offset = "0x1AB309C", VA = "0x1AB309C", Slot = "5")]
		public void NotifyRoundStart(int round)
		{
		}

		[Token(Token = "0x6002C5F")]
		[Address(RVA = "0x1AB3610", Offset = "0x1AB3610", VA = "0x1AB3610")]
		private void SetRole(int round)
		{
		}

		[Token(Token = "0x6002C60")]
		[Address(RVA = "0x1AB3328", Offset = "0x1AB3328", VA = "0x1AB3328")]
		private void ClearPlayerStates()
		{
		}

		[Token(Token = "0x6002C61")]
		[Address(RVA = "0x1AB3AE8", Offset = "0x1AB3AE8", VA = "0x1AB3AE8")]
		private int GetBuffID(int index, int[] buffList)
		{
			return default(int);
		}

		[Token(Token = "0x6002C62")]
		[Address(RVA = "0x1AB3B48", Offset = "0x1AB3B48", VA = "0x1AB3B48", Slot = "8")]
		public void NotifyRoundEnd(int round, XTeamEnum team)
		{
		}

		[Token(Token = "0x6002C63")]
		private void SetRoomCustomProperty<T>(string k, T v)
		{
		}

		[Token(Token = "0x6002C64")]
		private T GetRoomCustomProperty<T>(string k)
		{
			return (T)default;
		}

		[Token(Token = "0x6002C65")]
		[Address(RVA = "0x1AB3DC8", Offset = "0x1AB3DC8", VA = "0x1AB3DC8", Slot = "12")]
		public void OnWaitingRound(float remainTime, PoliceVsThiefRole localPlayerRole)
		{
		}

		[Token(Token = "0x6002C66")]
		[Address(RVA = "0x1AB3F30", Offset = "0x1AB3F30", VA = "0x1AB3F30", Slot = "6")]
		public void OnRoundStart(int round, PoliceVsThiefRole localPlayerRole, float startTime)
		{
		}

		[Token(Token = "0x6002C67")]
		[Address(RVA = "0x1AB4390", Offset = "0x1AB4390", VA = "0x1AB4390", Slot = "9")]
		public void OnRoundEnd(int round, XTeamEnum team, float endTime)
		{
		}

		[Token(Token = "0x6002C68")]
		[Address(RVA = "0x1AB49B0", Offset = "0x1AB49B0", VA = "0x1AB49B0", Slot = "10")]
		public void NotifyGameEnd(XTeamEnum winTeam)
		{
		}

		[Token(Token = "0x6002C69")]
		[Address(RVA = "0x1AB4C20", Offset = "0x1AB4C20", VA = "0x1AB4C20", Slot = "11")]
		public void OnEndMode(XTeamEnum winTeam)
		{
		}

		[Token(Token = "0x6002C6A")]
		[Address(RVA = "0x1AB4D88", Offset = "0x1AB4D88", VA = "0x1AB4D88", Slot = "13")]
		public void OnActorStatusChanged(PlayerProperty prop, int value)
		{
		}

		[Token(Token = "0x6002C6B")]
		[Address(RVA = "0x1AB4EF0", Offset = "0x1AB4EF0", VA = "0x1AB4EF0", Slot = "7")]
		public void OnRoundEndCount(int remainTime)
		{
		}
	}
}
