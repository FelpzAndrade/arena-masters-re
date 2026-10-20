using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000E59")]
public class XUILobbyState_PackageShop : XUILobbyState
{
	[Token(Token = "0x4004B5B")]
	[FieldOffset(Offset = "0x1C")]
	private XPanel_PackageShop m_pnlPackageShop;

	[Token(Token = "0x17000DC0")]
	public override bool IsPopup
	{
		[Token(Token = "0x6006B03")]
		[Address(RVA = "0x10A755C", Offset = "0x10A755C", VA = "0x10A755C", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000DC1")]
	public override bool IsPopupAutoPop
	{
		[Token(Token = "0x6006B04")]
		[Address(RVA = "0x10A7564", Offset = "0x10A7564", VA = "0x10A7564", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6006B01")]
	[Address(RVA = "0x10A754C", Offset = "0x10A754C", VA = "0x10A754C")]
	public XUILobbyState_PackageShop()
	{
	}

	[Token(Token = "0x6006B02")]
	[Address(RVA = "0x10A7554", Offset = "0x10A7554", VA = "0x10A7554", Slot = "17")]
	public override XLobbyStateTypes GetStateType()
	{
		return default(XLobbyStateTypes);
	}

	[Token(Token = "0x6006B05")]
	[Address(RVA = "0x10A756C", Offset = "0x10A756C", VA = "0x10A756C", Slot = "8")]
	public override void Final()
	{
	}

	[Token(Token = "0x6006B06")]
	[Address(RVA = "0x10A7588", Offset = "0x10A7588", VA = "0x10A7588", Slot = "7")]
	public override bool Back()
	{
		return default(bool);
	}

	[Token(Token = "0x6006B07")]
	[Address(RVA = "0x10A75E0", Offset = "0x10A75E0", VA = "0x10A75E0", Slot = "13")]
	protected override void OnCreated()
	{
	}

	[Token(Token = "0x6006B08")]
	[Address(RVA = "0x10A7694", Offset = "0x10A7694", VA = "0x10A7694", Slot = "14")]
	public override void OnShow()
	{
	}

	[Token(Token = "0x6006B09")]
	[Address(RVA = "0x10A77AC", Offset = "0x10A77AC", VA = "0x10A77AC")]
	private PackageShopTabCategory GetShopCategory()
	{
		return default(PackageShopTabCategory);
	}

	[Token(Token = "0x6006B0A")]
	[Address(RVA = "0x10A78FC", Offset = "0x10A78FC", VA = "0x10A78FC", Slot = "15")]
	public override void OnPop()
	{
	}

	[Token(Token = "0x6006B0B")]
	[Address(RVA = "0x10A7958", Offset = "0x10A7958", VA = "0x10A7958", Slot = "16")]
	public override void OnHide()
	{
	}
}
