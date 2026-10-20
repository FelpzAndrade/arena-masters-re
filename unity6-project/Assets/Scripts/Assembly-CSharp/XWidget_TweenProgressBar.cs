using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D4F")]
public class XWidget_TweenProgressBar : MonoBehaviour
{
	[Token(Token = "0x2000D50")]
	private sealed class _003CTween_003Ec__Iterator9E : IDisposable
	{
		[Token(Token = "0x4004472")]
		[FieldOffset(Offset = "0x8")]
		internal float duration;

		[Token(Token = "0x4004473")]
		[FieldOffset(Offset = "0xC")]
		internal int _0024PC;

		[Token(Token = "0x4004474")]
		[FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x4004475")]
		[FieldOffset(Offset = "0x14")]
		internal float _003C_0024_003Eduration;

		[Token(Token = "0x4004476")]
		[FieldOffset(Offset = "0x18")]
		internal XWidget_TweenProgressBar _003C_003Ef__this;

		[Token(Token = "0x17000D2A")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60061BA")]
			[Address(RVA = "0x1B32B44", Offset = "0x1B32B44", VA = "0x1B32B44", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000D2B")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60061BB")]
			[Address(RVA = "0x1B32B4C", Offset = "0x1B32B4C", VA = "0x1B32B4C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60061B9")]
		[Address(RVA = "0x1B32910", Offset = "0x1B32910", VA = "0x1B32910")]
		public _003CTween_003Ec__Iterator9E()
		{
		}

		[Token(Token = "0x60061BA")]
		[Address(RVA = "0x1B32B44", Offset = "0x1B32B44", VA = "0x1B32B44", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60061BB")]
		[Address(RVA = "0x1B32B4C", Offset = "0x1B32B4C", VA = "0x1B32B4C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60061BC")]
		[Address(RVA = "0x1B32B54", Offset = "0x1B32B54", VA = "0x1B32B54", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60061BD")]
		[Address(RVA = "0x1B32CAC", Offset = "0x1B32CAC", VA = "0x1B32CAC", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x60061BE")]
		[Address(RVA = "0x1B32CB8", Offset = "0x1B32CB8", VA = "0x1B32CB8", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4004468")]
	[FieldOffset(Offset = "0xC")]
	public UIProgressBar progressbar;

	[Token(Token = "0x4004469")]
	[FieldOffset(Offset = "0x10")]
	public UILabel label;

	[Token(Token = "0x400446A")]
	[FieldOffset(Offset = "0x14")]
	public int viewCost;

	[Token(Token = "0x400446B")]
	[FieldOffset(Offset = "0x18")]
	public float defaultDuration;

	[Token(Token = "0x400446C")]
	[FieldOffset(Offset = "0x1C")]
	private float elaspedTime;

	[Token(Token = "0x400446D")]
	[FieldOffset(Offset = "0x20")]
	private float viewCostFloat;

	[Token(Token = "0x400446E")]
	[FieldOffset(Offset = "0x24")]
	private int costDiff;

	[Token(Token = "0x400446F")]
	[FieldOffset(Offset = "0x28")]
	private int startCost;

	[Token(Token = "0x4004470")]
	[FieldOffset(Offset = "0x2C")]
	private int targetCost;

	[Token(Token = "0x4004471")]
	[FieldOffset(Offset = "0x30")]
	private int m_maxCost;

	[Token(Token = "0x60061B3")]
	[Address(RVA = "0x1B3284C", Offset = "0x1B3284C", VA = "0x1B3284C")]
	public XWidget_TweenProgressBar()
	{
	}

	[Token(Token = "0x60061B4")]
	[Address(RVA = "0x1B3285C", Offset = "0x1B3285C", VA = "0x1B3285C")]
	[DebuggerHidden]
	private IEnumerator Tween(float duration)
	{
		return null;
	}

	[Token(Token = "0x60061B5")]
	[Address(RVA = "0x1B32918", Offset = "0x1B32918", VA = "0x1B32918")]
	public void DoTweenCost(int initCost, int targetCost, float duration = 0f)
	{
	}

	[Token(Token = "0x60061B6")]
	[Address(RVA = "0x1B32968", Offset = "0x1B32968", VA = "0x1B32968")]
	public void AddCost(int targetCost, float duration = 0f)
	{
	}

	[Token(Token = "0x60061B7")]
	[Address(RVA = "0x1B3298C", Offset = "0x1B3298C", VA = "0x1B3298C")]
	public void InitCost(int startCost = 0, int maxCost = 1)
	{
	}

	[Token(Token = "0x60061B8")]
	[Address(RVA = "0x1B329F0", Offset = "0x1B329F0", VA = "0x1B329F0")]
	private void SetCostLabel()
	{
	}
}
