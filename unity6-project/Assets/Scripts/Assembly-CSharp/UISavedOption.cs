using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001EF")]
public class UISavedOption : MonoBehaviour
{
	[Token(Token = "0x40007F1")]
	[FieldOffset(Offset = "0xC")]
	public string keyName;

	[Token(Token = "0x40007F2")]
	[FieldOffset(Offset = "0x10")]
	private UIPopupList mList;

	[Token(Token = "0x40007F3")]
	[FieldOffset(Offset = "0x14")]
	private UIToggle mCheck;

	[Token(Token = "0x40007F4")]
	[FieldOffset(Offset = "0x18")]
	private UIProgressBar mSlider;

	[Token(Token = "0x17000272")]
	private string key
	{
		[Token(Token = "0x600106E")]
		[Address(RVA = "0x1793A58", Offset = "0x1793A58", VA = "0x1793A58")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600106D")]
	[Address(RVA = "0x1793A50", Offset = "0x1793A50", VA = "0x1793A50")]
	public UISavedOption()
	{
	}

	[Token(Token = "0x600106F")]
	[Address(RVA = "0x1793B80", Offset = "0x1793B80", VA = "0x1793B80")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001070")]
	[Address(RVA = "0x1793C40", Offset = "0x1793C40", VA = "0x1793C40")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6001071")]
	[Address(RVA = "0x17941E0", Offset = "0x17941E0", VA = "0x17941E0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6001072")]
	[Address(RVA = "0x179450C", Offset = "0x179450C", VA = "0x179450C")]
	public void SaveSelection()
	{
	}

	[Token(Token = "0x6001073")]
	[Address(RVA = "0x1794620", Offset = "0x1794620", VA = "0x1794620")]
	public void SaveState()
	{
	}

	[Token(Token = "0x6001074")]
	[Address(RVA = "0x1794720", Offset = "0x1794720", VA = "0x1794720")]
	public void SaveProgress()
	{
	}
}
