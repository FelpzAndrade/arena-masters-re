using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

[Token(Token = "0x2000EBB")]
public abstract class XInvenSelectedList
{
	[Token(Token = "0x2000EBC")]
	private sealed class _003CGetSelectedStackCnt_003Ec__AnonStorey20D
	{
		[Token(Token = "0x4004D8E")]
		[FieldOffset(Offset = "0x8")]
		internal string iid;

		[Token(Token = "0x6006DE2")]
		[Address(RVA = "0x1D2F7F4", Offset = "0x1D2F7F4", VA = "0x1D2F7F4")]
		public _003CGetSelectedStackCnt_003Ec__AnonStorey20D()
		{
		}

		[Token(Token = "0x6006DE3")]
		[Address(RVA = "0x1D2FC14", Offset = "0x1D2FC14", VA = "0x1D2FC14")]
		internal bool _003C_003Em__412(string x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4004D8A")]
	[FieldOffset(Offset = "0x8")]
	protected List<string> list;

	[Token(Token = "0x4004D8B")]
	[FieldOffset(Offset = "0xC")]
	private EventDelegate.Callback m_onClear;

	[Token(Token = "0x4004D8C")]
	[FieldOffset(Offset = "0x10")]
	private EventDelegate.Callback m_onSelectFirst;

	[Token(Token = "0x4004D8D")]
	[FieldOffset(Offset = "0x14")]
	private string ErrorMessage__BackingField;

	[Token(Token = "0x17000DFF")]
	public abstract InventoryModeType invenModeType
	{
		[Token(Token = "0x6006DD3")]
		get;
	}

	[Token(Token = "0x17000E00")]
	public List<string> SelectedList
	{
		[Token(Token = "0x6006DD4")]
		[Address(RVA = "0x1D2F4AC", Offset = "0x1D2F4AC", VA = "0x1D2F4AC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E01")]
	public string ErrorMessage
	{
		[Token(Token = "0x6006DD5")]
		[Address(RVA = "0x1D2F4B4", Offset = "0x1D2F4B4", VA = "0x1D2F4B4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006DD6")]
		[Address(RVA = "0x1D2F4BC", Offset = "0x1D2F4BC", VA = "0x1D2F4BC")]
		private set
		{
		}
	}

	[Token(Token = "0x17000E02")]
	public abstract int MaxCount
	{
		[Token(Token = "0x6006DDA")]
		get;
	}

	[Token(Token = "0x14000061")]
	public event EventDelegate.Callback onClear
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		[Token(Token = "0x6006DCF")]
		[Address(RVA = "0x1D2EE7C", Offset = "0x1D2EE7C", VA = "0x1D2EE7C")]
		add
		{
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[Token(Token = "0x6006DD0")]
		[Address(RVA = "0x1D2F008", Offset = "0x1D2F008", VA = "0x1D2F008")]
		remove
		{
		}
	}

	[Token(Token = "0x14000062")]
	public event EventDelegate.Callback onSelectFirst
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		[Token(Token = "0x6006DD1")]
		[Address(RVA = "0x1D2F194", Offset = "0x1D2F194", VA = "0x1D2F194")]
		add
		{
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[Token(Token = "0x6006DD2")]
		[Address(RVA = "0x1D2F320", Offset = "0x1D2F320", VA = "0x1D2F320")]
		remove
		{
		}
	}

	[Token(Token = "0x6006DCE")]
	[Address(RVA = "0x1D2EDD0", Offset = "0x1D2EDD0", VA = "0x1D2EDD0")]
	protected XInvenSelectedList()
	{
	}

	[Token(Token = "0x6006DD7")]
	[Address(RVA = "0x1D2F4C4", Offset = "0x1D2F4C4", VA = "0x1D2F4C4")]
	public void SetErrorMessge(string localeKey, params object[] param)
	{
	}

	[Token(Token = "0x6006DD8")]
	[Address(RVA = "0x1D2F5F0", Offset = "0x1D2F5F0", VA = "0x1D2F5F0", Slot = "5")]
	public virtual void ForcedAdd(XItem invenItem)
	{
	}

	[Token(Token = "0x6006DD9")]
	[Address(RVA = "0x1D2F69C", Offset = "0x1D2F69C", VA = "0x1D2F69C")]
	public int GetSelectedStackCnt(string iid)
	{
		return default(int);
	}

	[Token(Token = "0x6006DDB")]
	public abstract SelectRetType Add(XItem invenItem);

	[Token(Token = "0x6006DDC")]
	public abstract bool Remove(XItem selectedItem);

	[Token(Token = "0x6006DDD")]
	[Address(RVA = "0x1D2F7FC", Offset = "0x1D2F7FC", VA = "0x1D2F7FC")]
	public bool IsContain(string id)
	{
		return default(bool);
	}

	[Token(Token = "0x6006DDE")]
	[Address(RVA = "0x1D2F89C", Offset = "0x1D2F89C", VA = "0x1D2F89C")]
	public bool IsMax()
	{
		return default(bool);
	}

	[Token(Token = "0x6006DDF")]
	[Address(RVA = "0x1D2F974", Offset = "0x1D2F974", VA = "0x1D2F974", Slot = "9")]
	public virtual void Clear()
	{
	}

	[Token(Token = "0x6006DE0")]
	[Address(RVA = "0x1D2FA20", Offset = "0x1D2FA20", VA = "0x1D2FA20")]
	protected void Add(string iid)
	{
	}

	[Token(Token = "0x6006DE1")]
	[Address(RVA = "0x1D2FB0C", Offset = "0x1D2FB0C", VA = "0x1D2FB0C")]
	protected void Remove(string iid)
	{
	}
}
