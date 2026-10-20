using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Facebook.Unity.Example
{
	[Token(Token = "0x2000017")]
	internal class ConsoleBase : MonoBehaviour
	{
		[Token(Token = "0x400007B")]
		protected const int ButtonHeight = 60;

		[Token(Token = "0x400007C")]
		private const int DpiScalingFactor = 160;

		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x0")]
		protected static int MainWindowWidth;

		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x4")]
		protected static int MainWindowFullWidth;

		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x8")]
		private static Stack<string> menuStack;

		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0xC")]
		private string status;

		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0x10")]
		private string lastResponse;

		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x14")]
		private Vector2 scrollPosition;

		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0x1C")]
		private float? scaleFactor;

		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0x24")]
		private GUIStyle textStyle;

		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0x28")]
		private GUIStyle buttonStyle;

		[Token(Token = "0x4000086")]
		[FieldOffset(Offset = "0x2C")]
		private GUIStyle textInputStyle;

		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0x30")]
		private GUIStyle labelStyle;

		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0x34")]
		private Texture2D LastResponseTexture__BackingField;

		[Token(Token = "0x1700001B")]
		protected static Stack<string> MenuStack
		{
			[Token(Token = "0x600007A")]
			[Address(RVA = "0x1E850D0", Offset = "0x1E850D0", VA = "0x1E850D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600007B")]
			[Address(RVA = "0x1E85180", Offset = "0x1E85180", VA = "0x1E85180")]
			set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		protected string Status
		{
			[Token(Token = "0x600007C")]
			[Address(RVA = "0x1E85234", Offset = "0x1E85234", VA = "0x1E85234")]
			get
			{
				return null;
			}
			[Token(Token = "0x600007D")]
			[Address(RVA = "0x1E82AE8", Offset = "0x1E82AE8", VA = "0x1E82AE8")]
			set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		protected Texture2D LastResponseTexture
		{
			[Token(Token = "0x600007E")]
			[Address(RVA = "0x1E8523C", Offset = "0x1E8523C", VA = "0x1E8523C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600007F")]
			[Address(RVA = "0x1E85244", Offset = "0x1E85244", VA = "0x1E85244")]
			set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		protected string LastResponse
		{
			[Token(Token = "0x6000080")]
			[Address(RVA = "0x1E8524C", Offset = "0x1E8524C", VA = "0x1E8524C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000081")]
			[Address(RVA = "0x1E85254", Offset = "0x1E85254", VA = "0x1E85254")]
			set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		protected Vector2 ScrollPosition
		{
			[Token(Token = "0x6000082")]
			[Address(RVA = "0x1E8525C", Offset = "0x1E8525C", VA = "0x1E8525C")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000083")]
			[Address(RVA = "0x1E85270", Offset = "0x1E85270", VA = "0x1E85270")]
			set
			{
			}
		}

		[Token(Token = "0x17000020")]
		protected float ScaleFactor
		{
			[Token(Token = "0x6000084")]
			[Address(RVA = "0x1E848FC", Offset = "0x1E848FC", VA = "0x1E848FC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000021")]
		protected int FontSize
		{
			[Token(Token = "0x6000085")]
			[Address(RVA = "0x1E8527C", Offset = "0x1E8527C", VA = "0x1E8527C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000022")]
		protected GUIStyle TextStyle
		{
			[Token(Token = "0x6000086")]
			[Address(RVA = "0x1E85350", Offset = "0x1E85350", VA = "0x1E85350")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000023")]
		protected GUIStyle ButtonStyle
		{
			[Token(Token = "0x6000087")]
			[Address(RVA = "0x1E84A14", Offset = "0x1E84A14", VA = "0x1E84A14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000024")]
		protected GUIStyle TextInputStyle
		{
			[Token(Token = "0x6000088")]
			[Address(RVA = "0x1E85544", Offset = "0x1E85544", VA = "0x1E85544")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000025")]
		protected GUIStyle LabelStyle
		{
			[Token(Token = "0x6000089")]
			[Address(RVA = "0x1E847D4", Offset = "0x1E847D4", VA = "0x1E847D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x1E84EF4", Offset = "0x1E84EF4", VA = "0x1E84EF4")]
		public ConsoleBase()
		{
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x1E8566C", Offset = "0x1E8566C", VA = "0x1E8566C", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x1E828F4", Offset = "0x1E828F4", VA = "0x1E828F4")]
		protected bool Button(string label)
		{
			return default(bool);
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x1E8454C", Offset = "0x1E8454C", VA = "0x1E8454C")]
		protected void LabelAndTextField(string label, ref string text)
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x1E8567C", Offset = "0x1E8567C", VA = "0x1E8567C")]
		protected bool IsHorizontalLayout()
		{
			return default(bool);
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x1E856A4", Offset = "0x1E856A4", VA = "0x1E856A4")]
		protected void SwitchMenu(Type menuClass)
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x1E85820", Offset = "0x1E85820", VA = "0x1E85820")]
		protected void GoBack()
		{
		}
	}
}
