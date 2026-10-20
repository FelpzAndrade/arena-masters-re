using CS;
using Il2CppDummyDll;

[Token(Token = "0x20003A8")]
public class XServerPartySyncChecker
{
	[Token(Token = "0x40012EC")]
	[FieldOffset(Offset = "0x8")]
	private CharPartyData m_ServerSyncingCharPartyData;

	[Token(Token = "0x6001E15")]
	[Address(RVA = "0x181C65C", Offset = "0x181C65C", VA = "0x181C65C")]
	public XServerPartySyncChecker()
	{
	}

	[Token(Token = "0x6001E16")]
	[Address(RVA = "0x181C6F8", Offset = "0x181C6F8", VA = "0x181C6F8")]
	public bool IsChanged(CharPartyData charPartyData)
	{
		return default(bool);
	}

	[Token(Token = "0x6001E17")]
	[Address(RVA = "0x181C86C", Offset = "0x181C86C", VA = "0x181C86C")]
	public void Sync(CharPartyData charPartyData)
	{
	}
}
