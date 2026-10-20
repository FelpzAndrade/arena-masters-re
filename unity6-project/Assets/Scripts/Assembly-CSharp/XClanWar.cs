using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CS;
using ExitGames.Client.Photon;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

[Token(Token = "0x20003F4")]
public class XClanWar : IPhotonPlayerConnectListener
{
	[Token(Token = "0x20003F5")]
	private enum NotificationState
	{
		[Token(Token = "0x40013D5")]
		None = 0,
		[Token(Token = "0x40013D6")]
		NullError = 1,
		[Token(Token = "0x40013D7")]
		NotOpenFeature = 2,
		[Token(Token = "0x40013D8")]
		NotEnoughLevel = 3,
		[Token(Token = "0x40013D9")]
		NotPlacementTest = 4,
		[Token(Token = "0x40013DA")]
		ModeClosed = 5,
		[Token(Token = "0x40013DB")]
		LadderMatching = 6
	}

	[Token(Token = "0x20003F6")]
	private sealed class _003CJoinParty_003Ec__AnonStoreyF3
	{
		[Token(Token = "0x40013DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal long partyKey;

		[Token(Token = "0x40013DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal XClanWar _003C_003Ef__this;

		[Token(Token = "0x60020A3")]
		[Address(RVA = "0x1983B24", Offset = "0x1983B24", VA = "0x1983B24")]
		public _003CJoinParty_003Ec__AnonStoreyF3()
		{
		}

		[Token(Token = "0x60020A4")]
		[Address(RVA = "0x1983B2C", Offset = "0x1983B2C", VA = "0x1983B2C")]
		internal void _003C_003Em__B2()
		{
		}

		[Token(Token = "0x60020A5")]
		[Address(RVA = "0x1983DD4", Offset = "0x1983DD4", VA = "0x1983DD4")]
		internal void _003C_003Em__B3()
		{
		}
	}

	[Token(Token = "0x20003F7")]
	private sealed class _003COnCreateParty_003Ec__AnonStoreyF4
	{
		[Token(Token = "0x40013DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal DTPartyInfo partyInfo;

		[Token(Token = "0x60020A6")]
		[Address(RVA = "0x1983EA8", Offset = "0x1983EA8", VA = "0x1983EA8")]
		public _003COnCreateParty_003Ec__AnonStoreyF4()
		{
		}

		[Token(Token = "0x60020A7")]
		[Address(RVA = "0x1983EB0", Offset = "0x1983EB0", VA = "0x1983EB0")]
		internal void _003C_003Em__B4(IClanWarListener listener)
		{
		}
	}

	[Token(Token = "0x20003F8")]
	private sealed class _003COnJoinParty_003Ec__AnonStoreyF5
	{
		[Token(Token = "0x40013DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal DTPartyInfo partyInfo;

		[Token(Token = "0x60020A8")]
		[Address(RVA = "0x1983FBC", Offset = "0x1983FBC", VA = "0x1983FBC")]
		public _003COnJoinParty_003Ec__AnonStoreyF5()
		{
		}

		[Token(Token = "0x60020A9")]
		[Address(RVA = "0x1983FC4", Offset = "0x1983FC4", VA = "0x1983FC4")]
		internal void _003C_003Em__B5(IClanWarListener listener)
		{
		}
	}

	[Token(Token = "0x20003F9")]
	private sealed class _003COnRefreshClanParty_003Ec__AnonStoreyF6
	{
		[Token(Token = "0x40013E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal DTPartyInfo partyInfo;

		[Token(Token = "0x60020AA")]
		[Address(RVA = "0x1984544", Offset = "0x1984544", VA = "0x1984544")]
		public _003COnRefreshClanParty_003Ec__AnonStoreyF6()
		{
		}

		[Token(Token = "0x60020AB")]
		[Address(RVA = "0x198454C", Offset = "0x198454C", VA = "0x198454C")]
		internal void _003C_003Em__B6(IClanWarListener listener)
		{
		}
	}

	[Token(Token = "0x20003FA")]
	private sealed class _003COnLeaveParty_003Ec__AnonStoreyF7
	{
		[Token(Token = "0x40013E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal long partyKey;

		[Token(Token = "0x60020AC")]
		[Address(RVA = "0x19840D8", Offset = "0x19840D8", VA = "0x19840D8")]
		public _003COnLeaveParty_003Ec__AnonStoreyF7()
		{
		}

		[Token(Token = "0x60020AD")]
		[Address(RVA = "0x19840E0", Offset = "0x19840E0", VA = "0x19840E0")]
		internal void _003C_003Em__B8(IClanWarListener listener)
		{
		}
	}

	[Token(Token = "0x20003FB")]
	private sealed class _003COnLeavePartyNotify_003Ec__AnonStoreyF8
	{
		[Token(Token = "0x40013E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal DTPartyInfo partyInfo;

		[Token(Token = "0x60020AE")]
		[Address(RVA = "0x19841F4", Offset = "0x19841F4", VA = "0x19841F4")]
		public _003COnLeavePartyNotify_003Ec__AnonStoreyF8()
		{
		}

		[Token(Token = "0x60020AF")]
		[Address(RVA = "0x19841FC", Offset = "0x19841FC", VA = "0x19841FC")]
		internal void _003C_003Em__BB(IClanWarListener listener)
		{
		}
	}

	[Token(Token = "0x20003FC")]
	private sealed class _003COnPartyBreak_003Ec__AnonStoreyF9
	{
		[Token(Token = "0x40013E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal long partyKey;

		[Token(Token = "0x60020B0")]
		[Address(RVA = "0x1984428", Offset = "0x1984428", VA = "0x1984428")]
		public _003COnPartyBreak_003Ec__AnonStoreyF9()
		{
		}

		[Token(Token = "0x60020B1")]
		[Address(RVA = "0x1984430", Offset = "0x1984430", VA = "0x1984430")]
		internal void _003C_003Em__BD(IClanWarListener listener)
		{
		}
	}

	[Token(Token = "0x20003FD")]
	private sealed class _003COnMatchMakingSuccess_003Ec__AnonStoreyFA
	{
		[Token(Token = "0x40013E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal long partyKey;

		[Token(Token = "0x60020B2")]
		[Address(RVA = "0x198430C", Offset = "0x198430C", VA = "0x198430C")]
		public _003COnMatchMakingSuccess_003Ec__AnonStoreyFA()
		{
		}

		[Token(Token = "0x60020B3")]
		[Address(RVA = "0x1984314", Offset = "0x1984314", VA = "0x1984314")]
		internal void _003C_003Em__C2(IClanWarListener listener)
		{
		}
	}

	[Token(Token = "0x20003FE")]
	private sealed class _003CChatLeave_003Ec__AnonStoreyFB
	{
		[Token(Token = "0x40013E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal Action leaveAction;

		[Token(Token = "0x40013E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal XClanWar _003C_003Ef__this;

		[Token(Token = "0x60020B4")]
		[Address(RVA = "0x1ACC6E0", Offset = "0x1ACC6E0", VA = "0x1ACC6E0")]
		public _003CChatLeave_003Ec__AnonStoreyFB()
		{
		}

		[Token(Token = "0x60020B5")]
		[Address(RVA = "0x1ACD71C", Offset = "0x1ACD71C", VA = "0x1ACD71C")]
		internal void _003C_003Em__C4()
		{
		}

		[Token(Token = "0x60020B6")]
		[Address(RVA = "0x1ACD818", Offset = "0x1ACD818", VA = "0x1ACD818")]
		internal void _003C_003Em__C6()
		{
		}

		[Token(Token = "0x60020B7")]
		[Address(RVA = "0x1ACD900", Offset = "0x1ACD900", VA = "0x1ACD900")]
		internal void _003C_003Em__C9(IClanWarListener listener)
		{
		}
	}

	[Token(Token = "0x20003FF")]
	private sealed class _003CCheckClanWarPlay_003Ec__AnonStoreyFC
	{
		[Token(Token = "0x40013E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal Action _onStartSuccess;

		[Token(Token = "0x40013E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal Action _onStartFail;

		[Token(Token = "0x40013E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal XClanWar _003C_003Ef__this;

		[Token(Token = "0x60020B8")]
		[Address(RVA = "0x1983860", Offset = "0x1983860", VA = "0x1983860")]
		public _003CCheckClanWarPlay_003Ec__AnonStoreyFC()
		{
		}

		[Token(Token = "0x60020B9")]
		[Address(RVA = "0x1983868", Offset = "0x1983868", VA = "0x1983868")]
		internal void _003C_003Em__C7()
		{
		}

		[Token(Token = "0x60020BA")]
		[Address(RVA = "0x1983A2C", Offset = "0x1983A2C", VA = "0x1983A2C")]
		internal void _003C_003Em__C8()
		{
		}
	}

	[Token(Token = "0x40013C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool IsOpenFeature;

	[Token(Token = "0x40013C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private List<IClanWarListener> m_listeners;

	[Token(Token = "0x40013C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public readonly int MaxPlayer;

	[Token(Token = "0x40013C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private bool m_isMatching;

	[Token(Token = "0x40013C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private long m_tmpPartyKey;

	[Token(Token = "0x40013C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private CSGameOpenModeInfo m_gameOpenModeInfo;

	[Token(Token = "0x40013C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private bool m_IsClickHanding;

	[Token(Token = "0x40013C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
	private bool m_isLadderMatch;

	[Token(Token = "0x40013C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private XGameData prevGameData;

	[Token(Token = "0x40013C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private DTPartyInfo MyParty__BackingField;

	[Token(Token = "0x40013CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private XClanWarPartyCache PartyCache__BackingField;

	[Token(Token = "0x40013CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private Netdata_Clan ClanData__BackingField;

	[Token(Token = "0x40013CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static Action<IClanWarListener> _003C_003Ef__am_0024cacheC;

	[Token(Token = "0x40013CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Action<IClanWarListener> _003C_003Ef__am_0024cacheD;

	[Token(Token = "0x40013CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private static Action<IClanWarListener> _003C_003Ef__am_0024cacheE;

	[Token(Token = "0x40013CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static Action<IClanWarListener> _003C_003Ef__am_0024cacheF;

	[Token(Token = "0x40013D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private static Action<IClanWarListener> _003C_003Ef__am_0024cache10;

	[Token(Token = "0x40013D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static Action<IClanWarListener> _003C_003Ef__am_0024cache11;

	[Token(Token = "0x40013D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private static Action<IClanWarListener> _003C_003Ef__am_0024cache12;

	[Token(Token = "0x40013D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static Action _003C_003Ef__am_0024cache13;

	[Token(Token = "0x17000575")]
	private DTPartyInfo MyParty
	{
		[Token(Token = "0x6002056")]
		[Address(RVA = "0x1AC7684", Offset = "0x1AC7684", VA = "0x1AC7684")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002057")]
		[Address(RVA = "0x1AC768C", Offset = "0x1AC768C", VA = "0x1AC768C")]
		set
		{
		}
	}

	[Token(Token = "0x17000576")]
	public XClanWarPartyCache PartyCache
	{
		[Token(Token = "0x6002058")]
		[Address(RVA = "0x1AC7694", Offset = "0x1AC7694", VA = "0x1AC7694")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002059")]
		[Address(RVA = "0x1AC75F8", Offset = "0x1AC75F8", VA = "0x1AC75F8")]
		private set
		{
		}
	}

	[Token(Token = "0x17000577")]
	public Netdata_Clan ClanData
	{
		[Token(Token = "0x600205A")]
		[Address(RVA = "0x1AC769C", Offset = "0x1AC769C", VA = "0x1AC769C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600205B")]
		[Address(RVA = "0x1AC76A4", Offset = "0x1AC76A4", VA = "0x1AC76A4")]
		private set
		{
		}
	}

	[Token(Token = "0x17000578")]
	public bool IsLadderMatch
	{
		[Token(Token = "0x600205C")]
		[Address(RVA = "0x1AC76AC", Offset = "0x1AC76AC", VA = "0x1AC76AC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600205D")]
		[Address(RVA = "0x1AC76B4", Offset = "0x1AC76B4", VA = "0x1AC76B4")]
		set
		{
		}
	}

	[Token(Token = "0x6002054")]
	[Address(RVA = "0x1AC6460", Offset = "0x1AC6460", VA = "0x1AC6460")]
	public XClanWar()
	{
	}

	[Token(Token = "0x600205E")]
	[Address(RVA = "0x1AC778C", Offset = "0x1AC778C", VA = "0x1AC778C")]
	private void ListnerAction(Action<IClanWarListener> action)
	{
	}

	[Token(Token = "0x600205F")]
	[Address(RVA = "0x1AC7898", Offset = "0x1AC7898", VA = "0x1AC7898")]
	public void AddListener(IClanWarListener listener)
	{
	}

	[Token(Token = "0x6002060")]
	[Address(RVA = "0x1AC7970", Offset = "0x1AC7970", VA = "0x1AC7970")]
	public void RemoveListener(IClanWarListener listener)
	{
	}

	[Token(Token = "0x6002061")]
	[Address(RVA = "0x1AC7A48", Offset = "0x1AC7A48", VA = "0x1AC7A48")]
	public CompletedClanMember GetClanMemberByName(string nickname)
	{
		return null;
	}

	[Token(Token = "0x6002062")]
	[Address(RVA = "0x1AC7AF8", Offset = "0x1AC7AF8", VA = "0x1AC7AF8")]
	public bool IsInParty()
	{
		return default(bool);
	}

	[Token(Token = "0x6002063")]
	[Address(RVA = "0x1AC7B08", Offset = "0x1AC7B08", VA = "0x1AC7B08")]
	public bool IsMyParty(string nickname)
	{
		return default(bool);
	}

	[Token(Token = "0x6002064")]
	[Address(RVA = "0x1AC7C4C", Offset = "0x1AC7C4C", VA = "0x1AC7C4C")]
	public long GetMyPartyKey()
	{
		return default(long);
	}

	[Token(Token = "0x6002065")]
	[Address(RVA = "0x1AC7C68", Offset = "0x1AC7C68", VA = "0x1AC7C68")]
	public bool IsPartyMaster()
	{
		return default(bool);
	}

	[Token(Token = "0x6002066")]
	[Address(RVA = "0x1AC6634", Offset = "0x1AC6634", VA = "0x1AC6634")]
	internal void Clear()
	{
	}

	[Token(Token = "0x6002067")]
	[Address(RVA = "0x1AC7D78", Offset = "0x1AC7D78", VA = "0x1AC7D78")]
	public bool IsValidClanWar()
	{
		return default(bool);
	}

	[Token(Token = "0x6002068")]
	[Address(RVA = "0x1AC7EF0", Offset = "0x1AC7EF0", VA = "0x1AC7EF0")]
	public void ValidClanWarNotificationUseState()
	{
	}

	[Token(Token = "0x6002069")]
	[Address(RVA = "0x1AC7D98", Offset = "0x1AC7D98", VA = "0x1AC7D98")]
	private NotificationState IsTotalValidClanWarEnable()
	{
		return default(NotificationState);
	}

	[Token(Token = "0x600206A")]
	[Address(RVA = "0x1AC844C", Offset = "0x1AC844C", VA = "0x1AC844C")]
	private bool EnableLevelCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x600206B")]
	[Address(RVA = "0x1AC8708", Offset = "0x1AC8708", VA = "0x1AC8708")]
	public bool IsNearestClanWarModeOpen()
	{
		return default(bool);
	}

	[Token(Token = "0x600206C")]
	[Address(RVA = "0x1AC858C", Offset = "0x1AC858C", VA = "0x1AC858C")]
	public bool IsClanWarModeOpen()
	{
		return default(bool);
	}

	[Token(Token = "0x600206D")]
	[Address(RVA = "0x1AC8884", Offset = "0x1AC8884", VA = "0x1AC8884")]
	public TimeSpan GetRemainTimeUseStartTime()
	{
		return default(TimeSpan);
	}

	[Token(Token = "0x600206E")]
	[Address(RVA = "0x1AC8A4C", Offset = "0x1AC8A4C", VA = "0x1AC8A4C")]
	public TimeSpan GetRemainTimeUseEndTime()
	{
		return default(TimeSpan);
	}

	[Token(Token = "0x600206F")]
	[Address(RVA = "0x1AC8C14", Offset = "0x1AC8C14", VA = "0x1AC8C14")]
	private bool IsMatching()
	{
		return default(bool);
	}

	[Token(Token = "0x6002070")]
	[Address(RVA = "0x1AC8C1C", Offset = "0x1AC8C1C", VA = "0x1AC8C1C")]
	public bool TryResponseError(ApiReturnCode errno, string errmsg, JObject json)
	{
		return default(bool);
	}

	[Token(Token = "0x6002071")]
	[Address(RVA = "0x1AC9100", Offset = "0x1AC9100", VA = "0x1AC9100")]
	public bool TryResponseError(OperationResponse response)
	{
		return default(bool);
	}

	[Token(Token = "0x6002072")]
	[Address(RVA = "0x1AC8DE0", Offset = "0x1AC8DE0", VA = "0x1AC8DE0")]
	private void TryGetStringByApiReturnCode(ApiReturnCode errno, out string title, out string message)
	{
		message = default;
		title = default;
	}

	[Token(Token = "0x6002073")]
	[Address(RVA = "0x1AC9670", Offset = "0x1AC9670", VA = "0x1AC9670")]
	private void TryGetStringByOperationResponse(OperationResponse response, out string title, out string message)
	{
		message = default;
		title = default;
	}

	[Token(Token = "0x6002074")]
	[Address(RVA = "0x1AC9A80", Offset = "0x1AC9A80", VA = "0x1AC9A80")]
	public void CreateParty()
	{
	}

	[Token(Token = "0x6002075")]
	[Address(RVA = "0x1AC9DEC", Offset = "0x1AC9DEC", VA = "0x1AC9DEC")]
	public bool JoinParty(long partyKey)
	{
		return default(bool);
	}

	[Token(Token = "0x6002076")]
	[Address(RVA = "0x1AC9F58", Offset = "0x1AC9F58", VA = "0x1AC9F58")]
	public bool CheckRefreshClanParty(long partyKey)
	{
		return default(bool);
	}

	[Token(Token = "0x6002077")]
	[Address(RVA = "0x1AC9FA8", Offset = "0x1AC9FA8", VA = "0x1AC9FA8")]
	public void RefreshClanParty(long partyKey)
	{
	}

	[Token(Token = "0x6002078")]
	[Address(RVA = "0x1ACA1B0", Offset = "0x1ACA1B0", VA = "0x1ACA1B0")]
	public void LeaveParty()
	{
	}

	[Token(Token = "0x6002079")]
	[Address(RVA = "0x1ACA484", Offset = "0x1ACA484", VA = "0x1ACA484")]
	public bool GetClanPartyList()
	{
		return default(bool);
	}

	[Token(Token = "0x600207A")]
	[Address(RVA = "0x1ACA774", Offset = "0x1ACA774", VA = "0x1ACA774")]
	public bool StartGame()
	{
		return default(bool);
	}

	[Token(Token = "0x600207B")]
	[Address(RVA = "0x1AC9B88", Offset = "0x1AC9B88", VA = "0x1AC9B88")]
	private bool CheckClickHandling()
	{
		return default(bool);
	}

	[Token(Token = "0x600207C")]
	[Address(RVA = "0x1AC9594", Offset = "0x1AC9594", VA = "0x1AC9594")]
	private void ReleaseClickHandling()
	{
	}

	[Token(Token = "0x600207D")]
	[Address(RVA = "0x1ACA9AC", Offset = "0x1ACA9AC", VA = "0x1ACA9AC")]
	private void MatchCancel()
	{
	}

	[Token(Token = "0x600207E")]
	[Address(RVA = "0x1ACA970", Offset = "0x1ACA970", VA = "0x1ACA970")]
	private bool TryCheckOpen()
	{
		return default(bool);
	}

	[Token(Token = "0x600207F")]
	[Address(RVA = "0x1AC6870", Offset = "0x1AC6870", VA = "0x1AC6870")]
	public void OnUpdateClanData(Netdata_Clan data)
	{
	}

	[Token(Token = "0x6002080")]
	[Address(RVA = "0x1ACAB9C", Offset = "0x1ACAB9C", VA = "0x1ACAB9C")]
	public void OnUpdateParty(DTPartyInfo party)
	{
	}

	[Token(Token = "0x6002081")]
	[Address(RVA = "0x1ACABA4", Offset = "0x1ACABA4", VA = "0x1ACABA4")]
	public void OnCreateParty(DTPartyInfo partyInfo)
	{
	}

	[Token(Token = "0x6002082")]
	[Address(RVA = "0x1ACACB0", Offset = "0x1ACACB0", VA = "0x1ACACB0")]
	public void OnJoinParty(DTPartyInfo partyInfo)
	{
	}

	[Token(Token = "0x6002083")]
	[Address(RVA = "0x1ACAE14", Offset = "0x1ACAE14", VA = "0x1ACAE14")]
	public void OnRefreshClanParty(DTPartyInfo partyInfo)
	{
	}

	[Token(Token = "0x6002084")]
	[Address(RVA = "0x1ACAF20", Offset = "0x1ACAF20", VA = "0x1ACAF20")]
	public void OnLeaveParty()
	{
	}

	[Token(Token = "0x6002085")]
	[Address(RVA = "0x1ACB430", Offset = "0x1ACB430", VA = "0x1ACB430")]
	public void OnLeavePartyNotify(DTPartyInfo partyInfo)
	{
	}

	[Token(Token = "0x6002086")]
	[Address(RVA = "0x1ACB874", Offset = "0x1ACB874", VA = "0x1ACB874")]
	public bool OnPartyBreak()
	{
		return default(bool);
	}

	[Token(Token = "0x6002087")]
	[Address(RVA = "0x1AC97B0", Offset = "0x1AC97B0", VA = "0x1AC97B0")]
	public void ErrorPartyBreak(long partyKey = -1L)
	{
	}

	[Token(Token = "0x6002088")]
	[Address(RVA = "0x1ACBB4C", Offset = "0x1ACBB4C", VA = "0x1ACBB4C")]
	public void OnClanMatchStart()
	{
	}

	[Token(Token = "0x6002089")]
	[Address(RVA = "0x1ACBC24", Offset = "0x1ACBC24", VA = "0x1ACBC24")]
	public void OnClanMatchCancel(string nickName)
	{
	}

	[Token(Token = "0x600208A")]
	[Address(RVA = "0x1ACBEA4", Offset = "0x1ACBEA4", VA = "0x1ACBEA4")]
	public void OnMatchMakingSuccess()
	{
	}

	[Token(Token = "0x600208B")]
	[Address(RVA = "0x1ACC11C", Offset = "0x1ACC11C", VA = "0x1ACC11C")]
	public void OnUpdatePartyList(DTUpdateClanPartyList dtClanPartyList)
	{
	}

	[Token(Token = "0x600208C")]
	[Address(RVA = "0x1ACC194", Offset = "0x1ACC194", VA = "0x1ACC194")]
	public void ChatLeave([Optional][DefaultParameterValue(-1L)] long partyKey, [Optional] Action leaveAction)
	{
	}

	[Token(Token = "0x600208D")]
	[Address(RVA = "0x1ACC6E8", Offset = "0x1ACC6E8", VA = "0x1ACC6E8")]
	public void DisconnectClanParty()
	{
	}

	[Token(Token = "0x600208E")]
	[Address(RVA = "0x1ACC710", Offset = "0x1ACC710", VA = "0x1ACC710", Slot = "7")]
	public void OnDisconnectedFromPhoton()
	{
	}

	[Token(Token = "0x600208F")]
	[Address(RVA = "0x1ACC738", Offset = "0x1ACC738", VA = "0x1ACC738", Slot = "8")]
	public void OnDisconnectedFromPhoton(DisconnectCause cause)
	{
	}

	[Token(Token = "0x6002090")]
	[Address(RVA = "0x1ACC760", Offset = "0x1ACC760", VA = "0x1ACC760", Slot = "4")]
	public void OnPhotonPlayerConnected(PhotonPlayer player)
	{
	}

	[Token(Token = "0x6002091")]
	[Address(RVA = "0x1ACC764", Offset = "0x1ACC764", VA = "0x1ACC764", Slot = "5")]
	public void OnPhotonPlayerDisconnected(PhotonPlayer player)
	{
	}

	[Token(Token = "0x6002092")]
	[Address(RVA = "0x1ACC768", Offset = "0x1ACC768", VA = "0x1ACC768", Slot = "6")]
	public void OnMasterClientSwitched(PhotonPlayer player)
	{
	}

	[Token(Token = "0x6002093")]
	[Address(RVA = "0x1ACC76C", Offset = "0x1ACC76C", VA = "0x1ACC76C", Slot = "9")]
	public void OnJoinedRoom()
	{
	}

	[Token(Token = "0x6002094")]
	[Address(RVA = "0x1ACB35C", Offset = "0x1ACB35C", VA = "0x1ACB35C")]
	public void ResetGameData()
	{
	}

	[Token(Token = "0x6002095")]
	[Address(RVA = "0x1AC9BA8", Offset = "0x1AC9BA8", VA = "0x1AC9BA8")]
	private bool CheckClanWarPlay(Action onStartSuccess, Action onStartFail)
	{
		return default(bool);
	}

	[Token(Token = "0x6002096")]
	[Address(RVA = "0x1ACC770", Offset = "0x1ACC770", VA = "0x1ACC770")]
	public bool CheckClanWarPlay(int sectorID, XGameModeType gameMode, MatchType matchType, Action _onStartSuccess, Action _onStartFail)
	{
		return default(bool);
	}

	[Token(Token = "0x6002097")]
	[Address(RVA = "0x1ACC9AC", Offset = "0x1ACC9AC", VA = "0x1ACC9AC")]
	private void _003CCreateParty_003Em__B0()
	{
	}

	[Token(Token = "0x6002098")]
	[Address(RVA = "0x1ACCC58", Offset = "0x1ACCC58", VA = "0x1ACCC58")]
	private void _003CCreateParty_003Em__B1()
	{
	}

	[Token(Token = "0x6002099")]
	[Address(RVA = "0x1ACCD14", Offset = "0x1ACCD14", VA = "0x1ACCD14")]
	private static void _003COnLeaveParty_003Em__B7(IClanWarListener listener)
	{
	}

	[Token(Token = "0x600209A")]
	[Address(RVA = "0x1ACCE18", Offset = "0x1ACCE18", VA = "0x1ACCE18")]
	private static void _003COnLeaveParty_003Em__B9(IClanWarListener listener)
	{
	}

	[Token(Token = "0x600209B")]
	[Address(RVA = "0x1ACCF1C", Offset = "0x1ACCF1C", VA = "0x1ACCF1C")]
	private static void _003COnLeavePartyNotify_003Em__BA(IClanWarListener listener)
	{
	}

	[Token(Token = "0x600209C")]
	[Address(RVA = "0x1ACD020", Offset = "0x1ACD020", VA = "0x1ACD020")]
	private static void _003COnLeavePartyNotify_003Em__BC(IClanWarListener listener)
	{
	}

	[Token(Token = "0x600209D")]
	[Address(RVA = "0x1ACD124", Offset = "0x1ACD124", VA = "0x1ACD124")]
	private static void _003COnPartyBreak_003Em__BE(IClanWarListener listener)
	{
	}

	[Token(Token = "0x600209E")]
	[Address(RVA = "0x1ACD228", Offset = "0x1ACD228", VA = "0x1ACD228")]
	private void _003CErrorPartyBreak_003Em__BF(IClanWarListener listener)
	{
	}

	[Token(Token = "0x600209F")]
	[Address(RVA = "0x1ACD33C", Offset = "0x1ACD33C", VA = "0x1ACD33C")]
	private void _003COnClanMatchStart_003Em__C0(IClanWarListener listener)
	{
	}

	[Token(Token = "0x60020A0")]
	[Address(RVA = "0x1ACD44C", Offset = "0x1ACD44C", VA = "0x1ACD44C")]
	private static void _003COnClanMatchCancel_003Em__C1(IClanWarListener listener)
	{
	}

	[Token(Token = "0x60020A1")]
	[Address(RVA = "0x1ACD550", Offset = "0x1ACD550", VA = "0x1ACD550")]
	private static void _003COnMatchMakingSuccess_003Em__C3(IClanWarListener listener)
	{
	}

	[Token(Token = "0x60020A2")]
	[Address(RVA = "0x1ACD654", Offset = "0x1ACD654", VA = "0x1ACD654")]
	private static void _003CChatLeave_003Em__C5()
	{
	}
}
