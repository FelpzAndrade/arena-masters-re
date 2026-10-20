using Il2CppDummyDll;

[Token(Token = "0x200019C")]
public class UIStorageSlot : UIItemSlot
{
	[Token(Token = "0x40005E3")]
	[FieldOffset(Offset = "0x2C")]
	public UIItemStorage storage;

	[Token(Token = "0x40005E4")]
	[FieldOffset(Offset = "0x30")]
	public int slot;

	[Token(Token = "0x1700023F")]
	protected override InvGameItem observedItem
	{
		[Token(Token = "0x6000E7E")]
		[Address(RVA = "0x17A00B8", Offset = "0x17A00B8", VA = "0x17A00B8", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000E7D")]
	[Address(RVA = "0x17A00B0", Offset = "0x17A00B0", VA = "0x17A00B0")]
	public UIStorageSlot()
	{
	}

	[Token(Token = "0x6000E7F")]
	[Address(RVA = "0x17A019C", Offset = "0x17A019C", VA = "0x17A019C", Slot = "5")]
	protected override InvGameItem Replace(InvGameItem item)
	{
		return null;
	}
}
