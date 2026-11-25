#Funzione Genera MAC
import random

def genera_mac():
    print("Questo programma genera un indirizzo MAC pseudo-casuale.")

    # Generiamo 6 coppie di valori esadecimali (0-9, A-F)
    mac = ":".join(f"{random.choice('0123456789ABCDEF')}{random.choice('0123456789ABCDEF')}" for _ in range(6))
    
    print(f"L'indirizzo MAC generato è: {mac}")

# Chiamata della funzione
genera_mac()