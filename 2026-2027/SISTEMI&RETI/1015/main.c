#include <stdio.h>
#include <stdlib.h>

int main()
{

    int N;
    int *p;

    printf("\nEsercizio 1: utilizzo dei Puntatori");

    N = 10;
    p = &N;

    printf("\n\nValore di N: %d", N);
    printf("\n\nValore di p: %p", &N);

    printf("\n\nValore del Contenuto del Puntatore : %d", *p);
    printf("\n\nIndirizzo Contenuto nel Puntatore : %p", p);
    printf("\n\nIndirizzo del Puntatore : %p", &p);

    // Cambio del Contenuto di un Puntatore
    *p = *p * 2;
    *p *= 2;
    printf("\n\nValore del Contenuto del Puntatore : %p", *p);
    printf("\n\nValore del Contenuto del Puntatore : %d", *p);

    printf("\n\n");

    return 0;
}