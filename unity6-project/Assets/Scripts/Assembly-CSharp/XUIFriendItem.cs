using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using UnityEngine;

[Token(Token = "0x2001021")]
public class XUIFriendItem : MonoBehaviour
{
	[Token(Token = "0x4005676")]
	[FieldOffset(Offset = "0xC")]
	public UILabel lblName;

	[Token(Token = "0x4005677")]
	[FieldOffset(Offset = "0x10")]
	public UILabel lblLevel;

	[Token(Token = "0x4005678")]
	[FieldOffset(Offset = "0x14")]
	public UILabel lblLastTime;

	[Token(Token = "0x4005679")]
	[FieldOffset(Offset = "0x18")]
	public UI2DSprite sprImage;

	[Token(Token = "0x400567A")]
	[FieldOffset(Offset = "0x1C")]
	public UI2DSprite sprTitle;

	[Token(Token = "0x400567B")]
	[FieldOffset(Offset = "0x20")]
	public UI2DSprite sprFlag;

	[Token(Token = "0x400567C")]
	[FieldOffset(Offset = "0x24")]
	public UILabel lblCoolTime;

	[Token(Token = "0x400567D")]
	[FieldOffset(Offset = "0x28")]
	private XFriendData m_user;

	[Token(Token = "0x400567E")]
	[FieldOffset(Offset = "0x2C")]
	private bool sendPoint;

	[Token(Token = "0x6007839")]
	[Address(RVA = "0x1A467E4", Offset = "0x1A467E4", VA = "0x1A467E4")]
	public XUIFriendItem()
	{
	}

	[Token(Token = "0x600783A")]
	[Address(RVA = "0x1A467EC", Offset = "0x1A467EC", VA = "0x1A467EC")]
	public void Build(XFriendData user, bool state)
	{
	}

	[Token(Token = "0x600783B")]
	[Address(RVA = "0x1A46EA8", Offset = "0x1A46EA8", VA = "0x1A46EA8")]
	private void SetLastTime(XFriendData user)
	{
	}

	[Token(Token = "0x600783C")]
	[Address(RVA = "0x1A471A4", Offset = "0x1A471A4", VA = "0x1A471A4")]
	private void SetCoolTime(int cooltime)
	{
	}

	[Token(Token = "0x600783D")]
	[Address(RVA = "0x1A471DC", Offset = "0x1A471DC", VA = "0x1A471DC")]
	private string GetCoolTime(int sec)
	{
		return null;
	}

	[Token(Token = "0x600783E")]
	[Address(RVA = "0x1A473C4", Offset = "0x1A473C4", VA = "0x1A473C4")]
	public void OnClick_FriendPoint()
	{
	}

	[Token(Token = "0x600783F")]
	[Address(RVA = "0x1A47614", Offset = "0x1A47614", VA = "0x1A47614")]
	public void OnClick_FriendDetail()
	{
	}

	[Token(Token = "0x6007840")]
	[Address(RVA = "0x1A47770", Offset = "0x1A47770", VA = "0x1A47770")]
	public void OnClick_FriendDelete()
	{
	}

	[Token(Token = "0x6007841")]
	[Address(RVA = "0x1A479D4", Offset = "0x1A479D4", VA = "0x1A479D4")]
	public void MessageOneFriendPoint()
	{
	}

	[Token(Token = "0x6007842")]
	[Address(RVA = "0x1A47AA0", Offset = "0x1A47AA0", VA = "0x1A47AA0")]
	private void _003COnClick_FriendPoint_003Em__500(ApiReturnCode result, string errmsg, JObject json)
	{
	}

	[Token(Token = "0x6007843")]
	[Address(RVA = "0x1A47C30", Offset = "0x1A47C30", VA = "0x1A47C30")]
	private void _003COnClick_FriendDelete_003Em__501()
	{
	}
}
