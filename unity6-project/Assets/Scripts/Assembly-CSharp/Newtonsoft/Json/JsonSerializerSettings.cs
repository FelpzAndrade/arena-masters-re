using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using Il2CppDummyDll;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json
{
	[Token(Token = "0x20000D1")]
	public class JsonSerializerSettings
	{
		[Token(Token = "0x4000345")]
		internal const ReferenceLoopHandling DefaultReferenceLoopHandling = ReferenceLoopHandling.Error;

		[Token(Token = "0x4000346")]
		internal const MissingMemberHandling DefaultMissingMemberHandling = MissingMemberHandling.Ignore;

		[Token(Token = "0x4000347")]
		internal const NullValueHandling DefaultNullValueHandling = NullValueHandling.Include;

		[Token(Token = "0x4000348")]
		internal const DefaultValueHandling DefaultDefaultValueHandling = DefaultValueHandling.Include;

		[Token(Token = "0x4000349")]
		internal const ObjectCreationHandling DefaultObjectCreationHandling = ObjectCreationHandling.Auto;

		[Token(Token = "0x400034A")]
		internal const PreserveReferencesHandling DefaultPreserveReferencesHandling = PreserveReferencesHandling.None;

		[Token(Token = "0x400034B")]
		internal const ConstructorHandling DefaultConstructorHandling = ConstructorHandling.Default;

		[Token(Token = "0x400034C")]
		internal const TypeNameHandling DefaultTypeNameHandling = TypeNameHandling.None;

		[Token(Token = "0x400034D")]
		internal const FormatterAssemblyStyle DefaultTypeNameAssemblyFormat = FormatterAssemblyStyle.Simple;

		[Token(Token = "0x400034E")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly StreamingContext DefaultContext;

		[Token(Token = "0x400034F")]
		[FieldOffset(Offset = "0x8")]
		private ReferenceLoopHandling ReferenceLoopHandling__BackingField;

		[Token(Token = "0x4000350")]
		[FieldOffset(Offset = "0xC")]
		private MissingMemberHandling MissingMemberHandling__BackingField;

		[Token(Token = "0x4000351")]
		[FieldOffset(Offset = "0x10")]
		private ObjectCreationHandling ObjectCreationHandling__BackingField;

		[Token(Token = "0x4000352")]
		[FieldOffset(Offset = "0x14")]
		private NullValueHandling NullValueHandling__BackingField;

		[Token(Token = "0x4000353")]
		[FieldOffset(Offset = "0x18")]
		private DefaultValueHandling DefaultValueHandling__BackingField;

		[Token(Token = "0x4000354")]
		[FieldOffset(Offset = "0x1C")]
		private IList<JsonConverter> Converters__BackingField;

		[Token(Token = "0x4000355")]
		[FieldOffset(Offset = "0x20")]
		private PreserveReferencesHandling PreserveReferencesHandling__BackingField;

		[Token(Token = "0x4000356")]
		[FieldOffset(Offset = "0x24")]
		private TypeNameHandling TypeNameHandling__BackingField;

		[Token(Token = "0x4000357")]
		[FieldOffset(Offset = "0x28")]
		private FormatterAssemblyStyle TypeNameAssemblyFormat__BackingField;

		[Token(Token = "0x4000358")]
		[FieldOffset(Offset = "0x2C")]
		private ConstructorHandling ConstructorHandling__BackingField;

		[Token(Token = "0x4000359")]
		[FieldOffset(Offset = "0x30")]
		private IContractResolver ContractResolver__BackingField;

		[Token(Token = "0x400035A")]
		[FieldOffset(Offset = "0x34")]
		private IReferenceResolver ReferenceResolver__BackingField;

		[Token(Token = "0x400035B")]
		[FieldOffset(Offset = "0x38")]
		private SerializationBinder Binder__BackingField;

		[Token(Token = "0x400035C")]
		[FieldOffset(Offset = "0x3C")]
		private EventHandler<ErrorEventArgs> Error__BackingField;

		[Token(Token = "0x400035D")]
		[FieldOffset(Offset = "0x40")]
		private StreamingContext Context__BackingField;

		[Token(Token = "0x17000104")]
		public ReferenceLoopHandling ReferenceLoopHandling
		{
			[Token(Token = "0x60006CE")]
			[Address(RVA = "0xF6ED78", Offset = "0xF6ED78", VA = "0xF6ED78")]
			get
			{
				return default(ReferenceLoopHandling);
			}
			[Token(Token = "0x60006CF")]
			[Address(RVA = "0xF70424", Offset = "0xF70424", VA = "0xF70424")]
			set
			{
			}
		}

		[Token(Token = "0x17000105")]
		public MissingMemberHandling MissingMemberHandling
		{
			[Token(Token = "0x60006D0")]
			[Address(RVA = "0xF6ED80", Offset = "0xF6ED80", VA = "0xF6ED80")]
			get
			{
				return default(MissingMemberHandling);
			}
			[Token(Token = "0x60006D1")]
			[Address(RVA = "0xF7042C", Offset = "0xF7042C", VA = "0xF7042C")]
			set
			{
			}
		}

		[Token(Token = "0x17000106")]
		public ObjectCreationHandling ObjectCreationHandling
		{
			[Token(Token = "0x60006D2")]
			[Address(RVA = "0xF6ED88", Offset = "0xF6ED88", VA = "0xF6ED88")]
			get
			{
				return default(ObjectCreationHandling);
			}
			[Token(Token = "0x60006D3")]
			[Address(RVA = "0xF70434", Offset = "0xF70434", VA = "0xF70434")]
			set
			{
			}
		}

		[Token(Token = "0x17000107")]
		public NullValueHandling NullValueHandling
		{
			[Token(Token = "0x60006D4")]
			[Address(RVA = "0xF6ED90", Offset = "0xF6ED90", VA = "0xF6ED90")]
			get
			{
				return default(NullValueHandling);
			}
			[Token(Token = "0x60006D5")]
			[Address(RVA = "0xF7043C", Offset = "0xF7043C", VA = "0xF7043C")]
			set
			{
			}
		}

		[Token(Token = "0x17000108")]
		public DefaultValueHandling DefaultValueHandling
		{
			[Token(Token = "0x60006D6")]
			[Address(RVA = "0xF6ED98", Offset = "0xF6ED98", VA = "0xF6ED98")]
			get
			{
				return default(DefaultValueHandling);
			}
			[Token(Token = "0x60006D7")]
			[Address(RVA = "0xF70444", Offset = "0xF70444", VA = "0xF70444")]
			set
			{
			}
		}

		[Token(Token = "0x17000109")]
		public IList<JsonConverter> Converters
		{
			[Token(Token = "0x60006D8")]
			[Address(RVA = "0xF6ED58", Offset = "0xF6ED58", VA = "0xF6ED58")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006D9")]
			[Address(RVA = "0xF70470", Offset = "0xF70470", VA = "0xF70470")]
			set
			{
			}
		}

		[Token(Token = "0x1700010A")]
		public PreserveReferencesHandling PreserveReferencesHandling
		{
			[Token(Token = "0x60006DA")]
			[Address(RVA = "0xF6ED70", Offset = "0xF6ED70", VA = "0xF6ED70")]
			get
			{
				return default(PreserveReferencesHandling);
			}
			[Token(Token = "0x60006DB")]
			[Address(RVA = "0xF7044C", Offset = "0xF7044C", VA = "0xF7044C")]
			set
			{
			}
		}

		[Token(Token = "0x1700010B")]
		public TypeNameHandling TypeNameHandling
		{
			[Token(Token = "0x60006DC")]
			[Address(RVA = "0xF6ED60", Offset = "0xF6ED60", VA = "0xF6ED60")]
			get
			{
				return default(TypeNameHandling);
			}
			[Token(Token = "0x60006DD")]
			[Address(RVA = "0xF70454", Offset = "0xF70454", VA = "0xF70454")]
			set
			{
			}
		}

		[Token(Token = "0x1700010C")]
		public FormatterAssemblyStyle TypeNameAssemblyFormat
		{
			[Token(Token = "0x60006DE")]
			[Address(RVA = "0xF6ED68", Offset = "0xF6ED68", VA = "0xF6ED68")]
			get
			{
				return default(FormatterAssemblyStyle);
			}
			[Token(Token = "0x60006DF")]
			[Address(RVA = "0xF7045C", Offset = "0xF7045C", VA = "0xF7045C")]
			set
			{
			}
		}

		[Token(Token = "0x1700010D")]
		public ConstructorHandling ConstructorHandling
		{
			[Token(Token = "0x60006E0")]
			[Address(RVA = "0xF6EDA0", Offset = "0xF6EDA0", VA = "0xF6EDA0")]
			get
			{
				return default(ConstructorHandling);
			}
			[Token(Token = "0x60006E1")]
			[Address(RVA = "0xF70560", Offset = "0xF70560", VA = "0xF70560")]
			set
			{
			}
		}

		[Token(Token = "0x1700010E")]
		public IContractResolver ContractResolver
		{
			[Token(Token = "0x60006E2")]
			[Address(RVA = "0xF6EDC4", Offset = "0xF6EDC4", VA = "0xF6EDC4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006E3")]
			[Address(RVA = "0xF70568", Offset = "0xF70568", VA = "0xF70568")]
			set
			{
			}
		}

		[Token(Token = "0x1700010F")]
		public IReferenceResolver ReferenceResolver
		{
			[Token(Token = "0x60006E4")]
			[Address(RVA = "0xF6EDCC", Offset = "0xF6EDCC", VA = "0xF6EDCC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006E5")]
			[Address(RVA = "0xF70570", Offset = "0xF70570", VA = "0xF70570")]
			set
			{
			}
		}

		[Token(Token = "0x17000110")]
		public SerializationBinder Binder
		{
			[Token(Token = "0x60006E6")]
			[Address(RVA = "0xF6EDD4", Offset = "0xF6EDD4", VA = "0xF6EDD4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006E7")]
			[Address(RVA = "0xF70578", Offset = "0xF70578", VA = "0xF70578")]
			set
			{
			}
		}

		[Token(Token = "0x17000111")]
		public EventHandler<ErrorEventArgs> Error
		{
			[Token(Token = "0x60006E8")]
			[Address(RVA = "0xF6EDBC", Offset = "0xF6EDBC", VA = "0xF6EDBC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006E9")]
			[Address(RVA = "0xF70580", Offset = "0xF70580", VA = "0xF70580")]
			set
			{
			}
		}

		[Token(Token = "0x17000112")]
		public StreamingContext Context
		{
			[Token(Token = "0x60006EA")]
			[Address(RVA = "0xF6EDA8", Offset = "0xF6EDA8", VA = "0xF6EDA8")]
			get
			{
				return default(StreamingContext);
			}
			[Token(Token = "0x60006EB")]
			[Address(RVA = "0xF70464", Offset = "0xF70464", VA = "0xF70464")]
			set
			{
			}
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0xF702F8", Offset = "0xF702F8", VA = "0xF702F8")]
		public JsonSerializerSettings()
		{
		}
	}
}
