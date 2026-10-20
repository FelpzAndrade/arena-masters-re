using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000597")]
public class XGameModeScenario : XGameModePVE
{
	[Token(Token = "0x6002FE5")]
	[Address(RVA = "0x140E740", Offset = "0x140E740", VA = "0x140E740")]
	public XGameModeScenario(XGameModeType nGameModeType)
	{
	}

	[Token(Token = "0x6002FE6")]
	[Address(RVA = "0x1413070", Offset = "0x1413070", VA = "0x1413070", Slot = "12")]
	public override List<Vector3> GetCurrentWayPoints()
	{
		return null;
	}

	[Token(Token = "0x6002FE7")]
	[Address(RVA = "0x141309C", Offset = "0x141309C", VA = "0x141309C", Slot = "31")]
	public override bool IsMasterClient()
	{
		return default(bool);
	}

	[Token(Token = "0x6002FE8")]
	[Address(RVA = "0x14130A4", Offset = "0x14130A4", VA = "0x14130A4", Slot = "37")]
	public override bool IsFinish()
	{
		return default(bool);
	}

	[Token(Token = "0x6002FE9")]
	[Address(RVA = "0x14130AC", Offset = "0x14130AC", VA = "0x14130AC", Slot = "35")]
	public override void RefreshRecords()
	{
	}

	[Token(Token = "0x6002FEA")]
	[Address(RVA = "0x14130B0", Offset = "0x14130B0", VA = "0x14130B0", Slot = "39")]
	public override XPlayerManager GetFinalRecords()
	{
		return null;
	}

	[Token(Token = "0x6002FEB")]
	[Address(RVA = "0x14131C4", Offset = "0x14131C4", VA = "0x14131C4", Slot = "30")]
	public override void RespawnMyPlayer()
	{
	}
}
