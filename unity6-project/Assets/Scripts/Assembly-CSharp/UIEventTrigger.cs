using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001D6")]
public class UIEventTrigger : MonoBehaviour
{
	[Token(Token = "0x4000718")]
	[FieldOffset(Offset = "0x0")]
	public static UIEventTrigger current;

	[Token(Token = "0x4000719")]
	[FieldOffset(Offset = "0xC")]
	public List<EventDelegate> onHoverOver;

	[Token(Token = "0x400071A")]
	[FieldOffset(Offset = "0x10")]
	public List<EventDelegate> onHoverOut;

	[Token(Token = "0x400071B")]
	[FieldOffset(Offset = "0x14")]
	public List<EventDelegate> onPress;

	[Token(Token = "0x400071C")]
	[FieldOffset(Offset = "0x18")]
	public List<EventDelegate> onRelease;

	[Token(Token = "0x400071D")]
	[FieldOffset(Offset = "0x1C")]
	public List<EventDelegate> onSelect;

	[Token(Token = "0x400071E")]
	[FieldOffset(Offset = "0x20")]
	public List<EventDelegate> onDeselect;

	[Token(Token = "0x400071F")]
	[FieldOffset(Offset = "0x24")]
	public List<EventDelegate> onClick;

	[Token(Token = "0x4000720")]
	[FieldOffset(Offset = "0x28")]
	public List<EventDelegate> onDoubleClick;

	[Token(Token = "0x4000721")]
	[FieldOffset(Offset = "0x2C")]
	public List<EventDelegate> onDragStart;

	[Token(Token = "0x4000722")]
	[FieldOffset(Offset = "0x30")]
	public List<EventDelegate> onDragEnd;

	[Token(Token = "0x4000723")]
	[FieldOffset(Offset = "0x34")]
	public List<EventDelegate> onDragOver;

	[Token(Token = "0x4000724")]
	[FieldOffset(Offset = "0x38")]
	public List<EventDelegate> onDragOut;

	[Token(Token = "0x4000725")]
	[FieldOffset(Offset = "0x3C")]
	public List<EventDelegate> onDrag;

	[Token(Token = "0x17000253")]
	public bool isColliderEnabled
	{
		[Token(Token = "0x6000F8E")]
		[Address(RVA = "0x16EC3F8", Offset = "0x16EC3F8", VA = "0x16EC3F8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000F8D")]
	[Address(RVA = "0x16EC22C", Offset = "0x16EC22C", VA = "0x16EC22C")]
	public UIEventTrigger()
	{
	}

	[Token(Token = "0x6000F8F")]
	[Address(RVA = "0x16EC574", Offset = "0x16EC574", VA = "0x16EC574")]
	private void OnHover(bool isOver)
	{
	}

	[Token(Token = "0x6000F90")]
	[Address(RVA = "0x16EC704", Offset = "0x16EC704", VA = "0x16EC704")]
	private void OnPress(bool pressed)
	{
	}

	[Token(Token = "0x6000F91")]
	[Address(RVA = "0x16EC894", Offset = "0x16EC894", VA = "0x16EC894")]
	private void OnSelect(bool selected)
	{
	}

	[Token(Token = "0x6000F92")]
	[Address(RVA = "0x16ECA24", Offset = "0x16ECA24", VA = "0x16ECA24")]
	private void OnClick()
	{
	}

	[Token(Token = "0x6000F93")]
	[Address(RVA = "0x16ECB7C", Offset = "0x16ECB7C", VA = "0x16ECB7C")]
	private void OnDoubleClick()
	{
	}

	[Token(Token = "0x6000F94")]
	[Address(RVA = "0x16ECCD4", Offset = "0x16ECCD4", VA = "0x16ECCD4")]
	private void OnDragStart()
	{
	}

	[Token(Token = "0x6000F95")]
	[Address(RVA = "0x16ECE1C", Offset = "0x16ECE1C", VA = "0x16ECE1C")]
	private void OnDragEnd()
	{
	}

	[Token(Token = "0x6000F96")]
	[Address(RVA = "0x16ECF64", Offset = "0x16ECF64", VA = "0x16ECF64")]
	private void OnDragOver(GameObject go)
	{
	}

	[Token(Token = "0x6000F97")]
	[Address(RVA = "0x16ED0BC", Offset = "0x16ED0BC", VA = "0x16ED0BC")]
	private void OnDragOut(GameObject go)
	{
	}

	[Token(Token = "0x6000F98")]
	[Address(RVA = "0x16ED214", Offset = "0x16ED214", VA = "0x16ED214")]
	private void OnDrag(Vector2 delta)
	{
	}
}
