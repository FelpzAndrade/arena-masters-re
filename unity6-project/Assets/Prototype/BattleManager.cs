using System.Collections.Generic;
using CS;
using UnityEngine;
using UnityEngine.UI;

// Prototipo de luta 1x1 offline na DuelArena: jogador contra bot, cada um com um dos herois (Axie, Spark, Cavaleiro).
// No Play abre antes a tela de escolha (TelaEscolhaHeroi); o bot e sorteado entre os outros. Escolha salva em PlayerPrefs.
// O botao "Herois" na luta volta para a escolha.
// Regras de combate: codigo reconstruido do jogo (CharStatus + XCalculator). Resto: estrutura propria simples.
public class BattleManager : MonoBehaviour
{
	public bool playerControlled = true;
	public Font font;
	public GameObject machadinhaModel;
	public GameObject bruxaModel;
	public GameObject cavaleiroModel;       // Assets/Herois/Cavaleiro/CavaleiroLuta.prefab (Arena Masters/Herois/Montar Cavaleiro para a luta)
	public static readonly string[] Herois = { "Axie", "Spark", "Cavaleiro" };
	public GameObject[] effectPrefabs;      // Cartoon FX Remaster Free

	public Fighter player;
	public Fighter enemy;
	public Arena arena;
	public Camera cam;

	private class Projectile
	{
		public Fighter owner;
		public SkillDef sd;
		public CS.CSSkillInfo info;
		public Vector3 dir;
		public float traveled;
		public GameObject go;
	}

	private readonly List<Projectile> m_projectiles = new List<Projectile>();
	private Fighter m_ultFocus;
	private float m_ultTime;

	private IEnumerable<(Vector3 pos, Vector3 dir, Fighter owner)> LiveProjectiles()
	{
		foreach (Projectile p in m_projectiles)
		{
			yield return (p.go.transform.position, p.dir, p.owner);
		}
	}
	private Vector3 m_camBase;
	public bool brainsPaused;              // capturas de teste: ninguem pensa sozinho (VfxCapture.PlaySkill)
	private IBrain m_playerBrain;
	private IBrain m_enemyBrain;
	private readonly List<(GameObject go, float life, float total)> m_fx = new List<(GameObject, float, float)>();
	private Image m_playerHp;
	private Image m_enemyHp;
	private Text m_playerHpText;
	private Text m_enemyHpText;
	private Text m_score;
	private Text m_playerBuffs;
	private Text m_enemyBuffs;
	private Text m_status;
	private ControlesToque m_toque;

	public bool escolherHeroi = true;      // false = luta direto com a ultima escolha (testes)

	private void Awake()
	{
		if (Application.isPlaying && escolherHeroi)
		{
			MostrarEscolha();
			return;
		}
		Setup();
	}

	// ---------- escolha de heroi ----------

	private void MostrarEscolha()
	{
		List<FichaHeroi> fichas = new List<FichaHeroi>();
		foreach (string h in Herois)
		{
			fichas.Add(Ficha(Def(h, true)));
		}
		TelaEscolhaHeroi tela = null;
		tela = TelaEscolhaHeroi.Criar(fichas, Escolha("heroiJogador", "Axie"), escolhido =>
		{
			List<string> outros = new List<string>(Herois);
			outros.Remove(escolhido);
			PlayerPrefs.SetString("heroiJogador", escolhido);
			PlayerPrefs.SetString("heroiInimigo", outros[Random.Range(0, outros.Count)]);   // bot sorteado entre os outros
			PlayerPrefs.Save();
			Setup();
		}, heroi =>
		{
			PlayerPrefs.SetString("heroiJogador", heroi);
			tela.Fechar();
			TelaInventario.Abrir(heroi, Def(heroi), MostrarEscolha);   // ao voltar, a escolha abre de novo com o poder novo
		});
	}

	// poder total (estimativa propria para comparar herois; o jogo original somava atributos com pesos do servidor)
	public static int Poder(CS.CharStatus s) => Mathf.RoundToInt(s.MaxHP.Calc() * 0.1f + s.PhysicalDamage.Calc() * 3f + s.PhysicalDefense.Calc() * 8000f + s.Critical.Calc() * 6000f);

	private static FichaHeroi Ficha(FighterDef d)
	{
		CS.CharStatus s = new CS.CharStatus();
		d.applyStats(s);
		FichaHeroi f = new FichaHeroi { nome = d.name, classe = d.role, cor = d.color, poder = Poder(s) };
		f.atributos.Add(("Vida", $"{s.MaxHP.Calc():N0}".Replace(",", ".")));
		f.atributos.Add(("Ataque", $"{s.PhysicalDamage.Calc():N0}".Replace(",", ".")));
		f.atributos.Add(("Defesa", $"{s.PhysicalDefense.Calc() * 100f:0}%"));
		f.atributos.Add(("Critico", $"{s.Critical.Calc() * 100f:0.#}%"));
		f.atributos.Add(("Velocidade", $"{d.moveSpeed:0.#}"));
		for (int i = 0; i < d.skills.Length; i++)
		{
			SkillDef sd = d.skills[i];
			if (sd != null)
			{
				f.skills.Add((i == 0 ? "ataque" : sd.vfx, sd.color, (i == 0 ? "Ataque: " : "") + sd.name, Resumo(sd, i == 0)));
			}
		}
		f.skills.Add(("dust", d.color, "Esquiva: " + d.dodge.name, $"recarga {d.dodge.cooldown:0.#} s, invulneravel"));
		f.skills.Add((d.ultimate.vfx, d.ultimate.color, "Ultimate: " + d.ultimate.name, Resumo(d.ultimate, false)));
		f.passiva = d.passiveName.StartsWith("(") ? "ainda em proposta" : $"{d.passiveName}: {d.passiveDesc}";
		f.montarModelo = () => ModeloVitrine(d);
		return f;
	}

	// resumo tirado dos numeros da skill (nao fica desatualizado quando a skill muda)
	private static string Resumo(SkillDef sd, bool basico)
	{
		List<string> p = new List<string>();
		if (sd.damageRatio > 0f)
		{
			int golpes = basico && sd.combo != null ? sd.combo.Length + 1 : sd.hitCount;
			p.Add(golpes > 1 ? $"{golpes}x {sd.damageRatio * 100f:0}%" : $"{sd.damageRatio * 100f:0}%");
		}
		if (basico && sd.combo != null)
		{
			p.Add($"combo de {sd.combo.Length + 1}");
		}
		if (!basico && sd.cooldown > 1f)
		{
			p.Add($"recarga {sd.cooldown:0.#} s");
		}
		if (sd.projectileSpeed > 0f)
		{
			p.Add("projetil");
		}
		else if (sd.areaAtTarget)
		{
			p.Add($"area a distancia ({sd.castRange:0} m)");
		}
		else if (sd.lineWidth > 0f)
		{
			p.Add($"linha de {sd.range:0} m");
		}
		if (sd.dashDistance > 0f)
		{
			p.Add($"avanca {sd.dashDistance:0.#} m");
		}
		if (sd.knockbackDistance > 0f || sd.airborneHeight > 0f || sd.pullDistance > 0f)
		{
			p.Add(sd.pullDistance > 0f ? "puxa" : sd.airborneHeight > 0f ? "joga para cima" : "empurra");
		}
		if (sd.procs.Count > 0)
		{
			p.Add(sd.procs[0].buff.name.ToLower());
		}
		return string.Join(", ", p);
	}

