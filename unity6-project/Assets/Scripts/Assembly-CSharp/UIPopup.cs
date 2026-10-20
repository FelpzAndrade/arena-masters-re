using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000CB0")]
public class UIPopup : XCommonBackUI, IBase
{
	[Token(Token = "0x2000CB1")]
	public enum OpenActionType
	{
		[Token(Token = "0x40040A3")]
		None = 0,
		[Token(Token = "0x40040A4")]
		Balloon = 1
	}

	[Token(Token = "0x2000CB2")]
	public enum CloseActionType
	{
		[Token(Token = "0x40040A6")]
		None = 0
	}

	[Token(Token = "0x40040A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OpenActionType OpenAction__BackingField;

	[Token(Token = "0x40040A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private CloseActionType CloseAction__BackingField;

	[Token(Token = "0x17000CCE")]
	public OpenActionType OpenAction
	{
		[Token(Token = "0x6005B91")]
		[Address(RVA = "0x1786BA0", Offset = "0x1786BA0", VA = "0x1786BA0")]
		get
		{
			return default(OpenActionType);
		}
		[Token(Token = "0x6005B92")]
		[Address(RVA = "0x1786BA8", Offset = "0x1786BA8", VA = "0x1786BA8")]
		set
		{
		}
	}

	[Token(Token = "0x17000CCF")]
	public CloseActionType CloseAction
	{
		[Token(Token = "0x6005B93")]
		[Address(RVA = "0x1786BB0", Offset = "0x1786BB0", VA = "0x1786BB0")]
		get
		{
			return default(CloseActionType);
		}
		[Token(Token = "0x6005B94")]
		[Address(RVA = "0x1786BB8", Offset = "0x1786BB8", VA = "0x1786BB8")]
		set
		{
		}
	}

	[Token(Token = "0x17000CD0")]
	private XUIMgrBase XUIMgrBase
	{
		[Token(Token = "0x6005B95")]
		[Address(RVA = "0x1786BC0", Offset = "0x1786BC0", VA = "0x1786BC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000CD1")]
	public Vector2 Size
	{
		[Token(Token = "0x6005B96")]
		[Address(RVA = "0x1786E8C", Offset = "0x1786E8C", VA = "0x1786E8C", Slot = "18")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x6005B90")]
	[Address(RVA = "0x1786B98", Offset = "0x1786B98", VA = "0x1786B98")]
	public UIPopup()
	{
	}

	[Token(Token = "0x6005B97")]
	[Address(RVA = "0x1786FB8", Offset = "0x1786FB8", VA = "0x1786FB8", Slot = "23")]
	public virtual void Show()
	{
	}

	[Token(Token = "0x6005B98")]
	[Address(RVA = "0x1787014", Offset = "0x1787014", VA = "0x1787014", Slot = "24")]
	public virtual bool IsShow()
	{
		return default(bool);
	}

	[Token(Token = "0x6005B99")]
	[Address(RVA = "0x1787038", Offset = "0x1787038", VA = "0x1787038", Slot = "12")]
	public override void Hide()
	{
	}

	[Token(Token = "0x6005B9A")]
	[Address(RVA = "0x1787044", Offset = "0x1787044", VA = "0x1787044", Slot = "25")]
	public virtual void Refresh([Optional] UIEvent type, [Optional] object data)
	{
	}

	[Token(Token = "0x6005B9B")]
	[Address(RVA = "0x1787048", Offset = "0x1787048", VA = "0x1787048")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6005B9C")]
	[Address(RVA = "0x1787004", Offset = "0x1787004", VA = "0x1787004")]
	private void SetOpenAction()
	{
	}

	[Token(Token = "0x6005B9D")]
	[Address(RVA = "0x1787168", Offset = "0x1787168", VA = "0x1787168")]
	private void SetOpenActionBalloon()
	{
	}

	[Token(Token = "0x6005B9E")]
	[Address(RVA = "0x1787040", Offset = "0x1787040", VA = "0x1787040")]
	private void SetCloseAction()
	{
	}
}
