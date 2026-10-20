using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D42")]
public class XWidget_RankedIcon : MonoBehaviour
{
	[Token(Token = "0x4004437")]
	[FieldOffset(Offset = "0xC")]
	public UI2DSprite sprIcon;

	[Token(Token = "0x4004438")]
	[FieldOffset(Offset = "0x10")]
	public UI2DSprite sprRank;

	[Token(Token = "0x6006179")]
	[Address(RVA = "0x132FCF4", Offset = "0x132FCF4", VA = "0x132FCF4")]
	public XWidget_RankedIcon()
	{
	}

	[Token(Token = "0x600617A")]
	[Address(RVA = "0x132FCFC", Offset = "0x132FCFC", VA = "0x132FCFC")]
	public void Build(Sprite icon, Sprite rank)
	{
	}
}
