x = int(input("Please input the length  of one side of the crystal: "))
y = int(input("Please input the length of a side attached to the one already measured: "))
A = int(input("Please input the angle between these 2 sides. If the angle is 90 degrees input the number 90, etc...: "))

if A ==90:
    if x == y:
        print("The crystal is square")
    else:
        print("The crystal is rectangular")

elif A == 60 or A == 120:
    print("The crystal hexagonal")
   
else:
    if x==y:
        print("The crystal is rhombic")
    else:
        print("The crystal Parallelogram")


