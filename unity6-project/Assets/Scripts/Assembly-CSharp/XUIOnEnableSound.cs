using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2001044")]
public class XUIOnEnableSound : MonoBehaviour
{
	[Token(Token = "0x2001045")]
	public enum UIOnEnableSound
	{
		[Token(Token = "0x40057A7")]
		UIBattleVictory = 0,
		[Token(Token = "0x40057A8")]
		UIBattleReward = 1,
		[Token(Token = "0x40057A9")]
		None = 2
	}

	[Token(Token = "0x40057A3")]
	[FieldOffset(Offset = "0xC")]
	public UIOnEnableSound type;

	[Token(Token = "0x40057A4")]
	[FieldOffset(Offset = "0x10")]
	public string pathDirectly;

	[Token(Token = "0x40057A5")]
	[FieldOffset(Offset = "0x14")]
	public float delay;

	[Token(Token = "0x600796D")]
	[Address(RVA = "0x1905B98", Offset = "0x1905B98", VA = "0x1905B98")]
	public XUIOnEnableSound()
	{
	}

	[Token(Token = "0x600796E")]
	[Address(RVA = "0x1905C5C", Offset = "0x1905C5C", VA = "0x1905C5C")]
	private void Start()
	{
	}

	[Token(Token = "0x600796F")]
	[Address(RVA = "0x1905C60", Offset = "0x1905C60", VA = "0x1905C60")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x6007970")]
	[Address(RVA = "0x1905DDC", Offset = "0x1905DDC", VA = "0x1905DDC")]
	private void PlaySound()
	{
	}
}