	// modelo da vitrine: igual ao da luta (pecas escondidas) tocando a pose parada em laco
	public static GameObject ModeloVitrine(FighterDef d)
	{
		if (d.model == null)
		{
			return null;
		}
		GameObject go = Object.Instantiate(d.model);
		foreach (Transform t in go.GetComponentsInChildren<Transform>(true))
		{
			if (System.Array.IndexOf(d.hiddenParts, t.name) >= 0)
			{
				t.gameObject.SetActive(false);
			}
		}
		Animation anim = go.GetComponent<Animation>();
		AnimationClip parado = Resources.Load<AnimationClip>("Anim/" + d.animIdle);
		if (anim != null)
		{
			if (parado != null && anim[d.animIdle] == null)
			{
				anim.AddClip(parado, d.animIdle);
			}
			if (anim[d.animIdle] != null)
			{
				anim[d.animIdle].wrapMode = WrapMode.Loop;
				anim.Play(d.animIdle);
			}
		}
		return go;
	}

	public void Setup()
	{
		CSLog.Init(new CSLogger());
		Vfx.Clear();
		Vfx.Register(effectPrefabs);
		Vfx.Preload();
		HitStop.Clear();
		CameraShake.Clear();
		// constantes reais do jogo (XGameConst..cctor no binario)
		XGameConst.AIRBORNE_SPEED = 14f;
		XGameConst.THROW_VERTICAL_SPEED = 3.5f;
		XGameConst.THROW_HORIZENTAL_SPEED = 12.5f;
		XGameConst.KNOCKBACK_SPEED = 8f;
		XGameConst.SNEAK_TIME = 3f;
		if (font == null)
		{
			font = Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");
		}
		DamageNumber.Clear();
		DamageNumber.font = font;

		arena = new Arena();
		// cena da luta: o cenario ja vem salvo com lightmap, luzes e probes (Arena Masters/Mapa/Salvar arena e fazer bake).
		// Sem ele (cena vazia da captura de teste), monta na hora com luz em tempo real.
		if (DungeonDecor.UseBaked(arena) == null)
		{
			DungeonDecor.Build(arena, 3);
			// clima de masmorra: luz fria e fraca de cima, tochas quentes nas paredes
			Light light = new GameObject("Luz ambiente").AddComponent<Light>();
			light.type = LightType.Directional;
			light.intensity = 0.65f;
			light.color = new Color(0.75f, 0.8f, 1f);
			light.shadows = LightShadows.Soft;
			light.transform.rotation = Quaternion.Euler(55f, -30f, 0f);
			RenderSettings.ambientMode = UnityEngine.Rendering.AmbientMode.Flat;
			RenderSettings.ambientLight = new Color(0.17f, 0.16f, 0.21f);   // espaco de cor Linear (URP): mais escuro que no Gamma
		}

		player = new Fighter(Def(Escolha("heroiJogador", "Axie"), Application.isPlaying || Progresso.semSalvar), arena.SpawnPoint(new Vector3(-10f, 0f, 0f)), arena);   // jogador com o equipamento salvo
		enemy = new Fighter(Def(Escolha("heroiInimigo", "Spark")), arena.SpawnPoint(new Vector3(10f, 0f, 0f)), arena);
		player.opponent = enemy;
		enemy.opponent = player;
		foreach (Fighter f in new[] { player, enemy })
		{
			f.onPopup = Popup;
			f.onSkillFx = SkillFx;
			f.onSkillStart = SkillStartFx;
			f.onHitFx = (who, crit, sd) =>
			{
				if (sd != null && sd.vfx == "axeslash")
				{
					Vfx.AxeImpact(who.Position + Vector3.up * 0.2f);
					return;
				}
				if (sd != null && sd.damageType == (CS.SkillDamageTypes)2)
				{
					// magia (Spark): o projetil ja mostra o acerto; as outras soltam o choque eletrico
					if (sd.projectileSpeed <= 0f)
					{
						Vfx.ElectricHit(who.Position + Vector3.up * 0.2f, crit);
					}
					return;
				}
				Vfx.Hit(who.Position + Vector3.up * 0.2f, who.opponent.def.color, crit, who.opponent.def.skills[0].projectileSpeed > 0f);
			};
			f.onDeathFx = who => Vfx.Death(who.Position);
			f.onDodgeFx = (who, step) =>
			{
				Vector3 feet = who.Position + Vector3.down * Arena.CenterHeight;
				if (step == 0 || step == 4)
				{
					Vfx.DodgeDust(feet, who.facing, step == 0 ? 1f : 0.8f);
				}
				else
				{
					Vfx.Afterimage(who.Visual, who.def.color * 1.3f, 0.28f);
				}
			};
			f.onBuffAdded = (who, b) => b.aura = b.def.auraPrefab != null ? Vfx.OwnAura(who.go.transform, b.def.auraPrefab) : Vfx.Aura(who.go.transform, b.def.auraTexture, b.def.color, b.def.control == CS.MotionControlType.Stun);
			f.onBuffRemoved = (who, b) => Vfx.DestroyAura(b.aura);
			f.onProjectile = SpawnProjectile;
			f.onUltimate = (who, sd) =>
			{
				m_ultFocus = who;
				m_ultTime = 0.9f;
				HitStop.Request(0.35f);   // camera lenta na ativacao
				CameraShake.Add(0.2f);
				Popup(who, sd.name.ToUpper() + "!", sd.color);
			};
			f.onDealtHit = ItensMagicos;
			f.onImpact = (sd, crit) =>
			{
				HitStop.Request(sd.hitstop * (crit ? 1.8f : 1f));
				CameraShake.Add(sd.shake + (crit ? 0.15f : 0f));
			};
		}
		cam = new GameObject("Camera").AddComponent<Camera>();
		cam.clearFlags = CameraClearFlags.SolidColor;
		cam.backgroundColor = new Color(0.105f, 0.075f, 0.075f);   // fundo do vazio/fosso em marrom escuro (#1b1313), nao preto
		cam.fieldOfView = CameraFov;
		SetupPostProcessing();
		m_playerBrain = playerControlled ? (IBrain)new PlayerBrain(cam) : new BotBrain(7);
		m_enemyBrain = new BotBrain(42) { projectiles = LiveProjectiles };
		if (m_playerBrain is BotBrain playerBot)
		{
			playerBot.projectiles = LiveProjectiles;
		}
		BuildIndicator();
		BuildUI();
		UpdateCamera(1f);
	}

