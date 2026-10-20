using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x200106F")]
public class XFPSRecorder : MonoSingleton<XFPSRecorder>
{
	[Token(Token = "0x40058BA")]
	[FieldOffset(Offset = "0xC")]
	private IFPSReporter m_reporter;

	[Token(Token = "0x40058BB")]
	[FieldOffset(Offset = "0x10")]
	private IncreasableDictionary<int> m_fpsCount;

	[Token(Token = "0x40058BC")]
	[FieldOffset(Offset = "0x14")]
	private float m_fUpdateInterval;

	[Token(Token = "0x40058BD")]
	[FieldOffset(Offset = "0x18")]
	private float m_fLastInterval;

	[Token(Token = "0x40058BE")]
	[FieldOffset(Offset = "0x1C")]
	private int m_nFrames;

	[Token(Token = "0x40058BF")]
	[FieldOffset(Offset = "0x20")]
	private int m_totalFrame;

	[Token(Token = "0x40058C0")]
	[FieldOffset(Offset = "0x24")]
	private float m_totalTime;

	[Token(Token = "0x40058C1")]
	[FieldOffset(Offset = "0x28")]
	private bool m_started;

	[Token(Token = "0x40058C2")]
	[FieldOffset(Offset = "0x2C")]
	private int m_startCount;

	[Token(Token = "0x40058C3")]
	[FieldOffset(Offset = "0x30")]
	private string m_revision;

	[Token(Token = "0x6007C16")]
	[Address(RVA = "0x19B42B0", Offset = "0x19B42B0", VA = "0x19B42B0")]
	public XFPSRecorder()
	{
	}

	[Token(Token = "0x6007C17")]
	[Address(RVA = "0x19B43BC", Offset = "0x19B43BC", VA = "0x19B43BC")]
	public void RegisterReporter(IFPSReporter reporter)
	{
	}

	[Token(Token = "0x6007C18")]
	[Address(RVA = "0x19B43C4", Offset = "0x19B43C4", VA = "0x19B43C4")]
	public void StartRecording()
	{
	}

	[Token(Token = "0x6007C19")]
	[Address(RVA = "0x19B44E8", Offset = "0x19B44E8", VA = "0x19B44E8")]
	public void Clear()
	{
	}

	[Token(Token = "0x6007C1A")]
	[Address(RVA = "0x19B4594", Offset = "0x19B4594", VA = "0x19B4594")]
	public void StopRecordingAndReport()
	{
	}

	[Token(Token = "0x6007C1B")]
	[Address(RVA = "0x19B4818", Offset = "0x19B4818", VA = "0x19B4818")]
	public Dictionary<string, string> Analyze()
	{
		return null;
	}

	[Token(Token = "0x6007C1C")]
	[Address(RVA = "0x19B5284", Offset = "0x19B5284", VA = "0x19B5284")]
	private void Update()
	{
	}
}
