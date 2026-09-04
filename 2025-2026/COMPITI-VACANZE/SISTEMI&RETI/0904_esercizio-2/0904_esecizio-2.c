// Scrivere un programma che visualizzi in output i caratteri presenti nel vettore V1 lungo N tante volte quanto vale il corrispondentevalore intero contenuto nel vettore V2, anch’esso lungo N. (Es. V1=(‘Q’, ‘R’, ‘Y’, ‘G’) e V2=(3,5,0,3) OUTPUT=QQQRRRRRGGG).

#include <stdio.h>

int main (void){
    int N = 0;

    printf("Inserisci la lunghezza degli array: ");
    scanf("%i", &N);

    if (N <= 0)
    {
        printf("La lunghezza deve essere positiva.\n");
        return 1;
    }

    char V1[N];
    for (int i = 0; i < N; i++){
        printf("Inserisci il char %i del primo array ", i);
        scanf(" %c", &V1[i]);
    }

    int V2[N];
    for (int i = 0; i < N; i++){
        printf("Inserisci l'intero %i del secondo array", i);
        scanf(" %i", &V2[i]);
    }

    for (int i = 0; i < N; i++){
        for (int j = 0; j < V2[i]; j++){
            printf("%c", V1[i]);            
        }
    }

    return 0;

}