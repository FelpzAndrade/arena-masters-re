using Il2CppDummyDll;

[Token(Token = "0x20002B1")]
public enum EventCaching : byte
{
	[Token(Token = "0x4000DE3")]
	DoNotCache = 0,
	[Token(Token = "0x4000DE4")]
	MergeCache = 1,
	[Token(Token = "0x4000DE5")]
	ReplaceCache = 2,
	[Token(Token = "0x4000DE6")]
	RemoveCache = 3,
	[Token(Token = "0x4000DE7")]
	AddToRoomCache = 4,
	[Token(Token = "0x4000DE8")]
	AddToRoomCacheGlobal = 5,
	[Token(Token = "0x4000DE9")]
	RemoveFromRoomCache = 6,
	[Token(Token = "0x4000DEA")]
	RemoveFromRoomCacheForActorsLeft = 7,
	[Token(Token = "0x4000DEB")]
	SliceIncreaseIndex = 10,
	[Token(Token = "0x4000DEC")]
	SliceSetIndex = 11,
	[Token(Token = "0x4000DED")]
	SlicePurgeIndex = 12,
	[Token(Token = "0x4000DEE")]
	SlicePurgeUpToIndex = 13
}
