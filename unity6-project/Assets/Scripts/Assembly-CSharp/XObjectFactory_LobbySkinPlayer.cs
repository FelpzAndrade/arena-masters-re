using CS;
using Il2CppDummyDll;

[Token(Token = "0x20003C8")]
public class XObjectFactory_LobbySkinPlayer : XObjectFactory_Actor
{
	[Token(Token = "0x4001326")]
	[FieldOffset(Offset = "0x20")]
	private XModuleActor.CreationDesc desc;

	[Token(Token = "0x4001327")]
	[FieldOffset(Offset = "0x24")]
	private XModuleLobbyUI.LobbyCharCreationDesc lobbyCharCreationDesc;

	[Token(Token = "0x17000538")]
	protected override string PrefabName
	{
		[Token(Token = "0x6001EBD")]
		[Address(RVA = "0x1680118", Offset = "0x1680118", VA = "0x1680118", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000539")]
	protected override bool IsNetworkObject
	{
		[Token(Token = "0x6001EBE")]
		[Address(RVA = "0x1680190", Offset = "0x1680190", VA = "0x1680190", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700053A")]
	protected override CSCharacterInfo actorInfo
	{
		[Token(Token = "0x6001EBF")]
		[Address(RVA = "0x1680198", Offset = "0x1680198", VA = "0x1680198", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001EBC")]
	[Address(RVA = "0x1680098", Offset = "0x1680098", VA = "0x1680098")]
	public XObjectFactory_LobbySkinPlayer(XModuleActor.CreationDesc desc, XModuleLobbyUI.LobbyCharCreationDesc lobbyCharCreationDesc)
	{
	}

	[Token(Token = "0x6001EC0")]
	[Address(RVA = "0x16801A0", Offset = "0x16801A0", VA = "0x16801A0", Slot = "6")]
	public override XModuleEntity Run()
	{
		return null;
	}
}
