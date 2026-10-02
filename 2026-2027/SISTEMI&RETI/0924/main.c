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
//
void visualizzaStudenti();

int getUltimaMatricola();
void aggiungiDati(/*FILE, int*/ FILE *fpStudente, int ultimoNumeroMatricola)

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
                visualizzaStudenti();
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
    FILE *fp;

    int numeroMatricola = getUltimaMatricola();

    fp = fopen("Studenti.txt", "r");
    aggiungiDati(fp, numeroMatricola);
    fclose(fp);
}




int getUltimaMatricola(){
    int numeroMatricola = 0;
    char cognome[20+1], nome[20+1];
    char classe[2+1], specializzazione[3+1];

    FILE *fp;
    fp = fopen("Studenti.txt", "r");

    while(!feof(fp))
        fscanf(fp, "%i %s %s %s %s", &numeroMatricola, cognome, nome, classe, specializzazione);
    fclose(fp);


    return numeroMatricola;
}

void aggiungiDati(FILE *fpStudente, int ultimoNumeroMatricola){
    int numeroMatricola = ultimoNumeroMatricola;
    char cognome[20+1], nome[20+1];
    char classe[2+1], specializzazione[3+1];

    char c;

    do{
        clrscr();
        printf("\nInserimento dati del nuovo studente\n\n");

        printf("\nNumero Matricola: %d", ++numeroMatricola);

        printf("\nInserisci il Cognome\n>>> ");
        fflush(stdin);
        scanf("%s", cognome);

        printf("\nInserisci il Nome\n>>> ");
        fflush(stdin);
        scanf("%s", nome);

        printf("\nInserisci la Classe\n>>> ");
        fflush(stdin);
        scanf("%s", classe);

        printf("\nInserisci la Specializzazione\n>>> ");
        fflush(stdin);
        scanf("%s", specializzazione);

        fprintf(pfStu, "%i %s %s %s %s", numeroMatricola, cognome, nome, classe, specializzazione);

        printf("\nVuoi continuare? [y/n]\n>>> ");
        fflush(stdin);
        scanf("%c", &c);


    }
    while(c == 'y' || c == 'Y');
}

void visualizzaStudenti(){
    FILE *fp;

    int numeroMatricola = 0;
    char cognome[20+1], nome[20+1];
    char classe[2+1], specializzazione[3+1];

    fp = fopen("Studenti.txt", "r");

    clrscr();
    printf("\nElenco studenti\n\n");

    printf("\nMatricola\tCognome\t\tNome\t\tClasse\tSpecializzazione");

    fscanf(fp, "%i %s %s %s %s", &numeroMatricola, cognome, nome, classe, specializzazione);
    while(!feof(fp)){
        printf("\%d\t%s\t\t%s\t\t%s\t%s", numeroMatricola, cognome, nome, classe, specializzazione);
        scanf(fp, "%i %s %s %s %s", &numeroMatrice, cognome, nome, classe, specializzazione);
    }

    fclose(fp);

}
