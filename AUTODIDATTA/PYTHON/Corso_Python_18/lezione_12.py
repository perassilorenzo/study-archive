#variabili globali e locali

x = 15  #variabile globale

def funzione_esempio():

    #x += 2     #non funziona perché si distrugge la variabile tra global e local
    
    return x

print(funzione_esempio())

#soluzione

x=15

def funzione_esempio():
    global x
    x+=2
    return x



def mia_funzione():
    val=24
    print(val)

#new_val= val+6     #val non definita

#soluzione

def mia_funzione():
    val=24
    return val

new_val= mia_funzione()+6
print(new_val)