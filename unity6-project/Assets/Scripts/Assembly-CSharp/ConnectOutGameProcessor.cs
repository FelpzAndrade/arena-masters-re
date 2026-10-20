using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

[Token(Token = "0x2000831")]
public class ConnectOutGameProcessor : IConnectProcessor
{
	[Token(Token = "0x2000832")]
	private sealed class _003CReconnectToServer_003Ec__Iterator8C : IDisposable
	{
		[Token(Token = "0x400236B")]
		[FieldOffset(Offset = "0x8")]
		internal int _003Ci_003E__0;

		[Token(Token = "0x400236C")]
		[FieldOffset(Offset = "0xC")]
		internal int _0024PC;

		[Token(Token = "0x400236D")]
		[FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x400236E")]
		[FieldOffset(Offset = "0x14")]
		internal ConnectOutGameProcessor _003C_003Ef__this;

		[Token(Token = "0x17000928")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60041AB")]
			[Address(RVA = "0x20D2848", Offset = "0x20D2848", VA = "0x20D2848", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000929")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60041AC")]
			[Address(RVA = "0x20D2850", Offset = "0x20D2850", VA = "0x20D2850", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60041AA")]
		[Address(RVA = "0x20D2830", Offset = "0x20D2830", VA = "0x20D2830")]
		public _003CReconnectToServer_003Ec__Iterator8C()
		{
		}

		[Token(Token = "0x60041AB")]
		[Address(RVA = "0x20D2848", Offset = "0x20D2848", VA = "0x20D2848", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60041AC")]
		[Address(RVA = "0x20D2850", Offset = "0x20D2850", VA = "0x20D2850", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60041AD")]
		[Address(RVA = "0x20D2858", Offset = "0x20D2858", VA = "0x20D2858", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60041AE")]
		[Address(RVA = "0x20D2B54", Offset = "0x20D2B54", VA = "0x20D2B54", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x60041AF")]
		[Address(RVA = "0x20D2B60", Offset = "0x20D2B60", VA = "0x20D2B60", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4002366")]
	[FieldOffset(Offset = "0x0")]
	public static ConnectOutGameProcessor INST;

	[Token(Token = "0x4002367")]
	[FieldOffset(Offset = "0x8")]
	private IEnumerator coroutine;

	[Token(Token = "0x4002368")]
	[FieldOffset(Offset = "0xC")]
	private int m_tryEnterCount;

	[Token(Token = "0x4002369")]
	[FieldOffset(Offset = "0x10")]
	private int m_tryEnterCountLimit;

	[Token(Token = "0x400236A")]
	[FieldOffset(Offset = "0x14")]
	private readonly int m_tryReconnectCount;

	[Token(Token = "0x6004193")]
	[Address(RVA = "0x20D0EB4", Offset = "0x20D0EB4", VA = "0x20D0EB4")]
	private ConnectOutGameProcessor()
	{
	}

	[Token(Token = "0x6004195")]
	[Address(RVA = "0x20D0F74", Offset = "0x20D0F74", VA = "0x20D0F74", Slot = "16")]
	public void OnExitReconnector()
	{
	}

	[Token(Token = "0x6004196")]
	[Address(RVA = "0x20D0F78", Offset = "0x20D0F78", VA = "0x20D0F78")]
	private void StopReconnectCoroutine()
	{
	}

	[Token(Token = "0x6004197")]
	[Address(RVA = "0x20D0FC8", Offset = "0x20D0FC8", VA = "0x20D0FC8", Slot = "12")]
	public void OnApplicationPause(bool paused)
	{
	}

	[Token(Token = "0x6004198")]
	[Address(RVA = "0x20D1280", Offset = "0x20D1280", VA = "0x20D1280", Slot = "7")]
	public void OnConnectedToMaster()
	{
	}

	[Token(Token = "0x6004199")]
	[Address(RVA = "0x20D1284", Offset = "0x20D1284", VA = "0x20D1284", Slot = "8")]
	public void OnConnectedToPhoton()
	{
	}

	[Token(Token = "0x600419A")]
	[Address(RVA = "0x20D1288", Offset = "0x20D1288", VA = "0x20D1288", Slot = "10")]
	public void OnCreatedRoom()
	{
	}

	[Token(Token = "0x600419B")]
	[Address(RVA = "0x20D1294", Offset = "0x20D1294", VA = "0x20D1294", Slot = "4")]
	public void OnDisconnect(DisconnectCause cause)
	{
	}

	[Token(Token = "0x600419C")]
	[Address(RVA = "0x20D1298", Offset = "0x20D1298", VA = "0x20D1298", Slot = "5")]
	public void OnDisconnectedFromPhoton()
	{
	}

	[Token(Token = "0x600419D")]
	[Address(RVA = "0x20D129C", Offset = "0x20D129C", VA = "0x20D129C", Slot = "6")]
	public void OnDisconnectedFromPhoton(DisconnectCause cause)
	{
	}

	[Token(Token = "0x600419E")]
	[Address(RVA = "0x20D14DC", Offset = "0x20D14DC", VA = "0x20D14DC", Slot = "9")]
	public void OnJoinedLobby()
	{
	}

	[Token(Token = "0x600419F")]
	[Address(RVA = "0x20D14E0", Offset = "0x20D14E0", VA = "0x20D14E0", Slot = "11")]
	public void OnJoinedRoom()
	{
	}

	[Token(Token = "0x60041A0")]
	[Address(RVA = "0x20D1A88", Offset = "0x20D1A88", VA = "0x20D1A88", Slot = "13")]
	public void OnPhotonCreateRoomFailed(object[] codeAndMsg)
	{
	}

	[Token(Token = "0x60041A1")]
	[Address(RVA = "0x20D1EE8", Offset = "0x20D1EE8", VA = "0x20D1EE8", Slot = "14")]
	public void OnPhotonJoinRoomFailed(object[] result)
	{
	}

	[Token(Token = "0x60041A2")]
	[Address(RVA = "0x20D266C", Offset = "0x20D266C", VA = "0x20D266C", Slot = "15")]
	public void OnPhotonRandomJoinFailed()
	{
	}

	[Token(Token = "0x60041A3")]
	[Address(RVA = "0x20D278C", Offset = "0x20D278C", VA = "0x20D278C")]
	[DebuggerHidden]
	private IEnumerator ReconnectToServer()
	{
		return null;
	}

	[Token(Token = "0x60041A4")]
	[Address(RVA = "0x20D2288", Offset = "0x20D2288", VA = "0x20D2288")]
	private void ShowJoinRoomFailMessage()
	{
	}

	[Token(Token = "0x60041A5")]
	[Address(RVA = "0x20D1374", Offset = "0x20D1374", VA = "0x20D1374", Slot = "17")]
	public void TryConnectToMasterServer()
	{
	}

	[Token(Token = "0x60041A6")]
	[Address(RVA = "0x20D2838", Offset = "0x20D2838", VA = "0x20D2838", Slot = "18")]
	public void OnKicked()
	{
	}

	[Token(Token = "0x60041A7")]
	[Address(RVA = "0x20D283C", Offset = "0x20D283C", VA = "0x20D283C", Slot = "19")]
	public void OnBanned()
	{
	}

	[Token(Token = "0x60041A8")]
	[Address(RVA = "0x20D2840", Offset = "0x20D2840", VA = "0x20D2840", Slot = "20")]
	public void OnComplteGame()
	{
	}

	[Token(Token = "0x60041A9")]
	[Address(RVA = "0x20D2844", Offset = "0x20D2844", VA = "0x20D2844")]
	public void ReturnToCustomRoomList()
	{
	}
}
