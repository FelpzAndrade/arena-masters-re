using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000EF3")]
public class XUIPackageShopView : MonoBehaviour
{
	[Token(Token = "0x4004F39")]
	[FieldOffset(Offset = "0xC")]
	public GameObject goDrag;

	[Token(Token = "0x4004F3A")]
	[FieldOffset(Offset = "0x10")]
	public int posX_space;

	[Token(Token = "0x4004F3B")]
	[FieldOffset(Offset = "0x14")]
	public UIPanel clippedView;

	[Token(Token = "0x4004F3C")]
	[FieldOffset(Offset = "0x18")]
	public UIScrollView scrollView;

	[Token(Token = "0x4004F3D")]
	[FieldOffset(Offset = "0x1C")]
	public Transform pool;

	[Token(Token = "0x4004F3E")]
	[FieldOffset(Offset = "0x20")]
	public GameObject golblNoProduct;

	[Token(Token = "0x4004F3F")]
	[FieldOffset(Offset = "0x24")]
	private Dictionary<PackagePrefabType, List<XUIPackageShopItemBase>> used;

	[Token(Token = "0x4004F40")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<PackagePrefabType, List<XUIPackageShopItemBase>> unused;

	[Token(Token = "0x4004F41")]
	[FieldOffset(Offset = "0x2C")]
	private List<string> pathList;

	[Token(Token = "0x4004F42")]
	[FieldOffset(Offset = "0x30")]
	private List<GameObject> m_cloneSrcList;

	[Token(Token = "0x4004F43")]
	[FieldOffset(Offset = "0x34")]
	private float m_addPosX;

	[Token(Token = "0x4004F44")]
	[FieldOffset(Offset = "0x38")]
	private List<PackageShopInfo> m_info;

	[Token(Token = "0x4004F45")]
	[FieldOffset(Offset = "0x3C")]
	private Action<PackageShopInfo> m_onClickBuyAction;

	[Token(Token = "0x4004F46")]
	[FieldOffset(Offset = "0x40")]
	private Action<string, int> m_onShowDetailAction;

	[Token(Token = "0x4004F47")]
	[FieldOffset(Offset = "0x44")]
	private Action m_onRefresh;

	[Token(Token = "0x6006FBB")]
	[Address(RVA = "0x190BA14", Offset = "0x190BA14", VA = "0x190BA14")]
	public XUIPackageShopView()
	{
	}

	[Token(Token = "0x6006FBC")]
	[Address(RVA = "0x190BC18", Offset = "0x190BC18", VA = "0x190BC18")]
	public void Build(List<PackageShopInfo> infos, Action<PackageShopInfo> clickAction, Action<string, int> onClickDetail, Action onRefresh)
	{
	}

	[Token(Token = "0x6006FBD")]
	[Address(RVA = "0x190C4F0", Offset = "0x190C4F0", VA = "0x190C4F0")]
	private void Build()
	{
	}

	[Token(Token = "0x6006FBE")]
	[Address(RVA = "0x190C0E4", Offset = "0x190C0E4", VA = "0x190C0E4")]
	public void Clear()
	{
	}

	[Token(Token = "0x6006FBF")]
	[Address(RVA = "0x190C618", Offset = "0x190C618", VA = "0x190C618")]
	private void BuildAndSetPos(PackagePrefabType type, PackageShopInfo info)
	{
	}

	[Token(Token = "0x6006FC0")]
	[Address(RVA = "0x190C6E4", Offset = "0x190C6E4", VA = "0x190C6E4")]
	private XUIPackageShopItemBase GetClone(PackagePrefabType type)
	{
		return null;
	}

	[Token(Token = "0x6006FC1")]
	[Address(RVA = "0x190BE80", Offset = "0x190BE80", VA = "0x190BE80")]
	private void CreatePrefabs()
	{
	}

	[Token(Token = "0x6006FC2")]
	[Address(RVA = "0x190C9C8", Offset = "0x190C9C8", VA = "0x190C9C8")]
	private List<XUIPackageShopItemBase> GetListFromDictionary(PackagePrefabType type, Dictionary<PackagePrefabType, List<XUIPackageShopItemBase>> dic)
	{
		return null;
	}
}
