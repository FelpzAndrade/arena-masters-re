using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using UnityEngine;

[Token(Token = "0x200105B")]
public class XUIMgr_Lobby : XUIMgrBase
{
	[Token(Token = "0x200105C")]
	public enum AsyncUI
	{
		[Token(Token = "0x4005864")]
		pnlMain = 0,
		[Token(Token = "0x4005865")]
		pnlTopBanner = 1,
		[Token(Token = "0x4005866")]
		inventory = 2,
		[Token(Token = "0x4005867")]
		item = 3,
		[Token(Token = "0x4005868")]
		clearTicketResult_1 = 4,
		[Token(Token = "0x4005869")]
		clearTicketResult_5 = 5,
		[Token(Token = "0x400586A")]
		clearTicketReward_1 = 6,
		[Token(Token = "0x400586B")]
		clearTicketReward_5 = 7,
		[Token(Token = "0x400586C")]
		relicSlot = 8
	}

	[Token(Token = "0x200105D")]
	private sealed class _003CIsQueuedState_003Ec__AnonStorey259
	{
		[Token(Token = "0x400586D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal XLobbyStateTypes type;

		[Token(Token = "0x6007B7D")]
		[Address(RVA = "0x10C299C", Offset = "0x10C299C", VA = "0x10C299C")]
		public _003CIsQueuedState_003Ec__AnonStorey259()
		{
		}

		[Token(Token = "0x6007B7E")]
		[Address(RVA = "0x10CEEF8", Offset = "0x10CEEF8", VA = "0x10CEEF8")]
		internal bool _003C_003Em__51C(XUILobbyState each)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200105E")]
	private sealed class _003CMoveSceneLink_003Ec__AnonStorey25A
	{
		[Token(Token = "0x400586E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal string[] words;

		[Token(Token = "0x400586F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal string link;

		[Token(Token = "0x4005870")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal XUIMgr_Lobby _003C_003Ef__this;

		[Token(Token = "0x6007B7F")]
		[Address(RVA = "0x10CD4BC", Offset = "0x10CD4BC", VA = "0x10CD4BC")]
		public _003CMoveSceneLink_003Ec__AnonStorey25A()
		{
		}

		[Token(Token = "0x6007B80")]
		[Address(RVA = "0x10CEF60", Offset = "0x10CEF60", VA = "0x10CEF60")]
		internal void _003C_003Em__51E()
		{
		}

		[Token(Token = "0x6007B81")]
		[Address(RVA = "0x10CEF90", Offset = "0x10CEF90", VA = "0x10CEF90")]
		internal void _003C_003Em__51F()
		{
		}

		[Token(Token = "0x6007B82")]
		[Address(RVA = "0x10CEFC0", Offset = "0x10CEFC0", VA = "0x10CEFC0")]
		internal void _003C_003Em__520()
		{
		}

		[Token(Token = "0x6007B83")]
		[Address(RVA = "0x10CEFE8", Offset = "0x10CEFE8", VA = "0x10CEFE8")]
		internal void _003C_003Em__521()
		{
		}

		[Token(Token = "0x6007B84")]
		[Address(RVA = "0x10CF018", Offset = "0x10CF018", VA = "0x10CF018")]
		internal void _003C_003Em__522()
		{
		}

		[Token(Token = "0x6007B85")]
		[Address(RVA = "0x10CF048", Offset = "0x10CF048", VA = "0x10CF048")]
		internal void _003C_003Em__523()
		{
		}

		[Token(Token = "0x6007B86")]
		[Address(RVA = "0x10CF150", Offset = "0x10CF150", VA = "0x10CF150")]
		internal void _003C_003Em__524()
		{
		}

		[Token(Token = "0x6007B87")]
		[Address(RVA = "0x10CF178", Offset = "0x10CF178", VA = "0x10CF178")]
		internal void _003C_003Em__525()
		{
		}

		[Token(Token = "0x6007B88")]
		[Address(RVA = "0x10CF1A8", Offset = "0x10CF1A8", VA = "0x10CF1A8")]
		internal void _003C_003Em__526()
		{
		}

		[Token(Token = "0x6007B89")]
		[Address(RVA = "0x10CF1D8", Offset = "0x10CF1D8", VA = "0x10CF1D8")]
		internal void _003C_003Em__527()
		{
		}

		[Token(Token = "0x6007B8A")]
		[Address(RVA = "0x10CF224", Offset = "0x10CF224", VA = "0x10CF224")]
		internal void _003C_003Em__528()
		{
		}

		[Token(Token = "0x6007B8B")]
		[Address(RVA = "0x10CF270", Offset = "0x10CF270", VA = "0x10CF270")]
		internal void _003C_003Em__529()
		{
		}

		[Token(Token = "0x6007B8C")]
		[Address(RVA = "0x10CF2A0", Offset = "0x10CF2A0", VA = "0x10CF2A0")]
		internal void _003C_003Em__52A()
		{
		}

		[Token(Token = "0x6007B8D")]
		[Address(RVA = "0x10CF2D0", Offset = "0x10CF2D0", VA = "0x10CF2D0")]
		internal void _003C_003Em__52B()
		{
		}

		[Token(Token = "0x6007B8E")]
		[Address(RVA = "0x10CF330", Offset = "0x10CF330", VA = "0x10CF330")]
		internal void _003C_003Em__52C()
		{
		}

		[Token(Token = "0x6007B8F")]
		[Address(RVA = "0x10CF374", Offset = "0x10CF374", VA = "0x10CF374")]
		internal void _003C_003Em__52D()
		{
		}

		[Token(Token = "0x6007B90")]
		[Address(RVA = "0x10CF3B8", Offset = "0x10CF3B8", VA = "0x10CF3B8")]
		internal void _003C_003Em__52E()
		{
		}

		[Token(Token = "0x6007B91")]
		[Address(RVA = "0x10CF3E4", Offset = "0x10CF3E4", VA = "0x10CF3E4")]
		internal void _003C_003Em__52F()
		{
		}

		[Token(Token = "0x6007B92")]
		[Address(RVA = "0x10CF410", Offset = "0x10CF410", VA = "0x10CF410")]
		internal void _003C_003Em__530()
		{
		}

		[Token(Token = "0x6007B93")]
		[Address(RVA = "0x10CF43C", Offset = "0x10CF43C", VA = "0x10CF43C")]
		internal void _003C_003Em__531()
		{
		}

		[Token(Token = "0x6007B94")]
		[Address(RVA = "0x10CF468", Offset = "0x10CF468", VA = "0x10CF468")]
		internal void _003C_003Em__532()
		{
		}

		[Token(Token = "0x6007B95")]
		[Address(RVA = "0x10CF494", Offset = "0x10CF494", VA = "0x10CF494")]
		internal void _003C_003Em__533()
		{
		}

		[Token(Token = "0x6007B96")]
		[Address(RVA = "0x10CF4BC", Offset = "0x10CF4BC", VA = "0x10CF4BC")]
		internal void _003C_003Em__534()
		{
		}

		[Token(Token = "0x6007B97")]
		[Address(RVA = "0x10CF4E8", Offset = "0x10CF4E8", VA = "0x10CF4E8")]
		internal void _003C_003Em__535()
		{
		}

		[Token(Token = "0x6007B98")]
		[Address(RVA = "0x10CF514", Offset = "0x10CF514", VA = "0x10CF514")]
		internal void _003C_003Em__536()
		{
		}

		[Token(Token = "0x6007B99")]
		[Address(RVA = "0x10CF53C", Offset = "0x10CF53C", VA = "0x10CF53C")]
		internal void _003C_003Em__537()
		{
		}

		[Token(Token = "0x6007B9A")]
		[Address(RVA = "0x10CF564", Offset = "0x10CF564", VA = "0x10CF564")]
		internal void _003C_003Em__538()
		{
		}

		[Token(Token = "0x6007B9B")]
		[Address(RVA = "0x10CF7B8", Offset = "0x10CF7B8", VA = "0x10CF7B8")]
		internal void _003C_003Em__539()
		{
		}

		[Token(Token = "0x6007B9C")]
		[Address(RVA = "0x10CF7E4", Offset = "0x10CF7E4", VA = "0x10CF7E4")]
		internal void _003C_003Em__53A()
		{
		}
	}

	[Token(Token = "0x200105F")]
	private sealed class _003CShowMesseageBox_DownLoad_003Ec__AnonStorey25B
	{
		[Token(Token = "0x4005871")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal string storeUrl;

		[Token(Token = "0x6007B9D")]
		[Address(RVA = "0x10CEE10", Offset = "0x10CEE10", VA = "0x10CEE10")]
		public _003CShowMesseageBox_DownLoad_003Ec__AnonStorey25B()
		{
		}

		[Token(Token = "0x6007B9E")]
		[Address(RVA = "0x10CF810", Offset = "0x10CF810", VA = "0x10CF810")]
		internal void _003C_003Em__53B()
		{
		}
	}

	[Token(Token = "0x4005830")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private GameObject m_pnlWindowBackground;

	[Token(Token = "0x4005831")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private XPanel_Mail m_pnlMail;

	[Token(Token = "0x4005832")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private XPanel_TopBanner m_topBanner;

	[Token(Token = "0x4005833")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private XPanel_TeamManagement m_pnlTeamManagement;

	[Token(Token = "0x4005834")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private XPanel_CharMain m_pnlCharMain;

	[Token(Token = "0x4005835")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private XPanel_CharDetail m_pnlCharDetail;

	[Token(Token = "0x4005836")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private XPanel_Pet m_pnlPet;

	[Token(Token = "0x4005837")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public LobbyNotificationLogic lobbyNotiLogic;

	[Token(Token = "0x4005838")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private XPanel_GachaConfirm m_pnlGachaConfirm;

	[Token(Token = "0x4005839")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private XPanel_WaitingMatch m_pnlWaitingMatch;

	[Token(Token = "0x400583A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private XPanel_Quest m_pnlQuest;

	[Token(Token = "0x400583B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private XPanel_Friend m_pnlFriend;

	[Token(Token = "0x400583C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private XWidget_SelectDifficult m_widgetSelectDifficulty;

	[Token(Token = "0x400583D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private XPanel_GameReadyView m_pnlGameReadyView;

	[Token(Token = "0x400583E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private XPanel_ChallengeMain m_pnlChallengeMain;

	[Token(Token = "0x400583F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private XPanel_PlayMain m_pnlPlayMain;

	[Token(Token = "0x4005840")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private XPanel_LadderMain m_pnlLadderMain;

	[Token(Token = "0x4005841")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private XPanel_Achievement m_pnlAchievement;

	[Token(Token = "0x4005842")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public XCharacterInventory otherUserCharInven;

	[Token(Token = "0x4005843")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private XPanel_SkyTower m_pnlSkyTower;

	[Token(Token = "0x4005844")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private XPanel_Help m_pnlHelp;

	[Token(Token = "0x4005845")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private XPanel_FailStage m_pnlFailStage;

	[Token(Token = "0x4005846")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public bool showMissionDetail;

	[Token(Token = "0x4005847")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private XPanel_CharSkill m_pnlCharSkill;

	[Token(Token = "0x4005848")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private XWidget_EventAttendance_4Day m_pnlEventAttend4day;

	[Token(Token = "0x4005849")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private XPanel_AchieveNotice m_pnlAchieveNotice;

	[Token(Token = "0x400584A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private XWidget_Attendance m_pnlAttendance;

	[Token(Token = "0x400584B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private XWidget_EventAttendance m_pnlEventAttendance;

	[Token(Token = "0x400584C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private XPanel_GroupInviteMessagePopup m_groupInviteMessagePopup;

	[Token(Token = "0x400584D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private XWidget_ItemDetailToolTip m_widgetItemDetailToolTip;

	[Token(Token = "0x400584E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private XWidget_OtherUserInfoPopup m_otherUserPopup;

	[Token(Token = "0x400584F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private XUIPopup_CreateRoom m_popCreateRoom;

	[Token(Token = "0x4005850")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private XUIRewardBox m_rewardBox;

	[Token(Token = "0x4005851")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private XPanel_RewardPopup m_rewardPopup;

	[Token(Token = "0x4005852")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private XUIPartitionMessageBox m_partitionMessageBox;

	[Token(Token = "0x4005853")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private XPanel_Transfer m_transferPopup;

	[Token(Token = "0x4005854")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private List<XUILobbyState> states;

	[Token(Token = "0x4005855")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public List<XUILobbyState> protoStates;

	[Token(Token = "0x4005856")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	public bool isDirecting;

	[Token(Token = "0x4005857")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAD")]
	private bool m_fromCheckResource;

	[Token(Token = "0x4005858")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private XLobbyStateTypes m_from;

	[Token(Token = "0x4005859")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	private XUIModelPreview m_modelPreview;

	[Token(Token = "0x400585A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private Stack<IBackbutton> backStack;

	[Token(Token = "0x400585B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	private XLobbyStateTypes m_lobbyType;

	[Token(Token = "0x400585C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static NetCallback _003C_003Ef__am_0024cache2C;

	[Token(Token = "0x400585D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static Dictionary<string, int> _003C_003Ef__switch_0024map1A;

	[Token(Token = "0x400585E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Dictionary<string, int> _003C_003Ef__switch_0024map1B;

	[Token(Token = "0x400585F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private static Dictionary<string, int> _003C_003Ef__switch_0024map1C;

	[Token(Token = "0x4005860")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static Dictionary<string, int> _003C_003Ef__switch_0024map1D;

	[Token(Token = "0x4005861")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private static Dictionary<string, int> _003C_003Ef__switch_0024map1E;

	[Token(Token = "0x4005862")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static Dictionary<string, int> _003C_003Ef__switch_0024map1F;

	[Token(Token = "0x17000F1F")]
	private GameObject pnlWindowBackground
	{
		[Token(Token = "0x6007AC4")]
		[Address(RVA = "0x10BFC60", Offset = "0x10BFC60", VA = "0x10BFC60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F20")]
	private XPanel_Mail pnlMail
	{
		[Token(Token = "0x6007AC5")]
		[Address(RVA = "0x10BFD60", Offset = "0x10BFD60", VA = "0x10BFD60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F21")]
	public XPanel_TopBanner topBanner
	{
		[Token(Token = "0x6007AC6")]
		[Address(RVA = "0x10BFE6C", Offset = "0x10BFE6C", VA = "0x10BFE6C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F22")]
	private XPanel_TeamManagement pnlTeamManagement
	{
		[Token(Token = "0x6007AC7")]
		[Address(RVA = "0x10C0140", Offset = "0x10C0140", VA = "0x10C0140")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F23")]
	private XPanel_CharMain pnlCharMain
	{
		[Token(Token = "0x6007AC8")]
		[Address(RVA = "0x10C024C", Offset = "0x10C024C", VA = "0x10C024C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F24")]
	private XPanel_CharDetail pnlCharDetail
	{
		[Token(Token = "0x6007AC9")]
		[Address(RVA = "0x10C0358", Offset = "0x10C0358", VA = "0x10C0358")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F25")]
	private XPanel_Pet pnlPet
	{
		[Token(Token = "0x6007ACA")]
		[Address(RVA = "0x10C0464", Offset = "0x10C0464", VA = "0x10C0464")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F26")]
	private XPanel_GachaConfirm pnlGachaConfirm
	{
		[Token(Token = "0x6007ACB")]
		[Address(RVA = "0x10C0570", Offset = "0x10C0570", VA = "0x10C0570")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F27")]
	private XPanel_WaitingMatch pnlWaitingMatch
	{
		[Token(Token = "0x6007ACC")]
		[Address(RVA = "0x10C0764", Offset = "0x10C0764", VA = "0x10C0764")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F28")]
	private XPanel_Quest pnlQuest
	{
		[Token(Token = "0x6007ACD")]
		[Address(RVA = "0x10C09A0", Offset = "0x10C09A0", VA = "0x10C09A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F29")]
	private XPanel_Friend pnlFriend
	{
		[Token(Token = "0x6007ACE")]
		[Address(RVA = "0x10C0AAC", Offset = "0x10C0AAC", VA = "0x10C0AAC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F2A")]
	private XWidget_SelectDifficult widgetSelectDifficulty
	{
		[Token(Token = "0x6007ACF")]
		[Address(RVA = "0x10C0BB8", Offset = "0x10C0BB8", VA = "0x10C0BB8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F2B")]
	private XPanel_GameReadyView pnlGameReadyView
	{
		[Token(Token = "0x6007AD0")]
		[Address(RVA = "0x10C0D00", Offset = "0x10C0D00", VA = "0x10C0D00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F2C")]
	private XPanel_ChallengeMain pnlChallengeMain
	{
		[Token(Token = "0x6007AD1")]
		[Address(RVA = "0x10C0E0C", Offset = "0x10C0E0C", VA = "0x10C0E0C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F2D")]
	private XPanel_PlayMain pnlPlayMain
	{
		[Token(Token = "0x6007AD2")]
		[Address(RVA = "0x10C0F18", Offset = "0x10C0F18", VA = "0x10C0F18")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F2E")]
	private XPanel_LadderMain pnlLadderMain
	{
		[Token(Token = "0x6007AD3")]
		[Address(RVA = "0x10C1024", Offset = "0x10C1024", VA = "0x10C1024")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F2F")]
	private XPanel_Achievement pnlAchievement
	{
		[Token(Token = "0x6007AD4")]
		[Address(RVA = "0x10C1130", Offset = "0x10C1130", VA = "0x10C1130")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F30")]
	private XPanel_SkyTower pnlSkyTower
	{
		[Token(Token = "0x6007AD5")]
		[Address(RVA = "0x10C123C", Offset = "0x10C123C", VA = "0x10C123C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F31")]
	private XPanel_Help pnlHelp
	{
		[Token(Token = "0x6007AD6")]
		[Address(RVA = "0x10C1348", Offset = "0x10C1348", VA = "0x10C1348")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F32")]
	private XPanel_FailStage pnlFailStage
	{
		[Token(Token = "0x6007AD7")]
		[Address(RVA = "0x10C1454", Offset = "0x10C1454", VA = "0x10C1454")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F33")]
	private XPanel_CharSkill pnlCharSkill
	{
		[Token(Token = "0x6007AD8")]
		[Address(RVA = "0x10C1648", Offset = "0x10C1648", VA = "0x10C1648")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F34")]
	public XWidget_EventAttendance_4Day pnlEventAttend4day
	{
		[Token(Token = "0x6007AD9")]
		[Address(RVA = "0x10C1754", Offset = "0x10C1754", VA = "0x10C1754")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F35")]
	public XPanel_AchieveNotice pnlAchieveNotice
	{
		[Token(Token = "0x6007ADA")]
		[Address(RVA = "0x10C1860", Offset = "0x10C1860", VA = "0x10C1860")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F36")]
	public XWidget_Attendance pnlAttendancePopup
	{
		[Token(Token = "0x6007ADB")]
		[Address(RVA = "0x10C196C", Offset = "0x10C196C", VA = "0x10C196C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F37")]
	public XWidget_EventAttendance pnlEventAttendance
	{
		[Token(Token = "0x6007ADC")]
		[Address(RVA = "0x10C1A78", Offset = "0x10C1A78", VA = "0x10C1A78")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F38")]
	public XPanel_GroupInviteMessagePopup GroupInviteMessagePopup
	{
		[Token(Token = "0x6007ADD")]
		[Address(RVA = "0x10C1B84", Offset = "0x10C1B84", VA = "0x10C1B84")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F39")]
	private XWidget_ItemDetailToolTip widgetItemDetailToolTip
	{
		[Token(Token = "0x6007ADE")]
		[Address(RVA = "0x10C1C90", Offset = "0x10C1C90", VA = "0x10C1C90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F3A")]
	public XWidget_OtherUserInfoPopup OtherUserPopup
	{
		[Token(Token = "0x6007ADF")]
		[Address(RVA = "0x10C1D9C", Offset = "0x10C1D9C", VA = "0x10C1D9C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F3B")]
	public XUIPopup_CreateRoom PopupCreateRoom
	{
		[Token(Token = "0x6007AE0")]
		[Address(RVA = "0x10C202C", Offset = "0x10C202C", VA = "0x10C202C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F3C")]
	private XUIRewardBox rewardBox
	{
		[Token(Token = "0x6007AE1")]
		[Address(RVA = "0x10C22BC", Offset = "0x10C22BC", VA = "0x10C22BC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F3D")]
	private XPanel_RewardPopup rewardPopup
	{
		[Token(Token = "0x6007AE2")]
		[Address(RVA = "0x10C23C8", Offset = "0x10C23C8", VA = "0x10C23C8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F3E")]
	private XUIPartitionMessageBox partitionMessageBox
	{
		[Token(Token = "0x6007AE3")]
		[Address(RVA = "0x10C24D4", Offset = "0x10C24D4", VA = "0x10C24D4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F3F")]
	private XPanel_Transfer transferPopup
	{
		[Token(Token = "0x6007AE4")]
		[Address(RVA = "0x10C25E0", Offset = "0x10C25E0", VA = "0x10C25E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F40")]
	public XUIModelPreview ModelPreview
	{
		[Token(Token = "0x6007AF5")]
		[Address(RVA = "0x10C4840", Offset = "0x10C4840", VA = "0x10C4840")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007ABE")]
	[Address(RVA = "0x10B15B4", Offset = "0x10B15B4", VA = "0x10B15B4")]
	public XUIMgr_Lobby()
	{
	}

	[Token(Token = "0x6007ABF")]
	[Address(RVA = "0x10BF8AC", Offset = "0x10BF8AC", VA = "0x10BF8AC", Slot = "6")]
	public override void Clear()
	{
	}

	[Token(Token = "0x6007AC0")]
	[Address(RVA = "0x10BFABC", Offset = "0x10BFABC", VA = "0x10BFABC", Slot = "7")]
	public override void ReleaseNGUIAtlas()
	{
	}

	[Token(Token = "0x6007AC1")]
	[Address(RVA = "0x10BFBD8", Offset = "0x10BFBD8", VA = "0x10BFBD8", Slot = "4")]
	public override string GetPrefabPath()
	{
		return null;
	}

	[Token(Token = "0x6007AC2")]
	[Address(RVA = "0x10BFC50", Offset = "0x10BFC50", VA = "0x10BFC50")]
	public void SetCharDetail_ForTest(XPanel_CharDetail comp)
	{
	}

	[Token(Token = "0x6007AC3")]
	[Address(RVA = "0x10BFC58", Offset = "0x10BFC58", VA = "0x10BFC58")]
	public void SetTopBanner_ForTest(XPanel_TopBanner topbanner)
	{
	}

	[Token(Token = "0x6007AE5")]
	[Address(RVA = "0x10C26EC", Offset = "0x10C26EC", VA = "0x10C26EC")]
	public void ShowTransferPopup(UserTransferData _transferData)
	{
	}

	[Token(Token = "0x6007AE6")]
	[Address(RVA = "0x10C27D8", Offset = "0x10C27D8", VA = "0x10C27D8")]
	public void ShowItemDetailToolTip(XItem item, bool showSellPrice = false, int depth = 300)
	{
	}

	[Token(Token = "0x6007AE7")]
	[Address(RVA = "0x109D4F4", Offset = "0x109D4F4", VA = "0x109D4F4")]
	public bool IsItemDetailToolTip()
	{
		return default(bool);
	}

	[Token(Token = "0x6007AE8")]
	[Address(RVA = "0x109D5FC", Offset = "0x109D5FC", VA = "0x109D5FC")]
	public void HideItemDetailToolTip()
	{
	}

	[Token(Token = "0x6007AE9")]
	[Address(RVA = "0x10C28FC", Offset = "0x10C28FC", VA = "0x10C28FC")]
	private XUILobbyState GetState(XLobbyStateTypes type)
	{
		return null;
	}

	[Token(Token = "0x6007AEA")]
	[Address(RVA = "0x10A1B0C", Offset = "0x10A1B0C", VA = "0x10A1B0C")]
	public bool IsQueuedState(XLobbyStateTypes type)
	{
		return default(bool);
	}

	[Token(Token = "0x6007AEB")]
	[Address(RVA = "0x10C29A4", Offset = "0x10C29A4", VA = "0x10C29A4")]
	private bool IsPrevState(XLobbyStateTypes type)
	{
		return default(bool);
	}

	[Token(Token = "0x6007AEC")]
	[Address(RVA = "0x109C70C", Offset = "0x109C70C", VA = "0x109C70C")]
	public XLobbyStateTypes GetLastStateType()
	{
		return default(XLobbyStateTypes);
	}

	[Token(Token = "0x6007AED")]
	[Address(RVA = "0x10C2B4C", Offset = "0x10C2B4C", VA = "0x10C2B4C")]
	public void ReserveState(XLobbyStateTypes type, [Optional] Hashtable param)
	{
	}

	[Token(Token = "0x6007AEE")]
	[Address(RVA = "0x10C2C50", Offset = "0x10C2C50", VA = "0x10C2C50")]
	public void ShowCurrentState()
	{
	}

	[Token(Token = "0x6007AEF")]
	[Address(RVA = "0x10C2F64", Offset = "0x10C2F64", VA = "0x10C2F64")]
	public void PushState(XLobbyStateTypes type, [Optional] Hashtable param)
	{
	}

	[Token(Token = "0x6007AF0")]
	[Address(RVA = "0x10C3FE0", Offset = "0x10C3FE0", VA = "0x10C3FE0")]
	private void HideLastState()
	{
	}

	[Token(Token = "0x6007AF1")]
	[Address(RVA = "0x10C378C", Offset = "0x10C378C", VA = "0x10C378C")]
	private void PopState()
	{
	}

	[Token(Token = "0x6007AF2")]
	[Address(RVA = "0x10C4214", Offset = "0x10C4214", VA = "0x10C4214")]
	public void PopAllState()
	{
	}

	[Token(Token = "0x6007AF3")]
	[Address(RVA = "0x10C45BC", Offset = "0x10C45BC", VA = "0x10C45BC")]
	public void ClearAllState()
	{
	}

	[Token(Token = "0x6007AF4")]
	[Address(RVA = "0x10C471C", Offset = "0x10C471C", VA = "0x10C471C")]
	private void Final()
	{
	}

	[Token(Token = "0x6007AF6")]
	[Address(RVA = "0x10B37A0", Offset = "0x10B37A0", VA = "0x10B37A0")]
	public void FromCheckResource()
	{
	}

	[Token(Token = "0x6007AF7")]
	[Address(RVA = "0x10C4848", Offset = "0x10C4848", VA = "0x10C4848", Slot = "5")]
	public override void Init()
	{
	}

	[Token(Token = "0x6007AF8")]
	[Address(RVA = "0x10C5154", Offset = "0x10C5154", VA = "0x10C5154")]
	public void ReserveGoToState()
	{
	}

	[Token(Token = "0x6007AF9")]
	[Address(RVA = "0x10C632C", Offset = "0x10C632C", VA = "0x10C632C", Slot = "8")]
	public override void BackGroundLoadAsyncUI(int ui)
	{
	}

	[Token(Token = "0x6007AFA")]
	[Address(RVA = "0x10C6678", Offset = "0x10C6678", VA = "0x10C6678")]
	public void OnDelayCommonUI()
	{
	}

	[Token(Token = "0x6007AFB")]
	[Address(RVA = "0x10C2738", Offset = "0x10C2738", VA = "0x10C2738")]
	public void RegisterPopup(IBackbutton backUI)
	{
	}

	[Token(Token = "0x6007AFC")]
	[Address(RVA = "0x10C667C", Offset = "0x10C667C", VA = "0x10C667C")]
	public void UnRegisterPopup(IBackbutton backUI)
	{
	}

	[Token(Token = "0x6007AFD")]
	[Address(RVA = "0x1096A68", Offset = "0x1096A68", VA = "0x1096A68")]
	public void GoBack()
	{
	}

	[Token(Token = "0x6007AFE")]
	[Address(RVA = "0x10C3D20", Offset = "0x10C3D20", VA = "0x10C3D20")]
	protected void PopUIBackButton()
	{
	}

	[Token(Token = "0x6007AFF")]
	[Address(RVA = "0x10C6680", Offset = "0x10C6680", VA = "0x10C6680", Slot = "11")]
	protected override void BackUpdateFunc()
	{
	}

	[Token(Token = "0x6007B00")]
	[Address(RVA = "0x10C683C", Offset = "0x10C683C", VA = "0x10C683C", Slot = "12")]
	protected override bool PreBackStateCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x6007B01")]
	[Address(RVA = "0x10C6C60", Offset = "0x10C6C60", VA = "0x10C6C60", Slot = "13")]
	protected override void BackFunc()
	{
	}

	[Token(Token = "0x6007B02")]
	[Address(RVA = "0x10C70E4", Offset = "0x10C70E4", VA = "0x10C70E4")]
	public void ReqSelectCharPartyMember()
	{
	}

	[Token(Token = "0x6007B03")]
	[Address(RVA = "0x10C7554", Offset = "0x10C7554", VA = "0x10C7554")]
	public void ShowExitWindow()
	{
	}

	[Token(Token = "0x6007B04")]
	[Address(RVA = "0x109C3E4", Offset = "0x109C3E4", VA = "0x109C3E4")]
	public void ShowTopBannerInfo(XLobbyStateTypes lobbyStateType)
	{
	}

	[Token(Token = "0x6007B05")]
	[Address(RVA = "0x10C40B4", Offset = "0x10C40B4", VA = "0x10C40B4")]
	public void LobbyNotiAllEnqueue(bool bShowItemPopup = true)
	{
	}

	[Token(Token = "0x6007B06")]
	[Address(RVA = "0x10C7528", Offset = "0x10C7528", VA = "0x10C7528")]
	public void NextProgressEventNotification()
	{
	}

	[Token(Token = "0x6007B07")]
	[Address(RVA = "0x10C7620", Offset = "0x10C7620", VA = "0x10C7620")]
	public void ShowAttendanceRewards()
	{
	}

	[Token(Token = "0x6007B08")]
	[Address(RVA = "0x10C7664", Offset = "0x10C7664", VA = "0x10C7664")]
	public void ShowEventAttendance()
	{
	}

	[Token(Token = "0x6007B09")]
	[Address(RVA = "0x10C76B0", Offset = "0x10C76B0", VA = "0x10C76B0")]
	public void ShowAchievementNotice()
	{
	}

	[Token(Token = "0x6007B0A")]
	[Address(RVA = "0x10C77BC", Offset = "0x10C77BC", VA = "0x10C77BC")]
	public void ShowBuyButtonPopup(List<CSShopItem> itemInfo)
	{
	}

	[Token(Token = "0x6007B0B")]
	[Address(RVA = "0x10C77C0", Offset = "0x10C77C0", VA = "0x10C77C0")]
	public void ShowEventAttendanceBook()
	{
	}

	[Token(Token = "0x6007B0C")]
	[Address(RVA = "0x10A73F8", Offset = "0x10A73F8", VA = "0x10A73F8")]
	public void ShowWindowBackground(bool bShow)
	{
	}

	[Token(Token = "0x6007B0D")]
	[Address(RVA = "0x10C77C4", Offset = "0x10C77C4", VA = "0x10C77C4")]
	public void ShowMainWindow([Optional] Action<XPanel_Main> onAfterShow)
	{
	}

	[Token(Token = "0x6007B0E")]
	[Address(RVA = "0x10B5E90", Offset = "0x10B5E90", VA = "0x10B5E90")]
	public void ShowPackageShop(PackageShopTabCategory tab = PackageShopTabCategory.None)
	{
	}

	[Token(Token = "0x6007B0F")]
	[Address(RVA = "0x10C7908", Offset = "0x10C7908", VA = "0x10C7908")]
	public void ShowOptionWindow()
	{
	}

	[Token(Token = "0x6007B10")]
	[Address(RVA = "0x10C7914", Offset = "0x10C7914", VA = "0x10C7914")]
	private bool IsFeatureLock(FeatureType featureType, bool showNoti)
	{
		return default(bool);
	}

	[Token(Token = "0x6007B11")]
	[Address(RVA = "0x10B593C", Offset = "0x10B593C", VA = "0x10B593C")]
	public void ShowNormalShopWindow(ShopSubCategory subCategory = ShopSubCategory.None)
	{
	}

	[Token(Token = "0x6007B12")]
	[Address(RVA = "0x10C7BA0", Offset = "0x10C7BA0", VA = "0x10C7BA0")]
	public void ShowPVPShopWindow(ShopSubCategory subCategory = ShopSubCategory.None)
	{
	}

	[Token(Token = "0x6007B13")]
	[Address(RVA = "0x10C7CCC", Offset = "0x10C7CCC", VA = "0x10C7CCC")]
	public void ShowArenaShop(XPanel_ArenaShop.State state = XPanel_ArenaShop.State.None)
	{
	}

	[Token(Token = "0x6007B14")]
	[Address(RVA = "0x10C7E0C", Offset = "0x10C7E0C", VA = "0x10C7E0C")]
	public void ShowMischaShop(ShopSubCategory subCategory = ShopSubCategory.Bargain_Sale)
	{
	}

	[Token(Token = "0x6007B15")]
	[Address(RVA = "0x10C7F4C", Offset = "0x10C7F4C", VA = "0x10C7F4C")]
	public void ShowFriendlyMatch()
	{
	}

	[Token(Token = "0x6007B16")]
	[Address(RVA = "0x10C7F58", Offset = "0x10C7F58", VA = "0x10C7F58")]
	public void ShowCustomRoomList()
	{
	}

	[Token(Token = "0x6007B17")]
	[Address(RVA = "0x10C7F64", Offset = "0x10C7F64", VA = "0x10C7F64")]
	public void ShowRankingRewardListForClan(ClanRankType clanRankType, int myRank, int totalRanker)
	{
	}

	[Token(Token = "0x6007B18")]
	[Address(RVA = "0x10C8170", Offset = "0x10C8170", VA = "0x10C8170")]
	public void ShowRankingRewardListForLadder(RankType rankType, int myRank, int totalRanker)
	{
	}

	[Token(Token = "0x6007B19")]
	[Address(RVA = "0x10C837C", Offset = "0x10C837C", VA = "0x10C837C")]
	public void ShowRankingRewardForLadder(Netdata_Ranker rankerData, int rankerCount, int rankRewardID, RankType rankType)
	{
	}

	[Token(Token = "0x6007B1A")]
	[Address(RVA = "0x10C85DC", Offset = "0x10C85DC", VA = "0x10C85DC")]
	public void ShowRankingRewardForClanWar(ClanRankMetaData clanMetaData, int clanRank, int clanRewardID, ClanRankType clanRankType)
	{
	}

	[Token(Token = "0x6007B1B")]
	[Address(RVA = "0x10C883C", Offset = "0x10C883C", VA = "0x10C883C")]
	public void ShowGachaShopBuyWindow(CSShopItem shopItem, Dictionary<int, RotationItemSet> rotationInfo, bool buyFree = false)
	{
	}

	[Token(Token = "0x6007B1C")]
	[Address(RVA = "0x10C8A10", Offset = "0x10C8A10", VA = "0x10C8A10")]
	public void ShowArenaShopBuyWindow(CSArenaShopItem item)
	{
	}

	[Token(Token = "0x6007B1D")]
	[Address(RVA = "0x10C8D0C", Offset = "0x10C8D0C", VA = "0x10C8D0C")]
	public void ShowShopBuyWindow(IShopItem shopItem, Dictionary<int, RotationItemSet> rotationInfo, [Optional][DefaultParameterValue(false)] bool buyFree, [Optional] Action buyCompleteCallback)
	{
	}

	[Token(Token = "0x6007B1E")]
	[Address(RVA = "0x10C8F34", Offset = "0x10C8F34", VA = "0x10C8F34")]
	public void ShowGachaShopConfirm(IShopItem shopItem, Netdata_BuyShopItem acquisitions, Action rebuy)
	{
	}

	[Token(Token = "0x6007B1F")]
	[Address(RVA = "0x10C9120", Offset = "0x10C9120", VA = "0x10C9120")]
	public void ShowMailbox()
	{
	}

	[Token(Token = "0x6007B20")]
	[Address(RVA = "0x10C912C", Offset = "0x10C912C", VA = "0x10C912C")]
	public void ShowDailyQuest()
	{
	}

	[Token(Token = "0x6007B21")]
	[Address(RVA = "0x10C9138", Offset = "0x10C9138", VA = "0x10C9138")]
	public void ShowUILobbyQeust(QuestGroup group)
	{
	}

	[Token(Token = "0x6007B22")]
	[Address(RVA = "0x10C9264", Offset = "0x10C9264", VA = "0x10C9264")]
	public void RefreshQuestInfo()
	{
	}

	[Token(Token = "0x6007B23")]
	[Address(RVA = "0x10AFCC8", Offset = "0x10AFCC8", VA = "0x10AFCC8")]
	public void RefreshMailbox()
	{
	}

	[Token(Token = "0x6007B24")]
	[Address(RVA = "0x10C937C", Offset = "0x10C937C", VA = "0x10C937C")]
	public void ShowSkyTower()
	{
	}

	[Token(Token = "0x6007B25")]
	[Address(RVA = "0x10C9388", Offset = "0x10C9388", VA = "0x10C9388")]
	public void ShowRandomStage()
	{
	}

	[Token(Token = "0x6007B26")]
	[Address(RVA = "0x10C9520", Offset = "0x10C9520", VA = "0x10C9520")]
	public void ShowFriendlyJoinStage(string roomTitle, string photonRoomTitle, int modeInstanceID, int sectorID)
	{
	}

	[Token(Token = "0x6007B27")]
	[Address(RVA = "0x10C9844", Offset = "0x10C9844", VA = "0x10C9844")]
	public void ShowFriendlyRoomMakeStage(string roomTitle, string password, int modeInstanceID, int sectorID)
	{
	}

	[Token(Token = "0x6007B28")]
	[Address(RVA = "0x10C9B68", Offset = "0x10C9B68", VA = "0x10C9B68")]
	public void ShowCreateCustomRoomStage(CustomRoomInfo roomInfo)
	{
	}

	[Token(Token = "0x6007B29")]
	[Address(RVA = "0x10C9C6C", Offset = "0x10C9C6C", VA = "0x10C9C6C")]
	public void ShowNormalModesView()
	{
	}

	[Token(Token = "0x6007B2A")]
	[Address(RVA = "0x10C9C78", Offset = "0x10C9C78", VA = "0x10C9C78")]
	public void ShowEventModeReadyView(int eventmodeID)
	{
	}

	[Token(Token = "0x6007B2B")]
	[Address(RVA = "0x10C9DA4", Offset = "0x10C9DA4", VA = "0x10C9DA4")]
	public void ShowStage(int modeInstanceID, bool AIMode = false)
	{
	}

	[Token(Token = "0x6007B2C")]
	[Address(RVA = "0x10C9F44", Offset = "0x10C9F44", VA = "0x10C9F44")]
	public void ShowStage(XGameModeType gameModeType, bool AIMode = false)
	{
	}

	[Token(Token = "0x6007B2D")]
	[Address(RVA = "0x10CA0E4", Offset = "0x10CA0E4", VA = "0x10CA0E4")]
	public void ShowLadderSoloReadyView()
	{
	}

	[Token(Token = "0x6007B2E")]
	[Address(RVA = "0x10CA2B8", Offset = "0x10CA2B8", VA = "0x10CA2B8")]
	public void ShowLadderTeamReadyView()
	{
	}

	[Token(Token = "0x6007B2F")]
	[Address(RVA = "0x10CA48C", Offset = "0x10CA48C", VA = "0x10CA48C")]
	public void ShowLobbySpecialDungeonStage(int modeGroupId, int stageNumber)
	{
	}

	[Token(Token = "0x6007B30")]
	[Address(RVA = "0x10CA624", Offset = "0x10CA624", VA = "0x10CA624")]
	public void ShowSpecialSelectDifficulty(int group)
	{
	}

	[Token(Token = "0x6007B31")]
	[Address(RVA = "0x10CA674", Offset = "0x10CA674", VA = "0x10CA674")]
	public void ShowLobbyMissionMain()
	{
	}

	[Token(Token = "0x6007B32")]
	[Address(RVA = "0x10CA680", Offset = "0x10CA680", VA = "0x10CA680")]
	public void ShowLobbyMissionDetail(XGameModeType gameModeType)
	{
	}

	[Token(Token = "0x6007B33")]
	[Address(RVA = "0x10CA7AC", Offset = "0x10CA7AC", VA = "0x10CA7AC")]
	public void ShowCharMain()
	{
	}

	[Token(Token = "0x6007B34")]
	[Address(RVA = "0x10CA928", Offset = "0x10CA928", VA = "0x10CA928")]
	public void ShowPetMain()
	{
	}

	[Token(Token = "0x6007B35")]
	[Address(RVA = "0x10CA934", Offset = "0x10CA934", VA = "0x10CA934")]
	public void ShowCharMainPartySetting(string charUID)
	{
	}

	[Token(Token = "0x6007B36")]
	[Address(RVA = "0x10CAAB4", Offset = "0x10CAAB4", VA = "0x10CAAB4")]
	public void ShowCharMainToDetail(bool playVoiceSound = true)
	{
	}

	[Token(Token = "0x6007B37")]
	[Address(RVA = "0x10CADF4", Offset = "0x10CADF4", VA = "0x10CADF4")]
	public void ShowCharMainToDetailToOptionChange(bool playVoiceSound, string actorCID, XItem item)
	{
	}

	[Token(Token = "0x6007B38")]
	[Address(RVA = "0x10CAE78", Offset = "0x10CAE78", VA = "0x10CAE78")]
	public void ShowCharMainToDetailToSkill(bool playVoiceSound = true)
	{
	}

	[Token(Token = "0x6007B39")]
	[Address(RVA = "0x10CAC00", Offset = "0x10CAC00", VA = "0x10CAC00")]
	public void ShowCharDetail(int nCharID, string cid, bool playVoiceSound = true)
	{
	}

	[Token(Token = "0x6007B3A")]
	[Address(RVA = "0x10CAF84", Offset = "0x10CAF84", VA = "0x10CAF84")]
	public void ShowCharPreview(int nCharID)
	{
	}

	[Token(Token = "0x6007B3B")]
	[Address(RVA = "0x10CB218", Offset = "0x10CB218", VA = "0x10CB218")]
	public void ShowPetDetail(int nCharID, string cid, bool playVoiceSound = true)
	{
	}

	[Token(Token = "0x6007B3C")]
	[Address(RVA = "0x10CB40C", Offset = "0x10CB40C", VA = "0x10CB40C")]
	public void ShowPetMainToDetailToOptionChange(bool playVoiceSound, string actorCID, XItem item)
	{
	}

	[Token(Token = "0x6007B3D")]
	[Address(RVA = "0x10B6268", Offset = "0x10B6268", VA = "0x10B6268")]
	public void ShowInvenExtend()
	{
	}

	[Token(Token = "0x6007B3E")]
	[Address(RVA = "0x10CB480", Offset = "0x10CB480", VA = "0x10CB480")]
	public void ShowIllustratedBook()
	{
	}

	[Token(Token = "0x6007B3F")]
	[Address(RVA = "0x10CB48C", Offset = "0x10CB48C", VA = "0x10CB48C")]
	public void ShowRanking(RankType rankType = RankType.None)
	{
	}

	[Token(Token = "0x6007B40")]
	[Address(RVA = "0x10CB5B8", Offset = "0x10CB5B8", VA = "0x10CB5B8")]
	public void ShowAchievement()
	{
	}

	[Token(Token = "0x6007B41")]
	[Address(RVA = "0x10CB5C4", Offset = "0x10CB5C4", VA = "0x10CB5C4")]
	public void ShowTeamManagement()
	{
	}

	[Token(Token = "0x6007B42")]
	[Address(RVA = "0x10CB5D0", Offset = "0x10CB5D0", VA = "0x10CB5D0")]
	public void ShowTeamManagementRelic()
	{
	}

	[Token(Token = "0x6007B43")]
	[Address(RVA = "0x10CB6D4", Offset = "0x10CB6D4", VA = "0x10CB6D4")]
	public void ShowTeamManagementRelicWithOutMainWindow()
	{
	}

	[Token(Token = "0x6007B44")]
	[Address(RVA = "0x10CB7D8", Offset = "0x10CB7D8", VA = "0x10CB7D8")]
	public void ShowTeamManagementTalentWithOutMainWindow()
	{
	}

	[Token(Token = "0x6007B45")]
	[Address(RVA = "0x10CB8DC", Offset = "0x10CB8DC", VA = "0x10CB8DC")]
	public void ShowFriend()
	{
	}

	[Token(Token = "0x6007B46")]
	[Address(RVA = "0x10CB9E4", Offset = "0x10CB9E4", VA = "0x10CB9E4")]
	public void ShowPVPMain()
	{
	}

	[Token(Token = "0x6007B47")]
	[Address(RVA = "0x10CB9F0", Offset = "0x10CB9F0", VA = "0x10CB9F0")]
	public void ShowNormalModeView()
	{
	}

	[Token(Token = "0x6007B48")]
	[Address(RVA = "0x10CBA1C", Offset = "0x10CBA1C", VA = "0x10CBA1C")]
	public void ShowChallengeMain()
	{
	}

	[Token(Token = "0x6007B49")]
	[Address(RVA = "0x10CBA28", Offset = "0x10CBA28", VA = "0x10CBA28")]
	public void ShowLadderMain()
	{
	}

	[Token(Token = "0x6007B4A")]
	[Address(RVA = "0x10CBA34", Offset = "0x10CBA34", VA = "0x10CBA34")]
	public void ShowSkin(int char_id, string cid, int alreadyLookSkinID = 0)
	{
	}

	[Token(Token = "0x6007B4B")]
	[Address(RVA = "0x10CBC24", Offset = "0x10CBC24", VA = "0x10CBC24")]
	public void ShowClan()
	{
	}

	[Token(Token = "0x6007B4C")]
	[Address(RVA = "0x10CBC30", Offset = "0x10CBC30", VA = "0x10CBC30")]
	public void ShowCharacterSkill(XModuleActor character)
	{
	}

	[Token(Token = "0x6007B4D")]
	[Address(RVA = "0x10CBD34", Offset = "0x10CBD34", VA = "0x10CBD34")]
	public void SetCharSkillSelectCallback(Action action)
	{
	}

	[Token(Token = "0x6007B4E")]
	[Address(RVA = "0x10CBD68", Offset = "0x10CBD68", VA = "0x10CBD68", Slot = "14")]
	public virtual XModuleActor GetCurrentShowCharacter()
	{
		return null;
	}

	[Token(Token = "0x6007B4F")]
	[Address(RVA = "0x10CBE84", Offset = "0x10CBE84", VA = "0x10CBE84", Slot = "15")]
	public virtual XModuleActor GetCurrentShowPet()
	{
		return null;
	}

	[Token(Token = "0x6007B50")]
	[Address(RVA = "0x109C288", Offset = "0x109C288", VA = "0x109C288")]
	public void ShowStateInfo(string state)
	{
	}

	[Token(Token = "0x6007B51")]
	[Address(RVA = "0x10CBFA0", Offset = "0x10CBFA0", VA = "0x10CBFA0")]
	public int GetPVPAvailableMinLv()
	{
		return default(int);
	}

	[Token(Token = "0x6007B52")]
	[Address(RVA = "0x10CC1F0", Offset = "0x10CC1F0", VA = "0x10CC1F0")]
	public int GetChallengeAvailableMinLv()
	{
		return default(int);
	}

	[Token(Token = "0x6007B53")]
	[Address(RVA = "0x109CA64", Offset = "0x109CA64", VA = "0x109CA64")]
	public void SetTopbannerCurrency(List<Currency> currencyList)
	{
	}

	[Token(Token = "0x6007B54")]
	[Address(RVA = "0x109CA98", Offset = "0x109CA98", VA = "0x109CA98")]
	public void SetTopbannerNotiIcons(bool show)
	{
	}

	[Token(Token = "0x6007B55")]
	[Address(RVA = "0x1096014", Offset = "0x1096014", VA = "0x1096014")]
	public void MoveSceneLinkAndGo(string link)
	{
	}

	[Token(Token = "0x6007B56")]
	[Address(RVA = "0x10CC440", Offset = "0x10CC440", VA = "0x10CC440")]
	public Action MoveSceneLink(string link)
	{
		return null;
	}

	[Token(Token = "0x6007B57")]
	[Address(RVA = "0x10CD4C4", Offset = "0x10CD4C4", VA = "0x10CD4C4")]
	public bool IsLobbyState_Main()
	{
		return default(bool);
	}

	[Token(Token = "0x6007B58")]
	[Address(RVA = "0x10CD5D8", Offset = "0x10CD5D8", VA = "0x10CD5D8")]
	public void PauseTopBanner(bool pause)
	{
	}

	[Token(Token = "0x6007B59")]
	[Address(RVA = "0x10CD60C", Offset = "0x10CD60C", VA = "0x10CD60C")]
	public void EnableGameReadyViewStartButton(bool enable)
	{
	}

	[Token(Token = "0x6007B5A")]
	[Address(RVA = "0x10CD748", Offset = "0x10CD748", VA = "0x10CD748")]
	public bool GetGameReadyViewActive()
	{
		return default(bool);
	}

	[Token(Token = "0x6007B5B")]
	[Address(RVA = "0x10CD840", Offset = "0x10CD840", VA = "0x10CD840")]
	public void ShowShopRewardPopup(string title, Netdata_BuyShopItem acquisitions, bool Mail)
	{
	}

	[Token(Token = "0x6007B5C")]
	[Address(RVA = "0x10CD890", Offset = "0x10CD890", VA = "0x10CD890")]
	public void ShowGachaConfirm(CSContentReward rewardContent, bool toMail, string title, [Optional][DefaultParameterValue(true)] bool bShowModel, [Optional] Action onClick)
	{
	}

	[Token(Token = "0x6007B5D")]
	[Address(RVA = "0x10B10BC", Offset = "0x10B10BC", VA = "0x10B10BC")]
	public void ShowGachaConfirm(CSContent rewardContent, bool toMail, string title, [Optional][DefaultParameterValue(true)] bool bShowModel, [Optional] Action onClick)
	{
	}

	[Token(Token = "0x6007B5E")]
	[Address(RVA = "0x10CD908", Offset = "0x10CD908", VA = "0x10CD908")]
	public void ShowGachaConfirm(CSContent rewardContent, bool toMail, string title, string desc, [Optional][DefaultParameterValue(true)] bool bShowModel, [Optional] Action onClick)
	{
	}

	[Token(Token = "0x6007B5F")]
	[Address(RVA = "0x10CD988", Offset = "0x10CD988", VA = "0x10CD988")]
	public void ShowGachaListConfirm(List<CSContent> rewardContentList, bool toMail, string title, [Optional][DefaultParameterValue(true)] bool bShowModel, [Optional] Action onClick)
	{
	}

	[Token(Token = "0x6007B60")]
	[Address(RVA = "0x10CDA00", Offset = "0x10CDA00", VA = "0x10CDA00")]
	public void HideGachaConfirm()
	{
	}

	[Token(Token = "0x6007B61")]
	[Address(RVA = "0x10CDB50", Offset = "0x10CDB50", VA = "0x10CDB50")]
	public void ShowWaitingMatch(string title, int avgWaitTime, Action onCancel)
	{
	}

	[Token(Token = "0x6007B62")]
	[Address(RVA = "0x10CDBBC", Offset = "0x10CDBBC", VA = "0x10CDBBC")]
	public bool IsShowWaitingMatch()
	{
		return default(bool);
	}

	[Token(Token = "0x6007B63")]
	[Address(RVA = "0x10CDCCC", Offset = "0x10CDCCC", VA = "0x10CDCCC")]
	public void ShowEventAttendance4Day()
	{
	}

	[Token(Token = "0x6007B64")]
	[Address(RVA = "0x10B1134", Offset = "0x10B1134", VA = "0x10B1134")]
	public void ShowRewardBox(string strTitle, string strMessage, XMessageBoxButtons nButtons, string strBottomText, [Optional] Action delegateOK, [Optional] CSContent[] rewards, bool mail = false, bool bCenter = false)
	{
	}

	[Token(Token = "0x6007B65")]
	[Address(RVA = "0x1096928", Offset = "0x1096928", VA = "0x1096928")]
	public void ShowRewardBox(string strTitle, string strMessage, XMessageBoxButtons nButtons, Action delegateOK, CSContentReward[] rewards, bool mail = false, bool bCenter = false)
	{
	}

	[Token(Token = "0x6007B66")]
	[Address(RVA = "0x10B02BC", Offset = "0x10B02BC", VA = "0x10B02BC")]
	public void ShowPartitionlMessageBox(string strTitle, string strMessage, string strMessage2, XMessageBoxButtons nButtons, [Optional] Action delegateOK, [Optional] Action delegateCancle, [Optional] Action delegateLink, [Optional][DefaultParameterValue("")] string strLink, [Optional][DefaultParameterValue(false)] bool forceAlignmentLeft, [Optional] string okText, [Optional] string cancleText, [Optional] string linkText, int backgroundWidth = 606, int backgroundHeight = 406)
	{
	}

	[Token(Token = "0x6007B67")]
	[Address(RVA = "0x10CDD10", Offset = "0x10CDD10", VA = "0x10CDD10")]
	public void HideWaitingMatch()
	{
	}

	[Token(Token = "0x6007B68")]
	[Address(RVA = "0x10CDE04", Offset = "0x10CDE04", VA = "0x10CDE04")]
	public void MatchTimeOut()
	{
	}

	[Token(Token = "0x6007B69")]
	[Address(RVA = "0x10CDEF8", Offset = "0x10CDEF8", VA = "0x10CDEF8")]
	public int GetMatchWaitTime()
	{
		return default(int);
	}

	[Token(Token = "0x6007B6A")]
	[Address(RVA = "0x10CDFDC", Offset = "0x10CDFDC", VA = "0x10CDFDC")]
	public bool GetAchievementPopupActive()
	{
		return default(bool);
	}

	[Token(Token = "0x6007B6B")]
	[Address(RVA = "0x10CE0C4", Offset = "0x10CE0C4", VA = "0x10CE0C4")]
	public bool GetEventNotificationState()
	{
		return default(bool);
	}

	[Token(Token = "0x6007B6C")]
	[Address(RVA = "0x10CE1B8", Offset = "0x10CE1B8", VA = "0x10CE1B8")]
	public XLobbyStateTypes GetLobbyStateTypes()
	{
		return default(XLobbyStateTypes);
	}

	[Token(Token = "0x6007B6D")]
	[Address(RVA = "0x10CE1C0", Offset = "0x10CE1C0", VA = "0x10CE1C0")]
	public void SetAchievementTab(QuestGroup group)
	{
	}

	[Token(Token = "0x6007B6E")]
	[Address(RVA = "0x10CE1F4", Offset = "0x10CE1F4", VA = "0x10CE1F4")]
	public void ShowHelp(HelpLink nLink)
	{
	}

	[Token(Token = "0x6007B6F")]
	[Address(RVA = "0x10CE320", Offset = "0x10CE320", VA = "0x10CE320")]
	public void ShowHelp(int helpID)
	{
	}

	[Token(Token = "0x6007B70")]
	[Address(RVA = "0x10C6300", Offset = "0x10C6300", VA = "0x10C6300")]
	public void ShowMissionFailPopup()
	{
	}

	[Token(Token = "0x6007B71")]
	[Address(RVA = "0x10CE44C", Offset = "0x10CE44C", VA = "0x10CE44C")]
	public void SetHideLastState()
	{
	}

	[Token(Token = "0x6007B72")]
	[Address(RVA = "0x10CE450", Offset = "0x10CE450", VA = "0x10CE450")]
	public void SetSelectedCharacterDetail(int nCharID, string charUID)
	{
	}

	[Token(Token = "0x6007B73")]
	[Address(RVA = "0x10CE48C", Offset = "0x10CE48C", VA = "0x10CE48C")]
	public void SetQuestTabsBadge(int number)
	{
	}

	[Token(Token = "0x6007B74")]
	[Address(RVA = "0x10CE4C0", Offset = "0x10CE4C0", VA = "0x10CE4C0")]
	public void SetSkyTowerStageInfo()
	{
	}

	[Token(Token = "0x6007B75")]
	[Address(RVA = "0x10CE4EC", Offset = "0x10CE4EC", VA = "0x10CE4EC")]
	public void ShowGroupInviteMessagePopup(string groupMaster, Action onClickAccept, Action onClickReject)
	{
	}

	[Token(Token = "0x6007B76")]
	[Address(RVA = "0x10CE688", Offset = "0x10CE688", VA = "0x10CE688")]
	public void HideGroupInviteMessagePopup()
	{
	}

	[Token(Token = "0x6007B77")]
	[Address(RVA = "0x10CE798", Offset = "0x10CE798", VA = "0x10CE798")]
	public void ShowGroupReadyView()
	{
	}

	[Token(Token = "0x6007B78")]
	[Address(RVA = "0x10CE7A4", Offset = "0x10CE7A4", VA = "0x10CE7A4")]
	public void ShowOtherUserPopup(NetData_OtherUserMetaData otherUserMetaData)
	{
	}

	[Token(Token = "0x6007B79")]
	[Address(RVA = "0x10CE7D8", Offset = "0x10CE7D8", VA = "0x10CE7D8")]
	public void GoToInventory()
	{
	}

	[Token(Token = "0x6007B7A")]
	[Address(RVA = "0x10CE8F8", Offset = "0x10CE8F8", VA = "0x10CE8F8")]
	public void OpenDownloadPopup()
	{
	}

	[Token(Token = "0x6007B7B")]
	[Address(RVA = "0x10CEA3C", Offset = "0x10CEA3C", VA = "0x10CEA3C")]
	private void ShowMesseageBox_DownLoad(bool ready, string storeUrl)
	{
	}

	[Token(Token = "0x6007B7C")]
	[Address(RVA = "0x10CEE18", Offset = "0x10CEE18", VA = "0x10CEE18")]
	private static void _003CReqSelectCharPartyMember_003Em__51D(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
	{
	}
}
