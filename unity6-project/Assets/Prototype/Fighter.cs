using System.Collections.Generic;
using CS;
using UnityEngine;

// Lutador do prototipo. Implementa IActor (interface original) para usar as regras reconstruidas:
// CharStatus/CharStatusAttr, XCalculator (acerto, critico, dano, tempos de controle) e as regras de buff do XModuleBuff.
// Fluidez inspirada no original: combo (ComboSkillData), fila de comando (ReserveSkillOnCurrentSkillFinished),
// cancelamento (IsCancelable/CancelCurrentSkill), skills moveis (IsCurrentSkillMovable) e projeteis (XSkillProjectile).
public class Fighter : IActor
{
	public enum State { Idle, Casting, Recovering, Controlled, Dead }

	public const int DodgeSlot = 4;        // 0 = basico, 1..3 = skills A/B/C, 4 = esquiva, 5 = ultimate
	public const int UltSlot = 5;
	private const float QueueWindow = 0.35f;

	public readonly FighterDef def;
	public readonly GameObject go;
	public readonly CharStatus status = new CharStatus();      // efetivo: base + buffs
	public readonly CharStatus baseStatus = new CharStatus();
	public readonly List<ActiveBuff> buffs = new List<ActiveBuff>();
	public readonly float[] cooldowns;
	public Fighter opponent;
	public Arena arena;

	public System.Action<Fighter, string, Color> onPopup;
	public System.Action<Fighter, SkillDef, Vector3> onSkillFx;
	public System.Action<Fighter, SkillDef, Vector3> onSkillStart;
	public System.Action<Fighter, bool, SkillDef> onHitFx;
	public System.Action<Fighter> onDeathFx;
	public System.Action<Fighter, ActiveBuff> onBuffAdded;
	public System.Action<Fighter, ActiveBuff> onBuffRemoved;
	public System.Action<Fighter, SkillDef, CSSkillInfo, Vector3, Vector3> onProjectile; // dono, skill, info, origem, direcao
	public System.Action<SkillDef, bool> onImpact;                                      // hitstop/tremor
	public System.Action<Fighter, Fighter, SkillDef, int> onDealtHit;                    // dono, alvo, skill, dano (itens magicos)
	public System.Action<Fighter, SkillDef> onUltimate;                                 // camera lenta/zoom na ativacao
	public System.Action<Fighter, int> onDodgeFx;                                       // esquiva: 0 = saida, 1..3 = fantasmas, 4 = pouso
	public Transform Visual => m_visual;
	private int m_ghosts;

	public float hp;
	public float maxHp;
	public State state;
	public int kills;
	public Vector3 facing = Vector3.forward;
	public bool invulnerable;
	public float ultCharge;                // m_chargePoint do XUltimateSkillCharger
	public float passiveTimer;             // recarga interna da passiva

	private readonly Dictionary<SkillDef, CSSkillInfo> m_infos = new Dictionary<SkillDef, CSSkillInfo>();
	private readonly Vector3 m_spawn;
	private readonly Renderer[] m_renderers;
	private readonly Color[] m_baseColors;
	private readonly Animation m_anim;
	private readonly XModuleActor.CharacterStatus m_original = new XModuleActor.CharacterStatus();
	private string m_animName;
	private bool m_moved;
	private SkillDef m_sd;
	private int m_slot = -1;
	private float m_stateTime;
	private Vector3 m_aim;
	private float m_dashLen;               // avanco desta skill (dashDistance, ou menos com dashStop)
	private int m_comboStep;
	private float m_comboTimer;
	private int m_queuedSlot = -1;
	private Vector3 m_queuedAim;
	private float m_queuedTtl;
	// controle de movimento atual (XMotionControlBase): tipo, tempos, direcao, distancias, subida/queda
	private MotionControlType m_mcType;
	private float m_mcElapsed;
	private float m_mcTotal;
	private Vector3 m_mcDir;
	private Vector3 m_mcSource;
	private float m_mcDist;
	private float m_mcDist2;
	private float m_mcHSpeed;
	private float m_mcPullDur;
	private float m_mcRise;
	private float m_mcFall;
	private float m_mcHeight;
	private float m_mcLift0;
	private float m_mcVSpeed;
	private float m_lift;                  // altura do modelo (DOTween no Y local do mesh no original)
	private readonly HitFlash m_hitFlash;
	private int m_hitsDone;
	private Transform m_visual;
	private TrailRenderer m_trail;
	private Vector3 m_moveDir;
	private float m_getUp;
	private float m_cheer;
	private float m_punch;
	private bool m_wasAirborne;
	private bool m_fakeBeatenReady;

	// instante do golpe em cada clipe (s), medido pelo pico de velocidade da mao da arma (Editor/ImpactProbe).
	// No jogo original vinha de tabela (XSkillHitTime / character_anim.xml). Salto e Raise: ajuste manual.
	private static readonly Dictionary<string, float> ImpactTime = new Dictionary<string, float>
	{
		{ "2H_Melee_Attack_Slice", 0.385f }, { "2H_Melee_Attack_Stab", 0.387f }, { "2H_Melee_Attack_Chop", 0.721f },
		{ "2H_Melee_Attack_Spinning", 0.256f }, { "Jump_Full_Short", 0.85f }, { "Spellcast_Shoot", 0.3f },
		{ "Spellcasting", 0.45f }, { "Spellcast_Raise", 0.9f },
		{ "Bufalo_Cabecada", 0.4f },   // feita no Blender: cabecada no quadro 12 de 27 (30 fps)
		{ "Corneta_Guerra", 0.3f },    // feita no Blender: grito no quadro 9 de 22
		{ "Golpe_Terra", 0.333f },     // feita no Blender: machado bate no chao no quadro 10 de 28
		{ "Spark_Disparo", 0.133f },   // feitas no Blender: estocada do cajado no quadro 4 de 12
		{ "Spark_Feixe", 0.3f },       // solta o feixe no quadro 9 de 22
		{ "Spark_Onda", 0.3f },        // varrida passa pela frente no quadro 9 de 18 (Relampago e Ruptura tem varios golpes: tocam esticadas)
		// Cavaleiro: clipes do Mixamo assados no esqueleto do KayKit (Herois/Editor/CavaleiroLutaSetup); evento OnImpacto do clipe original
		{ "Cavaleiro_Ataque1", 0.7f }, { "Cavaleiro_Ataque2", 0.333f }, { "Cavaleiro_Ataque3", 0.367f }, { "Cavaleiro_Ataque4", 0.167f },
		{ "Cavaleiro_GolpeChao", 1.267f },
	};

