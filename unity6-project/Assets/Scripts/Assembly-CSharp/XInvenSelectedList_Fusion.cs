using Il2CppDummyDll;

[Token(Token = "0x2000EBD")]
public class XInvenSelectedList_Fusion : XInvenSelectedList
{
	[Token(Token = "0x17000E03")]
	public override int MaxCount
	{
		[Token(Token = "0x6006DE5")]
		[Address(RVA = "0x1D2FCCC", Offset = "0x1D2FCCC", VA = "0x1D2FCCC", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000E04")]
	public override InventoryModeType invenModeType
	{
		[Token(Token = "0x6006DE6")]
		[Address(RVA = "0x1D2FCD4", Offset = "0x1D2FCD4", VA = "0x1D2FCD4", Slot = "4")]
		get
		{
			return default(InventoryModeType);
		}
	}

	[Token(Token = "0x6006DE4")]
	[Address(RVA = "0x1D2FCC8", Offset = "0x1D2FCC8", VA = "0x1D2FCC8")]
	public XInvenSelectedList_Fusion()
	{
	}

	[Token(Token = "0x6006DE7")]
	[Address(RVA = "0x1D2FCDC", Offset = "0x1D2FCDC", VA = "0x1D2FCDC", Slot = "7")]
	public override SelectRetType Add(XItem invenItem)
	{
		return default(SelectRetType);
	}

	[Token(Token = "0x6006DE8")]
	[Address(RVA = "0x1D30094", Offset = "0x1D30094", VA = "0x1D30094")]
	public bool IsEqualRarity(XItem curSelectedItem)
	{
		return default(bool);
	}

	[Token(Token = "0x6006DE9")]
	[Address(RVA = "0x1D30378", Offset = "0x1D30378", VA = "0x1D30378", Slot = "8")]
	public override bool Remove(XItem selectedItem)
	{
		return default(bool);
	}
}
