using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200075E")]
public class XSectorProperty : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200075F")]
	public class LightMapData
	{
		[Token(Token = "0x40022D7")]
		[FieldOffset(Offset = "0x8")]
		public Transform tr;

		[Token(Token = "0x40022D8")]
		[FieldOffset(Offset = "0xC")]
		public int lightmapIndex;

		[Token(Token = "0x40022D9")]
		[FieldOffset(Offset = "0x10")]
		public Vector4 lightmapScaleOffset;

		[Token(Token = "0x6003C2D")]
		[Address(RVA = "0x181C474", Offset = "0x181C474", VA = "0x181C474")]
		public LightMapData()
		{
		}
	}

	[Token(Token = "0x40022CC")]
	[FieldOffset(Offset = "0xC")]
	public GameObject[] m_HeroSpawn;

	[Token(Token = "0x40022CD")]
	[FieldOffset(Offset = "0x10")]
	public GameObject[] m_TeamASpawn;

	[Token(Token = "0x40022CE")]
	[FieldOffset(Offset = "0x14")]
	public GameObject[] m_TeamBSpawn;

	[Token(Token = "0x40022CF")]
	[FieldOffset(Offset = "0x18")]
	public GameObject[] m_ItemSpawn;

	[Token(Token = "0x40022D0")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject[] m_PointSpawn;

	[Token(Token = "0x40022D1")]
	[FieldOffset(Offset = "0x20")]
	public GameObject[] m_PortalObjects;

	[Token(Token = "0x40022D2")]
	[FieldOffset(Offset = "0x24")]
	public SphereCollider m_battleField;

	[Token(Token = "0x40022D3")]
	[FieldOffset(Offset = "0x28")]
	public SphereCollider[] m_WayPoints;

	[Token(Token = "0x40022D4")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject m_miniMapBound;

	[Token(Token = "0x40022D5")]
	[FieldOffset(Offset = "0x30")]
	public List<XModuleGimmick> GimmickList;

	[Token(Token = "0x40022D6")]
	[FieldOffset(Offset = "0x34")]
	public LightMapData[] lightmapData;

	[Token(Token = "0x6003C29")]
	[Address(RVA = "0x181C1C0", Offset = "0x181C1C0", VA = "0x181C1C0")]
	public XSectorProperty()
	{
	}

	[Token(Token = "0x6003C2A")]
	[Address(RVA = "0x181C264", Offset = "0x181C264", VA = "0x181C264")]
	public void CacheLightMapData()
	{
	}

	[Token(Token = "0x6003C2B")]
	[Address(RVA = "0x181C47C", Offset = "0x181C47C", VA = "0x181C47C")]
	public void LoadCachedLightMapData()
	{
	}

	[Token(Token = "0x6003C2C")]
	[Address(RVA = "0x181C654", Offset = "0x181C654", VA = "0x181C654")]
	public List<XModuleGimmick> GetGimmickList()
	{
		return null;
	}
}
