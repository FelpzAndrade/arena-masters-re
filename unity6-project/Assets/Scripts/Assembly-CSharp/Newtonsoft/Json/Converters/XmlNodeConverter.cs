using System;
using System.Collections.Generic;
using System.Xml;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x20000BC")]
	public class XmlNodeConverter : JsonConverter
	{
		[Token(Token = "0x20000BD")]
		private sealed class _003CSerializeNode_003Ec__AnonStoreyC3
		{
			[Token(Token = "0x40002FD")]
			[FieldOffset(Offset = "0x8")]
			internal IXmlNode node;

			[Token(Token = "0x60005FE")]
			[Address(RVA = "0x1392E08", Offset = "0x1392E08", VA = "0x1392E08")]
			public _003CSerializeNode_003Ec__AnonStoreyC3()
			{
			}

			[Token(Token = "0x60005FF")]
			[Address(RVA = "0x1397880", Offset = "0x1397880", VA = "0x1397880")]
			internal bool _003C_003Em__30(IXmlNode n)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000BE")]
		private sealed class _003CReadArrayElements_003Ec__AnonStoreyC4
		{
			[Token(Token = "0x40002FE")]
			[FieldOffset(Offset = "0x8")]
			internal string propertyName;

			[Token(Token = "0x6000600")]
			[Address(RVA = "0x1396EA8", Offset = "0x1396EA8", VA = "0x1396EA8")]
			public _003CReadArrayElements_003Ec__AnonStoreyC4()
			{
			}

			[Token(Token = "0x6000601")]
			[Address(RVA = "0x1397728", Offset = "0x1397728", VA = "0x1397728")]
			internal bool _003C_003Em__31(IXmlElement n)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000BF")]
		private sealed class _003CDeserializeNode_003Ec__AnonStoreyC5
		{
			[Token(Token = "0x40002FF")]
			[FieldOffset(Offset = "0x8")]
			internal string propertyName;

			[Token(Token = "0x6000602")]
			[Address(RVA = "0x1397200", Offset = "0x1397200", VA = "0x1397200")]
			public _003CDeserializeNode_003Ec__AnonStoreyC5()
			{
			}

			[Token(Token = "0x6000603")]
			[Address(RVA = "0x13975D0", Offset = "0x13975D0", VA = "0x13975D0")]
			internal bool _003C_003Em__32(IXmlElement n)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40002EF")]
		private const string TextName = "#text";

		[Token(Token = "0x40002F0")]
		private const string CommentName = "#comment";

		[Token(Token = "0x40002F1")]
		private const string CDataName = "#cdata-section";

		[Token(Token = "0x40002F2")]
		private const string WhitespaceName = "#whitespace";

		[Token(Token = "0x40002F3")]
		private const string SignificantWhitespaceName = "#significant-whitespace";

		[Token(Token = "0x40002F4")]
		private const string DeclarationName = "?xml";

		[Token(Token = "0x40002F5")]
		private const string JsonNamespaceUri = "http://james.newtonking.com/projects/json";

		[Token(Token = "0x40002F6")]
		[FieldOffset(Offset = "0x8")]
		private string DeserializeRootElementName__BackingField;

		[Token(Token = "0x40002F7")]
		[FieldOffset(Offset = "0xC")]
		private bool WriteArrayAttribute__BackingField;

		[Token(Token = "0x40002F8")]
		[FieldOffset(Offset = "0xD")]
		private bool OmitRootObject__BackingField;

		[Token(Token = "0x40002F9")]
		[FieldOffset(Offset = "0x0")]
		private static Func<IXmlNode, bool> _003C_003Ef__am_0024cache3;

		[Token(Token = "0x40002FA")]
		[FieldOffset(Offset = "0x4")]
		private static Dictionary<string, int> _003C_003Ef__switch_0024map0;

		[Token(Token = "0x40002FB")]
		[FieldOffset(Offset = "0x8")]
		private static Dictionary<string, int> _003C_003Ef__switch_0024map1;

		[Token(Token = "0x40002FC")]
		[FieldOffset(Offset = "0xC")]
		private static Func<IXmlNode, bool> _003C_003Ef__am_0024cache6;

		[Token(Token = "0x170000D6")]
		public string DeserializeRootElementName
		{
			[Token(Token = "0x60005E2")]
			[Address(RVA = "0x138E6FC", Offset = "0x138E6FC", VA = "0x138E6FC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005E3")]
			[Address(RVA = "0x138E704", Offset = "0x138E704", VA = "0x138E704")]
			set
			{
			}
		}

		[Token(Token = "0x170000D7")]
		public bool WriteArrayAttribute
		{
			[Token(Token = "0x60005E4")]
			[Address(RVA = "0x138E70C", Offset = "0x138E70C", VA = "0x138E70C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005E5")]
			[Address(RVA = "0x138E714", Offset = "0x138E714", VA = "0x138E714")]
			set
			{
			}
		}

		[Token(Token = "0x170000D8")]
		public bool OmitRootObject
		{
			[Token(Token = "0x60005E6")]
			[Address(RVA = "0x138E71C", Offset = "0x138E71C", VA = "0x138E71C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005E7")]
			[Address(RVA = "0x138E724", Offset = "0x138E724", VA = "0x138E724")]
			set
			{
			}
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x138E6F4", Offset = "0x138E6F4", VA = "0x138E6F4")]
		public XmlNodeConverter()
		{
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x138E72C", Offset = "0x138E72C", VA = "0x138E72C", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x138E78C", Offset = "0x138E78C", VA = "0x138E78C")]
		private IXmlNode WrapXml(object value)
		{
			return null;
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x138E844", Offset = "0x138E844", VA = "0x138E844")]
		private void PushParentNamespaces(IXmlNode node, XmlNamespaceManager manager)
		{
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x1391768", Offset = "0x1391768", VA = "0x1391768")]
		private string ResolveFullName(IXmlNode node, XmlNamespaceManager manager)
		{
			return null;
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x1391C60", Offset = "0x1391C60", VA = "0x1391C60")]
		private string GetPropertyName(IXmlNode node, XmlNamespaceManager manager)
		{
			return null;
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x1392234", Offset = "0x1392234", VA = "0x1392234")]
		private bool IsArray(IXmlNode node)
		{
			return default(bool);
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x1392568", Offset = "0x1392568", VA = "0x1392568")]
		private void SerializeGroupedNodes(JsonWriter writer, IXmlNode node, XmlNamespaceManager manager, bool writePropertyName)
		{
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x138F394", Offset = "0x138F394", VA = "0x138F394")]
		private void SerializeNode(JsonWriter writer, IXmlNode node, XmlNamespaceManager manager, bool writePropertyName)
		{
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x1392F34", Offset = "0x1392F34", VA = "0x1392F34", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x1394C70", Offset = "0x1394C70", VA = "0x1394C70")]
		private void DeserializeValue(JsonReader reader, IXmlDocument document, XmlNamespaceManager manager, string propertyName, IXmlNode currentNode)
		{
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x139306C", Offset = "0x139306C", VA = "0x139306C")]
		private void ReadElement(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName, XmlNamespaceManager manager)
		{
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x1395E88", Offset = "0x1395E88", VA = "0x1395E88")]
		private void ReadArrayElements(JsonReader reader, IXmlDocument document, string propertyName, IXmlNode currentNode, XmlNamespaceManager manager)
		{
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x1396EB0", Offset = "0x1396EB0", VA = "0x1396EB0")]
		private void AddJsonArrayAttribute(IXmlElement element, IXmlDocument document)
		{
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x1396210", Offset = "0x1396210", VA = "0x1396210")]
		private Dictionary<string, string> ReadAttributeElements(JsonReader reader, XmlNamespaceManager manager)
		{
			return null;
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x139555C", Offset = "0x139555C", VA = "0x139555C")]
		private void CreateInstruction(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName)
		{
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x1396C68", Offset = "0x1396C68", VA = "0x1396C68")]
		private IXmlElement CreateElement(string elementName, IXmlDocument document, string elementPrefix, XmlNamespaceManager manager)
		{
			return null;
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x139421C", Offset = "0x139421C", VA = "0x139421C")]
		private void DeserializeNode(JsonReader reader, IXmlDocument document, XmlNamespaceManager manager, IXmlNode currentNode)
		{
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x1397098", Offset = "0x1397098", VA = "0x1397098")]
		private bool IsNamespaceAttribute(string attributeName, out string prefix)
		{
			prefix = default;
			return default(bool);
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x1392E10", Offset = "0x1392E10", VA = "0x1392E10")]
		private IEnumerable<IXmlNode> ValueAttributes(IEnumerable<IXmlNode> c)
		{
			return null;
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x1397208", Offset = "0x1397208", VA = "0x1397208", Slot = "6")]
		public override bool CanConvert(Type valueType)
		{
			return default(bool);
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x1397210", Offset = "0x1397210", VA = "0x1397210")]
		private static bool _003CIsArray_003Em__2F(IXmlNode a)
		{
			return default(bool);
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x139746C", Offset = "0x139746C", VA = "0x139746C")]
		private static bool _003CValueAttributes_003Em__33(IXmlNode a)
		{
			return default(bool);
		}
	}
}
