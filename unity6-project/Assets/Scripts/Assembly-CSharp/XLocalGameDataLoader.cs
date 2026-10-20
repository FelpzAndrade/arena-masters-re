using Il2CppDummyDll;

[Token(Token = "0x2000627")]
public class XLocalGameDataLoader
{
	[Token(Token = "0x4001DB9")]
	private const string DATA_KEY = "local_game_data";

	[Token(Token = "0x60034FC")]
	[Address(RVA = "0x1E25BD0", Offset = "0x1E25BD0", VA = "0x1E25BD0")]
	public XLocalGameDataLoader()
	{
	}

	[Token(Token = "0x60034FD")]
	[Address(RVA = "0x1E25BD8", Offset = "0x1E25BD8", VA = "0x1E25BD8")]
	public static XLocalGameData Load()
	{
		return null;
	}

	[Token(Token = "0x60034FE")]
	[Address(RVA = "0x1E25ADC", Offset = "0x1E25ADC", VA = "0x1E25ADC")]
	public static void Save(XLocalGameData data)
	{
	}
}
