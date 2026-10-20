using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

namespace Newtonsoft.Json
{
	[Token(Token = "0x20000D6")]
	public class JsonValidatingReader : JsonReader
	{
		[Token(Token = "0x20000D7")]
		private class SchemaScope
		{
			[Token(Token = "0x400038E")]
			[FieldOffset(Offset = "0x8")]
			private readonly JTokenType _tokenType;

			[Token(Token = "0x400038F")]
			[FieldOffset(Offset = "0xC")]
			private readonly IList<JsonSchemaModel> _schemas;

			[Token(Token = "0x4000390")]
			[FieldOffset(Offset = "0x10")]
			private readonly Dictionary<string, bool> _requiredProperties;

			[Token(Token = "0x4000391")]
			[FieldOffset(Offset = "0x14")]
			private string CurrentPropertyName__BackingField;

			[Token(Token = "0x4000392")]
			[FieldOffset(Offset = "0x18")]
			private int ArrayItemCount__BackingField;

			[Token(Token = "0x4000393")]
			[FieldOffset(Offset = "0x0")]
			private static Func<string, string> _003C_003Ef__am_0024cache5;

			[Token(Token = "0x4000394")]
			[FieldOffset(Offset = "0x4")]
			private static Func<string, bool> _003C_003Ef__am_0024cache6;

			[Token(Token = "0x4000395")]
			[FieldOffset(Offset = "0x8")]
			private static Func<KeyValuePair<string, JsonSchemaModel>, bool> _003C_003Ef__am_0024cache7;

			[Token(Token = "0x4000396")]
			[FieldOffset(Offset = "0xC")]
			private static Func<KeyValuePair<string, JsonSchemaModel>, string> _003C_003Ef__am_0024cache8;

