#include <stdio.h>
#include <stdlib.h>

int main()
{

    int *pi;
    char *pc;

    printf("\nEsercizio 6: allocazione Dinamica della Memoria");

    /**
     * malloc()
     * 
     * restituisce sempre un puntatore a VOID
     * 
     * - 1° : cast al Tipo di Allocazione richiesto;
     * - 2° : istruzione MALLOC
     * - 3° : la dimesione dell'Area di Memoria
     * 
    */
    
    pi = (int *)malloc(sizeof(int));
    *pi = 15;

    pc = (char *)malloc(sizeof(char));
    *pc = 'Z';

    printf("\nNumero %d - Indirizzo %p", *pi, pi);
    printf("\nCarattereo '%c' - Indirizzo %p", *pc, pc);

    free(pi);
    free(pc);

    printf("\n\n");

    return 0;
}