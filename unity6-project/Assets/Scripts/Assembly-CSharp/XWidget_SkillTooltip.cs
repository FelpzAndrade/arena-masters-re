using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E73")]
public class XWidget_SkillTooltip : MonoBehaviour
{
	[Token(Token = "0x2000E74")]
	public class CharStatusConvertParam
	{
		[Token(Token = "0x4004BBD")]
		[FieldOffset(Offset = "0x8")]
		public string inputText;

		[Token(Token = "0x4004BBE")]
		[FieldOffset(Offset = "0xC")]
		public string prefix;

		[Token(Token = "0x4004BBF")]
		[FieldOffset(Offset = "0x10")]
		public CharStatus status;

		[Token(Token = "0x4004BC0")]
		[FieldOffset(Offset = "0x14")]
		public bool isRatio;

		[Token(Token = "0x4004BC1")]
		[FieldOffset(Offset = "0x15")]
		public bool isPercentageView;

		[Token(Token = "0x4004BC2")]
		[FieldOffset(Offset = "0x16")]
		public bool isAbs;

		[Token(Token = "0x4004BC3")]
		[FieldOffset(Offset = "0x18")]
		public string colorText;

		[Token(Token = "0x6006BE4")]
		[Address(RVA = "0x1B0A4F0", Offset = "0x1B0A4F0", VA = "0x1B0A4F0")]
		public CharStatusConvertParam()
		{
		}
	}

	[Token(Token = "0x2000E75")]
	private sealed class _003CHideAfterSec_003Ec__IteratorA9 : IDisposable
	{
		[Token(Token = "0x4004BC4")]
		[FieldOffset(Offset = "0x8")]
		internal float sec;

		[Token(Token = "0x4004BC5")]
		[FieldOffset(Offset = "0xC")]
		internal int _0024PC;

