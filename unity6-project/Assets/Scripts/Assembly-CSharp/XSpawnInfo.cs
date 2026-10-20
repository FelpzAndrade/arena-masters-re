using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000760")]
public class XSpawnInfo
{
	[Token(Token = "0x40022DA")]
	[FieldOffset(Offset = "0x8")]
	public int nSpawnID;

	[Token(Token = "0x40022DB")]
	[FieldOffset(Offset = "0xC")]
	public Vector3 position;

	[Token(Token = "0x40022DC")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 direction;

	[Token(Token = "0x40022DD")]
	[FieldOffset(Offset = "0x24")]
	private GameObject m_SpawnedGameObject;

	[Token(Token = "0x40022DE")]
	[FieldOffset(Offset = "0x28")]
	private int m_SpawnedCharId;

	[Token(Token = "0x40022DF")]
	[FieldOffset(Offset = "0x2C")]
	private float m_fResetTime;

	[Token(Token = "0x40022E0")]
	[FieldOffset(Offset = "0x30")]
	private int m_groupIndex;

	[Token(Token = "0x17000848")]
	public int SpawnedCharID
	{
		[Token(Token = "0x6003C32")]
		[Address(RVA = "0x182AB48", Offset = "0x182AB48", VA = "0x182AB48")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000849")]
	public int GroupIndex
	{
		[Token(Token = "0x6003C34")]
		[Address(RVA = "0x182AC00", Offset = "0x182AC00", VA = "0x182AC00")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6003C2E")]
	[Address(RVA = "0x182AA50", Offset = "0x182AA50", VA = "0x182AA50")]
	public XSpawnInfo(int id, Vector3 position, Vector3 direction)
	{
	}

	[Token(Token = "0x6003C2F")]
	[Address(RVA = "0x182AB20", Offset = "0x182AB20", VA = "0x182AB20")]
	public void SetSpawnedData(GameObject goObject, int nCharID, int groupIndex)
	{
	}

	[Token(Token = "0x6003C30")]
	[Address(RVA = "0x182AB30", Offset = "0x182AB30", VA = "0x182AB30")]
	public void ResetSpawnedData(float fNowTime = 0f)
	{
	}

	[Token(Token = "0x6003C31")]
	[Address(RVA = "0x182AB40", Offset = "0x182AB40", VA = "0x182AB40")]
	public GameObject GetSpawnedGameObject()
	{
		return null;
	}

	[Token(Token = "0x6003C33")]
	[Address(RVA = "0x182AB50", Offset = "0x182AB50", VA = "0x182AB50")]
	public bool IsSpawned()
	{
		return default(bool);
	}

	[Token(Token = "0x6003C35")]
	[Address(RVA = "0x182AC08", Offset = "0x182AC08", VA = "0x182AC08")]
	public bool IsRecentlyReset(float fNowTime)
	{
		return default(bool);
	}
}
