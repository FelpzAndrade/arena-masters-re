using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F59")]
public class XUISkinList : XUIListView
{
	[Token(Token = "0x2000F5A")]
	private sealed class _003CBuild_003Ec__AnonStorey231
	{
		[Token(Token = "0x40050A7")]
		[FieldOffset(Offset = "0x8")]
		internal List<int> periodSkinIDs;

		[Token(Token = "0x40050A8")]
		[FieldOffset(Offset = "0xC")]
		internal List<SkinInfo> unlockableList;

		[Token(Token = "0x40050A9")]
		[FieldOffset(Offset = "0x10")]
		internal XUISkinList _003C_003Ef__this;

		[Token(Token = "0x6007216")]
		[Address(RVA = "0x192D0B0", Offset = "0x192D0B0", VA = "0x192D0B0")]
		public _003CBuild_003Ec__AnonStorey231()
		{
		}

		[Token(Token = "0x6007217")]
		[Address(RVA = "0x192DB14", Offset = "0x192DB14", VA = "0x192DB14")]
		internal bool _003C_003Em__48F(SkinInfo x)
		{
			return default(bool);
		}

		[Token(Token = "0x6007218")]
		[Address(RVA = "0x192DBF4", Offset = "0x192DBF4", VA = "0x192DBF4")]
		internal bool _003C_003Em__490(SkinInfo x)
		{
			return default(bool);
		}

		[Token(Token = "0x6007219")]
		[Address(RVA = "0x192DCC8", Offset = "0x192DCC8", VA = "0x192DCC8")]
		internal bool _003C_003Em__491(SkinInfo x)
		{
			return default(bool);
		}

		[Token(Token = "0x600721A")]
		[Address(RVA = "0x192DDA8", Offset = "0x192DDA8", VA = "0x192DDA8")]
		internal bool _003C_003Em__492(SkinInfo x)
		{
			return default(bool);
		}

