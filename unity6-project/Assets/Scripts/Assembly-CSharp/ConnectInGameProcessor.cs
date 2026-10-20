using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200082E")]
internal class ConnectInGameProcessor : IConnectProcessor
{
	[Token(Token = "0x200082F")]
	private sealed class _003CTryInGameJoin_003Ec__Iterator8A : IDisposable
	{
		[Token(Token = "0x400235C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal float _003CtryStart_003E__0;

		[Token(Token = "0x400235D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal float _003Cthreshold_003E__1;

		[Token(Token = "0x400235E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal int _0024PC;

		[Token(Token = "0x400235F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal object _0024current;

		[Token(Token = "0x4002360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal ConnectInGameProcessor _003C_003Ef__this;

		[Token(Token = "0x17000924")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6004187")]
			[Address(RVA = "0x20D0BC0", Offset = "0x20D0BC0", VA = "0x20D0BC0", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000925")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6004188")]
			[Address(RVA = "0x20D0BC8", Offset = "0x20D0BC8", VA = "0x20D0BC8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6004186")]
		[Address(RVA = "0x20CF5B0", Offset = "0x20CF5B0", VA = "0x20CF5B0")]
		public _003CTryInGameJoin_003Ec__Iterator8A()
		{
		}

		[Token(Token = "0x6004187")]
		[Address(RVA = "0x20D0BC0", Offset = "0x20D0BC0", VA = "0x20D0BC0", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6004188")]
		[Address(RVA = "0x20D0BC8", Offset = "0x20D0BC8", VA = "0x20D0BC8", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6004189")]
		[Address(RVA = "0x20D0BD0", Offset = "0x20D0BD0", VA = "0x20D0BD0", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600418A")]
		[Address(RVA = "0x20D0E14", Offset = "0x20D0E14", VA = "0x20D0E14", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x600418B")]
		[Address(RVA = "0x20D0E20", Offset = "0x20D0E20", VA = "0x20D0E20", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2000830")]
	private sealed class _003CFastReconnectToServer_003Ec__Iterator8B : IDisposable
	{
		[Token(Token = "0x4002361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal int _003Ci_003E__0;

		[Token(Token = "0x4002362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal int _0024PC;

		[Token(Token = "0x4002363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x4002364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal ConnectInGameProcessor _003C_003Ef__this;

		[Token(Token = "0x4002365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Action _003C_003Ef__am_0024cache4;

		[Token(Token = "0x17000926")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600418D")]
			[Address(RVA = "0x20D04F8", Offset = "0x20D04F8", VA = "0x20D04F8", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000927")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600418E")]
			[Address(RVA = "0x20D0500", Offset = "0x20D0500", VA = "0x20D0500", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600418C")]
		[Address(RVA = "0x20CF728", Offset = "0x20CF728", VA = "0x20CF728")]
		public _003CFastReconnectToServer_003Ec__Iterator8B()
		{
		}

		[Token(Token = "0x600418D")]
		[Address(RVA = "0x20D04F8", Offset = "0x20D04F8", VA = "0x20D04F8", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600418E")]
		[Address(RVA = "0x20D0500", Offset = "0x20D0500", VA = "0x20D0500", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600418F")]
		[Address(RVA = "0x20D0508", Offset = "0x20D0508", VA = "0x20D0508", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6004190")]
		[Address(RVA = "0x20D0964", Offset = "0x20D0964", VA = "0x20D0964", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6004191")]
		[Address(RVA = "0x20D0970", Offset = "0x20D0970", VA = "0x20D0970", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}

		[Token(Token = "0x6004192")]
		[Address(RVA = "0x20D0A04", Offset = "0x20D0A04", VA = "0x20D0A04")]
		private static void _003C_003Em__1D8()
		{
		}
	}

	[Token(Token = "0x4002351")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static ConnectInGameProcessor INST;

	[Token(Token = "0x4002352")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private IEnumerator coroutine;

	[Token(Token = "0x4002353")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private Vector3 savePos;

	[Token(Token = "0x4002354")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Vector3 saveDir;

	[Token(Token = "0x4002355")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private bool IsOnKickedOrBannedEvent;

	[Token(Token = "0x4002356")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static Action _003C_003Ef__am_0024cache5;

	[Token(Token = "0x4002357")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Action _003C_003Ef__am_0024cache6;

	[Token(Token = "0x4002358")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private static Action _003C_003Ef__am_0024cache7;

	[Token(Token = "0x4002359")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static Action _003C_003Ef__am_0024cache8;

	[Token(Token = "0x400235A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private static Action _003C_003Ef__am_0024cache9;

	[Token(Token = "0x400235B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static Action _003C_003Ef__am_0024cacheA;

	[Token(Token = "0x600415D")]
	[Address(RVA = "0x20CD398", Offset = "0x20CD398", VA = "0x20CD398")]
	private ConnectInGameProcessor()
	{
	}

	[Token(Token = "0x600415F")]
	[Address(RVA = "0x20CD48C", Offset = "0x20CD48C", VA = "0x20CD48C", Slot = "16")]
	public void OnExitReconnector()
	{
	}

	[Token(Token = "0x6004160")]
	[Address(RVA = "0x20CD5B4", Offset = "0x20CD5B4", VA = "0x20CD5B4")]
	private void StopReconnectCoroutine()
	{
	}

	[Token(Token = "0x6004161")]
	[Address(RVA = "0x20CD604", Offset = "0x20CD604", VA = "0x20CD604")]
	private void SaveMyPosAndDir()
	{
	}

	[Token(Token = "0x6004162")]
	[Address(RVA = "0x20CD798", Offset = "0x20CD798", VA = "0x20CD798", Slot = "12")]
	public void OnApplicationPause(bool paused)
	{
	}

	[Token(Token = "0x6004163")]
	[Address(RVA = "0x20CDB90", Offset = "0x20CDB90", VA = "0x20CDB90", Slot = "7")]
	public void OnConnectedToMaster()
	{
	}

	[Token(Token = "0x6004164")]
	[Address(RVA = "0x20CDB94", Offset = "0x20CDB94", VA = "0x20CDB94", Slot = "8")]
	public void OnConnectedToPhoton()
	{
	}

	[Token(Token = "0x6004165")]
	[Address(RVA = "0x20CDB98", Offset = "0x20CDB98", VA = "0x20CDB98", Slot = "4")]
	public void OnDisconnect(DisconnectCause cause)
	{
	}

	[Token(Token = "0x6004166")]
	[Address(RVA = "0x20CDB9C", Offset = "0x20CDB9C", VA = "0x20CDB9C", Slot = "5")]
	public void OnDisconnectedFromPhoton()
	{
	}

	[Token(Token = "0x6004167")]
	[Address(RVA = "0x20CDFB8", Offset = "0x20CDFB8", VA = "0x20CDFB8", Slot = "6")]
	public void OnDisconnectedFromPhoton(DisconnectCause cause)
	{
	}

	[Token(Token = "0x6004168")]
	[Address(RVA = "0x20CE154", Offset = "0x20CE154", VA = "0x20CE154")]
	private void FastRejoinToRoom()
	{
	}

	[Token(Token = "0x6004169")]
	[Address(RVA = "0x20CE3B8", Offset = "0x20CE3B8", VA = "0x20CE3B8")]
	private void FastReconnectWithRejoin()
	{
	}

	[Token(Token = "0x600416A")]
	[Address(RVA = "0x20CDD9C", Offset = "0x20CDD9C", VA = "0x20CDD9C")]
	private void ReturnTitleScene()
	{
	}

	[Token(Token = "0x600416B")]
	[Address(RVA = "0x20CE9F4", Offset = "0x20CE9F4", VA = "0x20CE9F4", Slot = "9")]
	public void OnJoinedLobby()
	{
	}

	[Token(Token = "0x600416C")]
	[Address(RVA = "0x20CE9F8", Offset = "0x20CE9F8", VA = "0x20CE9F8", Slot = "10")]
	public void OnCreatedRoom()
	{
	}

	[Token(Token = "0x600416D")]
	[Address(RVA = "0x20CE9FC", Offset = "0x20CE9FC", VA = "0x20CE9FC", Slot = "11")]
	public void OnJoinedRoom()
	{
	}

	[Token(Token = "0x600416E")]
	[Address(RVA = "0x20CED58", Offset = "0x20CED58", VA = "0x20CED58", Slot = "13")]
	public void OnPhotonCreateRoomFailed(object[] codeAndMsg)
	{
	}

	[Token(Token = "0x600416F")]
	[Address(RVA = "0x20CED5C", Offset = "0x20CED5C", VA = "0x20CED5C", Slot = "14")]
	public void OnPhotonJoinRoomFailed(object[] result)
	{
	}

	[Token(Token = "0x6004170")]
	[Address(RVA = "0x20CF508", Offset = "0x20CF508", VA = "0x20CF508", Slot = "15")]
	public void OnPhotonRandomJoinFailed()
	{
	}

	[Token(Token = "0x6004171")]
	[Address(RVA = "0x20CE2B0", Offset = "0x20CE2B0", VA = "0x20CE2B0")]
	public void FastJoinGameRoom()
	{
	}

	[Token(Token = "0x6004172")]
	[Address(RVA = "0x20CF50C", Offset = "0x20CF50C", VA = "0x20CF50C")]
	[DebuggerHidden]
	private IEnumerator TryInGameJoin()
	{
		return null;
	}

	[Token(Token = "0x6004173")]
	[Address(RVA = "0x20CF5B8", Offset = "0x20CF5B8", VA = "0x20CF5B8")]
	private bool IsInLobby()
	{
		return default(bool);
	}

	[Token(Token = "0x6004174")]
	[Address(RVA = "0x20CE648", Offset = "0x20CE648", VA = "0x20CE648")]
	[DebuggerHidden]
	private IEnumerator FastReconnectToServer()
	{
		return null;
	}

	[Token(Token = "0x6004175")]
	[Address(RVA = "0x20CF730", Offset = "0x20CF730", VA = "0x20CF730")]
	private void ShowTryingRejoinMessage()
	{
	}

	[Token(Token = "0x6004176")]
	[Address(RVA = "0x20CE580", Offset = "0x20CE580", VA = "0x20CE580")]
	private void ShowTryingToReconnectMessage()
	{
	}

	[Token(Token = "0x6004177")]
	[Address(RVA = "0x20CD4B0", Offset = "0x20CD4B0", VA = "0x20CD4B0")]
	private void HideMessageBox()
	{
	}

	[Token(Token = "0x6004178")]
	[Address(RVA = "0x20CF834", Offset = "0x20CF834", VA = "0x20CF834", Slot = "17")]
	public void TryConnectToMasterServer()
	{
	}

	[Token(Token = "0x6004179")]
	[Address(RVA = "0x20CF838", Offset = "0x20CF838", VA = "0x20CF838", Slot = "18")]
	public void OnKicked()
	{
	}

	[Token(Token = "0x600417A")]
	[Address(RVA = "0x20CF9F4", Offset = "0x20CF9F4", VA = "0x20CF9F4", Slot = "19")]
	public void OnBanned()
	{
	}

	[Token(Token = "0x600417B")]
	[Address(RVA = "0x20CE6EC", Offset = "0x20CE6EC", VA = "0x20CE6EC")]
	private void ShowMessageBox(string strTitle, string strMessage, XMessageBoxButtons nButtons, [Optional] Action delegateOK, [Optional] Action delegateCancle)
	{
	}

	[Token(Token = "0x600417C")]
	[Address(RVA = "0x20CFBB0", Offset = "0x20CFBB0", VA = "0x20CFBB0", Slot = "20")]
	public void OnComplteGame()
	{
	}

	[Token(Token = "0x600417D")]
	[Address(RVA = "0x20CFBB4", Offset = "0x20CFBB4", VA = "0x20CFBB4")]
	private static void _003CReturnTitleScene_003Em__1CF()
	{
	}

	[Token(Token = "0x600417E")]
	[Address(RVA = "0x20CFC80", Offset = "0x20CFC80", VA = "0x20CFC80")]
	private static void _003COnPhotonJoinRoomFailed_003Em__1D0()
	{
	}

	[Token(Token = "0x600417F")]
	[Address(RVA = "0x20CFD64", Offset = "0x20CFD64", VA = "0x20CFD64")]
	private static void _003COnPhotonJoinRoomFailed_003Em__1D1()
	{
	}

	[Token(Token = "0x6004180")]
	[Address(RVA = "0x20CFE48", Offset = "0x20CFE48", VA = "0x20CFE48")]
	private static void _003COnPhotonJoinRoomFailed_003Em__1D2()
	{
	}

	[Token(Token = "0x6004181")]
	[Address(RVA = "0x20CFF2C", Offset = "0x20CFF2C", VA = "0x20CFF2C")]
	private void _003CShowTryingRejoinMessage_003Em__1D3()
	{
	}

	[Token(Token = "0x6004182")]
	[Address(RVA = "0x20CFF30", Offset = "0x20CFF30", VA = "0x20CFF30")]
	private void _003COnKicked_003Em__1D4()
	{
	}

	[Token(Token = "0x6004183")]
	[Address(RVA = "0x20D0130", Offset = "0x20D0130", VA = "0x20D0130")]
	private void _003COnBanned_003Em__1D5()
	{
	}

	[Token(Token = "0x6004184")]
	[Address(RVA = "0x20D0330", Offset = "0x20D0330", VA = "0x20D0330")]
	private static void _003COnKicked_003Em__1D6()
	{
	}

	[Token(Token = "0x6004185")]
	[Address(RVA = "0x20D0414", Offset = "0x20D0414", VA = "0x20D0414")]
	private static void _003COnBanned_003Em__1D7()
	{
	}
}
