using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000902")]
	public static class RelicLogic
	{
		[Token(Token = "0x4002B74")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int max_slot_count;

		[Token(Token = "0x6004819")]
		[Address(RVA = "0x21C1670", Offset = "0x21C1670", VA = "0x21C1670")]
		public static int GetLevelThanRelicCount(UserDataBase userData, int level)
		{
			return default(int);
		}

		[Token(Token = "0x600481A")]
		[Address(RVA = "0x21C17F8", Offset = "0x21C17F8", VA = "0x21C17F8")]
		public static bool ResetDefault(UserDataBase userData)
		{
			return default(bool);
		}

		[Token(Token = "0x600481B")]
		[Address(RVA = "0x21C1944", Offset = "0x21C1944", VA = "0x21C1944")]
		public static bool ValidateSlotId(int id)
		{
			return default(bool);
		}

		[Token(Token = "0x600481C")]
		[Address(RVA = "0x21C1B28", Offset = "0x21C1B28", VA = "0x21C1B28")]
		public static bool IsOpenSlot(UserDataBase userData, int slot_id)
		{
			return default(bool);
		}

		[Token(Token = "0x600481D")]
		[Address(RVA = "0x21C1C20", Offset = "0x21C1C20", VA = "0x21C1C20")]
		public static bool OpenSlot(UserDataBase userData, int slot_id)
		{
			return default(bool);
		}

		[Token(Token = "0x600481E")]
		[Address(RVA = "0x21C1ECC", Offset = "0x21C1ECC", VA = "0x21C1ECC")]
		public static void IsInstalledOnSlot(UserDataBase userData, int relic_id, int crr_id)
		{
		}

		[Token(Token = "0x600481F")]
		[Address(RVA = "0x21C1F68", Offset = "0x21C1F68", VA = "0x21C1F68")]
		public static bool SetSlot(UserDataBase userData, int slot_id, int relic_id)
		{
			return default(bool);
		}

		[Token(Token = "0x6004820")]
		[Address(RVA = "0x21C2448", Offset = "0x21C2448", VA = "0x21C2448")]
		public static bool SetDailySlot(UserDataBase userData, int relic_id, int level)
		{
			return default(bool);
		}

		[Token(Token = "0x6004821")]
		[Address(RVA = "0x21C2398", Offset = "0x21C2398", VA = "0x21C2398")]
		public static bool IsExistRelic(UserDataBase userData, int relic_id)
		{
			return default(bool);
		}

		[Token(Token = "0x6004822")]
		[Address(RVA = "0x21C2570", Offset = "0x21C2570", VA = "0x21C2570")]
		public static int GetRelicCount(UserDataBase userData)
		{
			return default(int);
		}

		[Token(Token = "0x6004823")]
		[Address(RVA = "0x21C2618", Offset = "0x21C2618", VA = "0x21C2618")]
		public static bool Unlock(UserDataBase userData, int relic_id, ProtoInfoManager_Relic data)
		{
			return default(bool);
		}

		[Token(Token = "0x6004824")]
		[Address(RVA = "0x21C2A04", Offset = "0x21C2A04", VA = "0x21C2A04")]
		public static bool Upgrade(UserDataBase userData, int relic_id, int relic_level, ProtoInfoManager_Relic data)
		{
			return default(bool);
		}

		[Token(Token = "0x6004825")]
		[Address(RVA = "0x21C2FA8", Offset = "0x21C2FA8", VA = "0x21C2FA8")]
		public static int GetBuySlot(UserDataBase userData)
		{
			return default(int);
		}
	}
}
