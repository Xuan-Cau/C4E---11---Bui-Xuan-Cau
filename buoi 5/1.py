from turtle import*

a = int(input ("Enter into lengt"))
 
cho_color = input ("Enter into color?")


def draw_square (a,cho_color):
    for i in range (4) :
        color (str(cho_color))
        forward (a)
        left (90)
        
draw_square (a,cho_color)

for i in range(30):
    draw_square(i * 5, 'red')
    left(17)
    penup()
    forward(i * 2)
    pendown()
