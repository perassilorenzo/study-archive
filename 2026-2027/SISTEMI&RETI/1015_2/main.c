#include <stdio.h>

int main(void){
    char c;
    int n;

    char *pc;
    int *pn;

    printf("\n\nEsercizio 2: gestione puntatori in base al tipo");

    pc = &c;
    pn = &n;

    *pc = 'A';
    *pn = 5;

    for (int i = 0; i < *pn; i++){
        printf("\n- %c", *pc);

        printf("\n\nValore del contenuto del puntare intero: %d", *pn);
        printf("\n\nValore contenuto del puntare intero: %p", pn);
        printf("\n\nValore del puntare intero: %p", &pn);
        printf("\n\nValore del contenuto del puntare intero: %c", *pc);
        printf("\n\nValore del contenuto del puntare intero: %p", pc);
        printf("\n\nValore del contenuto del puntare intero: %p", &pc);
    }
}