using Il2CppDummyDll;

[Token(Token = "0x2000857")]
public class FriendPartyRoomJoiner
{
	[Token(Token = "0x4002406")]
	[FieldOffset(Offset = "0x8")]
	protected bool m_IsStandBy;

	[Token(Token = "0x4002407")]
	[FieldOffset(Offset = "0x9")]
	protected bool m_IsCreatedRoom;

	[Token(Token = "0x4002408")]
	[FieldOffset(Offset = "0xC")]
	protected string m_RoomUID;

	[Token(Token = "0x4002409")]
	[FieldOffset(Offset = "0x10")]
	protected Regulator m_regTimeOutUpdate;

	[Token(Token = "0x6004523")]
	[Address(RVA = "0x1F28014", Offset = "0x1F28014", VA = "0x1F28014")]
	public FriendPartyRoomJoiner()
	{
	}

	[Token(Token = "0x6004524")]
	[Address(RVA = "0x1F2813C", Offset = "0x1F2813C", VA = "0x1F2813C")]
	public void StandBy()
	{
	}

	[Token(Token = "0x6004525")]
	[Address(RVA = "0x1F281AC", Offset = "0x1F281AC", VA = "0x1F281AC")]
	public void CreatedRoomToJoin(string roomUID)
	{
	}

	[Token(Token = "0x6004526")]
	[Address(RVA = "0x1F28148", Offset = "0x1F28148", VA = "0x1F28148")]
	public void Start()
	{
	}

	[Token(Token = "0x6004527")]
	[Address(RVA = "0x1F281BC", Offset = "0x1F281BC", VA = "0x1F281BC")]
	private void DelayStart()
	{
	}

	[Token(Token = "0x6004528")]
	[Address(RVA = "0x1F282B0", Offset = "0x1F282B0", VA = "0x1F282B0")]
	public void Reset()
	{
	}

	[Token(Token = "0x6004529")]
	[Address(RVA = "0x1F28404", Offset = "0x1F28404", VA = "0x1F28404")]
	private void OnJoinTimeOut()
	{
	}

	[Token(Token = "0x600452A")]
	[Address(RVA = "0x1F28614", Offset = "0x1F28614", VA = "0x1F28614", Slot = "4")]
	protected virtual void TryJoin()
	{
	}

	[Token(Token = "0x600452B")]
	[Address(RVA = "0x1F2879C", Offset = "0x1F2879C", VA = "0x1F2879C")]
	internal void Update(float delta)
	{
	}

	[Token(Token = "0x600452C")]
	[Address(RVA = "0x1F287A0", Offset = "0x1F287A0", VA = "0x1F287A0")]
	private void UpdateTimeOut()
	{
	}
}
