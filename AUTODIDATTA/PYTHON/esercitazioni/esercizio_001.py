#Scrivi un programma che chieda due numeri all'utente tramite la funzione input e mostri il più grande tra i due utilizzando la funzione print. Per quanto Python disponga di una funzione max(), siete invitati ad utilizzare le istruzioni if, elif ed else per la scrittura dell'algoritmo.

rint("Inserire due valori per scoprirne il maggiore.")

# Chiede due numeri all'utente
while True:
    try:                                                    #try: → Qui mettiamo il codice che potrebbe generare un errore
        n1 = int(input("Primo valore:\n"))
        n2 = int(input("Secondo valore:\n"))
        break  # Esce dal ciclo se l'input è corretto       #except ValueError: → Se l'errore è un ValueError (ad esempio, l'utente scrive "ciao" invece di un numero), il programma non si blocca ma mostra un messaggio di errore
    except ValueError:
        print("Errore: inserire solo numeri interi.")

# Confronto dei due numeri
if n1 == n2:
    print("I valori sono uguali.")
elif n1 < n2:
    print(f"Il valore maggiore è {n2}")
else:
    print(f"Il valore maggiore è {n1}")