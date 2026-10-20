using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000CB6")]
public class XUIScrollView : UIScrollView
{
	[Token(Token = "0x40040AC")]
	[FieldOffset(Offset = "0xCC")]
	private Dictionary<object, UIBase> m_items;

	[Token(Token = "0x40040AD")]
	[FieldOffset(Offset = "0xD0")]
	public Vector2 Offset;

	[Token(Token = "0x40040AE")]
	[FieldOffset(Offset = "0xD8")]
	public Vector2 Gab;

	[Token(Token = "0x40040AF")]
	[FieldOffset(Offset = "0xE0")]
	public int RowLimit;

	[Token(Token = "0x40040B0")]
	[FieldOffset(Offset = "0xE4")]
	private Vector3 BackupPosition;

	[Token(Token = "0x40040B1")]
	[FieldOffset(Offset = "0xF0")]
	private Vector3 BackupOffset;

	[Token(Token = "0x40040B2")]
	[FieldOffset(Offset = "0xFC")]
	private Vector2 baseOffset;

	[Token(Token = "0x40040B3")]
	[FieldOffset(Offset = "0x104")]
	private IScrollViewListener listener;

	[Token(Token = "0x40040B4")]
	[FieldOffset(Offset = "0x108")]
	private bool Freeze__BackingField;

	[Token(Token = "0x17000CD2")]
	public bool Freeze
	{
		[Token(Token = "0x6005BA7")]
		[Address(RVA = "0x1920A18", Offset = "0x1920A18", VA = "0x1920A18")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6005BA8")]
		[Address(RVA = "0x1920A20", Offset = "0x1920A20", VA = "0x1920A20")]
		set
		{
		}
	}

	[Token(Token = "0x17000CD3")]
	protected override bool shouldMove
	{
		[Token(Token = "0x6005BA9")]
		[Address(RVA = "0x1920A28", Offset = "0x1920A28", VA = "0x1920A28", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000CD4")]
	private Vector2 BaseOffset
	{
		[Token(Token = "0x6005BAC")]
		[Address(RVA = "0x1920CF8", Offset = "0x1920CF8", VA = "0x1920CF8")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x17000CD5")]
	public IScrollViewListener Listener
	{
		[Token(Token = "0x6005BAD")]
		[Address(RVA = "0x1920DD4", Offset = "0x1920DD4", VA = "0x1920DD4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6005BAE")]
		[Address(RVA = "0x1920E74", Offset = "0x1920E74", VA = "0x1920E74")]
		set
		{
		}
	}

	// C# has no syntax for parameterized property 'Item'.
	// Its 'property:' attributes below are ignored by the compiler (CS0657).
	[property: Token(Token = "0x17000CD6")]
	[Token(Token = "0x6005BB0")]
	[Address(RVA = "0x1920F24", Offset = "0x1920F24", VA = "0x1920F24")]
	public UIBase get_Item(object key)
	{
		return null;
	}

	[Token(Token = "0x6005BB1")]
	[Address(RVA = "0x1920FC4", Offset = "0x1920FC4", VA = "0x1920FC4")]
	public void set_Item(object key, UIBase value)
	{
	}

	[Token(Token = "0x6005BA6")]
	[Address(RVA = "0x19208A4", Offset = "0x19208A4", VA = "0x19208A4")]
	public XUIScrollView()
	{
	}

	[Token(Token = "0x6005BAA")]
	[Address(RVA = "0x1920A54", Offset = "0x1920A54", VA = "0x1920A54")]
	public void Backup()
	{
	}

	[Token(Token = "0x6005BAB")]
	[Address(RVA = "0x1920BB0", Offset = "0x1920BB0", VA = "0x1920BB0")]
	public void Restore()
	{
	}

	[Token(Token = "0x6005BAF")]
	[Address(RVA = "0x1920E7C", Offset = "0x1920E7C", VA = "0x1920E7C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6005BB2")]
	[Address(RVA = "0x1921134", Offset = "0x1921134", VA = "0x1921134")]
	public List<UIBase> ToList()
	{
		return null;
	}

	[Token(Token = "0x6005BB3")]
	[Address(RVA = "0x19211E8", Offset = "0x19211E8", VA = "0x19211E8")]
	public int Count()
	{
		return default(int);
	}

	[Token(Token = "0x6005BB4")]
	[Address(RVA = "0x1920FC8", Offset = "0x1920FC8", VA = "0x1920FC8")]
	public void Add(object key, UIBase item)
	{
	}

	[Token(Token = "0x6005BB5")]
	[Address(RVA = "0x1921280", Offset = "0x1921280", VA = "0x1921280")]
	public void Remove(object key)
	{
	}

	[Token(Token = "0x6005BB6")]
	[Address(RVA = "0x192173C", Offset = "0x192173C", VA = "0x192173C")]
	public void RefreshNextFrame()
	{
	}

	[Token(Token = "0x6005BB7")]
	[Address(RVA = "0x19217C8", Offset = "0x19217C8", VA = "0x19217C8")]
	public void Refresh()
	{
	}

	[Token(Token = "0x6005BB8")]
	[Address(RVA = "0x19213D0", Offset = "0x19213D0", VA = "0x19213D0")]
	public void RefreshItemPosition()
	{
	}

	[Token(Token = "0x6005BB9")]
	[Address(RVA = "0x19217E8", Offset = "0x19217E8", VA = "0x19217E8")]
	public void Clear()
	{
	}

	[Token(Token = "0x6005BBA")]
	[Address(RVA = "0x1921A04", Offset = "0x1921A04", VA = "0x1921A04")]
	private void OnDragMoved()
	{
	}
}
