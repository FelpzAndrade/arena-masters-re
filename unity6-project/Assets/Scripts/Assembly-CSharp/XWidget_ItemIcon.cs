using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C87")]
public class XWidget_ItemIcon : MonoBehaviour
{
	[Token(Token = "0x4003FC9")]
	[FieldOffset(Offset = "0xC")]
	public UIBasicSprite sprGrade;

	[Token(Token = "0x4003FCA")]
	[FieldOffset(Offset = "0x10")]
	public UI2DSprite sprIcon;

	[Token(Token = "0x4003FCB")]
	[FieldOffset(Offset = "0x14")]
	public UI2DSprite sprSoul;

	[Token(Token = "0x4003FCC")]
	[FieldOffset(Offset = "0x18")]
	public GameObject goSetRoot;

	[Token(Token = "0x4003FCD")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject goMagicRoot;

	[Token(Token = "0x4003FCE")]
	[FieldOffset(Offset = "0x20")]
	public GameObject goCoolTime;

	[Token(Token = "0x4003FCF")]
	[FieldOffset(Offset = "0x24")]
	public UILabel lblQuantity;

	[Token(Token = "0x4003FD0")]
	[FieldOffset(Offset = "0x28")]
	public UILabel lblLevel;

	[Token(Token = "0x4003FD1")]
	[FieldOffset(Offset = "0x2C")]
	public int QuantityActiveMinCount;

	[Token(Token = "0x6005A8F")]
	[Address(RVA = "0x1456180", Offset = "0x1456180", VA = "0x1456180")]
	public XWidget_ItemIcon()
	{
	}

	[Token(Token = "0x6005A90")]
	[Address(RVA = "0x1456190", Offset = "0x1456190", VA = "0x1456190")]
	private void Deactive()
	{
	}

	[Token(Token = "0x6005A91")]
	[Address(RVA = "0x1451688", Offset = "0x1451688", VA = "0x1451688")]
	public void Build(XItem item, bool ShowGrade = true, bool ShowQuantity = true, bool ifExitUseBgTransparentIcon = false)
	{
	}

	[Token(Token = "0x6005A92")]
	[Address(RVA = "0x14562D4", Offset = "0x14562D4", VA = "0x14562D4")]
	public void ShowCoolTimIcon(bool showIcon)
	{
	}

	[Token(Token = "0x6005A93")]
	[Address(RVA = "0x14563B4", Offset = "0x14563B4", VA = "0x14563B4")]
	public void BuildFusionMaterialIcon(XItem item)
	{
	}

	[Token(Token = "0x6005A94")]
	[Address(RVA = "0x14455A0", Offset = "0x14455A0", VA = "0x14455A0")]
	public void ChangeQuantity(string quantity)
	{
	}
}
