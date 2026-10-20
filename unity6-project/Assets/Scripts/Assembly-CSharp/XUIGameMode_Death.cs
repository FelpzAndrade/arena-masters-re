using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000CF9")]
public class XUIGameMode_Death : XUIGameMode
{
	[Token(Token = "0x4004217")]
	[FieldOffset(Offset = "0x50")]
	private XPanel_Death m_pnlDeath;

	[Token(Token = "0x4004218")]
	[FieldOffset(Offset = "0x0")]
	private static Func<KeyValuePair<string, XPlayer>, XPlayer> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x4004219")]
	[FieldOffset(Offset = "0x4")]
	private static Func<XPlayer, int> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x400421A")]
	[FieldOffset(Offset = "0x8")]
	private static Func<XPlayer, int> _003C_003Ef__am_0024cache3;

	[Token(Token = "0x6005E30")]
	[Address(RVA = "0x1A53E64", Offset = "0x1A53E64", VA = "0x1A53E64")]
	public XUIGameMode_Death()
	{
	}

	[Token(Token = "0x6005E31")]
	[Address(RVA = "0x1A53E74", Offset = "0x1A53E74", VA = "0x1A53E74", Slot = "4")]
	public override void Final()
	{
	}

	[Token(Token = "0x6005E32")]
	[Address(RVA = "0x1A53E90", Offset = "0x1A53E90", VA = "0x1A53E90", Slot = "11")]
	public override XGameModeType GetModeType()
	{
		return default(XGameModeType);
	}

	[Token(Token = "0x6005E33")]
	[Address(RVA = "0x1A53E98", Offset = "0x1A53E98", VA = "0x1A53E98", Slot = "5")]
	protected override void LoadModePrefabs()
	{
	}

	[Token(Token = "0x6005E34")]
	[Address(RVA = "0x1A53F44", Offset = "0x1A53F44", VA = "0x1A53F44", Slot = "7")]
	public override void OnCreated()
	{
	}

	[Token(Token = "0x6005E35")]
	[Address(RVA = "0x1A54054", Offset = "0x1A54054", VA = "0x1A54054", Slot = "9")]
	public override void OnDelayShow()
	{
	}

	[Token(Token = "0x6005E36")]
	[Address(RVA = "0x1A54118", Offset = "0x1A54118", VA = "0x1A54118", Slot = "47")]
	public override void ShowGameUI(bool bShow, float fadein = 0f)
	{
	}

	[Token(Token = "0x6005E37")]
	[Address(RVA = "0x1A54164", Offset = "0x1A54164", VA = "0x1A54164", Slot = "21")]
	public override void RefreshGameModeStatus()
	{
	}

	[Token(Token = "0x6005E38")]
	[Address(RVA = "0x1A5421C", Offset = "0x1A5421C", VA = "0x1A5421C", Slot = "8")]
	public override void OnShow()
	{
	}

	[Token(Token = "0x6005E39")]
	[Address(RVA = "0x1A5432C", Offset = "0x1A5432C", VA = "0x1A5432C", Slot = "6")]
	public override void OnShowUI(bool bShow)
	{
	}

	[Token(Token = "0x6005E3A")]
	[Address(RVA = "0x1A5423C", Offset = "0x1A5423C", VA = "0x1A5423C")]
	public void ShowPanelDeath(bool bShow)
	{
	}

	[Token(Token = "0x6005E3B")]
	[Address(RVA = "0x1A54350", Offset = "0x1A54350", VA = "0x1A54350", Slot = "45")]
	protected override int GetRankForAIMode(XPlayerManager pm)
	{
		return default(int);
	}

	[Token(Token = "0x6005E3C")]
	[Address(RVA = "0x1A54A00", Offset = "0x1A54A00", VA = "0x1A54A00")]
	private static XPlayer _003CGetRankForAIMode_003Em__2A3(KeyValuePair<string, XPlayer> item)
	{
		return null;
	}

	[Token(Token = "0x6005E3D")]
	[Address(RVA = "0x1A54A8C", Offset = "0x1A54A8C", VA = "0x1A54A8C")]
	private static int _003CGetRankForAIMode_003Em__2A4(XPlayer x)
	{
		return default(int);
	}

	[Token(Token = "0x6005E3E")]
	[Address(RVA = "0x1A54B80", Offset = "0x1A54B80", VA = "0x1A54B80")]
	private static int _003CGetRankForAIMode_003Em__2A5(XPlayer x)
	{
		return default(int);
	}
}
