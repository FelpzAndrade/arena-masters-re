using Il2CppDummyDll;

[Token(Token = "0x2000E5A")]
public class XUILobbyState_Pet : XUILobbyState
{
	[Token(Token = "0x4004B5C")]
	[FieldOffset(Offset = "0x1C")]
	private XPanel_Pet pnlPet;

	[Token(Token = "0x4004B5D")]
	[FieldOffset(Offset = "0x20")]
	private XPanel_TopBanner topBanner;

	[Token(Token = "0x4004B5E")]
	[FieldOffset(Offset = "0x24")]
	private XPanel_PetList pnlPetList;

	[Token(Token = "0x17000DC2")]
	protected override bool ShowLobbyNotiIcons
	{
		[Token(Token = "0x6006B0D")]
		[Address(RVA = "0x10A7A78", Offset = "0x10A7A78", VA = "0x10A7A78", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6006B0C")]
	[Address(RVA = "0x10A7A70", Offset = "0x10A7A70", VA = "0x10A7A70")]
	public XUILobbyState_Pet()
	{
	}

	[Token(Token = "0x6006B0E")]
	[Address(RVA = "0x10A7A80", Offset = "0x10A7A80", VA = "0x10A7A80", Slot = "17")]
	public override XLobbyStateTypes GetStateType()
	{
		return default(XLobbyStateTypes);
	}

	[Token(Token = "0x6006B0F")]
	[Address(RVA = "0x10A7A88", Offset = "0x10A7A88", VA = "0x10A7A88", Slot = "18")]
	public override string GetStateName()
	{
		return null;
	}

	[Token(Token = "0x6006B10")]
	[Address(RVA = "0x10A7B0C", Offset = "0x10A7B0C", VA = "0x10A7B0C", Slot = "12")]
	public override LobbyBackground GetLobbyBackgroundType()
	{
		return default(LobbyBackground);
	}

	[Token(Token = "0x6006B11")]
	[Address(RVA = "0x10A7B14", Offset = "0x10A7B14", VA = "0x10A7B14", Slot = "7")]
	public override bool Back()
	{
		return default(bool);
	}

	[Token(Token = "0x6006B12")]
	[Address(RVA = "0x10A7B6C", Offset = "0x10A7B6C", VA = "0x10A7B6C", Slot = "8")]
	public override void Final()
	{
	}

	[Token(Token = "0x6006B13")]
	[Address(RVA = "0x10A7B8C", Offset = "0x10A7B8C", VA = "0x10A7B8C", Slot = "13")]
	protected override void OnCreated()
	{
	}

	[Token(Token = "0x6006B14")]
	[Address(RVA = "0x10A7CDC", Offset = "0x10A7CDC", VA = "0x10A7CDC")]
	private int GetPetID()
	{
		return default(int);
	}

	[Token(Token = "0x6006B15")]
	[Address(RVA = "0x10A7F84", Offset = "0x10A7F84", VA = "0x10A7F84", Slot = "14")]
	public override void OnShow()
	{
	}

	[Token(Token = "0x6006B16")]
	[Address(RVA = "0x10A8480", Offset = "0x10A8480", VA = "0x10A8480")]
	private string GetUID(int petID)
	{
		return null;
	}

	[Token(Token = "0x6006B17")]
	[Address(RVA = "0x10A843C", Offset = "0x10A843C", VA = "0x10A843C")]
	private bool OnClickPetList(int petID)
	{
		return default(bool);
	}

	[Token(Token = "0x6006B18")]
	[Address(RVA = "0x10A858C", Offset = "0x10A858C", VA = "0x10A858C", Slot = "16")]
	public override void OnHide()
	{
	}
}
