#Il Frequenzimetro

def freq(str):

    mappa = {}

    for i in str:
        if i in mappa:
            mappa[i] += 1
    return mappa