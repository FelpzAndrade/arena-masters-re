using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20003CE")]
public class XObjectManager
{
	[Token(Token = "0x400133E")]
	private const int ALL_POINT_OBJECT_INDEX = -1;

	[Token(Token = "0x400133F")]
	private const int NONE_POINT_OBJECT_INDEX = -2;

	[Token(Token = "0x4001340")]
	[FieldOffset(Offset = "0x8")]
	private GameObject goMyPlayer;

	[Token(Token = "0x4001341")]
	[FieldOffset(Offset = "0xC")]
	private XModuleEntity myPlayerMe;

	[Token(Token = "0x4001342")]
	[FieldOffset(Offset = "0x10")]
	private List<GameObject> goNPCs;

	[Token(Token = "0x4001343")]
	[FieldOffset(Offset = "0x14")]
	private List<XModuleEntity> m_NPCModuleEntityList;

	[Token(Token = "0x4001344")]
	[FieldOffset(Offset = "0x18")]
	private List<GameObject> goMapObjects;

	[Token(Token = "0x4001345")]
	[FieldOffset(Offset = "0x1C")]
	private List<XSpawnInfo> spawnPlayers;

	[Token(Token = "0x4001346")]
	[FieldOffset(Offset = "0x20")]
	private List<XSpawnInfo> spawnPlayerTeamA;

	[Token(Token = "0x4001347")]
	[FieldOffset(Offset = "0x24")]
	private List<XSpawnInfo> spawnPlayerTeamB;

	[Token(Token = "0x4001348")]
	[FieldOffset(Offset = "0x28")]
	private XSpawnManager m_DropObjectSpawnManager;

	[Token(Token = "0x4001349")]
	[FieldOffset(Offset = "0x2C")]
	private XSpawnManager m_PointObjectSpawnManager;

