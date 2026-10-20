using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C20")]
public class XWidget_TutorialBase : MonoBehaviour
{
	[Token(Token = "0x4003D45")]
	[FieldOffset(Offset = "0xC")]
	protected List<XUITutorialTarget> targetDataList;

	[Token(Token = "0x4003D46")]
	[FieldOffset(Offset = "0x10")]
	protected HashSet<GameObject> removeDataList;

	[Token(Token = "0x60057C2")]
	[Address(RVA = "0x1B2E398", Offset = "0x1B2E398", VA = "0x1B2E398")]
	public XWidget_TutorialBase()
	{
	}

	[Token(Token = "0x60057C3")]
	[Address(RVA = "0x1B2E478", Offset = "0x1B2E478", VA = "0x1B2E478")]
	protected void SyncRemoveDataList()
	{
	}

	[Token(Token = "0x60057C4")]
	[Address(RVA = "0x1B2E630", Offset = "0x1B2E630", VA = "0x1B2E630")]
	public void ClearTutorialTarget()
	{
	}
}
