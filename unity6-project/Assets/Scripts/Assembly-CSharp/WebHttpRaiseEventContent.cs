using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2000838")]
public class WebHttpRaiseEventContent
{
	[Token(Token = "0x400239F")]
	[FieldOffset(Offset = "0x8")]
	private string URI__BackingField;

	[Token(Token = "0x40023A0")]
	[FieldOffset(Offset = "0xC")]
	private int ContentCode__BackingField;

	[Token(Token = "0x40023A1")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<byte, object> DicContent__BackingField;

	[Token(Token = "0x40023A2")]
	[FieldOffset(Offset = "0x14")]
	private Dictionary<string, object> DicParams__BackingField;

	[Token(Token = "0x1700092E")]
	public string URI
	{
		[Token(Token = "0x60041D5")]
		[Address(RVA = "0x17B2490", Offset = "0x17B2490", VA = "0x17B2490")]
		get
		{
			return null;
		}
		[Token(Token = "0x60041D6")]
		[Address(RVA = "0x17B2254", Offset = "0x17B2254", VA = "0x17B2254")]
		private set
		{
		}
	}

	[Token(Token = "0x1700092F")]
	public int ContentCode
	{
		[Token(Token = "0x60041D7")]
		[Address(RVA = "0x17B2498", Offset = "0x17B2498", VA = "0x17B2498")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60041D8")]
		[Address(RVA = "0x17B225C", Offset = "0x17B225C", VA = "0x17B225C")]
		private set
		{
		}
	}

	[Token(Token = "0x17000930")]
	public Dictionary<byte, object> DicContent
	{
		[Token(Token = "0x60041D9")]
		[Address(RVA = "0x17B2264", Offset = "0x17B2264", VA = "0x17B2264")]
		get
		{
			return null;
		}
		[Token(Token = "0x60041DA")]
		[Address(RVA = "0x17B2244", Offset = "0x17B2244", VA = "0x17B2244")]
		private set
		{
		}
	}

	[Token(Token = "0x17000931")]
	public Dictionary<string, object> DicParams
	{
		[Token(Token = "0x60041DB")]
		[Address(RVA = "0x17B226C", Offset = "0x17B226C", VA = "0x17B226C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60041DC")]
		[Address(RVA = "0x17B224C", Offset = "0x17B224C", VA = "0x17B224C")]
		private set
		{
		}
	}

	[Token(Token = "0x60041D3")]
	[Address(RVA = "0x17B2094", Offset = "0x17B2094", VA = "0x17B2094")]
	public WebHttpRaiseEventContent(string _uri, int _ContentCode)
	{
	}

	[Token(Token = "0x60041D4")]
	[Address(RVA = "0x17B2274", Offset = "0x17B2274", VA = "0x17B2274")]
	public WebHttpRaiseEventContent(Dictionary<byte, object> _dicContent)
	{
	}

	[Token(Token = "0x60041DD")]
	[Address(RVA = "0x17B24A0", Offset = "0x17B24A0", VA = "0x17B24A0")]
	public void AddParam(string _key, object _data)
	{
	}

	[Token(Token = "0x60041DE")]
	[Address(RVA = "0x17B2548", Offset = "0x17B2548", VA = "0x17B2548")]
	public Dictionary<string, object> GetParams()
	{
		return null;
	}
}
