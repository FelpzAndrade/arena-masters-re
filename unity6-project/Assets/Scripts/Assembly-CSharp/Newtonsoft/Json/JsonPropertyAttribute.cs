using System;
using Il2CppDummyDll;

namespace Newtonsoft.Json
{
	[Token(Token = "0x20000CB")]
	public sealed class JsonPropertyAttribute : Attribute
	{
		[Token(Token = "0x4000314")]
		[FieldOffset(Offset = "0x8")]
		internal NullValueHandling? _nullValueHandling;

		[Token(Token = "0x4000315")]
		[FieldOffset(Offset = "0x10")]
		internal DefaultValueHandling? _defaultValueHandling;

		[Token(Token = "0x4000316")]
		[FieldOffset(Offset = "0x18")]
		internal ReferenceLoopHandling? _referenceLoopHandling;

		[Token(Token = "0x4000317")]
		[FieldOffset(Offset = "0x20")]
		internal ObjectCreationHandling? _objectCreationHandling;

		[Token(Token = "0x4000318")]
		[FieldOffset(Offset = "0x28")]
		internal TypeNameHandling? _typeNameHandling;

		[Token(Token = "0x4000319")]
		[FieldOffset(Offset = "0x30")]
		internal bool? _isReference;

		[Token(Token = "0x400031A")]
		[FieldOffset(Offset = "0x34")]
		internal int? _order;

		[Token(Token = "0x400031B")]
		[FieldOffset(Offset = "0x3C")]
		private string PropertyName__BackingField;

		[Token(Token = "0x400031C")]
		[FieldOffset(Offset = "0x40")]
		private Required Required__BackingField;

		[Token(Token = "0x170000E4")]
		public NullValueHandling NullValueHandling
		{
			[Token(Token = "0x6000666")]
			[Address(RVA = "0xF6C040", Offset = "0xF6C040", VA = "0xF6C040")]
			get
			{
				return default(NullValueHandling);
			}
			[Token(Token = "0x6000667")]
			[Address(RVA = "0xF6C104", Offset = "0xF6C104", VA = "0xF6C104")]
			set
			{
			}
		}

		[Token(Token = "0x170000E5")]
		public DefaultValueHandling DefaultValueHandling
		{
			[Token(Token = "0x6000668")]
			[Address(RVA = "0xF6C1B0", Offset = "0xF6C1B0", VA = "0xF6C1B0")]
			get
			{
				return default(DefaultValueHandling);
			}
			[Token(Token = "0x6000669")]
			[Address(RVA = "0xF6C27C", Offset = "0xF6C27C", VA = "0xF6C27C")]
			set
			{
			}
		}

		[Token(Token = "0x170000E6")]
		public ReferenceLoopHandling ReferenceLoopHandling
		{
			[Token(Token = "0x600066A")]
			[Address(RVA = "0xF6C328", Offset = "0xF6C328", VA = "0xF6C328")]
			get
			{
				return default(ReferenceLoopHandling);
			}
			[Token(Token = "0x600066B")]
			[Address(RVA = "0xF6C3F4", Offset = "0xF6C3F4", VA = "0xF6C3F4")]
			set
			{
			}
		}

		[Token(Token = "0x170000E7")]
		public ObjectCreationHandling ObjectCreationHandling
		{
			[Token(Token = "0x600066C")]
			[Address(RVA = "0xF6C4A0", Offset = "0xF6C4A0", VA = "0xF6C4A0")]
			get
			{
				return default(ObjectCreationHandling);
			}
			[Token(Token = "0x600066D")]
			[Address(RVA = "0xF6C56C", Offset = "0xF6C56C", VA = "0xF6C56C")]
			set
			{
			}
		}

		[Token(Token = "0x170000E8")]
		public TypeNameHandling TypeNameHandling
		{
			[Token(Token = "0x600066E")]
			[Address(RVA = "0xF6C618", Offset = "0xF6C618", VA = "0xF6C618")]
			get
			{
				return default(TypeNameHandling);
			}
			[Token(Token = "0x600066F")]
			[Address(RVA = "0xF6C6E4", Offset = "0xF6C6E4", VA = "0xF6C6E4")]
			set
			{
			}
		}

		[Token(Token = "0x170000E9")]
		public bool IsReference
		{
			[Token(Token = "0x6000670")]
			[Address(RVA = "0xF6C790", Offset = "0xF6C790", VA = "0xF6C790")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000671")]
			[Address(RVA = "0xF6C858", Offset = "0xF6C858", VA = "0xF6C858")]
			set
			{
			}
		}

		[Token(Token = "0x170000EA")]
		public int Order
		{
			[Token(Token = "0x6000672")]
			[Address(RVA = "0xF6C8FC", Offset = "0xF6C8FC", VA = "0xF6C8FC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000673")]
			[Address(RVA = "0xF6C9C8", Offset = "0xF6C9C8", VA = "0xF6C9C8")]
			set
			{
			}
		}

		[Token(Token = "0x170000EB")]
		public string PropertyName
		{
			[Token(Token = "0x6000674")]
			[Address(RVA = "0xF6CA74", Offset = "0xF6CA74", VA = "0xF6CA74")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000675")]
			[Address(RVA = "0xF6C038", Offset = "0xF6C038", VA = "0xF6C038")]
			set
			{
			}
		}

		[Token(Token = "0x170000EC")]
		public Required Required
		{
			[Token(Token = "0x6000676")]
			[Address(RVA = "0xF6CA7C", Offset = "0xF6CA7C", VA = "0xF6CA7C")]
			get
			{
				return default(Required);
			}
			[Token(Token = "0x6000677")]
			[Address(RVA = "0xF6CA84", Offset = "0xF6CA84", VA = "0xF6CA84")]
			set
			{
			}
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0xF6C010", Offset = "0xF6C010", VA = "0xF6C010")]
		public JsonPropertyAttribute()
		{
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0xF6C018", Offset = "0xF6C018", VA = "0xF6C018")]
		public JsonPropertyAttribute(string propertyName)
		{
		}
	}
}
