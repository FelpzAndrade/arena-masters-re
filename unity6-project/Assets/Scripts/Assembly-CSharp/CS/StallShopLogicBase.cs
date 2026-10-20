using System;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000915")]
	public abstract class StallShopLogicBase
	{
		[Token(Token = "0x170009BE")]
		public abstract Currency ChargeCurrencyType
		{
			[Token(Token = "0x60048B6")]
			get;
		}

		[Token(Token = "0x170009BF")]
		public abstract StallType StallType
		{
			[Token(Token = "0x60048B7")]
			get;
		}

		[Token(Token = "0x170009C0")]
		public abstract Stat.Type StallChargeStatType
		{
			[Token(Token = "0x60048B8")]
			get;
		}

		[Token(Token = "0x60048B5")]
		[Address(RVA = "0x21E32EC", Offset = "0x21E32EC", VA = "0x21E32EC")]
		protected StallShopLogicBase()
		{
		}

		[Token(Token = "0x60048B9")]
		[Address(RVA = "0x21E3344", Offset = "0x21E3344", VA = "0x21E3344")]
		public int GetDailyChargeCount(UserDataBase userData)
		{
			return default(int);
		}

		[Token(Token = "0x60048BA")]
		public abstract int GetStallChargePrice(UserDataBase userData, CSProtoInfoManager_GameConst gameConst);

		[Token(Token = "0x60048BB")]
		public abstract bool TryGetStallChargeTime(CSProtoInfoManager_GameConst gameConst, out TimeSpan resetTime1, out TimeSpan resetTime2);

		[Token(Token = "0x60048BC")]
		[Address(RVA = "0x21E34F8", Offset = "0x21E34F8", VA = "0x21E34F8")]
		public TimeSpan GetStallChargeRemainTime(DateTime now, CSProtoInfoManager_GameConst gameConst)
		{
			return default(TimeSpan);
		}

		[Token(Token = "0x60048BD")]
		[Address(RVA = "0x21E36C0", Offset = "0x21E36C0", VA = "0x21E36C0")]
		public bool CheckStallShopsResetTime(CSProtoInfoManager_GameConst gameConst, DateTime now, DateTime lastResetStampTime)
		{
			return default(bool);
		}
	}
}
