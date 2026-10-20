using System;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

[Token(Token = "0x20004D3")]
public class XGameExitor
{
	[Token(Token = "0x20004D4")]
	private sealed class _003CExit_003Ec__AnonStorey111
	{
		[Token(Token = "0x400185C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal string game_session_id;

		[Token(Token = "0x400185D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal XGameExitor _003C_003Ef__this;

		[Token(Token = "0x60029AE")]
		[Address(RVA = "0x13DE284", Offset = "0x13DE284", VA = "0x13DE284")]
		public _003CExit_003Ec__AnonStorey111()
		{
		}

		[Token(Token = "0x60029AF")]
		[Address(RVA = "0x13DF5C4", Offset = "0x13DF5C4", VA = "0x13DF5C4")]
		internal void _003C_003Em__FA()
		{
		}

		[Token(Token = "0x60029B0")]
		[Address(RVA = "0x13DF890", Offset = "0x13DF890", VA = "0x13DF890")]
		internal void _003C_003Em__FC(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
		{
		}
	}

	[Token(Token = "0x20004D5")]
	private sealed class _003CExitByClanLeave_003Ec__AnonStorey112
	{
		[Token(Token = "0x400185E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal Action nextAction;

		[Token(Token = "0x60029B1")]
		[Address(RVA = "0x13DF5BC", Offset = "0x13DF5BC", VA = "0x13DF5BC")]
		public _003CExitByClanLeave_003Ec__AnonStorey112()
		{
		}

		[Token(Token = "0x60029B2")]
		[Address(RVA = "0x13DF9B8", Offset = "0x13DF9B8", VA = "0x13DF9B8")]
		internal void _003C_003Em__FB()
		{
		}
	}

	[Token(Token = "0x400185B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private XGameManager m_GameManager;

	[Token(Token = "0x60029A5")]
	[Address(RVA = "0x13DDBF0", Offset = "0x13DDBF0", VA = "0x13DDBF0")]
	public XGameExitor(XGameManager gameManager)
	{
	}

	[Token(Token = "0x60029A6")]
	[Address(RVA = "0x13DDC10", Offset = "0x13DDC10", VA = "0x13DDC10")]
	public void Exit(bool bShowMessageBox, [Optional] Action onCancle)
	{
	}

	[Token(Token = "0x60029A7")]
	[Address(RVA = "0x13DE144", Offset = "0x13DE144", VA = "0x13DE144")]
	private void SendTapjoyEventPing()
	{
	}

	[Token(Token = "0x60029A8")]
	[Address(RVA = "0x13DE774", Offset = "0x13DE774", VA = "0x13DE774")]
	private void SaveLastMatchedNetworkPlayersNickName()
	{
	}

	[Token(Token = "0x60029A9")]
	[Address(RVA = "0x13DE4F4", Offset = "0x13DE4F4", VA = "0x13DE4F4")]
	private void DoExit()
	{
	}

	[Token(Token = "0x60029AA")]
	[Address(RVA = "0x13DEDB8", Offset = "0x13DEDB8", VA = "0x13DEDB8")]
	private void TrackMatchFailed()
	{
	}

	[Token(Token = "0x60029AB")]
	[Address(RVA = "0x13DEC34", Offset = "0x13DEC34", VA = "0x13DEC34")]
	private void OnLeftRoomComplete()
	{
	}

	[Token(Token = "0x60029AC")]
	[Address(RVA = "0x13DF300", Offset = "0x13DF300", VA = "0x13DF300")]
	private void ReserveObjectPools()
	{
	}

	[Token(Token = "0x60029AD")]
	[Address(RVA = "0x13DF304", Offset = "0x13DF304", VA = "0x13DF304")]
	internal void ExitByClanLeave(Action nextAction)
	{
	}
}
