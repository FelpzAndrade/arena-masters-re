using System;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000AF7")]
	public class IronsMission
	{
		[Token(Token = "0x2000AF8")]
		public enum Type
		{
			[Token(Token = "0x40035D1")]
			none = 0,
			[Token(Token = "0x40035D2")]
			normal = 10,
			[Token(Token = "0x40035D3")]
			rank = 20,
			[Token(Token = "0x40035D4")]
			rank_pvp = 21,
			[Token(Token = "0x40035D5")]
			deathmatch = 30,
			[Token(Token = "0x40035D6")]
			teamdeathmatch = 31,
			[Token(Token = "0x40035D7")]
			zombie = 40,
			[Token(Token = "0x40035D8")]
			capturepointa = 41,
			[Token(Token = "0x40035D9")]
			zombieescape = 42,
			[Token(Token = "0x40035DA")]
			annihilation = 43,
			[Token(Token = "0x40035DB")]
			teamlimited = 44,
			[Token(Token = "0x40035DC")]
			zombie2 = 45,
			[Token(Token = "0x40035DD")]
			relaymatch = 46,
			[Token(Token = "0x40035DE")]
			policevsthief = 47,
			[Token(Token = "0x40035DF")]
			hideandseek = 48,
			[Token(Token = "0x40035E0")]
			bonus = 100
		}

		[Token(Token = "0x2000AF9")]
		public enum Condition
		{
			[Token(Token = "0x40035E2")]
			none = 0,
			[Token(Token = "0x40035E3")]
			playcount = 10,
			[Token(Token = "0x40035E4")]
			win = 20,
			[Token(Token = "0x40035E5")]
			win_human = 21,
			[Token(Token = "0x40035E6")]
			within_3 = 22,
			[Token(Token = "0x40035E7")]
			kill = 30,
			[Token(Token = "0x40035E8")]
			finish = 40,
			[Token(Token = "0x40035E9")]
			victory_point = 50
		}

		[Token(Token = "0x40035C2")]
		public const int QUEST_ID_NONE = 0;

		[Token(Token = "0x40035C3")]
		[FieldOffset(Offset = "0x8")]
		public int GroupId;

		[Token(Token = "0x40035C4")]
		[FieldOffset(Offset = "0xC")]
		public int QuestId;

		[Token(Token = "0x40035C5")]
		[FieldOffset(Offset = "0x10")]
		public int NextQuestId;

		[Token(Token = "0x40035C6")]
		[FieldOffset(Offset = "0x14")]
		public Stat.Type StatType;

		[Token(Token = "0x40035C7")]
		[FieldOffset(Offset = "0x18")]
		public int MissionCount;

		[Token(Token = "0x40035C8")]
		[FieldOffset(Offset = "0x1C")]
		public CSContentType ContentType;

		[Token(Token = "0x40035C9")]
		[FieldOffset(Offset = "0x20")]
		public int ContentId;

		[Token(Token = "0x40035CA")]
		[FieldOffset(Offset = "0x24")]
		public int ContentCount;

		[Token(Token = "0x40035CB")]
		[FieldOffset(Offset = "0x28")]
		public string Link;

		[Token(Token = "0x40035CC")]
		[FieldOffset(Offset = "0x0")]
		private static Func<Type, string> _003C_003Ef__am_0024cache9;

		[Token(Token = "0x40035CD")]
		[FieldOffset(Offset = "0x4")]
		private static Func<Condition, string> _003C_003Ef__am_0024cacheA;

		[Token(Token = "0x40035CE")]
		[FieldOffset(Offset = "0x8")]
		private static Func<Type, string> _003C_003Ef__am_0024cacheB;

		[Token(Token = "0x40035CF")]
		[FieldOffset(Offset = "0xC")]
		private static Func<Condition, string> _003C_003Ef__am_0024cacheC;

		[Token(Token = "0x60050E6")]
		[Address(RVA = "0x2337CD0", Offset = "0x2337CD0", VA = "0x2337CD0")]
		public IronsMission()
		{
		}

		[Token(Token = "0x60050E7")]
		[Address(RVA = "0x2337D94", Offset = "0x2337D94", VA = "0x2337D94")]
		public Type GetMissionType()
		{
			return default(Type);
		}

		[Token(Token = "0x60050E8")]
		[Address(RVA = "0x2338240", Offset = "0x2338240", VA = "0x2338240")]
		public Condition GetMissionCondition()
		{
			return default(Condition);
		}

		[Token(Token = "0x60050E9")]
		[Address(RVA = "0x23386C8", Offset = "0x23386C8", VA = "0x23386C8")]
		private string GetConditionStringByStatType()
		{
			return null;
		}

		[Token(Token = "0x60050EA")]
		[Address(RVA = "0x23391B4", Offset = "0x23391B4", VA = "0x23391B4")]
		public CSContent GetContent()
		{
			return null;
		}

		[Token(Token = "0x60050EB")]
		[Address(RVA = "0x233926C", Offset = "0x233926C", VA = "0x233926C")]
		private static string _003CGetMissionType_003Em__204(Type x)
		{
			return null;
		}

		[Token(Token = "0x60050EC")]
		[Address(RVA = "0x2339340", Offset = "0x2339340", VA = "0x2339340")]
		private static string _003CGetMissionCondition_003Em__205(Condition x)
		{
			return null;
		}

		[Token(Token = "0x60050ED")]
		[Address(RVA = "0x2339414", Offset = "0x2339414", VA = "0x2339414")]
		private static string _003CGetConditionStringByStatType_003Em__206(Type x)
		{
			return null;
		}

		[Token(Token = "0x60050EE")]
		[Address(RVA = "0x23394E8", Offset = "0x23394E8", VA = "0x23394E8")]
		private static string _003CGetConditionStringByStatType_003Em__207(Condition x)
		{
			return null;
		}
	}
}
