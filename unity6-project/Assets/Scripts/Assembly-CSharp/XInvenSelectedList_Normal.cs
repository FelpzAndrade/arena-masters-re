using Il2CppDummyDll;

[Token(Token = "0x2000EBF")]
public class XInvenSelectedList_Normal : XInvenSelectedList
{
	[Token(Token = "0x17000E07")]
	public override int MaxCount
	{
		[Token(Token = "0x6006DF0")]
		[Address(RVA = "0x1D30688", Offset = "0x1D30688", VA = "0x1D30688", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000E08")]
	public override InventoryModeType invenModeType
	{
		[Token(Token = "0x6006DF1")]
		[Address(RVA = "0x1D30690", Offset = "0x1D30690", VA = "0x1D30690", Slot = "4")]
		get
		{
			return default(InventoryModeType);
		}
	}

	[Token(Token = "0x6006DEF")]
	[Address(RVA = "0x1D30684", Offset = "0x1D30684", VA = "0x1D30684")]
	public XInvenSelectedList_Normal()
	{
	}

	[Token(Token = "0x6006DF2")]
	[Address(RVA = "0x1D30698", Offset = "0x1D30698", VA = "0x1D30698", Slot = "7")]
	public override SelectRetType Add(XItem invenItem)
	{
		return default(SelectRetType);
	}

	[Token(Token = "0x6006DF3")]
	[Address(RVA = "0x1D30774", Offset = "0x1D30774", VA = "0x1D30774", Slot = "8")]
	public override bool Remove(XItem selectedItem)
	{
		return default(bool);
	}
}
