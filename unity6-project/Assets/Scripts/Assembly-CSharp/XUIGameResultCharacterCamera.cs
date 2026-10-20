using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D7B")]
public class XUIGameResultCharacterCamera : MonoBehaviour
{
	[Token(Token = "0x4004583")]
	private const int InitIndex = -1;

	[Token(Token = "0x4004584")]
	[FieldOffset(Offset = "0xC")]
	public Camera CharacterCamera;

	[Token(Token = "0x4004585")]
	[FieldOffset(Offset = "0x10")]
	public TweenPosition m_enterTween;

	[Token(Token = "0x4004586")]
	[FieldOffset(Offset = "0x14")]
	public List<Transform> m_attachCharacterObjectList;

	[Token(Token = "0x4004587")]
	[FieldOffset(Offset = "0x18")]
	public List<TweenPosition> m_attachCharacterTweenPos;

	[Token(Token = "0x4004588")]
	[FieldOffset(Offset = "0x1C")]
	public List<Transform> m_duel_attachCharacterObjectList;

	[Token(Token = "0x4004589")]
	[FieldOffset(Offset = "0x20")]
	public List<TweenPosition> m_duel_attachCharacterTweenPos;

	[Token(Token = "0x400458A")]
	[FieldOffset(Offset = "0x24")]
	private int m_duelATeamCharacterCount;

	[Token(Token = "0x400458B")]
	[FieldOffset(Offset = "0x28")]
	private int m_duelBTeamCharacterCount;

	[Token(Token = "0x400458C")]
	[FieldOffset(Offset = "0x2C")]
	private XGameModeType m_gameMode;

	[Token(Token = "0x400458D")]
	[FieldOffset(Offset = "0x30")]
	private Action m_animationEndAction;

	[Token(Token = "0x400458E")]
	[FieldOffset(Offset = "0x34")]
	private List<XModuleActor.CreationDesc> m_creationDescriptionList;

	[Token(Token = "0x400458F")]
	[FieldOffset(Offset = "0x38")]
	private List<XModuleEntity> m_createdDirectionModuleEntity;

	[Token(Token = "0x4004590")]
	[FieldOffset(Offset = "0x3C")]
	private List<XModuleEntity> m_createdDirectionPetModuleEntity;

	[Token(Token = "0x4004591")]
	[FieldOffset(Offset = "0x40")]
	private List<CSWinlose> m_xPlayerWinLoseResultList;

	[Token(Token = "0x4004592")]
	[FieldOffset(Offset = "0x44")]
	private List<CSWinlose> m_xPetWinLoseResultList;

	[Token(Token = "0x4004593")]
	[FieldOffset(Offset = "0x48")]
	private XPlayer myPlayer;

	[Token(Token = "0x4004594")]
	[FieldOffset(Offset = "0x4C")]
	private int myPlayerAttachIndex;

	[Token(Token = "0x4004595")]
	[FieldOffset(Offset = "0x50")]
	public Transform ResultPlayerCharacterRoot;

	[Token(Token = "0x4004596")]
	[FieldOffset(Offset = "0x54")]
	private float zoomInTime;

	[Token(Token = "0x4004597")]
	[FieldOffset(Offset = "0x58")]
	private XTeamEnum m_winningTeam;

	[Token(Token = "0x4004598")]
	[FieldOffset(Offset = "0x5C")]
	private bool m_isHasIndividualMvp;

	[Token(Token = "0x4004599")]
	[FieldOffset(Offset = "0x60")]
	private int m_individualMvpIndex;

	[Token(Token = "0x400459A")]
	[FieldOffset(Offset = "0x64")]
	private int m_individualMvpPetIndex;

	[Token(Token = "0x400459B")]
	[FieldOffset(Offset = "0x68")]
	private Action m_onEnterComplete;

	[Token(Token = "0x60062ED")]
	[Address(RVA = "0x1A5BF08", Offset = "0x1A5BF08", VA = "0x1A5BF08")]
	public XUIGameResultCharacterCamera()
	{
	}

	[Token(Token = "0x60062EE")]
	[Address(RVA = "0x1A5C104", Offset = "0x1A5C104", VA = "0x1A5C104")]
	private void UpdateScale()
	{
	}

