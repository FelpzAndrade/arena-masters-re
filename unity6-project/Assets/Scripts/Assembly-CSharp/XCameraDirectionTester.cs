using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20004BE")]
public class XCameraDirectionTester : MonoBehaviour
{
	[Token(Token = "0x4001791")]
	[FieldOffset(Offset = "0xC")]
	public GameObject actor;

	[Token(Token = "0x4001792")]
	[FieldOffset(Offset = "0x10")]
	public Transform start;

	[Token(Token = "0x4001793")]
	[FieldOffset(Offset = "0x14")]
	public Transform end;

	[Token(Token = "0x4001794")]
	[FieldOffset(Offset = "0x18")]
	public Transform focusingTarget;

	[Token(Token = "0x4001795")]
	[FieldOffset(Offset = "0x1C")]
	private XGamePlayController control;

	[Token(Token = "0x4001796")]
	[FieldOffset(Offset = "0x20")]
	public XInstancePoolsInitializers instancePoolsInitializers;

	[Token(Token = "0x4001797")]
	[FieldOffset(Offset = "0x24")]
	public Vector3 targetOffset;

	[Token(Token = "0x4001798")]
	[FieldOffset(Offset = "0x30")]
	public Vector3 cameraOffset;

	[Token(Token = "0x4001799")]
	[FieldOffset(Offset = "0x3C")]
	public Vector3 orbitStart;

	[Token(Token = "0x400179A")]
	[FieldOffset(Offset = "0x48")]
	public Vector3 orbitEnd;

	[Token(Token = "0x400179B")]
	[FieldOffset(Offset = "0x54")]
	public float distance;

	[Token(Token = "0x400179C")]
	[FieldOffset(Offset = "0x58")]
	public float duration;

	[Token(Token = "0x400179D")]
	[FieldOffset(Offset = "0x5C")]
	public float focusingDistanceOffset;

	[Token(Token = "0x400179E")]
	[FieldOffset(Offset = "0x60")]
	public Vector3 focusingPositionOffset;

	[Token(Token = "0x400179F")]
	[FieldOffset(Offset = "0x6C")]
	public float focusingMoveSpeed_Boss;

	[Token(Token = "0x40017A0")]
	[FieldOffset(Offset = "0x70")]
	public iTween.EaseType focusingMoveEaseType_Boss;

	[Token(Token = "0x40017A1")]
	[FieldOffset(Offset = "0x74")]
	public float focusingRotateSpeed_Boss;

	[Token(Token = "0x40017A2")]
	[FieldOffset(Offset = "0x78")]
	public iTween.EaseType focusingRotateEaseType_Boss;

	[Token(Token = "0x40017A3")]
	[FieldOffset(Offset = "0x7C")]
	public float focusingMoveSpeed_Player;

	[Token(Token = "0x40017A4")]
	[FieldOffset(Offset = "0x80")]
	public iTween.EaseType focusingMoveEaseType_Player;

	[Token(Token = "0x40017A5")]
	[FieldOffset(Offset = "0x84")]
	public float focusingRotateSpeed_Player;

	[Token(Token = "0x40017A6")]
	[FieldOffset(Offset = "0x88")]
	public iTween.EaseType focusingRotateEaseType_Player;

	[Token(Token = "0x40017A7")]
	[FieldOffset(Offset = "0x8C")]
	public float claerEffectDistanceOffset;

	[Token(Token = "0x40017A8")]
	[FieldOffset(Offset = "0x90")]
	public Vector3 clearEffectPositionOffset;

	[Token(Token = "0x40017A9")]
	[FieldOffset(Offset = "0x9C")]
	public float claerEffectMoveSpeed_Boss;

	[Token(Token = "0x40017AA")]
	[FieldOffset(Offset = "0xA0")]
	public iTween.EaseType claerMoveEaseType;

	[Token(Token = "0x40017AB")]
	[FieldOffset(Offset = "0xA4")]
	public float claerEffectRotateSpeed_Boss;

	[Token(Token = "0x40017AC")]
	[FieldOffset(Offset = "0xA8")]
	public iTween.EaseType claerRotateEaseType;

	[Token(Token = "0x40017AD")]
	[FieldOffset(Offset = "0xAC")]
	public float clearEffectDurationTime;

	[Token(Token = "0x40017AE")]
	[FieldOffset(Offset = "0xB0")]
	public float claerEffectShakingSpeed;

	[Token(Token = "0x40017AF")]
	[FieldOffset(Offset = "0xB4")]
	public float claerEffectShakingAmount;

	[Token(Token = "0x40017B0")]
	[FieldOffset(Offset = "0xB8")]
	public iTween.EaseType claerShakeEaseType;

	[Token(Token = "0x40017B1")]
	[FieldOffset(Offset = "0xBC")]
	public float showResultMoveSpeed;

