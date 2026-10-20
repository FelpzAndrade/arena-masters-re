using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D4E")]
public class XWidget_ToggleButton : MonoBehaviour
{
	[Token(Token = "0x4004465")]
	[FieldOffset(Offset = "0xC")]
	public UISprite sprActivate;

	[Token(Token = "0x4004466")]
	[FieldOffset(Offset = "0x10")]
	public UISprite sprDeactivate;

	[Token(Token = "0x4004467")]
	[FieldOffset(Offset = "0x14")]
	private bool isActive;

	[Token(Token = "0x17000D29")]
	public bool IsActive
	{
		[Token(Token = "0x60061B0")]
		[Address(RVA = "0x1B25B50", Offset = "0x1B25B50", VA = "0x1B25B50")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60061AF")]
	[Address(RVA = "0x1B25B48", Offset = "0x1B25B48", VA = "0x1B25B48")]
	public XWidget_ToggleButton()
	{
	}

	[Token(Token = "0x60061B1")]
	[Address(RVA = "0x1B25B58", Offset = "0x1B25B58", VA = "0x1B25B58")]
	public void SetActivate()
	{
	}

	[Token(Token = "0x60061B2")]
	[Address(RVA = "0x1B25CBC", Offset = "0x1B25CBC", VA = "0x1B25CBC")]
	public void SetDeactivate()
	{
	}
}
