using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C5F")]
public class XUIGachaItem : MonoBehaviour
{
	[Token(Token = "0x4003EAA")]
	[FieldOffset(Offset = "0xC")]
	public GameObject m_Camera;

	[Token(Token = "0x4003EAB")]
	[FieldOffset(Offset = "0x10")]
	public Transform m_GachaRoot;

	[Token(Token = "0x4003EAC")]
	[FieldOffset(Offset = "0x14")]
	public GameObject m_GachaModel;

	[Token(Token = "0x4003EAD")]
	[FieldOffset(Offset = "0x18")]
	public GameObject openEffect;

	[Token(Token = "0x4003EAE")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject tiesEffect;

	[Token(Token = "0x600595A")]
	[Address(RVA = "0x1A48144", Offset = "0x1A48144", VA = "0x1A48144")]
	public XUIGachaItem()
	{
	}

	[Token(Token = "0x600595B")]
	[Address(RVA = "0x1A4814C", Offset = "0x1A4814C", VA = "0x1A4814C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600595C")]
	[Address(RVA = "0x1A482FC", Offset = "0x1A482FC", VA = "0x1A482FC")]
	public void Show()
	{
	}

	[Token(Token = "0x600595D")]
	[Address(RVA = "0x1A4835C", Offset = "0x1A4835C", VA = "0x1A4835C")]
	public void AnimationAndPlayEffect(string animationName, float delay)
	{
	}

	[Token(Token = "0x600595E")]
	[Address(RVA = "0x1A484C4", Offset = "0x1A484C4", VA = "0x1A484C4")]
	public void PlayFirstOpenEffect()
	{
	}

	[Token(Token = "0x600595F")]
	[Address(RVA = "0x1A48510", Offset = "0x1A48510", VA = "0x1A48510")]
	private void ShowOpenEffect()
	{
	}

	[Token(Token = "0x6005960")]
	[Address(RVA = "0x1A48604", Offset = "0x1A48604", VA = "0x1A48604")]
	public void RepositionGachaEffect(Vector3 posistion)
	{
	}

	[Token(Token = "0x6005961")]
	[Address(RVA = "0x1A48688", Offset = "0x1A48688", VA = "0x1A48688")]
	public float GachaAnimationTime()
	{
		return default(float);
	}

	[Token(Token = "0x6005962")]
	[Address(RVA = "0x1A487D4", Offset = "0x1A487D4", VA = "0x1A487D4")]
	public void Hide()
	{
	}
}
