#include <stdio.h>
#include <string.h>

#define MAX 100
#define LUNGHEZZA 100

int caricaPazienti(int codici[], char cognomi[][LUNGHEZZA],
                   char nomi[][LUNGHEZZA], char citta[][LUNGHEZZA],
                   char reparti[][LUNGHEZZA], int letti[]) {
    FILE *file = fopen("Pazienti.txt", "r");
    int numero = 0;

    if (file == NULL) {
        return 0;
    }

    while (numero < MAX
           && fscanf(file, "%d|%99[^|]|%99[^|]|%99[^|]|%99[^|]|%d\n",
                     &codici[numero], cognomi[numero], nomi[numero],
                     citta[numero], reparti[numero], &letti[numero]) == 6) {
        numero++;
    }

    fclose(file);
    return numero;
}

int salvaPazienti(int codici[], char cognomi[][LUNGHEZZA],
                  char nomi[][LUNGHEZZA], char citta[][LUNGHEZZA],
                  char reparti[][LUNGHEZZA], int letti[], int numero) {
    FILE *file = fopen("Pazienti.txt", "w");

    if (file == NULL) {
        printf("Errore nell'apertura di Pazienti.txt\n");
        return 0;
    }

    for (int i = 0; i < numero; i++) {
        fprintf(file, "%d|%s|%s|%s|%s|%d\n", codici[i], cognomi[i],
                nomi[i], citta[i], reparti[i], letti[i]);
    }

    fclose(file);
    return 1;
}

int caricaVisite(int progressivi[], char date[][11],
                 char tipi[][LUNGHEZZA], char dottori[][LUNGHEZZA],
                 int codiciPaziente[]) {
    FILE *file = fopen("Visite.txt", "r");
    int numero = 0;

    if (file == NULL) {
        return 0;
    }

    while (numero < MAX
           && fscanf(file, "%d|%10[^|]|%99[^|]|%99[^|]|%d\n",
                     &progressivi[numero], date[numero], tipi[numero],
                     dottori[numero], &codiciPaziente[numero]) == 5) {
        numero++;
    }

    fclose(file);
    return numero;
}

