#Scrivi un programma che chieda all'utente una stringa composta da un solo carattere e dica se si tratta di una vocale oppure no.

print("Inserisci una stringa di una lettera.")

# Chiede all'utente di inserire un solo carattere
lettera = input("Inserisci una lettera:\n").lower()  # .lower() → Converte una stringa in minuscolo, le parentesi servono per indicare la funzione

# Controlla se è una vocale
if len(lettera) == 1 and lettera in "aeiou":         # len() → Restituisce la lunghezza di una stringa o di una lista, le parentesi servono per mettere l'argomento
    print("La lettera è una vocale.")
elif len(lettera) != 1:
    print("Errore: devi inserire un solo carattere.")
else:
    print("La lettera non è una vocale.")