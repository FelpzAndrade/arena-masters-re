using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ExitGames.UtilityScripts
{
	[Token(Token = "0x2000324")]
	public class ButtonInsideScrollList : MonoBehaviour, IEventSystemHandler
	{
		[Token(Token = "0x4001058")]
		[FieldOffset(Offset = "0xC")]
		private ScrollRect scrollRect;

		[Token(Token = "0x6001AD5")]
		[Address(RVA = "0x1E7D6B4", Offset = "0x1E7D6B4", VA = "0x1E7D6B4")]
		public ButtonInsideScrollList()
		{
		}

		[Token(Token = "0x6001AD6")]
		[Address(RVA = "0x1E7D6BC", Offset = "0x1E7D6BC", VA = "0x1E7D6BC", Slot = "4")]
		private void UnityEngine_002EEventSystems_002EIPointerDownHandler_002EOnPointerDown(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6001AD7")]
		[Address(RVA = "0x1E7D7D0", Offset = "0x1E7D7D0", VA = "0x1E7D7D0", Slot = "5")]
		private void UnityEngine_002EEventSystems_002EIPointerUpHandler_002EOnPointerUp(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6001AD8")]
		[Address(RVA = "0x1E7D8CC", Offset = "0x1E7D8CC", VA = "0x1E7D8CC")]
		private void Start()
		{
		}
	}
}
