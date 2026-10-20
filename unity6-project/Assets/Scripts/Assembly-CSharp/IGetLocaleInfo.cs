using Il2CppDummyDll;

[Token(Token = "0x2000666")]
public interface IGetLocaleInfo
{
	[Token(Token = "0x6003655")]
	bool IsExistLanguageLocaleInfo(string strLanguage);

	[Token(Token = "0x6003656")]
	string GetDefaultLanguage();
}
