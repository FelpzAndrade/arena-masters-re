using System.Text;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006E0")]
public class XUIEnterButton : MonoBehaviour
{
	[Token(Token = "0x40020C1")]
	[FieldOffset(Offset = "0xC")]
	public XWidget_EnterButton enterUI;

	[Token(Token = "0x40020C2")]
	[FieldOffset(Offset = "0x10")]
	public XGameModeMainCatecory mainCategory;

	[Token(Token = "0x40020C3")]
	[FieldOffset(Offset = "0x14")]
	public XGameModeSubCatecory subCategory;

	[Token(Token = "0x40020C4")]
	[FieldOffset(Offset = "0x18")]
	public IModeMenuElementLogic logic;

	[Token(Token = "0x40020C5")]
	[FieldOffset(Offset = "0x1C")]
	private CSGameOpenModeInfo m_gameOpenModeInfo;

	[Token(Token = "0x40020C6")]
	[FieldOffset(Offset = "0x20")]
	private bool m_isModeOpen;

	[Token(Token = "0x40020C7")]
	[FieldOffset(Offset = "0x21")]
	private bool m_isNearestModeOpen;

	[Token(Token = "0x40020C8")]
	[FieldOffset(Offset = "0x24")]
	private StringBuilder stringBuilder;

	[Token(Token = "0x40020C9")]
	[FieldOffset(Offset = "0x28")]
	private bool IsLock__BackingField;

	[Token(Token = "0x17000818")]
	public bool IsLock
	{
		[Token(Token = "0x600398B")]
		[Address(RVA = "0x1A3F4C0", Offset = "0x1A3F4C0", VA = "0x1A3F4C0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600398C")]
		[Address(RVA = "0x1A4021C", Offset = "0x1A4021C", VA = "0x1A4021C")]
		private set
		{
		}
	}

	[Token(Token = "0x6003988")]
	[Address(RVA = "0x1A3F404", Offset = "0x1A3F404", VA = "0x1A3F404")]
	public XUIEnterButton()
	{
	}

	[Token(Token = "0x6003989")]
	[Address(RVA = "0x1A3F4A0", Offset = "0x1A3F4A0", VA = "0x1A3F4A0")]
	private void Update()
	{
	}

	[Token(Token = "0x600398A")]
	[Address(RVA = "0x1A3F4C8", Offset = "0x1A3F4C8", VA = "0x1A3F4C8")]
	private void ShowRemainRankTimeLegacy()
	{
	}

	[Token(Token = "0x600398D")]
	[Address(RVA = "0x1A40224", Offset = "0x1A40224", VA = "0x1A40224", Slot = "4")]
	public virtual void Init()
	{
	}

	[Token(Token = "0x600398E")]
	[Address(RVA = "0x1A3FC74", Offset = "0x1A3FC74", VA = "0x1A3FC74")]
	private string GetRankTypeString()
	{
		return null;
	}

	[Token(Token = "0x600398F")]
	[Address(RVA = "0x1A3FF08", Offset = "0x1A3FF08", VA = "0x1A3FF08")]
	private void SearchModeOpen(XGameModeSubCatecory subCategory)
	{
	}

	[Token(Token = "0x6003990")]
	[Address(RVA = "0x1A40F58", Offset = "0x1A40F58", VA = "0x1A40F58")]
	public bool RequireRefresh()
	{
		return default(bool);
	}

	[Token(Token = "0x6003991")]
	[Address(RVA = "0x1A40CF4", Offset = "0x1A40CF4", VA = "0x1A40CF4")]
	private IModeMenuElementLogic GetLogic(XGameModeMainCatecory mainCategory, XGameModeSubCatecory subCategory)
	{
		return null;
	}
}
