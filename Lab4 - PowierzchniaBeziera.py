import math
import os

POINTS_FILENAME = os.path.dirname(os.path.abspath(__file__)) + "\\" + "points.txt"
OUT_POINTS_FILENAME = os.path.dirname(os.path.abspath(__file__)) + "\\" + "out_points.txt"
MATRIX_R = MATRIX_C = 4

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


#Implementacja powierzchni Beziera
def powierzchniaBeziera(punkty, kkrok):
    n = len(punkty) - 1
    wynik = []


    def punkt(u, v, nearPoints):
        x = 0
        y = 0
        z = 0 
        for i in range(MATRIX_R):
            bi = wbernsteina(MATRIX_R - 1, i, v)
            for j in range(MATRIX_C):
                bj = wbernsteina(MATRIX_C - 1, j, u)
                if len(nearPoints[i][j]) != 0:
                    x += float(nearPoints[i][j][0]) * bi * bj
                    y += float(nearPoints[i][j][1]) * bi * bj
                    z += float(nearPoints[i][j][2]) * bi * bj
                    
        return [round(x, 5), round(y, 5), round(z, 5)]

    z = 0
    for i in range(0, int((n + 1) / (MATRIX_C * MATRIX_R)) ):

        matrix = [[[] for i in range(MATRIX_C)] for i in range(MATRIX_R)]    
        for x in range(0, MATRIX_R):
            for y in range(0, MATRIX_C):   
                if z <= n + 1:
                    matrix[x][y] = punkty[z]
                    z += 1
                
        fact = (1.0/kkrok)
        for u in range(0, kkrok+1):
            u_ = u * fact
            for v in range(0, kkrok+1):
                v_ = v * fact
                wynik.append( punkt(u_, v_, matrix) )
    
    return wynik

# zczytywanie danych z pliku points
def wczytajPunkty(filename):
    file = open(filename, "r")
    punkty = []
    for line in file.readlines():
        punkty.append(line.split())
    return punkty
#konwertowanie
def kPunkty(punkty):
    out = ""
    for punkt in punkty:
        for punkt_pos in punkt:
            out += str(punkt_pos) + " "
        out += "\n"
    return out
#wpisywanie do pliku
def write_to_file(punkty, filename):
    file = open(filename, "w")
    file.write(punkty)

punkty = powierzchniaBeziera(wczytajPunkty(POINTS_FILENAME), 60)
write_to_file(kPunkty(punkty), OUT_POINTS_FILENAME)