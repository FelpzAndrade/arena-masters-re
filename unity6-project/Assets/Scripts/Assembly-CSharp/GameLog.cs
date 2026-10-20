using System.IO;
using Il2CppDummyDll;

[Token(Token = "0x2001072")]
public static class GameLog
{
	[Token(Token = "0x6007C20")]
	[Address(RVA = "0x1F2DC14", Offset = "0x1F2DC14", VA = "0x1F2DC14")]
	private static string GetLogPath(string filename)
	{
		return null;
	}

	[Token(Token = "0x6007C21")]
	[Address(RVA = "0x1F2DD08", Offset = "0x1F2DD08", VA = "0x1F2DD08")]
	private static StreamWriter GetStreamWriter(string type)
	{
		return null;
	}

	[Token(Token = "0x6007C22")]
	[Address(RVA = "0x1F2DD28", Offset = "0x1F2DD28", VA = "0x1F2DD28")]
	public static void Log(string type, string text)
	{
	}

	[Token(Token = "0x6007C23")]
	[Address(RVA = "0x1F2DE38", Offset = "0x1F2DE38", VA = "0x1F2DE38")]
	public static void Log(StreamWriter w, string text)
	{
	}

	[Token(Token = "0x6007C24")]
	[Address(RVA = "0x1F2DE3C", Offset = "0x1F2DE3C", VA = "0x1F2DE3C")]
	public static void Log_DumpNPC(XModuleActor actor)
	{
	}
}
