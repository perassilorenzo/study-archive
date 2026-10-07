#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include "Funzioni.h"

/// Studenti.txt
/// Numero di matricola
/// Cognome
/// Nome
/// Classe
/// Specializzazione

void disegnaMenu();
void attesa();

void inserisciStudente();
int ricercaStudente();
///...
void visualizzaStudenti();

int getUltimaMatricola();
void aggiungiDati(FILE *fpStudente, int ultimoNM);

void main()
{
    int scelta;
    FILE *fp;

    fp = fopen("Studenti.txt", "r");
    if(fp == NULL){
        fclose(fp);
        fp = fopen("Studenti.txt", "w");
    }
    ///Menu
    do{
        ///Voci di menu
        disegnaMenu();
        fflush(stdin);
        scanf("%d", &scelta);

        switch(scelta){
            case 1:
                inserisciStudente();
                break;

            case 2:
                ricercaStudente();
                break;
            case 3: break;

            case 4:
                visualizzaStudenti();
                break;
            case 5: break;
            case 6: break;
            default: break;
        }

        if(scelta != 0){
            attesa();
        }
    } while(scelta != 0);
}

void disegnaMenu(){
    clrscr();      ///Pulisce lo schermo
    printf("\nEsercizio 2 - gestione FILE STUDENTI\n");
    printf("\n1 - Inserimento Nuovo Studente");
    printf("\n2 - Ricerca Studente per Cognome/Nome");
    printf("\n3 - Visualizza Studenti per Classe");
    printf("\n4* - Visualizza File Studente");
    printf("\n5 - Modifica Studente");
    printf("\n6 - Elimina Studente");
    printf("\n\n0 - Esci");
    printf("\n\nScelta ==> ");

}
void attesa(){
    printf("\n\n Premi un crattere per continuare ==> ");
    fflush(stdin);
    getch();
}
void inserisciStudente(){
    FILE *fp;

    int nMatr = getUltimaMatricola();

     fp = fopen("Studenti.txt", "a");
     aggiungiDati(fp, nMatr);

     fclose(fp);
}

void visualizzaStudenti(){
     FILE *fp;
     int nm = 0;
     char cogn[20 + 1];
     char nome[20 + 1];
     char classe[2 + 1];
     char spec[3 + 1];

     fp = fopen("Studenti.txt", "r");

     clrscr();
     printf("\nElenco Studenti\n\n");

     printf("\nMatricola\tCognome\t\tNome\tClasse\tSpecializzazione");

     fscanf(fp, "%d %s %s %s %s", &nm, cogn, nome, classe, spec);
     while(!feof(fp)){
        printf("\n%d\t%s\t\t%s\t%s\t%s", nm, cogn, nome, classe, spec);
        fscanf(fp, "%d %s %s %s %s", &nm, cogn, nome, classe, spec);
     }

     fclose(fp);
}

int ricercaStudente(){
     FILE *fp;

     fp = fopen("Studenti.txt", "r");

     int nm = 0;
     char cogn[20 + 1];
     char nome[20 + 1];
     char classe[2 + 1];
     char spec[3 + 1];

     char cognRic[20 + 1], nomeRic[20 + 1];
     int trovato = 0;

     clrscr();
     printf("\n\nRicerca Studente per Cognome / Nome \n\n");

     ///Inserisci il cognome da ricercare
     printf("\nInserisci il  COGNOME ==> ");
     fflush(stdin);
     scanf("%s", cognRic);

     ///Inserisci il nome da ricercare
     printf("\nInserisci il  NOME ==> ");
     fflush(stdin);
     scanf("%s", nomeRic);

     fscanf(fp, "%d %s %s %s %s", &nm, cogn, nome, classe, spec);
     while(!feof(fp) && trovato == 0){
        if(strcmp(cogn, cognRic) == 0 && strcmp(nome, nomeRic) == 0){
           trovato = 1;
           printf("\n\nStudente: \n");
           printf("\n N.Matricola %d", nm);
           printf("\n Cognome %s", cogn);
           printf("\n Nome %s", nome);
           printf("\n Classe %s", classe);
           printf("\n Specializzazione %s", spec);
        }
        else{
        fscanf(fp, "%d %s %s %s %s", &nm, cogn, nome, classe, spec);
        }
     }
     if(trovato == 0){
        printf("\n\nLo studente %s %s non � stato trovato", cognRic, nomeRic);
     }

      fclose(fp);


}


int getUltimaMatricola(){
    FILE *fp;
    int nm = 0;
    char cogn[20 + 1];
    char nome[20 + 1];
    char classe[2 + 1];
    char spec[3 + 1];

    fp = fopen("Studenti.txt", "r");

    while(!feof(fp)){
        fscanf(fp, "%d %s %s %s %s\n", &nm, cogn, nome, classe, spec);
    }

    fclose(fp);
    return nm;
}

void aggiungiDati(FILE *fpStudente, int ultimoNM){
    int nm = ultimoNM;
    char cogn[20 + 1];
    char nome[20 + 1];
    char classe[2 + 1];
    char spec[3 + 1];

    char c;

    do{
        clrscr();
        printf("\nInserimento Dati Nuovo Studente\n\n");

        nm++;
        printf("\nNumero Matricola %d", nm);

        printf("\nInserisci il  COGNOME ==> ");
        fflush(stdin);
        scanf("%s", cogn);

        printf("\nInserisci il  NOME ==> ");
        fflush(stdin);
        scanf("%s", nome);

        printf("\nInserisci la CLASSE ==> ");
        fflush(stdin);
        scanf("%s", classe);

        printf("\nInserisci la SPECIALIZZAZIONE ==> ");
        fflush(stdin);
        scanf("%s", spec);

        fprintf(fpStudente, "%d %s %s %s %s\n", nm, cogn, nome, classe, spec);
        printf("\nVuoi continuare [S/N] ==> ");
        fflush(stdin);
        scanf("%c", &c);

    }while(c == 'S' || c == 's');
}
