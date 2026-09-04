// Scrivere un programma in cui, dati due vettori di caratteri V1 e V2, entrambi lunghi N, vengono caricati in un terzo vettore V3 gli elementi uguali in posizione uguale. (Es. V1=(‘Q’, ‘R’, ‘Y’, ‘G’, ‘D’) e V2=(‘Q’, ‘H’, ‘S’, ‘G’, ‘D’) V3=(‘Q’, ‘G’, ‘D’)

#include <stdio.h>

int main (void){
    int N;
    printf("Inserisci la lunghezza dei vettori");
    scanf(" %i", &N);

    if (N <= 0){
        printf("La lunghezza deve essere positiva");
        return 1;
    }

    char V1[N];
    for (int i = 0; i < N; i++){
        printf("Inserisci l'elemento %i del primo array", i);
        scanf(" %c", &V1[i]);
    }

    char V2[N];
    for (int i = 0; i < N; i++){
        printf("Inserisci l'elemento %i del secondo array", i);
        scanf(" %c", &V2[i]);
    }

    char V3[N];
    int j = 0;
    for (int i = 0; i < N; i++){
        if (V1[i] == V2[i]){
            V3[j] = V1[i];
            j++;
        }
    }
    
    printf("V3: ");
    for (int i = 0; i < j; i++)
    {
        printf("%c", V3[i]);
    }

    return 0;
}