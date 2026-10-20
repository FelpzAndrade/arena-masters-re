using CS;
using Il2CppDummyDll;

namespace XCasualModeLogic.PoliceVsThief
{
	[Token(Token = "0x2000530")]
	public class LocalPlayerJob : IGameJob
	{
		[Token(Token = "0x4001A11")]
		[FieldOffset(Offset = "0x8")]
		private Mode mode;

		[Token(Token = "0x4001A12")]
		[FieldOffset(Offset = "0xC")]
		private XPanel_PoliceVSThief modeUI;

		[Token(Token = "0x4001A13")]
		[FieldOffset(Offset = "0x10")]
		private int lastWaitingRoundRemainTime;

		[Token(Token = "0x6002C6C")]
		[Address(RVA = "0x1AACD60", Offset = "0x1AACD60", VA = "0x1AACD60")]
		public LocalPlayerJob(Mode mode, XPanel_PoliceVSThief modeUI)
		{
		}

		[Token(Token = "0x6002C6D")]
		[Address(RVA = "0x1AACD88", Offset = "0x1AACD88", VA = "0x1AACD88", Slot = "4")]
		public void OnStartMode()
		{
		}

		[Token(Token = "0x6002C6E")]
		[Address(RVA = "0x1AACF3C", Offset = "0x1AACF3C", VA = "0x1AACF3C", Slot = "5")]
		public void NotifyRoundStart(int round)
		{
		}

		[Token(Token = "0x6002C6F")]
		[Address(RVA = "0x1AACF40", Offset = "0x1AACF40", VA = "0x1AACF40")]
		public void NotifyGameEnd()
		{
		}

		[Token(Token = "0x6002C70")]
		[Address(RVA = "0x1AACF44", Offset = "0x1AACF44", VA = "0x1AACF44", Slot = "8")]
		public void NotifyRoundEnd(int round, XTeamEnum team)
		{
		}

		[Token(Token = "0x6002C71")]
		[Address(RVA = "0x1AACF48", Offset = "0x1AACF48", VA = "0x1AACF48", Slot = "13")]
		public void OnActorStatusChanged(PlayerProperty prop, int value)
		{
		}

		[Token(Token = "0x6002C72")]
		[Address(RVA = "0x1AAD80C", Offset = "0x1AAD80C", VA = "0x1AAD80C", Slot = "6")]
		public void OnRoundStart(int round, PoliceVsThiefRole role, float startTime)
		{
		}

		[Token(Token = "0x6002C73")]
		[Address(RVA = "0x1AADB70", Offset = "0x1AADB70", VA = "0x1AADB70", Slot = "12")]
		public void OnWaitingRound(float remainTime, PoliceVsThiefRole nextRole)
		{
		}

		[Token(Token = "0x6002C74")]
		[Address(RVA = "0x1AADFD4", Offset = "0x1AADFD4", VA = "0x1AADFD4", Slot = "7")]
		public void OnRoundEndCount(int remainTime)
		{
		}

		[Token(Token = "0x6002C75")]
		[Address(RVA = "0x1AAE288", Offset = "0x1AAE288", VA = "0x1AAE288", Slot = "9")]
		public void OnRoundEnd(int round, XTeamEnum team, float endTime)
		{
		}

		[Token(Token = "0x6002C76")]
		[Address(RVA = "0x1AAE8F8", Offset = "0x1AAE8F8", VA = "0x1AAE8F8", Slot = "10")]
		public void NotifyGameEnd(XTeamEnum winTeam)
		{
		}

		[Token(Token = "0x6002C77")]
		[Address(RVA = "0x1AAE8FC", Offset = "0x1AAE8FC", VA = "0x1AAE8FC", Slot = "11")]
		public void OnEndMode(XTeamEnum winTeam)
		{
		}
	}
}
