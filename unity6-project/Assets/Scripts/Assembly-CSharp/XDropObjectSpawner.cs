using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2000756")]
public class XDropObjectSpawner
{
	[Token(Token = "0x40022A8")]
	[FieldOffset(Offset = "0x8")]
	private List<List<XSpawnInfo>> m_NormalItemGroupSpawnInfoList;

	[Token(Token = "0x40022A9")]
	[FieldOffset(Offset = "0xC")]
	private List<XDropObjectSpawnController> m_NormalItemController;

	[Token(Token = "0x40022AA")]
	[FieldOffset(Offset = "0x10")]
	private XSpawnInfo[] m_SpecialSpawnInfoArray;

	[Token(Token = "0x40022AB")]
	[FieldOffset(Offset = "0x14")]
	private XDropObjectSpawnController[] m_SpecialItemController;

	[Token(Token = "0x6003BEC")]
	[Address(RVA = "0x19A95A0", Offset = "0x19A95A0", VA = "0x19A95A0")]
	public XDropObjectSpawner()
	{
	}

	[Token(Token = "0x6003BED")]
	[Address(RVA = "0x19A96D0", Offset = "0x19A96D0", VA = "0x19A96D0")]
	public int GetNormalItemGroupCount()
	{
		return default(int);
	}

	[Token(Token = "0x6003BEE")]
	[Address(RVA = "0x19A9768", Offset = "0x19A9768", VA = "0x19A9768")]
	public void Init(CSSectorInfo sectorInfo, XSpawnManager dropObjectSpawnManager)
	{
	}

	[Token(Token = "0x6003BEF")]
	[Address(RVA = "0x19A9D44", Offset = "0x19A9D44", VA = "0x19A9D44")]
	private bool UpdateNormalCheck(int nIndex, float fDeltaTime, int nCurrentSpawnedObjectCount, out int nCharID)
	{
		nCharID = default;
		return default(bool);
	}

	[Token(Token = "0x6003BF0")]
	[Address(RVA = "0x19A9E0C", Offset = "0x19A9E0C", VA = "0x19A9E0C")]
	public bool UpdateNormal(int groupIndex, float fDeltaTime, out int nSpawnID, out int nCharID)
	{
		nCharID = default;
		nSpawnID = default;
		return default(bool);
	}

	[Token(Token = "0x6003BF1")]
	[Address(RVA = "0x19A9F60", Offset = "0x19A9F60", VA = "0x19A9F60")]
	public int PickRandomDropObjectSpawnID(int nIndex)
	{
		return default(int);
	}

	[Token(Token = "0x6003BF2")]
	[Address(RVA = "0x19AA108", Offset = "0x19AA108", VA = "0x19AA108")]
	private bool UpdateSpecialCheck(int nIndex, float fDeltaTime, int nCurrentSpawnedObjectCount, out int nCharID)
	{
		nCharID = default;
		return default(bool);
	}

	[Token(Token = "0x6003BF3")]
	[Address(RVA = "0x19AA174", Offset = "0x19AA174", VA = "0x19AA174")]
	public bool UpdateSpecial(int groupIndex, float fDeltaTime, out int nSpawnID, out int nCharID)
	{
		nCharID = default;
		nSpawnID = default;
		return default(bool);
	}
}
