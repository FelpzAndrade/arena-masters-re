using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000451")]
public class XModuleAttackInfo : XModuleBase
{
	[Token(Token = "0x400153F")]
	[FieldOffset(Offset = "0x10")]
	private CSCharacterInfo m_CharacterInfo;

	[Token(Token = "0x4001540")]
	[FieldOffset(Offset = "0x14")]
	private XSkill m_skill;

	[Token(Token = "0x4001541")]
	[FieldOffset(Offset = "0x18")]
	private XModuleEntity m_ownerObject;

	[Token(Token = "0x4001542")]
	[FieldOffset(Offset = "0x1C")]
	private XModuleEntity m_targetObject;

	[Token(Token = "0x4001543")]
	[FieldOffset(Offset = "0x20")]
	private uint m_ColUID;

	[Token(Token = "0x4001544")]
	[FieldOffset(Offset = "0x24")]
	private Vector3 m_colPos;

	[Token(Token = "0x170005FC")]
	public uint ColUID
	{
		[Token(Token = "0x6002345")]
		[Address(RVA = "0xB443A8", Offset = "0xB443A8", VA = "0xB443A8")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x170005FD")]
	public CSCharacterInfo CharacterInfo
	{
		[Token(Token = "0x6002347")]
		[Address(RVA = "0xB44434", Offset = "0xB44434", VA = "0xB44434")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005FE")]
	public XModuleActor Character
	{
		[Token(Token = "0x6002348")]
		[Address(RVA = "0xB4443C", Offset = "0xB4443C", VA = "0xB4443C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005FF")]
	public XSkill Skill
	{
		[Token(Token = "0x6002349")]
		[Address(RVA = "0xB44518", Offset = "0xB44518", VA = "0xB44518")]
		get
		{
			return null;
		}
		[Token(Token = "0x600234A")]
		[Address(RVA = "0xB44520", Offset = "0xB44520", VA = "0xB44520")]
		set
		{
		}
	}

	[Token(Token = "0x17000600")]
	public CSSkillInfo SkillInfo
	{
		[Token(Token = "0x600234B")]
		[Address(RVA = "0xB44408", Offset = "0xB44408", VA = "0xB44408")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000601")]
	public XModuleEntity TargetObject
	{
		[Token(Token = "0x600234D")]
		[Address(RVA = "0xB44530", Offset = "0xB44530", VA = "0xB44530")]
		get
		{
			return null;
		}
		[Token(Token = "0x600234C")]
		[Address(RVA = "0xB44528", Offset = "0xB44528", VA = "0xB44528")]
		set
		{
		}
	}

	[Token(Token = "0x600233F")]
	[Address(RVA = "0xB4435C", Offset = "0xB4435C", VA = "0xB4435C")]
	public XModuleAttackInfo()
	{
	}

	[Token(Token = "0x6002340")]
	[Address(RVA = "0xB4436C", Offset = "0xB4436C", VA = "0xB4436C")]
	public void SetColPos(Vector3 pos)
	{
	}

	[Token(Token = "0x6002341")]
	[Address(RVA = "0xB44378", Offset = "0xB44378", VA = "0xB44378")]
	public Vector3 GetColPos()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6002342")]
	[Address(RVA = "0xB4438C", Offset = "0xB4438C", VA = "0xB4438C")]
	public XModuleEntity GetOwnerObject()
	{
		return null;
	}

	[Token(Token = "0x6002343")]
	[Address(RVA = "0xB44394", Offset = "0xB44394", VA = "0xB44394")]
	public void Init(CSCharacterInfo characterInfo, XSkill skill, XModuleEntity ownerObject)
	{
	}

	[Token(Token = "0x6002344")]
	[Address(RVA = "0xB443A0", Offset = "0xB443A0", VA = "0xB443A0")]
	public void SetColUID(uint uid)
	{
	}

	[Token(Token = "0x6002346")]
	[Address(RVA = "0xB443B0", Offset = "0xB443B0", VA = "0xB443B0")]
	public void OnCollision()
	{
	}

	[Token(Token = "0x600234E")]
	[Address(RVA = "0xB44538", Offset = "0xB44538", VA = "0xB44538", Slot = "14")]
	public override void OnDrawGizmos()
	{
	}
}
