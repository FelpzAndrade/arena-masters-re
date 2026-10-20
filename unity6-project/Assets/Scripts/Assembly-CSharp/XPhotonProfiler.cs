using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2000851")]
public class XPhotonProfiler
{
	[Token(Token = "0x40023F0")]
	[FieldOffset(Offset = "0x0")]
	public static bool IsLogPrint;

	[Token(Token = "0x40023F1")]
	[FieldOffset(Offset = "0x8")]
	public static long InCommingLogicTime;

	[Token(Token = "0x40023F2")]
	[FieldOffset(Offset = "0x10")]
	public static long TotalIncommingCommandsLogicTime;

	[Token(Token = "0x40023F3")]
	[FieldOffset(Offset = "0x18")]
	public static long MaxIncommingCommandsLogicTime;

	[Token(Token = "0x40023F4")]
	[FieldOffset(Offset = "0x20")]
	public static int IncommingCommandsCount;

	[Token(Token = "0x40023F5")]
	[FieldOffset(Offset = "0x24")]
	public static int DispatchCount;

	[Token(Token = "0x40023F6")]
	[FieldOffset(Offset = "0x28")]
	public static long OutgoingCommandsTime;

	[Token(Token = "0x40023F7")]
	[FieldOffset(Offset = "0x30")]
	public static long TotalOutgoingCommandsLogicTime;

	[Token(Token = "0x40023F8")]
	[FieldOffset(Offset = "0x38")]
	public static long MaxOutgoingCommandsLogicTime;

	[Token(Token = "0x40023F9")]
	[FieldOffset(Offset = "0x40")]
	public static int OutgoingCommandsCount;

	[Token(Token = "0x40023FA")]
	[FieldOffset(Offset = "0x44")]
	public static int OutgoingSendCount;

	[Token(Token = "0x40023FB")]
	[FieldOffset(Offset = "0x48")]
	public static long RunViewUpdateTime;

	[Token(Token = "0x40023FC")]
	[FieldOffset(Offset = "0x50")]
	public static long TotalRunViewUpdateLogicTime;

	[Token(Token = "0x40023FD")]
	[FieldOffset(Offset = "0x58")]
	public static long MaxRunViewUpdateTime;

	[Token(Token = "0x40023FE")]
	[FieldOffset(Offset = "0x60")]
	public static Dictionary<string, int> SendRPC;

	[Token(Token = "0x40023FF")]
	[FieldOffset(Offset = "0x64")]
	public static Dictionary<string, int> RecvRPC;

	[Token(Token = "0x60044FA")]
	[Address(RVA = "0xB24B24", Offset = "0xB24B24", VA = "0xB24B24")]
	public XPhotonProfiler()
	{
	}

	[Token(Token = "0x60044FC")]
	[Address(RVA = "0xB24C0C", Offset = "0xB24C0C", VA = "0xB24C0C")]
	public static void Init()
	{
	}

	[Token(Token = "0x60044FD")]
	[Address(RVA = "0xB24DF4", Offset = "0xB24DF4", VA = "0xB24DF4")]
	internal static void InComingCommandsLogicStart()
	{
	}

	[Token(Token = "0x60044FE")]
	[Address(RVA = "0xB24FC0", Offset = "0xB24FC0", VA = "0xB24FC0")]
	internal static void InComingCommandsLogicEnd(int dispatchCount)
	{
	}

	[Token(Token = "0x60044FF")]
	[Address(RVA = "0xB251DC", Offset = "0xB251DC", VA = "0xB251DC")]
	internal static void OutgoingCommandsLogicStart()
	{
	}

	[Token(Token = "0x6004500")]
	[Address(RVA = "0xB253A8", Offset = "0xB253A8", VA = "0xB253A8")]
	internal static void OutgoingCommandsLogicEnd(int outgoingCount)
	{
	}

	[Token(Token = "0x6004501")]
	[Address(RVA = "0xB255C4", Offset = "0xB255C4", VA = "0xB255C4")]
	internal static void RunViewUpdateLogicStart()
	{
	}

	[Token(Token = "0x6004502")]
	[Address(RVA = "0xB256F0", Offset = "0xB256F0", VA = "0xB256F0")]
	internal static void RunViewUpdateLogicEnd()
	{
	}

	[Token(Token = "0x6004503")]
	[Address(RVA = "0xB0CA8C", Offset = "0xB0CA8C", VA = "0xB0CA8C")]
	public static void Print()
	{
	}

	[Token(Token = "0x6004504")]
	[Address(RVA = "0xB0B5F8", Offset = "0xB0B5F8", VA = "0xB0B5F8")]
	internal static void AddSendRPC(string name)
	{
	}

	[Token(Token = "0x6004505")]
	[Address(RVA = "0xB0B92C", Offset = "0xB0B92C", VA = "0xB0B92C")]
	internal static void AddRecvRPC(string name)
	{
	}

	[Token(Token = "0x6004506")]
	[Address(RVA = "0xB258B4", Offset = "0xB258B4", VA = "0xB258B4")]
	private static string GetSendRPCLog()
	{
		return null;
	}

	[Token(Token = "0x6004507")]
	[Address(RVA = "0xB25C44", Offset = "0xB25C44", VA = "0xB25C44")]
	private static string GetRecvRPCLog()
	{
		return null;
	}
}
