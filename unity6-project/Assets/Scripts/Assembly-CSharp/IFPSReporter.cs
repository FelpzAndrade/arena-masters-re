using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2001070")]
public interface IFPSReporter
{
	[Token(Token = "0x6007C1D")]
	void Report(string title, Dictionary<string, string> data);
}
