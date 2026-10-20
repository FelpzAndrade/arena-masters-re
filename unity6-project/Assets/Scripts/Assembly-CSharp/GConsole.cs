using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000028")]
public class GConsole : MonoBehaviour
{
	[Token(Token = "0x2000029")]
	public delegate void GConsoleListener(string line);

	[Token(Token = "0x200002A")]
	private sealed class _003CGetSuggestions_003Ec__AnonStoreyC1
	{
		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal string inputSoFar;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal bool includeDescription;

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x1F3038C", Offset = "0x1F3038C", VA = "0x1F3038C")]
		public _003CGetSuggestions_003Ec__AnonStoreyC1()
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x1F318E4", Offset = "0x1F318E4", VA = "0x1F318E4")]
		internal bool _003C_003Em__5(string c)
		{
			return default(bool);
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x1F31918", Offset = "0x1F31918", VA = "0x1F31918")]
		internal string _003C_003Em__7(string c)
		{
			return null;
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x1F31B2C", Offset = "0x1F31B2C", VA = "0x1F31B2C")]
		internal string _003C_003Em__8(string c)
		{
			return null;
		}
	}

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static GConsole instance;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public bool outputUnityLog;

	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
	public bool outputStackTrace;

	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
	public bool useColoredText;

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
	public bool allowEmptyOutput;

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool newlineAfterCommandOutput;

	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static Dictionary<string, GConsoleCommand> commands;

	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static GConsoleCommand defaultCommand;

	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private static string INVALID_COMMAND_STRING;

	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static string COMMAND_NOT_FOUND_STRING;

	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private static string ERROR_STRING;

	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static string WARNING_STRING;

	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private static string LOG_STRING;

	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static string EXCEPTION_STRING;

	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private static string ASSERT_STRING;

	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static GConsoleListener m_OnOutput;

	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private static Func<KeyValuePair<string, GConsoleCommand>, string> _003C_003Ef__am_0024cache10;

	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static Func<KeyValuePair<string, GConsoleCommand>, string> _003C_003Ef__am_0024cache11;

	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private static Func<KeyValuePair<string, GConsoleCommand>, GConsoleCommand> _003C_003Ef__am_0024cache12;

	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static Func<string, int> _003C_003Ef__am_0024cache13;

	[Token(Token = "0x14000001")]
	public static event GConsoleListener OnOutput
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x1F2E030", Offset = "0x1F2E030", VA = "0x1F2E030")]
		add
		{
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x1F2E214", Offset = "0x1F2E214", VA = "0x1F2E214")]
		remove
		{
		}
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x1F2DF68", Offset = "0x1F2DF68", VA = "0x1F2DF68")]
	public GConsole()
	{
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x1F2E3F8", Offset = "0x1F2E3F8", VA = "0x1F2E3F8")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x1F2E7DC", Offset = "0x1F2E7DC", VA = "0x1F2E7DC")]
	private void Start()
	{
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x1F2E7E0", Offset = "0x1F2E7E0", VA = "0x1F2E7E0")]
	private void HandleUnityLog(string logString, string trace, LogType logType)
	{
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x1F2EEEC", Offset = "0x1F2EEEC", VA = "0x1F2EEEC")]
	public static void ClearCommands()
	{
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x1F2EFD0", Offset = "0x1F2EFD0", VA = "0x1F2EFD0")]
	public bool RemoveCommand(string command)
	{
		return default(bool);
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x1F2F148", Offset = "0x1F2F148", VA = "0x1F2F148")]
	public static void SetDefaultCommand(Func<string, string> method, [Optional] string helpText)
	{
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x1F2F26C", Offset = "0x1F2F26C", VA = "0x1F2F26C")]
	public static bool AddCommand(string command, string description, Func<string, string> method, [Optional] string helpText)
	{
		return default(bool);
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x1F2F91C", Offset = "0x1F2F91C", VA = "0x1F2F91C")]
	public static string Eval(string command)
	{
		return null;
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x1F2FEAC", Offset = "0x1F2FEAC", VA = "0x1F2FEAC")]
	private static string ExtractParameters(string command, string root)
	{
		return null;
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x1F2F530", Offset = "0x1F2F530", VA = "0x1F2F530")]
	private static void SortCommands()
	{
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x1F2FFFC", Offset = "0x1F2FFFC", VA = "0x1F2FFFC")]
	public static List<string> GetSuggestions(string inputSoFar, bool includeDescription = false)
	{
		return null;
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x1F2E63C", Offset = "0x1F2E63C", VA = "0x1F2E63C")]
	public static string Color(string text, string colorCode)
	{
		return null;
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x1F30394", Offset = "0x1F30394", VA = "0x1F30394")]
	private static string SendOutputToListeners(string output)
	{
		return null;
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x1F2ECD0", Offset = "0x1F2ECD0", VA = "0x1F2ECD0")]
	public static string Print(string text)
	{
		return null;
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x1F30548", Offset = "0x1F30548", VA = "0x1F30548")]
	public static string print(string text)
	{
		return null;
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x1F305E8", Offset = "0x1F305E8", VA = "0x1F305E8")]
	private void LoadBuiltInCommands()
	{
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x1F305EC", Offset = "0x1F305EC", VA = "0x1F305EC")]
	private static string HelpConsoleCommand(string param)
	{
		return null;
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x1F30F48", Offset = "0x1F30F48", VA = "0x1F30F48")]
	public static string GetHelpList(bool includeDescription)
	{
		return null;
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x1F31714", Offset = "0x1F31714", VA = "0x1F31714")]
	private static string _003CSortCommands_003Em__2(KeyValuePair<string, GConsoleCommand> x)
	{
		return null;
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x1F317A0", Offset = "0x1F317A0", VA = "0x1F317A0")]
	private static string _003CSortCommands_003Em__3(KeyValuePair<string, GConsoleCommand> x)
	{
		return null;
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x1F3182C", Offset = "0x1F3182C", VA = "0x1F3182C")]
	private static GConsoleCommand _003CSortCommands_003Em__4(KeyValuePair<string, GConsoleCommand> x)
	{
		return null;
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x1F318B8", Offset = "0x1F318B8", VA = "0x1F318B8")]
	private static int _003CGetSuggestions_003Em__6(string c)
	{
		return default(int);
	}
}
