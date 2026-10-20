using System.Collections.Generic;
using UnityEngine;

// Controle do jogador e IA simples do bot.
// A IA original usava BehaviorDesigner (comercial); esta e uma substituta propria.
public interface IBrain
{
	void Think(Fighter self, float dt);
}

// Jogador: WASD move; mira com o mouse. J/clique = ataque basico (combo); K/L/I = segura para ver o indicador,
// solta para usar na direcao do mouse; Espaco = esquiva (cancela a skill atual).
public class PlayerBrain : IBrain
{
	private readonly Camera m_cam;
	private int m_holding = -1;

	public Vector3 AimPoint { get; private set; }
	public SkillDef AimingSkill { get; private set; }

	public PlayerBrain(Camera cam)
	{
		m_cam = cam;
	}

	public void Think(Fighter self, float dt)
	{
		AimPoint = MousePoint(self);
		Vector3 move = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
		self.FaceTowards(AimPoint);
		self.Move(move, dt, true);

		if (Input.GetKeyDown(KeyCode.J) || Input.GetMouseButtonDown(0))
		{
			self.TryUseSkill(0, AimPoint);
		}
		HoldToAim(self, KeyCode.K, 1);
		HoldToAim(self, KeyCode.L, 2);
		HoldToAim(self, KeyCode.I, 3);
		HoldToAim(self, KeyCode.R, Fighter.UltSlot);
		if (Input.GetKeyDown(KeyCode.Space))
		{
			Vector3 dodgeAim = move.sqrMagnitude > 0.01f ? self.Position + move.normalized : AimPoint;
			self.TryUseSkill(Fighter.DodgeSlot, dodgeAim);
		}
		AimingSkill = m_holding >= 0 ? self.SlotSkill(m_holding) : null;
	}

	private void HoldToAim(Fighter self, KeyCode key, int slot)
	{
		if (Input.GetKeyDown(key))
		{
			m_holding = slot;
		}
		if (Input.GetKeyUp(key) && m_holding == slot)
		{
			m_holding = -1;
			self.TryUseSkill(slot, AimPoint);
		}
	}

	// ponto do chao sob o mouse (plano na altura dos pes do jogador)
	private Vector3 MousePoint(Fighter self)
	{
		if (m_cam == null)
		{
			return self.Position + self.facing * 3f;
		}
		Ray ray = m_cam.ScreenPointToRay(Input.mousePosition);
		Plane plane = new Plane(Vector3.up, self.Position);
		return plane.Raycast(ray, out float d) ? ray.GetPoint(d) : self.Position + self.facing * 3f;
	}
}

public class BotBrain : IBrain
{
	private readonly System.Random m_rng;
	private float m_thinkTimer;
	private float m_strafeSign = 1f;
	private float m_reaction;
	private List<Vector3> m_path = new List<Vector3>();
	private float m_repath;

	// projeteis vivos (posicao, direcao, dono) para o bot desviar
	public System.Func<IEnumerable<(Vector3 pos, Vector3 dir, Fighter owner)>> projectiles;

	public BotBrain(int seed)
	{
		m_rng = new System.Random(seed);
	}

	// perigo: area do inimigo em preparo sobre mim, ou projetil vindo na minha direcao
	private bool Danger(Fighter self, Fighter enemy, out Vector3 escape)
	{
		escape = Vector3.zero;
		SkillDef cast = enemy.state == Fighter.State.Casting ? enemy.CurrentSkill : null;
		if (cast != null && cast.damageRatio > 0f)
		{
			Vector3 center = enemy.Position;
			if (cast.areaAtTarget)
			{
				Vector3 to = enemy.CurrentAim - enemy.Position;
				to.y = 0f;
				center = enemy.Position + Vector3.ClampMagnitude(to, cast.castRange);
			}
			Vector3 away = self.Position - center;
			away.y = 0f;
			bool inArea = away.magnitude < cast.range + cast.areaJitter + 0.8f;
			bool inCone = cast.angle >= 360f || cast.areaAtTarget || Vector3.Angle(enemy.facing, -away * -1f) < cast.angle * 0.5f + 15f;
			if (inArea && inCone && cast.projectileSpeed <= 0f)
			{
				escape = away.sqrMagnitude > 0.01f ? away.normalized : Vector3.Cross(Vector3.up, enemy.facing);
				return true;
			}
		}
		if (projectiles != null)
		{
			foreach ((Vector3 pos, Vector3 dir, Fighter owner) p in projectiles())
			{
				if (p.owner == self)
				{
					continue;
				}
				Vector3 rel = self.Position - p.pos;
				rel.y = 0f;
				float along = Vector3.Dot(rel, p.dir);
				float side = Vector3.Cross(p.dir, rel).y;
				if (along > 0f && along < 6f && Mathf.Abs(side) < 1.3f)
				{
					escape = Vector3.Cross(Vector3.up, p.dir) * (side >= 0f ? -1f : 1f);
					return true;
				}
			}
		}
		return false;
	}