	[Token(Token = "0x60062EF")]
	[Address(RVA = "0x1A5C3A4", Offset = "0x1A5C3A4", VA = "0x1A5C3A4")]
	private void Init(XTeamEnum winningTeam, XGameModeType modeType, XPlayer myPlayer)
	{
	}

	[Token(Token = "0x60062F0")]
	[Address(RVA = "0x1A5C708", Offset = "0x1A5C708", VA = "0x1A5C708")]
	public void InitForIndivisualMode(XTeamEnum winningTeam, XGameModeType modeType, XPlayer myPlayer, List<XPlayer> sortedTotalPlayerList, List<XModuleEntity> playerMoludeEntityList)
	{
	}

	[Token(Token = "0x60062F1")]
	[Address(RVA = "0x1A5D09C", Offset = "0x1A5D09C", VA = "0x1A5D09C")]
	private void RecordMVPPlayer(List<XPlayer> sortedTotalPlayerList)
	{
	}

	[Token(Token = "0x60062F2")]
	[Address(RVA = "0x1A5D22C", Offset = "0x1A5D22C", VA = "0x1A5D22C")]
	public void InitForTeamMode(XTeamEnum winningTeam, XGameModeType modeType, XPlayer myPlayer, List<XPlayer> ATeamInversePlayerList, List<XPlayer> BTeamPlayerList, List<XModuleEntity> playerMoludeEntityList)
	{
	}

	[Token(Token = "0x60062F3")]
	[Address(RVA = "0x1A5D6A8", Offset = "0x1A5D6A8", VA = "0x1A5D6A8")]
	public void InitForDuelMode(XTeamEnum winningTeam, XGameModeType modeType, XPlayer myPlayer, XPlayer ATeamPlayer, XPlayer BTeamPlayer)
	{
	}

	[Token(Token = "0x60062F4")]
	[Address(RVA = "0x1A5D910", Offset = "0x1A5D910", VA = "0x1A5D910")]
	private void CreateModelForDirection(bool isTeamMode)
	{
	}

	[Token(Token = "0x60062F5")]
	[Address(RVA = "0x1A5DFB0", Offset = "0x1A5DFB0", VA = "0x1A5DFB0")]
	private void CreateModelForDirection_Duel(XTeamEnum team)
	{
	}

	[Token(Token = "0x60062F6")]
	[Address(RVA = "0x1A5C894", Offset = "0x1A5C894", VA = "0x1A5C894")]
	private void FineMyPlayerIndex_Indivisual(List<XPlayer> sortedTotalPlayerList, out int myPlayerAttachIndex)
	{
		myPlayerAttachIndex = default;
	}

	[Token(Token = "0x60062F7")]
	[Address(RVA = "0x1A5D3D0", Offset = "0x1A5D3D0", VA = "0x1A5D3D0")]
	private void FineMyPlayerIndex_Team(List<XPlayer> ATeamInversePlayerList, List<XPlayer> BTeamPlayerList, out int myPlayerAttachIndex)
	{
		myPlayerAttachIndex = default;
	}

	[Token(Token = "0x60062F8")]
	[Address(RVA = "0x1A5D82C", Offset = "0x1A5D82C", VA = "0x1A5D82C")]
	private void FineMyPlayerIndex_Duel(out int myPlayerAttachIndex)
	{
		myPlayerAttachIndex = default;
	}

	[Token(Token = "0x60062F9")]
	[Address(RVA = "0x1A5E24C", Offset = "0x1A5E24C", VA = "0x1A5E24C")]
	private XModuleEntity FindModuleEntity(string photonName, List<XModuleEntity> playerMoludeEntityList)
	{
		return null;
	}

	[Token(Token = "0x60062FA")]
	[Address(RVA = "0x1A5CA00", Offset = "0x1A5CA00", VA = "0x1A5CA00")]
	private void SetCreationDescriptionList(List<XPlayer> xPlayerList, List<XModuleEntity> playerMoludeEntityList)
	{
	}

	[Token(Token = "0x60062FB")]
	[Address(RVA = "0x1A5D880", Offset = "0x1A5D880", VA = "0x1A5D880")]
	private void SetCreationDescriptionList_Duel(XPlayer xPlayer)
	{
	}

