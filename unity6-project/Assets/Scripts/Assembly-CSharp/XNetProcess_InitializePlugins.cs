using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

[Token(Token = "0x2000804")]
public class XNetProcess_InitializePlugins : XNetProcessLoginBase
{
	[Token(Token = "0x400231A")]
	[FieldOffset(Offset = "0x0")]
	private static NetCallback _003C_003Ef__am_0024cache0;

	[Token(Token = "0x170008EE")]
	public override string Name
	{
		[Token(Token = "0x6004029")]
		[Address(RVA = "0x1EB7568", Offset = "0x1EB7568", VA = "0x1EB7568", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008EF")]
	public override bool IsProcessed
	{
		[Token(Token = "0x600402A")]
		[Address(RVA = "0x1EB75E0", Offset = "0x1EB75E0", VA = "0x1EB75E0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6004028")]
	[Address(RVA = "0x1EB7560", Offset = "0x1EB7560", VA = "0x1EB7560")]
	public XNetProcess_InitializePlugins()
	{
	}

	[Token(Token = "0x600402B")]
	[Address(RVA = "0x1EB75E8", Offset = "0x1EB75E8", VA = "0x1EB75E8", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x600402C")]
	[Address(RVA = "0x1EB7610", Offset = "0x1EB7610", VA = "0x1EB7610", Slot = "17")]
	public override void Update(float delta)
	{
	}

	[Token(Token = "0x600402D")]
	[Address(RVA = "0x1EB776C", Offset = "0x1EB776C", VA = "0x1EB776C", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}

	[Token(Token = "0x600402E")]
	[Address(RVA = "0x1EB7914", Offset = "0x1EB7914", VA = "0x1EB7914")]
	private static void _003CHandleResponse_User_003Em__1B7(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
	{
	}
}
