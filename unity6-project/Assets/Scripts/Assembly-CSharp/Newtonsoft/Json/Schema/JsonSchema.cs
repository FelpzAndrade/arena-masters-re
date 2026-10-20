using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

namespace Newtonsoft.Json.Schema
{
	[Token(Token = "0x2000104")]
	public class JsonSchema
	{
		[Token(Token = "0x4000438")]
		[FieldOffset(Offset = "0x8")]
		private readonly string _internalId;

		[Token(Token = "0x4000439")]
		[FieldOffset(Offset = "0xC")]
		private string Id__BackingField;

		[Token(Token = "0x400043A")]
		[FieldOffset(Offset = "0x10")]
		private string Title__BackingField;

		[Token(Token = "0x400043B")]
		[FieldOffset(Offset = "0x14")]
		private bool? Required__BackingField;

		[Token(Token = "0x400043C")]
		[FieldOffset(Offset = "0x16")]
		private bool? ReadOnly__BackingField;

		[Token(Token = "0x400043D")]
		[FieldOffset(Offset = "0x18")]
		private bool? Hidden__BackingField;

		[Token(Token = "0x400043E")]
		[FieldOffset(Offset = "0x1A")]
		private bool? Transient__BackingField;

		[Token(Token = "0x400043F")]
		[FieldOffset(Offset = "0x1C")]
		private string Description__BackingField;

		[Token(Token = "0x4000440")]
		[FieldOffset(Offset = "0x20")]
		private JsonSchemaType? Type__BackingField;

		[Token(Token = "0x4000441")]
		[FieldOffset(Offset = "0x28")]
		private string Pattern__BackingField;

		[Token(Token = "0x4000442")]
		[FieldOffset(Offset = "0x2C")]
		private int? MinimumLength__BackingField;

		[Token(Token = "0x4000443")]
		[FieldOffset(Offset = "0x34")]
		private int? MaximumLength__BackingField;

		[Token(Token = "0x4000444")]
		[FieldOffset(Offset = "0x40")]
		private double? DivisibleBy__BackingField;

		[Token(Token = "0x4000445")]
		[FieldOffset(Offset = "0x50")]
		private double? Minimum__BackingField;

		[Token(Token = "0x4000446")]
		[FieldOffset(Offset = "0x60")]
		private double? Maximum__BackingField;

		[Token(Token = "0x4000447")]
		[FieldOffset(Offset = "0x70")]
		private bool? ExclusiveMinimum__BackingField;

		[Token(Token = "0x4000448")]
		[FieldOffset(Offset = "0x72")]
		private bool? ExclusiveMaximum__BackingField;

		[Token(Token = "0x4000449")]
		[FieldOffset(Offset = "0x74")]
		private int? MinimumItems__BackingField;

		[Token(Token = "0x400044A")]
		[FieldOffset(Offset = "0x7C")]
		private int? MaximumItems__BackingField;

		[Token(Token = "0x400044B")]
		[FieldOffset(Offset = "0x84")]
		private IList<JsonSchema> Items__BackingField;

		[Token(Token = "0x400044C")]
		[FieldOffset(Offset = "0x88")]
		private IDictionary<string, JsonSchema> Properties__BackingField;

		[Token(Token = "0x400044D")]
		[FieldOffset(Offset = "0x8C")]
		private JsonSchema AdditionalProperties__BackingField;

		[Token(Token = "0x400044E")]
		[FieldOffset(Offset = "0x90")]
		private IDictionary<string, JsonSchema> PatternProperties__BackingField;

		[Token(Token = "0x400044F")]
		[FieldOffset(Offset = "0x94")]
		private bool AllowAdditionalProperties__BackingField;

		[Token(Token = "0x4000450")]
		[FieldOffset(Offset = "0x98")]
		private string Requires__BackingField;

		[Token(Token = "0x4000451")]
		[FieldOffset(Offset = "0x9C")]
		private IList<string> Identity__BackingField;

		[Token(Token = "0x4000452")]
		[FieldOffset(Offset = "0xA0")]
		private IList<JToken> Enum__BackingField;

		[Token(Token = "0x4000453")]
		[FieldOffset(Offset = "0xA4")]
		private IDictionary<JToken, string> Options__BackingField;

		[Token(Token = "0x4000454")]
		[FieldOffset(Offset = "0xA8")]
		private JsonSchemaType? Disallow__BackingField;

		[Token(Token = "0x4000455")]
		[FieldOffset(Offset = "0xB0")]
		private JToken Default__BackingField;

		[Token(Token = "0x4000456")]
		[FieldOffset(Offset = "0xB4")]
		private JsonSchema Extends__BackingField;

