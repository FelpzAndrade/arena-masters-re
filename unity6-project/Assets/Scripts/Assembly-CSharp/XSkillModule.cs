using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000BAA")]
public abstract class XSkillModule
{
		protected XSkillModule()
		{
		}

	[Token(Token = "0x4003B4D")]
	[FieldOffset(Offset = "0x8")]
	protected XSkill skill;

	[Token(Token = "0x4003B4E")]
	[FieldOffset(Offset = "0xC")]
	protected XModuleEntity me;

	[Token(Token = "0x4003B4F")]
	[FieldOffset(Offset = "0x10")]
	protected CSSkillInfo m_SkillInfo;

	[Token(Token = "0x4003B50")]
	[FieldOffset(Offset = "0x14")]
	protected CSSkillInfo m_ParentSkillInfo;

	[Token(Token = "0x600546F")]
	[Address(RVA = "0x181E278", Offset = "0x181E278", VA = "0x181E278")]
	public XSkillModule(XSkill skill, XModuleEntity me, CSSkillInfo skillInfo, CSSkillInfo parentSkillInfo)
	{
	}

	[Token(Token = "0x6005470")]
	[Address(RVA = "0x181F744", Offset = "0x181F744", VA = "0x181F744", Slot = "4")]
	public virtual void OnInit()
	{
	}

	[Token(Token = "0x6005471")]
	[Address(RVA = "0x181F748", Offset = "0x181F748", VA = "0x181F748", Slot = "5")]
	public virtual void OnUpdate(float timeDelta)
	{
	}

	[Token(Token = "0x6005472")]
	[Address(RVA = "0x181E7AC", Offset = "0x181E7AC", VA = "0x181E7AC", Slot = "6")]
	public virtual void OnDestroy()
	{
	}

	[Token(Token = "0x6005473")]
	[Address(RVA = "0x181F74C", Offset = "0x181F74C", VA = "0x181F74C", Slot = "7")]
	public virtual void OnSkillStart(Vector3 pos, Quaternion dir)
	{
	}

	[Token(Token = "0x6005474")]
	[Address(RVA = "0x181F750", Offset = "0x181F750", VA = "0x181F750", Slot = "8")]
	public virtual void OnSkillFinished()
	{
	}

	[Token(Token = "0x6005475")]
	[Address(RVA = "0x181F754", Offset = "0x181F754", VA = "0x181F754", Slot = "9")]
	public virtual bool IsUsable()
	{
		return default(bool);
	}

	[Token(Token = "0x6005476")]
	[Address(RVA = "0x181F75C", Offset = "0x181F75C", VA = "0x181F75C", Slot = "10")]
	public virtual void OnCollision(GameObject goAttack)
	{
	}
}
