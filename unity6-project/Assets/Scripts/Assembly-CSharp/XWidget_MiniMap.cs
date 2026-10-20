using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D39")]
public class XWidget_MiniMap : MonoBehaviour
{
	[Token(Token = "0x2000D3A")]
	private enum MiniMapObjectType
	{
		[Token(Token = "0x40043C9")]
		MyPlayer = 0,
		[Token(Token = "0x40043CA")]
		Player = 1,
		[Token(Token = "0x40043CB")]
		Item = 2,
		[Token(Token = "0x40043CC")]
		NoneTeamFlag = 3,
		[Token(Token = "0x40043CD")]
		ATeamFlag = 4,
		[Token(Token = "0x40043CE")]
		BTeamFlag = 5
	}

	[Token(Token = "0x40043AD")]
	[FieldOffset(Offset = "0xC")]
	public GameObject myMiniPlayers;

	[Token(Token = "0x40043AE")]
	[FieldOffset(Offset = "0x10")]
	public GameObject mapMiniPlayers;

	[Token(Token = "0x40043AF")]
	[FieldOffset(Offset = "0x14")]
	public GameObject mapMiniItemObject;

	[Token(Token = "0x40043B0")]
	[FieldOffset(Offset = "0x18")]
	public GameObject mapMiniPointObject;

