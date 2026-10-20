using CS;
using Il2CppDummyDll;

[Token(Token = "0x2001001")]
public class XWidget_TierInfoTable : XUIBaseWidget
{
	[Token(Token = "0x4005575")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel lblTitle;

	[Token(Token = "0x4005576")]
	[FieldOffset(Offset = "0x20")]
	public XUITierInfo bronzeTierInfo;

	[Token(Token = "0x4005577")]
	[FieldOffset(Offset = "0x24")]
	public XUITierInfo silverTierInfo;

	[Token(Token = "0x4005578")]
	[FieldOffset(Offset = "0x28")]
	public XUITierInfo goldTierInfo;

	[Token(Token = "0x4005579")]
	[FieldOffset(Offset = "0x2C")]
	public XUITierInfo diaTierInfo;

	[Token(Token = "0x400557A")]
	[FieldOffset(Offset = "0x30")]
	public UILabel lblDesc;

	[Token(Token = "0x6007764")]
	[Address(RVA = "0x1B22EC8", Offset = "0x1B22EC8", VA = "0x1B22EC8")]
	public XWidget_TierInfoTable()
	{
	}

	[Token(Token = "0x6007765")]
	[Address(RVA = "0x1B1AE04", Offset = "0x1B1AE04", VA = "0x1B1AE04")]
	public void Show(CSProtoInfoManager_TrophyReward tropyReward)
	{
	}

	[Token(Token = "0x6007766")]
	[Address(RVA = "0x1B22ED0", Offset = "0x1B22ED0", VA = "0x1B22ED0")]
	private void SetTierInfo(CSProtoInfoManager_TrophyReward tropyReward, TierRank tierRank, string textKey, XUITierInfo tierInfoUI)
	{
	}

	[Token(Token = "0x6007767")]
	[Address(RVA = "0x1B23164", Offset = "0x1B23164", VA = "0x1B23164")]
	public void OnClick_Close()
	{
	}
}
