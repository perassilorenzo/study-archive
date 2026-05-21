#Indovina il numero

while True:

    import random
    print("Benvenuto a Indovina il numero!\n")
    message="""Inserisci la difficoltà tra:
    - Facile: seleziona 1;
    - Medio: seleziona 2;
    - Difficile: seleziona 3.
    Per uscire dal gioco digitare un tasto.
    """
    print(message)
    difficoltà=input("Scegli tra 1, 2 e 3\n")

    if difficoltà=="1":
        val=random.randint(1,10)
        print("Indovina il numero tra 1 e 10.")
    elif difficoltà=="2":
        val=random.randint(1,20)
        print("Indovina il numero tra 1 e 20.")
    elif difficoltà=="3":
        val=random.randint(1,30)
        print("Indovina il numero tra 1 e 30.")
    else:
        print("Grazie per aver giocato")
        break
    
    #print(val)      #verifica

    count=0

    for n in range(3):
        prova=int(input(""))
        if prova==val:
            print("Hai vinto!")
            break
        else:
            pos=int(3-n)
            if pos==0:
                print("Hai perso! Il numero era "+str(val)+".")
                break
            else:
                print("Hai ancora "+str(pos)+" possibilità!")
                count+=1

    difficoltà=input("Vuoi ancora giocare? Premere Spazio per continuare o un qualsiasi tasto per chiudere.\n")

    if difficoltà==(" "):
        continue
    else:
        print("A presto!")
        break