	[Token(Token = "0x60062FC")]
	[Address(RVA = "0x1A5E4FC", Offset = "0x1A5E4FC", VA = "0x1A5E4FC")]
	private void SetDuelInfo(int charID, int skinID, XTeamEnum team, int petId = 0)
	{
	}

	[Token(Token = "0x60062FD")]
	[Address(RVA = "0x1A5E6CC", Offset = "0x1A5E6CC", VA = "0x1A5E6CC")]
	public void StartTween(Action onEnterComplete)
	{
	}

	[Token(Token = "0x60062FE")]
	[Address(RVA = "0x1A5E738", Offset = "0x1A5E738", VA = "0x1A5E738")]
	public void OnEnterComplete()
	{
	}

	[Token(Token = "0x60062FF")]
	[Address(RVA = "0x1A5E764", Offset = "0x1A5E764", VA = "0x1A5E764")]
	private void Start()
	{
	}

	[Token(Token = "0x6006300")]
	[Address(RVA = "0x1A5E9C4", Offset = "0x1A5E9C4", VA = "0x1A5E9C4")]
	public void Hide()
	{
	}

	[Token(Token = "0x6006301")]
	[Address(RVA = "0x1A5C3E0", Offset = "0x1A5C3E0", VA = "0x1A5C3E0")]
	private void ClearLists()
	{
	}

	[Token(Token = "0x6006302")]
	[Address(RVA = "0x1A5C518", Offset = "0x1A5C518", VA = "0x1A5C518")]
	private void InitAttachCharacterTweenPos()
	{
	}

	[Token(Token = "0x6006303")]
	[Address(RVA = "0x1A5EC4C", Offset = "0x1A5EC4C", VA = "0x1A5EC4C")]
	public void StartAttachCharacterTweenPos()
	{
	}

	[Token(Token = "0x6006304")]
	[Address(RVA = "0x1A5EC68", Offset = "0x1A5EC68", VA = "0x1A5EC68")]
	private void CharacterMoveLeftStart(List<TweenPosition> attachCharacterTweenPos)
	{
	}

	[Token(Token = "0x6006305")]
	[Address(RVA = "0x1A5ED94", Offset = "0x1A5ED94", VA = "0x1A5ED94")]
	public void StartPlayerCharacterZoomIn()
	{
	}

	[Token(Token = "0x6006306")]
	[Address(RVA = "0x1A5EDB0", Offset = "0x1A5EDB0", VA = "0x1A5EDB0")]
	private void AttachCharacterObjectTweenStart(List<Transform> attachCharacterObjectList)
	{
	}

	[Token(Token = "0x6006307")]
	[Address(RVA = "0x1A5DACC", Offset = "0x1A5DACC", VA = "0x1A5DACC")]
	private void CreateModel(XModuleActor.CreationDesc creationDesc, Transform AttachCharacterObject)
	{
	}

	[Token(Token = "0x6006308")]
	[Address(RVA = "0x1A5E768", Offset = "0x1A5E768", VA = "0x1A5E768")]
	public void PlayResultIdleAnimation()
	{
	}

	[Token(Token = "0x6006309")]
	[Address(RVA = "0x1A5FF34", Offset = "0x1A5FF34", VA = "0x1A5FF34")]
	public void PlayResultAnimation()
	{
	}

	[Token(Token = "0x600630A")]
	[Address(RVA = "0x1A5EA04", Offset = "0x1A5EA04", VA = "0x1A5EA04")]
	private void DestoryModels()
	{
	}

	[Token(Token = "0x600630B")]
	[Address(RVA = "0x1A603F4", Offset = "0x1A603F4", VA = "0x1A603F4")]
	private void _003CInitForIndivisualMode_003Em__312()
	{
	}

	[Token(Token = "0x600630C")]
	[Address(RVA = "0x1A603FC", Offset = "0x1A603FC", VA = "0x1A603FC")]
	private void _003CInitForTeamMode_003Em__313()
	{
	}

	[Token(Token = "0x600630D")]
	[Address(RVA = "0x1A60404", Offset = "0x1A60404", VA = "0x1A60404")]
	private void _003CInitForDuelMode_003Em__314()
	{
	}
}
