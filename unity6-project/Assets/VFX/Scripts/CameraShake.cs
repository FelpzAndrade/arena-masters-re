using UnityEngine;

// Tremida de camera por "trauma": cada impacto sobe o trauma, que cai sozinho com o tempo.
// Uso: CameraShake.Add(0.15f) no impacto; a camera soma CameraShake.Offset(tempo real) na posicao todo quadro.
// O balanco usa ruido Perlin (suave), nao sorteio a cada quadro.
public static class CameraShake
{
	public const float Decay = 1.6f;        // trauma perdido por segundo
	public const float Amplitude = 0.35f;   // deslocamento maximo em metros com trauma 1
	public const float Frequency = 22f;     // balancos por segundo

	private static float s_trauma;
	private static float s_time;

	public static void Add(float amount)
	{
		s_trauma = Mathf.Max(s_trauma, amount);
	}

	public static Vector3 Offset(float realDt)
	{
		s_trauma = Mathf.Max(0f, s_trauma - realDt * Decay);
		s_time += realDt * Frequency;
		if (s_trauma <= 0f)
		{
			return Vector3.zero;
		}
		Vector3 n = new Vector3(Mathf.PerlinNoise(s_time, 0.1f), Mathf.PerlinNoise(0.7f, s_time), Mathf.PerlinNoise(s_time, 3.3f)) * 2f - Vector3.one;
		return n * (s_trauma * Amplitude);
	}

	public static void Clear()
	{
		s_trauma = 0f;
	}
}
