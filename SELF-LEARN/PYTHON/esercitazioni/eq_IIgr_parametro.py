# Equazioni di II Grado

import math
from fractions import Fraction

print("Questo programma risolve le equazioni di II grado.")
message = "Vuoi continuare? Premi spazio e invio!"

while True:
    if input(message) == " ":
        while True:
            try:
                count = 0

                a = input("Inserire il valore di a: ")

                a = float(Fraction(a))

                if a.is_integer():
                    a = int(a)

                frza = Fraction(a).limit_denominator()

                if a == 0:
                    print(f"0 = 0")
                else:
                    print(f"{frza}x^2 = 0")



                b = str(input("Inserire il valore di b: "))

                b = float(Fraction(b))

                if b.is_integer():
                    b = int(b)

                frzb = Fraction(b).limit_denominator()

                if b < 0:
                    if a == 0:
                        print(f"{frzb}x = 0")
                    else:
                        print(f"{frza}x^2 {frzb}x = 0")
                elif b > 0:
                    if a == 0:
                        print(f"{frzb}x = 0")
                    else:
                        print(f"{frza}x^2 + {frzb}x = 0")
                elif b == 0:
                    if a == 0:
                        print(f"0 = 0")
                    else:
                        print(f"{frza}x^2 = 0")

                c = str(input("Inserire il valore di c: "))

                c = float(Fraction(c))

                if c.is_integer():
                    c = int(c)

                frzc = Fraction(c).limit_denominator()

                if c<0:
                    if a == 0:
                        if b == 0:
                            print(f"{frzc} = 0")
                        else:
                            print(f"{frzb}x {frzc} = 0")
                    else:
                        if b == 0:
                            print(f"{frza}x^2 {frzc} = 0")
                        elif b < 0:
                            print(f"{frza}x^2 {frzb}x {frzc} = 0")
                        else:
                            print(f"{frza}x^2 + {frzb}x {frzc} = 0")                

                elif c > 0:
                    if a == 0:
                        if b == 0:
                            print(f"{frzc} = 0")
                        else:
                            print(f"{frzb}x + {frzc} = 0")
                    else:
                        if b == 0:
                            print(f"{frza}x^2 + {frzc} = 0")
                        elif b < 0:
                            print(f"{frza}x^2 {frzb}x + {frzc} = 0")
                        else:
                            print(f"{frza}x^2 + {frzb}x + {frzc} = 0")
                else:
                    if a == 0:
                        if b == 0:
                            print("0 = 0")
                        else:
                            print(f"{frzb}x = 0")
                    else:
                        if b == 0:
                            print(f"{frza}x^2 = 0")
                        elif b < 0:
                            print(f"{frza}x^2 {frzb}x = 0")
                        else:
                            print(f"{frza}x^2 + {frzb}x = 0")

                break
            
            except ValueError:
                print("I valori devono essere numeri!")

        delta = b*b-(4*a*c)

        if a == 0:
            if c == 0 and b == 0 :
                print("E' un equazione indeterminata.")
            elif b == 0:
                print("E' un equazione impossibile.")
            else:
                x = -c/b
                if x == 0:
                    x = 0

                x = Fraction(x).limit_denominator()

                print(f"E' un equazione di primo grado e il risultato è: {x}") 
        else:
            if delta < 0:
                print("L'equazione è impossibile, non ha soluzioni.")
            elif delta == 0:
                x = -b / (2 * a)
                if x == 0:
                    x = 0

                x = Fraction(x).limit_denominator()

                print(f"Esiste una soluzione doppia che è {x}.")
            else:
                x1 = (-b + math.sqrt(delta))/(2*a)
                x2 = (-b - math.sqrt(delta))/(2*a)
                if x1 == 0:
                    x1 = 0
                if x2 == 0:
                    x2 = 0
                
                x1 = Fraction(x1).limit_denominator()

                if x1.denominator > 100 or x1.numerator > 100:
                    x1 = float(x1)
                    x1 = round(x1, 2)

                x2 = Fraction(x2).limit_denominator()

                if x2.denominator > 100 or x2.numerator > 100:
                    x2 = float(x2)
                    x2 = round(x2, 2)

                print(f"Ci sono due soluzioni distinte che sono rispettivamente {x1} e {x2}.")

    else:
        break