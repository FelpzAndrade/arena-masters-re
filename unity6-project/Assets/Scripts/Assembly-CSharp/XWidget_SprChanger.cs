using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000FED")]
public class XWidget_SprChanger : MonoBehaviour
{
	[Token(Token = "0x40054F2")]
	[FieldOffset(Offset = "0xC")]
	public GameObject sprBG;

	[Token(Token = "0x40054F3")]
	[FieldOffset(Offset = "0x10")]
	public GameObject[] goSprColorList;

	[Token(Token = "0x60076B5")]
	[Address(RVA = "0x1B0C080", Offset = "0x1B0C080", VA = "0x1B0C080")]
	public XWidget_SprChanger()
	{
	}

	[Token(Token = "0x60076B6")]
	[Address(RVA = "0x1B0C088", Offset = "0x1B0C088", VA = "0x1B0C088")]
	public void Build(int showIndex, bool showSprBG = true)
	{
	}
}
