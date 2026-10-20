using System;
using Il2CppDummyDll;

[Token(Token = "0x200080E")]
public class XNetProcess_NexonLogin : XNetProcessLoginBase
{
	[Token(Token = "0x400232B")]
	[FieldOffset(Offset = "0x35")]
	private bool m_bRequestUserInfo;

	[Token(Token = "0x400232C")]
	[FieldOffset(Offset = "0x36")]
	private bool m_bRequestSkuInfo;

	[Token(Token = "0x400232D")]
	[FieldOffset(Offset = "0x0")]
	private static Action _003C_003Ef__am_0024cache2;

	[Token(Token = "0x170008FB")]
	public override string Name
	{
		[Token(Token = "0x6004075")]
		[Address(RVA = "0x1EBDE4C", Offset = "0x1EBDE4C", VA = "0x1EBDE4C", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008FC")]
	public override bool IsProcessed
	{
		[Token(Token = "0x6004076")]
		[Address(RVA = "0x1EBDEC4", Offset = "0x1EBDEC4", VA = "0x1EBDEC4", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6004074")]
	[Address(RVA = "0x1EBDE44", Offset = "0x1EBDE44", VA = "0x1EBDE44")]
	public XNetProcess_NexonLogin()
	{
	}

	[Token(Token = "0x6004077")]
	[Address(RVA = "0x1EBE298", Offset = "0x1EBE298", VA = "0x1EBE298", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6004078")]
	[Address(RVA = "0x1EBE6A0", Offset = "0x1EBE6A0", VA = "0x1EBE6A0", Slot = "17")]
	public override void Update(float delta)
	{
	}

	[Token(Token = "0x6004079")]
	[Address(RVA = "0x1EBE6A4", Offset = "0x1EBE6A4", VA = "0x1EBE6A4", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}

	[Token(Token = "0x600407A")]
	[Address(RVA = "0x1EBEA88", Offset = "0x1EBEA88", VA = "0x1EBEA88")]
	private void _003CWork_003Em__1C3(string str)
	{
	}

	[Token(Token = "0x600407B")]
	[Address(RVA = "0x1EBEBC0", Offset = "0x1EBEBC0", VA = "0x1EBEBC0")]
	private void _003CHandleResponse_User_003Em__1C4()
	{
	}

	[Token(Token = "0x600407C")]
	[Address(RVA = "0x1EBEC70", Offset = "0x1EBEC70", VA = "0x1EBEC70")]
	private static void _003CHandleResponse_User_003Em__1C5()
	{
	}
}
