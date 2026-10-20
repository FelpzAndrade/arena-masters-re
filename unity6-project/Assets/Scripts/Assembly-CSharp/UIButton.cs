using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001BF")]
public class UIButton : UIButtonColor
{
	[Token(Token = "0x400067E")]
	[FieldOffset(Offset = "0x0")]
	public static UIButton current;

	[Token(Token = "0x400067F")]
	[FieldOffset(Offset = "0x70")]
	public bool dragHighlight;

	[Token(Token = "0x4000680")]
	[FieldOffset(Offset = "0x74")]
	public string hoverSprite;

	[Token(Token = "0x4000681")]
	[FieldOffset(Offset = "0x78")]
	public string pressedSprite;

	[Token(Token = "0x4000682")]
	[FieldOffset(Offset = "0x7C")]
	public string disabledSprite;

	[Token(Token = "0x4000683")]
	[FieldOffset(Offset = "0x80")]
	public Sprite hoverSprite2D;

	[Token(Token = "0x4000684")]
	[FieldOffset(Offset = "0x84")]
	public Sprite pressedSprite2D;

	[Token(Token = "0x4000685")]
	[FieldOffset(Offset = "0x88")]
	public Sprite disabledSprite2D;

	[Token(Token = "0x4000686")]
	[FieldOffset(Offset = "0x8C")]
	public bool pixelSnap;

	[Token(Token = "0x4000687")]
	[FieldOffset(Offset = "0x90")]
	public List<EventDelegate> onClick;

	[NonSerialized]
	[Token(Token = "0x4000688")]
	[FieldOffset(Offset = "0x94")]
	private UISprite mSprite;

	[NonSerialized]
	[Token(Token = "0x4000689")]
	[FieldOffset(Offset = "0x98")]
	private UI2DSprite mSprite2D;

	[NonSerialized]
	[Token(Token = "0x400068A")]
	[FieldOffset(Offset = "0x9C")]
	private string mNormalSprite;

	[NonSerialized]
	[Token(Token = "0x400068B")]
	[FieldOffset(Offset = "0xA0")]
	private Sprite mNormalSprite2D;

	[Token(Token = "0x1700024A")]
	public override bool isEnabled
	{
		[Token(Token = "0x6000EF5")]
		[Address(RVA = "0x16BDB88", Offset = "0x16BDB88", VA = "0x16BDB88", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000EF6")]
		[Address(RVA = "0x16BDD2C", Offset = "0x16BDD2C", VA = "0x16BDD2C", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x1700024B")]
	public string normalSprite
	{
		[Token(Token = "0x6000EF7")]
		[Address(RVA = "0x16BE058", Offset = "0x16BE058", VA = "0x16BE058")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000EF8")]
		[Address(RVA = "0x16BE0A4", Offset = "0x16BE0A4", VA = "0x16BE0A4")]
		set
		{
		}
	}

	[Token(Token = "0x1700024C")]
	public Sprite normalSprite2D
	{
		[Token(Token = "0x6000EF9")]
		[Address(RVA = "0x16BE4C0", Offset = "0x16BE4C0", VA = "0x16BE4C0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000EFA")]
		[Address(RVA = "0x16BE50C", Offset = "0x16BE50C", VA = "0x16BE50C")]
		set
		{
		}
	}

	[Token(Token = "0x6000EF4")]
	[Address(RVA = "0x16BDA08", Offset = "0x16BDA08", VA = "0x16BDA08")]
	public UIButton()
	{
	}

	[Token(Token = "0x6000EFB")]
	[Address(RVA = "0x16BE8D0", Offset = "0x16BE8D0", VA = "0x16BE8D0", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6000EFC")]
	[Address(RVA = "0x16BEEA8", Offset = "0x16BEEA8", VA = "0x16BEEA8", Slot = "7")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6000EFD")]
	[Address(RVA = "0x16BF344", Offset = "0x16BF344", VA = "0x16BF344", Slot = "11")]
	protected override void OnDragOver()
	{
	}

	[Token(Token = "0x6000EFE")]
	[Address(RVA = "0x16BF624", Offset = "0x16BF624", VA = "0x16BF624", Slot = "12")]
	protected override void OnDragOut()
	{
	}

	[Token(Token = "0x6000EFF")]
	[Address(RVA = "0x16BF904", Offset = "0x16BF904", VA = "0x16BF904", Slot = "14")]
	protected virtual void OnClick()
	{
	}

	[Token(Token = "0x6000F00")]
	[Address(RVA = "0x16BFB1C", Offset = "0x16BFB1C", VA = "0x16BFB1C", Slot = "13")]
	public override void SetState(State state, bool immediate)
	{
	}

	[Token(Token = "0x6000F01")]
	[Address(RVA = "0x16BE2DC", Offset = "0x16BE2DC", VA = "0x16BE2DC")]
	protected void SetSprite(string sp)
	{
	}

	[Token(Token = "0x6000F02")]
	[Address(RVA = "0x16BE6F0", Offset = "0x16BE6F0", VA = "0x16BE6F0")]
	protected void SetSprite(Sprite sp)
	{
	}
}
