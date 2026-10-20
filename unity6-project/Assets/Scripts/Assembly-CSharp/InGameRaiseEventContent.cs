using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2000837")]
public class InGameRaiseEventContent
{
	[Token(Token = "0x400239C")]
	[FieldOffset(Offset = "0x8")]
	private int ContentCode__BackingField;

	[Token(Token = "0x400239D")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<byte, object> DicContent__BackingField;

	[Token(Token = "0x400239E")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<int, object> DicParams__BackingField;

	[Token(Token = "0x1700092B")]
	public int ContentCode
	{
		[Token(Token = "0x60041C9")]
		[Address(RVA = "0xD88D00", Offset = "0xD88D00", VA = "0xD88D00")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60041CA")]
		[Address(RVA = "0xD88BF4", Offset = "0xD88BF4", VA = "0xD88BF4")]
		private set
		{
		}
	}

	[Token(Token = "0x1700092C")]
	public Dictionary<byte, object> DicContent
	{
		[Token(Token = "0x60041CB")]
		[Address(RVA = "0xD88BFC", Offset = "0xD88BFC", VA = "0xD88BFC")]
		get
		{
			return null;
		}
		[Token(Token = "0x60041CC")]
		[Address(RVA = "0xD88BE4", Offset = "0xD88BE4", VA = "0xD88BE4")]
		private set
		{
		}
	}

	[Token(Token = "0x1700092D")]
	public Dictionary<int, object> DicParams
	{
		[Token(Token = "0x60041CD")]
		[Address(RVA = "0xD88C04", Offset = "0xD88C04", VA = "0xD88C04")]
		get
		{
			return null;
		}
		[Token(Token = "0x60041CE")]
		[Address(RVA = "0xD88BEC", Offset = "0xD88BEC", VA = "0xD88BEC")]
		private set
		{
		}
	}

	[Token(Token = "0x60041C7")]
	[Address(RVA = "0xD88A68", Offset = "0xD88A68", VA = "0xD88A68")]
	public InGameRaiseEventContent(int _ContentCode)
	{
	}

	[Token(Token = "0x60041C8")]
	[Address(RVA = "0xD88C0C", Offset = "0xD88C0C", VA = "0xD88C0C")]
	public InGameRaiseEventContent(Dictionary<byte, object> _dicContent)
	{
	}

	[Token(Token = "0x60041CF")]
	[Address(RVA = "0xD88D08", Offset = "0xD88D08", VA = "0xD88D08")]
	public void AddParam(int _key, object _data)
	{
	}

	[Token(Token = "0x60041D0")]
	[Address(RVA = "0xD88DB0", Offset = "0xD88DB0", VA = "0xD88DB0")]
	public Dictionary<int, object> GetParams()
	{
		return null;
	}

	[Token(Token = "0x60041D1")]
	[Address(RVA = "0xD88DB8", Offset = "0xD88DB8", VA = "0xD88DB8")]
	public bool GetParam(int key, out object objParam)
	{
		objParam = default;
		return default(bool);
	}

	[Token(Token = "0x60041D2")]
	[Address(RVA = "0xD88E60", Offset = "0xD88E60", VA = "0xD88E60")]
	public object GetParam(int key)
	{
		return null;
	}
}
