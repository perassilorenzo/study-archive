#include <stdio.h>
#include <string.h>

#define MAX 100
#define LUNGHEZZA 100

int caricaLibri(int codici[], char titoli[][LUNGHEZZA],
                char autori[][LUNGHEZZA], int generi[], int pagine[]) {
    FILE *file = fopen("Libri.txt", "r");
    int numero = 0;

    if (file == NULL) {
        return 0;
    }

    while (numero < MAX
           && fscanf(file, "%d|%99[^|]|%99[^|]|%d|%d\n",
                     &codici[numero], titoli[numero], autori[numero],
                     &generi[numero], &pagine[numero]) == 5) {
        numero++;
    }

    fclose(file);
    return numero;
}

int salvaLibri(int codici[], char titoli[][LUNGHEZZA],
               char autori[][LUNGHEZZA], int generi[], int pagine[],
               int numero) {
    FILE *file = fopen("Libri.txt", "w");

    if (file == NULL) {
        printf("Errore nell'apertura di Libri.txt\n");
        return 0;
    }

    for (int i = 0; i < numero; i++) {
        fprintf(file, "%d|%s|%s|%d|%d\n", codici[i], titoli[i],
                autori[i], generi[i], pagine[i]);
    }

    fclose(file);
    return 1;
}

int caricaGeneri(int codici[], char descrizioni[][LUNGHEZZA]) {
    FILE *file = fopen("Generi.txt", "r");
    int numero = 0;

    if (file == NULL) {
        return 0;
    }

    while (numero < MAX
           && fscanf(file, "%d|%99[^\n]\n",
                     &codici[numero], descrizioni[numero]) == 2) {
        numero++;
    }

    fclose(file);
    return numero;
}

int salvaGeneri(int codici[], char descrizioni[][LUNGHEZZA], int numero) {
    FILE *file = fopen("Generi.txt", "w");

    if (file == NULL) {
        printf("Errore nell'apertura di Generi.txt\n");
        return 0;
    }

    for (int i = 0; i < numero; i++) {
        fprintf(file, "%d|%s\n", codici[i], descrizioni[i]);
    }

    fclose(file);
    return 1;
}

int caricaPrestiti(int numeri[], char datePrestito[][11],
                   char dateRestituzione[][11], int codiciLibro[]) {
    FILE *file = fopen("Prestiti.txt", "r");
    int numero = 0;

    if (file == NULL) {
        return 0;
    }

    while (numero < MAX
           && fscanf(file, "%d|%10[^|]|%10[^|]|%d\n",
                     &numeri[numero], datePrestito[numero],
                     dateRestituzione[numero], &codiciLibro[numero]) == 4) {
        numero++;
    }

    fclose(file);
    return numero;
}

int salvaPrestiti(int numeri[], char datePrestito[][11],
                  char dateRestituzione[][11], int codiciLibro[],
                  int numero) {
    FILE *file = fopen("Prestiti.txt", "w");

    if (file == NULL) {
        printf("Errore nell'apertura di Prestiti.txt\n");
        return 0;
    }

    for (int i = 0; i < numero; i++) {
        fprintf(file, "%d|%s|%s|%d\n", numeri[i], datePrestito[i],
                dateRestituzione[i], codiciLibro[i]);
    }

    fclose(file);
    return 1;
}

int cercaCodice(int codici[], int numero, int codice) {
    for (int i = 0; i < numero; i++) {
        if (codici[i] == codice) {
            return i;
        }
    }
    return -1;
}

int codiceSuccessivo(int codici[], int numero) {
    int massimo = 0;

    for (int i = 0; i < numero; i++) {
        if (codici[i] > massimo) {
            massimo = codici[i];
        }
    }

    return massimo + 1;
}

void stampaLibro(int codice, char titolo[], char autore[],
                 int genere, int pagine) {
    printf("Codice: %d | Titolo: %s | Autore: %s | Genere: %d | Pagine: %d\n",
           codice, titolo, autore, genere, pagine);
}

