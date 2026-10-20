# Texturas da interface de toque (botoes redondos e icones de skill), brancas sobre transparente:
# a cor vem do jogo (cor da skill no fundo do botao). Nada pintado a mao.
#   Assets/UI/Resources/UI/T_Circulo.png   disco com borda suave (fundo do botao, preenchimento radial da recarga)
#   Assets/UI/Resources/UI/T_Anel.png      anel fino (borda do botao, barra da ultimate em volta)
#   Assets/UI/Resources/UI/T_Brilho.png    brilho radial (ultimate cheia, joystick)
#   Assets/UI/Resources/Icones/<tipo>.png  um simbolo por tipo de efeito de skill (SkillDef.vfx) + ataque, esquiva, vazio
# Uso: tools/venv/Scripts/python.exe -I tools/gen_ui_textures.py
import math
from pathlib import Path

from PIL import Image, ImageDraw, ImageFilter

ROOT = Path(__file__).resolve().parent.parent / "unity6-project/Assets/UI/Resources"
N = 256          # tamanho final
S = 4            # superamostragem (bordas suaves)
W = N * S


def novo():
	return Image.new("L", (W, W), 0)


def salvar(alfa, pasta, nome, brilho=0):
	if brilho:
		halo = alfa.filter(ImageFilter.GaussianBlur(brilho * S))
		alfa = Image.composite(alfa, halo, alfa)
	alfa = alfa.resize((N, N), Image.LANCZOS)
	img = Image.merge("RGBA", (Image.new("L", (N, N), 255),) * 3 + (alfa,))
	(ROOT / pasta).mkdir(parents=True, exist_ok=True)
	img.save(ROOT / pasta / f"{nome}.png")
	print("gerado", pasta, nome)


def p(x, y):
	"""coordenadas de -1..1 (y para cima) para pixels"""
	return ((x + 1) * 0.5 * W, (1 - (y + 1) * 0.5) * W)


def linha(d, pts, larg):
	d.line([p(*q) for q in pts], fill=255, width=int(larg * W), joint="curve")
	for q in (pts[0], pts[-1]):
		r = larg * W / 2
		x, y = p(*q)
		d.ellipse([x - r, y - r, x + r, y + r], fill=255)


def arco(d, cx, cy, r, a0, a1, larg, passos=40):
	pts = [(cx + r * math.cos(math.radians(a0 + (a1 - a0) * i / passos)), cy + r * math.sin(math.radians(a0 + (a1 - a0) * i / passos))) for i in range(passos + 1)]
	linha(d, pts, larg)


def poligono(d, pts):
	d.polygon([p(*q) for q in pts], fill=255)


def raio(d, x0, y0, x1, y1, larg, desvio=0.12, n=5):
	pts = [(x0, y0)]
	for i in range(1, n):
		t = i / n
		lado = desvio if i % 2 else -desvio
		dx, dy = x1 - x0, y1 - y0
		comp = math.hypot(dx, dy)
		pts.append((x0 + dx * t - dy / comp * lado, y0 + dy * t + dx / comp * lado))
	pts.append((x1, y1))
	linha(d, pts, larg)


def base():
	# disco
	a = novo()
	ImageDraw.Draw(a).ellipse([S * 2, S * 2, W - S * 2, W - S * 2], fill=255)
	salvar(a, "UI", "T_Circulo")
	# anel
	a = novo()
	d = ImageDraw.Draw(a)
	d.ellipse([S * 2, S * 2, W - S * 2, W - S * 2], fill=255)
	d.ellipse([W * 0.09, W * 0.09, W * 0.91, W * 0.91], fill=0)
	salvar(a, "UI", "T_Anel")
	# brilho radial
	img = Image.new("L", (N, N), 0)
	px = img.load()
	for y in range(N):
		for x in range(N):
			r = math.hypot(x - N / 2 + 0.5, y - N / 2 + 0.5) / (N / 2)
			px[x, y] = int(255 * max(0.0, 1 - r) ** 2)
	(ROOT / "UI").mkdir(parents=True, exist_ok=True)
	Image.merge("RGBA", (Image.new("L", (N, N), 255),) * 3 + (img,)).save(ROOT / "UI" / "T_Brilho.png")
	print("gerado UI T_Brilho")


