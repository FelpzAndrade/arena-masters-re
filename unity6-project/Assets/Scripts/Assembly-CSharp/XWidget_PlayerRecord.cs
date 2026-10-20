using System;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D3D")]
public class XWidget_PlayerRecord : MonoBehaviour
{
	[Token(Token = "0x40043D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public UIBasicSprite sprBG;

	[Token(Token = "0x40043D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public XWiget_GridBuilder roundBuilder;

	[Token(Token = "0x40043D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public XWiget_GridBuilder roundBGBuilder;

	[Token(Token = "0x40043D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public UIGrid scoreAligin;

	[Token(Token = "0x40043D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public UIBasicSprite sprMVP;

	[Token(Token = "0x40043D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public UILabel lblTotalScore;

	[Token(Token = "0x40043DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public XWidget_CharacterThumbnail[] charIcons;

	[Token(Token = "0x40043DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public UIBasicSprite sprHost;

	[Token(Token = "0x40043DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public UI2DSprite sprRelicIcon;

	[Token(Token = "0x40043DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public UILabel lblUserNickName;

	[Token(Token = "0x40043DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public XWidget_RoudTripTime roundTrip;

	[Token(Token = "0x40043DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public UILabel lblZombieState;

	[Token(Token = "0x40043E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public GameObject goKDA;

	[Token(Token = "0x40043E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public UILabel lblKill;

	[Token(Token = "0x40043E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public UILabel lblDeath;

	[Token(Token = "0x40043E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public UILabel lblAssist;

	[Token(Token = "0x40043E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public UILabel lblLoading;

	[Token(Token = "0x40043E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject kdaIcons;

	[Token(Token = "0x40043E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public UI2DSprite sprRank;

	[Token(Token = "0x40043E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject goBtnFrined;

	[Token(Token = "0x40043E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public Color redTeamColor;

	[Token(Token = "0x40043E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public Color blueTeamColor;

	[Token(Token = "0x40043EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public Color baseColor;

	[Token(Token = "0x40043EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public string redTeamSelectSpriteName;

	[Token(Token = "0x40043EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public string blueTeamSelectSpriteName;

	[Token(Token = "0x40043ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public string baseTeamSelectSpriteName;

	[Token(Token = "0x40043EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public UISprite sprMine;

	[Token(Token = "0x40043EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public GameObject UserInfoBtn;

	[Token(Token = "0x40043F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public GameObject UserInfo;

	[Token(Token = "0x40043F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public XWidget_RadioButton MannerBtn;

	[Token(Token = "0x40043F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public XWidget_RadioButton FriendBtn;

	[Token(Token = "0x40043F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	public XWidget_OnPress pressCallBackUp;

	[Token(Token = "0x40043F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public XWidget_OnPress pressCallBackDown;

	[Token(Token = "0x40043F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	public GameObject goTweenRoot;

	[Token(Token = "0x40043F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public UILabel lblMannerInfo;

	[Token(Token = "0x40043F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	public TweenAlpha tweenAlpha;

	[Token(Token = "0x40043F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public UISprite sprKill;

	[Token(Token = "0x40043F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	public UISprite sprDeath;

	[Token(Token = "0x40043FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public UISprite sprAssist;

	[Token(Token = "0x40043FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	private XPlayer m_Player;

	[Token(Token = "0x40043FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private bool m_badMannerClick;

	[Token(Token = "0x17000D1E")]
	private string PlayerAID
	{
		[Token(Token = "0x6006120")]
		[Address(RVA = "0x1319D94", Offset = "0x1319D94", VA = "0x1319D94")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D1F")]
	private string PlayerNick
	{
		[Token(Token = "0x6006121")]
		[Address(RVA = "0x1319DB8", Offset = "0x1319DB8", VA = "0x1319DB8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D20")]
	private string PlayerAid_PlayerNick
	{
		[Token(Token = "0x6006122")]
		[Address(RVA = "0x1319DDC", Offset = "0x1319DDC", VA = "0x1319DDC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600611F")]
	[Address(RVA = "0x1319CEC", Offset = "0x1319CEC", VA = "0x1319CEC")]
	public XWidget_PlayerRecord()
	{
	}

	[Token(Token = "0x6006123")]
	[Address(RVA = "0x1319ED0", Offset = "0x1319ED0", VA = "0x1319ED0")]
	public void Awake()
	{
	}

	[Token(Token = "0x6006124")]
	[Address(RVA = "0x131A050", Offset = "0x131A050", VA = "0x131A050")]
	public void ShowMannerInfo_Manner()
	{
	}

	[Token(Token = "0x6006125")]
	[Address(RVA = "0x131A1E4", Offset = "0x131A1E4", VA = "0x131A1E4")]
	public void HideMannerInfo_Manner()
	{
	}

	[Token(Token = "0x6006126")]
	[Address(RVA = "0x131A210", Offset = "0x131A210", VA = "0x131A210")]
	public void Show(bool b)
	{
	}

	[Token(Token = "0x6006127")]
	[Address(RVA = "0x131A354", Offset = "0x131A354", VA = "0x131A354")]
	public void Build(XPlayer player, bool isTeamMode, XGameModeType mode, bool IsReady, [Optional][DefaultParameterValue(false)] bool bFinish, [Optional][DefaultParameterValue(false)] bool enableSpriteIcon, [Optional] Action<string, byte> mannerClickAction, [Optional] Action<string, byte> friendClickAction)
	{
	}

	[Token(Token = "0x6006128")]
	[Address(RVA = "0x131B00C", Offset = "0x131B00C", VA = "0x131B00C")]
	private void Update()
	{
	}

	[Token(Token = "0x6006129")]
	[Address(RVA = "0x131AC5C", Offset = "0x131AC5C", VA = "0x131AC5C")]
	private void BuildDynamic(XPlayer player, XGameModeType mode, bool bFinish)
	{
	}

	[Token(Token = "0x600612A")]
	[Address(RVA = "0x131BDD4", Offset = "0x131BDD4", VA = "0x131BDD4")]
	private void SetRank(XGameModeType mode, int rank)
	{
	}

	[Token(Token = "0x600612B")]
	[Address(RVA = "0x131A8A8", Offset = "0x131A8A8", VA = "0x131A8A8")]
	private void SetDuelRound(XPlayer player, XGameModeType mode)
	{
	}

	[Token(Token = "0x600612C")]
	[Address(RVA = "0x131C6AC", Offset = "0x131C6AC", VA = "0x131C6AC")]
	private void SetHost(XPlayer player)
	{
	}

	[Token(Token = "0x600612D")]
	[Address(RVA = "0x131C7BC", Offset = "0x131C7BC", VA = "0x131C7BC")]
	private void SetRelic(XPlayer player)
	{
	}

	[Token(Token = "0x600612E")]
	[Address(RVA = "0x131C5D0", Offset = "0x131C5D0", VA = "0x131C5D0")]
	private void SetButton(XPlayer player, XGameModeType mode, bool bFinish)
	{
	}

	[Token(Token = "0x600612F")]
	[Address(RVA = "0x131C020", Offset = "0x131C020", VA = "0x131C020")]
	private void SetZombieState(XPlayer player, bool zombieMode)
	{
	}

	[Token(Token = "0x6006130")]
	[Address(RVA = "0x131B820", Offset = "0x131B820", VA = "0x131B820")]
	private void SetLoading(XPlayer player)
	{
	}

	[Token(Token = "0x6006131")]
	[Address(RVA = "0x131B934", Offset = "0x131B934", VA = "0x131B934")]
	private void SetKDA(XPlayer player, XGameModeType mode)
	{
	}

	[Token(Token = "0x6006132")]
	[Address(RVA = "0x131C378", Offset = "0x131C378", VA = "0x131C378")]
	private void SetTotalScoreAndMVP(XGameModeType mode, bool isFinish, bool isMVP, int totalScore)
	{
	}

	[Token(Token = "0x6006133")]
	[Address(RVA = "0x131B4F0", Offset = "0x131B4F0", VA = "0x131B4F0")]
	private void SetName(XPlayer player, bool isFinish)
	{
	}

	[Token(Token = "0x6006134")]
	[Address(RVA = "0x131B2D0", Offset = "0x131B2D0", VA = "0x131B2D0")]
	private void SetCharacterIcons(XPlayer player)
	{
	}

	[Token(Token = "0x6006135")]
	[Address(RVA = "0x131AEA4", Offset = "0x131AEA4", VA = "0x131AEA4")]
	private void SetBGColor(UIBasicSprite sprBG, bool isMine, XTeamEnum team, bool isTeamMode)
	{
	}

	[Token(Token = "0x6006136")]
	[Address(RVA = "0x131CBE8", Offset = "0x131CBE8", VA = "0x131CBE8")]
	public void OnClick_UserInfo()
	{
	}

	[Token(Token = "0x6006137")]
	[Address(RVA = "0x131CC3C", Offset = "0x131CC3C", VA = "0x131CC3C")]
	public void OnClick_AIMode()
	{
	}

	[Token(Token = "0x6006138")]
	[Address(RVA = "0x131CDDC", Offset = "0x131CDDC", VA = "0x131CDDC")]
	public void OnClick_MannerUp()
	{
	}

	[Token(Token = "0x6006139")]
	[Address(RVA = "0x131D038", Offset = "0x131D038", VA = "0x131D038")]
	private void MannerUp()
	{
	}

	[Token(Token = "0x600613A")]
	[Address(RVA = "0x131D340", Offset = "0x131D340", VA = "0x131D340")]
	public void OnClick_MannerDown()
	{
	}

	[Token(Token = "0x600613B")]
	[Address(RVA = "0x131D444", Offset = "0x131D444", VA = "0x131D444")]
	private void MannerDown()
	{
	}

	[Token(Token = "0x600613C")]
	[Address(RVA = "0x131D6DC", Offset = "0x131D6DC", VA = "0x131D6DC")]
	private void ResetManner()
	{
	}

	[Token(Token = "0x600613D")]
	[Address(RVA = "0x131D178", Offset = "0x131D178", VA = "0x131D178")]
	private void ResetBadMannerClick()
	{
	}

	[Token(Token = "0x600613E")]
	[Address(RVA = "0x131D5F4", Offset = "0x131D5F4", VA = "0x131D5F4")]
	private void SetBadMannerClick()
	{
	}

	[Token(Token = "0x600613F")]
	[Address(RVA = "0x131D260", Offset = "0x131D260", VA = "0x131D260")]
	private void SetLblMannerInfo(string text)
	{
	}

	[Token(Token = "0x6006140")]
	[Address(RVA = "0x131D798", Offset = "0x131D798", VA = "0x131D798")]
	public void OnClick_AddFriend()
	{
	}

	[Token(Token = "0x6006141")]
	[Address(RVA = "0x131D89C", Offset = "0x131D89C", VA = "0x131D89C")]
	private void AddFriend()
	{
	}

	[Token(Token = "0x6006142")]
	[Address(RVA = "0x131D950", Offset = "0x131D950", VA = "0x131D950")]
	public void OnClick_BlockFriend()
	{
	}

	[Token(Token = "0x6006143")]
	[Address(RVA = "0x131DA54", Offset = "0x131DA54", VA = "0x131DA54")]
	private void BlockFriend()
	{
	}

	[Token(Token = "0x6006144")]
	[Address(RVA = "0x131DB08", Offset = "0x131DB08", VA = "0x131DB08")]
	private void ResetFriend()
	{
	}
}
