using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F26")]
public class XUIIllustratedBookItem : MonoBehaviour
{
	[Token(Token = "0x400500B")]
	[FieldOffset(Offset = "0xC")]
	private CSItemInfo m_itemInfo;

	[Token(Token = "0x400500C")]
	[FieldOffset(Offset = "0x10")]
	public Transform itemTransform;

	[Token(Token = "0x400500D")]
	[FieldOffset(Offset = "0x14")]
	public UILabel lblItemName;

	[Token(Token = "0x400500E")]
	[FieldOffset(Offset = "0x18")]
	public UILabel lblItemPrice;

	[Token(Token = "0x400500F")]
	[FieldOffset(Offset = "0x1C")]
	private XWidget_ItemIcon m_itemIcon;

	[Token(Token = "0x4005010")]
	[FieldOffset(Offset = "0x20")]
	private UIDragScrollView dragScrollView;

	[Token(Token = "0x60070D6")]
	[Address(RVA = "0x1090620", Offset = "0x1090620", VA = "0x1090620")]
	public XUIIllustratedBookItem()
	{
	}

	[Token(Token = "0x60070D7")]
	[Address(RVA = "0x1090628", Offset = "0x1090628", VA = "0x1090628")]
	private void Awake()
	{
	}

	[Token(Token = "0x60070D8")]
	[Address(RVA = "0x10906B0", Offset = "0x10906B0", VA = "0x10906B0")]
	public void Build(CSItemInfo itemInfo)
	{
	}

	[Token(Token = "0x60070D9")]
	[Address(RVA = "0x1090C10", Offset = "0x1090C10", VA = "0x1090C10")]
	public void BuildEmpty()
	{
	}

	[Token(Token = "0x60070DA")]
	[Address(RVA = "0x1090CA0", Offset = "0x1090CA0", VA = "0x1090CA0")]
	public void OnClick()
	{
	}
}