	[Token(Token = "0x400134A")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<int, XModuleActor> m_ActorDictionary;

	[Token(Token = "0x400134B")]
	[FieldOffset(Offset = "0x34")]
	private int m_ATIDGenerate;

	[Token(Token = "0x400134C")]
	[FieldOffset(Offset = "0x38")]
	private XRandomPosInCircle m_battleField;

	[Token(Token = "0x400134D")]
	[FieldOffset(Offset = "0x3C")]
	private List<XRandomPosInCircle> m_WayPointList;

	[Token(Token = "0x17000547")]
	public int NPCCount
	{
		[Token(Token = "0x6001EF6")]
		[Address(RVA = "0x1685990", Offset = "0x1685990", VA = "0x1685990")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000548")]
	public XSpawnManager DropObjectSpawnManager
	{
		[Token(Token = "0x6001EF8")]
		[Address(RVA = "0x1685A54", Offset = "0x1685A54", VA = "0x1685A54")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001ED7")]
	[Address(RVA = "0x16841D4", Offset = "0x16841D4", VA = "0x16841D4")]
	public XObjectManager()
	{
	}

	[Token(Token = "0x6001ED8")]
	[Address(RVA = "0x16843D4", Offset = "0x16843D4", VA = "0x16843D4")]
	public void AddActor(int nATID, XModuleActor actor)
	{
	}

	[Token(Token = "0x6001ED9")]
	[Address(RVA = "0x168447C", Offset = "0x168447C", VA = "0x168447C")]
	public void DelActor(int nATID)
	{
	}

	[Token(Token = "0x6001EDA")]
	[Address(RVA = "0x168451C", Offset = "0x168451C", VA = "0x168451C")]
	public XModuleActor FindActor(int nATID)
	{
		return null;
	}

	[Token(Token = "0x6001EDB")]
	[Address(RVA = "0x16845FC", Offset = "0x16845FC", VA = "0x16845FC")]
	public void ClearActors()
	{
	}

	[Token(Token = "0x6001EDC")]
	[Address(RVA = "0x1684694", Offset = "0x1684694", VA = "0x1684694")]
	public List<XModuleActor> GetActorList()
	{
		return null;
	}

	[Token(Token = "0x6001EDD")]
	[Address(RVA = "0x16848C8", Offset = "0x16848C8", VA = "0x16848C8")]
	public void SetActiveInvincibleActors(bool isInvincible)
	{
	}

	[Token(Token = "0x6001EDE")]
	[Address(RVA = "0x16849CC", Offset = "0x16849CC", VA = "0x16849CC")]
	public int GenerateNewATID()
	{
		return default(int);
	}

	[Token(Token = "0x6001EDF")]
	[Address(RVA = "0x16849E0", Offset = "0x16849E0", VA = "0x16849E0")]
	public GameObject GetMyPlayer()
	{
		return null;
	}

	[Token(Token = "0x6001EE0")]
	[Address(RVA = "0x16849E8", Offset = "0x16849E8", VA = "0x16849E8")]
	public XModuleEntity GetMyPlayerME()
	{
		return null;
	}

	[Token(Token = "0x6001EE1")]
	[Address(RVA = "0x16849F0", Offset = "0x16849F0", VA = "0x16849F0")]
	public bool IsMyObject(GameObject go)
	{
		return default(bool);
	}

	[Token(Token = "0x6001EE2")]
	[Address(RVA = "0x1684AA4", Offset = "0x1684AA4", VA = "0x1684AA4")]
	public bool IsLocalObject(XModuleEntity moduleEntity)
	{
		return default(bool);
	}

	[Token(Token = "0x6001EE3")]
	[Address(RVA = "0x1684BFC", Offset = "0x1684BFC", VA = "0x1684BFC")]
	public void SetMyPlayer(XModuleEntity me)
	{
	}

	[Token(Token = "0x6001EE4")]
	[Address(RVA = "0x1684C24", Offset = "0x1684C24", VA = "0x1684C24")]
	public void RemoveMyPlayer()
	{
	}

	[Token(Token = "0x6001EE5")]
	[Address(RVA = "0x1684C30", Offset = "0x1684C30", VA = "0x1684C30")]
	public void MyPlayerHitNotReady()
	{
	}

	[Token(Token = "0x6001EE6")]
	[Address(RVA = "0x1684D18", Offset = "0x1684D18", VA = "0x1684D18")]
	public void RemoveActor(XModuleActor actor)
	{
	}

	[Token(Token = "0x6001EE7")]
	[Address(RVA = "0x1684E10", Offset = "0x1684E10", VA = "0x1684E10")]
	public void RemoveDropObject(XModuleActor actor)
	{
	}

	[Token(Token = "0x6001EE8")]
	[Address(RVA = "0x1684E50", Offset = "0x1684E50", VA = "0x1684E50")]
	public void RemovePointObject(GameObject go)
	{
	}

	[Token(Token = "0x6001EE9")]
	[Address(RVA = "0x1684E7C", Offset = "0x1684E7C", VA = "0x1684E7C")]
	public void Clear()
	{
	}

	[Token(Token = "0x6001EEA")]
	[Address(RVA = "0x168503C", Offset = "0x168503C", VA = "0x168503C")]
	public void AddSpawnPlayer(Vector3 position, Vector3 direction)
	{
	}

	[Token(Token = "0x6001EEB")]
	[Address(RVA = "0x1685164", Offset = "0x1685164", VA = "0x1685164")]
	public void AddSpawnPlayerTeam(Vector3 position, Vector3 direction, XTeamEnum nTeamEnum)
	{
	}

	[Token(Token = "0x6001EEC")]
	[Address(RVA = "0x16852FC", Offset = "0x16852FC", VA = "0x16852FC")]
	public void AddSpawnDropObject(int nSpawnID, Vector3 position, Vector3 direction)
	{
	}

	[Token(Token = "0x6001EED")]
	[Address(RVA = "0x1685350", Offset = "0x1685350", VA = "0x1685350")]
	public void AddSpawnPointObject(int nSpawnID, Vector3 position, Vector3 direction)
	{
	}

	[Token(Token = "0x6001EEE")]
	[Address(RVA = "0x16853A4", Offset = "0x16853A4", VA = "0x16853A4")]
	public void AddBattleField(Vector3 position, float radius)
	{
	}

	[Token(Token = "0x6001EEF")]
	[Address(RVA = "0x1685494", Offset = "0x1685494", VA = "0x1685494")]
	public void AddWayPoint(Vector3 position, float radius)
	{
	}

	[Token(Token = "0x6001EF0")]
	[Address(RVA = "0x16855BC", Offset = "0x16855BC", VA = "0x16855BC")]
	public XRandomPosInCircle GetBattleField()
	{
		return null;
	}

	[Token(Token = "0x6001EF1")]
	[Address(RVA = "0x16855C4", Offset = "0x16855C4", VA = "0x16855C4")]
	public XRandomPosInCircle GetRandomWayPoint()
	{
		return null;
	}

	[Token(Token = "0x6001EF2")]
	[Address(RVA = "0x16856E8", Offset = "0x16856E8", VA = "0x16856E8")]
	public XSpawnInfo GetPlayerRandomSpawnInfo()
	{
		return null;
	}

	[Token(Token = "0x6001EF3")]
	[Address(RVA = "0x16857AC", Offset = "0x16857AC", VA = "0x16857AC")]
	public XSpawnInfo GetPlayerSpawnInfo(int nIndex)
	{
		return null;
	}

	[Token(Token = "0x6001EF4")]
	[Address(RVA = "0x1685890", Offset = "0x1685890", VA = "0x1685890")]
	public XSpawnInfo GetPlayerTeamSpawnInfo(XTeamEnum nTeamEnum)
	{
		return null;
	}

	[Token(Token = "0x6001EF5")]
	[Address(RVA = "0x1685964", Offset = "0x1685964", VA = "0x1685964")]
	public XSpawnInfo GetPointObjectSpawnInfo(int nIndex)
	{
		return null;
	}

	[Token(Token = "0x6001EF7")]
	[Address(RVA = "0x1685A28", Offset = "0x1685A28", VA = "0x1685A28")]
	public int DropObjectCount(int groupIndex)
	{
		return default(int);
	}

	[Token(Token = "0x6001EF9")]
	[Address(RVA = "0x1685A5C", Offset = "0x1685A5C", VA = "0x1685A5C")]
	public int GetDropObjectCount(List<int> spawnIDList)
	{
		return default(int);
	}

	[Token(Token = "0x6001EFA")]
	[Address(RVA = "0x1685B70", Offset = "0x1685B70", VA = "0x1685B70")]
	private XModuleEntity CreateNPC(int nCharID, Vector3 vPos, Vector3 vRot)
	{
		return null;
	}

	[Token(Token = "0x6001EFB")]
	[Address(RVA = "0x1685D10", Offset = "0x1685D10", VA = "0x1685D10")]
	private XModuleEntity CreateUseSkillNPC(int nCharID, Vector3 vPos, Vector3 vRot)
	{
		return null;
	}

	[Token(Token = "0x6001EFC")]
	[Address(RVA = "0x1685EBC", Offset = "0x1685EBC", VA = "0x1685EBC")]
	private XModuleEntity CreateLevelActor(int nCharID, int lev, Vector3 vPos, Vector3 vRot, XTeamEnum team)
	{
		return null;
	}

	[Token(Token = "0x6001EFD")]
	[Address(RVA = "0x1686188", Offset = "0x1686188", VA = "0x1686188")]
	private XModuleEntity CreateNetLevelActor_Master(int nCharID, int lev, Vector3 vPos, Vector3 vRot, XTeamEnum team)
	{
		return null;
	}

	[Token(Token = "0x6001EFE")]
	[Address(RVA = "0x168644C", Offset = "0x168644C", VA = "0x168644C")]
	private XModuleEntity CreateNetLevelActor_Client(GameObject go, int nCharID, int lev, XTeamEnum team)
	{
		return null;
	}

	[Token(Token = "0x6001EFF")]
	[Address(RVA = "0x16866B8", Offset = "0x16866B8", VA = "0x16866B8")]
	private XModuleEntity CreateLevelWall(int nCharID, Vector3 vPos, Vector3 vRot)
	{
		return null;
	}

	[Token(Token = "0x6001F00")]
	[Address(RVA = "0x1686934", Offset = "0x1686934", VA = "0x1686934")]
	private XModuleEntity CreateLevelMapObject(int nCharID, int lev, Vector3 vPos, Vector3 vRot)
	{
		return null;
	}

	[Token(Token = "0x6001F01")]
	[Address(RVA = "0x1686AB0", Offset = "0x1686AB0", VA = "0x1686AB0")]
	private XModuleEntity CreateDropObject(int groupIndex, int nCharID, Vector3 vPos, Vector3 vRot)
	{
		return null;
	}

	[Token(Token = "0x6001F02")]
	[Address(RVA = "0x1686C08", Offset = "0x1686C08", VA = "0x1686C08")]
	private XModuleEntity CreatePointObject(int nCharID, int nDropObjectIndex, Vector3 vPos, Vector3 vRot)
	{
		return null;
	}

	[Token(Token = "0x6001F03")]
	[Address(RVA = "0x1686D6C", Offset = "0x1686D6C", VA = "0x1686D6C")]
	private void CreateMyPlayer(XModuleActor.CreationDesc desc, Vector3 vPos, Vector3 vRot, bool isReJoin = false)
	{
	}

	[Token(Token = "0x6001F04")]
	[Address(RVA = "0x1687774", Offset = "0x1687774", VA = "0x1687774")]
	private void CreateNetMonster(XModuleActor.CreationDesc desc, Vector3 vPos, Vector3 vRot)
	{
	}

	[Token(Token = "0x6001F05")]
	[Address(RVA = "0x1687234", Offset = "0x1687234", VA = "0x1687234")]
	private void SetUpCustomAutoTargeting(XModuleActor.CreationDesc desc, XModuleEntity me)
	{
	}

	[Token(Token = "0x6001F06")]
	[Address(RVA = "0x16878A8", Offset = "0x16878A8", VA = "0x16878A8")]
	private void SetUpComboSkillCustomAutoTargetingSetup(Dictionary<int, bool> autotargetingSetUP)
	{
	}

	[Token(Token = "0x6001F07")]
	[Address(RVA = "0x1687DF8", Offset = "0x1687DF8", VA = "0x1687DF8")]
	private XModuleEntity CreateAIPlayer(XModuleActor.CreationDesc desc, Vector3 vPos, Vector3 vRot)
	{
		return null;
	}

	[Token(Token = "0x6001F08")]
	[Address(RVA = "0x1687FC4", Offset = "0x1687FC4", VA = "0x1687FC4")]
	private XModuleEntity CreateMyPlayerLocal(XModuleActor.CreationDesc desc, Vector3 vPos, Vector3 vRot)
	{
		return null;
	}

	[Token(Token = "0x6001F09")]
	[Address(RVA = "0x1688540", Offset = "0x1688540", VA = "0x1688540")]
	public XModuleEntity CreateLobbyPlayer(XModuleActor.CreationDesc actorCreationDesc, XModuleLobbyUI.LobbyCharCreationDesc lobbyCharCreationDesc)
	{
		return null;
	}

	[Token(Token = "0x6001F0A")]
	[Address(RVA = "0x168861C", Offset = "0x168861C", VA = "0x168861C")]
	public XModuleEntity CreateLobbySkinPlayer(XModuleActor.CreationDesc actorCreationDesc, XModuleLobbyUI.LobbyCharCreationDesc lobbyCharCreationDesc)
	{
		return null;
	}

	[Token(Token = "0x6001F0B")]
	[Address(RVA = "0x16886F8", Offset = "0x16886F8", VA = "0x16886F8")]
	public XModuleEntity CreateResultPlayer(XModuleActor.CreationDesc desc)
	{
		return null;
	}

	[Token(Token = "0x6001F0C")]
	[Address(RVA = "0x16887CC", Offset = "0x16887CC", VA = "0x16887CC")]
	public XModuleEntity CreateModelPreview(XModuleActor.CreationDesc desc)
	{
		return null;
	}

	[Token(Token = "0x6001F0D")]
	[Address(RVA = "0x16888A0", Offset = "0x16888A0", VA = "0x16888A0")]
	public XModuleEntity SetupNetPlayer(GameObject go, XModuleActor.CreationDesc desc)
	{
		return null;
	}

	[Token(Token = "0x6001F0E")]
	[Address(RVA = "0x1688AFC", Offset = "0x1688AFC", VA = "0x1688AFC")]
	public void SpawnMyPlayer(XModuleActor.CreationDesc desc, int nSpawnIndex = -1)
	{
	}

	[Token(Token = "0x6001F0F")]
	[Address(RVA = "0x1687738", Offset = "0x1687738", VA = "0x1687738")]
	public XModuleEntity SpawnPet(XModuleActor.CreationDesc desc, Vector3 position, Vector3 direction, XModuleEntity playerMe)
	{
		return null;
	}

	[Token(Token = "0x6001F10")]
	[Address(RVA = "0x1688C68", Offset = "0x1688C68", VA = "0x1688C68")]
	private XModuleEntity CreatePet(XModuleActor.CreationDesc desc, Vector3 vPos, Vector3 vRot, XModuleEntity playerMe)
	{
		return null;
	}

	[Token(Token = "0x6001F11")]
	[Address(RVA = "0x1688D98", Offset = "0x1688D98", VA = "0x1688D98")]
	public XModuleEntity SpawnAIPlayer(XModuleActor.CreationDesc desc, int nSpawnIndex = -1)
	{
		return null;
	}

	[Token(Token = "0x6001F12")]
	[Address(RVA = "0x1688F08", Offset = "0x1688F08", VA = "0x1688F08")]
	public void SpawnMyPlayer(XModuleActor.CreationDesc desc, Vector3 pos, Vector3 dir, bool isReJoin = false)
	{
	}

	[Token(Token = "0x6001F13")]
	[Address(RVA = "0x1688F44", Offset = "0x1688F44", VA = "0x1688F44")]
	public XModuleEntity SpawnMyPlayerLocal(XModuleActor.CreationDesc desc, Vector3 pos, Vector3 dir)
	{
		return null;
	}

	[Token(Token = "0x6001F14")]
	[Address(RVA = "0x1688F7C", Offset = "0x1688F7C", VA = "0x1688F7C")]
	public XModuleEntity SpawnNPC(int charId, Vector3 position, Vector3 direction)
	{
		return null;
	}

	[Token(Token = "0x6001F15")]
	[Address(RVA = "0x1688FB4", Offset = "0x1688FB4", VA = "0x1688FB4")]
	public XModuleEntity SpawnUseSkillNPC(int charId, Vector3 position, Vector3 direction)
	{
		return null;
	}

	[Token(Token = "0x6001F16")]
	[Address(RVA = "0x1688FEC", Offset = "0x1688FEC", VA = "0x1688FEC")]
	public XModuleEntity SpawnDropObject(int groupIndex, int charId, Vector3 position, Vector3 direction)
	{
		return null;
	}

	[Token(Token = "0x6001F17")]
	[Address(RVA = "0x1689028", Offset = "0x1689028", VA = "0x1689028")]
	public bool IsRecentlyRemovedDropObject(int spawnID)
	{
		return default(bool);
	}

	[Token(Token = "0x6001F18")]
	[Address(RVA = "0x1689088", Offset = "0x1689088", VA = "0x1689088")]
	public XModuleEntity SpawnDropObject(int spawnID, int charId, int groupIndex)
	{
		return null;
	}

	[Token(Token = "0x6001F19")]
	[Address(RVA = "0x1689280", Offset = "0x1689280", VA = "0x1689280")]
	public void SpawnPointObject(int charId, int nPointObjectIndex = -1)
	{
	}

	[Token(Token = "0x6001F1A")]
	[Address(RVA = "0x1689428", Offset = "0x1689428", VA = "0x1689428")]
	public void DestroyPointObject(int excludeIndex = -1)
	{
	}

	[Token(Token = "0x6001F1B")]
	[Address(RVA = "0x168966C", Offset = "0x168966C", VA = "0x168966C")]
	public void DestroyPointObject(GameObject goPointObject)
	{
	}

	[Token(Token = "0x6001F1C")]
	[Address(RVA = "0x1689840", Offset = "0x1689840", VA = "0x1689840")]
	public void DestroyDropObject(XModuleEntity dropObject)
	{
	}

	[Token(Token = "0x6001F1D")]
	[Address(RVA = "0x1689A04", Offset = "0x1689A04", VA = "0x1689A04")]
	public XModuleEntity SpawnNetLevelActor_Master(int id, int lev, Vector3 position, Vector3 rotation, XTeamEnum team)
	{
		return null;
	}

	[Token(Token = "0x6001F1E")]
	[Address(RVA = "0x1689B70", Offset = "0x1689B70", VA = "0x1689B70")]
	public XModuleEntity SpawnNetLevelActor_Client(GameObject go, int nCharID, int lev, XTeamEnum team)
	{
		return null;
	}

	[Token(Token = "0x6001F1F")]
	[Address(RVA = "0x1689CB0", Offset = "0x1689CB0", VA = "0x1689CB0")]
	public XModuleEntity SpawnLevelActor(int id, int lev, Vector3 position, Vector3 rotation, XTeamEnum team)
	{
		return null;
	}

	[Token(Token = "0x6001F20")]
	[Address(RVA = "0x1689E50", Offset = "0x1689E50", VA = "0x1689E50")]
	public XModuleEntity SpawnLevelMapObject(int id, int lev, Vector3 position, Vector3 rotation)
	{
		return null;
	}

	[Token(Token = "0x6001F21")]
	[Address(RVA = "0x1689F6C", Offset = "0x1689F6C", VA = "0x1689F6C")]
	public XModuleEntity SpawnLevelWall(int id, Vector3 position, Vector3 rotation)
	{
		return null;
	}

	[Token(Token = "0x6001F22")]
	[Address(RVA = "0x168A084", Offset = "0x168A084", VA = "0x168A084")]
	public void SpawnNetMonster(XModuleActor.CreationDesc desc, int nSpawnIndex = -1)
	{
	}

	[Token(Token = "0x6001F23")]
	[Address(RVA = "0x168A0EC", Offset = "0x168A0EC", VA = "0x168A0EC")]
	private Vector3 GetRespawnPos(bool bRandomSpawn)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6001F24")]
	[Address(RVA = "0x168A228", Offset = "0x168A228", VA = "0x168A228")]
	public Vector3 GetTeamRespawnPos(XTeamEnum nTeamEnum)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6001F25")]
	[Address(RVA = "0x168A358", Offset = "0x168A358", VA = "0x168A358")]
	private void RespawnMyPlayerImpl(Vector3 vRespawnPos)
	{
	}

	[Token(Token = "0x6001F26")]
	[Address(RVA = "0x168A45C", Offset = "0x168A45C", VA = "0x168A45C")]
	private void RespawnActor(XModuleActor actor, Vector3 respawnPos, bool notFullHp = false)
	{
	}

	[Token(Token = "0x6001F27")]
	[Address(RVA = "0x168A700", Offset = "0x168A700", VA = "0x168A700")]
	public void RespawnPet(XModuleActor actor, Vector3 respawnPos)
	{
	}

	[Token(Token = "0x6001F28")]
	[Address(RVA = "0x168A78C", Offset = "0x168A78C", VA = "0x168A78C")]
	public void RevivePlayer(XModuleActor actor, Vector3 revivePos, bool notFullHp = false)
	{
	}

	[Token(Token = "0x6001F29")]
	[Address(RVA = "0x168A7B8", Offset = "0x168A7B8", VA = "0x168A7B8")]
	public void RespawnMyPlayer(XTeamEnum nTeamEnum)
	{
	}

	[Token(Token = "0x6001F2A")]
	[Address(RVA = "0x168A7EC", Offset = "0x168A7EC", VA = "0x168A7EC")]
	public void RespawnMyPlayer()
	{
	}

	[Token(Token = "0x6001F2B")]
	[Address(RVA = "0x168A848", Offset = "0x168A848", VA = "0x168A848")]
	public void RespawnActor(XModuleActor moduleActor, XTeamEnum nTeamEnum)
	{
	}

	[Token(Token = "0x6001F2C")]
	[Address(RVA = "0x168A890", Offset = "0x168A890", VA = "0x168A890")]
	public void RespawnMyPlayer(bool bRandomSpawn)
	{
	}

	[Token(Token = "0x6001F2D")]
	[Address(RVA = "0x168A8C4", Offset = "0x168A8C4", VA = "0x168A8C4")]
	public void RespawnMyPlayer(int nSpawnIndex)
	{
	}

	[Token(Token = "0x6001F2E")]
	[Address(RVA = "0x168A904", Offset = "0x168A904", VA = "0x168A904")]
	public NetData_DropObjectSpawnedInfo[] DropObjectSpawnedInfoToNetData()
	{
		return null;
	}

	[Token(Token = "0x6001F2F")]
	[Address(RVA = "0x168A930", Offset = "0x168A930", VA = "0x168A930")]
	public void ChangeMyPlayer()
	{
	}

	[Token(Token = "0x6001F30")]
	[Address(RVA = "0x168ACD4", Offset = "0x168ACD4", VA = "0x168ACD4")]
	public void RepositionRandomMyPlayer()
	{
	}

	[Token(Token = "0x6001F31")]
	[Address(RVA = "0x168ADDC", Offset = "0x168ADDC", VA = "0x168ADDC")]
	public void RepositionMyPlayer(int nSpawnIndex)
	{
	}

	[Token(Token = "0x6001F32")]
	[Address(RVA = "0x168AF10", Offset = "0x168AF10", VA = "0x168AF10")]
	public void RepositionMyPlayer(XTeamEnum nTeam, int nSpawnIndex)
	{
	}

	[Token(Token = "0x6001F33")]
	[Address(RVA = "0x168B04C", Offset = "0x168B04C", VA = "0x168B04C")]
	public void RepositionPlayer(GameObject goPlayer, XTeamEnum nTeam, int nSpawnIndex)
	{
	}

	[Token(Token = "0x6001F34")]
	[Address(RVA = "0x1687690", Offset = "0x1687690", VA = "0x1687690")]
	public Vector3 GetPetPosition(Vector3 position)
	{
		return default(Vector3);
	}
}
