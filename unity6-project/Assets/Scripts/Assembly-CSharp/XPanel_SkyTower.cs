using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E30")]
public class XPanel_SkyTower : MonoBehaviour
{
	[Token(Token = "0x4004A88")]
	[FieldOffset(Offset = "0xC")]
	private readonly string Path_widgetContent;

	[Token(Token = "0x4004A89")]
	[FieldOffset(Offset = "0x10")]
	private XWidget_ContentIcon m_widgetContent;

	[Token(Token = "0x4004A8A")]
	[FieldOffset(Offset = "0x14")]
	public GameObject goMissionDetail;

	[Token(Token = "0x4004A8B")]
	[FieldOffset(Offset = "0x18")]
	public UILabel lblNumberSolo;

	[Token(Token = "0x4004A8C")]
	[FieldOffset(Offset = "0x1C")]
	public Transform contentIconParent;

	[Token(Token = "0x4004A8D")]
	[FieldOffset(Offset = "0x20")]
	public UILabel lblIconName;

	[Token(Token = "0x4004A8E")]
	[FieldOffset(Offset = "0x24")]
	public XUIMissionList missionList;

	[Token(Token = "0x4004A8F")]
	[FieldOffset(Offset = "0x28")]
	public GameObject disableStart;

	[Token(Token = "0x4004A90")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton btnStart;

	[Token(Token = "0x4004A91")]
	[FieldOffset(Offset = "0x30")]
	public UILabel lblStart;

	[Token(Token = "0x4004A92")]
	[FieldOffset(Offset = "0x34")]
	private XGameModeType m_mode;

	[Token(Token = "0x4004A93")]
	[FieldOffset(Offset = "0x38")]
	private CSStageInfo m_stageInfo;

	[Token(Token = "0x4004A94")]
	[FieldOffset(Offset = "0x3C")]
	private bool isReloadMissionList;

	[Token(Token = "0x4004A95")]
	[FieldOffset(Offset = "0x40")]
	private int countTick;

	[Token(Token = "0x4004A96")]
	[FieldOffset(Offset = "0x44")]
	public List<GameObject> m_Cloud;

	[Token(Token = "0x4004A97")]
	[FieldOffset(Offset = "0x48")]
	public List<float> cloudSpeed;

	[Token(Token = "0x4004A98")]
	[FieldOffset(Offset = "0x4C")]
	private bool m_isStarting;

	[Token(Token = "0x6006960")]
	[Address(RVA = "0xACA55C", Offset = "0xACA55C", VA = "0xACA55C")]
	public XPanel_SkyTower()
	{
	}

	[Token(Token = "0x6006961")]
	[Address(RVA = "0xACA5E8", Offset = "0xACA5E8", VA = "0xACA5E8")]
	public void BuildStageInfo(CSStageInfo stageInfo)
	{
	}

	[Token(Token = "0x6006962")]
	[Address(RVA = "0xACAEA8", Offset = "0xACAEA8", VA = "0xACAEA8")]
	private void BuildName(string name)
	{
	}

	[Token(Token = "0x6006963")]
	[Address(RVA = "0xACAFB0", Offset = "0xACAFB0", VA = "0xACAFB0")]
	private string ReplaceEmptyName(string name)
	{
		return null;
	}

	[Token(Token = "0x6006964")]
	[Address(RVA = "0xACB0B4", Offset = "0xACB0B4", VA = "0xACB0B4")]
	public void RefreshStageInfo()
	{
	}

	[Token(Token = "0x6006965")]
	[Address(RVA = "0xACB188", Offset = "0xACB188", VA = "0xACB188")]
	public void Show()
	{
	}

	[Token(Token = "0x6006966")]
	[Address(RVA = "0xACB858", Offset = "0xACB858", VA = "0xACB858")]
	public void OnShow()
	{
	}

	[Token(Token = "0x6006967")]
	[Address(RVA = "0xACB698", Offset = "0xACB698", VA = "0xACB698")]
	private void BuildCloud()
	{
	}

	[Token(Token = "0x6006968")]
	[Address(RVA = "0xACB88C", Offset = "0xACB88C", VA = "0xACB88C")]
	public void Hide()
	{
	}

	[Token(Token = "0x6006969")]
	[Address(RVA = "0xACB8C0", Offset = "0xACB8C0", VA = "0xACB8C0")]
	private void OnNetdataUpdated_Userdata(object arg)
	{
	}

	[Token(Token = "0x600696A")]
	[Address(RVA = "0xACB91C", Offset = "0xACB91C", VA = "0xACB91C")]
	private void SelectMissionItem(int infoIndex)
	{
	}

	[Token(Token = "0x600696B")]
	[Address(RVA = "0xACB9B0", Offset = "0xACB9B0", VA = "0xACB9B0")]
	public Camera GetParentCamera()
	{
		return null;
	}

	[Token(Token = "0x600696C")]
	[Address(RVA = "0xACBAE0", Offset = "0xACBAE0", VA = "0xACBAE0")]
	public void EnableStartButton()
	{
	}

	[Token(Token = "0x600696D")]
	[Address(RVA = "0xACBAEC", Offset = "0xACBAEC", VA = "0xACBAEC")]
	public void StartGame(bool previous_game_continue = false, bool friendly_match = false, string roomName = "")
	{
	}

	[Token(Token = "0x600696E")]
	[Address(RVA = "0xACBBB8", Offset = "0xACBBB8", VA = "0xACBBB8")]
	public void OnClick_Help()
	{
	}

	[Token(Token = "0x600696F")]
	[Address(RVA = "0xACBC90", Offset = "0xACBC90", VA = "0xACBC90")]
	public void OnButtonClick_GoGame()
	{
	}

	[Token(Token = "0x6006970")]
	[Address(RVA = "0xACBD68", Offset = "0xACBD68", VA = "0xACBD68")]
	private void _003CStartGame_003Em__3CA()
	{
	}
}
