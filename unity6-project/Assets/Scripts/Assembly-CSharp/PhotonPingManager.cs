using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using ExitGames.Client.Photon;
using Il2CppDummyDll;

[Token(Token = "0x20002D9")]
public class PhotonPingManager
{
	[Token(Token = "0x20002DA")]
	private sealed class _003CPingSocket_003Ec__Iterator27 : IDisposable
	{
		[Token(Token = "0x4000F30")]
		[FieldOffset(Offset = "0x8")]
		internal Region region;

		[Token(Token = "0x4000F31")]
		[FieldOffset(Offset = "0xC")]
		internal PhotonPing _003Cping_003E__0;

		[Token(Token = "0x4000F32")]
		[FieldOffset(Offset = "0x10")]
		internal float _003CrttSum_003E__1;

		[Token(Token = "0x4000F33")]
		[FieldOffset(Offset = "0x14")]
		internal int _003CreplyCount_003E__2;

		[Token(Token = "0x4000F34")]
		[FieldOffset(Offset = "0x18")]
		internal string _003CregionAddress_003E__3;

		[Token(Token = "0x4000F35")]
		[FieldOffset(Offset = "0x1C")]
		internal int _003CindexOfColon_003E__4;

		[Token(Token = "0x4000F36")]
		[FieldOffset(Offset = "0x20")]
		internal int _003CindexOfProtocol_003E__5;

		[Token(Token = "0x4000F37")]
		[FieldOffset(Offset = "0x24")]
		internal int _003Ci_003E__6;

		[Token(Token = "0x4000F38")]
		[FieldOffset(Offset = "0x28")]
		internal bool _003Covertime_003E__7;

		[Token(Token = "0x4000F39")]
		[FieldOffset(Offset = "0x2C")]
		internal Stopwatch _003Csw_003E__8;

		[Token(Token = "0x4000F3A")]
		[FieldOffset(Offset = "0x30")]
		internal Exception _003Ce_003E__9;

		[Token(Token = "0x4000F3B")]
		[FieldOffset(Offset = "0x34")]
		internal int _003Crtt_003E__10;

		[Token(Token = "0x4000F3C")]
		[FieldOffset(Offset = "0x38")]
		internal int _0024PC;

		[Token(Token = "0x4000F3D")]
		[FieldOffset(Offset = "0x3C")]
		internal object _0024current;

		[Token(Token = "0x4000F3E")]
		[FieldOffset(Offset = "0x40")]
		internal Region _003C_0024_003Eregion;

		[Token(Token = "0x4000F3F")]
		[FieldOffset(Offset = "0x44")]
		internal PhotonPingManager _003C_003Ef__this;

		[Token(Token = "0x17000456")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600194C")]
			[Address(RVA = "0x1B99C4C", Offset = "0x1B99C4C", VA = "0x1B99C4C", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000457")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600194D")]
			[Address(RVA = "0x1B99C54", Offset = "0x1B99C54", VA = "0x1B99C54", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600194B")]
		[Address(RVA = "0x1B99788", Offset = "0x1B99788", VA = "0x1B99788")]
		public _003CPingSocket_003Ec__Iterator27()
		{
		}

		[Token(Token = "0x600194C")]
		[Address(RVA = "0x1B99C4C", Offset = "0x1B99C4C", VA = "0x1B99C4C", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600194D")]
		[Address(RVA = "0x1B99C54", Offset = "0x1B99C54", VA = "0x1B99C54", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600194E")]
		[Address(RVA = "0x1B99C5C", Offset = "0x1B99C5C", VA = "0x1B99C5C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600194F")]
		[Address(RVA = "0x1B9A790", Offset = "0x1B9A790", VA = "0x1B9A790", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6001950")]
		[Address(RVA = "0x1B9A79C", Offset = "0x1B9A79C", VA = "0x1B9A79C", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4000F2A")]
	private const string wssProtocolString = "wss://";

	[Token(Token = "0x4000F2B")]
	[FieldOffset(Offset = "0x8")]
	public bool UseNative;

	[Token(Token = "0x4000F2C")]
	[FieldOffset(Offset = "0x0")]
	public static int Attempts;

	[Token(Token = "0x4000F2D")]
	[FieldOffset(Offset = "0x4")]
	public static bool IgnoreInitialAttempt;

	[Token(Token = "0x4000F2E")]
	[FieldOffset(Offset = "0x8")]
	public static int MaxMilliseconsPerPing;

	[Token(Token = "0x4000F2F")]
	[FieldOffset(Offset = "0xC")]
	private int PingsRunning;

	[Token(Token = "0x17000454")]
	public Region BestRegion
	{
		[Token(Token = "0x6001947")]
		[Address(RVA = "0x1B874F4", Offset = "0x1B874F4", VA = "0x1B874F4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000455")]
	public bool Done
	{
		[Token(Token = "0x6001948")]
		[Address(RVA = "0x1B874E0", Offset = "0x1B874E0", VA = "0x1B874E0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6001945")]
	[Address(RVA = "0x1B87428", Offset = "0x1B87428", VA = "0x1B87428")]
	public PhotonPingManager()
	{
	}

	[Token(Token = "0x6001949")]
	[Address(RVA = "0x1B87430", Offset = "0x1B87430", VA = "0x1B87430")]
	[DebuggerHidden]
	public IEnumerator PingSocket(Region region)
	{
		return null;
	}

	[Token(Token = "0x600194A")]
	[Address(RVA = "0x1B99790", Offset = "0x1B99790", VA = "0x1B99790")]
	public static string ResolveHost(string hostName)
	{
		return null;
	}
}
