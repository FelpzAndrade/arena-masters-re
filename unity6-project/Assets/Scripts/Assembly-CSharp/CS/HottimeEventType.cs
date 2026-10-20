using System;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000AD4")]
	public enum HottimeEventType
	{
		[Token(Token = "0x40032D1")]
		None = 0,
		[Token(Token = "0x40032D2")]
		PvpReward = None,
		[Token(Token = "0x40032D3")]
		FusionDiscount = 10,
		[Token(Token = "0x40032D4")]
		RefineDiscount = 11,
		[Token(Token = "0x40032D5")]
		PromoDiscount = 12
	}
}
