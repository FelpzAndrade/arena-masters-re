using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D31")]
public class XWidget_CharacterInfo : MonoBehaviour
{
	[Token(Token = "0x4004379")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public UI2DSprite sprPortrait;

	[Token(Token = "0x400437A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public UILabel lblLevel;

	[Token(Token = "0x400437B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public UIProgressBar pgbHp;

	[Token(Token = "0x400437C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public UILabel lblHp;

	[Token(Token = "0x400437D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public UILabel lblName;

	[Token(Token = "0x400437E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public UILabel lblCool;

	[Token(Token = "0x400437F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public UISprite sprCool;

	[Token(Token = "0x4004380")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private XModuleActor m_actor;

	[Token(Token = "0x4004381")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private bool m_updateCool;

	[Token(Token = "0x4004382")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private XKeyEnum m_key;

	[Token(Token = "0x4004383")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private bool m_tagChar;

	[Token(Token = "0x4004384")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject disableObject;

	[Token(Token = "0x4004385")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public string onSkillReadyEffectPath;

	[Token(Token = "0x4004386")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject onSkillReadyEffect;

	[Token(Token = "0x4004387")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public ParticleSystem[] onSkillReadyEffectPSS;

	[Token(Token = "0x4004388")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool m_isUIActive;

	[Token(Token = "0x4004389")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private StringBuilder hpStrBuilder;

	[Token(Token = "0x400438A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float m_lastTagRemainCoolTime;

	[Token(Token = "0x60060C8")]
	[Address(RVA = "0x15CBDD0", Offset = "0x15CBDD0", VA = "0x15CBDD0")]
	public XWidget_CharacterInfo()
	{
	}

	[Token(Token = "0x60060C9")]
	[Address(RVA = "0x15CBE80", Offset = "0x15CBE80", VA = "0x15CBE80")]
	private void Awake()
	{
	}

	[Token(Token = "0x60060CA")]
	[Address(RVA = "0x15CC0E0", Offset = "0x15CC0E0", VA = "0x15CC0E0")]
	public void Build(bool updateCoolTime, XModuleActor actor, [Optional] XKeyEnum key, [Optional] string name, bool tagChar = false, bool isBoss = false)
	{
	}

	[Token(Token = "0x60060CB")]
	[Address(RVA = "0x15CCA7C", Offset = "0x15CCA7C", VA = "0x15CCA7C")]
	private void BuildLevel(XModuleActor.CharacterStatus status)
	{
	}

	[Token(Token = "0x60060CC")]
	[Address(RVA = "0x15CC924", Offset = "0x15CC924", VA = "0x15CC924")]
	private void BuildPortraitSprite(XModuleActor.CharacterStatus status)
	{
	}

	[Token(Token = "0x60060CD")]
	[Address(RVA = "0x15CCDF4", Offset = "0x15CCDF4", VA = "0x15CCDF4")]
	public void Hide()
	{
	}

	[Token(Token = "0x60060CE")]
	[Address(RVA = "0x15CCE28", Offset = "0x15CCE28", VA = "0x15CCE28")]
	private void Update()
	{
	}

	[Token(Token = "0x60060CF")]
	[Address(RVA = "0x15CCE44", Offset = "0x15CCE44", VA = "0x15CCE44")]
	private void UpdateCoolTime()
	{
	}

	[Token(Token = "0x60060D0")]
	[Address(RVA = "0x15CD148", Offset = "0x15CD148", VA = "0x15CD148")]
	public void SetIsUIActive(bool isUIActive)
	{
	}

	[Token(Token = "0x60060D1")]
	[Address(RVA = "0x15CCB94", Offset = "0x15CCB94", VA = "0x15CCB94")]
	protected void RefreshLabels()
	{
	}

	[Token(Token = "0x60060D2")]
	[Address(RVA = "0x15CD150", Offset = "0x15CD150", VA = "0x15CD150")]
	private void OnPress(bool isPressed)
	{
	}

	[Token(Token = "0x60060D3")]
	[Address(RVA = "0x15CD15C", Offset = "0x15CD15C", VA = "0x15CD15C")]
	public void OnClickPortrait()
	{
	}

	[Token(Token = "0x60060D4")]
	[Address(RVA = "0x15CD290", Offset = "0x15CD290", VA = "0x15CD290")]
	private void OnActorDestroy()
	{
	}

	[Token(Token = "0x60060D5")]
	[Address(RVA = "0x15CD29C", Offset = "0x15CD29C", VA = "0x15CD29C")]
	public void ClearResource()
	{
	}
}
