using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000202")]
public class UIToggledObjects : MonoBehaviour
{
	[Token(Token = "0x4000869")]
	[FieldOffset(Offset = "0xC")]
	public List<GameObject> activate;

	[Token(Token = "0x400086A")]
	[FieldOffset(Offset = "0x10")]
	public List<GameObject> deactivate;

	[Token(Token = "0x400086B")]
	[FieldOffset(Offset = "0x14")]
	[HideInInspector]
	[SerializeField]
	private GameObject target;

	[Token(Token = "0x400086C")]
	[FieldOffset(Offset = "0x18")]
	[HideInInspector]
	[SerializeField]
	private bool inverse;

	[Token(Token = "0x60010DB")]
	[Address(RVA = "0x17A8364", Offset = "0x17A8364", VA = "0x17A8364")]
	public UIToggledObjects()
	{
	}

	[Token(Token = "0x60010DC")]
	[Address(RVA = "0x17A836C", Offset = "0x17A836C", VA = "0x17A836C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60010DD")]
	[Address(RVA = "0x17A85AC", Offset = "0x17A85AC", VA = "0x17A85AC")]
	public void Toggle()
	{
	}

	[Token(Token = "0x60010DE")]
	[Address(RVA = "0x17A87B4", Offset = "0x17A87B4", VA = "0x17A87B4")]
	private void Set(GameObject go, bool state)
	{
	}
}
