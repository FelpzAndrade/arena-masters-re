using System;
using System.IO;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Bson
{
	[Token(Token = "0x20000A9")]
	public class BsonWriter : JsonWriter
	{
		[Token(Token = "0x40002D8")]
		[FieldOffset(Offset = "0x1C")]
		private readonly BsonBinaryWriter _writer;

		[Token(Token = "0x40002D9")]
		[FieldOffset(Offset = "0x20")]
		private BsonToken _root;

		[Token(Token = "0x40002DA")]
		[FieldOffset(Offset = "0x24")]
		private BsonToken _parent;

		[Token(Token = "0x40002DB")]
		[FieldOffset(Offset = "0x28")]
		private string _propertyName;

		[Token(Token = "0x170000B6")]
		public DateTimeKind DateTimeKindHandling
		{
			[Token(Token = "0x6000549")]
			[Address(RVA = "0x138740C", Offset = "0x138740C", VA = "0x138740C")]
			get
			{
				return default(DateTimeKind);
			}
			[Token(Token = "0x600054A")]
			[Address(RVA = "0x1387430", Offset = "0x1387430", VA = "0x1387430")]
			set
			{
			}
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x1387314", Offset = "0x1387314", VA = "0x1387314")]
		public BsonWriter(Stream stream)
		{
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x1387454", Offset = "0x1387454", VA = "0x1387454", Slot = "5")]
		public override void Flush()
		{
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0x138747C", Offset = "0x138747C", VA = "0x138747C", Slot = "15")]
		protected override void WriteEnd(JsonToken token)
		{
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0x138750C", Offset = "0x138750C", VA = "0x138750C", Slot = "61")]
		public override void WriteComment(string text)
		{
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x13875B4", Offset = "0x13875B4", VA = "0x13875B4", Slot = "11")]
		public override void WriteStartConstructor(string name)
		{
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0x138765C", Offset = "0x138765C", VA = "0x138765C", Slot = "21")]
		public override void WriteRaw(string json)
		{
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0x1387704", Offset = "0x1387704", VA = "0x1387704", Slot = "22")]
		public override void WriteRawValue(string json)
		{
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0x13877AC", Offset = "0x13877AC", VA = "0x13877AC", Slot = "9")]
		public override void WriteStartArray()
		{
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x138786C", Offset = "0x138786C", VA = "0x138786C", Slot = "7")]
		public override void WriteStartObject()
		{
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x1387910", Offset = "0x1387910", VA = "0x1387910", Slot = "13")]
		public override void WritePropertyName(string name)
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x1387930", Offset = "0x1387930", VA = "0x1387930", Slot = "6")]
		public override void Close()
		{
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x1387850", Offset = "0x1387850", VA = "0x1387850")]
		private void AddParent(BsonToken container)
		{
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x13874E4", Offset = "0x13874E4", VA = "0x13874E4")]
		private void RemoveParent()
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x1387CE0", Offset = "0x1387CE0", VA = "0x1387CE0")]
		private void AddValue(object value, BsonType type)
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x1387970", Offset = "0x1387970", VA = "0x1387970")]
		internal void AddToken(BsonToken token)
		{
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x1387D88", Offset = "0x1387D88", VA = "0x1387D88", Slot = "19")]
		public override void WriteNull()
		{
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x1387DB0", Offset = "0x1387DB0", VA = "0x1387DB0", Slot = "20")]
		public override void WriteUndefined()
		{
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x1387DD8", Offset = "0x1387DD8", VA = "0x1387DD8", Slot = "23")]
		public override void WriteValue(string value)
		{
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x1387EB4", Offset = "0x1387EB4", VA = "0x1387EB4", Slot = "24")]
		public override void WriteValue(int value)
		{
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x1387F68", Offset = "0x1387F68", VA = "0x1387F68", Slot = "25")]
		public override void WriteValue(uint value)
		{
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x1388074", Offset = "0x1388074", VA = "0x1388074", Slot = "26")]
		public override void WriteValue(long value)
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x1388138", Offset = "0x1388138", VA = "0x1388138", Slot = "27")]
		public override void WriteValue(ulong value)
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x1388254", Offset = "0x1388254", VA = "0x1388254", Slot = "28")]
		public override void WriteValue(float value)
		{
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x1388314", Offset = "0x1388314", VA = "0x1388314", Slot = "29")]
		public override void WriteValue(double value)
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x13883E0", Offset = "0x13883E0", VA = "0x13883E0", Slot = "30")]
		public override void WriteValue(bool value)
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x1388494", Offset = "0x1388494", VA = "0x1388494", Slot = "31")]
		public override void WriteValue(short value)
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x1388548", Offset = "0x1388548", VA = "0x1388548", Slot = "32")]
		public override void WriteValue(ushort value)
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x13885FC", Offset = "0x13885FC", VA = "0x13885FC", Slot = "33")]
		public override void WriteValue(char value)
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x13886D8", Offset = "0x13886D8", VA = "0x13886D8", Slot = "34")]
		public override void WriteValue(byte value)
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x138878C", Offset = "0x138878C", VA = "0x138878C", Slot = "35")]
		public override void WriteValue(sbyte value)
		{
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x1388840", Offset = "0x1388840", VA = "0x1388840", Slot = "36")]
		public override void WriteValue(decimal value)
		{
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x138891C", Offset = "0x138891C", VA = "0x138891C", Slot = "37")]
		public override void WriteValue(DateTime value)
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x13889EC", Offset = "0x13889EC", VA = "0x13889EC", Slot = "38")]
		public override void WriteValue(DateTimeOffset value)
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x1388AE4", Offset = "0x1388AE4", VA = "0x1388AE4", Slot = "58")]
		public override void WriteValue(byte[] value)
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x1388B10", Offset = "0x1388B10", VA = "0x1388B10", Slot = "39")]
		public override void WriteValue(Guid value)
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x1388C14", Offset = "0x1388C14", VA = "0x1388C14", Slot = "40")]
		public override void WriteValue(TimeSpan value)
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x1388D00", Offset = "0x1388D00", VA = "0x1388D00", Slot = "59")]
		public override void WriteValue(Uri value)
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x1388E04", Offset = "0x1388E04", VA = "0x1388E04")]
		public void WriteObjectId(byte[] value)
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x1388F24", Offset = "0x1388F24", VA = "0x1388F24")]
		public void WriteRegex(string pattern, string options)
		{
		}
	}
}
