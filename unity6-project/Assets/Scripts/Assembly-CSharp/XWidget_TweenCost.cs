using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000CAA")]
public class XWidget_TweenCost : MonoBehaviour
{
	[Token(Token = "0x2000CAB")]
	private sealed class _003CTween_003Ec__Iterator9A : IDisposable
	{
		[Token(Token = "0x400408D")]
		[FieldOffset(Offset = "0x8")]
		internal float duration;

		[Token(Token = "0x400408E")]
		[FieldOffset(Offset = "0xC")]
		internal int _0024PC;

		[Token(Token = "0x400408F")]
		[FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x4004090")]
		[FieldOffset(Offset = "0x14")]
		internal float _003C_0024_003Eduration;

		[Token(Token = "0x4004091")]
		[FieldOffset(Offset = "0x18")]
		internal XWidget_TweenCost _003C_003Ef__this;

		[Token(Token = "0x17000CCA")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6005B73")]
			[Address(RVA = "0x1B31EF0", Offset = "0x1B31EF0", VA = "0x1B31EF0", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000CCB")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005B74")]
			[Address(RVA = "0x1B31EF8", Offset = "0x1B31EF8", VA = "0x1B31EF8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6005B72")]
		[Address(RVA = "0x1B31D3C", Offset = "0x1B31D3C", VA = "0x1B31D3C")]
		public _003CTween_003Ec__Iterator9A()
		{
		}

		[Token(Token = "0x6005B73")]
		[Address(RVA = "0x1B31EF0", Offset = "0x1B31EF0", VA = "0x1B31EF0", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6005B74")]
		[Address(RVA = "0x1B31EF8", Offset = "0x1B31EF8", VA = "0x1B31EF8", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6005B75")]
		[Address(RVA = "0x1B31F00", Offset = "0x1B31F00", VA = "0x1B31F00", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005B76")]
		[Address(RVA = "0x1B32024", Offset = "0x1B32024", VA = "0x1B32024", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6005B77")]
		[Address(RVA = "0x1B32030", Offset = "0x1B32030", VA = "0x1B32030", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4004086")]
	[FieldOffset(Offset = "0xC")]
	public UILabel label;

	[Token(Token = "0x4004087")]
	[FieldOffset(Offset = "0x10")]
	public int viewCost;

	[Token(Token = "0x4004088")]
	[FieldOffset(Offset = "0x14")]
	public float defaultDuration;

	[Token(Token = "0x4004089")]
	[FieldOffset(Offset = "0x18")]
	private float elaspedTime;

	[Token(Token = "0x400408A")]
	[FieldOffset(Offset = "0x1C")]
	private int costDiff;

	[Token(Token = "0x400408B")]
	[FieldOffset(Offset = "0x20")]
	private int startCost;

	[Token(Token = "0x400408C")]
	[FieldOffset(Offset = "0x24")]
	private int targetCost;

	[Token(Token = "0x6005B6C")]
	[Address(RVA = "0x1B31C78", Offset = "0x1B31C78", VA = "0x1B31C78")]
	public XWidget_TweenCost()
	{
	}

	[Token(Token = "0x6005B6D")]
	[Address(RVA = "0x1B31C88", Offset = "0x1B31C88", VA = "0x1B31C88")]
	[DebuggerHidden]
	private IEnumerator Tween(float duration)
	{
		return null;
	}

	[Token(Token = "0x6005B6E")]
	[Address(RVA = "0x1B31D44", Offset = "0x1B31D44", VA = "0x1B31D44")]
	public void DoTweenCost(int initCost, int targetCost, float duration = 0f)
	{
	}

	[Token(Token = "0x6005B6F")]
	[Address(RVA = "0x1B31D94", Offset = "0x1B31D94", VA = "0x1B31D94")]
	public void AddCost(int targetCost, float duration = 0f)
	{
	}

	[Token(Token = "0x6005B70")]
	[Address(RVA = "0x1B31DB8", Offset = "0x1B31DB8", VA = "0x1B31DB8")]
	public void InitCost(int startCost = 0)
	{
	}

	[Token(Token = "0x6005B71")]
	[Address(RVA = "0x1B31DC4", Offset = "0x1B31DC4", VA = "0x1B31DC4")]
	private void SetCostLabel()
	{
	}
}
