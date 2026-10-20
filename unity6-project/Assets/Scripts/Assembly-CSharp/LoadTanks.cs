using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using AssetBundles;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200000A")]
public class LoadTanks : MonoBehaviour
{
	[Token(Token = "0x200000B")]
	private sealed class _003CBeginExample_003Ec__Iterator6 : IDisposable
	{
		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x8")]
		internal int _0024PC;

		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x10")]
		internal LoadTanks _003C_003Ef__this;

		[Token(Token = "0x1700000D")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6000035")]
			[Address(RVA = "0x1350A64", Offset = "0x1350A64", VA = "0x1350A64", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700000E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000036")]
			[Address(RVA = "0x1350A6C", Offset = "0x1350A6C", VA = "0x1350A6C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x1350828", Offset = "0x1350828", VA = "0x1350828")]
		public _003CBeginExample_003Ec__Iterator6()
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x1350A64", Offset = "0x1350A64", VA = "0x1350A64", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x1350A6C", Offset = "0x1350A6C", VA = "0x1350A6C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x1350A74", Offset = "0x1350A74", VA = "0x1350A74", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x1350CE4", Offset = "0x1350CE4", VA = "0x1350CE4", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x1350CF0", Offset = "0x1350CF0", VA = "0x1350CF0", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x200000C")]
	private sealed class _003CInitialize_003Ec__Iterator7 : IDisposable
	{
		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x8")]
		internal AssetBundleLoadManifestOperation _003Crequest_003E__0;

		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0xC")]
		internal int _0024PC;

		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x14")]
		internal LoadTanks _003C_003Ef__this;

		[Token(Token = "0x1700000F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600003B")]
			[Address(RVA = "0x1350D84", Offset = "0x1350D84", VA = "0x1350D84", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000010")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600003C")]
			[Address(RVA = "0x1350D8C", Offset = "0x1350D8C", VA = "0x1350D8C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x13508D4", Offset = "0x13508D4", VA = "0x13508D4")]
		public _003CInitialize_003Ec__Iterator7()
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x1350D84", Offset = "0x1350D84", VA = "0x1350D84", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x1350D8C", Offset = "0x1350D8C", VA = "0x1350D8C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x1350D94", Offset = "0x1350D94", VA = "0x1350D94", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x1350F7C", Offset = "0x1350F7C", VA = "0x1350F7C", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x1350F88", Offset = "0x1350F88", VA = "0x1350F88", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x200000D")]
	private sealed class _003CInitializeLevelAsync_003Ec__Iterator8 : IDisposable
	{
		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x8")]
		internal float _003CstartTime_003E__0;

		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0xC")]
		internal string levelName;

		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x10")]
		internal bool isAdditive;

		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x14")]
		internal AssetBundleLoadOperation _003Crequest_003E__1;

		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x18")]
		internal float _003CelapsedTime_003E__2;

		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x1C")]
		internal int _0024PC;

		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x20")]
		internal object _0024current;

		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x24")]
		internal string _003C_0024_003ElevelName;

		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0x28")]
		internal bool _003C_0024_003EisAdditive;

		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x2C")]
		internal LoadTanks _003C_003Ef__this;

		[Token(Token = "0x17000011")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6000041")]
			[Address(RVA = "0x135101C", Offset = "0x135101C", VA = "0x135101C", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000012")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000042")]
			[Address(RVA = "0x1351024", Offset = "0x1351024", VA = "0x1351024", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x1350998", Offset = "0x1350998", VA = "0x1350998")]
		public _003CInitializeLevelAsync_003Ec__Iterator8()
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x135101C", Offset = "0x135101C", VA = "0x135101C", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x1351024", Offset = "0x1351024", VA = "0x1351024", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x135102C", Offset = "0x135102C", VA = "0x135102C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x1351460", Offset = "0x1351460", VA = "0x1351460", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x135146C", Offset = "0x135146C", VA = "0x135146C", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x200000E")]
	private sealed class _003CInstantiateGameObjectAsync_003Ec__Iterator9 : IDisposable
	{
		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x8")]
		internal float _003CstartTime_003E__0;

		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0xC")]
		internal string assetBundleName;

		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0x10")]
		internal string assetName;

		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0x14")]
		internal AssetBundleLoadAssetOperation _003Crequest_003E__1;

		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0x18")]
		internal GameObject _003Cprefab_003E__2;

		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x1C")]
		internal float _003CelapsedTime_003E__3;

		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x20")]
		internal int _0024PC;

		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x24")]
		internal object _0024current;

		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x28")]
		internal string _003C_0024_003EassetBundleName;

		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x2C")]
		internal string _003C_0024_003EassetName;

		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x30")]
		internal LoadTanks _003C_003Ef__this;

		[Token(Token = "0x17000013")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6000047")]
			[Address(RVA = "0x1351500", Offset = "0x1351500", VA = "0x1351500", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000014")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000048")]
			[Address(RVA = "0x1351508", Offset = "0x1351508", VA = "0x1351508", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x1350A5C", Offset = "0x1350A5C", VA = "0x1350A5C")]
		public _003CInstantiateGameObjectAsync_003Ec__Iterator9()
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x1351500", Offset = "0x1351500", VA = "0x1351500", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x1351508", Offset = "0x1351508", VA = "0x1351508", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x1351510", Offset = "0x1351510", VA = "0x1351510", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x1351D9C", Offset = "0x1351D9C", VA = "0x1351D9C", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x1351DA8", Offset = "0x1351DA8", VA = "0x1351DA8", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4000029")]
	[FieldOffset(Offset = "0xC")]
	public string sceneAssetBundle;

	[Token(Token = "0x400002A")]
	[FieldOffset(Offset = "0x10")]
	public string sceneName;

	[Token(Token = "0x400002B")]
	[FieldOffset(Offset = "0x14")]
	public string textAssetBundle;

	[Token(Token = "0x400002C")]
	[FieldOffset(Offset = "0x18")]
	public string textAssetName;

	[Token(Token = "0x400002D")]
	[FieldOffset(Offset = "0x1C")]
	private string[] activeVariants;

	[Token(Token = "0x400002E")]
	[FieldOffset(Offset = "0x20")]
	private bool bundlesLoaded;

	[Token(Token = "0x400002F")]
	[FieldOffset(Offset = "0x21")]
	private bool sd;

	[Token(Token = "0x4000030")]
	[FieldOffset(Offset = "0x22")]
	private bool hd;

	[Token(Token = "0x4000031")]
	[FieldOffset(Offset = "0x23")]
	private bool normal;

	[Token(Token = "0x4000032")]
	[FieldOffset(Offset = "0x24")]
	private bool desert;

	[Token(Token = "0x4000033")]
	[FieldOffset(Offset = "0x25")]
	private bool english;

	[Token(Token = "0x4000034")]
	[FieldOffset(Offset = "0x26")]
	private bool danish;

	[Token(Token = "0x4000035")]
	[FieldOffset(Offset = "0x28")]
	private string tankAlbedoStyle;

	[Token(Token = "0x4000036")]
	[FieldOffset(Offset = "0x2C")]
	private string tankAlbedoResolution;

	[Token(Token = "0x4000037")]
	[FieldOffset(Offset = "0x30")]
	private string language;

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x134FC44", Offset = "0x134FC44", VA = "0x134FC44")]
	public LoadTanks()
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x134FC4C", Offset = "0x134FC4C", VA = "0x134FC4C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x134FCE8", Offset = "0x134FCE8", VA = "0x134FCE8")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x1350784", Offset = "0x1350784", VA = "0x1350784")]
	[DebuggerHidden]
	private IEnumerator BeginExample()
	{
		return null;
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x1350830", Offset = "0x1350830", VA = "0x1350830")]
	[DebuggerHidden]
	protected IEnumerator Initialize()
	{
		return null;
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x13508DC", Offset = "0x13508DC", VA = "0x13508DC")]
	[DebuggerHidden]
	protected IEnumerator InitializeLevelAsync(string levelName, bool isAdditive)
	{
		return null;
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x13509A0", Offset = "0x13509A0", VA = "0x13509A0")]
	[DebuggerHidden]
	protected IEnumerator InstantiateGameObjectAsync(string assetBundleName, string assetName)
	{
		return null;
	}
}
