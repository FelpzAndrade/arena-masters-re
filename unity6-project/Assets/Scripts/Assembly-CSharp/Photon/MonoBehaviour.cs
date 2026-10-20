using Il2CppDummyDll;
using UnityEngine;

namespace Photon
{
	[Token(Token = "0x20002C5")]
	public class MonoBehaviour : UnityEngine.MonoBehaviour
	{
		[Token(Token = "0x4000E98")]
		[FieldOffset(Offset = "0xC")]
		private PhotonView pvCache;

		[Token(Token = "0x170003FF")]
		public PhotonView photonView
		{
			[Token(Token = "0x60017EA")]
			[Address(RVA = "0x1B802D4", Offset = "0x1B802D4", VA = "0x1B802D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60017E9")]
		[Address(RVA = "0x1B802CC", Offset = "0x1B802CC", VA = "0x1B802CC")]
		public MonoBehaviour()
		{
		}
	}
}
