using System.Collections.Generic;
using CS.Constant;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000AE5")]
	public class MannerPointOptions
	{
		[Token(Token = "0x2000AE6")]
		private delegate bool TryParse<T>(string value, out T result);

		[Token(Token = "0x40034D6")]
		[FieldOffset(Offset = "0x8")]
		public int BaseMannerPoint;

		[Token(Token = "0x40034D7")]
		[FieldOffset(Offset = "0xC")]
		public bool MannerRestrictSystemUse;

		[Token(Token = "0x40034D8")]
		[FieldOffset(Offset = "0xD")]
		public bool RankEnterRestrictUse;

		[Token(Token = "0x40034D9")]
		[FieldOffset(Offset = "0x10")]
		public int MannerRestrictTriggingPoint;

		[Token(Token = "0x40034DA")]
		[FieldOffset(Offset = "0x14")]
		public int VeryBadRestrictTime;

		[Token(Token = "0x40034DB")]
		[FieldOffset(Offset = "0x18")]
		public int BadRestrictTime;

		[Token(Token = "0x40034DC")]
		[FieldOffset(Offset = "0x1C")]
		public int NormalRestrictTime;

		[Token(Token = "0x40034DD")]
		[FieldOffset(Offset = "0x20")]
		public int GoodRestrictTime;

		[Token(Token = "0x40034DE")]
		[FieldOffset(Offset = "0x24")]
		public int VeryGoodRestrictTime;

		[Token(Token = "0x40034DF")]
		[FieldOffset(Offset = "0x28")]
		public int MannerBlockPoint;

		[Token(Token = "0x600506F")]
		[Address(RVA = "0x233B26C", Offset = "0x233B26C", VA = "0x233B26C")]
		public MannerPointOptions(Dictionary<key, string> source)
		{
		}

		[Token(Token = "0x6005070")]
		private void SetValue<T>(Dictionary<key, string> source, key key, TryParse<T> parser, out T target)
		{
			target = default;
		}
	}
}
