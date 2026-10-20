using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;
using UnityEngine;
using XUIEnum;

[Token(Token = "0x2000D0E")]
public class XPanel_GameCommon : MonoBehaviour
{
	[Token(Token = "0x400424F")]
	private const int SKILL_BUTTON_COUNT = 5;

	[Token(Token = "0x4004250")]
	private const int RELIC_SKILL_BUTTON_COUNT = 2;

	[Token(Token = "0x4004251")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public Transform MiniMap;

	[Token(Token = "0x4004252")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly string Path_CommonKill;

	[Token(Token = "0x4004253")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private readonly string Path_scr_caution;

	[Token(Token = "0x4004254")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly string Path_minimap;

	[Token(Token = "0x4004255")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private readonly string Path_charInfo;

	[Token(Token = "0x4004256")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly string Path_roundTripTime;

	[Token(Token = "0x4004257")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private readonly string Path_spectatorTargetMsg;

	[Token(Token = "0x4004258")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly string Path_emoticonMenu;

	[Token(Token = "0x4004259")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private readonly string Path_WelcomeProfileIcon;

	[Token(Token = "0x400425A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private XWidget_CommonKillUI _commonKill;

	[Token(Token = "0x400425B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private GameObject _sprScrCaution;

	[Token(Token = "0x400425C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private XWidget_MiniMap _widget_MiniMap;

	[Token(Token = "0x400425D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private XUICharacterInfo _characterHPBar;

	[Token(Token = "0x400425E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private XWidget_RoudTripTime _roundTripTimeRoot;

	[Token(Token = "0x400425F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private XWidget_SpectatorTargetMsg _spectatorTargetMsg;

	[Token(Token = "0x4004260")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private XWidget_EmoticonMenu _emoticonMenu;

	[Token(Token = "0x4004261")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private XWidget_WelcomeProfileIcon _welcomeProfileIcon;

	[Token(Token = "0x4004262")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private XUIHitCombo m_hitCombo;

	[Token(Token = "0x4004263")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private XUIHUDText m_hudText;

	[Token(Token = "0x4004264")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private XWidget_TagDirection m_ultDirection;

	[Token(Token = "0x4004265")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public GameObject goCharInfoRoot;

	[Token(Token = "0x4004266")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Transform topRightRoot;

	[Token(Token = "0x4004267")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public XWidget_CharacterInfo tagCharInfo;

	[Token(Token = "0x4004268")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Transform hitComboParent;

	[Token(Token = "0x4004269")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public UILabel lblRoomName;

	[Token(Token = "0x400426A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public UILabel lblRoomMaster;

	[Token(Token = "0x400426B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public UILabel lblRoomPassword;

	[Token(Token = "0x400426C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public UI2DSprite sprVignetting;

	[Token(Token = "0x400426D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public GameObject healthBarRoot;

	[Token(Token = "0x400426E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GameObject headBalloonRoot;

	[Token(Token = "0x400426F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public UIGrid gridTopLeft;

	[Token(Token = "0x4004270")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public UILabel lblGoalMessage;

	[Token(Token = "0x4004271")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public UIBasicSprite sprGoalMessageBG;

	[Token(Token = "0x4004272")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public UIGrid goSettingRoot;

	[Token(Token = "0x4004273")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public GameObject btnEmoticon;

	[Token(Token = "0x4004274")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public UIButton pauseButton;

	[Token(Token = "0x4004275")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public GameObject chatButton;

	[Token(Token = "0x4004276")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public UILabel lblClanPartyCount;

	[Token(Token = "0x4004277")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public GameObject sprPauseButtonActive;

	[Token(Token = "0x4004278")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public GameObject sprPauseButtonDisable;

	[Token(Token = "0x4004279")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	public XUIGameRecordsButton btnTopGameRecord;

	[Token(Token = "0x400427A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public XUIGameRecordsButton btnGameRecord;

	[Token(Token = "0x400427B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	public XWidget_TeamInfo teamInfo;

	[Token(Token = "0x400427C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public GameObject BtnFreeSpectator;

	[Token(Token = "0x400427D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	public XUISkill_Character[] CharacterSkillButton;

	[Token(Token = "0x400427E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public XUIUltimateSkill UltSkillButton;

	[Token(Token = "0x400427F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	public XUISkill_Relic RelicSkillButton;

	[Token(Token = "0x4004280")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public Transform ultDirectionParent;

	[Token(Token = "0x4004281")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	public GameObject btnAuto;

	[Token(Token = "0x4004282")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public UISprite sprAutoCombatOn;

	[Token(Token = "0x4004283")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	public UISprite sprAutoCombatOff;

	[Token(Token = "0x4004284")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	protected GameModeInfo m_GameModeInfo;

	[Token(Token = "0x4004285")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	protected XGameData m_GameData;

	[Token(Token = "0x4004286")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	protected CSSectorInfo m_SectorInfo;

	[Token(Token = "0x4004287")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	protected XSectorProperty m_SectorProperty;

	[Token(Token = "0x4004288")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public UIGrid gridMenu;

	[Token(Token = "0x4004289")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	public GameObject goRoomNameRoot;

	[Token(Token = "0x400428A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private UIPanel panel;

	[Token(Token = "0x400428B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	private Queue<XKillMessage> killMassageQueue;

	[Token(Token = "0x400428C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private bool isPossibleKillDirection;

	[Token(Token = "0x400428D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF9")]
	private bool isStartKillMessage;

	[Token(Token = "0x400428E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	private XKillMessage currKillMessage;

	[Token(Token = "0x400428F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public UIWidget widgetBottomLeft;

	[Token(Token = "0x4004290")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
	public UIWidget widgetBottomRight;

	[Token(Token = "0x4004291")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public UIWidget widgetTeamInfo;

	[Token(Token = "0x4004292")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
	public GameObject goTopAnchor;

	[Token(Token = "0x4004293")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private bool isShowPauseMenu;

	[Token(Token = "0x17000D04")]
	public XWidget_CommonKillUI commonKill
	{
		[Token(Token = "0x6005F2F")]
		[Address(RVA = "0xFD09BC", Offset = "0xFD09BC", VA = "0xFD09BC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D05")]
	public GameObject sprScrCaution
	{
		[Token(Token = "0x6005F30")]
		[Address(RVA = "0xFD0B80", Offset = "0xFD0B80", VA = "0xFD0B80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D06")]
	public XWidget_MiniMap widget_MiniMap
	{
		[Token(Token = "0x6005F31")]
		[Address(RVA = "0xFD0D1C", Offset = "0xFD0D1C", VA = "0xFD0D1C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D07")]
	public XUICharacterInfo characterHPBar
	{
		[Token(Token = "0x6005F32")]
		[Address(RVA = "0xFD0F08", Offset = "0xFD0F08", VA = "0xFD0F08")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D08")]
	public XWidget_RoudTripTime roundTripTimeRoot
	{
		[Token(Token = "0x6005F33")]
		[Address(RVA = "0xFD10D4", Offset = "0xFD10D4", VA = "0xFD10D4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D09")]
	public XWidget_SpectatorTargetMsg SpectatorTargetMsg
	{
		[Token(Token = "0x6005F34")]
		[Address(RVA = "0xFD12A0", Offset = "0xFD12A0", VA = "0xFD12A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D0A")]
	public XWidget_EmoticonMenu emoticonMenu
	{
		[Token(Token = "0x6005F35")]
		[Address(RVA = "0xFD146C", Offset = "0xFD146C", VA = "0xFD146C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D0B")]
	public XWidget_WelcomeProfileIcon welcomeProfileIcon
	{
		[Token(Token = "0x6005F36")]
		[Address(RVA = "0xFD1630", Offset = "0xFD1630", VA = "0xFD1630")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6005F2C")]
	[Address(RVA = "0xFD0510", Offset = "0xFD0510", VA = "0xFD0510")]
	public XPanel_GameCommon()
	{
	}

	[Token(Token = "0x6005F2D")]
	[Address(RVA = "0xFD068C", Offset = "0xFD068C", VA = "0xFD068C")]
	public void Final()
	{
	}

	[Token(Token = "0x6005F2E")]
	[Address(RVA = "0xFD07BC", Offset = "0xFD07BC", VA = "0xFD07BC")]
	private void ClearResource()
	{
	}

	[Token(Token = "0x6005F37")]
	[Address(RVA = "0xFD17F4", Offset = "0xFD17F4", VA = "0xFD17F4")]
	public bool isCachedSpectatorTargetMsg()
	{
		return default(bool);
	}

	[Token(Token = "0x6005F38")]
	[Address(RVA = "0xFD18A4", Offset = "0xFD18A4", VA = "0xFD18A4")]
	public void SetOption(GameUIOption targetOption)
	{
	}

	[Token(Token = "0x6005F39")]
	[Address(RVA = "0xFD21AC", Offset = "0xFD21AC", VA = "0xFD21AC")]
	public static bool HasOption(GameUIOption target, GameUIOption checkOption)
	{
		return default(bool);
	}

	[Token(Token = "0x6005F3A")]
	[Address(RVA = "0xFD21C0", Offset = "0xFD21C0", VA = "0xFD21C0")]
	public void SetPanelAlpha(float alpha)
	{
	}

	[Token(Token = "0x6005F3B")]
	[Address(RVA = "0xFD22F0", Offset = "0xFD22F0", VA = "0xFD22F0")]
	private void SetActiveSkillButtonEffect(bool isActive)
	{
	}

	[Token(Token = "0x6005F3C")]
	[Address(RVA = "0xFD2398", Offset = "0xFD2398", VA = "0xFD2398")]
	private void Awake()
	{
	}

	[Token(Token = "0x6005F3D")]
	[Address(RVA = "0xFD2B4C", Offset = "0xFD2B4C", VA = "0xFD2B4C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6005F3E")]
	[Address(RVA = "0xFD2C18", Offset = "0xFD2C18", VA = "0xFD2C18")]
	private void OnClanWarPartyUpdated(int clanWarPartyCount)
	{
	}

	[Token(Token = "0x6005F3F")]
	[Address(RVA = "0xFD2D88", Offset = "0xFD2D88", VA = "0xFD2D88")]
	private void BuildAutoButton()
	{
	}

	[Token(Token = "0x6005F40")]
	[Address(RVA = "0xFD3124", Offset = "0xFD3124", VA = "0xFD3124")]
	private void BuildGameRecordsButton(XUIGameRecordsButton gameRecordButton, Action<bool> onClickGameRecord, bool enable)
	{
	}

	[Token(Token = "0x6005F41")]
	[Address(RVA = "0xFD2948", Offset = "0xFD2948", VA = "0xFD2948")]
	private void InitUltDirection()
	{
	}

	[Token(Token = "0x6005F42")]
	[Address(RVA = "0xFD3298", Offset = "0xFD3298", VA = "0xFD3298")]
	public void ShowScrCaution()
	{
	}

	[Token(Token = "0x6005F43")]
	[Address(RVA = "0xFD32C8", Offset = "0xFD32C8", VA = "0xFD32C8")]
	public void HideScrCaution()
	{
	}

	[Token(Token = "0x6005F44")]
	[Address(RVA = "0xFD33A8", Offset = "0xFD33A8", VA = "0xFD33A8")]
	public void ShowUltDirection(string iconPath, Action onComplete)
	{
	}

	[Token(Token = "0x6005F45")]
	[Address(RVA = "0xFD34A4", Offset = "0xFD34A4", VA = "0xFD34A4")]
	private void BuildEmoticonButton()
	{
	}

	[Token(Token = "0x6005F46")]
	[Address(RVA = "0xFD35C8", Offset = "0xFD35C8", VA = "0xFD35C8")]
	private void HideKillMessage()
	{
	}

	[Token(Token = "0x6005F47")]
	[Address(RVA = "0xFD36A4", Offset = "0xFD36A4", VA = "0xFD36A4")]
	public void ShowGoalMessage(bool bShow, string message = "")
	{
	}

	[Token(Token = "0x6005F48")]
	[Address(RVA = "0xFD3724", Offset = "0xFD3724", VA = "0xFD3724")]
	public void HideName()
	{
	}

	[Token(Token = "0x6005F49")]
	[Address(RVA = "0xFD3764", Offset = "0xFD3764", VA = "0xFD3764")]
	public void ShowDamage(string damage, DamageType type, Vector3 worldPos, Vector3 dir, int fontsize)
	{
	}

	[Token(Token = "0x6005F4A")]
	[Address(RVA = "0xFD37C0", Offset = "0xFD37C0", VA = "0xFD37C0")]
	public void ShowHitCombo(string str, Color c)
	{
	}

	[Token(Token = "0x6005F4B")]
	[Address(RVA = "0xFD38C8", Offset = "0xFD38C8", VA = "0xFD38C8")]
	public void BuildSkill()
	{
	}

	[Token(Token = "0x6005F4C")]
	[Address(RVA = "0xFD418C", Offset = "0xFD418C", VA = "0xFD418C")]
	public void HideSkillUI()
	{
	}

	[Token(Token = "0x6005F4D")]
	[Address(RVA = "0xFD3CAC", Offset = "0xFD3CAC", VA = "0xFD3CAC")]
	private void BuildCharacterSkill(XModuleActor character)
	{
	}

	[Token(Token = "0x6005F4E")]
	[Address(RVA = "0xFD43E4", Offset = "0xFD43E4", VA = "0xFD43E4")]
	private void OnSkillButtonClick()
	{
	}

	[Token(Token = "0x6005F4F")]
	[Address(RVA = "0xFD4034", Offset = "0xFD4034", VA = "0xFD4034")]
	private void BuildRelicSkill(XModuleActor character)
	{
	}

	[Token(Token = "0x6005F50")]
	[Address(RVA = "0xFD44E4", Offset = "0xFD44E4", VA = "0xFD44E4")]
	internal void ReLinkSkillModule()
	{
	}

	[Token(Token = "0x6005F51")]
	[Address(RVA = "0xFD475C", Offset = "0xFD475C", VA = "0xFD475C")]
	private void ReLinkCharacterSKill(XModuleActor character)
	{
	}

	[Token(Token = "0x6005F52")]
	[Address(RVA = "0xFD4944", Offset = "0xFD4944", VA = "0xFD4944")]
	private void ReLinkRelicSkill(XModuleActor character)
	{
	}

	[Token(Token = "0x6005F53")]
	[Address(RVA = "0xFD4A48", Offset = "0xFD4A48", VA = "0xFD4A48")]
	public void RefreshTeamHpBar(List<XPlayer> playerList)
	{
	}

	[Token(Token = "0x6005F54")]
	[Address(RVA = "0xFD4A74", Offset = "0xFD4A74", VA = "0xFD4A74")]
	public void RefreshFriendlyTeamInfo()
	{
	}

	[Token(Token = "0x6005F55")]
	[Address(RVA = "0xFD4AA0", Offset = "0xFD4AA0", VA = "0xFD4AA0")]
	public void RefreshPauseButton()
	{
	}

	[Token(Token = "0x6005F56")]
	[Address(RVA = "0xFD3B7C", Offset = "0xFD3B7C", VA = "0xFD3B7C")]
	private bool GetCharTagButtonVisible()
	{
		return default(bool);
	}

	[Token(Token = "0x6005F57")]
	[Address(RVA = "0xFD4E24", Offset = "0xFD4E24", VA = "0xFD4E24")]
	public void RefreshCharTagButton()
	{
	}

	[Token(Token = "0x6005F58")]
	[Address(RVA = "0xFD4EA4", Offset = "0xFD4EA4", VA = "0xFD4EA4")]
	public void RefreshMiniMapPlayer()
	{
	}

	[Token(Token = "0x6005F59")]
	[Address(RVA = "0xFD4F80", Offset = "0xFD4F80", VA = "0xFD4F80")]
	public void RefreshMiniMapItem()
	{
	}

	[Token(Token = "0x6005F5A")]
	[Address(RVA = "0xFD505C", Offset = "0xFD505C", VA = "0xFD505C")]
	public void RefreshMiniMapFlag()
	{
	}

	[Token(Token = "0x6005F5B")]
	[Address(RVA = "0xFD5138", Offset = "0xFD5138", VA = "0xFD5138")]
	private void Update()
	{
	}

	[Token(Token = "0x6005F5C")]
	[Address(RVA = "0xFD5B38", Offset = "0xFD5B38", VA = "0xFD5B38")]
	private void CheckHidePauseMenu()
	{
	}

	[Token(Token = "0x6005F5D")]
	[Address(RVA = "0xFD5958", Offset = "0xFD5958", VA = "0xFD5958")]
	private void UpdateRoundTripTime()
	{
	}

	[Token(Token = "0x6005F5E")]
	[Address(RVA = "0xFD5DB8", Offset = "0xFD5DB8", VA = "0xFD5DB8")]
	public void RefreshActors(XModuleActor actor)
	{
	}

	[Token(Token = "0x6005F5F")]
	[Address(RVA = "0xFD5E9C", Offset = "0xFD5E9C", VA = "0xFD5E9C")]
	public void Build(XModuleActor actor, XGameData gameData, XSectorProperty sectorProperty, Action<bool> onClickRecord, [Optional] string stageName)
	{
	}

	[Token(Token = "0x6005F60")]
	[Address(RVA = "0xFD6098", Offset = "0xFD6098", VA = "0xFD6098")]
	private void BuildCommon(Action<bool> onClickRecord)
	{
	}

	[Token(Token = "0x6005F61")]
	[Address(RVA = "0xFD65E0", Offset = "0xFD65E0", VA = "0xFD65E0")]
	private void SetModeUI()
	{
	}

	[Token(Token = "0x6005F62")]
	[Address(RVA = "0xFD6748", Offset = "0xFD6748", VA = "0xFD6748")]
	public void ShowHpBar(bool isShow)
	{
	}

	[Token(Token = "0x6005F63")]
	[Address(RVA = "0xFD6AD4", Offset = "0xFD6AD4", VA = "0xFD6AD4")]
	public void ShowTripTime(bool isShow)
	{
	}

	[Token(Token = "0x6005F64")]
	[Address(RVA = "0xFD68E4", Offset = "0xFD68E4", VA = "0xFD68E4")]
	public void ShowMiniMap(bool isShow)
	{
	}

	[Token(Token = "0x6005F65")]
	[Address(RVA = "0xFD4E44", Offset = "0xFD4E44", VA = "0xFD4E44")]
	public void ShowCharTagButton(bool isShow)
	{
	}

	[Token(Token = "0x6005F66")]
	[Address(RVA = "0xFD6CF0", Offset = "0xFD6CF0", VA = "0xFD6CF0")]
	public void SetEnableXUIGameRecordsButtons(bool isEnable)
	{
	}

	[Token(Token = "0x6005F67")]
	[Address(RVA = "0xFD6BF8", Offset = "0xFD6BF8", VA = "0xFD6BF8")]
	public void SetPortraitFrame(int titleId)
	{
	}

	[Token(Token = "0x6005F68")]
	[Address(RVA = "0xFD515C", Offset = "0xFD515C", VA = "0xFD515C")]
	private void CheckKillMessageQueue()
	{
	}

	[Token(Token = "0x6005F69")]
	[Address(RVA = "0xFD6D40", Offset = "0xFD6D40", VA = "0xFD6D40")]
	public void KillMessageEnd()
	{
	}

	[Token(Token = "0x6005F6A")]
	[Address(RVA = "0xFD6D4C", Offset = "0xFD6D4C", VA = "0xFD6D4C")]
	public void ShowMultiKill(int charID, int skinID, int profileIconID, int titleID, string userName, int killCount)
	{
	}

	[Token(Token = "0x6005F6B")]
	[Address(RVA = "0xFD7004", Offset = "0xFD7004", VA = "0xFD7004")]
	public void ShowStreakKill(int charID, int skinID, int profileIconID, int titleID, string userName, int killCount, bool isEnemy)
	{
	}

	[Token(Token = "0x6005F6C")]
	[Address(RVA = "0xFD7254", Offset = "0xFD7254", VA = "0xFD7254")]
	public void ShowShutDownKill(int charID, int skinID, int profileIconID, int titleID, string userName, bool isEnemy)
	{
	}

	[Token(Token = "0x6005F6D")]
	[Address(RVA = "0xFD7490", Offset = "0xFD7490", VA = "0xFD7490")]
	public void ClearKillMessageDirection()
	{
	}

	[Token(Token = "0x6005F6E")]
	[Address(RVA = "0xFD7540", Offset = "0xFD7540", VA = "0xFD7540")]
	private void SetAuto(bool val)
	{
	}

	[Token(Token = "0x6005F6F")]
	[Address(RVA = "0xFD2F0C", Offset = "0xFD2F0C", VA = "0xFD2F0C")]
	private void SetAutoCombat(bool bShow)
	{
	}

	[Token(Token = "0x6005F70")]
	[Address(RVA = "0xFD779C", Offset = "0xFD779C", VA = "0xFD779C")]
	private void EnableAuto(bool val)
	{
	}

	[Token(Token = "0x6005F71")]
	[Address(RVA = "0xFD77C8", Offset = "0xFD77C8", VA = "0xFD77C8")]
	public void OnShowUI(bool bShow)
	{
	}

	[Token(Token = "0x6005F72")]
	[Address(RVA = "0xFD7AD0", Offset = "0xFD7AD0", VA = "0xFD7AD0")]
	public void BottomRightActive(bool isActive)
	{
	}

	[Token(Token = "0x6005F73")]
	[Address(RVA = "0xFD7B14", Offset = "0xFD7B14", VA = "0xFD7B14")]
	public void ShowWelcomeProfileIcon(int profileIconId, int titleId, float durationTime)
	{
	}

	[Token(Token = "0x6005F74")]
	[Address(RVA = "0xFD7B64", Offset = "0xFD7B64", VA = "0xFD7B64")]
	public void OnClickFreeSpectator()
	{
	}

	[Token(Token = "0x6005F75")]
	[Address(RVA = "0xFD7C34", Offset = "0xFD7C34", VA = "0xFD7C34")]
	public void SetIsShowPauseMenu(bool isShow)
	{
	}

	[Token(Token = "0x6005F76")]
	[Address(RVA = "0xFD7C3C", Offset = "0xFD7C3C", VA = "0xFD7C3C")]
	public void OnClickGameMenu()
	{
	}

	[Token(Token = "0x6005F77")]
	[Address(RVA = "0xFD7F50", Offset = "0xFD7F50", VA = "0xFD7F50")]
	public void OnClickEmoticonMenu()
	{
	}

	[Token(Token = "0x6005F78")]
	[Address(RVA = "0xFD810C", Offset = "0xFD810C", VA = "0xFD810C")]
	public void OnToggleAutoCombat()
	{
	}

	[Token(Token = "0x6005F79")]
	[Address(RVA = "0xFD8220", Offset = "0xFD8220", VA = "0xFD8220")]
	public void OnClickGameClearButton()
	{
	}

	[Token(Token = "0x6005F7A")]
	[Address(RVA = "0xFD8224", Offset = "0xFD8224", VA = "0xFD8224")]
	public void OnClickSwitchCharacter()
	{
	}

	[Token(Token = "0x6005F7B")]
	[Address(RVA = "0xFD82F0", Offset = "0xFD82F0", VA = "0xFD82F0")]
	public void OnClickChatWindow()
	{
	}

	[Token(Token = "0x6005F7C")]
	[Address(RVA = "0xFD83F0", Offset = "0xFD83F0", VA = "0xFD83F0")]
	public void SkillButtonEffectEnable(bool isEnable)
	{
	}

	[Token(Token = "0x6005F7D")]
	[Address(RVA = "0xFD8464", Offset = "0xFD8464", VA = "0xFD8464")]
	internal void VisiblePlayerBanButton()
	{
	}

	[Token(Token = "0x6005F7E")]
	[Address(RVA = "0xFD853C", Offset = "0xFD853C", VA = "0xFD853C")]
	internal void InvisiblePlayerBanButton()
	{
	}

	[Token(Token = "0x6005F7F")]
	[Address(RVA = "0xFD8614", Offset = "0xFD8614", VA = "0xFD8614")]
	internal void VisiblePlayerSpectatorButton()
	{
	}

	[Token(Token = "0x6005F80")]
	[Address(RVA = "0xFD86EC", Offset = "0xFD86EC", VA = "0xFD86EC")]
	internal void InvisiblePlayerSpectatorButton()
	{
	}

	[Token(Token = "0x6005F81")]
	[Address(RVA = "0xFD87C4", Offset = "0xFD87C4", VA = "0xFD87C4")]
	internal void VisibleFreeSpectatorButton(bool isShow)
	{
	}

	[Token(Token = "0x6005F82")]
	[Address(RVA = "0xFD87F0", Offset = "0xFD87F0", VA = "0xFD87F0")]
	internal void SetBanPlayerEvent(Action<XPlayer> _action)
	{
	}

	[Token(Token = "0x6005F83")]
	[Address(RVA = "0xFD881C", Offset = "0xFD881C", VA = "0xFD881C")]
	internal void SetSpectatorPlayerEvent(Action<XPlayer> _action)
	{
	}
}
