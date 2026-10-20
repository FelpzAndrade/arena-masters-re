using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000CD4")]
public class XWidget_CustomRoomMaker
{
	[Token(Token = "0x4004150")]
	[FieldOffset(Offset = "0x8")]
	private List<GameModeInstanceInfo> m_modeInstanceInfoShowList;

	[Token(Token = "0x4004151")]
	[FieldOffset(Offset = "0xC")]
	private int m_selectedModeIndex;

	[Token(Token = "0x4004152")]
	[FieldOffset(Offset = "0x10")]
	private GameModeInstanceInfo m_selectedModeInfo;

	[Token(Token = "0x4004153")]
	[FieldOffset(Offset = "0x14")]
	private List<CSSectorInfo> m_sectorInfoList;

	[Token(Token = "0x4004154")]
	[FieldOffset(Offset = "0x18")]
	private int m_selectedSectorIndex;

	[Token(Token = "0x4004155")]
	[FieldOffset(Offset = "0x1C")]
	private CSSectorInfo m_selectedSectorInfo;

	[Token(Token = "0x4004156")]
	[FieldOffset(Offset = "0x20")]
	private bool m_isSpectatorMode;

	[Token(Token = "0x4004157")]
	[FieldOffset(Offset = "0x24")]
	private List<string> roomNameExampleList;

	[Token(Token = "0x4004158")]
	[FieldOffset(Offset = "0x0")]
	private static HashSet<XGameModeType> hsCustomGameEnableMode;

	[Token(Token = "0x4004159")]
	[FieldOffset(Offset = "0x28")]
	private int CustomKill__BackingField;

	[Token(Token = "0x400415A")]
	[FieldOffset(Offset = "0x2C")]
	private int CustomTime__BackingField;

	[Token(Token = "0x400415B")]
	[FieldOffset(Offset = "0x30")]
	private Bit32Flags CustomSetting__BackingField;

	[Token(Token = "0x400415C")]
	[FieldOffset(Offset = "0x34")]
	private bool IsPrivate__BackingField;

	[Token(Token = "0x400415D")]
	[FieldOffset(Offset = "0x35")]
	private bool IsCombatPowerCorrection__BackingField;

	[Token(Token = "0x400415E")]
	[FieldOffset(Offset = "0x36")]
	private bool IsAbleCustom__BackingField;

