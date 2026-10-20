using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x200098C")]
	public class NetData_Pet_List
	{
		[Token(Token = "0x4002F21")]
		[FieldOffset(Offset = "0x8")]
		public List<Netdata_Pet> liNetPet;

		[Token(Token = "0x6004CC7")]
		[Address(RVA = "0x23401F0", Offset = "0x23401F0", VA = "0x23401F0")]
		public NetData_Pet_List()
		{
		}

		[Token(Token = "0x6004CC8")]
		[Address(RVA = "0x234029C", Offset = "0x234029C", VA = "0x234029C")]
		public NetData_Pet_List(List<Netdata_Pet> liNetDataPet)
		{
		}
	}
}
