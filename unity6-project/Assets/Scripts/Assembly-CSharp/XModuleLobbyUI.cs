using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x20003B7")]
public class XModuleLobbyUI : XModuleBase
{
	[Token(Token = "0x20003B8")]
	public class LobbyCharCreationDesc
	{
		[Token(Token = "0x400130A")]
		[FieldOffset(Offset = "0x8")]
		public bool isShowed;

		[Token(Token = "0x400130B")]
		[FieldOffset(Offset = "0xC")]
		public List<int> Skins;

		[Token(Token = "0x6001E71")]
		[Address(RVA = "0xB69C14", Offset = "0xB69C14", VA = "0xB69C14")]
		public LobbyCharCreationDesc(bool isShowed, List<int> skinList)
		{
		}
	}

	[Token(Token = "0x4001308")]
	[FieldOffset(Offset = "0x10")]
	private bool m_isShowed;

	[Token(Token = "0x4001309")]
	[FieldOffset(Offset = "0x14")]
	private List<int> m_Skins;

	[Token(Token = "0x1700050D")]
	public bool IsShowed
	{
		[Token(Token = "0x6001E6C")]
		[Address(RVA = "0xB34B1C", Offset = "0xB34B1C", VA = "0xB34B1C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001E6D")]
		[Address(RVA = "0xB69B34", Offset = "0xB69B34", VA = "0xB69B34")]
		set
		{
		}
	}

	[Token(Token = "0x1700050E")]
	public List<int> Skins
	{
		[Token(Token = "0x6001E6E")]
		[Address(RVA = "0xB34B14", Offset = "0xB34B14", VA = "0xB34B14")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001E6F")]
		[Address(RVA = "0xB69B3C", Offset = "0xB69B3C", VA = "0xB69B3C")]
		set
		{
		}
	}

	[Token(Token = "0x6001E6B")]
	[Address(RVA = "0xB69B24", Offset = "0xB69B24", VA = "0xB69B24")]
	public XModuleLobbyUI()
	{
	}

	[Token(Token = "0x6001E70")]
	[Address(RVA = "0xB69B44", Offset = "0xB69B44", VA = "0xB69B44")]
	public void InitLobbyChar(LobbyCharCreationDesc desc)
	{
	}
}
