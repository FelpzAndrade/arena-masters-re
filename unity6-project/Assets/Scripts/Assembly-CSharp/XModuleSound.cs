using System.Collections.Generic;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200048D")]
public class XModuleSound : XModuleBase
{
	[Token(Token = "0x200048E")]
	public class Entry : CSPoolEntry
	{
		[Token(Token = "0x40016F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int skillID;

		[Token(Token = "0x40016F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public string sound;

		[Token(Token = "0x40016F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool played;

		[Token(Token = "0x40016FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float at;

		[Token(Token = "0x40016FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public XAudioSourceFromPool audioSourceFromPool;

		[Token(Token = "0x40016FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool persist;

		[Token(Token = "0x40016FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CSCharacterSkillInfo.SkillType type;

		[Token(Token = "0x600274C")]
		[Address(RVA = "0xB989C0", Offset = "0xB989C0", VA = "0xB989C0")]
		public Entry()
		{
		}

		[Token(Token = "0x600274D")]
		[Address(RVA = "0xB989C8", Offset = "0xB989C8", VA = "0xB989C8", Slot = "4")]
		public void OnCleanupInObjectPool()
		{
		}

		[Token(Token = "0x600274E")]
		[Address(RVA = "0xB989CC", Offset = "0xB989CC", VA = "0xB989CC")]
		public void Clear()
		{
		}
	}

	[Token(Token = "0x200048F")]
	private class SoundCoolTime
	{
		[Token(Token = "0x40016FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string key;

		[Token(Token = "0x40016FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float coolTime;

		[Token(Token = "0x600274F")]
		[Address(RVA = "0xB97628", Offset = "0xB97628", VA = "0xB97628")]
		public SoundCoolTime()
		{
		}
	}

	[Token(Token = "0x40016F1")]
	private const float m_SoundAttenuationRatio = 0.5f;

	[Token(Token = "0x40016F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private List<Entry> scheduledSounds;

	[Token(Token = "0x40016F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private List<SoundCoolTime> soundCoolTimes;

	[Token(Token = "0x40016F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Dictionary<string, float> soundCoolTimeDictionary;

	[Token(Token = "0x40016F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private AudioSource m_audioSource_1;

	[Token(Token = "0x40016F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private AudioSource m_audioSource_2;

	[Token(Token = "0x17000637")]
	public AudioSource AudioSource_1
	{
		[Token(Token = "0x6002738")]
		[Address(RVA = "0xB95FB0", Offset = "0xB95FB0", VA = "0xB95FB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000638")]
	public AudioSource AudioSource_2
	{
		[Token(Token = "0x6002739")]
		[Address(RVA = "0xB95FB8", Offset = "0xB95FB8", VA = "0xB95FB8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002736")]
	[Address(RVA = "0xB95DB8", Offset = "0xB95DB8", VA = "0xB95DB8")]
	public XModuleSound()
	{
	}

	[Token(Token = "0x6002737")]
	[Address(RVA = "0xB95EDC", Offset = "0xB95EDC", VA = "0xB95EDC", Slot = "5")]
	public override void OnInit()
	{
	}

	[Token(Token = "0x600273A")]
	[Address(RVA = "0xB95FC0", Offset = "0xB95FC0", VA = "0xB95FC0")]
	private void RemoveEntry(int index)
	{
	}

	[Token(Token = "0x600273B")]
	[Address(RVA = "0xB960E8", Offset = "0xB960E8", VA = "0xB960E8", Slot = "6")]
	public override void OnUpdate(float dt)
	{
	}

	[Token(Token = "0x600273C")]
	[Address(RVA = "0xB966FC", Offset = "0xB966FC", VA = "0xB966FC")]
	private void UpdateSoundCoolTime(float time)
	{
	}

	[Token(Token = "0x600273D")]
	[Address(RVA = "0xB96128", Offset = "0xB96128", VA = "0xB96128")]
	private void UpdateSkillSound(float time)
	{
	}

	[Token(Token = "0x600273E")]
	[Address(RVA = "0xB96A20", Offset = "0xB96A20", VA = "0xB96A20", Slot = "26")]
	public override void OnSkillStart(XSkill skill)
	{
	}

	[Token(Token = "0x600273F")]
	[Address(RVA = "0xB973DC", Offset = "0xB973DC", VA = "0xB973DC")]
	private void ClearSceduleSoundExceptUltimateSkill()
	{
	}

	[Token(Token = "0x6002740")]
	[Address(RVA = "0xB9750C", Offset = "0xB9750C", VA = "0xB9750C")]
	private bool HaveSoundKey(string key)
	{
		return default(bool);
	}

	[Token(Token = "0x6002741")]
	[Address(RVA = "0xB972F8", Offset = "0xB972F8", VA = "0xB972F8")]
	private void AddCoolTime(string _key, float _coolTime)
	{
	}

	[Token(Token = "0x6002742")]
	[Address(RVA = "0xB97630", Offset = "0xB97630", VA = "0xB97630")]
	private bool PlaySoundFromRatio(float _ratio)
	{
		return default(bool);
	}

	[Token(Token = "0x6002743")]
	[Address(RVA = "0xB9716C", Offset = "0xB9716C", VA = "0xB9716C")]
	private void AddEntry(int skillId, string sound, float delay, float time, bool persist, CSCharacterSkillInfo.SkillType type, float ratio)
	{
	}

	[Token(Token = "0x6002744")]
	[Address(RVA = "0xB97678", Offset = "0xB97678", VA = "0xB97678", Slot = "30")]
	public override void OnSkillFinished(XSkill skill)
	{
	}

	[Token(Token = "0x6002745")]
	[Address(RVA = "0xB9767C", Offset = "0xB9767C", VA = "0xB9767C", Slot = "31")]
	public override void OnSkillCanceled(XSkill skill)
	{
	}

	[Token(Token = "0x6002746")]
	[Address(RVA = "0xB978DC", Offset = "0xB978DC", VA = "0xB978DC")]
	public void AllSkillSoundStop()
	{
	}

	[Token(Token = "0x6002747")]
	[Address(RVA = "0xB97A4C", Offset = "0xB97A4C", VA = "0xB97A4C", Slot = "35")]
	public override void OnHitMe(ModuleEventArgument_Hit arg)
	{
	}

	[Token(Token = "0x6002748")]
	[Address(RVA = "0xB98314", Offset = "0xB98314", VA = "0xB98314", Slot = "37")]
	public override void OnActorDie(ModuleEventArgument_Hit arg)
	{
	}

	[Token(Token = "0x6002749")]
	[Address(RVA = "0xB9692C", Offset = "0xB9692C", VA = "0xB9692C")]
	private float Play(string key, [Optional] GameObject sourceObj, float volumeRatio = 1f, XSoundCullingType soundCullingType = XSoundCullingType.NormalSound)
	{
		return default(float);
	}

	[Token(Token = "0x600274A")]
	[Address(RVA = "0xB96838", Offset = "0xB96838", VA = "0xB96838")]
	private float Play(string key, XModuleSound moduleSound, float volumeRatio = 1f, XSoundCullingType soundCullingType = XSoundCullingType.NormalSound)
	{
		return default(float);
	}

	[Token(Token = "0x600274B")]
	[Address(RVA = "0xB9892C", Offset = "0xB9892C", VA = "0xB9892C", Slot = "51")]
	public override void OnStartUlitmateCinema(int skillID)
	{
	}
}
