using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using AssetBundles;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000002")]
public class LoadAssets : MonoBehaviour
{
	[Token(Token = "0x2000003")]
	private sealed class _003CStart_003Ec__Iterator0 : IDisposable
	{
		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x8")]
		internal int _0024PC;

		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x10")]
		internal LoadAssets _003C_003Ef__this;

		[Token(Token = "0x17000001")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x13494C8", Offset = "0x13494C8", VA = "0x13494C8", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000002")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x13494D0", Offset = "0x13494D0", VA = "0x13494D0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x1348854", Offset = "0x1348854", VA = "0x1348854")]
		public _003CStart_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x13494C8", Offset = "0x13494C8", VA = "0x13494C8", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x13494D0", Offset = "0x13494D0", VA = "0x13494D0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x13494D8", Offset = "0x13494D8", VA = "0x13494D8", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x1349598", Offset = "0x1349598", VA = "0x1349598", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x13495A4", Offset = "0x13495A4", VA = "0x13495A4", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2000004")]
	private sealed class _003CInitialize_003Ec__Iterator1 : IDisposable
	{
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x8")]
		internal AssetBundleLoadManifestOperation _003Crequest_003E__0;

		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0xC")]
		internal int _0024PC;

		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x14")]
		internal LoadAssets _003C_003Ef__this;

		[Token(Token = "0x17000003")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600000C")]
			[Address(RVA = "0x13489CC", Offset = "0x13489CC", VA = "0x13489CC", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000004")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600000D")]
			[Address(RVA = "0x13489D4", Offset = "0x13489D4", VA = "0x13489D4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x1348900", Offset = "0x1348900", VA = "0x1348900")]
		public _003CInitialize_003Ec__Iterator1()
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x13489CC", Offset = "0x13489CC", VA = "0x13489CC", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x13489D4", Offset = "0x13489D4", VA = "0x13489D4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x13489DC", Offset = "0x13489DC", VA = "0x13489DC", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x1348BC4", Offset = "0x1348BC4", VA = "0x1348BC4", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x1348BD0", Offset = "0x1348BD0", VA = "0x1348BD0", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2000005")]
	private sealed class _003CInstantiateGameObjectAsync_003Ec__Iterator2 : IDisposable
	{
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x8")]
		internal float _003CstartTime_003E__0;

		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0xC")]
		internal string assetBundleName;

		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x10")]
		internal string assetName;

		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x14")]
		internal AssetBundleLoadAssetOperation _003Crequest_003E__1;

		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x18")]
		internal GameObject _003Cprefab_003E__2;

		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x1C")]
		internal float _003CelapsedTime_003E__3;

		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x20")]
		internal int _0024PC;

		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x24")]
		internal object _0024current;

		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x28")]
		internal string _003C_0024_003EassetBundleName;

		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x2C")]
		internal string _003C_0024_003EassetName;

		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x30")]
		internal LoadAssets _003C_003Ef__this;

		[Token(Token = "0x17000005")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6000012")]
			[Address(RVA = "0x1348C64", Offset = "0x1348C64", VA = "0x1348C64", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000006")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000013")]
			[Address(RVA = "0x1348C6C", Offset = "0x1348C6C", VA = "0x1348C6C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x13489C4", Offset = "0x13489C4", VA = "0x13489C4")]
		public _003CInstantiateGameObjectAsync_003Ec__Iterator2()
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x1348C64", Offset = "0x1348C64", VA = "0x1348C64", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x1348C6C", Offset = "0x1348C6C", VA = "0x1348C6C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x1348C74", Offset = "0x1348C74", VA = "0x1348C74", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x1349428", Offset = "0x1349428", VA = "0x1349428", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x1349434", Offset = "0x1349434", VA = "0x1349434", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4000001")]
	public const string AssetBundlesOutputPath = "/AssetBundles/";

	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0xC")]
	public string assetBundleName;

	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x10")]
	public string assetName;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x13487A8", Offset = "0x13487A8", VA = "0x13487A8")]
	public LoadAssets()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x13487B0", Offset = "0x13487B0", VA = "0x13487B0")]
	[DebuggerHidden]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x134885C", Offset = "0x134885C", VA = "0x134885C")]
	[DebuggerHidden]
	protected IEnumerator Initialize()
	{
		return null;
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x1348908", Offset = "0x1348908", VA = "0x1348908")]
	[DebuggerHidden]
	protected IEnumerator InstantiateGameObjectAsync(string assetBundleName, string assetName)
	{
		return null;
	}
}
