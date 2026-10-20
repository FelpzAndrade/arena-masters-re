using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Bson
{
	[Token(Token = "0x20000A3")]
	internal class BsonArray : BsonToken
	{
		[Token(Token = "0x40002BA")]
		[FieldOffset(Offset = "0x10")]
		private readonly List<BsonToken> _children;

		[Token(Token = "0x170000AC")]
		public override BsonType Type
		{
			[Token(Token = "0x6000533")]
			[Address(RVA = "0x13809C4", Offset = "0x13809C4", VA = "0x13809C4", Slot = "4")]
			get
			{
				return default(BsonType);
			}
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x138079C", Offset = "0x138079C", VA = "0x138079C")]
		public BsonArray()
		{
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x1380850", Offset = "0x1380850", VA = "0x1380850", Slot = "5")]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x1380914", Offset = "0x1380914", VA = "0x1380914")]
		public void Add(BsonToken token)
		{
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x1380854", Offset = "0x1380854", VA = "0x1380854", Slot = "6")]
		public IEnumerator<BsonToken> GetEnumerator()
		{
			return null;
		}
	}
}
