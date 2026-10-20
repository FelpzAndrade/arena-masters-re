using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000FAF")]
public class XWidget_ModeInfo : MonoBehaviour
{
	[Token(Token = "0x4005326")]
	[FieldOffset(Offset = "0xC")]
	public UILabel lblModeName;

	[Token(Token = "0x4005327")]
	[FieldOffset(Offset = "0x10")]
	public UILabel lblModeDescDetail;

	[Token(Token = "0x4005328")]
	[FieldOffset(Offset = "0x14")]
	public UILabel lblModeDescTitle;

	[Token(Token = "0x4005329")]
	[FieldOffset(Offset = "0x18")]
	public UIBasicSprite sprTeamModeBG;

	[Token(Token = "0x400532A")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel lblTeamMode;

	[Token(Token = "0x400532B")]
	[FieldOffset(Offset = "0x20")]
	public UILabel lblRoundMode;

	[Token(Token = "0x400532C")]
	[FieldOffset(Offset = "0x24")]
	public UILabel lblDifficulty;

	[Token(Token = "0x400532D")]
	[FieldOffset(Offset = "0x28")]
	public UIBasicSprite sprDifficultyBG;

	[Token(Token = "0x400532E")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel lblCorrect;

	[Token(Token = "0x400532F")]
	[FieldOffset(Offset = "0x30")]
	public UITable infoTable;

	[Token(Token = "0x4005330")]
	[FieldOffset(Offset = "0x34")]
	public bool showExtraChar;

	[Token(Token = "0x4005331")]
	[FieldOffset(Offset = "0x38")]
	public UI2DSprite sprExtraChar;

	[Token(Token = "0x4005332")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel lblExtraChar;

	[Token(Token = "0x60074C3")]
	[Address(RVA = "0x1469794", Offset = "0x1469794", VA = "0x1469794")]
	public XWidget_ModeInfo()
	{
	}

	[Token(Token = "0x60074C4")]
	[Address(RVA = "0x146979C", Offset = "0x146979C", VA = "0x146979C")]
	public void Build(GameModeInstanceInfo gamemodeInstance, string modeName)
	{
	}

	[Token(Token = "0x60074C5")]
	[Address(RVA = "0x146A488", Offset = "0x146A488", VA = "0x146A488")]
	private void ExtraCharSetting(GameModeInstanceInfo info)
	{
	}

	[Token(Token = "0x60074C6")]
	[Address(RVA = "0x146A104", Offset = "0x146A104", VA = "0x146A104")]
	private void GetTeamModeUISetting(XTeamMode teamMode, out string text, out Color bgColor)
	{
		bgColor = default;
		text = default;
	}

	[Token(Token = "0x60074C7")]
	[Address(RVA = "0x146A300", Offset = "0x146A300", VA = "0x146A300")]
	private void SetLabel(UILabel lbl, string text, Color color)
	{
	}

	[Token(Token = "0x60074C8")]
	[Address(RVA = "0x1469F7C", Offset = "0x1469F7C", VA = "0x1469F7C")]
	public static Color GetDifficultyColor(CSStageDifficulty type)
	{
		return default(Color);
	}
}
