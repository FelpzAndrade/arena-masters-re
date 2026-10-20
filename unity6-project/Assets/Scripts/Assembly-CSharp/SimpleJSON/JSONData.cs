using System.IO;
using Il2CppDummyDll;

namespace SimpleJSON
{
	[Token(Token = "0x20010CD")]
	public class JSONData : JSONNode
	{
		[Token(Token = "0x4005CA4")]
		[FieldOffset(Offset = "0x8")]
		private string m_Data;

		[Token(Token = "0x17000F94")]
		public override string Value
		{
			[Token(Token = "0x6007EE0")]
			[Address(RVA = "0x210002C", Offset = "0x210002C", VA = "0x210002C", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6007EE1")]
			[Address(RVA = "0x2100034", Offset = "0x2100034", VA = "0x2100034", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x6007EDB")]
		[Address(RVA = "0x20FFEB4", Offset = "0x20FFEB4", VA = "0x20FFEB4")]
		public JSONData(string aData)
		{
		}

		[Token(Token = "0x6007EDC")]
		[Address(RVA = "0x20FFED4", Offset = "0x20FFED4", VA = "0x20FFED4")]
		public JSONData(float aData)
		{
		}

		[Token(Token = "0x6007EDD")]
		[Address(RVA = "0x20FFF28", Offset = "0x20FFF28", VA = "0x20FFF28")]
		public JSONData(double aData)
		{
		}

		[Token(Token = "0x6007EDE")]
		[Address(RVA = "0x20FFF84", Offset = "0x20FFF84", VA = "0x20FFF84")]
		public JSONData(bool aData)
		{
		}

		[Token(Token = "0x6007EDF")]
		[Address(RVA = "0x20FFFD8", Offset = "0x20FFFD8", VA = "0x20FFFD8")]
		public JSONData(int aData)
		{
		}

		[Token(Token = "0x6007EE2")]
		[Address(RVA = "0x210003C", Offset = "0x210003C", VA = "0x210003C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6007EE3")]
		[Address(RVA = "0x210011C", Offset = "0x210011C", VA = "0x210011C", Slot = "17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}

		[Token(Token = "0x6007EE4")]
		[Address(RVA = "0x21001FC", Offset = "0x21001FC", VA = "0x21001FC", Slot = "30")]
		public override void Serialize(BinaryWriter aWriter)
		{
		}
	}
}
