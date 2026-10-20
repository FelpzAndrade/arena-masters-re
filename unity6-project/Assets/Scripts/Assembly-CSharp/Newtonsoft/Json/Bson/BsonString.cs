using Il2CppDummyDll;

namespace Newtonsoft.Json.Bson
{
	[Token(Token = "0x20000A5")]
	internal class BsonString : BsonValue
	{
		[Token(Token = "0x40002BD")]
		[FieldOffset(Offset = "0x18")]
		private int ByteCount__BackingField;

		[Token(Token = "0x40002BE")]
		[FieldOffset(Offset = "0x1C")]
		private bool IncludeLength__BackingField;

		[Token(Token = "0x170000AF")]
		public int ByteCount
		{
			[Token(Token = "0x6000539")]
			[Address(RVA = "0x1382FC8", Offset = "0x1382FC8", VA = "0x1382FC8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600053A")]
			[Address(RVA = "0x1383680", Offset = "0x1383680", VA = "0x1383680")]
			set
			{
			}
		}

		[Token(Token = "0x170000B0")]
		public bool IncludeLength
		{
			[Token(Token = "0x600053B")]
			[Address(RVA = "0x1383688", Offset = "0x1383688", VA = "0x1383688")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600053C")]
			[Address(RVA = "0x13872FC", Offset = "0x13872FC", VA = "0x13872FC")]
			set
			{
			}
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x138386C", Offset = "0x138386C", VA = "0x138386C")]
		public BsonString(object value, bool includeLength)
		{
		}
	}
}
