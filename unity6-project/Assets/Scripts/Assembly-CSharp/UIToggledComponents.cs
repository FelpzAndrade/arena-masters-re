using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000201")]
[ExecuteInEditMode]
public class UIToggledComponents : MonoBehaviour
{
	[Token(Token = "0x4000865")]
	[FieldOffset(Offset = "0xC")]
	public List<MonoBehaviour> activate;

	[Token(Token = "0x4000866")]
	[FieldOffset(Offset = "0x10")]
	public List<MonoBehaviour> deactivate;

	[Token(Token = "0x4000867")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	[HideInInspector]
	private MonoBehaviour target;

	[Token(Token = "0x4000868")]
	[FieldOffset(Offset = "0x18")]
	[HideInInspector]
	[SerializeField]
	private bool inverse;

	[Token(Token = "0x60010D8")]
	[Address(RVA = "0x17A7EA8", Offset = "0x17A7EA8", VA = "0x17A7EA8")]
	public UIToggledComponents()
	{
	}

	[Token(Token = "0x60010D9")]
	[Address(RVA = "0x17A7EB0", Offset = "0x17A7EB0", VA = "0x17A7EB0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60010DA")]
	[Address(RVA = "0x17A80F0", Offset = "0x17A80F0", VA = "0x17A80F0")]
	public void Toggle()
	{
	}
}
