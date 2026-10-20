using System.Collections.Generic;
using System.Xml;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x20000BB")]
	internal interface IXmlNode
	{
		[Token(Token = "0x170000CE")]
		XmlNodeType NodeType
		{
			[Token(Token = "0x60005D7")]
			get;
		}

		[Token(Token = "0x170000CF")]
		string LocalName
		{
			[Token(Token = "0x60005D8")]
			get;
		}

		[Token(Token = "0x170000D0")]
		IList<IXmlNode> ChildNodes
		{
			[Token(Token = "0x60005D9")]
			get;
		}

		[Token(Token = "0x170000D1")]
		IList<IXmlNode> Attributes
		{
			[Token(Token = "0x60005DA")]
			get;
		}

		[Token(Token = "0x170000D2")]
		IXmlNode ParentNode
		{
			[Token(Token = "0x60005DB")]
			get;
		}

		[Token(Token = "0x170000D3")]
		string Value
		{
			[Token(Token = "0x60005DC")]
			get;
			[Token(Token = "0x60005DD")]
			set;
		}

		[Token(Token = "0x170000D4")]
		string NamespaceURI
		{
			[Token(Token = "0x60005DF")]
			get;
		}

		[Token(Token = "0x170000D5")]
		object WrappedNode
		{
			[Token(Token = "0x60005E0")]
			get;
		}

		[Token(Token = "0x60005DE")]
		IXmlNode AppendChild(IXmlNode newChild);
	}
}