		[Token(Token = "0x4000457")]
		[FieldOffset(Offset = "0xB8")]
		private string Format__BackingField;

		[Token(Token = "0x17000180")]
		public string Id
		{
			[Token(Token = "0x60009E5")]
			[Address(RVA = "0xFA71F0", Offset = "0xFA71F0", VA = "0xFA71F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009E6")]
			[Address(RVA = "0xFA71F8", Offset = "0xFA71F8", VA = "0xFA71F8")]
			set
			{
			}
		}

		[Token(Token = "0x17000181")]
		public string Title
		{
			[Token(Token = "0x60009E7")]
			[Address(RVA = "0xFA7200", Offset = "0xFA7200", VA = "0xFA7200")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009E8")]
			[Address(RVA = "0xFA7208", Offset = "0xFA7208", VA = "0xFA7208")]
			set
			{
			}
		}

		[Token(Token = "0x17000182")]
		public bool? Required
		{
			[Token(Token = "0x60009E9")]
			[Address(RVA = "0xFA7210", Offset = "0xFA7210", VA = "0xFA7210")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009EA")]
			[Address(RVA = "0xFA7218", Offset = "0xFA7218", VA = "0xFA7218")]
			set
			{
			}
		}

		[Token(Token = "0x17000183")]
		public bool? ReadOnly
		{
			[Token(Token = "0x60009EB")]
			[Address(RVA = "0xFA7220", Offset = "0xFA7220", VA = "0xFA7220")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009EC")]
			[Address(RVA = "0xFA7228", Offset = "0xFA7228", VA = "0xFA7228")]
			set
			{
			}
		}

		[Token(Token = "0x17000184")]
		public bool? Hidden
		{
			[Token(Token = "0x60009ED")]
			[Address(RVA = "0xFA7230", Offset = "0xFA7230", VA = "0xFA7230")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009EE")]
			[Address(RVA = "0xFA7238", Offset = "0xFA7238", VA = "0xFA7238")]
			set
			{
			}
		}

		[Token(Token = "0x17000185")]
		public bool? Transient
		{
			[Token(Token = "0x60009EF")]
			[Address(RVA = "0xFA7240", Offset = "0xFA7240", VA = "0xFA7240")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009F0")]
			[Address(RVA = "0xFA7248", Offset = "0xFA7248", VA = "0xFA7248")]
			set
			{
			}
		}

		[Token(Token = "0x17000186")]
		public string Description
		{
			[Token(Token = "0x60009F1")]
			[Address(RVA = "0xFA7250", Offset = "0xFA7250", VA = "0xFA7250")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009F2")]
			[Address(RVA = "0xFA7258", Offset = "0xFA7258", VA = "0xFA7258")]
			set
			{
			}
		}

		[Token(Token = "0x17000187")]
		public JsonSchemaType? Type
		{
			[Token(Token = "0x60009F3")]
			[Address(RVA = "0xFA7260", Offset = "0xFA7260", VA = "0xFA7260")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009F4")]
			[Address(RVA = "0xFA7274", Offset = "0xFA7274", VA = "0xFA7274")]
			set
			{
			}
		}

		[Token(Token = "0x17000188")]
		public string Pattern
		{
			[Token(Token = "0x60009F5")]
			[Address(RVA = "0xFA7280", Offset = "0xFA7280", VA = "0xFA7280")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009F6")]
			[Address(RVA = "0xFA7288", Offset = "0xFA7288", VA = "0xFA7288")]
			set
			{
			}
		}

		[Token(Token = "0x17000189")]
		public int? MinimumLength
		{
			[Token(Token = "0x60009F7")]
			[Address(RVA = "0xFA7290", Offset = "0xFA7290", VA = "0xFA7290")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009F8")]
			[Address(RVA = "0xFA72A4", Offset = "0xFA72A4", VA = "0xFA72A4")]
			set
			{
			}
		}

		[Token(Token = "0x1700018A")]
		public int? MaximumLength
		{
			[Token(Token = "0x60009F9")]
			[Address(RVA = "0xFA72B0", Offset = "0xFA72B0", VA = "0xFA72B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009FA")]
			[Address(RVA = "0xFA72C4", Offset = "0xFA72C4", VA = "0xFA72C4")]
			set
			{
			}
		}

		[Token(Token = "0x1700018B")]
		public double? DivisibleBy
		{
			[Token(Token = "0x60009FB")]
			[Address(RVA = "0xFA72D0", Offset = "0xFA72D0", VA = "0xFA72D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009FC")]
			[Address(RVA = "0xFA72E0", Offset = "0xFA72E0", VA = "0xFA72E0")]
			set
			{
			}
		}

		[Token(Token = "0x1700018C")]
		public double? Minimum
		{
			[Token(Token = "0x60009FD")]
			[Address(RVA = "0xFA72F8", Offset = "0xFA72F8", VA = "0xFA72F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009FE")]
			[Address(RVA = "0xFA7308", Offset = "0xFA7308", VA = "0xFA7308")]
			set
			{
			}
		}

		[Token(Token = "0x1700018D")]
		public double? Maximum
		{
			[Token(Token = "0x60009FF")]
			[Address(RVA = "0xFA7320", Offset = "0xFA7320", VA = "0xFA7320")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A00")]
			[Address(RVA = "0xFA7330", Offset = "0xFA7330", VA = "0xFA7330")]
			set
			{
			}
		}

		[Token(Token = "0x1700018E")]
		public bool? ExclusiveMinimum
		{
			[Token(Token = "0x6000A01")]
			[Address(RVA = "0xFA7348", Offset = "0xFA7348", VA = "0xFA7348")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A02")]
			[Address(RVA = "0xFA7350", Offset = "0xFA7350", VA = "0xFA7350")]
			set
			{
			}
		}

		[Token(Token = "0x1700018F")]
		public bool? ExclusiveMaximum
		{
			[Token(Token = "0x6000A03")]
			[Address(RVA = "0xFA7358", Offset = "0xFA7358", VA = "0xFA7358")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A04")]
			[Address(RVA = "0xFA7360", Offset = "0xFA7360", VA = "0xFA7360")]
			set
			{
			}
		}

		[Token(Token = "0x17000190")]
		public int? MinimumItems
		{
			[Token(Token = "0x6000A05")]
			[Address(RVA = "0xFA7368", Offset = "0xFA7368", VA = "0xFA7368")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A06")]
			[Address(RVA = "0xFA737C", Offset = "0xFA737C", VA = "0xFA737C")]
			set
			{
			}
		}

		[Token(Token = "0x17000191")]
		public int? MaximumItems
		{
			[Token(Token = "0x6000A07")]
			[Address(RVA = "0xFA7388", Offset = "0xFA7388", VA = "0xFA7388")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A08")]
			[Address(RVA = "0xFA739C", Offset = "0xFA739C", VA = "0xFA739C")]
			set
			{
			}
		}

		[Token(Token = "0x17000192")]
		public IList<JsonSchema> Items
		{
			[Token(Token = "0x6000A09")]
			[Address(RVA = "0xFA73A8", Offset = "0xFA73A8", VA = "0xFA73A8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A0A")]
			[Address(RVA = "0xFA73B0", Offset = "0xFA73B0", VA = "0xFA73B0")]
			set
			{
			}
		}

		[Token(Token = "0x17000193")]
		public IDictionary<string, JsonSchema> Properties
		{
			[Token(Token = "0x6000A0B")]
			[Address(RVA = "0xFA73B8", Offset = "0xFA73B8", VA = "0xFA73B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A0C")]
			[Address(RVA = "0xFA73C0", Offset = "0xFA73C0", VA = "0xFA73C0")]
			set
			{
			}
		}

		[Token(Token = "0x17000194")]
		public JsonSchema AdditionalProperties
		{
			[Token(Token = "0x6000A0D")]
			[Address(RVA = "0xFA73C8", Offset = "0xFA73C8", VA = "0xFA73C8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A0E")]
			[Address(RVA = "0xFA73D0", Offset = "0xFA73D0", VA = "0xFA73D0")]
			set
			{
			}
		}

		[Token(Token = "0x17000195")]
		public IDictionary<string, JsonSchema> PatternProperties
		{
			[Token(Token = "0x6000A0F")]
			[Address(RVA = "0xFA73D8", Offset = "0xFA73D8", VA = "0xFA73D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A10")]
			[Address(RVA = "0xFA73E0", Offset = "0xFA73E0", VA = "0xFA73E0")]
			set
			{
			}
		}

		[Token(Token = "0x17000196")]
		public bool AllowAdditionalProperties
		{
			[Token(Token = "0x6000A11")]
			[Address(RVA = "0xFA73E8", Offset = "0xFA73E8", VA = "0xFA73E8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A12")]
			[Address(RVA = "0xFA71E8", Offset = "0xFA71E8", VA = "0xFA71E8")]
			set
			{
			}
		}

		[Token(Token = "0x17000197")]
		public string Requires
		{
			[Token(Token = "0x6000A13")]
			[Address(RVA = "0xFA73F0", Offset = "0xFA73F0", VA = "0xFA73F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A14")]
			[Address(RVA = "0xFA73F8", Offset = "0xFA73F8", VA = "0xFA73F8")]
			set
			{
			}
		}

		[Token(Token = "0x17000198")]
		public IList<string> Identity
		{
			[Token(Token = "0x6000A15")]
			[Address(RVA = "0xFA7400", Offset = "0xFA7400", VA = "0xFA7400")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A16")]
			[Address(RVA = "0xFA7408", Offset = "0xFA7408", VA = "0xFA7408")]
			set
			{
			}
		}

		[Token(Token = "0x17000199")]
		public IList<JToken> Enum
		{
			[Token(Token = "0x6000A17")]
			[Address(RVA = "0xFA7410", Offset = "0xFA7410", VA = "0xFA7410")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A18")]
			[Address(RVA = "0xFA7418", Offset = "0xFA7418", VA = "0xFA7418")]
			set
			{
			}
		}

		[Token(Token = "0x1700019A")]
		public IDictionary<JToken, string> Options
		{
			[Token(Token = "0x6000A19")]
			[Address(RVA = "0xFA7420", Offset = "0xFA7420", VA = "0xFA7420")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A1A")]
			[Address(RVA = "0xFA7428", Offset = "0xFA7428", VA = "0xFA7428")]
			set
			{
			}
		}

		[Token(Token = "0x1700019B")]
		public JsonSchemaType? Disallow
		{
			[Token(Token = "0x6000A1B")]
			[Address(RVA = "0xFA7430", Offset = "0xFA7430", VA = "0xFA7430")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A1C")]
			[Address(RVA = "0xFA7444", Offset = "0xFA7444", VA = "0xFA7444")]
			set
			{
			}
		}

		[Token(Token = "0x1700019C")]
		public JToken Default
		{
			[Token(Token = "0x6000A1D")]
			[Address(RVA = "0xFA7450", Offset = "0xFA7450", VA = "0xFA7450")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A1E")]
			[Address(RVA = "0xFA7458", Offset = "0xFA7458", VA = "0xFA7458")]
			set
			{
			}
		}

		[Token(Token = "0x1700019D")]
		public JsonSchema Extends
		{
			[Token(Token = "0x6000A1F")]
			[Address(RVA = "0xFA7460", Offset = "0xFA7460", VA = "0xFA7460")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A20")]
			[Address(RVA = "0xFA7468", Offset = "0xFA7468", VA = "0xFA7468")]
			set
			{
			}
		}

		[Token(Token = "0x1700019E")]
		public string Format
		{
			[Token(Token = "0x6000A21")]
			[Address(RVA = "0xFA7470", Offset = "0xFA7470", VA = "0xFA7470")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A22")]
			[Address(RVA = "0xFA7478", Offset = "0xFA7478", VA = "0xFA7478")]
			set
			{
			}
		}

		[Token(Token = "0x1700019F")]
		internal string InternalId
		{
			[Token(Token = "0x6000A23")]
			[Address(RVA = "0xFA7480", Offset = "0xFA7480", VA = "0xFA7480")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60009E4")]
		[Address(RVA = "0xFA70E0", Offset = "0xFA70E0", VA = "0xFA70E0")]
		public JsonSchema()
		{
		}

		[Token(Token = "0x6000A24")]
		[Address(RVA = "0xFA7488", Offset = "0xFA7488", VA = "0xFA7488")]
		public static JsonSchema Read(JsonReader reader)
		{
			return null;
		}

		[Token(Token = "0x6000A25")]
		[Address(RVA = "0xFA75C8", Offset = "0xFA75C8", VA = "0xFA75C8")]
		public static JsonSchema Read(JsonReader reader, JsonSchemaResolver resolver)
		{
			return null;
		}

		[Token(Token = "0x6000A26")]
		[Address(RVA = "0xFA780C", Offset = "0xFA780C", VA = "0xFA780C")]
		public static JsonSchema Parse(string json)
		{
			return null;
		}

		[Token(Token = "0x6000A27")]
		[Address(RVA = "0xFA78A0", Offset = "0xFA78A0", VA = "0xFA78A0")]
		public static JsonSchema Parse(string json, JsonSchemaResolver resolver)
		{
			return null;
		}

		[Token(Token = "0x6000A28")]
		[Address(RVA = "0xFA7980", Offset = "0xFA7980", VA = "0xFA7980")]
		public void WriteTo(JsonWriter writer)
		{
		}

		[Token(Token = "0x6000A29")]
		[Address(RVA = "0xFA7A1C", Offset = "0xFA7A1C", VA = "0xFA7A1C")]
		public void WriteTo(JsonWriter writer, JsonSchemaResolver resolver)
		{
		}

		[Token(Token = "0x6000A2A")]
		[Address(RVA = "0xFA902C", Offset = "0xFA902C", VA = "0xFA902C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
