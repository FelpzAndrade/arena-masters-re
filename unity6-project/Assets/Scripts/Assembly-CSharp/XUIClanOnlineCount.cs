using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E84")]
public class XUIClanOnlineCount : MonoBehaviour
{
	[Token(Token = "0x4004C0D")]
	[FieldOffset(Offset = "0xC")]
	public UILabel lblMemNum;

	[Token(Token = "0x6006C38")]
	[Address(RVA = "0x1A386A4", Offset = "0x1A386A4", VA = "0x1A386A4")]
	public XUIClanOnlineCount()
	{
	}

	[Token(Token = "0x6006C39")]
	[Address(RVA = "0x1A386AC", Offset = "0x1A386AC", VA = "0x1A386AC")]
	public void SetActive(bool isEnable)
	{
	}

	[Token(Token = "0x6006C3A")]
	[Address(RVA = "0x1A386E4", Offset = "0x1A386E4", VA = "0x1A386E4")]
	public void Refresh()
	{
	}

	[Token(Token = "0x6006C3B")]
	[Address(RVA = "0x1A38940", Offset = "0x1A38940", VA = "0x1A38940")]
	private int GetClanMember()
	{
		return default(int);
	}

	[Token(Token = "0x6006C3C")]
	[Address(RVA = "0x1A38874", Offset = "0x1A38874", VA = "0x1A38874")]
	private int GetConnectMember()
	{
		return default(int);
	}
}
