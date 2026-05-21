#Moltiplicatore Inarrestabile

moltiplicazione = 1  # Inizializziamo a 1 perché 1 è l'elemento neutro della moltiplicazione
lista = []

while True:
    try:
        numero = input("Inserisci un numero da moltiplicare o digita STOP: ")
        if numero.lower() == "stop":
            break
        lista.append(int(numero))  # Converte il numero e lo aggiunge alla lista
    except ValueError:
        print("Inserisci solo numeri interi!")

# Se la lista è vuota, evitiamo di moltiplicare
if lista:           # è uguale a "if bool(lista) == True:" quindi se la lista è piena è true altrimenti è falsa     
    for num in lista:  # Iteriamo direttamente sugli elementi della lista
        moltiplicazione *= num

    print(f"Il risultato della moltiplicazione è: {moltiplicazione}")
else:
    print("Nessun numero inserito, impossibile calcolare la moltiplicazione.")