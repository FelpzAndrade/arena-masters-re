using System;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000DAA")]
public class XUIEventAttendanceItem : MonoBehaviour
{
	[Token(Token = "0x40046D7")]
	[FieldOffset(Offset = "0xC")]
	public GameObject goEffect;

	[Token(Token = "0x40046D8")]
	[FieldOffset(Offset = "0x10")]
	public UILabel lblDay;

	[Token(Token = "0x40046D9")]
	[FieldOffset(Offset = "0x14")]
	public Transform contentItemParent;

	[Token(Token = "0x40046DA")]
	[FieldOffset(Offset = "0x18")]
	public UILabel lblName;

	[Token(Token = "0x40046DB")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel lblSubDesc1;

	[Token(Token = "0x40046DC")]
	[FieldOffset(Offset = "0x20")]
	public UILabel lblMainDesc;

	[Token(Token = "0x40046DD")]
	[FieldOffset(Offset = "0x24")]
	public UILabel lblSubDesc2;

	[Token(Token = "0x40046DE")]
	[FieldOffset(Offset = "0x28")]
	public UI2DSprite sprRewardImage;

	[Token(Token = "0x40046DF")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject goStamp;

	[Token(Token = "0x40046E0")]
	[FieldOffset(Offset = "0x30")]
	public GameObject goSprSelect;

	[Token(Token = "0x40046E1")]
	[FieldOffset(Offset = "0x34")]
	public XWidget_Button btnReward;

	[Token(Token = "0x40046E2")]
	[FieldOffset(Offset = "0x38")]
	private XWidget_ContentIcon _contentIcon;

	[Token(Token = "0x17000D4B")]
	private XWidget_ContentIcon contentIcon
	{
		[Token(Token = "0x6006470")]
		[Address(RVA = "0x1A4108C", Offset = "0x1A4108C", VA = "0x1A4108C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600646F")]
	[Address(RVA = "0x1A41084", Offset = "0x1A41084", VA = "0x1A41084")]
	public XUIEventAttendanceItem()
	{
	}

	[Token(Token = "0x6006471")]
	[Address(RVA = "0x1A41278", Offset = "0x1A41278", VA = "0x1A41278")]
	private void BuildCommon(CSEventAttendanceBookItem itemInfo)
	{
	}

	[Token(Token = "0x6006472")]
	[Address(RVA = "0x1A41628", Offset = "0x1A41628", VA = "0x1A41628")]
	public bool GetIsStamped()
	{
		return default(bool);
	}

	[Token(Token = "0x6006473")]
	[Address(RVA = "0x1A41654", Offset = "0x1A41654", VA = "0x1A41654")]
	public void BuildWithContent(CSEventAttendanceBookItem itemInfo)
	{
	}

	[Token(Token = "0x6006474")]
	[Address(RVA = "0x1A41938", Offset = "0x1A41938", VA = "0x1A41938")]
	public void Build(CSEventAttendanceBookItem itemInfo)
	{
	}

	[Token(Token = "0x6006475")]
	[Address(RVA = "0x1A41A94", Offset = "0x1A41A94", VA = "0x1A41A94")]
	public void SetSelect(bool bSelect)
	{
	}

	[Token(Token = "0x6006476")]
	[Address(RVA = "0x1A41B74", Offset = "0x1A41B74", VA = "0x1A41B74")]
	public void ShowEffect(bool isShow)
	{
	}

	[Token(Token = "0x6006477")]
	[Address(RVA = "0x1A41C84", Offset = "0x1A41C84", VA = "0x1A41C84")]
	public void BuildButton(string localKey, Action onClick, bool disable)
	{
	}
}
