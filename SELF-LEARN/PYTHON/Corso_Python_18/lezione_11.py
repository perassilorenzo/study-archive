#le funzioni

def say_my_name():
    name=input("Come ti chiami?\n")
    print("Il tuo nome è: ", name)

say_my_name()

def addizione(a,b):
    print("Questa è la funzione addizione.")
    print("Fornisce la somma di due numeri passati come parametri.")
    ris=a+b
    print("Il risultato dell'addizione è: ", str(ris))

addizione(15, 5)

def laptop_new(ram, cpu, antivirus =False):
    print("Il laptop nuovo avrà le seguenti caratteristiche:\n")
    print("- RAM: ", ram)
    print("- CPU: ", cpu)

    if antivirus==True:
        print("Hai comprato anche un antivirus!")

laptop_new("16GB", "i7", antivirus =True)

def addizione2(a, b):
    risultato=a+b
    return risultato

risultato=addizione2(3,3)
print(risultato)
print(addizione(21,9))