		[Token(Token = "0x600721B")]
		[Address(RVA = "0x192DE4C", Offset = "0x192DE4C", VA = "0x192DE4C")]
		internal bool _003C_003Em__494(SkinInfo x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000F5B")]
	private sealed class _003CPushDatum_003Ec__AnonStorey232
	{
		[Token(Token = "0x40050AA")]
		[FieldOffset(Offset = "0x8")]
		internal SkinInfo skinInfo;

		[Token(Token = "0x600721C")]
		[Address(RVA = "0x192D49C", Offset = "0x192D49C", VA = "0x192D49C")]
		public _003CPushDatum_003Ec__AnonStorey232()
		{
		}

		[Token(Token = "0x600721D")]
		[Address(RVA = "0x192DEEC", Offset = "0x192DEEC", VA = "0x192DEEC")]
		internal bool _003C_003Em__495(ExpireNode item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400509C")]
	[FieldOffset(Offset = "0x78")]
	private List<SkinInfo> m_list;

	[Token(Token = "0x400509D")]
	[FieldOffset(Offset = "0x7C")]
	private Action<GameObject, int> itemSelectAction;

	[Token(Token = "0x400509E")]
	[FieldOffset(Offset = "0x80")]
	private Action<SkinInfo> itemSkinInfo;

	[Token(Token = "0x400509F")]
	[FieldOffset(Offset = "0x84")]
	private Action<int> m_acExpirePeriodSkin;

	[Token(Token = "0x40050A0")]
	[FieldOffset(Offset = "0x88")]
	private string m_selectedCharUid;

	[Token(Token = "0x40050A1")]
	[FieldOffset(Offset = "0x8C")]
	private int m_selectedSkinID;

	[Token(Token = "0x40050A2")]
	[FieldOffset(Offset = "0x90")]
	private List<int> m_unlockList;

	[Token(Token = "0x40050A3")]
	[FieldOffset(Offset = "0x94")]
	private List<ExpireNode> m_periodSkinList;

	[Token(Token = "0x40050A4")]
	[FieldOffset(Offset = "0x98")]
	public XModuleActor m_SelectedActor;

	[Token(Token = "0x40050A5")]
	[FieldOffset(Offset = "0x0")]
	private static Func<ExpireNode, int> _003C_003Ef__am_0024cache9;

	[Token(Token = "0x40050A6")]
	[FieldOffset(Offset = "0x4")]
	private static Predicate<SkinInfo> _003C_003Ef__am_0024cacheA;

	[Token(Token = "0x17000E8F")]
	protected override string ItemPrefabName
	{
		[Token(Token = "0x6007203")]
		[Address(RVA = "0x192C754", Offset = "0x192C754", VA = "0x192C754", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E90")]
	protected override int BuildItemSettingCount
	{
		[Token(Token = "0x6007204")]
		[Address(RVA = "0x192C7CC", Offset = "0x192C7CC", VA = "0x192C7CC", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000E91")]
	protected override int InfoListCount
	{
		[Token(Token = "0x6007205")]
		[Address(RVA = "0x192C7D4", Offset = "0x192C7D4", VA = "0x192C7D4", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6007201")]
	[Address(RVA = "0x192C6A8", Offset = "0x192C6A8", VA = "0x192C6A8")]
	public XUISkinList()
	{
	}

	[Token(Token = "0x6007202")]
	[Address(RVA = "0x192C74C", Offset = "0x192C74C", VA = "0x192C74C")]
	public void RefreshSelectSkinID(int skinID)
	{
	}

	[Token(Token = "0x6007206")]
	[Address(RVA = "0x192C86C", Offset = "0x192C86C", VA = "0x192C86C")]
	public void Init(XModuleActor selectedActor, string selCharUid, Action<GameObject, int> selAction, Action<SkinInfo> selInfo, int selectSkinID, List<int> unlockList, List<ExpireNode> periodSkinList, Action<int> onExpireFunc)
	{
	}

	[Token(Token = "0x6007207")]
	[Address(RVA = "0x192C8B0", Offset = "0x192C8B0", VA = "0x192C8B0")]
	public void Build()
	{
	}

	[Token(Token = "0x6007208")]
	[Address(RVA = "0x192D25C", Offset = "0x192D25C", VA = "0x192D25C", Slot = "12")]
	protected override void PushDatum(GameObject go, int index)
	{
	}

	[Token(Token = "0x6007209")]
	[Address(RVA = "0x192D4C0", Offset = "0x192D4C0", VA = "0x192D4C0")]
	public void RefreshEquipped(int skinID)
	{
	}

	[Token(Token = "0x600720A")]
	[Address(RVA = "0x192D5F0", Offset = "0x192D5F0", VA = "0x192D5F0")]
	public void RefreshSelectSkin(int skinID)
	{
	}

	[Token(Token = "0x600720B")]
	[Address(RVA = "0x192D4B4", Offset = "0x192D4B4", VA = "0x192D4B4")]
	private bool FindUnlockSkin(List<int> unlockList, int skinID)
	{
		return default(bool);
	}

	[Token(Token = "0x600720C")]
	[Address(RVA = "0x192D710", Offset = "0x192D710", VA = "0x192D710")]
	private bool IsHavePeriodSkin(List<int> liPeriodSkin, int skinID)
	{
		return default(bool);
	}

	[Token(Token = "0x600720D")]
	[Address(RVA = "0x192D7B0", Offset = "0x192D7B0", VA = "0x192D7B0")]
	public void RefreshSkinState(List<int> unlockList, int selectedSkinID)
	{
	}

	[Token(Token = "0x600720E")]
	[Address(RVA = "0x192C8A8", Offset = "0x192C8A8", VA = "0x192C8A8")]
	public void SetSelectActor(XModuleActor selectActor)
	{
	}

	[Token(Token = "0x600720F")]
	[Address(RVA = "0x192D0B8", Offset = "0x192D0B8", VA = "0x192D0B8")]
	private List<SkinInfo> GetSkinList()
	{
		return null;
	}

	[Token(Token = "0x6007210")]
	[Address(RVA = "0x192D7BC", Offset = "0x192D7BC", VA = "0x192D7BC")]
	private int SkinSort(SkinInfo x, SkinInfo y)
	{
		return default(int);
	}

	[Token(Token = "0x6007211")]
	[Address(RVA = "0x192D4A4", Offset = "0x192D4A4", VA = "0x192D4A4")]
	private bool IsCharacterNotOwned()
	{
		return default(bool);
	}

	[Token(Token = "0x6007212")]
	[Address(RVA = "0x192D8D8", Offset = "0x192D8D8", VA = "0x192D8D8")]
	public XModuleActor GetSelectCharacterModuleActor(string selectedCharUid)
	{
		return null;
	}

	[Token(Token = "0x6007213")]
	[Address(RVA = "0x192D9B4", Offset = "0x192D9B4", VA = "0x192D9B4")]
	private static int _003CBuild_003Em__48E(ExpireNode item)
	{
		return default(int);
	}

	[Token(Token = "0x6007214")]
	[Address(RVA = "0x192D9E0", Offset = "0x192D9E0", VA = "0x192D9E0")]
	private static bool _003CBuild_003Em__493(SkinInfo x)
	{
		return default(bool);
	}

	[Token(Token = "0x6007215")]
	[Address(RVA = "0x192DABC", Offset = "0x192DABC", VA = "0x192DABC")]
	private bool _003CGetSkinList_003Em__496(SkinInfo x)
	{
		return default(bool);
	}
}
