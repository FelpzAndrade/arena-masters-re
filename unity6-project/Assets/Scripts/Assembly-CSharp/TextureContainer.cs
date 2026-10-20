using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000CB3")]
public class TextureContainer
{
	[Token(Token = "0x40040A7")]
	[FieldOffset(Offset = "0x0")]
	internal static readonly TextureContainer Instance;

	[Token(Token = "0x40040A8")]
	[FieldOffset(Offset = "0x8")]
	private Dictionary<string, Texture2D> textures;

	[Token(Token = "0x6005B9F")]
	[Address(RVA = "0x1D4D9C8", Offset = "0x1D4D9C8", VA = "0x1D4D9C8")]
	public TextureContainer()
	{
	}

	[Token(Token = "0x6005BA1")]
	[Address(RVA = "0x1D4DB04", Offset = "0x1D4DB04", VA = "0x1D4DB04")]
	public Texture2D Get(string url)
	{
		return null;
	}

	[Token(Token = "0x6005BA2")]
	[Address(RVA = "0x1D4DBE4", Offset = "0x1D4DBE4", VA = "0x1D4DBE4")]
	public void Set(string url, Texture2D texture)
	{
	}
}
