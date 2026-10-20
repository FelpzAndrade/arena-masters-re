using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000B19")]
	public class ShopContent : CSContent
	{
		[Token(Token = "0x4003696")]
		[FieldOffset(Offset = "0x1C")]
		private bool IsShowBonusUI__BackingField;

		[Token(Token = "0x17000BEA")]
		public bool IsShowBonusUI
		{
			[Token(Token = "0x6005183")]
			[Address(RVA = "0x21DF314", Offset = "0x21DF314", VA = "0x21DF314")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005184")]
			[Address(RVA = "0x21DF30C", Offset = "0x21DF30C", VA = "0x21DF30C")]
			private set
			{
			}
		}

		[Token(Token = "0x6005182")]
		[Address(RVA = "0x21DF2EC", Offset = "0x21DF2EC", VA = "0x21DF2EC")]
		public ShopContent(bool isShowBonusUI)
		{
		}
	}
}
