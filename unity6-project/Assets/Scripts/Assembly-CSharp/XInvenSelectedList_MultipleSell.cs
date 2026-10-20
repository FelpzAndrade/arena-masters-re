using Il2CppDummyDll;

[Token(Token = "0x2000EBE")]
public class XInvenSelectedList_MultipleSell : XInvenSelectedList
{
	[Token(Token = "0x17000E05")]
	public override InventoryModeType invenModeType
	{
		[Token(Token = "0x6006DEB")]
		[Address(RVA = "0x1D303F8", Offset = "0x1D303F8", VA = "0x1D303F8", Slot = "4")]
		get
		{
			return default(InventoryModeType);
		}
	}

	[Token(Token = "0x17000E06")]
	public override int MaxCount
	{
		[Token(Token = "0x6006DEC")]
		[Address(RVA = "0x1D30400", Offset = "0x1D30400", VA = "0x1D30400", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6006DEA")]
	[Address(RVA = "0x1D303F4", Offset = "0x1D303F4", VA = "0x1D303F4")]
	public XInvenSelectedList_MultipleSell()
	{
	}

	[Token(Token = "0x6006DED")]
	[Address(RVA = "0x1D30408", Offset = "0x1D30408", VA = "0x1D30408", Slot = "7")]
	public override SelectRetType Add(XItem invenItem)
	{
		return default(SelectRetType);
	}

	[Token(Token = "0x6006DEE")]
	[Address(RVA = "0x1D30614", Offset = "0x1D30614", VA = "0x1D30614", Slot = "8")]
	public override bool Remove(XItem selectedItem)
	{
		return default(bool);
	}
}
