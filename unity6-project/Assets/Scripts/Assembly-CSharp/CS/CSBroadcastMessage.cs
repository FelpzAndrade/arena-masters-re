using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x200086D")]
	public class CSBroadcastMessage
	{
		[Token(Token = "0x40026AF")]
		[FieldOffset(Offset = "0x8")]
		private string Message__BackingField;

		[Token(Token = "0x40026B0")]
		[FieldOffset(Offset = "0xC")]
		private BCMessageType Type__BackingField;

		[Token(Token = "0x40026B1")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<int, object> Param__BackingField;

		[Token(Token = "0x17000970")]
		public string Message
		{
			[Token(Token = "0x600458B")]
			[Address(RVA = "0x2224CC4", Offset = "0x2224CC4", VA = "0x2224CC4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600458C")]
			[Address(RVA = "0x2224C84", Offset = "0x2224C84", VA = "0x2224C84")]
			set
			{
			}
		}

		[Token(Token = "0x17000971")]
		public BCMessageType Type
		{
			[Token(Token = "0x600458D")]
			[Address(RVA = "0x2224CCC", Offset = "0x2224CCC", VA = "0x2224CCC")]
			get
			{
				return default(BCMessageType);
			}
			[Token(Token = "0x600458E")]
			[Address(RVA = "0x2224C8C", Offset = "0x2224C8C", VA = "0x2224C8C")]
			set
			{
			}
		}

		[Token(Token = "0x17000972")]
		public Dictionary<int, object> Param
		{
			[Token(Token = "0x600458F")]
			[Address(RVA = "0x2224CD4", Offset = "0x2224CD4", VA = "0x2224CD4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004590")]
			[Address(RVA = "0x2224C58", Offset = "0x2224C58", VA = "0x2224C58")]
			set
			{
			}
		}

		[Token(Token = "0x6004588")]
		[Address(RVA = "0x2224BB4", Offset = "0x2224BB4", VA = "0x2224BB4")]
		public CSBroadcastMessage()
		{
		}

		[Token(Token = "0x6004589")]
		[Address(RVA = "0x2224C60", Offset = "0x2224C60", VA = "0x2224C60")]
		public CSBroadcastMessage(string _msg, BCMessageType _type)
		{
		}

		[Token(Token = "0x600458A")]
		[Address(RVA = "0x2224C94", Offset = "0x2224C94", VA = "0x2224C94")]
		public CSBroadcastMessage(string _msg, BCMessageType _type, Dictionary<int, object> dataParam)
		{
		}

		[Token(Token = "0x6004591")]
		[Address(RVA = "0x2224CDC", Offset = "0x2224CDC", VA = "0x2224CDC")]
		public void SetDataParam(Dictionary<int, object> dataParam)
		{
		}
	}
}
