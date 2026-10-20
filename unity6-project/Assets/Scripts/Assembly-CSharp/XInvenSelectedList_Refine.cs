using Il2CppDummyDll;

[Token(Token = "0x2000EC2")]
public class XInvenSelectedList_Refine : XInvenSelectedList
{
	[Token(Token = "0x4004D8F")]
	[FieldOffset(Offset = "0x18")]
	private int ExpTotal__BackingField;

	[Token(Token = "0x4004D90")]
	[FieldOffset(Offset = "0x1C")]
	private int LastExp__BackingField;

	[Token(Token = "0x4004D91")]
	[FieldOffset(Offset = "0x20")]
	private XItem RefineTargetItem__BackingField;

	[Token(Token = "0x17000E0C")]
	public override int MaxCount
	{
		[Token(Token = "0x6006DFC")]
		[Address(RVA = "0x1D30AE4", Offset = "0x1D30AE4", VA = "0x1D30AE4", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000E0D")]
	public override InventoryModeType invenModeType
	{
		[Token(Token = "0x6006DFD")]
		[Address(RVA = "0x1D30AEC", Offset = "0x1D30AEC", VA = "0x1D30AEC", Slot = "4")]
		get
		{
			return default(InventoryModeType);
		}
	}

	[Token(Token = "0x17000E0E")]
	public int ExpTotal
	{
		[Token(Token = "0x6006DFE")]
		[Address(RVA = "0x1D30AF4", Offset = "0x1D30AF4", VA = "0x1D30AF4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006DFF")]
		[Address(RVA = "0x1D30AFC", Offset = "0x1D30AFC", VA = "0x1D30AFC")]
		private set
		{
		}
	}

	[Token(Token = "0x17000E0F")]
	public int LastExp
	{
		[Token(Token = "0x6006E00")]
		[Address(RVA = "0x1D30B04", Offset = "0x1D30B04", VA = "0x1D30B04")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006E01")]
		[Address(RVA = "0x1D30B0C", Offset = "0x1D30B0C", VA = "0x1D30B0C")]
		private set
		{
		}
	}

	[Token(Token = "0x17000E10")]
	public XItem RefineTargetItem
	{
		[Token(Token = "0x6006E02")]
		[Address(RVA = "0x1D30B14", Offset = "0x1D30B14", VA = "0x1D30B14")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006E03")]
		[Address(RVA = "0x1D30B1C", Offset = "0x1D30B1C", VA = "0x1D30B1C")]
		private set
		{
		}
	}

	[Token(Token = "0x6006DFB")]
	[Address(RVA = "0x1D30AE0", Offset = "0x1D30AE0", VA = "0x1D30AE0")]
	public XInvenSelectedList_Refine()
	{
	}

	[Token(Token = "0x6006E04")]
	[Address(RVA = "0x1D30B24", Offset = "0x1D30B24", VA = "0x1D30B24", Slot = "7")]
	public override SelectRetType Add(XItem invenItem)
	{
		return default(SelectRetType);
	}

	[Token(Token = "0x6006E05")]
	[Address(RVA = "0x1D31364", Offset = "0x1D31364", VA = "0x1D31364", Slot = "8")]
	public override bool Remove(XItem selectedItem)
	{
		return default(bool);
	}

	[Token(Token = "0x6006E06")]
	[Address(RVA = "0x1D313F4", Offset = "0x1D313F4", VA = "0x1D313F4", Slot = "5")]
	public override void ForcedAdd(XItem invenItem)
	{
	}

	[Token(Token = "0x6006E07")]
	[Address(RVA = "0x1D30F8C", Offset = "0x1D30F8C", VA = "0x1D30F8C")]
	public bool IsExpExceed(XItem addItem)
	{
		return default(bool);
	}

	[Token(Token = "0x6006E08")]
	[Address(RVA = "0x1D31200", Offset = "0x1D31200", VA = "0x1D31200")]
	private void SetItemTotalExp(XItem item, bool isAdd)
	{
	}

	[Token(Token = "0x6006E09")]
	[Address(RVA = "0x1D3141C", Offset = "0x1D3141C", VA = "0x1D3141C")]
	public void SetRefineTargetItem(XItem item)
	{
	}

	[Token(Token = "0x6006E0A")]
	[Address(RVA = "0x1D31424", Offset = "0x1D31424", VA = "0x1D31424", Slot = "9")]
	public override void Clear()
	{
	}
}
