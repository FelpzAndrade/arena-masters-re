using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000BBC")]
public class AudioSources
{
	[Token(Token = "0x4003BC8")]
	[FieldOffset(Offset = "0x8")]
	private Dictionary<int, AudioSource> m_sources;

	[Token(Token = "0x60054EE")]
	[Address(RVA = "0x20BD62C", Offset = "0x20BD62C", VA = "0x20BD62C")]
	public AudioSources()
	{
	}

	[Token(Token = "0x60054EF")]
	[Address(RVA = "0x20BD6D8", Offset = "0x20BD6D8", VA = "0x20BD6D8")]
	public AudioSource GetSource(int type, GameObject parent)
	{
		return null;
	}

	[Token(Token = "0x60054F0")]
	[Address(RVA = "0x20BD824", Offset = "0x20BD824", VA = "0x20BD824")]
	public void Stop()
	{
	}
}