	// velocidade natural de cada clipe de locomocao (m/s, medida no pe de apoio no Blender): o clipe toca na
	// velocidade real / natural para o pe nao escorregar no chao
	private static readonly Dictionary<string, float> GroundSpeed = new Dictionary<string, float>
	{
		{ "Running_A", 3.72f }, { "Running_Strafe_Left", 3.44f }, { "Running_Strafe_Right", 3.39f }, { "Walking_Backwards", 0.81f },
		{ "Correr", 4.58f }, { "Axie_Correr", 4.58f }, { "Correr_Tras", 4f }, { "Axie_Correr_Tras", 4f },
		{ "Axie_Lado_E", 3.44f }, { "Axie_Lado_D", 3.39f },
		{ "Cavaleiro_Correr", CavaleiroCorrer },
	};
	private const float CavaleiroCorrer = 1.79f;   // medido no pe de apoio do clipe assado (CavaleiroLutaSetup); a corrida do Mixamo e curta
	private bool m_ultHitCharge;           // EnableHitCharge: so o primeiro acerto de cada skill carrega

	public Vector3 Position => go.transform.position;
	public bool IsAlive => state != State.Dead;
	public bool IsStunned => state == State.Controlled;          // HasMotionFactor: nenhum controle deixa agir
	public MotionControlType CurrentControl => m_mcType;
	public bool CanAct => state == State.Idle && !IsStunned;
	public bool IsBusy => state == State.Casting || state == State.Recovering;
	public string CurrentSkillName => m_sd != null ? m_sd.name : string.Empty;
	public SkillDef CurrentSkill => m_sd;
	public int ComboStep => m_comboTimer > 0f ? m_comboStep : 0;
	public bool UltReady => ultCharge >= def.ultMaxCharge;           // CheckActivate
	public float UltPercent => Mathf.Clamp01(ultCharge / def.ultMaxCharge);
	public Vector3 CurrentAim => m_aim;
	public float CastProgress => m_sd != null && state == State.Casting ? m_stateTime / Mathf.Max(0.01f, m_sd.windup) : 0f;

	// IActor
	public XModuleActor.CharacterStatus OriginalStatus => m_original;
	public CharStatus Status => status;
	public bool IsDeathDoor() => hp > 0f && hp <= maxHp * 0.2f;

	public Fighter(FighterDef def, Vector3 spawn, Arena arena)
	{
		this.def = def;
		this.arena = arena;
		m_spawn = spawn;
		def.applyStats(baseStatus);
		status.Copy(baseStatus);
		maxHp = status.MaxHP.Calc();
		hp = maxHp;
		cooldowns = new float[UltSlot + 1];   // lugares fixos: 0 basico, 1..3 skills (pode faltar), 4 esquiva, 5 ultimate

		go = new GameObject(def.name);
		if (def.model != null)
		{
			// personagem KayKit: pivot nos pes, o centro do lutador fica 1m acima
			GameObject visual = Object.Instantiate(def.model, go.transform);
			visual.transform.localPosition = new Vector3(0f, -Arena.CenterHeight, 0f);
			foreach (Transform t in visual.GetComponentsInChildren<Transform>(true))
			{
				if (System.Array.IndexOf(def.hiddenParts, t.name) >= 0)
				{
					t.gameObject.SetActive(false);
				}
			}
			m_renderers = visual.GetComponentsInChildren<Renderer>();
			m_anim = visual.GetComponent<Animation>();
			AddExtraClips(def);
			m_visual = visual.transform;
			m_trail = CreateWeaponTrail(visual, def.weapon, def.color);
		}
		else
		{
			GameObject capsule = GameObject.CreatePrimitive(PrimitiveType.Capsule);
			Object.DestroyImmediate(capsule.GetComponent<Collider>());
			capsule.transform.SetParent(go.transform, false);
			capsule.GetComponent<Renderer>().material = Arena.MakeMaterial(def.color);
			m_renderers = new[] { capsule.GetComponent<Renderer>() };
		}
		m_baseColors = new Color[m_renderers.Length];
		for (int i = 0; i < m_renderers.Length; i++)
		{
			m_baseColors[i] = m_renderers[i].material.color;
		}
		m_hitFlash = go.AddComponent<HitFlash>();
		m_hitFlash.Init(m_renderers);
		Respawn();
	}

	public void Respawn()
	{
		ClearBuffs();
		hp = maxHp;
		state = State.Idle;
		m_sd = null;
		m_slot = -1;
		m_mcType = MotionControlType.None;
		m_lift = 0f;
		m_comboTimer = 0f;
		m_queuedSlot = -1;
		invulnerable = false;
		for (int i = 0; i < cooldowns.Length; i++)
		{
			cooldowns[i] = 0f;
		}
		go.transform.position = arena.Snap(m_spawn);
		go.SetActive(true);
		m_getUp = 0f;
		m_cheer = 0f;
		if (m_visual != null)
		{
			m_visual.localPosition = new Vector3(0f, -Arena.CenterHeight, 0f);
			m_visual.localScale = Vector3.one;
		}
		m_animName = null;
		PlayLoop(def.animIdle);
	}

	// null = lugar vazio (heroi com menos de 3 skills)
	public SkillDef SlotSkill(int slot) => slot < def.skills.Length ? def.skills[slot] : slot == UltSlot ? def.ultimate : slot == DodgeSlot ? def.dodge : null;

	public float CooldownRatio(int slot)
	{
		SkillDef sd = SlotSkill(slot);
		if (sd == null)
		{
			return 0f;
		}
		float cd = slot == 0 ? 0f : sd.cooldown;
		return cd <= 0f ? 0f : Mathf.Clamp01(cooldowns[slot] / cd);
	}

	private CSSkillInfo InfoFor(SkillDef sd)
	{
		if (!m_infos.TryGetValue(sd, out CSSkillInfo info))
		{
			info = sd.BuildInfo(100 + m_infos.Count);
			m_infos[sd] = info;
		}
		return info;
	}

	// skill que sai no slot agora (o slot 0 avanca no combo dentro da janela)
	private SkillDef ResolveSlot(int slot)
	{
		SkillDef sd = SlotSkill(slot);
		if (slot == 0 && sd.combo != null && m_comboTimer > 0f && m_comboStep > 0 && m_comboStep <= sd.combo.Length)
		{
			return sd.combo[m_comboStep - 1];
		}
		return sd;
	}

	// tempo que falta para a acao atual terminar
	private float RemainingAction()
	{
		if (m_sd == null)
		{
			return 0f;
		}
		float release = m_sd.windup > 0f ? m_sd.windup : 0.2f;
		return state == State.Casting ? release - m_stateTime + m_sd.recovery : m_sd.recovery - m_stateTime;
	}

	// slot 0..3 = skills, 4 = esquiva, 5 = ultimate. Ocupado: esquiva cancela; perto do fim, entra na fila.
	public bool TryUseSkill(int slot, Vector3 aim)
	{
		if (!IsAlive || slot < 0 || slot >= cooldowns.Length || IsStunned || SlotSkill(slot) == null)
		{
			return false;
		}
		if (IsBusy)
		{
			if (slot == DodgeSlot && m_sd != null && m_sd.cancelable && cooldowns[slot] <= 0f && m_slot != DodgeSlot)
			{
				CancelCurrent();
			}
			else
			{
				if (RemainingAction() <= QueueWindow)
				{
					m_queuedSlot = slot;
					m_queuedAim = aim;
					m_queuedTtl = QueueWindow + 0.1f;
				}
				return false;
			}
		}
		if (!CanAct || cooldowns[slot] > 0f || (slot == UltSlot && (def.ultimate == null || !UltReady)))
		{
			return false;
		}
		Execute(slot, aim);
		return true;
	}

