using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200101C")]
public class XUIBlockFriendItem : MonoBehaviour
{
	[Token(Token = "0x400564C")]
	[FieldOffset(Offset = "0xC")]
	public UILabel lblName;

	[Token(Token = "0x400564D")]
	[FieldOffset(Offset = "0x10")]
	public UILabel lblLevel;

	[Token(Token = "0x400564E")]
	[FieldOffset(Offset = "0x14")]
	public UI2DSprite sprImage;

	[Token(Token = "0x400564F")]
	[FieldOffset(Offset = "0x18")]
	public UI2DSprite sprTitle;

	[Token(Token = "0x4005650")]
	[FieldOffset(Offset = "0x1C")]
	public UI2DSprite sprFlag;

	[Token(Token = "0x4005651")]
	[FieldOffset(Offset = "0x20")]
	private Friend m_user;

	[Token(Token = "0x6007824")]
	[Address(RVA = "0x1A2C198", Offset = "0x1A2C198", VA = "0x1A2C198")]
	public XUIBlockFriendItem()
	{
	}

	[Token(Token = "0x6007825")]
	[Address(RVA = "0x1A2C1A0", Offset = "0x1A2C1A0", VA = "0x1A2C1A0")]
	public void Build(Friend user)
	{
	}

	[Token(Token = "0x6007826")]
	[Address(RVA = "0x1A2C70C", Offset = "0x1A2C70C", VA = "0x1A2C70C")]
	public void OnClick_BlockFriendDetail()
	{
	}

	[Token(Token = "0x6007827")]
	[Address(RVA = "0x1A2C858", Offset = "0x1A2C858", VA = "0x1A2C858")]
	public void OnClick_BlockFriendDelete()
	{
	}

	[Token(Token = "0x6007828")]
	[Address(RVA = "0x1A2CAAC", Offset = "0x1A2CAAC", VA = "0x1A2CAAC")]
	private void _003COnClick_BlockFriendDelete_003Em__4FE()
	{
	}
}
