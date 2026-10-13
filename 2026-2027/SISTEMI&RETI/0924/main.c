#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include "Funzioni.h"

/// Studenti.txt :
/// Num. Matricola
/// Cognome
/// Nome
/// Classe
/// Specializzazione

void disegnaMenu();
void attesa();

void inserisciStudente();
int ricercaStudente();
void ricercaClasse();
void visualizzaStudenti();
void modificaStudente();
void eliminaStudente();

int getUltimaMatricola();
void aggiungiDati(FILE *pFStu, int ultimoNM);

void main()
{
    int scelta;
    FILE *fp;

    fp = fopen("Studenti.txt","r");
    if (fp == NULL) {
        fclose(fp);
        fp = fopen("Studenti.txt","w");
    }
    fclose(fp);

    /// Men�
    do
    {

        /// Voci di Men�
        disegnaMenu();
        fflush(stdin);
        scanf("%d", &scelta);

        switch (scelta)
        {
            case 1:
                inserisciStudente();
                break;

            case 2:
                ricercaStudente();
                break;

            case 3:
                ricercaClasse();
                break;

            case 4:
                visualizzaStudenti();
                break;

            case 5:
                modificaStudente();
                break;

            case 6:
                eliminaStudente();
                break;

            default: break;
        }

        if (scelta != 0)
            attesa();

    }
    while(scelta != 0);

}

void disegnaMenu()
{
    clrscr();
    printf("\nEsercizio 2 - gestione FILE STUDENTI\n");
    printf("\n1  - Inserimento Nuovo Studente");
    printf("\n2  - Ricerca Studente per Cognome/Nome");
    printf("\n3  - Visualizza Studenti per Classe");
    printf("\n4* - Visualizza File Studenti");
    printf("\n5  - Modifica Studente");
    printf("\n6  - Elimina Studente");
    printf("\n\n0  - Esci");
    printf("\n\nScelta ==> ");

}

void attesa()
{
    printf("\n\nPremi un carattere per continuare ...");
    fflush(stdin);
    getch();
}


void inserisciStudente()
{
    FILE *fp;

    int nMatr = getUltimaMatricola();

    fp = fopen("Studenti.txt","a");
    aggiungiDati(fp, nMatr);
    fclose(fp);

}

int ricercaStudente()
{

    FILE *fp;

    int nm = 0;
    char cogn[20+1], nome[20+1];
    char cl[2+1], spec[3+1];

    char cognRic[20+1], nomeRic[20+1];
    int trovato = 0;

    clrscr();
    printf("\n\nRicerca Studente per Cognome / Nome \n\n");

    /// Input Cognome da Ricerca
    printf("\nInserisci il COGNOME ==> ");
    fflush(stdin);
    scanf("%s", cognRic);

    /// Input Nome da Ricerca
    printf("\nInserisci il NOME ==> ");
    fflush(stdin);
    scanf("%s", nomeRic);

    fp = fopen("Studenti.txt","r");
    fscanf(fp, "%i %s %s %s %s", &nm, cogn, nome, cl , spec);
    while( ! (feof(fp) || trovato == 1 ) ) {

        if (strcmp(cogn, cognRic) == 0 && strcmp(nome, nomeRic) == 0)
            trovato = 1;
        else
            fscanf(fp, "%i %s %s %s %s", &nm, cogn, nome, cl , spec);
    }
    fclose(fp);

    if (trovato == 1) {
        printf("\n\nStudente:\n");
        printf("\n N. Matricola %d", nm);
        printf("\n Cognome %s", cogn);
        printf("\n Nome %s", nome);
        printf("\n Classe %s", cl);
        printf("\n Specializzazione %s", spec);
    }
    else
        printf("\n\nLo Studente %s %s non e' stato trovato", cognRic, nomeRic);

    return nm;
}

void ricercaClasse()
{
    FILE *fp;

    int nm = 0;
    char cogn[20+1], nome[20+1];
    char cl[2+1], spec[3+1];

    char ricClasse[2+1];

    clrscr();
    printf("\nInserisci la Classe da ricerca ==> ");
    fflush(stdin);
    gets(ricClasse);

    printf("\n\nStudenti Classe %s :", ricClasse);

    printf("\nMatricola\tCognome\t\tNome\t\tClasse\tSpecializzazione");

    fp = fopen("Studenti.txt","r");
    fscanf(fp, "%i %s %s %s %s", &nm, cogn, nome, cl , spec);
    while(!feof(fp)) {

        if (strcmp(cl, ricClasse) == 0)
            printf("\n%d\t\t%s\t\t%s\t\t%s\t%s", nm, cogn, nome, cl, spec);

        fscanf(fp, "%i %s %s %s %s", &nm, cogn, nome, cl , spec);
    }

    fclose(fp);

}

void visualizzaStudenti()
{
    FILE *fp;

    int nm = 0;
    char cogn[20+1], nome[20+1];
    char cl[2+1], spec[3+1];

    fp = fopen("Studenti.txt","r");

    clrscr();
    printf("\nElenco Studenti\n\n");

    printf("\nMatricola\tCognome\t\tNome\t\tClasse\tSpecializzazione");

    fscanf(fp, "%i %s %s %s %s", &nm, cogn, nome, cl , spec);
    while(!feof(fp)) {
        printf("\n%d\t\t%s\t\t%s\t\t%s\t%s", nm, cogn, nome, cl, spec);
        fscanf(fp, "%i %s %s %s %s", &nm, cogn, nome, cl , spec);
    }

    fclose(fp);

}

