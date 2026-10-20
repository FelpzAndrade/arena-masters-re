using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

namespace XCasualModeLogic.PoliceVsThief
{
	[Token(Token = "0x2000533")]
	public class Mode : ICasualModeEventReceiver
	{
		[Token(Token = "0x2000534")]
		public class Setting
		{
			[Token(Token = "0x4001A2D")]
			[FieldOffset(Offset = "0x8")]
			public int totalRound;

			[Token(Token = "0x4001A2E")]
			[FieldOffset(Offset = "0xC")]
			public int curRound;

			[Token(Token = "0x4001A2F")]
			[FieldOffset(Offset = "0x10")]
			public Game.Setting gameSetting;

			[Token(Token = "0x4001A30")]
			[FieldOffset(Offset = "0x14")]
			public float startTime;

			[Token(Token = "0x6002C91")]
			[Address(RVA = "0x1AB2864", Offset = "0x1AB2864", VA = "0x1AB2864")]
			public Setting()
			{
			}
		}

		[Token(Token = "0x4001A1A")]
		[FieldOffset(Offset = "0x0")]
		public static int[] PoliceBuff;

		[Token(Token = "0x4001A1B")]
		[FieldOffset(Offset = "0x4")]
		public static int[] ThiefBuff;

		[Token(Token = "0x4001A1C")]
		[FieldOffset(Offset = "0x8")]
		public static string PropModStartTime;

		[Token(Token = "0x4001A1D")]
		[FieldOffset(Offset = "0xC")]
		public static string PropRoundStart;

		[Token(Token = "0x4001A1E")]
		[FieldOffset(Offset = "0x10")]
		public static string PropRoundStartTime;

		[Token(Token = "0x4001A1F")]
		[FieldOffset(Offset = "0x14")]
		public static string PropRoundEnd;

		[Token(Token = "0x4001A20")]
		[FieldOffset(Offset = "0x18")]
		public static string PropRoundEndTime;

		[Token(Token = "0x4001A21")]
		[FieldOffset(Offset = "0x1C")]
		public static string PropRoundResult;

		[Token(Token = "0x4001A22")]
		[FieldOffset(Offset = "0x8")]
		public Setting setting;

		[Token(Token = "0x4001A23")]
		[FieldOffset(Offset = "0xC")]
		private bool finish;

		[Token(Token = "0x4001A24")]
		[FieldOffset(Offset = "0x10")]
		public IPlayer localPlayer;

		[Token(Token = "0x4001A25")]
		[FieldOffset(Offset = "0x14")]
		public List<IPlayer> players;

		[Token(Token = "0x4001A26")]
		[FieldOffset(Offset = "0x18")]
		public List<IPlayer> ATeam;

		[Token(Token = "0x4001A27")]
		[FieldOffset(Offset = "0x1C")]
		public List<IPlayer> BTeam;

		[Token(Token = "0x4001A28")]
		[FieldOffset(Offset = "0x20")]
		public GameResult gameResult;

		[Token(Token = "0x4001A29")]
		[FieldOffset(Offset = "0x24")]
		private List<IGameJob> jobs;

		[Token(Token = "0x4001A2A")]
		[FieldOffset(Offset = "0x28")]
		public Game curGame;

		[Token(Token = "0x4001A2B")]
		[FieldOffset(Offset = "0x2C")]
		public float lastRoundEndTime;

		[Token(Token = "0x4001A2C")]
		[FieldOffset(Offset = "0x30")]
		private int lastSendSec;

		[Token(Token = "0x170006F5")]
		public float RemainTime
		{
			[Token(Token = "0x6002C81")]
			[Address(RVA = "0x1AB0BD0", Offset = "0x1AB0BD0", VA = "0x1AB0BD0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170006F6")]
		public bool IsFinish
		{
			[Token(Token = "0x6002C84")]
			[Address(RVA = "0x1AB0FD0", Offset = "0x1AB0FD0", VA = "0x1AB0FD0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6002C7F")]
		[Address(RVA = "0x1AB07F8", Offset = "0x1AB07F8", VA = "0x1AB07F8")]
		public Mode(Setting setting)
		{
		}

		[Token(Token = "0x6002C82")]
		[Address(RVA = "0x1AB0C18", Offset = "0x1AB0C18", VA = "0x1AB0C18", Slot = "7")]
		public void OnPlayerPropertiesChanged(PlayerProperty property, object val)
		{
		}

		[Token(Token = "0x6002C83")]
		[Address(RVA = "0x1AB0E44", Offset = "0x1AB0E44", VA = "0x1AB0E44")]
		public void Start()
		{
		}

		[Token(Token = "0x6002C85")]
		[Address(RVA = "0x1AB0FD8", Offset = "0x1AB0FD8", VA = "0x1AB0FD8")]
		public void AddPlayer(IPlayer player)
		{
		}

		[Token(Token = "0x6002C86")]
		[Address(RVA = "0x1AB1278", Offset = "0x1AB1278", VA = "0x1AB1278")]
		public void AddJob(IGameJob roll)
		{
		}

		[Token(Token = "0x6002C87")]
		[Address(RVA = "0x1AB1318", Offset = "0x1AB1318", VA = "0x1AB1318")]
		public void ClearJob()
		{
		}

		[Token(Token = "0x6002C88")]
		[Address(RVA = "0x1AB13B0", Offset = "0x1AB13B0", VA = "0x1AB13B0")]
		public void StartRound(Game.Setting gameSetting, bool onReconnect = false)
		{
		}

		[Token(Token = "0x6002C89")]
		[Address(RVA = "0x1AB1AFC", Offset = "0x1AB1AFC", VA = "0x1AB1AFC", Slot = "4")]
		public void StartRound(int round, float startTime)
		{
		}

		[Token(Token = "0x6002C8A")]
		[Address(RVA = "0x1AB1B54", Offset = "0x1AB1B54", VA = "0x1AB1B54", Slot = "5")]
		public void EndRound(int round, XTeamEnum winTeam, float endTime)
		{
		}

		[Token(Token = "0x6002C8B")]
		[Address(RVA = "0x1AB1D34", Offset = "0x1AB1D34", VA = "0x1AB1D34", Slot = "6")]
		public void End(XTeamEnum winTeam)
		{
		}

		[Token(Token = "0x6002C8C")]
		[Address(RVA = "0x1AB1ECC", Offset = "0x1AB1ECC", VA = "0x1AB1ECC")]
		public void Update(float now, float dt)
		{
		}

		[Token(Token = "0x6002C8D")]
		[Address(RVA = "0x1AB255C", Offset = "0x1AB255C", VA = "0x1AB255C")]
		public int GetTotalSafeScore(XTeamEnum team)
		{
			return default(int);
		}

		[Token(Token = "0x6002C8E")]
		[Address(RVA = "0x1AAA8B4", Offset = "0x1AAA8B4", VA = "0x1AAA8B4")]
		public static int GetTotalSafeScore(List<IPlayer> players, XTeamEnum team)
		{
			return default(int);
		}

		[Token(Token = "0x6002C8F")]
		[Address(RVA = "0x1AB2608", Offset = "0x1AB2608", VA = "0x1AB2608")]
		private void OnRoundEnd(object sender, GameEventArgs e)
		{
		}

		[Token(Token = "0x6002C90")]
		[Address(RVA = "0x1AB23A0", Offset = "0x1AB23A0", VA = "0x1AB23A0")]
		private void NextRound()
		{
		}
	}
}
