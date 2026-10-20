# Gera as texturas dos efeitos proprios (Assets/VFX/Textures), PNG com alpha, ate 512x512.
#   T_SlashMask.png  faixa do corte: u = ao longo do arco (0 = cauda, 1 = ponta), v = atravessando (0 = dentro, 1 = fio)
#                    RGB = miolo quente (1 no fio), A = formato. Bordas da imagem com alpha 0 (textura em Clamp).
#   T_Noise.png      ruido fractal que repete nas bordas (dissolve e distorcao). RGB = A = valor.
#   T_Spark.png      faisca: miolo branco + halo + cruz fina. RGB branco, A = brilho.
#   T_Ring.png       anel de onda de choque (RGB = borda quente, A = anel).
#   T_Hex.png        grade de hexagonos da cupula de escudo (RGB = linhas, A = linhas + fundo fraco).
#   T_Crack.png      rachaduras saindo do centro (RGB = miolo de lava, A = rachadura + cratera). Clamp.
#   T_Rocks.png      folha 2x2 de pedrinhas (RGB = luz das facetas, A = formato).
#   T_Puff.png       nuvem de poeira (RGB = mais claro em cima, A = densidade).
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


def make_crack(size=512, branches=9, rng=None):
	# rachaduras saindo do centro (onde o machado bate): RGB = miolo quente (lava), A = rachadura + cratera escura.
	# Desenha em 2x e reduz (borda suave).
	from PIL import ImageDraw, ImageFilter
	big = size * 2
	c = big / 2.0
	line_img = Image.new("L", (big, big), 0)
	core_img = Image.new("L", (big, big), 0)
	dl, dc = ImageDraw.Draw(line_img), ImageDraw.Draw(core_img)

	def crack(x, y, ang, length, width, depth):
		steps = max(3, int(length / 40))
		for _ in range(steps):
			ang += rng.normal(0.0, 0.12) + (rng.choice([-1, 1]) * 0.5 if rng.random() < 0.12 else 0.0)
			seg = length / steps
			nx, ny = x + np.cos(ang) * seg, y + np.sin(ang) * seg
			w = max(1.0, width)
			dl.line([(x, y), (nx, ny)], fill=255, width=int(w))
			dc.line([(x, y), (nx, ny)], fill=255, width=max(1, int(w * 0.45)))
			if depth > 0 and rng.random() < 0.3:
				crack(nx, ny, ang + rng.choice([-1, 1]) * rng.uniform(0.5, 1.0), length * 0.4, width * 0.6, depth - 1)
			x, y = nx, ny
			width *= 0.9

	for k in range(branches):
		ang = k * 2 * np.pi / branches + rng.uniform(-0.25, 0.25)
		crack(c, c, ang, big * rng.uniform(0.3, 0.46), big * 0.026, 1)
	line = np.asarray(line_img.filter(ImageFilter.GaussianBlur(1.5)).resize((size, size), Image.LANCZOS)) / 255.0
	core = np.asarray(core_img.filter(ImageFilter.GaussianBlur(1.0)).resize((size, size), Image.LANCZOS)) / 255.0
	y, x = np.mgrid[0:size, 0:size]
	r = np.sqrt((x - size / 2) ** 2 + (y - size / 2) ** 2) / (size / 2)
	crater = 1.0 - smoothstep(0.05, 0.22, r)
	fade = 1.0 - smoothstep(0.75, 0.98, r)             # pontas somem antes da borda (Clamp)
	alpha = np.clip(np.maximum(line, crater * 0.9) * fade, 0.0, 1.0)
	hot = np.clip(core * (1.0 - smoothstep(0.1, 0.9, r) * 0.6) + crater * 0.8, 0.0, 1.0) * fade
	return hot, alpha


