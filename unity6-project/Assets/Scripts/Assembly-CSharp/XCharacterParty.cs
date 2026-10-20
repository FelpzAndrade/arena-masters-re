using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x20003EF")]
internal class XCharacterParty
{
	[Token(Token = "0x40013B9")]
	[FieldOffset(Offset = "0x8")]
	private List<XCharacterInfo> characters;

	// C# has no syntax for parameterized property 'Item'.
	// Its 'property:' attributes below are ignored by the compiler (CS0657).
	[property: Token(Token = "0x17000571")]
	[Token(Token = "0x600203D")]
	[Address(RVA = "0x1ABD828", Offset = "0x1ABD828", VA = "0x1ABD828")]
	public XCharacterInfo get_Item(int index)
	{
		return null;
	}

	[Token(Token = "0x17000572")]
	public string CharactersInfo
	{
		[Token(Token = "0x600203E")]
		[Address(RVA = "0x1ABD5B8", Offset = "0x1ABD5B8", VA = "0x1ABD5B8")]
		set
		{
		}
	}

	[Token(Token = "0x600203B")]
	[Address(RVA = "0x1ABD460", Offset = "0x1ABD460", VA = "0x1ABD460")]
	public XCharacterParty()
	{
	}

	[Token(Token = "0x600203C")]
	[Address(RVA = "0x1ABD50C", Offset = "0x1ABD50C", VA = "0x1ABD50C")]
	public static XCharacterParty Create(string charactersInfo)
	{
		return null;
	}
}
