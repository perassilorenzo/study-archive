#include <stdio.h>
#include "../funzioni/Funzioni.h"

#define MAX 100

int caricaVettore(int *pv);
void visualizzaVettore(int *pv, int lv);

int main()
{

    int Vet[MAX];
    int lunVett;
    int *p;

    printf("\nEsercizio 4: caricamento e Visualizzazione Vettore Tramite Puntatori");

    randomize();

    // Carico Vettore
    p = Vet;
    lunVett = caricaVettore(p);

    // Visualizza Vettore
    printf("\n\nVettore:\n");
    p = Vet;
    visualizzaVettore(p, lunVett);

    printf("\n\n");

    // Ordina Vettore
    p = Vet;
    bubble(p, lunVett);

    // Visualizza Vettore Ordinato
    printf("\n\nVettore Ordinato:\n");
    p = Vet;
    visualizzaVettore(p,lunVett);

    printf("\n\n");

    return 0;
}

int caricaVettore(int *pv)
{
    int lun;

    // Chiedo in Input la Lunghezza del Vettore
    do
    {
        clrscr();
        printf("\nInserisci la Lunghezza del Vettore ==> ");
        fflush(stdin);
        scanf("%d",&lun);
    } 
    while (lun < 1 || lun > MAX);

    // Carico il Vettore
    for(int I=0; I < lun; I++) {
        //*(pv++) = random(MAX) + 1;
        *pv = random(MAX) + 1;
        pv++;
    }

    return lun;
}

void visualizzaVettore(int *pv, int lv)
{

    for(int I=0; I < lv; I++) {
        printf("\n - elemento %d - valore %d - indirizzo %p", I+1, *pv, pv);
        pv++;
    }
