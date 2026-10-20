using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000876")]
	public class Cash
	{
		[Token(Token = "0x2000877")]
		public class Action
		{
			[Token(Token = "0x4002892")]
			[FieldOffset(Offset = "0x0")]
			public static readonly char Buy;

			[Token(Token = "0x4002893")]
			[FieldOffset(Offset = "0x2")]
			public static readonly char Refund;

			[Token(Token = "0x4002894")]
			[FieldOffset(Offset = "0x4")]
			public static readonly char Present;

			[Token(Token = "0x60045BA")]
			[Address(RVA = "0x23E81EC", Offset = "0x23E81EC", VA = "0x23E81EC")]
			public Action()
			{
			}
		}

		[Token(Token = "0x2000878")]
		public enum Market
		{
			[Token(Token = "0x4002896")]
			None = 0,
			[Token(Token = "0x4002897")]
			GooglePlay = 1,
			[Token(Token = "0x4002898")]
			AppStore = 2
		}

		[Token(Token = "0x2000879")]
		public enum Currency : byte
		{
			[Token(Token = "0x400289A")]
			None = 0,
			[Token(Token = "0x400289B")]
			KRW = 1,
			[Token(Token = "0x400289C")]
			USD = 2,
			[Token(Token = "0x400289D")]
			NOK = 3,
			[Token(Token = "0x400289E")]
			THB = 4,
			[Token(Token = "0x400289F")]
			TWD = 5,
			[Token(Token = "0x40028A0")]
			MXN = 6,
			[Token(Token = "0x40028A1")]
			DKK = 7,
			[Token(Token = "0x40028A2")]
			NZD = 8,
			[Token(Token = "0x40028A3")]
			SEK = 9,
			[Token(Token = "0x40028A4")]
			AUD = 10,
			[Token(Token = "0x40028A5")]
			HKD = 11,
			[Token(Token = "0x40028A6")]
			SGD = 12,
			[Token(Token = "0x40028A7")]
			CNY = 13,
			[Token(Token = "0x40028A8")]
			AED = 14,
			[Token(Token = "0x40028A9")]
			BRL = 15,
			[Token(Token = "0x40028AA")]
			ILS = 16,
			[Token(Token = "0x40028AB")]
			EUR = 17,
			[Token(Token = "0x40028AC")]
			INR = 18,
			[Token(Token = "0x40028AD")]
			CHF = 19,
			[Token(Token = "0x40028AE")]
			PHP = 20,
			[Token(Token = "0x40028AF")]
			TRY = 21,
			[Token(Token = "0x40028B0")]
			GBP = 22,
			[Token(Token = "0x40028B1")]
			MYR = 23,
			[Token(Token = "0x40028B2")]
			CAD = 24,
			[Token(Token = "0x40028B3")]
			IDR = 25,
			[Token(Token = "0x40028B4")]
			ZAR = 26,
			[Token(Token = "0x40028B5")]
			VND = 27,
			[Token(Token = "0x40028B6")]
			JPY = 28,
			[Token(Token = "0x40028B7")]
			SAR = 29,
			[Token(Token = "0x40028B8")]
			RUB = 30,
			[Token(Token = "0x40028B9")]
			MMK = 31,
			[Token(Token = "0x40028BA")]
			ARS = 32,
			[Token(Token = "0x40028BB")]
			BAM = 33,
			[Token(Token = "0x40028BC")]
			BGN = 34,
			[Token(Token = "0x40028BD")]
			BOB = 35,
			[Token(Token = "0x40028BE")]
			CLP = 36,
			[Token(Token = "0x40028BF")]
			COP = 37,
			[Token(Token = "0x40028C0")]
			CRC = 38,
			[Token(Token = "0x40028C1")]
			CZK = 39,
			[Token(Token = "0x40028C2")]
			DOP = 40,
			[Token(Token = "0x40028C3")]
			EGP = 41,
			[Token(Token = "0x40028C4")]
			GTQ = 42,
			[Token(Token = "0x40028C5")]
			HNL = 43,
			[Token(Token = "0x40028C6")]
			HRK = 44,
			[Token(Token = "0x40028C7")]
			HUF = 45,
			[Token(Token = "0x40028C8")]
			KZT = 46,
			[Token(Token = "0x40028C9")]
			LBP = 47,
			[Token(Token = "0x40028CA")]
			LSL = 48,
			[Token(Token = "0x40028CB")]
			LTL = 49,
			[Token(Token = "0x40028CC")]
			MAD = 50,
			[Token(Token = "0x40028CD")]
			MKD = 51,
			[Token(Token = "0x40028CE")]
			NGN = 52,
			[Token(Token = "0x40028CF")]
			NIO = 53,
			[Token(Token = "0x40028D0")]
			PEN = 54,
			[Token(Token = "0x40028D1")]
			PKR = 55,
			[Token(Token = "0x40028D2")]
			PLN = 56,
			[Token(Token = "0x40028D3")]
			QAR = 57,
			[Token(Token = "0x40028D4")]
			RON = 58,
			[Token(Token = "0x40028D5")]
			RSD = 59,
			[Token(Token = "0x40028D6")]
			UAH = 60,
			[Token(Token = "0x40028D7")]
			UGX = 61
		}

		[Token(Token = "0x200087A")]
		public enum State : byte
		{
			[Token(Token = "0x40028D9")]
			None = 0,
			[Token(Token = "0x40028DA")]
			ValidationWait = 1,
			[Token(Token = "0x40028DB")]
			ValidationFail = 2,
			[Token(Token = "0x40028DC")]
			ValidationSuccess = 3,
			[Token(Token = "0x40028DD")]
			Complete = 4
		}

		[Token(Token = "0x60045B8")]
		[Address(RVA = "0x23E81DC", Offset = "0x23E81DC", VA = "0x23E81DC")]
		public Cash()
		{
		}

		[Token(Token = "0x60045B9")]
		[Address(RVA = "0x23E81E4", Offset = "0x23E81E4", VA = "0x23E81E4")]
		public static Market GetMarketType()
		{
			return default(Market);
		}
	}
}