	private void CancelCurrent()
	{
		state = State.Idle;
		m_sd = null;
		m_slot = -1;
		invulnerable = false;
	}

	private void Execute(int slot, Vector3 aim)
	{
		SkillDef sd = ResolveSlot(slot);
		if (slot == 0)
		{
			SkillDef first = SlotSkill(0);
			bool hasCombo = first.combo != null && first.combo.Length > 0;
			m_comboStep = hasCombo && m_comboTimer > 0f ? (m_comboStep + 1) % (first.combo.Length + 1) : 1;
			if (!hasCombo)
			{
				m_comboStep = 0;
			}
			m_comboTimer = 0f;
		}
		m_sd = sd;
		m_slot = slot;
		m_aim = aim;
		m_dashLen = sd.dashDistance;
		if (sd.dashStop > 0f && opponent != null)
		{
			// avanca ate ficar a dashStop do inimigo (nunca mais que dashDistance; parado se ja esta perto)
			Vector3 to = opponent.Position - Position;
			to.y = 0f;
			m_dashLen = Mathf.Clamp(to.magnitude - sd.dashStop, 0f, sd.dashDistance);
			if (to.sqrMagnitude > 0.01f)
			{
				aim = opponent.Position;
			}
		}
		Vector3 dir = aim - Position;
		dir.y = 0f;
		if (dir.sqrMagnitude > 0.01f)
		{
			facing = dir.normalized;
		}
		cooldowns[slot] = sd.cooldown;
		m_hitsDone = 0;
		m_ultHitCharge = slot != UltSlot;
		if (slot == UltSlot)
		{
			ultCharge = 0f;                // Use()
			onUltimate?.Invoke(this, sd);
		}
		PlaySkillAnim(sd);
		Vector3 startCenter = Position;
		if (sd.areaAtTarget)
		{
			Vector3 to = aim - Position;
			to.y = 0f;
			startCenter = Position + Vector3.ClampMagnitude(to, sd.castRange);
		}
		onSkillStart?.Invoke(this, sd, startCenter);
		TriggerProcs(sd, ProcTimingType.None, null);
		state = State.Casting;
		m_stateTime = 0f;
		invulnerable = slot == DodgeSlot;
		if (slot == DodgeSlot)
		{
			m_ghosts = 0;
			onDodgeFx?.Invoke(this, 0);
		}
	}

	public void Move(Vector3 dir, float dt, bool keepFacing = false)
	{
		if (dir.sqrMagnitude < 0.0001f || !IsAlive || IsStunned)
		{
			return;
		}
		dir.y = 0f;
		dir.Normalize();
		if (CanAct)
		{
			if (!keepFacing)
			{
				facing = dir;
			}
			// de lado um pouco mais lento, de costas bem mais lento
			float angle = Vector3.Angle(facing, dir);
			float mul = angle < 50f ? 1f : angle > 130f ? 0.7f : 0.85f;
			TryMoveTo(Position + dir * MoveSpeed * mul * dt);
			m_moved = true;
			m_moveDir = dir;
			m_cheer = 0f;
		}
		else if (IsBusy && m_sd != null && m_sd.movable)
		{
			TryMoveTo(Position + dir * MoveSpeed * 0.5f * dt);
		}
	}

	// gira para um ponto sem andar (mira do jogador parado)
	public void FaceTowards(Vector3 point)
	{
		if (!CanAct)
		{
			return;
		}
		Vector3 d = point - Position;
		d.y = 0f;
		if (d.sqrMagnitude > 0.04f)
		{
			facing = d.normalized;
		}
	}

	public void Nudge(Vector3 delta)
	{
		if (IsAlive && state != State.Controlled)
		{
			TryMoveTo(Position + delta);
		}
	}

	private void TryMoveTo(Vector3 target)
	{
		if (arena.TryGetFloor(target, Position.y, out Vector3 snapped) && !arena.IsBlocked(Position, snapped))
		{
			go.transform.position = snapped;
		}
	}

	public void Tick(float dt)
	{
		for (int i = 0; i < cooldowns.Length; i++)
		{
			cooldowns[i] = Mathf.Max(0f, cooldowns[i] - dt);
		}
		m_comboTimer = Mathf.Max(0f, m_comboTimer - dt);
		passiveTimer = Mathf.Max(0f, passiveTimer - dt);
		m_queuedTtl -= dt;
		if (!Application.isPlaying)
		{
			m_hitFlash.Tick(dt);
		}
		UpdateBuffs(dt);
		for (int i = 0; i < m_renderers.Length; i++)
		{
			Color baseColor = m_baseColors[i];
			m_renderers[i].material.color = IsDeathDoor() ? Color.Lerp(baseColor, new Color(0.5f, 0.1f, 0.1f), 0.35f) : baseColor;
		}

		m_punch = Mathf.Max(0f, m_punch - dt * 6f);
		if (m_visual != null)
		{
			m_visual.localScale = Vector3.one * (1f + 0.12f * m_punch);
		}
		if (m_trail != null)
		{
			m_trail.emitting = (state == State.Casting || state == State.Recovering) && m_slot != DodgeSlot;
		}
		if (state == State.Dead)
		{
			m_stateTime += dt;
			if (m_visual != null && m_stateTime > 1.2f)
			{
				m_visual.localPosition = new Vector3(0f, -Arena.CenterHeight - Mathf.Clamp01((m_stateTime - 1.2f) / 0.8f) * 1.2f, 0f);
			}
			if (m_stateTime >= 2f && go.activeSelf)
			{
				go.SetActive(false);
			}
			if (m_stateTime >= 3f)
			{
				Respawn();
			}
			UpdateAnimation(dt);
			return;
		}
		if (state == State.Controlled)
		{
			UpdateControl(dt);
		}
		else if (state == State.Casting)
		{
			UpdateCast(dt);
		}
		else if (state == State.Recovering)
		{
			m_stateTime += dt;
			if (m_stateTime >= m_sd.recovery)
			{
				FinishAction();
			}
		}
		// comando na fila sai assim que der
		if (CanAct && m_queuedSlot >= 0)
		{
			int slot = m_queuedSlot;
			m_queuedSlot = -1;
			if (m_queuedTtl > 0f && cooldowns[slot] <= 0f)
			{
				Execute(slot, m_queuedAim);
			}
		}
		go.transform.rotation = Quaternion.Slerp(go.transform.rotation, Quaternion.LookRotation(facing), Mathf.Clamp01(dt * 18f));
		if (state == State.Idle && !IsStunned)
		{
			if (m_moved)
			{
				string loco = LocomotionClip();
				PlayLoop(loco);
				if (m_anim != null && m_anim[loco] != null && GroundSpeed.TryGetValue(loco, out float natural))
				{
					m_anim[loco].speed = Mathf.Clamp(MoveSpeed / natural, 0.6f, 1.9f);
				}
			}
			else if (m_cheer > 0f)
			{
				m_cheer -= dt;
				if (m_animName != def.animCheer)
				{
					PlayOnce(def.animCheer, 1.6f);
				}
			}
			else
			{
				PlayLoop(def.animIdle);
			}
		}
		m_moved = false;
		UpdateAnimation(dt);
	}

