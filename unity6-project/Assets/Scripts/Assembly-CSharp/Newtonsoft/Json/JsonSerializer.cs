using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using Il2CppDummyDll;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json
{
	[Token(Token = "0x20000D0")]
	public class JsonSerializer
	{
		[Token(Token = "0x4000336")]
		[FieldOffset(Offset = "0x8")]
		private TypeNameHandling _typeNameHandling;

		[Token(Token = "0x4000337")]
		[FieldOffset(Offset = "0xC")]
		private FormatterAssemblyStyle _typeNameAssemblyFormat;

		[Token(Token = "0x4000338")]
		[FieldOffset(Offset = "0x10")]
		private PreserveReferencesHandling _preserveReferencesHandling;

		[Token(Token = "0x4000339")]
		[FieldOffset(Offset = "0x14")]
		private ReferenceLoopHandling _referenceLoopHandling;

		[Token(Token = "0x400033A")]
		[FieldOffset(Offset = "0x18")]
		private MissingMemberHandling _missingMemberHandling;

		[Token(Token = "0x400033B")]
		[FieldOffset(Offset = "0x1C")]
		private ObjectCreationHandling _objectCreationHandling;

		[Token(Token = "0x400033C")]
		[FieldOffset(Offset = "0x20")]
		private NullValueHandling _nullValueHandling;

		[Token(Token = "0x400033D")]
		[FieldOffset(Offset = "0x24")]
		private DefaultValueHandling _defaultValueHandling;

		[Token(Token = "0x400033E")]
		[FieldOffset(Offset = "0x28")]
		private ConstructorHandling _constructorHandling;

		[Token(Token = "0x400033F")]
		[FieldOffset(Offset = "0x2C")]
		private JsonConverterCollection _converters;

		[Token(Token = "0x4000340")]
		[FieldOffset(Offset = "0x30")]
		private IContractResolver _contractResolver;

		[Token(Token = "0x4000341")]
		[FieldOffset(Offset = "0x34")]
		private IReferenceResolver _referenceResolver;

		[Token(Token = "0x4000342")]
		[FieldOffset(Offset = "0x38")]
		private SerializationBinder _binder;

		[Token(Token = "0x4000343")]
		[FieldOffset(Offset = "0x3C")]
		private StreamingContext _context;

		[Token(Token = "0x4000344")]
		[FieldOffset(Offset = "0x44")]
		private EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> m_Error;

		[Token(Token = "0x170000F6")]
		public virtual IReferenceResolver ReferenceResolver
		{
			[Token(Token = "0x60006A2")]
			[Address(RVA = "0xF6DCD8", Offset = "0xF6DCD8", VA = "0xF6DCD8", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006A3")]
			[Address(RVA = "0xF6DD80", Offset = "0xF6DD80", VA = "0xF6DD80", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x170000F7")]
		public virtual SerializationBinder Binder
		{
			[Token(Token = "0x60006A4")]
			[Address(RVA = "0xF6DE4C", Offset = "0xF6DE4C", VA = "0xF6DE4C", Slot = "8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006A5")]
			[Address(RVA = "0xF6DE54", Offset = "0xF6DE54", VA = "0xF6DE54", Slot = "9")]
			set
			{
			}
		}

		[Token(Token = "0x170000F8")]
		public virtual TypeNameHandling TypeNameHandling
		{
			[Token(Token = "0x60006A6")]
			[Address(RVA = "0xF6DF20", Offset = "0xF6DF20", VA = "0xF6DF20", Slot = "10")]
			get
			{
				return default(TypeNameHandling);
			}
			[Token(Token = "0x60006A7")]
			[Address(RVA = "0xF6DF28", Offset = "0xF6DF28", VA = "0xF6DF28", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x170000F9")]
		public virtual FormatterAssemblyStyle TypeNameAssemblyFormat
		{
			[Token(Token = "0x60006A8")]
			[Address(RVA = "0xF6DFE4", Offset = "0xF6DFE4", VA = "0xF6DFE4", Slot = "12")]
			get
			{
				return default(FormatterAssemblyStyle);
			}
			[Token(Token = "0x60006A9")]
			[Address(RVA = "0xF6DFEC", Offset = "0xF6DFEC", VA = "0xF6DFEC", Slot = "13")]
			set
			{
			}
		}

		[Token(Token = "0x170000FA")]
		public virtual PreserveReferencesHandling PreserveReferencesHandling
		{
			[Token(Token = "0x60006AA")]
			[Address(RVA = "0xF6E0A8", Offset = "0xF6E0A8", VA = "0xF6E0A8", Slot = "14")]
			get
			{
				return default(PreserveReferencesHandling);
			}
			[Token(Token = "0x60006AB")]
			[Address(RVA = "0xF6E0B0", Offset = "0xF6E0B0", VA = "0xF6E0B0", Slot = "15")]
			set
			{
			}
		}

		[Token(Token = "0x170000FB")]
		public virtual ReferenceLoopHandling ReferenceLoopHandling
		{
			[Token(Token = "0x60006AC")]
			[Address(RVA = "0xF6E16C", Offset = "0xF6E16C", VA = "0xF6E16C", Slot = "16")]
			get
			{
				return default(ReferenceLoopHandling);
			}
			[Token(Token = "0x60006AD")]
			[Address(RVA = "0xF6E174", Offset = "0xF6E174", VA = "0xF6E174", Slot = "17")]
			set
			{
			}
		}

		[Token(Token = "0x170000FC")]
		public virtual MissingMemberHandling MissingMemberHandling
		{
			[Token(Token = "0x60006AE")]
			[Address(RVA = "0xF6E230", Offset = "0xF6E230", VA = "0xF6E230", Slot = "18")]
			get
			{
				return default(MissingMemberHandling);
			}
			[Token(Token = "0x60006AF")]
			[Address(RVA = "0xF6E238", Offset = "0xF6E238", VA = "0xF6E238", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x170000FD")]
		public virtual NullValueHandling NullValueHandling
		{
			[Token(Token = "0x60006B0")]
			[Address(RVA = "0xF6E2F4", Offset = "0xF6E2F4", VA = "0xF6E2F4", Slot = "20")]
			get
			{
				return default(NullValueHandling);
			}
			[Token(Token = "0x60006B1")]
			[Address(RVA = "0xF6E2FC", Offset = "0xF6E2FC", VA = "0xF6E2FC", Slot = "21")]
			set
			{
			}
		}

		[Token(Token = "0x170000FE")]
		public virtual DefaultValueHandling DefaultValueHandling
		{
			[Token(Token = "0x60006B2")]
			[Address(RVA = "0xF6E3B8", Offset = "0xF6E3B8", VA = "0xF6E3B8", Slot = "22")]
			get
			{
				return default(DefaultValueHandling);
			}
			[Token(Token = "0x60006B3")]
			[Address(RVA = "0xF6E3C0", Offset = "0xF6E3C0", VA = "0xF6E3C0", Slot = "23")]
			set
			{
			}
		}

		[Token(Token = "0x170000FF")]
		public virtual ObjectCreationHandling ObjectCreationHandling
		{
			[Token(Token = "0x60006B4")]
			[Address(RVA = "0xF6E47C", Offset = "0xF6E47C", VA = "0xF6E47C", Slot = "24")]
			get
			{
				return default(ObjectCreationHandling);
			}
			[Token(Token = "0x60006B5")]
			[Address(RVA = "0xF6E484", Offset = "0xF6E484", VA = "0xF6E484", Slot = "25")]
			set
			{
			}
		}

		[Token(Token = "0x17000100")]
		public virtual ConstructorHandling ConstructorHandling
		{
			[Token(Token = "0x60006B6")]
			[Address(RVA = "0xF6E540", Offset = "0xF6E540", VA = "0xF6E540", Slot = "26")]
			get
			{
				return default(ConstructorHandling);
			}
			[Token(Token = "0x60006B7")]
			[Address(RVA = "0xF6E548", Offset = "0xF6E548", VA = "0xF6E548", Slot = "27")]
			set
			{
			}
		}

		[Token(Token = "0x17000101")]
		public virtual JsonConverterCollection Converters
		{
			[Token(Token = "0x60006B8")]
			[Address(RVA = "0xF6E604", Offset = "0xF6E604", VA = "0xF6E604", Slot = "28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000102")]
		public virtual IContractResolver ContractResolver
		{
			[Token(Token = "0x60006B9")]
			[Address(RVA = "0xF6E6A4", Offset = "0xF6E6A4", VA = "0xF6E6A4", Slot = "29")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006BA")]
			[Address(RVA = "0xF6E800", Offset = "0xF6E800", VA = "0xF6E800", Slot = "30")]
			set
			{
			}
		}

		[Token(Token = "0x17000103")]
		public virtual StreamingContext Context
		{
			[Token(Token = "0x60006BB")]
			[Address(RVA = "0xF6E808", Offset = "0xF6E808", VA = "0xF6E808", Slot = "31")]
			get
			{
				return default(StreamingContext);
			}
			[Token(Token = "0x60006BC")]
			[Address(RVA = "0xF6E81C", Offset = "0xF6E81C", VA = "0xF6E81C", Slot = "32")]
			set
			{
			}
		}

		[Token(Token = "0x14000055")]
		public virtual event EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> Error
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x60006A0")]
			[Address(RVA = "0xF6D9C0", Offset = "0xF6D9C0", VA = "0xF6D9C0", Slot = "4")]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x60006A1")]
			[Address(RVA = "0xF6DB4C", Offset = "0xF6DB4C", VA = "0xF6DB4C", Slot = "5")]
			remove
			{
			}
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0xF6D880", Offset = "0xF6D880", VA = "0xF6D880")]
		public JsonSerializer()
		{
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0xF6E828", Offset = "0xF6E828", VA = "0xF6E828")]
		public static JsonSerializer Create(JsonSerializerSettings settings)
		{
			return null;
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0xF6EDDC", Offset = "0xF6EDDC", VA = "0xF6EDDC")]
		public void Populate(TextReader reader, object target)
		{
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0xF6EF84", Offset = "0xF6EF84", VA = "0xF6EF84")]
		public void Populate(JsonReader reader, object target)
		{
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0xF6EFD8", Offset = "0xF6EFD8", VA = "0xF6EFD8", Slot = "33")]
		internal virtual void PopulateInternal(JsonReader reader, object target)
		{
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0xF6FA14", Offset = "0xF6FA14", VA = "0xF6FA14")]
		public object Deserialize(JsonReader reader)
		{
			return null;
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0xF6FA70", Offset = "0xF6FA70", VA = "0xF6FA70")]
		public object Deserialize(TextReader reader, Type objectType)
		{
			return null;
		}

		[Token(Token = "0x60006C3")]
		public T Deserialize<T>(JsonReader reader)
		{
			return (T)default;
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0xF6FA1C", Offset = "0xF6FA1C", VA = "0xF6FA1C")]
		public object Deserialize(JsonReader reader, Type objectType)
		{
			return null;
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0xF6FB14", Offset = "0xF6FB14", VA = "0xF6FB14", Slot = "34")]
		internal virtual object DeserializeInternal(JsonReader reader, Type objectType)
		{
			return null;
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0xF6FD30", Offset = "0xF6FD30", VA = "0xF6FD30")]
		public void Serialize(TextWriter textWriter, object value)
		{
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0xF6FEF0", Offset = "0xF6FEF0", VA = "0xF6FEF0")]
		public void Serialize(JsonWriter jsonWriter, object value)
		{
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0xF6FF44", Offset = "0xF6FF44", VA = "0xF6FF44", Slot = "35")]
		internal virtual void SerializeInternal(JsonWriter jsonWriter, object value)
		{
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0xF70024", Offset = "0xF70024", VA = "0xF70024")]
		internal JsonConverter GetMatchingConverter(Type type)
		{
			return null;
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0xF70030", Offset = "0xF70030", VA = "0xF70030")]
		internal static JsonConverter GetMatchingConverter(IList<JsonConverter> converters, Type objectType)
		{
			return null;
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0xF70260", Offset = "0xF70260", VA = "0xF70260")]
		internal void OnError(Newtonsoft.Json.Serialization.ErrorEventArgs e)
		{
		}
	}
}
