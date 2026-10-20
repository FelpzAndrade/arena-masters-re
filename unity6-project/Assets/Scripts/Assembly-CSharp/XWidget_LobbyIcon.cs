using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E6D")]
public class XWidget_LobbyIcon : MonoBehaviour
{
	[Token(Token = "0x4004B89")]
	[FieldOffset(Offset = "0xC")]
	public UI2DSprite sprExpeditionIcon;

	[Token(Token = "0x4004B8A")]
	[FieldOffset(Offset = "0x10")]
	public UI2DSprite sprExpeditionLabelBackground;

	[Token(Token = "0x4004B8B")]
	[FieldOffset(Offset = "0x14")]
	public UILabel lblExpeditionName;

	[Token(Token = "0x4004B8C")]
	[FieldOffset(Offset = "0x18")]
	public UIPlayTween playTween;

	[Token(Token = "0x4004B8D")]
	[FieldOffset(Offset = "0x1C")]
	public XWidget_OnPress pressCallBack;

	[Token(Token = "0x4004B8E")]
	[FieldOffset(Offset = "0x20")]
	public UILabel lblChargeInfo;

	[Token(Token = "0x4004B8F")]
	[FieldOffset(Offset = "0x24")]
	public TweenAlpha tweenAlpha;

	[Token(Token = "0x4004B90")]
	[FieldOffset(Offset = "0x28")]
	private int m_reqLev;

	[Token(Token = "0x6006BAD")]
	[Address(RVA = "0x145CF28", Offset = "0x145CF28", VA = "0x145CF28")]
	public XWidget_LobbyIcon()
	{
	}

	[Token(Token = "0x6006BAE")]
	[Address(RVA = "0x145CF30", Offset = "0x145CF30", VA = "0x145CF30")]
	public void Build(ICON_TYPE type)
	{
	}

	[Token(Token = "0x6006BAF")]
	[Address(RVA = "0x145D1F8", Offset = "0x145D1F8", VA = "0x145D1F8")]
	public void ShowChargeInfo()
	{
	}

	[Token(Token = "0x6006BB0")]
	[Address(RVA = "0x145D268", Offset = "0x145D268", VA = "0x145D268")]
	public void HideChargeInfo()
	{
	}

	[Token(Token = "0x6006BB1")]
	[Address(RVA = "0x145D294", Offset = "0x145D294", VA = "0x145D294")]
	public void ExpeditionRequireLevelCheck()
	{
	}
}