	[Token(Token = "0x17000CDF")]
	public int CustomKill
	{
		[Token(Token = "0x6005C7C")]
		[Address(RVA = "0x15EE7F8", Offset = "0x15EE7F8", VA = "0x15EE7F8")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6005C7D")]
		[Address(RVA = "0x15EE800", Offset = "0x15EE800", VA = "0x15EE800")]
		private set
		{
		}
	}

	[Token(Token = "0x17000CE0")]
	public int CustomTime
	{
		[Token(Token = "0x6005C7E")]
		[Address(RVA = "0x15EE808", Offset = "0x15EE808", VA = "0x15EE808")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6005C7F")]
		[Address(RVA = "0x15EE810", Offset = "0x15EE810", VA = "0x15EE810")]
		private set
		{
		}
	}

	[Token(Token = "0x17000CE1")]
	public Bit32Flags CustomSetting
	{
		[Token(Token = "0x6005C80")]
		[Address(RVA = "0x15EE818", Offset = "0x15EE818", VA = "0x15EE818")]
		get
		{
			return null;
		}
		[Token(Token = "0x6005C81")]
		[Address(RVA = "0x15EE820", Offset = "0x15EE820", VA = "0x15EE820")]
		private set
		{
		}
	}

	[Token(Token = "0x17000CE2")]
	public bool IsPrivate
	{
		[Token(Token = "0x6005C82")]
		[Address(RVA = "0x15EE828", Offset = "0x15EE828", VA = "0x15EE828")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6005C83")]
		[Address(RVA = "0x15EE830", Offset = "0x15EE830", VA = "0x15EE830")]
		private set
		{
		}
	}

	[Token(Token = "0x17000CE3")]
	public bool IsCombatPowerCorrection
	{
		[Token(Token = "0x6005C84")]
		[Address(RVA = "0x15EE838", Offset = "0x15EE838", VA = "0x15EE838")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6005C85")]
		[Address(RVA = "0x15EE840", Offset = "0x15EE840", VA = "0x15EE840")]
		private set
		{
		}
	}

	[Token(Token = "0x17000CE4")]
	public bool IsAbleCustom
	{
		[Token(Token = "0x6005C86")]
		[Address(RVA = "0x15EE848", Offset = "0x15EE848", VA = "0x15EE848")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6005C87")]
		[Address(RVA = "0x15EE850", Offset = "0x15EE850", VA = "0x15EE850")]
		private set
		{
		}
	}

	[Token(Token = "0x17000CE5")]
	public int SelectedModeIndex
	{
		[Token(Token = "0x6005C88")]
		[Address(RVA = "0x15EE858", Offset = "0x15EE858", VA = "0x15EE858")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000CE6")]
	public List<GameModeInstanceInfo> ModeInstanceInfos
	{
		[Token(Token = "0x6005C89")]
		[Address(RVA = "0x15EE860", Offset = "0x15EE860", VA = "0x15EE860")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000CE7")]
	public int SelectedMapIndex
	{
		[Token(Token = "0x6005C8A")]
		[Address(RVA = "0x15EE868", Offset = "0x15EE868", VA = "0x15EE868")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000CE8")]
	public List<CSSectorInfo> SectorInfos
	{
		[Token(Token = "0x6005C8B")]
		[Address(RVA = "0x15EE870", Offset = "0x15EE870", VA = "0x15EE870")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000CE9")]
	public GameModeInstanceInfo SelectedModeInfo
	{
		[Token(Token = "0x6005C8D")]
		[Address(RVA = "0x15EE878", Offset = "0x15EE878", VA = "0x15EE878")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000CEA")]
	public CSSectorInfo SelectedSectorInfo
	{
		[Token(Token = "0x6005C8E")]
		[Address(RVA = "0x15EE880", Offset = "0x15EE880", VA = "0x15EE880")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000CEB")]
	public string SelectedModeName
	{
		[Token(Token = "0x6005C8F")]
		[Address(RVA = "0x15EE888", Offset = "0x15EE888", VA = "0x15EE888")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000CEC")]
	public string SelectedSectorName
	{
		[Token(Token = "0x6005C90")]
		[Address(RVA = "0x15EE8AC", Offset = "0x15EE8AC", VA = "0x15EE8AC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000CED")]
	public bool IsSpectatorMode
	{
		[Token(Token = "0x6005C91")]
		[Address(RVA = "0x15EE8D0", Offset = "0x15EE8D0", VA = "0x15EE8D0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6005C92")]
		[Address(RVA = "0x15EE8D8", Offset = "0x15EE8D8", VA = "0x15EE8D8")]
		set
		{
		}
	}

	[Token(Token = "0x6005C7A")]
	[Address(RVA = "0x15EE5B0", Offset = "0x15EE5B0", VA = "0x15EE5B0")]
	public XWidget_CustomRoomMaker()
	{
	}

	[Token(Token = "0x6005C8C")]
	[Address(RVA = "0x15EE664", Offset = "0x15EE664", VA = "0x15EE664")]
	public void Init()
	{
	}

	[Token(Token = "0x6005C93")]
	[Address(RVA = "0x15EE8E0", Offset = "0x15EE8E0", VA = "0x15EE8E0")]
	public void BuildGameModes(ProtoInfoManager_GameModeInstance gameModeInstanceInfoManager)
	{
	}

	[Token(Token = "0x6005C94")]
	[Address(RVA = "0x15EEAD0", Offset = "0x15EEAD0", VA = "0x15EEAD0")]
	public void BuildSectorList(CSProtoInfoManager_Sector sectorInfoManager)
	{
	}

	[Token(Token = "0x6005C95")]
	[Address(RVA = "0x15EEC1C", Offset = "0x15EEC1C", VA = "0x15EEC1C")]
	public void BuildRoomNameExampleList()
	{
	}

	[Token(Token = "0x6005C96")]
	[Address(RVA = "0x15EED74", Offset = "0x15EED74", VA = "0x15EED74")]
	public void SelectMode(int modeIndex)
	{
	}

	[Token(Token = "0x6005C97")]
	[Address(RVA = "0x15EEE1C", Offset = "0x15EEE1C", VA = "0x15EEE1C")]
	public void SelectRightMode()
	{
	}

	[Token(Token = "0x6005C98")]
	[Address(RVA = "0x15EEF4C", Offset = "0x15EEF4C", VA = "0x15EEF4C")]
	public void SelectLeftMode()
	{
	}

	[Token(Token = "0x6005C99")]
	[Address(RVA = "0x15EF07C", Offset = "0x15EF07C", VA = "0x15EF07C")]
	public void SelectSector(int sectorIndex)
	{
	}

	[Token(Token = "0x6005C9A")]
	[Address(RVA = "0x15EF124", Offset = "0x15EF124", VA = "0x15EF124")]
	public void SelectRightSector()
	{
	}

	[Token(Token = "0x6005C9B")]
	[Address(RVA = "0x15EF1D8", Offset = "0x15EF1D8", VA = "0x15EF1D8")]
	public void SelectLeftSector()
	{
	}

	[Token(Token = "0x6005C9C")]
	[Address(RVA = "0x15EF288", Offset = "0x15EF288", VA = "0x15EF288")]
	public string MakeRandomRoomName()
	{
		return null;
	}

	[Token(Token = "0x6005C9D")]
	[Address(RVA = "0x15EF364", Offset = "0x15EF364", VA = "0x15EF364")]
	internal void IncrementKill()
	{
	}

	[Token(Token = "0x6005C9E")]
	[Address(RVA = "0x15EF60C", Offset = "0x15EF60C", VA = "0x15EF60C")]
	internal void DecrementKill()
	{
	}

	[Token(Token = "0x6005C9F")]
	[Address(RVA = "0x15EF47C", Offset = "0x15EF47C", VA = "0x15EF47C")]
	private int MinMaxKill(int setKill)
	{
		return default(int);
	}

	[Token(Token = "0x6005CA0")]
	[Address(RVA = "0x15EF724", Offset = "0x15EF724", VA = "0x15EF724")]
	internal void IncrementTime()
	{
	}

	[Token(Token = "0x6005CA1")]
	[Address(RVA = "0x15EF9CC", Offset = "0x15EF9CC", VA = "0x15EF9CC")]
	internal void DecrementTime()
	{
	}

	[Token(Token = "0x6005CA2")]
	[Address(RVA = "0x15EF83C", Offset = "0x15EF83C", VA = "0x15EF83C")]
	private int MinMaxTime(int setTime)
	{
		return default(int);
	}

	[Token(Token = "0x6005CA3")]
	[Address(RVA = "0x15EFAE4", Offset = "0x15EFAE4", VA = "0x15EFAE4")]
	internal void ChangeCombatPowerCorrection(bool isCorrection)
	{
	}

	[Token(Token = "0x6005CA4")]
	[Address(RVA = "0x15EFB30", Offset = "0x15EFB30", VA = "0x15EFB30")]
	internal void ChangePrivateRoom(bool isPrivate)
	{
	}

	[Token(Token = "0x6005CA5")]
	[Address(RVA = "0x15EFB7C", Offset = "0x15EFB7C", VA = "0x15EFB7C")]
	internal bool IsVisibleCutomGameMode()
	{
		return default(bool);
	}

	[Token(Token = "0x6005CA6")]
	[Address(RVA = "0x15EFC9C", Offset = "0x15EFC9C", VA = "0x15EFC9C")]
	internal void SetAbleCustomOption(bool ableCustom)
	{
	}

	[Token(Token = "0x6005CA7")]
	[Address(RVA = "0x15EFD1C", Offset = "0x15EFD1C", VA = "0x15EFD1C")]
	public bool IsVisibleCombatPowerCorrectionMode()
	{
		return default(bool);
	}

	[Token(Token = "0x6005CA8")]
	[Address(RVA = "0x15EFD30", Offset = "0x15EFD30", VA = "0x15EFD30")]
	public bool IsDisableCombatPowerCorrectionMode()
	{
		return default(bool);
	}

	[Token(Token = "0x6005CA9")]
	[Address(RVA = "0x15EFD64", Offset = "0x15EFD64", VA = "0x15EFD64")]
	internal bool IsCombatPowerCorrectionDefaultOnMode()
	{
		return default(bool);
	}

	[Token(Token = "0x6005CAA")]
	[Address(RVA = "0x15EFD88", Offset = "0x15EFD88", VA = "0x15EFD88")]
	internal void ChangeModeInstance()
	{
	}
}
