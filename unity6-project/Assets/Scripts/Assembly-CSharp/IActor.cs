using CS;
using Il2CppDummyDll;

[Token(Token = "0x200044C")]
public interface IActor
{
	[Token(Token = "0x170005F1")]
	XModuleActor.CharacterStatus OriginalStatus
	{
		[Token(Token = "0x60022FA")]
		get;
	}

	[Token(Token = "0x170005F2")]
	CharStatus Status
	{
		[Token(Token = "0x60022FB")]
		get;
	}

	[Token(Token = "0x60022FC")]
	bool IsDeathDoor();
}