		[Token(Token = "0x4004BC6")]
		[FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x4004BC7")]
		[FieldOffset(Offset = "0x14")]
		internal float _003C_0024_003Esec;

		[Token(Token = "0x4004BC8")]
		[FieldOffset(Offset = "0x18")]
		internal XWidget_SkillTooltip _003C_003Ef__this;

		[Token(Token = "0x17000DDC")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6006BE6")]
			[Address(RVA = "0x1B0AF90", Offset = "0x1B0AF90", VA = "0x1B0AF90", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000DDD")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6006BE7")]
			[Address(RVA = "0x1B0AF98", Offset = "0x1B0AF98", VA = "0x1B0AF98", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6006BE5")]
		[Address(RVA = "0x1B093B0", Offset = "0x1B093B0", VA = "0x1B093B0")]
		public _003CHideAfterSec_003Ec__IteratorA9()
		{
		}

		[Token(Token = "0x6006BE6")]
		[Address(RVA = "0x1B0AF90", Offset = "0x1B0AF90", VA = "0x1B0AF90", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6006BE7")]
		[Address(RVA = "0x1B0AF98", Offset = "0x1B0AF98", VA = "0x1B0AF98", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6006BE8")]
		[Address(RVA = "0x1B0AFA0", Offset = "0x1B0AFA0", VA = "0x1B0AFA0", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6006BE9")]
		[Address(RVA = "0x1B0B08C", Offset = "0x1B0B08C", VA = "0x1B0B08C", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6006BEA")]
		[Address(RVA = "0x1B0B098", Offset = "0x1B0B098", VA = "0x1B0B098", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4004BB2")]
	[FieldOffset(Offset = "0xC")]
	public UI2DSprite sprSkillIcon;

	[Token(Token = "0x4004BB3")]
	[FieldOffset(Offset = "0x10")]
	public UILabel lblLockLv;

	[Token(Token = "0x4004BB4")]
	[FieldOffset(Offset = "0x14")]
	public UILabel lblName;

	[Token(Token = "0x4004BB5")]
	[FieldOffset(Offset = "0x18")]
	public UILabel lblLevel;

	[Token(Token = "0x4004BB6")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel lblType;

	[Token(Token = "0x4004BB7")]
	[FieldOffset(Offset = "0x20")]
	public UILabel lblMpRequire;

	[Token(Token = "0x4004BB8")]
	[FieldOffset(Offset = "0x24")]
	public UILabel lblCoolTime;

	[Token(Token = "0x4004BB9")]
	[FieldOffset(Offset = "0x28")]
	public UILabel lblDescription;

	[Token(Token = "0x4004BBA")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject goTypeUltimate;

	[Token(Token = "0x4004BBB")]
	[FieldOffset(Offset = "0x30")]
	public UI2DSprite sprTypeBg;

	[Token(Token = "0x4004BBC")]
	[FieldOffset(Offset = "0x34")]
	public float showDuration;

	[Token(Token = "0x6006BD8")]
	[Address(RVA = "0x1B089D8", Offset = "0x1B089D8", VA = "0x1B089D8")]
	public XWidget_SkillTooltip()
	{
	}

	[Token(Token = "0x6006BD9")]
	[Address(RVA = "0x1B089EC", Offset = "0x1B089EC", VA = "0x1B089EC")]
	public void Show(CSCharacterSkillInfo skillInfo, int skillLevel, Sprite sprIcon)
	{
	}

	[Token(Token = "0x6006BDA")]
	[Address(RVA = "0x1B0937C", Offset = "0x1B0937C", VA = "0x1B0937C")]
	public void Hide()
	{
	}

	[Token(Token = "0x6006BDB")]
	[Address(RVA = "0x1B092C8", Offset = "0x1B092C8", VA = "0x1B092C8")]
	[DebuggerHidden]
	private IEnumerator HideAfterSec(float sec)
	{
		return null;
	}

	[Token(Token = "0x6006BDC")]
	[Address(RVA = "0x1B08A5C", Offset = "0x1B08A5C", VA = "0x1B08A5C")]
	public void Build(CSCharacterSkillInfo characterSkillInfo, int skillLevel, Sprite sprIcon)
	{
	}

	[Token(Token = "0x6006BDD")]
	[Address(RVA = "0x1B09A54", Offset = "0x1B09A54", VA = "0x1B09A54")]
	private void BuildLock(XModuleActor character, CSCharacterSkillInfo skillInfo)
	{
	}

	[Token(Token = "0x6006BDE")]
	[Address(RVA = "0x1B093B8", Offset = "0x1B093B8", VA = "0x1B093B8")]
	private string MakeDescription(CSSkillInfo skillInfo, int lev)
	{
		return null;
	}

	[Token(Token = "0x6006BDF")]
	[Address(RVA = "0x1B09EA8", Offset = "0x1B09EA8", VA = "0x1B09EA8")]
	public int GetNextSkillID(string desc)
	{
		return default(int);
	}

	[Token(Token = "0x6006BE0")]
	[Address(RVA = "0x1B0A158", Offset = "0x1B0A158", VA = "0x1B0A158")]
	private string MakeDescriptionForBuffImpl(string text, int skillid, int buffid, int index, int lev)
	{
		return null;
	}

	[Token(Token = "0x6006BE1")]
	[Address(RVA = "0x1B09CDC", Offset = "0x1B09CDC", VA = "0x1B09CDC")]
	private string MakeDescriptionImpl(string text, string prefix, CharStatus status)
	{
		return null;
	}

	[Token(Token = "0x6006BE2")]
	[Address(RVA = "0x1B0AE08", Offset = "0x1B0AE08", VA = "0x1B0AE08")]
	public static string ReplaceAttrTextColor(CharStatusConvertParam arg)
	{
		return null;
	}

	[Token(Token = "0x6006BE3")]
	[Address(RVA = "0x1B0A4F8", Offset = "0x1B0A4F8", VA = "0x1B0A4F8")]
	public static string ReplaceAttrName(CharStatusConvertParam arg)
	{
		return null;
	}
}
