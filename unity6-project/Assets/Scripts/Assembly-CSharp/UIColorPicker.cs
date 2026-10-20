using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000273")]
public class UIColorPicker : MonoBehaviour
{
	[Token(Token = "0x4000B25")]
	[FieldOffset(Offset = "0x0")]
	public static UIColorPicker current;

	[Token(Token = "0x4000B26")]
	[FieldOffset(Offset = "0xC")]
	public Color value;

	[Token(Token = "0x4000B27")]
	[FieldOffset(Offset = "0x1C")]
	public UIWidget selectionWidget;

	[Token(Token = "0x4000B28")]
	[FieldOffset(Offset = "0x20")]
	public List<EventDelegate> onChange;

	[NonSerialized]
	[Token(Token = "0x4000B29")]
	[FieldOffset(Offset = "0x24")]
	private Transform mTrans;

	[NonSerialized]
	[Token(Token = "0x4000B2A")]
	[FieldOffset(Offset = "0x28")]
	private UITexture mUITex;

	[NonSerialized]
	[Token(Token = "0x4000B2B")]
	[FieldOffset(Offset = "0x2C")]
	private Texture2D mTex;

	[NonSerialized]
	[Token(Token = "0x4000B2C")]
	[FieldOffset(Offset = "0x30")]
	private UICamera mCam;

	[NonSerialized]
	[Token(Token = "0x4000B2D")]
	[FieldOffset(Offset = "0x34")]
	private Vector2 mPos;

	[NonSerialized]
	[Token(Token = "0x4000B2E")]
	[FieldOffset(Offset = "0x3C")]
	private int mWidth;

	[NonSerialized]
	[Token(Token = "0x4000B2F")]
	[FieldOffset(Offset = "0x40")]
	private int mHeight;

	[Token(Token = "0x4000B30")]
	[FieldOffset(Offset = "0x4")]
	private static AnimationCurve mRed;

	[Token(Token = "0x4000B31")]
	[FieldOffset(Offset = "0x8")]
	private static AnimationCurve mGreen;

	[Token(Token = "0x4000B32")]
	[FieldOffset(Offset = "0xC")]
	private static AnimationCurve mBlue;

	[Token(Token = "0x60014F5")]
	[Address(RVA = "0x16DA72C", Offset = "0x16DA72C", VA = "0x16DA72C")]
	public UIColorPicker()
	{
	}

	[Token(Token = "0x60014F6")]
	[Address(RVA = "0x16DA804", Offset = "0x16DA804", VA = "0x16DA804")]
	private void Start()
	{
	}

	[Token(Token = "0x60014F7")]
	[Address(RVA = "0x16DB96C", Offset = "0x16DB96C", VA = "0x16DB96C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60014F8")]
	[Address(RVA = "0x16DBA20", Offset = "0x16DBA20", VA = "0x16DBA20")]
	private void OnPress(bool pressed)
	{
	}

	[Token(Token = "0x60014F9")]
	[Address(RVA = "0x16DBFEC", Offset = "0x16DBFEC", VA = "0x16DBFEC")]
	private void OnDrag(Vector2 delta)
	{
	}

	[Token(Token = "0x60014FA")]
	[Address(RVA = "0x16DC014", Offset = "0x16DC014", VA = "0x16DC014")]
	private void OnPan(Vector2 delta)
	{
	}

	[Token(Token = "0x60014FB")]
	[Address(RVA = "0x16DBAEC", Offset = "0x16DBAEC", VA = "0x16DBAEC")]
	private void Sample()
	{
	}

	[Token(Token = "0x60014FC")]
	[Address(RVA = "0x16DC128", Offset = "0x16DC128", VA = "0x16DC128")]
	public void Select(Vector2 v)
	{
	}

	[Token(Token = "0x60014FD")]
	[Address(RVA = "0x16DB4D8", Offset = "0x16DB4D8", VA = "0x16DB4D8")]
	public Vector2 Select(Color c)
	{
		return default(Vector2);
	}

	[Token(Token = "0x60014FE")]
	[Address(RVA = "0x16DAB54", Offset = "0x16DAB54", VA = "0x16DAB54")]
	public static Color Sample(float x, float y)
	{
		return default(Color);
	}
}
