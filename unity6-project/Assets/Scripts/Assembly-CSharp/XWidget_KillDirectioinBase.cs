using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

[Token(Token = "0x2000D38")]
public class XWidget_KillDirectioinBase : XUIAsyncLoadBase
{
	[Token(Token = "0x40043A4")]
	private const string strEffectPath = "Prefab/Effects/Etc/Fx_multikill";

	[Token(Token = "0x40043A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public UILabel lblUserName;

	[Token(Token = "0x40043A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public UI2DSprite sprChar;

	[Token(Token = "0x40043A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public UI2DSprite sprCharTitle;

	[Token(Token = "0x40043A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public UIWidget widget;

	[Token(Token = "0x40043A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected bool m_isShow;

	[Token(Token = "0x40043AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float m_show_KeepTime;

	[Token(Token = "0x40043AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float m_show_ElapsedTime;

	[Token(Token = "0x40043AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	protected Action endShowAction;

	[Token(Token = "0x60060F5")]
	[Address(RVA = "0x1456C1C", Offset = "0x1456C1C", VA = "0x1456C1C")]
	public XWidget_KillDirectioinBase()
	{
	}

	[Token(Token = "0x60060F6")]
	[Address(RVA = "0x1456C2C", Offset = "0x1456C2C", VA = "0x1456C2C", Slot = "4")]
	protected override void Init()
	{
	}

	[Token(Token = "0x60060F7")]
	[Address(RVA = "0x1456CB8", Offset = "0x1456CB8", VA = "0x1456CB8")]
	public void SetAlpha(float alpha)
	{
	}

	[Token(Token = "0x60060F8")]
	[Address(RVA = "0x1456DC4", Offset = "0x1456DC4", VA = "0x1456DC4")]
	protected void SetKillDirection(int profileIconID, int titleID, string userName, [Optional] Action action)
	{
	}

	[Token(Token = "0x60060F9")]
	[Address(RVA = "0x145717C", Offset = "0x145717C", VA = "0x145717C")]
	protected void SetEndAction(Action action)
	{
	}

	[Token(Token = "0x60060FA")]
	[Address(RVA = "0x1456E78", Offset = "0x1456E78", VA = "0x1456E78")]
	protected void ResetElapedTime()
	{
	}

	[Token(Token = "0x60060FB")]
	[Address(RVA = "0x1456E84", Offset = "0x1456E84", VA = "0x1456E84")]
	protected void SetUserName(string userName)
	{
	}

	[Token(Token = "0x60060FC")]
	[Address(RVA = "0x1457070", Offset = "0x1457070", VA = "0x1457070")]
	protected void SetCharTitle(int titleID)
	{
	}

	[Token(Token = "0x60060FD")]
	[Address(RVA = "0x1456F64", Offset = "0x1456F64", VA = "0x1456F64")]
	protected void SetProfileIcon(int profileIconId)
	{
	}

	[Token(Token = "0x60060FE")]
	[Address(RVA = "0x1457184", Offset = "0x1457184", VA = "0x1457184")]
	public void Hide()
	{
	}

	[Token(Token = "0x60060FF")]
	[Address(RVA = "0x14571B8", Offset = "0x14571B8", VA = "0x14571B8")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6006100")]
	[Address(RVA = "0x14571E0", Offset = "0x14571E0", VA = "0x14571E0")]
	private void UpdateMultiKill(float deltaTime)
	{
	}
}