	// heroi escolhido (PlayerPrefs; na captura do CI fica o padrao Axie x Spark)
	public static string heroiJogadorTeste, heroiInimigoTeste;   // testes fora do Play (TesteEquipamento)

	private static string Escolha(string chave, string padrao)
	{
		string teste = chave == "heroiJogador" ? heroiJogadorTeste : heroiInimigoTeste;
		string h = Application.isPlaying ? PlayerPrefs.GetString(chave, padrao) : teste ?? padrao;
		return System.Array.IndexOf(Herois, h) >= 0 ? h : padrao;
	}

	private FighterDef Def(string heroi, bool comEquipamento = false)
	{
		FighterDef d = heroi == "Spark" ? FighterDef.Spark() : heroi == "Cavaleiro" ? FighterDef.Cavaleiro() : FighterDef.Axie();
		d.model = heroi == "Spark" ? bruxaModel : heroi == "Cavaleiro" ? cavaleiroModel : machadinhaModel;
		if (comEquipamento)
		{
			System.Action<CS.CharStatus> base_ = d.applyStats;
			d.applyStats = s => { base_(s); Progresso.Aplicar(heroi, s); };   // atributos dos 6 slots + bonus de conjunto
		}
		return d;
	}

	private void Recomecar()
	{
		UnityEngine.SceneManagement.Scene cena = gameObject.scene;
#if UNITY_EDITOR
		if (cena.buildIndex < 0)
		{
			// cena fora da lista de build (normal no prototipo): recarrega pelo caminho
			UnityEditor.SceneManagement.EditorSceneManager.LoadSceneInPlayMode(cena.path, new UnityEngine.SceneManagement.LoadSceneParameters(UnityEngine.SceneManagement.LoadSceneMode.Single));
			return;
		}
#endif
		UnityEngine.SceneManagement.SceneManager.LoadScene(cena.buildIndex);
	}

	private void Update()
	{
		if (player == null)
		{
			return;   // ainda na tela de escolha
		}
		HitStop.Tick(Time.unscaledDeltaTime);
		Step(Mathf.Min(Time.deltaTime, 0.05f));
	}

	private void OnDisable()
	{
		HitStop.Clear();
	}

	public void Step(float dt)
	{
		if (!Application.isPlaying && HitStop.Active)
		{
			HitStop.Tick(dt);
			dt *= HitStop.FrozenScale;
		}
		if (player.IsAlive && !brainsPaused)
		{
			m_playerBrain.Think(player, dt);
		}
		if (enemy.IsAlive && !brainsPaused)
		{
			m_enemyBrain.Think(enemy, dt);
		}
		player.Tick(dt);
		enemy.Tick(dt);
		Separate();
		UpdateProjectiles(dt);
		UpdateIndicator();
		UpdateFx(dt);
		Agendados();
		FimDaLuta();
		EspadaPronta(player);
		EspadaPronta(enemy);
		Vfx.Update(dt);
		arena.UpdateBlockers(dt);
		UpdateCamera(dt);
		UpdateUI();
	}

	// tempo real (ignora o hitstop); na captura em modo de edicao o relogio real nao anda, usa o passo da simulacao
	private static float RealDt(float dt) => Application.isPlaying ? Time.unscaledDeltaTime : dt;

	private void UpdateCamera(float dt)
	{
		Vector3 focus = player.IsAlive ? (enemy.IsAlive ? Vector3.Lerp(player.Position, enemy.Position, 0.35f) : player.Position) : arena.center;
		m_ultTime = Mathf.Max(0f, m_ultTime - RealDt(dt));
		if (m_ultTime > 0f && m_ultFocus != null && m_ultFocus.IsAlive)
		{
			focus = Vector3.Lerp(focus, m_ultFocus.Position, 0.7f);
		}
		// lutadores longe (ou um entre a camera e o outro): afasta a camera para caber os dois
		float spread = player.IsAlive && enemy.IsAlive ? Vector3.Distance(player.Position, enemy.Position) : 0f;
		float zoomOut = 1f + Mathf.Clamp(spread - 5f, 0f, 10f) * 0.07f;
		Vector3 want = focus + CameraOffset(m_ultTime > 0f ? CameraDistanceUlt : CameraDistance * zoomOut);
		if (m_ultTime <= 0f && player.IsAlive && enemy.IsAlive)
		{
			// nunca deixa um lutador passar por baixo/atras da camera
			float nearest = Mathf.Min(player.Position.z, enemy.Position.z) - 6f;
			if (want.z > nearest)
			{
				want.y += (want.z - nearest) * 1.1f;
				want.z = nearest;
			}
		}
		m_camBase = Vector3.Lerp(m_camBase == Vector3.zero ? want : m_camBase, want, Mathf.Clamp01(dt * 5f));
		cam.transform.position = m_camBase + CameraShake.Offset(RealDt(dt));
		cam.transform.rotation = Quaternion.LookRotation(focus - want);
		DungeonDecor.UpdateOcclusion(focus, cam.transform.position);
		LuzesBraseiros.SetFocus(focus);
	}

	// camera do jogo original (referencia_visual.md): 55 graus do chao, FOV fechado, heroi com ~15% da altura da tela
	private const float CameraPitch = 55f;
	private const float CameraFov = 33f;
	private const float CameraDistance = 16.5f;
	private const float CameraDistanceUlt = 10f;   // aproxima na ativacao da ultimate

	private static Vector3 CameraOffset(float distance)
	{
		float a = CameraPitch * Mathf.Deg2Rad;
		return new Vector3(0f, Mathf.Sin(a), -Mathf.Cos(a)) * distance;
	}

	// ---------- efeitos ----------

