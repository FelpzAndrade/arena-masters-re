using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x2000127")]
	public class JsonArrayContract : JsonContract
	{
		[Token(Token = "0x40004DC")]
		[FieldOffset(Offset = "0x38")]
		private readonly bool _isCollectionItemTypeNullableType;

		[Token(Token = "0x40004DD")]
		[FieldOffset(Offset = "0x3C")]
		private readonly Type _genericCollectionDefinitionType;

		[Token(Token = "0x40004DE")]
		[FieldOffset(Offset = "0x40")]
		private Type _genericWrapperType;

		[Token(Token = "0x40004DF")]
		[FieldOffset(Offset = "0x44")]
		private MethodCall<object, object> _genericWrapperCreator;

		[Token(Token = "0x40004E0")]
		[FieldOffset(Offset = "0x48")]
		private Type CollectionItemType__BackingField;

		[Token(Token = "0x170001CE")]
		internal Type CollectionItemType
		{
			[Token(Token = "0x6000B21")]
			[Address(RVA = "0xFBEF90", Offset = "0xFBEF90", VA = "0xFBEF90")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B22")]
			[Address(RVA = "0xFBEF88", Offset = "0xFBEF88", VA = "0xFBEF88")]
			private set
			{
			}
		}

		[Token(Token = "0x6000B20")]
		[Address(RVA = "0xFBB524", Offset = "0xFBB524", VA = "0xFBB524")]
		public JsonArrayContract(Type underlyingType)
		{
		}

		[Token(Token = "0x6000B23")]
		[Address(RVA = "0xFBF1B0", Offset = "0xFBF1B0", VA = "0xFBF1B0")]
		internal IWrappedCollection CreateWrapper(object list)
		{
			return null;
		}

		[Token(Token = "0x6000B24")]
		[Address(RVA = "0xFBF640", Offset = "0xFBF640", VA = "0xFBF640")]
		private void EnsureGenericWrapperCreator()
		{
		}

		[Token(Token = "0x6000B25")]
		[Address(RVA = "0xFBEF98", Offset = "0xFBEF98", VA = "0xFBEF98")]
		private bool IsTypeGenericCollectionInterface(Type type)
		{
			return default(bool);
		}
	}
}
