#include <stdio.h>
#include <stdlib.h>

#define MAX_LENGTH 100

int main()
{
    int *array;
    int arrayLength;

    printf("\nEsercizio 10: allocazione Dinamica di un Vettore di Interi");

    // Input Lunghezza Vettore
    do
    {
        printf("\nInserisci la Lunghezza del Vettore >>> ");
        fflush(stdin);
        scanf("%d", &arrayLength);

    } while (arrayLength < 1 || arrayLength > MAX_LENGTH);
    
    array = (int *)malloc(arrayLength * sizeof(int));

    // Carico il Vettore
    for(int i = 0; i < arrayLength; i++)
        array[i] = i * 2;

    // Visualizzo il Vettore
    printf("\n\nVettore:");
    for(int i = 0; i < arrayLength; i++)
        printf("\nElemento %d - Valore %d - Indirizzo %p", i + 1, array[i], &array[i]);        

    free(array);
    printf("\n\n");

    return 0;

}