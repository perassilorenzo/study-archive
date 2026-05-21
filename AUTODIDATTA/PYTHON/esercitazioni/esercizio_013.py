#Il Signore del Tempo

def sec():
    print("Inserire il tempo da calcolare.")

    while True:

        try:
            giorni = float(input("Giorni: ")) * 24 * 3600
            ore = float(input("Ore: ")) * 3600
            minuti = float(input("Minuti: ")) * 60
            break
        except ValueError:
            print("Devono essere numeri!")

    print(f"I valori dati in secondi sono {giorni+ore+minuti}")