using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2000757")]
public class XDropObjectSpawnController
{
	[Token(Token = "0x40022AC")]
	[FieldOffset(Offset = "0x8")]
	private List<int> m_ItemList;

	[Token(Token = "0x40022AD")]
	[FieldOffset(Offset = "0xC")]
	private float m_fSpawnTime;

	[Token(Token = "0x40022AE")]
	[FieldOffset(Offset = "0x10")]
	private int m_nMaxSpawnedCount;

	[Token(Token = "0x40022AF")]
	[FieldOffset(Offset = "0x14")]
	private float m_fSpawnElapsedTime;

	[Token(Token = "0x6003BF4")]
	[Address(RVA = "0x19A933C", Offset = "0x19A933C", VA = "0x19A933C")]
	public XDropObjectSpawnController()
	{
	}

	[Token(Token = "0x6003BF5")]
	[Address(RVA = "0x19A935C", Offset = "0x19A935C", VA = "0x19A935C")]
	public void Init(List<int> itemList, float fSpawnTime, int nMaxSpawnedCount = -1)
	{
	}

	[Token(Token = "0x6003BF6")]
	[Address(RVA = "0x19A9374", Offset = "0x19A9374", VA = "0x19A9374")]
	private bool CheckSpawnTime(float fDeltaTime)
	{
		return default(bool);
	}

	[Token(Token = "0x6003BF7")]
	[Address(RVA = "0x19A93A8", Offset = "0x19A93A8", VA = "0x19A93A8")]
	private bool CheckTotalSpawnCount(int nCurrentSpawnedObjectCount)
	{
		return default(bool);
	}

	[Token(Token = "0x6003BF8")]
	[Address(RVA = "0x19A93CC", Offset = "0x19A93CC", VA = "0x19A93CC")]
	public bool UpdateCheck(float fDeltaTime, int nCurrentSpawnedCount, out int nCharID)
	{
		nCharID = default;
		return default(bool);
	}

	[Token(Token = "0x6003BF9")]
	[Address(RVA = "0x19A944C", Offset = "0x19A944C", VA = "0x19A944C")]
	public int SpawnDropObjectID()
	{
		return default(int);
	}
}
