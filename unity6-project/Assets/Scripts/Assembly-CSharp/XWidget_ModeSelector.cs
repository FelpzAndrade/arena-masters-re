using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000FB0")]
public class XWidget_ModeSelector : MonoBehaviour
{
	[Token(Token = "0x2000FB1")]
	private sealed class _003CBuildCommon_003Ec__AnonStorey242
	{
		[Token(Token = "0x400533B")]
		[FieldOffset(Offset = "0x8")]
		internal List<GameModeInstanceInfo> modeInfos;

		[Token(Token = "0x60074D3")]
		[Address(RVA = "0x12FF830", Offset = "0x12FF830", VA = "0x12FF830")]
		public _003CBuildCommon_003Ec__AnonStorey242()
		{
		}

		[Token(Token = "0x60074D4")]
		[Address(RVA = "0x12FF838", Offset = "0x12FF838", VA = "0x12FF838")]
		internal void _003C_003Em__4C6(int index, GameObject go)
		{
		}
	}

	[Token(Token = "0x4005333")]
	[FieldOffset(Offset = "0xC")]
	public GameObject goBtnMapChange;

	[Token(Token = "0x4005334")]
	[FieldOffset(Offset = "0x10")]
	public GameObject goUnlock;

	[Token(Token = "0x4005335")]
	[FieldOffset(Offset = "0x14")]
	public UILabel lblUnlockLv;

	[Token(Token = "0x4005336")]
	[FieldOffset(Offset = "0x18")]
	public XWidget_SwipeObject modeImageSwiper;

	[Token(Token = "0x4005337")]
	[FieldOffset(Offset = "0x1C")]
	private List<GameModeInstanceInfo> modeInfos;

	[Token(Token = "0x4005338")]
	[FieldOffset(Offset = "0x20")]
	private Action<GameModeInstanceInfo, string, bool> modeSelectDelegate;

	[Token(Token = "0x4005339")]
	[FieldOffset(Offset = "0x24")]
	private bool isFriendly;

	[Token(Token = "0x400533A")]
	[FieldOffset(Offset = "0x28")]
	private XGameModeInstanceSorter m_GameModeInstanceSorter;

	[Token(Token = "0x60074C9")]
	[Address(RVA = "0x146AA5C", Offset = "0x146AA5C", VA = "0x146AA5C")]
	public XWidget_ModeSelector()
	{
	}

	[Token(Token = "0x60074CA")]
	[Address(RVA = "0x146AB2C", Offset = "0x146AB2C", VA = "0x146AB2C")]
	public void RegisterModeSelectDelegate(Action<GameModeInstanceInfo, string, bool> modeSelectDelegate)
	{
	}

	[Token(Token = "0x60074CB")]
	[Address(RVA = "0x146AB34", Offset = "0x146AB34", VA = "0x146AB34")]
	private void BuildCommon(List<GameModeInstanceInfo> modeInfos)
	{
	}

	[Token(Token = "0x60074CC")]
	[Address(RVA = "0x146AD34", Offset = "0x146AD34", VA = "0x146AD34")]
	public void BuildNormalOneMode(GameModeInstanceInfo modeInfo)
	{
	}

	[Token(Token = "0x60074CD")]
	[Address(RVA = "0x146AE64", Offset = "0x146AE64", VA = "0x146AE64")]
	private List<GameModeInstanceInfo> GetSortGameModeInfos(List<GameModeInstanceInfo> originList, XGameModeType firstShowType = XGameModeType.NA)
	{
		return null;
	}

	[Token(Token = "0x60074CE")]
	[Address(RVA = "0x146AE90", Offset = "0x146AE90", VA = "0x146AE90")]
	public void BuildAIMode()
	{
	}

	[Token(Token = "0x60074CF")]
	[Address(RVA = "0x146B000", Offset = "0x146B000", VA = "0x146B000")]
	public void BuildFriendlyMode(GameModeInstanceInfo gameModeInstanceInfo)
	{
	}

	[Token(Token = "0x60074D0")]
	[Address(RVA = "0x146B0F4", Offset = "0x146B0F4", VA = "0x146B0F4")]
	private void BuildMode(int index)
	{
	}

	[Token(Token = "0x60074D1")]
	[Address(RVA = "0x146B76C", Offset = "0x146B76C", VA = "0x146B76C")]
	public GameModeInstanceInfo GetSelectedMode(bool isOrigin = false)
	{
		return null;
	}

	[Token(Token = "0x60074D2")]
	[Address(RVA = "0x146B9FC", Offset = "0x146B9FC", VA = "0x146B9FC")]
	public void ClearListMap()
	{
	}
}
