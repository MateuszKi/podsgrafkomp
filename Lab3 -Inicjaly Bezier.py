import math
from PIL import Image
from PIL import ImageDraw

#Implementacja symbolu newtona.
def snewton(n, k):
    if k == 1: return n

    n_silnia = 1
    for x in range(1, n):
        n_silnia += n_silnia * x

    k_silnia = 1
    for x in range(1, k):
        k_silnia += k_silnia * x

    nk_silnia = 1
    for x in range(1, n - k):
        nk_silnia += nk_silnia * x

    return n_silnia/(k_silnia*nk_silnia)

#implementacja wielomianu bersteina
def wbernsteina(n, i, t):
    return snewton(n, i) * math.pow(t, i) * math.pow(1 - t, n - i)

#Implementacja krzewej Beziera
def bezierCurve(punkty, kkrok):
    n = len(punkty) - 1
    wynik = []


    def punkt(t):
        x = 0
        y = 0
        for i in range(0, n + 1):
            x += punkty[i][0] * wbernsteina(n,i,t)
            y += punkty[i][1] * wbernsteina(n,i,t)
        return (x, y)


    for x in range(0, kkrok+1):
        t = x * (1.0/kkrok)
        wynik.append( punkt(t) )
    
    return wynik

img_size = 500
img = Image.new("RGB", (img_size, img_size))
draw = ImageDraw.Draw(img)

draw.rectangle([0,0,img_size, img_size], fill="#fff")
#Budowanie inicjałów
literaM = [
  bezierCurve([(167, 402), (186, 87)], 50),
  bezierCurve([(180, 73), (237, 197)], 50),
  bezierCurve([(229, 209), (301, 103)], 50),
  bezierCurve([(300,88), (303, 391)], 50),
    
]

for x in literaM:
    draw.line(x, fill='black', width=1)

literaK = [
  bezierCurve([(399, 394), (373, 94)], 50),
  bezierCurve([(374, 255), (497, 120)], 50),
  bezierCurve([(511, 383), (382, 247)], 50),

]

for x in literaK:
   draw.line(x, fill='black', width=1)

img.show()