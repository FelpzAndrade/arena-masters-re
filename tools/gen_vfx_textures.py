# Gera as texturas dos efeitos proprios (Assets/VFX/Textures), PNG com alpha, ate 512x512.
#   T_SlashMask.png  faixa do corte: u = ao longo do arco (0 = cauda, 1 = ponta), v = atravessando (0 = dentro, 1 = fio)
#                    RGB = miolo quente (1 no fio), A = formato. Bordas da imagem com alpha 0 (textura em Clamp).
#   T_Noise.png      ruido fractal que repete nas bordas (dissolve e distorcao). RGB = A = valor.
#   T_Spark.png      faisca: miolo branco + halo + cruz fina. RGB branco, A = brilho.
#   T_Ring.png       anel de onda de choque (RGB = borda quente, A = anel).
#   T_Hex.png        grade de hexagonos da cupula de escudo (RGB = linhas, A = linhas + fundo fraco).
# Uso: tools/venv/Scripts/python.exe -I tools/gen_vfx_textures.py [pasta_de_saida]
import sys
from pathlib import Path

import numpy as np
from PIL import Image

OUT = Path(sys.argv[1]) if len(sys.argv) > 1 else Path(__file__).resolve().parent.parent / "unity6-project/Assets/VFX/Textures"
RNG = np.random.default_rng(7)


def smoothstep(a, b, x):
	t = np.clip((x - a) / (b - a), 0.0, 1.0)
	return t * t * (3.0 - 2.0 * t)


def periodic_noise(size, freq, rng):
	# ruido de valor com grade que da a volta (repete sem emenda)
	grid = rng.random((freq, freq))
	coords = np.arange(size) * freq / size
	i0 = np.floor(coords).astype(int)
	f = coords - i0
	f = f * f * (3.0 - 2.0 * f)
	i1 = (i0 + 1) % freq
	g00 = grid[np.ix_(i0, i0)]
	g10 = grid[np.ix_(i1, i0)]
	g01 = grid[np.ix_(i0, i1)]
	g11 = grid[np.ix_(i1, i1)]
	fy = f[:, None]
	fx = f[None, :]
	top = g00 * (1 - fx) + g01 * fx
	bot = g10 * (1 - fx) + g11 * fx
	return top * (1 - fy) + bot * fy


def make_noise(size=256):
	n = np.zeros((size, size))
	amp, total = 1.0, 0.0
	for freq in (4, 8, 16, 32, 64):
		n += periodic_noise(size, freq, RNG) * amp
		total += amp
		amp *= 0.5
	n /= total
	# estica o contraste pra usar a faixa toda (dissolve fica uniforme no tempo)
	lo, hi = np.percentile(n, 1), np.percentile(n, 99)
	return np.clip((n - lo) / (hi - lo), 0.0, 1.0)


def make_slash_mask(w=512, h=128):
	u = np.linspace(0.0, 1.0, w)[None, :]
	v = np.linspace(0.0, 1.0, h)[:, None]
	# espessura ao longo do arco: fina na cauda, mais grossa perto da ponta, afina ate um bico
	thick = smoothstep(0.0, 0.75, u) ** 1.5 * (1.0 - smoothstep(0.82, 1.0, u)) ** 0.6
	thick = 0.06 + 0.64 * thick
	# o fio fica em v = 1; a lamina vai de v = 1 - thick ate 1
	depth = (1.0 - v) / np.maximum(thick, 1e-4)        # 0 no fio, 1 no fim da lamina
	inside = 1.0 - smoothstep(0.55, 1.0, depth)
	edge_aa = smoothstep(0.0, 0.04, 1.0 - v)            # borda do fio sem serrilhado
	# a cauda some devagar, a ponta acende
	along = smoothstep(0.0, 0.55, u) * (1.0 - smoothstep(0.93, 1.0, u))
	# riscos finos correndo junto com o arco (variam so em v)
	streak = periodic_noise(h, 24, RNG)[:, :1] * 0.6 + periodic_noise(h, 48, RNG)[:, :1] * 0.4
	streak = 0.8 + 0.2 * smoothstep(0.3, 0.8, streak)
	alpha = inside * edge_aa * along * streak
	core = (1.0 - smoothstep(0.0, 0.45, depth)) * smoothstep(0.35, 0.85, u)
	core = np.clip(core * edge_aa, 0.0, 1.0)
	# bordas da imagem zeradas (Clamp nao vaza)
	alpha[:, :2] = 0
	alpha[:, -2:] = 0
	alpha[:2, :] = 0
	alpha[-1:, :] = 0
	# linha 0 do PNG e o topo da imagem = v = 1 no Unity: inverte pra o fio ficar em cima
	return core[::-1], alpha[::-1]


