using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ExitGames.UtilityScripts
{
	[Token(Token = "0x2000325")]
	public class TextButtonTransition : MonoBehaviour, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler
	{
		[Token(Token = "0x4001059")]
		[FieldOffset(Offset = "0xC")]
		private Text _text;

		[Token(Token = "0x400105A")]
		[FieldOffset(Offset = "0x10")]
		public Color NormalColor;

		[Token(Token = "0x400105B")]
		[FieldOffset(Offset = "0x20")]
		public Color HoverColor;

		[Token(Token = "0x6001AD9")]
		[Address(RVA = "0x1E7F34C", Offset = "0x1E7F34C", VA = "0x1E7F34C")]
		public TextButtonTransition()
		{
		}

		[Token(Token = "0x6001ADA")]
		[Address(RVA = "0x1E7F3B4", Offset = "0x1E7F3B4", VA = "0x1E7F3B4")]
		public void Awake()
		{
		}

		[Token(Token = "0x6001ADB")]
		[Address(RVA = "0x1E7F43C", Offset = "0x1E7F43C", VA = "0x1E7F43C", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6001ADC")]
		[Address(RVA = "0x1E7F4B0", Offset = "0x1E7F4B0", VA = "0x1E7F4B0", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}
	}
}
