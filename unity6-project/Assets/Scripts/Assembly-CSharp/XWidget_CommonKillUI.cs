using System;
using Il2CppDummyDll;

[Token(Token = "0x2000D33")]
public class XWidget_CommonKillUI : XWidget_KillDirectioinBase
{
	[Token(Token = "0x4004392")]
	[FieldOffset(Offset = "0x40")]
	public UILabel lblText;

	[Token(Token = "0x4004393")]
	[FieldOffset(Offset = "0x44")]
	public UI2DSprite sprMultiKill;

	[Token(Token = "0x60060DB")]
	[Address(RVA = "0x15E8B28", Offset = "0x15E8B28", VA = "0x15E8B28")]
	public XWidget_CommonKillUI()
	{
	}

	[Token(Token = "0x60060DC")]
	[Address(RVA = "0x15E8B30", Offset = "0x15E8B30", VA = "0x15E8B30")]
	public void ShowCommonKill(XKillStreakInfo killInfo, bool isEnemy, int profileIconID, int titleID, string userName, Action action)
	{
	}

	[Token(Token = "0x60060DD")]
	[Address(RVA = "0x15E90B0", Offset = "0x15E90B0", VA = "0x15E90B0")]
	public void ShowMultiKill(int charID, int skinID, int profileIconID, int titleID, string userName, int killCount, Action action)
	{
	}

	[Token(Token = "0x60060DE")]
	[Address(RVA = "0x15E8BD4", Offset = "0x15E8BD4", VA = "0x15E8BD4")]
	private void SetCommonText(XKillStreakInfo killInfo, bool isEnemy)
	{
	}

	[Token(Token = "0x60060DF")]
	[Address(RVA = "0x15E910C", Offset = "0x15E910C", VA = "0x15E910C")]
	private void ActiveMultiKillSpriteAndSound(int charID, int skinID, int killCount)
	{
	}

	[Token(Token = "0x60060E0")]
	[Address(RVA = "0x15E8B88", Offset = "0x15E8B88", VA = "0x15E8B88")]
	public void Clear()
	{
	}
}
