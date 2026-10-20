using System.Collections.Generic;
using Il2CppDummyDll;

namespace XLevel
{
	[Token(Token = "0x2000748")]
	public class ObjectKillCounter
	{
		[Token(Token = "0x400228B")]
		[FieldOffset(Offset = "0x8")]
		private Dictionary<int, int> m_GroupCount;

		[Token(Token = "0x400228C")]
		[FieldOffset(Offset = "0xC")]
		private Dictionary<int, int> m_groupKilledCount;

		[Token(Token = "0x400228D")]
		[FieldOffset(Offset = "0x10")]
		private int m_totalCount;

		[Token(Token = "0x400228E")]
		[FieldOffset(Offset = "0x14")]
		private int m_maxMonsterCount;

		[Token(Token = "0x400228F")]
		[FieldOffset(Offset = "0x18")]
		private int m_spawnedMonsterCount;

		[Token(Token = "0x4002290")]
		[FieldOffset(Offset = "0x1C")]
		private int m_killedTotalCount;

		[Token(Token = "0x17000839")]
		private int curMonseterCount
		{
			[Token(Token = "0x6003B9D")]
			[Address(RVA = "0x201E8C0", Offset = "0x201E8C0", VA = "0x201E8C0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700083A")]
		public bool NoCurrentMonsters
		{
			[Token(Token = "0x6003B9E")]
			[Address(RVA = "0x201E8D0", Offset = "0x201E8D0", VA = "0x201E8D0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6003B9C")]
		[Address(RVA = "0x201E7EC", Offset = "0x201E7EC", VA = "0x201E7EC")]
		public ObjectKillCounter(int totalCount, int maxMonsterCount)
		{
		}

		[Token(Token = "0x6003B9F")]
		[Address(RVA = "0x201E8E8", Offset = "0x201E8E8", VA = "0x201E8E8")]
		public void RegisterTrigger(int triggerUID, int count)
		{
		}

		[Token(Token = "0x6003BA0")]
		[Address(RVA = "0x201EB04", Offset = "0x201EB04", VA = "0x201EB04")]
		public void CountUpSpawned()
		{
		}

		[Token(Token = "0x6003BA1")]
		[Address(RVA = "0x201EB14", Offset = "0x201EB14", VA = "0x201EB14")]
		public void CountUpKilledTotal()
		{
		}

		[Token(Token = "0x6003BA2")]
		[Address(RVA = "0x201EB24", Offset = "0x201EB24", VA = "0x201EB24")]
		public bool CanSpawn()
		{
			return default(bool);
		}

		[Token(Token = "0x6003BA3")]
		[Address(RVA = "0x201EB54", Offset = "0x201EB54", VA = "0x201EB54")]
		public int GetSpawnableCount()
		{
			return default(int);
		}

		[Token(Token = "0x6003BA4")]
		[Address(RVA = "0x201EB78", Offset = "0x201EB78", VA = "0x201EB78")]
		public bool IsAllKilled()
		{
			return default(bool);
		}

		[Token(Token = "0x6003BA5")]
		[Address(RVA = "0x201EB90", Offset = "0x201EB90", VA = "0x201EB90")]
		public void CountUpKilledGroup(int triggerUID)
		{
		}

		[Token(Token = "0x6003BA6")]
		[Address(RVA = "0x201EC8C", Offset = "0x201EC8C", VA = "0x201EC8C")]
		public bool IsGroupKilledAll(int triggerUID)
		{
			return default(bool);
		}
	}
}
