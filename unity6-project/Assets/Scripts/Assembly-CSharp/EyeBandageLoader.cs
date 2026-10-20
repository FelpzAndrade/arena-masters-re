using Il2CppDummyDll;

[Token(Token = "0x20004BB")]
public class EyeBandageLoader : MonoSingleton<EyeBandageLoader>
{
	[Token(Token = "0x4001789")]
	[FieldOffset(Offset = "0xC")]
	public string PrefabPath;

	[Token(Token = "0x400178A")]
	[FieldOffset(Offset = "0x10")]
	private EyeBandage m_eyeBandage;

	[Token(Token = "0x1700066D")]
	public EyeBandage eyeBandage
	{
		[Token(Token = "0x60028B6")]
		[Address(RVA = "0x1E822C8", Offset = "0x1E822C8", VA = "0x1E822C8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60028B5")]
	[Address(RVA = "0x1E821F8", Offset = "0x1E821F8", VA = "0x1E821F8")]
	public EyeBandageLoader()
	{
	}

	[Token(Token = "0x60028B7")]
	[Address(RVA = "0x1E82388", Offset = "0x1E82388", VA = "0x1E82388")]
	private void LoadEyeBandage()
	{
	}
}
