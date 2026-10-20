using System;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F72")]
public class XWidget_CharacterCard : MonoBehaviour
{
	[Token(Token = "0x2000F73")]
	public enum CardOption
	{
		[Token(Token = "0x400518F")]
		None = 0,
		[Token(Token = "0x4005190")]
		CardIcon = 1,
		[Token(Token = "0x4005191")]
		Level = 2,
		[Token(Token = "0x4005192")]
		Grade = 4,
		[Token(Token = "0x4005193")]
		Name = 8,
		[Token(Token = "0x4005194")]
		Upgrade = 16,
		[Token(Token = "0x4005195")]
		EnableSprite = 32,
		[Token(Token = "0x4005196")]
		NewBadge = 128,
		[Token(Token = "0x4005197")]
		Selected = 256,
		[Token(Token = "0x4005198")]
		Drag = 512,
		[Token(Token = "0x4005199")]
		FreeRotation = 1024,
		[Token(Token = "0x400519A")]
		NeedShowingOpenTime = 4096,
		[Token(Token = "0x400519B")]
		HaveOpenTime = 8192,
		[Token(Token = "0x400519C")]
		All = 65535
	}

	[Token(Token = "0x400516E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public UI2DSprite iconSprite;

	[Token(Token = "0x400516F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public UILabel levelLabel;

	[Token(Token = "0x4005170")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public UILabel lblName;

	[Token(Token = "0x4005171")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public UILabel lblTitle;

	[Token(Token = "0x4005172")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public XWiget_GridBuilder gridGrade;

	[Token(Token = "0x4005173")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public UILabel lblSoulStone;

	[Token(Token = "0x4005174")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public UIProgressBar prbSoulStone;

	[Token(Token = "0x4005175")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public XWidget_ProgressBarWithTable prbExp;

	[Token(Token = "0x4005176")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public GameObject badgeNew;

	[Token(Token = "0x4005177")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public UITweener upgradableTween;

	[Token(Token = "0x4005178")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public UISprite selected;

	[Token(Token = "0x4005179")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject goSprDisabled;

	[Token(Token = "0x400517A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public XUISound sound;

	[Token(Token = "0x400517B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public XModuleActor m_character;

	[Token(Token = "0x400517C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public UIWidget onPress;

	[Token(Token = "0x400517D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject getCharCostObj;

	[Token(Token = "0x400517E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public GameObject getCharCostGoldIconObj;

	[Token(Token = "0x400517F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject getCharCostCrystalIconObj;

	[Token(Token = "0x4005180")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public UILabel lblGetCharCost;

	[Token(Token = "0x4005181")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public XWidget_DragDrop dragDrop;

	[Token(Token = "0x4005182")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public GameObject goSprFreeRotation;

	[Token(Token = "0x4005183")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GameObject goCharacterOpenTime;

	[Token(Token = "0x4005184")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public UI2DSprite sprTime;

	[Token(Token = "0x4005185")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public UILabel lblTime;

	[Token(Token = "0x4005186")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private Action m_refreshCharacterOpenTimeAction;

	[Token(Token = "0x4005187")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private bool m_isOpen;

	[Token(Token = "0x4005188")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
	private bool m_IsDoOpenTimeAction;

	[Token(Token = "0x4005189")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private CardOption m_option;

	[Token(Token = "0x400518A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private int m_CurrentSoulStoneCount;

	[Token(Token = "0x400518B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public XUIEffectPool levelUpEffect;

	[Token(Token = "0x400518C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public string UIEventPopupSoundKey;

	[Token(Token = "0x400518D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private Action<object> m_onClick__BackingField;

	[Token(Token = "0x17000EA2")]
	public Action<object> m_onClick
	{
		[Token(Token = "0x60072F1")]
		[Address(RVA = "0x15C9068", Offset = "0x15C9068", VA = "0x15C9068")]
		get
		{
			return null;
		}
		[Token(Token = "0x60072F2")]
		[Address(RVA = "0x15C9070", Offset = "0x15C9070", VA = "0x15C9070")]
		private set
		{
		}
	}

	[Token(Token = "0x17000EA3")]
	
	public string CharUID
	{
		[Token(Token = "0x60072F3")]
		[Address(RVA = "0x15C9078", Offset = "0x15C9078", VA = "0x15C9078")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000EA4")]
	
	public int CharID
	{
		[Token(Token = "0x60072F4")]
		[Address(RVA = "0x15C90A4", Offset = "0x15C90A4", VA = "0x15C90A4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000EA5")]
	
	public int SkinID
	{
		[Token(Token = "0x60072F5")]
		[Address(RVA = "0x15C90D0", Offset = "0x15C90D0", VA = "0x15C90D0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60072F0")]
	[Address(RVA = "0x15C8FD4", Offset = "0x15C8FD4", VA = "0x15C8FD4")]
	public XWidget_CharacterCard()
	{
	}

	[Token(Token = "0x60072F6")]
	[Address(RVA = "0x15C90FC", Offset = "0x15C90FC", VA = "0x15C90FC")]
	private void Update()
	{
	}

	[Token(Token = "0x60072F7")]
	[Address(RVA = "0x15C9100", Offset = "0x15C9100", VA = "0x15C9100")]
	public void RefreshOpenTime()
	{
	}

	[Token(Token = "0x60072F8")]
	[Address(RVA = "0x15C94BC", Offset = "0x15C94BC", VA = "0x15C94BC")]
	public void Build(XModuleActor character, bool selected, Action calculatorCharacterOpenTime, [Optional] CardOption option, [Optional] Action<object> onClick, [Optional] Action<object> onDragStart)
	{
	}

	[Token(Token = "0x60072F9")]
	[Address(RVA = "0x15CAAA0", Offset = "0x15CAAA0", VA = "0x15CAAA0")]
	private void BuildCharacterOpenTIme(CardOption option, XModuleActor character)
	{
	}

	[Token(Token = "0x60072FA")]
	[Address(RVA = "0x15CA924", Offset = "0x15CA924", VA = "0x15CA924")]
	private void BuildDrag(CardOption option, XModuleActor character, Action<object> onDragStart)
	{
	}

	[Token(Token = "0x60072FB")]
	[Address(RVA = "0x15CAF8C", Offset = "0x15CAF8C", VA = "0x15CAF8C")]
	public void RegistDragFailDelegate(Action dropFailDelegate)
	{
	}

	[Token(Token = "0x60072FC")]
	[Address(RVA = "0x15CACCC", Offset = "0x15CACCC", VA = "0x15CACCC")]
	private bool IsOwnedCharacter(string charUID)
	{
		return default(bool);
	}

	[Token(Token = "0x60072FD")]
	[Address(RVA = "0x15CB06C", Offset = "0x15CB06C", VA = "0x15CB06C")]
	public CardOption GetOption()
	{
		return default(CardOption);
	}

	[Token(Token = "0x60072FE")]
	[Address(RVA = "0x15CACC4", Offset = "0x15CACC4", VA = "0x15CACC4")]
	public void SetOption(CardOption option)
	{
	}

	[Token(Token = "0x60072FF")]
	[Address(RVA = "0x15C94A8", Offset = "0x15C94A8", VA = "0x15C94A8")]
	private bool HasOption(CardOption option1, CardOption option2)
	{
		return default(bool);
	}

	[Token(Token = "0x6007300")]
	[Address(RVA = "0x15CB074", Offset = "0x15CB074", VA = "0x15CB074")]
	public static CardOption AddOption(CardOption option, CardOption add)
	{
		return default(CardOption);
	}

	[Token(Token = "0x6007301")]
	[Address(RVA = "0x15CB07C", Offset = "0x15CB07C", VA = "0x15CB07C")]
	public static CardOption RemoveOption(CardOption option, CardOption remove)
	{
		return default(CardOption);
	}

	[Token(Token = "0x6007302")]
	[Address(RVA = "0x15C9934", Offset = "0x15C9934", VA = "0x15C9934")]
	public void SetIcon(Sprite spr)
	{
	}

	[Token(Token = "0x6007303")]
	[Address(RVA = "0x15C998C", Offset = "0x15C998C", VA = "0x15C998C")]
	private void BuildLevel(CardOption option, string level)
	{
	}

	[Token(Token = "0x6007304")]
	[Address(RVA = "0x15C9B14", Offset = "0x15C9B14", VA = "0x15C9B14")]
	private void BuildName(CardOption option, string name, string title)
	{
	}

	[Token(Token = "0x6007305")]
	[Address(RVA = "0x15C9C9C", Offset = "0x15C9C9C", VA = "0x15C9C9C")]
	private void BuildGetCharCost(CardOption option, XModuleActor character)
	{
	}

	[Token(Token = "0x6007306")]
	[Address(RVA = "0x15CB084", Offset = "0x15CB084", VA = "0x15CB084")]
	private bool CheckGetCharCost(CSCharacterInfo characterInfo, int nMyGold, int nMyCrystal, int nMySoulStoneCount, bool showNoti = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6007307")]
	[Address(RVA = "0x15CB314", Offset = "0x15CB314", VA = "0x15CB314")]
	private bool CheckUpgradeVisible(int charLevel, int getCharSoulStoneCost, bool isOwnedChar)
	{
		return default(bool);
	}

	[Token(Token = "0x6007308")]
	[Address(RVA = "0x15C9F60", Offset = "0x15C9F60", VA = "0x15C9F60")]
	private void BuildUpgrade(CardOption option, XModuleActor character)
	{
	}

	[Token(Token = "0x6007309")]
	[Address(RVA = "0x15CB438", Offset = "0x15CB438", VA = "0x15CB438")]
	private void TweenRestart(UITweener tween, bool active)
	{
	}

	[Token(Token = "0x600730A")]
	[Address(RVA = "0x15CA464", Offset = "0x15CA464", VA = "0x15CA464")]
	private void BuildEnable(CardOption option)
	{
	}

	[Token(Token = "0x600730B")]
	[Address(RVA = "0x15CB540", Offset = "0x15CB540", VA = "0x15CB540")]
	private void ShowLevelUpEffect(int val)
	{
	}

	[Token(Token = "0x600730C")]
	[Address(RVA = "0x15CA55C", Offset = "0x15CA55C", VA = "0x15CA55C")]
	private void BuildBadgeNew(CardOption option, bool isShowed)
	{
	}

	[Token(Token = "0x600730D")]
	[Address(RVA = "0x15CA658", Offset = "0x15CA658", VA = "0x15CA658")]
	private void BuildSelected(CardOption option, bool isSelected)
	{
	}

	[Token(Token = "0x600730E")]
	[Address(RVA = "0x15CA7F8", Offset = "0x15CA7F8", VA = "0x15CA7F8")]
	private void BuildFreeRotation(CardOption option, int charID)
	{
	}

	[Token(Token = "0x600730F")]
	[Address(RVA = "0x15CAE30", Offset = "0x15CAE30", VA = "0x15CAE30")]
	private bool IsFreeRotaCharacter(int charID)
	{
		return default(bool);
	}

	[Token(Token = "0x6007310")]
	[Address(RVA = "0x15CB5FC", Offset = "0x15CB5FC", VA = "0x15CB5FC")]
	public void OnClick()
	{
	}

	[Token(Token = "0x6007311")]
	[Address(RVA = "0x15CB698", Offset = "0x15CB698", VA = "0x15CB698")]
	public void OnClick_GetCharacterCard()
	{
	}

	[Token(Token = "0x6007312")]
	[Address(RVA = "0x15CB728", Offset = "0x15CB728", VA = "0x15CB728")]
	public bool HasNew()
	{
		return default(bool);
	}

	[Token(Token = "0x6007313")]
	[Address(RVA = "0x15CB76C", Offset = "0x15CB76C", VA = "0x15CB76C")]
	public void DisableNewBadge()
	{
	}

	[Token(Token = "0x6007314")]
	[Address(RVA = "0x15CACBC", Offset = "0x15CACBC", VA = "0x15CACBC")]
	public void SetOnClick(Action<object> onClick)
	{
	}
}