	private void SkillFx(Fighter owner, SkillDef sd, Vector3 center)
	{
		Vector3 ground = center + Vector3.down * Arena.CenterHeight;
		switch (sd.vfx)
		{
			case "warhorn":
				Vfx.WarHorn(owner.Position + Vector3.down * Arena.CenterHeight);
				CameraShake.Add(0.12f);
				return;
			case "bufalo":
				Vfx.BufaloImpact(owner.Position + owner.facing * 0.9f, owner.facing);
				return;
			case "earthslam":
				Vfx.EarthSlam(owner.Position + Vector3.down * Arena.CenterHeight, owner.facing, sd.range);
				return;
			case "axeslash":
				Vfx.AxeSlash(owner.Position, owner.facing, sd.range, sd.vfxRoll);
				return;
			case "slash":
				Vfx.Slash(owner.Position, owner.facing, sd.color, sd.range);
				return;
			case "spin":
				Vfx.Spin(owner.Position, sd.color, sd.range, false);
				return;
			case "magicspin":
				Vfx.Spin(owner.Position, sd.color, sd.range, true);
				return;
			case "slam":
				Vfx.Slam(ground, sd.color, sd.range);
				return;
			case "beam":
				Vfx.Beam(owner.Position + Vector3.up * 0.3f + owner.facing * 0.6f, owner.facing, sd.range, sd.color);
				return;
			case "burst":
				Vfx.MagicBurst(ground, sd.color, sd.range);
				return;
			case "dust":
				Vfx.Dust(owner.Position + Vector3.down * Arena.CenterHeight);
				return;
			case "teleport":
				Vfx.Teleport(owner.Position, owner.def.color);
				return;
			case "bolt":
				Vfx.Muzzle(owner.Position + owner.facing * 0.7f + Vector3.up * 0.25f, sd.color);
				return;
			case "barrier":
				Vfx.Barrier(owner.Position, sd.color);
				return;
			case "lightning":
				Vfx.Lightning(ground, sd.color, sd.range);
				return;
			case "wave":
				Vfx.Wave(owner.Position, owner.facing, sd.color, sd.range);
				return;
			case "rupture":
				Vfx.Rupture(ground, sd.color, sd.range);
				return;
			case "terrasplitter":
				Vfx.TerraSplitter(owner.Position + Vector3.down * Arena.CenterHeight, owner.facing, sd.color, sd.range);
				return;
			case "esfera":
				return;   // a esfera (SkillEsferaGiratoria) ja esta na tela desde o inicio da skill; cada acerto so da o dano
			case "explosao":
				owner.Visual?.GetComponent<SkillUltimateExplosao>()?.Impacto();   // golpe no chao: massa escura, onda, 2a onda depois
				return;
		}
		GameObject disc = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
		Object.DestroyImmediate(disc.GetComponent<Collider>());
		disc.name = "fx_" + sd.name;
		float r = sd.range;
		disc.transform.position = center + Vector3.down * (Arena.CenterHeight - 0.05f);
		disc.transform.localScale = new Vector3(r * 2f, 0.02f, r * 2f);
		disc.GetComponent<Renderer>().material = Arena.MakeMaterial(sd.color);
		m_fx.Add((disc, 0.25f, 0.25f));
		if (sd.angle < 360f && !sd.areaAtTarget)
		{
			// cone/linha: barra na direcao do golpe
			GameObject bar = GameObject.CreatePrimitive(PrimitiveType.Cube);
			Object.DestroyImmediate(bar.GetComponent<Collider>());
			bar.transform.position = owner.Position + owner.facing * (r * 0.5f) + Vector3.down * 0.3f;
			bar.transform.rotation = Quaternion.LookRotation(owner.facing);
			bar.transform.localScale = new Vector3(Mathf.Max(0.4f, r * Mathf.Tan(sd.angle * 0.5f * Mathf.Deg2Rad)), 0.1f, r);
			bar.GetComponent<Renderer>().material = Arena.MakeMaterial(sd.color);
			m_fx.Add((bar, 0.2f, 0.2f));
			Object.DestroyImmediate(disc);
			m_fx.RemoveAt(m_fx.Count - 2);
		}
	}

	// aviso no chao durante a preparacao das skills de area
	private void SkillStartFx(Fighter owner, SkillDef sd, Vector3 center)
	{
		Vector3 ground = center + Vector3.down * (Arena.CenterHeight - 0.02f);
		if (sd.vfx == "burst" || sd.vfx == "slam" || sd.vfx == "earthslam" || sd.vfx == "magicspin" || sd.vfx == "spin")
		{
			Vfx.Telegraph(ground, sd.color, sd.range, Mathf.Max(0.2f, sd.windup), sd.vfx == "burst" || sd.vfx == "magicspin");
		}
		if (sd.vfx == "teleport")
		{
			Vfx.Teleport(owner.Position, owner.def.color);
		}
		if (sd.vfx == "rupture")
		{
			Vfx.RuptureRift(ground, sd.range);   // a fenda inteira (3,4 s); cada dano solta so um pulso
		}
		if (sd.vfx == "bufalo")
		{
			Vfx.BufaloRun(owner.go.transform, sd.windup + 0.9f);   // corrida + tempo para a poeira assentar
		}
		if (sd.vfx == "esfera")
		{
			SkillEsferaGiratoria esfera = owner.Visual?.GetComponent<SkillEsferaGiratoria>();
			if (esfera != null)
			{
				esfera.atraso = sd.windup;
				esfera.duracao = Mathf.Max(0.2f, sd.dashTime - sd.windup);
				esfera.Iniciar(owner.facing);
				esfera.CorteEntrada();
			}
			Espada(owner)?.Pico(sd.dashTime);
		}
		if (sd.vfx == "explosao")
		{
			SkillUltimateExplosao ult = owner.Visual?.GetComponent<SkillUltimateExplosao>();
			if (ult != null && owner.opponent != null)
			{
				ult.tempoImpacto = sd.windup + 0.3f;   // + camera lenta da ativacao (HitStop 0,35 s); o golpe chama Impacto() na hora certa
				ult.aoExplosao = p => ExplosaoArcana(owner, p);
				ult.Iniciar(owner.opponent.Position + Vector3.down * Arena.CenterHeight);
			}
			Espada(owner)?.Pico(sd.windup);
		}
	}

	// 2a onda da Explosao Arcana: cada explosao da dano em quem estiver perto (estimativa: 150%)
	private static readonly SkillDef s_explosao = new SkillDef { name = "Explosao Arcana", damageRatio = 1.5f, hitstop = 0.03f, shake = 0.14f, ultimateCharge = 0f };
	private CS.CSSkillInfo m_explosaoInfo;

	private void ExplosaoArcana(Fighter owner, Vector3 p)
	{
		CameraShake.Add(0.14f);
		Fighter alvo = owner.opponent;
		if (alvo == null || !alvo.IsAlive || alvo.invulnerable)
		{
			return;
		}
		Vector3 d = alvo.Position + Vector3.down * Arena.CenterHeight - p;
		d.y = 0f;
		if (d.magnitude < 2.4f)
		{
			m_explosaoInfo ??= s_explosao.BuildInfo(990);
			owner.ResolveHit(alvo, s_explosao, m_explosaoInfo, d.sqrMagnitude > 0.01f ? d.normalized : owner.facing);
		}
	}

	// ---------- itens magicos (chance ao causar dano) ----------

