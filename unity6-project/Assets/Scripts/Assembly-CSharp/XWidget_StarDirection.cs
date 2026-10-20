using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000CA2")]
public class XWidget_StarDirection : MonoBehaviour
{
	[Token(Token = "0x4004052")]
	[FieldOffset(Offset = "0xC")]
	public GameObject addStar;

	[Token(Token = "0x4004053")]
	[FieldOffset(Offset = "0x10")]
	public GameObject star;

	[Token(Token = "0x4004054")]
	[FieldOffset(Offset = "0x0")]
	public static string AddStarSoundKey;

	[Token(Token = "0x4004055")]
	[FieldOffset(Offset = "0x14")]
	public float soundDelay;

	[Token(Token = "0x4004056")]
	[FieldOffset(Offset = "0x18")]
	private UITweener[] m_tweens;

	[Token(Token = "0x4004057")]
	[FieldOffset(Offset = "0x1C")]
	private ParticleSystem[] m_particle;

	[Token(Token = "0x6005B39")]
	[Address(RVA = "0x1B0EE34", Offset = "0x1B0EE34", VA = "0x1B0EE34")]
	public XWidget_StarDirection()
	{
	}

	[Token(Token = "0x6005B3B")]
	[Address(RVA = "0x1B0EED4", Offset = "0x1B0EED4", VA = "0x1B0EED4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6005B3C")]
	[Address(RVA = "0x1B0EFE0", Offset = "0x1B0EFE0", VA = "0x1B0EFE0")]
	public void HideAll()
	{
	}

	[Token(Token = "0x6005B3D")]
	[Address(RVA = "0x1B0F018", Offset = "0x1B0F018", VA = "0x1B0F018")]
	public void HideAdd()
	{
	}

	[Token(Token = "0x6005B3E")]
	[Address(RVA = "0x1B0F064", Offset = "0x1B0F064", VA = "0x1B0F064")]
	public void ShowAddStar()
	{
	}

	[Token(Token = "0x6005B3F")]
	[Address(RVA = "0x1B0F210", Offset = "0x1B0F210", VA = "0x1B0F210")]
	private void PlaySound()
	{
	}

	[Token(Token = "0x6005B40")]
	[Address(RVA = "0x1B0F334", Offset = "0x1B0F334", VA = "0x1B0F334")]
	public void ShowStar()
	{
	}

	[Token(Token = "0x6005B41")]
	[Address(RVA = "0x1B0F11C", Offset = "0x1B0F11C", VA = "0x1B0F11C")]
	private void PlayDirection()
	{
	}

	[Token(Token = "0x6005B42")]
	[Address(RVA = "0x1B0F370", Offset = "0x1B0F370", VA = "0x1B0F370")]
	public void EndDirection()
	{
	}
}
