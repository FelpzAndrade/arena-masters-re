using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20004BD")]
public class XIdentificationFriendOrFoe : MonoBehaviour
{
	[Token(Token = "0x400178F")]
	[FieldOffset(Offset = "0xC")]
	public GameObject target;

	[Token(Token = "0x4001790")]
	[FieldOffset(Offset = "0x10")]
	public GameObject forFriend;

	[Token(Token = "0x60028BC")]
	[Address(RVA = "0x1D28AC8", Offset = "0x1D28AC8", VA = "0x1D28AC8")]
	public XIdentificationFriendOrFoe()
	{
	}

	[Token(Token = "0x60028BD")]
	[Address(RVA = "0x1D28AD0", Offset = "0x1D28AD0", VA = "0x1D28AD0")]
	public void SetIdentity(bool foe)
	{
	}
}
