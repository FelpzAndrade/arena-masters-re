using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20002D2")]
public class PhotonStatsGui : MonoBehaviour
{
	[Token(Token = "0x4000EF1")]
	[FieldOffset(Offset = "0xC")]
	public bool statsWindowOn;

	[Token(Token = "0x4000EF2")]
	[FieldOffset(Offset = "0xD")]
	public bool statsOn;

	[Token(Token = "0x4000EF3")]
	[FieldOffset(Offset = "0xE")]
	public bool healthStatsVisible;

	[Token(Token = "0x4000EF4")]
	[FieldOffset(Offset = "0xF")]
	public bool trafficStatsOn;

	[Token(Token = "0x4000EF5")]
	[FieldOffset(Offset = "0x10")]
	public bool buttonsOn;

	[Token(Token = "0x4000EF6")]
	[FieldOffset(Offset = "0x14")]
	public Rect statsRect;

	[Token(Token = "0x4000EF7")]
	[FieldOffset(Offset = "0x24")]
	public int WindowId;

	[Token(Token = "0x6001917")]
	[Address(RVA = "0x1B9C2D8", Offset = "0x1B9C2D8", VA = "0x1B9C2D8")]
	public PhotonStatsGui()
	{
	}

	[Token(Token = "0x6001918")]
	[Address(RVA = "0x1B9C35C", Offset = "0x1B9C35C", VA = "0x1B9C35C")]
	public void Start()
	{
	}

	[Token(Token = "0x6001919")]
	[Address(RVA = "0x1B9C3C4", Offset = "0x1B9C3C4", VA = "0x1B9C3C4")]
	public void Update()
	{
	}

	[Token(Token = "0x600191A")]
	[Address(RVA = "0x1B9C4D0", Offset = "0x1B9C4D0", VA = "0x1B9C4D0")]
	public void OnGUI()
	{
	}

	[Token(Token = "0x600191B")]
	[Address(RVA = "0x1B9C708", Offset = "0x1B9C708", VA = "0x1B9C708")]
	public void TrafficStatsWindow(int windowID)
	{
	}
}
