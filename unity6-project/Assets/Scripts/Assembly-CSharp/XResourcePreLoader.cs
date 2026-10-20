using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000679")]
public class XResourcePreLoader
{
	[Token(Token = "0x200067A")]
	private sealed class _003CLoadListCoroutine_003Ec__Iterator80 : IDisposable
	{
		[Token(Token = "0x4001F12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal Dictionary<XPoolType, IncreasableDictionary<string>>.Enumerator _003Cenumerator_003E__0;

		[Token(Token = "0x4001F13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		internal KeyValuePair<XPoolType, IncreasableDictionary<string>> _003Clist_003E__1;

		[Token(Token = "0x4001F14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		internal XPoolType _003Ctype_003E__2;

		[Token(Token = "0x4001F15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal Dictionary<string, int>.Enumerator _003Cenumerator2_003E__3;

		[Token(Token = "0x4001F16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		internal KeyValuePair<string, int> _003Cinfo_003E__4;

		[Token(Token = "0x4001F17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		internal int _0024PC;

		[Token(Token = "0x4001F18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal object _0024current;

		[Token(Token = "0x4001F19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		internal XResourcePreLoader _003C_003Ef__this;

		[Token(Token = "0x170007E5")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60036A3")]
			[Address(RVA = "0x1CA439C", Offset = "0x1CA439C", VA = "0x1CA439C", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170007E6")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60036A4")]
			[Address(RVA = "0x1CA43A4", Offset = "0x1CA43A4", VA = "0x1CA43A4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60036A2")]
		[Address(RVA = "0x1CA2228", Offset = "0x1CA2228", VA = "0x1CA2228")]
		public _003CLoadListCoroutine_003Ec__Iterator80()
		{
		}

		[Token(Token = "0x60036A3")]
		[Address(RVA = "0x1CA439C", Offset = "0x1CA439C", VA = "0x1CA439C", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60036A4")]
		[Address(RVA = "0x1CA43A4", Offset = "0x1CA43A4", VA = "0x1CA43A4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60036A5")]
		[Address(RVA = "0x1CA43AC", Offset = "0x1CA43AC", VA = "0x1CA43AC", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60036A6")]
		[Address(RVA = "0x1CA4714", Offset = "0x1CA4714", VA = "0x1CA4714", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x60036A7")]
		[Address(RVA = "0x1CA4720", Offset = "0x1CA4720", VA = "0x1CA4720", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x200067B")]
	private sealed class _003CLoadCoroutine_003Ec__Iterator81 : IDisposable
	{
		[Token(Token = "0x4001F1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal GameModeInstanceInfo gameModeInstanceInfo;

		[Token(Token = "0x4001F1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal XGameModeType _003CgameModeType_003E__0;

		[Token(Token = "0x4001F1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal List<XModuleActor.CreationDesc> characterList;

		[Token(Token = "0x4001F1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal int _003Ci_003E__1;

		[Token(Token = "0x4001F1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal XModuleActor.CreationDesc _003CcharDesc_003E__2;

		[Token(Token = "0x4001F1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		internal CSSectorInfo sectorInfo;

		[Token(Token = "0x4001F20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal int _0024PC;

		[Token(Token = "0x4001F21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		internal object _0024current;

		[Token(Token = "0x4001F22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal GameModeInstanceInfo _003C_0024_003EgameModeInstanceInfo;

		[Token(Token = "0x4001F23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		internal List<XModuleActor.CreationDesc> _003C_0024_003EcharacterList;

		[Token(Token = "0x4001F24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal CSSectorInfo _003C_0024_003EsectorInfo;

		[Token(Token = "0x4001F25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		internal XResourcePreLoader _003C_003Ef__this;

		[Token(Token = "0x170007E7")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60036A9")]
			[Address(RVA = "0x1CA3F60", Offset = "0x1CA3F60", VA = "0x1CA3F60", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170007E8")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60036AA")]
			[Address(RVA = "0x1CA3F68", Offset = "0x1CA3F68", VA = "0x1CA3F68", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60036A8")]
		[Address(RVA = "0x1CA22F8", Offset = "0x1CA22F8", VA = "0x1CA22F8")]
		public _003CLoadCoroutine_003Ec__Iterator81()
		{
		}

		[Token(Token = "0x60036A9")]
		[Address(RVA = "0x1CA3F60", Offset = "0x1CA3F60", VA = "0x1CA3F60", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60036AA")]
		[Address(RVA = "0x1CA3F68", Offset = "0x1CA3F68", VA = "0x1CA3F68", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60036AB")]
		[Address(RVA = "0x1CA3F70", Offset = "0x1CA3F70", VA = "0x1CA3F70", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60036AC")]
		[Address(RVA = "0x1CA41B4", Offset = "0x1CA41B4", VA = "0x1CA41B4", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x60036AD")]
		[Address(RVA = "0x1CA41C0", Offset = "0x1CA41C0", VA = "0x1CA41C0", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x200067C")]
	private sealed class _003CLoadCoroutine_003Ec__Iterator82 : IDisposable
	{
		[Token(Token = "0x4001F26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal Dictionary<int, int> levelObjects;

		[Token(Token = "0x4001F27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal int _0024PC;

		[Token(Token = "0x4001F28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x4001F29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal Dictionary<int, int> _003C_0024_003ElevelObjects;

		[Token(Token = "0x4001F2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal XResourcePreLoader _003C_003Ef__this;

		[Token(Token = "0x170007E9")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60036AF")]
			[Address(RVA = "0x1CA4254", Offset = "0x1CA4254", VA = "0x1CA4254", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170007EA")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60036B0")]
			[Address(RVA = "0x1CA425C", Offset = "0x1CA425C", VA = "0x1CA425C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60036AE")]
		[Address(RVA = "0x1CA23B0", Offset = "0x1CA23B0", VA = "0x1CA23B0")]
		public _003CLoadCoroutine_003Ec__Iterator82()
		{
		}

		[Token(Token = "0x60036AF")]
		[Address(RVA = "0x1CA4254", Offset = "0x1CA4254", VA = "0x1CA4254", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60036B0")]
		[Address(RVA = "0x1CA425C", Offset = "0x1CA425C", VA = "0x1CA425C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60036B1")]
		[Address(RVA = "0x1CA4264", Offset = "0x1CA4264", VA = "0x1CA4264", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60036B2")]
		[Address(RVA = "0x1CA42FC", Offset = "0x1CA42FC", VA = "0x1CA42FC", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x60036B3")]
		[Address(RVA = "0x1CA4308", Offset = "0x1CA4308", VA = "0x1CA4308", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4001F10")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private readonly int PRELOAD_COUNT_MAXIMUM;

	[Token(Token = "0x4001F11")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private Dictionary<XPoolType, IncreasableDictionary<string>> m_list;

	[Token(Token = "0x600368E")]
	[Address(RVA = "0x1CA20D0", Offset = "0x1CA20D0", VA = "0x1CA20D0")]
	public XResourcePreLoader()
	{
	}

	[Token(Token = "0x600368F")]
	[Address(RVA = "0x1CA2184", Offset = "0x1CA2184", VA = "0x1CA2184")]
	[DebuggerHidden]
	private IEnumerator LoadListCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6003690")]
	[Address(RVA = "0x1CA2230", Offset = "0x1CA2230", VA = "0x1CA2230")]
	[DebuggerHidden]
	public IEnumerator LoadCoroutine(GameModeInstanceInfo gameModeInstanceInfo, CSSectorInfo sectorInfo, [Optional] List<XModuleActor.CreationDesc> characterList)
	{
		return null;
	}

	[Token(Token = "0x6003691")]
	[Address(RVA = "0x1CA2300", Offset = "0x1CA2300", VA = "0x1CA2300")]
	[DebuggerHidden]
	public IEnumerator LoadCoroutine(Dictionary<int, int> levelObjects)
	{
		return null;
	}

	[Token(Token = "0x6003692")]
	[Address(RVA = "0x1CA23B8", Offset = "0x1CA23B8", VA = "0x1CA23B8")]
	private void AddLevelObjectsToList(Dictionary<int, int> monsters)
	{
	}

	[Token(Token = "0x6003693")]
	[Address(RVA = "0x1CA264C", Offset = "0x1CA264C", VA = "0x1CA264C")]
	private void AddCharacterShadowToList()
	{
	}

	[Token(Token = "0x6003694")]
	[Address(RVA = "0x1CA2740", Offset = "0x1CA2740", VA = "0x1CA2740")]
	private void AddDefaultCharactersToList(XGameModeType gameModeType)
	{
	}

	[Token(Token = "0x6003695")]
	[Address(RVA = "0x1CA29E8", Offset = "0x1CA29E8", VA = "0x1CA29E8")]
	private void AddGameModeUISoundUIList(XGameModeType gameModeType)
	{
	}

	[Token(Token = "0x6003696")]
	[Address(RVA = "0x1CA2C50", Offset = "0x1CA2C50", VA = "0x1CA2C50")]
	private void AddModeCharactersToList(GameModeInstanceInfo info)
	{
	}

	[Token(Token = "0x6003697")]
	[Address(RVA = "0x1CA2D9C", Offset = "0x1CA2D9C", VA = "0x1CA2D9C")]
	private void AddDefaultEffectsToList()
	{
	}

	[Token(Token = "0x6003698")]
	[Address(RVA = "0x1CA3130", Offset = "0x1CA3130", VA = "0x1CA3130")]
	private void AddGameModeEffectsToList(XGameModeType gameModeType)
	{
	}

	[Token(Token = "0x6003699")]
	[Address(RVA = "0x1CA2EA8", Offset = "0x1CA2EA8", VA = "0x1CA2EA8")]
	private void AddResourceAsyncLoad(string resPath)
	{
	}

	[Token(Token = "0x600369A")]
	[Address(RVA = "0x1CA2F84", Offset = "0x1CA2F84", VA = "0x1CA2F84")]
	private void PushObjectPool(XPoolType type, string strResName)
	{
	}

	[Token(Token = "0x600369B")]
	[Address(RVA = "0x1CA32A8", Offset = "0x1CA32A8", VA = "0x1CA32A8")]
	private void LoadDefaultSprites()
	{
	}

	[Token(Token = "0x600369C")]
	[Address(RVA = "0x1CA34BC", Offset = "0x1CA34BC", VA = "0x1CA34BC")]
	public void LoadCharacterSprites(XModuleActor.CreationDesc desc)
	{
	}

	[Token(Token = "0x600369D")]
	[Address(RVA = "0x1CA3810", Offset = "0x1CA3810", VA = "0x1CA3810")]
	private void PreloadCharacterSprites(CSCharacterInfo characterInfo)
	{
	}

	[Token(Token = "0x600369E")]
	[Address(RVA = "0x1CA3978", Offset = "0x1CA3978", VA = "0x1CA3978")]
	private void LoadSkillSprites(CSCharacterInfo characterInfo)
	{
	}

	[Token(Token = "0x600369F")]
	[Address(RVA = "0x1CA3A18", Offset = "0x1CA3A18", VA = "0x1CA3A18")]
	private void LoadSkillSprite(CSSkillInfo skillInfo)
	{
	}

	[Token(Token = "0x60036A0")]
	[Address(RVA = "0x1CA3854", Offset = "0x1CA3854", VA = "0x1CA3854")]
	private void loadSprite(string resName)
	{
	}

	[Token(Token = "0x60036A1")]
	[Address(RVA = "0x1CA3A28", Offset = "0x1CA3A28", VA = "0x1CA3A28")]
	private void LoadSectorResourcesToList(CSSectorInfo sectorInfo)
	{
	}
}
