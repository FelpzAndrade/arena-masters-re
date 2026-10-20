using System;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x200084B")]
public class XPhotonStats
{
	[Token(Token = "0x40023CF")]
	[FieldOffset(Offset = "0x8")]
	public string rpc;

	[Token(Token = "0x40023D0")]
	[FieldOffset(Offset = "0xC")]
	public int count;

	[Token(Token = "0x40023D1")]
	[FieldOffset(Offset = "0x10")]
	public int bytes;

	[Token(Token = "0x6004431")]
	[Address(RVA = "0xB264F0", Offset = "0xB264F0", VA = "0xB264F0")]
	public XPhotonStats()
	{
	}
}
