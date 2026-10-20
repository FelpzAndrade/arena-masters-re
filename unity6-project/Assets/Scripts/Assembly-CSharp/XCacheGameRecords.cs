using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2001078")]
public class XCacheGameRecords
{
	[Token(Token = "0x40058CA")]
	[FieldOffset(Offset = "0x8")]
	private Dictionary<KeyValuePair<MatchType, XGameModeType>, GameRecord> cache;

	[Token(Token = "0x6007C40")]
	[Address(RVA = "0x1A9A368", Offset = "0x1A9A368", VA = "0x1A9A368")]
	public XCacheGameRecords()
	{
	}

	[Token(Token = "0x6007C41")]
	[Address(RVA = "0x1A9A414", Offset = "0x1A9A414", VA = "0x1A9A414")]
	public void ClearCache(MatchType matchType, XGameModeType gameMode)
	{
	}

	[Token(Token = "0x6007C42")]
	[Address(RVA = "0x1A9A5FC", Offset = "0x1A9A5FC", VA = "0x1A9A5FC")]
	public void AddCache(MatchType matchType, XGameModeType gameMode, GameRecord record)
	{
	}

	[Token(Token = "0x6007C43")]
	[Address(RVA = "0x1A9A6F4", Offset = "0x1A9A6F4", VA = "0x1A9A6F4")]
	public GameRecord GetCache(MatchType matchType, XGameModeType gameMode)
	{
		return null;
	}

	[Token(Token = "0x6007C44")]
	[Address(RVA = "0x1A9A514", Offset = "0x1A9A514", VA = "0x1A9A514")]
	public bool ExistCache(MatchType matchType, XGameModeType gameMode)
	{
		return default(bool);
	}

	[Token(Token = "0x6007C45")]
	[Address(RVA = "0x1A9A7FC", Offset = "0x1A9A7FC", VA = "0x1A9A7FC")]
	public bool TryGetCacheValue(MatchType matchType, XGameModeType gameMode, GameRecordType recordType, out int value)
	{
		value = default;
		return default(bool);
	}

	[Token(Token = "0x6007C46")]
	[Address(RVA = "0x1A9A944", Offset = "0x1A9A944", VA = "0x1A9A944")]
	public void ClearAllCache()
	{
	}
}
