using Il2CppDummyDll;

[Token(Token = "0x20002B6")]
public class TypedLobby
{
	[Token(Token = "0x4000E0C")]
	[FieldOffset(Offset = "0x8")]
	public string Name;

	[Token(Token = "0x4000E0D")]
	[FieldOffset(Offset = "0xC")]
	public LobbyType Type;

	[Token(Token = "0x4000E0E")]
	[FieldOffset(Offset = "0x0")]
	public static readonly TypedLobby Default;

	[Token(Token = "0x170003E3")]
	public bool IsDefault
	{
		[Token(Token = "0x6001730")]
		[Address(RVA = "0x1D60F34", Offset = "0x1D60F34", VA = "0x1D60F34")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600172D")]
	[Address(RVA = "0x1D60DB0", Offset = "0x1D60DB0", VA = "0x1D60DB0")]
	public TypedLobby()
	{
	}

	[Token(Token = "0x600172E")]
	[Address(RVA = "0x1D60E7C", Offset = "0x1D60E7C", VA = "0x1D60E7C")]
	public TypedLobby(string name, LobbyType type)
	{
	}

	[Token(Token = "0x6001731")]
	[Address(RVA = "0x1D60FF0", Offset = "0x1D60FF0", VA = "0x1D60FF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
