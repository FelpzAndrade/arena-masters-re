using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using AssetBundles;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000006")]
public class LoadScenes : MonoBehaviour
{
	[Token(Token = "0x2000007")]
	private sealed class _003CStart_003Ec__Iterator3 : IDisposable
	{
		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x8")]
		internal int _0024PC;

		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x10")]
		internal LoadScenes _003C_003Ef__this;

		[Token(Token = "0x17000007")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600001C")]
			[Address(RVA = "0x134F714", Offset = "0x134F714", VA = "0x134F714", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000008")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600001D")]
			[Address(RVA = "0x134F71C", Offset = "0x134F71C", VA = "0x134F71C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x134EE20", Offset = "0x134EE20", VA = "0x134EE20")]
		public _003CStart_003Ec__Iterator3()
		{
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x134F714", Offset = "0x134F714", VA = "0x134F714", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x134F71C", Offset = "0x134F71C", VA = "0x134F71C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x134F724", Offset = "0x134F724", VA = "0x134F724", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x134F7E4", Offset = "0x134F7E4", VA = "0x134F7E4", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x134F7F0", Offset = "0x134F7F0", VA = "0x134F7F0", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2000008")]
	private sealed class _003CInitialize_003Ec__Iterator4 : IDisposable
	{
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x8")]
		internal AssetBundleLoadManifestOperation _003Crequest_003E__0;

		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0xC")]
		internal int _0024PC;

		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x14")]
		internal LoadScenes _003C_003Ef__this;

		[Token(Token = "0x17000009")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6000022")]
			[Address(RVA = "0x134EF98", Offset = "0x134EF98", VA = "0x134EF98", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700000A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000023")]
			[Address(RVA = "0x134EFA0", Offset = "0x134EFA0", VA = "0x134EFA0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x134EECC", Offset = "0x134EECC", VA = "0x134EECC")]
		public _003CInitialize_003Ec__Iterator4()
		{
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x134EF98", Offset = "0x134EF98", VA = "0x134EF98", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x134EFA0", Offset = "0x134EFA0", VA = "0x134EFA0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x134EFA8", Offset = "0x134EFA8", VA = "0x134EFA8", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x134F190", Offset = "0x134F190", VA = "0x134F190", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x134F19C", Offset = "0x134F19C", VA = "0x134F19C", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2000009")]
	private sealed class _003CInitializeLevelAsync_003Ec__Iterator5 : IDisposable
	{
		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x8")]
		internal float _003CstartTime_003E__0;

		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0xC")]
		internal string levelName;

		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x10")]
		internal bool isAdditive;

		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x14")]
		internal AssetBundleLoadOperation _003Crequest_003E__1;

		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x18")]
		internal float _003CelapsedTime_003E__2;

		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x1C")]
		internal int _0024PC;

		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x20")]
		internal object _0024current;

		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x24")]
		internal string _003C_0024_003ElevelName;

		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x28")]
		internal bool _003C_0024_003EisAdditive;

		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x2C")]
		internal LoadScenes _003C_003Ef__this;

		[Token(Token = "0x1700000B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6000028")]
			[Address(RVA = "0x134F230", Offset = "0x134F230", VA = "0x134F230", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700000C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000029")]
			[Address(RVA = "0x134F238", Offset = "0x134F238", VA = "0x134F238", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x134EF90", Offset = "0x134EF90", VA = "0x134EF90")]
		public _003CInitializeLevelAsync_003Ec__Iterator5()
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x134F230", Offset = "0x134F230", VA = "0x134F230", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x134F238", Offset = "0x134F238", VA = "0x134F238", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x134F240", Offset = "0x134F240", VA = "0x134F240", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x134F674", Offset = "0x134F674", VA = "0x134F674", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x134F680", Offset = "0x134F680", VA = "0x134F680", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0xC")]
	public string sceneAssetBundle;

	[Token(Token = "0x4000017")]
	[FieldOffset(Offset = "0x10")]
	public string sceneName;

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x134ED74", Offset = "0x134ED74", VA = "0x134ED74")]
	public LoadScenes()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x134ED7C", Offset = "0x134ED7C", VA = "0x134ED7C")]
	[DebuggerHidden]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x134EE28", Offset = "0x134EE28", VA = "0x134EE28")]
	[DebuggerHidden]
	protected IEnumerator Initialize()
	{
		return null;
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x134EED4", Offset = "0x134EED4", VA = "0x134EED4")]
	[DebuggerHidden]
	protected IEnumerator InitializeLevelAsync(string levelName, bool isAdditive)
	{
		return null;
	}
}
