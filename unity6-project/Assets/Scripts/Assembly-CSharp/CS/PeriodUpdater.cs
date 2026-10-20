using System;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x20008AE")]
	public class PeriodUpdater
	{
		protected PeriodUpdater()
		{
		}

		[Token(Token = "0x4002A88")]
		[FieldOffset(Offset = "0x8")]
		protected Action<float> action;

		[Token(Token = "0x4002A89")]
		[FieldOffset(Offset = "0xC")]
		protected float tickTime;

		[Token(Token = "0x4002A8A")]
		[FieldOffset(Offset = "0x10")]
		protected float remainTime;

		[Token(Token = "0x4002A8B")]
		[FieldOffset(Offset = "0x14")]
		protected bool runOnce;

		[Token(Token = "0x4002A8C")]
		[FieldOffset(Offset = "0x15")]
		protected bool processed;

		[Token(Token = "0x6004666")]
		[Address(RVA = "0x21ADECC", Offset = "0x21ADECC", VA = "0x21ADECC")]
		public PeriodUpdater(float tickTime, Action<float> action, bool runOnce = false)
		{
		}

		[Token(Token = "0x6004667")]
		[Address(RVA = "0x21ADF38", Offset = "0x21ADF38", VA = "0x21ADF38")]
		public void Reset()
		{
		}

		[Token(Token = "0x6004668")]
		[Address(RVA = "0x21ADF84", Offset = "0x21ADF84", VA = "0x21ADF84", Slot = "4")]
		protected virtual void ResetTime()
		{
		}

		[Token(Token = "0x6004669")]
		[Address(RVA = "0x21ADF90", Offset = "0x21ADF90", VA = "0x21ADF90", Slot = "5")]
		public virtual void Update(float delta)
		{
		}
	}
}
