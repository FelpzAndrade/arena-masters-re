using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001A7")]
public class ChatInput : MonoBehaviour
{
	[Token(Token = "0x4000627")]
	[FieldOffset(Offset = "0xC")]
	public UITextList textList;

	[Token(Token = "0x4000628")]
	[FieldOffset(Offset = "0x10")]
	public bool fillWithDummyData;

	[Token(Token = "0x4000629")]
	[FieldOffset(Offset = "0x14")]
	private UIInput mInput;

	[Token(Token = "0x6000EA3")]
	[Address(RVA = "0x20C466C", Offset = "0x20C466C", VA = "0x20C466C")]
	public ChatInput()
	{
	}

	[Token(Token = "0x6000EA4")]
	[Address(RVA = "0x20C4674", Offset = "0x20C4674", VA = "0x20C4674")]
	private void Start()
	{
	}

	[Token(Token = "0x6000EA5")]
	[Address(RVA = "0x20C4A1C", Offset = "0x20C4A1C", VA = "0x20C4A1C")]
	public void OnSubmit()
	{
	}
}
