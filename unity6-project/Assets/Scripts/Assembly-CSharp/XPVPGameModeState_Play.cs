using CS;
using Il2CppDummyDll;

[Token(Token = "0x20005A7")]
public class XPVPGameModeState_Play : XGameModeState_Play
{
	[Token(Token = "0x20005A8")]
	private sealed class _003CSelectRandomPlayer_003Ec__AnonStorey11B
	{
		[Token(Token = "0x4001B80")]
		[FieldOffset(Offset = "0x8")]
		internal int ignoreChoosePhotonID;

		[Token(Token = "0x6003065")]
		[Address(RVA = "0x1C9A444", Offset = "0x1C9A444", VA = "0x1C9A444")]
		public _003CSelectRandomPlayer_003Ec__AnonStorey11B()
		{
		}

		[Token(Token = "0x6003066")]
		[Address(RVA = "0x1C9A9E4", Offset = "0x1C9A9E4", VA = "0x1C9A9E4")]
		internal bool _003C_003Em__115(XPlayer p)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6003060")]
	[Address(RVA = "0x1C8414C", Offset = "0x1C8414C", VA = "0x1C8414C")]
	public XPVPGameModeState_Play()
	{
	}

	[Token(Token = "0x6003061")]
	[Address(RVA = "0x1C9A170", Offset = "0x1C9A170", VA = "0x1C9A170", Slot = "12")]
	public override void OnApplicationPause(bool pauseStatus)
	{
	}

	[Token(Token = "0x6003062")]
	[Address(RVA = "0x1C9A2D0", Offset = "0x1C9A2D0", VA = "0x1C9A2D0")]
	protected int SelectRandomPlayer(int ignoreChoosePhotonID = -1)
	{
		return default(int);
	}

	[Token(Token = "0x6003063")]
	[Address(RVA = "0x1C9A44C", Offset = "0x1C9A44C", VA = "0x1C9A44C")]
	protected void RepositionAIPlayerOnStart()
	{
	}

	[Token(Token = "0x6003064")]
	[Address(RVA = "0x1C9A8D0", Offset = "0x1C9A8D0", VA = "0x1C9A8D0", Slot = "25")]
	public virtual void SetPlayerState(CSPlayerState state)
	{
	}
}
