using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D2F")]
public class XWidget_Builder : MonoBehaviour
{
	[Token(Token = "0x400436F")]
	[FieldOffset(Offset = "0xC")]
	public GameObject originalElement;

	[Token(Token = "0x4004370")]
	[FieldOffset(Offset = "0x10")]
	public string prefabPath;

	[Token(Token = "0x4004371")]
	[FieldOffset(Offset = "0x14")]
	protected List<GameObject> m_list;

	[Token(Token = "0x4004372")]
	[FieldOffset(Offset = "0x18")]
	protected bool m_elementChanged;

	[Token(Token = "0x4004373")]
	[FieldOffset(Offset = "0x1C")]
	protected List<GameObject> m_unused;

	[Token(Token = "0x17000D1D")]
	public bool Empty
	{
		[Token(Token = "0x60060C0")]
		[Address(RVA = "0x15C3640", Offset = "0x15C3640", VA = "0x15C3640")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60060B2")]
	[Address(RVA = "0x15C2764", Offset = "0x15C2764", VA = "0x15C2764")]
	public XWidget_Builder()
	{
	}

	[Token(Token = "0x60060B3")]
	[Address(RVA = "0x15C2828", Offset = "0x15C2828", VA = "0x15C2828")]
	private void Awake()
	{
	}

	[Token(Token = "0x60060B4")]
	[Address(RVA = "0x15C2830", Offset = "0x15C2830", VA = "0x15C2830")]
	public void SetOriginElement(string prefabPath)
	{
	}

	[Token(Token = "0x60060B5")]
	public T[] Build<T>(GameObject[] buildPosition) where T : MonoBehaviour
	{
		return null;
	}

	[Token(Token = "0x60060B6")]
	public T[] Build<T>(int cloneNumber) where T : MonoBehaviour
	{
		return null;
	}

	[Token(Token = "0x60060B7")]
	[Address(RVA = "0x15BB3D0", Offset = "0x15BB3D0", VA = "0x15BB3D0")]
	public GameObject[] Build(int cloneNumber)
	{
		return null;
	}

	[Token(Token = "0x60060B8")]
	[Address(RVA = "0x15C3224", Offset = "0x15C3224", VA = "0x15C3224", Slot = "4")]
	public virtual void Reposition()
	{
	}

	[Token(Token = "0x60060B9")]
	[Address(RVA = "0x15C2CE4", Offset = "0x15C2CE4", VA = "0x15C2CE4")]
	private GameObject Clone()
	{
		return null;
	}

	[Token(Token = "0x60060BA")]
	[Address(RVA = "0x15C2A70", Offset = "0x15C2A70", VA = "0x15C2A70")]
	private void ClearCloned()
	{
	}

	[Token(Token = "0x60060BB")]
	[Address(RVA = "0x15C3228", Offset = "0x15C3228", VA = "0x15C3228")]
	private void PushAllToUnused()
	{
	}

	[Token(Token = "0x60060BC")]
	[Address(RVA = "0x15C33EC", Offset = "0x15C33EC", VA = "0x15C33EC")]
	public void RemoveClone(GameObject clone)
	{
	}

	[Token(Token = "0x60060BD")]
	[Address(RVA = "0x15C300C", Offset = "0x15C300C", VA = "0x15C300C")]
	public void RemoveClone(int count)
	{
	}

	[Token(Token = "0x60060BE")]
	[Address(RVA = "0x15C3550", Offset = "0x15C3550", VA = "0x15C3550")]
	public GameObject GetClone(int index)
	{
		return null;
	}

	[Token(Token = "0x60060BF")]
	[Address(RVA = "0x15C3638", Offset = "0x15C3638", VA = "0x15C3638")]
	public List<GameObject> GetClones()
	{
		return null;
	}
}
