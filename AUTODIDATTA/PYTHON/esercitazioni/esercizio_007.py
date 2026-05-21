#Solamente per Soci

lista = []

# Chiedere un valore da verificare
while True:
    try:
        valore = int(input("Inserire un valore da verificare: "))  # Convertire subito in int
        break
    except ValueError:
        print("Deve essere un valore intero!")

# Inserire elementi nella lista
while True:
    try:
        elemento = input("Inserisci un numero da mettere all'interno della lista o digita STOP: ")
        if elemento.lower() == "stop":  # Correzione qui
            break
        lista.append(int(elemento))
    except ValueError:
        print("Inserisci solo numeri interi!")

# Controllare se il valore è presente nella lista
if valore in lista:
    print(f"Il valore {valore} è presente nella lista all'indice: {lista.index(valore)}")
else:
    print(f"Il valore {valore} NON è presente nella lista.")