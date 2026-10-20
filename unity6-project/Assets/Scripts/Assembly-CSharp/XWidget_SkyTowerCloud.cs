using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000FEC")]
public class XWidget_SkyTowerCloud : MonoBehaviour
{
	[Token(Token = "0x40054EC")]
	[FieldOffset(Offset = "0xC")]
	public UIScrollView m_listScrollView;

	[Token(Token = "0x40054ED")]
	[FieldOffset(Offset = "0x10")]
	public XPanel_SkyTower pnlSkyTower;

	[Token(Token = "0x40054EE")]
	[FieldOffset(Offset = "0x14")]
	public Camera m_Camera;

	[Token(Token = "0x40054EF")]
	[FieldOffset(Offset = "0x18")]
	public float m_Speed;

	[Token(Token = "0x40054F0")]
	[FieldOffset(Offset = "0x1C")]
	private float currPosY;

	[Token(Token = "0x40054F1")]
	[FieldOffset(Offset = "0x20")]
	private bool updateState;

	[Token(Token = "0x60076B2")]
	[Address(RVA = "0x1B0B12C", Offset = "0x1B0B12C", VA = "0x1B0B12C")]
	public XWidget_SkyTowerCloud()
	{
	}

	[Token(Token = "0x60076B3")]
	[Address(RVA = "0x1B0B134", Offset = "0x1B0B134", VA = "0x1B0B134")]
	public void BuildCloud(float speed)
	{
	}

	[Token(Token = "0x60076B4")]
	[Address(RVA = "0x1B0B2C4", Offset = "0x1B0B2C4", VA = "0x1B0B2C4")]
	private void Update()
	{
	}
}
