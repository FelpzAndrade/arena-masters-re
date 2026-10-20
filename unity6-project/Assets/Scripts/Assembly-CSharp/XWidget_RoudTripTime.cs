using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D46")]
public class XWidget_RoudTripTime : MonoBehaviour
{
	[Token(Token = "0x4004451")]
	[FieldOffset(Offset = "0xC")]
	private Color greenColor;

	[Token(Token = "0x4004452")]
	[FieldOffset(Offset = "0x1C")]
	private Color orangeColor;

	[Token(Token = "0x4004453")]
	[FieldOffset(Offset = "0x2C")]
	private Color redColor;

	[Token(Token = "0x4004454")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite[] sprRoundTripTimeList;

	[Token(Token = "0x600618D")]
	[Address(RVA = "0x134645C", Offset = "0x134645C", VA = "0x134645C")]
	public XWidget_RoudTripTime()
	{
	}

	[Token(Token = "0x600618E")]
	[Address(RVA = "0x131B090", Offset = "0x131B090", VA = "0x131B090")]
	internal void UpdateRoundTripState(int roundTripTime)
	{
	}
}
