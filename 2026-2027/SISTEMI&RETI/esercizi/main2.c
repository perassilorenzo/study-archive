// Scrivi un programma in C che dichiari un vettore di 10 numeri interi e utilizzi un puntatore per attraversarlo, stampando ogni elemento con la sua posizione e il suo valore. Successivamente, crea una funzione che riceva il vettore e ne modifichi gli elementi tramite puntatori, incrementando ogni numero di 1, e infine ristampi il vettore aggiornato.

#include <stdio.h>

int main(void){
    int array[10];
    int *p = array;

    for (int i = 0; i < 10; i++)
        printf("\nElemento: %i\nPosizione: %p\n\n", p[i], &p[i]);

    modificatore(array);
}

void modificatore(int *array){
    int *p;

    for(int i = 0; i < 10; i++){
        *p = array[i]++;
        array[i] = *p;

        printf("\nValore %i aggiornato in: %i", i, array[i]);
    }
}