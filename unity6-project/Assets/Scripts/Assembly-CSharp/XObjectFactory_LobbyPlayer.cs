using CS;
using Il2CppDummyDll;

[Token(Token = "0x20003C7")]
public class XObjectFactory_LobbyPlayer : XObjectFactory_Actor
{
	[Token(Token = "0x4001324")]
	[FieldOffset(Offset = "0x20")]
	private XModuleActor.CreationDesc desc;

	[Token(Token = "0x4001325")]
	[FieldOffset(Offset = "0x24")]
	private XModuleLobbyUI.LobbyCharCreationDesc lobbyCharCreationDesc;

	[Token(Token = "0x17000535")]
	protected override string PrefabName
	{
		[Token(Token = "0x6001EB8")]
		[Address(RVA = "0x167FCC8", Offset = "0x167FCC8", VA = "0x167FCC8", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000536")]
	protected override bool IsNetworkObject
	{
		[Token(Token = "0x6001EB9")]
		[Address(RVA = "0x167FD40", Offset = "0x167FD40", VA = "0x167FD40", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000537")]
	protected override CSCharacterInfo actorInfo
	{
		[Token(Token = "0x6001EBA")]
		[Address(RVA = "0x167FD48", Offset = "0x167FD48", VA = "0x167FD48", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001EB7")]
	[Address(RVA = "0x167FC48", Offset = "0x167FC48", VA = "0x167FC48")]
	public XObjectFactory_LobbyPlayer(XModuleActor.CreationDesc desc, XModuleLobbyUI.LobbyCharCreationDesc lobbyCharCreationDesc)
	{
	}

	[Token(Token = "0x6001EBB")]
	[Address(RVA = "0x167FD50", Offset = "0x167FD50", VA = "0x167FD50", Slot = "6")]
	public override XModuleEntity Run()
	{
		return null;
	}
}