int dataValida(char data[]) {
    int giorno, mese, anno;
    int giorniMese;

    if (strlen(data) != 10 || data[2] != '/' || data[5] != '/') {
        return 0;
    }

    for (int i = 0; i < 10; i++) {
        if (i != 2 && i != 5 && (data[i] < '0' || data[i] > '9')) {
            return 0;
        }
    }

    giorno = (data[0] - '0') * 10 + data[1] - '0';
    mese = (data[3] - '0') * 10 + data[4] - '0';
    anno = (data[6] - '0') * 1000 + (data[7] - '0') * 100
           + (data[8] - '0') * 10 + data[9] - '0';

    if (anno < 1 || mese < 1 || mese > 12) {
        return 0;
    }

    giorniMese = 31;
    if (mese == 4 || mese == 6 || mese == 9 || mese == 11) {
        giorniMese = 30;
    } else if (mese == 2) {
        if ((anno % 4 == 0 && anno % 100 != 0) || anno % 400 == 0) {
            giorniMese = 29;
        } else {
            giorniMese = 28;
        }
    }

    return giorno >= 1 && giorno <= giorniMese;
}

int valoreData(char data[]) {
    return (data[6] - '0') * 10000000 + (data[7] - '0') * 1000000
           + (data[8] - '0') * 100000 + (data[9] - '0') * 10000
           + (data[3] - '0') * 1000 + (data[4] - '0') * 100
           + (data[0] - '0') * 10 + data[1] - '0';
}

void gestioneLibri(void) {
    int codici[MAX], generi[MAX], pagine[MAX];
    char titoli[MAX][LUNGHEZZA], autori[MAX][LUNGHEZZA];
    int codiciGeneri[MAX];
    char descrizioniGeneri[MAX][LUNGHEZZA];
    int numeroLibri, numeroGeneri, scelta;

    do {
        printf("\n--- Gestione Libri ---\n");
        printf("1) Inserimento libro\n");
        printf("2) Modifica libro\n");
        printf("3) Visualizza libri di un genere\n");
        printf("4) Ritorna al menu principale\n");
        printf("Scelta: ");
        scanf("%d", &scelta);

        numeroLibri = caricaLibri(codici, titoli, autori, generi, pagine);
        numeroGeneri = caricaGeneri(codiciGeneri, descrizioniGeneri);

        if (scelta == 1) {
            int codiceGenere;

            if (numeroLibri == MAX) {
                printf("Archivio libri pieno.\n");
                continue;
            }
            if (numeroGeneri == 0) {
                printf("Inserisci prima almeno un genere.\n");
                continue;
            }

            printf("Generi disponibili:\n");
            for (int i = 0; i < numeroGeneri; i++) {
                printf("%d - %s\n", codiciGeneri[i], descrizioniGeneri[i]);
            }
            printf("Titolo: ");
            scanf(" %99[^\n]", titoli[numeroLibri]);
            printf("Autore: ");
            scanf(" %99[^\n]", autori[numeroLibri]);
            printf("Codice genere: ");
            scanf("%d", &codiceGenere);

            if (cercaCodice(codiciGeneri, numeroGeneri, codiceGenere) == -1) {
                printf("Genere non trovato.\n");
                continue;
            }

            printf("Numero di pagine: ");
            scanf("%d", &pagine[numeroLibri]);
            codici[numeroLibri] = codiceSuccessivo(codici, numeroLibri);
            generi[numeroLibri] = codiceGenere;
            numeroLibri++;

            if (salvaLibri(codici, titoli, autori, generi, pagine, numeroLibri)) {
                printf("Libro inserito con codice %d.\n", codici[numeroLibri - 1]);
            }
        } else if (scelta == 2) {
            int codice, posizione;

            printf("Codice del libro da modificare: ");
            scanf("%d", &codice);
            posizione = cercaCodice(codici, numeroLibri, codice);

            if (posizione == -1) {
                printf("Libro non trovato.\n");
                continue;
            }

            stampaLibro(codici[posizione], titoli[posizione], autori[posizione],
                        generi[posizione], pagine[posizione]);
            printf("Nuovo titolo: ");
            scanf(" %99[^\n]", titoli[posizione]);
            printf("Nuovo autore: ");
            scanf(" %99[^\n]", autori[posizione]);
            printf("Nuovo codice genere: ");
            scanf("%d", &generi[posizione]);

            if (cercaCodice(codiciGeneri, numeroGeneri, generi[posizione]) == -1) {
                printf("Genere non trovato. Modifica annullata.\n");
                continue;
            }

            printf("Nuovo numero di pagine: ");
            scanf("%d", &pagine[posizione]);
            salvaLibri(codici, titoli, autori, generi, pagine, numeroLibri);
        } else if (scelta == 3) {
            int codiceGenere, trovato = 0;

            printf("Codice del genere: ");
            scanf("%d", &codiceGenere);
            for (int i = 0; i < numeroLibri; i++) {
                if (generi[i] == codiceGenere) {
                    stampaLibro(codici[i], titoli[i], autori[i],
                                generi[i], pagine[i]);
                    trovato = 1;
                }
            }
            if (!trovato) {
                printf("Nessun libro trovato per questo genere.\n");
            }
        }
    } while (scelta != 4);
}

