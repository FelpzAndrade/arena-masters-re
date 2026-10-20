using System;
using CS;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x2000676")]
public sealed class ShowBoxInfo
{
	[Token(Token = "0x4001F0A")]
	[FieldOffset(Offset = "0x8")]
	public int nID;

	[Token(Token = "0x4001F0B")]
	[FieldOffset(Offset = "0xC")]
	public ShowBoxRewardType rewardType;

	[Token(Token = "0x4001F0C")]
	[FieldOffset(Offset = "0x10")]
	public ItemRarity min_grade;

	[Token(Token = "0x4001F0D")]
	[FieldOffset(Offset = "0x14")]
	public ItemRarity max_grade;

	[Token(Token = "0x4001F0E")]
	[FieldOffset(Offset = "0x18")]
	public string strCount;

	[Token(Token = "0x6003686")]
	[Address(RVA = "0x20F8C88", Offset = "0x20F8C88", VA = "0x20F8C88")]
	public ShowBoxInfo()
	{
	}
}
