#include <stdio.h>
#include <stdlib.h>

#define MAX 100

int main()
{

    int *array;
    int lunA;

    printf("\nEsercizio 10: allocazione Dinamica di un Vettore di Interi");

    // Input Lunghezza Vettore
    do
    {
        printf("\nInserisci la Lunghezza del Vettore ==> ");
        fflush(stdin);
        scanf("%d",&lunA);

    } 
    while (lunA < 1 || lunA > MAX);
    
    array = (int *)malloc(lunA * sizeof(int));

    // Carico il Vettore
    for(int I=0; I<lunA; I++)
        array[I] = I * 2;

    // Visualizzo il Vettore
    printf("\n\nVettore:");
    for(int I=0; I<lunA; I++)
        printf("\nElemento %d - Valore %d - Indirizzo %p", I+1, array[I], &array[I]);        

    free(array);

    printf("\n\n");

    return 0;

}