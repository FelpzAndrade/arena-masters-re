using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000058")]
public class ChatParticipant : MonoBehaviour
{
	[Token(Token = "0x400017F")]
	[FieldOffset(Offset = "0xC")]
	public GameObject prefab;

	[Token(Token = "0x4000180")]
	[FieldOffset(Offset = "0x10")]
	public Transform lookAt;

	[Token(Token = "0x4000181")]
	[FieldOffset(Offset = "0x14")]
	private HUDText mText;

	[Token(Token = "0x17000053")]
	public HUDText hudText
	{
		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x20C531C", Offset = "0x20C531C", VA = "0x20C531C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60002D5")]
	[Address(RVA = "0x20C5658", Offset = "0x20C5658", VA = "0x20C5658")]
	public ChatParticipant()
	{
	}

	[Token(Token = "0x60002D7")]
	[Address(RVA = "0x20C5660", Offset = "0x20C5660", VA = "0x20C5660")]
	private void Start()
	{
	}
}
