using Il2CppDummyDll;

[Token(Token = "0x20004B9")]
public class BlindEffectLoader : MonoSingleton<BlindEffectLoader>
{
	[Token(Token = "0x4001776")]
	[FieldOffset(Offset = "0xC")]
	public string effectPrefabPath;

	[Token(Token = "0x4001777")]
	[FieldOffset(Offset = "0x10")]
	private EyeBandage m_blind;

	[Token(Token = "0x1700066C")]
	public EyeBandage blind
	{
		[Token(Token = "0x60028A4")]
		[Address(RVA = "0x20C067C", Offset = "0x20C067C", VA = "0x20C067C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60028A3")]
	[Address(RVA = "0x20C05AC", Offset = "0x20C05AC", VA = "0x20C05AC")]
	public BlindEffectLoader()
	{
	}

	[Token(Token = "0x60028A5")]
	[Address(RVA = "0x20C073C", Offset = "0x20C073C", VA = "0x20C073C")]
	private void LoadBlindEffect()
	{
	}
}
