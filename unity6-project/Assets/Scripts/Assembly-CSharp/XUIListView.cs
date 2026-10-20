using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D96")]
public abstract class XUIListView : MonoBehaviour
{
	[Token(Token = "0x2000D97")]
	public enum ArrangementTypes
	{
		[Token(Token = "0x40046A2")]
		Horizontal = 0,
		[Token(Token = "0x40046A3")]
		Vertical = 1
	}

	[Token(Token = "0x2000D98")]
	private sealed class _003CAsyncBuild_003Ec__IteratorA1 : IDisposable
	{
		[Token(Token = "0x40046A4")]
		[FieldOffset(Offset = "0x8")]
		internal int _003Ci_003E__0;

		[Token(Token = "0x40046A5")]
		[FieldOffset(Offset = "0xC")]
		internal int _003Ci_003E__1;

		[Token(Token = "0x40046A6")]
		[FieldOffset(Offset = "0x10")]
		internal int _0024PC;

		[Token(Token = "0x40046A7")]
		[FieldOffset(Offset = "0x14")]
		internal object _0024current;

		[Token(Token = "0x40046A8")]
		[FieldOffset(Offset = "0x18")]
		internal XUIListView _003C_003Ef__this;

		[Token(Token = "0x17000D44")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60063FB")]
			[Address(RVA = "0x109AF04", Offset = "0x109AF04", VA = "0x109AF04", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000D45")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60063FC")]
			[Address(RVA = "0x109AF0C", Offset = "0x109AF0C", VA = "0x109AF0C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60063FA")]
		[Address(RVA = "0x109AB08", Offset = "0x109AB08", VA = "0x109AB08")]
		public _003CAsyncBuild_003Ec__IteratorA1()
		{
		}

		[Token(Token = "0x60063FB")]
		[Address(RVA = "0x109AF04", Offset = "0x109AF04", VA = "0x109AF04", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60063FC")]
		[Address(RVA = "0x109AF0C", Offset = "0x109AF0C", VA = "0x109AF0C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60063FD")]
		[Address(RVA = "0x109AF14", Offset = "0x109AF14", VA = "0x109AF14", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60063FE")]
		[Address(RVA = "0x109B3E8", Offset = "0x109B3E8", VA = "0x109B3E8", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x60063FF")]
		[Address(RVA = "0x109B3F4", Offset = "0x109B3F4", VA = "0x109B3F4", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400468C")]
	[FieldOffset(Offset = "0xC")]
	public Vector2 ListItemOffset;

	[Token(Token = "0x400468D")]
	[FieldOffset(Offset = "0x14")]
	public ArrangementTypes Arrangement;

	[Token(Token = "0x400468E")]
	[FieldOffset(Offset = "0x18")]
	public bool reverse;

	[Token(Token = "0x400468F")]
	[FieldOffset(Offset = "0x1C")]
	protected UIScrollView m_scrollView;

	[Token(Token = "0x4004690")]
	[FieldOffset(Offset = "0x20")]
	protected List<GameObject> m_items;

	[Token(Token = "0x4004691")]
	[FieldOffset(Offset = "0x24")]
	protected Stack<GameObject> m_unusedItems;

	[Token(Token = "0x4004692")]
	[FieldOffset(Offset = "0x28")]
	private GameObject m_prefab;

	[Token(Token = "0x4004693")]
	[FieldOffset(Offset = "0x2C")]
	private Vector3 m_prefabSize;

	[Token(Token = "0x4004694")]
	[FieldOffset(Offset = "0x38")]
	protected float m_updateUnit;

	[Token(Token = "0x4004695")]
	[FieldOffset(Offset = "0x3C")]
	private float m_scrollViewInitPos;

	[Token(Token = "0x4004696")]
	[FieldOffset(Offset = "0x40")]
	protected bool m_enableTowardPosition;

	[Token(Token = "0x4004697")]
	[FieldOffset(Offset = "0x44")]
	private float m_TargetPosition;

	[Token(Token = "0x4004698")]
	[FieldOffset(Offset = "0x48")]
	private bool m_reset;

	[Token(Token = "0x4004699")]
	[FieldOffset(Offset = "0x0")]
	private static readonly string dummyName;

	[Token(Token = "0x400469A")]
	[FieldOffset(Offset = "0x4C")]
	private UIWidget m_dummyWidget;

	[Token(Token = "0x400469B")]
	[FieldOffset(Offset = "0x50")]
	private int m_headIndex;

	[Token(Token = "0x400469C")]
	[FieldOffset(Offset = "0x54")]
	private int m_tailIndex;

	[Token(Token = "0x400469D")]
	[FieldOffset(Offset = "0x58")]
	private int m_infoHeadIndex;

	[Token(Token = "0x400469E")]
	[FieldOffset(Offset = "0x5C")]
	private int m_infoTailIndex;

	[Token(Token = "0x400469F")]
	[FieldOffset(Offset = "0x60")]
	private Vector3 BackupPosition;

	[Token(Token = "0x40046A0")]
	[FieldOffset(Offset = "0x6C")]
	private Vector3 BackupOffset;

	[Token(Token = "0x17000D3E")]
	private float m_reverseFactor
	{
		[Token(Token = "0x60063D2")]
		[Address(RVA = "0x10988D0", Offset = "0x10988D0", VA = "0x10988D0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000D3F")]
	protected abstract string ItemPrefabName
	{
		[Token(Token = "0x60063D3")]
		get;
	}

	[Token(Token = "0x17000D40")]
	protected abstract int BuildItemSettingCount
	{
		[Token(Token = "0x60063D4")]
		get;
	}

	[Token(Token = "0x17000D41")]
	protected abstract int InfoListCount
	{
		[Token(Token = "0x60063D5")]
		get;
	}

	[Token(Token = "0x17000D42")]
	private int BuildItemCount
	{
		[Token(Token = "0x60063D6")]
		[Address(RVA = "0x10988EC", Offset = "0x10988EC", VA = "0x10988EC")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000D43")]
	public UIScrollView ScrollView
	{
		[Token(Token = "0x60063D8")]
		[Address(RVA = "0x1098A3C", Offset = "0x1098A3C", VA = "0x1098A3C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60063D0")]
	[Address(RVA = "0x1097B14", Offset = "0x1097B14", VA = "0x1097B14")]
	protected XUIListView()
	{
	}

	[Token(Token = "0x60063D7")]
	[Address(RVA = "0x10989F8", Offset = "0x10989F8", VA = "0x10989F8")]
	public int GetInfoListCount()
	{
		return default(int);
	}

	[Token(Token = "0x60063D9")]
	[Address(RVA = "0x1098EF4", Offset = "0x1098EF4", VA = "0x1098EF4")]
	private void Awake()
	{
	}

	[Token(Token = "0x60063DA")]
	[Address(RVA = "0x1098F38", Offset = "0x1098F38", VA = "0x1098F38", Slot = "7")]
	public virtual void OnAwake()
	{
	}

	[Token(Token = "0x60063DB")]
	[Address(RVA = "0x1098F3C", Offset = "0x1098F3C", VA = "0x1098F3C")]
	private void Update()
	{
	}

	[Token(Token = "0x60063DC")]
	[Address(RVA = "0x1099244", Offset = "0x1099244", VA = "0x1099244", Slot = "8")]
	public virtual void OnUpdate()
	{
	}

	[Token(Token = "0x60063DD")]
	[Address(RVA = "0x1099248", Offset = "0x1099248", VA = "0x1099248")]
	protected void EnableToward()
	{
	}

	[Token(Token = "0x60063DE")]
	[Address(RVA = "0x1099254", Offset = "0x1099254", VA = "0x1099254")]
	protected void DisableToward()
	{
	}

	[Token(Token = "0x60063DF")]
	[Address(RVA = "0x1098BD0", Offset = "0x1098BD0", VA = "0x1098BD0")]
	private void InitDummy(UIScrollView scrollView)
	{
	}

	[Token(Token = "0x60063E0")]
	[Address(RVA = "0x1099044", Offset = "0x1099044", VA = "0x1099044")]
	public void ResetListPosition()
	{
	}

	[Token(Token = "0x60063E1")]
	[Address(RVA = "0x10992D4", Offset = "0x10992D4", VA = "0x10992D4", Slot = "9")]
	public virtual void SetIndexToTop(int index)
	{
	}

	[Token(Token = "0x60063E2")]
	[Address(RVA = "0x1099318", Offset = "0x1099318", VA = "0x1099318")]
	private float CalcAmount(int index)
	{
		return default(float);
	}

	[Token(Token = "0x60063E3")]
	[Address(RVA = "0x109935C", Offset = "0x109935C", VA = "0x109935C")]
	public void MoveScrollAbsolute(float amount)
	{
	}

	[Token(Token = "0x60063E4")]
	[Address(RVA = "0x10994CC", Offset = "0x10994CC", VA = "0x10994CC")]
	public float GetScrollViewPosDeltaFromInitPos()
	{
		return default(float);
	}

	[Token(Token = "0x60063E5")]
	[Address(RVA = "0x1099080", Offset = "0x1099080", VA = "0x1099080")]
	public void OnScroll()
	{
	}

	[Token(Token = "0x60063E6")]
	[Address(RVA = "0x1099508", Offset = "0x1099508", VA = "0x1099508")]
	private void HeadToTail()
	{
	}

	[Token(Token = "0x60063E7")]
	[Address(RVA = "0x1099654", Offset = "0x1099654", VA = "0x1099654")]
	private void TailToHead()
	{
	}

	[Token(Token = "0x60063E8")]
	[Address(RVA = "0x1099898", Offset = "0x1099898", VA = "0x1099898")]
	private int GetNextIndexOnCircular(int index)
	{
		return default(int);
	}

	[Token(Token = "0x60063E9")]
	[Address(RVA = "0x1099944", Offset = "0x1099944", VA = "0x1099944")]
	private int GetPreviusIndexOnCircular(int index)
	{
		return default(int);
	}

	[Token(Token = "0x60063EA")]
	[Address(RVA = "0x1099260", Offset = "0x1099260", VA = "0x1099260")]
	private float GetScrollViewPosition()
	{
		return default(float);
	}

	[Token(Token = "0x60063EB")]
	[Address(RVA = "0x10999F0", Offset = "0x10999F0", VA = "0x10999F0")]
	public void Backup()
	{
	}

	[Token(Token = "0x60063EC")]
	[Address(RVA = "0x1099BC8", Offset = "0x1099BC8", VA = "0x1099BC8")]
	public void Restore()
	{
	}

	[Token(Token = "0x60063ED")]
	[Address(RVA = "0x1097EA0", Offset = "0x1097EA0", VA = "0x1097EA0", Slot = "10")]
	public virtual void BuildList()
	{
	}

	[Token(Token = "0x60063EE")]
	[Address(RVA = "0x109A830", Offset = "0x109A830", VA = "0x109A830", Slot = "11")]
	public virtual void BuildFixedPositionList()
	{
	}

	[Token(Token = "0x60063EF")]
	[Address(RVA = "0x109AA40", Offset = "0x109AA40", VA = "0x109AA40")]
	public void AsyncBuildList()
	{
	}

	[Token(Token = "0x60063F0")]
	[Address(RVA = "0x109AA64", Offset = "0x109AA64", VA = "0x109AA64")]
	[DebuggerHidden]
	public IEnumerator AsyncBuild()
	{
		return null;
	}

	[Token(Token = "0x60063F1")]
	[Address(RVA = "0x1099D90", Offset = "0x1099D90", VA = "0x1099D90")]
	private void PushToUnused(GameObject go)
	{
	}

	[Token(Token = "0x60063F2")]
	[Address(RVA = "0x109AB10", Offset = "0x109AB10", VA = "0x109AB10")]
	private GameObject PopUnused()
	{
		return null;
	}

	[Token(Token = "0x60063F3")]
	[Address(RVA = "0x1099E8C", Offset = "0x1099E8C", VA = "0x1099E8C")]
	protected GameObject MakeItem(int index)
	{
		return null;
	}

	[Token(Token = "0x60063F4")]
	[Address(RVA = "0x109A5C8", Offset = "0x109A5C8", VA = "0x109A5C8")]
	private void PushData()
	{
	}

	[Token(Token = "0x60063F5")]
	protected abstract void PushDatum(GameObject go, int index);

	[Token(Token = "0x60063F6")]
	[Address(RVA = "0x109AC30", Offset = "0x109AC30", VA = "0x109AC30", Slot = "13")]
	public virtual void SetReset()
	{
	}

	[Token(Token = "0x60063F7")]
	[Address(RVA = "0x109AC3C", Offset = "0x109AC3C", VA = "0x109AC3C", Slot = "14")]
	protected virtual GameObject GetPrefabInfo()
	{
		return null;
	}

	[Token(Token = "0x60063F8")]
	[Address(RVA = "0x10997A0", Offset = "0x10997A0", VA = "0x10997A0")]
	private Vector3 GetPosition(int index)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60063F9")]
	[Address(RVA = "0x109AE6C", Offset = "0x109AE6C", VA = "0x109AE6C")]
	public int GetListCount()
	{
		return default(int);
	}
}
