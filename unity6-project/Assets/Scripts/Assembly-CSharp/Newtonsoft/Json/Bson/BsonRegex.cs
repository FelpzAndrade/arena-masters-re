using Il2CppDummyDll;

namespace Newtonsoft.Json.Bson
{
	[Token(Token = "0x20000A6")]
	internal class BsonRegex : BsonToken
	{
		[Token(Token = "0x40002BF")]
		[FieldOffset(Offset = "0x10")]
		private BsonString Pattern__BackingField;

		[Token(Token = "0x40002C0")]
		[FieldOffset(Offset = "0x14")]
		private BsonString Options__BackingField;

		[Token(Token = "0x170000B1")]
		public BsonString Pattern
		{
			[Token(Token = "0x600053E")]
			[Address(RVA = "0x138364C", Offset = "0x138364C", VA = "0x138364C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600053F")]
			[Address(RVA = "0x13872BC", Offset = "0x13872BC", VA = "0x13872BC")]
			set
			{
			}
		}

		[Token(Token = "0x170000B2")]
		public BsonString Options
		{
			[Token(Token = "0x6000540")]
			[Address(RVA = "0x1383654", Offset = "0x1383654", VA = "0x1383654")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000541")]
			[Address(RVA = "0x13872C4", Offset = "0x13872C4", VA = "0x13872C4")]
			set
			{
			}
		}

		[Token(Token = "0x170000B3")]
		public override BsonType Type
		{
			[Token(Token = "0x6000542")]
			[Address(RVA = "0x13872CC", Offset = "0x13872CC", VA = "0x13872CC", Slot = "4")]
			get
			{
				return default(BsonType);
			}
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x13871D8", Offset = "0x13871D8", VA = "0x13871D8")]
		public BsonRegex(string pattern, string options)
		{
		}
	}
}
