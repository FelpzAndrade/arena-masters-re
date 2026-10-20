using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Photon;

[Token(Token = "0x2000308")]
public class OnClickDestroy : MonoBehaviour
{
	[Token(Token = "0x2000309")]
	private sealed class _003CDestroyRpc_003Ec__Iterator29 : IDisposable
	{
		[Token(Token = "0x400101A")]
		[FieldOffset(Offset = "0x8")]
		internal int _0024PC;

		[Token(Token = "0x400101B")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400101C")]
		[FieldOffset(Offset = "0x10")]
		internal OnClickDestroy _003C_003Ef__this;

		[Token(Token = "0x17000486")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6001A4D")]
			[Address(RVA = "0x11E5AF8", Offset = "0x11E5AF8", VA = "0x11E5AF8", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000487")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001A4E")]
			[Address(RVA = "0x11E5B00", Offset = "0x11E5B00", VA = "0x11E5B00", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001A4C")]
		[Address(RVA = "0x11E5AF0", Offset = "0x11E5AF0", VA = "0x11E5AF0")]
		public _003CDestroyRpc_003Ec__Iterator29()
		{
		}

		[Token(Token = "0x6001A4D")]
		[Address(RVA = "0x11E5AF8", Offset = "0x11E5AF8", VA = "0x11E5AF8", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001A4E")]
		[Address(RVA = "0x11E5B00", Offset = "0x11E5B00", VA = "0x11E5B00", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001A4F")]
		[Address(RVA = "0x11E5B08", Offset = "0x11E5B08", VA = "0x11E5B08", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6001A50")]
		[Address(RVA = "0x11E5CB8", Offset = "0x11E5CB8", VA = "0x11E5CB8", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6001A51")]
		[Address(RVA = "0x11E5CC4", Offset = "0x11E5CC4", VA = "0x11E5CC4", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4001019")]
	[FieldOffset(Offset = "0x10")]
	public bool DestroyByRpc;

	[Token(Token = "0x6001A49")]
	[Address(RVA = "0x11E58F0", Offset = "0x11E58F0", VA = "0x11E58F0")]
	public OnClickDestroy()
	{
	}

	[Token(Token = "0x6001A4A")]
	[Address(RVA = "0x11E58F8", Offset = "0x11E58F8", VA = "0x11E58F8")]
	public void OnClick()
	{
	}

	[Token(Token = "0x6001A4B")]
	[Address(RVA = "0x11E5A4C", Offset = "0x11E5A4C", VA = "0x11E5A4C")]
	[DebuggerHidden]
	[PunRPC]
	public IEnumerator DestroyRpc()
	{
		return null;
	}
}