int salvaVisite(int progressivi[], char date[][11],
                char tipi[][LUNGHEZZA], char dottori[][LUNGHEZZA],
                int codiciPaziente[], int numero) {
    FILE *file = fopen("Visite.txt", "w");

    if (file == NULL) {
        printf("Errore nell'apertura di Visite.txt\n");
        return 0;
    }

    for (int i = 0; i < numero; i++) {
        fprintf(file, "%d|%s|%s|%s|%d\n", progressivi[i], date[i],
                tipi[i], dottori[i], codiciPaziente[i]);
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

void stampaPaziente(int codice, char cognome[], char nome[], char citta[],
                    char reparto[], int letto) {
    printf("Codice: %d | %s %s | Citta': %s | Reparto: %s | Letto: %d\n",
           codice, cognome, nome, citta, reparto, letto);
}

void inserimentoPaziente(void) {
    int codici[MAX], letti[MAX];
    char cognomi[MAX][LUNGHEZZA], nomi[MAX][LUNGHEZZA];
    char citta[MAX][LUNGHEZZA], reparti[MAX][LUNGHEZZA];
    int numero = caricaPazienti(codici, cognomi, nomi, citta, reparti, letti);

    if (numero == MAX) {
        printf("Archivio pazienti pieno.\n");
        return;
    }

    codici[numero] = codiceSuccessivo(codici, numero);
    printf("Cognome: ");
    scanf(" %99[^\n]", cognomi[numero]);
    printf("Nome: ");
    scanf(" %99[^\n]", nomi[numero]);
    printf("Citta': ");
    scanf(" %99[^\n]", citta[numero]);
    printf("Reparto: ");
    scanf(" %99[^\n]", reparti[numero]);
    printf("Numero letto: ");
    scanf("%d", &letti[numero]);

    numero++;
    if (salvaPazienti(codici, cognomi, nomi, citta, reparti, letti, numero)) {
        printf("Paziente inserito con codice %d.\n", codici[numero - 1]);
    }
}

void ricercaPazienti(void) {
    int codici[MAX], letti[MAX], scelta;
    char cognomi[MAX][LUNGHEZZA], nomi[MAX][LUNGHEZZA];
    char citta[MAX][LUNGHEZZA], reparti[MAX][LUNGHEZZA];
    int numeroPazienti;

    do {
        printf("\n--- Ricerca pazienti ---\n");
        printf("1) Ricerca per cognome e nome\n");
        printf("2) Ricerca pazienti di un reparto\n");
        printf("3) Ricerca pazienti per citta'\n");
        printf("4) Ricerca visite di un paziente\n");
        printf("5) Pazienti visitati in una data\n");
        printf("6) Ritorna al menu principale\n");
        printf("Scelta: ");
        scanf("%d", &scelta);

        numeroPazienti = caricaPazienti(codici, cognomi, nomi,
                                        citta, reparti, letti);

        if (scelta == 1) {
            char cognome[LUNGHEZZA], nome[LUNGHEZZA];
            int trovato = 0;

            printf("Cognome: ");
            scanf(" %99[^\n]", cognome);
            printf("Nome: ");
            scanf(" %99[^\n]", nome);

            for (int i = 0; i < numeroPazienti; i++) {
                if (strcmp(cognomi[i], cognome) == 0
                    && strcmp(nomi[i], nome) == 0) {
                    stampaPaziente(codici[i], cognomi[i], nomi[i],
                                   citta[i], reparti[i], letti[i]);
                    trovato = 1;
                }
            }
            if (!trovato) {
                printf("Paziente non trovato.\n");
            }
        } else if (scelta == 2) {
            char reparto[LUNGHEZZA];
            int trovato = 0;

            printf("Reparto: ");
            scanf(" %99[^\n]", reparto);

            for (int i = 0; i < numeroPazienti; i++) {
                if (strcmp(reparti[i], reparto) == 0) {
                    stampaPaziente(codici[i], cognomi[i], nomi[i],
                                   citta[i], reparti[i], letti[i]);
                    trovato = 1;
                }
            }
            if (!trovato) {
                printf("Nessun paziente trovato in questo reparto.\n");
            }
        } else if (scelta == 3) {
            char cittaRicerca[LUNGHEZZA];
            int trovato = 0;

            printf("Citta': ");
            scanf(" %99[^\n]", cittaRicerca);

            for (int i = 0; i < numeroPazienti; i++) {
                if (strcmp(citta[i], cittaRicerca) == 0) {
                    stampaPaziente(codici[i], cognomi[i], nomi[i],
                                   citta[i], reparti[i], letti[i]);
                    trovato = 1;
                }
            }
            if (!trovato) {
                printf("Nessun paziente trovato in questa citta'.\n");
            }
        } else if (scelta == 4) {
            int progressivi[MAX], codiciVisita[MAX], codice, trovato = 0;
            char date[MAX][11], tipi[MAX][LUNGHEZZA];
            char dottori[MAX][LUNGHEZZA];
            int numeroVisite;

            printf("Codice del paziente: ");
            scanf("%d", &codice);
            if (cercaCodice(codici, numeroPazienti, codice) == -1) {
                printf("Paziente non trovato.\n");
                continue;
            }

            numeroVisite = caricaVisite(progressivi, date, tipi,
                                       dottori, codiciVisita);
            for (int i = 0; i < numeroVisite; i++) {
                if (codiciVisita[i] == codice) {
                    printf("Visita n. %d | Data: %s | Tipo: %s | Dottore: %s\n",
                           progressivi[i], date[i], tipi[i], dottori[i]);
                    trovato = 1;
                }
            }
            if (!trovato) {
                printf("Nessuna visita trovata per questo paziente.\n");
            }
        } else if (scelta == 5) {
            int progressivi[MAX], codiciVisita[MAX], trovato = 0;
            char dataRicerca[11];
            char date[MAX][11], tipi[MAX][LUNGHEZZA];
            char dottori[MAX][LUNGHEZZA];
            int numeroVisite;

            do {
                printf("Data (gg/MM/aaaa): ");
                scanf("%10s", dataRicerca);
                if (!dataValida(dataRicerca)) {
                    printf("Data non valida.\n");
                }
            } while (!dataValida(dataRicerca));

            numeroVisite = caricaVisite(progressivi, date, tipi,
                                       dottori, codiciVisita);
            for (int i = 0; i < numeroVisite; i++) {
                if (strcmp(date[i], dataRicerca) == 0) {
                    int posizione = cercaCodice(codici, numeroPazienti,
                                                codiciVisita[i]);
                    if (posizione != -1) {
                        stampaPaziente(codici[posizione], cognomi[posizione],
                                       nomi[posizione], citta[posizione],
                                       reparti[posizione], letti[posizione]);
                        printf("Visita n. %d | Tipo: %s | Dottore: %s\n",
                               progressivi[i], tipi[i], dottori[i]);
                        trovato = 1;
                    }
                }
            }
            if (!trovato) {
                printf("Nessun paziente visitato in questa data.\n");
            }
        }
    } while (scelta != 6);
}

void inserimentoVisita(void) {
    int codiciPazienti[MAX], letti[MAX], progressivi[MAX];
    int codiciVisita[MAX], codicePaziente;
    char cognomi[MAX][LUNGHEZZA], nomi[MAX][LUNGHEZZA];
    char citta[MAX][LUNGHEZZA], reparti[MAX][LUNGHEZZA];
    char date[MAX][11], tipi[MAX][LUNGHEZZA], dottori[MAX][LUNGHEZZA];
    int numeroPazienti, numeroVisite;

    numeroPazienti = caricaPazienti(codiciPazienti, cognomi, nomi,
                                    citta, reparti, letti);
    if (numeroPazienti == 0) {
        printf("Non ci sono pazienti registrati.\n");
        return;
    }

    numeroVisite = caricaVisite(progressivi, date, tipi,
                               dottori, codiciVisita);
    if (numeroVisite == MAX) {
        printf("Archivio visite pieno.\n");
        return;
    }

    printf("Codice del paziente: ");
    scanf("%d", &codicePaziente);
    if (cercaCodice(codiciPazienti, numeroPazienti, codicePaziente) == -1) {
        printf("Paziente non trovato.\n");
        return;
    }

    do {
        printf("Data visita (gg/MM/aaaa): ");
        scanf("%10s", date[numeroVisite]);
        if (!dataValida(date[numeroVisite])) {
            printf("Data non valida.\n");
        }
    } while (!dataValida(date[numeroVisite]));

    printf("Tipo visita: ");
    scanf(" %99[^\n]", tipi[numeroVisite]);
    printf("Dottore: ");
    scanf(" %99[^\n]", dottori[numeroVisite]);

    progressivi[numeroVisite] = codiceSuccessivo(progressivi, numeroVisite);
    codiciVisita[numeroVisite] = codicePaziente;
    numeroVisite++;

    if (salvaVisite(progressivi, date, tipi, dottori,
                    codiciVisita, numeroVisite)) {
        printf("Visita inserita con numero %d.\n", progressivi[numeroVisite - 1]);
    }
}

int main(void) {
    int scelta;

    do {
        printf("\n--- Gestione pazienti e visite ---\n");
        printf("1) Inserimento paziente\n");
        printf("2) Ricerca paziente\n");
        printf("3) Inserimento visita\n");
        printf("0) Esci\n");
        printf("Scelta: ");
        scanf("%d", &scelta);

        if (scelta == 1) {
            inserimentoPaziente();
        } else if (scelta == 2) {
            ricercaPazienti();
        } else if (scelta == 3) {
            inserimentoVisita();
        }
    } while (scelta != 0);

    return 0;
}
    