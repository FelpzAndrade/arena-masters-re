using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20004BA")]
public class EyeBandage : MonoBehaviour
{
	[Token(Token = "0x4001778")]
	[FieldOffset(Offset = "0xC")]
	public Camera cam;

	[Token(Token = "0x4001779")]
	[FieldOffset(Offset = "0x10")]
	public SpriteRenderer sprite;

	[Token(Token = "0x400177A")]
	[FieldOffset(Offset = "0x14")]
	public MeshVisible.HideFlag hideFlag;

	[Token(Token = "0x400177B")]
	[FieldOffset(Offset = "0x18")]
	public float radiusOffset;

	[Token(Token = "0x400177C")]
	[FieldOffset(Offset = "0x1C")]
	private float m_radius;

	[Token(Token = "0x400177D")]
	[FieldOffset(Offset = "0x20")]
	private float m_radiusFinal;

	[Token(Token = "0x400177E")]
	[FieldOffset(Offset = "0x24")]
	private Transform target;

	[Token(Token = "0x400177F")]
	[FieldOffset(Offset = "0x28")]
	private bool isChase;

	[Token(Token = "0x4001780")]
	[FieldOffset(Offset = "0x2C")]
	private float bandageDuration;

	[Token(Token = "0x4001781")]
	[FieldOffset(Offset = "0x30")]
	private float bandageRemainTime;

	[Token(Token = "0x4001782")]
	[FieldOffset(Offset = "0x34")]
	public float alphaMin;

	[Token(Token = "0x4001783")]
	[FieldOffset(Offset = "0x38")]
	public float alphaMax;

	[Token(Token = "0x4001784")]
	[FieldOffset(Offset = "0x3C")]
	private float m_alpha;

	[Token(Token = "0x4001785")]
	[FieldOffset(Offset = "0x40")]
	private float m_to;

	[Token(Token = "0x4001786")]
	[FieldOffset(Offset = "0x44")]
	public float fadeInDuration;

	[Token(Token = "0x4001787")]
	[FieldOffset(Offset = "0x48")]
	public float fadeOutDuration;

	[Token(Token = "0x4001788")]
	[FieldOffset(Offset = "0x4C")]
	private float m_step;

	[Token(Token = "0x60028A6")]
	[Address(RVA = "0x1E81464", Offset = "0x1E81464", VA = "0x1E81464")]
	public EyeBandage()
	{
	}

	[Token(Token = "0x60028A7")]
	[Address(RVA = "0x1E81498", Offset = "0x1E81498", VA = "0x1E81498")]
	private void Awake()
	{
	}

	[Token(Token = "0x60028A8")]
	[Address(RVA = "0x1E814BC", Offset = "0x1E814BC", VA = "0x1E814BC")]
	public void Init()
	{
	}

	[Token(Token = "0x60028A9")]
	[Address(RVA = "0x1E814E0", Offset = "0x1E814E0", VA = "0x1E814E0")]
	private void InitCamera()
	{
	}

	[Token(Token = "0x60028AA")]
	[Address(RVA = "0x1E81668", Offset = "0x1E81668", VA = "0x1E81668")]
	public void FadeIn(Vector3 position, float radius)
	{
	}

	[Token(Token = "0x60028AB")]
	[Address(RVA = "0x1E817F4", Offset = "0x1E817F4", VA = "0x1E817F4")]
	public void FadeIn(Transform target, float radius)
	{
	}

	[Token(Token = "0x60028AC")]
	[Address(RVA = "0x1E817E8", Offset = "0x1E817E8", VA = "0x1E817E8")]
	public void Stay()
	{
	}

	[Token(Token = "0x60028AD")]
	[Address(RVA = "0x1E81A58", Offset = "0x1E81A58", VA = "0x1E81A58")]
	public void FadeOut()
	{
	}

	[Token(Token = "0x60028AE")]
	[Address(RVA = "0x1E81BA8", Offset = "0x1E81BA8", VA = "0x1E81BA8")]
	private void ForeachObjects(Action<XModuleEntity> action)
	{
	}

	[Token(Token = "0x60028AF")]
	[Address(RVA = "0x1E81C98", Offset = "0x1E81C98", VA = "0x1E81C98")]
	private void UpdateVisibleObject(XModuleEntity me)
	{
	}

	[Token(Token = "0x60028B0")]
	[Address(RVA = "0x1E81D4C", Offset = "0x1E81D4C", VA = "0x1E81D4C")]
	private void VisibleObject(XModuleEntity me, bool visible)
	{
	}

	[Token(Token = "0x60028B1")]
	[Address(RVA = "0x1E81EEC", Offset = "0x1E81EEC", VA = "0x1E81EEC")]
	private void Update()
	{
	}

	[Token(Token = "0x60028B2")]
	[Address(RVA = "0x1E81574", Offset = "0x1E81574", VA = "0x1E81574")]
	public void Disable()
	{
	}

	[Token(Token = "0x60028B3")]
	[Address(RVA = "0x1E821E8", Offset = "0x1E821E8", VA = "0x1E821E8")]
	private void _003CFadeOut_003Em__EE(XModuleEntity go)
	{
	}

	[Token(Token = "0x60028B4")]
	[Address(RVA = "0x1E821F0", Offset = "0x1E821F0", VA = "0x1E821F0")]
	private void _003CDisable_003Em__EF(XModuleEntity go)
	{
	}
}