def make_spark(size=128):
	c = (size - 1) / 2.0
	y, x = np.mgrid[0:size, 0:size]
	dx, dy = (x - c) / c, (y - c) / c
	r = np.sqrt(dx * dx + dy * dy)
	glow = np.exp(-r * r * 18.0) + 0.35 * np.exp(-r * r * 4.0)
	cross = np.exp(-(dy * dy) * 900.0) * np.exp(-(dx * dx) * 3.0) + np.exp(-(dx * dx) * 900.0) * np.exp(-(dy * dy) * 3.0)
	a = np.clip(glow + 0.5 * cross, 0.0, 1.0) * (1.0 - smoothstep(0.9, 1.0, r))
	return a


def make_ring(size=256):
	# anel de onda de choque: borda externa dura, cauda suave para dentro, falhas de ruido
	c = (size - 1) / 2.0
	y, x = np.mgrid[0:size, 0:size]
	r = np.sqrt((x - c) ** 2 + (y - c) ** 2) / c
	ring = smoothstep(0.55, 0.9, r) * (1.0 - smoothstep(0.9, 0.97, r))
	ang = np.arctan2(y - c, x - c)
	wobble = 0.8 + 0.2 * np.sin(ang * 7.0) * np.sin(ang * 3.0 + 1.3)
	core = smoothstep(0.82, 0.9, r) * (1.0 - smoothstep(0.9, 0.95, r))
	return core, np.clip(ring * wobble, 0.0, 1.0)


def make_hex(size=256, nx=4, ny=2):
	# grade de hexagonos que repete nas bordas: RGB = linhas (miolo), A = linhas + leve preenchimento.
	# Periodo do padrao = (1, raiz de 3); nx x ny periodos cabem na imagem, entao a borda emenda certinho.
	sq3 = np.sqrt(3.0)
	u = (np.arange(size) + 0.5) / size
	X, Y = np.meshgrid(u * nx, u * ny * sq3)
	rx, ry = 1.0, sq3
	ax, ay = np.mod(X, rx) - rx / 2, np.mod(Y, ry) - ry / 2
	bx, by = np.mod(X - rx / 2, rx) - rx / 2, np.mod(Y - ry / 2, ry) - ry / 2
	use_a = ax * ax + ay * ay < bx * bx + by * by
	gx, gy = np.abs(np.where(use_a, ax, bx)), np.abs(np.where(use_a, ay, by))
	d = np.maximum(gx * 0.5 + gy * sq3 / 2, gx)          # 0,5 na borda do hexagono
	line = smoothstep(0.43, 0.49, d)
	return line, np.clip(line * 0.85 + 0.1, 0.0, 1.0)


def save(path, rgb, alpha):
	rgb = np.clip(rgb, 0.0, 1.0)
	img = np.dstack([rgb, rgb, rgb, np.clip(alpha, 0.0, 1.0)])
	Image.fromarray((img * 255.0 + 0.5).astype(np.uint8), "RGBA").save(path)
	print("gerado", path)


def main():
	OUT.mkdir(parents=True, exist_ok=True)
	core, alpha = make_slash_mask()
	save(OUT / "T_SlashMask.png", core, alpha)
	noise = make_noise()
	save(OUT / "T_Noise.png", noise, noise)
	spark = make_spark()
	save(OUT / "T_Spark.png", np.ones_like(spark), spark)
	core, ring = make_ring()
	save(OUT / "T_Ring.png", core, ring)
	line, hexa = make_hex()
	save(OUT / "T_Hex.png", line, hexa)


if __name__ == "__main__":
	main()
