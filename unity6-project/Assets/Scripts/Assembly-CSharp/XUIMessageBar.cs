using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000CEC")]
public class XUIMessageBar : MonoBehaviour
{
	[Token(Token = "0x40041E3")]
	private const int listCnt = 3;

	[Token(Token = "0x40041E4")]
	public const string strKillEffectPath = "Prefab/UI/Game/common/XUIMessageBarKillEffect";

	[Token(Token = "0x40041E5")]
	[FieldOffset(Offset = "0xC")]
	private bool m_init;

	[Token(Token = "0x40041E6")]
	[FieldOffset(Offset = "0x10")]
	public XWiget_GridBuilder Grid;

	[Token(Token = "0x40041E7")]
	[FieldOffset(Offset = "0x14")]
	private XUIMessageBarDesc[] MessageBarDescArray;

	[Token(Token = "0x40041E8")]
	[FieldOffset(Offset = "0x18")]
	private XMessageBar m_MessageBar;

	[Token(Token = "0x6005D4C")]
	[Address(RVA = "0x10B6568", Offset = "0x10B6568", VA = "0x10B6568")]
	public XUIMessageBar()
	{
	}

	[Token(Token = "0x6005D4D")]
	[Address(RVA = "0x10B6604", Offset = "0x10B6604", VA = "0x10B6604")]
	private void Awake()
	{
	}

	[Token(Token = "0x6005D4E")]
	[Address(RVA = "0x10B6634", Offset = "0x10B6634", VA = "0x10B6634")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6005D4F")]
	[Address(RVA = "0x10B68FC", Offset = "0x10B68FC", VA = "0x10B68FC")]
	private void Update()
	{
	}

	[Token(Token = "0x6005D50")]
	[Address(RVA = "0x10B693C", Offset = "0x10B693C", VA = "0x10B693C")]
	public void PushMessage(XChatMsgType msgType, string strName, string strText, bool bMyKill = false)
	{
	}

	[Token(Token = "0x6005D51")]
	[Address(RVA = "0x10B66F0", Offset = "0x10B66F0", VA = "0x10B66F0")]
	private void RefreshUI()
	{
	}
}