void gestioneGeneri(void) {
    int codici[MAX];
    char descrizioni[MAX][LUNGHEZZA];
    int numeroGeneri, scelta;

    do {
        printf("\n--- Gestione Generi ---\n");
        printf("1) Inserimento genere\n");
        printf("2) Modifica genere\n");
        printf("3) Visualizza tutti i generi\n");
        printf("4) Ritorna al menu principale\n");
        printf("Scelta: ");
        scanf("%d", &scelta);

        numeroGeneri = caricaGeneri(codici, descrizioni);

        if (scelta == 1) {
            if (numeroGeneri == MAX) {
                printf("Archivio generi pieno.\n");
                continue;
            }

            codici[numeroGeneri] = codiceSuccessivo(codici, numeroGeneri);
            printf("Descrizione del genere: ");
            scanf(" %99[^\n]", descrizioni[numeroGeneri]);
            numeroGeneri++;

            if (salvaGeneri(codici, descrizioni, numeroGeneri)) {
                printf("Genere inserito con codice %d.\n", codici[numeroGeneri - 1]);
            }
        } else if (scelta == 2) {
            int codice, posizione;

            printf("Codice del genere da modificare: ");
            scanf("%d", &codice);
            posizione = cercaCodice(codici, numeroGeneri, codice);

            if (posizione == -1) {
                printf("Genere non trovato.\n");
                continue;
            }

            printf("Nuova descrizione: ");
            scanf(" %99[^\n]", descrizioni[posizione]);
            salvaGeneri(codici, descrizioni, numeroGeneri);
        } else if (scelta == 3) {
            if (numeroGeneri == 0) {
                printf("Non ci sono generi registrati.\n");
            }
            for (int i = 0; i < numeroGeneri; i++) {
                printf("%d - %s\n", codici[i], descrizioni[i]);
            }
        }
    } while (scelta != 4);
}

