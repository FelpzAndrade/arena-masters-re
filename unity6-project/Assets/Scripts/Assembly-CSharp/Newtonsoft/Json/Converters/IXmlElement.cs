using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x20000BA")]
	internal interface IXmlElement : IXmlNode
	{
		[Token(Token = "0x60005D5")]
		void SetAttributeNode(IXmlNode attribute);

		[Token(Token = "0x60005D6")]
		string GetPrefixOfNamespace(string namespaceURI);
	}
}
