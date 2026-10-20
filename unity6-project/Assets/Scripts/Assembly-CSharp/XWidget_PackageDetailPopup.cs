using Il2CppDummyDll;

[Token(Token = "0x2000EF9")]
public class XWidget_PackageDetailPopup : XUIBaseWidget
{
	[Token(Token = "0x4004F5C")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel lblTitle;

	[Token(Token = "0x4004F5D")]
	[FieldOffset(Offset = "0x20")]
	public UIScrollView scrollView;

	[Token(Token = "0x4004F5E")]
	[FieldOffset(Offset = "0x24")]
	public XWiget_GridBuilder builder;

	[Token(Token = "0x6006FD9")]
	[Address(RVA = "0x1312E18", Offset = "0x1312E18", VA = "0x1312E18")]
	public XWidget_PackageDetailPopup()
	{
	}

	[Token(Token = "0x6006FDA")]
	[Address(RVA = "0x1312E20", Offset = "0x1312E20", VA = "0x1312E20")]
	public void Show(string strTitle, int detailID)
	{
	}

	[Token(Token = "0x6006FDB")]
	[Address(RVA = "0x1312E98", Offset = "0x1312E98", VA = "0x1312E98")]
	private void Build(string strTitle, int detailID)
	{
	}
}
