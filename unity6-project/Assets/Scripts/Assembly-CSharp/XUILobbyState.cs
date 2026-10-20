using System.Collections;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000E3D")]
public abstract class XUILobbyState : ILobbyStateBackbutton, IBackbutton
{
	[Token(Token = "0x4004B34")]
	[FieldOffset(Offset = "0x8")]
	protected XGameObjectHolder goHolder;

	[Token(Token = "0x4004B35")]
	[FieldOffset(Offset = "0xC")]
	protected XUIMgr_Lobby uIManager;

	[Token(Token = "0x4004B36")]
	[FieldOffset(Offset = "0x10")]
	protected Hashtable parameters;

	[Token(Token = "0x4004B37")]
	[FieldOffset(Offset = "0x14")]
	protected Dictionary<string, object> snapshots;

	[Token(Token = "0x4004B38")]
	[FieldOffset(Offset = "0x18")]
	private bool m_created;

	[Token(Token = "0x17000DA6")]
	protected virtual List<Currency> TopbannerCurrencyList
	{
		[Token(Token = "0x60069F4")]
		[Address(RVA = "0x109BDFC", Offset = "0x109BDFC", VA = "0x109BDFC", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DA7")]
	protected virtual bool ShowLobbyNotiIcons
	{
		[Token(Token = "0x60069F5")]
		[Address(RVA = "0x109BF14", Offset = "0x109BF14", VA = "0x109BF14", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000DA8")]
	public virtual bool IsPopup
	{
		[Token(Token = "0x60069F8")]
		[Address(RVA = "0x109BF3C", Offset = "0x109BF3C", VA = "0x109BF3C", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000DA9")]
	public virtual bool IsPopupAutoPop
	{
		[Token(Token = "0x60069F9")]
		[Address(RVA = "0x109BF44", Offset = "0x109BF44", VA = "0x109BF44", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000DAA")]
	public virtual bool IsBackable
	{
		[Token(Token = "0x60069FA")]
		[Address(RVA = "0x109BF4C", Offset = "0x109BF4C", VA = "0x109BF4C", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60069F3")]
	[Address(RVA = "0x109BDF4", Offset = "0x109BDF4", VA = "0x109BDF4")]
	protected XUILobbyState()
	{
	}

	[Token(Token = "0x60069F6")]
	[Address(RVA = "0x109BF1C", Offset = "0x109BF1C", VA = "0x109BF1C", Slot = "7")]
	public virtual bool Back()
	{
		return default(bool);
	}

	[Token(Token = "0x60069F7")]
	[Address(RVA = "0x109BF24", Offset = "0x109BF24", VA = "0x109BF24", Slot = "8")]
	public virtual void Final()
	{
	}

	[Token(Token = "0x60069FB")]
	[Address(RVA = "0x109BF54", Offset = "0x109BF54", VA = "0x109BF54", Slot = "12")]
	public virtual LobbyBackground GetLobbyBackgroundType()
	{
		return default(LobbyBackground);
	}

	[Token(Token = "0x60069FC")]
	[Address(RVA = "0x109BF5C", Offset = "0x109BF5C", VA = "0x109BF5C", Slot = "13")]
	protected virtual void OnCreated()
	{
	}

	[Token(Token = "0x60069FD")]
	[Address(RVA = "0x109C038", Offset = "0x109C038", VA = "0x109C038", Slot = "14")]
	public virtual void OnShow()
	{
	}

	[Token(Token = "0x60069FE")]
	[Address(RVA = "0x109C420", Offset = "0x109C420", VA = "0x109C420", Slot = "15")]
	public virtual void OnPop()
	{
	}

	[Token(Token = "0x60069FF")]
	[Address(RVA = "0x109C464", Offset = "0x109C464", VA = "0x109C464", Slot = "16")]
	public virtual void OnHide()
	{
	}

	[Token(Token = "0x6006A00")]
	[Address(RVA = "0x109C81C", Offset = "0x109C81C", VA = "0x109C81C")]
	public void SetParam(Hashtable param)
	{
	}

	[Token(Token = "0x6006A01")]
	[Address(RVA = "0x109C828", Offset = "0x109C828", VA = "0x109C828")]
	public void AddSnapShot(string key, object value)
	{
	}

	[Token(Token = "0x6006A02")]
	[Address(RVA = "0x109C984", Offset = "0x109C984", VA = "0x109C984")]
	public object GetSnapShot(string key)
	{
		return null;
	}

	[Token(Token = "0x6006A03")]
	[Address(RVA = "0x109C2BC", Offset = "0x109C2BC", VA = "0x109C2BC")]
	public void RefreshEnterResorce()
	{
	}

	[Token(Token = "0x6006A04")]
	[Address(RVA = "0x109C350", Offset = "0x109C350", VA = "0x109C350")]
	public void RefreshLobbyNotiIcons()
	{
	}

	[Token(Token = "0x6006A05")]
	public abstract XLobbyStateTypes GetStateType();

	[Token(Token = "0x6006A06")]
	[Address(RVA = "0x109CACC", Offset = "0x109CACC", VA = "0x109CACC", Slot = "18")]
	public virtual string GetStateName()
	{
		return null;
	}
}