	private void FinishAction()
	{
		if (m_slot == 0)
		{
			m_comboTimer = SlotSkill(0).comboWindow;
		}
		state = State.Idle;
		m_sd = null;
		m_slot = -1;
		invulnerable = false;
	}

	private bool m_heavyHit;

	private string LocomotionClip()
	{
		float angle = Vector3.SignedAngle(facing, m_moveDir, Vector3.up);
		float abs = Mathf.Abs(angle);
		if (abs < 50f)
		{
			return def.animRun;
		}
		if (abs > 130f)
		{
			return def.animBackwards;
		}
		return angle > 0f ? def.animStrafeRight : def.animStrafeLeft;
	}

	// animacoes feitas no Blender (Resources/Anim, menu Arena Masters/Animacoes/Converter do Blender) que o modelo nao tem
	private void AddExtraClips(FighterDef def)
	{
		if (m_anim == null)
		{
			return;
		}
		List<SkillDef> all = new List<SkillDef>(def.skills) { def.dodge, def.ultimate };
		for (int i = 0; i < all.Count; i++)
		{
			SkillDef sd = all[i];
			if (sd == null)
			{
				continue;
			}
			if (sd.combo != null)
			{
				all.AddRange(sd.combo);
			}
			AddExtraClip(sd.anim);
		}
		foreach (string name in new[] { def.animIdle, def.animRun, def.animStrafeLeft, def.animStrafeRight, def.animBackwards, def.animHit, def.animHitHeavy })
		{
			AddExtraClip(name);
		}
	}

	private void AddExtraClip(string name)
	{
		if (!string.IsNullOrEmpty(name) && m_anim[name] == null)
		{
			AnimationClip clip = Resources.Load<AnimationClip>("Anim/" + name);
			if (clip != null)
			{
				m_anim.AddClip(clip, name);
			}
		}
	}

	// toca a animacao da skill acelerada para o impacto do clipe cair exatamente no fim do windup
	private void PlaySkillAnim(SkillDef sd)
	{
		float release = sd.windup > 0f ? sd.windup : 0.2f;   // igual ao UpdateCast (esquiva: windup 0 = 0,2 s de corrida)
		float total = Mathf.Max(0.2f, release + (sd.hitCount - 1) * sd.hitInterval + sd.recovery);
		if (m_anim == null || sd.anim == null || m_anim[sd.anim] == null)
		{
			return;
		}
		if (sd.hitCount == 1 && sd.windup > 0.05f && ImpactTime.TryGetValue(sd.anim, out float impact))
		{
			AnimationState st = m_anim[sd.anim];
			st.wrapMode = WrapMode.ClampForever;
			st.speed = Mathf.Clamp(impact / sd.windup, 0.4f, 4f);
			st.time = 0f;
			m_anim.CrossFade(sd.anim, 0.05f);
			m_animName = sd.anim;
			return;
		}
		PlayOnce(sd.anim, total);
	}

	private static TrailRenderer CreateWeaponTrail(GameObject visual, string weapon, Color color)
	{
		if (string.IsNullOrEmpty(weapon))
		{
			return null;
		}
		Transform w = null;
		foreach (Transform t in visual.GetComponentsInChildren<Transform>(true))
		{
			if (t.name == weapon)
			{
				w = t;
				break;
			}
		}
		MeshFilter mf = w != null ? w.GetComponent<MeshFilter>() : null;
		if (mf == null || mf.sharedMesh == null)
		{
			return null;
		}
		// ponta da arma: extremo do maior eixo da malha
		Bounds b = mf.sharedMesh.bounds;
		Vector3 e = b.extents;
		Vector3 axis = e.x >= e.y && e.x >= e.z ? Vector3.right * e.x : e.y >= e.z ? Vector3.up * e.y : Vector3.forward * e.z;
		GameObject tip = new GameObject("rastro_arma");
		tip.transform.SetParent(w, false);
		tip.transform.localPosition = b.center + axis * 0.9f;
		TrailRenderer tr = tip.AddComponent<TrailRenderer>();
		tr.time = 0.16f;
		tr.minVertexDistance = 0.05f;
		tr.widthCurve = new AnimationCurve(new Keyframe(0f, 0.35f), new Keyframe(1f, 0f));
		tr.material = Vfx.ParticleMaterial(Resources.Load<Texture2D>("VFX/trace_04"), true);
		Color c = Color.Lerp(color, Color.white, 0.4f);
		Gradient g = new Gradient();
		g.SetKeys(new[] { new GradientColorKey(c, 0f), new GradientColorKey(color, 1f) },
			new[] { new GradientAlphaKey(0.9f, 0f), new GradientAlphaKey(0f, 1f) });
		tr.colorGradient = g;
		tr.emitting = false;
		return tr;
	}

	// ---------- animacao (clipes Legacy do KayKit) ----------

	private void PlayLoop(string clip)
	{
		if (m_anim == null || clip == null || m_animName == clip || m_anim[clip] == null)
		{
			return;
		}
		m_anim[clip].wrapMode = WrapMode.Loop;
		m_anim[clip].speed = 1f;
		m_anim.CrossFade(clip, 0.12f);
		m_animName = clip;
	}

	// toca o clipe uma vez, esticado/comprimido para durar 'duration' segundos
	private void PlayOnce(string clip, float duration)
	{
		if (m_anim == null || clip == null || m_anim[clip] == null)
		{
			return;
		}
		AnimationState st = m_anim[clip];
		st.wrapMode = WrapMode.ClampForever;
		st.speed = duration > 0f ? st.length / duration : 1f;
		st.time = 0f;
		m_anim.CrossFade(clip, 0.06f);
		m_animName = clip;
	}

	private void UpdateAnimation(float dt)
	{
		// fora do Play (captura em batch) o Animation nao avanca sozinho
		if (m_anim == null || Application.isPlaying)
		{
			return;
		}
		foreach (AnimationState st in m_anim)
		{
			if (st.enabled)
			{
				st.time += dt * st.speed;
			}
		}
		m_anim.Sample();
	}