	private float Rand() => (float)m_rng.NextDouble();

	public void Think(Fighter self, float dt)
	{
		Fighter enemy = self.opponent;
		if (enemy == null || !enemy.IsAlive)
		{
			return;
		}
		Vector3 to = enemy.Position - self.Position;
		to.y = 0f;
		float dist = to.magnitude;
		m_thinkTimer -= dt;
		m_reaction -= dt;

		if (!self.CanAct && !self.IsBusy)
		{
			return;
		}
		// perigo: sai da area/linha de tiro andando; as vezes usa a esquiva (cancelando a propria skill)
		if (Danger(self, enemy, out Vector3 escape))
		{
			if (m_reaction <= 0f && Rand() < 0.45f && self.TryUseSkill(Fighter.DodgeSlot, self.Position + escape))
			{
				m_reaction = 0.8f;
				return;
			}
			if (self.CanAct)
			{
				self.Move(escape, dt);
				return;
			}
		}
		// ultimate cheia e alvo no alcance
		if (self.UltReady && self.def.ultimate != null)
		{
			SkillDef ult = self.def.ultimate;
			float reach = ult.areaAtTarget ? ult.castRange : ult.range + 1f;
			if (dist <= reach && self.TryUseSkill(Fighter.UltSlot, enemy.Position))
			{
				return;
			}
		}
		// lutador a distancia encostado: teleporta para longe
		bool ranged = self.def.skills[0].projectileSpeed > 0f;
		if (ranged && dist < 2.5f && m_reaction <= 0f && Rand() < 0.04f)
		{
			m_reaction = 1f;
			if (self.TryUseSkill(Fighter.DodgeSlot, self.Position - to.normalized * 3f))
			{
				return;
			}
		}
		// escolhe a skill disponivel de maior dano que alcance o alvo; o basico vira combo apertando seguido
		for (int i = self.def.skills.Length - 1; i >= 0; i--)
		{
			SkillDef sd = self.def.skills[i];
			if (sd == null)
			{
				continue;   // lugar vazio
			}
			float reach = sd.areaAtTarget ? sd.castRange : sd.range + sd.dashDistance;
			float chance = i == 0 ? 0.45f : 0.08f;
			if (self.cooldowns[i] <= 0f && dist <= reach * 0.9f && Rand() < chance)
			{
				if (self.TryUseSkill(i, enemy.Position))
				{
					return;
				}
			}
		}
		if (!self.CanAct)
		{
			return;
		}
		if (m_thinkTimer <= 0f)
		{
			m_thinkTimer = 0.8f + Rand();
			m_strafeSign = Rand() < 0.5f ? -1f : 1f;
		}
		// mantem a distancia preferida (perto para a Machadinha, media para a Bruxa)
		float preferred = ranged ? 6.5f : self.def.skills[0].range * 0.75f;
		Vector3 move = dist > preferred ? ChaseDirection(self, enemy, dt) : Vector3.Cross(Vector3.up, to).normalized * m_strafeSign;
		if (dist < preferred * 0.5f)
		{
			move = -to.normalized;
		}
		self.Move(move, dt);
		if (dist <= preferred * 1.5f && to.sqrMagnitude > 0.01f)
		{
			self.facing = to.normalized;
		}
	}

	// segue o caminho do A* no navmesh (contorna buracos e vaos do mapa)
	private Vector3 ChaseDirection(Fighter self, Fighter enemy, float dt)
	{
		m_repath -= dt;
		if (m_repath <= 0f || m_path.Count == 0)
		{
			m_repath = 0.5f;
			m_path = self.arena.FindPath(self.Position, enemy.Position);
		}
		while (m_path.Count > 1 && Vector3.Distance(Flat(m_path[0]), Flat(self.Position)) < 0.8f)
		{
			m_path.RemoveAt(0);
		}
		if (m_path.Count == 0)
		{
			// sem caminho (alvo em outra regiao): contorna em vez de forcar a parede
			return Vector3.Cross(Vector3.up, (enemy.Position - self.Position).normalized) * m_strafeSign;
		}
		Vector3 next = m_path[0];
		Vector3 dir = next - self.Position;
		dir.y = 0f;
		return dir.sqrMagnitude > 0.0001f ? dir.normalized : Vector3.zero;
	}

	private static Vector3 Flat(Vector3 v) => new Vector3(v.x, 0f, v.z);
}