	[Token(Token = "0x40017B2")]
	[FieldOffset(Offset = "0xC0")]
	public iTween.EaseType showResultMoveEaseType;

	[Token(Token = "0x40017B3")]
	[FieldOffset(Offset = "0xC4")]
	public float showResultRotateSpeed;

	[Token(Token = "0x40017B4")]
	[FieldOffset(Offset = "0xC8")]
	public iTween.EaseType showResultRotateEaseTypes;

	[Token(Token = "0x40017B5")]
	[FieldOffset(Offset = "0xCC")]
	public float showResultRightDistance;

	[Token(Token = "0x40017B6")]
	[FieldOffset(Offset = "0xD0")]
	public float showResultUpDistance;

	[Token(Token = "0x40017B7")]
	[FieldOffset(Offset = "0xD4")]
	public float showResultForwardDistance;

	[Token(Token = "0x40017B8")]
	[FieldOffset(Offset = "0xD8")]
	public float lookatHeightOffset;

	[Token(Token = "0x40017B9")]
	[FieldOffset(Offset = "0xDC")]
	public GameObject player;

	[Token(Token = "0x40017BA")]
	[FieldOffset(Offset = "0xE0")]
	public XModuleEntity playerEntity;

	[Token(Token = "0x40017BB")]
	[FieldOffset(Offset = "0xE4")]
	public XPanel_GameResultExpression gameResultExpression;

	[Token(Token = "0x40017BC")]
	[FieldOffset(Offset = "0xE8")]
	public XPanel_ResultCharactersDirectionRoot resultCharactersDirectionRoot;

	[Token(Token = "0x40017BD")]
	[FieldOffset(Offset = "0xEC")]
	public int char_0;

	[Token(Token = "0x40017BE")]
	[FieldOffset(Offset = "0xF0")]
	public int charSkin_0;

	[Token(Token = "0x40017BF")]
	[FieldOffset(Offset = "0xF4")]
	public int char_1;

	[Token(Token = "0x40017C0")]
	[FieldOffset(Offset = "0xF8")]
	public int charSkin_1;

	[Token(Token = "0x40017C1")]
	[FieldOffset(Offset = "0xFC")]
	public int char_2;

	[Token(Token = "0x40017C2")]
	[FieldOffset(Offset = "0x100")]
	public int charSkin_2;

	[Token(Token = "0x40017C3")]
	[FieldOffset(Offset = "0x104")]
	public int char_3;

	[Token(Token = "0x40017C4")]
	[FieldOffset(Offset = "0x108")]
	public int charSkin_3;

	[Token(Token = "0x40017C5")]
	[FieldOffset(Offset = "0x10C")]
	public int char_4;

	[Token(Token = "0x40017C6")]
	[FieldOffset(Offset = "0x110")]
	public int charSkin_4;

	[Token(Token = "0x40017C7")]
	[FieldOffset(Offset = "0x114")]
	public int char_5;

	[Token(Token = "0x40017C8")]
	[FieldOffset(Offset = "0x118")]
	public int charSkin_5;

	[Token(Token = "0x40017C9")]
	[FieldOffset(Offset = "0x11C")]
	public XPanel_GameRecords pnlGameRecord;

	[Token(Token = "0x60028BE")]
	[Address(RVA = "0x1AA2B3C", Offset = "0x1AA2B3C", VA = "0x1AA2B3C")]
	public XCameraDirectionTester()
	{
	}

	[Token(Token = "0x60028BF")]
	[Address(RVA = "0x1AA2D58", Offset = "0x1AA2D58", VA = "0x1AA2D58")]
	private void Start()
	{
	}

	[Token(Token = "0x60028C0")]
	[Address(RVA = "0x1AA3230", Offset = "0x1AA3230", VA = "0x1AA3230")]
	private void Update()
	{
	}

	[Token(Token = "0x60028C1")]
	[Address(RVA = "0x1AA3A54", Offset = "0x1AA3A54", VA = "0x1AA3A54")]
	private void EndResultExpression()
	{
	}

	[Token(Token = "0x60028C2")]
	[Address(RVA = "0x1AA4780", Offset = "0x1AA4780", VA = "0x1AA4780")]
	private void ShowTest()
	{
	}

	[Token(Token = "0x60028C3")]
	[Address(RVA = "0x1AA4154", Offset = "0x1AA4154", VA = "0x1AA4154")]
	private void AddPlayerManager(XPlayerManager playerManager)
	{
	}

	[Token(Token = "0x60028C4")]
	[Address(RVA = "0x1AA2F6C", Offset = "0x1AA2F6C", VA = "0x1AA2F6C")]
	private static void AddCharatersInfo()
	{
	}
}
