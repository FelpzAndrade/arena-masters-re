using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000EF4")]
public class XWidget_PackageDetailItem : MonoBehaviour
{
	[Token(Token = "0x2000EF5")]
	private sealed class _003CBuildDetailInfoAndButton_003Ec__AnonStorey224
	{
		[Token(Token = "0x4004F53")]
		[FieldOffset(Offset = "0x8")]
		internal CSContent content;

		[Token(Token = "0x4004F54")]
		[FieldOffset(Offset = "0xC")]
		internal XWidget_PackageDetailItem _003C_003Ef__this;

		[Token(Token = "0x6006FD1")]
		[Address(RVA = "0x131242C", Offset = "0x131242C", VA = "0x131242C")]
		public _003CBuildDetailInfoAndButton_003Ec__AnonStorey224()
		{
		}
	}

	[Token(Token = "0x2000EF6")]
	private sealed class _003CBuildDetailInfoAndButton_003Ec__AnonStorey221
	{
		[Token(Token = "0x4004F55")]
		[FieldOffset(Offset = "0x8")]
		internal int contentID;

		[Token(Token = "0x4004F56")]
		[FieldOffset(Offset = "0xC")]
		internal XWidget_PackageDetailItem _003C_003Ef__this;

		[Token(Token = "0x6006FD2")]
		[Address(RVA = "0x1312434", Offset = "0x1312434", VA = "0x1312434")]
		public _003CBuildDetailInfoAndButton_003Ec__AnonStorey221()
		{
		}

		[Token(Token = "0x6006FD3")]
		[Address(RVA = "0x1312BD0", Offset = "0x1312BD0", VA = "0x1312BD0")]
		internal void _003C_003Em__452()
		{
		}

		[Token(Token = "0x6006FD4")]
		[Address(RVA = "0x1312BFC", Offset = "0x1312BFC", VA = "0x1312BFC")]
		internal void _003C_003Em__453()
		{
		}
	}

	[Token(Token = "0x2000EF7")]
	private sealed class _003CBuildDetailInfoAndButton_003Ec__AnonStorey223
	{
		[Token(Token = "0x4004F57")]
		[FieldOffset(Offset = "0x8")]
		internal CSItemInfo itemInfo;

		[Token(Token = "0x4004F58")]
		[FieldOffset(Offset = "0xC")]
		internal _003CBuildDetailInfoAndButton_003Ec__AnonStorey224 _003C_003Ef__ref_0024548;

		[Token(Token = "0x4004F59")]
		[FieldOffset(Offset = "0x10")]
		internal XWidget_PackageDetailItem _003C_003Ef__this;

		[Token(Token = "0x6006FD5")]
		[Address(RVA = "0x131243C", Offset = "0x131243C", VA = "0x131243C")]
		public _003CBuildDetailInfoAndButton_003Ec__AnonStorey223()
		{
		}

		[Token(Token = "0x6006FD6")]
		[Address(RVA = "0x1312C60", Offset = "0x1312C60", VA = "0x1312C60")]
		internal void _003C_003Em__455()
		{
		}
	}

	[Token(Token = "0x2000EF8")]
	private sealed class _003CBuildDetailInfoAndButton_003Ec__AnonStorey222
	{
		[Token(Token = "0x4004F5A")]
		[FieldOffset(Offset = "0x8")]
		internal SkinInfo skinInfo;

		[Token(Token = "0x4004F5B")]
		[FieldOffset(Offset = "0xC")]
		internal XWidget_PackageDetailItem _003C_003Ef__this;

		[Token(Token = "0x6006FD7")]
		[Address(RVA = "0x1312444", Offset = "0x1312444", VA = "0x1312444")]
		public _003CBuildDetailInfoAndButton_003Ec__AnonStorey222()
		{
		}

		[Token(Token = "0x6006FD8")]
		[Address(RVA = "0x1312C28", Offset = "0x1312C28", VA = "0x1312C28")]
		internal void _003C_003Em__454()
		{
		}
	}

	[Token(Token = "0x4004F48")]
	[FieldOffset(Offset = "0xC")]
	public Transform contentIconParent;

	[Token(Token = "0x4004F49")]
	[FieldOffset(Offset = "0x10")]
	private XWidget_ContentIcon m_contentIcon;