void gestionePrestiti(void) {
    int numeri[MAX], codiciLibro[MAX];
    char datePrestito[MAX][11], dateRestituzione[MAX][11];
    int codici[MAX], generi[MAX], pagine[MAX];
    char titoli[MAX][LUNGHEZZA], autori[MAX][LUNGHEZZA];
    int numeroPrestiti, numeroLibri, scelta;

    do {
        printf("\n--- Gestione Prestiti ---\n");
        printf("1) Effettua un prestito di un libro\n");
        printf("2) Effettua una restituzione\n");
        printf("3) Ricerca singolo libro dato in prestito\n");
        printf("4) Ricerca tutti i libri in prestito\n");
        printf("5) Ricerca tutti i libri restituiti\n");
        printf("6) Ritorna al menu principale\n");
        printf("Scelta: ");
        scanf("%d", &scelta);

        numeroPrestiti = caricaPrestiti(numeri, datePrestito,
                                       dateRestituzione, codiciLibro);
        numeroLibri = caricaLibri(codici, titoli, autori, generi, pagine);

        if (scelta == 1) {
            int codiceLibro, posizioneLibro, giaPrestato = 0;
            char data[11];

            if (numeroPrestiti == MAX) {
                printf("Archivio prestiti pieno.\n");
                continue;
            }

            printf("Codice del libro: ");
            scanf("%d", &codiceLibro);
            posizioneLibro = cercaCodice(codici, numeroLibri, codiceLibro);

            if (posizioneLibro == -1) {
                printf("Libro non trovato.\n");
                continue;
            }
            for (int i = 0; i < numeroPrestiti; i++) {
                if (codiciLibro[i] == codiceLibro
                    && strcmp(dateRestituzione[i], "-") == 0) {
                    giaPrestato = 1;
                }
            }
            if (giaPrestato) {
                printf("Il libro e' gia' in prestito.\n");
                continue;
            }

            do {
                printf("Data prestito (gg/MM/aaaa): ");
                scanf("%10s", data);
                if (!dataValida(data)) {
                    printf("Data non valida.\n");
                }
            } while (!dataValida(data));

            numeri[numeroPrestiti] = codiceSuccessivo(numeri, numeroPrestiti);
            strcpy(datePrestito[numeroPrestiti], data);
            strcpy(dateRestituzione[numeroPrestiti], "-");
            codiciLibro[numeroPrestiti] = codiceLibro;
            numeroPrestiti++;

            if (salvaPrestiti(numeri, datePrestito, dateRestituzione,
                              codiciLibro, numeroPrestiti)) {
                printf("Prestito registrato.\n");
            }
        } else if (scelta == 2) {
            int codiceLibro, posizione = -1;
            char data[11];

            printf("Codice del libro da restituire: ");
            scanf("%d", &codiceLibro);
            for (int i = 0; i < numeroPrestiti; i++) {
                if (codiciLibro[i] == codiceLibro
                    && strcmp(dateRestituzione[i], "-") == 0) {
                    posizione = i;
                }
            }
            if (posizione == -1) {
                printf("Non risulta un prestito attivo per questo libro.\n");
                continue;
            }

            do {
                printf("Data restituzione (gg/MM/aaaa): ");
                scanf("%10s", data);
                if (!dataValida(data)) {
                    printf("Data non valida.\n");
                } else if (valoreData(data) < valoreData(datePrestito[posizione])) {
                    printf("La restituzione non puo' precedere il prestito.\n");
                    data[0] = '\0';
                }
            } while (!dataValida(data));

            strcpy(dateRestituzione[posizione], data);
            salvaPrestiti(numeri, datePrestito, dateRestituzione,
                          codiciLibro, numeroPrestiti);
            printf("Restituzione registrata.\n");
        } else if (scelta == 3) {
            int codiceLibro, trovato = 0;

            printf("Codice del libro: ");
            scanf("%d", &codiceLibro);
            for (int i = 0; i < numeroPrestiti; i++) {
                if (codiciLibro[i] == codiceLibro
                    && strcmp(dateRestituzione[i], "-") == 0) {
                    int posizione = cercaCodice(codici, numeroLibri, codiceLibro);
                    if (posizione != -1) {
                        stampaLibro(codici[posizione], titoli[posizione],
                                    autori[posizione], generi[posizione],
                                    pagine[posizione]);
                    }
                    printf("Data prestito: %s\n", datePrestito[i]);
                    trovato = 1;
                }
            }
            if (!trovato) {
                printf("Il libro non risulta in prestito.\n");
            }
        } else if (scelta == 4 || scelta == 5) {
            int trovato = 0;

            for (int i = 0; i < numeroPrestiti; i++) {
                int attivo = strcmp(dateRestituzione[i], "-") == 0;

                if ((scelta == 4 && attivo) || (scelta == 5 && !attivo)) {
                    int posizione = cercaCodice(codici, numeroLibri, codiciLibro[i]);
                    if (posizione != -1) {
                        stampaLibro(codici[posizione], titoli[posizione],
                                    autori[posizione], generi[posizione],
                                    pagine[posizione]);
                    }
                    printf("Prestito n. %d | Data prestito: %s | Data restituzione: %s\n",
                           numeri[i], datePrestito[i],
                           attivo ? "non restituito" : dateRestituzione[i]);
                    trovato = 1;
                }
            }
            if (!trovato) {
                printf("Nessun prestito trovato.\n");
            }
        }
    } while (scelta != 6);
}

int main(void) {
    int scelta;

    do {
        printf("\n--- Biblioteca scolastica ---\n");
        printf("1) Gestione Libri\n");
        printf("2) Gestione Generi\n");
        printf("3) Gestione Prestiti\n");
        printf("0) Esci\n");
        printf("Scelta: ");
        scanf("%d", &scelta);

        if (scelta == 1) {
            gestioneLibri();
        } else if (scelta == 2) {
            gestioneGeneri();
        } else if (scelta == 3) {
            gestionePrestiti();
        }
    } while (scelta != 0);

    return 0;
}
