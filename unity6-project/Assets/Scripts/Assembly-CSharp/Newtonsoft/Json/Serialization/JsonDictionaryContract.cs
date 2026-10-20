using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x2000129")]
	public class JsonDictionaryContract : JsonContract
	{
		[Token(Token = "0x40004ED")]
		[FieldOffset(Offset = "0x38")]
		private readonly bool _isDictionaryValueTypeNullableType;

		[Token(Token = "0x40004EE")]
		[FieldOffset(Offset = "0x3C")]
		private readonly Type _genericCollectionDefinitionType;

		[Token(Token = "0x40004EF")]
		[FieldOffset(Offset = "0x40")]
		private Type _genericWrapperType;

		[Token(Token = "0x40004F0")]
		[FieldOffset(Offset = "0x44")]
		private MethodCall<object, object> _genericWrapperCreator;

		[Token(Token = "0x40004F1")]
		[FieldOffset(Offset = "0x48")]
		private Func<string, string> PropertyNameResolver__BackingField;

		[Token(Token = "0x40004F2")]
		[FieldOffset(Offset = "0x4C")]
		private Type DictionaryKeyType__BackingField;

		[Token(Token = "0x40004F3")]
		[FieldOffset(Offset = "0x50")]
		private Type DictionaryValueType__BackingField;

		[Token(Token = "0x170001DB")]
		public Func<string, string> PropertyNameResolver
		{
			[Token(Token = "0x6000B45")]
			[Address(RVA = "0xFC02AC", Offset = "0xFC02AC", VA = "0xFC02AC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B46")]
			[Address(RVA = "0xFBB47C", Offset = "0xFBB47C", VA = "0xFBB47C")]
			set
			{
			}
		}

		[Token(Token = "0x170001DC")]
		internal Type DictionaryKeyType
		{
			[Token(Token = "0x6000B47")]
			[Address(RVA = "0xFC02B4", Offset = "0xFC02B4", VA = "0xFC02B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B48")]
			[Address(RVA = "0xFC0148", Offset = "0xFC0148", VA = "0xFC0148")]
			private set
			{
			}
		}

		[Token(Token = "0x170001DD")]
		internal Type DictionaryValueType
		{
			[Token(Token = "0x6000B49")]
			[Address(RVA = "0xFC0158", Offset = "0xFC0158", VA = "0xFC0158")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B4A")]
			[Address(RVA = "0xFC0150", Offset = "0xFC0150", VA = "0xFC0150")]
			private set
			{
			}
		}

		[Token(Token = "0x6000B44")]
		[Address(RVA = "0xFBB064", Offset = "0xFBB064", VA = "0xFBB064")]
		public JsonDictionaryContract(Type underlyingType)
		{
		}

		[Token(Token = "0x6000B4B")]
		[Address(RVA = "0xFC02BC", Offset = "0xFC02BC", VA = "0xFC02BC")]
		internal IWrappedDictionary CreateWrapper(object dictionary)
		{
			return null;
		}

		[Token(Token = "0x6000B4C")]
		[Address(RVA = "0xFC0160", Offset = "0xFC0160", VA = "0xFC0160")]
		private bool IsTypeGenericDictionaryInterface(Type type)
		{
			return default(bool);
		}
	}
}
