using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C8B")]
public class XWidget_NewBadge : MonoBehaviour
{
	[Token(Token = "0x4003FDC")]
	[FieldOffset(Offset = "0xC")]
	public XNewBadgeEnum NewBadgeEnum;

	[Token(Token = "0x4003FDD")]
	[FieldOffset(Offset = "0x10")]
	public GameObject Badge;

	[Token(Token = "0x6005AA1")]
	[Address(RVA = "0x1301298", Offset = "0x1301298", VA = "0x1301298")]
	public XWidget_NewBadge()
	{
	}

	[Token(Token = "0x6005AA2")]
	[Address(RVA = "0x13012A0", Offset = "0x13012A0", VA = "0x13012A0")]
	public void ShowBadge(bool val)
	{
	}

	[Token(Token = "0x6005AA3")]
	[Address(RVA = "0x13013EC", Offset = "0x13013EC", VA = "0x13013EC")]
	public bool Refresh()
	{
		return default(bool);
	}

	[Token(Token = "0x6005AA4")]
	[Address(RVA = "0x1301524", Offset = "0x1301524", VA = "0x1301524")]
	public void Touch()
	{
	}
}
