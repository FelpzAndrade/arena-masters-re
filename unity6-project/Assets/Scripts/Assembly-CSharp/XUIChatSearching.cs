using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C3C")]
public class XUIChatSearching : MonoBehaviour
{
	[Token(Token = "0x2000C3D")]
	private sealed class _003CCountTimeLabel_003Ec__Iterator98 : IDisposable
	{
		[Token(Token = "0x4003DDD")]
		[FieldOffset(Offset = "0x8")]
		internal int _0024PC;

		[Token(Token = "0x4003DDE")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x4003DDF")]
		[FieldOffset(Offset = "0x10")]
		internal XUIChatSearching _003C_003Ef__this;

		[Token(Token = "0x17000CB0")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6005874")]
			[Address(RVA = "0x1A351A4", Offset = "0x1A351A4", VA = "0x1A351A4", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000CB1")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005875")]
			[Address(RVA = "0x1A351AC", Offset = "0x1A351AC", VA = "0x1A351AC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6005873")]
		[Address(RVA = "0x1A35070", Offset = "0x1A35070", VA = "0x1A35070")]
		public _003CCountTimeLabel_003Ec__Iterator98()
		{
		}

		[Token(Token = "0x6005874")]
		[Address(RVA = "0x1A351A4", Offset = "0x1A351A4", VA = "0x1A351A4", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6005875")]
		[Address(RVA = "0x1A351AC", Offset = "0x1A351AC", VA = "0x1A351AC", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6005876")]
		[Address(RVA = "0x1A351B4", Offset = "0x1A351B4", VA = "0x1A351B4", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005877")]
		[Address(RVA = "0x1A35358", Offset = "0x1A35358", VA = "0x1A35358", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6005878")]
		[Address(RVA = "0x1A35364", Offset = "0x1A35364", VA = "0x1A35364", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4003DDB")]
	[FieldOffset(Offset = "0xC")]
	public UILabel Time;

	[Token(Token = "0x4003DDC")]
	[FieldOffset(Offset = "0x10")]
	private Stopwatch m_stopWatch;

	[Token(Token = "0x600586B")]
	[Address(RVA = "0x1A34E64", Offset = "0x1A34E64", VA = "0x1A34E64")]
	public XUIChatSearching()
	{
	}

	[Token(Token = "0x600586C")]
	[Address(RVA = "0x1A34F00", Offset = "0x1A34F00", VA = "0x1A34F00")]
	public void SetEnableTime(bool enable)
	{
	}

	[Token(Token = "0x600586D")]
	[Address(RVA = "0x1A34F2C", Offset = "0x1A34F2C", VA = "0x1A34F2C")]
	public void SetActive(bool active)
	{
	}

	[Token(Token = "0x600586E")]
	[Address(RVA = "0x1A34F74", Offset = "0x1A34F74", VA = "0x1A34F74")]
	public void ResetTime()
	{
	}

	[Token(Token = "0x600586F")]
	[Address(RVA = "0x1A34FA0", Offset = "0x1A34FA0", VA = "0x1A34FA0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6005870")]
	[Address(RVA = "0x1A35068", Offset = "0x1A35068", VA = "0x1A35068")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6005871")]
	[Address(RVA = "0x1A34FC4", Offset = "0x1A34FC4", VA = "0x1A34FC4")]
	[DebuggerHidden]
	private IEnumerator CountTimeLabel()
	{
		return null;
	}

	[Token(Token = "0x6005872")]
	[Address(RVA = "0x1A35078", Offset = "0x1A35078", VA = "0x1A35078")]
	private string ToMinSecString(int sec)
	{
		return null;
	}
}
