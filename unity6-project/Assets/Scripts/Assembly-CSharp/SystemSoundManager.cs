using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2000BB7")]
public class SystemSoundManager
{
	[Token(Token = "0x4003B9B")]
	[FieldOffset(Offset = "0x8")]
	private Queue<SystemSound> systemSoundQueue;

	[Token(Token = "0x4003B9C")]
	[FieldOffset(Offset = "0xC")]
	private SystemSound currentSound;

	[Token(Token = "0x4003B9D")]
	[FieldOffset(Offset = "0x18")]
	private bool isEnd;

	[Token(Token = "0x60054B3")]
	[Address(RVA = "0x1D49688", Offset = "0x1D49688", VA = "0x1D49688")]
	public SystemSoundManager()
	{
	}

	[Token(Token = "0x60054B4")]
	[Address(RVA = "0x1D49734", Offset = "0x1D49734", VA = "0x1D49734")]
	public void Start()
	{
	}

	[Token(Token = "0x60054B5")]
	[Address(RVA = "0x1D497C8", Offset = "0x1D497C8", VA = "0x1D497C8")]
	public void UpdateSystemSound(float time)
	{
	}

	[Token(Token = "0x60054B6")]
	[Address(RVA = "0x1D49B24", Offset = "0x1D49B24", VA = "0x1D49B24")]
	public void EnqueueSystemSound(string key, XSoundCullingType soundCullingType)
	{
	}

	[Token(Token = "0x60054B7")]
	[Address(RVA = "0x1D499B4", Offset = "0x1D499B4", VA = "0x1D499B4")]
	public void SystemSoundPlay(SystemSound systemSound)
	{
	}

	[Token(Token = "0x60054B8")]
	[Address(RVA = "0x1D49CAC", Offset = "0x1D49CAC", VA = "0x1D49CAC")]
	public void ClearQueue()
	{
	}
}
