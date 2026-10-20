using Il2CppDummyDll;
using PigeonCoopToolkit.Utillities;
using UnityEngine;

[Token(Token = "0x200034C")]
public class PitchShifter : MonoBehaviour
{
	[Token(Token = "0x4001152")]
	[FieldOffset(Offset = "0xC")]
	public Range pitchRange;

	[Token(Token = "0x4001153")]
	[FieldOffset(Offset = "0x10")]
	public AudioSource src;

	[Token(Token = "0x6001BD7")]
	[Address(RVA = "0x1BB3584", Offset = "0x1BB3584", VA = "0x1BB3584")]
	public PitchShifter()
	{
	}

	[Token(Token = "0x6001BD8")]
	[Address(RVA = "0x1BB358C", Offset = "0x1BB358C", VA = "0x1BB358C")]
	private void Start()
	{
	}
}
