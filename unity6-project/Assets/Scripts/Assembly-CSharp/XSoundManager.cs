using CS;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Audio;
using XAssetBundle;

[Token(Token = "0x2000BB8")]
public class XSoundManager : MonoBehaviour
{
	[Token(Token = "0x2000BB9")]
	public enum BGM_TYPE
	{
		[Token(Token = "0x4003BB7")]
		Normal = 0,
		[Token(Token = "0x4003BB8")]
		Effect = 1
	}

	[Token(Token = "0x2000BBA")]
	private struct XRequestSoundInfo
	{
		[Token(Token = "0x4003BB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string dataPath;

		[Token(Token = "0x4003BBA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public XAssetBundleLoadAssetOperation req;

		[Token(Token = "0x60054ED")]
		[Address(RVA = "0x182A9E4", Offset = "0x182A9E4", VA = "0x182A9E4")]
		public bool IsValid()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4003B9E")]
	private const float DUPLICATED_SOUND_IGNORE_TIME = 0.1f;

	[Token(Token = "0x4003B9F")]
	private const string rootSoundPath = "Sound/";

	[Token(Token = "0x4003BA0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private GameObject m_objSound;

	[Token(Token = "0x4003BA1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private GameObject m_objSystemSound;

	[Token(Token = "0x4003BA2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private AudioSource m_bgmSource;

	[Token(Token = "0x4003BA3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private string m_bgmClipPath;

	[Token(Token = "0x4003BA4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private AudioSource m_bgmEffectSource;

	[Token(Token = "0x4003BA5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private string m_bgmEffectClipPath;

	[Token(Token = "0x4003BA6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private AudioSources m_sources;

	[Token(Token = "0x4003BA7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private AudioMixer m_AudioMixer;

	[Token(Token = "0x4003BA8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private Dictionary<string, AudioClip> m_clips;

	[Token(Token = "0x4003BA9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private XSoundCullingChecker m_CullingChecker;

	[Token(Token = "0x4003BAA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private SystemSoundManager systemSoundManager;

	[Token(Token = "0x4003BAB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool isFadeBGMVolume;

	[Token(Token = "0x4003BAC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float initFadeBGMTime;

	[Token(Token = "0x4003BAD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float fadeBGMTime;

	[Token(Token = "0x4003BAE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private float fadeBGMVolume;

	[Token(Token = "0x4003BAF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private List<AudioClip> unloadList;

	[Token(Token = "0x4003BB0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private List<XRequestSoundInfo> requestList;

	[Token(Token = "0x4003BB1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private HashSet<string> preloadSoundKey;

	[Token(Token = "0x4003BB2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private HashSet<XRequestSoundInfo> removeRequestList;

	[Token(Token = "0x4003BB3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Stack<XAudioSourceFromPool> audioSourcePool;

	[Token(Token = "0x4003BB4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public Transform poolRoot;

	[Token(Token = "0x4003BB5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Transform m_transform;

	[Token(Token = "0x17000C81")]
	public AudioSource BGMSource
	{
		[Token(Token = "0x60054BA")]
		[Address(RVA = "0x1825DC8", Offset = "0x1825DC8", VA = "0x1825DC8")]
		get
		{
			return m_bgmSource;
		}
	}

	[Token(Token = "0x17000C82")]
	public AudioSource BGMEffectSource
	{
		[Token(Token = "0x60054BB")]
		[Address(RVA = "0x1825DD0", Offset = "0x1825DD0", VA = "0x1825DD0")]
		get
		{
			return m_bgmEffectSource;
		}
	}

	[Token(Token = "0x60054B9")]
	[Address(RVA = "0x1825BA8", Offset = "0x1825BA8", VA = "0x1825BA8")]
	public XSoundManager()
	{
		m_sources = new AudioSources();
		m_clips = new Dictionary<string, AudioClip>();
		m_CullingChecker = new XSoundCullingChecker();
		systemSoundManager = new SystemSoundManager();
		initFadeBGMTime = 0.5f;
		unloadList = new List<AudioClip>();
		requestList = new List<XRequestSoundInfo>();
		preloadSoundKey = new HashSet<string>();
		removeRequestList = new HashSet<XRequestSoundInfo>();
		audioSourcePool = new Stack<XAudioSourceFromPool>();
	}

	[Token(Token = "0x60054BC")]
	[Address(RVA = "0x1825DD8", Offset = "0x1825DD8", VA = "0x1825DD8")]
	public GameObject GetSystemSoundObject()
	{
		return m_objSystemSound;
	}

	[Token(Token = "0x60054BD")]
	[Address(RVA = "0x1825DE0", Offset = "0x1825DE0", VA = "0x1825DE0")]
	public void Init()
	{
		if (m_objSound == null)
		{
			m_objSound = new GameObject("AudioSource");
			m_objSound.AddComponent<AudioListener>();
			GameObject bgm = new GameObject();
			bgm.name = "BGM";
			bgm.transform.parent = m_objSound.transform;
			m_bgmSource = bgm.AddComponent<AudioSource>();
			GameObject bgmEffect = new GameObject();
			bgmEffect.name = "BGM_Effect";
			bgmEffect.transform.parent = m_objSound.transform;
			m_bgmEffectSource = bgmEffect.AddComponent<AudioSource>();
			if (m_objSystemSound == null)
			{
				m_objSystemSound = new GameObject("SystemAudioSource");
				m_objSystemSound.AddComponent<XAudioSourceFromPool>();
				m_objSystemSound.GetComponent<XAudioSourceFromPool>().Init();
			}
			InitAudioMixer();
			InitAudioSourcePool();
		}
		if (Application.isPlaying)
		{
			Object.DontDestroyOnLoad(m_objSound);
			Object.DontDestroyOnLoad(this);
		}
	}

	[Token(Token = "0x60054BE")]
	[Address(RVA = "0x1826640", Offset = "0x1826640", VA = "0x1826640")]
	public void ApplyDecibel()
	{
		SetAudioMixerDecibel(MixerTrack.MUSIC, "BGM", XGlobal.Option.BGM_Vol);
		SetAudioMixerDecibel(MixerTrack.SFX, "SFX", XGlobal.Option.SFX_Vol);
	}

	[Token(Token = "0x60054BF")]
	[Address(RVA = "0x18268FC", Offset = "0x18268FC", VA = "0x18268FC")]
	public void ClearAll()
	{
	}

	[Token(Token = "0x60054C0")]
	[Address(RVA = "0x18269FC", Offset = "0x18269FC", VA = "0x18269FC")]
	public void SceneSoundClear()
	{
	}

	[Token(Token = "0x60054C1")]
	[Address(RVA = "0x18261C4", Offset = "0x18261C4", VA = "0x18261C4")]
	private void InitAudioMixer()
	{
		m_AudioMixer = Resources.Load("Sound/AudioMixer/AudioMixer") as AudioMixer;
		// nome do snapshot nao resolvido no pseudo-C; "Start" e o snapshot inicial do mixer
		SetSnapShot("Start", 0f);
	}

	[Token(Token = "0x60054C2")]
	[Address(RVA = "0x1826C70", Offset = "0x1826C70", VA = "0x1826C70")]
	private void LinkAudioToMixer(XSoundInfo soundInfo, AudioSource audioSource)
	{
		if (m_AudioMixer == null)
		{
			return;
		}
		if (soundInfo.trackType == MixerTrack.NONE)
		{
			return;
		}
		AudioMixerGroup[] groups = m_AudioMixer.FindMatchingGroups(soundInfo.trackType.ToString());
		audioSource.outputAudioMixerGroup = groups[0];
	}

	[Token(Token = "0x60054C3")]
	[Address(RVA = "0x1826E0C", Offset = "0x1826E0C", VA = "0x1826E0C")]
	public void PreloadSceneUISound(GameFlowTypes type)
	{
	}

	[Token(Token = "0x60054C4")]
	[Address(RVA = "0x18270FC", Offset = "0x18270FC", VA = "0x18270FC")]
	public void PreloadSoundFromKey(string key)
	{
	}

	[Token(Token = "0x60054C5")]
	[Address(RVA = "0x182719C", Offset = "0x182719C", VA = "0x182719C")]
	private void Update()
	{
	}

	[Token(Token = "0x60054C6")]
	[Address(RVA = "0x18275C8", Offset = "0x18275C8", VA = "0x18275C8")]
	private void LoadSound()
	{
	}

	[Token(Token = "0x60054C7")]
	[Address(RVA = "0x18275F8", Offset = "0x18275F8", VA = "0x18275F8")]
	private void RequestAsyncSound()
	{
	}

	[Token(Token = "0x60054C8")]
	[Address(RVA = "0x1827C70", Offset = "0x1827C70", VA = "0x1827C70")]
	private void RequestToAudioSrc()
	{
	}

	[Token(Token = "0x60054C9")]
	[Address(RVA = "0x1828350", Offset = "0x1828350", VA = "0x1828350")]
	private void SetAudioSourceData(AudioSource source, XSoundInfo info, bool forceVolumeMax = false)
	{
		source.loop = info.LoopFlag;
		source.volume = forceVolumeMax ? 1f : info.fVolume;
		source.playOnAwake = false;
	}

	[Token(Token = "0x60054CA")]
	[Address(RVA = "0x18283BC", Offset = "0x18283BC", VA = "0x18283BC")]
	private float GetVolumeByDistance(XSoundInfo info, Vector3 origin, Vector3 destination)
	{
		return default(float);
	}

	[Token(Token = "0x60054CB")]
	[Address(RVA = "0x1828478", Offset = "0x1828478", VA = "0x1828478")]
	public void Play(SoundKey key)
	{
	}

	[Token(Token = "0x60054CC")]
	[Address(RVA = "0x1828574", Offset = "0x1828574", VA = "0x1828574")]
	public float Play(string key)
	{
		return default(float);
	}

	[Token(Token = "0x60054CD")]
	[Address(RVA = "0x18289CC", Offset = "0x18289CC", VA = "0x18289CC")]
	public float Play(string key, XModuleSound moduleSound, float volumeRatio = 1f, XSoundCullingType soundCullingType = XSoundCullingType.NormalSound)
	{
		return default(float);
	}

	[Token(Token = "0x60054CE")]
	[Address(RVA = "0x1828A58", Offset = "0x1828A58", VA = "0x1828A58")]
	public float Play(string key, GameObject sourceObj, float volumeRatio = 1f, XSoundCullingType soundCullingType = XSoundCullingType.NormalSound)
	{
		return default(float);
	}

	[Token(Token = "0x60054CF")]
	[Address(RVA = "0x1828BD0", Offset = "0x1828BD0", VA = "0x1828BD0")]
	public void Stop([Optional] GameObject sourceObj)
	{
	}

	[Token(Token = "0x60054D0")]
	[Address(RVA = "0x1828D30", Offset = "0x1828D30", VA = "0x1828D30")]
	public void StopObjSound()
	{
	}

	[Token(Token = "0x60054D1")]
	[Address(RVA = "0x1826A94", Offset = "0x1826A94", VA = "0x1826A94")]
	public void SetSnapShot(string name, float delay)
	{
		if (m_AudioMixer == null)
		{
			return;
		}
		AudioMixerSnapshot snapshot = m_AudioMixer.FindSnapshot(name);
		if (snapshot == null)
		{
			CSLog.Error("Not Exist Snapshot!!");
			return;
		}
		snapshot.TransitionTo(delay);
	}

	[Token(Token = "0x60054D2")]
	[Address(RVA = "0x18285A4", Offset = "0x18285A4", VA = "0x18285A4")]
	private float Play(string key, AudioSource source_1, AudioSource source_2, float volumeRatio = 1f, XSoundCullingType soundCullingType = XSoundCullingType.NormalSound)
	{
		return default(float);
	}

	[Token(Token = "0x60054D3")]
	[Address(RVA = "0x18293A8", Offset = "0x18293A8", VA = "0x18293A8")]
	public void PlayAtPath(string path, [Optional] GameObject sourceObj)
	{
	}

	[Token(Token = "0x60054D4")]
	[Address(RVA = "0x1828F80", Offset = "0x1828F80", VA = "0x1828F80")]
	private bool TryGetAudioClip(XSoundInfo info, out AudioClip clip)
	{
		if (m_clips.TryGetValue(info.strFileName, out clip))
		{
			return true;
		}
		if (info.trackType != MixerTrack.VOX_TUTO)
		{
			CSLog.Warning("Not Sound Preloading : {0}", info.strFileName);
		}
		clip = Resources.Load("Sound/" + info.strFileName) as AudioClip;
		if (clip == null)
		{
			CSLog.Warning("invalid sound file name : " + info.strFileName);
			return false;
		}
		m_clips.Add(info.strFileName, clip);
		return true;
	}

	[Token(Token = "0x60054D5")]
	[Address(RVA = "0x18296E8", Offset = "0x18296E8", VA = "0x18296E8")]
	private bool CheckIgnorePreloadTrack(MixerTrack track)
	{
		return default(bool);
	}

	[Token(Token = "0x60054D6")]
	[Address(RVA = "0x18296F8", Offset = "0x18296F8", VA = "0x18296F8")]
	public float GetSoundLenght(string key)
	{
		return default(float);
	}

	[Token(Token = "0x60054D7")]
	[Address(RVA = "0x1826774", Offset = "0x1826774", VA = "0x1826774")]
	public void SetAudioMixerDecibel(MixerTrack track, string name, float value)
	{
		AudioMixerGroup[] groups = XGlobal.sound.GetAudioMixerGroup(track);
		float decibel = XGlobal.sound.CalcVolumToDecibel(value);
		foreach (AudioMixerGroup group in groups)
		{
			group.audioMixer.SetFloat(name, decibel);
		}
	}

	[Token(Token = "0x60054D8")]
	[Address(RVA = "0x1829994", Offset = "0x1829994", VA = "0x1829994")]
	public float CalcVolumToDecibel(float volume)
	{
		float decibel = volume * 30f - 20f;
		if (decibel == -20f)
		{
			// constante nao resolvida no pseudo-C; -80 dB e o silencio do AudioMixer
			decibel = -80f;
		}
		return decibel;
	}

	[Token(Token = "0x60054D9")]
	[Address(RVA = "0x18298A0", Offset = "0x18298A0", VA = "0x18298A0")]
	public AudioMixerGroup[] GetAudioMixerGroup(MixerTrack mixerTrack)
	{
		return m_AudioMixer.FindMatchingGroups(mixerTrack.ToString());
	}

	[Token(Token = "0x60054DA")]
	[Address(RVA = "0x18299C4", Offset = "0x18299C4", VA = "0x18299C4")]
	public void PlayBGM(BGM_TYPE bgmType, string key)
	{
		XSoundInfo info = GetSoundInfo(key);
		if (info == null)
		{
			CSLog.Error("BGM key {0} not exist.", key);
			return;
		}
		string path = "Sound/" + info.strFileName;
		// original: ResourceLoader.Load<AudioClip> + XAssetBundleManager.UnloadAssetBundle(path)
		AudioClip clip = Resources.Load<AudioClip>(path);
		if (clip == null)
		{
			// texto do log nao resolvido no pseudo-C
			CSLog.Error("BGM clip not exist : {0}", path);
			return;
		}
		clip.LoadAudioData();
		PlayBGM(bgmType, info, clip, path);
	}

	[Token(Token = "0x60054DB")]
	[Address(RVA = "0x1829DB0", Offset = "0x1829DB0", VA = "0x1829DB0")]
	private void PlayBGM(BGM_TYPE bgmType, XSoundInfo soundInfo, AudioClip bgmClip, string bgmClipPath)
	{
		AudioSource source = bgmType == BGM_TYPE.Effect ? m_bgmEffectSource : m_bgmSource;
		string currentPath = bgmType == BGM_TYPE.Normal ? m_bgmClipPath : (bgmType == BGM_TYPE.Effect ? m_bgmEffectClipPath : string.Empty);
		if (currentPath == bgmClipPath)
		{
			return;
		}
		// mesmo clip pausado: nao reinicia
		if (source != null && source.clip != null && source.clip == bgmClip && !source.isPlaying)
		{
			return;
		}
		ClearBGM(bgmType);
		source.clip = bgmClip;
		SetAudioSourceData(source, soundInfo);
		source.loop = true;
		LinkAudioToMixer(soundInfo, source);
		isFadeBGMVolume = false;
		fadeBGMVolume = soundInfo.fVolume;
		fadeBGMTime = initFadeBGMTime;
		source.volume = soundInfo.fVolume;
		source.Play();
	}

	[Token(Token = "0x60054DC")]
	[Address(RVA = "0x182A2B4", Offset = "0x182A2B4", VA = "0x182A2B4")]
	public void ResumeBGM(BGM_TYPE bgmType = BGM_TYPE.Normal)
	{
		GetBGMAudioSource(bgmType).Play();
	}

	[Token(Token = "0x60054DD")]
	[Address(RVA = "0x182A2EC", Offset = "0x182A2EC", VA = "0x182A2EC")]
	public void StopBGM(BGM_TYPE bgmType = BGM_TYPE.Normal)
	{
		GetBGMAudioSource(bgmType).Pause();
	}

	[Token(Token = "0x60054DE")]
	[Address(RVA = "0x182A0B4", Offset = "0x182A0B4", VA = "0x182A0B4")]
	private AudioSource GetBGMAudioSource(BGM_TYPE bgmType)
	{
		return bgmType == BGM_TYPE.Effect ? m_bgmEffectSource : m_bgmSource;
	}

	[Token(Token = "0x60054DF")]
	[Address(RVA = "0x182A0C8", Offset = "0x182A0C8", VA = "0x182A0C8")]
	public void ClearBGM(BGM_TYPE bgmType = BGM_TYPE.Normal)
	{
		AudioSource source = GetBGMAudioSource(bgmType);
		if (source == null || source.clip == null)
		{
			return;
		}
		if (source.clip.loadState == AudioDataLoadState.Loading)
		{
			unloadList.Add(source.clip);
		}
		else
		{
			source.clip.UnloadAudioData();
			Resources.UnloadAsset(source.clip);
		}
		source.clip = null;
	}

	[Token(Token = "0x60054E0")]
	[Address(RVA = "0x182A324", Offset = "0x182A324", VA = "0x182A324")]
	public void SetBGMVolumeFade()
	{
		isFadeBGMVolume = true;
	}

	[Token(Token = "0x60054E1")]
	[Address(RVA = "0x182A330", Offset = "0x182A330", VA = "0x182A330")]
	public void PlayBGM_Title()
	{
		XSoundInfo info = GetSoundInfo("BGM_Title");
		if (info == null)
		{
			CSLog.Error("BGM key {0} not exist.", "BGM_Title");
			return;
		}
		string path = "Sound/" + info.strFileName;
		AudioClip clip = Resources.Load<AudioClip>("Sound/" + info.strFileName);
		PlayBGM(BGM_TYPE.Normal, info, clip, path);
	}

	[Token(Token = "0x60054E2")]
	[Address(RVA = "0x182A570", Offset = "0x182A570", VA = "0x182A570")]
	public void PlayBGM_Lobby()
	{
		PlayBGM(BGM_TYPE.Normal, "BGM_Lobby");
	}

	[Token(Token = "0x60054E3")]
	[Address(RVA = "0x182A5F8", Offset = "0x182A5F8", VA = "0x182A5F8")]
	public XSoundInfo GetSoundInfoForTest(string key)
	{
		return null;
	}

	[Token(Token = "0x60054E4")]
	[Address(RVA = "0x1828D38", Offset = "0x1828D38", VA = "0x1828D38")]
	private XSoundInfo GetSoundInfo(string key)
	{
		if (!XGlobal.proto.sound.TryGetValue(key, out List<XSoundInfo> list))
		{
			return null;
		}
		// sorteio ponderado pela soma acumulada de ratio
		float pick = Random.Range(0f, list[list.Count - 1].ratioSum);
		for (int i = 0; i < list.Count; i++)
		{
			if (pick <= list[i].ratioSum)
			{
				return list[i];
			}
		}
		return list[0];
	}

	[Token(Token = "0x60054E5")]
	[Address(RVA = "0x18275E4", Offset = "0x18275E4", VA = "0x18275E4")]
	private void UpdateSystemSound(float time)
	{
	}

	[Token(Token = "0x60054E6")]
	[Address(RVA = "0x182A5FC", Offset = "0x182A5FC", VA = "0x182A5FC")]
	public void EnqueueSystemSound(string key, XSoundCullingType soundCullingType = XSoundCullingType.NormalSound)
	{
	}

	[Token(Token = "0x60054E7")]
	[Address(RVA = "0x182A610", Offset = "0x182A610", VA = "0x182A610")]
	private void SystemSoundPlay(SystemSound systemSound)
	{
	}

	[Token(Token = "0x60054E8")]
	[Address(RVA = "0x182A63C", Offset = "0x182A63C", VA = "0x182A63C")]
	public void ClearSystemSoundQueue()
	{
	}

	[Token(Token = "0x60054E9")]
	[Address(RVA = "0x182A650", Offset = "0x182A650", VA = "0x182A650")]
	public void StartSystemSound()
	{
	}

	[Token(Token = "0x60054EA")]
	[Address(RVA = "0x1826330", Offset = "0x1826330", VA = "0x1826330")]
	private void InitAudioSourcePool()
	{
		m_transform = transform;
		poolRoot = new GameObject("pool").transform;
		poolRoot.parent = transform;
		Object prefab = Resources.Load("Prefab/AudioSourceFromPool");
		if (prefab == null)
		{
			return;
		}
		for (int i = 0; i < 3; i++)
		{
			GameObject go = Object.Instantiate(prefab) as GameObject;
			// o pseudo-C passa null como parent aqui
			go.transform.parent = null;
			XAudioSourceFromPool pooled = go.GetComponent<XAudioSourceFromPool>();
			pooled.Init();
			if (pooled != null)
			{
				audioSourcePool.Push(pooled);
			}
		}
	}

	[Token(Token = "0x60054EB")]
	[Address(RVA = "0x182A664", Offset = "0x182A664", VA = "0x182A664")]
	public XAudioSourceFromPool GetAudioSourceFromPool()
	{
		return null;
	}

	[Token(Token = "0x60054EC")]
	[Address(RVA = "0x182A8C8", Offset = "0x182A8C8", VA = "0x182A8C8")]
	public void Push(XAudioSourceFromPool audioSourceFromPool)
	{
	}
}
