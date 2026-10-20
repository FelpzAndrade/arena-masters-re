using System;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000914")]
	public interface IStallShopLogic
	{
		[Token(Token = "0x170009BB")]
		Currency ChargeCurrencyType
		{
			[Token(Token = "0x60048AE")]
			get;
		}

		[Token(Token = "0x170009BC")]
		StallType StallType
		{
			[Token(Token = "0x60048AF")]
			get;
		}

		[Token(Token = "0x170009BD")]
		Stat.Type StallChargeStatType
		{
			[Token(Token = "0x60048B0")]
			get;
		}

		[Token(Token = "0x60048B1")]
		int GetStallChargePrice(UserDataBase userData, CSProtoInfoManager_GameConst gameConst);

		[Token(Token = "0x60048B2")]
		TimeSpan GetStallChargeRemainTime(DateTime now, CSProtoInfoManager_GameConst gameConst);

		[Token(Token = "0x60048B3")]
		int GetDailyChargeCount(UserDataBase userData);

		[Token(Token = "0x60048B4")]
		bool CheckStallShopsResetTime(CSProtoInfoManager_GameConst gameConst, DateTime now, DateTime lastResetStampTime);
	}
}
