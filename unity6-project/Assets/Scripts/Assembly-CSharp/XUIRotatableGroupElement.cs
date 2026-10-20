using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006E8")]
public class XUIRotatableGroupElement : MonoBehaviour
{
	[Token(Token = "0x4002110")]
	[FieldOffset(Offset = "0xC")]
	[HideInInspector]
	public List<EventDelegate> onSelectable;

	[Token(Token = "0x4002111")]
	[FieldOffset(Offset = "0x10")]
	[HideInInspector]
	public List<EventDelegate> onUnselectable;

	[Token(Token = "0x4002112")]
	[FieldOffset(Offset = "0x14")]
	private XUIRotatableGroup groupRoot;

	[Token(Token = "0x4002113")]
	[FieldOffset(Offset = "0x18")]
	private List<EventDelegate> m_CurDelegate;

	[Token(Token = "0x60039D1")]
	[Address(RVA = "0x19202DC", Offset = "0x19202DC", VA = "0x19202DC")]
	public XUIRotatableGroupElement()
	{
	}

	[Token(Token = "0x60039D2")]
	[Address(RVA = "0x19203A0", Offset = "0x19203A0", VA = "0x19203A0", Slot = "4")]
	public virtual void Init()
	{
	}

	[Token(Token = "0x60039D3")]
	[Address(RVA = "0x19203A4", Offset = "0x19203A4", VA = "0x19203A4")]
	private void Awake()
	{
	}

	[Token(Token = "0x60039D4")]
	[Address(RVA = "0x1920590", Offset = "0x1920590", VA = "0x1920590")]
	public void OnClickDelegate()
	{
	}

	[Token(Token = "0x60039D5")]
	[Address(RVA = "0x192063C", Offset = "0x192063C", VA = "0x192063C")]
	public void RotateToFront()
	{
	}

	[Token(Token = "0x60039D6")]
	[Address(RVA = "0x1920668", Offset = "0x1920668", VA = "0x1920668", Slot = "5")]
	public virtual void OnSelectable()
	{
	}

	[Token(Token = "0x60039D7")]
	[Address(RVA = "0x1920674", Offset = "0x1920674", VA = "0x1920674", Slot = "6")]
	public virtual void OnUnselectable()
	{
	}

	[Token(Token = "0x60039D8")]
	[Address(RVA = "0x1920680", Offset = "0x1920680", VA = "0x1920680")]
	private void OnDragStart()
	{
	}

	[Token(Token = "0x60039D9")]
	[Address(RVA = "0x19206A8", Offset = "0x19206A8", VA = "0x19206A8")]
	public void OnDrag(Vector2 delta)
	{
	}

	[Token(Token = "0x60039DA")]
	[Address(RVA = "0x19206D0", Offset = "0x19206D0", VA = "0x19206D0")]
	public void OnDragEnd()
	{
	}
}