def make_rocks(size=256, rng=None):
	# folha 2x2 com 4 pedrinhas: RGB = luz das facetas (luz vindo de cima-esquerda), A = formato. Desenha em 4x.
	from PIL import ImageDraw
	cell = size // 2
	s = 4
	shade_img = Image.new("L", (size * s, size * s), 0)
	alpha_img = Image.new("L", (size * s, size * s), 0)
	ds, da = ImageDraw.Draw(shade_img), ImageDraw.Draw(alpha_img)
	light = np.array([-0.6, -0.8])
	for k in range(4):
		ox, oy = (k % 2) * cell * s, (k // 2) * cell * s
		cx, cy = ox + cell * s / 2, oy + cell * s / 2
		n = int(rng.integers(6, 9))
		angs = np.sort(rng.uniform(0, 2 * np.pi, n))
		rad = cell * s * rng.uniform(0.3, 0.4, n)
		pts = [(cx + np.cos(a) * r, cy + np.sin(a) * r) for a, r in zip(angs, rad)]
		da.polygon(pts, fill=255)
		top = (cx - 0.07 * cell * s, cy - 0.07 * cell * s)
		for i in range(n):
			p0, p1 = pts[i], pts[(i + 1) % n]
			mid = np.array([(p0[0] + p1[0]) / 2 - top[0], (p0[1] + p1[1]) / 2 - top[1]])
			mid /= np.linalg.norm(mid) + 1e-6
			lum = 0.62 + 0.36 * float(np.dot(mid, light))
			ds.polygon([top, p0, p1], fill=int(np.clip(lum, 0.1, 1.0) * 255))
	shade = np.asarray(shade_img.resize((size, size), Image.LANCZOS)) / 255.0
	alpha = np.asarray(alpha_img.resize((size, size), Image.LANCZOS)) / 255.0
	return shade, alpha


def make_puff(size=128, rng=None):
	# nuvem de poeira: bolhas macias + ruido; RGB = mais claro em cima, A = densidade
	y, x = np.mgrid[0:size, 0:size] / (size - 1.0)
	a = np.zeros((size, size))
	for _ in range(7):
		cx, cy = rng.uniform(0.35, 0.65), rng.uniform(0.4, 0.62)
		rr = rng.uniform(0.12, 0.22)
		a = np.maximum(a, np.exp(-((x - cx) ** 2 + (y - cy) ** 2) / (2 * rr * rr)))
	n = periodic_noise(size, 8, rng) * 0.6 + periodic_noise(size, 16, rng) * 0.4
	r = np.sqrt((x - 0.5) ** 2 + (y - 0.5) ** 2)
	a = np.clip(a * (0.65 + 0.5 * n) - 0.1, 0.0, 1.0) * (1.0 - smoothstep(0.38, 0.5, r))
	shade = np.clip(1.0 - y * 0.7 + (n - 0.5) * 0.3, 0.0, 1.0)
	return shade, a


def bolt_path(n, length, amp, rng, periodic):
	# linha quebrada do raio: soma de senos (frequencias inteiras = repete nas pontas) + zigue-zague fino
	t = np.linspace(0.0, 1.0, n)
	y = np.zeros(n)
	for k, a in ((1, 0.5), (2, 0.35), (3, 0.25), (5, 0.18), (8, 0.12), (13, 0.08)):
		f = k if periodic else k + rng.uniform(-0.4, 0.4)
		y += a * np.sin(2 * np.pi * f * t + rng.uniform(0, 2 * np.pi))
	jag = rng.uniform(-1, 1, n) * 0.15
	if periodic:
		jag[-1] = jag[0]
	y = (y + jag) * amp
	return t * length, y


def make_bolt(w=512, h=128, rng=None):
	# raio horizontal que repete em U (feixe e onda): miolo branco fino (RGB) + brilho (A), 2 fios finos ao lado
	from PIL import ImageDraw, ImageFilter
	s = 2
	core = Image.new("L", (w * s, h * s), 0)
	dc = ImageDraw.Draw(core)
	for strand, (amp, width, val) in enumerate(((0.22, 5, 255), (0.32, 2, 170), (0.28, 2, 140))):
		x, y = bolt_path(64, w * s, amp * h * s * 0.5, rng, True)
		pts = list(zip(x, y + h * s / 2))
		dc.line(pts, fill=val, width=width * s)
	core_a = np.asarray(core.resize((w, h), Image.LANCZOS)) / 255.0
	glow = np.asarray(core.filter(ImageFilter.GaussianBlur(9 * s)).resize((w, h), Image.LANCZOS)) / 255.0
	glow = np.clip(glow * 2.2, 0, 1)
	v = np.linspace(-1, 1, h)[:, None]
	edge = 1.0 - smoothstep(0.8, 1.0, np.abs(v))      # topo e base zerados (Clamp em V)
	alpha = np.clip(np.maximum(core_a, glow * 0.7), 0, 1) * edge
	return np.clip(core_a * 1.2, 0, 1) * edge, alpha


def make_bolt_v(w=128, h=512, rng=None):
	# raio vertical do ceu ao chao, com galhos; afina nas pontas (nao repete)
	from PIL import ImageDraw, ImageFilter
	s = 2
	core = Image.new("L", (w * s, h * s), 0)
	dc = ImageDraw.Draw(core)
	y, x = bolt_path(48, h * s, w * s * 0.18, rng, False)
	main = list(zip(x + w * s / 2, y))
	for i in range(len(main) - 1):
		width = int((2 + 6 * (1 - i / len(main))) * s)
		dc.line([main[i], main[i + 1]], fill=255, width=width)
	for _ in range(4):
		i0 = int(rng.integers(6, len(main) - 12))
		bx, by = main[i0]
		ang = rng.choice([-1, 1]) * rng.uniform(0.4, 0.9)
		for _ in range(8):
			nx, ny = bx + np.sin(ang) * 14 * s + rng.uniform(-5, 5) * s, by + np.cos(ang) * 16 * s
			dc.line([(bx, by), (nx, ny)], fill=170, width=2 * s)
			bx, by = nx, ny
	core_a = np.asarray(core.resize((w, h), Image.LANCZOS)) / 255.0
	glow = np.clip(np.asarray(core.filter(ImageFilter.GaussianBlur(8 * s)).resize((w, h), Image.LANCZOS)) / 255.0 * 2.2, 0, 1)
	u = np.linspace(-1, 1, w)[None, :]
	t = np.linspace(0, 1, h)[:, None]
	fade = (1.0 - smoothstep(0.85, 1.0, np.abs(u))) * smoothstep(0.0, 0.05, t) * (1.0 - smoothstep(0.97, 1.0, t))
	return np.clip(core_a * 1.2, 0, 1) * fade, np.clip(np.maximum(core_a, glow * 0.7), 0, 1) * fade


def make_swirl(size=256, rng=None):
	# redemoinho da fenda: 3 bracos em espiral que afinam para o centro; miolo vazio
	y, x = np.mgrid[0:size, 0:size]
	c = (size - 1) / 2.0
	dx, dy = (x - c) / c, (y - c) / c
	r = np.sqrt(dx * dx + dy * dy)
	th = np.arctan2(dy, dx)
	arms = 0.5 + 0.5 * np.cos(3 * (th + 5.0 * r))
	arms = smoothstep(0.55, 0.95, arms)
	n = periodic_noise(size, 16, rng)
	ring = smoothstep(0.12, 0.35, r) * (1.0 - smoothstep(0.8, 0.98, r))
	alpha = np.clip(arms * ring * (0.75 + 0.5 * n), 0, 1)
	core = np.clip(arms * (1.0 - smoothstep(0.2, 0.8, r)) * ring, 0, 1)
	return core, alpha


def make_ring_streak(size=512, rng=None, thick=1.0):
	# anel de redemoinho (Skill B): faixa circular feita de riscos finos que correm em volta, com 3 "cabecas" fortes
	# que afinam numa cauda (cara de giro rapido). RGB = miolo quente, A = brilho. Centro vazio, bordas zeradas (Clamp).
	c = (size - 1) / 2.0
	y, x = np.mgrid[0:size, 0:size]
	r = np.sqrt((x - c) ** 2 + (y - c) ** 2) / c
	th = np.arctan2(y - c, x - c)
	band = smoothstep(0.8 - 0.18 * thick, 0.8 - 0.06 * thick, r) * (1.0 - smoothstep(0.8 + 0.06 * thick, 0.8 + 0.17 * thick, r))
	# riscos: varias faixas finas em raios diferentes, cada uma com um trecho aceso de tamanho proprio
	streaks = np.zeros_like(r)
	for k in range(14):
		rad = rng.uniform(0.8 - 0.14 * thick, 0.8 + 0.13 * thick)
		w = rng.uniform(0.006, 0.018) * thick
		start = rng.uniform(0, 2 * np.pi)
		length = rng.uniform(0.6, 2.2)
		ang = np.mod(th - start, 2 * np.pi)
		tail = np.clip(1.0 - ang / length, 0.0, 1.0) ** 1.6          # forte na cabeca, some na cauda
		streaks = np.maximum(streaks, np.exp(-((r - rad) / w) ** 2) * tail)
	# 3 cabecas grossas igualmente espacadas (o giro fica legivel de cima)
	heads = np.zeros_like(r)
	for k in range(3):
		ang = np.mod(th - k * 2 * np.pi / 3, 2 * np.pi)
		tail = np.clip(1.0 - ang / 2.4, 0.0, 1.0) ** 2.2
		heads = np.maximum(heads, tail * np.exp(-((r - 0.8) / (0.06 * thick)) ** 2))
	alpha = np.clip(np.maximum(streaks * 0.9, heads) + band * 0.18, 0.0, 1.0) * (1.0 - smoothstep(0.96, 1.0, r))
	core = np.clip(heads * 1.1 + streaks * 0.35, 0.0, 1.0)
	return core, alpha


def make_thin_ring(size=512):
	# filete fino e limpo (borda da esfera): uma linha so, sem falhas
	c = (size - 1) / 2.0
	y, x = np.mgrid[0:size, 0:size]
	r = np.sqrt((x - c) ** 2 + (y - c) ** 2) / c
	line = np.exp(-((r - 0.9) / 0.012) ** 2)
	glow = np.exp(-((r - 0.9) / 0.05) ** 2) * 0.35
	return np.clip(line, 0, 1), np.clip(line + glow, 0, 1) * (1.0 - smoothstep(0.97, 1.0, r))


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
	# texturas do Golpe da Terra: sorteio proprio (nao muda as de cima)
	rng = np.random.default_rng(11)
	hot, crack = make_crack(rng=rng)
	save(OUT / "T_Crack.png", hot, crack)
	shade, rocks = make_rocks(rng=rng)
	save(OUT / "T_Rocks.png", shade, rocks)
	shade, puff = make_puff(rng=rng)
	save(OUT / "T_Puff.png", shade, puff)
	# texturas do Spark: sorteio proprio
	rng = np.random.default_rng(23)
	core, bolt = make_bolt(rng=rng)
	save(OUT / "T_Bolt.png", core, bolt)
	core, bolt = make_bolt_v(rng=rng)
	save(OUT / "T_BoltV.png", core, bolt)
	core, swirl = make_swirl(rng=rng)
	save(OUT / "T_Swirl.png", core, swirl)
	# Skill B do Aj (esfera giratoria): sorteio proprio
	rng = np.random.default_rng(61)
	core, ring = make_ring_streak(rng=rng)
	save(OUT / "T_AnelRisco.png", core, ring)
	for nome, k in (("T_AnelRiscoGrosso", 1.7), ("T_AnelRiscoFino", 0.45)):
		core, ring = make_ring_streak(rng=rng, thick=k)
		save(OUT / (nome + ".png"), core, ring)
	core, ring = make_thin_ring()
	save(OUT / "T_AnelFilete.png", core, ring)


if __name__ == "__main__":
	main()
