using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C89")]
public class XWidget_MonsterIcon : MonoBehaviour
{
	[Token(Token = "0x4003FD5")]
	[FieldOffset(Offset = "0xC")]
	public UI2DSprite sprIcon;

	[Token(Token = "0x4003FD6")]
	[FieldOffset(Offset = "0x10")]
	public UI2DSprite sprGrade;

	[Token(Token = "0x6005A98")]
	[Address(RVA = "0x12FFA58", Offset = "0x12FFA58", VA = "0x12FFA58")]
	public XWidget_MonsterIcon()
	{
	}

	[Token(Token = "0x6005A99")]
	[Address(RVA = "0x12FFA60", Offset = "0x12FFA60", VA = "0x12FFA60")]
	public void Build(CSCharacterInfo monsterInfo)
	{
	}
}
