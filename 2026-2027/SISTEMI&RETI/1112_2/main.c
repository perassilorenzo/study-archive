#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main()
{

    char *cogno;
    char *nome;
    
    printf("\nEsercizio 7: allocazione Dinamica per Memorizzare Cognome e Nome");

    cogno = (char *)malloc(9 * sizeof(char));
    strcpy(cogno,"Maggiore");

    nome = (char *)malloc(10 * sizeof(char));
    strcpy(nome,"Giampaolo");

    printf("\n\nCognome: \"%s\" ", cogno);
    printf("\nNome: \"%s\" ", nome);

    printf("\n\n");

    free(cogno);
    free(nome);

    return 0;
}
 
/*
    * APPUNTI SULLA STRINGA DINAMICA:
    *
    * cogno = (char *)malloc(9 * sizeof(char));
    * strcpy(cogno, "Maggiore");
    *
    * Il primo comando alloca memoria dinamicamente.
    *
    * - cogno è una variabile puntatore a char.
    * - char occupa sempre 1 byte.
    * - sizeof(char) vale 1.
    * - 9 * sizeof(char) richiede quindi 9 byte.
    * - malloc restituisce l'indirizzo della memoria allocata.
    * - (char *) converte il puntatore generico void * restituito da
    *   malloc nel tipo char *.
    *
    * Schema:
    * cogno -> indirizzo del primo carattere della memoria allocata
    *
    * strcpy(cogno, "Maggiore") copia la stringa nella memoria puntata
    * da cogno.
    *
    * La stringa "Maggiore" è composta da 8 caratteri:
    * M, a, g, g, i, o, r, e
    *
    * In C una stringa termina sempre con il carattere '\0'.
    * Servono quindi 9 byte:
    *
    * M  a  g  g  i  o  r  e  \0
    *
    * L'allocazione di 9 byte è quindi sufficiente:
    *
    * +---+---+---+---+---+---+---+---+---+
    * | M | a | g | g | i | o | r | e | \0|
    * +---+---+---+---+---+---+---+---+---+
    *
    * In sintesi:
    * cogno  -> indirizzo del primo carattere;
    * *cogno -> primo carattere 'M';
    * &cogno -> indirizzo della variabile puntatore cogno;
    * \0     -> carattere che indica la fine della stringa.
    *
    * Per stampare la stringa si usa:
    * printf("%s", cogno);
    *
    * Dopo free(cogno), una buona pratica è evitare che il puntatore
    * continui a indicare memoria rilasciata:
    *
    * free(cogno);
    * cogno = NULL;
    *
    * Lo stesso vale per nome:
    *
    * nome = (char *)malloc(10 * sizeof(char));
    * strcpy(nome, "Giampaolo");
    *
    * "Giampaolo" contiene 9 caratteri più il carattere finale '\0',
    * quindi richiede 10 byte. Anche qui l'allocazione è sufficiente.
    *
    * Prima di usare un puntatore allocato, sarebbe utile verificare
    * che malloc abbia avuto successo:
    *
    * if (cogno == NULL) {
    *     printf("Errore di allocazione della memoria");
    *     return 1;
    * }
    *
    * Alla fine dell'esercizio:
    * free(cogno) rilascia la memoria della stringa cogno;
    * free(nome) rilascia la memoria della stringa nome.
*/