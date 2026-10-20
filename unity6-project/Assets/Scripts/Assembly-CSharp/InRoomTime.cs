using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using ExitGames.Client.Photon;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000301")]
public class InRoomTime : MonoBehaviour
{
	[Token(Token = "0x2000302")]
	private sealed class _003CSetRoomStartTimestamp_003Ec__Iterator28 : IDisposable
	{
		[Token(Token = "0x4000FFE")]
		[FieldOffset(Offset = "0x8")]
		internal ExitGames.Client.Photon.Hashtable _003CstartTimeProp_003E__0;

		[Token(Token = "0x4000FFF")]
		[FieldOffset(Offset = "0xC")]
		internal int _0024PC;

		[Token(Token = "0x4001000")]
		[FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x4001001")]
		[FieldOffset(Offset = "0x14")]
		internal InRoomTime _003C_003Ef__this;

		[Token(Token = "0x17000482")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6001A28")]
			[Address(RVA = "0xD8D498", Offset = "0xD8D498", VA = "0xD8D498", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000483")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001A29")]
			[Address(RVA = "0xD8D4A0", Offset = "0xD8D4A0", VA = "0xD8D4A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001A27")]
		[Address(RVA = "0xD8D290", Offset = "0xD8D290", VA = "0xD8D290")]
		public _003CSetRoomStartTimestamp_003Ec__Iterator28()
		{
		}

		[Token(Token = "0x6001A28")]
		[Address(RVA = "0xD8D498", Offset = "0xD8D498", VA = "0xD8D498", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001A29")]
		[Address(RVA = "0xD8D4A0", Offset = "0xD8D4A0", VA = "0xD8D4A0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001A2A")]
		[Address(RVA = "0xD8D4A8", Offset = "0xD8D4A8", VA = "0xD8D4A8", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6001A2B")]
		[Address(RVA = "0xD8D718", Offset = "0xD8D718", VA = "0xD8D718", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6001A2C")]
		[Address(RVA = "0xD8D724", Offset = "0xD8D724", VA = "0xD8D724", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4000FFC")]
	private const string StartTimeKey = "#rt";

	[Token(Token = "0x4000FFD")]
	[FieldOffset(Offset = "0xC")]
	private int roomStartTimestamp;

	[Token(Token = "0x1700047F")]
	public double RoomTime
	{
		[Token(Token = "0x6001A20")]
		[Address(RVA = "0xD8CF80", Offset = "0xD8CF80", VA = "0xD8CF80")]
		get
		{
			return default(double);
		}
	}

	[Token(Token = "0x17000480")]
	public int RoomTimestamp
	{
		[Token(Token = "0x6001A21")]
		[Address(RVA = "0xD8CFB0", Offset = "0xD8CFB0", VA = "0xD8CFB0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000481")]
	public bool IsRoomTimeSet
	{
		[Token(Token = "0x6001A22")]
		[Address(RVA = "0xD8D0A8", Offset = "0xD8D0A8", VA = "0xD8D0A8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6001A1F")]
	[Address(RVA = "0xD8CF74", Offset = "0xD8CF74", VA = "0xD8CF74")]
	public InRoomTime()
	{
	}

	[Token(Token = "0x6001A23")]
	[Address(RVA = "0xD8D1EC", Offset = "0xD8D1EC", VA = "0xD8D1EC")]
	[DebuggerHidden]
	internal IEnumerator SetRoomStartTimestamp()
	{
		return null;
	}

	[Token(Token = "0x6001A24")]
	[Address(RVA = "0xD8D298", Offset = "0xD8D298", VA = "0xD8D298")]
	public void OnJoinedRoom()
	{
	}

	[Token(Token = "0x6001A25")]
	[Address(RVA = "0xD8D320", Offset = "0xD8D320", VA = "0xD8D320")]
	public void OnMasterClientSwitched(PhotonPlayer newMasterClient)
	{
	}

	[Token(Token = "0x6001A26")]
	[Address(RVA = "0xD8D3A8", Offset = "0xD8D3A8", VA = "0xD8D3A8")]
	public void OnPhotonCustomRoomPropertiesChanged(ExitGames.Client.Photon.Hashtable propertiesThatChanged)
	{
	}
}
