using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C7A")]
public class XWidget_GachaCardBox : MonoBehaviour
{
	[Token(Token = "0x4003F49")]
	[FieldOffset(Offset = "0xC")]
	public XWidget_ContentIcon widgetContent;

	[Token(Token = "0x4003F4A")]
	[FieldOffset(Offset = "0x10")]
	public string GachaEffectPath;

	[Token(Token = "0x4003F4B")]
	[FieldOffset(Offset = "0x14")]
	public string GachaLoopEffectPath;

	[Token(Token = "0x4003F4C")]
	[FieldOffset(Offset = "0x18")]
	private XUIGachaItem m_gachaItem;

	[Token(Token = "0x4003F4D")]
	[FieldOffset(Offset = "0x1C")]
	private UIDirector m_direction;

	[Token(Token = "0x4003F4E")]
	[FieldOffset(Offset = "0x20")]
	private XWidget_GachaEffect m_gachaEffect;

	[Token(Token = "0x4003F4F")]
	[FieldOffset(Offset = "0x24")]
	private float delayEffect;

	[Token(Token = "0x60059F9")]
	[Address(RVA = "0x1432F94", Offset = "0x1432F94", VA = "0x1432F94")]
	public XWidget_GachaCardBox()
	{
	}

	[Token(Token = "0x60059FA")]
	[Address(RVA = "0x143303C", Offset = "0x143303C", VA = "0x143303C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60059FB")]
	[Address(RVA = "0x1433080", Offset = "0x1433080", VA = "0x1433080")]
	private void SetGachaEffect()
	{
	}

	[Token(Token = "0x60059FC")]
	[Address(RVA = "0x1433040", Offset = "0x1433040", VA = "0x1433040")]
	private void Init()
	{
	}

	[Token(Token = "0x60059FD")]
	[Address(RVA = "0x14333D4", Offset = "0x14333D4", VA = "0x14333D4")]
	public void Show()
	{
	}

	[Token(Token = "0x60059FE")]
	[Address(RVA = "0x1433524", Offset = "0x1433524", VA = "0x1433524")]
	private XUIGachaItem GetAndShowGachaItem(bool isShow)
	{
		return null;
	}

	[Token(Token = "0x60059FF")]
	[Address(RVA = "0x1433698", Offset = "0x1433698", VA = "0x1433698")]
	public void ShowAndPlayEffectSound(Vector3 position)
	{
	}

	[Token(Token = "0x6005A00")]
	[Address(RVA = "0x14338BC", Offset = "0x14338BC", VA = "0x14338BC")]
	public void BuildGachaAnimation(string animationName, float delay)
	{
	}

	[Token(Token = "0x6005A01")]
	[Address(RVA = "0x14339BC", Offset = "0x14339BC", VA = "0x14339BC")]
	public void PlayFirstOpenEffect()
	{
	}

	[Token(Token = "0x6005A02")]
	[Address(RVA = "0x14337C0", Offset = "0x14337C0", VA = "0x14337C0")]
	public void RepositionGachaEffect(Vector3 position)
	{
	}

	[Token(Token = "0x6005A03")]
	[Address(RVA = "0x14339E8", Offset = "0x14339E8", VA = "0x14339E8")]
	public void HideGacha()
	{
	}

	[Token(Token = "0x6005A04")]
	[Address(RVA = "0x14336EC", Offset = "0x14336EC", VA = "0x14336EC")]
	public void PlayEffectSound()
	{
	}

	[Token(Token = "0x6005A05")]
	[Address(RVA = "0x1433414", Offset = "0x1433414", VA = "0x1433414")]
	private void Reset()
	{
	}

	[Token(Token = "0x6005A06")]
	[Address(RVA = "0x1433B4C", Offset = "0x1433B4C", VA = "0x1433B4C")]
	public void Hide()
	{
	}

	[Token(Token = "0x6005A07")]
	[Address(RVA = "0x1433B80", Offset = "0x1433B80", VA = "0x1433B80")]
	private void Update()
	{
	}
}
