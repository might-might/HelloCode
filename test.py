from random import randint

counter = 0

xa = 40
ya = 1
xb = 1
yb = 30
xc = 80
yc = 30
x = xa
y = xb

while counter < 10:
    i = randint(0, 3)
    if i == 0:
        x = (x + xa) / 2
        y = (y + ya) / 2
    if i == 1:
        x = (x + xb) / 2
        y = (y + yb) / 2
    if i == 3:
        x = (x + xc) / 2
        y = (y + yc) / 2
    counter += 1
    print(x, y)