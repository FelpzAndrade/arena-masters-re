using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200102D")]
public class XUIPandoraBoxItem : MonoBehaviour
{
	[Token(Token = "0x40056E2")]
	[FieldOffset(Offset = "0xC")]
	public UILabel lblOrder;

	[Token(Token = "0x40056E3")]
	[FieldOffset(Offset = "0x10")]
	public UILabel lblRewardName;

	[Token(Token = "0x40056E4")]
	[FieldOffset(Offset = "0x14")]
	public UILabel lblRewardDesc;

	[Token(Token = "0x40056E5")]
	[FieldOffset(Offset = "0x18")]
	public GameObject goRecieved;

	[Token(Token = "0x40056E6")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject goSprSelect;

	[Token(Token = "0x60078A9")]
	[Address(RVA = "0x190CCB4", Offset = "0x190CCB4", VA = "0x190CCB4")]
	public XUIPandoraBoxItem()
	{
	}

	[Token(Token = "0x60078AA")]
	[Address(RVA = "0x190CCBC", Offset = "0x190CCBC", VA = "0x190CCBC")]
	public void Build(int order, string name, string desc, bool isRecieved, bool isSelect)
	{
	}

	[Token(Token = "0x60078AB")]
	[Address(RVA = "0x190CD44", Offset = "0x190CD44", VA = "0x190CD44")]
	private void SetSelect(bool bSelect)
	{
	}

	[Token(Token = "0x60078AC")]
	[Address(RVA = "0x190CE24", Offset = "0x190CE24", VA = "0x190CE24")]
	private void SetRecieved(bool isRecieved)
	{
	}
}
