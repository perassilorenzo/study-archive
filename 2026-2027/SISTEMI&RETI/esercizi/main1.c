// Scrivi un programma in C che dichiari una variabile intera, assegni il suo indirizzo a un puntatore e stampi il valore della variabile, il suo indirizzo, il valore puntato e l'indirizzo del puntatore. Successivamente, modifica il valore della variabile utilizzando esclusivamente il puntatore.

#include <stdio.h>

int main(void){
    int var = 0;
    int *p = &var;

    
    char answer;
    while(1){
        printf("Vuoi cambiare la variabile? [y/n]\n>>> ");
        scanf("%c", &answer);
        
        if(answer == 'n' || answer == 'N')
        break;
        
        printf("Inserisci la variabile modificata\n>>> ");
        scanf("%i", p);
        
        printf("variabile: %i\nindirizzo: %p\nvalore puntato: %i\nindirizzo puntatore: %p\n\n", var, &var, *p, &p);
    }
}