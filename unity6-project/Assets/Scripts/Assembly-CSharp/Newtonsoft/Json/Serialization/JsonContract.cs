using System;
using System.Reflection;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x2000128")]
	public abstract class JsonContract
	{
		protected JsonContract()
		{
		}

		[Token(Token = "0x40004E1")]
		[FieldOffset(Offset = "0x8")]
		private Type UnderlyingType__BackingField;

		[Token(Token = "0x40004E2")]
		[FieldOffset(Offset = "0xC")]
		private Type CreatedType__BackingField;

		[Token(Token = "0x40004E3")]
		[FieldOffset(Offset = "0x10")]
		private bool? IsReference__BackingField;

		[Token(Token = "0x40004E4")]
		[FieldOffset(Offset = "0x14")]
		private JsonConverter Converter__BackingField;

		[Token(Token = "0x40004E5")]
		[FieldOffset(Offset = "0x18")]
		private JsonConverter InternalConverter__BackingField;

		[Token(Token = "0x40004E6")]
		[FieldOffset(Offset = "0x1C")]
		private MethodInfo OnDeserialized__BackingField;

		[Token(Token = "0x40004E7")]
		[FieldOffset(Offset = "0x20")]
		private MethodInfo OnDeserializing__BackingField;

		[Token(Token = "0x40004E8")]
		[FieldOffset(Offset = "0x24")]
		private MethodInfo OnSerialized__BackingField;

		[Token(Token = "0x40004E9")]
		[FieldOffset(Offset = "0x28")]
		private MethodInfo OnSerializing__BackingField;

		[Token(Token = "0x40004EA")]
		[FieldOffset(Offset = "0x2C")]
		private Func<object> DefaultCreator__BackingField;

		[Token(Token = "0x40004EB")]
		[FieldOffset(Offset = "0x30")]
		private bool DefaultCreatorNonPublic__BackingField;

		[Token(Token = "0x40004EC")]
		[FieldOffset(Offset = "0x34")]
		private MethodInfo OnError__BackingField;

		[Token(Token = "0x170001CF")]
		public Type UnderlyingType
		{
			[Token(Token = "0x6000B27")]
			[Address(RVA = "0xFB1BF4", Offset = "0xFB1BF4", VA = "0xFB1BF4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B28")]
			[Address(RVA = "0xFBFAA0", Offset = "0xFBFAA0", VA = "0xFBFAA0")]
			private set
			{
			}
		}

		[Token(Token = "0x170001D0")]
		public Type CreatedType
		{
			[Token(Token = "0x6000B29")]
			[Address(RVA = "0xFB9784", Offset = "0xFB9784", VA = "0xFB9784")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B2A")]
			[Address(RVA = "0xFBF1A8", Offset = "0xFBF1A8", VA = "0xFBF1A8")]
			set
			{
			}
		}

		[Token(Token = "0x170001D1")]
		public bool? IsReference
		{
			[Token(Token = "0x6000B2B")]
			[Address(RVA = "0xFBFAA8", Offset = "0xFBFAA8", VA = "0xFBFAA8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B2C")]
			[Address(RVA = "0xFB976C", Offset = "0xFB976C", VA = "0xFB976C")]
			set
			{
			}
		}

		[Token(Token = "0x170001D2")]
		public JsonConverter Converter
		{
			[Token(Token = "0x6000B2D")]
			[Address(RVA = "0xFB1244", Offset = "0xFB1244", VA = "0xFB1244")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B2E")]
			[Address(RVA = "0xFB9774", Offset = "0xFB9774", VA = "0xFB9774")]
			set
			{
			}
		}

		[Token(Token = "0x170001D3")]
		internal JsonConverter InternalConverter
		{
			[Token(Token = "0x6000B2F")]
			[Address(RVA = "0xFB124C", Offset = "0xFB124C", VA = "0xFB124C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B30")]
			[Address(RVA = "0xFB977C", Offset = "0xFB977C", VA = "0xFB977C")]
			set
			{
			}
		}

		[Token(Token = "0x170001D4")]
		public MethodInfo OnDeserialized
		{
			[Token(Token = "0x6000B31")]
			[Address(RVA = "0xFBFAB0", Offset = "0xFBFAB0", VA = "0xFBFAB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B32")]
			[Address(RVA = "0xFB9E80", Offset = "0xFB9E80", VA = "0xFB9E80")]
			set
			{
			}
		}

		[Token(Token = "0x170001D5")]
		public MethodInfo OnDeserializing
		{
			[Token(Token = "0x6000B33")]
			[Address(RVA = "0xFBFAB8", Offset = "0xFBFAB8", VA = "0xFBFAB8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B34")]
			[Address(RVA = "0xFB9E78", Offset = "0xFB9E78", VA = "0xFB9E78")]
			set
			{
			}
		}

		[Token(Token = "0x170001D6")]
		public MethodInfo OnSerialized
		{
			[Token(Token = "0x6000B35")]
			[Address(RVA = "0xFBFAC0", Offset = "0xFBFAC0", VA = "0xFBFAC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B36")]
			[Address(RVA = "0xFB9E70", Offset = "0xFB9E70", VA = "0xFB9E70")]
			set
			{
			}
		}

		[Token(Token = "0x170001D7")]
		public MethodInfo OnSerializing
		{
			[Token(Token = "0x6000B37")]
			[Address(RVA = "0xFBFAC8", Offset = "0xFBFAC8", VA = "0xFBFAC8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B38")]
			[Address(RVA = "0xFB9E68", Offset = "0xFB9E68", VA = "0xFB9E68")]
			set
			{
			}
		}

		[Token(Token = "0x170001D8")]
		public Func<object> DefaultCreator
		{
			[Token(Token = "0x6000B39")]
			[Address(RVA = "0xFB7F64", Offset = "0xFB7F64", VA = "0xFB7F64")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B3A")]
			[Address(RVA = "0xFB978C", Offset = "0xFB978C", VA = "0xFB978C")]
			set
			{
			}
		}

		[Token(Token = "0x170001D9")]
		public bool DefaultCreatorNonPublic
		{
			[Token(Token = "0x6000B3B")]
			[Address(RVA = "0xFB7F6C", Offset = "0xFB7F6C", VA = "0xFB7F6C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000B3C")]
			[Address(RVA = "0xFB9794", Offset = "0xFB9794", VA = "0xFB9794")]
			set
			{
			}
		}

		[Token(Token = "0x170001DA")]
		public MethodInfo OnError
		{
			[Token(Token = "0x6000B3D")]
			[Address(RVA = "0xFBFAD0", Offset = "0xFBFAD0", VA = "0xFBFAD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B3E")]
			[Address(RVA = "0xFB9E88", Offset = "0xFB9E88", VA = "0xFB9E88")]
			set
			{
			}
		}

		[Token(Token = "0x6000B26")]
		[Address(RVA = "0xFBEEE4", Offset = "0xFBEEE4", VA = "0xFBEEE4")]
		internal JsonContract(Type underlyingType)
		{
		}

		[Token(Token = "0x6000B3F")]
		[Address(RVA = "0xFBFAD8", Offset = "0xFBFAD8", VA = "0xFBFAD8")]
		internal void InvokeOnSerializing(object o, StreamingContext context)
		{
		}

		[Token(Token = "0x6000B40")]
		[Address(RVA = "0xFBFC14", Offset = "0xFBFC14", VA = "0xFBFC14")]
		internal void InvokeOnSerialized(object o, StreamingContext context)
		{
		}

		[Token(Token = "0x6000B41")]
		[Address(RVA = "0xFBFD50", Offset = "0xFBFD50", VA = "0xFBFD50")]
		internal void InvokeOnDeserializing(object o, StreamingContext context)
		{
		}

		[Token(Token = "0x6000B42")]
		[Address(RVA = "0xFBFE8C", Offset = "0xFBFE8C", VA = "0xFBFE8C")]
		internal void InvokeOnDeserialized(object o, StreamingContext context)
		{
		}

		[Token(Token = "0x6000B43")]
		[Address(RVA = "0xFBFFC8", Offset = "0xFBFFC8", VA = "0xFBFFC8")]
		internal void InvokeOnError(object o, StreamingContext context, ErrorContext errorContext)
		{
		}
	}
}
