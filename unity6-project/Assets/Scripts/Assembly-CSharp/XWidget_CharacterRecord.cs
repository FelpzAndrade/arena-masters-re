using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D32")]
public class XWidget_CharacterRecord : MonoBehaviour
{
	[Token(Token = "0x400438B")]
	[FieldOffset(Offset = "0xC")]
	public UI2DSprite sprIcon;

	[Token(Token = "0x400438C")]
	[FieldOffset(Offset = "0x10")]
	public UILabel lblLevel;

	[Token(Token = "0x400438D")]
	[FieldOffset(Offset = "0x14")]
	public UI2DSprite sprSelect;

	[Token(Token = "0x400438E")]
	[FieldOffset(Offset = "0x18")]
	public UILabel lblWinLose;

	[Token(Token = "0x400438F")]
	[FieldOffset(Offset = "0x1C")]
	public UI2DSprite sprDisable;

	[Token(Token = "0x4004390")]
	[FieldOffset(Offset = "0x20")]
	public UI2DSprite sprPortraitFrame;

	[Token(Token = "0x4004391")]
	[FieldOffset(Offset = "0x24")]
	public UI2DSprite sprPortraitLevel;

	[Token(Token = "0x60060D6")]
	[Address(RVA = "0x15CD2D8", Offset = "0x15CD2D8", VA = "0x15CD2D8")]
	public XWidget_CharacterRecord()
	{
	}

	[Token(Token = "0x60060D7")]
	[Address(RVA = "0x15CD2E0", Offset = "0x15CD2E0", VA = "0x15CD2E0")]
	public void Show(bool b)
	{
	}

	[Token(Token = "0x60060D8")]
	[Address(RVA = "0x15CD424", Offset = "0x15CD424", VA = "0x15CD424")]
	public void Build(int charId, int charSkinId, int charLev, CSWinlose winLose, bool select, bool disable, int tier)
	{
	}

	[Token(Token = "0x60060D9")]
	[Address(RVA = "0x15CD71C", Offset = "0x15CD71C", VA = "0x15CD71C")]
	public void SetPortraitFrame(int titleId)
	{
	}

	[Token(Token = "0x60060DA")]
	[Address(RVA = "0x15CD828", Offset = "0x15CD828", VA = "0x15CD828")]
	public void SetPortraitLevel(int playerTier)
	{
	}
}
