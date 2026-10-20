using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C7D")]
public class XWidget_GachaCardItem : MonoBehaviour
{
	[Token(Token = "0x4003F68")]
	[FieldOffset(Offset = "0xC")]
	public XWidget_GachaCardContentIcon widgetContent;

	[Token(Token = "0x4003F69")]
	[FieldOffset(Offset = "0x10")]
	public string GachaEffectPath;

	[Token(Token = "0x4003F6A")]
	[FieldOffset(Offset = "0x14")]
	public UILabel lblItemCount;

	[Token(Token = "0x4003F6B")]
	[FieldOffset(Offset = "0x18")]
	public TweenTransform cardBackTweenTransform;

	[Token(Token = "0x4003F6C")]
	[FieldOffset(Offset = "0x1C")]
	private UIDirector m_direction;

	[Token(Token = "0x4003F6D")]
	[FieldOffset(Offset = "0x20")]
	private XWidget_GachaCardContentIcon.Option m_option;

	[Token(Token = "0x4003F6E")]
	[FieldOffset(Offset = "0x24")]
	private bool effectShowed;

	[Token(Token = "0x4003F6F")]
	[FieldOffset(Offset = "0x28")]
	private XUIGachaItem m_gachaItem;

	[Token(Token = "0x4003F70")]
	[FieldOffset(Offset = "0x2C")]
	private CSContent m_content;

	[Token(Token = "0x4003F71")]
	[FieldOffset(Offset = "0x30")]
	private CSItemInfo m_itemInfo;

	[Token(Token = "0x6005A18")]
	[Address(RVA = "0x14360DC", Offset = "0x14360DC", VA = "0x14360DC")]
	public XWidget_GachaCardItem()
	{
	}

	[Token(Token = "0x6005A19")]
	[Address(RVA = "0x1436184", Offset = "0x1436184", VA = "0x1436184")]
	private void Awake()
	{
	}

	[Token(Token = "0x6005A1A")]
	[Address(RVA = "0x14361E8", Offset = "0x14361E8", VA = "0x14361E8")]
	public CSContent GetContent()
	{
		return null;
	}

	[Token(Token = "0x6005A1B")]
	[Address(RVA = "0x1436188", Offset = "0x1436188", VA = "0x1436188")]
	private void Init()
	{
	}

	[Token(Token = "0x6005A1C")]
	[Address(RVA = "0x14361F0", Offset = "0x14361F0", VA = "0x14361F0")]
	public void Show()
	{
	}

	[Token(Token = "0x6005A1D")]
	[Address(RVA = "0x14362B4", Offset = "0x14362B4", VA = "0x14362B4")]
	public void OpenCard()
	{
	}

	[Token(Token = "0x6005A1E")]
	[Address(RVA = "0x14363E0", Offset = "0x14363E0", VA = "0x14363E0")]
	private void CardReplayTween(float duration)
	{
	}

	[Token(Token = "0x6005A1F")]
	[Address(RVA = "0x14364F8", Offset = "0x14364F8", VA = "0x14364F8")]
	public void BuildCard(float duration, float delay, CSContent content)
	{
	}

	[Token(Token = "0x6005A20")]
	[Address(RVA = "0x1436738", Offset = "0x1436738", VA = "0x1436738")]
	public bool IsHaveSkin()
	{
		return default(bool);
	}

	[Token(Token = "0x6005A21")]
	[Address(RVA = "0x1436770", Offset = "0x1436770", VA = "0x1436770")]
	public int GetCurrentItemID()
	{
		return default(int);
	}

	[Token(Token = "0x6005A22")]
	[Address(RVA = "0x143667C", Offset = "0x143667C", VA = "0x143667C")]
	private void PlayCardFlyStartSound(CSItemInfo itemInfo)
	{
	}

	[Token(Token = "0x6005A23")]
	[Address(RVA = "0x1436784", Offset = "0x1436784", VA = "0x1436784")]
	private void PlayCardFlyEndSound(CSItemInfo itemInfo)
	{
	}

	[Token(Token = "0x6005A24")]
	[Address(RVA = "0x1436324", Offset = "0x1436324", VA = "0x1436324")]
	private void PlayCardTurnSound(CSItemInfo itemInfo)
	{
	}

	[Token(Token = "0x6005A25")]
	[Address(RVA = "0x14362D8", Offset = "0x14362D8", VA = "0x14362D8")]
	public void BuildContent(CSContent content, XWidget_GachaCardContentIcon.Option option = XWidget_GachaCardContentIcon.Option.None)
	{
	}

	[Token(Token = "0x6005A26")]
	[Address(RVA = "0x1436840", Offset = "0x1436840", VA = "0x1436840")]
	public void HideContent()
	{
	}

	[Token(Token = "0x6005A27")]
	[Address(RVA = "0x143624C", Offset = "0x143624C", VA = "0x143624C")]
	public void Reset()
	{
	}

	[Token(Token = "0x6005A28")]
	[Address(RVA = "0x1436868", Offset = "0x1436868", VA = "0x1436868")]
	public void ReplayTweens(UITweener[] tweens)
	{
	}

	[Token(Token = "0x6005A29")]
	[Address(RVA = "0x14368F0", Offset = "0x14368F0", VA = "0x14368F0")]
	public void Hide()
	{
	}

	[Token(Token = "0x6005A2A")]
	[Address(RVA = "0x1436924", Offset = "0x1436924", VA = "0x1436924")]
	private void Update()
	{
	}
}
