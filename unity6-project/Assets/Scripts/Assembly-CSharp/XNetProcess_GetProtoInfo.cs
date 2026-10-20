using Il2CppDummyDll;

[Token(Token = "0x200080F")]
public class XNetProcess_GetProtoInfo : XNetProcessLoginBase
{
	[Token(Token = "0x400232E")]
	[FieldOffset(Offset = "0x35")]
	private bool m_bDataLoadedFail;

	[Token(Token = "0x400232F")]
	[FieldOffset(Offset = "0x36")]
	private bool m_bDataLoaded;

	[Token(Token = "0x170008FD")]
	public override string Name
	{
		[Token(Token = "0x600407E")]
		[Address(RVA = "0x21411DC", Offset = "0x21411DC", VA = "0x21411DC", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008FE")]
	public override bool IsProcessed
	{
		[Token(Token = "0x600407F")]
		[Address(RVA = "0x2141254", Offset = "0x2141254", VA = "0x2141254", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600407D")]
	[Address(RVA = "0x21410B0", Offset = "0x21410B0", VA = "0x21410B0")]
	public XNetProcess_GetProtoInfo()
	{
	}

	[Token(Token = "0x6004080")]
	[Address(RVA = "0x2141278", Offset = "0x2141278", VA = "0x2141278", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6004081")]
	[Address(RVA = "0x2141E40", Offset = "0x2141E40", VA = "0x2141E40", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}

	[Token(Token = "0x6004082")]
	[Address(RVA = "0x2141F08", Offset = "0x2141F08", VA = "0x2141F08", Slot = "17")]
	public override void Update(float delta)
	{
	}

	[Token(Token = "0x6004083")]
	[Address(RVA = "0x2141448", Offset = "0x2141448", VA = "0x2141448")]
	private void LoadInfoFromServer()
	{
	}

	[Token(Token = "0x6004084")]
	[Address(RVA = "0x2141F1C", Offset = "0x2141F1C", VA = "0x2141F1C")]
	private void DataPatchFail(GameDataPatcher.PatchResult result, string errMsg)
	{
	}

	[Token(Token = "0x6004085")]
	[Address(RVA = "0x214177C", Offset = "0x214177C", VA = "0x214177C")]
	private void LoadServerInfoFromLocalFile()
	{
	}

	[Token(Token = "0x6004086")]
	[Address(RVA = "0x21421E8", Offset = "0x21421E8", VA = "0x21421E8")]
	private void AfterDataLoad()
	{
	}

	[Token(Token = "0x6004087")]
	[Address(RVA = "0x214258C", Offset = "0x214258C", VA = "0x214258C")]
	protected void Timeout(float _delta)
	{
	}

	[Token(Token = "0x6004088")]
	[Address(RVA = "0x21425D0", Offset = "0x21425D0", VA = "0x21425D0")]
	private void _003CLoadInfoFromServer_003Em__1C6()
	{
	}
}