void modificaStudente()
{

    FILE *fStu, *fApp;

    int nm = 0;
    char cogn[20+1], nome[20+1];
    char cl[2+1], spec[3+1];
    int nMatr = ricercaStudente();
    char c;

    if (nMatr != 0)
    {

        printf("\n\nVoui modificare lo Studente (S/N) ? ==> ");
        fflush(stdin);
        c = getchar();

        if (c == 'S' || c == 's')
        {

            fStu = fopen("Studenti.txt","r");
            fApp = fopen("Appoggio.txt","w");

            fscanf(fStu, "%i %s %s %s %s", &nm, cogn, nome, cl , spec);
            while(!feof(fStu)) {

                /// Gestisco i Nuovi Dati dello Studente Ricercato
                if (nm == nMatr) {

                    printf("\nInserisci la Nuova Classe ==> ");
                    fflush(stdin);
                    gets(cl);

                    printf("\nInserisci la Nuova Specializzazione ==> ");
                    fflush(stdin);
                    gets(spec);

                }

                /// Riporto i Dati sul File di Appoggio
                fprintf(fApp, "%i %s %s %s %s\n", nm, cogn, nome, cl , spec);

                fscanf(fStu, "%i %s %s %s %s", &nm, cogn, nome, cl , spec);
            }

            fclose(fStu);
            fclose(fApp);

            /// Ricreo il File Studenti
            fStu = fopen("Studenti.txt","w");
            fApp = fopen("Appoggio.txt","r");

            fscanf(fApp, "%i %s %s %s %s", &nm, cogn, nome, cl , spec);
            while(!feof(fApp)) {
                fprintf(fStu, "%i %s %s %s %s\n", nm, cogn, nome, cl , spec);
                fscanf(fApp, "%i %s %s %s %s", &nm, cogn, nome, cl , spec);
            }

            fclose(fStu);
            fclose(fApp);

            printf("\n\nLo Studente e' stato modificato con successo !!!");

        }

    }

}

void eliminaStudente()
{

    FILE *fStu, *fApp;

    int nm = 0;
    char cogn[20+1], nome[20+1];
    char cl[2+1], spec[3+1];
    int nMatr = ricercaStudente();
    char c;

    if (nMatr != 0)
    {

        printf("\n\nVoui elimina lo Studente (S/N) ? ==> ");
        fflush(stdin);
        c = getchar();

        if (c == 'S' || c == 's')
        {

            fStu = fopen("Studenti.txt","r");
            fApp = fopen("Appoggio.txt","w");

            fscanf(fStu, "%i %s %s %s %s", &nm, cogn, nome, cl , spec);
            while(!feof(fStu)) {

                if (nm != nMatr)
                    /// Riporto i Dati sul File di Appoggio
                    fprintf(fApp, "%i %s %s %s %s\n", nm, cogn, nome, cl , spec);

                fscanf(fStu, "%i %s %s %s %s", &nm, cogn, nome, cl , spec);
            }

            fclose(fStu);
            fclose(fApp);

            /// Ricreo il File Studenti
            fStu = fopen("Studenti.txt","w");
            fApp = fopen("Appoggio.txt","r");

            fscanf(fApp, "%i %s %s %s %s", &nm, cogn, nome, cl , spec);
            while(!feof(fApp)) {
                fprintf(fStu, "%i %s %s %s %s\n", nm, cogn, nome, cl , spec);
                fscanf(fApp, "%i %s %s %s %s", &nm, cogn, nome, cl , spec);
            }

            fclose(fStu);
            fclose(fApp);

            printf("\n\nLo Studente e' stato eliminato con successo !!!");

        }

    }

}

int getUltimaMatricola()
{
    FILE *fp;

    int nm = 0;
    char cogn[20+1], nome[20+1];
    char cl[2+1], spec[3+1];

    fp = fopen("Studenti.txt","r");

    while(!feof(fp))
        fscanf(fp, "%i %s %s %s %s", &nm, cogn, nome, cl , spec);
    fclose(fp);

    return nm;
}

void aggiungiDati(FILE *pFStu, int ultimoNM)
{
    int nm = ultimoNM;
    char cogn[20+1], nome[20+1];
    char cl[2+1], spec[3+1];

    char c;

    do
    {
        clrscr();
        printf("\nInserimento Dati Nuovo Studente\n\n");

        nm++;
        printf("\nNumero Matricola %d", nm);

        printf("\nInserisci il COGNOME ==> ");
        fflush(stdin);
        scanf("%s", cogn);

        printf("\nInserisci il NOME ==> ");
        fflush(stdin);
        scanf("%s", nome);

        printf("\nInserisci la CLASSE ==> ");
        fflush(stdin);
        scanf("%s", cl);

        printf("\nInserisci la SPECIALIZZAZIONE ==> ");
        fflush(stdin);
        scanf("%s", spec);

        fprintf(pFStu, "%i %s %s %s %s\n", nm, cogn, nome, cl , spec);

        printf("\nVuoi continuare [S/N] ==> ");
        fflush(stdin);
        scanf("%c", &c);

    }
    while(c == 'S' || c == 's');
}
