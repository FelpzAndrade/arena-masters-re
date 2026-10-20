using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C96")]
public class XWidget_ResizeLabel : MonoBehaviour
{
	[Token(Token = "0x4004011")]
	[FieldOffset(Offset = "0xC")]
	public UILabel label;

	[Token(Token = "0x4004012")]
	[FieldOffset(Offset = "0x10")]
	public int widgetWidth;

	[Token(Token = "0x4004013")]
	[FieldOffset(Offset = "0x14")]
	public int defaultFontSize;

	[Token(Token = "0x4004014")]
	[FieldOffset(Offset = "0x18")]
	public int shrinkFontSize;

	[Token(Token = "0x6005AEF")]
	[Address(RVA = "0x1342770", Offset = "0x1342770", VA = "0x1342770")]
	public XWidget_ResizeLabel()
	{
	}

	[Token(Token = "0x6005AF0")]
	[Address(RVA = "0x1342F08", Offset = "0x1342F08", VA = "0x1342F08", Slot = "4")]
	public virtual void OnEnable()
	{
	}

	[Token(Token = "0x6005AF1")]
	[Address(RVA = "0x134301C", Offset = "0x134301C", VA = "0x134301C")]
	private int ResizeFont()
	{
		return default(int);
	}

	[Token(Token = "0x6005AF2")]
	[Address(RVA = "0x1342924", Offset = "0x1342924", VA = "0x1342924")]
	protected bool IsOverWidgetWidth()
	{
		return default(bool);
	}

	[Token(Token = "0x6005AF3")]
	[Address(RVA = "0x1343040", Offset = "0x1343040", VA = "0x1343040", Slot = "5")]
	public virtual void SetText(string text)
	{
	}
}
