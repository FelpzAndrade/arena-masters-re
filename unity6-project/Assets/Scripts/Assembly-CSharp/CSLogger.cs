using CS;
using Il2CppDummyDll;

// Reconstruido a partir do pseudo-C (Ghidra) de libil2cpp.so.
[Token(Token = "0x200106E")]
public class CSLogger : CSLoggerInterface
{
	[Token(Token = "0x6007C11")]
	[Address(RVA = "0x21F1E88", Offset = "0x21F1E88", VA = "0x21F1E88")]
	public CSLogger()
	{
	}

	[Token(Token = "0x6007C12")]
	[Address(RVA = "0x21F1E90", Offset = "0x21F1E90", VA = "0x21F1E90", Slot = "4")]
	public void Debug(string text)
	{
		UnityEngine.Debug.Log(text);
	}

	[Token(Token = "0x6007C13")]
	[Address(RVA = "0x21F1F38", Offset = "0x21F1F38", VA = "0x21F1F38", Slot = "5")]
	public void Info(string text)
	{
		UnityEngine.Debug.Log(text);
	}

	[Token(Token = "0x6007C14")]
	[Address(RVA = "0x21F1FE0", Offset = "0x21F1FE0", VA = "0x21F1FE0", Slot = "6")]
	public void Warning(string text)
	{
		UnityEngine.Debug.LogWarning(text);
	}

	[Token(Token = "0x6007C15")]
	[Address(RVA = "0x21F2088", Offset = "0x21F2088", VA = "0x21F2088", Slot = "7")]
	public void Error(string text)
	{
		UnityEngine.Debug.LogError(text);
	}
}
