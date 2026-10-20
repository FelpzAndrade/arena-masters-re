using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20004C2")]
public class XAIModeTester : MonoBehaviour
{
	[Token(Token = "0x40017DC")]
	[FieldOffset(Offset = "0xC")]
	public int sectorId;

	[Token(Token = "0x40017DD")]
	[FieldOffset(Offset = "0x10")]
	public XGameModeType gameModeType;

	[Token(Token = "0x40017DE")]
	[FieldOffset(Offset = "0x14")]
	public int playerCharID;

	[Token(Token = "0x40017DF")]
	[FieldOffset(Offset = "0x18")]
	public int playerLev;

	[Token(Token = "0x40017E0")]
	[FieldOffset(Offset = "0x1C")]
	public int skillLev;

	[Token(Token = "0x40017E1")]
	[FieldOffset(Offset = "0x20")]
	public Netdata_EquipedItem[] equipItems;

	[Token(Token = "0x40017E2")]
	[FieldOffset(Offset = "0x24")]
	public int fieldLevel;

	[Token(Token = "0x40017E3")]
	[FieldOffset(Offset = "0x28")]
	public int timeLimit;

	[Token(Token = "0x40017E4")]
	[FieldOffset(Offset = "0x2C")]
	public int goalKill;

	[Token(Token = "0x60028DB")]
	[Address(RVA = "0x1EE2250", Offset = "0x1EE2250", VA = "0x1EE2250")]
	public XAIModeTester()
	{
	}

	[Token(Token = "0x60028DC")]
	[Address(RVA = "0x1EE2324", Offset = "0x1EE2324", VA = "0x1EE2324")]
	private void Start()
	{
	}
}
