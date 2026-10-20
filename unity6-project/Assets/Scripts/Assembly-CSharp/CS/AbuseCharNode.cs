using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x20008EF")]
	public class AbuseCharNode : Dictionary<string, AbuseCharNode>
	{
		[Token(Token = "0x4002B46")]
		[FieldOffset(Offset = "0x34")]
		private bool m_is_leaf_node;

		[Token(Token = "0x17000997")]
		public bool leaf_node
		{
			[Token(Token = "0x600479A")]
			[Address(RVA = "0x23E4264", Offset = "0x23E4264", VA = "0x23E4264")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600479B")]
			[Address(RVA = "0x23E426C", Offset = "0x23E426C", VA = "0x23E426C")]
			set
			{
			}
		}

		[Token(Token = "0x6004799")]
		[Address(RVA = "0x23E41E0", Offset = "0x23E41E0", VA = "0x23E41E0")]
		public AbuseCharNode()
		{
		}

		[Token(Token = "0x600479C")]
		[Address(RVA = "0x23E4274", Offset = "0x23E4274", VA = "0x23E4274")]
		public AbuseCharNode find_child(string val)
		{
			return null;
		}

		[Token(Token = "0x600479D")]
		[Address(RVA = "0x23E435C", Offset = "0x23E435C", VA = "0x23E435C")]
		public AbuseCharNode add_child(string val)
		{
			return null;
		}
	}
}
