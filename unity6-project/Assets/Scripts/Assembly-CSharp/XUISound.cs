using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2001046")]
public class XUISound : MonoBehaviour
{
	[Token(Token = "0x2001047")]
	public enum UISound
	{
		[Token(Token = "0x40057AE")]
		UIButtonTouch = 0,
		[Token(Token = "0x40057AF")]
		UIButtonTouchFail = 1,
		[Token(Token = "0x40057B0")]
		UICardSwipe = 2,
		[Token(Token = "0x40057B1")]
		UIItemEquip = 3,
		[Token(Token = "0x40057B2")]
		UIItemSell = 4,
		[Token(Token = "0x40057B3")]
		UIWarningPopup = 5,
		[Token(Token = "0x40057B4")]
		UIWinClose = 6,
		[Token(Token = "0x40057B5")]
		UIPay = 7,
		[Token(Token = "0x40057B6")]
		UISuddenDeath = 8,
		[Token(Token = "0x40057B7")]
		UICountDown = 9,
		[Token(Token = "0x40057B8")]
		UIStartGame = 10,
		[Token(Token = "0x40057B9")]
		UIScrambelComplete = 11,
		[Token(Token = "0x40057BA")]
		UIClearTicket = 12,
		[Token(Token = "0x40057BB")]
		UIPartyJoin = 13,
		[Token(Token = "0x40057BC")]
		UIEventPop = 14,
		[Token(Token = "0x40057BD")]
		UIQuestReward = 15,
		[Token(Token = "0x40057BE")]
		UICharacterGet = 16,
		[Token(Token = "0x40057BF")]
		UIToolTip = 17,
		[Token(Token = "0x40057C0")]
		None = 18,
		[Token(Token = "0x40057C1")]
		UISkillLevelUp = 19,
		[Token(Token = "0x40057C2")]
		UIEventPopup = 20,
		[Token(Token = "0x40057C3")]
		UI_GameResult_MVPStamp = 21,
		[Token(Token = "0x40057C4")]
		UI_MannerPoint = 22
	}

	[Token(Token = "0x40057AA")]
	[FieldOffset(Offset = "0x0")]
	private static string[] Path;

	[Token(Token = "0x40057AB")]
	[FieldOffset(Offset = "0xC")]
	public UISound type;

	[Token(Token = "0x40057AC")]
	[FieldOffset(Offset = "0x10")]
	public string pathDirectly;

	[Token(Token = "0x6007971")]
	[Address(RVA = "0x1931080", Offset = "0x1931080", VA = "0x1931080")]
	public XUISound()
	{
	}

	[Token(Token = "0x6007973")]
	[Address(RVA = "0x1931C20", Offset = "0x1931C20", VA = "0x1931C20")]
	private void Start()
	{
	}

	[Token(Token = "0x6007974")]
	[Address(RVA = "0x1931C24", Offset = "0x1931C24", VA = "0x1931C24")]
	public void OnClick()
	{
	}

	[Token(Token = "0x6007975")]
	[Address(RVA = "0x191E4BC", Offset = "0x191E4BC", VA = "0x191E4BC")]
	public static string GetSoundKey(UISound type)
	{
		return null;
	}
}