	[Token(Token = "0x40043B1")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite sprBackgroundFrame;

	[Token(Token = "0x40043B2")]
	[FieldOffset(Offset = "0x20")]
	public UI2DSprite sprMiniMap;

	[Token(Token = "0x40043B3")]
	[FieldOffset(Offset = "0x24")]
	private UIWidget _widget;

	[Token(Token = "0x40043B4")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<MiniMapObjectType, List<XWidget_MiniMapObject>> cachingMiniMapObjectList;

	[Token(Token = "0x40043B5")]
	[FieldOffset(Offset = "0x2C")]
	private Dictionary<MiniMapObjectType, List<XModuleEntity>> cachingInstancePoolObjectList;

	[Token(Token = "0x40043B6")]
	[FieldOffset(Offset = "0x30")]
	private float sightDistacneSquare;

	[Token(Token = "0x40043B7")]
	[FieldOffset(Offset = "0x34")]
	private int myPlayerPoolingCount;

	[Token(Token = "0x40043B8")]
	[FieldOffset(Offset = "0x38")]
	private int playerPoolingCount;

	[Token(Token = "0x40043B9")]
	[FieldOffset(Offset = "0x3C")]
	private int itemPoolingCount;

	[Token(Token = "0x40043BA")]
	[FieldOffset(Offset = "0x40")]
	private int noneFlagPoolingCount;

	[Token(Token = "0x40043BB")]
	[FieldOffset(Offset = "0x44")]
	private int aTeamFlagPoolingCount;

	[Token(Token = "0x40043BC")]
	[FieldOffset(Offset = "0x48")]
	private int bTeamFlagPoolingCount;

	[Token(Token = "0x40043BD")]
	[FieldOffset(Offset = "0x4C")]
	private bool m_isInit;

	[Token(Token = "0x40043BE")]
	[FieldOffset(Offset = "0x50")]
	private int m_friendPlayerCount;

	[Token(Token = "0x40043BF")]
	[FieldOffset(Offset = "0x54")]
	private int m_enemyPlayerCount;

	[Token(Token = "0x40043C0")]
	[FieldOffset(Offset = "0x58")]
	private Vector3 m_correctPosition;

	[Token(Token = "0x40043C1")]
	[FieldOffset(Offset = "0x64")]
	private Quaternion m_qRot;

	[Token(Token = "0x40043C2")]
	[FieldOffset(Offset = "0x74")]
	private Transform m_miniMapTransform;

	[Token(Token = "0x40043C3")]
	[FieldOffset(Offset = "0x78")]
	private Vector3 m_miniMapMeshSize;

	[Token(Token = "0x40043C4")]
	[FieldOffset(Offset = "0x84")]
	private CSSectorInfo m_sectorInfo;

	[Token(Token = "0x40043C5")]
	[FieldOffset(Offset = "0x88")]
	private Color friendPlayerColor;

	[Token(Token = "0x40043C6")]
	[FieldOffset(Offset = "0x98")]
	private Color enemyPlayerColor;

	[Token(Token = "0x40043C7")]
	[FieldOffset(Offset = "0xA8")]
	private bool reserveRefreshMiniMapItem;

	[Token(Token = "0x6006101")]
	[Address(RVA = "0x14618B8", Offset = "0x14618B8", VA = "0x14618B8")]
	public XWidget_MiniMap()
	{
	}

	[Token(Token = "0x6006102")]
	[Address(RVA = "0x1461AE8", Offset = "0x1461AE8", VA = "0x1461AE8")]
	public void SetAlpha(float alpha)
	{
	}

	[Token(Token = "0x6006103")]
	[Address(RVA = "0x1461BF4", Offset = "0x1461BF4", VA = "0x1461BF4")]
	private void InstaceLoad(int poolingCount, string path, GameObject parentObject, MiniMapObjectType mapObjectType)
	{
	}

	[Token(Token = "0x6006104")]
	[Address(RVA = "0x1462178", Offset = "0x1462178", VA = "0x1462178")]
	public void Init(CSSectorInfo sectorInfo, XSectorProperty sectorProperty)
	{
	}

	[Token(Token = "0x6006105")]
	[Address(RVA = "0x14623A0", Offset = "0x14623A0", VA = "0x14623A0")]
	private void InitSprite(XSectorProperty sectorProperty)
	{
	}

	[Token(Token = "0x6006106")]
	[Address(RVA = "0x1463764", Offset = "0x1463764", VA = "0x1463764")]
	private void HideMiniMapObject(MiniMapObjectType miniMapObjectType)
	{
	}

	[Token(Token = "0x6006107")]
	[Address(RVA = "0x14639BC", Offset = "0x14639BC", VA = "0x14639BC")]
	private void BuildCachingInstancePoolObjectList(MiniMapObjectType miniMapObjectType)
	{
	}

	[Token(Token = "0x6006108")]
	[Address(RVA = "0x1462C88", Offset = "0x1462C88", VA = "0x1462C88")]
	public void RefreshMiniMapPlayer()
	{
	}

	[Token(Token = "0x6006109")]
	[Address(RVA = "0x146313C", Offset = "0x146313C", VA = "0x146313C")]
	public void RefreshMiniMapItem()
	{
	}

	[Token(Token = "0x600610A")]
	[Address(RVA = "0x1463BC0", Offset = "0x1463BC0", VA = "0x1463BC0")]
	private void _RefreshMiniMapItem()
	{
	}

	[Token(Token = "0x600610B")]
	[Address(RVA = "0x1463148", Offset = "0x1463148", VA = "0x1463148")]
	public void RefreshMiniMapFlag()
	{
	}

	[Token(Token = "0x600610C")]
	[Address(RVA = "0x1463F10", Offset = "0x1463F10", VA = "0x1463F10")]
	private void Update()
	{
	}

	[Token(Token = "0x600610D")]
	[Address(RVA = "0x1464D18", Offset = "0x1464D18", VA = "0x1464D18")]
	private void DecideVisible(MiniMapObjectType miniMapObjectType, XModuleEntity entity, XWidget_MiniMapObject miniMapObject)
	{
	}

	[Token(Token = "0x600610E")]
	[Address(RVA = "0x1465114", Offset = "0x1465114", VA = "0x1465114")]
	private void UpdateMiniMapObject(MiniMapObjectType miniMapObjectType, ref int poolingCount, string prefabPath)
	{
	}

	[Token(Token = "0x600610F")]
	[Address(RVA = "0x146570C", Offset = "0x146570C", VA = "0x146570C")]
	private bool IsOnlyUpdateMyPlayer()
	{
		return default(bool);
	}

	[Token(Token = "0x6006110")]
	[Address(RVA = "0x1463F34", Offset = "0x1463F34", VA = "0x1463F34")]
	private void UpdatePlayer()
	{
	}

	[Token(Token = "0x6006111")]
	[Address(RVA = "0x1464C20", Offset = "0x1464C20", VA = "0x1464C20")]
	private void UpdateFlag()
	{
	}

	[Token(Token = "0x6006112")]
	[Address(RVA = "0x14649B4", Offset = "0x14649B4", VA = "0x14649B4")]
	private void UpdateItem()
	{
	}

	[Token(Token = "0x6006113")]
	[Address(RVA = "0x14657E8", Offset = "0x14657E8", VA = "0x14657E8")]
	private float CalcDistanceSquare(Vector3 from, Vector3 to)
	{
		return default(float);
	}

	[Token(Token = "0x6006114")]
	[Address(RVA = "0x1464DC8", Offset = "0x1464DC8", VA = "0x1464DC8")]
	private void UpdatePosition(XWidget_MiniMapObject miniMapObject, Vector3 meshPosition)
	{
	}
}
