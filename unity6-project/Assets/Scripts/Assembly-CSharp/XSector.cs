using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200075B")]
public class XSector
{
	[Token(Token = "0x200075C")]
	private sealed class _003CInit_003Ec__Iterator86 : IDisposable
	{
		[Token(Token = "0x40022C1")]
		[FieldOffset(Offset = "0x8")]
		internal CSSectorInfo sectorInfo;

		[Token(Token = "0x40022C2")]
		[FieldOffset(Offset = "0xC")]
		internal int _0024PC;

		[Token(Token = "0x40022C3")]
		[FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x40022C4")]
		[FieldOffset(Offset = "0x14")]
		internal CSSectorInfo _003C_0024_003EsectorInfo;

		[Token(Token = "0x40022C5")]
		[FieldOffset(Offset = "0x18")]
		internal XSector _003C_003Ef__this;

		[Token(Token = "0x17000844")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6003C1E")]
			[Address(RVA = "0x1CB1560", Offset = "0x1CB1560", VA = "0x1CB1560", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000845")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003C1F")]
			[Address(RVA = "0x1CB1568", Offset = "0x1CB1568", VA = "0x1CB1568", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003C1D")]
		[Address(RVA = "0x1CAFCA8", Offset = "0x1CAFCA8", VA = "0x1CAFCA8")]
		public _003CInit_003Ec__Iterator86()
		{
		}

		[Token(Token = "0x6003C1E")]
		[Address(RVA = "0x1CB1560", Offset = "0x1CB1560", VA = "0x1CB1560", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003C1F")]
		[Address(RVA = "0x1CB1568", Offset = "0x1CB1568", VA = "0x1CB1568", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003C20")]
		[Address(RVA = "0x1CB1570", Offset = "0x1CB1570", VA = "0x1CB1570", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6003C21")]
		[Address(RVA = "0x1CB15F4", Offset = "0x1CB15F4", VA = "0x1CB15F4", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6003C22")]
		[Address(RVA = "0x1CB1600", Offset = "0x1CB1600", VA = "0x1CB1600", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x200075D")]
	private sealed class _003CLoadSectorObject_003Ec__Iterator87 : IDisposable
	{
		[Token(Token = "0x40022C6")]
		[FieldOffset(Offset = "0x8")]
		internal CSSectorInfo sectorInfo;

		[Token(Token = "0x40022C7")]
		[FieldOffset(Offset = "0xC")]
		internal string _003CmapObjectPath_003E__0;

		[Token(Token = "0x40022C8")]
		[FieldOffset(Offset = "0x10")]
		internal int _0024PC;

		[Token(Token = "0x40022C9")]
		[FieldOffset(Offset = "0x14")]
		internal object _0024current;

		[Token(Token = "0x40022CA")]
		[FieldOffset(Offset = "0x18")]
		internal CSSectorInfo _003C_0024_003EsectorInfo;

		[Token(Token = "0x40022CB")]
		[FieldOffset(Offset = "0x1C")]
		internal XSector _003C_003Ef__this;

		[Token(Token = "0x17000846")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6003C24")]
			[Address(RVA = "0x1CB1694", Offset = "0x1CB1694", VA = "0x1CB1694", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000847")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003C25")]
			[Address(RVA = "0x1CB169C", Offset = "0x1CB169C", VA = "0x1CB169C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003C23")]
		[Address(RVA = "0x1CB0884", Offset = "0x1CB0884", VA = "0x1CB0884")]
		public _003CLoadSectorObject_003Ec__Iterator87()
		{
		}

		[Token(Token = "0x6003C24")]
		[Address(RVA = "0x1CB1694", Offset = "0x1CB1694", VA = "0x1CB1694", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003C25")]
		[Address(RVA = "0x1CB169C", Offset = "0x1CB169C", VA = "0x1CB169C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003C26")]
		[Address(RVA = "0x1CB16A4", Offset = "0x1CB16A4", VA = "0x1CB16A4", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6003C27")]
		[Address(RVA = "0x1CB1724", Offset = "0x1CB1724", VA = "0x1CB1724", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6003C28")]
		[Address(RVA = "0x1CB1730", Offset = "0x1CB1730", VA = "0x1CB1730", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x40022BA")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int _ColorHashKey;

	[Token(Token = "0x40022BB")]
	[FieldOffset(Offset = "0x8")]
	private CSSectorInfo m_SectorInfo;

	[Token(Token = "0x40022BC")]
	[FieldOffset(Offset = "0xC")]
	public GameObject m_goSector;

	[Token(Token = "0x40022BD")]
	[FieldOffset(Offset = "0x10")]
	private XSectorProperty m_sectorProperty;

	[Token(Token = "0x40022BE")]
	[FieldOffset(Offset = "0x14")]
	private XMapBuffManager m_MapBuffManager;

	[Token(Token = "0x40022BF")]
	[FieldOffset(Offset = "0x18")]
	private Renderer[] sectorRendrers;

	[Token(Token = "0x40022C0")]
	[FieldOffset(Offset = "0x1C")]
	private float m_offDelay;

	[Token(Token = "0x1700083F")]
	public XSectorProperty SectorProperty
	{
		[Token(Token = "0x6003C0F")]
		[Address(RVA = "0x1CAFB30", Offset = "0x1CAFB30", VA = "0x1CAFB30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000840")]
	public bool HasSectorGimmickInfo
	{
		[Token(Token = "0x6003C10")]
		[Address(RVA = "0x1CAFB38", Offset = "0x1CAFB38", VA = "0x1CAFB38")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000841")]
	public XMapBuffManager MapBuffManager
	{
		[Token(Token = "0x6003C11")]
		[Address(RVA = "0x1CAFBF0", Offset = "0x1CAFBF0", VA = "0x1CAFBF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000842")]
	public CSSectorInfo SectorInfo
	{
		[Token(Token = "0x6003C1B")]
		[Address(RVA = "0x1CB1534", Offset = "0x1CB1534", VA = "0x1CB1534")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000843")]
	public CSSectorType SectorType
	{
		[Token(Token = "0x6003C1C")]
		[Address(RVA = "0x1CB153C", Offset = "0x1CB153C", VA = "0x1CB153C")]
		get
		{
			return default(CSSectorType);
		}
	}

	[Token(Token = "0x6003C0D")]
	[Address(RVA = "0x1CAF9F8", Offset = "0x1CAF9F8", VA = "0x1CAF9F8")]
	public XSector()
	{
	}

	[Token(Token = "0x6003C0E")]
	[Address(RVA = "0x1CAFA94", Offset = "0x1CAFA94", VA = "0x1CAFA94")]
	static XSector()
	{
	}

	[Token(Token = "0x6003C12")]
	[Address(RVA = "0x1CAFBF8", Offset = "0x1CAFBF8", VA = "0x1CAFBF8")]
	[DebuggerHidden]
	public IEnumerator Init(CSSectorInfo sectorInfo)
	{
		return null;
	}

	[Token(Token = "0x6003C13")]
	[Address(RVA = "0x1CAFCB0", Offset = "0x1CAFCB0", VA = "0x1CAFCB0")]
	public void InitImmediatly(CSSectorInfo sectorInfo)
	{
	}

	[Token(Token = "0x6003C14")]
	[Address(RVA = "0x1CAFCDC", Offset = "0x1CAFCDC", VA = "0x1CAFCDC")]
	private string LoadMapObject(CSSectorInfo sectorInfo)
	{
		return null;
	}

	[Token(Token = "0x6003C15")]
	[Address(RVA = "0x1CAFFEC", Offset = "0x1CAFFEC", VA = "0x1CAFFEC")]
	private void LoadLightMapTexture(string mapObjectPath)
	{
	}

	[Token(Token = "0x6003C16")]
	[Address(RVA = "0x1CB07D4", Offset = "0x1CB07D4", VA = "0x1CB07D4")]
	[DebuggerHidden]
	private IEnumerator LoadSectorObject(CSSectorInfo sectorInfo)
	{
		return null;
	}

	[Token(Token = "0x6003C17")]
	[Address(RVA = "0x1CB088C", Offset = "0x1CB088C", VA = "0x1CB088C")]
	public void InitSectorSpawns()
	{
	}

	[Token(Token = "0x6003C18")]
	[Address(RVA = "0x1CB13CC", Offset = "0x1CB13CC", VA = "0x1CB13CC")]
	public void DirectionUpdate(float dt)
	{
	}

	[Token(Token = "0x6003C19")]
	[Address(RVA = "0x1CB1474", Offset = "0x1CB1474", VA = "0x1CB1474")]
	public void BlackOutSector(float offDelay)
	{
	}

	[Token(Token = "0x6003C1A")]
	[Address(RVA = "0x1CB1400", Offset = "0x1CB1400", VA = "0x1CB1400")]
	public void VisibleSector(bool val)
	{
	}
}
