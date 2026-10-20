using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F77")]
public class XWidget_CurrencyInfo : MonoBehaviour
{
	[Token(Token = "0x2000F78")]
	public abstract class EnterResourceInfo
	{
		protected EnterResourceInfo()
		{
		}

		[Token(Token = "0x40051B4")]
		[FieldOffset(Offset = "0x8")]
		protected XMyInfo m_myInfo;

		[Token(Token = "0x17000EA7")]
		public abstract string ResourceText
		{
			[Token(Token = "0x6007334")]
			get;
		}

		[Token(Token = "0x17000EA8")]
		public abstract long LastCheckTime
		{
			[Token(Token = "0x6007335")]
			get;
		}

		[Token(Token = "0x17000EA9")]
		public abstract int RestorePeriod
		{
			[Token(Token = "0x6007336")]
			get;
		}

		[Token(Token = "0x17000EAA")]
		public abstract string InfoPrefix
		{
			[Token(Token = "0x6007337")]
			get;
		}

		[Token(Token = "0x17000EAB")]
		public abstract bool IsMax
		{
			[Token(Token = "0x6007338")]
			get;
		}

		[Token(Token = "0x6007333")]
		[Address(RVA = "0x15ED2E4", Offset = "0x15ED2E4", VA = "0x15ED2E4")]
		public EnterResourceInfo(XMyInfo myInfo)
		{
		}
	}

