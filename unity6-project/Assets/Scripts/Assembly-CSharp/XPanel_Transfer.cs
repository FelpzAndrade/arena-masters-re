using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E37")]
public class XPanel_Transfer : MonoBehaviour, IUIBackbutton, IBackbutton
{
	[Token(Token = "0x4004ADE")]
	[FieldOffset(Offset = "0xC")]
	public GameObject requestTransfer;

	[Token(Token = "0x4004ADF")]
	[FieldOffset(Offset = "0x10")]
	public GameObject completeTransfer;

	[Token(Token = "0x4004AE0")]
	[FieldOffset(Offset = "0x14")]
	public UISprite scrollViewBG;

	[Token(Token = "0x4004AE1")]
	[FieldOffset(Offset = "0x18")]
	public UIScrollView scrollView;

	[Token(Token = "0x4004AE2")]
	[FieldOffset(Offset = "0x1C")]
	public BoxCollider scrollBarBGCollider;

	[Token(Token = "0x4004AE3")]
	[FieldOffset(Offset = "0x20")]
	public GameObject explanation;

	[Token(Token = "0x4004AE4")]
	[FieldOffset(Offset = "0x24")]
	public UILabel lblRequestTitle;

	[Token(Token = "0x4004AE5")]
	[FieldOffset(Offset = "0x28")]
	public UILabel lblBtnRequest;

	[Token(Token = "0x4004AE6")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel lblComboBoxPrivacyAgree;

	[Token(Token = "0x4004AE7")]
	[FieldOffset(Offset = "0x30")]
	public GameObject comboBoxPrivacyAgree;

	[Token(Token = "0x4004AE8")]
	[FieldOffset(Offset = "0x34")]
	public UILabel lblComboBoxTransferAgree;

	[Token(Token = "0x4004AE9")]
	[FieldOffset(Offset = "0x38")]
	public GameObject comboBoxTransferAgree;

	[Token(Token = "0x4004AEA")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel lblTransferRequestContent;

	[Token(Token = "0x4004AEB")]
	[FieldOffset(Offset = "0x40")]
	public UILabel lblPrivacyAgreeTitle;

	[Token(Token = "0x4004AEC")]
	[FieldOffset(Offset = "0x44")]
	public UILabel lblPrivacyAgreeMsg;

	[Token(Token = "0x4004AED")]
	[FieldOffset(Offset = "0x48")]
	public UILabel lblPrivacyAgreeGoal;

	[Token(Token = "0x4004AEE")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel lblTransferAgreeTitle;

	[Token(Token = "0x4004AEF")]
	[FieldOffset(Offset = "0x50")]
	public UILabel lblTransferAgreeMsg;

	[Token(Token = "0x4004AF0")]
	[FieldOffset(Offset = "0x54")]
	public UILabel lblTransferAgreeTopic;

	[Token(Token = "0x4004AF1")]
	[FieldOffset(Offset = "0x58")]
	public UILabel lblTransferAgreeNotice;

	[Token(Token = "0x4004AF2")]
	[FieldOffset(Offset = "0x5C")]
	private bool privacyAgree;

	[Token(Token = "0x4004AF3")]
	[FieldOffset(Offset = "0x5D")]
	private bool transferAgree;

	[Token(Token = "0x4004AF4")]
	[FieldOffset(Offset = "0x60")]
	public UILabel lblTransferKey;

	[Token(Token = "0x4004AF5")]
	[FieldOffset(Offset = "0x64")]
	public UIInput inputEmail;

	[Token(Token = "0x4004AF6")]
	[FieldOffset(Offset = "0x68")]
	private bool isGoToComplete;

	[Token(Token = "0x4004AF7")]
	[FieldOffset(Offset = "0x6C")]
	private UserTransferData transferData;

	[Token(Token = "0x60069C5")]
	[Address(RVA = "0xAD4C1C", Offset = "0xAD4C1C", VA = "0xAD4C1C")]
	public XPanel_Transfer()
	{
	}

	[Token(Token = "0x60069C6")]
	[Address(RVA = "0xAD4D14", Offset = "0xAD4D14", VA = "0xAD4D14")]
	public void Show(UserTransferData _transferData)
	{
	}

	[Token(Token = "0x60069C7")]
	[Address(RVA = "0xAD4D98", Offset = "0xAD4D98", VA = "0xAD4D98")]
	private void Refresh()
	{
	}

	[Token(Token = "0x60069C8")]
	[Address(RVA = "0xAD4EB8", Offset = "0xAD4EB8", VA = "0xAD4EB8")]
	private void SetUIRequestTransfer()
	{
	}

	[Token(Token = "0x60069C9")]
	[Address(RVA = "0xAD4E34", Offset = "0xAD4E34", VA = "0xAD4E34")]
	private void SetUICompleteTransfer()
	{
	}

	[Token(Token = "0x60069CA")]
	[Address(RVA = "0xAD5ED0", Offset = "0xAD5ED0", VA = "0xAD5ED0")]
	public void OnClickClose()
	{
	}

	[Token(Token = "0x60069CB")]
	[Address(RVA = "0xAD5F08", Offset = "0xAD5F08", VA = "0xAD5F08", Slot = "4")]
	public bool IsActive()
	{
		return default(bool);
	}

	[Token(Token = "0x60069CC")]
	[Address(RVA = "0xAD5ED4", Offset = "0xAD5ED4", VA = "0xAD5ED4", Slot = "5")]
	public void OnHide()
	{
	}

	[Token(Token = "0x60069CD")]
	[Address(RVA = "0xAD5D48", Offset = "0xAD5D48", VA = "0xAD5D48")]
	public void OnClickPrivacyAgree()
	{
	}

	[Token(Token = "0x60069CE")]
	[Address(RVA = "0xAD5E0C", Offset = "0xAD5E0C", VA = "0xAD5E0C")]
	public void OnClickTransferAgree()
	{
	}

	[Token(Token = "0x60069CF")]
	[Address(RVA = "0xAD5F38", Offset = "0xAD5F38", VA = "0xAD5F38")]
	public void OnClickRequest()
	{
	}

	[Token(Token = "0x60069D0")]
	[Address(RVA = "0xAD61CC", Offset = "0xAD61CC", VA = "0xAD61CC")]
	public void OnClickCopy()
	{
	}

	[Token(Token = "0x60069D1")]
	[Address(RVA = "0xAD632C", Offset = "0xAD632C", VA = "0xAD632C")]
	public void OnClickComplete()
	{
	}

	[Token(Token = "0x60069D2")]
	[Address(RVA = "0xAD61BC", Offset = "0xAD61BC", VA = "0xAD61BC")]
	public void UserTransferDataSuccessCallback(UserTransferData _userTransferData)
	{
	}

	[Token(Token = "0x60069D3")]
	[Address(RVA = "0xAD654C", Offset = "0xAD654C", VA = "0xAD654C")]
	private void _003COnClickComplete_003Em__3D3()
	{
	}
}
