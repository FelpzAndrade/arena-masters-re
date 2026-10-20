using System;
using Il2CppDummyDll;

[Token(Token = "0x2000FE4")]
public class XWidget_SellInputBox : XWidget_ItemQuantityInputBoxBase
{
	[Token(Token = "0x40054C8")]
	[FieldOffset(Offset = "0x58")]
	public UILabel lblTotal;

	[Token(Token = "0x40054C9")]
	[FieldOffset(Offset = "0x5C")]
	public UILabel lblItemName;

	[Token(Token = "0x40054CA")]
	[FieldOffset(Offset = "0x60")]
	public UISprite goldIcon;

	[Token(Token = "0x40054CB")]
	[FieldOffset(Offset = "0x64")]
	public UISprite arenaCoinIcon;

	[Token(Token = "0x600768B")]
	[Address(RVA = "0x1B03134", Offset = "0x1B03134", VA = "0x1B03134")]
	public XWidget_SellInputBox()
	{
	}

	[Token(Token = "0x600768C")]
	[Address(RVA = "0x1B0313C", Offset = "0x1B0313C", VA = "0x1B0313C", Slot = "22")]
	public override void Build(XItem item, Action<string, int, int> onClickOK, int limitValue = -1)
	{
	}

	[Token(Token = "0x600768D")]
	[Address(RVA = "0x1B03230", Offset = "0x1B03230", VA = "0x1B03230", Slot = "19")]
	protected override void SetConfirmTitle()
	{
	}

	[Token(Token = "0x600768E")]
	[Address(RVA = "0x1B0329C", Offset = "0x1B0329C", VA = "0x1B0329C", Slot = "20")]
	protected override void SetInputTitle()
	{
	}

	[Token(Token = "0x600768F")]
	[Address(RVA = "0x1B0316C", Offset = "0x1B0316C", VA = "0x1B0316C")]
	private void BuildItemPriceIcon()
	{
	}

	[Token(Token = "0x6007690")]
	[Address(RVA = "0x1B03258", Offset = "0x1B03258", VA = "0x1B03258")]
	public void ShowItemName(bool bShow)
	{
	}

	[Token(Token = "0x6007691")]
	[Address(RVA = "0x1B0340C", Offset = "0x1B0340C", VA = "0x1B0340C", Slot = "23")]
	protected override int GetTotal()
	{
		return default(int);
	}

	[Token(Token = "0x6007692")]
	[Address(RVA = "0x1B034B0", Offset = "0x1B034B0", VA = "0x1B034B0", Slot = "24")]
	protected override void RefreshTotal()
	{
	}

	[Token(Token = "0x6007693")]
	[Address(RVA = "0x1B03600", Offset = "0x1B03600", VA = "0x1B03600", Slot = "25")]
	protected override void ShowMsgMax()
	{
	}

	[Token(Token = "0x6007694")]
	[Address(RVA = "0x1B0373C", Offset = "0x1B0373C", VA = "0x1B0373C", Slot = "21")]
	protected override void SetQuantityInputBox(XItem item)
	{
	}

	[Token(Token = "0x6007695")]
	[Address(RVA = "0x1B0393C", Offset = "0x1B0393C", VA = "0x1B0393C", Slot = "26")]
	public override void OnClick_InputConfirm()
	{
	}

	[Token(Token = "0x6007696")]
	[Address(RVA = "0x1B03A7C", Offset = "0x1B03A7C", VA = "0x1B03A7C", Slot = "27")]
	public override void OnClick_ResultConfirm()
	{
	}
}
