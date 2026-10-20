using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000056")]
public class ChatManager : MonoBehaviour
{
	[Token(Token = "0x2000057")]
	private sealed class _003CProgressChat_003Ec__Iterator10 : IDisposable
	{
		[Token(Token = "0x400017B")]
		[FieldOffset(Offset = "0x8")]
		internal HUDText _003Cct_003E__0;

		[Token(Token = "0x400017C")]
		[FieldOffset(Offset = "0xC")]
		internal int _0024PC;

		[Token(Token = "0x400017D")]
		[FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x400017E")]
		[FieldOffset(Offset = "0x14")]
		internal ChatManager _003C_003Ef__this;

		[Token(Token = "0x17000051")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60002D0")]
			[Address(RVA = "0x20C4F70", Offset = "0x20C4F70", VA = "0x20C4F70", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000052")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60002D1")]
			[Address(RVA = "0x20C4F78", Offset = "0x20C4F78", VA = "0x20C4F78", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x20C4F68", Offset = "0x20C4F68", VA = "0x20C4F68")]
		public _003CProgressChat_003Ec__Iterator10()
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x20C4F70", Offset = "0x20C4F70", VA = "0x20C4F70", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x20C4F78", Offset = "0x20C4F78", VA = "0x20C4F78", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x20C4F80", Offset = "0x20C4F80", VA = "0x20C4F80", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x20C5324", Offset = "0x20C5324", VA = "0x20C5324", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x20C5330", Offset = "0x20C5330", VA = "0x20C5330", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4000174")]
	[FieldOffset(Offset = "0x0")]
	public static ChatManager instance;

	[Token(Token = "0x4000175")]
	[FieldOffset(Offset = "0xC")]
	public string[] chatMessages;

	[Token(Token = "0x4000176")]
	[FieldOffset(Offset = "0x10")]
	public LookAtTarget cameraLookAt;

	[Token(Token = "0x4000177")]
	[FieldOffset(Offset = "0x14")]
	private List<ChatParticipant> mParticipants;

	[Token(Token = "0x4000178")]
	[FieldOffset(Offset = "0x18")]
	private int mCurrentChatter;

	[Token(Token = "0x4000179")]
	[FieldOffset(Offset = "0x1C")]
	private int mCurrentMessage;

	[Token(Token = "0x400017A")]
	[FieldOffset(Offset = "0x20")]
	private bool mDisplay;

	[Token(Token = "0x60002C9")]
	[Address(RVA = "0x20C4C2C", Offset = "0x20C4C2C", VA = "0x20C4C2C")]
	public ChatManager()
	{
	}

	[Token(Token = "0x60002CA")]
	[Address(RVA = "0x20C4CD8", Offset = "0x20C4CD8", VA = "0x20C4CD8")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002CB")]
	[Address(RVA = "0x20C4D5C", Offset = "0x20C4D5C", VA = "0x20C4D5C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60002CC")]
	[Address(RVA = "0x20C4DE0", Offset = "0x20C4DE0", VA = "0x20C4DE0")]
	public void AddParticipant(ChatParticipant participant)
	{
	}

	[Token(Token = "0x60002CD")]
	[Address(RVA = "0x20C4E80", Offset = "0x20C4E80", VA = "0x20C4E80")]
	private void Update()
	{
	}

	[Token(Token = "0x60002CE")]
	[Address(RVA = "0x20C4EC4", Offset = "0x20C4EC4", VA = "0x20C4EC4")]
	[DebuggerHidden]
	private IEnumerator ProgressChat()
	{
		return null;
	}
}
