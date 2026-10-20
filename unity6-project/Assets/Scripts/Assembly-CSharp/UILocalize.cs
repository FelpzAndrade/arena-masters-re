using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000282")]
[ExecuteInEditMode]
public class UILocalize : MonoBehaviour
{
	[Token(Token = "0x4000BC6")]
	[FieldOffset(Offset = "0xC")]
	public string key;

	[Token(Token = "0x4000BC7")]
	[FieldOffset(Offset = "0x10")]
	private bool mStarted;

	[Token(Token = "0x1700038E")]
	public string value
	{
		[Token(Token = "0x60015E0")]
		[Address(RVA = "0x1709C30", Offset = "0x1709C30", VA = "0x1709C30")]
		set
		{
		}
	}

	[Token(Token = "0x60015DF")]
	[Address(RVA = "0x1709C28", Offset = "0x1709C28", VA = "0x1709C28")]
	public UILocalize()
	{
	}

	[Token(Token = "0x60015E1")]
	[Address(RVA = "0x170A104", Offset = "0x170A104", VA = "0x170A104")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60015E2")]
	[Address(RVA = "0x170A2F8", Offset = "0x170A2F8", VA = "0x170A2F8")]
	private void Start()
	{
	}

	[Token(Token = "0x60015E3")]
	[Address(RVA = "0x170A114", Offset = "0x170A114", VA = "0x170A114")]
	private void OnLocalize()
	{
	}
}
