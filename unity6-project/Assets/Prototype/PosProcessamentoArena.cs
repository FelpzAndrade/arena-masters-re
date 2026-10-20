using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

// Pos-processamento da arena (bloom, cor, temperatura, vinheta), igual na luta e na cena de teste de efeitos (VFX_Test).
public static class PosProcessamentoArena
{
	public static Volume Aplicar(Camera cam)
	{
		cam.allowHDR = true;
		UniversalAdditionalCameraData data = CameraExtensions.GetUniversalAdditionalCameraData(cam);
		data.renderPostProcessing = true;
		data.antialiasing = AntialiasingMode.FastApproximateAntialiasing;
		VolumeProfile profile = ScriptableObject.CreateInstance<VolumeProfile>();
		Bloom bloom = profile.Add<Bloom>(true);
		bloom.intensity.Override(1.1f);
		bloom.threshold.Override(0.9f);
		bloom.scatter.Override(0.7f);
		Tonemapping tonemapping = profile.Add<Tonemapping>(true);
		// Neutral, nao ACES: o ACES esmaga o escuro (a masmorra virava preto) e satura o laranja; medido contra a referencia
		// do jogo (folha_referencia.jpg: brilho medio ~0,23, escuro ~0,09 marrom), com estes valores a tela fica em ~0,20 / 0,075
		tonemapping.mode.Override(TonemappingMode.Neutral);
		ColorAdjustments color = profile.Add<ColorAdjustments>(true);
		color.postExposure.Override(1.4f);
		color.contrast.Override(-8f);
		color.saturation.Override(6f);
		WhiteBalance white = profile.Add<WhiteBalance>(true);
		white.temperature.Override(5f);   // ambiente puxado pro quente: herois e efeitos frios saltam do fundo
		Vignette vignette = profile.Add<Vignette>(true);
		vignette.intensity.Override(0.4f);
		vignette.smoothness.Override(0.45f);
		Volume volume = new GameObject("PosProcessamento").AddComponent<Volume>();
		volume.isGlobal = true;
		volume.priority = 1f;
		volume.sharedProfile = profile;
		return volume;
	}
}