	private void UpdateCast(float dt)
	{
		SkillDef sd = m_sd;
		m_stateTime += dt;
		// avanco: durante o preparo, ou por dashTime segundos (avanco que acerta pelo caminho)
		float dashT = sd.dashTime > 0f ? sd.dashTime : Mathf.Max(0.15f, sd.windup > 0f ? sd.windup : 0.2f);
		if (m_dashLen > 0f && m_stateTime - dt < dashT)
		{
			TryMoveTo(Position + facing * (m_dashLen / dashT) * dt);
		}
		float release = sd.windup > 0f ? sd.windup : 0.2f;
		if (m_slot == DodgeSlot)
		{
			// 3 imagens fantasma espalhadas pela corrida da esquiva
			while (m_ghosts < 3 && m_stateTime >= m_ghosts * release / 3f)
			{
				m_ghosts++;
				onDodgeFx?.Invoke(this, m_ghosts);
			}
		}
		if (m_stateTime < release)
		{
			return;
		}
		if (sd.blinkDistance > 0f)
		{
			// teleporte so para chao ligado ao atual (nunca para uma ilha isolada); encurta ate achar
			int region = arena.RegionOf(Position);
			for (float d = sd.blinkDistance; d > 0.9f; d -= 1.5f)
			{
				Vector3 dest = Position + facing * d;
				if (arena.TryGetFloor(dest, Position.y, out Vector3 snapped) && arena.RegionOf(snapped) == region)
				{
					go.transform.position = snapped;
					break;
				}
			}
		}
		if (m_slot != DodgeSlot)
		{
			// golpes repetidos: o k-esimo sai em windup + k*intervalo
			while (m_hitsDone < sd.hitCount && m_stateTime >= release + m_hitsDone * sd.hitInterval)
			{
				ReleaseHit(sd, InfoFor(sd));
				m_hitsDone++;
			}
			if (m_hitsDone < sd.hitCount)
			{
				return;
			}
		}
		if (m_slot == DodgeSlot)
		{
			onDodgeFx?.Invoke(this, 4);
		}
		state = State.Recovering;
		m_stateTime = 0f;
	}

	private void ReleaseHit(SkillDef sd, CSSkillInfo info)
	{
		if (sd.projectileSpeed > 0f)
		{
			onSkillFx?.Invoke(this, sd, Position);
			for (int i = 0; i < sd.projectileCount; i++)
			{
				float yaw = (i - (sd.projectileCount - 1) * 0.5f) * sd.projectileSpread;
				Vector3 dir = Quaternion.Euler(0f, yaw, 0f) * facing;
				onProjectile?.Invoke(this, sd, info, Position + facing * 0.7f + Vector3.up * 0.25f, dir);
			}
			return;
		}
		Vector3 center = Position;
		if (sd.areaAtTarget)
		{
			Vector3 to = m_aim - Position;
			to.y = 0f;
			center = Position + Vector3.ClampMagnitude(to, sd.castRange);
			if (sd.areaJitter > 0f)
			{
				Vector2 r = Random.insideUnitCircle * sd.areaJitter;
				center += new Vector3(r.x, 0f, r.y);
			}
		}
		onSkillFx?.Invoke(this, sd, center);
		if (sd.rockWall)
		{
			// linha de pedras ao longo da onda de choque, bloqueando a passagem por 4s
			for (float d = 2f; d <= sd.range; d += 1.6f)
			{
				arena.blockers.Add((Position + facing * d, 0.75f, 4f));
			}
		}
		if (sd.damageRatio <= 0f)
		{
			return;                        // skill de efeito proprio (barreira, buff)
		}
		Fighter target = opponent;
		if (target == null || !target.IsAlive || target.invulnerable)
		{
			return;
		}
		Vector3 delta = target.Position - center;
		delta.y = 0f;
		if (Mathf.Abs(target.Position.y - center.y) > 2.5f)
		{
			return;
		}
		if (sd.lineWidth > 0f)
		{
			// retangulo a frente: distancia ao longo da linha e afastamento lateral
			float along = Vector3.Dot(delta, facing);
			float side = Vector3.Cross(facing, delta).y;
			if (along < -0.5f || along > sd.range + 0.5f || Mathf.Abs(side) > sd.lineWidth * 0.5f + 0.4f)
			{
				return;
			}
			Vector3 sideways = Vector3.Cross(Vector3.up, facing) * (side >= 0f ? -1f : 1f);
			ResolveHit(target, sd, info, sd.pushSideways ? sideways : facing);
			return;
		}
		if (delta.magnitude > sd.range + 0.5f)
		{
			return;
		}
		if (sd.angle < 360f && !sd.areaAtTarget && Vector3.Angle(facing, delta) > sd.angle * 0.5f)
		{
			return;
		}
		// puxao: direcao (nao normalizada) do alvo para o centro
		ResolveHit(target, sd, info, sd.pullDistance > 0f ? -delta : (delta.sqrMagnitude > 0.01f ? delta.normalized : facing));
	}

	// Regras reconstruidas do jogo: XCalculator.CheckHit / CheckCritical / CalcSkillDamage / CalcCriticalDamageRatio
	public void ResolveHit(Fighter target, SkillDef sd, CSSkillInfo info, Vector3 pushDir)
	{
		XCalculator.SkillParam param = new XCalculator.SkillParam();
		param.attacker = this;
		param.victim = target;
		param.skillInfo = info;
		if (!XCalculator.CheckHit(param))
		{
			onPopup?.Invoke(target, "MISS", Color.gray);
			return;
		}
		int damage = XCalculator.CalcSkillDamage(param, 1f, out float pure);
		bool critical = XCalculator.CheckCritical(param);
		if (critical)
		{
			damage = (int)(damage * XCalculator.CalcCriticalDamageRatio(param, 1.5f));
		}
		onImpact?.Invoke(sd, critical);
		if (m_ultHitCharge)
		{
			ultCharge = Mathf.Min(def.ultMaxCharge, ultCharge + sd.ultimateCharge);   // ChargeOnHit(skill.ultimateCharge)
			m_ultHitCharge = false;
		}
		target.ChargeOnBeaten(damage);
		target.TakeDamage(this, damage, critical, pushDir, sd);
		def.passiveOnHit?.Invoke(this, target, sd, critical);
		onDealtHit?.Invoke(this, target, sd, damage);
		if (target.IsAlive)
		{
			TriggerProcs(sd, ProcTimingType.Hit, target);
			if (critical)
			{
				TriggerProcs(sd, ProcTimingType.CriHit, target);
			}
		}
	}

	// ChargeOnBeaten: min(dano/vidaMax * 0.2, 0.05) da barra por golpe recebido
	public void ChargeOnBeaten(int damage)
	{
		if (def.ultimate == null || (m_slot == UltSlot && IsBusy))
		{
			return;
		}
		ultCharge = Mathf.Min(def.ultMaxCharge, ultCharge + Mathf.Min(damage / maxHp * 0.2f, 0.05f) * def.ultMaxCharge);
	}

