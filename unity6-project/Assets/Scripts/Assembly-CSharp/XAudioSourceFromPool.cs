using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000BAF")]
public class XAudioSourceFromPool : MonoBehaviour
{
	[Token(Token = "0x4003B64")]
	[FieldOffset(Offset = "0xC")]
	private AudioSource m_audioSource_1;

	[Token(Token = "0x4003B65")]
	[FieldOffset(Offset = "0x10")]
	private AudioSource m_audioSource_2;

	[Token(Token = "0x17000C7E")]
	public AudioSource AudioSource_1
	{
		[Token(Token = "0x600549E")]
		[Address(RVA = "0x1EFD388", Offset = "0x1EFD388", VA = "0x1EFD388")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C7F")]
	public AudioSource AudioSource_2
	{
		[Token(Token = "0x600549F")]
		[Address(RVA = "0x1EFD390", Offset = "0x1EFD390", VA = "0x1EFD390")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600549D")]
	[Address(RVA = "0x1EFD380", Offset = "0x1EFD380", VA = "0x1EFD380")]
	public XAudioSourceFromPool()
	{
	}

	[Token(Token = "0x60054A0")]
	[Address(RVA = "0x1EFD398", Offset = "0x1EFD398", VA = "0x1EFD398")]
	public void Init()
	{
	}

	[Token(Token = "0x60054A1")]
	[Address(RVA = "0x1EFD4B8", Offset = "0x1EFD4B8", VA = "0x1EFD4B8")]
	public void Stop()
	{
	}
}
