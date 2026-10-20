using System.Collections.Generic;
using BehaviorDesigner.Runtime;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x200043E")]
public class XModuleBT : XModuleBase
{
	[Token(Token = "0x40014B7")]
	[FieldOffset(Offset = "0x10")]
	private List<BehaviorTree> m_behaviorTrees;

	[Token(Token = "0x40014B8")]
	[FieldOffset(Offset = "0x14")]
	private XAIAgent m_agent;

	[Token(Token = "0x40014B9")]
	[FieldOffset(Offset = "0x18")]
	private bool m_actorEnable;

	[Token(Token = "0x40014BA")]
	[FieldOffset(Offset = "0x19")]
	private bool m_systemEnable;

	[Token(Token = "0x40014BB")]
	[FieldOffset(Offset = "0x1A")]
	private bool enableOnReady;

	[Token(Token = "0x60021E7")]
	[Address(RVA = "0xB44BAC", Offset = "0xB44BAC", VA = "0xB44BAC")]
	public XModuleBT()
	{
	}

	[Token(Token = "0x60021E8")]
	[Address(RVA = "0xB44C68", Offset = "0xB44C68", VA = "0xB44C68", Slot = "5")]
	public override void OnInit()
	{
	}

	[Token(Token = "0x60021E9")]
	[Address(RVA = "0xB44C90", Offset = "0xB44C90", VA = "0xB44C90")]
	public void InitComp()
	{
	}

	[Token(Token = "0x60021EA")]
	[Address(RVA = "0xB44DA0", Offset = "0xB44DA0", VA = "0xB44DA0", Slot = "17")]
	public override void OnActorInit(XModuleActor.CreationDesc actor)
	{
	}

	[Token(Token = "0x60021EB")]
	[Address(RVA = "0xB44DA4", Offset = "0xB44DA4", VA = "0xB44DA4", Slot = "23")]
	public override void OnActorChangeModel(CSCharacterInfo characterInfo, SkinInfo skinInfo)
	{
	}

	[Token(Token = "0x60021EC")]
	[Address(RVA = "0xB44DE0", Offset = "0xB44DE0", VA = "0xB44DE0")]
	public void SetBehavior(string path)
	{
	}

	[Token(Token = "0x60021ED")]
	[Address(RVA = "0xB450D0", Offset = "0xB450D0", VA = "0xB450D0")]
	public void SetBehavior(string[] paths)
	{
	}

	[Token(Token = "0x60021EE")]
	[Address(RVA = "0xB44F74", Offset = "0xB44F74", VA = "0xB44F74")]
	private void SetBehavior(ExternalBehavior behavior, int index = 0)
	{
	}

	[Token(Token = "0x60021EF")]
	[Address(RVA = "0xB452C4", Offset = "0xB452C4", VA = "0xB452C4", Slot = "19")]
	public override void OnActorReady()
	{
	}

	[Token(Token = "0x60021F0")]
	[Address(RVA = "0xB452DC", Offset = "0xB452DC", VA = "0xB452DC", Slot = "37")]
	public override void OnActorDie(ModuleEventArgument_Hit arg)
	{
	}

	[Token(Token = "0x60021F1")]
	[Address(RVA = "0xB452E8", Offset = "0xB452E8", VA = "0xB452E8", Slot = "16")]
	public override void OnActorRevive()
	{
	}

	[Token(Token = "0x60021F2")]
	[Address(RVA = "0xB452F4", Offset = "0xB452F4", VA = "0xB452F4")]
	public void ReserveEnableOnReady()
	{
	}

	[Token(Token = "0x60021F3")]
	[Address(RVA = "0xB45300", Offset = "0xB45300", VA = "0xB45300")]
	public void Enable()
	{
	}

	[Token(Token = "0x60021F4")]
	[Address(RVA = "0xB454E8", Offset = "0xB454E8", VA = "0xB454E8")]
	public bool Enabled()
	{
		return default(bool);
	}

	[Token(Token = "0x60021F5")]
	[Address(RVA = "0xB44DD4", Offset = "0xB44DD4", VA = "0xB44DD4")]
	public void SystemEnable()
	{
	}

	[Token(Token = "0x60021F6")]
	[Address(RVA = "0xB4550C", Offset = "0xB4550C", VA = "0xB4550C")]
	public void Disable()
	{
	}

	[Token(Token = "0x60021F7")]
	[Address(RVA = "0xB44D94", Offset = "0xB44D94", VA = "0xB44D94")]
	public void SystemDisable()
	{
	}

	[Token(Token = "0x60021F8")]
	[Address(RVA = "0xB4530C", Offset = "0xB4530C", VA = "0xB4530C")]
	private void UpdateBT()
	{
	}

	[Token(Token = "0x60021F9")]
	[Address(RVA = "0xB45518", Offset = "0xB45518", VA = "0xB45518")]
	public void ActorEnable()
	{
	}

	[Token(Token = "0x60021FA")]
	[Address(RVA = "0xB45524", Offset = "0xB45524", VA = "0xB45524")]
	public void ActorDisable()
	{
	}

	[Token(Token = "0x60021FB")]
	[Address(RVA = "0xB45530", Offset = "0xB45530", VA = "0xB45530", Slot = "45")]
	public override void OnHide()
	{
	}

	[Token(Token = "0x60021FC")]
	[Address(RVA = "0xB4553C", Offset = "0xB4553C", VA = "0xB4553C", Slot = "42")]
	public override void OnGamePause()
	{
	}

	[Token(Token = "0x60021FD")]
	[Address(RVA = "0xB45548", Offset = "0xB45548", VA = "0xB45548", Slot = "41")]
	public override void OnGameResume()
	{
	}

	[Token(Token = "0x60021FE")]
	[Address(RVA = "0xB45554", Offset = "0xB45554", VA = "0xB45554", Slot = "40")]
	public override void OnGameObjectDestroy()
	{
	}
}
