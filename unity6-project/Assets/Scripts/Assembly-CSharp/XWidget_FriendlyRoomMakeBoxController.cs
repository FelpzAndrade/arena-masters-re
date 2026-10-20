using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000F88")]
public class XWidget_FriendlyRoomMakeBoxController
{
	[Token(Token = "0x4005203")]
	[FieldOffset(Offset = "0x8")]
	private List<GameModeInstanceInfo> m_modeInstanceInfoList;

	[Token(Token = "0x4005204")]
	[FieldOffset(Offset = "0xC")]
	private int m_selectedModeIndex;

	[Token(Token = "0x4005205")]
	[FieldOffset(Offset = "0x10")]
	private GameModeInstanceInfo m_selectedModeInfo;

	[Token(Token = "0x4005206")]
	[FieldOffset(Offset = "0x14")]
	private List<CSSectorInfo> m_sectorInfoList;

	[Token(Token = "0x4005207")]
	[FieldOffset(Offset = "0x18")]
	private int m_selectedSectorIndex;

	[Token(Token = "0x4005208")]
	[FieldOffset(Offset = "0x1C")]
	private CSSectorInfo m_selectedSectorInfo;

	[Token(Token = "0x4005209")]
	[FieldOffset(Offset = "0x20")]
	private bool m_isSpectatorMode;

	[Token(Token = "0x400520A")]
	[FieldOffset(Offset = "0x24")]
	private List<string> roomNameExampleList;

	[Token(Token = "0x17000EB9")]
	public GameModeInstanceInfo SelectedModeInfo
	{
		[Token(Token = "0x6007390")]
		[Address(RVA = "0x142F96C", Offset = "0x142F96C", VA = "0x142F96C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000EBA")]
	public CSSectorInfo SelectedSectorInfo
	{
		[Token(Token = "0x6007391")]
		[Address(RVA = "0x142F974", Offset = "0x142F974", VA = "0x142F974")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000EBB")]
	public string SelectedModeName
	{
		[Token(Token = "0x6007392")]
		[Address(RVA = "0x142E0CC", Offset = "0x142E0CC", VA = "0x142E0CC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000EBC")]
	public string SelectedSectorName
	{
		[Token(Token = "0x6007393")]
		[Address(RVA = "0x142E0F0", Offset = "0x142E0F0", VA = "0x142E0F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000EBD")]
	public bool IsSpectatorMode
	{
		[Token(Token = "0x6007394")]
		[Address(RVA = "0x142F97C", Offset = "0x142F97C", VA = "0x142F97C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6007395")]
		[Address(RVA = "0x142FAF0", Offset = "0x142FAF0", VA = "0x142FAF0")]
		set
		{
		}
	}

	[Token(Token = "0x600738F")]
	[Address(RVA = "0x142DEB4", Offset = "0x142DEB4", VA = "0x142DEB4")]
	public XWidget_FriendlyRoomMakeBoxController()
	{
	}

	[Token(Token = "0x6007396")]
	[Address(RVA = "0x142E314", Offset = "0x142E314", VA = "0x142E314")]
	public void BuildGameModes(ProtoInfoManager_GameModeInstance gameModeInstanceInfoManager)
	{
	}

	[Token(Token = "0x6007397")]
	[Address(RVA = "0x142E65C", Offset = "0x142E65C", VA = "0x142E65C")]
	public void BuildSectorList(CSProtoInfoManager_Sector sectorInfoManager)
	{
	}

	[Token(Token = "0x6007398")]
	[Address(RVA = "0x142E850", Offset = "0x142E850", VA = "0x142E850")]
	public void BuildRoomNameExampleList()
	{
	}

	[Token(Token = "0x6007399")]
	[Address(RVA = "0x142E5B4", Offset = "0x142E5B4", VA = "0x142E5B4")]
	public void SelectMode(int modeIndex)
	{
	}

	[Token(Token = "0x600739A")]
	[Address(RVA = "0x142EF2C", Offset = "0x142EF2C", VA = "0x142EF2C")]
	public void SelectRightMode()
	{
	}

	[Token(Token = "0x600739B")]
	[Address(RVA = "0x142ED44", Offset = "0x142ED44", VA = "0x142ED44")]
	public void SelectLeftMode()
	{
	}

	[Token(Token = "0x600739C")]
	[Address(RVA = "0x142E7A8", Offset = "0x142E7A8", VA = "0x142E7A8")]
	public void SelectSector(int sectorIndex)
	{
	}

	[Token(Token = "0x600739D")]
	[Address(RVA = "0x142F0F8", Offset = "0x142F0F8", VA = "0x142F0F8")]
	public void SelectRightSector()
	{
	}

	[Token(Token = "0x600739E")]
	[Address(RVA = "0x142F014", Offset = "0x142F014", VA = "0x142F014")]
	public void SelectLeftSector()
	{
	}

	[Token(Token = "0x600739F")]
	[Address(RVA = "0x142E9A8", Offset = "0x142E9A8", VA = "0x142E9A8")]
	public string MakeRandomRoomName()
	{
		return null;
	}
}
