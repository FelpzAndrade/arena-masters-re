using System;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000913")]
	public class StallMischaShopLogic : StallShopLogicBase
	{
		[Token(Token = "0x170009B8")]
		public override Currency ChargeCurrencyType
		{
			[Token(Token = "0x60048A9")]
			[Address(RVA = "0x21E32F4", Offset = "0x21E32F4", VA = "0x21E32F4", Slot = "4")]
			get
			{
				return default(Currency);
			}
		}

		[Token(Token = "0x170009B9")]
		public override StallType StallType
		{
			[Token(Token = "0x60048AA")]
			[Address(RVA = "0x21E32FC", Offset = "0x21E32FC", VA = "0x21E32FC", Slot = "5")]
			get
			{
				return default(StallType);
			}
		}

		[Token(Token = "0x170009BA")]
		public override Stat.Type StallChargeStatType
		{
			[Token(Token = "0x60048AB")]
			[Address(RVA = "0x21E3304", Offset = "0x21E3304", VA = "0x21E3304", Slot = "6")]
			get
			{
				return default(Stat.Type);
			}
		}

		[Token(Token = "0x60048A8")]
		[Address(RVA = "0x21E32E4", Offset = "0x21E32E4", VA = "0x21E32E4")]
		public StallMischaShopLogic()
		{
		}

		[Token(Token = "0x60048AC")]
		[Address(RVA = "0x21E330C", Offset = "0x21E330C", VA = "0x21E330C", Slot = "7")]
		public override int GetStallChargePrice(UserDataBase userData, CSProtoInfoManager_GameConst gameConst)
		{
			return default(int);
		}

		[Token(Token = "0x60048AD")]
		[Address(RVA = "0x21E34C0", Offset = "0x21E34C0", VA = "0x21E34C0", Slot = "8")]
		public override bool TryGetStallChargeTime(CSProtoInfoManager_GameConst gameConst, out TimeSpan resetTime1, out TimeSpan resetTime2)
		{
			resetTime1 = default;
			resetTime2 = default;
			return default(bool);
		}
	}
}
