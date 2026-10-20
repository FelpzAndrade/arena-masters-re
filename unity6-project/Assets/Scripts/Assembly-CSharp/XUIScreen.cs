using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D29")]
public class XUIScreen : MonoBehaviour
{
	[Token(Token = "0x4004351")]
	[FieldOffset(Offset = "0xC")]
	public float time;

	[Token(Token = "0x4004352")]
	[FieldOffset(Offset = "0x10")]
	public UITweener[] tweeners;

	[Token(Token = "0x4004353")]
	[FieldOffset(Offset = "0x14")]
	private XHelper.XIntervalUpdater m_timer;

	[Token(Token = "0x6006097")]
	[Address(RVA = "0x1920708", Offset = "0x1920708", VA = "0x1920708")]
	public XUIScreen()
	{
	}

	[Token(Token = "0x6006098")]
	[Address(RVA = "0x1920710", Offset = "0x1920710", VA = "0x1920710")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6006099")]
	[Address(RVA = "0x192084C", Offset = "0x192084C", VA = "0x192084C")]
	private void Update()
	{
	}

	[Token(Token = "0x600609A")]
	[Address(RVA = "0x1920860", Offset = "0x1920860", VA = "0x1920860")]
	private bool DisableFunc()
	{
		return default(bool);
	}
}
