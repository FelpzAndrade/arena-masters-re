using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C35")]
public class XUIChatClanInvitePlayer : MonoBehaviour
{
	[Token(Token = "0x2000C36")]
	public enum UIState
	{
		[Token(Token = "0x4003DB6")]
		None = 0,
		[Token(Token = "0x4003DB7")]
		Normal = 1,
		[Token(Token = "0x4003DB8")]
		Wait = 2
	}

	[Token(Token = "0x4003DAD")]
	[FieldOffset(Offset = "0xC")]
	public UISprite sprBack;

	[Token(Token = "0x4003DAE")]
	[FieldOffset(Offset = "0x10")]
	public UI2DSprite sprTierIcon;

	[Token(Token = "0x4003DAF")]
	[FieldOffset(Offset = "0x14")]
	public UI2DSprite sprProfileIcon;

	[Token(Token = "0x4003DB0")]
	[FieldOffset(Offset = "0x18")]
	public UI2DSprite sprCharFrame;

	[Token(Token = "0x4003DB1")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel lblNickName;

	[Token(Token = "0x4003DB2")]
	[FieldOffset(Offset = "0x20")]
	public UILabel lblWaiting;

	[Token(Token = "0x4003DB3")]
	[FieldOffset(Offset = "0x24")]
	public Color myNameColor;

	[Token(Token = "0x4003DB4")]
	[FieldOffset(Offset = "0x34")]
	public Color defaultNameColor;

	[Token(Token = "0x600583E")]
	[Address(RVA = "0x1A31A4C", Offset = "0x1A31A4C", VA = "0x1A31A4C")]
	public XUIChatClanInvitePlayer()
	{
	}

	[Token(Token = "0x600583F")]
	[Address(RVA = "0x1A31A54", Offset = "0x1A31A54", VA = "0x1A31A54")]
	public void BuildEmpty()
	{
	}

	[Token(Token = "0x6005840")]
	[Address(RVA = "0x1A31A70", Offset = "0x1A31A70", VA = "0x1A31A70")]
	public void Build(string nickName, int profileIconID, int elo, int frameID)
	{
	}

	[Token(Token = "0x6005841")]
	[Address(RVA = "0x1A31BC4", Offset = "0x1A31BC4", VA = "0x1A31BC4")]
	private bool IsMyPlayer(string nickName)
	{
		return default(bool);
	}

	[Token(Token = "0x6005842")]
	[Address(RVA = "0x1A31A58", Offset = "0x1A31A58", VA = "0x1A31A58")]
	private void SetStateUI(UIState state)
	{
	}

	[Token(Token = "0x6005843")]
	[Address(RVA = "0x1A32018", Offset = "0x1A32018", VA = "0x1A32018")]
	private void NormalLayoutUI()
	{
	}

	[Token(Token = "0x6005844")]
	[Address(RVA = "0x1A320C4", Offset = "0x1A320C4", VA = "0x1A320C4")]
	private void WaitLayoutUI()
	{
	}

	[Token(Token = "0x6005845")]
	[Address(RVA = "0x1A31CE4", Offset = "0x1A31CE4", VA = "0x1A31CE4")]
	private void BuildProfileIcon(int profileIconId)
	{
	}

	[Token(Token = "0x6005846")]
	[Address(RVA = "0x1A31DD8", Offset = "0x1A31DD8", VA = "0x1A31DD8")]
	private void BuildTierIcon(int elo)
	{
	}
}
