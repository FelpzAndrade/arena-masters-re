using System;
using Il2CppDummyDll;

[Token(Token = "0x2000856")]
public class XMatchMakingJoiner
{
	[Token(Token = "0x4002400")]
	[FieldOffset(Offset = "0x8")]
	private float m_bTimeOut;

	[Token(Token = "0x4002401")]
	[FieldOffset(Offset = "0xC")]
	private float m_bElapsedTime;

	[Token(Token = "0x4002402")]
	[FieldOffset(Offset = "0x10")]
	private bool m_bActive;

	[Token(Token = "0x4002403")]
	[FieldOffset(Offset = "0x11")]
	private bool m_bJoined;

	[Token(Token = "0x4002404")]
	[FieldOffset(Offset = "0x14")]
	private string m_strRoomName;

	[Token(Token = "0x4002405")]
	[FieldOffset(Offset = "0x18")]
	private DateTime nextTry;

	[Token(Token = "0x600451D")]
	[Address(RVA = "0x1E2D9D0", Offset = "0x1E2D9D0", VA = "0x1E2D9D0")]
	public XMatchMakingJoiner()
	{
	}

	[Token(Token = "0x600451E")]
	[Address(RVA = "0x1E2DAB0", Offset = "0x1E2DAB0", VA = "0x1E2DAB0")]
	public void Begin(string strRoomName)
	{
	}

	[Token(Token = "0x600451F")]
	[Address(RVA = "0x1E2DADC", Offset = "0x1E2DADC", VA = "0x1E2DADC")]
	public void SetActive(bool bActive)
	{
	}

	[Token(Token = "0x6004520")]
	[Address(RVA = "0x1E2DBE0", Offset = "0x1E2DBE0", VA = "0x1E2DBE0")]
	public void Update()
	{
	}

	[Token(Token = "0x6004521")]
	[Address(RVA = "0x1E2DD64", Offset = "0x1E2DD64", VA = "0x1E2DD64")]
	private void OnJoinTimeOut()
	{
	}

	[Token(Token = "0x6004522")]
	[Address(RVA = "0x1E2DFC4", Offset = "0x1E2DFC4", VA = "0x1E2DFC4", Slot = "4")]
	protected virtual void TryJoin()
	{
	}
}
