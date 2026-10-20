using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x20005AF")]
public class XGameModeStateMachine
{
	[Token(Token = "0x4001B92")]
	[FieldOffset(Offset = "0x8")]
	private XGameModeState m_CurrentState;

	[Token(Token = "0x4001B93")]
	[FieldOffset(Offset = "0xC")]
	private XGameModeStateType m_PreStateType;

	[Token(Token = "0x4001B94")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<int, XGameModeState> m_GameModeStateDictionary;

	// C# has no syntax for parameterized property 'Item'.
	// Its 'property:' attributes below are ignored by the compiler (CS0657).
	[property: Token(Token = "0x17000769")]
	[Token(Token = "0x6003094")]
	[Address(RVA = "0x13FBAA0", Offset = "0x13FBAA0", VA = "0x13FBAA0")]
	public XGameModeState get_Item(int nID)
	{
		return null;
	}

	[Token(Token = "0x6003091")]
	[Address(RVA = "0x141CBF4", Offset = "0x141CBF4", VA = "0x141CBF4")]
	public XGameModeStateMachine()
	{
	}

	[Token(Token = "0x6003092")]
	[Address(RVA = "0x13FB440", Offset = "0x13FB440", VA = "0x13FB440")]
	public void SetGameMode(XGameMode mode)
	{
	}

	[Token(Token = "0x6003093")]
	[Address(RVA = "0x141CCA8", Offset = "0x141CCA8", VA = "0x141CCA8")]
	public bool IsValid(int nID)
	{
		return default(bool);
	}

	[Token(Token = "0x6003095")]
	[Address(RVA = "0x141CD48", Offset = "0x141CD48", VA = "0x141CD48")]
	public XGameModeState Find(XGameModeStateType nGameModeStateType)
	{
		return null;
	}

	[Token(Token = "0x6003096")]
	[Address(RVA = "0x141CE04", Offset = "0x141CE04", VA = "0x141CE04")]
	public void Insert(int nID, XGameModeState gameModeState)
	{
	}

	[Token(Token = "0x6003097")]
	[Address(RVA = "0x141CEAC", Offset = "0x141CEAC", VA = "0x141CEAC")]
	public void Clear()
	{
	}

	[Token(Token = "0x6003098")]
	[Address(RVA = "0x1411190", Offset = "0x1411190", VA = "0x1411190")]
	public void SetCurrentState(XGameModeStateType nGameModeStateType)
	{
	}

	[Token(Token = "0x6003099")]
	[Address(RVA = "0x13FBF0C", Offset = "0x13FBF0C", VA = "0x13FBF0C")]
	public void Update()
	{
	}

	[Token(Token = "0x600309A")]
	[Address(RVA = "0x13FBF80", Offset = "0x13FBF80", VA = "0x13FBF80")]
	public void FixedUpdate()
	{
	}

	[Token(Token = "0x600309B")]
	[Address(RVA = "0x13FC0C4", Offset = "0x13FC0C4", VA = "0x13FC0C4")]
	public void OnApplicationPause(bool pauseStatus)
	{
	}

	[Token(Token = "0x600309C")]
	[Address(RVA = "0x13FC140", Offset = "0x13FC140", VA = "0x13FC140")]
	public bool OnMessage(IGameModeStateMessage msg)
	{
		return default(bool);
	}

	[Token(Token = "0x600309D")]
	[Address(RVA = "0x13FC1B8", Offset = "0x13FC1B8", VA = "0x13FC1B8")]
	public bool ChangeState(XGameModeStateType nNextStateType)
	{
		return default(bool);
	}

	[Token(Token = "0x600309E")]
	[Address(RVA = "0x13FDA60", Offset = "0x13FDA60", VA = "0x13FDA60")]
	public XGameModeStateType GetCurrentGameModeStateType()
	{
		return default(XGameModeStateType);
	}

	[Token(Token = "0x600309F")]
	[Address(RVA = "0x13FCD44", Offset = "0x13FCD44", VA = "0x13FCD44")]
	public XGameModeState GetCurrentGameModeState()
	{
		return null;
	}

	[Token(Token = "0x60030A0")]
	[Address(RVA = "0x13FE610", Offset = "0x13FE610", VA = "0x13FE610")]
	public XGameModeStateType GetPreGameModeStateType()
	{
		return default(XGameModeStateType);
	}

	[Token(Token = "0x60030A1")]
	public T GetCurrentState<T>() where T : XGameModeState
	{
		return null;
	}
}
