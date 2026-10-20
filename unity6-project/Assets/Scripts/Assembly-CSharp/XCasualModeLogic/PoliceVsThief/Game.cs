using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace XCasualModeLogic.PoliceVsThief
{
	[Token(Token = "0x2000538")]
	public class Game
	{
		[Token(Token = "0x2000539")]
		public class Setting
		{
			[Token(Token = "0x4001A3A")]
			[FieldOffset(Offset = "0x8")]
			public float gameTime;

			[Token(Token = "0x4001A3B")]
			[FieldOffset(Offset = "0xC")]
			public int totalKeyCount;

			[Token(Token = "0x4001A3C")]
			[FieldOffset(Offset = "0x10")]
			public float startTime;

			[Token(Token = "0x6002CAA")]
			[Address(RVA = "0x1AACD48", Offset = "0x1AACD48", VA = "0x1AACD48")]
			public Setting()
			{
			}
		}

		[Token(Token = "0x4001A31")]
		[FieldOffset(Offset = "0x8")]
		private Rule rule;

		[Token(Token = "0x4001A32")]
		[FieldOffset(Offset = "0xC")]
		private List<IPolice> police;

		[Token(Token = "0x4001A33")]
		[FieldOffset(Offset = "0x10")]
		private List<IThief> thiefs;

		[Token(Token = "0x4001A34")]
		[FieldOffset(Offset = "0x14")]
		private Setting setting;

		[Token(Token = "0x4001A35")]
		[FieldOffset(Offset = "0x18")]
		private bool finished;

		[Token(Token = "0x4001A36")]
		[FieldOffset(Offset = "0x1C")]
		private List<IGameJob> jobs;

		[Token(Token = "0x4001A37")]
		[FieldOffset(Offset = "0x20")]
		private float now;

		[Token(Token = "0x4001A38")]
		[FieldOffset(Offset = "0x24")]
		private int lastRemainCountInt;

		[Token(Token = "0x4001A39")]
		[FieldOffset(Offset = "0x28")]
		private EventHandler<GameEventArgs> m_OnEnd;

		[Token(Token = "0x170006FB")]
		public float Time
		{
			[Token(Token = "0x6002C9D")]
			[Address(RVA = "0x1AAB030", Offset = "0x1AAB030", VA = "0x1AAB030")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170006FC")]
		public float EndTime
		{
			[Token(Token = "0x6002C9E")]
			[Address(RVA = "0x1AAB054", Offset = "0x1AAB054", VA = "0x1AAB054")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170006FD")]
		public float RemainTime
		{
			[Token(Token = "0x6002C9F")]
			[Address(RVA = "0x1AAB084", Offset = "0x1AAB084", VA = "0x1AAB084")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1400005D")]
		public event EventHandler<GameEventArgs> OnEnd
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x6002C9B")]
			[Address(RVA = "0x1AAAD18", Offset = "0x1AAAD18", VA = "0x1AAAD18")]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x6002C9C")]
			[Address(RVA = "0x1AAAEA4", Offset = "0x1AAAEA4", VA = "0x1AAAEA4")]
			remove
			{
			}
		}

		[Token(Token = "0x6002C9A")]
		[Address(RVA = "0x1AAABE4", Offset = "0x1AAABE4", VA = "0x1AAABE4")]
		public Game(Setting setting, List<IGameJob> jobs)
		{
		}

		[Token(Token = "0x6002CA0")]
		[Address(RVA = "0x1AAB150", Offset = "0x1AAB150", VA = "0x1AAB150")]
		public void Update(float now, float dt)
		{
		}

		[Token(Token = "0x6002CA1")]
		[Address(RVA = "0x1AAB6F8", Offset = "0x1AAB6F8", VA = "0x1AAB6F8")]
		private void OnUpdateTime(float remainTime)
		{
		}

		[Token(Token = "0x6002CA2")]
		[Address(RVA = "0x1AAB1D8", Offset = "0x1AAB1D8", VA = "0x1AAB1D8")]
		private void UpdateThiefSurviveScore(float dt)
		{
		}

		[Token(Token = "0x6002CA3")]
		[Address(RVA = "0x1AABA54", Offset = "0x1AABA54", VA = "0x1AABA54")]
		public void AddPolice(IPolice police)
		{
		}

		[Token(Token = "0x6002CA4")]
		[Address(RVA = "0x1AABAF4", Offset = "0x1AABAF4", VA = "0x1AABAF4")]
		public void AddThief(IThief thief)
		{
		}

		[Token(Token = "0x6002CA5")]
		[Address(RVA = "0x1AABB94", Offset = "0x1AABB94", VA = "0x1AABB94")]
		public void OnActorStatusChanged(object sender, ActorPropertyChangedEventArgs e)
		{
		}

		[Token(Token = "0x6002CA6")]
		[Address(RVA = "0x1AABC0C", Offset = "0x1AABC0C", VA = "0x1AABC0C")]
		private void HandleActorEvent(ActorPropertyChangedEventArgs e)
		{
		}

		[Token(Token = "0x6002CA7")]
		[Address(RVA = "0x1AAC2C0", Offset = "0x1AAC2C0", VA = "0x1AAC2C0")]
		private int GetFreeThiefCount()
		{
			return default(int);
		}

		[Token(Token = "0x6002CA8")]
		[Address(RVA = "0x1AAB8CC", Offset = "0x1AAB8CC", VA = "0x1AAB8CC")]
		private void EndGame()
		{
		}

		[Token(Token = "0x6002CA9")]
		[Address(RVA = "0x1AAC7A8", Offset = "0x1AAC7A8", VA = "0x1AAC7A8")]
		private void OnGameEnd()
		{
		}
	}
}
