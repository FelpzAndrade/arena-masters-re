using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200040F")]
public class XEffectHide : MonoBehaviour
{
	[Token(Token = "0x2000410")]
	public enum HideState
	{
		[Token(Token = "0x4001420")]
		None = 0,
		[Token(Token = "0x4001421")]
		Ready = 1,
		[Token(Token = "0x4001422")]
		Processing = 2,
		[Token(Token = "0x4001423")]
		Done = 3
	}

	[Token(Token = "0x4001417")]
	[FieldOffset(Offset = "0xC")]
	public float startTime;

	[Token(Token = "0x4001418")]
	[FieldOffset(Offset = "0x10")]
	public float processingTime;

	[Token(Token = "0x4001419")]
	[FieldOffset(Offset = "0x14")]
	private float m_deltaTime;

	[Token(Token = "0x400141A")]
	[FieldOffset(Offset = "0x18")]
	private float m_alpha;

	[Token(Token = "0x400141B")]
	[FieldOffset(Offset = "0x1C")]
	private int _TexAlphaHashKey;

	[Token(Token = "0x400141C")]
	[FieldOffset(Offset = "0x20")]
	private float alphaPerSecond;

	[Token(Token = "0x400141D")]
	[FieldOffset(Offset = "0x24")]
	private HideState m_hideState;

	[Token(Token = "0x400141E")]
	[FieldOffset(Offset = "0x28")]
	public SkinnedMeshRenderer skinnedMeshRenderer;

	[Token(Token = "0x600212A")]
	[Address(RVA = "0x19AD36C", Offset = "0x19AD36C", VA = "0x19AD36C")]
	public XEffectHide()
	{
	}

	[Token(Token = "0x600212B")]
	[Address(RVA = "0x19AD37C", Offset = "0x19AD37C", VA = "0x19AD37C")]
	private void Reset()
	{
	}

	[Token(Token = "0x600212C")]
	[Address(RVA = "0x19AD570", Offset = "0x19AD570", VA = "0x19AD570")]
	private void ChangeState(HideState state)
	{
	}

	[Token(Token = "0x600212D")]
	[Address(RVA = "0x19AD580", Offset = "0x19AD580", VA = "0x19AD580")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600212E")]
	[Address(RVA = "0x19AD584", Offset = "0x19AD584", VA = "0x19AD584")]
	private void Update()
	{
	}
}