	public void TakeDamage(Fighter from, int damage, bool critical, Vector3 pushDir, SkillDef sd)
	{
		damage = AbsorbWithShield(damage);
		hp -= damage;
		m_hitFlash.Play();
		m_punch = critical ? 1.6f : 1f;
		m_heavyHit = critical || damage > maxHp * 0.06f;
		onHitFx?.Invoke(this, critical, sd);
		onPopup?.Invoke(this, critical ? damage + "!" : damage.ToString(), critical ? new Color(1f, 0.85f, 0.1f) : Color.white);
		if (hp <= 0f)
		{
			Die(from);
			return;
		}
		FakeBeaten();
		if (IsBusy && m_sd != null && m_sd.superArmor)
		{
			return;
		}
		// um controle por acerto, vindo da skill (o buff MF do original); 'pushDir' = direcao Forward (vitima - fonte)
		Vector3 source = from != null ? from.Position : Position - pushDir;
		if (sd.pullDistance > 0f)
		{
			// pushDir aqui e o vetor ate o centro da area: a fonte do puxao e o centro
			StartMotionControl(MotionControlType.Pull, pushDir, sd.pullDistance, 0f, Position + pushDir);
		}
		else if (sd.throwDistance > 0f)
		{
			StartMotionControl(MotionControlType.Throw, pushDir, sd.throwDistance, 0f, source);
		}
		else if (sd.throwupDistance > 0f)
		{
			StartMotionControl(MotionControlType.Throwup, pushDir, sd.throwupDistance, 0f, source);
		}
		else if (sd.knockbackDistance > 0f && sd.pushSideways)
		{
			StartMotionControl(MotionControlType.Split, pushDir, sd.knockbackDistance, 0f, source);
		}
		else if (sd.airborneHeight > 0f)
		{
			StartMotionControl(MotionControlType.Airborne, pushDir, sd.airborneHeight, 0f, source);
		}
		else if (sd.knockbackDistance > 0f)
		{
			StartMotionControl(MotionControlType.Knockback, pushDir, sd.knockbackDistance, 0f, source);
		}
		else if (sd.beatenDuration > 0f && state != State.Controlled && status.Toughness.Calc() < 1f)
		{
			// Beaten so quando nenhum controle esta ativo (XModuleBuff.OnHitMe); tempo cru, sem tenacidade
			StartMotionControl(MotionControlType.Beaten, pushDir, sd.beatenDistance, sd.beatenDuration, source);
		}
	}

	private int AbsorbWithShield(int damage)
	{
		int absorbed = 0;
		for (int i = buffs.Count - 1; i >= 0 && damage > 0; i--)
		{
			ActiveBuff b = buffs[i];
			if (b.shield <= 0f)
			{
				continue;
			}
			float take = Mathf.Min(b.shield, damage);
			b.shield -= take;
			damage -= (int)take;
			absorbed += (int)take;
			if (b.shield <= 0f)
			{
				RemoveBuff(b);
			}
		}
		if (absorbed > 0)
		{
			onPopup?.Invoke(this, "(" + absorbed + ")", new Color(1f, 0.85f, 0.4f));
		}
		return damage;
	}

	public bool HasBuff(BuffDef buff) => buffs.Exists(b => b.def == buff);

	private void Die(Fighter killer)
	{
		hp = 0f;
		state = State.Dead;
		m_mcType = MotionControlType.None;
		m_lift = 0f;
		m_stateTime = 0f;
		if (killer != null && killer != this)
		{
			killer.kills++;
			killer.m_cheer = 1.6f;
		}
		onPopup?.Invoke(this, "K.O.", Color.red);
		PlayOnce(def.animDeath, 1.2f);
		onDeathFx?.Invoke(this);
		ClearBuffs(true);
	}

	// ---------- buffs ----------

	public float MoveSpeed
	{
		get
		{
			float slow = 0f;
			foreach (ActiveBuff b in buffs)
			{
				if (b.def.control == MotionControlType.Slow)
				{
					slow = Mathf.Max(slow, b.def.slowRatio);
				}
			}
			return def.moveSpeed * (1f + status.MovingSpeed.ratio) * (1f - slow);
		}
	}

	public bool HasControl(MotionControlType type)
	{
		foreach (ActiveBuff b in buffs)
		{
			if (b.def.control == type)
			{
				return true;
			}
		}
		return false;
	}

	private void TriggerProcs(SkillDef sd, ProcTimingType timing, Fighter target)
	{
		foreach (BuffProc proc in sd.procs)
		{
			if (proc.timing != timing || Random.Range(0, 100) >= proc.rate)
			{
				continue;
			}
			Fighter who = proc.onSelf ? this : target;
			who?.AddBuff(proc.buff, this);
		}
	}

	// Regras do XModuleBuff.GainBuff (0xB48D34), XBuff.Reapply (0x1A98F98), ApplyEraseBuff (0xB4C190), ApplyMF (0xB46454)
	public void AddBuff(BuffDef buff, Fighter source)
	{
		if (!IsAlive)
		{
			return;
		}
		// mesmo buff reaplicado: stack +1 ate o maximo e renova o tempo
		ActiveBuff existing = buffs.Find(b => b.def == buff);
		if (existing != null)
		{
			existing.stack = Mathf.Min(existing.stack + 1, buff.maxStack);
			existing.remaining = CalcDuration(buff);
			existing.tickDamage = Mathf.Max(1, Mathf.RoundToInt(maxHp * buff.dotPerMaxHp * existing.stack));
			existing.shield = maxHp * buff.shieldPerMaxHp;
			RecalcStatus();
			onPopup?.Invoke(this, buff.maxStack > 1 ? $"{buff.name} x{existing.stack}" : buff.name, buff.color);
			return;
		}
		// rank menor que um buff ativo da mesma linha e rejeitado
		if (buffs.Exists(b => b.def.line != null && b.def.line == buff.line && b.def.rank > buff.rank))
		{
			return;
		}
		float duration = CalcDuration(buff);
		if (duration < 0f)
		{
			onPopup?.Invoke(this, "IMUNE", Color.gray);
			return;
		}
		// o novo remove os buffs da mesma linha
		for (int i = buffs.Count - 1; i >= 0; i--)
		{
			if (buffs[i].def.line != null && buffs[i].def.line == buff.line)
			{
				RemoveBuff(buffs[i]);
			}
		}
		// so um controle de movimento por vez: o novo libera o anterior
		if (buff.control != MotionControlType.None)
		{
			for (int i = buffs.Count - 1; i >= 0; i--)
			{
				if (buffs[i].def.control != MotionControlType.None)
				{
					RemoveBuff(buffs[i]);
				}
			}
		}
		ActiveBuff active = new ActiveBuff { def = buff, source = source, remaining = duration };
		active.tickDamage = Mathf.Max(1, Mathf.RoundToInt(maxHp * buff.dotPerMaxHp));
		active.shield = maxHp * buff.shieldPerMaxHp;
		buffs.Add(active);
		RecalcStatus();
		if (buff.control == MotionControlType.Stun || buff.control == MotionControlType.Paralysis || buff.control == MotionControlType.Root)
		{
			StartMotionControl(buff.control, Vector3.zero, 0f, duration, Position);
		}
		onBuffAdded?.Invoke(this, active);
		onPopup?.Invoke(this, buff.name, buff.color);
	}

