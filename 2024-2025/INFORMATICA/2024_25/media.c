#include <stdio.h>      //serve a includere una libreria
#include <math.h>       //serve a includere una libreria

/* questo è il mio
primo programma */



int main()      //inizio la funzione princiopale
{
    int n1, n2;     // ho dichiarato le variablili per indicare i numeri interi
    int res; // ho dichiarato la variabile per l'output

    printf("Inserisci il primo numero: ");        // messaggio per l'utente
    scanf("%d", &n1);       // prendo il numero digirato e lo metto in n1

    printf("Inserisci il secondo numero: ");        // messaggio per l'utente
    scanf("%d", &n2);       // prendo il numero digirato e lo metto in n1

    res = (n1 + n2) / 2;        // ho calcolato la media e l'ho salvata in res

    printf("La media dei due numeri e': %d", res);      // mostro il risultato





return 0;
}
