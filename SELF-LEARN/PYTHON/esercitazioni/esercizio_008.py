# Generatore di Istogrammi

lista = []

# Chiedere i numeri all'utente
while True:
    try:
        elemento = input("Inserisci i valori da analizzare o digita STOP: ")
        if elemento.lower() == "stop":
            break
        lista.append(int(elemento))
    except ValueError: 
        print("Devi inserire solo numeri interi!")

# Stampare l'istogramma
for i in lista:
    print("*" * i)  # Stampa il numero di asterischi corrispondente al valore