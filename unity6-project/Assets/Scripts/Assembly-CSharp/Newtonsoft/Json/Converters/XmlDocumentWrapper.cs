using System.Xml;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x20000B4")]
	internal class XmlDocumentWrapper : XmlNodeWrapper, IXmlDocument, IXmlNode
	{
		[Token(Token = "0x40002EB")]
		[FieldOffset(Offset = "0xC")]
		private XmlDocument _document;

		[Token(Token = "0x170000BC")]
		public IXmlElement DocumentElement
		{
			[Token(Token = "0x60005AA")]
			[Address(RVA = "0x138E4AC", Offset = "0x138E4AC", VA = "0x138E4AC", Slot = "25")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x138DA60", Offset = "0x138DA60", VA = "0x138DA60")]
		public XmlDocumentWrapper(XmlDocument document)
		{
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x138DA84", Offset = "0x138DA84", VA = "0x138DA84", Slot = "14")]
		public IXmlNode CreateComment(string data)
		{
			return null;
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x138DB68", Offset = "0x138DB68", VA = "0x138DB68", Slot = "15")]
		public IXmlNode CreateTextNode(string text)
		{
			return null;
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x138DC4C", Offset = "0x138DC4C", VA = "0x138DC4C", Slot = "16")]
		public IXmlNode CreateCDataSection(string data)
		{
			return null;
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x138DD30", Offset = "0x138DD30", VA = "0x138DD30", Slot = "17")]
		public IXmlNode CreateWhitespace(string text)
		{
			return null;
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x138DE14", Offset = "0x138DE14", VA = "0x138DE14", Slot = "18")]
		public IXmlNode CreateSignificantWhitespace(string text)
		{
			return null;
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x138DEF8", Offset = "0x138DEF8", VA = "0x138DEF8", Slot = "19")]
		public IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone)
		{
			return null;
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x138DFF4", Offset = "0x138DFF4", VA = "0x138DFF4", Slot = "20")]
		public IXmlNode CreateProcessingInstruction(string target, string data)
		{
			return null;
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x138E0E0", Offset = "0x138E0E0", VA = "0x138E0E0", Slot = "21")]
		public IXmlElement CreateElement(string elementName)
		{
			return null;
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x138E1C8", Offset = "0x138E1C8", VA = "0x138E1C8", Slot = "22")]
		public IXmlElement CreateElement(string qualifiedName, string namespaceURI)
		{
			return null;
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x138E294", Offset = "0x138E294", VA = "0x138E294", Slot = "23")]
		public IXmlNode CreateAttribute(string name, string value)
		{
			return null;
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x138E3CC", Offset = "0x138E3CC", VA = "0x138E3CC", Slot = "24")]
		public IXmlNode CreateAttribute(string qualifiedName, string namespaceURI, string value)
		{
			return null;
		}
	}
}
