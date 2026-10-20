using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x20000B8")]
	internal interface IXmlDocument : IXmlNode
	{
		[Token(Token = "0x170000CA")]
		IXmlElement DocumentElement
		{
			[Token(Token = "0x60005CF")]
			get;
		}

		[Token(Token = "0x60005C4")]
		IXmlNode CreateComment(string text);

		[Token(Token = "0x60005C5")]
		IXmlNode CreateTextNode(string text);

		[Token(Token = "0x60005C6")]
		IXmlNode CreateCDataSection(string data);

		[Token(Token = "0x60005C7")]
		IXmlNode CreateWhitespace(string text);

		[Token(Token = "0x60005C8")]
		IXmlNode CreateSignificantWhitespace(string text);

		[Token(Token = "0x60005C9")]
		IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone);

		[Token(Token = "0x60005CA")]
		IXmlNode CreateProcessingInstruction(string target, string data);

		[Token(Token = "0x60005CB")]
		IXmlElement CreateElement(string elementName);

		[Token(Token = "0x60005CC")]
		IXmlElement CreateElement(string qualifiedName, string namespaceURI);

		[Token(Token = "0x60005CD")]
		IXmlNode CreateAttribute(string name, string value);

		[Token(Token = "0x60005CE")]
		IXmlNode CreateAttribute(string qualifiedName, string namespaceURI, string value);
	}
}
