#creare una calcolatrice

from math import sqrt

hello_message= '''
Benvenuti al programma calcolatrice!

Di seguito un elenco delle varie funzioni di  disponibili:

- Per effettuare un'ADDIZIONE, seleziona 1;
- Per effettuare una SOTTRAZIONE, seleziona 2;
- Per effettuare una MOLTIPLICAZIONE, seleziona 3;
- Per effettuare una DIVISIONE, seleziona 4;
- Per effettuare un CALCOLO ESPONENZIALE, seleziona 5;
- Per effettuare una RADICE QUADRATA, seleziona 6;
- Per uscire dal programma digitare ESC.
'''

while True:
    print(hello_message)

    action=input("Inserisci il numero corrispondente all'operazione da effettuare:\n")

    if action=='1':
        print('\nHai scelto ADDIZIONE\n')
        a=float(input('Inserisci il primo numero -> '))
        b=float(input('\nInserisci il secondo numero -> '))
        print("Il risultato dell'ADDIZIONE è: ", str(a+b))

    elif action=='2':
        print('\nHai scelto SOTTRAZIONE\n')
        a=float(input('Inserisci il primo numero -> '))
        b=float(input('\nInserisci il secondo numero -> '))
        print("Il risultato della SOTTRAZIONE è: ", str(a-b))

    elif action=='3':
        print('\nHai scelto MOLTIPLICAZIONE\n')
        a=float(input('Inserisci il primo numero -> '))
        b=float(input('\nInserisci il secondo numero -> '))
        print("Il risultato della MOLTIPLICAZIONE è: ", str(a*b))

    elif action=='4':
        print('\nHai scelto DIVISIONE\n')
        a=float(input('Inserisci il primo numero -> '))
        b=float(input('\nInserisci il secondo numero -> '))
        print("Il risultato della DIVISIONE è: ", str(a/b))

    elif action=='5':
        print('\nHai scelto CALCOLO ESPONENZIALE\n')
        a=float(input('Inserisci la base -> '))
        b=float(input("\nInserisci l'esponente -> "))
        print("Il risultato del CALCOLO ESPONENZIALE è: ", str(a**b))

    elif action=='6':
        print('\nHai scelto RADICE QUADRATA\n')
        a=float(input('Inserisci il numero -> '))
        print("Il risultato della RADICE QUADRATA è: ", str(sqrt(a)))

    elif action=='ESC':
        print("\nL'applicazione verrà chiusa.\n")
        break


    new_action=input("\nDesideri continuare ad utilizzare l'applicazione? S/N ")
    if new_action== "S" or new_action=="s":
        print("Sto tornando indietro\n")
        continue
    else: 
        print("A presto!\n")
        break