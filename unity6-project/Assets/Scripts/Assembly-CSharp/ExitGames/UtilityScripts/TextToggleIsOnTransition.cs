using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ExitGames.UtilityScripts
{
	[Token(Token = "0x2000326")]
	public class TextToggleIsOnTransition : MonoBehaviour, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler
	{
		[Token(Token = "0x400105C")]
		[FieldOffset(Offset = "0xC")]
		public Toggle toggle;

		[Token(Token = "0x400105D")]
		[FieldOffset(Offset = "0x10")]
		private Text _text;

		[Token(Token = "0x400105E")]
		[FieldOffset(Offset = "0x14")]
		public Color NormalOnColor;

		[Token(Token = "0x400105F")]
		[FieldOffset(Offset = "0x24")]
		public Color NormalOffColor;

		[Token(Token = "0x4001060")]
		[FieldOffset(Offset = "0x34")]
		public Color HoverOnColor;

		[Token(Token = "0x4001061")]
		[FieldOffset(Offset = "0x44")]
		public Color HoverOffColor;

		[Token(Token = "0x4001062")]
		[FieldOffset(Offset = "0x54")]
		private bool isHover;

		[Token(Token = "0x6001ADD")]
		[Address(RVA = "0x1E7F524", Offset = "0x1E7F524", VA = "0x1E7F524")]
		public TextToggleIsOnTransition()
		{
		}

		[Token(Token = "0x6001ADE")]
		[Address(RVA = "0x1E7F5CC", Offset = "0x1E7F5CC", VA = "0x1E7F5CC")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x6001ADF")]
		[Address(RVA = "0x1E7F6F4", Offset = "0x1E7F6F4", VA = "0x1E7F6F4")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6001AE0")]
		[Address(RVA = "0x1E7F7F4", Offset = "0x1E7F7F4", VA = "0x1E7F7F4")]
		public void OnValueChanged(bool isOn)
		{
		}

		[Token(Token = "0x6001AE1")]
		[Address(RVA = "0x1E7F91C", Offset = "0x1E7F91C", VA = "0x1E7F91C", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6001AE2")]
		[Address(RVA = "0x1E7F9D4", Offset = "0x1E7F9D4", VA = "0x1E7F9D4", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}
	}
}
