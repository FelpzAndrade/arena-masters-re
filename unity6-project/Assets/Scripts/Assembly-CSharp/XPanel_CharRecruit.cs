using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using UnityEngine;

[Token(Token = "0x2000DC4")]
public class XPanel_CharRecruit : MonoBehaviour
{
	[Token(Token = "0x2000DC5")]
	private sealed class _003CSelectCharacter_003Ec__AnonStorey1BE
	{
		[Token(Token = "0x400479C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal XWidget_SkillIconSelect skillWidget;

		[Token(Token = "0x400479D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal CSCharacterSkillInfo charSkillInfo;

		[Token(Token = "0x400479E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal XPanel_CharRecruit _003C_003Ef__this;

		[Token(Token = "0x6006567")]
		[Address(RVA = "0x16A2274", Offset = "0x16A2274", VA = "0x16A2274")]
		public _003CSelectCharacter_003Ec__AnonStorey1BE()
		{
		}

		[Token(Token = "0x6006568")]
		[Address(RVA = "0x16A2D84", Offset = "0x16A2D84", VA = "0x16A2D84")]
		internal void _003C_003Em__34A()
		{
		}
	}

	[Token(Token = "0x400478A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public XWiget_GridBuilder gridCharacters;

	[Token(Token = "0x400478B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private Dictionary<int, XModuleActor> m_characterDic;

	[Token(Token = "0x400478C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private XWidget_CharItem[] m_characterItems;

	[Token(Token = "0x400478D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public UITexture texture;

	[Token(Token = "0x400478E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private RenderTexture m_rt;

	[Token(Token = "0x400478F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public UILabel lblIntro;

	[Token(Token = "0x4004790")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public UILabel lblCharName;

	[Token(Token = "0x4004791")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public UILabel lblCharTitle;

	[Token(Token = "0x4004792")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public UILabel lblFigthingMsg;

	[Token(Token = "0x4004793")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public UI2DSprite sprBG;

	[Token(Token = "0x4004794")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public string sprBGPath;

	[Token(Token = "0x4004795")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private XModuleActor m_selectedCharacterActor;

	[Token(Token = "0x4004796")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private XWidget_SkillIconSelect[] widgetCharSkills;

	[Token(Token = "0x4004797")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public XWiget_GridBuilder gridSkillBuilder;

	[Token(Token = "0x4004798")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public UILabel lblSkillName;

	[Token(Token = "0x4004799")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public UILabel lblSkillDesc;

	[Token(Token = "0x400479A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private XPanel_CardDirectionRoot cardDirectionRoot;

	[Token(Token = "0x400479B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Action m_endAction;

	[Token(Token = "0x17000D56")]
	private XUIModelPreview m_ModelPreview
	{
		[Token(Token = "0x6006559")]
		[Address(RVA = "0x16A0F50", Offset = "0x16A0F50", VA = "0x16A0F50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006558")]
	[Address(RVA = "0x16A0EA4", Offset = "0x16A0EA4", VA = "0x16A0EA4")]
	public XPanel_CharRecruit()
	{
	}

	[Token(Token = "0x600655A")]
	[Address(RVA = "0x16A1024", Offset = "0x16A1024", VA = "0x16A1024")]
	public void CreateCharacterData()
	{
	}

	[Token(Token = "0x600655B")]
	[Address(RVA = "0x16A15D8", Offset = "0x16A15D8", VA = "0x16A15D8")]
	public void BuildRecruitCharacter()
	{
	}

	[Token(Token = "0x600655C")]
	[Address(RVA = "0x16A1B84", Offset = "0x16A1B84", VA = "0x16A1B84")]
	private void ShowModelPreview(XModuleActor characterActor, bool playIntro = false)
	{
	}

	[Token(Token = "0x600655D")]
	[Address(RVA = "0x16A1C24", Offset = "0x16A1C24", VA = "0x16A1C24")]
	private void InitRenderTexture()
	{
	}

	[Token(Token = "0x600655E")]
	[Address(RVA = "0x16A1C98", Offset = "0x16A1C98", VA = "0x16A1C98")]
	private void ReleaseRenderTexture()
	{
	}

	[Token(Token = "0x600655F")]
	[Address(RVA = "0x16A1D0C", Offset = "0x16A1D0C", VA = "0x16A1D0C")]
	private void SelectCharacter(int selectCharID)
	{
	}

	[Token(Token = "0x6006560")]
	[Address(RVA = "0x16A1A64", Offset = "0x16A1A64", VA = "0x16A1A64")]
	public void Hide()
	{
	}

	[Token(Token = "0x6006561")]
	[Address(RVA = "0x16A227C", Offset = "0x16A227C", VA = "0x16A227C")]
	public void Show([Optional] Action endAction)
	{
	}

	[Token(Token = "0x6006562")]
	[Address(RVA = "0x16A2404", Offset = "0x16A2404", VA = "0x16A2404")]
	public void OnClick_GetCharacter()
	{
	}

	[Token(Token = "0x6006563")]
	[Address(RVA = "0x16A26D0", Offset = "0x16A26D0", VA = "0x16A26D0")]
	private void SendProtocol_GetTutorialCharacter()
	{
	}

	[Token(Token = "0x6006564")]
	[Address(RVA = "0x16A29B8", Offset = "0x16A29B8", VA = "0x16A29B8")]
	private void ShowCardDirection()
	{
	}

	[Token(Token = "0x6006565")]
	[Address(RVA = "0x16A2B84", Offset = "0x16A2B84", VA = "0x16A2B84")]
	private void _003CSendProtocol_GetTutorialCharacter_003Em__34B(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
	{
	}

	[Token(Token = "0x6006566")]
	[Address(RVA = "0x16A2D58", Offset = "0x16A2D58", VA = "0x16A2D58")]
	private void _003CShowCardDirection_003Em__34C()
	{
	}
}
