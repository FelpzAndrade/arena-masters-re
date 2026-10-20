using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x20002D3")]
public class PhotonStreamQueue
{
	[Token(Token = "0x4000EF8")]
	[FieldOffset(Offset = "0x8")]
	private int m_SampleRate;

	[Token(Token = "0x4000EF9")]
	[FieldOffset(Offset = "0xC")]
	private int m_SampleCount;

	[Token(Token = "0x4000EFA")]
	[FieldOffset(Offset = "0x10")]
	private int m_ObjectsPerSample;

	[Token(Token = "0x4000EFB")]
	[FieldOffset(Offset = "0x14")]
	private float m_LastSampleTime;

	[Token(Token = "0x4000EFC")]
	[FieldOffset(Offset = "0x18")]
	private int m_LastFrameCount;

	[Token(Token = "0x4000EFD")]
	[FieldOffset(Offset = "0x1C")]
	private int m_NextObjectIndex;

	[Token(Token = "0x4000EFE")]
	[FieldOffset(Offset = "0x20")]
	private List<object> m_Objects;

	[Token(Token = "0x4000EFF")]
	[FieldOffset(Offset = "0x24")]
	private bool m_IsWriting;

	[Token(Token = "0x600191C")]
	[Address(RVA = "0x1B806A0", Offset = "0x1B806A0", VA = "0x1B806A0")]
	public PhotonStreamQueue(int sampleRate)
	{
	}

	[Token(Token = "0x600191D")]
	[Address(RVA = "0x1B9EB40", Offset = "0x1B9EB40", VA = "0x1B9EB40")]
	private void BeginWritePackage()
	{
	}

	[Token(Token = "0x600191E")]
	[Address(RVA = "0x1B80F30", Offset = "0x1B80F30", VA = "0x1B80F30")]
	public void Reset()
	{
	}

	[Token(Token = "0x600191F")]
	[Address(RVA = "0x1B822FC", Offset = "0x1B822FC", VA = "0x1B822FC")]
	public void SendNext(object obj)
	{
	}

	[Token(Token = "0x6001920")]
	[Address(RVA = "0x1B823D4", Offset = "0x1B823D4", VA = "0x1B823D4")]
	public bool HasQueuedObjects()
	{
		return default(bool);
	}

	[Token(Token = "0x6001921")]
	[Address(RVA = "0x1B823E8", Offset = "0x1B823E8", VA = "0x1B823E8")]
	public object ReceiveNext()
	{
		return null;
	}

	[Token(Token = "0x6001922")]
	[Address(RVA = "0x1B83708", Offset = "0x1B83708", VA = "0x1B83708")]
	public void Serialize(PhotonStream stream)
	{
	}

	[Token(Token = "0x6001923")]
	[Address(RVA = "0x1B83900", Offset = "0x1B83900", VA = "0x1B83900")]
	public void Deserialize(PhotonStream stream)
	{
	}
}
