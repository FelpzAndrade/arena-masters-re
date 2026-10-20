using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000FA5")]
public class XWidget_LobbyCharIllust : MonoBehaviour
{
	[Token(Token = "0x40052D0")]
	[FieldOffset(Offset = "0xC")]
	public UI2DSprite sprIllust;

	[Token(Token = "0x40052D1")]
	[FieldOffset(Offset = "0x10")]
	public XUISound sound;

	[Token(Token = "0x40052D2")]
	[FieldOffset(Offset = "0x14")]
	private XModuleActor m_actor;

	[Token(Token = "0x600748F")]
	[Address(RVA = "0x145CF18", Offset = "0x145CF18", VA = "0x145CF18")]
	public XWidget_LobbyCharIllust()
	{
	}

	[Token(Token = "0x6007490")]
	[Address(RVA = "0x145CF20", Offset = "0x145CF20", VA = "0x145CF20")]
	public void Build(XCharacterInventory charInven)
	{
	}

	[Token(Token = "0x6007491")]
	[Address(RVA = "0x145CF24", Offset = "0x145CF24", VA = "0x145CF24")]
	public void OnClick()
	{
	}
}
