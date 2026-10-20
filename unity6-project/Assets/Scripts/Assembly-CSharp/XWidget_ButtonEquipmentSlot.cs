using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using CS;
using Il2CppDummyDll;
using UnityEngine;
using XAssetBundle;

[Token(Token = "0x2000EC6")]
public class XWidget_ButtonEquipmentSlot : MonoBehaviour
{
	[Token(Token = "0x2000EC7")]
	private sealed class _003CLoadAsync_003Ec__IteratorAB : IDisposable
	{
		[Token(Token = "0x4004DA6")]
		[FieldOffset(Offset = "0x8")]
		internal XAssetBundleLoadAssetOperation _003Creq_003E__0;

		[Token(Token = "0x4004DA7")]
		[FieldOffset(Offset = "0xC")]
		internal GameObject _003Cprefab_003E__1;

		[Token(Token = "0x4004DA8")]
		[FieldOffset(Offset = "0x10")]
		internal XItem item;

		[Token(Token = "0x4004DA9")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x4004DAA")]
		[FieldOffset(Offset = "0x18")]
		internal object _0024current;

		[Token(Token = "0x4004DAB")]
		[FieldOffset(Offset = "0x1C")]
		internal XItem _003C_0024_003Eitem;

		[Token(Token = "0x4004DAC")]
		[FieldOffset(Offset = "0x20")]
		internal XWidget_ButtonEquipmentSlot _003C_003Ef__this;

		[Token(Token = "0x17000E15")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6006E22")]
			[Address(RVA = "0x15C5570", Offset = "0x15C5570", VA = "0x15C5570", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000E16")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6006E23")]
			[Address(RVA = "0x15C5578", Offset = "0x15C5578", VA = "0x15C5578", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6006E21")]
		[Address(RVA = "0x15C5110", Offset = "0x15C5110", VA = "0x15C5110")]
		public _003CLoadAsync_003Ec__IteratorAB()
		{
		}

		[Token(Token = "0x6006E22")]
		[Address(RVA = "0x15C5570", Offset = "0x15C5570", VA = "0x15C5570", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6006E23")]
		[Address(RVA = "0x15C5578", Offset = "0x15C5578", VA = "0x15C5578", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6006E24")]
		[Address(RVA = "0x15C5580", Offset = "0x15C5580", VA = "0x15C5580", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6006E25")]
		[Address(RVA = "0x15C57D8", Offset = "0x15C57D8", VA = "0x15C57D8", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6006E26")]
		[Address(RVA = "0x15C57E4", Offset = "0x15C57E4", VA = "0x15C57E4", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4004D98")]
	[FieldOffset(Offset = "0xC")]
	public Transform iconParent;

	[Token(Token = "0x4004D99")]
	[FieldOffset(Offset = "0x10")]
	public AnimationCurve curve;

	[Token(Token = "0x4004D9A")]
	[FieldOffset(Offset = "0x14")]
	public float duration;

	[Token(Token = "0x4004D9B")]
	[FieldOffset(Offset = "0x18")]
	public UISprite slotBg;

	[Token(Token = "0x4004D9C")]
	[FieldOffset(Offset = "0x1C")]
	public string[] slotBGSpriteNames;

	[Token(Token = "0x4004D9D")]
	[FieldOffset(Offset = "0x20")]
	public UISprite slotLock;

	[Token(Token = "0x4004D9E")]
	[FieldOffset(Offset = "0x24")]
	public UILabel lockInfo;

	[Token(Token = "0x4004D9F")]
	[FieldOffset(Offset = "0x28")]
	public TweenAlpha lockInfoTweenAlpha;

	[Token(Token = "0x4004DA0")]
	[FieldOffset(Offset = "0x2C")]
	private XItem m_item;

	[Token(Token = "0x4004DA1")]
	[FieldOffset(Offset = "0x30")]
	private Action m_onClick;

	[Token(Token = "0x4004DA2")]
	[FieldOffset(Offset = "0x34")]
	private XWidget_ItemIcon m_icon;

	[Token(Token = "0x4004DA3")]
	[FieldOffset(Offset = "0x38")]
	private UIToggle m_toggle;

	[Token(Token = "0x4004DA4")]
	[FieldOffset(Offset = "0x3C")]
	private EquipmentSlot m_slot;

	[Token(Token = "0x4004DA5")]
	[FieldOffset(Offset = "0x40")]
	public XWidget_NGUITween onEquipEffect;

	[Token(Token = "0x6006E17")]
	[Address(RVA = "0x15C4C40", Offset = "0x15C4C40", VA = "0x15C4C40")]
	public XWidget_ButtonEquipmentSlot()
	{
	}

	[Token(Token = "0x6006E18")]
	[Address(RVA = "0x15C4C50", Offset = "0x15C4C50", VA = "0x15C4C50")]
	private void Awake()
	{
	}

	[Token(Token = "0x6006E19")]
	[Address(RVA = "0x15C4D54", Offset = "0x15C4D54", VA = "0x15C4D54")]
	private void Start()
	{
	}

	[Token(Token = "0x6006E1A")]
	[Address(RVA = "0x15C4D58", Offset = "0x15C4D58", VA = "0x15C4D58")]
	public void Build(XItem item, EquipmentSlot slot, Action onClick, bool lockSlot, bool enableSeleted = false)
	{
	}

	[Token(Token = "0x6006E1B")]
	[Address(RVA = "0x15C5060", Offset = "0x15C5060", VA = "0x15C5060")]
	[DebuggerHidden]
	private IEnumerator LoadAsync(XItem item)
	{
		return null;
	}

	[Token(Token = "0x6006E1C")]
	[Address(RVA = "0x15C501C", Offset = "0x15C501C", VA = "0x15C501C")]
	private string GetSlotBG(EquipmentSlot slot)
	{
		return null;
	}

	[Token(Token = "0x6006E1D")]
	[Address(RVA = "0x15C5118", Offset = "0x15C5118", VA = "0x15C5118")]
	private void OnClick()
	{
	}

	[Token(Token = "0x6006E1E")]
	[Address(RVA = "0x15C52B4", Offset = "0x15C52B4", VA = "0x15C52B4")]
	public void OnPress(bool bshow)
	{
	}

	[Token(Token = "0x6006E1F")]
	[Address(RVA = "0x15C52A0", Offset = "0x15C52A0", VA = "0x15C52A0")]
	private void ShowDetail()
	{
	}

	[Token(Token = "0x6006E20")]
	[Address(RVA = "0x15C5490", Offset = "0x15C5490", VA = "0x15C5490")]
	public void EquipEffect()
	{
	}
}