	private static readonly SkillDef s_raioItem = new SkillDef { name = "Relampago Errante", damageType = (CS.SkillDamageTypes)2, damageRatio = 2.5f, hitstop = 0.04f, shake = 0.12f, ultimateCharge = 0f, color = new Color(0.5f, 0.85f, 1f) };
	private static readonly SkillDef s_esferaItem = new SkillDef { name = "Esfera Runica", damageRatio = 0.8f, hitstop = 0.03f, ultimateCharge = 0f, color = new Color(0.6f, 0.35f, 1f) };
	private readonly Dictionary<ItemDef, float> m_esperaMagia = new Dictionary<ItemDef, float>();
	private readonly List<(float quando, System.Action acao)> m_agendados = new List<(float, System.Action)>();
	private CS.CSSkillInfo m_infoRaio, m_infoEsfera;

	private void ItensMagicos(Fighter dono, Fighter alvo, SkillDef sd, int dano)
	{
		if (dono != player || sd == s_raioItem || sd == s_esferaItem || !Application.isPlaying)
		{
			return;   // so o jogador tem equipamento; o dano do proprio item nao dispara outro item
		}
		foreach (ItemDef item in Progresso.MagiasDoHeroi(dono.def.name))
		{
			if (m_esperaMagia.TryGetValue(item, out float livre) && Time.time < livre || Random.value >= item.chanceMagia)
			{
				continue;
			}
			m_esperaMagia[item] = Time.time + item.esperaMagia;
			if (item.magia == Magia.Relampago)
			{
				Vfx.Lightning(alvo.Position + Vector3.down * Arena.CenterHeight, s_raioItem.color, 1.2f);
				Popup(dono, "Relampago Errante!", s_raioItem.color);
				m_infoRaio ??= s_raioItem.BuildInfo(991);
				if (alvo.IsAlive)
				{
					dono.ResolveHit(alvo, s_raioItem, m_infoRaio, alvo.Position - dono.Position);
				}
			}
			else if (item.magia == Magia.EsferaRunica && dono.Visual != null)
			{
				GameObject prefab = Resources.Load<GameObject>("VFX_EsferaGiratoria");
				if (prefab != null)
				{
					EfeitoCor.Criar(prefab, dono.Visual.position + Vector3.up * 1.15f, Quaternion.identity, dono.Visual, s_esferaItem.color, 0.6f, 1.6f);
				}
				Popup(dono, "Esfera Runica!", s_esferaItem.color);
				m_infoEsfera ??= s_esferaItem.BuildInfo(992);
				for (int k = 1; k <= 2; k++)
				{
					m_agendados.Add((Time.time + 0.5f * k, () =>
					{
						Fighter a = dono.opponent;
						if (a != null && a.IsAlive && !a.invulnerable && Vector3.Distance(a.Position, dono.Position) < 2.2f)
						{
							dono.ResolveHit(a, s_esferaItem, m_infoEsfera, a.Position - dono.Position);
						}
					}));
				}
			}
		}
	}

	private void Agendados()
	{
		for (int i = m_agendados.Count - 1; i >= 0; i--)
		{
			if (Time.time >= m_agendados[i].quando)
			{
				System.Action a = m_agendados[i].acao;
				m_agendados.RemoveAt(i);
				a();
			}
		}
	}

	// ---------- fim de luta (3 abates) ----------

	public const int AbatesParaVencer = 3;
	private bool m_fim;

	private void FimDaLuta()
	{
		if (m_fim || !Application.isPlaying || (player.kills < AbatesParaVencer && enemy.kills < AbatesParaVencer))
		{
			return;
		}
		m_fim = true;
		brainsPaused = true;
		bool vitoria = player.kills >= AbatesParaVencer;
		(int ouro, ItemDef item) = Progresso.Recompensa(vitoria);
		MostrarResultado(vitoria, ouro, item);
	}

	private void MostrarResultado(bool vitoria, int ouro, ItemDef item)
	{
		Canvas c = new GameObject("Resultado").AddComponent<Canvas>();
		c.renderMode = RenderMode.ScreenSpaceOverlay;
		c.sortingOrder = 40;
		CanvasScaler sc = c.gameObject.AddComponent<CanvasScaler>();
		sc.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
		sc.referenceResolution = new Vector2(1280f, 720f);
		sc.matchWidthOrHeight = 1f;
		c.gameObject.AddComponent<GraphicRaycaster>();
		RectTransform fundo = Rect("Fundo", c.transform, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(4000f, 4000f));
		fundo.gameObject.AddComponent<Image>().color = new Color(0f, 0f, 0f, 0.6f);
		RectTransform caixa = Rect("Caixa", c.transform, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(620f, 400f));
		Image ci = caixa.gameObject.AddComponent<Image>();
		ci.sprite = TelaEscolhaHeroi.SpriteRedondo();
		ci.type = Image.Type.Sliced;
		ci.pixelsPerUnitMultiplier = 4f;
		ci.color = new Color(0.1f, 0.08f, 0.1f, 0.95f);
		TMPro.TextMeshProUGUI titulo = TextoTmp(caixa, new Vector2(0f, 130f), new Vector2(580f, 80f), vitoria ? "VITORIA!" : "DERROTA", 64f, vitoria ? new Color(1f, 0.8f, 0.3f) : new Color(0.75f, 0.75f, 0.8f));
		titulo.fontStyle = TMPro.FontStyles.Bold;
		TextoTmp(caixa, new Vector2(0f, 60f), new Vector2(580f, 34f), $"{player.kills} x {enemy.kills}", 28f, Color.white);
		string ganho = $"+{ouro:N0} de ouro".Replace(",", ".");
		if (item != null)
		{
			ganho += $"\nItem novo: <color=#{ColorUtility.ToHtmlStringRGB(Atributos.CoresGrade[(int)item.grade])}>{item.nome}</color> ({Atributos.NomesGrade[(int)item.grade]})";
		}
		TextoTmp(caixa, new Vector2(0f, -10f), new Vector2(580f, 80f), ganho, 24f, new Color(1f, 0.9f, 0.6f));
		BotaoTmp(caixa, new Vector2(-150f, -130f), "EQUIPAMENTOS", new Color(0.25f, 0.22f, 0.35f), () =>
		{
			Destroy(c.gameObject);
			TelaInventario.Abrir(player.def.name, Def(player.def.name), Recomecar);
		});
		BotaoTmp(caixa, new Vector2(150f, -130f), "JOGAR DE NOVO", new Color(0.85f, 0.45f, 0.12f), Recomecar);
	}

