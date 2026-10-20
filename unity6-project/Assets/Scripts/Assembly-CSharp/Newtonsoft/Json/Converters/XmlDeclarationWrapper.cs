using System.Xml;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x20000B6")]
	internal class XmlDeclarationWrapper : XmlNodeWrapper, IXmlDeclaration, IXmlNode
	{
		[Token(Token = "0x40002ED")]
		[FieldOffset(Offset = "0xC")]
		private XmlDeclaration _declaration;

		[Token(Token = "0x170000BD")]
		public string Version
		{
			[Token(Token = "0x60005AF")]
			[Address(RVA = "0x138D984", Offset = "0x138D984", VA = "0x138D984", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BE")]
		public string Encoding
		{
			[Token(Token = "0x60005B0")]
			[Address(RVA = "0x138D9B0", Offset = "0x138D9B0", VA = "0x138D9B0", Slot = "15")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005B1")]
			[Address(RVA = "0x138D9DC", Offset = "0x138D9DC", VA = "0x138D9DC", Slot = "16")]
			set
			{
			}
		}

		[Token(Token = "0x170000BF")]
		public string Standalone
		{
			[Token(Token = "0x60005B2")]
			[Address(RVA = "0x138DA08", Offset = "0x138DA08", VA = "0x138DA08", Slot = "17")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005B3")]
			[Address(RVA = "0x138DA34", Offset = "0x138DA34", VA = "0x138DA34", Slot = "18")]
			set
			{
			}
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x138D940", Offset = "0x138D940", VA = "0x138D940")]
		public XmlDeclarationWrapper(XmlDeclaration declaration)
		{
		}
	}
}
