using System.Collections.Generic;
using ExitGames.Client.Photon;
using Il2CppDummyDll;

[Token(Token = "0x20002CB")]
public class WebRpcResponse
{
	[Token(Token = "0x4000EAC")]
	[FieldOffset(Offset = "0x8")]
	private string Name__BackingField;

	[Token(Token = "0x4000EAD")]
	[FieldOffset(Offset = "0xC")]
	private int ReturnCode__BackingField;

	[Token(Token = "0x4000EAE")]
	[FieldOffset(Offset = "0x10")]
	private string DebugMessage__BackingField;

	[Token(Token = "0x4000EAF")]
	[FieldOffset(Offset = "0x14")]
	private Dictionary<string, object> Parameters__BackingField;

	[Token(Token = "0x17000406")]
	public string Name
	{
		[Token(Token = "0x6001825")]
		[Address(RVA = "0x17B27BC", Offset = "0x17B27BC", VA = "0x17B27BC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001826")]
		[Address(RVA = "0x17B279C", Offset = "0x17B279C", VA = "0x17B279C")]
		private set
		{
		}
	}

	[Token(Token = "0x17000407")]
	public int ReturnCode
	{
		[Token(Token = "0x6001827")]
		[Address(RVA = "0x17B27C4", Offset = "0x17B27C4", VA = "0x17B27C4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001828")]
		[Address(RVA = "0x17B27A4", Offset = "0x17B27A4", VA = "0x17B27A4")]
		private set
		{
		}
	}

	[Token(Token = "0x17000408")]
	public string DebugMessage
	{
		[Token(Token = "0x6001829")]
		[Address(RVA = "0x17B27CC", Offset = "0x17B27CC", VA = "0x17B27CC")]
		get
		{
			return null;
		}
		[Token(Token = "0x600182A")]
		[Address(RVA = "0x17B27B4", Offset = "0x17B27B4", VA = "0x17B27B4")]
		private set
		{
		}
	}

	[Token(Token = "0x17000409")]
	public Dictionary<string, object> Parameters
	{
		[Token(Token = "0x600182B")]
		[Address(RVA = "0x17B27D4", Offset = "0x17B27D4", VA = "0x17B27D4")]
		get
		{
			return null;
		}
		[Token(Token = "0x600182C")]
		[Address(RVA = "0x17B27AC", Offset = "0x17B27AC", VA = "0x17B27AC")]
		private set
		{
		}
	}

	[Token(Token = "0x6001824")]
	[Address(RVA = "0x17B2550", Offset = "0x17B2550", VA = "0x17B2550")]
	public WebRpcResponse(OperationResponse response)
	{
	}

	[Token(Token = "0x600182D")]
	[Address(RVA = "0x17B27DC", Offset = "0x17B27DC", VA = "0x17B27DC")]
	public string ToStringFull()
	{
		return null;
	}
}
