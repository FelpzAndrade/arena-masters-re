using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Bson
{
	[Token(Token = "0x20000A2")]
	internal class BsonObject : BsonToken
	{
		[Token(Token = "0x40002B9")]
		[FieldOffset(Offset = "0x10")]
		private readonly List<BsonProperty> _children;

		[Token(Token = "0x170000AB")]
		public override BsonType Type
		{
			[Token(Token = "0x600052E")]
			[Address(RVA = "0x13838AC", Offset = "0x13838AC", VA = "0x13838AC", Slot = "4")]
			get
			{
				return default(BsonType);
			}
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x1383690", Offset = "0x1383690", VA = "0x1383690")]
		public BsonObject()
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x138373C", Offset = "0x138373C", VA = "0x138373C", Slot = "5")]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x1383740", Offset = "0x1383740", VA = "0x1383740")]
		public void Add(string name, BsonToken token)
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x1382EF0", Offset = "0x1382EF0", VA = "0x1382EF0", Slot = "6")]
		public IEnumerator<BsonProperty> GetEnumerator()
		{
			return null;
		}
	}
}
