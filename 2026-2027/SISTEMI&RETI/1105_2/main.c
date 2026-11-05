#include <stdio.h>

int main() {
    int n;
    int *p;

    printf("Implemento l'elevamento al Quadrato tramite Puntatori");

    p = &n;

    printf("\nInserisci il numero da elevare al quadrato\n>>> ");
    fflush(stdin);
    scanf("%d", p);

    printf("\nRisultato: %d", (*p) * (*p));

    return 0;
}