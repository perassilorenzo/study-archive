# Print senza andare a capo

def print_senza_andare_a_capo():

    valore = str(input("Inserisci una stringa: "))
    
    while valore != " ":
        print(valore, end = " ")
        valore = str(input("Inserisci una stringa: "))

print_senza_andare_a_capo()