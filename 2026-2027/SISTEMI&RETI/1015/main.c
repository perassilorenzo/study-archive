#include <stdio.h>
#include <stdlib.h>

int main(){
    int n;
    int *p;

    printf("\nEsercizio 1: utilizzo dei puntatori\n");

    n = 10;
    p = &n;
    
    printf("\nValore di n: %d", n);
    printf("\nValore di p: %p", &n);

    printf("\n\nValore del contenuto del puntatore: %d", *p);
    printf("\n\nIndirizzo contenuto nel puntatore: %d", p);
    printf("\n\nIndirizzo del puntatore: %p", &p);

    // cambio contenuto del puntatore

    *p *= 2;

    printf("\n\nValore del contenuto %p", *p);

    printf("\n\n");
    return 0;
}