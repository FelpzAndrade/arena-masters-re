using System;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000912")]
	public class StallWarriorShopLogic : StallShopLogicBase
	{
		[Token(Token = "0x170009B5")]
		public override Currency ChargeCurrencyType
		{
			[Token(Token = "0x60048A3")]
			[Address(RVA = "0x21E39E4", Offset = "0x21E39E4", VA = "0x21E39E4", Slot = "4")]
			get
			{
				return default(Currency);
			}
		}

		[Token(Token = "0x170009B6")]
		public override StallType StallType
		{
			[Token(Token = "0x60048A4")]
			[Address(RVA = "0x21E39EC", Offset = "0x21E39EC", VA = "0x21E39EC", Slot = "5")]
			get
			{
				return default(StallType);
			}
		}

		[Token(Token = "0x170009B7")]
		public override Stat.Type StallChargeStatType
		{
			[Token(Token = "0x60048A5")]
			[Address(RVA = "0x21E39F4", Offset = "0x21E39F4", VA = "0x21E39F4", Slot = "6")]
			get
			{
				return default(Stat.Type);
			}
		}

		[Token(Token = "0x60048A2")]
		[Address(RVA = "0x21E39DC", Offset = "0x21E39DC", VA = "0x21E39DC")]
		public StallWarriorShopLogic()
		{
		}

		[Token(Token = "0x60048A6")]
		[Address(RVA = "0x21E39FC", Offset = "0x21E39FC", VA = "0x21E39FC", Slot = "7")]
		public override int GetStallChargePrice(UserDataBase userData, CSProtoInfoManager_GameConst gameConst)
		{
			return default(int);
		}

		[Token(Token = "0x60048A7")]
		[Address(RVA = "0x21E3A34", Offset = "0x21E3A34", VA = "0x21E3A34", Slot = "8")]
		public override bool TryGetStallChargeTime(CSProtoInfoManager_GameConst gameConst, out TimeSpan resetTime1, out TimeSpan resetTime2)
		{
			resetTime1 = default;
			resetTime2 = default;
			return default(bool);
		}
	}
}
