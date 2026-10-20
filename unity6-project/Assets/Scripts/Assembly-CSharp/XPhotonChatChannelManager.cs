using Il2CppDummyDll;

[Token(Token = "0x20003ED")]
public class XPhotonChatChannelManager
{
	[Token(Token = "0x600202A")]
	[Address(RVA = "0xADF7A0", Offset = "0xADF7A0", VA = "0xADF7A0")]
	public XPhotonChatChannelManager()
	{
	}

	[Token(Token = "0x600202B")]
	[Address(RVA = "0xADF7A8", Offset = "0xADF7A8", VA = "0xADF7A8")]
	public bool AnalyzeChannelInfo(string _channelName, out string _region, out string _Lang, out int _ChannelID)
	{
		_ChannelID = default;
		_Lang = default;
		_region = default;
		return default(bool);
	}

	[Token(Token = "0x600202C")]
	[Address(RVA = "0xADFB58", Offset = "0xADFB58", VA = "0xADFB58")]
	public int ParseChannelID(string ChannelName)
	{
		return default(int);
	}

	[Token(Token = "0x600202D")]
	[Address(RVA = "0xADFDC8", Offset = "0xADFDC8", VA = "0xADFDC8")]
	private string GetLanguage()
	{
		return null;
	}

	[Token(Token = "0x600202E")]
	[Address(RVA = "0xAE00C0", Offset = "0xAE00C0", VA = "0xAE00C0")]
	public string MakeChannelName(string region, string strLang, int changeChannelID)
	{
		return null;
	}

	[Token(Token = "0x600202F")]
	[Address(RVA = "0xAE036C", Offset = "0xAE036C", VA = "0xAE036C")]
	public string MakeNormalChannelName(int channel_id)
	{
		return null;
	}

	[Token(Token = "0x6002030")]
	[Address(RVA = "0xAE04B8", Offset = "0xAE04B8", VA = "0xAE04B8")]
	public string MakeClanChannelName(string region, string clanId)
	{
		return null;
	}

	[Token(Token = "0x6002031")]
	[Address(RVA = "0xAE07E4", Offset = "0xAE07E4", VA = "0xAE07E4")]
	public string MakeClanInviteChannelName(string region, string clanId)
	{
		return null;
	}

	[Token(Token = "0x6002032")]
	[Address(RVA = "0xAE0B10", Offset = "0xAE0B10", VA = "0xAE0B10")]
	public bool IsClanChannel(string channelName)
	{
		return default(bool);
	}

	[Token(Token = "0x6002033")]
	[Address(RVA = "0xAE0C5C", Offset = "0xAE0C5C", VA = "0xAE0C5C")]
	public bool IsClanInviteChannel(string channelName)
	{
		return default(bool);
	}

	[Token(Token = "0x6002034")]
	[Address(RVA = "0xAE0DA8", Offset = "0xAE0DA8", VA = "0xAE0DA8")]
	public bool IsNormalChannel(string channelName)
	{
		return default(bool);
	}

	[Token(Token = "0x6002035")]
	[Address(RVA = "0xAE0DD4", Offset = "0xAE0DD4", VA = "0xAE0DD4")]
	public ChannelState GetChannelState(string channelName)
	{
		return default(ChannelState);
	}

	[Token(Token = "0x6002036")]
	[Address(RVA = "0xAE0DFC", Offset = "0xAE0DFC", VA = "0xAE0DFC")]
	public bool GetLastChattingChannel(out string _lastChattingChannelName)
	{
		_lastChattingChannelName = default;
		return default(bool);
	}

	[Token(Token = "0x6002037")]
	[Address(RVA = "0xAE1024", Offset = "0xAE1024", VA = "0xAE1024")]
	public string GetDefaultNormalChannelName()
	{
		return null;
	}

	[Token(Token = "0x6002038")]
	[Address(RVA = "0xAE12AC", Offset = "0xAE12AC", VA = "0xAE12AC")]
	public int RecommendChannelId(int nPlayersInRoomsCount)
	{
		return default(int);
	}
}
