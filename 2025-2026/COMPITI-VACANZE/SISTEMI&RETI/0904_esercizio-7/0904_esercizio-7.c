#include <stdio.h>
#include <string.h>

struct Alimentare
{
    char desc[20];
    int quant;
    int scad;
};

const int N = 10;

int main(void){
    struct Alimentare alimentari[N];

    for (int i = 0; i < N; i++){
        printf("Inserisci la descrizione dell'alimentare numero %i ", i);
        scanf("%19s", alimentari[i].desc);
        
        printf("Inserisci la sua quantità ");
        scanf("%i", &alimentari[i].quant);

        printf("Inserisci la sua data di scadenza ");
        scanf("%i", &alimentari[i].scad);
    }

    struct Alimentare scaduti[N];
    int j = 0;

    for (int i = 0; i < N; i++){
        if (alimentari[i].scad < 2010){
            strcpy(scaduti[j].desc, alimentari[i].desc);
            scaduti[j].quant = alimentari[i].quant;
            scaduti[j].scad = alimentari[i].scad;

            j++;
        }
    }

    for (int i = 0; i < j; i++)
    {
        printf("%s %d %d\n", scaduti[i].desc, scaduti[i].quant, scaduti[i].scad);
    }

    return 0;
}