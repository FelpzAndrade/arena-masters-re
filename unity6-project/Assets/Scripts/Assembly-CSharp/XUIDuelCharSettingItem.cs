using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F1A")]
public class XUIDuelCharSettingItem : MonoBehaviour
{
	[Token(Token = "0x4004FE5")]
	[FieldOffset(Offset = "0xC")]
	private XModuleActor m_moduleActor;

	[Token(Token = "0x4004FE6")]
	[FieldOffset(Offset = "0x10")]
	public UI2DSprite sprIcon;

	[Token(Token = "0x4004FE7")]
	[FieldOffset(Offset = "0x14")]
	public UILabel lblCharLevel;

	[Token(Token = "0x4004FE8")]
	[FieldOffset(Offset = "0x18")]
	public UI2DSprite sprSelect;

	[Token(Token = "0x4004FE9")]
	[FieldOffset(Offset = "0x1C")]
	public UI2DSprite sprSelectHide;

	[Token(Token = "0x4004FEA")]
	[FieldOffset(Offset = "0x20")]
	public UI2DSprite sprBlankPoint;

	[Token(Token = "0x4004FEB")]
	[FieldOffset(Offset = "0x24")]
	public XWiget_GridBuilder gridGrade;

	[Token(Token = "0x4004FEC")]
	[FieldOffset(Offset = "0x28")]
	private bool SelectItem;

	[Token(Token = "0x4004FED")]
	[FieldOffset(Offset = "0x2C")]
	private int MaxSelectCount;

	[Token(Token = "0x4004FEE")]
	[FieldOffset(Offset = "0x30")]
	public TweenAlpha pointAlpha;

	[Token(Token = "0x4004FEF")]
	[FieldOffset(Offset = "0x34")]
	private string charUID;

	[Token(Token = "0x6007089")]
	[Address(RVA = "0x1A3B678", Offset = "0x1A3B678", VA = "0x1A3B678")]
	public XUIDuelCharSettingItem()
	{
	}

	[Token(Token = "0x600708A")]
	[Address(RVA = "0x1A3B744", Offset = "0x1A3B744", VA = "0x1A3B744")]
	public void AlphaFinished()
	{
	}

	[Token(Token = "0x600708B")]
	[Address(RVA = "0x1A3B7A4", Offset = "0x1A3B7A4", VA = "0x1A3B7A4")]
	public void Build(XModuleActor charList)
	{
	}

	[Token(Token = "0x600708C")]
	[Address(RVA = "0x1A3BBA8", Offset = "0x1A3BBA8", VA = "0x1A3BBA8")]
	public void Build()
	{
	}

	[Token(Token = "0x600708D")]
	[Address(RVA = "0x1A3BC04", Offset = "0x1A3BC04", VA = "0x1A3BC04")]
	public XUIDuelCharSettingItem GetItemScript()
	{
		return null;
	}

	[Token(Token = "0x600708E")]
	[Address(RVA = "0x1A3BC08", Offset = "0x1A3BC08", VA = "0x1A3BC08")]
	public string GetCharUID()
	{
		return null;
	}

	[Token(Token = "0x600708F")]
	[Address(RVA = "0x1A3B814", Offset = "0x1A3B814", VA = "0x1A3B814")]
	private void BuildIcon(string iconSprName)
	{
	}

	[Token(Token = "0x6007090")]
	[Address(RVA = "0x1A3B9B8", Offset = "0x1A3B9B8", VA = "0x1A3B9B8")]
	private void BuildLevel(int level)
	{
	}

	[Token(Token = "0x6007091")]
	[Address(RVA = "0x1A3BC34", Offset = "0x1A3BC34", VA = "0x1A3BC34")]
	private void BuildGrade(int charGrade = 0)
	{
	}

	[Token(Token = "0x6007092")]
	[Address(RVA = "0x1A3BD14", Offset = "0x1A3BD14", VA = "0x1A3BD14")]
	public void BuildGrade()
	{
	}

	[Token(Token = "0x6007093")]
	[Address(RVA = "0x1A3BAB0", Offset = "0x1A3BAB0", VA = "0x1A3BAB0")]
	public void BuildSelected(bool select)
	{
	}

	[Token(Token = "0x6007094")]
	[Address(RVA = "0x1A3BBAC", Offset = "0x1A3BBAC", VA = "0x1A3BBAC")]
	public void BuildSelectedHide()
	{
	}

	[Token(Token = "0x6007095")]
	[Address(RVA = "0x1A3BEA4", Offset = "0x1A3BEA4", VA = "0x1A3BEA4")]
	public void BuildBlankPoint(bool point)
	{
	}

	[Token(Token = "0x6007096")]
	[Address(RVA = "0x1A3BF0C", Offset = "0x1A3BF0C", VA = "0x1A3BF0C")]
	public void OnClick()
	{
	}

	[Token(Token = "0x6007097")]
	[Address(RVA = "0x1A3BFA8", Offset = "0x1A3BFA8", VA = "0x1A3BFA8")]
	public void SetSelectItemState(bool state)
	{
	}

	[Token(Token = "0x6007098")]
	[Address(RVA = "0x1A3BFB0", Offset = "0x1A3BFB0", VA = "0x1A3BFB0")]
	public bool GetSelectItemState()
	{
		return default(bool);
	}

	[Token(Token = "0x6007099")]
	[Address(RVA = "0x1A3BFB8", Offset = "0x1A3BFB8", VA = "0x1A3BFB8")]
	public XModuleActor GetModuleActor()
	{
		return null;
	}
}
