using System.Collections.Generic;
using System.Collections.Specialized;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x20008C2")]
	public abstract class CSNetHelper
	{
		[Token(Token = "0x4002AC1")]
		[FieldOffset(Offset = "0x0")]
		private static CSNetHelper _instance;

		[Token(Token = "0x1700098B")]
		public static CSNetHelper Instance
		{
			[Token(Token = "0x60046B5")]
			[Address(RVA = "0x1FBD270", Offset = "0x1FBD270", VA = "0x1FBD270")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60046B3")]
		[Address(RVA = "0x1FBD264", Offset = "0x1FBD264", VA = "0x1FBD264")]
		protected CSNetHelper()
		{
		}

		[Token(Token = "0x60046B6")]
		[Address(RVA = "0x1FBD320", Offset = "0x1FBD320", VA = "0x1FBD320")]
		public static void SetInstance(CSNetHelper inst)
		{
		}

		[Token(Token = "0x60046B7")]
		public abstract string GetSessionId();

		[Token(Token = "0x60046B8")]
		public abstract NameValueCollection ParserUrlParams(string rawURL);

		[Token(Token = "0x60046B9")]
		[Address(RVA = "0x1FBD3D4", Offset = "0x1FBD3D4", VA = "0x1FBD3D4")]
		public string GetParamText(CSNetCommand cmd)
		{
			return null;
		}

		[Token(Token = "0x60046BA")]
		public string ParseParamText<T>(Dictionary<T, object> dicObject)
		{
			return null;
		}

		[Token(Token = "0x60046BB")]
		public abstract string EncodeString(string s);

		[Token(Token = "0x60046BC")]
		public abstract string DecodeString(string s);

		[Token(Token = "0x60046BD")]
		public string GetUrl<T>()
		{
			return null;
		}
	}
}
