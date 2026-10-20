"""Controles de movimento seguindo o original (decomp/motion_rules.md): um controle por vez (XModuleAction),
tipos Beaten/Knockback/Stun/Paralysis/Root/Airborne/Throwup/Throw/Split/Pull com as trajetorias reais
e o FakeBeaten (tranco visual aditivo) no lugar do tranco que travava o lutador."""
ROOT = "unity6-project/Assets/Prototype/"


def patch(path, pairs):
    p = ROOT + path
    s = open(p, encoding="utf-8").read()
    for old, new in pairs:
        assert old in s, (path, old[:90])
        s = s.replace(old, new, 1)
    open(p, "w", encoding="utf-8").write(s)


def replace_between(path, start, end, new):
    p = ROOT + path
    s = open(p, encoding="utf-8").read()
    a = s.index(start)
    b = s.index(end, a) if end else len(s)
    s = s[:a] + new + s[b:]
    open(p, "w", encoding="utf-8").write(s)


patch("SkillDef.cs", [
    ("""	public float knockbackDistance;
	public float airborneHeight;""", """	// controles de movimento aplicados no acerto (distancia d do buff MF: fMotionControlDistance)
	public float knockbackDistance;   // Knockback: empurra para longe
	public float airborneHeight;      // Airborne: joga para cima no lugar
	public float throwupDistance;     // Throwup: joga para cima e para longe (8 u/s)
	public float throwDistance;       // Throw: arremesso baixo e longo (12,5 u/s)
	public float beatenDuration;      // Beaten: "apanhando" curto (CSSkillInfo.beatenDuration / beatenDistance)
	public float beatenDistance = 0.3f;"""),
    ("""	public bool stagger = true;       // o acerto faz o alvo vacilar (Beaten curto); desligado nos tiros basicos
""", ""),
])

patch("FighterDef.cs", [
    (""", stagger = false,""", ""","""),
])

# ---- Fighter ----
patch("Fighter.cs", [
    ("""	public bool IsStunned => HasControl(MotionControlType.Stun);""",
     """	public bool IsStunned => state == State.Controlled;          // HasMotionFactor: nenhum controle deixa agir
	public MotionControlType CurrentControl => m_mcType;"""),
    ("""		if (dir.sqrMagnitude < 0.0001f || !IsAlive || IsStunned || HasControl(MotionControlType.Root))""",
     """		if (dir.sqrMagnitude < 0.0001f || !IsAlive || IsStunned)"""),
    # stun/raiz/paralisia por buff viram controle de movimento
    ("""		if (buff.control == MotionControlType.Stun)
		{
			if (state != State.Controlled)
			{
				state = State.Idle;
			}
			m_sd = null;
			m_slot = -1;
			m_queuedSlot = -1;
			invulnerable = false;
			PlayOnce(def.animHit, duration);
		}""", """		if (buff.control == MotionControlType.Stun || buff.control == MotionControlType.Paralysis || buff.control == MotionControlType.Root)
		{
			StartMotionControl(buff.control, Vector3.zero, 0f, duration, Position);
		}"""),
    ("""	private void RemoveBuff(ActiveBuff b)
	{
		buffs.Remove(b);
		RecalcStatus();""", """	private void RemoveBuff(ActiveBuff b)
	{
		buffs.Remove(b);
		RecalcStatus();
		// o fim do buff MF libera o controle (ReleaseBuffWithTrigging -> ReleaseMotionControl)
		if (b.def.control != MotionControlType.None && b.def.control == m_mcType && state == State.Controlled)
		{
			m_mcElapsed = m_mcTotal;
		}"""),
    ("""	private void Die(Fighter killer)
	{
		hp = 0f;
		state = State.Dead;""", """	private void Die(Fighter killer)
	{
		hp = 0f;
		state = State.Dead;
		m_mcType = MotionControlType.None;
		m_lift = 0f;"""),
    ("""		m_airTime = 0f;
		m_controlTime = 0f;""", """		m_mcType = MotionControlType.None;
		m_lift = 0f;"""),
    ("""	private Vector3 m_pushDir;
	private float m_pushSpeed;
	private float m_controlTime;
	private float m_controlTotal;
	private float m_airTime;
	private float m_airTotal;
	private float m_airHeight;""", """	// controle de movimento atual (XMotionControlBase): tipo, tempos, direcao, distancias, subida/queda
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
	private float m_lift;                  // altura do modelo (DOTween no Y local do mesh no original)"""),
    ("""	private bool m_wasAirborne;""", """	private bool m_wasAirborne;
	private bool m_fakeBeatenReady;"""),
])

replace_between("Fighter.cs", """		if (IsBusy && m_sd != null && m_sd.superArmor)
		{
			return;
		}
		float weight = status.Weight.Calc();""", """	private int AbsorbWithShield(int damage)""", """		FakeBeaten();
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

""")

replace_between("Fighter.cs", """	// ---------- controle de movimento ----------""", None, """	// ---------- controle de movimento (XModuleAction / XMotionControl_*) ----------

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
		m_anim.Blend("fakebeaten", 0.7f, 0.05f);
	}
}
""")

# limpar referencias antigas: StartControl/m_air*/m_control* restantes
p = ROOT + "Fighter.cs"
s = open(p, encoding="utf-8").read()
for name in ["StartControl(", "m_airTime", "m_airTotal", "m_airHeight", "m_controlTime", "m_controlTotal", "m_pushSpeed", "m_pushDir"]:
    if name in s:
        import re
        print("RESTANTE:", name, [m.start() for m in re.finditer(re.escape(name), s)][:5])
print("ok")
