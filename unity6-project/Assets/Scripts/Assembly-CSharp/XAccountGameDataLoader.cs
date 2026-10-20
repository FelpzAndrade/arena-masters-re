using Il2CppDummyDll;

[Token(Token = "0x200062A")]
public class XAccountGameDataLoader
{
	[Token(Token = "0x4001DBD")]
	private const string DATA_KEY = "local_game_data";

	[Token(Token = "0x6003506")]
	[Address(RVA = "0x17B5AE0", Offset = "0x17B5AE0", VA = "0x17B5AE0")]
	public XAccountGameDataLoader()
	{
	}

	[Token(Token = "0x6003507")]
	[Address(RVA = "0x17B5AE8", Offset = "0x17B5AE8", VA = "0x17B5AE8")]
	public static XAccountGameData Load(string name)
	{
		return null;
	}

	[Token(Token = "0x6003508")]
	[Address(RVA = "0x17B5C60", Offset = "0x17B5C60", VA = "0x17B5C60")]
	public static void Save(string name, XAccountGameData data)
	{
	}
}
