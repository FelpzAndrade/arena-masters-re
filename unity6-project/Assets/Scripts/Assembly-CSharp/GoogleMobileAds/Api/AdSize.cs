using Il2CppDummyDll;

namespace GoogleMobileAds.Api
{
	[Token(Token = "0x2000038")]
	public class AdSize
	{
		[Token(Token = "0x4000101")]
		[FieldOffset(Offset = "0x8")]
		private bool isSmartBanner;

		[Token(Token = "0x4000102")]
		[FieldOffset(Offset = "0xC")]
		private int width;

		[Token(Token = "0x4000103")]
		[FieldOffset(Offset = "0x10")]
		private int height;

		[Token(Token = "0x4000104")]
		[FieldOffset(Offset = "0x0")]
		public static readonly AdSize Banner;

		[Token(Token = "0x4000105")]
		[FieldOffset(Offset = "0x4")]
		public static readonly AdSize MediumRectangle;

		[Token(Token = "0x4000106")]
		[FieldOffset(Offset = "0x8")]
		public static readonly AdSize IABBanner;

		[Token(Token = "0x4000107")]
		[FieldOffset(Offset = "0xC")]
		public static readonly AdSize Leaderboard;

		[Token(Token = "0x4000108")]
		[FieldOffset(Offset = "0x10")]
		public static readonly AdSize SmartBanner;

		[Token(Token = "0x17000043")]
		public int Width
		{
			[Token(Token = "0x600015B")]
			[Address(RVA = "0x1F440BC", Offset = "0x1F440BC", VA = "0x1F440BC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000044")]
		public int Height
		{
			[Token(Token = "0x600015C")]
			[Address(RVA = "0x1F440C4", Offset = "0x1F440C4", VA = "0x1F440C4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000045")]
		public bool IsSmartBanner
		{
			[Token(Token = "0x600015D")]
			[Address(RVA = "0x1F440B4", Offset = "0x1F440B4", VA = "0x1F440B4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x1F45C00", Offset = "0x1F45C00", VA = "0x1F45C00")]
		public AdSize(int width, int height)
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x1F45C30", Offset = "0x1F45C30", VA = "0x1F45C30")]
		private AdSize(bool isSmartBanner)
		{
		}
	}
}
