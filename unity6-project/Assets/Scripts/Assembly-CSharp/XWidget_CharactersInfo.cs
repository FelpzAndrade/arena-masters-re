using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000EB8")]
public class XWidget_CharactersInfo : MonoBehaviour
{
	[Token(Token = "0x4004D6B")]
	[FieldOffset(Offset = "0xC")]
	public UI2DSprite sprTier;

	[Token(Token = "0x4004D6C")]
	[FieldOffset(Offset = "0x10")]
	public UILabel lblNickName;

	[Token(Token = "0x4004D6D")]
	[FieldOffset(Offset = "0x14")]
	public UILabel lblReadyState;

	[Token(Token = "0x4004D6E")]
	[FieldOffset(Offset = "0x18")]
	public UI2DSprite[] sprChar;

	[Token(Token = "0x4004D6F")]
	[FieldOffset(Offset = "0x1C")]
	public UI2DSprite sprRelic;

	[Token(Token = "0x6006DAB")]
	[Address(RVA = "0x15CDAA8", Offset = "0x15CDAA8", VA = "0x15CDAA8")]
	public XWidget_CharactersInfo()
	{
	}

	[Token(Token = "0x6006DAC")]
	[Address(RVA = "0x15CDAB0", Offset = "0x15CDAB0", VA = "0x15CDAB0")]
	public void InitUI()
	{
	}

	[Token(Token = "0x6006DAD")]
	[Address(RVA = "0x15CDC6C", Offset = "0x15CDC6C", VA = "0x15CDC6C")]
	internal void SetCharacterInfo(MatchPlayerInfo _playerInfo)
	{
	}

	[Token(Token = "0x6006DAE")]
	[Address(RVA = "0x15CE448", Offset = "0x15CE448", VA = "0x15CE448")]
	public void UnloadSprite()
	{
	}

	[Token(Token = "0x6006DAF")]
	[Address(RVA = "0x15CE5B0", Offset = "0x15CE5B0", VA = "0x15CE5B0")]
	internal void ChangeLoadingState(bool isReady)
	{
	}
}
