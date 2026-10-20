using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000BAC")]
public class XSkillProjectile : XSkillModule
{
	[Token(Token = "0x2000BAD")]
	public class Entry
	{
		[Token(Token = "0x4003B58")]
		[FieldOffset(Offset = "0x8")]
		public GameObject goProjectile;

		[Token(Token = "0x4003B59")]
		[FieldOffset(Offset = "0xC")]
		public Transform trProjectile;

		[Token(Token = "0x4003B5A")]
		[FieldOffset(Offset = "0x10")]
		public CSSkillEffectInfo effectInfo;

		[Token(Token = "0x4003B5B")]
		[FieldOffset(Offset = "0x14")]
		public Vector3 launchedPos;

		[Token(Token = "0x4003B5C")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 launchedDir;

		[Token(Token = "0x6005490")]
		[Address(RVA = "0x1820914", Offset = "0x1820914", VA = "0x1820914")]
		public Entry()
		{
		}
	}

	[Token(Token = "0x4003B54")]
	[FieldOffset(Offset = "0x18")]
	private List<Entry> m_entries;

	[Token(Token = "0x4003B55")]
	[FieldOffset(Offset = "0x1C")]
	private float m_showTime;

	[Token(Token = "0x4003B56")]
	[FieldOffset(Offset = "0x20")]
	private bool m_isLaunched;

	[Token(Token = "0x4003B57")]
	[FieldOffset(Offset = "0x21")]
	private bool m_isInitialized;

	[Token(Token = "0x17000C79")]
	public List<Entry> Entries
	{
		[Token(Token = "0x6005483")]
		[Address(RVA = "0x1820088", Offset = "0x1820088", VA = "0x1820088")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6005482")]
	[Address(RVA = "0x181FFB4", Offset = "0x181FFB4", VA = "0x181FFB4")]
	public XSkillProjectile(XSkill skill, XModuleEntity me, CSSkillInfo skillInfo, CSSkillInfo parentSkillInfo)
	{
	}

	[Token(Token = "0x6005484")]
	[Address(RVA = "0x1820090", Offset = "0x1820090", VA = "0x1820090")]
	public bool IsLaunched()
	{
		return default(bool);
	}

	[Token(Token = "0x6005485")]
	[Address(RVA = "0x181D4AC", Offset = "0x181D4AC", VA = "0x181D4AC")]
	public bool IsRunning()
	{
		return default(bool);
	}

	[Token(Token = "0x6005486")]
	[Address(RVA = "0x18200B4", Offset = "0x18200B4", VA = "0x18200B4", Slot = "6")]
	public override void OnDestroy()
	{
	}

	[Token(Token = "0x6005487")]
	[Address(RVA = "0x182022C", Offset = "0x182022C", VA = "0x182022C", Slot = "4")]
	public override void OnInit()
	{
	}

	[Token(Token = "0x6005488")]
	[Address(RVA = "0x182091C", Offset = "0x182091C", VA = "0x182091C", Slot = "9")]
	public override bool IsUsable()
	{
		return default(bool);
	}

	[Token(Token = "0x6005489")]
	[Address(RVA = "0x1820930", Offset = "0x1820930", VA = "0x1820930", Slot = "5")]
	public override void OnUpdate(float timeDelta)
	{
	}

	[Token(Token = "0x600548A")]
	[Address(RVA = "0x1821440", Offset = "0x1821440", VA = "0x1821440", Slot = "7")]
	public override void OnSkillStart(Vector3 pos, Quaternion dir)
	{
	}

	[Token(Token = "0x600548B")]
	[Address(RVA = "0x18215B4", Offset = "0x18215B4", VA = "0x18215B4", Slot = "10")]
	public override void OnCollision(GameObject goAttack)
	{
	}

	[Token(Token = "0x600548C")]
	[Address(RVA = "0x1820B8C", Offset = "0x1820B8C", VA = "0x1820B8C")]
	private void ActivateGameobject()
	{
	}

	[Token(Token = "0x600548D")]
	[Address(RVA = "0x18212D4", Offset = "0x18212D4", VA = "0x18212D4")]
	private void DeactivateGameobject(GameObject goAttack)
	{
	}

	[Token(Token = "0x600548E")]
	[Address(RVA = "0x181D480", Offset = "0x181D480", VA = "0x181D480")]
	public bool IsTrap()
	{
		return default(bool);
	}

	[Token(Token = "0x600548F")]
	[Address(RVA = "0x1821814", Offset = "0x1821814", VA = "0x1821814", Slot = "8")]
	public override void OnSkillFinished()
	{
	}
}
