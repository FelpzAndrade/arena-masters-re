using Il2CppDummyDll;

[Token(Token = "0x20002B4")]
public class RaiseEventOptions
{
	[Token(Token = "0x4000E00")]
	[FieldOffset(Offset = "0x0")]
	public static readonly RaiseEventOptions Default;

	[Token(Token = "0x4000E01")]
	[FieldOffset(Offset = "0x8")]
	public EventCaching CachingOption;

	[Token(Token = "0x4000E02")]
	[FieldOffset(Offset = "0x9")]
	public byte InterestGroup;

	[Token(Token = "0x4000E03")]
	[FieldOffset(Offset = "0xC")]
	public int[] TargetActors;

	[Token(Token = "0x4000E04")]
	[FieldOffset(Offset = "0x10")]
	public ReceiverGroup Receivers;

	[Token(Token = "0x4000E05")]
	[FieldOffset(Offset = "0x11")]
	public byte SequenceChannel;

	[Token(Token = "0x4000E06")]
	[FieldOffset(Offset = "0x12")]
	public bool ForwardToWebhook;

	[Token(Token = "0x4000E07")]
	[FieldOffset(Offset = "0x13")]
	public bool Encrypt;

	[Token(Token = "0x600172A")]
	[Address(RVA = "0x20E94D8", Offset = "0x20E94D8", VA = "0x20E94D8")]
	public RaiseEventOptions()
	{
	}

	[Token(Token = "0x600172C")]
	[Address(RVA = "0x20EA158", Offset = "0x20EA158", VA = "0x20EA158")]
	public void Reset()
	{
	}
}
