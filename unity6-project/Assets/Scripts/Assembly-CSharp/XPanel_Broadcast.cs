using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C48")]
public class XPanel_Broadcast : MonoBehaviour
{
	[Token(Token = "0x2000C49")]
	public enum BroadCastType
	{
		[Token(Token = "0x4003E42")]
		None = 0,
		[Token(Token = "0x4003E43")]
		Chat = 1,
		[Token(Token = "0x4003E44")]
		ShowOff = 2,
		[Token(Token = "0x4003E45")]
		Notice = 3
	}

	[Token(Token = "0x4003E3B")]
	[FieldOffset(Offset = "0xC")]
	public UIPanel rootPanel;

	[Token(Token = "0x4003E3C")]
	[FieldOffset(Offset = "0x10")]
	public XWidget_BroadcastMsg msgUI;

	[Token(Token = "0x4003E3D")]
	[FieldOffset(Offset = "0x14")]
	public XWidget_TextScrolling scrollText;

	[Token(Token = "0x4003E3E")]
	[FieldOffset(Offset = "0x18")]
	public int notiDepth;

	[Token(Token = "0x4003E3F")]
	[FieldOffset(Offset = "0x1C")]
	public int normalDepth;

	[Token(Token = "0x4003E40")]
	[FieldOffset(Offset = "0x20")]
	private BroadCastType curBroadCastType;

	[Token(Token = "0x60058DC")]
	[Address(RVA = "0x1694D1C", Offset = "0x1694D1C", VA = "0x1694D1C")]
	public XPanel_Broadcast()
	{
	}

	[Token(Token = "0x60058DD")]
	[Address(RVA = "0x1694D34", Offset = "0x1694D34", VA = "0x1694D34")]
	private void Awake()
	{
	}

	[Token(Token = "0x60058DE")]
	[Address(RVA = "0x1694E00", Offset = "0x1694E00", VA = "0x1694E00")]
	private void BuildNone()
	{
	}

	[Token(Token = "0x60058DF")]
	[Address(RVA = "0x1694E38", Offset = "0x1694E38", VA = "0x1694E38")]
	private void Show()
	{
	}

	[Token(Token = "0x60058E0")]
	[Address(RVA = "0x1694E6C", Offset = "0x1694E6C", VA = "0x1694E6C")]
	private void Build(BroadCastType type, ChatMessage message)
	{
	}

	[Token(Token = "0x60058E1")]
	[Address(RVA = "0x16951D8", Offset = "0x16951D8", VA = "0x16951D8")]
	public void ShowMessage(BroadCastType type, ChatMessage message)
	{
	}

	[Token(Token = "0x60058E2")]
	[Address(RVA = "0x1695204", Offset = "0x1695204", VA = "0x1695204")]
	private void _003CAwake_003Em__251()
	{
	}
}
