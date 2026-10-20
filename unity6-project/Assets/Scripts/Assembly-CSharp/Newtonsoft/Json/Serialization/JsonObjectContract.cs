using System;
using System.Reflection;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x200012D")]
	public class JsonObjectContract : JsonContract
	{
		[Token(Token = "0x40004F6")]
		[FieldOffset(Offset = "0x38")]
		private MemberSerialization MemberSerialization__BackingField;

		[Token(Token = "0x40004F7")]
		[FieldOffset(Offset = "0x3C")]
		private JsonPropertyCollection Properties__BackingField;

		[Token(Token = "0x40004F8")]
		[FieldOffset(Offset = "0x40")]
		private JsonPropertyCollection ConstructorParameters__BackingField;

		[Token(Token = "0x40004F9")]
		[FieldOffset(Offset = "0x44")]
		private ConstructorInfo OverrideConstructor__BackingField;

		[Token(Token = "0x40004FA")]
		[FieldOffset(Offset = "0x48")]
		private ConstructorInfo ParametrizedConstructor__BackingField;

		[Token(Token = "0x170001DF")]
		public MemberSerialization MemberSerialization
		{
			[Token(Token = "0x6000B65")]
			[Address(RVA = "0xFB7B1C", Offset = "0xFB7B1C", VA = "0xFB7B1C")]
			get
			{
				return default(MemberSerialization);
			}
			[Token(Token = "0x6000B66")]
			[Address(RVA = "0xFB7B14", Offset = "0xFB7B14", VA = "0xFB7B14")]
			set
			{
			}
		}

		[Token(Token = "0x170001E0")]
		public JsonPropertyCollection Properties
		{
			[Token(Token = "0x6000B67")]
			[Address(RVA = "0xFB1C10", Offset = "0xFB1C10", VA = "0xFB1C10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B68")]
			[Address(RVA = "0xFC130C", Offset = "0xFC130C", VA = "0xFC130C")]
			private set
			{
			}
		}

		[Token(Token = "0x170001E1")]
		public JsonPropertyCollection ConstructorParameters
		{
			[Token(Token = "0x6000B69")]
			[Address(RVA = "0xFB7F5C", Offset = "0xFB7F5C", VA = "0xFB7F5C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B6A")]
			[Address(RVA = "0xFC1314", Offset = "0xFC1314", VA = "0xFC1314")]
			private set
			{
			}
		}

		[Token(Token = "0x170001E2")]
		public ConstructorInfo OverrideConstructor
		{
			[Token(Token = "0x6000B6B")]
			[Address(RVA = "0xFC131C", Offset = "0xFC131C", VA = "0xFC131C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B6C")]
			[Address(RVA = "0xFB7F54", Offset = "0xFB7F54", VA = "0xFB7F54")]
			set
			{
			}
		}

		[Token(Token = "0x170001E3")]
		public ConstructorInfo ParametrizedConstructor
		{
			[Token(Token = "0x6000B6D")]
			[Address(RVA = "0xFC1324", Offset = "0xFC1324", VA = "0xFC1324")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B6E")]
			[Address(RVA = "0xFB814C", Offset = "0xFB814C", VA = "0xFB814C")]
			set
			{
			}
		}

		[Token(Token = "0x6000B64")]
		[Address(RVA = "0xFB77B8", Offset = "0xFB77B8", VA = "0xFB77B8")]
		public JsonObjectContract(Type underlyingType)
		{
		}
	}
}
