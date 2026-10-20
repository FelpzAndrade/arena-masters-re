using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000644")]
public class XProtoInfoManager_Abuse : CSProtoInfoManagerBase
{
	[Token(Token = "0x4001E1E")]
	[FieldOffset(Offset = "0x8")]
	private AbuseFilter m_AbuseFilter;

	[Token(Token = "0x4001E1F")]
	[FieldOffset(Offset = "0xC")]
	private bool m_loaded;

	[Token(Token = "0x60035D8")]
	[Address(RVA = "0x1C86288", Offset = "0x1C86288", VA = "0x1C86288")]
	public XProtoInfoManager_Abuse()
	{
	}

	[Token(Token = "0x60035D9")]
	[Address(RVA = "0x1C86B34", Offset = "0x1C86B34", VA = "0x1C86B34", Slot = "4")]
	public bool IsFrom(ProtoInfoFrom from)
	{
		return default(bool);
	}

	[Token(Token = "0x60035DA")]
	[Address(RVA = "0x1C86B44", Offset = "0x1C86B44", VA = "0x1C86B44", Slot = "6")]
	public void RemoveNotTagedContents(CSProtoInfoManagers protos)
	{
	}

	[Token(Token = "0x60035DB")]
	[Address(RVA = "0x1C86B48", Offset = "0x1C86B48", VA = "0x1C86B48", Slot = "5")]
	public bool Cooking(CSProtoInfoManagers protos)
	{
		return default(bool);
	}

	[Token(Token = "0x60035DC")]
	[Address(RVA = "0x1C86B50", Offset = "0x1C86B50", VA = "0x1C86B50", Slot = "7")]
	public bool LoadFromLocalFile(CSFileLoaderBase loader)
	{
		return default(bool);
	}

	[Token(Token = "0x60035DD")]
	[Address(RVA = "0x1C86EB8", Offset = "0x1C86EB8", VA = "0x1C86EB8")]
	public string GetAbuseFiltering(string val)
	{
		return null;
	}

	[Token(Token = "0x60035DE")]
	[Address(RVA = "0x1C86EE4", Offset = "0x1C86EE4", VA = "0x1C86EE4")]
	private void _003CLoadFromLocalFile_003Em__17A(XAbuse e)
	{
	}
}
