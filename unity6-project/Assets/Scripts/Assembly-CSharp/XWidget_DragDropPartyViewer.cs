using System;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F7F")]
public class XWidget_DragDropPartyViewer : XWidget_PartyViewer
{
	[Token(Token = "0x2000F80")]
	private sealed class _003CPartySetting_003Ec__AnonStorey237
	{
		[Token(Token = "0x40051D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal string changeUID;

		[Token(Token = "0x40051D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal string prevUID;

		[Token(Token = "0x6007362")]
		[Address(RVA = "0x15F25F8", Offset = "0x15F25F8", VA = "0x15F25F8")]
		public _003CPartySetting_003Ec__AnonStorey237()
		{
		}

		[Token(Token = "0x6007363")]
		[Address(RVA = "0x15F2A1C", Offset = "0x15F2A1C", VA = "0x15F2A1C")]
		internal bool _003C_003Em__4A2(string uid)
		{
			return default(bool);
		}

		[Token(Token = "0x6007364")]
		[Address(RVA = "0x15F2AD0", Offset = "0x15F2AD0", VA = "0x15F2AD0")]
		internal bool _003C_003Em__4A3(string uid)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x40051CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public TweenPosition[] tweenArrows;

	[Token(Token = "0x40051CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public Action refreshDeleagte;

	[Token(Token = "0x40051CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject goDropOtherArea;

	[Token(Token = "0x40051CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private bool m_isArrowActive;

	[Token(Token = "0x40051CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
	private bool m_waitPartySetting;

	[Token(Token = "0x40051CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private string m_waitChangeUID;

	[Token(Token = "0x40051D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private string m_changeUID;

	[Token(Token = "0x40051D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool isOnPressProcess;

	[Token(Token = "0x6007356")]
	[Address(RVA = "0x15F18DC", Offset = "0x15F18DC", VA = "0x15F18DC")]
	public XWidget_DragDropPartyViewer()
	{
	}

	[Token(Token = "0x6007357")]
	[Address(RVA = "0x15F19E0", Offset = "0x15F19E0", VA = "0x15F19E0", Slot = "4")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6007358")]
	[Address(RVA = "0x15F1E00", Offset = "0x15F1E00", VA = "0x15F1E00")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6007359")]
	[Address(RVA = "0x15F1E54", Offset = "0x15F1E54", VA = "0x15F1E54")]
	public void SetWaitPartySetting(bool isWait, [Optional] string changeUID)
	{
	}

	[Token(Token = "0x600735A")]
	[Address(RVA = "0x15F1E04", Offset = "0x15F1E04", VA = "0x15F1E04")]
	public void OnClick_DropOtherArea()
	{
	}

	[Token(Token = "0x600735B")]
	[Address(RVA = "0x15F1EA4", Offset = "0x15F1EA4", VA = "0x15F1EA4")]
	public void PartySetting(string prevUID, string changeUID)
	{
	}

	[Token(Token = "0x600735C")]
	[Address(RVA = "0x15F2600", Offset = "0x15F2600", VA = "0x15F2600")]
	public void PlayPartyJoinSound(string charUID)
	{
	}

	[Token(Token = "0x600735D")]
	[Address(RVA = "0x15F1B94", Offset = "0x15F1B94", VA = "0x15F1B94")]
	public void SetActiveArrow(bool isActive, [Optional] string draggingCharUID)
	{
	}

	[Token(Token = "0x600735E")]
	[Address(RVA = "0x15F26EC", Offset = "0x15F26EC", VA = "0x15F26EC", Slot = "5")]
	public override void BuildParty(CharPartyId IdNum)
	{
	}

	[Token(Token = "0x600735F")]
	[Address(RVA = "0x15F2718", Offset = "0x15F2718", VA = "0x15F2718")]
	public void OnClickChangePartySetting(XWidget_CharacterDropArea dropArea)
	{
	}

	[Token(Token = "0x6007360")]
	[Address(RVA = "0x15F2900", Offset = "0x15F2900", VA = "0x15F2900")]
	public void OnPressPartySetting(XWidget_CharacterDropArea dropArea)
	{
	}

	[Token(Token = "0x6007361")]
	[Address(RVA = "0x15F2A10", Offset = "0x15F2A10", VA = "0x15F2A10")]
	private void _003CAwake_003Em__4A1()
	{
	}
}
