using CS;
using Il2CppDummyDll;

[Token(Token = "0x20006A3")]
public static class XCharHelper
{
	[Token(Token = "0x60037C3")]
	[Address(RVA = "0x1ABCC60", Offset = "0x1ABCC60", VA = "0x1ABCC60")]
	public static bool TryGetCharacterSoundInfo(CSProtoInfoManager_CharacterSound characterSound, int charID, int skinID, out CSCharacterSoundInfo characterSoundInfo)
	{
		characterSoundInfo = default;
		return default(bool);
	}

	[Token(Token = "0x60037C4")]
	[Address(RVA = "0x1AB8B60", Offset = "0x1AB8B60", VA = "0x1AB8B60")]
	public static string GetResourceFullPathName(CSCharacterInfo characterInfo, SkinInfo skinInfo)
	{
		return null;
	}

	[Token(Token = "0x60037C5")]
	[Address(RVA = "0x1ABD930", Offset = "0x1ABD930", VA = "0x1ABD930")]
	public static XModuleActor.CreationDesc CreateCharacterDescriptionFromActor(XModuleActor characterModuleActor)
	{
		return null;
	}

	[Token(Token = "0x60037C6")]
	[Address(RVA = "0x1ABDA38", Offset = "0x1ABDA38", VA = "0x1ABDA38")]
	public static bool IsCharacterNotOwned(XModuleActor actor)
	{
		return default(bool);
	}

	[Token(Token = "0x60037C7")]
	[Address(RVA = "0x1ABDB18", Offset = "0x1ABDB18", VA = "0x1ABDB18")]
	public static bool IsCharacterNotOwned(string uid)
	{
		return default(bool);
	}

	[Token(Token = "0x60037C8")]
	[Address(RVA = "0x1ABDBDC", Offset = "0x1ABDBDC", VA = "0x1ABDBDC")]
	public static bool IsPetNotOwned(XModuleActor actor)
	{
		return default(bool);
	}

	[Token(Token = "0x60037C9")]
	[Address(RVA = "0x1ABDCBC", Offset = "0x1ABDCBC", VA = "0x1ABDCBC")]
	public static bool IsPetNotOwned(string uid)
	{
		return default(bool);
	}
}
