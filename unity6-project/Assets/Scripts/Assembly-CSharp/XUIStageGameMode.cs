using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000CF3")]
public abstract class XUIStageGameMode : XUIGameMode
{
	[Token(Token = "0x4004210")]
	[FieldOffset(Offset = "0x50")]
	private XPanel_RevivePopup m_pnlRevivePopup;

	[Token(Token = "0x6005DF5")]
	[Address(RVA = "0x1931E24", Offset = "0x1931E24", VA = "0x1931E24")]
	protected XUIStageGameMode()
	{
	}

	[Token(Token = "0x6005DF6")]
	[Address(RVA = "0x1931E2C", Offset = "0x1931E2C", VA = "0x1931E2C", Slot = "4")]
	public override void Final()
	{
	}

	[Token(Token = "0x6005DF7")]
	[Address(RVA = "0x1931E4C", Offset = "0x1931E4C", VA = "0x1931E4C", Slot = "5")]
	protected override void LoadModePrefabs()
	{
	}

	[Token(Token = "0x6005DF8")]
	[Address(RVA = "0x1931E54", Offset = "0x1931E54", VA = "0x1931E54", Slot = "64")]
	public override void ShowRevivePopup(bool bShow, Vector3 diePos, Action giveUpCallBack)
	{
	}
}