	[Token(Token = "0x4004F4A")]
	[FieldOffset(Offset = "0x14")]
	public XWidget_Button btnGoTo;

	[Token(Token = "0x4004F4B")]
	[FieldOffset(Offset = "0x18")]
	public UILabel lblName;

	[Token(Token = "0x4004F4C")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel lblDesc1;

	[Token(Token = "0x4004F4D")]
	[FieldOffset(Offset = "0x20")]
	public UILabel lblDesc2;

	[Token(Token = "0x4004F4E")]
	[FieldOffset(Offset = "0x24")]
	public UILabel lblDesc3;

	[Token(Token = "0x4004F4F")]
	[FieldOffset(Offset = "0x28")]
	private int characterID;

	[Token(Token = "0x4004F50")]
	[FieldOffset(Offset = "0x2C")]
	private int skinID;

	[Token(Token = "0x4004F51")]
	[FieldOffset(Offset = "0x30")]
	private int _parentDepth;

	[Token(Token = "0x4004F52")]
	[FieldOffset(Offset = "0x34")]
	private PackageDetailInfo PackageDetailInfo__BackingField;

	[Token(Token = "0x17000E26")]
	private PackageDetailInfo PackageDetailInfo
	{
		[Token(Token = "0x6006FC4")]
		[Address(RVA = "0x1311278", Offset = "0x1311278", VA = "0x1311278")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006FC5")]
		[Address(RVA = "0x1311280", Offset = "0x1311280", VA = "0x1311280")]
		set
		{
		}
	}

	[Token(Token = "0x17000E27")]
	public int ParentDepth
	{
		[Token(Token = "0x6006FC6")]
		[Address(RVA = "0x1311288", Offset = "0x1311288", VA = "0x1311288")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6006FC3")]
	[Address(RVA = "0x1311270", Offset = "0x1311270", VA = "0x1311270")]
	public XWidget_PackageDetailItem()
	{
	}

	[Token(Token = "0x6006FC7")]
	[Address(RVA = "0x1311390", Offset = "0x1311390", VA = "0x1311390")]
	public void Build(PackageDetailInfo info)
	{
	}

	[Token(Token = "0x6006FC8")]
	[Address(RVA = "0x1311974", Offset = "0x1311974", VA = "0x1311974")]
	private void BuildContentName(string forceName, CSContent content)
	{
	}

	[Token(Token = "0x6006FC9")]
	[Address(RVA = "0x13115FC", Offset = "0x13115FC", VA = "0x13115FC")]
	private void BuildContentIconWidget(string forceIconPath, CSContent content)
	{
	}

	[Token(Token = "0x6006FCA")]
	[Address(RVA = "0x1311B48", Offset = "0x1311B48", VA = "0x1311B48")]
	private string GetStringProductType(ProductType type)
	{
		return null;
	}

	[Token(Token = "0x6006FCB")]
	[Address(RVA = "0x1311D24", Offset = "0x1311D24", VA = "0x1311D24")]
	private void BuildDetailInfoAndButton(string link, CSContent content)
	{
	}

	[Token(Token = "0x6006FCC")]
	[Address(RVA = "0x131244C", Offset = "0x131244C", VA = "0x131244C")]
	private string GetPackageDetailItemName()
	{
		return null;
	}

	[Token(Token = "0x6006FCD")]
	[Address(RVA = "0x131259C", Offset = "0x131259C", VA = "0x131259C")]
	public void OnClickButton_SkinDetail(int characterID, int skinID)
	{
	}

	[Token(Token = "0x6006FCE")]
	[Address(RVA = "0x13126F4", Offset = "0x13126F4", VA = "0x13126F4")]
	public void OnClickButton_CharacterDetail(int characterID)
	{
	}

	[Token(Token = "0x6006FCF")]
	[Address(RVA = "0x13128C8", Offset = "0x13128C8", VA = "0x13128C8")]
	public void OnClickButton_petDetail(int characterID)
	{
	}

	[Token(Token = "0x6006FD0")]
	[Address(RVA = "0x1312A9C", Offset = "0x1312A9C", VA = "0x1312A9C")]
	public void OnClickButton_GachaDetail()
	{
	}
}
