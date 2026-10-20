using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2000834")]
public class CustomRaiseEventError
{
	[Token(Token = "0x400236F")]
	[FieldOffset(Offset = "0x8")]
	private Dictionary<byte, object> DicContent__BackingField;

	[Token(Token = "0x1700092A")]
	public Dictionary<byte, object> DicContent
	{
		[Token(Token = "0x60041C2")]
		[Address(RVA = "0x1E60E90", Offset = "0x1E60E90", VA = "0x1E60E90")]
		get
		{
			return null;
		}
		[Token(Token = "0x60041C3")]
		[Address(RVA = "0x1E60E88", Offset = "0x1E60E88", VA = "0x1E60E88")]
		private set
		{
		}
	}

	[Token(Token = "0x60041C1")]
	[Address(RVA = "0x1E60DD0", Offset = "0x1E60DD0", VA = "0x1E60DD0")]
	public CustomRaiseEventError(Dictionary<byte, object> _dicContent)
	{
	}

	[Token(Token = "0x60041C4")]
	[Address(RVA = "0x1E60E98", Offset = "0x1E60E98", VA = "0x1E60E98")]
	public RaiseEventContentCode GetContentType()
	{
		return default(RaiseEventContentCode);
	}

	[Token(Token = "0x60041C5")]
	[Address(RVA = "0x1E60F7C", Offset = "0x1E60F7C", VA = "0x1E60F7C")]
	public string GetMessage()
	{
		return null;
	}

	[Token(Token = "0x60041C6")]
	[Address(RVA = "0x1E61194", Offset = "0x1E61194", VA = "0x1E61194")]
	public string GetI2LMessage()
	{
		return null;
	}
}
