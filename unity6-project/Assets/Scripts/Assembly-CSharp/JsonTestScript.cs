using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000093")]
public class JsonTestScript
{
	[Token(Token = "0x4000276")]
	private const string BAD_RESULT_MESSAGE = "Incorrect Deserialized Result";

	[Token(Token = "0x4000277")]
	[FieldOffset(Offset = "0x8")]
	private TextMesh _text;

	[Token(Token = "0x60004B9")]
	[Address(RVA = "0xDD0520", Offset = "0xDD0520", VA = "0xDD0520")]
	public JsonTestScript(TextMesh text)
	{
	}

	[Token(Token = "0x60004BA")]
	[Address(RVA = "0xDD0540", Offset = "0xDD0540", VA = "0xDD0540")]
	public void SerializeVector3()
	{
	}

	[Token(Token = "0x60004BB")]
	[Address(RVA = "0xDD0EF8", Offset = "0xDD0EF8", VA = "0xDD0EF8")]
	public void GenericListSerialization()
	{
	}

	[Token(Token = "0x60004BC")]
	[Address(RVA = "0xDD14DC", Offset = "0xDD14DC", VA = "0xDD14DC")]
	public void PolymorphicSerialization()
	{
	}

	[Token(Token = "0x60004BD")]
	[Address(RVA = "0xDD1AC8", Offset = "0xDD1AC8", VA = "0xDD1AC8")]
	public void DictionarySerialization()
	{
	}

	[Token(Token = "0x60004BE")]
	[Address(RVA = "0xDD25D8", Offset = "0xDD25D8", VA = "0xDD25D8")]
	public void DictionaryObjectValueSerialization()
	{
	}

	[Token(Token = "0x60004BF")]
	[Address(RVA = "0xDD2A78", Offset = "0xDD2A78", VA = "0xDD2A78")]
	public void DictionaryObjectKeySerialization()
	{
	}

	[Token(Token = "0x60004C0")]
	[Address(RVA = "0xDD0E04", Offset = "0xDD0E04", VA = "0xDD0E04")]
	private void DisplaySuccess(string testName)
	{
	}

	[Token(Token = "0x60004C1")]
	[Address(RVA = "0xDD0B6C", Offset = "0xDD0B6C", VA = "0xDD0B6C")]
	private void DisplayFail(string testName, string reason)
	{
	}

	[Token(Token = "0x60004C2")]
	[Address(RVA = "0xDD0864", Offset = "0xDD0864", VA = "0xDD0864")]
	private void LogStart(string testName)
	{
	}

	[Token(Token = "0x60004C3")]
	[Address(RVA = "0xDD0EF4", Offset = "0xDD0EF4", VA = "0xDD0EF4")]
	private void LogEnd(int testNum)
	{
	}

	[Token(Token = "0x60004C4")]
	[Address(RVA = "0xDD3498", Offset = "0xDD3498", VA = "0xDD3498")]
	private void Log(object message)
	{
	}

	[Token(Token = "0x60004C5")]
	[Address(RVA = "0xDD0950", Offset = "0xDD0950", VA = "0xDD0950")]
	private void LogSerialized(string message)
	{
	}

	[Token(Token = "0x60004C6")]
	[Address(RVA = "0xDD0A54", Offset = "0xDD0A54", VA = "0xDD0A54")]
	private void LogResult(string shouldEqual, object actual)
	{
	}
}
