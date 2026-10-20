using System;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E71")]
public class XWidget_SkillItem : XWidget_SkillIcon
{
	[Token(Token = "0x4004B9F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public UILabel lblPoint;

	[Token(Token = "0x4004BA0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public UILabel lblLockLv;

	[Token(Token = "0x4004BA1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public GameObject goDamageType;

	[Token(Token = "0x4004BA2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public UILabel lblDamageType;

	[Token(Token = "0x4004BA3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public UISprite sprDamageTypeBg;

	[Token(Token = "0x4004BA4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject goSkillType;

	[Token(Token = "0x4004BA5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public UILabel lblSkillType;

	[Token(Token = "0x4004BA6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject goTagSkill;

	[Token(Token = "0x4004BA7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public GameObject goTagInactive;

	[Token(Token = "0x4004BA8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject goAutoTargetingSkill;

	[Token(Token = "0x4004BA9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public GameObject goAutoTargetingInactive;

	[Token(Token = "0x4004BAA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject registTagEffect;

	[Token(Token = "0x4004BAB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public string effectSoundKey;

	[Token(Token = "0x4004BAC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private CSCharacterSkillInfo CharacterSkillInfo__BackingField;

	[Token(Token = "0x17000DD9")]
	public CSCharacterSkillInfo CharacterSkillInfo
	{
		[Token(Token = "0x6006BC5")]
		[Address(RVA = "0x1B07860", Offset = "0x1B07860", VA = "0x1B07860")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006BC6")]
		[Address(RVA = "0x1B07868", Offset = "0x1B07868", VA = "0x1B07868")]
		private set
		{
		}
	}

	[Token(Token = "0x6006BC4")]
	[Address(RVA = "0x1B077D4", Offset = "0x1B077D4", VA = "0x1B077D4")]
	public XWidget_SkillItem()
	{
	}

	[Token(Token = "0x6006BC7")]
	[Address(RVA = "0x1B07870", Offset = "0x1B07870", VA = "0x1B07870")]
	public void PlayEffect([Optional] Action onCompleteCallback)
	{
	}

	[Token(Token = "0x6006BC8")]
	[Address(RVA = "0x1B07A28", Offset = "0x1B07A28", VA = "0x1B07A28")]
	public void Build(CSCharacterSkillInfo characterSkillInfo, int usePoint, bool isLock, bool isTagSkillable, [Optional] bool? autotargetingEnabled)
	{
	}

	[Token(Token = "0x6006BC9")]
	[Address(RVA = "0x1B07E4C", Offset = "0x1B07E4C", VA = "0x1B07E4C")]
	private void BuildDamageType(SkillDamageTypes damageType)
	{
	}

	[Token(Token = "0x6006BCA")]
	[Address(RVA = "0x1B080B0", Offset = "0x1B080B0", VA = "0x1B080B0")]
	private void BuildSkillType(CSCharacterSkillInfo characterSkillInfo)
	{
	}

	[Token(Token = "0x6006BCB")]
	[Address(RVA = "0x1B0833C", Offset = "0x1B0833C", VA = "0x1B0833C")]
	private void BuildSkillTypeUI(bool bActive, string strSkillTypeText = "")
	{
	}

	[Token(Token = "0x6006BCC")]
	[Address(RVA = "0x1B08394", Offset = "0x1B08394", VA = "0x1B08394")]
	public void SelectTagSkill(bool isSelect)
	{
	}

	[Token(Token = "0x6006BCD")]
	[Address(RVA = "0x1B0825C", Offset = "0x1B0825C", VA = "0x1B0825C")]
	public void SetAutotargetingEnabled(bool enabled)
	{
	}

	[Token(Token = "0x6006BCE")]
	[Address(RVA = "0x1B07D54", Offset = "0x1B07D54", VA = "0x1B07D54")]
	protected void BuildLabelPoint(string point)
	{
	}
}
