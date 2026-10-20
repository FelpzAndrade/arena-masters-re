using System;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F54")]
public class XUIRelicItem : MonoBehaviour
{
	[Token(Token = "0x4005066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public UI2DSprite sprIcon;

	[Token(Token = "0x4005067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public UILabel lblName;

	[Token(Token = "0x4005068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public UISprite sprSelect;

	[Token(Token = "0x4005069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public UILabel lblLevel;

	[Token(Token = "0x400506A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public UIWidget bgType;

	[Token(Token = "0x400506B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Action<RelicInfo, bool> m_action;

	[Token(Token = "0x400506C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public RelicInfo m_relicInfo;

	[Token(Token = "0x400506D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Action<XUIRelicItem> m_item;

	[Token(Token = "0x400506E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public UISprite sprLock;

	[Token(Token = "0x400506F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool m_open;

	[Token(Token = "0x4005070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float m_coolTime;

	[Token(Token = "0x4005071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public SkillDamageTypes m_damageType;

	[Token(Token = "0x4005072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private int m_level;

	[Token(Token = "0x4005073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public XWidget_ProgressBar prbUpgrade;

	[Token(Token = "0x17000E89")]
	public int RelicID
	{
		[Token(Token = "0x60071C9")]
		[Address(RVA = "0x1916E04", Offset = "0x1916E04", VA = "0x1916E04")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60071C8")]
	[Address(RVA = "0x1916DFC", Offset = "0x1916DFC", VA = "0x1916DFC")]
	public XUIRelicItem()
	{
	}

	[Token(Token = "0x60071CA")]
	[Address(RVA = "0x1916E18", Offset = "0x1916E18", VA = "0x1916E18")]
	public void GetComponentAction(Action<RelicInfo, bool> action)
	{
	}

	[Token(Token = "0x60071CB")]
	[Address(RVA = "0x1916E20", Offset = "0x1916E20", VA = "0x1916E20")]
	public void Build(RelicInfo item, Action<XUIRelicItem> m_selObj, [Optional] RelicInfo initItem)
	{
	}

	[Token(Token = "0x60071CC")]
	[Address(RVA = "0x19178F4", Offset = "0x19178F4", VA = "0x19178F4")]
	public void RefreshPieceBar()
	{
	}

	[Token(Token = "0x60071CD")]
	[Address(RVA = "0x1917D6C", Offset = "0x1917D6C", VA = "0x1917D6C")]
	public void BuildType()
	{
	}

	[Token(Token = "0x60071CE")]
	[Address(RVA = "0x19176C4", Offset = "0x19176C4", VA = "0x19176C4")]
	public void BuildUpgradeState()
	{
	}

	[Token(Token = "0x60071CF")]
	[Address(RVA = "0x1917434", Offset = "0x1917434", VA = "0x1917434")]
	public void RefreshLevel()
	{
	}

	[Token(Token = "0x60071D0")]
	[Address(RVA = "0x1918104", Offset = "0x1918104", VA = "0x1918104")]
	public void SetSelectSprite(bool state)
	{
	}

	[Token(Token = "0x60071D1")]
	[Address(RVA = "0x1918148", Offset = "0x1918148", VA = "0x1918148")]
	public void OnClick()
	{
	}

	[Token(Token = "0x60071D2")]
	[Address(RVA = "0x1918218", Offset = "0x1918218", VA = "0x1918218")]
	public void SetOpenRelic(bool newOpen)
	{
	}

	[Token(Token = "0x60071D3")]
	[Address(RVA = "0x1917C84", Offset = "0x1917C84", VA = "0x1917C84")]
	private int GetCurrentCount()
	{
		return default(int);
	}

	[Token(Token = "0x60071D4")]
	[Address(RVA = "0x191730C", Offset = "0x191730C", VA = "0x191730C")]
	private int GetRelicLevel()
	{
		return default(int);
	}

	[Token(Token = "0x60071D5")]
	[Address(RVA = "0x1917FF4", Offset = "0x1917FF4", VA = "0x1917FF4")]
	private RelicInfo GetActualityRelicInfo(int id, int level)
	{
		return null;
	}

	[Token(Token = "0x60071D6")]
	[Address(RVA = "0x1917B74", Offset = "0x1917B74", VA = "0x1917B74")]
	private RelicInfo GetNextLevelRelicInfo(int id, int level)
	{
		return null;
	}
}
