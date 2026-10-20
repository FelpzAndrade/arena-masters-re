using Il2CppDummyDll;

namespace Newtonsoft.Json.Bson
{
	[Token(Token = "0x20000A4")]
	internal class BsonValue : BsonToken
	{
		protected BsonValue()
		{
		}

		[Token(Token = "0x40002BB")]
		[FieldOffset(Offset = "0x10")]
		private object _value;

		[Token(Token = "0x40002BC")]
		[FieldOffset(Offset = "0x14")]
		private BsonType _type;

		[Token(Token = "0x170000AD")]
		public object Value
		{
			[Token(Token = "0x6000536")]
			[Address(RVA = "0x1382FC0", Offset = "0x1382FC0", VA = "0x1382FC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AE")]
		public override BsonType Type
		{
			[Token(Token = "0x6000537")]
			[Address(RVA = "0x138730C", Offset = "0x138730C", VA = "0x138730C", Slot = "4")]
			get
			{
				return default(BsonType);
			}
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x13872D4", Offset = "0x13872D4", VA = "0x13872D4")]
		public BsonValue(object value, BsonType type)
		{
		}
	}
}
