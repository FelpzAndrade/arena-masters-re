using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

[Token(Token = "0x2000771")]
public abstract class XNetProcess_GameBase : XNetProcessBase
{
	[Token(Token = "0x4002300")]
	[FieldOffset(Offset = "0x30")]
	protected float m_elapsedTime;

	[Token(Token = "0x1700084E")]
	public virtual bool showLoadingIcon
	{
		[Token(Token = "0x6003C98")]
		[Address(RVA = "0x2139410", Offset = "0x2139410", VA = "0x2139410", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700084F")]
	public virtual float networkLoadingPanelDelay
	{
		[Token(Token = "0x6003C99")]
		[Address(RVA = "0x2139418", Offset = "0x2139418", VA = "0x2139418", Slot = "19")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6003C97")]
	[Address(RVA = "0x2125800", Offset = "0x2125800", VA = "0x2125800")]
	protected XNetProcess_GameBase()
	{
	}

	[Token(Token = "0x6003C9A")]
	[Address(RVA = "0x2125A5C", Offset = "0x2125A5C", VA = "0x2125A5C", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003C9B")]
	[Address(RVA = "0x2139420", Offset = "0x2139420", VA = "0x2139420", Slot = "14")]
	public override void OnWorkFinish()
	{
	}

	[Token(Token = "0x6003C9C")]
	[Address(RVA = "0x213950C", Offset = "0x213950C", VA = "0x213950C", Slot = "17")]
	public override void Update(float delta)
	{
	}

	[Token(Token = "0x6003C9D")]
	[Address(RVA = "0x21396BC", Offset = "0x21396BC", VA = "0x21396BC", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003C9E")]
	[Address(RVA = "0x21397E0", Offset = "0x21397E0", VA = "0x21397E0", Slot = "11")]
	protected sealed override void HandleResponse_Default()
	{
	}

	[Token(Token = "0x6003C9F")]
	[Address(RVA = "0x2139E8C", Offset = "0x2139E8C", VA = "0x2139E8C")]
	public static string GetCookie(string seed)
	{
		return null;
	}

	[Token(Token = "0x6003CA0")]
	[Address(RVA = "0x213A274", Offset = "0x213A274", VA = "0x213A274", Slot = "15")]
	protected override void OnTimeout()
	{
	}

	[Token(Token = "0x6003CA1")]
	[Address(RVA = "0x213A5E0", Offset = "0x213A5E0", VA = "0x213A5E0")]
	private void _003COnTimeout_003Em__9A(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
	{
	}
}
