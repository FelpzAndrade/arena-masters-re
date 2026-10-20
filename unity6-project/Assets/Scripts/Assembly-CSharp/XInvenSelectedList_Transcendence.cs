using Il2CppDummyDll;

[Token(Token = "0x2000EC3")]
public class XInvenSelectedList_Transcendence : XInvenSelectedList
{
	[Token(Token = "0x4004D92")]
	[FieldOffset(Offset = "0x18")]
	private int targetTranscendCnt;

	[Token(Token = "0x17000E11")]
	public override int MaxCount
	{
		[Token(Token = "0x6006E0C")]
		[Address(RVA = "0x1D31444", Offset = "0x1D31444", VA = "0x1D31444", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000E12")]
	public override InventoryModeType invenModeType
	{
		[Token(Token = "0x6006E0D")]
		[Address(RVA = "0x1D3144C", Offset = "0x1D3144C", VA = "0x1D3144C", Slot = "4")]
		get
		{
			return default(InventoryModeType);
		}
	}

	[Token(Token = "0x17000E13")]
	public int TargetTranscendCnt
	{
		[Token(Token = "0x6006E0E")]
		[Address(RVA = "0x1D31454", Offset = "0x1D31454", VA = "0x1D31454")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6006E0B")]
	[Address(RVA = "0x1D31440", Offset = "0x1D31440", VA = "0x1D31440")]
	public XInvenSelectedList_Transcendence()
	{
	}

	[Token(Token = "0x6006E0F")]
	[Address(RVA = "0x1D3145C", Offset = "0x1D3145C", VA = "0x1D3145C", Slot = "7")]
	public override SelectRetType Add(XItem invenItem)
	{
		return default(SelectRetType);
	}

	[Token(Token = "0x6006E10")]
	[Address(RVA = "0x1D31A80", Offset = "0x1D31A80", VA = "0x1D31A80", Slot = "8")]
	public override bool Remove(XItem selectedItem)
	{
		return default(bool);
	}
}
