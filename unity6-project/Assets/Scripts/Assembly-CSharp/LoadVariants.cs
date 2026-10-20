using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using AssetBundles;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200000F")]
public class LoadVariants : MonoBehaviour
{
	[Token(Token = "0x2000010")]
	private sealed class _003CBeginExample_003Ec__IteratorA : IDisposable
	{
		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x8")]
		internal int _0024PC;

		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x10")]
		internal LoadVariants _003C_003Ef__this;

		[Token(Token = "0x17000015")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6000053")]
			[Address(RVA = "0x135245C", Offset = "0x135245C", VA = "0x135245C", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000016")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000054")]
			[Address(RVA = "0x1352464", Offset = "0x1352464", VA = "0x1352464", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x13522E4", Offset = "0x13522E4", VA = "0x13522E4")]
		public _003CBeginExample_003Ec__IteratorA()
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x135245C", Offset = "0x135245C", VA = "0x135245C", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x1352464", Offset = "0x1352464", VA = "0x1352464", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x135246C", Offset = "0x135246C", VA = "0x135246C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x13525EC", Offset = "0x13525EC", VA = "0x13525EC", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x13525F8", Offset = "0x13525F8", VA = "0x13525F8", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2000011")]
	private sealed class _003CInitialize_003Ec__IteratorB : IDisposable
	{
		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0x8")]
		internal AssetBundleLoadManifestOperation _003Crequest_003E__0;

		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0xC")]
		internal int _0024PC;

		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x14")]
		internal LoadVariants _003C_003Ef__this;

		[Token(Token = "0x17000017")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6000059")]
			[Address(RVA = "0x135268C", Offset = "0x135268C", VA = "0x135268C", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000018")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600005A")]
			[Address(RVA = "0x1352694", Offset = "0x1352694", VA = "0x1352694", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x1352390", Offset = "0x1352390", VA = "0x1352390")]
		public _003CInitialize_003Ec__IteratorB()
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x135268C", Offset = "0x135268C", VA = "0x135268C", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x1352694", Offset = "0x1352694", VA = "0x1352694", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x135269C", Offset = "0x135269C", VA = "0x135269C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x1352884", Offset = "0x1352884", VA = "0x1352884", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x1352890", Offset = "0x1352890", VA = "0x1352890", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2000012")]
	private sealed class _003CInitializeLevelAsync_003Ec__IteratorC : IDisposable
	{
		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x8")]
		internal float _003CstartTime_003E__0;

		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0xC")]
		internal string levelName;

		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x10")]
		internal bool isAdditive;

		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x14")]
		internal AssetBundleLoadOperation _003Crequest_003E__1;

		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x18")]
		internal float _003CelapsedTime_003E__2;

		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x1C")]
		internal int _0024PC;

		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0x20")]
		internal object _0024current;

		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0x24")]
		internal string _003C_0024_003ElevelName;

		[Token(Token = "0x4000067")]
		[FieldOffset(Offset = "0x28")]
		internal bool _003C_0024_003EisAdditive;

		[Token(Token = "0x4000068")]
		[FieldOffset(Offset = "0x2C")]
		internal LoadVariants _003C_003Ef__this;

		[Token(Token = "0x17000019")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600005F")]
			[Address(RVA = "0x1352924", Offset = "0x1352924", VA = "0x1352924", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700001A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000060")]
			[Address(RVA = "0x135292C", Offset = "0x135292C", VA = "0x135292C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x1352454", Offset = "0x1352454", VA = "0x1352454")]
		public _003CInitializeLevelAsync_003Ec__IteratorC()
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x1352924", Offset = "0x1352924", VA = "0x1352924", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x135292C", Offset = "0x135292C", VA = "0x135292C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x1352934", Offset = "0x1352934", VA = "0x1352934", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x1352D70", Offset = "0x1352D70", VA = "0x1352D70", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x1352D7C", Offset = "0x1352D7C", VA = "0x1352D7C", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4000054")]
	private const string variantSceneAssetBundle = "variants/variant-scene";

	[Token(Token = "0x4000055")]
	private const string variantSceneName = "VariantScene";

	[Token(Token = "0x4000056")]
	[FieldOffset(Offset = "0xC")]
	private string[] activeVariants;

	[Token(Token = "0x4000057")]
	[FieldOffset(Offset = "0x10")]
	private bool bundlesLoaded;

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x1351E3C", Offset = "0x1351E3C", VA = "0x1351E3C")]
	public LoadVariants()
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x1351E44", Offset = "0x1351E44", VA = "0x1351E44")]
	private void Awake()
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x1351EE0", Offset = "0x1351EE0", VA = "0x1351EE0")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x1352240", Offset = "0x1352240", VA = "0x1352240")]
	[DebuggerHidden]
	private IEnumerator BeginExample()
	{
		return null;
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x13522EC", Offset = "0x13522EC", VA = "0x13522EC")]
	[DebuggerHidden]
	protected IEnumerator Initialize()
	{
		return null;
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x1352398", Offset = "0x1352398", VA = "0x1352398")]
	[DebuggerHidden]
	protected IEnumerator InitializeLevelAsync(string levelName, bool isAdditive)
	{
		return null;
	}
}
