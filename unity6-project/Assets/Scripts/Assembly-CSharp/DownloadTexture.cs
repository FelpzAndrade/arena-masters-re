using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001A8")]
public class DownloadTexture : MonoBehaviour
{
	[Token(Token = "0x20001A9")]
	private sealed class _003CStart_003Ec__Iterator22 : IDisposable
	{
		[Token(Token = "0x400062D")]
		[FieldOffset(Offset = "0x8")]
		internal WWW _003Cwww_003E__0;

		[Token(Token = "0x400062E")]
		[FieldOffset(Offset = "0xC")]
		internal UITexture _003Cut_003E__1;

		[Token(Token = "0x400062F")]
		[FieldOffset(Offset = "0x10")]
		internal int _0024PC;

		[Token(Token = "0x4000630")]
		[FieldOffset(Offset = "0x14")]
		internal object _0024current;

		[Token(Token = "0x4000631")]
		[FieldOffset(Offset = "0x18")]
		internal DownloadTexture _003C_003Ef__this;

		[Token(Token = "0x17000247")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6000EAA")]
			[Address(RVA = "0x1E656EC", Offset = "0x1E656EC", VA = "0x1E656EC", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000248")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000EAB")]
			[Address(RVA = "0x1E656F4", Offset = "0x1E656F4", VA = "0x1E656F4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000EA9")]
		[Address(RVA = "0x1E655E8", Offset = "0x1E655E8", VA = "0x1E655E8")]
		public _003CStart_003Ec__Iterator22()
		{
		}

		[Token(Token = "0x6000EAA")]
		[Address(RVA = "0x1E656EC", Offset = "0x1E656EC", VA = "0x1E656EC", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000EAB")]
		[Address(RVA = "0x1E656F4", Offset = "0x1E656F4", VA = "0x1E656F4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000EAC")]
		[Address(RVA = "0x1E656FC", Offset = "0x1E656FC", VA = "0x1E656FC", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000EAD")]
		[Address(RVA = "0x1E6594C", Offset = "0x1E6594C", VA = "0x1E6594C", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000EAE")]
		[Address(RVA = "0x1E65958", Offset = "0x1E65958", VA = "0x1E65958", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400062A")]
	[FieldOffset(Offset = "0xC")]
	public string url;

	[Token(Token = "0x400062B")]
	[FieldOffset(Offset = "0x10")]
	public bool pixelPerfect;

	[Token(Token = "0x400062C")]
	[FieldOffset(Offset = "0x14")]
	private Texture2D mTex;

	[Token(Token = "0x6000EA6")]
	[Address(RVA = "0x1E654B0", Offset = "0x1E654B0", VA = "0x1E654B0")]
	public DownloadTexture()
	{
	}

	[Token(Token = "0x6000EA7")]
	[Address(RVA = "0x1E65544", Offset = "0x1E65544", VA = "0x1E65544")]
	[DebuggerHidden]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6000EA8")]
	[Address(RVA = "0x1E655F0", Offset = "0x1E655F0", VA = "0x1E655F0")]
	private void OnDestroy()
	{
	}
}
