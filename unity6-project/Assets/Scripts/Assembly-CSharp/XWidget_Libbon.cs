using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F9D")]
public class XWidget_Libbon : MonoBehaviour
{
	[Token(Token = "0x40052A6")]
	[FieldOffset(Offset = "0xC")]
	private string strFramePath;

	[Token(Token = "0x40052A7")]
	[FieldOffset(Offset = "0x10")]
	public UI2DSprite sprFrame;

	[Token(Token = "0x40052A8")]
	[FieldOffset(Offset = "0x14")]
	public UILabel lblText;

	[Token(Token = "0x6007464")]
	[Address(RVA = "0x1459A20", Offset = "0x1459A20", VA = "0x1459A20")]
	public XWidget_Libbon()
	{
	}

	[Token(Token = "0x6007465")]
	[Address(RVA = "0x1459A28", Offset = "0x1459A28", VA = "0x1459A28")]
	public void Show(string framePath, string text = "")
	{
	}

	[Token(Token = "0x6007466")]
	[Address(RVA = "0x1459A88", Offset = "0x1459A88", VA = "0x1459A88")]
	private void Build(string framePath, string text = "")
	{
	}

	[Token(Token = "0x6007467")]
	[Address(RVA = "0x1459C60", Offset = "0x1459C60", VA = "0x1459C60")]
	public void ChangeFrameColor(Color color)
	{
	}

	[Token(Token = "0x6007468")]
	[Address(RVA = "0x1459D60", Offset = "0x1459D60", VA = "0x1459D60")]
	public void ChangeTextColor(Color color)
	{
	}

	[Token(Token = "0x6007469")]
	[Address(RVA = "0x1459AB4", Offset = "0x1459AB4", VA = "0x1459AB4")]
	public void ChangeFrame(string framePath)
	{
	}

	[Token(Token = "0x600746A")]
	[Address(RVA = "0x1459E60", Offset = "0x1459E60", VA = "0x1459E60")]
	public void Hide()
	{
	}
}
