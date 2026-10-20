using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

namespace CS
{
	[Token(Token = "0x2000B9C")]
	public class ObjectDiffPatchResult
	{
		[Token(Token = "0x4003B2F")]
		[FieldOffset(Offset = "0x8")]
		private JObject _oldValues;

		[Token(Token = "0x4003B30")]
		[FieldOffset(Offset = "0xC")]
		private JObject _newValues;

		[Token(Token = "0x4003B31")]
		[FieldOffset(Offset = "0x10")]
		private Type _type;

		[Token(Token = "0x17000C6A")]
		public bool AreEqual
		{
			[Token(Token = "0x6005418")]
			[Address(RVA = "0x2341B98", Offset = "0x2341B98", VA = "0x2341B98")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000C6B")]
		public Type Type
		{
			[Token(Token = "0x6005419")]
			[Address(RVA = "0x2342A1C", Offset = "0x2342A1C", VA = "0x2342A1C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600541A")]
			[Address(RVA = "0x2341378", Offset = "0x2341378", VA = "0x2341378")]
			set
			{
			}
		}

		[Token(Token = "0x17000C6C")]
		public JObject OldValues
		{
			[Token(Token = "0x600541B")]
			[Address(RVA = "0x2342970", Offset = "0x2342970", VA = "0x2342970")]
			get
			{
				return null;
			}
			[Token(Token = "0x600541C")]
			[Address(RVA = "0x2341388", Offset = "0x2341388", VA = "0x2341388")]
			set
			{
			}
		}

		[Token(Token = "0x17000C6D")]
		public JObject NewValues
		{
			[Token(Token = "0x600541D")]
			[Address(RVA = "0x2342968", Offset = "0x2342968", VA = "0x2342968")]
			get
			{
				return null;
			}
			[Token(Token = "0x600541E")]
			[Address(RVA = "0x2341390", Offset = "0x2341390", VA = "0x2341390")]
			set
			{
			}
		}

		[Token(Token = "0x6005417")]
		[Address(RVA = "0x2341380", Offset = "0x2341380", VA = "0x2341380")]
		public ObjectDiffPatchResult()
		{
		}
	}
}
