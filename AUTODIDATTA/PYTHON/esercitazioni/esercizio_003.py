#Scrivi un programma che, data una lista di numeri, fornisca in output il maggiore tra tutti gli elementi della lista.

print("Inserisci 3 valori.")

# Creazione della lista con input utente
numeri = [
    int(input("Primo valore:\n")),
    int(input("Secondo valore:\n")),
    int(input("Terzo valore:\n"))
]

# Trova il numero maggiore
numero_maggiore = numeri[0]
for numero in numeri:                      #numero → È una variabile temporanea che assume, a ogni iterazione, il valore di un elemento della lista numeri
    if numero > numero_maggiore:
        numero_maggiore = numero

# Stampa il risultato
print("Il numero maggiore tra tutti è:", numero_maggiore)