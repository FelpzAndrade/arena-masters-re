using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000ED5")]
public class XWidget_ItemBaseInfo : MonoBehaviour
{
	[Token(Token = "0x2000ED6")]
	private sealed class _003CBuildExp_003Ec__AnonStorey214
	{
		[Token(Token = "0x4004E3E")]
		[FieldOffset(Offset = "0x8")]
		internal CSProtoInfoManager_ItemBalance balance;

		[Token(Token = "0x4004E3F")]
		[FieldOffset(Offset = "0xC")]
		internal ItemRarity itemRarity;

		[Token(Token = "0x4004E40")]
		[FieldOffset(Offset = "0x10")]
		internal XItem item;

		[Token(Token = "0x4004E41")]
		[FieldOffset(Offset = "0x14")]
		internal CSProtoInfoManager_GameConst protoInfoConst;

		[Token(Token = "0x6006EA2")]
		[Address(RVA = "0x1452840", Offset = "0x1452840", VA = "0x1452840")]
		public _003CBuildExp_003Ec__AnonStorey214()
		{
		}

		[Token(Token = "0x6006EA3")]
		[Address(RVA = "0x1452848", Offset = "0x1452848", VA = "0x1452848")]
		internal bool _003C_003Em__423(int val)
		{
			return default(bool);
		}

		[Token(Token = "0x6006EA4")]
		[Address(RVA = "0x14528BC", Offset = "0x14528BC", VA = "0x14528BC")]
		internal void _003C_003Em__424(UILabel label, int val)
		{
		}

		[Token(Token = "0x6006EA5")]
		[Address(RVA = "0x1452A00", Offset = "0x1452A00", VA = "0x1452A00")]
		internal void _003C_003Em__425(UIProgressBar prb, int val)
		{
		}
	}

	[Token(Token = "0x4004E2F")]
	[FieldOffset(Offset = "0xC")]
	public UILabel lblName;

	[Token(Token = "0x4004E30")]
	[FieldOffset(Offset = "0x10")]
	public Transform iconParent;

	[Token(Token = "0x4004E31")]
	[FieldOffset(Offset = "0x14")]
	public UILabel lblGrade;

	[Token(Token = "0x4004E32")]
	[FieldOffset(Offset = "0x18")]
	public UILabel lblType;

	[Token(Token = "0x4004E33")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel lblLevel;

	[Token(Token = "0x4004E34")]
	[FieldOffset(Offset = "0x20")]
	public UILabel lblPrice;

	[Token(Token = "0x4004E35")]
	[FieldOffset(Offset = "0x24")]
	public UILabel lblDesc;

	[Token(Token = "0x4004E36")]
	[FieldOffset(Offset = "0x28")]
	public UILabel lblArenaCoinPrice;

	[Token(Token = "0x4004E37")]
	[FieldOffset(Offset = "0x2C")]
	public XWidget_ProgressBarWithTable prbExp;

	[Token(Token = "0x4004E38")]
	[FieldOffset(Offset = "0x30")]
	public bool UseTypeColorForRarity;

	[Token(Token = "0x4004E39")]
	[FieldOffset(Offset = "0x31")]
	public bool UseNameColorForRarity;

	[Token(Token = "0x4004E3A")]
	[FieldOffset(Offset = "0x32")]
	public bool UseRarityTextBracket;

	[Token(Token = "0x4004E3B")]
	[FieldOffset(Offset = "0x34")]
	public GameObject itemPrice;

	[Token(Token = "0x4004E3C")]
	[FieldOffset(Offset = "0x38")]
	public GameObject ArenaCoinPrice;

	[Token(Token = "0x4004E3D")]
	[FieldOffset(Offset = "0x3C")]
	protected XWidget_ItemIcon m_itemIcon;

	[Token(Token = "0x17000E1B")]
	public XWidget_ItemIcon ItemIcon
	{
		[Token(Token = "0x6006E9D")]
		[Address(RVA = "0x1450BFC", Offset = "0x1450BFC", VA = "0x1450BFC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006E9C")]
	[Address(RVA = "0x1450BEC", Offset = "0x1450BEC", VA = "0x1450BEC")]
	public XWidget_ItemBaseInfo()
	{
	}

	[Token(Token = "0x6006E9E")]
	[Address(RVA = "0x1450E2C", Offset = "0x1450E2C", VA = "0x1450E2C")]
	public void Build(XItem item)
	{
	}

	[Token(Token = "0x6006E9F")]
	[Address(RVA = "0x1451594", Offset = "0x1451594", VA = "0x1451594")]
	private Color GetColor(bool useColor, ItemRarity rarity)
	{
		return default(Color);
	}

	[Token(Token = "0x6006EA0")]
	[Address(RVA = "0x1452540", Offset = "0x1452540", VA = "0x1452540")]
	public void BuildPrice(XItem item)
	{
	}

	[Token(Token = "0x6006EA1")]
	[Address(RVA = "0x1452168", Offset = "0x1452168", VA = "0x1452168")]
	protected void BuildExp(XItem item)
	{
	}
}
