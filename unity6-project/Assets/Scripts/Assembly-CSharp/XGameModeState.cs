using System;
using Il2CppDummyDll;

[Token(Token = "0x200059C")]
public class XGameModeState
{
	[Token(Token = "0x4001B64")]
	[FieldOffset(Offset = "0x8")]
	protected XGameMode m_Owner;

	[Token(Token = "0x4001B65")]
	[FieldOffset(Offset = "0xC")]
	private Action m_enterStateAction;

	[Token(Token = "0x4001B66")]
	[FieldOffset(Offset = "0x10")]
	private bool OnFinished__BackingField;

	[Token(Token = "0x17000762")]
	public bool OnFinished
	{
		[Token(Token = "0x6002FFC")]
		[Address(RVA = "0x140681C", Offset = "0x140681C", VA = "0x140681C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002FFD")]
		[Address(RVA = "0x14138D8", Offset = "0x14138D8", VA = "0x14138D8")]
		set
		{
		}
	}

	[Token(Token = "0x6002FFB")]
	[Address(RVA = "0x14138D0", Offset = "0x14138D0", VA = "0x14138D0")]
	public XGameModeState()
	{
	}

	[Token(Token = "0x6002FFE")]
	[Address(RVA = "0x14138E0", Offset = "0x14138E0", VA = "0x14138E0", Slot = "4")]
	public virtual void SetGameMode(XGameMode owner)
	{
	}

	[Token(Token = "0x6002FFF")]
	[Address(RVA = "0x14138E8", Offset = "0x14138E8", VA = "0x14138E8", Slot = "5")]
	public virtual void Enter()
	{
	}

	[Token(Token = "0x6003000")]
	[Address(RVA = "0x14138EC", Offset = "0x14138EC", VA = "0x14138EC", Slot = "6")]
	public virtual void EnterDidFinished()
	{
	}

	[Token(Token = "0x6003001")]
	[Address(RVA = "0x14139B8", Offset = "0x14139B8", VA = "0x14139B8", Slot = "7")]
	public virtual void Update()
	{
	}

	[Token(Token = "0x6003002")]
	[Address(RVA = "0x14139BC", Offset = "0x14139BC", VA = "0x14139BC", Slot = "8")]
	public virtual void FixedUpdate()
	{
	}

	[Token(Token = "0x6003003")]
	[Address(RVA = "0x14139C0", Offset = "0x14139C0", VA = "0x14139C0", Slot = "9")]
	public virtual void Exit()
	{
	}

	[Token(Token = "0x6003004")]
	[Address(RVA = "0x14139C4", Offset = "0x14139C4", VA = "0x14139C4", Slot = "10")]
	public virtual bool CheckEnterable()
	{
		return default(bool);
	}

	[Token(Token = "0x6003005")]
	[Address(RVA = "0x14139CC", Offset = "0x14139CC", VA = "0x14139CC", Slot = "11")]
	public virtual bool CheckExitable()
	{
		return default(bool);
	}

	[Token(Token = "0x6003006")]
	[Address(RVA = "0x14139D4", Offset = "0x14139D4", VA = "0x14139D4", Slot = "12")]
	public virtual void OnApplicationPause(bool pauseStatus)
	{
	}

	[Token(Token = "0x6003007")]
	[Address(RVA = "0x14139D8", Offset = "0x14139D8", VA = "0x14139D8", Slot = "13")]
	public virtual bool OnMessage(IGameModeStateMessage msg)
	{
		return default(bool);
	}

	[Token(Token = "0x6003008")]
	[Address(RVA = "0x14139E0", Offset = "0x14139E0", VA = "0x14139E0", Slot = "14")]
	public virtual void OnBeforeFinish()
	{
	}

	[Token(Token = "0x6003009")]
	[Address(RVA = "0x1413B4C", Offset = "0x1413B4C", VA = "0x1413B4C", Slot = "15")]
	public virtual XGameModeStateType GetGameModeStateType()
	{
		return default(XGameModeStateType);
	}

	[Token(Token = "0x600300A")]
	public T GetOwner<T>() where T : XGameMode
	{
		return null;
	}

	[Token(Token = "0x600300B")]
	[Address(RVA = "0x1413B54", Offset = "0x1413B54", VA = "0x1413B54", Slot = "16")]
	public virtual void SetEnterStateAction(Action enterStateAction)
	{
	}

	[Token(Token = "0x600300C")]
	[Address(RVA = "0x1413B5C", Offset = "0x1413B5C", VA = "0x1413B5C")]
	public void EnterStateAction()
	{
	}

	[Token(Token = "0x600300D")]
	[Address(RVA = "0x1413B70", Offset = "0x1413B70", VA = "0x1413B70", Slot = "17")]
	public virtual void RespawnMyPlayer()
	{
	}

	[Token(Token = "0x600300E")]
	[Address(RVA = "0x1413C48", Offset = "0x1413C48", VA = "0x1413C48", Slot = "18")]
	public virtual void OnJoinPlayer(int nTargetPhotonID)
	{
	}

	[Token(Token = "0x600300F")]
	[Address(RVA = "0x14142C4", Offset = "0x14142C4", VA = "0x14142C4")]
	protected void InitPlayerTeam()
	{
	}

	[Token(Token = "0x6003010")]
	[Address(RVA = "0x14142C8", Offset = "0x14142C8", VA = "0x14142C8")]
	protected void RequestStartGameToServer()
	{
	}

	[Token(Token = "0x6003011")]
	[Address(RVA = "0x14143F0", Offset = "0x14143F0", VA = "0x14143F0")]
	protected void PreventInput()
	{
	}

	[Token(Token = "0x6003012")]
	[Address(RVA = "0x1406824", Offset = "0x1406824", VA = "0x1406824")]
	public void RequestFinishToPhoton()
	{
	}
}
