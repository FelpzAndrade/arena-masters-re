using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000EAB")]
public class XWidget_MatchingLoadingClanInfo : MonoBehaviour
{
	[Token(Token = "0x4004D09")]
	[FieldOffset(Offset = "0xC")]
	public Transform transformClanMark;

	[Token(Token = "0x4004D0A")]
	[FieldOffset(Offset = "0x10")]
	private XWidget_ClanMark clanMark;

	[Token(Token = "0x4004D0B")]
	[FieldOffset(Offset = "0x14")]
	public UILabel lblClanName;

	[Token(Token = "0x6006D5F")]
	[Address(RVA = "0x14618B0", Offset = "0x14618B0", VA = "0x14618B0")]
	public XWidget_MatchingLoadingClanInfo()
	{
	}

	[Token(Token = "0x6006D60")]
	[Address(RVA = "0x145F0EC", Offset = "0x145F0EC", VA = "0x145F0EC")]
	public void Build(string clanName, int clanMarkId, int clanColorId)
	{
	}

	[Token(Token = "0x6006D61")]
	[Address(RVA = "0x145F5AC", Offset = "0x145F5AC", VA = "0x145F5AC")]
	public void InActive()
	{
	}

	[Token(Token = "0x6006D62")]
	[Address(RVA = "0x145ED70", Offset = "0x145ED70", VA = "0x145ED70")]
	public void UnLoadResource()
	{
	}
}
