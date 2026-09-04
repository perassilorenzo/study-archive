#include <stdio.h>

struct Partecipante
{
    char nome[20];
    int punteggi[10];
};

const int N = 10;

int main(void){
    struct Partecipante partecipanti[N];

    for (int i = 0; i < N; i++){
        printf("Inserisci il nome del partecipante numero %i ", i);
        scanf("%19s", &partecipanti[i].nome);

        printf("Inserisci i suoi punteggi ");
        for (int j = 0; j < 10; j++){
            scanf("%i", &partecipanti[i].punteggi[j]);
        }
    }

    for (int i = 0; i < 10; i++){
        int index;
        int max = -1;
        
        for (int j = 0; j < N; j++){
            if (partecipanti[j].punteggi[i] > max){
                max = partecipanti[j].punteggi[i];
                index = j; 
            }
        }

        printf("prova %i: %s %i\n", i, partecipanti[index].nome, max);
    }

    return 0;
}