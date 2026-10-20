using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x20000B9")]
	internal interface IXmlDeclaration : IXmlNode
	{
		[Token(Token = "0x170000CB")]
		string Version
		{
			[Token(Token = "0x60005D0")]
			get;
		}

		[Token(Token = "0x170000CC")]
		string Encoding
		{
			[Token(Token = "0x60005D1")]
			get;
			[Token(Token = "0x60005D2")]
			set;
		}

		[Token(Token = "0x170000CD")]
		string Standalone
		{
			[Token(Token = "0x60005D3")]
			get;
			[Token(Token = "0x60005D4")]
			set;
		}
	}
}
