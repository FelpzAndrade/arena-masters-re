using Il2CppDummyDll;

namespace Newtonsoft.Json.Bson
{
	[Token(Token = "0x20000A1")]
	internal abstract class BsonToken
	{
		[Token(Token = "0x40002B7")]
		[FieldOffset(Offset = "0x8")]
		private BsonToken Parent__BackingField;

		[Token(Token = "0x40002B8")]
		[FieldOffset(Offset = "0xC")]
		private int CalculatedSize__BackingField;

		[Token(Token = "0x170000A8")]
		public abstract BsonType Type
		{
			[Token(Token = "0x6000526")]
			get;
		}

		[Token(Token = "0x170000A9")]
		public BsonToken Parent
		{
			[Token(Token = "0x6000527")]
			[Address(RVA = "0x1387304", Offset = "0x1387304", VA = "0x1387304")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000528")]
			[Address(RVA = "0x13809BC", Offset = "0x13809BC", VA = "0x13809BC")]
			set
			{
			}
		}

		[Token(Token = "0x170000AA")]
		public int CalculatedSize
		{
			[Token(Token = "0x6000529")]
			[Address(RVA = "0x1382EE8", Offset = "0x1382EE8", VA = "0x1382EE8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600052A")]
			[Address(RVA = "0x1383678", Offset = "0x1383678", VA = "0x1383678")]
			set
			{
			}
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x1380848", Offset = "0x1380848", VA = "0x1380848")]
		protected BsonToken()
		{
		}
	}
}