def icones():
	L = 0.11   # espessura padrao do traco
	desenhos = {}

	def ic(nome):
		def reg(f):
			desenhos[nome] = f
			return f
		return reg

	@ic("ataque")       # espadas cruzadas
	def _(d):
		linha(d, [(-0.55, -0.55), (0.55, 0.55)], L)
		linha(d, [(0.55, -0.55), (-0.55, 0.55)], L)
		linha(d, [(-0.62, -0.25), (-0.25, -0.62)], L * 0.8)
		linha(d, [(0.62, -0.25), (0.25, -0.62)], L * 0.8)

	@ic("slash")        # corte em arco
	def _(d):
		arco(d, -0.25, -0.25, 0.85, 0, 90, L * 1.2)
		arco(d, -0.25, -0.25, 0.55, 10, 80, L * 0.6)

	@ic("axeslash")     # machado
	def _(d):
		linha(d, [(-0.5, -0.6), (0.35, 0.45)], L)
		poligono(d, [(0.05, 0.6), (0.55, 0.75), (0.75, 0.25), (0.55, 0.05)])

	@ic("earthslam")    # punho/onda batendo no chao: rachaduras
	def _(d):
		linha(d, [(-0.75, -0.45), (0.75, -0.45)], L)
		linha(d, [(0, -0.45), (-0.2, -0.05), (0.05, 0.25), (-0.1, 0.6)], L * 0.8)
		linha(d, [(0, -0.45), (0.35, -0.1), (0.5, 0.3)], L * 0.7)
		linha(d, [(0, -0.45), (-0.45, -0.15)], L * 0.6)

	@ic("bufalo")       # chifres
	def _(d):
		arco(d, -0.35, 0.0, 0.45, 100, 230, L * 1.2)
		arco(d, 0.35, 0.0, 0.45, -50, 80, L * 1.2)
		d.ellipse([*p(-0.3, 0.2), *p(0.3, -0.4)], fill=255)

	@ic("warhorn")      # corneta com ondas
	def _(d):
		poligono(d, [(-0.7, -0.15), (-0.2, -0.05), (0.25, -0.35), (0.25, 0.35), (-0.2, 0.05), (-0.7, 0.15)])
		arco(d, 0.25, 0, 0.3, -45, 45, L * 0.6)
		arco(d, 0.25, 0, 0.55, -40, 40, L * 0.6)

	@ic("bolt")         # projetil de raio
	def _(d):
		raio(d, -0.7, -0.4, 0.6, 0.45, L, 0.14)
		d.ellipse([*p(0.4, 0.65), *p(0.8, 0.25)], fill=255)

	@ic("beam")         # feixe reto
	def _(d):
		linha(d, [(-0.75, 0), (0.75, 0)], L * 1.6)
		linha(d, [(-0.5, 0.35), (0.75, 0.35)], L * 0.4)
		linha(d, [(-0.5, -0.35), (0.75, -0.35)], L * 0.4)

	@ic("lightning")    # relampago caindo
	def _(d):
		poligono(d, [(0.15, 0.85), (-0.35, 0.0), (0.0, 0.0), (-0.2, -0.85), (0.4, 0.15), (0.05, 0.15), (0.35, 0.85)])

	@ic("wave")         # ondas em leque
	def _(d):
		for r in (0.35, 0.6, 0.85):
			arco(d, -0.6, 0, r + 0.2, -40, 40, L * 0.7)

	@ic("rupture")      # espiral
	def _(d):
		pts = [(0.08 * t * math.cos(t), 0.08 * t * math.sin(t)) for t in [i * 0.2 for i in range(52)]]
		linha(d, pts, L * 0.8)

	@ic("terrasplitter")  # onda de choque em linha com pedras
	def _(d):
		linha(d, [(-0.8, -0.6), (0.8, 0.6)], L * 0.6)
		for t in (-0.45, 0.05, 0.5):
			x, y = t, t * 0.75
			poligono(d, [(x - 0.18, y - 0.05), (x, y + 0.35), (x + 0.18, y - 0.05)])

	@ic("esfera")       # esfera giratoria: aneis
	def _(d):
		d.ellipse([*p(-0.22, 0.22), *p(0.22, -0.22)], fill=255)
		arco(d, 0, 0, 0.55, 20, 300, L * 0.8)
		arco(d, 0, 0, 0.8, 200, 470, L * 0.5)

	@ic("explosao")     # explosao estrelada
	def _(d):
		pts = []
		for i in range(16):
			r = 0.85 if i % 2 == 0 else 0.4
			a = math.radians(i * 22.5 + 11)
			pts.append((r * math.cos(a), r * math.sin(a)))
		poligono(d, pts)

	@ic("dust")         # esquiva: setas de impulso
	def _(d):
		linha(d, [(-0.6, -0.35), (0.6, -0.35)], L)
		poligono(d, [(0.45, -0.1), (0.8, -0.35), (0.45, -0.6)])
		linha(d, [(-0.7, 0.2), (0.2, 0.2)], L * 0.6)
		linha(d, [(-0.5, 0.5), (0.0, 0.5)], L * 0.4)

	@ic("vazio")        # lugar sem skill: cadeado simples
	def _(d):
		arco(d, 0, 0.15, 0.3, 0, 180, L * 0.7)
		d.rectangle([*p(-0.42, 0.15), *p(0.42, -0.5)], fill=255)

	@ic("reliquia")     # vaga de reliquia (Etapa 4): gema
	def _(d):
		poligono(d, [(0, 0.8), (0.55, 0.25), (0, -0.8), (-0.55, 0.25)])

	for nome, f in desenhos.items():
		a = novo()
		f(ImageDraw.Draw(a))
		salvar(a, "Icones", nome, brilho=2)


