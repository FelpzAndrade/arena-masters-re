using System;
using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x20005A3")]
public class XPVPGameModeState_CountDown : XGameModeState_CountDown
{
	[Token(Token = "0x4001B70")]
	[FieldOffset(Offset = "0x0")]
	private static Func<KeyValuePair<string, XPlayer>, string> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x4001B71")]
	[FieldOffset(Offset = "0x4")]
	private static Func<KeyValuePair<string, XPlayer>, XPlayer> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x4001B72")]
	[FieldOffset(Offset = "0x8")]
	private static Func<XPlayer, XPlayerTeamData> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x6003037")]
	[Address(RVA = "0x1C82BAC", Offset = "0x1C82BAC", VA = "0x1C82BAC")]
	public XPVPGameModeState_CountDown()
	{
	}

	[Token(Token = "0x6003038")]
	[Address(RVA = "0x1C9990C", Offset = "0x1C9990C", VA = "0x1C9990C", Slot = "12")]
	public override void OnApplicationPause(bool pauseStatus)
	{
	}

	[Token(Token = "0x6003039")]
	[Address(RVA = "0x1C82DB0", Offset = "0x1C82DB0", VA = "0x1C82DB0")]
	protected bool CheckLeague()
	{
		return default(bool);
	}

	[Token(Token = "0x600303A")]
	[Address(RVA = "0x1C82DB8", Offset = "0x1C82DB8", VA = "0x1C82DB8")]
	protected void DevideIntoTeamForLeague()
	{
	}

	[Token(Token = "0x600303B")]
	[Address(RVA = "0x1C99A6C", Offset = "0x1C99A6C", VA = "0x1C99A6C")]
	protected void DivideTeamNew(ref List<KeyValuePair<string, XPlayer>> sortedList)
	{
	}

	[Token(Token = "0x600303C")]
	[Address(RVA = "0x1C99C08", Offset = "0x1C99C08", VA = "0x1C99C08")]
	protected void NotifyDivideTeam(List<XPlayer> _liPlayer)
	{
	}

	[Token(Token = "0x600303D")]
	[Address(RVA = "0x1C99E74", Offset = "0x1C99E74", VA = "0x1C99E74")]
	private static string _003CDevideIntoTeamForLeague_003Em__112(KeyValuePair<string, XPlayer> e)
	{
		return null;
	}

	[Token(Token = "0x600303E")]
	[Address(RVA = "0x1C99F14", Offset = "0x1C99F14", VA = "0x1C99F14")]
	private static XPlayer _003CDivideTeamNew_003Em__113(KeyValuePair<string, XPlayer> item)
	{
		return null;
	}

	[Token(Token = "0x600303F")]
	[Address(RVA = "0x1C99FA0", Offset = "0x1C99FA0", VA = "0x1C99FA0")]
	private static XPlayerTeamData _003CNotifyDivideTeam_003Em__114(XPlayer item)
	{
		return null;
	}
}
