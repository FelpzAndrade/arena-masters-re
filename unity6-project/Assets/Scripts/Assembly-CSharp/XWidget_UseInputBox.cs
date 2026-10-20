using System;
using Il2CppDummyDll;

[Token(Token = "0x2001006")]
public class XWidget_UseInputBox : XWidget_ItemQuantityInputBoxBase
{
	[Token(Token = "0x4005592")]
	[FieldOffset(Offset = "0x58")]
	public UIGrid grid;

	[Token(Token = "0x6007783")]
	[Address(RVA = "0x1B32D4C", Offset = "0x1B32D4C", VA = "0x1B32D4C")]
	public XWidget_UseInputBox()
	{
	}

	[Token(Token = "0x6007784")]
	[Address(RVA = "0x1B32D54", Offset = "0x1B32D54", VA = "0x1B32D54", Slot = "22")]
	public override void Build(XItem item, Action<string, int, int> onClickOK, int limitValue = -1)
	{
	}

	[Token(Token = "0x6007785")]
	[Address(RVA = "0x1B32F04", Offset = "0x1B32F04", VA = "0x1B32F04", Slot = "26")]
	public override void OnClick_InputConfirm()
	{
	}

	[Token(Token = "0x6007786")]
	[Address(RVA = "0x1B33018", Offset = "0x1B33018", VA = "0x1B33018", Slot = "27")]
	public override void OnClick_ResultConfirm()
	{
	}

	[Token(Token = "0x6007787")]
	[Address(RVA = "0x1B33070", Offset = "0x1B33070", VA = "0x1B33070", Slot = "23")]
	protected override int GetTotal()
	{
		return default(int);
	}

	[Token(Token = "0x6007788")]
	[Address(RVA = "0x1B33078", Offset = "0x1B33078", VA = "0x1B33078", Slot = "24")]
	protected override void RefreshTotal()
	{
	}

	[Token(Token = "0x6007789")]
	[Address(RVA = "0x1B3307C", Offset = "0x1B3307C", VA = "0x1B3307C", Slot = "21")]
	protected override void SetQuantityInputBox(XItem item)
	{
	}

	[Token(Token = "0x600778A")]
	[Address(RVA = "0x1B33254", Offset = "0x1B33254", VA = "0x1B33254", Slot = "25")]
	protected override void ShowMsgMax()
	{
	}

	[Token(Token = "0x600778B")]
	[Address(RVA = "0x1B33258", Offset = "0x1B33258", VA = "0x1B33258")]
	public void VisibleSetQuantityInputBox(bool isVisible)
	{
	}

	[Token(Token = "0x600778C")]
	[Address(RVA = "0x1B33348", Offset = "0x1B33348", VA = "0x1B33348")]
	public void ChangeUseText(string strText = "")
	{
	}

	[Token(Token = "0x600778D")]
	[Address(RVA = "0x1B3335C", Offset = "0x1B3335C", VA = "0x1B3335C")]
	public void GridReposition()
	{
	}
}
