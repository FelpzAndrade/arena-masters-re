using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XAssetBundle;

[Token(Token = "0x2001056")]
public abstract class XUIMgrBase
{
	[Token(Token = "0x400580D")]
	[FieldOffset(Offset = "0x8")]
	protected Dictionary<int, XAssetBundleLoadAssetOperation> asyncReqList;

	[Token(Token = "0x400580E")]
	[FieldOffset(Offset = "0xC")]
	protected XGameObjectHolder m_goHolder;

	[Token(Token = "0x400580F")]
	[FieldOffset(Offset = "0x10")]
	protected Stack<ICommonBackableUI> backUIStack;

	[Token(Token = "0x17000F0F")]
	protected Transform defaultParent
	{
		[Token(Token = "0x60079FC")]
		[Address(RVA = "0x10BCEE4", Offset = "0x10BCEE4", VA = "0x10BCEE4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F10")]
	public XGameObjectHolder GOHolder
	{
		[Token(Token = "0x60079FD")]
		[Address(RVA = "0x1093014", Offset = "0x1093014", VA = "0x1093014")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60079FB")]
	[Address(RVA = "0x10B898C", Offset = "0x10B898C", VA = "0x10B898C")]
	protected XUIMgrBase()
	{
	}

	[Token(Token = "0x60079FE")]
	public abstract string GetPrefabPath();

	[Token(Token = "0x60079FF")]
	[Address(RVA = "0x10B98B0", Offset = "0x10B98B0", VA = "0x10B98B0", Slot = "5")]
	public virtual void Init()
	{
	}

	[Token(Token = "0x6007A00")]
	[Address(RVA = "0x10BBEB8", Offset = "0x10BBEB8", VA = "0x10BBEB8", Slot = "6")]
	public virtual void Clear()
	{
	}

	[Token(Token = "0x6007A01")]
	[Address(RVA = "0x10D14EC", Offset = "0x10D14EC", VA = "0x10D14EC", Slot = "7")]
	public virtual void ReleaseNGUIAtlas()
	{
	}

	[Token(Token = "0x6007A02")]
	[Address(RVA = "0x10BC0AC", Offset = "0x10BC0AC", VA = "0x10BC0AC")]
	protected void ReleaseNGUIAtlas(string[] atlasList)
	{
	}

	[Token(Token = "0x6007A03")]
	[Address(RVA = "0x10D14F0", Offset = "0x10D14F0", VA = "0x10D14F0", Slot = "8")]
	public virtual void BackGroundLoadAsyncUI(int ui)
	{
	}

	[Token(Token = "0x6007A04")]
	[Address(RVA = "0x10B73E4", Offset = "0x10B73E4", VA = "0x10B73E4")]
	public XAssetBundleLoadAssetOperation GetAsyncReqList(int ui)
	{
		return null;
	}

	[Token(Token = "0x6007A05")]
	[Address(RVA = "0x10D14F4", Offset = "0x10D14F4", VA = "0x10D14F4")]
	public bool IsAsnycReqDone(int ui)
	{
		return default(bool);
	}

	[Token(Token = "0x6007A06")]
	[Address(RVA = "0x10BC444", Offset = "0x10BC444", VA = "0x10BC444")]
	protected static XAssetBundleLoadAssetOperation CreateAsync(string path)
	{
		return null;
	}

	[Token(Token = "0x6007A07")]
	[Address(RVA = "0x10BC520", Offset = "0x10BC520", VA = "0x10BC520")]
	protected bool AddAsyncReqList(int ui, XAssetBundleLoadAssetOperation req)
	{
		return default(bool);
	}

	[Token(Token = "0x6007A08")]
	[Address(RVA = "0x10D1540", Offset = "0x10D1540", VA = "0x10D1540")]
	public void RegisterPopup(ICommonBackableUI ui)
	{
	}

	[Token(Token = "0x6007A09")]
	[Address(RVA = "0x10D1454", Offset = "0x10D1454", VA = "0x10D1454")]
	public void AllClearPopup()
	{
	}

	[Token(Token = "0x6007A0A")]
	[Address(RVA = "0x10D16EC", Offset = "0x10D16EC", VA = "0x10D16EC", Slot = "9")]
	public virtual bool Back()
	{
		return default(bool);
	}

	[Token(Token = "0x6007A0B")]
	[Address(RVA = "0x10D1970", Offset = "0x10D1970", VA = "0x10D1970")]
	public void ReleasePopup(ICommonBackableUI ui)
	{
	}

	[Token(Token = "0x6007A0C")]
	[Address(RVA = "0x10D1610", Offset = "0x10D1610", VA = "0x10D1610")]
	private void TryPeek(out ICommonBackableUI ui)
	{
		ui = default;
	}

	[Token(Token = "0x6007A0D")]
	[Address(RVA = "0x10BA008", Offset = "0x10BA008", VA = "0x10BA008", Slot = "10")]
	public virtual void Update()
	{
	}

	[Token(Token = "0x6007A0E")]
	[Address(RVA = "0x10D1BEC", Offset = "0x10D1BEC", VA = "0x10D1BEC", Slot = "11")]
	protected virtual void BackUpdateFunc()
	{
	}

	[Token(Token = "0x6007A0F")]
	[Address(RVA = "0x10D1BF0", Offset = "0x10D1BF0", VA = "0x10D1BF0", Slot = "12")]
	protected virtual bool PreBackStateCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x6007A10")]
	[Address(RVA = "0x10D1BF8", Offset = "0x10D1BF8", VA = "0x10D1BF8", Slot = "13")]
	protected virtual void BackFunc()
	{
	}
}
