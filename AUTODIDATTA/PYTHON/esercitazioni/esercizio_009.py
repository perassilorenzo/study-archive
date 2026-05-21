#Scriviamo la nostra versione di len()

# Chiedere all'utente di inserire numeri in una lista
lista = []

while True:
    try:
        elemento = input("Inserisci i valori da analizzare o digita STOP: ")
        if elemento.lower() == "stop":
            break
        lista.append(int(elemento))
    except ValueError: 
        print("Devi inserire solo numeri interi!")

# Funzione personalizzata per calcolare la lunghezza
def mia_len(sequenza):
    count = 0
    for _ in sequenza:  # Conta ogni elemento nella lista
        count += 1
    return count

# Output della lunghezza della lista
print(f"La lunghezza della lista è: {mia_len(lista)}")