	[Token(Token = "0x2000F79")]
	public sealed class EnergyInfo : EnterResourceInfo
	{
		[Token(Token = "0x17000EAC")]
		public override string ResourceText
		{
			[Token(Token = "0x600733A")]
			[Address(RVA = "0x15ED304", Offset = "0x15ED304", VA = "0x15ED304", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000EAD")]
		public override long LastCheckTime
		{
			[Token(Token = "0x600733B")]
			[Address(RVA = "0x15ED47C", Offset = "0x15ED47C", VA = "0x15ED47C", Slot = "5")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x17000EAE")]
		public override string InfoPrefix
		{
			[Token(Token = "0x600733C")]
			[Address(RVA = "0x15ED4A8", Offset = "0x15ED4A8", VA = "0x15ED4A8", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000EAF")]
		public override bool IsMax
		{
			[Token(Token = "0x600733D")]
			[Address(RVA = "0x15ED52C", Offset = "0x15ED52C", VA = "0x15ED52C", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000EB0")]
		public override int RestorePeriod
		{
			[Token(Token = "0x600733E")]
			[Address(RVA = "0x15ED584", Offset = "0x15ED584", VA = "0x15ED584", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6007339")]
		[Address(RVA = "0x15ED0EC", Offset = "0x15ED0EC", VA = "0x15ED0EC")]
		public EnergyInfo(XMyInfo myInfo)
		{
		}
	}

	[Token(Token = "0x2000F7A")]
	public sealed class StaminaInfo : EnterResourceInfo
	{
		[Token(Token = "0x17000EB1")]
		public override string ResourceText
		{
			[Token(Token = "0x6007340")]
			[Address(RVA = "0x15ED58C", Offset = "0x15ED58C", VA = "0x15ED58C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000EB2")]
		public override long LastCheckTime
		{
			[Token(Token = "0x6007341")]
			[Address(RVA = "0x15ED704", Offset = "0x15ED704", VA = "0x15ED704", Slot = "5")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x17000EB3")]
		public override string InfoPrefix
		{
			[Token(Token = "0x6007342")]
			[Address(RVA = "0x15ED730", Offset = "0x15ED730", VA = "0x15ED730", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000EB4")]
		public override bool IsMax
		{
			[Token(Token = "0x6007343")]
			[Address(RVA = "0x15ED7B4", Offset = "0x15ED7B4", VA = "0x15ED7B4", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000EB5")]
		public override int RestorePeriod
		{
			[Token(Token = "0x6007344")]
			[Address(RVA = "0x15ED80C", Offset = "0x15ED80C", VA = "0x15ED80C", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600733F")]
		[Address(RVA = "0x15ED0CC", Offset = "0x15ED0CC", VA = "0x15ED0CC")]
		public StaminaInfo(XMyInfo myInfo)
		{
		}
	}

	[Token(Token = "0x40051A8")]
	[FieldOffset(Offset = "0xC")]
	private EnterResourceInfo m_enterResourceInfo;

	[Token(Token = "0x40051A9")]
	[FieldOffset(Offset = "0x10")]
	public GameObject BtnResourceAdd;

	[Token(Token = "0x40051AA")]
	[FieldOffset(Offset = "0x14")]
	public XWidget_OnPress pressCallBack;

	[Token(Token = "0x40051AB")]
	[FieldOffset(Offset = "0x18")]
	public GameObject goTweenRoot;

	[Token(Token = "0x40051AC")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject goWideRoot;

	[Token(Token = "0x40051AD")]
	[FieldOffset(Offset = "0x20")]
	public GameObject goNarrowRoot;

	[Token(Token = "0x40051AE")]
	[FieldOffset(Offset = "0x24")]
	public UI2DSprite sprIcon;

	[Token(Token = "0x40051AF")]
	[FieldOffset(Offset = "0x28")]
	public UILabel lblNarrowCount;

	[Token(Token = "0x40051B0")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel lblWideCount;

	[Token(Token = "0x40051B1")]
	[FieldOffset(Offset = "0x30")]
	public UILabel lblChargeInfo;

	[Token(Token = "0x40051B2")]
	[FieldOffset(Offset = "0x34")]
	public TweenAlpha tweenAlpha;

	[Token(Token = "0x40051B3")]
	[FieldOffset(Offset = "0x38")]
	private Currency Currency__BackingField;

	[Token(Token = "0x17000EA6")]
	public Currency Currency
	{
		[Token(Token = "0x6007328")]
		[Address(RVA = "0x15EC33C", Offset = "0x15EC33C", VA = "0x15EC33C")]
		get
		{
			return default(Currency);
		}
		[Token(Token = "0x6007329")]
		[Address(RVA = "0x15EC344", Offset = "0x15EC344", VA = "0x15EC344")]
		private set
		{
		}
	}

	[Token(Token = "0x6007327")]
	[Address(RVA = "0x15EC334", Offset = "0x15EC334", VA = "0x15EC334")]
	public XWidget_CurrencyInfo()
	{
	}

	[Token(Token = "0x600732A")]
	[Address(RVA = "0x15EC34C", Offset = "0x15EC34C", VA = "0x15EC34C")]
	public void Awake()
	{
	}

	[Token(Token = "0x600732B")]
	[Address(RVA = "0x15EC460", Offset = "0x15EC460", VA = "0x15EC460")]
	public void ShowEnterResourceChargeInfo()
	{
	}

	[Token(Token = "0x600732C")]
	[Address(RVA = "0x15EC514", Offset = "0x15EC514", VA = "0x15EC514")]
	public void HideEnterResourceChargeInfo()
	{
	}

	[Token(Token = "0x600732D")]
	[Address(RVA = "0x15EC540", Offset = "0x15EC540", VA = "0x15EC540")]
	private void SetCount(string text)
	{
	}

	[Token(Token = "0x600732E")]
	[Address(RVA = "0x15EC57C", Offset = "0x15EC57C", VA = "0x15EC57C")]
	private void RefreshEnterResource()
	{
	}

	[Token(Token = "0x600732F")]
	[Address(RVA = "0x15ECADC", Offset = "0x15ECADC", VA = "0x15ECADC")]
	public void Build(XMyInfo myInfo, Currency currency)
	{
	}

	[Token(Token = "0x6007330")]
	[Address(RVA = "0x15ECFDC", Offset = "0x15ECFDC", VA = "0x15ECFDC")]
	private void SetEnergyInfo(XMyInfo myInfo, Currency currency)
	{
	}

	[Token(Token = "0x6007331")]
	[Address(RVA = "0x15ED0A8", Offset = "0x15ED0A8", VA = "0x15ED0A8")]
	private bool IsBtnAddedActive(Currency currency)
	{
		return default(bool);
	}

	[Token(Token = "0x6007332")]
	[Address(RVA = "0x15ED10C", Offset = "0x15ED10C", VA = "0x15ED10C")]
	public void OnClick_Added()
	{
	}
}
