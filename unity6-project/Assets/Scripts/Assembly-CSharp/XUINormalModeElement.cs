using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006E5")]
public class XUINormalModeElement : XUIModeElementBase
{
	[Token(Token = "0x40020F3")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject goEffect;

	[Token(Token = "0x40020F4")]
	[FieldOffset(Offset = "0x30")]
	public XWidget_Libbon libbon;

	[Token(Token = "0x40020F5")]
	[FieldOffset(Offset = "0x34")]
	public UILabel lblModeName;

	[Token(Token = "0x40020F6")]
	[FieldOffset(Offset = "0x38")]
	public XWidget_Mark modeMark;

	[Token(Token = "0x40020F7")]
	[FieldOffset(Offset = "0x3C")]
	public UIBasicSprite[] sprSpeeds;

	[Token(Token = "0x40020F8")]
	[FieldOffset(Offset = "0x40")]
	private GameModeInstanceInfo m_modeInstanceInfo;

	[Token(Token = "0x40020F9")]
	[FieldOffset(Offset = "0x44")]
	private int m_unlockNeedLv;

	[Token(Token = "0x40020FA")]
	[FieldOffset(Offset = "0x48")]
	private int m_roomCount;

	[Token(Token = "0x40020FB")]
	[FieldOffset(Offset = "0x4C")]
	private int roomCheckMin;

	[Token(Token = "0x40020FC")]
	[FieldOffset(Offset = "0x50")]
	private int roomCheckMax;

	[Token(Token = "0x40020FD")]
	[FieldOffset(Offset = "0x54")]
	private int hideLevel;

	[Token(Token = "0x60039B7")]
	[Address(RVA = "0x1904F9C", Offset = "0x1904F9C", VA = "0x1904F9C")]
	public XUINormalModeElement()
	{
	}

	[Token(Token = "0x60039B8")]
	[Address(RVA = "0x1904FAC", Offset = "0x1904FAC", VA = "0x1904FAC")]
	private void Awake()
	{
	}

	[Token(Token = "0x60039B9")]
	[Address(RVA = "0x1905110", Offset = "0x1905110", VA = "0x1905110")]
	public void SetActiveEffect(bool isActive)
	{
	}

	[Token(Token = "0x60039BA")]
	[Address(RVA = "0x19051F0", Offset = "0x19051F0", VA = "0x19051F0")]
	public void Init(GameModeInstanceInfo modeInstanceInfo, string modeLocaleKey, int unlockNeedLv, int myLevel, int hideLevel)
	{
	}

	[Token(Token = "0x60039BB")]
	[Address(RVA = "0x1905588", Offset = "0x1905588", VA = "0x1905588")]
	public void BuildLock(int level)
	{
	}

	[Token(Token = "0x60039BC")]
	[Address(RVA = "0x19055C4", Offset = "0x19055C4", VA = "0x19055C4")]
	public bool IsHideLevel(int myLevel)
	{
		return default(bool);
	}

	[Token(Token = "0x60039BD")]
	[Address(RVA = "0x1905440", Offset = "0x1905440", VA = "0x1905440")]
	public void Refresh(int myLevel)
	{
	}

	[Token(Token = "0x60039BE")]
	[Address(RVA = "0x1905AB0", Offset = "0x1905AB0", VA = "0x1905AB0")]
	public void OnPlayingPlayerCountChanged()
	{
	}

	[Token(Token = "0x60039BF")]
	[Address(RVA = "0x19055D8", Offset = "0x19055D8", VA = "0x19055D8")]
	private void BuildMatchingSpeed(GameModeInstanceInfo modeInstanceInfo)
	{
	}
}
