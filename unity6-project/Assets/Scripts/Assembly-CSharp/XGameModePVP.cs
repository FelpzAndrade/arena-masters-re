using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000596")]
public class XGameModePVP : XGameMode
{
		protected XGameModePVP()
		{
		}

	[Token(Token = "0x4001B5A")]
	[FieldOffset(Offset = "0x78")]
	private List<GameObject> headStoneList;

	[Token(Token = "0x6002FD8")]
	[Address(RVA = "0x13FF00C", Offset = "0x13FF00C", VA = "0x13FF00C")]
	public XGameModePVP(XGameModeType nGameModeType)
	{
	}

	[Token(Token = "0x6002FD9")]
	[Address(RVA = "0x1411370", Offset = "0x1411370", VA = "0x1411370", Slot = "37")]
	public override bool IsFinish()
	{
		return default(bool);
	}

	[Token(Token = "0x6002FDA")]
	[Address(RVA = "0x1411378", Offset = "0x1411378", VA = "0x1411378")]
	public string GetKillAndDeathMessage(XModuleEntity attacker, XModuleEntity me)
	{
		return null;
	}

	[Token(Token = "0x6002FDB")]
	[Address(RVA = "0x14116C4", Offset = "0x14116C4", VA = "0x14116C4", Slot = "48")]
	protected virtual void SendKillAndDieEvent(string strAttackerName)
	{
	}

	[Token(Token = "0x6002FDC")]
	[Address(RVA = "0x13FF3B0", Offset = "0x13FF3B0", VA = "0x13FF3B0")]
	protected void ProcessKillAndDie(XModuleEntity attacker, XModuleEntity me)
	{
	}

	[Token(Token = "0x6002FDD")]
	[Address(RVA = "0x1401D70", Offset = "0x1401D70", VA = "0x1401D70", Slot = "18")]
	public override void OnMyDie(XModuleEntity me, XModuleEntity attacker)
	{
	}

	[Token(Token = "0x6002FDE")]
	[Address(RVA = "0x1405A04", Offset = "0x1405A04", VA = "0x1405A04", Slot = "11")]
	public override void OnGameInit()
	{
	}

	[Token(Token = "0x6002FDF")]
	[Address(RVA = "0x14117A8", Offset = "0x14117A8", VA = "0x14117A8")]
	private bool CheckReentryGame()
	{
		return default(bool);
	}

	[Token(Token = "0x6002FE0")]
	[Address(RVA = "0x1400224", Offset = "0x1400224", VA = "0x1400224", Slot = "35")]
	public override void RefreshRecords()
	{
	}

	[Token(Token = "0x6002FE1")]
	[Address(RVA = "0x14007E4", Offset = "0x14007E4", VA = "0x14007E4", Slot = "39")]
	public override XPlayerManager GetFinalRecords()
	{
		return null;
	}

	[Token(Token = "0x6002FE2")]
	[Address(RVA = "0x140DBE4", Offset = "0x140DBE4", VA = "0x140DBE4")]
	public void SyncToHeadStone()
	{
	}

	[Token(Token = "0x6002FE3")]
	[Address(RVA = "0x141194C", Offset = "0x141194C", VA = "0x141194C")]
	private void ReleaseHeadStone()
	{
	}

	[Token(Token = "0x6002FE4")]
	[Address(RVA = "0x1411B08", Offset = "0x1411B08", VA = "0x1411B08")]
	private void CreateHeadStone(XModuleEntity me)
	{
	}
}
