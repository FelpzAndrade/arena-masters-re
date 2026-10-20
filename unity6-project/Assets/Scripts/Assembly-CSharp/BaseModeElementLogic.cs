using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006D5")]
public abstract class BaseModeElementLogic : IModeMenuElementLogic
{
		protected BaseModeElementLogic()
		{
		}

	[Token(Token = "0x40020A6")]
	[FieldOffset(Offset = "0x8")]
	private XGameModeSortInfo info__BackingField;

	[Token(Token = "0x17000816")]
	public XGameModeSortInfo info
	{
		[Token(Token = "0x6003948")]
		[Address(RVA = "0x20BEF68", Offset = "0x20BEF68", VA = "0x20BEF68", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003949")]
		[Address(RVA = "0x20BEF60", Offset = "0x20BEF60", VA = "0x20BEF60")]
		private set
		{
		}
	}

	[Token(Token = "0x6003947")]
	[Address(RVA = "0x20B8FE0", Offset = "0x20B8FE0", VA = "0x20B8FE0")]
	public BaseModeElementLogic(XGameModeMainCatecory mainCategory, XGameModeSubCatecory subCategory)
	{
	}

	[Token(Token = "0x600394A")]
	[Address(RVA = "0x20BEF70", Offset = "0x20BEF70", VA = "0x20BEF70", Slot = "8")]
	public Sprite GetImage()
	{
		return null;
	}

	[Token(Token = "0x600394B")]
	[Address(RVA = "0x20BF064", Offset = "0x20BF064", VA = "0x20BF064", Slot = "7")]
	public string GetTitle()
	{
		return null;
	}

	[Token(Token = "0x600394C")]
	[Address(RVA = "0x20BF088", Offset = "0x20BF088", VA = "0x20BF088", Slot = "16")]
	public virtual void GetTopDeco(out string text, out bool isTween)
	{
		isTween = default;
		text = default;
	}

	[Token(Token = "0x600394D")]
	[Address(RVA = "0x20BF14C", Offset = "0x20BF14C", VA = "0x20BF14C", Slot = "17")]
	public virtual bool GetMidTitle(out string midTop, out bool isLock)
	{
		isLock = default;
		midTop = default;
		return default(bool);
	}

	[Token(Token = "0x600394E")]
	[Address(RVA = "0x20BF160", Offset = "0x20BF160", VA = "0x20BF160", Slot = "11")]
	public string GetBottomTitle()
	{
		return null;
	}

	[Token(Token = "0x600394F")]
	public abstract int GetUnlockLv();

	[Token(Token = "0x6003950")]
	[Address(RVA = "0x20BF184", Offset = "0x20BF184", VA = "0x20BF184", Slot = "6")]
	public bool IsLock()
	{
		return default(bool);
	}

	[Token(Token = "0x6003951")]
	public abstract void OnClick();

	[Token(Token = "0x6003952")]
	[Address(RVA = "0x20BF294", Offset = "0x20BF294", VA = "0x20BF294", Slot = "13")]
	public bool IsEffectActive()
	{
		return default(bool);
	}

	[Token(Token = "0x6003953")]
	[Address(RVA = "0x20BF2B8", Offset = "0x20BF2B8", VA = "0x20BF2B8", Slot = "14")]
	public void SetEventDescriptionText(string text)
	{
	}

	[Token(Token = "0x6003954")]
	[Address(RVA = "0x20BF2BC", Offset = "0x20BF2BC", VA = "0x20BF2BC", Slot = "20")]
	public virtual bool TryRewardItemIconInfo(out string iconPath, out Color color)
	{
		color = default;
		iconPath = default;
		return default(bool);
	}
}
