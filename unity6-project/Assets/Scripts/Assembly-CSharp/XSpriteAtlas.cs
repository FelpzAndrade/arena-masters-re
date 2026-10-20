using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2001064")]
public class XSpriteAtlas : MonoBehaviour
{
	[Token(Token = "0x4005886")]
	[FieldOffset(Offset = "0xC")]
	public int HashVal;

	[Token(Token = "0x4005887")]
	[FieldOffset(Offset = "0x10")]
	public List<Sprite> list;

	[Token(Token = "0x6007BDC")]
	[Address(RVA = "0x182F228", Offset = "0x182F228", VA = "0x182F228")]
	public XSpriteAtlas()
	{
	}

	[Token(Token = "0x6007BDD")]
	[Address(RVA = "0x182F2D4", Offset = "0x182F2D4", VA = "0x182F2D4")]
	public Dictionary<string, Sprite> GetAtlasData()
	{
		return null;
	}
}
