using UnityEngine;

// Hit stop: congela o jogo por um instante no impacto (peso do golpe).
// Uso: HitStop.Request(0.05f) no acerto; quem roda o jogo chama HitStop.Tick(tempo real) uma vez por quadro.
// Pedidos ao mesmo tempo nao somam: vale o maior.
public static class HitStop
{
	public const float FrozenScale = 0.03f;   // velocidade do jogo durante o congelamento (quase parado)

	private static float s_left;

	public static bool Active => s_left > 0f;

	// velocidade do jogo agora: FrozenScale congelado, 1 normal
	public static float Scale => s_left > 0f ? FrozenScale : 1f;

	public static void Request(float seconds)
	{
		s_left = Mathf.Max(s_left, seconds);
	}

	// realDt = tempo real do quadro (Time.unscaledDeltaTime no Play); no Play tambem ajusta o Time.timeScale
	public static void Tick(float realDt)
	{
		if (s_left <= 0f)
		{
			return;
		}
		s_left -= realDt;
		if (Application.isPlaying)
		{
			Time.timeScale = Scale;
		}
	}

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]   // inicio de cada Play (vale com o recarregamento de codigo desligado)
	public static void Clear()
	{
		s_left = 0f;
		if (Application.isPlaying)
		{
			Time.timeScale = 1f;
		}
	}
}
