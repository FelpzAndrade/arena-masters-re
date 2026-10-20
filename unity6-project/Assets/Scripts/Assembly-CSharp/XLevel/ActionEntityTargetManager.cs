using System.Collections.Generic;
using Il2CppDummyDll;

namespace XLevel
{
	[Token(Token = "0x2000749")]
	public class ActionEntityTargetManager
	{
		[Token(Token = "0x4002291")]
		[FieldOffset(Offset = "0x8")]
		private Dictionary<string, XModuleLevelObject> m_actionEntityTargets;

		[Token(Token = "0x6003BA7")]
		[Address(RVA = "0x1D3F734", Offset = "0x1D3F734", VA = "0x1D3F734")]
		public ActionEntityTargetManager()
		{
		}

		[Token(Token = "0x6003BA8")]
		[Address(RVA = "0x1D3F7E0", Offset = "0x1D3F7E0", VA = "0x1D3F7E0")]
		public void RegisterLevelObject(string tag, XModuleLevelObject lvo)
		{
		}

		[Token(Token = "0x6003BA9")]
		[Address(RVA = "0x1D3F9A4", Offset = "0x1D3F9A4", VA = "0x1D3F9A4")]
		public XModuleLevelObject GetLevelObject(string tag)
		{
			return null;
		}
	}
}
