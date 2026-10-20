"""Liga os efeitos de particula (Vfx.cs) ao prototipo de luta."""
ROOT = "unity6-project/Assets/"


def patch(path, pairs):
    p = ROOT + path
    s = open(p, encoding="utf-8").read()
    for old, new in pairs:
        assert old in s, (path, old[:70])
        s = s.replace(old, new, 1)
    open(p, "w", encoding="utf-8").write(s)


patch("Prototype/SkillDef.cs", [("""	public string anim;""", """	public string vfx;                // efeito: slash, spin, slam, beam, burst, magicspin, dust, teleport
	public string anim;""")])

vfx = {"Machadada": "slash", "Giro do Machado": "spin", "Salto Esmagador": "slam", "Rolamento": "dust",
       "Raio Arcano": "beam", "Explosao Magica": "burst", "Gira Gira": "magicspin", "Teleporte": "teleport"}
patch("Prototype/FighterDef.cs", [(f'name = "{k}",', f'name = "{k}", vfx = "{v}",') for k, v in vfx.items()])

patch("Prototype/Fighter.cs", [
    ("""	public System.Action<Fighter, SkillDef, Vector3> onSkillFx;
""", """	public System.Action<Fighter, SkillDef, Vector3> onSkillFx;
	public System.Action<Fighter, SkillDef, Vector3> onSkillStart;
	public System.Action<Fighter, bool> onHitFx;
	public System.Action<Fighter> onDeathFx;
"""),
    ("""		PlayOnce(sd.anim, Mathf.Max(0.2f, sd.windup + sd.recovery));
		state = State.Casting;""", """		PlayOnce(sd.anim, Mathf.Max(0.2f, sd.windup + sd.recovery));
		Vector3 startCenter = Position;
		if (sd.areaAtTarget)
		{
			Vector3 to = aim - Position;
			to.y = 0f;
			startCenter = Position + Vector3.ClampMagnitude(to, sd.castRange);
		}
		onSkillStart?.Invoke(this, sd, startCenter);
		state = State.Casting;"""),
    ("""		hp -= damage;
		m_flash = 0.12f;""", """		hp -= damage;
		m_flash = 0.12f;
		onHitFx?.Invoke(this, critical);"""),
    ("""			PlayOnce(def.animDeath, 1.2f);
			return;""", """			PlayOnce(def.animDeath, 1.2f);
			onDeathFx?.Invoke(this);
			return;"""),
])

patch("Prototype/BattleManager.cs", [
    ("""			f.onSkillFx = SkillFx;""", """			f.onSkillFx = SkillFx;
			f.onSkillStart = SkillStartFx;
			f.onHitFx = (who, crit) => Vfx.Hit(who.Position + Vector3.up * 0.2f, who.opponent.def.color, crit);
			f.onDeathFx = who => Vfx.Death(who.Position);"""),
    ("""		CSLog.Init(new CSLogger());""", """		CSLog.Init(new CSLogger());
		Vfx.Clear();"""),
    ("""		UpdateFx(dt);""", """		UpdateFx(dt);
		Vfx.Update(dt);"""),
    # substitui os discos/barras por particulas
    ("""	private void SkillFx(Fighter owner, SkillDef sd, Vector3 center)
	{
		GameObject disc""", """	private void SkillFx(Fighter owner, SkillDef sd, Vector3 center)
	{
		Vector3 ground = center + Vector3.down * Arena.CenterHeight;
		switch (sd.vfx)
		{
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
		}
		GameObject disc"""),
    ("""	private void Popup(Fighter who, string text, Color color)""", """	// aviso no chao durante a preparacao das skills de area
	private void SkillStartFx(Fighter owner, SkillDef sd, Vector3 center)
	{
		Vector3 ground = center + Vector3.down * (Arena.CenterHeight - 0.02f);
		if (sd.vfx == "burst" || sd.vfx == "slam" || sd.vfx == "magicspin" || sd.vfx == "spin")
		{
			Vfx.Telegraph(ground, sd.color, sd.range, Mathf.Max(0.2f, sd.windup), sd.vfx == "burst" || sd.vfx == "magicspin");
		}
		if (sd.vfx == "teleport")
		{
			Vfx.Teleport(owner.Position, owner.def.color);
		}
	}

	private void Popup(Fighter who, string text, Color color)"""),
])
print("ok")