			[Token(Token = "0x17000126")]
			public string CurrentPropertyName
			{
				[Token(Token = "0x600076F")]
				[Address(RVA = "0xF7B8B8", Offset = "0xF7B8B8", VA = "0xF7B8B8")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000770")]
				[Address(RVA = "0xF8290C", Offset = "0xF8290C", VA = "0xF8290C")]
				set
				{
				}
			}

			[Token(Token = "0x17000127")]
			public int ArrayItemCount
			{
				[Token(Token = "0x6000771")]
				[Address(RVA = "0xF7B8E8", Offset = "0xF7B8E8", VA = "0xF7B8E8")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6000772")]
				[Address(RVA = "0xF82448", Offset = "0xF82448", VA = "0xF82448")]
				set
				{
				}
			}

			[Token(Token = "0x17000128")]
			public IList<JsonSchemaModel> Schemas
			{
				[Token(Token = "0x6000773")]
				[Address(RVA = "0xF7A1CC", Offset = "0xF7A1CC", VA = "0xF7A1CC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000129")]
			public Dictionary<string, bool> RequiredProperties
			{
				[Token(Token = "0x6000774")]
				[Address(RVA = "0xF8211C", Offset = "0xF8211C", VA = "0xF8211C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700012A")]
			public JTokenType TokenType
			{
				[Token(Token = "0x6000775")]
				[Address(RVA = "0xF7B8B0", Offset = "0xF7B8B0", VA = "0xF7B8B0")]
				get
				{
					return default(JTokenType);
				}
			}

			[Token(Token = "0x600076E")]
			[Address(RVA = "0xF7EED8", Offset = "0xF7EED8", VA = "0xF7EED8")]
			public SchemaScope(JTokenType tokenType, IList<JsonSchemaModel> schemas)
			{
			}

			[Token(Token = "0x6000776")]
			[Address(RVA = "0xF82A88", Offset = "0xF82A88", VA = "0xF82A88")]
			private IEnumerable<string> GetRequiredProperties(JsonSchemaModel schema)
			{
				return null;
			}

			[Token(Token = "0x6000777")]
			[Address(RVA = "0xF82C98", Offset = "0xF82C98", VA = "0xF82C98")]
			private static string _003CSchemaScope_003Em__36(string p)
			{
				return null;
			}

			[Token(Token = "0x6000778")]
			[Address(RVA = "0xF82CA0", Offset = "0xF82CA0", VA = "0xF82CA0")]
			private static bool _003CSchemaScope_003Em__37(string p)
			{
				return default(bool);
			}

			[Token(Token = "0x6000779")]
			[Address(RVA = "0xF82CA8", Offset = "0xF82CA8", VA = "0xF82CA8")]
			private static bool _003CGetRequiredProperties_003Em__38(KeyValuePair<string, JsonSchemaModel> p)
			{
				return default(bool);
			}

			[Token(Token = "0x600077A")]
			[Address(RVA = "0xF82D50", Offset = "0xF82D50", VA = "0xF82D50")]
			private static string _003CGetRequiredProperties_003Em__39(KeyValuePair<string, JsonSchemaModel> p)
			{
				return null;
			}
		}

		[Token(Token = "0x4000386")]
		[FieldOffset(Offset = "0x2C")]
		private readonly JsonReader _reader;

		[Token(Token = "0x4000387")]
		[FieldOffset(Offset = "0x30")]
		private readonly Stack<SchemaScope> _stack;

		[Token(Token = "0x4000388")]
		[FieldOffset(Offset = "0x34")]
		private JsonSchema _schema;

		[Token(Token = "0x4000389")]
		[FieldOffset(Offset = "0x38")]
		private JsonSchemaModel _model;

		[Token(Token = "0x400038A")]
		[FieldOffset(Offset = "0x3C")]
		private SchemaScope _currentScope;

		[Token(Token = "0x400038B")]
		[FieldOffset(Offset = "0x40")]
		private ValidationEventHandler m_ValidationEventHandler;

		[Token(Token = "0x400038C")]
		[FieldOffset(Offset = "0x0")]
		private static Func<KeyValuePair<string, bool>, bool> _003C_003Ef__am_0024cache6;

		[Token(Token = "0x400038D")]
		[FieldOffset(Offset = "0x4")]
		private static Func<KeyValuePair<string, bool>, string> _003C_003Ef__am_0024cache7;

		[Token(Token = "0x1700011B")]
		private int Newtonsoft_002EJson_002EIJsonLineInfo_002ELineNumber
		{
			[Token(Token = "0x6000746")]
			[Address(RVA = "0xF79BF8", Offset = "0xF79BF8", VA = "0xF79BF8", Slot = "19")]
			get
			{
				return Newtonsoft_002EJson_002EIJsonLineInfo_002Eget_LineNumber();
			}
		}

		[Token(Token = "0x1700011C")]
		private int Newtonsoft_002EJson_002EIJsonLineInfo_002ELinePosition
		{
			[Token(Token = "0x6000747")]
			[Address(RVA = "0xF79D1C", Offset = "0xF79D1C", VA = "0xF79D1C", Slot = "20")]
			get
			{
				return Newtonsoft_002EJson_002EIJsonLineInfo_002Eget_LinePosition();
			}
		}

		[Token(Token = "0x1700011D")]
		public override object Value
		{
			[Token(Token = "0x6000748")]
			[Address(RVA = "0xF79E3C", Offset = "0xF79E3C", VA = "0xF79E3C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700011E")]
		public override int Depth
		{
			[Token(Token = "0x6000749")]
			[Address(RVA = "0xF79E94", Offset = "0xF79E94", VA = "0xF79E94", Slot = "10")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700011F")]
		public override char QuoteChar
		{
			[Token(Token = "0x600074A")]
			[Address(RVA = "0xF79EEC", Offset = "0xF79EEC", VA = "0xF79EEC", Slot = "5")]
			get
			{
				return default(char);
			}
			[Token(Token = "0x600074B")]
			[Address(RVA = "0xF79F44", Offset = "0xF79F44", VA = "0xF79F44", Slot = "6")]
			protected internal set
			{
			}
		}

		[Token(Token = "0x17000120")]
		public override JsonToken TokenType
		{
			[Token(Token = "0x600074C")]
			[Address(RVA = "0xF79F48", Offset = "0xF79F48", VA = "0xF79F48", Slot = "7")]
			get
			{
				return default(JsonToken);
			}
		}

		[Token(Token = "0x17000121")]
		public override Type ValueType
		{
			[Token(Token = "0x600074D")]
			[Address(RVA = "0xF79FA0", Offset = "0xF79FA0", VA = "0xF79FA0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000122")]
		private IEnumerable<JsonSchemaModel> CurrentSchemas
		{
			[Token(Token = "0x6000750")]
			[Address(RVA = "0xF7A1A8", Offset = "0xF7A1A8", VA = "0xF7A1A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000123")]
		private IEnumerable<JsonSchemaModel> CurrentMemberSchemas
		{
			[Token(Token = "0x6000751")]
			[Address(RVA = "0xF7A1D4", Offset = "0xF7A1D4", VA = "0xF7A1D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000124")]
		public JsonSchema Schema
		{
			[Token(Token = "0x6000754")]
			[Address(RVA = "0xF7C0A8", Offset = "0xF7C0A8", VA = "0xF7C0A8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000755")]
			[Address(RVA = "0xF7C0B0", Offset = "0xF7C0B0", VA = "0xF7C0B0")]
			set
			{
			}
		}

		[Token(Token = "0x17000125")]
		public JsonReader Reader
		{
			[Token(Token = "0x6000756")]
			[Address(RVA = "0xF7C1A0", Offset = "0xF7C1A0", VA = "0xF7C1A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000056")]
		public event ValidationEventHandler ValidationEventHandler
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x6000743")]
			[Address(RVA = "0xF797D0", Offset = "0xF797D0", VA = "0xF797D0")]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x6000744")]
			[Address(RVA = "0xF7995C", Offset = "0xF7995C", VA = "0xF7995C")]
			remove
			{
			}
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0xF79700", Offset = "0xF79700", VA = "0xF79700")]
		public JsonValidatingReader(JsonReader reader)
		{
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0xF79AE8", Offset = "0xF79AE8", VA = "0xF79AE8", Slot = "18")]
		private bool Newtonsoft_002EJson_002EIJsonLineInfo_002EHasLineInfo()
		{
			return default(bool);
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0xF79BF8", Offset = "0xF79BF8", VA = "0xF79BF8", Slot = "19")]
		private int Newtonsoft_002EJson_002EIJsonLineInfo_002Eget_LineNumber()
		{
			return default(int);
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0xF79D1C", Offset = "0xF79D1C", VA = "0xF79D1C", Slot = "20")]
		private int Newtonsoft_002EJson_002EIJsonLineInfo_002Eget_LinePosition()
		{
			return default(int);
		}

		[Token(Token = "0x600074E")]
		[Address(RVA = "0xF79FF8", Offset = "0xF79FF8", VA = "0xF79FF8")]
		private void Push(SchemaScope scope)
		{
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0xF7A09C", Offset = "0xF7A09C", VA = "0xF7A09C")]
		private SchemaScope Pop()
		{
			return null;
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0xF7B8F0", Offset = "0xF7B8F0", VA = "0xF7B8F0")]
		private void RaiseError(string message, JsonSchemaModel schema)
		{
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0xF7BE4C", Offset = "0xF7BE4C", VA = "0xF7BE4C")]
		private void OnValidationEvent(JsonSchemaException exception)
		{
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0xF7C1A8", Offset = "0xF7C1A8", VA = "0xF7C1A8")]
		private void ValidateInEnumAndNotDisallowed(JsonSchemaModel schema)
		{
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0xF7C810", Offset = "0xF7C810", VA = "0xF7C810")]
		private JsonSchemaType? GetCurrentNodeSchemaType()
		{
			return null;
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0xF7CCA0", Offset = "0xF7CCA0", VA = "0xF7CCA0", Slot = "12")]
		public override byte[] ReadAsBytes()
		{
			return null;
		}

		[Token(Token = "0x600075A")]
		[Address(RVA = "0xF7E4FC", Offset = "0xF7E4FC", VA = "0xF7E4FC", Slot = "13")]
		public override decimal? ReadAsDecimal()
		{
			return null;
		}

		[Token(Token = "0x600075B")]
		[Address(RVA = "0xF7E5A0", Offset = "0xF7E5A0", VA = "0xF7E5A0", Slot = "14")]
		public override DateTimeOffset? ReadAsDateTimeOffset()
		{
			return null;
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0xF7E654", Offset = "0xF7E654", VA = "0xF7E654", Slot = "11")]
		public override bool Read()
		{
			return default(bool);
		}

		[Token(Token = "0x600075D")]
		[Address(RVA = "0xF7CD04", Offset = "0xF7CD04", VA = "0xF7CD04")]
		private void ValidateCurrentToken()
		{
		}

		[Token(Token = "0x600075E")]
		[Address(RVA = "0xF81830", Offset = "0xF81830", VA = "0xF81830")]
		private void ValidateEndObject(JsonSchemaModel schema)
		{
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0xF81C18", Offset = "0xF81C18", VA = "0xF81C18")]
		private void ValidateEndArray(JsonSchemaModel schema)
		{
		}

		[Token(Token = "0x6000760")]
		[Address(RVA = "0xF817EC", Offset = "0xF817EC", VA = "0xF817EC")]
		private void ValidateNull(JsonSchemaModel schema)
		{
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0xF817A8", Offset = "0xF817A8", VA = "0xF817A8")]
		private void ValidateBoolean(JsonSchemaModel schema)
		{
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0xF80DE4", Offset = "0xF80DE4", VA = "0xF80DE4")]
		private void ValidateString(JsonSchemaModel schema)
		{
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0xF7F440", Offset = "0xF7F440", VA = "0xF7F440")]
		private void ValidateInteger(JsonSchemaModel schema)
		{
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0xF7E8B0", Offset = "0xF7E8B0", VA = "0xF7E8B0")]
		private void ProcessValue()
		{
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0xF80118", Offset = "0xF80118", VA = "0xF80118")]
		private void ValidateFloat(JsonSchemaModel schema)
		{
		}

		[Token(Token = "0x6000766")]
		[Address(RVA = "0xF82420", Offset = "0xF82420", VA = "0xF82420")]
		private static bool IsZero(double value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0xF7F140", Offset = "0xF7F140", VA = "0xF7F140")]
		private void ValidatePropertyName(JsonSchemaModel schema)
		{
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0xF82450", Offset = "0xF82450", VA = "0xF82450")]
		private bool IsPropertyDefinied(JsonSchemaModel schema, string propertyName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0xF82914", Offset = "0xF82914", VA = "0xF82914")]
		private bool ValidateArray(JsonSchemaModel schema)
		{
			return default(bool);
		}

		[Token(Token = "0x600076A")]
		[Address(RVA = "0xF8293C", Offset = "0xF8293C", VA = "0xF8293C")]
		private bool ValidateObject(JsonSchemaModel schema)
		{
			return default(bool);
		}

		[Token(Token = "0x600076B")]
		[Address(RVA = "0xF8214C", Offset = "0xF8214C", VA = "0xF8214C")]
		private bool TestType(JsonSchemaModel currentSchema, JsonSchemaType currentType)
		{
			return default(bool);
		}

		[Token(Token = "0x600076C")]
		[Address(RVA = "0xF8296C", Offset = "0xF8296C", VA = "0xF8296C")]
		private static bool _003CValidateEndObject_003Em__34(KeyValuePair<string, bool> kv)
		{
			return default(bool);
		}

		[Token(Token = "0x600076D")]
		[Address(RVA = "0xF829FC", Offset = "0xF829FC", VA = "0xF829FC")]
		private static string _003CValidateEndObject_003Em__35(KeyValuePair<string, bool> kv)
		{
			return null;
		}
	}
}
