using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000FFF")]
public class XWidget_TeamTalentGroup : MonoBehaviour
{
	[Token(Token = "0x2001000")]
	private sealed class _003CGetItem_003Ec__AnonStorey254
	{
		[Token(Token = "0x4005574")]
		[FieldOffset(Offset = "0x8")]
		internal int id;

		[Token(Token = "0x6007762")]
		[Address(RVA = "0x1B227B0", Offset = "0x1B227B0", VA = "0x1B227B0")]
		public _003CGetItem_003Ec__AnonStorey254()
		{
		}

		[Token(Token = "0x6007763")]
		[Address(RVA = "0x1B227B8", Offset = "0x1B227B8", VA = "0x1B227B8")]
		internal bool _003C_003Em__4FA(XUITeamTalentItem x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4005571")]
	[FieldOffset(Offset = "0xC")]
	private List<XUITeamTalentItem> xTalentItem;

	[Token(Token = "0x4005572")]
	[FieldOffset(Offset = "0x10")]
	private int GamutLineCount;

	[Token(Token = "0x4005573")]
	[FieldOffset(Offset = "0x14")]
	private Action<TalentInfo> m_action;

	[Token(Token = "0x17000EEA")]
	private string m_BookItemPrefabPath
	{
		[Token(Token = "0x600775D")]
		[Address(RVA = "0x1B22738", Offset = "0x1B22738", VA = "0x1B22738")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600775C")]
	[Address(RVA = "0x1B2268C", Offset = "0x1B2268C", VA = "0x1B2268C")]
	public XWidget_TeamTalentGroup()
	{
	}

	[Token(Token = "0x600775E")]
	[Address(RVA = "0x1B1EE38", Offset = "0x1B1EE38", VA = "0x1B1EE38")]
	public void Init(int createCount, Action<TalentInfo> action)
	{
	}

	[Token(Token = "0x600775F")]
	[Address(RVA = "0x1B1F258", Offset = "0x1B1F258", VA = "0x1B1F258")]
	public void Build(List<TalentInfo> list, Action<XUITeamTalentItem> itemAction, string pageNumber)
	{
	}

	[Token(Token = "0x6007760")]
	[Address(RVA = "0x1B21B50", Offset = "0x1B21B50", VA = "0x1B21B50")]
	public XUITeamTalentItem GetItem(int id)
	{
		return null;
	}

	[Token(Token = "0x6007761")]
	[Address(RVA = "0x1B1DF2C", Offset = "0x1B1DF2C", VA = "0x1B1DF2C")]
	public XUITeamTalentItem GetItemByIndex(int index)
	{
		return null;
	}
}
