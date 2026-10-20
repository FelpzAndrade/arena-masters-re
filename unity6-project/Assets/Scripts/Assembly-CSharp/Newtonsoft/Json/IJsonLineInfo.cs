using Il2CppDummyDll;

namespace Newtonsoft.Json
{
	[Token(Token = "0x20000C1")]
	public interface IJsonLineInfo
	{
		[Token(Token = "0x170000D9")]
		int LineNumber
		{
			[Token(Token = "0x6000605")]
			get;
		}

		[Token(Token = "0x170000DA")]
		int LinePosition
		{
			[Token(Token = "0x6000606")]
			get;
		}

		[Token(Token = "0x6000604")]
		bool HasLineInfo();
	}
}
