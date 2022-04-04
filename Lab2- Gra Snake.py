import pygame as pg
import time
import random


# klasa Plansza odpowiada za przygotowanie pola do gry
class Plansza:
    pg.init()
    pg.display.set_caption('Snake')
    szer = 500
    wys = 500
    okno = pg.display.set_mode([szer, wys])
    zegar = pg.time.Clock()
    szybkosc = 10
    snake = 10
    dlugosc_weza = 1

    # funkcja pokazująca napis po porażce
    def porazka(self):
        wiadomosc = pg.font.SysFont(None, 60).render('Przegrana', True, (255,8,8))
        Plansza.okno.blit(wiadomosc, [150, 150])

    # funkcja pokazująca zdobyte ounkty
    def punkty(self, pkt):
        wynik = pg.font.SysFont(None, 40).render('Zdobyte pkt: ' + str(pkt), True, (255,8,8))
        Plansza.okno.blit(wynik, [0, 0])


# klasa Waz tworzy węża oraz rysuje go na planszy
class Waz:
    def __init__(self, snake, lista):
        self.snake = snake
        self.lista = lista

    def nowy(self, snake, lista):
        for x in lista:
            pg.draw.rect(Plansza.okno, (0, 255, 0), [x[0], x[1], snake, snake])


class Gra:
    # funkcja odpowiadająca za uruchomienie gry
    def gra_start(self):
        plansza = Plansza()
        start = True
        x1 = plansza.szer / 2
        y1 = plansza.wys / 2

        # zmienne pomocniczne, wykorzystane w sterowaniu
        zmiana_x = 0
        zmiana_y = 0

        lista = []

        # losowanie współrzędnych gdzie pojawi się jedzenie
        jedzenie_x = round(random.randrange(0, plansza.szer - plansza.snake) / 10) * 10
        jedzenie_y = round(random.randrange(0, plansza.wys - plansza.snake) / 10) * 10

        # sterowanie wężem
        while start:
            for event in pg.event.get():
                if event.type == pg.QUIT:
                    start = False
                if event.type == pg.KEYDOWN:
                    if event.key == pg.K_LEFT:
                        zmiana_x = -plansza.snake
                        zmiana_y = 0
                    elif event.key == pg.K_RIGHT:
                        zmiana_x = plansza.snake
                        zmiana_y = 0
                    elif event.key == pg.K_UP:
                        zmiana_y = -plansza.snake
                        zmiana_x = 0
                    elif event.key == pg.K_DOWN:
                        zmiana_y = plansza.snake
                        zmiana_x = 0

            # uderzenie wężem w ścianę planszy kończy gre
            if x1 >= plansza.szer or x1 < 0 or y1 >= plansza.wys or y1 < 0:
                start = False

            # poruszanie węża
            x1 += zmiana_x
            y1 += zmiana_y
            plansza.okno.fill((0, 0, 0))
            pg.draw.rect(plansza.okno, (0, 191, 255), [jedzenie_x, jedzenie_y, 10, 10])


            # zjadanie ogona węża
            glowa = []
            glowa.append(x1)
            glowa.append(y1)
            lista.append(glowa)
            if len(lista) > plansza.dlugosc_weza:
                del lista[0]

            # dotknięcie głowy węża kończy gre
            for x in lista[:-1]:
                if x == glowa:
                    start = False

            # inicjalizacja gry
            Snake = Waz(plansza.snake, lista)
            Snake.nowy(plansza.snake, lista)
            plansza.punkty(plansza.dlugosc_weza - 1)

            pg.display.update()

            # powiększanie się węża po zjedzeniu pokarmu
            if x1 == jedzenie_x and y1 == jedzenie_y:
                jedzenie_x = round(random.randrange(0, plansza.szer - plansza.snake) / 10) * 10
                jedzenie_y = round(random.randrange(0, plansza.wys - plansza.snake) / 10) * 10
                plansza.dlugosc_weza += 1
                plansza.szybkosc += 1

            plansza.zegar.tick(plansza.szybkosc)
        plansza.porazka()
        pg.display.update()
        time.sleep(1)

        pg.quit()
        quit()


gra = Gra()
gra.gra_start()