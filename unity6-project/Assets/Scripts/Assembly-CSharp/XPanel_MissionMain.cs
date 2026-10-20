using System.Collections.Generic;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000DFA")]
public class XPanel_MissionMain : MonoBehaviour
{
	[Token(Token = "0x2000DFB")]
	private class StageGroupCooker
	{
		[Token(Token = "0x400494E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private Dictionary<int, List<CSStageInfo>> m_stageGroupDic;

		[Token(Token = "0x400494F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private int m_curGroup;

		[Token(Token = "0x17000D76")]
		public int CurTheme
		{
			[Token(Token = "0x60067D4")]
			[Address(RVA = "0x1007AF8", Offset = "0x1007AF8", VA = "0x1007AF8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60067D3")]
		[Address(RVA = "0x1007574", Offset = "0x1007574", VA = "0x1007574")]
		public StageGroupCooker(CSStageGameModeType stageMode, int initGroup)
		{
		}

		[Token(Token = "0x60067D5")]
		[Address(RVA = "0x1008B14", Offset = "0x1008B14", VA = "0x1008B14")]
		public List<CSStageInfo> GetGroup(int group)
		{
			return null;
		}

		[Token(Token = "0x60067D6")]
		[Address(RVA = "0x10084E4", Offset = "0x10084E4", VA = "0x10084E4")]
		public List<CSStageInfo> GetPreviousGroup()
		{
			return null;
		}

		[Token(Token = "0x60067D7")]
		[Address(RVA = "0x1008640", Offset = "0x1008640", VA = "0x1008640")]
		public List<CSStageInfo> GetNextGroup()
		{
			return null;
		}

		[Token(Token = "0x60067D8")]
		[Address(RVA = "0x1006CAC", Offset = "0x1006CAC", VA = "0x1006CAC")]
		public List<CSStageInfo> GetCurGroup()
		{
			return null;
		}

		[Token(Token = "0x60067D9")]
		[Address(RVA = "0x1007B00", Offset = "0x1007B00", VA = "0x1007B00")]
		public bool IsExitGroup(int group)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000DFC")]
	private sealed class _003CBuildStage_003Ec__AnonStorey1D7
	{
		[Token(Token = "0x4004950")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal List<CSStageInfo> stageGroup;

		[Token(Token = "0x4004951")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal XPanel_MissionMain _003C_003Ef__this;

		[Token(Token = "0x60067DA")]
		[Address(RVA = "0x1007BA0", Offset = "0x1007BA0", VA = "0x1007BA0")]
		public _003CBuildStage_003Ec__AnonStorey1D7()
		{
		}

		[Token(Token = "0x60067DB")]
		[Address(RVA = "0x100884C", Offset = "0x100884C", VA = "0x100884C")]
		internal void _003C_003Em__396()
		{
		}
	}

	[Token(Token = "0x400493E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public UILabel lblMapName;

	[Token(Token = "0x400493F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public UILabel lblDifficulty;

	[Token(Token = "0x4004940")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public XWiget_GridBuilder gridStageLists;

	[Token(Token = "0x4004941")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public XWidget_MissionStageItem[] stageElements;

	[Token(Token = "0x4004942")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public UIScrollView scrollView;

	[Token(Token = "0x4004943")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public SpringPanel scrollViewSpring;

	[Token(Token = "0x4004944")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private StageGroupCooker m_stageGroupCooker;

	[Token(Token = "0x4004945")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private UserDataBase m_userData;

	[Token(Token = "0x4004946")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private CSStageLogic m_svcStage;

	[Token(Token = "0x4004947")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject goNext;

	[Token(Token = "0x4004948")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public GameObject goPrev;

	[Token(Token = "0x4004949")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public XTutorialObjContainer pnlTutorial;

	[Token(Token = "0x400494A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private int? m_group;

	[Token(Token = "0x400494B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private float scrollOffsetY;

	[Token(Token = "0x400494C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int m_firstShowGroup;

	[Token(Token = "0x400494D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private bool m_isFirstScroll;

	[Token(Token = "0x60067C3")]
	[Address(RVA = "0x1006BEC", Offset = "0x1006BEC", VA = "0x1006BEC")]
	public XPanel_MissionMain()
	{
	}

	[Token(Token = "0x60067C4")]
	[Address(RVA = "0x1006BFC", Offset = "0x1006BFC", VA = "0x1006BFC")]
	private void Start()
	{
	}

	[Token(Token = "0x60067C5")]
	[Address(RVA = "0x1006C58", Offset = "0x1006C58", VA = "0x1006C58")]
	private void OnNetdataUpdated_ClearTicket(object arg)
	{
	}

	[Token(Token = "0x60067C6")]
	[Address(RVA = "0x1007354", Offset = "0x1007354", VA = "0x1007354")]
	public void Show(CSStageGameModeType stageType, UserDataBase userData, int charLev, CSStageLogic svcStage, [Optional] int? group)
	{
	}

	[Token(Token = "0x60067C7")]
	[Address(RVA = "0x1007380", Offset = "0x1007380", VA = "0x1007380")]
	private void Build(CSStageGameModeType stageType, UserDataBase userData, int charLev, CSStageLogic svcStage, [Optional] int? group)
	{
	}

	[Token(Token = "0x60067C8")]
	[Address(RVA = "0x1007698", Offset = "0x1007698", VA = "0x1007698")]
	private void BuildStageGroup(List<CSStageInfo> stageGroup)
	{
	}

	[Token(Token = "0x60067C9")]
	[Address(RVA = "0x1007974", Offset = "0x1007974", VA = "0x1007974")]
	public void BuildMoveBtn()
	{
	}

	[Token(Token = "0x60067CA")]
	[Address(RVA = "0x1006CB4", Offset = "0x1006CB4", VA = "0x1006CB4")]
	private void BuildStage(List<CSStageInfo> stageGroup, UserDataBase userData, CSStageLogic svcStage, bool reScrollPos = true)
	{
	}

	[Token(Token = "0x60067CB")]
	[Address(RVA = "0x1007BA8", Offset = "0x1007BA8", VA = "0x1007BA8")]
	private void MoveScroll(int groupCnt, int lastSelectElementIdx)
	{
	}

	[Token(Token = "0x60067CC")]
	[Address(RVA = "0x1007FBC", Offset = "0x1007FBC", VA = "0x1007FBC")]
	public void RefreshStageElements()
	{
	}

	[Token(Token = "0x60067CD")]
	[Address(RVA = "0x1008010", Offset = "0x1008010", VA = "0x1008010")]
	private void OnNetdataUpdated_Userdata(object arg)
	{
	}

	[Token(Token = "0x60067CE")]
	[Address(RVA = "0x1008390", Offset = "0x1008390", VA = "0x1008390")]
	public void OnClickPrevious()
	{
	}

	[Token(Token = "0x60067CF")]
	[Address(RVA = "0x1008500", Offset = "0x1008500", VA = "0x1008500")]
	public void OnClickNext()
	{
	}

	[Token(Token = "0x60067D0")]
	[Address(RVA = "0x1008700", Offset = "0x1008700", VA = "0x1008700")]
	public void OnClickShop()
	{
	}

	[Token(Token = "0x60067D1")]
	[Address(RVA = "0x10087D8", Offset = "0x10087D8", VA = "0x10087D8")]
	public void Show()
	{
	}

	[Token(Token = "0x60067D2")]
	[Address(RVA = "0x1008818", Offset = "0x1008818", VA = "0x1008818")]
	public void Hide()
	{
	}
}
