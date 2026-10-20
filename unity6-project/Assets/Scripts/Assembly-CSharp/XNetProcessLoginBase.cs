using Il2CppDummyDll;

[Token(Token = "0x2000770")]
public abstract class XNetProcessLoginBase : XNetProcessBase
{
	[Token(Token = "0x40022FE")]
	[FieldOffset(Offset = "0x30")]
	protected float m_elapsedTime;

	[Token(Token = "0x40022FF")]
	[FieldOffset(Offset = "0x34")]
	protected bool m_networkLoadingIconOn;

	[Token(Token = "0x1700084D")]
	protected virtual float m_networkLoadingPanelDelay
	{
		[Token(Token = "0x6003C91")]
		[Address(RVA = "0x1ECCC50", Offset = "0x1ECCC50", VA = "0x1ECCC50", Slot = "18")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6003C90")]
	[Address(RVA = "0x1EB58E0", Offset = "0x1EB58E0", VA = "0x1EB58E0")]
	protected XNetProcessLoginBase()
	{
	}

	[Token(Token = "0x6003C92")]
	[Address(RVA = "0x1EB5F30", Offset = "0x1EB5F30", VA = "0x1EB5F30")]
	protected void ShowMessage(string text)
	{
	}

	[Token(Token = "0x6003C93")]
	[Address(RVA = "0x1ECCC5C", Offset = "0x1ECCC5C", VA = "0x1ECCC5C", Slot = "11")]
	protected sealed override void HandleResponse_Default()
	{
	}

	[Token(Token = "0x6003C94")]
	[Address(RVA = "0x1EB7614", Offset = "0x1EB7614", VA = "0x1EB7614", Slot = "17")]
	public override void Update(float delta)
	{
	}

	[Token(Token = "0x6003C95")]
	[Address(RVA = "0x1ECCF40", Offset = "0x1ECCF40", VA = "0x1ECCF40", Slot = "14")]
	public override void OnWorkFinish()
	{
	}

	[Token(Token = "0x6003C96")]
	[Address(RVA = "0x1ECD030", Offset = "0x1ECD030", VA = "0x1ECD030", Slot = "15")]
	protected override void OnTimeout()
	{
	}
}
