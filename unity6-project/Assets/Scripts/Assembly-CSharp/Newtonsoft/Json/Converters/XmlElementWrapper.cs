using System.Xml;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x20000B5")]
	internal class XmlElementWrapper : XmlNodeWrapper, IXmlElement, IXmlNode
	{
		[Token(Token = "0x40002EC")]
		[FieldOffset(Offset = "0xC")]
		private XmlElement _element;

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x138E1A4", Offset = "0x138E1A4", VA = "0x138E1A4")]
		public XmlElementWrapper(XmlElement element)
		{
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x138E588", Offset = "0x138E588", VA = "0x138E588", Slot = "14")]
		public void SetAttributeNode(IXmlNode attribute)
		{
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x138E694", Offset = "0x138E694", VA = "0x138E694", Slot = "15")]
		public string GetPrefixOfNamespace(string namespaceURI)
		{
			return null;
		}
	}
}
