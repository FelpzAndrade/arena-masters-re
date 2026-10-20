using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D30")]
public class XWidget_CharSelectMode : MonoBehaviour
{
	[Token(Token = "0x4004374")]
	[FieldOffset(Offset = "0xC")]
	public GameObject btnOK;

	[Token(Token = "0x4004375")]
	[FieldOffset(Offset = "0x10")]
	public UILabel lblLabel;

	[Token(Token = "0x4004376")]
	[FieldOffset(Offset = "0x14")]
	public XUIOrderBtn[] OrderBtn;

	[Token(Token = "0x4004377")]
	[FieldOffset(Offset = "0x18")]
	private int tmpIndex;

	[Token(Token = "0x4004378")]
	[FieldOffset(Offset = "0x1C")]
	private int tmpID;

	[Token(Token = "0x60060C1")]
	[Address(RVA = "0x15CF1E0", Offset = "0x15CF1E0", VA = "0x15CF1E0")]
	public XWidget_CharSelectMode()
	{
	}

	[Token(Token = "0x60060C2")]
	[Address(RVA = "0x15CF1F4", Offset = "0x15CF1F4", VA = "0x15CF1F4")]
	public void Init()
	{
	}

	[Token(Token = "0x60060C3")]
	[Address(RVA = "0x15CF438", Offset = "0x15CF438", VA = "0x15CF438")]
	public void SetActive(bool isActive)
	{
	}

	[Token(Token = "0x60060C4")]
	[Address(RVA = "0x15CF668", Offset = "0x15CF668", VA = "0x15CF668")]
	public void OnClick_Ok()
	{
	}

	[Token(Token = "0x60060C5")]
	[Address(RVA = "0x15CF4A8", Offset = "0x15CF4A8", VA = "0x15CF4A8")]
	private void SetOrderList()
	{
	}

	[Token(Token = "0x60060C6")]
	[Address(RVA = "0x15CF6A8", Offset = "0x15CF6A8", VA = "0x15CF6A8")]
	public void OnClickOrderBtn(int index, int charID)
	{
	}

	[Token(Token = "0x60060C7")]
	[Address(RVA = "0x15CF7D0", Offset = "0x15CF7D0", VA = "0x15CF7D0")]
	private void OrderBtnStateWithoutTargetIndex(int index, XUIOrderBtn.OrderBtnState state)
	{
	}
}
