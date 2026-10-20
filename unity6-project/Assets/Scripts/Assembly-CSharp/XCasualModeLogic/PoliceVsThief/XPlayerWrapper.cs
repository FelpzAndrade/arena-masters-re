using CS;
using Il2CppDummyDll;

namespace XCasualModeLogic.PoliceVsThief
{
	[Token(Token = "0x200052D")]
	public class XPlayerWrapper : IPlayer, IActor, IPolice, IThief
	{
		protected XPlayerWrapper()
		{
		}

		[Token(Token = "0x4001A0F")]
		[FieldOffset(Offset = "0x8")]
		protected XPlayer pp;

		[Token(Token = "0x4001A10")]
		[FieldOffset(Offset = "0xC")]
		private float surviveElapsed;

		[Token(Token = "0x170006E3")]
		public PoliceVsThiefRole Role
		{
			[Token(Token = "0x6002C3E")]
			[Address(RVA = "0x1AAF908", Offset = "0x1AAF908", VA = "0x1AAF908", Slot = "5")]
			get
			{
				return default(PoliceVsThiefRole);
			}
			[Token(Token = "0x6002C3F")]
			[Address(RVA = "0x1AB522C", Offset = "0x1AB522C", VA = "0x1AB522C")]
			set
			{
			}
		}

		[Token(Token = "0x170006E4")]
		public int BuffID
		{
			[Token(Token = "0x6002C40")]
			[Address(RVA = "0x1AB52D4", Offset = "0x1AB52D4", VA = "0x1AB52D4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6002C41")]
			[Address(RVA = "0x1AB53C8", Offset = "0x1AB53C8", VA = "0x1AB53C8")]
			set
			{
			}
		}

		[Token(Token = "0x170006E5")]
		public XTeamEnum Team
		{
			[Token(Token = "0x6002C43")]
			[Address(RVA = "0x1AB5474", Offset = "0x1AB5474", VA = "0x1AB5474", Slot = "4")]
			get
			{
				return default(XTeamEnum);
			}
		}

		[Token(Token = "0x170006E6")]
		public int ProfileIcon
		{
			[Token(Token = "0x6002C44")]
			[Address(RVA = "0x1AB54A8", Offset = "0x1AB54A8", VA = "0x1AB54A8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170006E7")]
		public bool IsDead
		{
			[Token(Token = "0x6002C45")]
			[Address(RVA = "0x1AB54CC", Offset = "0x1AB54CC", VA = "0x1AB54CC", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170006E8")]
		public bool IsArrested
		{
			[Token(Token = "0x6002C46")]
			[Address(RVA = "0x1AB55FC", Offset = "0x1AB55FC", VA = "0x1AB55FC", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170006E9")]
		public int KeyCount
		{
			[Token(Token = "0x6002C47")]
			[Address(RVA = "0x1AB572C", Offset = "0x1AB572C", VA = "0x1AB572C", Slot = "15")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170006EA")]
		public float SurviveTime
		{
			[Token(Token = "0x6002C4A")]
			[Address(RVA = "0x1AB59A4", Offset = "0x1AB59A4", VA = "0x1AB59A4", Slot = "16")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6002C4B")]
			[Address(RVA = "0x1AB59AC", Offset = "0x1AB59AC", VA = "0x1AB59AC", Slot = "17")]
			set
			{
			}
		}

		[Token(Token = "0x170006EB")]
		public bool IsLocal
		{
			[Token(Token = "0x6002C4C")]
			[Address(RVA = "0x1AB59B4", Offset = "0x1AB59B4", VA = "0x1AB59B4", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170006EC")]
		public int RoleBuff
		{
			[Token(Token = "0x6002C4D")]
			[Address(RVA = "0x1AB03C8", Offset = "0x1AB03C8", VA = "0x1AB03C8", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170006ED")]
		public int SafeScore
		{
			[Token(Token = "0x6002C4E")]
			[Address(RVA = "0x1AB59D8", Offset = "0x1AB59D8", VA = "0x1AB59D8", Slot = "9")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170006EE")]
		public bool Escaped
		{
			[Token(Token = "0x6002C4F")]
			[Address(RVA = "0x1AB5ACC", Offset = "0x1AB5ACC", VA = "0x1AB5ACC", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6002C3D")]
		[Address(RVA = "0x1AAEF74", Offset = "0x1AAEF74", VA = "0x1AAEF74")]
		public XPlayerWrapper(XPlayer xPlayer)
		{
		}

		[Token(Token = "0x6002C42")]
		[Address(RVA = "0x1AB5470", Offset = "0x1AB5470", VA = "0x1AB5470", Slot = "19")]
		public virtual void ChangeRoll(PoliceVsThiefRole role, int buffID)
		{
		}

		[Token(Token = "0x6002C48")]
		[Address(RVA = "0x1AB5760", Offset = "0x1AB5760", VA = "0x1AB5760", Slot = "11")]
		public void IncreaseRoundEndSurvive()
		{
		}

		[Token(Token = "0x6002C49")]
		[Address(RVA = "0x1AB5834", Offset = "0x1AB5834", VA = "0x1AB5834", Slot = "18")]
		public void IncreaseSurvive()
		{
		}

		[Token(Token = "0x6002C50")]
		[Address(RVA = "0x1AB5B00", Offset = "0x1AB5B00", VA = "0x1AB5B00", Slot = "20")]
		public virtual void OnStrongBoxOpened()
		{
		}
	}
}
