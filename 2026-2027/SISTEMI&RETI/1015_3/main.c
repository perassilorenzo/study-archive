#include <stdio.h>

int main(void){
    int array[5] = {10, 20, 30, 40, 50};
    int *p;

    printf("\n\nEsercizio 3: gestione vettori con puntatori");

    p = array;
    
    for (int i = 0; i < 5; i++){
        printf("\n- elemento %d - valore %d - indirizzo %p", i+1, *p, p);
        p++;
    }


    printf("\n\n");
    return 0;
}