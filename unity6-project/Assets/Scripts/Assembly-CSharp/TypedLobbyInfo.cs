using Il2CppDummyDll;

[Token(Token = "0x20002B7")]
public class TypedLobbyInfo : TypedLobby
{
	[Token(Token = "0x4000E0F")]
	[FieldOffset(Offset = "0x10")]
	public int PlayerCount;

	[Token(Token = "0x4000E10")]
	[FieldOffset(Offset = "0x14")]
	public int RoomCount;

	[Token(Token = "0x6001732")]
	[Address(RVA = "0x1D610EC", Offset = "0x1D610EC", VA = "0x1D610EC")]
	public TypedLobbyInfo()
	{
	}

	[Token(Token = "0x6001733")]
	[Address(RVA = "0x1D6118C", Offset = "0x1D6118C", VA = "0x1D6118C", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