def miras():
	"""formas da mira no chao (decal do URP, Assets/UI/Resources/Mira): miolo fraco + borda forte, branco (cor vem do jogo)"""
	pasta = ROOT / "Mira"
	pasta.mkdir(parents=True, exist_ok=True)

	def gravar(nome, w, h, alfa_de):
		img = Image.new("L", (w, h), 0)
		px = img.load()
		for y in range(h):
			for x in range(w):
				px[x, y] = int(255 * max(0.0, min(1.0, alfa_de(x, y))))
		Image.merge("RGBA", (Image.new("L", (w, h), 255),) * 3 + (img,)).save(pasta / f"{nome}.png")
		print("gerado Mira", nome)

	def borda(d, larg):
		# d = distancia ate a borda (0 na borda, >0 dentro); borda forte + miolo fraco com degrade
		if d < 0:
			return 0.0
		return max(1.0 - d / larg, 0.0) * 0.85 + 0.22 + 0.08 * min(d / (larg * 6), 1.0)

	# circulo: area (raio 1 = metade da textura)
	gravar("T_MiraCirculo", 256, 256, lambda x, y: borda(1 - math.hypot((x + 0.5) / 128 - 1, (y + 0.5) / 128 - 1), 0.05))
	# anel: so o contorno (alcance maximo da mira de area)
	gravar("T_MiraAnel", 256, 256, lambda x, y: max(0.0, 1 - abs(1 - 0.02 - math.hypot((x + 0.5) / 128 - 1, (y + 0.5) / 128 - 1)) / 0.02) * 0.9)

	# cone de 120 graus com a ponta embaixo no meio: x de -1 a 1, y de 0 (ponta) a 1 (raio)
	def cone(x, y):
		u, v = (x + 0.5) / 256 - 1, 1 - (y + 0.5) / 256
		r, a = math.hypot(u, v), math.degrees(math.atan2(abs(u), v))
		return borda(min(1 - r, math.radians(60 - a) * max(r, 0.05)), 0.04)
	gravar("T_MiraCone", 512, 256, cone)

	# faixa (golpe em linha / avanco): largura toda, comprimento todo; setas na ponta indicam a direcao
	def faixa(x, y):
		u, v = (x + 0.5) / 128 - 1, 1 - (y + 0.5) / 512
		dentro = borda(min(1 - abs(u), v, 1 - v) * 0.5, 0.05)
		seta = 0.0
		for c in (0.86, 0.72):
			seta = max(seta, max(0.0, 1 - abs((c - v) - abs(u) * 0.16 - 0.0) / 0.012) * 0.7 if abs(u) < 0.55 else 0.0)
		return max(dentro, seta)
	gravar("T_MiraFaixa", 256, 1024, faixa)


if __name__ == "__main__":
	base()
	icones()
	miras()
