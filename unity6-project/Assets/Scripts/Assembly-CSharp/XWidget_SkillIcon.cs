using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E6F")]
public class XWidget_SkillIcon : MonoBehaviour
{
	[Token(Token = "0x4004B93")]
	[FieldOffset(Offset = "0xC")]
	public UILabel lblName;

	[Token(Token = "0x4004B94")]
	[FieldOffset(Offset = "0x10")]
	public UI2DSprite sprSkillIcon;

	[Token(Token = "0x4004B95")]
	[FieldOffset(Offset = "0x14")]
	public GameObject goSelected;

	[Token(Token = "0x4004B96")]
	[FieldOffset(Offset = "0x18")]
	public GameObject goLock;

	[Token(Token = "0x4004B97")]
	[FieldOffset(Offset = "0x1C")]
	private Action m_onClick;

	[Token(Token = "0x4004B98")]
	[FieldOffset(Offset = "0x20")]
	private int ID__BackingField;

	[Token(Token = "0x17000DD8")]
	public int ID
	{
		[Token(Token = "0x6006BB7")]
		[Address(RVA = "0x1B06ED4", Offset = "0x1B06ED4", VA = "0x1B06ED4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006BB8")]
		[Address(RVA = "0x1B06EDC", Offset = "0x1B06EDC", VA = "0x1B06EDC")]
		private set
		{
		}
	}

	[Token(Token = "0x6006BB6")]
	[Address(RVA = "0x1B06ECC", Offset = "0x1B06ECC", VA = "0x1B06ECC")]
	public XWidget_SkillIcon()
	{
	}

	[Token(Token = "0x6006BB9")]
	[Address(RVA = "0x1B06EE4", Offset = "0x1B06EE4", VA = "0x1B06EE4")]
	public void SetOnClick(Action onClick)
	{
	}

	[Token(Token = "0x6006BBA")]
	[Address(RVA = "0x1B06EEC", Offset = "0x1B06EEC", VA = "0x1B06EEC")]
	private void BuildName(string name)
	{
	}

	[Token(Token = "0x6006BBB")]
	[Address(RVA = "0x1B06FCC", Offset = "0x1B06FCC", VA = "0x1B06FCC")]
	private void BuildSkillIcon(Sprite sprIcon)
	{
	}

	[Token(Token = "0x6006BBC")]
	[Address(RVA = "0x1B070AC", Offset = "0x1B070AC", VA = "0x1B070AC")]
	public void Build(int id, Sprite sprSkillIcon, string name, bool isLock)
	{
	}

	[Token(Token = "0x6006BBD")]
	[Address(RVA = "0x1B071C4", Offset = "0x1B071C4", VA = "0x1B071C4", Slot = "4")]
	public virtual void Select(bool isSelect)
	{
	}

	[Token(Token = "0x6006BBE")]
	[Address(RVA = "0x1B070E4", Offset = "0x1B070E4", VA = "0x1B070E4")]
	private void BuildLock(bool isLock)
	{
	}

	[Token(Token = "0x6006BBF")]
	[Address(RVA = "0x1B072A4", Offset = "0x1B072A4", VA = "0x1B072A4", Slot = "5")]
	public virtual void OnClick()
	{
	}
}
