using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C97")]
public class XWidget_RewardGachaWithBoxEffect : MonoBehaviour
{
	[Token(Token = "0x4004015")]
	[FieldOffset(Offset = "0xC")]
	public Transform contentParent;

	[Token(Token = "0x4004016")]
	[FieldOffset(Offset = "0x10")]
	public GameObject effectBox;

	[Token(Token = "0x4004017")]
	[FieldOffset(Offset = "0x14")]
	public float effectBoxDuration;

	[Token(Token = "0x4004018")]
	[FieldOffset(Offset = "0x18")]
	public XWidget_RewardItem m_rewardContent;

	[Token(Token = "0x4004019")]
	[FieldOffset(Offset = "0x1C")]
	private XWidget_ContentIcon m_content;

	[Token(Token = "0x400401A")]
	[FieldOffset(Offset = "0x20")]
	public UILabel lblQuantity;

	[Token(Token = "0x400401B")]
	[FieldOffset(Offset = "0x24")]
	public UI2DSprite sprIcon;

	[Token(Token = "0x6005AF4")]
	[Address(RVA = "0x1344A30", Offset = "0x1344A30", VA = "0x1344A30")]
	public XWidget_RewardGachaWithBoxEffect()
	{
	}

	[Token(Token = "0x6005AF5")]
	[Address(RVA = "0x1344A38", Offset = "0x1344A38", VA = "0x1344A38")]
	public void Build(CSContent reward, XWidget_ItemDetailToolTip toolTip, string topLocaleKey, XWidget_ContentIcon.Option option, bool firstClearReward = false, bool isBooster = false, int multiple = 0)
	{
	}

	[Token(Token = "0x6005AF6")]
	[Address(RVA = "0x1344BF0", Offset = "0x1344BF0", VA = "0x1344BF0")]
	public void Build(CSContent reward, XWidget_ContentIcon.Option option)
	{
	}

	[Token(Token = "0x6005AF7")]
	[Address(RVA = "0x1344EC8", Offset = "0x1344EC8", VA = "0x1344EC8")]
	public void Build(CSContent reward, bool bEffect)
	{
	}

	[Token(Token = "0x6005AF8")]
	[Address(RVA = "0x13451B0", Offset = "0x13451B0", VA = "0x13451B0")]
	public void ShowEffect(bool bShow)
	{
	}

	[Token(Token = "0x6005AF9")]
	[Address(RVA = "0x1344BBC", Offset = "0x1344BBC", VA = "0x1344BBC")]
	public void Hide()
	{
	}
}
