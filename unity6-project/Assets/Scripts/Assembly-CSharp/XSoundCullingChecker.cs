using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2000BB5")]
public class XSoundCullingChecker
{
	[Token(Token = "0x4003B95")]
	protected const float DUPLICATED_SOUND_IGNORE_TIME = 0.1f;

	[Token(Token = "0x4003B96")]
	[FieldOffset(Offset = "0x8")]
	protected Dictionary<string, float> m_NormalSoundPlayTimeStamps;

	[Token(Token = "0x4003B97")]
	[FieldOffset(Offset = "0xC")]
	protected Dictionary<string, float> m_MySoundPlayTimeStamps;

	[Token(Token = "0x60054B0")]
	[Address(RVA = "0x1825400", Offset = "0x1825400", VA = "0x1825400")]
	public XSoundCullingChecker()
	{
	}

	[Token(Token = "0x60054B1")]
	[Address(RVA = "0x18254C4", Offset = "0x18254C4", VA = "0x18254C4")]
	public bool Check(float fNowTime, string key, XSoundCullingType soundCullingType)
	{
		return default(bool);
	}

	[Token(Token = "0x60054B2")]
	[Address(RVA = "0x182563C", Offset = "0x182563C", VA = "0x182563C")]
	public void SetTime(string key, float fNowTime, XSoundCullingType soundCullingType)
	{
	}
}
