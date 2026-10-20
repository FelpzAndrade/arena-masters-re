using System.Collections.Generic;
using AnimationOrTween;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001E2")]
[ExecuteInEditMode]
public class UIPlayAnimation : MonoBehaviour
{
	[Token(Token = "0x4000770")]
	[FieldOffset(Offset = "0x0")]
	public static UIPlayAnimation current;

	[Token(Token = "0x4000771")]
	[FieldOffset(Offset = "0xC")]
	public Animation target;

	[Token(Token = "0x4000772")]
	[FieldOffset(Offset = "0x10")]
	public Animator animator;

	[Token(Token = "0x4000773")]
	[FieldOffset(Offset = "0x14")]
	public string clipName;

	[Token(Token = "0x4000774")]
	[FieldOffset(Offset = "0x18")]
	public Trigger trigger;

	[Token(Token = "0x4000775")]
	[FieldOffset(Offset = "0x1C")]
	public Direction playDirection;

	[Token(Token = "0x4000776")]
	[FieldOffset(Offset = "0x20")]
	public bool resetOnPlay;

	[Token(Token = "0x4000777")]
	[FieldOffset(Offset = "0x21")]
	public bool clearSelection;

	[Token(Token = "0x4000778")]
	[FieldOffset(Offset = "0x24")]
	public EnableCondition ifDisabledOnPlay;

	[Token(Token = "0x4000779")]
	[FieldOffset(Offset = "0x28")]
	public DisableCondition disableWhenFinished;

	[Token(Token = "0x400077A")]
	[FieldOffset(Offset = "0x2C")]
	public List<EventDelegate> onFinished;

	[Token(Token = "0x400077B")]
	[FieldOffset(Offset = "0x30")]
	[HideInInspector]
	[SerializeField]
	private GameObject eventReceiver;

	[Token(Token = "0x400077C")]
	[FieldOffset(Offset = "0x34")]
	[HideInInspector]
	[SerializeField]
	private string callWhenFinished;

	[Token(Token = "0x400077D")]
	[FieldOffset(Offset = "0x38")]
	private bool mStarted;

	[Token(Token = "0x400077E")]
	[FieldOffset(Offset = "0x39")]
	private bool mActivated;

	[Token(Token = "0x400077F")]
	[FieldOffset(Offset = "0x3A")]
	private bool dragHighlight;

	[Token(Token = "0x17000259")]
	private bool dualState
	{
		[Token(Token = "0x6000FE4")]
		[Address(RVA = "0x1782F64", Offset = "0x1782F64", VA = "0x1782F64")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000FE2")]
	[Address(RVA = "0x1782EAC", Offset = "0x1782EAC", VA = "0x1782EAC")]
	public UIPlayAnimation()
	{
	}

	[Token(Token = "0x6000FE5")]
	[Address(RVA = "0x1782F7C", Offset = "0x1782F7C", VA = "0x1782F7C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000FE6")]
	[Address(RVA = "0x1783114", Offset = "0x1783114", VA = "0x1783114")]
	private void Start()
	{
	}

	[Token(Token = "0x6000FE7")]
	[Address(RVA = "0x17833D4", Offset = "0x17833D4", VA = "0x17833D4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000FE8")]
	[Address(RVA = "0x17837F8", Offset = "0x17837F8", VA = "0x17837F8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000FE9")]
	[Address(RVA = "0x178377C", Offset = "0x178377C", VA = "0x178377C")]
	private void OnHover(bool isOver)
	{
	}

	[Token(Token = "0x6000FEA")]
	[Address(RVA = "0x1783D9C", Offset = "0x1783D9C", VA = "0x1783D9C")]
	private void OnPress(bool isPressed)
	{
	}

	[Token(Token = "0x6000FEB")]
	[Address(RVA = "0x1783F08", Offset = "0x1783F08", VA = "0x1783F08")]
	private void OnClick()
	{
	}

	[Token(Token = "0x6000FEC")]
	[Address(RVA = "0x1784034", Offset = "0x1784034", VA = "0x1784034")]
	private void OnDoubleClick()
	{
	}

	[Token(Token = "0x6000FED")]
	[Address(RVA = "0x1784160", Offset = "0x1784160", VA = "0x1784160")]
	private void OnSelect(bool isSelected)
	{
	}

	[Token(Token = "0x6000FEE")]
	[Address(RVA = "0x17841DC", Offset = "0x17841DC", VA = "0x17841DC")]
	private void OnToggle()
	{
	}

	[Token(Token = "0x6000FEF")]
	[Address(RVA = "0x17844BC", Offset = "0x17844BC", VA = "0x17844BC")]
	private void OnDragOver()
	{
	}

	[Token(Token = "0x6000FF0")]
	[Address(RVA = "0x178463C", Offset = "0x178463C", VA = "0x178463C")]
	private void OnDragOut()
	{
	}

	[Token(Token = "0x6000FF1")]
	[Address(RVA = "0x1784780", Offset = "0x1784780", VA = "0x1784780")]
	private void OnDrop(GameObject go)
	{
	}

	[Token(Token = "0x6000FF2")]
	[Address(RVA = "0x17848E0", Offset = "0x17848E0", VA = "0x17848E0")]
	public void Play(bool forward)
	{
	}

	[Token(Token = "0x6000FF3")]
	[Address(RVA = "0x1783964", Offset = "0x1783964", VA = "0x1783964")]
	public void Play(bool forward, bool onlyIfDifferent)
	{
	}

	[Token(Token = "0x6000FF4")]
	[Address(RVA = "0x17848E8", Offset = "0x17848E8", VA = "0x17848E8")]
	public void PlayForward()
	{
	}

	[Token(Token = "0x6000FF5")]
	[Address(RVA = "0x17848F4", Offset = "0x17848F4", VA = "0x17848F4")]
	public void PlayReverse()
	{
	}

	[Token(Token = "0x6000FF6")]
	[Address(RVA = "0x1784900", Offset = "0x1784900", VA = "0x1784900")]
	private void OnFinished()
	{
	}
}
