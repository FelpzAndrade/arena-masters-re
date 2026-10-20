using System;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F76")]
public class XWidget_CraftInputBox : XWidget_ItemQuantityInputBoxBase
{
	[Token(Token = "0x40051A4")]
	[FieldOffset(Offset = "0x58")]
	public GameObject goLblMaterialLack;

	[Token(Token = "0x40051A5")]
	[FieldOffset(Offset = "0x5C")]
	public Transform resultIcon;

	[Token(Token = "0x40051A6")]
	[FieldOffset(Offset = "0x60")]
	private XWidget_ItemIcon m_resultIcon;

	[Token(Token = "0x40051A7")]
	[FieldOffset(Offset = "0x64")]
	private CraftInfo m_craftInfo;

	[Token(Token = "0x600731A")]
	[Address(RVA = "0x15EB390", Offset = "0x15EB390", VA = "0x15EB390")]
	public XWidget_CraftInputBox()
	{
	}

	[Token(Token = "0x600731B")]
	[Address(RVA = "0x15EB398", Offset = "0x15EB398", VA = "0x15EB398")]
	private int GetSumInvenStackCount(int id)
	{
		return default(int);
	}

	[Token(Token = "0x600731C")]
	[Address(RVA = "0x15EB474", Offset = "0x15EB474", VA = "0x15EB474")]
	private void SetIconQuantity(XWidget_ItemIcon targetIcon, string quantityStr)
	{
	}

	[Token(Token = "0x600731D")]
	[Address(RVA = "0x15EB578", Offset = "0x15EB578", VA = "0x15EB578", Slot = "18")]
	public override void BuildIcon(XItem item)
	{
	}

	[Token(Token = "0x600731E")]
	[Address(RVA = "0x15EBB0C", Offset = "0x15EBB0C", VA = "0x15EBB0C")]
	private bool IsLack()
	{
		return default(bool);
	}

	[Token(Token = "0x600731F")]
	[Address(RVA = "0x15EBB7C", Offset = "0x15EBB7C", VA = "0x15EBB7C")]
	private string GetMaterialQuantityString(bool isLack)
	{
		return null;
	}

	[Token(Token = "0x6007320")]
	[Address(RVA = "0x15EBD48", Offset = "0x15EBD48", VA = "0x15EBD48", Slot = "22")]
	public override void Build(XItem item, Action<string, int, int> onClickOK, int limitValue = -1)
	{
	}

	[Token(Token = "0x6007321")]
	[Address(RVA = "0x15EBF3C", Offset = "0x15EBF3C", VA = "0x15EBF3C", Slot = "21")]
	protected override void SetQuantityInputBox(XItem item)
	{
	}

	[Token(Token = "0x6007322")]
	[Address(RVA = "0x15EC104", Offset = "0x15EC104", VA = "0x15EC104", Slot = "23")]
	protected override int GetTotal()
	{
		return default(int);
	}

	[Token(Token = "0x6007323")]
	[Address(RVA = "0x15EC10C", Offset = "0x15EC10C", VA = "0x15EC10C", Slot = "24")]
	protected override void RefreshTotal()
	{
	}

	[Token(Token = "0x6007324")]
	[Address(RVA = "0x15EC1C4", Offset = "0x15EC1C4", VA = "0x15EC1C4", Slot = "25")]
	protected override void ShowMsgMax()
	{
	}

	[Token(Token = "0x6007325")]
	[Address(RVA = "0x15EC1C8", Offset = "0x15EC1C8", VA = "0x15EC1C8", Slot = "26")]
	public override void OnClick_InputConfirm()
	{
	}

	[Token(Token = "0x6007326")]
	[Address(RVA = "0x15EC2DC", Offset = "0x15EC2DC", VA = "0x15EC2DC", Slot = "27")]
	public override void OnClick_ResultConfirm()
	{
	}
}
