using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x2000131")]
	internal abstract class JsonSerializerInternalBase
	{
		protected JsonSerializerInternalBase()
		{
		}

		[Token(Token = "0x2000132")]
		private class ReferenceEqualsEqualityComparer
		{
			[Token(Token = "0x6000BA8")]
			[Address(RVA = "0xFC1768", Offset = "0xFC1768", VA = "0xFC1768")]
			public ReferenceEqualsEqualityComparer()
			{
			}

			[Token(Token = "0x6000BA9")]
			[Address(RVA = "0xFC1AB4", Offset = "0xFC1AB4", VA = "0xFC1AB4", Slot = "4")]
			private bool System_002ECollections_002EGeneric_002EIEqualityComparer_003Cobject_003E_002EEquals(object x, object y)
			{
				return default(bool);
			}

			[Token(Token = "0x6000BAA")]
			[Address(RVA = "0xFC1AC0", Offset = "0xFC1AC0", VA = "0xFC1AC0", Slot = "5")]
			private int System_002ECollections_002EGeneric_002EIEqualityComparer_003Cobject_003E_002EGetHashCode(object obj)
			{
				return default(int);
			}
		}

		[Token(Token = "0x4000511")]
		[FieldOffset(Offset = "0x8")]
		private ErrorContext _currentErrorContext;

		[Token(Token = "0x4000512")]
		[FieldOffset(Offset = "0xC")]
		private BidirectionalDictionary<string, object> _mappings;

		[Token(Token = "0x4000513")]
		[FieldOffset(Offset = "0x10")]
		private JsonSerializer Serializer__BackingField;

		[Token(Token = "0x170001F9")]
		internal JsonSerializer Serializer
		{
			[Token(Token = "0x6000BA2")]
			[Address(RVA = "0xFC1760", Offset = "0xFC1760", VA = "0xFC1760")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BA3")]
			[Address(RVA = "0xFC1758", Offset = "0xFC1758", VA = "0xFC1758")]
			private set
			{
			}
		}

		[Token(Token = "0x170001FA")]
		internal BidirectionalDictionary<string, object> DefaultReferenceMappings
		{
			[Token(Token = "0x6000BA4")]
			[Address(RVA = "0xFBE01C", Offset = "0xFBE01C", VA = "0xFBE01C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000BA1")]
		[Address(RVA = "0xFC16B8", Offset = "0xFC16B8", VA = "0xFC16B8")]
		protected JsonSerializerInternalBase(JsonSerializer serializer)
		{
		}

		[Token(Token = "0x6000BA5")]
		[Address(RVA = "0xFC1770", Offset = "0xFC1770", VA = "0xFC1770")]
		protected ErrorContext GetErrorContext(object currentObject, object member, Exception error)
		{
			return null;
		}

		[Token(Token = "0x6000BA6")]
		[Address(RVA = "0xFC1894", Offset = "0xFC1894", VA = "0xFC1894")]
		protected void ClearErrorContext()
		{
		}

		[Token(Token = "0x6000BA7")]
		[Address(RVA = "0xFC1954", Offset = "0xFC1954", VA = "0xFC1954")]
		protected bool IsErrorHandled(object currentObject, JsonContract contract, object keyValue, Exception ex)
		{
			return default(bool);
		}
	}
}
