using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using UnityEngine;

[Token(Token = "0x2000DC2")]
public class XPanel_CharMain : MonoBehaviour
{
	[Token(Token = "0x2000DC3")]
	private sealed class _003COnClick_GetCharacter_003Ec__AnonStorey1BD
	{
		[Token(Token = "0x4004787")]
		[FieldOffset(Offset = "0x8")]
		internal XModuleActor character;

		[Token(Token = "0x4004788")]
		[FieldOffset(Offset = "0xC")]
		internal XModuleActor.CreationDesc characterDescription;

		[Token(Token = "0x4004789")]
		[FieldOffset(Offset = "0x10")]
		internal XPanel_CharMain _003C_003Ef__this;

		[Token(Token = "0x6006555")]
		[Address(RVA = "0x16A04B4", Offset = "0x16A04B4", VA = "0x16A04B4")]
		public _003COnClick_GetCharacter_003Ec__AnonStorey1BD()
		{
		}

		[Token(Token = "0x6006556")]
		[Address(RVA = "0x16A09FC", Offset = "0x16A09FC", VA = "0x16A09FC")]
		internal void _003C_003Em__347()
		{
		}

		[Token(Token = "0x6006557")]
		[Address(RVA = "0x16A0D80", Offset = "0x16A0D80", VA = "0x16A0D80")]
		internal void _003C_003Em__349(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
		{
		}
	}

	[Token(Token = "0x400477F")]
	[FieldOffset(Offset = "0xC")]
	public XWidget_DragDropPartyViewer partyViewer;

	[Token(Token = "0x4004780")]
	[FieldOffset(Offset = "0x10")]
	private bool isDirectingGetCard;

	[Token(Token = "0x4004781")]
	[FieldOffset(Offset = "0x14")]
	public XUICharInventory pnlCharInventory;

	[Token(Token = "0x4004782")]
	[FieldOffset(Offset = "0x18")]
	public UILabel lblOwnCharacter;

	[Token(Token = "0x4004783")]
	[FieldOffset(Offset = "0x1C")]
	private XPanel_CardDirectionRoot cardDirectionRoot;

	[Token(Token = "0x4004784")]
	[FieldOffset(Offset = "0x20")]
	public XTutorialObjContainer tutorialPanel;

	[Token(Token = "0x4004785")]
	[FieldOffset(Offset = "0x24")]
	private UIDirector m_directions;

	[Token(Token = "0x4004786")]
	[FieldOffset(Offset = "0x28")]
	public XUIModelPreviewDragZone tutoActiveModel;

	[Token(Token = "0x17000D55")]
	public bool IsDirectingGetCard
	{
		[Token(Token = "0x6006543")]
		[Address(RVA = "0x169F750", Offset = "0x169F750", VA = "0x169F750")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6006542")]
	[Address(RVA = "0x169F6B0", Offset = "0x169F6B0", VA = "0x169F6B0")]
	public XPanel_CharMain()
	{
	}

	[Token(Token = "0x6006544")]
	[Address(RVA = "0x169F758", Offset = "0x169F758", VA = "0x169F758")]
	public void BuildCharacterInventory()
	{
	}

	[Token(Token = "0x6006545")]
	[Address(RVA = "0x169FB64", Offset = "0x169FB64", VA = "0x169FB64")]
	public void Show()
	{
	}

	[Token(Token = "0x6006546")]
	[Address(RVA = "0x169FE30", Offset = "0x169FE30", VA = "0x169FE30")]
	public void ShowPartySetting(string selectUID)
	{
	}

	[Token(Token = "0x6006547")]
	[Address(RVA = "0x169FE70", Offset = "0x169FE70", VA = "0x169FE70")]
	public void Hide()
	{
	}

	[Token(Token = "0x6006548")]
	[Address(RVA = "0x169FFB8", Offset = "0x169FFB8", VA = "0x169FFB8")]
	private void OnNetdataUpdated_CharacterList(object arg)
	{
	}

	[Token(Token = "0x6006549")]
	[Address(RVA = "0x16A00E0", Offset = "0x16A00E0", VA = "0x16A00E0")]
	private void Update()
	{
	}

	[Token(Token = "0x600654A")]
	[Address(RVA = "0x16A010C", Offset = "0x16A010C", VA = "0x16A010C")]
	public void SelectedCharacterDetail(int nCharID, string actorUID)
	{
	}

	[Token(Token = "0x600654B")]
	[Address(RVA = "0x16A0200", Offset = "0x16A0200", VA = "0x16A0200")]
	private void SelectCharacter(XWidget_CharacterCard character)
	{
	}

	[Token(Token = "0x600654C")]
	[Address(RVA = "0x16A0310", Offset = "0x16A0310", VA = "0x16A0310")]
	public void EndGetCardDirection()
	{
	}

	[Token(Token = "0x600654D")]
	[Address(RVA = "0x16A031C", Offset = "0x16A031C", VA = "0x16A031C")]
	public void OnClick_GetCharacter(XModuleActor character)
	{
	}

	[Token(Token = "0x600654E")]
	[Address(RVA = "0x16A04BC", Offset = "0x16A04BC", VA = "0x16A04BC")]
	private void ShowCardDirection(XModuleActor.CreationDesc characterDescription)
	{
	}

	[Token(Token = "0x600654F")]
	[Address(RVA = "0x16A0678", Offset = "0x16A0678", VA = "0x16A0678")]
	public void OnClick_Help()
	{
	}

	[Token(Token = "0x6006550")]
	[Address(RVA = "0x169FA54", Offset = "0x169FA54", VA = "0x169FA54")]
	public void SetTutorialObject()
	{
	}

	[Token(Token = "0x6006551")]
	[Address(RVA = "0x16A0750", Offset = "0x16A0750", VA = "0x16A0750")]
	private void _003CBuildCharacterInventory_003Em__344(object obj)
	{
	}

	[Token(Token = "0x6006552")]
	[Address(RVA = "0x16A0808", Offset = "0x16A0808", VA = "0x16A0808")]
	private void _003CBuildCharacterInventory_003Em__345(object dragObj)
	{
	}

	[Token(Token = "0x6006553")]
	[Address(RVA = "0x16A0970", Offset = "0x16A0970", VA = "0x16A0970")]
	private void _003CBuildCharacterInventory_003Em__346()
	{
	}

	[Token(Token = "0x6006554")]
	[Address(RVA = "0x16A09A4", Offset = "0x16A09A4", VA = "0x16A09A4")]
	private void _003CSetTutorialObject_003Em__348()
	{
	}
}
