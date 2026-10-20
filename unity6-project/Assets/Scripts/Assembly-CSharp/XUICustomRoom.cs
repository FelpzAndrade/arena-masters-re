using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F18")]
public class XUICustomRoom : MonoBehaviour
{
	[Token(Token = "0x4004FE0")]
	[FieldOffset(Offset = "0xC")]
	public XWidget_Button btnCreateRoom;

	[Token(Token = "0x4004FE1")]
	[FieldOffset(Offset = "0x10")]
	public XWidget_Button btnShowRoomList;

	[Token(Token = "0x600707F")]
	[Address(RVA = "0x1A3AA08", Offset = "0x1A3AA08", VA = "0x1A3AA08")]
	public XUICustomRoom()
	{
	}

	[Token(Token = "0x6007080")]
	[Address(RVA = "0x1A3AA10", Offset = "0x1A3AA10", VA = "0x1A3AA10")]
	public void Build()
	{
	}

	[Token(Token = "0x6007081")]
	[Address(RVA = "0x1A3ABD4", Offset = "0x1A3ABD4", VA = "0x1A3ABD4")]
	public void OnClick_CreateRoom()
	{
	}

	[Token(Token = "0x6007082")]
	[Address(RVA = "0x1A3AD20", Offset = "0x1A3AD20", VA = "0x1A3AD20")]
	public void OnClick_ShowRoomList()
	{
	}
}
