using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x200098E")]
	public class Netdata_Char : Netdata_Actor
	{
		[Token(Token = "0x4002F29")]
		[FieldOffset(Offset = "0x24")]
		public SkillSpecialized specialized_skill_list;

		[Token(Token = "0x4002F2A")]
		[FieldOffset(Offset = "0x28")]
		public int skin_id;

		[Token(Token = "0x4002F2B")]
		[FieldOffset(Offset = "0x2C")]
		private List<int> skins__BackingField;

		[Token(Token = "0x17000AF2")]
		public List<int> skins
		{
			[Token(Token = "0x6004CCB")]
			[Address(RVA = "0x233E7F4", Offset = "0x233E7F4", VA = "0x233E7F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004CCC")]
			[Address(RVA = "0x233E7FC", Offset = "0x233E7FC", VA = "0x233E7FC")]
			set
			{
			}
		}

		[Token(Token = "0x6004CCA")]
		[Address(RVA = "0x233E7E4", Offset = "0x233E7E4", VA = "0x233E7E4")]
		public Netdata_Char()
		{
		}
	}
}
