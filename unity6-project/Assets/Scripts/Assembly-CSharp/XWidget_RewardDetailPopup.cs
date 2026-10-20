using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000FDD")]
public class XWidget_RewardDetailPopup : XUIBaseWidget
{
	[Token(Token = "0x2000FDE")]
	public class Info
	{
		[Token(Token = "0x40054A7")]
		[FieldOffset(Offset = "0x8")]
		public string boxName;

		[Token(Token = "0x40054A8")]
		[FieldOffset(Offset = "0xC")]
		public List<ShowBoxInfo> showBoxInfoList;

		[Token(Token = "0x40054A9")]
		[FieldOffset(Offset = "0x10")]
		public string boxIconPath;

		[Token(Token = "0x6007662")]
		[Address(RVA = "0x13443DC", Offset = "0x13443DC", VA = "0x13443DC")]
		public Info()
		{
		}
	}

	[Token(Token = "0x400549D")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel lblTItle;

	[Token(Token = "0x400549E")]
	[FieldOffset(Offset = "0x20")]
	public UILabel lblRewardName;

	[Token(Token = "0x400549F")]
	[FieldOffset(Offset = "0x24")]
	public UI2DSprite sprRewardBox;

	[Token(Token = "0x40054A0")]
	[FieldOffset(Offset = "0x28")]
	public XWidget_DisplayShowBox showboxDisplay;

	[Token(Token = "0x40054A1")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel lblDescription;

	[Token(Token = "0x40054A2")]
	[FieldOffset(Offset = "0x30")]
	private List<Info> detailDatas;

	[Token(Token = "0x40054A3")]
	[FieldOffset(Offset = "0x34")]
	private int m_curShowIdx;

	[Token(Token = "0x40054A4")]
	[FieldOffset(Offset = "0x38")]
	private int m_curRecievableIdx;

	[Token(Token = "0x40054A5")]
	[FieldOffset(Offset = "0x3C")]
	private bool isSelect;

	[Token(Token = "0x40054A6")]
	[FieldOffset(Offset = "0x40")]
	private int m_selectIndex;

	[Token(Token = "0x6007658")]
	[Address(RVA = "0x1343FCC", Offset = "0x1343FCC", VA = "0x1343FCC")]
	public XWidget_RewardDetailPopup()
	{
	}

	[Token(Token = "0x6007659")]
	[Address(RVA = "0x1329840", Offset = "0x1329840", VA = "0x1329840")]
	public void Show()
	{
	}

	[Token(Token = "0x600765A")]
	[Address(RVA = "0x13442B4", Offset = "0x13442B4", VA = "0x13442B4")]
	public void BuildCommon(string strtitle, string strDescription, List<Info> detailDatas, int curRecievableIndex, bool isSelectBuild, int selectIndex = 0)
	{
	}

	[Token(Token = "0x600765B")]
	[Address(RVA = "0x132A520", Offset = "0x132A520", VA = "0x132A520")]
	public void Build(string strDescription, CSPvpRewardInfo curReward, CSProtoInfoManager_PvpReward protoPVPReward, XProtoInfoManager_ShowBox protoShowbox, bool isSelectBuild = false, int selectIndex = 0)
	{
	}

	[Token(Token = "0x600765C")]
	[Address(RVA = "0x13443E4", Offset = "0x13443E4", VA = "0x13443E4")]
	public void Build(string strDescription, CSTrophyReward curReward, CSProtoInfoManager_TrophyReward protoTrophy, XProtoInfoManager_ShowBox protoShowbox, bool isSelectBuild = false, int selectIndex = 0)
	{
	}

	[Token(Token = "0x600765D")]
	[Address(RVA = "0x1344078", Offset = "0x1344078", VA = "0x1344078")]
	private void RefreshDetail()
	{
	}

	[Token(Token = "0x600765E")]
	[Address(RVA = "0x13447A8", Offset = "0x13447A8", VA = "0x13447A8")]
	private Info GetInfo(int index)
	{
		return null;
	}

	[Token(Token = "0x600765F")]
	[Address(RVA = "0x1344884", Offset = "0x1344884", VA = "0x1344884")]
	public void OnClick_Prev()
	{
	}

	[Token(Token = "0x6007660")]
	[Address(RVA = "0x1344938", Offset = "0x1344938", VA = "0x1344938")]
	public void OnClick_Next()
	{
	}

	[Token(Token = "0x6007661")]
	[Address(RVA = "0x13449EC", Offset = "0x13449EC", VA = "0x13449EC")]
	public void OnClick_Close()
	{
	}
}
