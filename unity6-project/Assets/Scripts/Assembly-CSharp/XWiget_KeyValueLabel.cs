using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2001007")]
public class XWiget_KeyValueLabel : MonoBehaviour
{
	[Token(Token = "0x4005593")]
	[FieldOffset(Offset = "0xC")]
	public UILabel lblKey;

	[Token(Token = "0x4005594")]
	[FieldOffset(Offset = "0x10")]
	public UILabel lblValue;

	[Token(Token = "0x600778E")]
	[Address(RVA = "0x1B34A20", Offset = "0x1B34A20", VA = "0x1B34A20")]
	public XWiget_KeyValueLabel()
	{
	}

	[Token(Token = "0x600778F")]
	[Address(RVA = "0x1B10920", Offset = "0x1B10920", VA = "0x1B10920")]
	public void Build(string key, string value)
	{
	}

	[Token(Token = "0x6007790")]
	[Address(RVA = "0x1B34A28", Offset = "0x1B34A28", VA = "0x1B34A28")]
	public void SetAllColor(Color color)
	{
	}

	[Token(Token = "0x6007791")]
	[Address(RVA = "0x1B34BA4", Offset = "0x1B34BA4", VA = "0x1B34BA4")]
	public void Hide()
	{
	}

	[Token(Token = "0x6007792")]
	[Address(RVA = "0x1B34BD8", Offset = "0x1B34BD8", VA = "0x1B34BD8", Slot = "4")]
	public virtual void SetGradient(bool useGradient, Color topColor, Color bottomColor)
	{
	}

	[Token(Token = "0x6007793")]
	[Address(RVA = "0x1B34C70", Offset = "0x1B34C70", VA = "0x1B34C70")]
	protected void SetGradient(UILabel lbl, bool useGradient, Color topColor, Color bottomColor)
	{
	}
}
