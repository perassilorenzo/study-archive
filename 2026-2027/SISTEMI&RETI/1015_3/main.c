#include <stdio.h>

int main()
{

    int vet[5] = {10, 20, 30, 40, 50};
    int *p;

    printf("\n\nEsercizio 3: gestione Vettori con Puntatori\n\n");

    // p = vet[0]; // Versione "grezza" / "grossolana"
    p = vet;

    for(int I=0; I<5; I++) {
        printf("\n - elemento %d - valore %d - indirizzo %p", I+1, *p, p);
        p++; // FONDAMENTALE !!!!
    }


    printf("\n\n");

    return 0;

}
