using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C86")]
public class XWidget_ItemGachaCardIcon : MonoBehaviour
{
	[Token(Token = "0x4003FBD")]
	[FieldOffset(Offset = "0xC")]
	public UI2DSprite sprIcon;

	[Token(Token = "0x4003FBE")]
	[FieldOffset(Offset = "0x10")]
	public UIBasicSprite sprGrade;

	[Token(Token = "0x4003FBF")]
	[FieldOffset(Offset = "0x14")]
	public UILabel lblQuantity;

	[Token(Token = "0x4003FC0")]
	[FieldOffset(Offset = "0x18")]
	public UI2DSprite sprSoulstoneChar;

	[Token(Token = "0x4003FC1")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject goSetRoot;

	[Token(Token = "0x4003FC2")]
	[FieldOffset(Offset = "0x20")]
	public GameObject goMagicRoot;

	[Token(Token = "0x4003FC3")]
	[FieldOffset(Offset = "0x24")]
	public UIBasicSprite sprBg;

	[Token(Token = "0x4003FC4")]
	[FieldOffset(Offset = "0x28")]
	public UIBasicSprite sprNameBg;

	[Token(Token = "0x4003FC5")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject skinIconGameObject;

	[Token(Token = "0x4003FC6")]
	[FieldOffset(Offset = "0x30")]
	public UI2DSprite sprSkin;

	[Token(Token = "0x4003FC7")]
	[FieldOffset(Offset = "0x34")]
	public UILabel lblSkinTitle;

	[Token(Token = "0x4003FC8")]
	[FieldOffset(Offset = "0x38")]
	public UILabel lblSkinName;

	[Token(Token = "0x6005A88")]
	[Address(RVA = "0x1455C98", Offset = "0x1455C98", VA = "0x1455C98")]
	public XWidget_ItemGachaCardIcon()
	{
	}

	[Token(Token = "0x6005A89")]
	[Address(RVA = "0x1434C7C", Offset = "0x1434C7C", VA = "0x1434C7C")]
	public void Deactive()
	{
	}

	[Token(Token = "0x6005A8A")]
	[Address(RVA = "0x1455CA0", Offset = "0x1455CA0", VA = "0x1455CA0")]
	private void DeactiveItemInfo()
	{
	}

	[Token(Token = "0x6005A8B")]
	[Address(RVA = "0x1435044", Offset = "0x1435044", VA = "0x1435044")]
	public void Build(XItem item, bool ShowGrade = true, bool ShowQuantity = true)
	{
	}

	[Token(Token = "0x6005A8C")]
	[Address(RVA = "0x14358E4", Offset = "0x14358E4", VA = "0x14358E4")]
	public void Build(CSContent content, bool ShowGrade = true, bool ShowQuantity = true)
	{
	}

	[Token(Token = "0x6005A8D")]
	[Address(RVA = "0x1455DDC", Offset = "0x1455DDC", VA = "0x1455DDC")]
	public void BuildFusionMaterialIcon(XItem item)
	{
	}

	[Token(Token = "0x6005A8E")]
	[Address(RVA = "0x1456090", Offset = "0x1456090", VA = "0x1456090")]
	public void ChangeQuantity(string quantity)
	{
	}
}
