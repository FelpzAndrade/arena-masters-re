using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C7F")]
public class XWidget_GachaItem : MonoBehaviour
{
	[Token(Token = "0x2000C80")]
	private sealed class _003CBuildEffect_003Ec__AnonStorey181
	{
		[Token(Token = "0x4003F82")]
		[FieldOffset(Offset = "0x8")]
		internal CSContent content;

		[Token(Token = "0x4003F83")]
		[FieldOffset(Offset = "0xC")]
		internal XWidget_GachaItem _003C_003Ef__this;

		[Token(Token = "0x6005A44")]
		[Address(RVA = "0x1437A04", Offset = "0x1437A04", VA = "0x1437A04")]
		public _003CBuildEffect_003Ec__AnonStorey181()
		{
		}

		[Token(Token = "0x6005A45")]
		[Address(RVA = "0x143800C", Offset = "0x143800C", VA = "0x143800C")]
		internal void _003C_003Em__25D()
		{
		}
	}

	[Token(Token = "0x4003F75")]
	[FieldOffset(Offset = "0xC")]
	public UI2DSprite sprShopItemIcon;

	[Token(Token = "0x4003F76")]
	[FieldOffset(Offset = "0x10")]
	private readonly string Path_widgetContent;

	[Token(Token = "0x4003F77")]
	[FieldOffset(Offset = "0x14")]
	public XWidget_ContentIcon _widgetContent;

	[Token(Token = "0x4003F78")]
	[FieldOffset(Offset = "0x18")]
	public string GachaEffectPath;

	[Token(Token = "0x4003F79")]
	[FieldOffset(Offset = "0x1C")]
	public string GachaLoopEffectPath;

	[Token(Token = "0x4003F7A")]
	[FieldOffset(Offset = "0x20")]
	private UIDirector m_direction;

	[Token(Token = "0x4003F7B")]
	[FieldOffset(Offset = "0x24")]
	private UITweener[] m_tweens;

	[Token(Token = "0x4003F7C")]
	[FieldOffset(Offset = "0x28")]
	private TweenScale m_scaleTweens;

	[Token(Token = "0x4003F7D")]
	[FieldOffset(Offset = "0x2C")]
	private XWidget_ContentIcon.Option m_option;

	[Token(Token = "0x4003F7E")]
	[FieldOffset(Offset = "0x30")]
	private XWidget_GachaEffect m_gachaEffect;

	[Token(Token = "0x4003F7F")]
	[FieldOffset(Offset = "0x34")]
	private bool effectShowed;

	[Token(Token = "0x4003F80")]
	[FieldOffset(Offset = "0x38")]
	private XUIGachaItem m_gachaItem;

	[Token(Token = "0x4003F81")]
	[FieldOffset(Offset = "0x3C")]
	private float delayEffect;

	[Token(Token = "0x17000CC1")]
	public XWidget_ContentIcon widgetContent
	{
		[Token(Token = "0x6005A2F")]
		[Address(RVA = "0x1436B80", Offset = "0x1436B80", VA = "0x1436B80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6005A2E")]
	[Address(RVA = "0x1436ABC", Offset = "0x1436ABC", VA = "0x1436ABC")]
	public XWidget_GachaItem()
	{
	}

	[Token(Token = "0x6005A30")]
	[Address(RVA = "0x1436D44", Offset = "0x1436D44", VA = "0x1436D44")]
	private void Awake()
	{
	}

	[Token(Token = "0x6005A31")]
	[Address(RVA = "0x1436D48", Offset = "0x1436D48", VA = "0x1436D48")]
	private void Init()
	{
	}

	[Token(Token = "0x6005A32")]
	[Address(RVA = "0x1437030", Offset = "0x1437030", VA = "0x1437030")]
	public void Show()
	{
	}

	[Token(Token = "0x6005A33")]
	[Address(RVA = "0x1437088", Offset = "0x1437088", VA = "0x1437088")]
	public void BuildGachaEffect()
	{
	}

	[Token(Token = "0x6005A34")]
	[Address(RVA = "0x143729C", Offset = "0x143729C", VA = "0x143729C")]
	public void BuildGachaAnimation(string animationName, float delay)
	{
	}

	[Token(Token = "0x6005A35")]
	[Address(RVA = "0x14373DC", Offset = "0x14373DC", VA = "0x14373DC")]
	public void RepositionGachaEffect(Vector3 position)
	{
	}

	[Token(Token = "0x6005A36")]
	[Address(RVA = "0x14374D8", Offset = "0x14374D8", VA = "0x14374D8")]
	public void OpenCard()
	{
	}

	[Token(Token = "0x6005A37")]
	[Address(RVA = "0x1437520", Offset = "0x1437520", VA = "0x1437520")]
	public void BuildEffect()
	{
	}

	[Token(Token = "0x6005A38")]
	[Address(RVA = "0x1437628", Offset = "0x1437628", VA = "0x1437628")]
	public void HideGacha()
	{
	}

	[Token(Token = "0x6005A39")]
	[Address(RVA = "0x1437700", Offset = "0x1437700", VA = "0x1437700")]
	public void PlayEffectSound()
	{
	}

	[Token(Token = "0x6005A3A")]
	[Address(RVA = "0x14377D4", Offset = "0x14377D4", VA = "0x14377D4")]
	public void BuildEffect(float delay, CSContent content)
	{
	}

	[Token(Token = "0x6005A3B")]
	[Address(RVA = "0x1437A0C", Offset = "0x1437A0C", VA = "0x1437A0C")]
	private void TweenScale()
	{
	}

	[Token(Token = "0x6005A3C")]
	[Address(RVA = "0x1437B14", Offset = "0x1437B14", VA = "0x1437B14")]
	public void HideEffect()
	{
	}

	[Token(Token = "0x6005A3D")]
	[Address(RVA = "0x1437C00", Offset = "0x1437C00", VA = "0x1437C00")]
	public void BuildContent(CSContent content, XWidget_ContentIcon.Option option = XWidget_ContentIcon.Option.None)
	{
	}

	[Token(Token = "0x6005A3E")]
	[Address(RVA = "0x1437DBC", Offset = "0x1437DBC", VA = "0x1437DBC")]
	public void BuildShopItemIcon(string iconPath)
	{
	}

	[Token(Token = "0x6005A3F")]
	[Address(RVA = "0x1437C68", Offset = "0x1437C68", VA = "0x1437C68")]
	public void HideContent()
	{
	}

	[Token(Token = "0x6005A40")]
	[Address(RVA = "0x1437F48", Offset = "0x1437F48", VA = "0x1437F48")]
	public void BuildContentInstant(CSContent content)
	{
	}

	[Token(Token = "0x6005A41")]
	[Address(RVA = "0x14371B8", Offset = "0x14371B8", VA = "0x14371B8")]
	private void Reset()
	{
	}

	[Token(Token = "0x6005A42")]
	[Address(RVA = "0x1437FAC", Offset = "0x1437FAC", VA = "0x1437FAC")]
	public void Hide()
	{
	}

	[Token(Token = "0x6005A43")]
	[Address(RVA = "0x1437FE0", Offset = "0x1437FE0", VA = "0x1437FE0")]
	private void Update()
	{
	}
}
