using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200019A")]
public abstract class UIItemSlot : MonoBehaviour
{
	[Token(Token = "0x40005D2")]
	[FieldOffset(Offset = "0xC")]
	public UISprite icon;

	[Token(Token = "0x40005D3")]
	[FieldOffset(Offset = "0x10")]
	public UIWidget background;

	[Token(Token = "0x40005D4")]
	[FieldOffset(Offset = "0x14")]
	public UILabel label;

	[Token(Token = "0x40005D5")]
	[FieldOffset(Offset = "0x18")]
	public AudioClip grabSound;

	[Token(Token = "0x40005D6")]
	[FieldOffset(Offset = "0x1C")]
	public AudioClip placeSound;

	[Token(Token = "0x40005D7")]
	[FieldOffset(Offset = "0x20")]
	public AudioClip errorSound;

	[Token(Token = "0x40005D8")]
	[FieldOffset(Offset = "0x24")]
	private InvGameItem mItem;

	[Token(Token = "0x40005D9")]
	[FieldOffset(Offset = "0x28")]
	private string mText;

	[Token(Token = "0x40005DA")]
	[FieldOffset(Offset = "0x0")]
	private static InvGameItem mDraggedItem;

	[Token(Token = "0x1700023D")]
	protected abstract InvGameItem observedItem
	{
		[Token(Token = "0x6000E70")]
		get;
	}

	[Token(Token = "0x6000E6F")]
	[Address(RVA = "0x16EAFF4", Offset = "0x16EAFF4", VA = "0x16EAFF4")]
	protected UIItemSlot()
	{
	}

	[Token(Token = "0x6000E71")]
	protected abstract InvGameItem Replace(InvGameItem item);

	[Token(Token = "0x6000E72")]
	[Address(RVA = "0x16FC720", Offset = "0x16FC720", VA = "0x16FC720")]
	private void OnTooltip(bool show)
	{
	}

	[Token(Token = "0x6000E73")]
	[Address(RVA = "0x16FD0DC", Offset = "0x16FD0DC", VA = "0x16FD0DC")]
	private void OnClick()
	{
	}

	[Token(Token = "0x6000E74")]
	[Address(RVA = "0x16FD4E4", Offset = "0x16FD4E4", VA = "0x16FD4E4")]
	private void OnDrag(Vector2 delta)
	{
	}

	[Token(Token = "0x6000E75")]
	[Address(RVA = "0x16FD230", Offset = "0x16FD230", VA = "0x16FD230")]
	private void OnDrop(GameObject go)
	{
	}

	[Token(Token = "0x6000E76")]
	[Address(RVA = "0x16FD3C0", Offset = "0x16FD3C0", VA = "0x16FD3C0")]
	private void UpdateCursor()
	{
	}

	[Token(Token = "0x6000E77")]
	[Address(RVA = "0x16FD680", Offset = "0x16FD680", VA = "0x16FD680")]
	private void Update()
	{
	}
}
