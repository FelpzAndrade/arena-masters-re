using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200067D")]
public class XSpriteLoader
{
	[Token(Token = "0x4001F2B")]
	[FieldOffset(Offset = "0x0")]
	public static string textureFolder;

	[Token(Token = "0x4001F2C")]
	[FieldOffset(Offset = "0x4")]
	public static string imageNoneName;

	[Token(Token = "0x4001F2D")]
	[FieldOffset(Offset = "0x8")]
	private Dictionary<string, Sprite> m_DefaultCaching;

	[Token(Token = "0x4001F2E")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<string, Sprite> m_LobbyCaching;

	[Token(Token = "0x4001F2F")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<string, Sprite> m_InGameCaching;

	[Token(Token = "0x4001F30")]
	[FieldOffset(Offset = "0x14")]
	private Dictionary<string, Sprite> m_AlwaysCaching;

	[Token(Token = "0x4001F31")]
	[FieldOffset(Offset = "0x18")]
	private HashSet<string> atlasList;

	[Token(Token = "0x4001F32")]
	[FieldOffset(Offset = "0x8")]
	public static string AtlasFolderRoot;

	[Token(Token = "0x4001F33")]
	[FieldOffset(Offset = "0x1C")]
	public Dictionary<string, Dictionary<string, Sprite>> m_atlasCache;

	[Token(Token = "0x4001F34")]
	[FieldOffset(Offset = "0x20")]
	public Dictionary<string, Dictionary<string, Sprite>> m_atlasCachePersistence;

	[Token(Token = "0x4001F35")]
	[FieldOffset(Offset = "0x24")]
	public HashSet<string> atlasPersistenceList;

	[Token(Token = "0x4001F36")]
	[FieldOffset(Offset = "0x28")]
	private StringBuilder builder;

	[Token(Token = "0x170007EB")]
	public HashSet<string> AtlasFolderList
	{
		[Token(Token = "0x60036BB")]
		[Address(RVA = "0x18304DC", Offset = "0x18304DC", VA = "0x18304DC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60036B4")]
	[Address(RVA = "0x182F4BC", Offset = "0x182F4BC", VA = "0x182F4BC")]
	public XSpriteLoader()
	{
	}

	[Token(Token = "0x60036B6")]
	[Address(RVA = "0x182F780", Offset = "0x182F780", VA = "0x182F780")]
	private Sprite Load(string key)
	{
		return null;
	}

	[Token(Token = "0x60036B7")]
	[Address(RVA = "0x182FF24", Offset = "0x182FF24", VA = "0x182FF24")]
	public Sprite LoadInGamePool(string key)
	{
		return null;
	}

	[Token(Token = "0x60036B8")]
	[Address(RVA = "0x18303C8", Offset = "0x18303C8", VA = "0x18303C8")]
	public Sprite LoadInPool(string key)
	{
		return null;
	}

	[Token(Token = "0x60036B9")]
	[Address(RVA = "0x182FF2C", Offset = "0x182FF2C", VA = "0x182FF2C")]
	private Sprite LoadInPool(string key, Dictionary<string, Sprite> pool)
	{
		return null;
	}

	[Token(Token = "0x60036BA")]
	[Address(RVA = "0x18303D0", Offset = "0x18303D0", VA = "0x18303D0")]
	public void Clear()
	{
	}

	[Token(Token = "0x60036BC")]
	[Address(RVA = "0x182FB9C", Offset = "0x182FB9C", VA = "0x182FB9C")]
	private Sprite LoadFromAtlas(string key, string atlasName)
	{
		return null;
	}

	[Token(Token = "0x60036BD")]
	[Address(RVA = "0x18305B4", Offset = "0x18305B4", VA = "0x18305B4")]
	public string GetAtlasName(string relativePath)
	{
		return null;
	}

	[Token(Token = "0x60036BE")]
	[Address(RVA = "0x182FA58", Offset = "0x182FA58", VA = "0x182FA58")]
	public string GetAtlasFolder(string relativePath)
	{
		return null;
	}

	[Token(Token = "0x60036BF")]
	[Address(RVA = "0x18306F4", Offset = "0x18306F4", VA = "0x18306F4")]
	public void LoadLoadingMultipleSprite(UI2DSprite sprite1, UI2DSprite sprite2, string path)
	{
	}

	[Token(Token = "0x60036C0")]
	[Address(RVA = "0x1830AE4", Offset = "0x1830AE4", VA = "0x1830AE4")]
	public Sprite LoadSpriteAndAssetUnloadRightnow(string path)
	{
		return null;
	}
}
