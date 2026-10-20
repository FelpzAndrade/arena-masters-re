using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using UnityEngine;
using XAssetBundle;

[Token(Token = "0x20005FF")]
public abstract class XCharacterLoadOperator
{
	[Token(Token = "0x4001CCD")]
	[FieldOffset(Offset = "0x8")]
	private IXObjectPoolManager _objectPoolManager;

	[Token(Token = "0x4001CCE")]
	[FieldOffset(Offset = "0xC")]
	private ResourceLoader _resourceLoader;

	[Token(Token = "0x4001CCF")]
	[FieldOffset(Offset = "0x10")]
	protected List<XModuleActor.CreationDesc> m_descList;

	[Token(Token = "0x4001CD0")]
	[FieldOffset(Offset = "0x14")]
	protected Dictionary<string, List<KeyValuePair<string, XAniClipLoadOperation>>> m_aniReqDic;

	[Token(Token = "0x170007A0")]
	public IXObjectPoolManager objectPoolManager
	{
		[Token(Token = "0x6003323")]
		[Address(RVA = "0x1AB8350", Offset = "0x1AB8350", VA = "0x1AB8350")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003324")]
		[Address(RVA = "0x1AB8414", Offset = "0x1AB8414", VA = "0x1AB8414")]
		set
		{
		}
	}

	[Token(Token = "0x170007A1")]
	public ResourceLoader resourceLoader
	{
		[Token(Token = "0x6003325")]
		[Address(RVA = "0x1AB841C", Offset = "0x1AB841C", VA = "0x1AB841C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003326")]
		[Address(RVA = "0x1AB853C", Offset = "0x1AB853C", VA = "0x1AB853C")]
		set
		{
		}
	}

	[Token(Token = "0x6003322")]
	[Address(RVA = "0x1AB8348", Offset = "0x1AB8348", VA = "0x1AB8348")]
	protected XCharacterLoadOperator()
	{
	}

	[Token(Token = "0x6003327")]
	public abstract void OnUpdate();

	[Token(Token = "0x6003328")]
	public abstract bool LoadDone();

	[Token(Token = "0x6003329")]
	protected abstract void Init();

	[Token(Token = "0x600332A")]
	[Address(RVA = "0x1AB8544", Offset = "0x1AB8544", VA = "0x1AB8544")]
	protected bool CheckAlreadyLoad()
	{
		return default(bool);
	}

	[Token(Token = "0x600332B")]
	protected abstract void SkipOperatorDone();

	[Token(Token = "0x600332C")]
	[Address(RVA = "0x1AB8CF0", Offset = "0x1AB8CF0", VA = "0x1AB8CF0")]
	protected void PreloadAnimation()
	{
	}

	[Token(Token = "0x600332D")]
	[Address(RVA = "0x1AB9198", Offset = "0x1AB9198", VA = "0x1AB9198")]
	protected void RequestAnimation(string strKey, AniCategoryType type, int skinId)
	{
	}

	[Token(Token = "0x600332E")]
	protected abstract void LoadAnimationClip(string aniKey, string path, ref List<KeyValuePair<string, XAniClipLoadOperation>> aniReqList);

	[Token(Token = "0x600332F")]
	[Address(RVA = "0x1AB9754", Offset = "0x1AB9754", VA = "0x1AB9754")]
	protected void AttachAniMesh()
	{
	}

	[Token(Token = "0x6003330")]
	[Address(RVA = "0x1ABA068", Offset = "0x1ABA068", VA = "0x1ABA068")]
	protected void AttachAniClip(Animation aniComponent, string key)
	{
	}

	[Token(Token = "0x6003331")]
	[Address(RVA = "0x1ABA314", Offset = "0x1ABA314", VA = "0x1ABA314")]
	protected void PreloadEffect()
	{
	}

	[Token(Token = "0x6003332")]
	protected abstract bool CheckLoadEffect();

	[Token(Token = "0x6003333")]
	protected abstract void PreloadCharacterEffects(CSCharacterInfo characterInfo, int skinId);

	[Token(Token = "0x6003334")]
	protected abstract void PreloadRelicEffects(int relicSkillId);

	[Token(Token = "0x6003335")]
	protected abstract void loadEffect(string resName);

	[Token(Token = "0x6003336")]
	protected abstract void loadSkill(string resName);

	[Token(Token = "0x6003337")]
	[Address(RVA = "0x1ABA8C8", Offset = "0x1ABA8C8", VA = "0x1ABA8C8")]
	protected void LoadCharacterEffect(CSCharacterInfo characterInfo, int skinId)
	{
	}

	[Token(Token = "0x6003338")]
	[Address(RVA = "0x1ABAD50", Offset = "0x1ABAD50", VA = "0x1ABAD50")]
	protected void LoadCharacterEffect(int relicId)
	{
	}

	[Token(Token = "0x6003339")]
	[Address(RVA = "0x1ABAD5C", Offset = "0x1ABAD5C", VA = "0x1ABAD5C")]
	protected void LoadRelicEffects(int relicId)
	{
	}

	[Token(Token = "0x600333A")]
	[Address(RVA = "0x1ABA900", Offset = "0x1ABA900", VA = "0x1ABA900")]
	protected void LoadHitFragmentEffects(CSCharacterInfo characterInfo)
	{
	}

	[Token(Token = "0x600333B")]
	[Address(RVA = "0x1ABAA58", Offset = "0x1ABAA58", VA = "0x1ABAA58")]
	protected void LoadSkillEffects(CSCharacterInfo characterInfo, int skinId)
	{
	}

	[Token(Token = "0x600333C")]
	[Address(RVA = "0x1ABAB44", Offset = "0x1ABAB44", VA = "0x1ABAB44")]
	protected void LoadDropObjectBuffEffects(CSCharacterInfo characterInfo)
	{
	}

	[Token(Token = "0x600333D")]
	[Address(RVA = "0x1ABB0CC", Offset = "0x1ABB0CC", VA = "0x1ABB0CC")]
	protected void LoadSkillEffect(int nSkillID, int skinId)
	{
	}

	[Token(Token = "0x600333E")]
	[Address(RVA = "0x1ABAEAC", Offset = "0x1ABAEAC", VA = "0x1ABAEAC")]
	protected void LoadSkillEffect(CSSkillInfo skillInfo, int skinId)
	{
	}

	[Token(Token = "0x600333F")]
	[Address(RVA = "0x1ABB798", Offset = "0x1ABB798", VA = "0x1ABB798")]
	protected void LoadSkillProjectile(List<CSSkillEffectInfo> skillEffectInfo)
	{
	}

	[Token(Token = "0x6003340")]
	[Address(RVA = "0x1ABB228", Offset = "0x1ABB228", VA = "0x1ABB228")]
	protected void LoadSkillColliderToList(CSSkillInfo skillInfo)
	{
	}

	[Token(Token = "0x6003341")]
	[Address(RVA = "0x1ABB8C0", Offset = "0x1ABB8C0", VA = "0x1ABB8C0")]
	protected void LoadSkillEffectElement(List<CSSkillEffectInfo> skillEffectInfo)
	{
	}

	[Token(Token = "0x6003342")]
	[Address(RVA = "0x1ABB358", Offset = "0x1ABB358", VA = "0x1ABB358")]
	protected void LoadSkillBuffEffect(CSSkillInfo skillInfo, int skinId)
	{
	}

	[Token(Token = "0x6003343")]
	[Address(RVA = "0x1ABB74C", Offset = "0x1ABB74C", VA = "0x1ABB74C")]
	protected void LoadSkillMetaProperty(CSSkillInfo skillInfo, int skinId)
	{
	}

	[Token(Token = "0x6003344")]
	[Address(RVA = "0x1ABAF5C", Offset = "0x1ABAF5C", VA = "0x1ABAF5C")]
	protected void LoadDropObjectBuffEffct(CSBuffInfo buffInfo, int skinId)
	{
	}

	[Token(Token = "0x6003345")]
	[Address(RVA = "0x1ABBAF8", Offset = "0x1ABBAF8", VA = "0x1ABBAF8")]
	protected void AddChangeCharBuffDesc()
	{
	}

	[Token(Token = "0x6003346")]
	[Address(RVA = "0x1ABBCC0", Offset = "0x1ABBCC0", VA = "0x1ABBCC0")]
	private void FindDescFromRelic(XModuleActor.CreationDesc desc, ref List<XModuleActor.CreationDesc> list)
	{
	}

	[Token(Token = "0x6003347")]
	[Address(RVA = "0x1ABBF24", Offset = "0x1ABBF24", VA = "0x1ABBF24")]
	private void FindDescFromSkill(Dictionary<int, XModuleActor.CreationDesc.CharDesc> descList, ref List<XModuleActor.CreationDesc> list)
	{
	}

	[Token(Token = "0x6003348")]
	[Address(RVA = "0x1ABC39C", Offset = "0x1ABC39C", VA = "0x1ABC39C")]
	private void FindDescFromBuffID(int buffid, ref List<XModuleActor.CreationDesc> list)
	{
	}

	[Token(Token = "0x6003349")]
	[Address(RVA = "0x1ABC54C", Offset = "0x1ABC54C", VA = "0x1ABC54C")]
	protected void PreloadCharSound()
	{
	}

	[Token(Token = "0x600334A")]
	[Address(RVA = "0x1ABCF28", Offset = "0x1ABCF28", VA = "0x1ABCF28")]
	private void PreloadRelicSounds(int relicSkillId)
	{
	}

	[Token(Token = "0x600334B")]
	[Address(RVA = "0x1ABCF34", Offset = "0x1ABCF34", VA = "0x1ABCF34")]
	protected void LoadRelicSounds(int relicId)
	{
	}

	[Token(Token = "0x600334C")]
	[Address(RVA = "0x1ABCD9C", Offset = "0x1ABCD9C", VA = "0x1ABCD9C")]
	private void LoadCharSound(CSCharacterSoundInfo info)
	{
	}

	[Token(Token = "0x600334D")]
	[Address(RVA = "0x1ABCE3C", Offset = "0x1ABCE3C", VA = "0x1ABCE3C")]
	protected void LoadSkillSounds(CSCharacterInfo characterInfo, int skinId)
	{
	}

	[Token(Token = "0x600334E")]
	[Address(RVA = "0x1ABD20C", Offset = "0x1ABD20C", VA = "0x1ABD20C")]
	protected void LoadSkillSound(int nSkillID, int skinId)
	{
	}

	[Token(Token = "0x600334F")]
	[Address(RVA = "0x1ABD084", Offset = "0x1ABD084", VA = "0x1ABD084")]
	protected void LoadSkillSound(CSSkillInfo skillInfo, int skinId)
	{
	}

	[Token(Token = "0x6003350")]
	[Address(RVA = "0x1ABD368", Offset = "0x1ABD368", VA = "0x1ABD368")]
	protected void LoadSkillSoundElement(List<SkillSoundInfo> skillSoundInfo)
	{
	}

	[Token(Token = "0x6003351")]
	[Address(RVA = "0x1ABD0E8", Offset = "0x1ABD0E8", VA = "0x1ABD0E8")]
	private void loadSound(string resName)
	{
	}
}
