# Trova ASCII

def trova_ascii():

    while True:
        try:
            carattere = int(input( "Inserire un numero tra 0 e 97 per trovare il corrispondente in ASCII."))
            
            if carattere < 0 and carattere > 97:
                continue

            else:
                break

        except ValueError:
            print(" Il valore deve essere un numero intero.")

    valore = ord(carattere)

    output = f"Il valore ASCII associato a {carattere} è {valore}."

    return output

trova_ascii()