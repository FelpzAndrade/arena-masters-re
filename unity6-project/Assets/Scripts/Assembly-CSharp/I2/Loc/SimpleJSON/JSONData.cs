using System.IO;
using Il2CppDummyDll;

namespace I2.Loc.SimpleJSON
{
	[Token(Token = "0x200007A")]
	public class JSONData : JSONNode
	{
		[Token(Token = "0x4000215")]
		[FieldOffset(Offset = "0x8")]
		private string m_Data;

		[Token(Token = "0x1700007E")]
		public override string Value
		{
			[Token(Token = "0x60003E1")]
			[Address(RVA = "0xD84898", Offset = "0xD84898", VA = "0xD84898", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003E2")]
			[Address(RVA = "0xD848A0", Offset = "0xD848A0", VA = "0xD848A0", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0xD84720", Offset = "0xD84720", VA = "0xD84720")]
		public JSONData(string aData)
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0xD84740", Offset = "0xD84740", VA = "0xD84740")]
		public JSONData(float aData)
		{
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0xD84794", Offset = "0xD84794", VA = "0xD84794")]
		public JSONData(double aData)
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0xD847F0", Offset = "0xD847F0", VA = "0xD847F0")]
		public JSONData(bool aData)
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0xD84844", Offset = "0xD84844", VA = "0xD84844")]
		public JSONData(int aData)
		{
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0xD848A8", Offset = "0xD848A8", VA = "0xD848A8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0xD84988", Offset = "0xD84988", VA = "0xD84988", Slot = "17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0xD84A68", Offset = "0xD84A68", VA = "0xD84A68", Slot = "28")]
		public override void Serialize(BinaryWriter aWriter)
		{
		}
	}
}
