using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json.Schema
{
	[Token(Token = "0x2000109")]
	public class JsonSchemaGenerator
	{
		[Token(Token = "0x200010A")]
		private class TypeSchema
		{
			[Token(Token = "0x4000488")]
			[FieldOffset(Offset = "0x8")]
			private Type Type__BackingField;

			[Token(Token = "0x4000489")]
			[FieldOffset(Offset = "0xC")]
			private JsonSchema Schema__BackingField;

			[Token(Token = "0x170001A6")]
			public Type Type
			{
				[Token(Token = "0x6000A60")]
				[Address(RVA = "0xFB1CAC", Offset = "0xFB1CAC", VA = "0xFB1CAC")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000A61")]
				[Address(RVA = "0xFB1CB4", Offset = "0xFB1CB4", VA = "0xFB1CB4")]
				private set
				{
				}
			}

			[Token(Token = "0x170001A7")]
			public JsonSchema Schema
			{
				[Token(Token = "0x6000A62")]
				[Address(RVA = "0xFAF19C", Offset = "0xFAF19C", VA = "0xFAF19C")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000A63")]
				[Address(RVA = "0xFB1CBC", Offset = "0xFB1CBC", VA = "0xFB1CBC")]
				private set
				{
				}
			}

			[Token(Token = "0x6000A5F")]
			[Address(RVA = "0xFB1254", Offset = "0xFB1254", VA = "0xFB1254")]
			public TypeSchema(Type type, JsonSchema schema)
			{
			}
		}

		[Token(Token = "0x200010B")]
		private sealed class _003CGenerateInternal_003Ec__AnonStoreyC7
		{
			[Token(Token = "0x400048A")]
			[FieldOffset(Offset = "0x8")]
			internal Type type;

			[Token(Token = "0x6000A64")]
			[Address(RVA = "0xFB123C", Offset = "0xFB123C", VA = "0xFB123C")]
			public _003CGenerateInternal_003Ec__AnonStoreyC7()
			{
			}

			[Token(Token = "0x6000A65")]
			[Address(RVA = "0xFB1C78", Offset = "0xFB1C78", VA = "0xFB1C78")]
			internal bool _003C_003Em__40(TypeSchema tc)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000483")]
		[FieldOffset(Offset = "0x8")]
		private IContractResolver _contractResolver;

		[Token(Token = "0x4000484")]
		[FieldOffset(Offset = "0xC")]
		private JsonSchemaResolver _resolver;

		[Token(Token = "0x4000485")]
		[FieldOffset(Offset = "0x10")]
		private IList<TypeSchema> _stack;

		[Token(Token = "0x4000486")]
		[FieldOffset(Offset = "0x14")]
		private JsonSchema _currentSchema;

		[Token(Token = "0x4000487")]
		[FieldOffset(Offset = "0x18")]
		private UndefinedSchemaIdHandling UndefinedSchemaIdHandling__BackingField;

		[Token(Token = "0x170001A3")]
		public UndefinedSchemaIdHandling UndefinedSchemaIdHandling
		{
			[Token(Token = "0x6000A4A")]
			[Address(RVA = "0xFAEF14", Offset = "0xFAEF14", VA = "0xFAEF14")]
			get
			{
				return default(UndefinedSchemaIdHandling);
			}
			[Token(Token = "0x6000A4B")]
			[Address(RVA = "0xFAEF1C", Offset = "0xFAEF1C", VA = "0xFAEF1C")]
			set
			{
			}
		}

		[Token(Token = "0x170001A4")]
		public IContractResolver ContractResolver
		{
			[Token(Token = "0x6000A4C")]
			[Address(RVA = "0xFAEF24", Offset = "0xFAEF24", VA = "0xFAEF24")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A4D")]
			[Address(RVA = "0xFAEFCC", Offset = "0xFAEFCC", VA = "0xFAEFCC")]
			set
			{
			}
		}

		[Token(Token = "0x170001A5")]
		private JsonSchema CurrentSchema
		{
			[Token(Token = "0x6000A4E")]
			[Address(RVA = "0xFAEFD4", Offset = "0xFAEFD4", VA = "0xFAEFD4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A49")]
		[Address(RVA = "0xFAEE68", Offset = "0xFAEE68", VA = "0xFAEE68")]
		public JsonSchemaGenerator()
		{
		}

		[Token(Token = "0x6000A4F")]
		[Address(RVA = "0xFAEFDC", Offset = "0xFAEFDC", VA = "0xFAEFDC")]
		private void Push(TypeSchema typeSchema)
		{
		}

		[Token(Token = "0x6000A50")]
		[Address(RVA = "0xFAF1A4", Offset = "0xFAF1A4", VA = "0xFAF1A4")]
		private TypeSchema Pop()
		{
			return null;
		}

		[Token(Token = "0x6000A51")]
		[Address(RVA = "0xFAF48C", Offset = "0xFAF48C", VA = "0xFAF48C")]
		public JsonSchema Generate(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000A52")]
		[Address(RVA = "0xFAF628", Offset = "0xFAF628", VA = "0xFAF628")]
		public JsonSchema Generate(Type type, JsonSchemaResolver resolver)
		{
			return null;
		}

		[Token(Token = "0x6000A53")]
		[Address(RVA = "0xFAF644", Offset = "0xFAF644", VA = "0xFAF644")]
		public JsonSchema Generate(Type type, bool rootSchemaNullable)
		{
			return null;
		}

		[Token(Token = "0x6000A54")]
		[Address(RVA = "0xFAF534", Offset = "0xFAF534", VA = "0xFAF534")]
		public JsonSchema Generate(Type type, JsonSchemaResolver resolver, bool rootSchemaNullable)
		{
			return null;
		}

		[Token(Token = "0x6000A55")]
		[Address(RVA = "0xFB0DCC", Offset = "0xFB0DCC", VA = "0xFB0DCC")]
		private string GetTitle(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000A56")]
		[Address(RVA = "0xFB0EF4", Offset = "0xFB0EF4", VA = "0xFB0EF4")]
		private string GetDescription(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000A57")]
		[Address(RVA = "0xFB1088", Offset = "0xFB1088", VA = "0xFB1088")]
		private string GetTypeId(Type type, bool explicitOnly)
		{
			return null;
		}

		[Token(Token = "0x6000A58")]
		[Address(RVA = "0xFAF6F0", Offset = "0xFAF6F0", VA = "0xFAF6F0")]
		private JsonSchema GenerateInternal(Type type, Required valueRequired, bool required)
		{
			return null;
		}

		[Token(Token = "0x6000A59")]
		[Address(RVA = "0xFB131C", Offset = "0xFB131C", VA = "0xFB131C")]
		private JsonSchemaType AddNullType(JsonSchemaType type, Required valueRequired)
		{
			return default(JsonSchemaType);
		}

		[Token(Token = "0x6000A5A")]
		[Address(RVA = "0xFB1BFC", Offset = "0xFB1BFC", VA = "0xFB1BFC")]
		private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A5B")]
		[Address(RVA = "0xFB165C", Offset = "0xFB165C", VA = "0xFB165C")]
		private void GenerateObjectSchema(Type type, JsonObjectContract contract)
		{
		}

		[Token(Token = "0x6000A5C")]
		[Address(RVA = "0xFB1BCC", Offset = "0xFB1BCC", VA = "0xFB1BCC")]
		private void GenerateISerializableContract(Type type, JsonISerializableContract contract)
		{
		}

		[Token(Token = "0x6000A5D")]
		[Address(RVA = "0xF7CAC8", Offset = "0xF7CAC8", VA = "0xF7CAC8")]
		internal static bool HasFlag(JsonSchemaType? value, JsonSchemaType flag)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A5E")]
		[Address(RVA = "0xFB132C", Offset = "0xFB132C", VA = "0xFB132C")]
		private JsonSchemaType GetJsonSchemaType(Type type, Required valueRequired)
		{
			return default(JsonSchemaType);
		}
	}
}
