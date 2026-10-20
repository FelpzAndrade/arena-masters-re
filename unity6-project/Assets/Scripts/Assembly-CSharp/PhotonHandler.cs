using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

[Token(Token = "0x20002CC")]
internal class PhotonHandler : MonoBehaviour
{
	[Token(Token = "0x20002CD")]
	private sealed class _003CPingAvailableRegionsCoroutine_003Ec__Iterator26 : IDisposable
	{
		[Token(Token = "0x4000EBB")]
		[FieldOffset(Offset = "0x8")]
		internal PhotonPingManager _003CpingManager_003E__0;

		[Token(Token = "0x4000EBC")]
		[FieldOffset(Offset = "0xC")]
		internal List<Region>.Enumerator _003C_0024s_201_003E__1;

		[Token(Token = "0x4000EBD")]
		[FieldOffset(Offset = "0x1C")]
		internal Region _003Cregion_003E__2;

		[Token(Token = "0x4000EBE")]
		[FieldOffset(Offset = "0x20")]
		internal Region _003Cbest_003E__3;

		[Token(Token = "0x4000EBF")]
		[FieldOffset(Offset = "0x24")]
		internal bool connectToBest;

		[Token(Token = "0x4000EC0")]
		[FieldOffset(Offset = "0x28")]
		internal int _0024PC;

		[Token(Token = "0x4000EC1")]
		[FieldOffset(Offset = "0x2C")]
		internal object _0024current;

		[Token(Token = "0x4000EC2")]
		[FieldOffset(Offset = "0x30")]
		internal bool _003C_0024_003EconnectToBest;

