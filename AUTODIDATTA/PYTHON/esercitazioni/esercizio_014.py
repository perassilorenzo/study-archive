#Il Geometra

def area():

    while True:

        print("Questo programma calcola l'area del cerchio, del quadrato, del rettangolo e del triangolo.")

        while True:
            try:
                area = str(input("Digitare la figura geometrica la quale si vuole calcolare l'area: "))
                break
            except ValueError:
                print("Inserire tra cerchio, quadrato, rettangolo e triangolo!")
        
        if area.lower() == "cerchio":
            while True:
                try:
                    r = float(input("Inserire il raggio del cerchio: "))
                    break
                except ValueError:
                    print("Devi inserire numeri!")
            print(f"L'area è {3.14 * r * r}")
            break

        elif area.lower() == "quadrato":
            while True:
                try:
                    l = float(input("Inserire il lato del quadrato: "))
                    break
                except ValueError:
                    print("Devi inserire numeri!")
            print(f"L'area è {l * l}")
            break

        elif area.lower() == "rettagolo":
            while True:
                try:
                    b = float(input("Inserire la base del rettangolo: "))
                    h = float(input("Inserire l'altezza del rettangolo: "))
                    break
                except ValueError:
                    print("Devi inserire numeri!")
            print(f"L'area è {b * h}")
            break

        elif area.lower() == "triangolo":
            while True:
                try:
                    b = float(input("Inserire la base del triangolo: "))
                    h = float(input("Inserire l'altezza del triangolo: "))
                    break
                except ValueError:
                    print("Devi inserire solo numeri!")
            print(f"L'area è {b * h / 2}")
            break

        else: continue
    
area()