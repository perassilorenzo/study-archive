#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include "Funzioni.h"

// studenti.txt
// num. matricola
// cognome
// nome
// classe
// specializzazione

void disegnaMenu();
void attesa();

void inserisciStudente();
//

void main()
{
    int scelta;
    FILE *fp;

    fp = fopen("studenti.txt", "r");
    if (fp == NULL){
        fclose(fp);
        fp = fopen("studenti.txt", "w");
    }
    fclose(fp);

    // menu
    do{
        disegnaMenu();
        fflush(stdin);
        scanf("%d", &scelta);

        switch (scelta){
            case 1:
                inserisciStudente();
                break;

            case 2:

                break;

            case 3:

                break;

            case 4:

                break;

            default:

                break;
        }

        if(scelta != 0
            attesa();

    }while(scelta != 0);
}

void disegnaMenu(){
    clrscr();
    printf("\nEsercizio 2 - gestione file studenti\n");
    printf("\n1  - Inserimento nuovo studente");
    printf("\n2  - Ricerca studente per cognome/nome");
    printf("\n3  - Visualizza studenti per classe");
    printf("\n4* - Visualizza file studenti");  // aiuto per verificare, non utile all'utente
    printf("\n5  - Modifica studente");
    printf("\n6  - Elimina studente");
    printf("\n\n0  - Esci");
    printf("\n>>>");
}

void attesa(){
    printf("\n\nPremi un carattere per continuare...")
    fflush(stdin);
}

void inserisciStudente(){

}
