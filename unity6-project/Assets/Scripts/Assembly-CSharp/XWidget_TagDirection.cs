using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D92")]
public class XWidget_TagDirection : XUIAsyncLoadBase
{
	[Token(Token = "0x4004678")]
	private const string strEffectPath = "Prefab/UI/Game/TagEffect/TagEffect";

	[Token(Token = "0x4004679")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public UI2DSprite[] sprIcons;

	[Token(Token = "0x400467A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public UITweener[] tweens;

	[Token(Token = "0x400467B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform effectRoot;

	[Token(Token = "0x400467C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private Action m_onComplete;

	[Token(Token = "0x400467D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float m_oncompleteDuration;

	[Token(Token = "0x400467E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private ParticleSystem[] m_ps;

	[Token(Token = "0x400467F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private double lastTime;

	[Token(Token = "0x4004680")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float startTime;

	[Token(Token = "0x4004681")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private float elapsed;

	[Token(Token = "0x4004682")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float deltaTime;

	[Token(Token = "0x60063B6")]
	[Address(RVA = "0x1B13450", Offset = "0x1B13450", VA = "0x1B13450")]
	public XWidget_TagDirection()
	{
	}

	[Token(Token = "0x60063B7")]
	[Address(RVA = "0x1B13458", Offset = "0x1B13458", VA = "0x1B13458")]
	public void RequestEfffect()
	{
	}

	[Token(Token = "0x60063B8")]
	[Address(RVA = "0x1B134A0", Offset = "0x1B134A0", VA = "0x1B134A0", Slot = "6")]
	protected override void GetParsorObj()
	{
	}

	[Token(Token = "0x60063B9")]
	[Address(RVA = "0x1B13594", Offset = "0x1B13594", VA = "0x1B13594", Slot = "4")]
	protected override void Init()
	{
	}

	[Token(Token = "0x60063BA")]
	[Address(RVA = "0x1B1361C", Offset = "0x1B1361C", VA = "0x1B1361C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60063BB")]
	[Address(RVA = "0x1B137E0", Offset = "0x1B137E0", VA = "0x1B137E0")]
	private void Update()
	{
	}

	[Token(Token = "0x60063BC")]
	[Address(RVA = "0x1B137E4", Offset = "0x1B137E4", VA = "0x1B137E4")]
	public void UpdateTime()
	{
	}

	[Token(Token = "0x60063BD")]
	[Address(RVA = "0x1B139C4", Offset = "0x1B139C4", VA = "0x1B139C4")]
	private void OnComplete()
	{
	}

	[Token(Token = "0x60063BE")]
	[Address(RVA = "0x1B139F0", Offset = "0x1B139F0", VA = "0x1B139F0")]
	public void Show(Sprite spr, [Optional] Action onComplete)
	{
	}

	[Token(Token = "0x60063BF")]
	[Address(RVA = "0x1B13B84", Offset = "0x1B13B84", VA = "0x1B13B84")]
	private void PlayEffect()
	{
	}

	[Token(Token = "0x60063C0")]
	[Address(RVA = "0x1B13D08", Offset = "0x1B13D08", VA = "0x1B13D08")]
	public void Hide()
	{
	}

	[Token(Token = "0x60063C1")]
	[Address(RVA = "0x1B13D48", Offset = "0x1B13D48", VA = "0x1B13D48")]
	public void HideDirection()
	{
	}

	[Token(Token = "0x60063C2")]
	[Address(RVA = "0x1B13E6C", Offset = "0x1B13E6C", VA = "0x1B13E6C", Slot = "7")]
	public virtual float GetRealtimeSinceStartup()
	{
		return default(float);
	}
}