	private static TMPro.TextMeshProUGUI TextoTmp(Transform pai, Vector2 pos, Vector2 tam, string txt, float tamanho, Color cor)
	{
		TMPro.TextMeshProUGUI t = Rect("Txt", pai, new Vector2(0.5f, 0.5f), pos, tam).gameObject.AddComponent<TMPro.TextMeshProUGUI>();
		t.text = txt;
		t.fontSize = tamanho;
		t.color = cor;
		t.alignment = TMPro.TextAlignmentOptions.Center;
		t.raycastTarget = false;
		return t;
	}

	private static void BotaoTmp(Transform pai, Vector2 pos, string txt, Color cor, System.Action aoTocar)
	{
		RectTransform rt = Rect("Botao", pai, new Vector2(0.5f, 0.5f), pos, new Vector2(260f, 76f));
		Image i = rt.gameObject.AddComponent<Image>();
		i.sprite = TelaEscolhaHeroi.SpriteRedondo();
		i.type = Image.Type.Sliced;
		i.pixelsPerUnitMultiplier = 4f;
		i.color = cor;
		rt.gameObject.AddComponent<Button>().onClick.AddListener(() => aoTocar());
		TextoTmp(rt, Vector2.zero, new Vector2(250f, 70f), txt, 24f, Color.white).fontStyle = TMPro.FontStyles.Bold;
	}

	private static EspadaBrilho Espada(Fighter f) => f.Visual != null ? f.Visual.GetComponent<EspadaBrilho>() : null;

	// espada no brilho maximo enquanto a ultimate estiver pronta (da para ver de longe)
	private static void EspadaPronta(Fighter f)
	{
		EspadaBrilho e = Espada(f);
		if (e != null)
		{
			e.ultimatePronta = f.IsAlive && f.UltReady;
		}
	}

	// bloom (magias, tochas, criticos brilham), cor mais quente/contrastada e vinheta
	private void SetupPostProcessing()
	{
		PosProcessamentoArena.Aplicar(cam);
	}

	// ---------- projeteis (podem ser esquivados) ----------

	private void SpawnProjectile(Fighter owner, SkillDef sd, CS.CSSkillInfo info, Vector3 origin, Vector3 dir)
	{
		GameObject go = new GameObject("projetil_" + sd.name);
		go.transform.position = origin;
		Vfx.ProjectileVisual(go, sd.color);
		m_projectiles.Add(new Projectile { owner = owner, sd = sd, info = info, dir = dir.normalized, go = go });
	}

	private void UpdateProjectiles(float dt)
	{
		for (int i = m_projectiles.Count - 1; i >= 0; i--)
		{
			Projectile p = m_projectiles[i];
			float step = p.sd.projectileSpeed * dt;
			Vector3 pos = p.go.transform.position + p.dir * step;
			p.traveled += step;
			p.go.transform.position = pos;
			Fighter target = p.owner.opponent;
			bool done = false;
			if (target != null && target.IsAlive && !target.invulnerable)
			{
				Vector3 d = target.Position - pos;
				float dy = Mathf.Abs(d.y);
				d.y = 0f;
				if (d.magnitude < p.sd.projectileRadius + 0.5f && dy < 2f)
				{
					p.owner.ResolveHit(target, p.sd, p.info, p.dir);
					Vfx.Impact(pos, p.sd.color);
					done = true;
				}
			}
			// bate em parede/borda: sem chao proximo abaixo do projetil
			if (!done && arena.FloorBelow(pos, pos.y + 0.3f) is float floorY && pos.y - floorY > 3f)
			{
				done = true;
			}
			if (!done && arena.FloorBelow(pos, pos.y + 0.3f) == null)
			{
				Vfx.Impact(pos, p.sd.color);
				done = true;
			}
			if (!done && p.traveled >= p.sd.range)
			{
				Vfx.Muzzle(pos, p.sd.color);
				done = true;
			}
			if (done)
			{
				Vfx.ReleaseProjectileVisual(p.go);
				DestroyAny(p.go);
				m_projectiles.RemoveAt(i);
			}
		}
	}

	// ---------- colisao entre lutadores ----------

	private void Separate()
	{
		if (!player.IsAlive || !enemy.IsAlive)
		{
			return;
		}
		Vector3 d = enemy.Position - player.Position;
		d.y = 0f;
		float dist = d.magnitude;
		const float minDist = 1.1f;
		if (dist < minDist && Mathf.Abs(enemy.Position.y - player.Position.y) < 1.5f)
		{
			Vector3 n = dist > 0.001f ? d / dist : Vector3.right;
			float push = (minDist - dist) * 0.5f;
			player.Nudge(-n * push);
			enemy.Nudge(n * push);
		}
	}

	// ---------- indicador de mira (segurar K/L/I/R ou o botao da skill) ----------
	// Decal do URP so na camada "chao" (nao pinta os personagens). Formas brancas de Resources/Mira (tools/gen_ui_textures.py),
	// pintadas na cor da skill uma vez por cor (pixels; Editor/ImportMira deixa as formas legiveis). Area: circulo no alvo + anel do alcance;
	// golpe em linha ou avanco: faixa ate onde chega; cone: cone esticado para o angulo da skill.
	private const uint CamadaChao = 1u << 1;
	private UnityEngine.Rendering.Universal.DecalProjector m_mira, m_miraAnel;
	private readonly Dictionary<string, Material> m_materiaisMira = new Dictionary<string, Material>();

	private void BuildIndicator()
	{
		m_mira = NovaMira("mira");
		m_miraAnel = NovaMira("mira_alcance");
	}

	private UnityEngine.Rendering.Universal.DecalProjector NovaMira(string nome)
	{
		UnityEngine.Rendering.Universal.DecalProjector d = new GameObject(nome).AddComponent<UnityEngine.Rendering.Universal.DecalProjector>();
		d.renderingLayerMask = CamadaChao;
		d.drawDistance = 60f;
		d.fadeFactor = 1f;
		d.gameObject.SetActive(false);
		return d;
	}

	private Material MaterialMira(string forma, Color cor)
	{
		string chave = forma + ColorUtility.ToHtmlStringRGBA(cor);
		if (m_materiaisMira.TryGetValue(chave, out Material m) && m != null)
		{
			return m;
		}
		Texture2D branca = Resources.Load<Texture2D>("Mira/" + forma);
		Color32[] px = branca.GetPixels32();
		Color32 c = cor;
		for (int i = 0; i < px.Length; i++)
		{
			px[i] = new Color32((byte)(px[i].r * c.r / 255), (byte)(px[i].g * c.g / 255), (byte)(px[i].b * c.b / 255), (byte)Mathf.Min(255, px[i].a * c.a / 255 * 2));   // x2: o miolo fraco ainda aparece no chao escuro
		}
		Texture2D pintada = new Texture2D(branca.width, branca.height, TextureFormat.RGBA32, true) { name = chave, wrapMode = TextureWrapMode.Clamp };
		pintada.SetPixels32(px);
		pintada.Apply(true, true);   // sobe para a placa de video e libera a copia na memoria
		m = new Material(Shader.Find("Shader Graphs/Decal"));
		m.SetTexture("Base_Map", pintada);
		m.SetFloat("_DrawOrder", 10f);       // por cima dos decalques do mapa
		m_materiaisMira[chave] = m;
		return m;
	}

