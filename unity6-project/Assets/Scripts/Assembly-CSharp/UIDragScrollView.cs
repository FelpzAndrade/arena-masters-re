using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001D4")]
public class UIDragScrollView : MonoBehaviour
{
	[Token(Token = "0x4000704")]
	[FieldOffset(Offset = "0xC")]
	public UIScrollView scrollView;

	[Token(Token = "0x4000705")]
	[FieldOffset(Offset = "0x10")]
	[HideInInspector]
	[SerializeField]
	private UIScrollView draggablePanel;

	[Token(Token = "0x4000706")]
	[FieldOffset(Offset = "0x14")]
	private Transform mTrans;

	[Token(Token = "0x4000707")]
	[FieldOffset(Offset = "0x18")]
	private UIScrollView mScroll;

	[Token(Token = "0x4000708")]
	[FieldOffset(Offset = "0x1C")]
	private bool mAutoFind;

	[Token(Token = "0x4000709")]
	[FieldOffset(Offset = "0x1D")]
	private bool mStarted;

	[Token(Token = "0x6000F7A")]
	[Address(RVA = "0x16E4DF8", Offset = "0x16E4DF8", VA = "0x16E4DF8")]
	public UIDragScrollView()
	{
	}

	[Token(Token = "0x6000F7B")]
	[Address(RVA = "0x16E4E00", Offset = "0x16E4E00", VA = "0x16E4E00")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000F7C")]
	[Address(RVA = "0x16E5170", Offset = "0x16E5170", VA = "0x16E5170")]
	private void Start()
	{
	}

	[Token(Token = "0x6000F7D")]
	[Address(RVA = "0x16E4F98", Offset = "0x16E4F98", VA = "0x16E4F98")]
	private void FindScrollView()
	{
	}

	[Token(Token = "0x6000F7E")]
	[Address(RVA = "0x16E517C", Offset = "0x16E517C", VA = "0x16E517C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000F7F")]
	[Address(RVA = "0x16E52D0", Offset = "0x16E52D0", VA = "0x16E52D0")]
	public void OnPress(bool pressed)
	{
	}

	[Token(Token = "0x6000F80")]
	[Address(RVA = "0x16E5514", Offset = "0x16E5514", VA = "0x16E5514")]
	public void OnDrag(Vector2 delta)
	{
	}

	[Token(Token = "0x6000F81")]
	[Address(RVA = "0x16E563C", Offset = "0x16E563C", VA = "0x16E563C")]
	private void OnScroll(float delta)
	{
	}

	[Token(Token = "0x6000F82")]
	[Address(RVA = "0x16E576C", Offset = "0x16E576C", VA = "0x16E576C")]
	public void OnPan(Vector2 delta)
	{
	}
}
