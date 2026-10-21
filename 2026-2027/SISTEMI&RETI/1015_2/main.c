#include <stdio.h>

int main()
{

    char C;
    int N;

    char *pc;
    int *pn;

    printf("\n\nEsercizio 2 : gestione Puntatori in base la Tipo\n\n");

    pc = &C;
    pn = &N;

    *pc = 'A';
    *pn = 5;

    for(int I=0; I<*pn; I++)
        printf("\n- %c", *pc);

    printf("\n\nValore del Contenuto del Puntatore Intero : %d", *pn);
    printf("\n\nIndirizzo Contenuto nel Puntatore Intero : %p", pn);
    printf("\n\nIndirizzo del Puntatore Intero : %p", &pn);

    printf("\n\nValore del Contenuto del Puntatore Carattere : %c", *pc);
    printf("\n\nIndirizzo Contenuto nel Puntatore Carattere : %p", pc);
    printf("\n\nIndirizzo del Puntatore Carattere : %p", &pc);



    printf("\n\n");

    return 0;
}