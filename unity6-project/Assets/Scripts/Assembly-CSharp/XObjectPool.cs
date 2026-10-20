using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000638")]
public class XObjectPool
{
	[Token(Token = "0x2000639")]
	private interface IObjectCache
	{
		[Token(Token = "0x600358D")]
		void Cache(string goName, GameObject newObj);

		[Token(Token = "0x600358E")]
		bool Has(string goName);

		[Token(Token = "0x600358F")]
		GameObject Get(string goName);

		[Token(Token = "0x6003590")]
		void Remove(string goName);

		[Token(Token = "0x6003591")]
		void Clear();
	}

	[Token(Token = "0x200063A")]
	private class ObjectCache : IObjectCache
	{
		[Token(Token = "0x4001E09")]
		[FieldOffset(Offset = "0x8")]
		private Transform parent;

		[Token(Token = "0x4001E0A")]
		[FieldOffset(Offset = "0xC")]
		private Dictionary<string, GameObject> cache;

		[Token(Token = "0x6003592")]
		[Address(RVA = "0x168B63C", Offset = "0x168B63C", VA = "0x168B63C")]
		public ObjectCache(Transform parent)
		{
		}

		[Token(Token = "0x6003593")]
		[Address(RVA = "0x168CE64", Offset = "0x168CE64", VA = "0x168CE64", Slot = "4")]
		public void Cache(string goName, GameObject newObj)
		{
		}

		[Token(Token = "0x6003594")]
		[Address(RVA = "0x168D0CC", Offset = "0x168D0CC", VA = "0x168D0CC", Slot = "8")]
		public void Clear()
		{
		}

		[Token(Token = "0x6003595")]
		[Address(RVA = "0x168D2E8", Offset = "0x168D2E8", VA = "0x168D2E8", Slot = "6")]
		public GameObject Get(string goName)
		{
			return null;
		}

		[Token(Token = "0x6003596")]
		[Address(RVA = "0x168D02C", Offset = "0x168D02C", VA = "0x168D02C", Slot = "5")]
		public bool Has(string goName)
		{
			return default(bool);
		}

		[Token(Token = "0x6003597")]
		[Address(RVA = "0x168D514", Offset = "0x168D514", VA = "0x168D514", Slot = "7")]
		public void Remove(string goName)
		{
		}
	}

	[Token(Token = "0x200063B")]
	private sealed class _003COnSetActiveEndOfFrame_003Ec__Iterator7F : IDisposable
	{
		[Token(Token = "0x4001E0B")]
		[FieldOffset(Offset = "0x8")]
		internal GameObject target;

		[Token(Token = "0x4001E0C")]
		[FieldOffset(Offset = "0xC")]
		internal bool value;

		[Token(Token = "0x4001E0D")]
		[FieldOffset(Offset = "0x10")]
		internal int _0024PC;

		[Token(Token = "0x4001E0E")]
		[FieldOffset(Offset = "0x14")]
		internal object _0024current;

		[Token(Token = "0x4001E0F")]
		[FieldOffset(Offset = "0x18")]
		internal GameObject _003C_0024_003Etarget;

		[Token(Token = "0x4001E10")]
		[FieldOffset(Offset = "0x1C")]
		internal bool _003C_0024_003Evalue;

		[Token(Token = "0x4001E11")]
		[FieldOffset(Offset = "0x20")]
		internal XObjectPool _003C_003Ef__this;

