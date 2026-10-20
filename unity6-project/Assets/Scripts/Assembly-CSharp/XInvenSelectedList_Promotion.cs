using Il2CppDummyDll;

[Token(Token = "0x2000EC1")]
public class XInvenSelectedList_Promotion : XInvenSelectedList
{
	[Token(Token = "0x17000E0A")]
	public override int MaxCount
	{
		[Token(Token = "0x6006DF7")]
		[Address(RVA = "0x1D307AC", Offset = "0x1D307AC", VA = "0x1D307AC", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000E0B")]
	public override InventoryModeType invenModeType
	{
		[Token(Token = "0x6006DF8")]
		[Address(RVA = "0x1D307B4", Offset = "0x1D307B4", VA = "0x1D307B4", Slot = "4")]
		get
		{
			return default(InventoryModeType);
		}
	}

	[Token(Token = "0x6006DF6")]
	[Address(RVA = "0x1D307A8", Offset = "0x1D307A8", VA = "0x1D307A8")]
	public XInvenSelectedList_Promotion()
	{
	}

	[Token(Token = "0x6006DF9")]
	[Address(RVA = "0x1D307BC", Offset = "0x1D307BC", VA = "0x1D307BC", Slot = "7")]
	public override SelectRetType Add(XItem invenItem)
	{
		return default(SelectRetType);
	}

	[Token(Token = "0x6006DFA")]
	[Address(RVA = "0x1D30A8C", Offset = "0x1D30A8C", VA = "0x1D30A8C", Slot = "8")]
	public override bool Remove(XItem selectedItem)
	{
		return default(bool);
	}
}