	private void UpdateIndicator()
	{
		PlayerBrain brain = m_playerBrain as PlayerBrain;
		SkillDef sd = brain != null && player.IsAlive ? brain.AimingSkill : null;
		m_mira.gameObject.SetActive(sd != null);
		m_miraAnel.gameObject.SetActive(sd != null && sd.areaAtTarget);
		if (sd == null)
		{
			return;
		}
		Color c = Color.Lerp(sd.color, Color.white, 0.35f);
		c.a = 1f;
		Vector3 pes = player.Position + Vector3.down * Arena.CenterHeight + Vector3.up * 0.5f;
		Vector3 aim = brain.AimPoint - player.Position;
		aim.y = 0f;
		float giro = Quaternion.LookRotation(aim.sqrMagnitude > 0.01f ? aim.normalized : player.facing).eulerAngles.y;
		if (sd.areaAtTarget)
		{
			Posicionar(m_mira, "T_MiraCirculo", c, pes + Vector3.ClampMagnitude(aim, sd.castRange), 0f, new Vector2(sd.range * 2f, sd.range * 2f), Vector2.zero);
			Posicionar(m_miraAnel, "T_MiraAnel", c, pes, 0f, new Vector2(sd.castRange * 2f, sd.castRange * 2f), Vector2.zero);
		}
		else if (sd.lineWidth > 0f || (sd.dashDistance > 0f && sd.angle >= 360f))
		{
			// golpe em linha (largura da linha) ou avanco que acerta pelo caminho (largura = diametro da area)
			float largura = sd.lineWidth > 0f ? sd.lineWidth : sd.range * 2f, comprimento = sd.range + sd.dashDistance;
			Posicionar(m_mira, "T_MiraFaixa", c, pes, giro, new Vector2(largura, comprimento), new Vector2(0f, comprimento * 0.5f));
		}
		else if (sd.angle >= 360f)
		{
			Posicionar(m_mira, "T_MiraCirculo", c, pes, 0f, new Vector2(sd.range * 2f, sd.range * 2f), Vector2.zero);
		}
		else
		{
			// cone: a textura tem 120 graus; estica na largura para o angulo da skill (ponta no heroi)
			float alcance = sd.range + sd.dashDistance;
			float esticar = Mathf.Sin(Mathf.Min(sd.angle, 179f) * 0.5f * Mathf.Deg2Rad) / Mathf.Sin(60f * Mathf.Deg2Rad);
			Posicionar(m_mira, "T_MiraCone", c, pes, giro, new Vector2(alcance * 2f * esticar, alcance), new Vector2(0f, alcance * 0.5f));
		}
	}

	// projeta para baixo (local +Z = chao, local +Y = frente do giro); tamanho (largura, comprimento), centro deslocado para a frente
	private void Posicionar(UnityEngine.Rendering.Universal.DecalProjector d, string forma, Color cor, Vector3 pos, float giro, Vector2 tamanho, Vector2 deslocamento)
	{
		d.material = MaterialMira(forma, cor);
		d.transform.SetPositionAndRotation(pos, Quaternion.Euler(90f, giro, 0f));
		d.size = new Vector3(tamanho.x, tamanho.y, 2f);
		d.pivot = new Vector3(deslocamento.x, deslocamento.y, 0f);
	}
	private void Popup(Fighter who, string text, Color color)
	{
		bool isNumber = text.Length > 0 && char.IsDigit(text[0]);
		Vector3 pos = who.Position + Vector3.up * (isNumber ? 1.6f : 2.3f) + new Vector3(Random.Range(-0.4f, 0.4f), 0f, 0f);
		DamageNumber.Show(pos, text, color, DamageNumber.Estilo.Simples);   // estilo da luta mantido (o novo fica para a etapa de UI)
	}

	private void UpdateFx(float dt)
	{
		for (int i = m_fx.Count - 1; i >= 0; i--)
		{
			(GameObject go, float life, float total) = m_fx[i];
			life -= dt;
			if (life <= 0f)
			{
				DestroyAny(go);
				m_fx.RemoveAt(i);
				continue;
			}
			go.transform.localScale = Vector3.Scale(go.transform.localScale, new Vector3(1f, 1f, 1f)) * (1f + dt * 0.8f);
			m_fx[i] = (go, life, total);
		}
		DamageNumber.Tick(cam);
	}

	private static string BuffText(Fighter f)
	{
		System.Text.StringBuilder sb = new System.Text.StringBuilder();
		foreach (ActiveBuff b in f.buffs)
		{
			string hex = ColorUtility.ToHtmlStringRGB(b.def.color);
			string stack = b.stack > 1 ? $" x{b.stack}" : string.Empty;
			sb.Append($"<color=#{hex}>{(b.def.type == CS.BuffType.Debuff ? "v" : "^")} {b.def.name}{stack} {b.remaining:0.0}s</color>   ");
		}
		return sb.ToString();
	}

	private static void DestroyAny(Object o)
	{
		if (Application.isPlaying)
		{
			Destroy(o);
		}
		else
		{
			DestroyImmediate(o);
		}
	}

	// ---------- UI (uGUI nativo) ----------

