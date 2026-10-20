using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C75")]
public abstract class UIDropArea : MonoBehaviour
{
	[Token(Token = "0x60059E7")]
	[Address(RVA = "0x16EAFE8", Offset = "0x16EAFE8", VA = "0x16EAFE8")]
	protected UIDropArea()
	{
	}

	[Token(Token = "0x60059E8")]
	public abstract void DragDropChange(GameObject dragOBJ);
}