		[Token(Token = "0x170007CA")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6003599")]
			[Address(RVA = "0x168CC38", Offset = "0x168CC38", VA = "0x168CC38", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170007CB")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600359A")]
			[Address(RVA = "0x168CC40", Offset = "0x168CC40", VA = "0x168CC40", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003598")]
		[Address(RVA = "0x168CC30", Offset = "0x168CC30", VA = "0x168CC30")]
		public _003COnSetActiveEndOfFrame_003Ec__Iterator7F()
		{
		}

		[Token(Token = "0x6003599")]
		[Address(RVA = "0x168CC38", Offset = "0x168CC38", VA = "0x168CC38", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600359A")]
		[Address(RVA = "0x168CC40", Offset = "0x168CC40", VA = "0x168CC40", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600359B")]
		[Address(RVA = "0x168CC48", Offset = "0x168CC48", VA = "0x168CC48", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600359C")]
		[Address(RVA = "0x168CDC4", Offset = "0x168CDC4", VA = "0x168CDC4", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x600359D")]
		[Address(RVA = "0x168CDD0", Offset = "0x168CDD0", VA = "0x168CDD0", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4001E05")]
	[FieldOffset(Offset = "0x8")]
	private GameObject parentGameObject;

	[Token(Token = "0x4001E06")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<string, Stack<GameObject>> objectLookup;

	[Token(Token = "0x4001E07")]
	[FieldOffset(Offset = "0x10")]
	private Action<GameObject> initAction;

	[Token(Token = "0x4001E08")]
	[FieldOffset(Offset = "0x14")]
	private IObjectCache objectCache;

	[Token(Token = "0x170007C9")]
	public Dictionary<string, Stack<GameObject>> ObjectLookup
	{
		[Token(Token = "0x600357F")]
		[Address(RVA = "0x168B6F0", Offset = "0x168B6F0", VA = "0x168B6F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600357E")]
	[Address(RVA = "0x168B2F8", Offset = "0x168B2F8", VA = "0x168B2F8")]
	public XObjectPool(GameObject goPoolParent, Action<GameObject> initAction)
	{
	}

	[Token(Token = "0x6003580")]
	[Address(RVA = "0x168B6F8", Offset = "0x168B6F8", VA = "0x168B6F8")]
	private GameObject CreateGameObject(string goName)
	{
		return null;
	}

	[Token(Token = "0x6003581")]
	[Address(RVA = "0x168B9D0", Offset = "0x168B9D0", VA = "0x168B9D0")]
	public bool Peek(string goName)
	{
		return default(bool);
	}

	[Token(Token = "0x6003582")]
	[Address(RVA = "0x168BAFC", Offset = "0x168BAFC", VA = "0x168BAFC")]
	public GameObject Spawn(string goName, Vector3 position, Quaternion rotation)
	{
		return null;
	}

	[Token(Token = "0x6003583")]
	[Address(RVA = "0x168C194", Offset = "0x168C194", VA = "0x168C194")]
	public bool Destroy(GameObject target)
	{
		return default(bool);
	}

	[Token(Token = "0x6003584")]
	[Address(RVA = "0x168C198", Offset = "0x168C198", VA = "0x168C198")]
	private bool Push(GameObject target)
	{
		return default(bool);
	}

	[Token(Token = "0x6003585")]
	[Address(RVA = "0x168BFA8", Offset = "0x168BFA8", VA = "0x168BFA8")]
	private void ResetTransform(GameObject target)
	{
	}

	[Token(Token = "0x6003586")]
	[Address(RVA = "0x168C440", Offset = "0x168C440", VA = "0x168C440")]
	public void Reserve(string strName, int nCount)
	{
	}

	[Token(Token = "0x6003587")]
	[Address(RVA = "0x168C67C", Offset = "0x168C67C", VA = "0x168C67C")]
	public void ReserveAdd(string strName, int nCount)
	{
	}

	[Token(Token = "0x6003588")]
	[Address(RVA = "0x168C55C", Offset = "0x168C55C", VA = "0x168C55C")]
	private int GetCount(string goName)
	{
		return default(int);
	}

	[Token(Token = "0x6003589")]
	[Address(RVA = "0x168C788", Offset = "0x168C788", VA = "0x168C788")]
	public void Clear()
	{
	}

	[Token(Token = "0x600358A")]
	[Address(RVA = "0x168C164", Offset = "0x168C164", VA = "0x168C164")]
	protected void SetActive(GameObject target, bool value)
	{
	}

	[Token(Token = "0x600358B")]
	[Address(RVA = "0x168CB18", Offset = "0x168CB18", VA = "0x168CB18")]
	private void SetActiveOnEndOfFrame(GameObject target, bool value)
	{
	}

	[Token(Token = "0x600358C")]
	[Address(RVA = "0x168CB74", Offset = "0x168CB74", VA = "0x168CB74")]
	[DebuggerHidden]
	private IEnumerator OnSetActiveEndOfFrame(GameObject target, bool value)
	{
		return null;
	}
}
