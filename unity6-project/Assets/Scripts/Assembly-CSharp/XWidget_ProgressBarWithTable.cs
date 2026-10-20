using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D3F")]
public class XWidget_ProgressBarWithTable : MonoBehaviour
{
	[Token(Token = "0x4004413")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public UIProgressBar progressbar;

	[Token(Token = "0x4004414")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public UILabel label;

	[Token(Token = "0x4004415")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public UILabel labelExtra;

	[Token(Token = "0x4004416")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool percentageLabel;

	[Token(Token = "0x4004417")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float baseStep;

	[Token(Token = "0x4004418")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float limitDuration;

	[Token(Token = "0x4004419")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private Color? m_initColor;

	[Token(Token = "0x400441A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Action m_onDirectionComplete;

	[Token(Token = "0x400441B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private bool m_pause;

	[Token(Token = "0x400441C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Action action;

	[Token(Token = "0x400441D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private int m_curValue;

	[Token(Token = "0x400441E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int m_targetValue;

	[Token(Token = "0x400441F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private float m_curTotalPercent;

	[Token(Token = "0x4004420")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float m_targetTotalPercent;

	[Token(Token = "0x4004421")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private List<int> m_table;

	[Token(Token = "0x4004422")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float m_step;

	[Token(Token = "0x4004423")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private Func<int, string> m_extraCalc;

	[Token(Token = "0x4004424")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Action<int> m_onChangeFloor;

	[Token(Token = "0x4004425")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private Action m_playSound;

	[Token(Token = "0x4004426")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int m_lastDemod;

	[Token(Token = "0x4004427")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private float m_maxTotalPercent;

	[Token(Token = "0x4004428")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private bool bException;

	[Token(Token = "0x4004429")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
	public bool percentageRoundValue;

	[Token(Token = "0x400442A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private Func<int, bool> m_exception;

	[Token(Token = "0x400442B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Func<int, int> m_demodCalcOnException;

	[Token(Token = "0x400442C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private Func<int, int> m_numerCalcOnException;

	[Token(Token = "0x400442D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Func<int, string> m_extraCalcOnException;

	[Token(Token = "0x400442E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private Func<int, bool> m_labelException;

	[Token(Token = "0x400442F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Action<UILabel, int> m_labelSetter;

	[Token(Token = "0x4004430")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private Action<UIProgressBar, int> m_prbColorSetter;

	[Token(Token = "0x17000D24")]
	public bool HasOnComplete
	{
		[Token(Token = "0x6006158")]
		[Address(RVA = "0x131FD24", Offset = "0x131FD24", VA = "0x131FD24")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000D25")]
	public int CurValue
	{
		[Token(Token = "0x6006159")]
		[Address(RVA = "0x131FD34", Offset = "0x131FD34", VA = "0x131FD34")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000D26")]
	public int TargetValue
	{
		[Token(Token = "0x600615A")]
		[Address(RVA = "0x131FD3C", Offset = "0x131FD3C", VA = "0x131FD3C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6006157")]
	[Address(RVA = "0x131FD0C", Offset = "0x131FD0C", VA = "0x131FD0C")]
	public XWidget_ProgressBarWithTable()
	{
	}

	[Token(Token = "0x600615B")]
	[Address(RVA = "0x131FD44", Offset = "0x131FD44", VA = "0x131FD44")]
	public void Build(List<int> table, int initValue, int targetValue, Func<int, string> extraCalc, [Optional] Action<int> onChangeFloor, [Optional] Action playSound, bool percentage = false, bool roundValue = false)
	{
	}

	[Token(Token = "0x600615C")]
	[Address(RVA = "0x1320080", Offset = "0x1320080", VA = "0x1320080")]
	public void Build(List<int> table, int initValue, int targetValue, Action<int> onChangeFloor, Action playSound, Action onComplete)
	{
	}

	[Token(Token = "0x600615D")]
	[Address(RVA = "0x13200AC", Offset = "0x13200AC", VA = "0x13200AC")]
	public void BuildException(Func<int, bool> exception, Func<int, int> demodCalcOnException, Func<int, int> numerCalcOnException, Func<int, string> extraCalcOnException, Action onChangeFloor)
	{
	}

	[Token(Token = "0x600615E")]
	[Address(RVA = "0x13200C4", Offset = "0x13200C4", VA = "0x13200C4")]
	public void BuildLabelException(Func<int, bool> labelException, Action<UILabel, int> labelSetter, Action<UIProgressBar, int> prbColorSetter)
	{
	}

	[Token(Token = "0x600615F")]
	[Address(RVA = "0x131FD7C", Offset = "0x131FD7C", VA = "0x131FD7C")]
	public void Build(List<int> table, int initValue, int targetValue)
	{
	}

	[Token(Token = "0x6006160")]
	[Address(RVA = "0x1320690", Offset = "0x1320690", VA = "0x1320690")]
	public void SetCurValue(int val)
	{
	}

	[Token(Token = "0x6006161")]
	[Address(RVA = "0x13207E4", Offset = "0x13207E4", VA = "0x13207E4")]
	private int m_demodCalc(int val)
	{
		return default(int);
	}

	[Token(Token = "0x6006162")]
	[Address(RVA = "0x1320BB4", Offset = "0x1320BB4", VA = "0x1320BB4")]
	private int m_numerCalc(int val)
	{
		return default(int);
	}

	[Token(Token = "0x6006163")]
	[Address(RVA = "0x1320A6C", Offset = "0x1320A6C", VA = "0x1320A6C")]
	private float m_normalize(int val)
	{
		return default(float);
	}

	[Token(Token = "0x6006164")]
	[Address(RVA = "0x1320CB8", Offset = "0x1320CB8", VA = "0x1320CB8")]
	private int m_denormalize(float totalPercent)
	{
		return default(int);
	}

	[Token(Token = "0x6006165")]
	[Address(RVA = "0x1320EA8", Offset = "0x1320EA8", VA = "0x1320EA8")]
	public void Pause(bool pause)
	{
	}

	[Token(Token = "0x6006166")]
	[Address(RVA = "0x132064C", Offset = "0x132064C", VA = "0x132064C")]
	public void Show(bool bshow)
	{
	}

	[Token(Token = "0x6006167")]
	[Address(RVA = "0x1320EB0", Offset = "0x1320EB0", VA = "0x1320EB0")]
	private void CalcStep()
	{
	}

	[Token(Token = "0x6006168")]
	[Address(RVA = "0x1320EE4", Offset = "0x1320EE4", VA = "0x1320EE4")]
	public void SetTargetValue(int targetValue, Action onDirectionComplete)
	{
	}

	[Token(Token = "0x6006169")]
	[Address(RVA = "0x13208E8", Offset = "0x13208E8", VA = "0x13208E8")]
	private void SetTargetValue(int targetValue)
	{
	}

	[Token(Token = "0x600616A")]
	[Address(RVA = "0x1320EEC", Offset = "0x1320EEC", VA = "0x1320EEC")]
	public void SetAction([Optional] Action action)
	{
	}

	[Token(Token = "0x600616B")]
	[Address(RVA = "0x1320EF4", Offset = "0x1320EF4", VA = "0x1320EF4")]
	private void UpdateValue(float dt)
	{
	}

	[Token(Token = "0x600616C")]
	[Address(RVA = "0x1320F6C", Offset = "0x1320F6C", VA = "0x1320F6C")]
	private bool IsDemodChanged(int demod)
	{
		return default(bool);
	}

	[Token(Token = "0x600616D")]
	[Address(RVA = "0x1320F88", Offset = "0x1320F88", VA = "0x1320F88")]
	public float CalclProgressTime()
	{
		return default(float);
	}

	[Token(Token = "0x600616E")]
	[Address(RVA = "0x13200E0", Offset = "0x13200E0", VA = "0x13200E0")]
	private void CalcAndSet(float dt)
	{
	}

	[Token(Token = "0x600616F")]
	[Address(RVA = "0x1320FA4", Offset = "0x1320FA4", VA = "0x1320FA4")]
	public string GetLabelPercentageText(float value, bool percentage, int numer, int demod, bool bException, bool roundValue)
	{
		return null;
	}

	[Token(Token = "0x6006170")]
	[Address(RVA = "0x1320F54", Offset = "0x1320F54", VA = "0x1320F54")]
	public bool IsDirectFinished()
	{
		return default(bool);
	}

	[Token(Token = "0x6006171")]
	[Address(RVA = "0x1321250", Offset = "0x1321250", VA = "0x1321250")]
	public void SkipDirection()
	{
	}

	[Token(Token = "0x6006172")]
	[Address(RVA = "0x1321260", Offset = "0x1321260", VA = "0x1321260")]
	public string GetLevel()
	{
		return null;
	}

	[Token(Token = "0x6006173")]
	[Address(RVA = "0x1321328", Offset = "0x1321328", VA = "0x1321328")]
	private void Update()
	{
	}
}
