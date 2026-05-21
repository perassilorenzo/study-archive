#Somma Inarrestabile

somma = 0
lista = []

while True:
    try:
        numero = input("Inserisci un numero (o 'stop' per terminare): ")
        if numero.lower() == "stop":
            break  # Esce dal ciclo se l'utente scrive 'stop'
        lista.append(int(numero))  # Converte il numero e lo aggiunge alla lista
    except ValueError:
        print("Errore! Inserisci solo numeri interi.")

# Calcola la somma
somma = sum(lista)
print(f"La somma dei numeri inseriti è: {somma}")