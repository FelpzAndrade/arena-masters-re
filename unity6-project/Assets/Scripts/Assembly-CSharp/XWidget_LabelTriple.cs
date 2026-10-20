using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C88")]
public class XWidget_LabelTriple : MonoBehaviour
{
	[Token(Token = "0x4003FD2")]
	[FieldOffset(Offset = "0xC")]
	public UILabel lblFirst;

	[Token(Token = "0x4003FD3")]
	[FieldOffset(Offset = "0x10")]
	public UILabel lblSecond;

	[Token(Token = "0x4003FD4")]
	[FieldOffset(Offset = "0x14")]
	public UILabel lblThird;

	[Token(Token = "0x6005A95")]
	[Address(RVA = "0x1457248", Offset = "0x1457248", VA = "0x1457248")]
	public XWidget_LabelTriple()
	{
	}

	[Token(Token = "0x6005A96")]
	[Address(RVA = "0x1443ED8", Offset = "0x1443ED8", VA = "0x1443ED8")]
	public void Show(string first, string second, string third)
	{
	}

	[Token(Token = "0x6005A97")]
	[Address(RVA = "0x1457250", Offset = "0x1457250", VA = "0x1457250")]
	public void Hide()
	{
	}
}
