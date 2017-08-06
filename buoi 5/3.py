

from turtle import *

length = int(input("length:"))
x = int (input ("left or right"))
    
y = int (input ("up or down"))
def draw_star (length):
    
    forward (1)
    
    penup()
    forward (x-1)
    left (90)
    forward (y)
    pendown()
    for i in range (5) :
        forward (length)
        left (144)
    

       
draw_star (length)

