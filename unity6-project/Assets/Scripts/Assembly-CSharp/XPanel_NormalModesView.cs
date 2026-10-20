using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000DFD")]
public class XPanel_NormalModesView : XUIBasePanel
{
	[Token(Token = "0x2000DFE")]
	private sealed class _003CAwake_003Ec__AnonStorey1D8
	{
		[Token(Token = "0x400495C")]
		[FieldOffset(Offset = "0x8")]
		internal Dictionary<int, string> modeNameLocaleKeyDic;

		[Token(Token = "0x400495D")]
		[FieldOffset(Offset = "0xC")]
		internal int myLevel;

		[Token(Token = "0x400495E")]
		[FieldOffset(Offset = "0x10")]
		internal XPanel_NormalModesView _003C_003Ef__this;

		[Token(Token = "0x60067E6")]
		[Address(RVA = "0x1009544", Offset = "0x1009544", VA = "0x1009544")]
		public _003CAwake_003Ec__AnonStorey1D8()
		{
		}

		[Token(Token = "0x60067E7")]
		[Address(RVA = "0x100AF38", Offset = "0x100AF38", VA = "0x100AF38")]
		internal void _003C_003Em__397()
		{
		}
	}

	[Token(Token = "0x2000DFF")]
	private sealed class _003CBuildNormalUI_003Ec__AnonStorey1D9
	{
		[Token(Token = "0x400495F")]
		[FieldOffset(Offset = "0x8")]
		internal GameModeInstanceInfo instanceInfo;

		[Token(Token = "0x60067E8")]
		[Address(RVA = "0x100990C", Offset = "0x100990C", VA = "0x100990C")]
		public _003CBuildNormalUI_003Ec__AnonStorey1D9()
		{
		}

		[Token(Token = "0x60067E9")]
		[Address(RVA = "0x100B7D4", Offset = "0x100B7D4", VA = "0x100B7D4")]
		internal void _003C_003Em__398()
		{
		}
	}

	[Token(Token = "0x2000E00")]
	private sealed class _003CBuildEventUI_003Ec__AnonStorey1DA
	{
		[Token(Token = "0x4004960")]
		[FieldOffset(Offset = "0x8")]
		internal XUIEventModeElement modeUI;

		[Token(Token = "0x4004961")]
		[FieldOffset(Offset = "0xC")]
		internal XPanel_NormalModesView _003C_003Ef__this;

		[Token(Token = "0x60067EA")]
		[Address(RVA = "0x1009E94", Offset = "0x1009E94", VA = "0x1009E94")]
		public _003CBuildEventUI_003Ec__AnonStorey1DA()
		{
		}

		[Token(Token = "0x60067EB")]
		[Address(RVA = "0x100B3B0", Offset = "0x100B3B0", VA = "0x100B3B0")]
		internal void _003C_003Em__399()
		{
		}

		[Token(Token = "0x60067EC")]
		[Address(RVA = "0x100B600", Offset = "0x100B600", VA = "0x100B600")]
		internal void _003C_003Em__39A()
		{
		}

		[Token(Token = "0x60067ED")]
		[Address(RVA = "0x100B6F8", Offset = "0x100B6F8", VA = "0x100B6F8")]
		internal void _003C_003Em__39B()
		{
		}
	}

	[Token(Token = "0x4004952")]
	[FieldOffset(Offset = "0x10")]
	public UIScrollView scrollView;

	[Token(Token = "0x4004953")]
	[FieldOffset(Offset = "0x14")]
	public XWiget_GridBuilder builder;

	[Token(Token = "0x4004954")]
	[FieldOffset(Offset = "0x18")]
	public XWidget_Builder eventBuilder;

	[Token(Token = "0x4004955")]
	[FieldOffset(Offset = "0x1C")]
	public int buildItemViewCount;

	[Token(Token = "0x4004956")]
	[FieldOffset(Offset = "0x20")]
	public int commingsoonCount;

	[Token(Token = "0x4004957")]
	[FieldOffset(Offset = "0x24")]
	public XTutorialObjContainer tutoObjContainer;

	[Token(Token = "0x4004958")]
	[FieldOffset(Offset = "0x28")]
	public List<XUINormalModeElement> normalEnterBtns;

	[Token(Token = "0x4004959")]
	[FieldOffset(Offset = "0x2C")]
	public XUICustomRoom FrmCustomRoom;

	[Token(Token = "0x400495A")]
	[FieldOffset(Offset = "0x30")]
	private readonly string Path_eventEnterPopup;

	[Token(Token = "0x400495B")]
	[FieldOffset(Offset = "0x34")]
	private XWidget_EventEnterPopup _eventEnterPopup;

	[Token(Token = "0x17000D77")]
	public XWidget_EventEnterPopup EventRewardPopup
	{
		[Token(Token = "0x60067DD")]
		[Address(RVA = "0x1008F7C", Offset = "0x1008F7C", VA = "0x1008F7C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60067DC")]
	[Address(RVA = "0x1008EBC", Offset = "0x1008EBC", VA = "0x1008EBC")]
	public XPanel_NormalModesView()
	{
	}

	[Token(Token = "0x60067DE")]
	[Address(RVA = "0x100907C", Offset = "0x100907C", VA = "0x100907C")]
	private void SetGridPerLine(int builderCount)
	{
	}

	[Token(Token = "0x60067DF")]
	[Address(RVA = "0x10091A0", Offset = "0x10091A0", VA = "0x10091A0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60067E0")]
	[Address(RVA = "0x100954C", Offset = "0x100954C", VA = "0x100954C")]
	private void BuildNormalUI(XUINormalModeElement modeUI, GameModeInstanceInfo instanceInfo, string modeNameLocaleKey, int myLevel)
	{
	}

	[Token(Token = "0x60067E1")]
	[Address(RVA = "0x1009914", Offset = "0x1009914", VA = "0x1009914")]
	private void BuildEventUI(XUIEventModeElement modeUI, EventGameModeInfo eventModeInfo, bool isCurrent)
	{
	}

	[Token(Token = "0x60067E2")]
	[Address(RVA = "0x1009E9C", Offset = "0x1009E9C", VA = "0x1009E9C")]
	private bool IsExistRecievableFirstReward(EventGameModeInfo eventModeInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x60067E3")]
	[Address(RVA = "0x100A030", Offset = "0x100A030", VA = "0x100A030")]
	public void Show()
	{
	}

	[Token(Token = "0x60067E4")]
	[Address(RVA = "0x100A0E4", Offset = "0x100A0E4", VA = "0x100A0E4")]
	public void Refresh()
	{
	}

	[Token(Token = "0x60067E5")]
	[Address(RVA = "0x100A4FC", Offset = "0x100A4FC", VA = "0x100A4FC")]
	private void GetShowEventModeInfos(out List<EventGameModeInfo> curList, out List<EventGameModeInfo> nextList)
	{
		curList = default;
		nextList = default;
	}
}
