using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000BCE")]
public class AntiCheatToolkitDetectionReciever : MonoBehaviour
{
	[Token(Token = "0x2000BCF")]
	private sealed class _003CGoToTitle_003Ec__Iterator90 : IDisposable
	{
		[Token(Token = "0x4003BF9")]
		[FieldOffset(Offset = "0x8")]
		internal int _0024PC;

		[Token(Token = "0x4003BFA")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x17000C86")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6005551")]
			[Address(RVA = "0x20BC8DC", Offset = "0x20BC8DC", VA = "0x20BC8DC", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000C87")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005552")]
			[Address(RVA = "0x20BC8E4", Offset = "0x20BC8E4", VA = "0x20BC8E4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6005550")]
		[Address(RVA = "0x20BC8D4", Offset = "0x20BC8D4", VA = "0x20BC8D4")]
		public _003CGoToTitle_003Ec__Iterator90()
		{
		}

		[Token(Token = "0x6005551")]
		[Address(RVA = "0x20BC8DC", Offset = "0x20BC8DC", VA = "0x20BC8DC", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6005552")]
		[Address(RVA = "0x20BC8E4", Offset = "0x20BC8E4", VA = "0x20BC8E4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6005553")]
		[Address(RVA = "0x20BC8EC", Offset = "0x20BC8EC", VA = "0x20BC8EC", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005554")]
		[Address(RVA = "0x20BCA2C", Offset = "0x20BCA2C", VA = "0x20BCA2C", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6005555")]
		[Address(RVA = "0x20BCA38", Offset = "0x20BCA38", VA = "0x20BCA38", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4003BF7")]
	public const string prefabPath = "act_detect";

	[Token(Token = "0x4003BF8")]
	[FieldOffset(Offset = "0x0")]
	public static GameObject obj;

	[Token(Token = "0x600554A")]
	[Address(RVA = "0x20BC38C", Offset = "0x20BC38C", VA = "0x20BC38C")]
	public AntiCheatToolkitDetectionReciever()
	{
	}

	[Token(Token = "0x600554C")]
	[Address(RVA = "0x20BC398", Offset = "0x20BC398", VA = "0x20BC398")]
	public static void Create()
	{
	}

	[Token(Token = "0x600554D")]
	[Address(RVA = "0x20BC640", Offset = "0x20BC640", VA = "0x20BC640")]
	public void OnObscuredCheatingDetected()
	{
	}

	[Token(Token = "0x600554E")]
	[Address(RVA = "0x20BC6C4", Offset = "0x20BC6C4", VA = "0x20BC6C4")]
	private void OnDetect(string reason)
	{
	}

	[Token(Token = "0x600554F")]
	[Address(RVA = "0x20BC848", Offset = "0x20BC848", VA = "0x20BC848")]
	[DebuggerHidden]
	private IEnumerator GoToTitle()
	{
		return null;
	}
}
