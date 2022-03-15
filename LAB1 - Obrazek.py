import turtle

t = turtle.Turtle()
screen = turtle.Screen()
screen.setup(width=800, height=500)
screen.bgcolor('black')
screen.tracer(False)



def slonce():
 t.penup() 
 t.goto(300, 130)
 t.fillcolor("yellow")
 t.pendown()
 t.begin_fill()
 t.circle(50)
 t.end_fill()

def pien():
    t.penup() 
    t.goto(-155, -200)
    t.pendown()
    t.color("brown")
    t.begin_fill()
    t.forward(50)
    t.right(90)
    t.forward(400)
    t.right(90)
    t.forward(50)
    t.right(90)
    t.forward(400)
    t.end_fill()

def korona_drzewa():
    t.penup() 
    t.goto(-180, -50)
    t.pendown()
    t.backward(100)
    t.left(90)
    t.color('green')
    t.begin_fill()
    t.circle(80)
    t.end_fill()


def trawa():
    t.home()
    t.backward(400)
    t.right(90)
    t.forward(300)
    t.begin_fill()
    t.color('lightgreen')
    t.left(90)
    t.forward(800)
    t.left(90)
    t.forward(100)
    t.left(90)
    t.forward(800)
    t.end_fill()

def domek():
    t.penup() 
    t.goto(50, 0)
    t.pendown()
    t.begin_fill()
    t.color('#e6e6e6')
    t.forward(200) 
    t.right(90)
    t.forward(200)
    t.right(90)
    t.forward(200)
    t.right(90)
    t.forward(200)
    t.end_fill()

def dach():
    t.penup() 
    t.goto(50,0)
    t.pendown()
    t.begin_fill()
    t.color('red')
    t.forward(200)
    t.left(120)
    t.forward(200)
    t.left(120)
    t.forward(200)
    t.left(120)
    t.end_fill()
  
def okno1():
  t.penup() 
  t.goto(210,-95)
  t.pendown()
  t.begin_fill()
  t.color('yellow')
  t.forward(40)
  t.left(90)
  t.forward(40)
  t.left(90)
  t.forward(40)
  t.left(90)
  t.forward(40)
  t.left(90)
  t.end_fill()

def okno2():
  t.penup() 
  t.goto(135,-95)
  t.pendown()
  t.begin_fill()
  t.color('yellow')
  t.forward(40)
  t.left(90)
  t.forward(40)
  t.left(90)
  t.forward(40)
  t.left(90)
  t.forward(40)
  t.left(90)
  t.end_fill()

def drzwi():
  t.penup() 
  t.goto(172.5,-200)
  t.pendown()
  t.begin_fill()
  t.color('orange')
  t.forward(60)
  t.left(90)
  t.forward(40)
  t.left(90)
  t.forward(60)
  t.left(90)
  t.forward(40)
  t.left(90)
  t.end_fill()

slonce()
trawa()
pien()
korona_drzewa()
dach()
domek()
okno1()
okno2()
drzwi()



screen.update()
screen.exitonclick()