		[Token(Token = "0x1700040B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6001841")]
			[Address(RVA = "0x1B86488", Offset = "0x1B86488", VA = "0x1B86488", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700040C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001842")]
			[Address(RVA = "0x1B86490", Offset = "0x1B86490", VA = "0x1B86490", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001840")]
		[Address(RVA = "0x1B86374", Offset = "0x1B86374", VA = "0x1B86374")]
		public _003CPingAvailableRegionsCoroutine_003Ec__Iterator26()
		{
		}

		[Token(Token = "0x6001841")]
		[Address(RVA = "0x1B86488", Offset = "0x1B86488", VA = "0x1B86488", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001842")]
		[Address(RVA = "0x1B86490", Offset = "0x1B86490", VA = "0x1B86490", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001843")]
		[Address(RVA = "0x1B86498", Offset = "0x1B86498", VA = "0x1B86498", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6001844")]
		[Address(RVA = "0x1B87884", Offset = "0x1B87884", VA = "0x1B87884", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6001845")]
		[Address(RVA = "0x1B87890", Offset = "0x1B87890", VA = "0x1B87890", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4000EB0")]
	private const string PlayerPrefsKey = "PUNCloudBestRegion";

	[Token(Token = "0x4000EB1")]
	[FieldOffset(Offset = "0x0")]
	public static PhotonHandler SP;

	[Token(Token = "0x4000EB2")]
	[FieldOffset(Offset = "0xC")]
	public int updateInterval;

	[Token(Token = "0x4000EB3")]
	[FieldOffset(Offset = "0x10")]
	public int updateIntervalOnSerialize;

	[Token(Token = "0x4000EB4")]
	[FieldOffset(Offset = "0x14")]
	private int nextSendTickCount;

	[Token(Token = "0x4000EB5")]
	[FieldOffset(Offset = "0x18")]
	private int nextSendTickCountOnSerialize;

	[Token(Token = "0x4000EB6")]
	[FieldOffset(Offset = "0x4")]
	private static bool sendThreadShouldRun;

	[Token(Token = "0x4000EB7")]
	[FieldOffset(Offset = "0x8")]
	public static Stopwatch timerToStopConnectionInBackground;

	[Token(Token = "0x4000EB8")]
	[FieldOffset(Offset = "0xC")]
	protected internal static bool AppQuits;

	[Token(Token = "0x4000EB9")]
	[FieldOffset(Offset = "0x10")]
	protected internal static Type PingImplementation;

	[Token(Token = "0x4000EBA")]
	[FieldOffset(Offset = "0x14")]
	private static UnityAction<Scene, LoadSceneMode> _003C_003Ef__am_0024cache9;

	[Token(Token = "0x1700040A")]
	internal static CloudRegionCode BestRegionCodeInPreferences
	{
		[Token(Token = "0x600183B")]
		[Address(RVA = "0x1B85FB4", Offset = "0x1B85FB4", VA = "0x1B85FB4")]
		get
		{
			return default(CloudRegionCode);
		}
		[Token(Token = "0x600183C")]
		[Address(RVA = "0x1B860BC", Offset = "0x1B860BC", VA = "0x1B860BC")]
		set
		{
		}
	}

	[Token(Token = "0x600182E")]
	[Address(RVA = "0x1B83EE8", Offset = "0x1B83EE8", VA = "0x1B83EE8")]
	public PhotonHandler()
	{
	}

	[Token(Token = "0x6001830")]
	[Address(RVA = "0x1B83EF4", Offset = "0x1B83EF4", VA = "0x1B83EF4")]
	protected void Awake()
	{
	}

	[Token(Token = "0x6001831")]
	[Address(RVA = "0x1B84648", Offset = "0x1B84648", VA = "0x1B84648")]
	protected void Start()
	{
	}

	[Token(Token = "0x6001832")]
	[Address(RVA = "0x1B847EC", Offset = "0x1B847EC", VA = "0x1B847EC")]
	protected void OnApplicationQuit()
	{
	}

	[Token(Token = "0x6001833")]
	[Address(RVA = "0x1B84BAC", Offset = "0x1B84BAC", VA = "0x1B84BAC")]
	protected void OnApplicationPause(bool pause)
	{
	}

	[Token(Token = "0x6001834")]
	[Address(RVA = "0x1B84E58", Offset = "0x1B84E58", VA = "0x1B84E58")]
	protected void OnDestroy()
	{
	}

	[Token(Token = "0x6001835")]
	[Address(RVA = "0x1B84EF0", Offset = "0x1B84EF0", VA = "0x1B84EF0")]
	protected void Update()
	{
	}

	[Token(Token = "0x6001836")]
	[Address(RVA = "0x1B85894", Offset = "0x1B85894", VA = "0x1B85894")]
	protected void OnJoinedRoom()
	{
	}

	[Token(Token = "0x6001837")]
	[Address(RVA = "0x1B85960", Offset = "0x1B85960", VA = "0x1B85960")]
	protected void OnCreatedRoom()
	{
	}

	[Token(Token = "0x6001838")]
	[Address(RVA = "0x1B8445C", Offset = "0x1B8445C", VA = "0x1B8445C")]
	public static void StartFallbackSendAckThread()
	{
	}

	[Token(Token = "0x6001839")]
	[Address(RVA = "0x1B848E0", Offset = "0x1B848E0", VA = "0x1B848E0")]
	public static void StopFallbackSendAckThread()
	{
	}

	[Token(Token = "0x600183A")]
	[Address(RVA = "0x1B85A40", Offset = "0x1B85A40", VA = "0x1B85A40")]
	public static bool FallbackSendAckThread()
	{
		return default(bool);
	}

	[Token(Token = "0x600183D")]
	[Address(RVA = "0x1B861F0", Offset = "0x1B861F0", VA = "0x1B861F0")]
	protected internal static void PingAvailableRegionsAndConnectToBest()
	{
	}

	[Token(Token = "0x600183E")]
	[Address(RVA = "0x1B862CC", Offset = "0x1B862CC", VA = "0x1B862CC")]
	[DebuggerHidden]
	internal IEnumerator PingAvailableRegionsCoroutine(bool connectToBest)
	{
		return null;
	}

	[Token(Token = "0x600183F")]
	[Address(RVA = "0x1B8637C", Offset = "0x1B8637C", VA = "0x1B8637C")]
	private static void _003CStart_003Em__7E(Scene scene, LoadSceneMode loadingMode)
	{
	}
}
