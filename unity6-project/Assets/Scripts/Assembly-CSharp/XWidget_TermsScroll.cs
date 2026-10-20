using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2001052")]
public class XWidget_TermsScroll : MonoBehaviour
{
	[Token(Token = "0x40057FD")]
	[FieldOffset(Offset = "0xC")]
	public UILabel article;

	[Token(Token = "0x40057FE")]
	[FieldOffset(Offset = "0x10")]
	private int labelHeight;

	[Token(Token = "0x17000F0E")]
	public int LabelHeight
	{
		[Token(Token = "0x60079C9")]
		[Address(RVA = "0x1B22804", Offset = "0x1B22804", VA = "0x1B22804")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60079C8")]
	[Address(RVA = "0x1B227FC", Offset = "0x1B227FC", VA = "0x1B227FC")]
	public XWidget_TermsScroll()
	{
	}

	[Token(Token = "0x60079CA")]
	[Address(RVA = "0x1B2280C", Offset = "0x1B2280C", VA = "0x1B2280C")]
	private void Start()
	{
	}
}
