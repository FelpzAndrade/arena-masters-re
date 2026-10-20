using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000EEF")]
public class XUIPackageShopItem : XUIPackageShopItemBase
{
	[Token(Token = "0x4004F2E")]
	[FieldOffset(Offset = "0x5C")]
	public UILabel lblLimitedEdition;

	[Token(Token = "0x4004F2F")]
	[FieldOffset(Offset = "0x60")]
	public UILabel lblProductDes;

	[Token(Token = "0x4004F30")]
	[FieldOffset(Offset = "0x64")]
	public UILabel lblResetDes;

	[Token(Token = "0x4004F31")]
	[FieldOffset(Offset = "0x68")]
	public XWidget_Builder contentBuilder;

	[Token(Token = "0x6006FA2")]
	[Address(RVA = "0x1906518", Offset = "0x1906518", VA = "0x1906518")]
	public XUIPackageShopItem()
	{
	}

	[Token(Token = "0x6006FA3")]
	[Address(RVA = "0x1906538", Offset = "0x1906538", VA = "0x1906538", Slot = "7")]
	protected override void BuildImage(string path)
	{
	}

	[Token(Token = "0x6006FA4")]
	[Address(RVA = "0x19067A8", Offset = "0x19067A8", VA = "0x19067A8")]
	private string GetContentValueText(ShopContent content)
	{
		return null;
	}

	[Token(Token = "0x6006FA5")]
	[Address(RVA = "0x1906A3C", Offset = "0x1906A3C", VA = "0x1906A3C", Slot = "4")]
	protected override void BuildContentInfo(List<CSContent> contentList)
	{
	}

	[Token(Token = "0x6006FA6")]
	[Address(RVA = "0x1907288", Offset = "0x1907288", VA = "0x1907288", Slot = "8")]
	protected override string GetBuyButtonText()
	{
		return null;
	}

	[Token(Token = "0x6006FA7")]
	[Address(RVA = "0x19073E4", Offset = "0x19073E4", VA = "0x19073E4", Slot = "5")]
	protected override void Reposition()
	{
	}

	[Token(Token = "0x6006FA8")]
	[Address(RVA = "0x1906DC8", Offset = "0x1906DC8", VA = "0x1906DC8")]
	protected void BuildProductDesLabel(bool active)
	{
	}

	[Token(Token = "0x6006FA9")]
	[Address(RVA = "0x1906F28", Offset = "0x1906F28", VA = "0x1906F28")]
	protected void BuildResetDayDesLabel(bool active, int firstDay)
	{
	}

	[Token(Token = "0x6006FAA")]
	[Address(RVA = "0x19070F4", Offset = "0x19070F4", VA = "0x19070F4")]
	protected void BuildLimitedEditionLabel(string localeKey)
	{
	}
}
