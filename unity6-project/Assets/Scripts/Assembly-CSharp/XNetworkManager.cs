using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200082C")]
public class XNetworkManager : CSNetworkManager
{
	[Token(Token = "0x200082D")]
	private sealed class _003CUpdate_NetProcessor_003Ec__Iterator89 : IDisposable
	{
		[Token(Token = "0x400234E")]
		[FieldOffset(Offset = "0x8")]
		internal int _0024PC;

		[Token(Token = "0x400234F")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x4002350")]
		[FieldOffset(Offset = "0x10")]
		internal XNetworkManager _003C_003Ef__this;

		[Token(Token = "0x17000922")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6004158")]
			[Address(RVA = "0x1ECF2E4", Offset = "0x1ECF2E4", VA = "0x1ECF2E4", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000923")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6004159")]
			[Address(RVA = "0x1ECF2EC", Offset = "0x1ECF2EC", VA = "0x1ECF2EC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6004157")]
		[Address(RVA = "0x1ECD6D4", Offset = "0x1ECD6D4", VA = "0x1ECD6D4")]
		public _003CUpdate_NetProcessor_003Ec__Iterator89()
		{
		}

		[Token(Token = "0x6004158")]
		[Address(RVA = "0x1ECF2E4", Offset = "0x1ECF2E4", VA = "0x1ECF2E4", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6004159")]
		[Address(RVA = "0x1ECF2EC", Offset = "0x1ECF2EC", VA = "0x1ECF2EC", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600415A")]
		[Address(RVA = "0x1ECF2F4", Offset = "0x1ECF2F4", VA = "0x1ECF2F4", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600415B")]
		[Address(RVA = "0x1ECF464", Offset = "0x1ECF464", VA = "0x1ECF464", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x600415C")]
		[Address(RVA = "0x1ECF470", Offset = "0x1ECF470", VA = "0x1ECF470", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4002346")]
	[FieldOffset(Offset = "0x0")]
	public static readonly XNetworkManager Instance;

	[Token(Token = "0x4002347")]
	[FieldOffset(Offset = "0x8")]
	public INetProcessor processor;

	[Token(Token = "0x4002348")]
	[FieldOffset(Offset = "0xC")]
	private Coroutine processorCoroutine;

	[Token(Token = "0x4002349")]
	[FieldOffset(Offset = "0x10")]
	private XHttpNetwork m_HttpNetwork;

	[Token(Token = "0x400234A")]
	[FieldOffset(Offset = "0x14")]
	private bool m_inited;

	[Token(Token = "0x400234B")]
	[FieldOffset(Offset = "0x18")]
	private float remainPingTime;

	[Token(Token = "0x400234C")]
	[FieldOffset(Offset = "0x1C")]
	private float remainPollingProcessTime;

	[Token(Token = "0x400234D")]
	[FieldOffset(Offset = "0x20")]
	public string TempUserName;

	[Token(Token = "0x17000920")]
	public long ServerTime
	{
		[Token(Token = "0x600413D")]
		[Address(RVA = "0x1ECD310", Offset = "0x1ECD310", VA = "0x1ECD310")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x17000921")]
	public bool IsInitialize
	{
		[Token(Token = "0x600413E")]
		[Address(RVA = "0x1ECD3DC", Offset = "0x1ECD3DC", VA = "0x1ECD3DC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600413B")]
	[Address(RVA = "0x1ECD1E4", Offset = "0x1ECD1E4", VA = "0x1ECD1E4")]
	public XNetworkManager()
	{
	}

	[Token(Token = "0x600413F")]
	[Address(RVA = "0x1ECD3E4", Offset = "0x1ECD3E4", VA = "0x1ECD3E4")]
	public void Init()
	{
	}

	[Token(Token = "0x6004140")]
	[Address(RVA = "0x1ECD490", Offset = "0x1ECD490", VA = "0x1ECD490")]
	public void Init(INetProcessor processor)
	{
	}

	[Token(Token = "0x6004141")]
	[Address(RVA = "0x1ECD630", Offset = "0x1ECD630", VA = "0x1ECD630")]
	[DebuggerHidden]
	private IEnumerator Update_NetProcessor()
	{
		return null;
	}

	[Token(Token = "0x6004142")]
	[Address(RVA = "0x1ECD6DC", Offset = "0x1ECD6DC", VA = "0x1ECD6DC")]
	public void Update()
	{
	}

	[Token(Token = "0x6004143")]
	[Address(RVA = "0x1ECD728", Offset = "0x1ECD728", VA = "0x1ECD728")]
	private void UpdatePing(float deltaTime)
	{
	}

	[Token(Token = "0x6004144")]
	[Address(RVA = "0x1EBDB48", Offset = "0x1EBDB48", VA = "0x1EBDB48")]
	public void PostPing()
	{
	}

	[Token(Token = "0x6004145")]
	[Address(RVA = "0x1ECD8D4", Offset = "0x1ECD8D4", VA = "0x1ECD8D4")]
	private void UpdatePollingProcess(float deltaTime)
	{
	}

	[Token(Token = "0x6004146")]
	[Address(RVA = "0x1ECDA80", Offset = "0x1ECDA80", VA = "0x1ECDA80")]
	public void PostPollingProcess()
	{
	}

	[Token(Token = "0x6004147")]
	[Address(RVA = "0x1ECDC18", Offset = "0x1ECDC18", VA = "0x1ECDC18")]
	public void ResetGameTimeStamp()
	{
	}

	[Token(Token = "0x6004148")]
	public void RunCommand<T>(NetCallback callback, CSNetParameters param) where T : CSNetCommand, new()
	{
	}

	[Token(Token = "0x6004149")]
	public void RunCommand<T>(NetCallback callback, params CSNetParameters[] values) where T : CSNetCommand, new()
	{
	}

	[Token(Token = "0x600414A")]
	[Address(RVA = "0x1ECDCE0", Offset = "0x1ECDCE0", VA = "0x1ECDCE0", Slot = "4")]
	public void RunCommand(CSNetCommand cmd)
	{
	}

	[Token(Token = "0x600414B")]
	[Address(RVA = "0x1ECDD0C", Offset = "0x1ECDD0C", VA = "0x1ECDD0C")]
	public void ClearProcess()
	{
	}

	[Token(Token = "0x600414C")]
	[Address(RVA = "0x1ECDE18", Offset = "0x1ECDE18", VA = "0x1ECDE18")]
	public void InitToy()
	{
	}

	[Token(Token = "0x600414D")]
	[Address(RVA = "0x1ECDEE0", Offset = "0x1ECDEE0", VA = "0x1ECDEE0")]
	public void LoadClientProtoInfo()
	{
	}

	[Token(Token = "0x600414E")]
	[Address(RVA = "0x1ECDFA8", Offset = "0x1ECDFA8", VA = "0x1ECDFA8")]
	public void StartNexonLogin()
	{
	}

	[Token(Token = "0x600414F")]
	[Address(RVA = "0x1ECE070", Offset = "0x1ECE070", VA = "0x1ECE070")]
	public void StartLogin()
	{
	}

	[Token(Token = "0x6004150")]
	[Address(RVA = "0x1ECE138", Offset = "0x1ECE138", VA = "0x1ECE138")]
	public void StarTitleProcess()
	{
	}

	[Token(Token = "0x6004151")]
	[Address(RVA = "0x1ECE13C", Offset = "0x1ECE13C", VA = "0x1ECE13C")]
	public void Logout()
	{
	}

	[Token(Token = "0x6004152")]
	[Address(RVA = "0x1ECE140", Offset = "0x1ECE140", VA = "0x1ECE140")]
	public void PingToDDingDong(string strCmd)
	{
	}

	[Token(Token = "0x6004153")]
	[Address(RVA = "0x1ECE774", Offset = "0x1ECE774", VA = "0x1ECE774")]
	public void PurchaseLogToSlack(IShopItem item, string prefix, string message)
	{
	}

	[Token(Token = "0x6004154")]
	[Address(RVA = "0x1ECEDB4", Offset = "0x1ECEDB4", VA = "0x1ECEDB4")]
	public void LogToSlack(string url, string strLog)
	{
	}

	[Token(Token = "0x6004155")]
	[Address(RVA = "0x1ECEFEC", Offset = "0x1ECEFEC", VA = "0x1ECEFEC")]
	public string GetCommandDebugLog()
	{
		return null;
	}

	[Token(Token = "0x6004156")]
	[Address(RVA = "0x1ECF168", Offset = "0x1ECF168", VA = "0x1ECF168")]
	public string GetHttpRequestFailCommandLog()
	{
		return null;
	}
}
