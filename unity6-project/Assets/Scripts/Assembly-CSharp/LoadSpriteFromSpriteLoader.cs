using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000172")]
public class LoadSpriteFromSpriteLoader : MonoBehaviour
{
	[Token(Token = "0x4000594")]
	[FieldOffset(Offset = "0xC")]
	public string path;

	[Token(Token = "0x4000595")]
	[FieldOffset(Offset = "0x10")]
	private UI2DSprite sprite;

	[Token(Token = "0x4000596")]
	[FieldOffset(Offset = "0x14")]
	public bool unloadOnDisable;

	[Token(Token = "0x6000DC1")]
	[Address(RVA = "0x134F884", Offset = "0x134F884", VA = "0x134F884")]
	public LoadSpriteFromSpriteLoader()
	{
	}

	[Token(Token = "0x6000DC2")]
	[Address(RVA = "0x134F88C", Offset = "0x134F88C", VA = "0x134F88C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000DC3")]
	[Address(RVA = "0x134FB34", Offset = "0x134FB34", VA = "0x134FB34")]
	private void OnDisable()
	{
	}
}
