using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D47")]
public class XWidget_SpectatorTargetMsg : MonoBehaviour
{
	[Token(Token = "0x4004455")]
	[FieldOffset(Offset = "0xC")]
	public UILabel lblMsg;

	[Token(Token = "0x4004456")]
	[FieldOffset(Offset = "0x10")]
	private bool m_isForceDisable;

	[Token(Token = "0x600618F")]
	[Address(RVA = "0x1B0BED0", Offset = "0x1B0BED0", VA = "0x1B0BED0")]
	public XWidget_SpectatorTargetMsg()
	{
	}

	[Token(Token = "0x6006190")]
	[Address(RVA = "0x1B0BED8", Offset = "0x1B0BED8", VA = "0x1B0BED8")]
	public void ResetState()
	{
	}

	[Token(Token = "0x6006191")]
	[Address(RVA = "0x1B0BEE4", Offset = "0x1B0BEE4", VA = "0x1B0BEE4")]
	public void ForceDisable()
	{
	}

	[Token(Token = "0x6006192")]
	[Address(RVA = "0x1B0BEF0", Offset = "0x1B0BEF0", VA = "0x1B0BEF0")]
	public void SetActive(bool isActive)
	{
	}

	[Token(Token = "0x6006193")]
	[Address(RVA = "0x1B0BF34", Offset = "0x1B0BF34", VA = "0x1B0BF34")]
	public void SetTargetMsg(string nickName)
	{
	}
}
