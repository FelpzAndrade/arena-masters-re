using Il2CppDummyDll;

[Token(Token = "0x2000199")]
public class UIEquipmentSlot : UIItemSlot
{
	[Token(Token = "0x40005D0")]
	[FieldOffset(Offset = "0x2C")]
	public InvEquipment equipment;

	[Token(Token = "0x40005D1")]
	[FieldOffset(Offset = "0x30")]
	public InvBaseItem.Slot slot;

	[Token(Token = "0x1700023C")]
	protected override InvGameItem observedItem
	{
		[Token(Token = "0x6000E6D")]
		[Address(RVA = "0x16EB0B8", Offset = "0x16EB0B8", VA = "0x16EB0B8", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000E6C")]
	[Address(RVA = "0x16EAFF0", Offset = "0x16EAFF0", VA = "0x16EAFF0")]
	public UIEquipmentSlot()
	{
	}

	[Token(Token = "0x6000E6E")]
	[Address(RVA = "0x16EB19C", Offset = "0x16EB19C", VA = "0x16EB19C", Slot = "5")]
	protected override InvGameItem Replace(InvGameItem item)
	{
		return null;
	}
}
