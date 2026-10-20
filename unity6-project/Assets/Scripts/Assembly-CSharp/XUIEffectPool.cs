using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D95")]
public class XUIEffectPool : MonoBehaviour
{
	[Token(Token = "0x4004684")]
	[FieldOffset(Offset = "0xC")]
	public int EffectPoolQuantity;

	[Token(Token = "0x4004685")]
	[FieldOffset(Offset = "0x10")]
	public int CurPoolIndex;

	[Token(Token = "0x4004686")]
	[FieldOffset(Offset = "0x14")]
	public string EffectPrefabPath;

	[Token(Token = "0x4004687")]
	[FieldOffset(Offset = "0x18")]
	public float Duration;

	[Token(Token = "0x4004688")]
	[FieldOffset(Offset = "0x1C")]
	public int renderQueue;

	[Token(Token = "0x4004689")]
	[FieldOffset(Offset = "0x20")]
	public bool resetTransform;

	[Token(Token = "0x400468A")]
	[FieldOffset(Offset = "0x24")]
	public GameObject EffectParent;

	[Token(Token = "0x400468B")]
	[FieldOffset(Offset = "0x28")]
	private GameObject[] EffectPool;

	[Token(Token = "0x60063C9")]
	[Address(RVA = "0x1A3BFC0", Offset = "0x1A3BFC0", VA = "0x1A3BFC0")]
	public XUIEffectPool()
	{
	}

	[Token(Token = "0x60063CA")]
	[Address(RVA = "0x1A3C05C", Offset = "0x1A3C05C", VA = "0x1A3C05C")]
	public void InitPool()
	{
	}

	[Token(Token = "0x60063CB")]
	[Address(RVA = "0x1A3C5AC", Offset = "0x1A3C5AC", VA = "0x1A3C5AC")]
	public float GetDuration(GameObject go)
	{
		return default(float);
	}

	[Token(Token = "0x60063CC")]
	[Address(RVA = "0x1A3C748", Offset = "0x1A3C748", VA = "0x1A3C748")]
	public GameObject GetEffect()
	{
		return null;
	}

	[Token(Token = "0x60063CD")]
	[Address(RVA = "0x1A3C7DC", Offset = "0x1A3C7DC", VA = "0x1A3C7DC")]
	public GameObject GetEffect(Vector3 worldPosition)
	{
		return null;
	}

	[Token(Token = "0x60063CE")]
	[Address(RVA = "0x1A3C848", Offset = "0x1A3C848", VA = "0x1A3C848")]
	public GameObject GetEffectLocalPosition(Vector3 localPosition)
	{
		return null;
	}

	[Token(Token = "0x60063CF")]
	[Address(RVA = "0x1A3C91C", Offset = "0x1A3C91C", VA = "0x1A3C91C")]
	public void HideAllEffect()
	{
	}
}
