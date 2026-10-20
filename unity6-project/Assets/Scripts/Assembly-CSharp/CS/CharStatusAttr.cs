using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x200091F")]
	public class CharStatusAttr
	{
		[Token(Token = "0x4002D41")]
		[FieldOffset(Offset = "0x8")]
		public float value;

		[Token(Token = "0x4002D42")]
		[FieldOffset(Offset = "0xC")]
		public float ratio;

		[Token(Token = "0x4002D43")]
		[FieldOffset(Offset = "0x10")]
		public float multiplier;

		[Token(Token = "0x60048E5")]
		[Address(RVA = "0x23EA2D4", Offset = "0x23EA2D4", VA = "0x23EA2D4")]
		public CharStatusAttr()
		{
			value = 0f;
			ratio = 0f;
			multiplier = 1f;
		}

		[Token(Token = "0x60048E6")]
		[Address(RVA = "0x23E9868", Offset = "0x23E9868", VA = "0x23E9868")]
		public void Clear()
		{
			value = 0f;
			ratio = 0f;
			multiplier = 1f;
		}

		[Token(Token = "0x60048E7")]
		[Address(RVA = "0x23E96AC", Offset = "0x23E96AC", VA = "0x23E96AC")]
		public bool IsChanged()
		{
			return value != 0f || ratio != 0f || multiplier != 1f;
		}

		[Token(Token = "0x60048E8")]
		[Address(RVA = "0x23EA300", Offset = "0x23EA300", VA = "0x23EA300")]
		public bool IsRatio()
		{
			return ratio != 0f;
		}

		[Token(Token = "0x60048E9")]
		[Address(RVA = "0x23EA318", Offset = "0x23EA318", VA = "0x23EA318")]
		public bool IsMultiplier()
		{
			return multiplier != 1f;
		}

		[Token(Token = "0x60048EA")]
		[Address(RVA = "0x23EA334", Offset = "0x23EA334", VA = "0x23EA334")]
		public bool IsValue()
		{
			return value != 0f;
		}

		[Token(Token = "0x60048EB")]
		[Address(RVA = "0x23EA34C", Offset = "0x23EA34C", VA = "0x23EA34C")]
		public float GetPureStat()
		{
			if (value != 0f)
			{
				return value;
			}
			if (ratio != 0f)
			{
				return ratio;
			}
			return multiplier;
		}

		[Token(Token = "0x60048EC")]
		[Address(RVA = "0x23EA374", Offset = "0x23EA374", VA = "0x23EA374")]
		public float GetItemPureStat()
		{
			if (value != 0f)
			{
				return value;
			}
			if (ratio != 0f)
			{
				return ratio;
			}
			return multiplier - 1f;
		}

		[Token(Token = "0x60048ED")]
		[Address(RVA = "0x23EA3A4", Offset = "0x23EA3A4", VA = "0x23EA3A4")]
		public float GetDiffPureStat()
		{
			if (multiplier != 0f)
			{
				return multiplier;
			}
			if (value != 0f)
			{
				return value;
			}
			return ratio;
		}

		[Token(Token = "0x60048EE")]
		[Address(RVA = "0x23E9A14", Offset = "0x23E9A14", VA = "0x23E9A14")]
		public bool IsEmpty()
		{
			return value == 0f && ratio == 0f && multiplier == 1f;
		}

		[Token(Token = "0x60048EF")]
		[Address(RVA = "0x23EA3CC", Offset = "0x23EA3CC", VA = "0x23EA3CC")]
		public bool IsDiffEmpty()
		{
			return value == 0f && ratio == 0f && multiplier == 0f;
		}

		[Token(Token = "0x60048F0")]
		[Address(RVA = "0x23EA40C", Offset = "0x23EA40C", VA = "0x23EA40C")]
		public float Calc()
		{
			return multiplier * value * (ratio + 1f);
		}

		[Token(Token = "0x60048F1")]
		[Address(RVA = "0x23EA430", Offset = "0x23EA430", VA = "0x23EA430")]
		public void Set(CharStatusAttr other)
		{
			value = other.value;
			ratio = other.ratio;
			multiplier = other.multiplier;
		}

		[Token(Token = "0x60048F2")]
		[Address(RVA = "0x23EA464", Offset = "0x23EA464", VA = "0x23EA464")]
		public static CharStatusAttr GetDiff(CharStatusAttr lhsVal, CharStatusAttr rhsVal, StatDesc statDesc)
		{
			return null;
		}

		[Token(Token = "0x60048F3")]
		[Address(RVA = "0x23E9E5C", Offset = "0x23E9E5C", VA = "0x23E9E5C")]
		public void Merge(CharStatusAttr other, float multiply = 1f)
		{
			ratio += other.ratio * multiply;
			value += other.value * multiply;
			multiplier += (other.multiplier - 1f) * multiply;
		}
	}
}
