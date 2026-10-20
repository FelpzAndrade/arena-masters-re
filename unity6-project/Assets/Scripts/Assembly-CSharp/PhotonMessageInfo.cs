using Il2CppDummyDll;

[Token(Token = "0x20002C7")]
public struct PhotonMessageInfo
{
	[Token(Token = "0x4000E99")]
	[FieldOffset(Offset = "0x0")]
	private readonly int timeInt;

	[Token(Token = "0x4000E9A")]
	[FieldOffset(Offset = "0x4")]
	public readonly PhotonPlayer sender;

	[Token(Token = "0x4000E9B")]
	[FieldOffset(Offset = "0x8")]
	public readonly PhotonView photonView;

	[Token(Token = "0x17000400")]
	public double timestamp
	{
		[Token(Token = "0x600180A")]
		[Address(RVA = "0x1B88430", Offset = "0x1B88430", VA = "0x1B88430")]
		get
		{
			return default(double);
		}
	}

	[Token(Token = "0x6001809")]
	[Address(RVA = "0x1B8841C", Offset = "0x1B8841C", VA = "0x1B8841C")]
	public PhotonMessageInfo(PhotonPlayer player, int timestamp, PhotonView view)
	{
		this = default;
	}

	[Token(Token = "0x600180B")]
	[Address(RVA = "0x1B88564", Offset = "0x1B88564", VA = "0x1B88564", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
