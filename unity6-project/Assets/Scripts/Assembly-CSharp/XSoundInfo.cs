using System;
using System.Xml.Serialization;
using CS;
using Il2CppDummyDll;

// Reconstruido a partir do pseudo-C (Ghidra) de libil2cpp.so.
// Nomes dos atributos XML inferidos de Resources/xml/sound_xml (IL2CPP nao preserva os argumentos dos atributos).
[Serializable]
[Token(Token = "0x2000BB1")]
public sealed class XSoundInfo
{
	[Token(Token = "0x4003B80")]
	[FieldOffset(Offset = "0x8")]
	[XmlAttribute("name")]
	public string strName;

	[Token(Token = "0x4003B81")]
	[FieldOffset(Offset = "0xC")]
	[XmlAttribute("filename")]
	public string strFileName;

	[Token(Token = "0x4003B82")]
	[FieldOffset(Offset = "0x10")]
	[XmlAttribute("loop")]
	public string strLoop;

	[Token(Token = "0x4003B83")]
	[FieldOffset(Offset = "0x14")]
	private bool m_LoopFlag;

	[Token(Token = "0x4003B84")]
	[FieldOffset(Offset = "0x18")]
	[XmlAttribute("volume")]
	public float fVolume;

	[Token(Token = "0x4003B85")]
	[FieldOffset(Offset = "0x1C")]
	[XmlAttribute("distance")]
	public float distance;

	[Token(Token = "0x4003B86")]
	[FieldOffset(Offset = "0x20")]
	[XmlAttribute("ratio")]
	public float ratio;

	[Token(Token = "0x4003B87")]
	[FieldOffset(Offset = "0x24")]
	[XmlIgnore]
	public float ratioSum;

	[Token(Token = "0x4003B88")]
	[FieldOffset(Offset = "0x28")]
	[XmlAttribute("track")]
	public MixerTrack trackType;

	[Token(Token = "0x4003B89")]
	[FieldOffset(Offset = "0x2C")]
	[XmlAttribute("lang_code_filter")]
	public string language;

	[Token(Token = "0x4003B8A")]
	[FieldOffset(Offset = "0x30")]
	[XmlAttribute("sound_source_id")]
	public int soundSourceId;

	[Token(Token = "0x17000C80")]
	public bool LoopFlag
	{
		[Token(Token = "0x60054A3")]
		[Address(RVA = "0x1825844", Offset = "0x1825844", VA = "0x1825844")]
		get
		{
			return m_LoopFlag;
		}
	}

	[Token(Token = "0x60054A2")]
	[Address(RVA = "0x1825718", Offset = "0x1825718", VA = "0x1825718")]
	public XSoundInfo()
	{
		strName = string.Empty;
		strFileName = string.Empty;
		// literal nao resolvido no pseudo-C; "False" e o valor dominante na tabela
		strLoop = "False";
		trackType = MixerTrack.Master;
		fVolume = 1f;
		distance = 20f;
		ratio = 1f;
		language = string.Empty;
		soundSourceId = 1;
	}

	[Token(Token = "0x60054A4")]
	[Address(RVA = "0x182584C", Offset = "0x182584C", VA = "0x182584C")]
	public bool Cooking()
	{
		m_LoopFlag = strLoop.ToUpper() != "FALSE";
		if (trackType == MixerTrack.NONE)
		{
			CSLog.Error(string.Format("XSoundInfo track is NONE : " + strName));
			return false;
		}
		return true;
	}
}