	private void BuildUI()
	{
		Canvas canvas = new GameObject("UI").AddComponent<Canvas>();
		canvas.renderMode = RenderMode.ScreenSpaceOverlay;   // por cima do pos-processamento (botoes sem bloom nem vinheta)
		CanvasScaler scaler = canvas.gameObject.AddComponent<CanvasScaler>();
		scaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
		scaler.referenceResolution = new Vector2(1280f, 720f);
		scaler.matchWidthOrHeight = 1f;

		m_playerHp = Bar(canvas.transform, new Vector2(0f, 1f), new Vector2(30f, -30f), player.def.color, out m_playerHpText, player.def.name + " (voce)");
		m_enemyHp = Bar(canvas.transform, new Vector2(1f, 1f), new Vector2(-30f, -30f), enemy.def.color, out m_enemyHpText, enemy.def.name + " (bot)");
		m_playerBuffs = Label(canvas.transform, new Vector2(0f, 1f), new Vector2(30f, -98f), 16, TextAnchor.UpperLeft, new Vector2(420f, 24f));
		m_playerBuffs.rectTransform.pivot = new Vector2(0f, 1f);
		m_enemyBuffs = Label(canvas.transform, new Vector2(1f, 1f), new Vector2(-30f, -98f), 16, TextAnchor.UpperRight, new Vector2(420f, 24f));
		m_enemyBuffs.rectTransform.pivot = new Vector2(1f, 1f);
		m_score = Label(canvas.transform, new Vector2(0.5f, 1f), new Vector2(0f, -40f), 30, TextAnchor.UpperCenter, new Vector2(400f, 70f));
		m_status = Label(canvas.transform, new Vector2(0.5f, 1f), new Vector2(0f, -70f), 18, TextAnchor.UpperCenter, new Vector2(700f, 30f));

		// controles de toque (no PC os botoes tambem funcionam com o mouse e mostram a tecla de cada um)
		m_toque = ControlesToque.Criar(canvas, !Application.isMobilePlatform);
		foreach (int slot in new[] { 0, 1, 2, 3, Fighter.DodgeSlot, Fighter.UltSlot })
		{
			SkillDef sd = player.SlotSkill(slot);
			string icone = sd == null ? "vazio" : slot == 0 ? "ataque" : slot == Fighter.DodgeSlot ? "dust" : sd.vfx;
			Color cor = sd == null ? Color.gray : slot == 0 || slot == Fighter.DodgeSlot ? player.def.color : sd.color;
			m_toque.Botao(slot)?.Configurar(cor, ControlesToque.Icone(icone), sd == null);
		}
		(m_playerBrain as PlayerBrain)?.Ligar(m_toque);
		// voltar para a escolha de heroi
		RectTransform voltar = Rect("Herois", canvas.transform, new Vector2(0.5f, 1f), new Vector2(0f, -112f), new Vector2(120f, 36f));   // embaixo do placar
		Image vi = voltar.gameObject.AddComponent<Image>();
		vi.color = new Color(0f, 0f, 0f, 0.55f);
		voltar.gameObject.AddComponent<Button>().onClick.AddListener(Recomecar);
		Label(voltar, new Vector2(0.5f, 0.5f), Vector2.zero, 16, TextAnchor.MiddleCenter, new Vector2(120f, 40f)).text = "Herois";
		if (!Application.isMobilePlatform)
		{
			Text help = Label(canvas.transform, new Vector2(0f, 1f), new Vector2(30f, -130f), 13, TextAnchor.UpperLeft, new Vector2(520f, 40f));
			help.rectTransform.pivot = new Vector2(0f, 1f);
			help.text = "WASD ou joystick | mouse mira | J/clique combo | segure K/L/I/R para mirar | Espaco esquiva";
		}
	}

	private Image Bar(Transform parent, Vector2 anchor, Vector2 pos, Color color, out Text text, string title)
	{
		RectTransform back = Rect("hp", parent, anchor, pos, new Vector2(420f, 30f));
		back.pivot = anchor;
		back.gameObject.AddComponent<Image>().color = new Color(0f, 0f, 0f, 0.7f);
		Image fill = Rect("fill", back, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(412f, 22f)).gameObject.AddComponent<Image>();
		fill.color = color;
		fill.type = Image.Type.Filled;
		fill.fillMethod = Image.FillMethod.Horizontal;
		fill.fillOrigin = anchor.x > 0.5f ? 1 : 0;
		text = Label(back, new Vector2(0.5f, 0.5f), Vector2.zero, 16, TextAnchor.MiddleCenter, new Vector2(412f, 22f));
		Text name = Label(back, new Vector2(anchor.x, 0f), new Vector2(0f, -4f), 18, anchor.x > 0.5f ? TextAnchor.UpperRight : TextAnchor.UpperLeft, new Vector2(412f, 26f));
		name.rectTransform.pivot = new Vector2(anchor.x, 1f);
		name.text = "<b>" + title + "</b>";
		return fill;
	}

	private Text Label(Transform parent, Vector2 anchor, Vector2 pos, int size, TextAnchor align, Vector2 boxSize)
	{
		Text t = Rect("txt", parent, anchor, pos, boxSize).gameObject.AddComponent<Text>();
		t.font = font;
		t.fontSize = size;
		t.alignment = align;
		t.color = Color.white;
		t.supportRichText = true;
		t.gameObject.AddComponent<Outline>().effectColor = Color.black;
		return t;
	}

	private static RectTransform Rect(string name, Transform parent, Vector2 anchor, Vector2 pos, Vector2 size)
	{
		RectTransform rt = new GameObject(name, typeof(RectTransform)).GetComponent<RectTransform>();
		rt.SetParent(parent, false);
		rt.anchorMin = rt.anchorMax = anchor;
		rt.pivot = new Vector2(0.5f, 0.5f);
		rt.anchoredPosition = pos;
		rt.sizeDelta = size;
		return rt;
	}

	private void UpdateUI()
	{
		m_playerHp.fillAmount = player.hp / player.maxHp;
		m_enemyHp.fillAmount = enemy.hp / enemy.maxHp;
		m_playerHpText.text = $"{Mathf.CeilToInt(player.hp)} / {Mathf.CeilToInt(player.maxHp)}" + (player.IsDeathDoor() ? "  (a beira da morte)" : string.Empty);
		m_enemyHpText.text = $"{Mathf.CeilToInt(enemy.hp)} / {Mathf.CeilToInt(enemy.maxHp)}" + (enemy.IsDeathDoor() ? "  (a beira da morte)" : string.Empty);
		m_score.text = $"<b>{player.kills}  x  {enemy.kills}</b>\n<size=55%>vence quem fizer {AbatesParaVencer}</size>";
		m_playerBuffs.text = BuffText(player);
		m_enemyBuffs.text = BuffText(enemy);
		string s = !player.IsAlive ? "Voce foi derrotado - renascendo..." : !enemy.IsAlive ? "K.O.! A Bruxa renasce em instantes" : player.CurrentSkillName;
		m_status.text = s;
		foreach (int slot in new[] { 1, 2, 3, Fighter.DodgeSlot, Fighter.UltSlot })
		{
			m_toque.Botao(slot)?.Recarga(player.CooldownRatio(slot), player.cooldowns[slot]);
		}
		BotaoSkill ult = m_toque.Botao(Fighter.UltSlot);
		if (ult != null)
		{
			ult.Carga(player.UltPercent, player.UltReady);
			if (!player.UltReady)
			{
				ult.Recarga(1f - player.UltPercent, 0f);   // escurecida ate encher
			}
		}
		if (player.ComboStep > 0 && player.SlotSkill(0).combo != null)
		{
			SkillDef[] combo = player.SlotSkill(0).combo;
			string next = player.ComboStep <= combo.Length ? combo[player.ComboStep - 1].name : player.SlotSkill(0).name;
			m_status.text = $"Combo {player.ComboStep + 1}/{combo.Length + 1}: {next}";
		}
	}
}
