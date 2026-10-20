using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2000B9A")]
public class FileHash
{
	[Token(Token = "0x4003B29")]
	[FieldOffset(Offset = "0x0")]
	public static string dexFile;

	[Token(Token = "0x4003B2A")]
	[FieldOffset(Offset = "0x4")]
	public static List<string> libFileList;

	[Token(Token = "0x60053FD")]
	[Address(RVA = "0x1E8B808", Offset = "0x1E8B808", VA = "0x1E8B808")]
	public FileHash()
	{
	}

	[Token(Token = "0x60053FF")]
	[Address(RVA = "0x1E8B97C", Offset = "0x1E8B97C", VA = "0x1E8B97C")]
	public static string GetHashValueFromFile(string filePath)
	{
		return null;
	}
}
