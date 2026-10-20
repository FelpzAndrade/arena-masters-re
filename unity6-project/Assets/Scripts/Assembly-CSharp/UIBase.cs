using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000CAF")]
public class UIBase : MonoBehaviour, IBase
{
	[Token(Token = "0x17000CCD")]
	public Vector2 Size
	{
		[Token(Token = "0x6005B8A")]
		[Address(RVA = "0x1D693BC", Offset = "0x1D693BC", VA = "0x1D693BC", Slot = "4")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x6005B89")]
	[Address(RVA = "0x1D693B4", Offset = "0x1D693B4", VA = "0x1D693B4")]
	public UIBase()
	{
	}

	[Token(Token = "0x6005B8B")]
	[Address(RVA = "0x1D694E8", Offset = "0x1D694E8", VA = "0x1D694E8", Slot = "9")]
	public virtual void Show()
	{
	}

	[Token(Token = "0x6005B8C")]
	[Address(RVA = "0x1D6951C", Offset = "0x1D6951C", VA = "0x1D6951C")]
	public void ShowHide(bool show)
	{
	}

	[Token(Token = "0x6005B8D")]
	[Address(RVA = "0x1D69574", Offset = "0x1D69574", VA = "0x1D69574", Slot = "10")]
	public virtual bool IsShow()
	{
		return default(bool);
	}

	[Token(Token = "0x6005B8E")]
	[Address(RVA = "0x1D69598", Offset = "0x1D69598", VA = "0x1D69598", Slot = "11")]
	public virtual void Hide()
	{
	}

	[Token(Token = "0x6005B8F")]
	[Address(RVA = "0x1D695CC", Offset = "0x1D695CC", VA = "0x1D695CC", Slot = "12")]
	public virtual void Refresh([Optional] UIEvent type, [Optional] object data)
	{
	}
}
