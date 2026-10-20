using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C99")]
public class XWidget_RewardItem : MonoBehaviour
{
	[Token(Token = "0x4004022")]
	[FieldOffset(Offset = "0xC")]
	public Transform contentParent;

	[Token(Token = "0x4004023")]
	[FieldOffset(Offset = "0x10")]
	public XUISound sound;

	[Token(Token = "0x4004024")]
	[FieldOffset(Offset = "0x14")]
	private XWidget_ItemDetailToolTip m_itemTooltip;

	[Token(Token = "0x4004025")]
	[FieldOffset(Offset = "0x18")]
	public UILabel lblTopText;

	[Token(Token = "0x4004026")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel lblBootser;

	[Token(Token = "0x4004027")]
	[FieldOffset(Offset = "0x20")]
	public UILabel lblMultiple;

	[Token(Token = "0x4004028")]
	[FieldOffset(Offset = "0x24")]
	private XItem m_item;

	[Token(Token = "0x4004029")]
	[FieldOffset(Offset = "0x28")]
	public GameObject effect;

	[Token(Token = "0x400402A")]
	[FieldOffset(Offset = "0x2C")]
	private XWidget_ContentIcon ContentIcon__BackingField;

	[Token(Token = "0x17000CC3")]
	public XWidget_ContentIcon ContentIcon
	{
		[Token(Token = "0x6005AFF")]
		[Address(RVA = "0x1345924", Offset = "0x1345924", VA = "0x1345924")]
		get
		{
			return null;
		}
		[Token(Token = "0x6005B00")]
		[Address(RVA = "0x134592C", Offset = "0x134592C", VA = "0x134592C")]
		private set
		{
		}
	}

	[Token(Token = "0x6005AFE")]
	[Address(RVA = "0x134591C", Offset = "0x134591C", VA = "0x134591C")]
	public XWidget_RewardItem()
	{
	}

	[Token(Token = "0x6005B01")]
	[Address(RVA = "0x1326134", Offset = "0x1326134", VA = "0x1326134")]
	public void Build(CSContent content, XWidget_ItemDetailToolTip itemToolTip, string topLocaleKey, XWidget_ContentIcon.Option option, bool firstClearReward = false, bool isBooster = false, int multiple = 0)
	{
	}

	[Token(Token = "0x6005B02")]
	[Address(RVA = "0x1345934", Offset = "0x1345934", VA = "0x1345934")]
	private void BuildContentIcon(CSContent content, XWidget_ContentIcon.Option option)
	{
	}

	[Token(Token = "0x6005B03")]
	[Address(RVA = "0x1345BDC", Offset = "0x1345BDC", VA = "0x1345BDC")]
	private void BuildXItem(CSContent content)
	{
	}

	[Token(Token = "0x6005B04")]
	[Address(RVA = "0x1345DE4", Offset = "0x1345DE4", VA = "0x1345DE4")]
	private void SetSound(CSContentType contentType)
	{
	}

	[Token(Token = "0x6005B05")]
	[Address(RVA = "0x1345EC8", Offset = "0x1345EC8", VA = "0x1345EC8")]
	public void UnHide()
	{
	}

	[Token(Token = "0x6005B06")]
	[Address(RVA = "0x1345FD4", Offset = "0x1345FD4", VA = "0x1345FD4")]
	public void Hide()
	{
	}

	[Token(Token = "0x6005B07")]
	[Address(RVA = "0x1346008", Offset = "0x1346008", VA = "0x1346008")]
	public void HideDescription()
	{
	}

	[Token(Token = "0x6005B08")]
	[Address(RVA = "0x134625C", Offset = "0x134625C", VA = "0x134625C")]
	public void ShowTooltip(object obj)
	{
	}

	[Token(Token = "0x6005B09")]
	[Address(RVA = "0x1346358", Offset = "0x1346358", VA = "0x1346358")]
	public void HideTooltip()
	{
	}
}
