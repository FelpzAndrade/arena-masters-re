using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000761")]
public class XSpawnManager
{
	[Token(Token = "0x40022E1")]
	[FieldOffset(Offset = "0x8")]
	private Dictionary<int, List<GameObject>> m_SpawnedGameObjectList;

	[Token(Token = "0x40022E2")]
	[FieldOffset(Offset = "0xC")]
	private List<XSpawnInfo> m_SpawnInfoList;

	[Token(Token = "0x40022E3")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<int, XSpawnInfo> m_SpawnInfoDic;

	[Token(Token = "0x1700084A")]
	public List<XSpawnInfo> SpawnInfoList
	{
		[Token(Token = "0x6003C37")]
		[Address(RVA = "0x182AD50", Offset = "0x182AD50", VA = "0x182AD50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003C36")]
	[Address(RVA = "0x182AC3C", Offset = "0x182AC3C", VA = "0x182AC3C")]
	public XSpawnManager()
	{
	}

	[Token(Token = "0x6003C38")]
	[Address(RVA = "0x182AD58", Offset = "0x182AD58", VA = "0x182AD58")]
	public void Add(GameObject go, int groupIndex)
	{
	}

	[Token(Token = "0x6003C39")]
	[Address(RVA = "0x182AEBC", Offset = "0x182AEBC", VA = "0x182AEBC")]
	public void Remove(GameObject go)
	{
	}

	[Token(Token = "0x6003C3A")]
	[Address(RVA = "0x182B0C4", Offset = "0x182B0C4", VA = "0x182B0C4")]
	public void Clear()
	{
	}

	[Token(Token = "0x6003C3B")]
	[Address(RVA = "0x182B2D0", Offset = "0x182B2D0", VA = "0x182B2D0")]
	public void AddSpawnInfo(int nSpawnID, Vector3 position, Vector3 direction)
	{
	}

	[Token(Token = "0x6003C3C")]
	[Address(RVA = "0x182B418", Offset = "0x182B418", VA = "0x182B418")]
	public int Count(int groupIndex)
	{
		return default(int);
	}

	[Token(Token = "0x6003C3D")]
	[Address(RVA = "0x182B508", Offset = "0x182B508", VA = "0x182B508")]
	public XSpawnInfo GetSpawnInfo(int nSpawnID)
	{
		return null;
	}

	[Token(Token = "0x6003C3E")]
	[Address(RVA = "0x182B5C0", Offset = "0x182B5C0", VA = "0x182B5C0")]
	public NetData_DropObjectSpawnedInfo[] ToNetData()
	{
		return null;
	}
}
