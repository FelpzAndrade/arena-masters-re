using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using UnityEngine;

[Token(Token = "0x2000D85")]
public class XUIRespawnWindow : MonoBehaviour
{
	[Token(Token = "0x4004619")]
	[FieldOffset(Offset = "0xC")]
	public UIWidget widget;

	[Token(Token = "0x400461A")]
	[FieldOffset(Offset = "0x10")]
	public UIProgressBar TimeProgressBar;

	[Token(Token = "0x400461B")]
	[FieldOffset(Offset = "0x14")]
	public UILabel lblPrice;

	[Token(Token = "0x400461C")]
	[FieldOffset(Offset = "0x18")]
	public UIButton btnInstantRespawn;

	[Token(Token = "0x400461D")]
	[FieldOffset(Offset = "0x1C")]
	public UIBasicSprite sprInstantRespawn;

	[Token(Token = "0x400461E")]
	[FieldOffset(Offset = "0x20")]
	public UIBasicSprite sprInstantRespawnIcon;

	[Token(Token = "0x400461F")]
	[FieldOffset(Offset = "0x24")]
	public UIBasicSprite sprHide;

	[Token(Token = "0x4004620")]
	[FieldOffset(Offset = "0x28")]
	public GameObject record;

	[Token(Token = "0x4004621")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel lblRank;

	[Token(Token = "0x4004622")]
	[FieldOffset(Offset = "0x30")]
	public UILabel lblKill;

	[Token(Token = "0x4004623")]
	[FieldOffset(Offset = "0x34")]
	public UILabel lblDeath;

	[Token(Token = "0x4004624")]
	[FieldOffset(Offset = "0x38")]
	public UILabel lblAssist;

	[Token(Token = "0x4004625")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel lblInstantRespawnCount;

	[Token(Token = "0x4004626")]
	[FieldOffset(Offset = "0x40")]
	public float m_fTime;

	[Token(Token = "0x4004627")]
	[FieldOffset(Offset = "0x44")]
	public bool m_AutoRespawn;

	[Token(Token = "0x4004628")]
	[FieldOffset(Offset = "0x45")]
	private bool m_bClicked;

	[Token(Token = "0x4004629")]
	[FieldOffset(Offset = "0x46")]
	private bool m_bRespawned;

	[Token(Token = "0x400462A")]
	[FieldOffset(Offset = "0x47")]
	private bool m_bBuildedPrice;

	[Token(Token = "0x400462B")]
	[FieldOffset(Offset = "0x48")]
	private GameModeInfo m_CurrentGameModeInfo;

	[Token(Token = "0x600634B")]
	[Address(RVA = "0x191A40C", Offset = "0x191A40C", VA = "0x191A40C")]
	public XUIRespawnWindow()
	{
	}

	[Token(Token = "0x600634C")]
	[Address(RVA = "0x191A414", Offset = "0x191A414", VA = "0x191A414")]
	private void Update()
	{
	}

	[Token(Token = "0x600634D")]
	[Address(RVA = "0x191A738", Offset = "0x191A738", VA = "0x191A738")]
	public void Build()
	{
	}

	[Token(Token = "0x600634E")]
	[Address(RVA = "0x191B198", Offset = "0x191B198", VA = "0x191B198")]
	public void Build(int rank, int killCount, int deathCount, int assistCount)
	{
	}

	[Token(Token = "0x600634F")]
	[Address(RVA = "0x191B38C", Offset = "0x191B38C", VA = "0x191B38C")]
	public void Hide()
	{
	}

	[Token(Token = "0x6006350")]
	[Address(RVA = "0x191A6E4", Offset = "0x191A6E4", VA = "0x191A6E4")]
	private void UpdateWidgets()
	{
	}

	[Token(Token = "0x6006351")]
	[Address(RVA = "0x191B3C0", Offset = "0x191B3C0", VA = "0x191B3C0")]
	private void BuildPrice()
	{
	}

	[Token(Token = "0x6006352")]
	[Address(RVA = "0x191AE40", Offset = "0x191AE40", VA = "0x191AE40")]
	private void BuildRecord(bool bShow, int rank = 0, int kill = 0, int death = 0, int assist = 0)
	{
	}

	[Token(Token = "0x6006353")]
	[Address(RVA = "0x191B078", Offset = "0x191B078", VA = "0x191B078")]
	private void BuildInstantRespawnCount(int count)
	{
	}

	[Token(Token = "0x6006354")]
	[Address(RVA = "0x191AB98", Offset = "0x191AB98", VA = "0x191AB98")]
	private void BuildButtonEnabled(bool bShow)
	{
	}

	[Token(Token = "0x6006355")]
	[Address(RVA = "0x191B544", Offset = "0x191B544", VA = "0x191B544")]
	private bool CheckInstantRespawnEnabled()
	{
		return default(bool);
	}

	[Token(Token = "0x6006356")]
	[Address(RVA = "0x191A91C", Offset = "0x191A91C", VA = "0x191A91C")]
	private int GetRespawnTime()
	{
		return default(int);
	}

	[Token(Token = "0x6006357")]
	[Address(RVA = "0x191A5C4", Offset = "0x191A5C4", VA = "0x191A5C4")]
	private void Respawn()
	{
	}

	[Token(Token = "0x6006358")]
	[Address(RVA = "0x191B7EC", Offset = "0x191B7EC", VA = "0x191B7EC")]
	private void ResetCooltime()
	{
	}

	[Token(Token = "0x6006359")]
	[Address(RVA = "0x191AAB4", Offset = "0x191AAB4", VA = "0x191AAB4")]
	private int CalcEnabledInstantRespawnCount()
	{
		return default(int);
	}

	[Token(Token = "0x600635A")]
	[Address(RVA = "0x191B940", Offset = "0x191B940", VA = "0x191B940")]
	private bool CheckInstanceRespawnEnabled(int currentRespawnCount, int maxInstantRespawnCount)
	{
		return default(bool);
	}

	[Token(Token = "0x600635B")]
	[Address(RVA = "0x191B6FC", Offset = "0x191B6FC", VA = "0x191B6FC")]
	private bool CheckInstanceRespawnEnabled()
	{
		return default(bool);
	}

	[Token(Token = "0x600635C")]
	[Address(RVA = "0x191B950", Offset = "0x191B950", VA = "0x191B950")]
	private void IncInstantRespawnCount()
	{
	}

	[Token(Token = "0x600635D")]
	[Address(RVA = "0x191BAC0", Offset = "0x191BAC0", VA = "0x191BAC0")]
	public void OnButtonClick_InstantRespawn()
	{
	}

	[Token(Token = "0x600635E")]
	[Address(RVA = "0x191BE30", Offset = "0x191BE30", VA = "0x191BE30")]
	private void _003COnButtonClick_InstantRespawn_003Em__315(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
	{
	}
}
