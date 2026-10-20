using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D3E")]
public class XWidget_ProgressBar : MonoBehaviour
{
	[Token(Token = "0x40043FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public UIProgressBar progressbar;

	[Token(Token = "0x40043FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public UILabel label;

	[Token(Token = "0x40043FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public UILabel labelExtra;

	[Token(Token = "0x4004400")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool percentageLabel;

	[Token(Token = "0x4004401")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float baseStep;

	[Token(Token = "0x4004402")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Color m_initColor;

	[Token(Token = "0x4004403")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Action m_onDirectionComplete;

	[Token(Token = "0x4004404")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float m_curValueFloat;

	[Token(Token = "0x4004405")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int m_targetValue;

	[Token(Token = "0x4004406")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float m_step;

	[Token(Token = "0x4004407")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Func<int, int> m_demodCalc;

	[Token(Token = "0x4004408")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private Func<int, int> m_numerCalc;

	[Token(Token = "0x4004409")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Func<int, string> m_extraCalc;

	[Token(Token = "0x400440A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private Action<int> m_onChangeFloor;

	[Token(Token = "0x400440B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private int m_lastDemod;

	[Token(Token = "0x400440C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private Func<int, bool> m_exception;

	[Token(Token = "0x400440D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Func<int, int> m_demodCalcOnException;

	[Token(Token = "0x400440E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private Func<int, int> m_numerCalcOnException;

	[Token(Token = "0x400440F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Func<int, string> m_extraCalcOnException;

	[Token(Token = "0x4004410")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private Func<int, bool> m_labelException;

	[Token(Token = "0x4004411")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Action<UILabel, int> m_labelSetter;

	[Token(Token = "0x4004412")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private Action<UIProgressBar, int> m_prbColorSetter;

	[Token(Token = "0x17000D21")]
	public int CurValue
	{
		[Token(Token = "0x6006147")]
		[Address(RVA = "0x131F284", Offset = "0x131F284", VA = "0x131F284")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000D22")]
	public int TargetValue
	{
		[Token(Token = "0x6006148")]
		[Address(RVA = "0x131F33C", Offset = "0x131F33C", VA = "0x131F33C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000D23")]
	private int m_curValue
	{
		[Token(Token = "0x6006149")]
		[Address(RVA = "0x131F288", Offset = "0x131F288", VA = "0x131F288")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6006145")]
	[Address(RVA = "0x131F210", Offset = "0x131F210", VA = "0x131F210")]
	public XWidget_ProgressBar()
	{
	}

	[Token(Token = "0x6006146")]
	[Address(RVA = "0x131F220", Offset = "0x131F220", VA = "0x131F220")]
	private void Awake()
	{
	}

	[Token(Token = "0x600614A")]
	[Address(RVA = "0x131F344", Offset = "0x131F344", VA = "0x131F344")]
	public void Build(Func<int, int> demodCalc, Func<int, int> numerCalc, int initValue, int targetValue, Func<int, string> extraCalc, [Optional] Action<int> onChangeFloor)
	{
	}

	[Token(Token = "0x600614B")]
	[Address(RVA = "0x131F480", Offset = "0x131F480", VA = "0x131F480")]
	public void BuildException(Func<int, bool> exception, Func<int, int> demodCalcOnException, Func<int, int> numerCalcOnException, Func<int, string> extraCalcOnException, Action onChangeFloor)
	{
	}

	[Token(Token = "0x600614C")]
	[Address(RVA = "0x131F498", Offset = "0x131F498", VA = "0x131F498")]
	public void BuildLabelException(Func<int, bool> labelException, Action<UILabel, int> labelSetter, Action<UIProgressBar, int> prbColorSetter)
	{
	}

	[Token(Token = "0x600614D")]
	[Address(RVA = "0x131F374", Offset = "0x131F374", VA = "0x131F374")]
	public void Build(Func<int, int> demodCalc, Func<int, int> numerCalc, int initValue, int targetValue)
	{
	}

	[Token(Token = "0x600614E")]
	[Address(RVA = "0x131FBBC", Offset = "0x131FBBC", VA = "0x131FBBC")]
	public void Show(bool bshow)
	{
	}

	[Token(Token = "0x600614F")]
	[Address(RVA = "0x131FC10", Offset = "0x131FC10", VA = "0x131FC10")]
	private void CalcStep()
	{
	}

	[Token(Token = "0x6006150")]
	[Address(RVA = "0x131FC04", Offset = "0x131FC04", VA = "0x131FC04")]
	public void Set(int targetValue, [Optional] Action onDirectionComplete)
	{
	}

	[Token(Token = "0x6006151")]
	[Address(RVA = "0x131FC34", Offset = "0x131FC34", VA = "0x131FC34")]
	private void UpdateValue()
	{
	}

	[Token(Token = "0x6006152")]
	[Address(RVA = "0x131FCB8", Offset = "0x131FCB8", VA = "0x131FCB8")]
	private bool IsDemodChanged(int demod)
	{
		return default(bool);
	}

	[Token(Token = "0x6006153")]
	[Address(RVA = "0x131F4A4", Offset = "0x131F4A4", VA = "0x131F4A4")]
	private void CalcAndSet()
	{
	}

	[Token(Token = "0x6006154")]
	[Address(RVA = "0x131FC94", Offset = "0x131FC94", VA = "0x131FC94")]
	public bool IsDirectFinished()
	{
		return default(bool);
	}

	[Token(Token = "0x6006155")]
	[Address(RVA = "0x131FCF8", Offset = "0x131FCF8", VA = "0x131FCF8")]
	public void SkipDirection()
	{
	}

	[Token(Token = "0x6006156")]
	[Address(RVA = "0x131FD08", Offset = "0x131FD08", VA = "0x131FD08")]
	private void FixedUpdate()
	{
	}
}
