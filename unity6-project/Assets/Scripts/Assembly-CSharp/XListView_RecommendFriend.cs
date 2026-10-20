using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F20")]
public class XListView_RecommendFriend : XUIListView
{
	[Token(Token = "0x4005005")]
	[FieldOffset(Offset = "0x78")]
	private List<Friend> m_list;

	[Token(Token = "0x17000E4F")]
	protected override string ItemPrefabName
	{
		[Token(Token = "0x60070BB")]
		[Address(RVA = "0x1E15340", Offset = "0x1E15340", VA = "0x1E15340", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E50")]
	protected override int BuildItemSettingCount
	{
		[Token(Token = "0x60070BC")]
		[Address(RVA = "0x1E153B8", Offset = "0x1E153B8", VA = "0x1E153B8", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000E51")]
	protected override int InfoListCount
	{
		[Token(Token = "0x60070BD")]
		[Address(RVA = "0x1E153C0", Offset = "0x1E153C0", VA = "0x1E153C0", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60070BA")]
	[Address(RVA = "0x1E15268", Offset = "0x1E15268", VA = "0x1E15268")]
	public XListView_RecommendFriend()
	{
	}

	[Token(Token = "0x60070BE")]
	[Address(RVA = "0x1E15458", Offset = "0x1E15458", VA = "0x1E15458")]
	public void Build(List<Friend> recommend_user)
	{
	}

	[Token(Token = "0x60070BF")]
	[Address(RVA = "0x1E15464", Offset = "0x1E15464", VA = "0x1E15464", Slot = "12")]
	protected override void PushDatum(GameObject go, int index)
	{
	}

	[Token(Token = "0x60070C0")]
	[Address(RVA = "0x1E15550", Offset = "0x1E15550", VA = "0x1E15550")]
	public XUIRecommendFriendItem GetFirstItem()
	{
		return null;
	}
}
