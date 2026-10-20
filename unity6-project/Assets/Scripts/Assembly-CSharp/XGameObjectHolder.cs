using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200061C")]
public class XGameObjectHolder
{
	[Token(Token = "0x4001D3E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private Dictionary<string, GameObject> GOs;

	[Token(Token = "0x4001D3F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private string prefabPath;

	[Token(Token = "0x4001D40")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private Transform defaultParent;

	[Token(Token = "0x4001D41")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private List<GameObject> prefabs;

	[Token(Token = "0x4001D42")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool m_unloadAssetbundleRightAway;

	[Token(Token = "0x170007BD")]
	public Dictionary<string, GameObject> GOS
	{
		[Token(Token = "0x60034A4")]
		[Address(RVA = "0x1424C2C", Offset = "0x1424C2C", VA = "0x1424C2C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60034A2")]
	[Address(RVA = "0x1424ABC", Offset = "0x1424ABC", VA = "0x1424ABC")]
	public XGameObjectHolder()
	{
	}

	[Token(Token = "0x60034A3")]
	[Address(RVA = "0x1424B68", Offset = "0x1424B68", VA = "0x1424B68")]
	public XGameObjectHolder(string path, Transform defaultParent, bool unloadAssetbundleRightAway = false)
	{
	}

	[Token(Token = "0x60034A5")]
	[Address(RVA = "0x1424C34", Offset = "0x1424C34", VA = "0x1424C34")]
	protected GameObject CreateGameObject(GameObject goParent, string prefabName, string Name, bool isVisible = true)
	{
		return null;
	}

	[Token(Token = "0x60034A6")]
	[Address(RVA = "0x1424D00", Offset = "0x1424D00", VA = "0x1424D00", Slot = "4")]
	public virtual void Init()
	{
	}

	[Token(Token = "0x60034A7")]
	[Address(RVA = "0x1424D98", Offset = "0x1424D98", VA = "0x1424D98")]
	public GameObject Find(string key)
	{
		return null;
	}

	[Token(Token = "0x60034A8")]
	public T Find<T>(string prefabName) where T : MonoBehaviour
	{
		return null;
	}

	[Token(Token = "0x60034A9")]
	[Address(RVA = "0x1425354", Offset = "0x1425354", VA = "0x1425354", Slot = "5")]
	public virtual void Clear()
	{
	}

	[Token(Token = "0x60034AA")]
	[Address(RVA = "0x1425664", Offset = "0x1425664", VA = "0x1425664", Slot = "6")]
	public virtual void HideAll()
	{
	}

	[Token(Token = "0x60034AB")]
	public T LoadAndGetComponent<T>(string prefabName, Transform parent) where T : MonoBehaviour
	{
		return null;
	}

	[Token(Token = "0x60034AC")]
	[Address(RVA = "0x1424E84", Offset = "0x1424E84", VA = "0x1424E84")]
	public GameObject Load(string prefabName, Transform parent)
	{
		return null;
	}

	[Token(Token = "0x60034AD")]
	[Address(RVA = "0x1425848", Offset = "0x1425848", VA = "0x1425848")]
	private void InstantiateAll(UnityEngine.Object[] prefabs, GameObject parent, [Optional] Func<UnityEngine.Object, bool> condition)
	{
	}
}
