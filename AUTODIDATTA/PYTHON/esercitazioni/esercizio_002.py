#Scrivi un programma che chieda tre numeri a, b, c all'utente e mostri il più grande tra loro.

print("Inserire tre numeri per scoprire il maggiore.")

# Chiede tre numeri all'utente
while True:
    try:
        n1 = int(input("Inserire il primo valore: "))
        n2 = int(input("Inserire il secondo valore: "))
        n3 = int(input("Inserire il terzo valore: "))
        break  # Esce dal ciclo se l'input è corretto
    except ValueError:
        print("Errore: inserire solo numeri interi.")

# Confronto dei tre numeri
if n1 == n2 == n3:
    print("I valori sono tutti uguali.")
elif n1 > n2 and n1 > n3:
    print(f"Il valore maggiore è {n1}")     #utilizzo di f string
elif n2 > n1 and n2 > n3:
    print(f"Il valore maggiore è {n2}")
else:
    print(f"Il valore maggiore è {n3}")