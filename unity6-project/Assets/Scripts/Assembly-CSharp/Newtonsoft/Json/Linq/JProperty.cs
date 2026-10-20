using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Linq
{
	[Token(Token = "0x20000E8")]
	public class JProperty : JContainer
	{
		[Token(Token = "0x40003CF")]
		[FieldOffset(Offset = "0x2C")]
		private readonly List<JToken> _content;

		[Token(Token = "0x40003D0")]
		[FieldOffset(Offset = "0x30")]
		private readonly string _name;

		[Token(Token = "0x17000153")]
		protected override IList<JToken> ChildrenTokens
		{
			[Token(Token = "0x6000898")]
			[Address(RVA = "0xF96BC0", Offset = "0xF96BC0", VA = "0xF96BC0", Slot = "51")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000154")]
		public string Name
		{
			[Token(Token = "0x6000899")]
			[Address(RVA = "0xF922BC", Offset = "0xF922BC", VA = "0xF922BC")]
			[DebuggerStepThrough]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000155")]
		public new JToken Value
		{
			[Token(Token = "0x600089A")]
			[Address(RVA = "0xF8FE28", Offset = "0xF8FE28", VA = "0xF8FE28")]
			[DebuggerStepThrough]
			get
			{
				return null;
			}
			[Token(Token = "0x600089B")]
			[Address(RVA = "0xF93E40", Offset = "0xF93E40", VA = "0xF93E40")]
			set
			{
			}
		}

		[Token(Token = "0x17000156")]
		public override JTokenType Type
		{
			[Token(Token = "0x60008A5")]
			[Address(RVA = "0xF977D8", Offset = "0xF977D8", VA = "0xF977D8", Slot = "13")]
			[DebuggerStepThrough]
			get
			{
				return default(JTokenType);
			}
		}

		[Token(Token = "0x6000894")]
		[Address(RVA = "0xF96AF4", Offset = "0xF96AF4", VA = "0xF96AF4")]
		public JProperty(JProperty other)
		{
		}

		[Token(Token = "0x6000895")]
		[Address(RVA = "0xF901D4", Offset = "0xF901D4", VA = "0xF901D4")]
		internal JProperty(string name)
		{
		}

		[Token(Token = "0x6000896")]
		[Address(RVA = "0xF96BBC", Offset = "0xF96BBC", VA = "0xF96BBC")]
		public JProperty(string name, params object[] content)
		{
		}

		[Token(Token = "0x6000897")]
		[Address(RVA = "0xF91B40", Offset = "0xF91B40", VA = "0xF91B40")]
		public JProperty(string name, object content)
		{
		}

		[Token(Token = "0x600089C")]
		[Address(RVA = "0xF96BC8", Offset = "0xF96BC8", VA = "0xF96BC8", Slot = "55")]
		internal override JToken GetItem(int index)
		{
			return null;
		}

		[Token(Token = "0x600089D")]
		[Address(RVA = "0xF96C78", Offset = "0xF96C78", VA = "0xF96C78", Slot = "56")]
		internal override void SetItem(int index, JToken item)
		{
		}

		[Token(Token = "0x600089E")]
		[Address(RVA = "0xF96E0C", Offset = "0xF96E0C", VA = "0xF96E0C", Slot = "54")]
		internal override bool RemoveItem(JToken item)
		{
			return default(bool);
		}

		[Token(Token = "0x600089F")]
		[Address(RVA = "0xF96FFC", Offset = "0xF96FFC", VA = "0xF96FFC", Slot = "53")]
		internal override void RemoveItemAt(int index)
		{
		}

		[Token(Token = "0x60008A0")]
		[Address(RVA = "0xF971EC", Offset = "0xF971EC", VA = "0xF971EC", Slot = "52")]
		internal override void InsertItem(int index, JToken item)
		{
		}

		[Token(Token = "0x60008A1")]
		[Address(RVA = "0xF9740C", Offset = "0xF9740C", VA = "0xF9740C", Slot = "59")]
		internal override bool ContainsItem(JToken item)
		{
			return default(bool);
		}

		[Token(Token = "0x60008A2")]
		[Address(RVA = "0xF97430", Offset = "0xF97430", VA = "0xF97430", Slot = "57")]
		internal override void ClearItems()
		{
		}

		[Token(Token = "0x60008A3")]
		[Address(RVA = "0xF97620", Offset = "0xF97620", VA = "0xF97620", Slot = "12")]
		internal override bool DeepEquals(JToken node)
		{
			return default(bool);
		}

		[Token(Token = "0x60008A4")]
		[Address(RVA = "0xF97748", Offset = "0xF97748", VA = "0xF97748", Slot = "11")]
		internal override JToken CloneToken()
		{
			return null;
		}

		[Token(Token = "0x60008A6")]
		[Address(RVA = "0xF977E0", Offset = "0xF977E0", VA = "0xF977E0", Slot = "22")]
		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
		}

		[Token(Token = "0x60008A7")]
		[Address(RVA = "0xF97890", Offset = "0xF97890", VA = "0xF97890", Slot = "23")]
		internal override int GetDeepHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60008A8")]
		[Address(RVA = "0xF97920", Offset = "0xF97920", VA = "0xF97920")]
		public new static JProperty Load(JsonReader reader)
		{
			return null;
		}
	}
}
