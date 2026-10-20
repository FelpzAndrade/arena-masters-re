using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F56")]
public class XUIRelicSlotItem : MonoBehaviour
{
	[Token(Token = "0x2000F57")]
	private sealed class _003CRefreshTimeOnSec_003Ec__IteratorAE : IDisposable
	{
		[Token(Token = "0x4005088")]
		[FieldOffset(Offset = "0x8")]
		internal int _0024PC;

		[Token(Token = "0x4005089")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400508A")]
		[FieldOffset(Offset = "0x10")]
		internal XUIRelicSlotItem _003C_003Ef__this;

		[Token(Token = "0x17000E8D")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60071EE")]
			[Address(RVA = "0x19198D4", Offset = "0x19198D4", VA = "0x19198D4", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000E8E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60071EF")]
			[Address(RVA = "0x19198DC", Offset = "0x19198DC", VA = "0x19198DC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60071ED")]
		[Address(RVA = "0x19196CC", Offset = "0x19196CC", VA = "0x19196CC")]
		public _003CRefreshTimeOnSec_003Ec__IteratorAE()
		{
		}

		[Token(Token = "0x60071EE")]
		[Address(RVA = "0x19198D4", Offset = "0x19198D4", VA = "0x19198D4", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60071EF")]
		[Address(RVA = "0x19198DC", Offset = "0x19198DC", VA = "0x19198DC", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60071F0")]
		[Address(RVA = "0x19198E4", Offset = "0x19198E4", VA = "0x19198E4", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60071F1")]
		[Address(RVA = "0x19199B8", Offset = "0x19199B8", VA = "0x19199B8", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x60071F2")]
		[Address(RVA = "0x19199C4", Offset = "0x19199C4", VA = "0x19199C4", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400507A")]
	[FieldOffset(Offset = "0xC")]
	public UI2DSprite sprIcon;

	[Token(Token = "0x400507B")]
	[FieldOffset(Offset = "0x10")]
	public GameObject goSprLock;

	[Token(Token = "0x400507C")]
	[FieldOffset(Offset = "0x14")]
	public GameObject goSprArrow;

	[Token(Token = "0x400507D")]
	[FieldOffset(Offset = "0x18")]
	public TweenPosition arrowTween;

	[Token(Token = "0x400507E")]
	[FieldOffset(Offset = "0x1C")]
	private RelicInfo selObject;

	[Token(Token = "0x400507F")]
	[FieldOffset(Offset = "0x20")]
	private int m_index;

	[Token(Token = "0x4005080")]
	[FieldOffset(Offset = "0x24")]
	public Action<int> selSlotIndex;

	[Token(Token = "0x4005081")]
	[FieldOffset(Offset = "0x28")]
	public Action setSlotAction;

	[Token(Token = "0x4005082")]
	[FieldOffset(Offset = "0x2C")]
	public Action<int> changeSlot;

	[Token(Token = "0x4005083")]
	[FieldOffset(Offset = "0x30")]
	public UIWidget bgType;

	[Token(Token = "0x4005084")]
	[FieldOffset(Offset = "0x34")]
	public UILabel lblLevel;

	[Token(Token = "0x4005085")]
	[FieldOffset(Offset = "0x38")]
	public UILabel lblRemainTime;

	[Token(Token = "0x4005086")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject DailyRelicBG;

	[Token(Token = "0x4005087")]
	[FieldOffset(Offset = "0x40")]
	public GameObject blockBg;

	[Token(Token = "0x60071DE")]
	[Address(RVA = "0x19187E0", Offset = "0x19187E0", VA = "0x19187E0")]
	public XUIRelicSlotItem()
	{
	}

	[Token(Token = "0x60071DF")]
	[Address(RVA = "0x19187F0", Offset = "0x19187F0", VA = "0x19187F0")]
	public void EnableBlockBg(bool enable)
	{
	}

	[Token(Token = "0x60071E0")]
	[Address(RVA = "0x19188D0", Offset = "0x19188D0", VA = "0x19188D0")]
	public void SetLastSlot()
	{
	}

	[Token(Token = "0x60071E1")]
	[Address(RVA = "0x1918A34", Offset = "0x1918A34", VA = "0x1918A34")]
	public void Build(Action<int> selSlot, Action slotAction)
	{
	}

	[Token(Token = "0x60071E2")]
	[Address(RVA = "0x1918D74", Offset = "0x1918D74", VA = "0x1918D74")]
	public void ChangeAction(Action<int> actionChange)
	{
	}

	[Token(Token = "0x60071E3")]
	[Address(RVA = "0x1918A40", Offset = "0x1918A40", VA = "0x1918A40")]
	public void InItItem()
	{
	}

	[Token(Token = "0x60071E4")]
	[Address(RVA = "0x1918D7C", Offset = "0x1918D7C", VA = "0x1918D7C")]
	public void CalculateRelicRemainTime()
	{
	}

	[Token(Token = "0x60071E5")]
	[Address(RVA = "0x1918E68", Offset = "0x1918E68", VA = "0x1918E68")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x60071E6")]
	[Address(RVA = "0x1918E70", Offset = "0x1918E70", VA = "0x1918E70")]
	public void RefreshSlotItem(int index)
	{
	}

	[Token(Token = "0x60071E7")]
	[Address(RVA = "0x1919454", Offset = "0x1919454", VA = "0x1919454")]
	public void RefreshArrow(bool state)
	{
	}

	[Token(Token = "0x60071E8")]
	[Address(RVA = "0x19194B0", Offset = "0x19194B0", VA = "0x19194B0")]
	public void OnClick()
	{
	}

	[Token(Token = "0x60071E9")]
	[Address(RVA = "0x19196BC", Offset = "0x19196BC", VA = "0x19196BC")]
	public void SettingObject(RelicInfo obj)
	{
	}

	[Token(Token = "0x60071EA")]
	[Address(RVA = "0x19196C4", Offset = "0x19196C4", VA = "0x19196C4")]
	public GameObject SlotGameObject()
	{
		return null;
	}

	[Token(Token = "0x60071EB")]
	[Address(RVA = "0x1918DC4", Offset = "0x1918DC4", VA = "0x1918DC4")]
	[DebuggerHidden]
	private IEnumerator RefreshTimeOnSec()
	{
		return null;
	}

	[Token(Token = "0x60071EC")]
	[Address(RVA = "0x19196D4", Offset = "0x19196D4", VA = "0x19196D4")]
	private void RefreshDailyBoxResetTime()
	{
	}
}
