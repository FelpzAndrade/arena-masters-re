using System.IO;
using System.Linq;
using System.Text;
using UnityEditor;
using UnityEngine;

// Mede o instante de impacto de cada clipe de ataque: pico de velocidade do slot da arma (handslot.r).
// O jogo original guardava esses tempos em tabela (XSkillHitTime / character_anim.xml); aqui saem do proprio clipe.
public static class ImpactProbe
{
	private static readonly string[] Clips =
	{
		"2H_Melee_Attack_Slice", "2H_Melee_Attack_Stab", "2H_Melee_Attack_Chop", "2H_Melee_Attack_Spinning", "2H_Melee_Attack_Spin",
		"Jump_Full_Short", "Spellcast_Shoot", "Spellcasting", "Spellcast_Raise", "Spellcast_Long", "Dodge_Forward",
	};

	public static void Run()
	{
		StringBuilder sb = new StringBuilder();
		GameObject model = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Prototype/KayKit/Characters/Barbarian.fbx");
		GameObject go = Object.Instantiate(model);
		Animation anim = go.GetComponent<Animation>();
		Transform hand = go.GetComponentsInChildren<Transform>().First(t => t.name == "handslot.r");
		foreach (string name in Clips)
		{
			AnimationState st = anim[name];
			if (st == null)
			{
				continue;
			}
			const int samples = 120;
			Vector3 prev = Vector3.zero;
			float bestSpeed = 0f, bestT = 0f;
			anim.Play(name);
			for (int i = 0; i <= samples; i++)
			{
				float t = st.length * i / samples;
				st.time = t;
				anim.Sample();
				Vector3 p = hand.position;
				if (i > 0)
				{
					float speed = (p - prev).magnitude / (st.length / samples);
					// ignora o comeco (preparo) para nao pegar o recuo
					if (t > st.length * 0.15f && speed > bestSpeed)
					{
						bestSpeed = speed;
						bestT = t;
					}
				}
				prev = p;
			}
			sb.AppendLine($"{name}|{st.length:F3}|{bestT:F3}|{bestT / st.length:F3}");
		}
		Object.DestroyImmediate(go);
		File.WriteAllText("C:/Users/felip/arena-masters-re/captures/impact_times.txt", sb.ToString());
	}
}
