using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000DB7")]
public class XPanel_ChallengeMain : MonoBehaviour
{
	[Token(Token = "0x2000DB8")]
	private sealed class _003CAwake_003Ec__AnonStorey1B7
	{
		[Token(Token = "0x4004731")]
		[FieldOffset(Offset = "0x8")]
		internal XUIEnterButton missionBtn;

		[Token(Token = "0x4004732")]
		[FieldOffset(Offset = "0xC")]
		internal XPanel_ChallengeMain _003C_003Ef__this;

		[Token(Token = "0x60064ED")]
		[Address(RVA = "0x1698EA4", Offset = "0x1698EA4", VA = "0x1698EA4")]
		public _003CAwake_003Ec__AnonStorey1B7()
		{
		}

		[Token(Token = "0x60064EE")]
		[Address(RVA = "0x169911C", Offset = "0x169911C", VA = "0x169911C")]
		internal void _003C_003Em__337()
		{
		}
	}

	[Token(Token = "0x400472D")]
	[FieldOffset(Offset = "0xC")]
	public UIScrollView scrollView;

	[Token(Token = "0x400472E")]
	[FieldOffset(Offset = "0x10")]
	public XWiget_GridBuilder enterBuilder;

	[Token(Token = "0x400472F")]
	[FieldOffset(Offset = "0x14")]
	public List<XUIEnterButton> enterBtns;

	[Token(Token = "0x4004730")]
	[FieldOffset(Offset = "0x18")]
	public XTutorialObjContainer tutoObjContainer;

	[Token(Token = "0x60064E4")]
	[Address(RVA = "0x169893C", Offset = "0x169893C", VA = "0x169893C")]
	public XPanel_ChallengeMain()
	{
	}

	[Token(Token = "0x60064E5")]
	[Address(RVA = "0x16989E8", Offset = "0x16989E8", VA = "0x16989E8")]
	private void OnNetdataUpdated_Userdata(object arg)
	{
	}

	[Token(Token = "0x60064E6")]
	[Address(RVA = "0x1698B10", Offset = "0x1698B10", VA = "0x1698B10")]
	private void Awake()
	{
	}

	[Token(Token = "0x60064E7")]
	[Address(RVA = "0x1698EAC", Offset = "0x1698EAC", VA = "0x1698EAC")]
	public void Show()
	{
	}

	[Token(Token = "0x60064E8")]
	[Address(RVA = "0x1698EFC", Offset = "0x1698EFC", VA = "0x1698EFC")]
	public void RefreshTween()
	{
	}

	[Token(Token = "0x60064E9")]
	[Address(RVA = "0x16989EC", Offset = "0x16989EC", VA = "0x16989EC")]
	public void Refresh()
	{
	}

	[Token(Token = "0x60064EA")]
	[Address(RVA = "0x1698F00", Offset = "0x1698F00", VA = "0x1698F00")]
	private int GetUnLockLv(string type)
	{
		return default(int);
	}

	[Token(Token = "0x60064EB")]
	[Address(RVA = "0x1699008", Offset = "0x1699008", VA = "0x1699008")]
	public void Hide()
	{
	}

	[Token(Token = "0x60064EC")]
	[Address(RVA = "0x169903C", Offset = "0x169903C", VA = "0x169903C")]
	private void ChangeSelectGameMode(XGameModeType type)
	{
	}
}