	private float CalcDuration(BuffDef buff)
	{
		if (buff.control == MotionControlType.Stun || buff.control == MotionControlType.Beaten)
		{
			float toughness = status.Toughness.Calc();
			if (toughness >= 1f)
			{
				return -1f;
			}
			return XCalculator.CalcMotionControlTime(buff.duration, toughness);
		}
		return buff.duration;
	}

	private void RemoveBuff(ActiveBuff b)
	{
		buffs.Remove(b);
		RecalcStatus();
		// o fim do buff MF libera o controle (ReleaseBuffWithTrigging -> ReleaseMotionControl)
		if (b.def.control != MotionControlType.None && b.def.control == m_mcType && state == State.Controlled)
		{
			m_mcElapsed = m_mcTotal;
		}
		onBuffRemoved?.Invoke(this, b);
	}

	private void ClearBuffs(bool onlyClearOnDie = false)
	{
		for (int i = buffs.Count - 1; i >= 0; i--)
		{
			if (!onlyClearOnDie || buffs[i].def.clearOnDie)
			{
				RemoveBuff(buffs[i]);
			}
		}
	}

	// status efetivo = base + atributos de cada buff (CharStatus.Merge do jogo)
	private void RecalcStatus()
	{
		status.Copy(baseStatus);
		foreach (ActiveBuff b in buffs)
		{
			status.Merge(b.def.stats, b.stack);
		}
	}

	private void UpdateBuffs(float dt)
	{
		for (int i = buffs.Count - 1; i >= 0 && i < buffs.Count; i--)
		{
			ActiveBuff b = buffs[i];
			b.remaining -= dt;
			if (b.def.dotPerMaxHp > 0f || b.def.hotPerMaxHp > 0f)
			{
				b.tickTimer += dt;
				while (b.tickTimer >= b.def.period && IsAlive)
				{
					b.tickTimer -= b.def.period;
					if (b.def.dotPerMaxHp > 0f && !invulnerable)
					{
						hp -= b.tickDamage;
						onPopup?.Invoke(this, b.tickDamage.ToString(), b.def.color);
						if (hp <= 0f)
						{
							Die(b.source);
						}
					}
					if (b.def.hotPerMaxHp > 0f)
					{
						hp = Mathf.Min(maxHp, hp + maxHp * b.def.hotPerMaxHp);
					}
				}
			}
			if (!IsAlive)
			{
				return;
			}
			if (b.remaining <= 0f && buffs.Contains(b))
			{
				RemoveBuff(b);
			}
		}
	}

	// ---------- controle de movimento (XModuleAction / XMotionControl_*) ----------

	private static float OutSine(float x) => Mathf.Sin(Mathf.Clamp01(x) * Mathf.PI * 0.5f);
	private static float InSine(float x) => 1f - Mathf.Cos(Mathf.Clamp01(x) * Mathf.PI * 0.5f);
	private static float InQuad(float x) => Mathf.Clamp01(x) * Mathf.Clamp01(x);
	private static float OutQuad(float x) => 1f - (1f - Mathf.Clamp01(x)) * (1f - Mathf.Clamp01(x));

	// d = fMotionControlDistance; time so para Stun/Paralysis/Root/Beaten (duracao do buff/skill)
	public void StartMotionControl(MotionControlType type, Vector3 dir, float d, float time, Vector3 source)
	{
		if (!IsAlive)
		{
			return;
		}
		float weight = status.Weight.Calc();
		if ((type == MotionControlType.Airborne || type == MotionControlType.Pull) && weight >= 20f)
		{
			onPopup?.Invoke(this, "IMUNE", Color.gray);
			return;
		}
		dir.y = 0f;
		Vector3 flat = dir.sqrMagnitude > 0.0001f ? dir.normalized : -facing;
		float lift = m_lift;
		m_mcType = type;
		m_mcElapsed = 0f;
		m_mcSource = source;
		m_mcDir = flat;
		m_mcHSpeed = 0f;
		m_mcHeight = 0f;
		m_mcRise = 0f;
		m_mcLift0 = lift;
		m_mcDist = 0f;
		m_mcVSpeed = 0f;
		float knockTime = Mathf.Min(50f, (2f - weight / 10f) * d) / XGameConst.KNOCKBACK_SPEED;
		string anim = def.animHit;
		switch (type)
		{
			case MotionControlType.Beaten:
				m_mcTotal = time;
				m_mcDist = d;
				facing = -flat;                                  // LookAt: vira para quem bateu
				anim = m_heavyHit ? def.animHitHeavy : def.animHit;
				break;
			case MotionControlType.Knockback:
				m_mcTotal = knockTime;
				m_mcDist = Mathf.Min(50f, (2f - weight / 10f) * d);
				anim = def.animHitHeavy;
				break;
			case MotionControlType.Stun:
			case MotionControlType.Paralysis:
			case MotionControlType.Root:
				m_mcTotal = time;
				anim = type == MotionControlType.Root ? def.animIdle : def.animHit;
				break;
			case MotionControlType.Airborne:
				m_mcTotal = XCalculator.CalcMotionControlAirborneTime(d, weight);
				m_mcHeight = m_mcTotal * 0.5f * XGameConst.AIRBORNE_SPEED;
				m_mcVSpeed = XGameConst.AIRBORNE_SPEED;
				anim = def.animAirborne;
				break;
			case MotionControlType.Throwup:
			case MotionControlType.Split:
				m_mcHeight = knockTime * 0.5f * XGameConst.AIRBORNE_SPEED;
				m_mcVSpeed = XGameConst.AIRBORNE_SPEED;
				m_mcHSpeed = XGameConst.KNOCKBACK_SPEED;
				if (type == MotionControlType.Split)
				{
					m_mcDir = flat;                              // pushDir ja vem perpendicular a linha (Front: para fora)
				}
				anim = def.animAirborne;
				break;
			case MotionControlType.Throw:
				m_mcHeight = knockTime * 0.5f * XGameConst.THROW_VERTICAL_SPEED;
				m_mcVSpeed = XGameConst.THROW_VERTICAL_SPEED;
				m_mcHSpeed = XGameConst.THROW_HORIZENTAL_SPEED;
				anim = def.animAirborne;
				break;
			case MotionControlType.Pull:
				// ate encostar na fonte (descontando os raios), depois quica de volta um pouco
				Vector3 toSource = source - Position;
				toSource.y = 0f;
				m_mcDir = toSource.sqrMagnitude > 0.0001f ? toSource.normalized : flat;
				m_mcDist = Mathf.Max(0f, Mathf.Min(d, toSource.magnitude - 0.5f));
				m_mcPullDur = m_mcDist / PullSpeed;
				m_mcDist2 = Mathf.Clamp01(toSource.magnitude / Mathf.Max(0.01f, d)) * PullBounceDistance;
				m_mcTotal = Mathf.Max(m_mcPullDur + PullBounceTime, 0.15f) + 0.05f;
				m_mcHeight = PullBounceHeight;
				anim = def.animAirborne;
				break;
		}
		if (m_mcHeight > 0f)
		{
			// subida ate H na velocidade vertical (OutSine), queda em 0,9 * T/2 (InSine)
			float t = type == MotionControlType.Airborne ? m_mcTotal : knockTime;
			m_mcRise = type == MotionControlType.Pull ? m_mcPullDur : Mathf.Max(0f, m_mcHeight - lift) / m_mcVSpeed;
			m_mcFall = type == MotionControlType.Pull ? (m_mcTotal - m_mcPullDur) * 0.5f : 0.9f * t * 0.5f;
			if (type != MotionControlType.Airborne && type != MotionControlType.Pull)
			{
				m_mcTotal = m_mcRise + t * 0.5f;
				m_mcHSpeed = (t - m_mcRise) * m_mcHSpeed / Mathf.Max(0.0001f, t * 0.5f);
			}
		}
		else if (lift > 0f)
		{
			m_mcFall = lift / XGameConst.AIRBORNE_SPEED * 0.9f;   // controle sem subida: cai do ar
		}
		if (m_mcTotal <= 0f)
		{
			m_mcType = MotionControlType.None;
			return;
		}
		// o controle cancela a skill atual (XModuleSkill.OnMotionControlStart) e substitui o anterior
		state = State.Controlled;
		m_sd = null;
		m_slot = -1;
		m_queuedSlot = -1;
		invulnerable = false;
		m_wasAirborne = m_mcHeight > 0f && type != MotionControlType.Pull;
		m_getUp = 0f;
		if (type == MotionControlType.Paralysis)
		{
			FreezePose();
		}
		else
		{
			PlayOnce(anim, Mathf.Max(0.25f, m_mcTotal));
		}
	}

