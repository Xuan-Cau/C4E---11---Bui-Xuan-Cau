
from turtle import *

def draw_star (x, y,length):
    
    forward (1)
    
    penup()
    forward (x-1)
    left (90)
    forward (y)

    pendown()
    for i in range (5) :
        forward (length)
        left (144)

speed(0)
color('blue')
for i in range(100):
    import random
    x = random.randint(-300, 300)
    y = random.randint(-300, 300)
    length = random.randint(3, 10)
    draw_star(x, y, length)




