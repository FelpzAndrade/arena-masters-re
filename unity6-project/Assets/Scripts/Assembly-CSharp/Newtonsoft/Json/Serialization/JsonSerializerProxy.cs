using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x2000137")]
	internal class JsonSerializerProxy : JsonSerializer
	{
		[Token(Token = "0x4000525")]
		[FieldOffset(Offset = "0x48")]
		private readonly JsonSerializerInternalReader _serializerReader;

		[Token(Token = "0x4000526")]
		[FieldOffset(Offset = "0x4C")]
		private readonly JsonSerializerInternalWriter _serializerWriter;

		[Token(Token = "0x4000527")]
		[FieldOffset(Offset = "0x50")]
		private readonly JsonSerializer _serializer;

		[Token(Token = "0x170001FC")]
		public override IReferenceResolver ReferenceResolver
		{
			[Token(Token = "0x6000BF5")]
			[Address(RVA = "0x118F3C4", Offset = "0x118F3C4", VA = "0x118F3C4", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BF6")]
			[Address(RVA = "0x118F41C", Offset = "0x118F41C", VA = "0x118F41C", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x170001FD")]
		public override JsonConverterCollection Converters
		{
			[Token(Token = "0x6000BF7")]
			[Address(RVA = "0x118F47C", Offset = "0x118F47C", VA = "0x118F47C", Slot = "28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001FE")]
		public override DefaultValueHandling DefaultValueHandling
		{
			[Token(Token = "0x6000BF8")]
			[Address(RVA = "0x118F4D4", Offset = "0x118F4D4", VA = "0x118F4D4", Slot = "22")]
			get
			{
				return default(DefaultValueHandling);
			}
			[Token(Token = "0x6000BF9")]
			[Address(RVA = "0x118F52C", Offset = "0x118F52C", VA = "0x118F52C", Slot = "23")]
			set
			{
			}
		}

		[Token(Token = "0x170001FF")]
		public override IContractResolver ContractResolver
		{
			[Token(Token = "0x6000BFA")]
			[Address(RVA = "0x118F58C", Offset = "0x118F58C", VA = "0x118F58C", Slot = "29")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BFB")]
			[Address(RVA = "0x118F5E4", Offset = "0x118F5E4", VA = "0x118F5E4", Slot = "30")]
			set
			{
			}
		}

		[Token(Token = "0x17000200")]
		public override MissingMemberHandling MissingMemberHandling
		{
			[Token(Token = "0x6000BFC")]
			[Address(RVA = "0x118F644", Offset = "0x118F644", VA = "0x118F644", Slot = "18")]
			get
			{
				return default(MissingMemberHandling);
			}
			[Token(Token = "0x6000BFD")]
			[Address(RVA = "0x118F69C", Offset = "0x118F69C", VA = "0x118F69C", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x17000201")]
		public override NullValueHandling NullValueHandling
		{
			[Token(Token = "0x6000BFE")]
			[Address(RVA = "0x118F6FC", Offset = "0x118F6FC", VA = "0x118F6FC", Slot = "20")]
			get
			{
				return default(NullValueHandling);
			}
			[Token(Token = "0x6000BFF")]
			[Address(RVA = "0x118F754", Offset = "0x118F754", VA = "0x118F754", Slot = "21")]
			set
			{
			}
		}

		[Token(Token = "0x17000202")]
		public override ObjectCreationHandling ObjectCreationHandling
		{
			[Token(Token = "0x6000C00")]
			[Address(RVA = "0x118F7B4", Offset = "0x118F7B4", VA = "0x118F7B4", Slot = "24")]
			get
			{
				return default(ObjectCreationHandling);
			}
			[Token(Token = "0x6000C01")]
			[Address(RVA = "0x118F80C", Offset = "0x118F80C", VA = "0x118F80C", Slot = "25")]
			set
			{
			}
		}

		[Token(Token = "0x17000203")]
		public override ReferenceLoopHandling ReferenceLoopHandling
		{
			[Token(Token = "0x6000C02")]
			[Address(RVA = "0x118F86C", Offset = "0x118F86C", VA = "0x118F86C", Slot = "16")]
			get
			{
				return default(ReferenceLoopHandling);
			}
			[Token(Token = "0x6000C03")]
			[Address(RVA = "0x118F8C4", Offset = "0x118F8C4", VA = "0x118F8C4", Slot = "17")]
			set
			{
			}
		}

		[Token(Token = "0x17000204")]
		public override PreserveReferencesHandling PreserveReferencesHandling
		{
			[Token(Token = "0x6000C04")]
			[Address(RVA = "0x118F924", Offset = "0x118F924", VA = "0x118F924", Slot = "14")]
			get
			{
				return default(PreserveReferencesHandling);
			}
			[Token(Token = "0x6000C05")]
			[Address(RVA = "0x118F97C", Offset = "0x118F97C", VA = "0x118F97C", Slot = "15")]
			set
			{
			}
		}

		[Token(Token = "0x17000205")]
		public override TypeNameHandling TypeNameHandling
		{
			[Token(Token = "0x6000C06")]
			[Address(RVA = "0x118F9DC", Offset = "0x118F9DC", VA = "0x118F9DC", Slot = "10")]
			get
			{
				return default(TypeNameHandling);
			}
			[Token(Token = "0x6000C07")]
			[Address(RVA = "0x118FA34", Offset = "0x118FA34", VA = "0x118FA34", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x17000206")]
		public override FormatterAssemblyStyle TypeNameAssemblyFormat
		{
			[Token(Token = "0x6000C08")]
			[Address(RVA = "0x118FA94", Offset = "0x118FA94", VA = "0x118FA94", Slot = "12")]
			get
			{
				return default(FormatterAssemblyStyle);
			}
			[Token(Token = "0x6000C09")]
			[Address(RVA = "0x118FAEC", Offset = "0x118FAEC", VA = "0x118FAEC", Slot = "13")]
			set
			{
			}
		}

		[Token(Token = "0x17000207")]
		public override ConstructorHandling ConstructorHandling
		{
			[Token(Token = "0x6000C0A")]
			[Address(RVA = "0x118FB4C", Offset = "0x118FB4C", VA = "0x118FB4C", Slot = "26")]
			get
			{
				return default(ConstructorHandling);
			}
			[Token(Token = "0x6000C0B")]
			[Address(RVA = "0x118FBA4", Offset = "0x118FBA4", VA = "0x118FBA4", Slot = "27")]
			set
			{
			}
		}

		[Token(Token = "0x17000208")]
		public override SerializationBinder Binder
		{
			[Token(Token = "0x6000C0C")]
			[Address(RVA = "0x118FC04", Offset = "0x118FC04", VA = "0x118FC04", Slot = "8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C0D")]
			[Address(RVA = "0x118FC5C", Offset = "0x118FC5C", VA = "0x118FC5C", Slot = "9")]
			set
			{
			}
		}

		[Token(Token = "0x17000209")]
		public override StreamingContext Context
		{
			[Token(Token = "0x6000C0E")]
			[Address(RVA = "0x118FCBC", Offset = "0x118FCBC", VA = "0x118FCBC", Slot = "31")]
			get
			{
				return default(StreamingContext);
			}
			[Token(Token = "0x6000C0F")]
			[Address(RVA = "0x118FD14", Offset = "0x118FD14", VA = "0x118FD14", Slot = "32")]
			set
			{
			}
		}

		[Token(Token = "0x1400005A")]
		public override event EventHandler<ErrorEventArgs> Error
		{
			[Token(Token = "0x6000BF3")]
			[Address(RVA = "0x118F304", Offset = "0x118F304", VA = "0x118F304", Slot = "4")]
			add
			{
			}
			[Token(Token = "0x6000BF4")]
			[Address(RVA = "0x118F364", Offset = "0x118F364", VA = "0x118F364", Slot = "5")]
			remove
			{
			}
		}

		[Token(Token = "0x6000BF1")]
		[Address(RVA = "0x118F1A0", Offset = "0x118F1A0", VA = "0x118F1A0")]
		public JsonSerializerProxy(JsonSerializerInternalReader serializerReader)
		{
		}

		[Token(Token = "0x6000BF2")]
		[Address(RVA = "0x11899C4", Offset = "0x11899C4", VA = "0x11899C4")]
		public JsonSerializerProxy(JsonSerializerInternalWriter serializerWriter)
		{
		}

		[Token(Token = "0x6000C10")]
		[Address(RVA = "0x118FD7C", Offset = "0x118FD7C", VA = "0x118FD7C")]
		internal JsonSerializerInternalBase GetInternalSerializer()
		{
			return null;
		}

		[Token(Token = "0x6000C11")]
		[Address(RVA = "0x118FD90", Offset = "0x118FD90", VA = "0x118FD90", Slot = "34")]
		internal override object DeserializeInternal(JsonReader reader, Type objectType)
		{
			return null;
		}

		[Token(Token = "0x6000C12")]
		[Address(RVA = "0x118FDD8", Offset = "0x118FDD8", VA = "0x118FDD8", Slot = "33")]
		internal override void PopulateInternal(JsonReader reader, object target)
		{
		}

		[Token(Token = "0x6000C13")]
		[Address(RVA = "0x118FE20", Offset = "0x118FE20", VA = "0x118FE20", Slot = "35")]
		internal override void SerializeInternal(JsonWriter jsonWriter, object value)
		{
		}
	}
}