	// valores do XSystemData (cena) que nao estao no codigo: estimados
	private const float PullSpeed = 14f;
	private const float PullBounceTime = 0.25f;
	private const float PullBounceDistance = 0.5f;
	private const float PullBounceHeight = 0.4f;

	private void UpdateControl(float dt)
	{
		float prev = m_mcElapsed;
		m_mcElapsed += dt;
		float e = m_mcElapsed;
		Vector3 move = Vector3.zero;
		switch (m_mcType)
		{
			case MotionControlType.Beaten:
			case MotionControlType.Knockback:
				// curva de recuo: desacelera ate parar (beatenKnockbackCurve do XSystemData, aproximada por OutQuad)
				move = m_mcDir * m_mcDist * (OutQuad(e / m_mcTotal) - OutQuad(prev / m_mcTotal));
				break;
			case MotionControlType.Throwup:
			case MotionControlType.Split:
			case MotionControlType.Throw:
				if (e < m_mcTotal)
				{
					move = m_mcDir * m_mcHSpeed * dt;
				}
				break;
			case MotionControlType.Pull:
				if (e < m_mcPullDur)
				{
					move = m_mcDir * m_mcDist * (OutQuad(e / m_mcPullDur) - OutQuad(prev / m_mcPullDur));
				}
				else
				{
					float span = Mathf.Max(0.0001f, m_mcTotal - m_mcPullDur);
					move = -m_mcDir * m_mcDist2 * (OutQuad((e - m_mcPullDur) / span) - OutQuad(Mathf.Max(0f, prev - m_mcPullDur) / span));
				}
				break;
		}
		if (move.sqrMagnitude > 0f)
		{
			TryMoveTo(Position + move);
		}
		m_lift = ControlLift(e);
		Vector3 p = arena.Snap(Position);
		go.transform.position = p + Vector3.up * m_lift;
		if (m_mcType == MotionControlType.Paralysis)
		{
			FreezePose();
		}
		if (e < m_mcTotal)
		{
			return;
		}
		// fim: solta o controle (e o buff MF que o originou)
		MotionControlType ended = m_mcType;
		m_mcType = MotionControlType.None;
		m_lift = 0f;
		go.transform.position = p;
		for (int i = buffs.Count - 1; i >= 0; i--)
		{
			if (buffs[i].def.control == ended)
			{
				RemoveBuff(buffs[i]);
			}
		}
		if (m_wasAirborne && m_getUp <= 0f)
		{
			// caiu de um lancamento: levanta do chao (adicao do prototipo; o original volta direto ao idle)
			m_wasAirborne = false;
			m_getUp = 0.35f;
			m_mcType = MotionControlType.Root;
			m_mcElapsed = 0f;
			m_mcTotal = m_getUp;
			PlayOnce(def.animGetUp, m_getUp);
			return;
		}
		state = State.Idle;
		m_getUp = 0f;
	}

	// altura do modelo durante o controle (subida OutSine ate H, queda InSine; Pull: pulinho no quique)
	private float ControlLift(float e)
	{
		if (m_mcType == MotionControlType.Pull)
		{
			if (e < m_mcPullDur)
			{
				return 0f;
			}
			float half = Mathf.Max(0.0001f, (m_mcTotal - m_mcPullDur) * 0.5f);
			float u = e - m_mcPullDur;
			return u < half ? m_mcHeight * OutSine(u / half) : m_mcHeight * (1f - InSine((u - half) / (half * 0.9f)));
		}
		if (m_mcHeight > 0f)
		{
			if (e < m_mcRise)
			{
				float k = m_mcType == MotionControlType.Throw ? InQuad(e / m_mcRise) : OutSine(e / m_mcRise);
				return Mathf.Lerp(m_mcLift0, m_mcHeight, k);
			}
			float f = (e - m_mcRise) / Mathf.Max(0.0001f, m_mcFall);
			float down = m_mcType == MotionControlType.Throw ? OutQuad(f) : InSine(f);
			return m_mcHeight * (1f - down);
		}
		if (m_mcLift0 > 0f && m_mcFall > 0f)
		{
			return m_mcLift0 * (1f - InSine(e / m_mcFall));
		}
		return 0f;
	}

	// Paralysis: Animation.Stop no original, a pose congela
	private void FreezePose()
	{
		if (m_anim == null)
		{
			return;
		}
		foreach (AnimationState st in m_anim)
		{
			st.speed = 0f;
		}
	}

	// FakeBeaten: tranco visual aditivo (camada 10, clipe "beaten" encurtado) em todo dano, sem controle nem movimento
	private void FakeBeaten()
	{
		if (m_anim == null || m_mcType == MotionControlType.Paralysis || def.animHit == null || m_anim[def.animHit] == null)
		{
			return;
		}
		if (!m_fakeBeatenReady)
		{
			m_anim.AddClip(m_anim[def.animHit].clip, "fakebeaten");
			AnimationState fb = m_anim["fakebeaten"];
			fb.layer = 10;
			fb.blendMode = AnimationBlendMode.Additive;
			fb.wrapMode = WrapMode.Once;
			fb.speed = fb.length / 0.3f;
			m_fakeBeatenReady = true;
		}
		AnimationState st = m_anim["fakebeaten"];
		st.time = 0f;
		m_anim.Blend("fakebeaten", 0.5f, 0.05f);   // o clipe de golpe feito no Blender recua bastante
	}
}
