using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F49")]
public class XListView_Mail : XUIListView
{
	[Token(Token = "0x400504A")]
	[FieldOffset(Offset = "0x78")]
	private MailType mailType;

	[Token(Token = "0x17000E76")]
	protected override string ItemPrefabName
	{
		[Token(Token = "0x600718C")]
		[Address(RVA = "0x1E122FC", Offset = "0x1E122FC", VA = "0x1E122FC", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E77")]
	protected override int BuildItemSettingCount
	{
		[Token(Token = "0x600718D")]
		[Address(RVA = "0x1E12374", Offset = "0x1E12374", VA = "0x1E12374", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000E78")]
	protected override int InfoListCount
	{
		[Token(Token = "0x600718E")]
		[Address(RVA = "0x1E1237C", Offset = "0x1E1237C", VA = "0x1E1237C", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600718A")]
	[Address(RVA = "0x1E12250", Offset = "0x1E12250", VA = "0x1E12250")]
	public XListView_Mail()
	{
	}

	[Token(Token = "0x600718B")]
	[Address(RVA = "0x1E122F4", Offset = "0x1E122F4", VA = "0x1E122F4")]
	public void SetMailType(MailType type)
	{
	}

	[Token(Token = "0x600718F")]
	[Address(RVA = "0x1E1267C", Offset = "0x1E1267C", VA = "0x1E1267C", Slot = "12")]
	protected override void PushDatum(GameObject go, int index)
	{
	}
}
