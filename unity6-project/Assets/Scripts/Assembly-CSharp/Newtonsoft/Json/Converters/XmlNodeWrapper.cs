using System.Collections.Generic;
using System.Xml;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x20000B7")]
	internal class XmlNodeWrapper : IXmlNode
	{
		protected XmlNodeWrapper()
		{
		}

		[Token(Token = "0x40002EE")]
		[FieldOffset(Offset = "0x8")]
		private readonly XmlNode _node;

		[Token(Token = "0x170000C0")]
		public object WrappedNode
		{
			[Token(Token = "0x60005B5")]
			[Address(RVA = "0x138E68C", Offset = "0x138E68C", VA = "0x138E68C", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C1")]
		public XmlNodeType NodeType
		{
			[Token(Token = "0x60005B6")]
			[Address(RVA = "0x1397A68", Offset = "0x1397A68", VA = "0x1397A68", Slot = "4")]
			get
			{
				return default(XmlNodeType);
			}
		}

		[Token(Token = "0x170000C2")]
		public string Name
		{
			[Token(Token = "0x60005B7")]
			[Address(RVA = "0x1397AC0", Offset = "0x1397AC0", VA = "0x1397AC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C3")]
		public string LocalName
		{
			[Token(Token = "0x60005B8")]
			[Address(RVA = "0x1397B18", Offset = "0x1397B18", VA = "0x1397B18", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C4")]
		public IList<IXmlNode> ChildNodes
		{
			[Token(Token = "0x60005B9")]
			[Address(RVA = "0x1397B70", Offset = "0x1397B70", VA = "0x1397B70", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C5")]
		public IList<IXmlNode> Attributes
		{
			[Token(Token = "0x60005BB")]
			[Address(RVA = "0x1397E30", Offset = "0x1397E30", VA = "0x1397E30", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C6")]
		public IXmlNode ParentNode
		{
			[Token(Token = "0x60005BC")]
			[Address(RVA = "0x1397FCC", Offset = "0x1397FCC", VA = "0x1397FCC", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C7")]
		public string Value
		{
			[Token(Token = "0x60005BD")]
			[Address(RVA = "0x1398110", Offset = "0x1398110", VA = "0x1398110", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005BE")]
			[Address(RVA = "0x138E36C", Offset = "0x138E36C", VA = "0x138E36C", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x170000C8")]
		public string Prefix
		{
			[Token(Token = "0x60005C0")]
			[Address(RVA = "0x1398244", Offset = "0x1398244", VA = "0x1398244")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C9")]
		public string NamespaceURI
		{
			[Token(Token = "0x60005C1")]
			[Address(RVA = "0x139829C", Offset = "0x139829C", VA = "0x139829C", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x138D964", Offset = "0x138D964", VA = "0x138D964")]
		public XmlNodeWrapper(XmlNode node)
		{
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x1397CC4", Offset = "0x1397CC4", VA = "0x1397CC4")]
		private IXmlNode WrapNode(XmlNode node)
		{
			return null;
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x1398168", Offset = "0x1398168", VA = "0x1398168", Slot = "11")]
		public IXmlNode AppendChild(IXmlNode newChild)
		{
			return null;
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x13982F4", Offset = "0x13982F4", VA = "0x13982F4")]
		private IXmlNode _003Cget_ChildNodes_003Em__2D(XmlNode n)
		{
			return null;
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x13982F8", Offset = "0x13982F8", VA = "0x13982F8")]
		private IXmlNode _003Cget_Attributes_003Em__2E(XmlAttribute a)
		{
			return null;
		}
	}
}
